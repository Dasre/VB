Public Class game4after
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim mForm As New game5_1
        mForm.ShowDialog()
        Me.Close()
    End Sub
End Class