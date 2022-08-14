Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Double

        a = TextBox1.Text
        b = TextBox2.Text

        If RadioButton1.Checked = True Then
            c = a + b
            Label4.Text = c
        ElseIf RadioButton2.Checked = True Then
            c = a - b
            Label4.Text = c
        ElseIf RadioButton3.Checked = True Then
            c = a * b
            Label4.Text = c
        ElseIf RadioButton4.Checked = True Then
            c = a / b
            Label4.Text = c
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If MsgBox("Desea Salir?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
End Class
