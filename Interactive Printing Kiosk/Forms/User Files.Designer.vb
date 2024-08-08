<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User_Files
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.flp_user_files = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnl_loading_container = New System.Windows.Forms.Panel()
        Me.Guna2WinProgressIndicator1 = New Guna.UI2.WinForms.Guna2WinProgressIndicator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnl_loading_container.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(752, 35)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 35)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select  File"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(701, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(51, 35)
        Me.Guna2ControlBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Please select the file that you want to print."
        '
        'flp_user_files
        '
        Me.flp_user_files.AutoScroll = True
        Me.flp_user_files.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flp_user_files.Location = New System.Drawing.Point(6, 89)
        Me.flp_user_files.Name = "flp_user_files"
        Me.flp_user_files.Size = New System.Drawing.Size(740, 335)
        Me.flp_user_files.TabIndex = 2
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.Panel1
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(671, 439)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'pnl_loading_container
        '
        Me.pnl_loading_container.Controls.Add(Me.Label3)
        Me.pnl_loading_container.Controls.Add(Me.Guna2WinProgressIndicator1)
        Me.pnl_loading_container.Location = New System.Drawing.Point(328, 197)
        Me.pnl_loading_container.Name = "pnl_loading_container"
        Me.pnl_loading_container.Size = New System.Drawing.Size(96, 142)
        Me.pnl_loading_container.TabIndex = 4
        '
        'Guna2WinProgressIndicator1
        '
        Me.Guna2WinProgressIndicator1.AutoStart = True
        Me.Guna2WinProgressIndicator1.CircleSize = 1.0!
        Me.Guna2WinProgressIndicator1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2WinProgressIndicator1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2WinProgressIndicator1.Name = "Guna2WinProgressIndicator1"
        Me.Guna2WinProgressIndicator1.Size = New System.Drawing.Size(96, 96)
        Me.Guna2WinProgressIndicator1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(0, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 46)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "File is being load." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please wait" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'User_Files
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(752, 490)
        Me.Controls.Add(Me.pnl_loading_container)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.flp_user_files)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Roboto", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "User_Files"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User_Files"
        Me.Panel1.ResumeLayout(False)
        Me.pnl_loading_container.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents flp_user_files As FlowLayoutPanel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Button1 As Button
    Friend WithEvents pnl_loading_container As Panel
    Friend WithEvents Guna2WinProgressIndicator1 As Guna.UI2.WinForms.Guna2WinProgressIndicator
    Friend WithEvents Label3 As Label
End Class
