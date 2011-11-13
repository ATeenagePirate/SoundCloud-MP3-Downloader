Public Class Download

    Private Sub OpenFolderBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFolderBtn.Click
        Process.Start("explorer.exe", My.Settings.folder)
    End Sub


    Private Sub OpenFileBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileBtn.Click
        Dim psi As New ProcessStartInfo()
        With psi
            .FileName = My.Settings.file
            .UseShellExecute = True
        End With
        Process.Start(psi)
    End Sub

End Class