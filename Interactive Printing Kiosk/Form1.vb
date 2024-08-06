Imports System.ComponentModel
Imports System.IO
Imports System.Management

Public Class Form1
    Private watcher As ManagementEventWatcher

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListViewFiles.View = View.Details
        ListViewFiles.Columns.Add("File Name", -2, HorizontalAlignment.Left)
        InitializeWatcher()
    End Sub

    Private Sub InitializeWatcher()
        Try
            Dim query As New WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent WHERE EventType = 2")
            watcher = New ManagementEventWatcher(query)

            AddHandler watcher.EventArrived, AddressOf OnVolumeChangeEvent

            watcher.Start()
        Catch ex As Exception
            MsgBox("Intialize  Watcher: ", ex.ToString)
        End Try
    End Sub

    Private Sub OnVolumeChangeEvent(sender As Object, e As EventArrivedEventArgs)
        Try
            Dim getDriveLetter As String = e.NewEvent.Properties("DriveName").Value.ToString


            If IsFlashDrive(getDriveLetter) Then
                PopulateFiles(getDriveLetter)
            End If

        Catch ex As Exception
            MsgBox("On Volume Change Event: ", ex.ToString)
        End Try
    End Sub


    Public Function IsFlashDrive(driveLetter As String) As Boolean
        Try
            Dim driveInfo As New DriveInfo(driveLetter)

            Return driveInfo.DriveType = DriveType.Removable
        Catch ex As Exception
            MsgBox("Is Flash drive: ", ex.ToString)
        End Try
    End Function

    Public Sub PopulateFiles(filePath As String)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of String)(AddressOf PopulateFiles), filePath)
            Return
        End If
        Try
            ListViewFiles.Items.Clear()
            TraverseDirectories(filePath)
        Catch ex As Exception
            ' Handle any exceptions that might occur
            MessageBox.Show("Error populating files: " & ex.Message)
        End Try
    End Sub

    Private Sub TraverseDirectories(fileDirectory As String)
        Try
            Dim files As String() = Directory.GetFiles(fileDirectory)

            For Each file As String In files
                Dim fileName As String = Path.GetFileName(file)
                ListViewFiles.Items.Add(New ListViewItem(file))
            Next


            Dim subDirectories As String() = Directory.GetDirectories(fileDirectory)
            For Each subFiles As String In subDirectories
                TraverseDirectories(subFiles)
            Next
        Catch ex As Exception
            MsgBox("Error traversing directories: ", ex.ToString)
        End Try
    End Sub

    Public Function IsvalidFile(filepath As String) As Boolean
        Dim validExtensions As String() = {".docx", ".pdf", "pptx"}
        Dim fileExtension As String = Path.GetExtension(filepath).ToLower()
        Return validExtensions.Contains(fileExtension)
    End Function


    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        watcher.Stop()
        watcher.Dispose()
    End Sub
End Class
