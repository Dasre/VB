Public Class Form1
    Public flag As Boolean = True
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim mForm As New Form2
        mForm.ShowDialog()
        Me.Close()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        My.Computer.Audio.Stop()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim mForm As New Form3
        mForm.ShowDialog()


    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If flag Then
            My.Computer.Audio.Play(My.Resources.opening_mp3_mp3,
         AudioPlayMode.BackgroundLoop)
            flag = Not flag
            PictureBox1.Image = My.Resources.image11
        Else
            flag = Not flag
            PictureBox1.Image = My.Resources.image21
            My.Computer.Audio.Stop()
        End If
    End Sub
End Class


