Public Class game5_2
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Text = "當你走在路上時，突然看到有三個人溺水你要救哪一個"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked Then
            Module1.answer(2) = "阿明"
        ElseIf RadioButton2.Checked Then
            Module1.answer(2) = "老婆婆"
        ElseIf RadioButton3.Checked Then
            Module1.answer(2) = "幼稚園小孩"
        Else
            Module1.answer(2) = "全都拯救，但會失去一條腿"
        End If
        Me.Hide()
        Dim mForm As New game5_3
        mForm.ShowDialog()
        Me.Close()
    End Sub
End Class