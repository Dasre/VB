Public Class game4
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim randGen As New Random
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intNum3 As Integer
        Dim intNum4 As Integer

        Dim inttotal As Integer
        intNum1 = randGen.Next(1, 6)
        intNum2 = randGen.Next(1, 6)
        intNum3 = randGen.Next(1, 6)
        intNum4 = randGen.Next(1, 6)

        Select Case intNum1
            Case 1
                PictureBox7.Image = PictureBox1.Image
            Case 2
                PictureBox7.Image = PictureBox2.Image
            Case 3
                PictureBox7.Image = PictureBox3.Image
            Case 4
                PictureBox7.Image = PictureBox4.Image
            Case 5
                PictureBox7.Image = PictureBox5.Image
            Case 6
                PictureBox7.Image = PictureBox6.Image
        End Select
         Select intNum2
            Case 1
                PictureBox8.Image = PictureBox1.Image
            Case 2
                PictureBox8.Image = PictureBox2.Image
            Case 3
                PictureBox8.Image = PictureBox3.Image
            Case 4
                PictureBox8.Image = PictureBox4.Image
            Case 5
                PictureBox8.Image = PictureBox5.Image
            Case 6
                PictureBox8.Image = PictureBox6.Image
        End Select
        Select Case intNum3
            Case 1
                PictureBox9.Image = PictureBox1.Image
            Case 2
                PictureBox9.Image = PictureBox2.Image
            Case 3
                PictureBox9.Image = PictureBox3.Image
            Case 4
                PictureBox9.Image = PictureBox4.Image
            Case 5
                PictureBox9.Image = PictureBox5.Image
            Case 6
                PictureBox9.Image = PictureBox6.Image
        End Select
Select intNum4
            Case 1
                PictureBox10.Image = PictureBox1.Image
            Case 2
                PictureBox10.Image = PictureBox2.Image
            Case 3
                PictureBox10.Image = PictureBox3.Image
            Case 4
                PictureBox10.Image = PictureBox4.Image
            Case 5
                PictureBox10.Image = PictureBox5.Image
            Case 6
                PictureBox10.Image = PictureBox5.Image
        End Select



        If (intNum1 = intNum2 And intNum3 = intNum4 And intNum2 = intNum4) Then
            Label1.Text = ("豹子")
        End If

        If (intNum1 = intNum2 And intNum2 = intNum3 And intNum1 = intNum3) Then
            Label1.Text = "無效"
            MsgBox("三個骰子一樣請重來一次")
        ElseIf (intNum1 = intNum2 And intNum2 = intNum4 And intNum1 = intNum4) Then
            Label1.Text = "無效"
            MsgBox("三個骰子一樣請重來一次")
        ElseIf (intNum2 = intNum3 And intNum2 = intNum4 And intNum2 = intNum4) Then
            Label1.Text = "無效"
            MsgBox("三個骰子一樣請重來一次")
        ElseIf (intNum1 = intNum3 And intNum3 = intNum4 And intNum1 = intNum4) Then
            Label1.Text = "無效"
            MsgBox("三個骰子一樣請重來一次")
        End If

        If (intNum1 = intNum2 And intNum1 <> intNum3) And (intNum1 = intNum2 And intNum2 <> intNum3) And (intNum1 = intNum2 And intNum1 <> intNum4) And (intNum1 = intNum2 And intNum2 <> intNum4) Then
            inttotal = intNum3 + intNum4
            Label1.Text = intNum3 + intNum4
        ElseIf (intNum2 = intNum4 And intNum2 <> intNum3) And (intNum2 = intNum4 And intNum2 <> intNum1) And (intNum2 = intNum4 And intNum1 <> intNum4) And (intNum2 = intNum4 And intNum3 <> intNum4) Then
            inttotal = intNum1 + intNum3
            Label1.Text = intNum1 + intNum3
        ElseIf (intNum2 = intNum3 And intNum1 <> intNum3) And (intNum2 = intNum3 And intNum2 <> intNum4) And (intNum2 = intNum3 And intNum1 <> intNum2) And (intNum2 = intNum3 And intNum3 <> intNum4) Then
            inttotal = intNum1 + intNum4
            Label1.Text = intNum1 + intNum4
        ElseIf (intNum1 = intNum3 And intNum1 <> intNum2) And (intNum1 = intNum3 And intNum2 <> intNum3) And (intNum1 = intNum3 And intNum3 <> intNum4) And (intNum1 = intNum3 And intNum1 <> intNum4) Then
            inttotal = intNum2 + intNum4
            Label1.Text = intNum2 + intNum4
        ElseIf (intNum1 = intNum4 And intNum1 <> intNum3) And (intNum1 = intNum4 And intNum3 <> intNum4) And (intNum1 = intNum4 And intNum1 <> intNum2) And (intNum1 = intNum4 And intNum2 <> intNum4) Then
            inttotal = intNum2 + intNum3
            Label1.Text = intNum2 + intNum3
        ElseIf (intNum3 = intNum4 And intNum1 <> intNum3) And (intNum3 = intNum4 And intNum2 <> intNum3) And (intNum3 = intNum4 And intNum1 <> intNum4) And (intNum3 = intNum4 And intNum2 <> intNum4) Then
            inttotal = intNum1 + intNum2
            Label1.Text = intNum1 + intNum2
        End If

        If (intNum1 <> intNum2 And intNum3 <> intNum4 And intNum2 <> intNum3 And intNum2 <> intNum4 And intNum1 <> intNum4 And intNum1 <> intNum3) Then
            Label1.Text = "零蛋"
            MsgBox("骰子都不一樣，請重來一次")



        End If
        If (intNum1 = intNum2 And intNum1 <> intNum3) And (intNum1 = intNum2 And intNum2 <> intNum3) And (intNum1 = intNum2 And intNum1 <> intNum4) And (intNum1 = intNum2 And intNum2 <> intNum4 And intNum3 = intNum4 And intNum1 > intNum3) Then
            inttotal = intNum1 * 2
            Label1.Text = intNum1 * 2
        ElseIf (intNum1 = intNum2 And intNum1 <> intNum3) And (intNum1 = intNum2 And intNum2 <> intNum3) And (intNum1 = intNum2 And intNum1 <> intNum4) And (intNum1 = intNum2 And intNum2 <> intNum4 And intNum3 = intNum4 And intNum1 < intNum3) Then
            inttotal = intNum3 * 2
            Label1.Text = intNum3 * 2

        ElseIf (intNum2 = intNum4 And intNum2 <> intNum3) And (intNum2 = intNum4 And intNum2 <> intNum1) And (intNum2 = intNum4 And intNum1 <> intNum4) And (intNum2 = intNum4 And intNum3 <> intNum4 And intNum1 = intNum3 And intNum2 > intNum3) Then
            inttotal = intNum2 * 2
            Label1.Text = intNum2 * 2
        ElseIf (intNum2 = intNum4 And intNum2 <> intNum3) And (intNum2 = intNum4 And intNum2 <> intNum1) And (intNum2 = intNum4 And intNum1 <> intNum4) And (intNum2 = intNum4 And intNum3 <> intNum4 And intNum1 = intNum3 And intNum2 < intNum3) Then
            inttotal = intNum3 * 2
            Label1.Text = intNum3 * 2

        ElseIf (intNum2 = intNum3 And intNum1 <> intNum3) And (intNum2 = intNum3 And intNum2 <> intNum4) And (intNum2 = intNum3 And intNum1 <> intNum2) And (intNum2 = intNum3 And intNum3 <> intNum4 And intNum1 = intNum4 And intNum2 > intNum4) Then
            inttotal = intNum2 * 2
            Label1.Text = intNum2 * 2
        ElseIf (intNum2 = intNum3 And intNum1 <> intNum3) And (intNum2 = intNum3 And intNum2 <> intNum4) And (intNum2 = intNum3 And intNum1 <> intNum2) And (intNum2 = intNum3 And intNum3 <> intNum4 And intNum1 = intNum4 And intNum2 < intNum4) Then
            inttotal = intNum4 * 2
            Label1.Text = intNum4 * 2

        ElseIf (intNum1 = intNum3 And intNum1 <> intNum2) And (intNum1 = intNum3 And intNum2 <> intNum3) And (intNum1 = intNum3 And intNum3 <> intNum4) And (intNum1 = intNum3 And intNum1 <> intNum4 And intNum2 And intNum4 And intNum1 > intNum2) Then
            inttotal = intNum1 * 2
            Label1.Text = intNum1 * 2
        ElseIf (intNum1 = intNum3 And intNum1 <> intNum2) And (intNum1 = intNum3 And intNum2 <> intNum3) And (intNum1 = intNum3 And intNum3 <> intNum4) And (intNum1 = intNum3 And intNum1 <> intNum4 And intNum2 And intNum4 And intNum1 < intNum2) Then
            inttotal = intNum2 * 2
            Label1.Text = intNum2 * 2


        ElseIf (intNum1 = intNum4 And intNum1 <> intNum3) And (intNum1 = intNum4 And intNum3 <> intNum4) And (intNum1 = intNum4 And intNum1 <> intNum2) And (intNum1 = intNum4 And intNum2 <> intNum4 And intNum2 = intNum3 And intNum1 > intNum2) Then
            inttotal = intNum1 * 2
            Label1.Text = intNum1 * 2
        ElseIf (intNum1 = intNum4 And intNum1 <> intNum3) And (intNum1 = intNum4 And intNum3 <> intNum4) And (intNum1 = intNum4 And intNum1 <> intNum2) And (intNum1 = intNum4 And intNum2 <> intNum4 And intNum2 = intNum3 And intNum1 > intNum2) Then
            inttotal = intNum2 * 2
            Label1.Text = intNum2 * 2

        ElseIf (intNum3 = intNum4 And intNum1 <> intNum3) And (intNum3 = intNum4 And intNum2 <> intNum3) And (intNum3 = intNum4 And intNum1 <> intNum4) And (intNum3 = intNum4 And intNum2 <> intNum4 And intNum1 = intNum2 And intNum1 < intNum3) Then
            inttotal = intNum3 * 2
            Label1.Text = intNum3 * 2
        ElseIf (intNum3 = intNum4 And intNum1 <> intNum3) And (intNum3 = intNum4 And intNum2 <> intNum3) And (intNum3 = intNum4 And intNum1 <> intNum4) And (intNum3 = intNum4 And intNum2 <> intNum4 And intNum1 = intNum2 And intNum1 < intNum3) Then
            inttotal = intNum1 * 2
            Label1.Text = intNum1 * 2
        End If











        Label1.Text = inttotal.ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim mForm As New game4after
        mForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub game4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim randGen As New Random
        Dim intNum5 As Integer
        Dim intNum6 As Integer
        Dim intNum7 As Integer
        Dim intNum8 As Integer

        Dim inttotal As Integer
        intNum5 = randGen.Next(1, 6)
        intNum6 = randGen.Next(1, 6)
        intNum7 = randGen.Next(1, 6)
        intNum8 = randGen.Next(1, 6)

        Select Case intNum5
            Case 1
                PictureBox11.Image = PictureBox1.Image
            Case 2
                PictureBox11.Image = PictureBox2.Image
            Case 3
                PictureBox11.Image = PictureBox3.Image
            Case 4
                PictureBox11.Image = PictureBox4.Image
            Case 5
                PictureBox11.Image = PictureBox5.Image
            Case 6
                PictureBox11.Image = PictureBox6.Image
        End Select

        Select Case intNum6
            Case 1
                PictureBox12.Image = PictureBox1.Image
            Case 2
                PictureBox12.Image = PictureBox2.Image
            Case 3
                PictureBox12.Image = PictureBox3.Image
            Case 4
                PictureBox12.Image = PictureBox4.Image
            Case 5
                PictureBox12.Image = PictureBox5.Image
            Case 6
                PictureBox12.Image = PictureBox6.Image
        End Select
        Select Case intNum7
            Case 1
                PictureBox13.Image = PictureBox1.Image
            Case 2
                PictureBox13.Image = PictureBox2.Image
            Case 3
                PictureBox13.Image = PictureBox3.Image
            Case 4
                PictureBox13.Image = PictureBox4.Image
            Case 5
                PictureBox13.Image = PictureBox5.Image
            Case 6
                PictureBox13.Image = PictureBox6.Image
        End Select
        Select Case intNum8
            Case 1
                PictureBox14.Image = PictureBox1.Image
            Case 2
                PictureBox14.Image = PictureBox2.Image
            Case 3
                PictureBox14.Image = PictureBox3.Image
            Case 4
                PictureBox14.Image = PictureBox4.Image
            Case 5
                PictureBox14.Image = PictureBox5.Image
            Case 6
                PictureBox14.Image = PictureBox5.Image
        End Select


        If (intNum5 = intNum6 = intNum7 = intNum8) Then
            Label2.Text = ("999")
        End If

        If (intNum5 = intNum6 And intNum5 = intNum7 And intNum6 = intNum7) Then
            Label1.Text = "無效"
            MsgBox("三個骰子一樣請重來一次")
        ElseIf (intNum5 = intNum6 And intNum6 = intNum8 And intNum5 = intNum8) Then
            Label1.Text = "無效"
            MsgBox("三個骰子一樣請重來一次")
        ElseIf (intNum6 = intNum7 And intNum6 = intNum8 And intNum7 = intNum8) Then
            Label1.Text = "無效"
            MsgBox("三個骰子一樣請重來一次")
        ElseIf (intNum5 = intNum7 And intNum7 = intNum8 And intNum5 = intNum8) Then
            Label1.Text = "無效"
            MsgBox("三個骰子一樣請重來一次")
        End If

        If (intNum5 = intNum6 And intNum5 <> intNum7) And (intNum5 = intNum6 And intNum6 <> intNum7) And (intNum5 = intNum6 And intNum5 <> intNum8) And (intNum5 = intNum6 And intNum6 <> intNum8) Then
            inttotal = intNum7 + intNum8
            Label2.Text = intNum7 + intNum8
        ElseIf (intNum6 = intNum8 And intNum6 <> intNum7) And (intNum6 = intNum8 And intNum6 <> intNum5) And (intNum6 = intNum8 And intNum5 <> intNum8) And (intNum6 = intNum8 And intNum7 <> intNum8) Then
            inttotal = intNum5 + intNum7
            Label2.Text = intNum5 + intNum7
        ElseIf (intNum6 = intNum7 And intNum5 <> intNum7) And (intNum6 = intNum7 And intNum6 <> 8) And (intNum6 = intNum7 And intNum5 <> intNum6) And (intNum6 = intNum7 And intNum7 <> intNum8) Then
            inttotal = intNum5 + intNum8
            Label2.Text = intNum5 + intNum8
        ElseIf (intNum5 = intNum7 And intNum5 <> intNum6) And (intNum5 = intNum7 And intNum6 <> intNum7) And (intNum5 = intNum7 And intNum7 <> intNum8) And (intNum5 = intNum7 And intNum5 <> intNum8) Then
            inttotal = intNum6 + intNum8
            Label2.Text = intNum6 + intNum8
        ElseIf (intNum5 = intNum8 And intNum5 <> intNum7) And (intNum5 = intNum8 And intNum7 <> intNum6) And (intNum5 = intNum8 And intNum5 <> intNum6) And (intNum5 = intNum8 And intNum6 <> intNum8) Then
            inttotal = intNum6 + intNum7
            Label2.Text = intNum6 + intNum7
        ElseIf (intNum7 = intNum8 And intNum5 <> intNum7) And (intNum7 = intNum8 And intNum6 <> intNum7) And (intNum7 = intNum8 And intNum5 <> intNum8) And (intNum7 = intNum8 And intNum6 <> intNum8) Then
            inttotal = intNum5 + intNum6
            Label2.Text = intNum5 + intNum6

        End If
        If (intNum5 = intNum6 And intNum5 <> intNum7) And (intNum5 = intNum6 And intNum6 <> intNum7) And (intNum5 = intNum6 And intNum5 <> intNum8) And (intNum5 = intNum6 And intNum6 <> intNum8 And intNum7 = intNum8 And intNum5 > intNum7) Then
            inttotal = intNum5 * 2
            Label1.Text = intNum5 * 2
        ElseIf (intNum5 = intNum6 And intNum5 <> intNum7) And (intNum5 = intNum6 And intNum6 <> intNum7) And (intNum5 = intNum6 And intNum5 <> intNum8) And (intNum5 = intNum6 And intNum6 <> intNum8 And intNum7 = intNum8 And intNum5 < intNum7) Then
            inttotal = intNum7 * 2
            Label1.Text = intNum7 * 2

        ElseIf (intNum6 = intNum8 And intNum6 <> intNum7) And (intNum6 = intNum8 And intNum6 <> intNum5) And (intNum6 = intNum8 And intNum5 <> intNum8) And (intNum6 = intNum8 And intNum7 <> intNum8 And intNum5 = intNum7 And intNum6 > intNum7) Then
            inttotal = intNum6 * 2
            Label1.Text = intNum6 * 2
        ElseIf (intNum6 = intNum8 And intNum6 <> intNum7) And (intNum6 = intNum8 And intNum6 <> intNum5) And (intNum6 = intNum8 And intNum5 <> intNum8) And (intNum6 = intNum8 And intNum7 <> intNum8 And intNum5 = intNum7 And intNum6 < intNum7) Then
            inttotal = intNum7 * 2
            Label1.Text = intNum7 * 2

        ElseIf (intNum6 = intNum7 And intNum5 <> intNum7) And (intNum6 = intNum7 And intNum6 <> intNum8) And (intNum6 = intNum7 And intNum5 <> intNum6) And (intNum6 = intNum7 And intNum7 <> intNum8 And intNum5 = intNum8 And intNum6 > intNum8) Then
            inttotal = intNum6 * 2
            Label1.Text = intNum6 * 2
        ElseIf (intNum6 = intNum7 And intNum5 <> intNum7) And (intNum6 = intNum7 And intNum6 <> intNum8) And (intNum6 = intNum7 And intNum5 <> intNum6) And (intNum6 = intNum7 And intNum7 <> intNum8 And intNum5 = intNum8 And intNum6 < intNum8) Then
            inttotal = intNum8 * 2
            Label1.Text = intNum8 * 2

        ElseIf (intNum5 = intNum7 And intNum5 <> intNum6) And (intNum5 = intNum7 And intNum6 <> intNum7) And (intNum5 = intNum7 And intNum7 <> intNum8) And (intNum5 = intNum7 And intNum5 <> intNum8 And intNum6 And intNum8 And intNum5 > intNum6) Then
            inttotal = intNum5 * 2
            Label1.Text = intNum5 * 2
        ElseIf (intNum5 = intNum7 And intNum5 <> intNum6) And (intNum5 = intNum7 And intNum6 <> intNum7) And (intNum5 = intNum7 And intNum7 <> intNum8) And (intNum5 = intNum7 And intNum5 <> intNum8 And intNum6 And intNum8 And intNum5 < intNum6) Then
            inttotal = intNum6 * 2
            Label1.Text = intNum6 * 2


        ElseIf (intNum5 = intNum8 And intNum5 <> intNum7) And (intNum5 = intNum8 And intNum7 <> intNum8) And (intNum5 = intNum8 And intNum5 <> intNum6) And (intNum5 = intNum8 And intNum6 <> intNum8 And intNum6 = intNum7 And intNum5 > intNum6) Then
            inttotal = intNum5 * 2
            Label1.Text = intNum5 * 2
        ElseIf (intNum5 = intNum8 And intNum5 <> intNum7) And (intNum5 = intNum8 And intNum7 <> intNum8) And (intNum5 = intNum8 And intNum5 <> intNum6) And (intNum5 = intNum8 And intNum6 <> intNum8 And intNum6 = intNum7 And intNum5 > intNum6) Then
            inttotal = intNum6 * 2
            Label1.Text = intNum6 * 2

        ElseIf (intNum7 = intNum8 And intNum5 <> intNum7) And (intNum7 = intNum8 And intNum6 <> intNum7) And (intNum7 = intNum8 And intNum5 <> intNum8) And (intNum7 = intNum8 And intNum6 <> intNum8 And intNum5 = intNum6 And intNum5 < intNum7) Then
            inttotal = intNum7 * 2
            Label1.Text = intNum7 * 2
        ElseIf (intNum7 = intNum8 And intNum5 <> intNum7) And (intNum7 = intNum8 And intNum6 <> intNum7) And (intNum7 = intNum8 And intNum5 <> intNum8) And (intNum7 = intNum8 And intNum6 <> intNum8 And intNum5 = intNum6 And intNum5 < intNum7) Then
            inttotal = intNum5 * 2
            Label1.Text = intNum5 * 2
        End If
        If (intNum5 <> intNum6 And intNum7 <> intNum8 And intNum6 <> intNum7 And intNum6 <> intNum8 And intNum5 <> intNum8 And intNum5 <> intNum7) Then
            Label2.Text = "0"
            MsgBox("骰子都不一樣，請重來一次")



        End If

        If Label2.Text <> "" Then

            If CInt(Label1.Text) = CInt(Label2.Text) Then
                MsgBox("平手請再來一次")
                Me.Hide()
                Dim mForm As New game4
                mForm.ShowDialog()
                Me.Close()
            ElseIf CInt(Label1.Text) < CInt(Label2.Text) Then
                MsgBox("失敗請再來一次")
                Me.Hide()
                Dim mForm As New game4
                mForm.ShowDialog()
                Me.Close()
            ElseIf CInt(Label1.Text) > CInt(Label2.Text) And (CInt(Label2.Text) <> 0) Then
                MsgBox("恭喜成功，獲得神的右腳道具")
                Me.Hide()
                Dim mForm As New game4after

                mForm.ShowDialog()
                Me.Close()

            End If
        End If




        Label2.Text = inttotal.ToString
    End Sub



    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub
End Class