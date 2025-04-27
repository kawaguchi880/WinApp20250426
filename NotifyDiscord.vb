Imports System.Net
Imports System.Text


Public Module DiscordHelper
    Private webhookUrl = GetConnectionString("DiscordNotify")
    Public Sub SendMessage(message As String)
        Dim client As New WebClient()
        client.Headers("Content-Type") = "application/json"
        client.Encoding = Encoding.UTF8
        Dim jsonpayload As String = "{""content"":""" & message & """}"
        Try
            Debug.WriteLine("送信するペイロード: " & jsonpayload)
            client.UploadString(webhookUrl, "POST", jsonpayload)
            Debug.WriteLine("メッセージをDiscordに送信しました: " & message)
        Catch ex As Exception
            MessageBox.Show("Discordへの通知に失敗しました: " & ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
