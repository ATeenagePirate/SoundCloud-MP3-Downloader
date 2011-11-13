<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DownloadBtn = New System.Windows.Forms.Button()
        Me.ArtistTxt = New System.Windows.Forms.TextBox()
        Me.ArtistLbl = New System.Windows.Forms.Label()
        Me.TitleLbl = New System.Windows.Forms.Label()
        Me.TitleTxt = New System.Windows.Forms.TextBox()
        Me.DownloadSFD = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'DownloadBtn
        '
        Me.DownloadBtn.BackColor = System.Drawing.Color.Green
        Me.DownloadBtn.ForeColor = System.Drawing.Color.Yellow
        Me.DownloadBtn.Location = New System.Drawing.Point(18, 91)
        Me.DownloadBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DownloadBtn.Name = "DownloadBtn"
        Me.DownloadBtn.Size = New System.Drawing.Size(394, 42)
        Me.DownloadBtn.TabIndex = 0
        Me.DownloadBtn.Text = "Download"
        Me.DownloadBtn.UseVisualStyleBackColor = False
        '
        'ArtistTxt
        '
        Me.ArtistTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ArtistTxt.ForeColor = System.Drawing.Color.Yellow
        Me.ArtistTxt.Location = New System.Drawing.Point(70, 17)
        Me.ArtistTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ArtistTxt.Name = "ArtistTxt"
        Me.ArtistTxt.Size = New System.Drawing.Size(342, 27)
        Me.ArtistTxt.TabIndex = 1
        '
        'ArtistLbl
        '
        Me.ArtistLbl.AutoSize = True
        Me.ArtistLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArtistLbl.ForeColor = System.Drawing.Color.Red
        Me.ArtistLbl.Location = New System.Drawing.Point(12, 20)
        Me.ArtistLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ArtistLbl.Name = "ArtistLbl"
        Me.ArtistLbl.Size = New System.Drawing.Size(50, 20)
        Me.ArtistLbl.TabIndex = 2
        Me.ArtistLbl.Text = "Artist:"
        '
        'TitleLbl
        '
        Me.TitleLbl.AutoSize = True
        Me.TitleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLbl.ForeColor = System.Drawing.Color.Red
        Me.TitleLbl.Location = New System.Drawing.Point(12, 57)
        Me.TitleLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TitleLbl.Name = "TitleLbl"
        Me.TitleLbl.Size = New System.Drawing.Size(42, 20)
        Me.TitleLbl.TabIndex = 4
        Me.TitleLbl.Text = "Title:"
        '
        'TitleTxt
        '
        Me.TitleTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TitleTxt.ForeColor = System.Drawing.Color.Yellow
        Me.TitleTxt.Location = New System.Drawing.Point(62, 54)
        Me.TitleTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TitleTxt.Name = "TitleTxt"
        Me.TitleTxt.Size = New System.Drawing.Size(350, 27)
        Me.TitleTxt.TabIndex = 3
        '
        'DownloadSFD
        '
        Me.DownloadSFD.DefaultExt = "mp3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(424, 143)
        Me.Controls.Add(Me.TitleLbl)
        Me.Controls.Add(Me.TitleTxt)
        Me.Controls.Add(Me.ArtistLbl)
        Me.Controls.Add(Me.ArtistTxt)
        Me.Controls.Add(Me.DownloadBtn)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "SoundCloud Downloader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DownloadBtn As System.Windows.Forms.Button
    Friend WithEvents ArtistTxt As System.Windows.Forms.TextBox
    Friend WithEvents ArtistLbl As System.Windows.Forms.Label
    Friend WithEvents TitleLbl As System.Windows.Forms.Label
    Friend WithEvents TitleTxt As System.Windows.Forms.TextBox
    Friend WithEvents DownloadSFD As System.Windows.Forms.SaveFileDialog

End Class
