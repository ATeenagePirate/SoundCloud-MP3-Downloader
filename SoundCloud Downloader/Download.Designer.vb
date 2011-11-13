<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Download
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.OpenFolderBtn = New System.Windows.Forms.Button()
        Me.OpenFileBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Progress
        '
        Me.Progress.Location = New System.Drawing.Point(13, 12)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(260, 34)
        Me.Progress.TabIndex = 0
        '
        'OpenFolderBtn
        '
        Me.OpenFolderBtn.BackColor = System.Drawing.Color.Green
        Me.OpenFolderBtn.ForeColor = System.Drawing.Color.Yellow
        Me.OpenFolderBtn.Location = New System.Drawing.Point(13, 54)
        Me.OpenFolderBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpenFolderBtn.Name = "OpenFolderBtn"
        Me.OpenFolderBtn.Size = New System.Drawing.Size(103, 42)
        Me.OpenFolderBtn.TabIndex = 1
        Me.OpenFolderBtn.Text = "Open Folder"
        Me.OpenFolderBtn.UseVisualStyleBackColor = False
        '
        'OpenFileBtn
        '
        Me.OpenFileBtn.BackColor = System.Drawing.Color.Green
        Me.OpenFileBtn.Enabled = False
        Me.OpenFileBtn.ForeColor = System.Drawing.Color.Yellow
        Me.OpenFileBtn.Location = New System.Drawing.Point(170, 54)
        Me.OpenFileBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OpenFileBtn.Name = "OpenFileBtn"
        Me.OpenFileBtn.Size = New System.Drawing.Size(103, 42)
        Me.OpenFileBtn.TabIndex = 2
        Me.OpenFileBtn.Text = "Open File"
        Me.OpenFileBtn.UseVisualStyleBackColor = False
        '
        'Download
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 106)
        Me.Controls.Add(Me.OpenFileBtn)
        Me.Controls.Add(Me.OpenFolderBtn)
        Me.Controls.Add(Me.Progress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Download"
        Me.Text = "Download"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Progress As System.Windows.Forms.ProgressBar
    Friend WithEvents OpenFolderBtn As System.Windows.Forms.Button
    Friend WithEvents OpenFileBtn As System.Windows.Forms.Button
End Class
