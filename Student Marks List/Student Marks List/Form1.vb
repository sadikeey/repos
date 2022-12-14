Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim eng, maths, phy, chem, percentage As Double
        Dim grade As String
        eng = Val(TextBox1.Text) + Val(TextBox2.Text)
        maths = Val(TextBox3.Text) + Val(TextBox4.Text)
        phy = Val(TextBox5.Text) + Val(TextBox6.Text)
        chem = Val(TextBox7.Text) + Val(TextBox8.Text)

        TextBox9.Text = eng
        TextBox10.Text = maths
        TextBox11.Text = phy
        TextBox12.Text = chem

        percentage = (eng + maths + phy + chem) / 400 * 100
        TextBox13.Text = percentage

        If percentage > 90 Then
            grade = "A"
        ElseIf percentage > 80 And percentage < 90 Then
            grade = "B"
        ElseIf percentage > 70 And percentage < 80 Then
            grade = "C"
        ElseIf percentage > 60 And percentage < 50 Then
            grade = "D"
        ElseIf percentage > 50 And percentage < 60 Then
            grade = "E"
        Else
            grade = "F"
        End If

        TextBox14.Text = grade

        If grade = "F" Then
            Button1.Text = "Fail"
        Else
            Button1.Text = "Pass"
        End If
    End Sub
End Class
