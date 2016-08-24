Public Class game5_1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Text = "假如你有神的能力之後你會選擇做哪一件事?"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked Then
            Module1.answer(1) = "統治世界，變成世界的王"
        ElseIf RadioButton2.Checked Then
            Module1.answer(1) = "淫姦婦女及孩童、搶賊、殺人和放火"
        ElseIf RadioButton3.Checked Then
            Module1.answer(1) = "什麼事都不做，繼續當普通人。"
        Else
            Module1.answer(1) = "拯救世界，將壞人都消滅"
        End If
        Me.Hide()
        Dim mForm As New game5_2
        mForm.ShowDialog()
        Me.Close()
    End Sub

End Class