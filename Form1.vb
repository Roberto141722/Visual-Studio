Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim a, b, r As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        r = (a + b)
        TextBox3.Text = r
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        r = (a - b)
        TextBox3.Text = r
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        r = (a * b)
        TextBox3.Text = r
    End Sub
End Class
