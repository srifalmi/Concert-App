Public Class Form1


    Sub batal()
        tbuser.Text = ""
        tbpass.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tbuser.Text = "saya" And tbpass.Text = "12" Then
            Form2.Show()

            Call batal()
            Me.Hide()
        End If
    End Sub
End Class
