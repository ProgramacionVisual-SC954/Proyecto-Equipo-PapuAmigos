Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As String = TextBox1.Text
        Dim contraseña As String = TextBox2.Text

        If (usuario = "root" And contraseña = "root") Or
       (usuario = "admin" And contraseña = "admin") Or
       (usuario = "admin" And contraseña = "123") Then

            MessageBox.Show("Login correcto")

            ' Abrir el nuevo formulario
            Dim menu As New menu_pricipal
            menu.Show()

            ' Ocultar el login
            Me.Hide()

        Else
            MessageBox.Show("Usuario o contraseña incorrectos")
        End If
    End Sub
End Class
