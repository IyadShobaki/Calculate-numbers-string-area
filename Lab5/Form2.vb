Public Class Form2

    Dim myCalculate As New part2Class()

    Dim myCalculate1 As New part2bClass()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(myCalculate.Calculate(CType(TextBox1.Text, Integer), CType(TextBox2.Text, Integer)))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show(myCalculate1.Calculate(CType(TextBox1.Text, Integer), CType(TextBox2.Text, Integer)))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()

    End Sub
End Class