Public Class Form1

    Private counter As Integer = 0

    ' フォームロード時の初期設定
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCounter.Text = "カウント: " & counter.ToString() ' 初期値をラベルに表示
    End Sub

    Private Sub btnCounter_Click(sender As Object, e As EventArgs) Handles btnIncrement.Click, btnReset.Click, btnDecrease.Click
        Dim clickedBtn As Button = CType(sender, Button)
        If clickedBtn.Name = "btnIncrement" Then
            IncrementCounter()
        ElseIf clickedBtn.Name = "btnDecrease" Then
            btnDecrease_Click()
        ElseIf clickedBtn.Name = "btnReset" Then
            resetCounter()
        End If
        lblCounter.Text = "カウント: " & counter.ToString()
        CheckCounter20()
    End Sub

    Private Sub IncrementCounter()
        counter += 1
    End Sub

    Private Sub resetCounter()
        counter = 0
    End Sub

    Private Sub btnDecrease_Click()
        If counter <= 0 Then
            ShowToastNotification("カウントはこれ以上減らせません。")
        Else
            counter -= 1
        End If
    End Sub

    Private Sub ShowToastNotification(message As String)
        Dim toast As New Form()
        toast.FormBorderStyle = FormBorderStyle.None
        toast.StartPosition = FormStartPosition.CenterScreen
        toast.Size = New Size(300, 100)
        toast.BackColor = Color.LightYellow

        Dim lblMessage As New Label()
        lblMessage.Text = message
        lblMessage.Dock = DockStyle.Fill
        lblMessage.TextAlign = ContentAlignment.MiddleCenter
        lblMessage.Font = New Font("Arial", 12, FontStyle.Bold)
        toast.Controls.Add(lblMessage)

        Dim timer As New Timer()
        AddHandler timer.Tick, Sub(sender, e)
                                   toast.Close()
                                   timer.Stop()
                               End Sub
        timer.Interval = 2000 ' 2秒後に閉じる
        timer.Start()

        toast.ShowDialog()
    End Sub

    Private Sub CheckCounter20()
        If counter = 20 Then
            DiscordHelper.SendMessage("カウントが20になりました！")
        End If
    End Sub
End Class
