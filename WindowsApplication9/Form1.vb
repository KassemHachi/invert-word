Public Class Form1
    Dim cls As New cls
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cls.inInvert = TextBox2.Text
        cls.invert()
        TextBox1.Text = cls.outInvert

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        cls.inInvert = TextBox2.Text
        cls.invert()
        TextBox1.Text = cls.outInvert
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
