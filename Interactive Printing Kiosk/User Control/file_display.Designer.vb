<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class file_display
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.frm_elipse = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pb_file_type = New System.Windows.Forms.PictureBox()
        Me.lbl_file_name = New System.Windows.Forms.Label()
        CType(Me.pb_file_type, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frm_elipse
        '
        Me.frm_elipse.TargetControl = Me
        '
        'pb_file_type
        '
        Me.pb_file_type.Location = New System.Drawing.Point(9, 9)
        Me.pb_file_type.Name = "pb_file_type"
        Me.pb_file_type.Size = New System.Drawing.Size(60, 60)
        Me.pb_file_type.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_file_type.TabIndex = 0
        Me.pb_file_type.TabStop = False
        '
        'lbl_file_name
        '
        Me.lbl_file_name.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_file_name.Location = New System.Drawing.Point(75, 9)
        Me.lbl_file_name.Name = "lbl_file_name"
        Me.lbl_file_name.Size = New System.Drawing.Size(164, 60)
        Me.lbl_file_name.TabIndex = 1
        Me.lbl_file_name.Text = "Sample file name"
        '
        'file_display
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.lbl_file_name)
        Me.Controls.Add(Me.pb_file_type)
        Me.DoubleBuffered = True
        Me.Name = "file_display"
        Me.Size = New System.Drawing.Size(250, 78)
        CType(Me.pb_file_type, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents frm_elipse As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents lbl_file_name As Label
    Friend WithEvents pb_file_type As PictureBox
End Class
