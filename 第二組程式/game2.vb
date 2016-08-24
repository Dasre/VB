Public Class game2
    Dim evil As Integer
    Dim time As Integer = 20
    Dim R

    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click
        sender.Visible = False
        evil += 1
        Label1.Text = "得分= " + evil.ToString


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time = time - 1
        Label2.Text = "倒數時間" & time
        If time <= 0 Then
            Timer1.Stop()
            appear.Stop()
            MsgBox("遊戲結束，你總共擊殺" & evil & "隻", MsgBoxStyle.OkOnly, )
            If evil > 30 Then
                MsgBox("恭喜獲得神的左手道具", MsgBoxStyle.OkOnly)
                Me.Hide()
                Dim mForm As New game3
                mForm.ShowDialog()
                Me.Close()
            Else
                MsgBox("請在挑戰一次")
                Me.Hide()
                Dim mForm As New game2
                mForm.ShowDialog()
                Me.Close()
            End If
            Me.Close()
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub



    Private Sub appear_Tick(sender As Object, e As EventArgs) Handles appear.Tick

        Dim randomshow As New Random
        R = randomshow.Next(2, 13)
        Select Case R
            Case 2
                Button2.Visible = True
            Case 3
                Button3.Visible = True
            Case 4
                Button4.Visible = True
            Case 5
                Button5.Visible = True
            Case 6
                Button6.Visible = True
            Case 7
                Button7.Visible = True
            Case 8
                Button8.Visible = True
            Case 9
                Button9.Visible = True
            Case 10
                Button10.Visible = True
            Case 11
                Button11.Visible = True
            Case 12
                Button12.Visible = True
            Case 13
                Button13.Visible = True

        End Select


    End Sub



    Private Sub alive_Tick(sender As Object, e As EventArgs) Handles alive.Tick
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        Button9.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Button13.Visible = False


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("請在20秒擊殺30隻小惡魔，失敗就必須要重來")
        Timer1.Start()
        appear.Start()
        alive.Start()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Hide()
        Dim mForm As New game3

        mForm.ShowDialog()
        Me.Close()
    End Sub
End Class



