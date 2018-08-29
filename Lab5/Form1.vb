Public Class Form1
    Dim myClassVB As part1Class = New part1Class()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox3.Text <> "" Then
            MessageBox.Show(myClassVB.Add(CType(TextBox1.Text, Integer), CType(TextBox2.Text, Integer), CType(TextBox3.Text, Integer)))
        Else
            MessageBox.Show(myClassVB.Add(CType(TextBox1.Text, Integer), CType(TextBox2.Text, Integer)))
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If TextBox3.Text <> "" Then

            MessageBox.Show(myClassVB.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text))
        Else
            MessageBox.Show(myClassVB.Add(TextBox1.Text, TextBox2.Text))
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure?", "quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
