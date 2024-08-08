Imports System.IO
Imports System.Management
Imports System.Threading

Public Class User_Files

    Private volumeRemovalWatcher As ManagementEventWatcher

    Private Sub User_Files_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim flashDriveLetter As String = GetFlashDriveLetter()
        If String.IsNullOrEmpty(flashDriveLetter) Then
            MsgBox("No Flash drive is detected")
            Me.Close()
            Return
        End If

        pnl_loading_container.Visible = True

        Dim loadingThread As New Thread(AddressOf LoadFiles)
        loadingThread.IsBackground = True
        loadingThread.Start()


        DetectRemoval()
    End Sub


    Private Sub DetectRemoval()
        Try
            Dim query As New WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 3")

            volumeRemovalWatcher = New ManagementEventWatcher(query)

            AddHandler volumeRemovalWatcher.EventArrived, AddressOf OnVolumeRemoveEvent

            volumeRemovalWatcher.Start()
        Catch ex As Exception
            MsgBox("Something when wrong with removal watcher : \n" & ex.Message)
        End Try
    End Sub

    Private Sub OnVolumeRemoveEvent(sender As Object, e As EventArrivedEventArgs)
        Try
            Dim getDriveLetter As String = e.NewEvent.Properties("DriveName").Value.ToString()

            ' Ensure thread safety when accessing UI elements
            If Me.InvokeRequired Then
                Me.Invoke(New Action(Sub()
                                         HandleDriveRemoval(getDriveLetter)
                                     End Sub))
            Else
                HandleDriveRemoval(getDriveLetter)
            End If
        Catch ex As Exception
            MessageBox.Show("Removal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HandleDriveRemoval(driveLetter As String)
        If Me IsNot Nothing Then
            ' Optional: you can check if the drive letter matches the one used in User_Files if needed
            Me.Close()
            Me.Dispose()
        End If

        MessageBox.Show("Drive " & driveLetter & " has been removed.", "Drive Removed", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Sub LoadFiles()

#Region "Old Implementation"
        'flp_user_files.Controls.Clear()

        'Try
        '    Dim files = Directory.GetFiles(driveLetter, "*.*", SearchOption.AllDirectories) _
        '        .Where(Function(f) f.EndsWith(".docx") OrElse f.EndsWith(".pdf") OrElse f.EndsWith(".pptx")).ToList()
        '    For Each file In files
        '        Dim fileControl As New file_display
        '        With fileControl
        '            fileControl.SetFile(file)
        '            flp_user_files.Controls.Add(fileControl)
        '            .Size = New Size(flp_user_files.Width / 3 - 14, 78)
        '        End With
        '    Next
        'Catch ex As Exception
        '    MsgBox("Error occur while loading the files" & ex.Message)
        'End Try
#End Region

        If Not IsDriveReady() Then
            pnl_loading_container.Visible = False
            Return
        End If

        Try
            Dim driveLetter As String = GetFlashDriveLetter()
            Dim files = Directory.GetFiles(driveLetter, "*.*", SearchOption.AllDirectories) _
                .Where(Function(f) f.EndsWith(".docx") OrElse f.EndsWith(".pdf") OrElse f.EndsWith(".pptx")).ToList()

            Me.Invoke(New Action(Sub()
                                     flp_user_files.Controls.Clear()
                                     For Each file In files
                                         Dim fileControl As New file_display()
                                         fileControl.SetFile(file)
                                         flp_user_files.Controls.Add(fileControl)
                                         fileControl.Size = New Size(flp_user_files.Width / 3 - 14, 78)
                                     Next

                                     pnl_loading_container.Visible = False
                                 End Sub))

        Catch ex As IOException
            MessageBox.Show("Error occurred while loading the files: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Me.Invoke(New Action(Sub()
            '                         pnl_loading_container.Visible = False
            '                     End Sub))
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error occurred while loading the files: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Me.Invoke(New Action(Sub()
            '                         pnl_loading_container.Visible = False
            '                     End Sub))
            Me.Dispose()
        End Try
    End Sub

    ' Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    If ListBoxFiles.SelectedItem IsNot Nothing Then
    '        Dim selectedFile As String = ListBoxFiles.SelectedItem.ToString()
    '        MessageBox.Show("Selected file: " & selectedFile)
    '    Else
    '        MessageBox.Show("Please select a file.")
    '    End If
    'End Sub

    Private Function IsDriveReady() As Boolean
        Dim isReady As Boolean = False
        Dim driveLetter As String = GetFlashDriveLetter()
        Dim driveInfo As New DriveInfo(driveLetter)

        If driveInfo.IsReady Then
            isReady = True
        End If

        Return isReady
    End Function

    Private Function GetFlashDriveLetter() As String
        For Each drive As DriveInfo In DriveInfo.GetDrives()
            If drive.DriveType = DriveType.Removable Then
                Return drive.Name
            End If
        Next
        Return String.Empty
    End Function

    Private Sub User_Files_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If volumeRemovalWatcher IsNot Nothing Then
            volumeRemovalWatcher.Stop()
            volumeRemovalWatcher.Dispose()
        End If
    End Sub
End Class