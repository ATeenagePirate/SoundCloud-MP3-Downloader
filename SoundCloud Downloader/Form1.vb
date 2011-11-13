Imports System.Net
Imports System.IO
Imports System.Diagnostics

Class Form1
    Function GetPage(ByVal pageUrl As String) As String
        Dim s As String = ""
        Try
            Dim request As HttpWebRequest = WebRequest.Create(pageUrl)
            Dim response As HttpWebResponse = request.GetResponse()
            Using reader As StreamReader = New StreamReader(response.GetResponseStream())
                s = reader.ReadToEnd()
            End Using
        Catch ex As Exception
            MsgBox("FAIL: " + ex.Message)
        End Try
        Return s
    End Function


    Private Sub DownloadBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadBtn.Click

        Try

            If ArtistTxt.Text <> "" And TitleTxt.Text <> "" Then

                ArtistTxt.Text = StrConv(ArtistTxt.Text, VbStrConv.ProperCase)
                TitleTxt.Text = StrConv(TitleTxt.Text, VbStrConv.ProperCase)

                Dim page As String = GetPage("http://soundcloud.com/tracks/search?q=%22" & ArtistTxt.Text.Replace(" ", "+") & "+-+" & TitleTxt.Text.Replace(" ", "+") & "%22")
                If page <> "" Then

                    Dim URL As String = page.Substring(page.IndexOf("streamUrl") + 12, 66)

                    If URL <> "" Then

                        DownloadSFD.Title = "Where do we save this MP3 to?"
                        DownloadSFD.FileName = ArtistTxt.Text & " - " & TitleTxt.Text

                        If DownloadSFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
                            My.Settings.folder = Path.GetDirectoryName(DownloadSFD.FileName)
                            My.Settings.file = DownloadSFD.FileName
                            Dim myWebClient As New System.Net.WebClient()
                            AddHandler myWebClient.DownloadProgressChanged, AddressOf client_ProgressChanged
                            AddHandler myWebClient.DownloadFileCompleted, AddressOf client_DownloadCompleted
                            myWebClient.DownloadFileAsync(New Uri(URL), DownloadSFD.FileName)
                            Download.Text = ArtistTxt.Text & " - " & TitleTxt.Text & " download"
                            Download.ShowDialog()

                        End If

                    Else

                        MsgBox("No song found. Please try again.")

                    End If

                End If

            Else

                MsgBox("Please enter both the artist and the title. Thank you.", MsgBoxStyle.Critical, "Error")

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)

        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        Download.OpenFileBtn.Enabled = False
        Download.Progress.Value = Int32.Parse(Math.Truncate(percentage).ToString())

    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        ArtistTxt.Text = ""
        TitleTxt.Text = ""

        Download.OpenFileBtn.Enabled = True

    End Sub

End Class
