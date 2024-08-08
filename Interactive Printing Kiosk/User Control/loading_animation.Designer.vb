<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loading_animation
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
        Me.Guna2WinProgressIndicator1 = New Guna.UI2.WinForms.Guna2WinProgressIndicator()
        Me.SuspendLayout()
        '
        'Guna2WinProgressIndicator1
        '
        Me.Guna2WinProgressIndicator1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2WinProgressIndicator1.CircleSize = 1.0!
        Me.Guna2WinProgressIndicator1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2WinProgressIndicator1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2WinProgressIndicator1.Name = "Guna2WinProgressIndicator1"
        Me.Guna2WinProgressIndicator1.Size = New System.Drawing.Size(96, 96)
        Me.Guna2WinProgressIndicator1.TabIndex = 0
        '
        'loading_animation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2WinProgressIndicator1)
        Me.Name = "loading_animation"
        Me.Size = New System.Drawing.Size(96, 96)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2WinProgressIndicator1 As Guna.UI2.WinForms.Guna2WinProgressIndicator
End Class
