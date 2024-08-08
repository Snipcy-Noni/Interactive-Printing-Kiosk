Imports System.IO

Public Class file_display
    Public Sub SetFile(filePath As String)
        lbl_file_name.Text = Path.GetFileName(filePath)
        pb_file_type.Image = GetFileIcon(filePath)
    End Sub

    Private Function GetFileIcon(filePath As String) As Image
        Select Case Path.GetExtension(filePath).ToLower()
            Case ".docx"
                Return My.Resources.icon_doc
            Case ".pdf"
                Return My.Resources.icon_pdf
            Case ".pptx"
                Return My.Resources.icon_ppt
            Case Else
                Return My.Resources.icon_folder
        End Select
    End Function
End Class
