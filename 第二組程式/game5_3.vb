Public Class game5_3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            Module1.answer(3) = "帥氣"
        ElseIf RadioButton2.Checked Then
            Module1.answer(3) = "意志力強大"
        ElseIf RadioButton3.Checked Then
            Module1.answer(3) = "細心"
        Else
            Module1.answer(3) = "以上都沒有"
        End If
        Me.Hide()
        Dim mForm As New Final
        mForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Text = "下列哪項特點不是哲安有的?"

    End Sub

    Private Sub game5_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class