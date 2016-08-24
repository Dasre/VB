Public Class game3after

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim mForm As New game4

        mForm.ShowDialog()
    End Sub
End Class