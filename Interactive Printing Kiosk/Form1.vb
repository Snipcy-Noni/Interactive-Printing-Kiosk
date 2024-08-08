Imports System.IO
Imports System.Management

Public Class Form1
    Private volumeChangeWatcher As ManagementEventWatcher
    Private volumeRemovalWatcher As ManagementEventWatcher

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitializeWatcher()
        'DetectRemoval()
    End Sub

    Private Sub InitializeWatcher()
        Try
            Dim query As New WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2")

            volumeChangeWatcher = New ManagementEventWatcher(query)

            AddHandler volumeChangeWatcher.EventArrived, AddressOf OnVolumeChangeEvent

            volumeChangeWatcher.Start()
        Catch ex As Exception
            MsgBox("Something when wrong with arrive watcher : \n" & ex.Message)
        End Try
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

    Private Sub OnVolumeChangeEvent(sender As Object, e As EventArrivedEventArgs)
        Try
            Dim getDriveLetter As String = e.NewEvent.Properties("DriveName").Value.ToString


            If IsFlashDrive(getDriveLetter) Then
                Using dialog As New User_Files()
                    dialog.ShowDialog()
                End Using

            End If
        Catch ex As Exception
            MsgBox("Something when wrong with volume change event : \n" & ex.Message)
        End Try
    End Sub

    Private Sub OnVolumeRemoveEvent(sender As Object, e As EventArrivedEventArgs)
        Try
            Dim getDriveLetter As String = e.NewEvent.Properties("DriveName").Value.ToString()

            ' Ensure thread safety when accessing UI elements
            If Me.InvokeRequired Then
                Me.Invoke(New Action(Sub()
                                         MessageBox.Show("Drive " & getDriveLetter & " has been removed.", "Drive Removed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                     End Sub))
            Else
                MessageBox.Show("Drive " & getDriveLetter & " has been removed.", "Drive Removed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Removal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'Check if user insert a removable drive
    Public Function IsFlashDrive(driveLetter As String) As Boolean
        Try
            Dim driveInfo As New DriveInfo(driveLetter)
            Return driveInfo.DriveType = DriveType.Removable
        Catch ex As Exception
            MsgBox("Something when wrong with flash drive check: \n" & ex.Message)
        End Try
    End Function

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If volumeChangeWatcher IsNot Nothing Then
            volumeChangeWatcher.Stop()
            volumeChangeWatcher.Dispose()
        End If
        If volumeRemovalWatcher IsNot Nothing Then
            volumeRemovalWatcher.Stop()
            volumeRemovalWatcher.Dispose()
        End If
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Using dialog As New User_Files()
    '        dialog.ShowDialog()
    '    End Using
    'End Sub
End Class