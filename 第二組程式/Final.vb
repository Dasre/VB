Public Class Final
    Private Sub Final_Load(sender As Object, e As EventArgs) Handles Me.Load



        If Module1.answer(1) = "統治世界，變成世界的王" And Module1.answer(2) = "全都拯救，但會失去一條腿" And Module1.answer(3) = "帥氣" Then
            MsgBox("恭喜你成為新世界的神了")
        Else
            MsgBox("你並不符合神的資格")
            Me.Hide()
            Dim mForm As New Final2
            mForm.ShowDialog()
            Me.Close()
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class