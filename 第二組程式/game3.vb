Public Class game3

    Public Shared L(10) As Integer, H(10) As Integer
    Public Shared j As Integer = 0
    Public Shared Ans As Integer





  

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim mFrom As New game3
        mFrom.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




        Dim myans(10) As Integer
        Dim i As Integer = 0


        L(0) = 1
        H(0) = 100
        myans(i) = Val(TextBox1.Text)


        If myans(i) >= 1 And myans(i) <= 100 Then

            If myans(i) = Ans Then
                PictureBox2.Visible = True
                For a = 0 To 140 Step 20
                    PictureBox2.Location = New Point(a, 140)
                    Me.Refresh()
                    System.Threading.Thread.Sleep(50)
                Next a
                PictureBox2.Hide()
                MsgBox("恭喜你, 第" & j & "次猜中了！" + vbNewLine + "恭喜獲得神的左腳道具")
                Me.Hide()
                Dim mFrom As New game3after
                mFrom.ShowDialog()
                Me.Close()
            ElseIf myans(i) < L(j - 1) Then
                Label1.Text = "輸入錯誤,請重玩"

            ElseIf myans(i) > H(j - 1) Then
                Label1.Text = "輸入錯誤,請重玩"

            ElseIf myans(i) > Ans Then
                H(j) = myans(i)
                L(j) = L(j - 1)
                Label1.Text = "範圍為" & L(j) & "到" & H(j)
            ElseIf myans(i) < Ans Then
                L(j) = myans(i)
                H(j) = H(j - 1)
                Label1.Text = "範圍為" & L(j) & "到" & H(j)

            End If
            i = i + 1
            j = j + 1
            If j > 5 Then
                Label1.Text = "你已經失敗請重來"
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim mForm As New game3after

        mForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub game3_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        j = 0
        j = j + 1
        Randomize()
        Ans = Int(Rnd() * 100) + 1

    End Sub
End Class