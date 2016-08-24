Public Class game1

    Dim ans(3) As Integer '宣告正確答案變數



    Private Function RandomInt(ByVal lowerbound, ByVal upperbound) As Integer '亂數函式
        Randomize()
        Return Int((upperbound - lowerbound + 1) * Rnd() + lowerbound)
    End Function





    Private Sub Button_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Do Until (ans(0) <> ans(1)) And (ans(0) <> ans(2)) And (ans(0) <> ans(3)) And (ans(1) <> ans(2)) And (ans(1) <> ans(3)) And (ans(2) <> ans(3))
            ans(0) = RandomInt(0, 9)
            ans(1) = RandomInt(0, 9)
            ans(2) = RandomInt(0, 9)
            ans(3) = RandomInt(0, 9)
        Loop


        Button1.Enabled = True
        Button2.Enabled = True
        TextBox1.ReadOnly = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Length = 4 Then
            Dim d1 = Mid(TextBox1.Text, 1, 1)
            Dim d2 = Mid(TextBox1.Text, 2, 1)
            Dim d3 = Mid(TextBox1.Text, 3, 1)
            Dim d4 = Mid(TextBox1.Text, 4, 1)
            If (d1 <> d2) And (d1 <> d3) And (d1 <> d4) And (d2 <> d3) And (d2 <> d4) And (d3 <> d4) Then '輸入答案4位數字皆不同才執行
                Dim i As Integer = 0
                Dim j As Integer = 0
                Dim A As Integer = 0
                Dim B As Integer = 0
                For i = 0 To 3
                    If Mid(TextBox1.Text, i + 1, 1) = ans(i) Then
                        A = A + 1
                    Else
                        For j = 0 To 3
                            If Mid(TextBox1.Text, i + 1, 1) = ans(j) Then
                                B = B + 1
                            End If
                        Next
                    End If
                Next
                ListBox1.Items.Add(TextBox1.Text + "　" + A.ToString + "A" + B.ToString + "B")
                If A = 4 Then

                    MsgBox("輸入次數：" + ListBox1.Items.Count.ToString + "次" + Chr(10) + "☆恭喜完成☆" + vbNewLine + "恭喜獲得神的右手道具")
                    Me.Hide()
                    Dim mForm As New game1after
                    mForm.ShowDialog()
                    Me.Close()
                    Button1.Enabled = False
                End If
                If ListBox1.Items.Count > 7 Then
                    MsgBox("你已經失敗QQ 請再來一次")
                End If
                TextBox1.Clear()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        ListBox1.Items.Clear()

        Button1.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = False
        ans(0) = 0
        ans(1) = 0
        TextBox1.ReadOnly = True
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim mForm As New game2
        mForm.ShowDialog()
        Me.Close()

    End Sub

    Private Sub game1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class