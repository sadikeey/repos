Public Class Form1
    Dim xchange, ychange As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xchange = 200
        ychange = 200
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.WindowState = FormWindowState.Maximized
        PictureBox1.Left = PictureBox1.Left + xchange
        PictureBox1.Top = PictureBox1.Top + ychange
        If PictureBox1.Left + PictureBox1.Width > Width Then
            xchange = xchange * -1
            PictureBox1.BackColor = Color.Sienna
            PictureBox1.Width = 50
        End If
        If PictureBox1.Left < 0 Then
            xchange = xchange * -1
            PictureBox1.BackColor = Color.Violet
            PictureBox1.Width = 100
        End If
        If PictureBox1.Top + PictureBox1.Width > Width Then
            ychange = ychange * -1
            PictureBox1.BackColor = Color.Tomato
            PictureBox1.Width = 150
        End If
        If PictureBox1.Top < 0 Then
            ychange = ychange * -1
            PictureBox1.BackColor = Color.SeaGreen
            PictureBox1.Width = 200
        End If

    End Sub
End Class
