Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As String = TextBox1.Text
        Dim contraseña As String = TextBox2.Text

        ' Validar campos vacíos
        If usuario = "" Or contraseña = "" Then
            MessageBox.Show("Por favor ingresa usuario y contraseña")
            Exit Sub
        End If

        ' Validar credenciales
        If (usuario = "root" And contraseña = "root") Or
       (usuario = "admin" And contraseña = "admin") Or
       (usuario = "admin" And contraseña = "123") Then

            MessageBox.Show("Bienvenido " & usuario)

            Dim menu As New menu_principal

            ' Cuando cierres el menú, se cierra toda la app
            AddHandler menu.FormClosed, Sub()
                                            Application.Exit()
                                        End Sub

            menu.Show()

            ' Oculta el login (no lo cierres para evitar que muera la app)
            Me.Hide()

        Else
            MessageBox.Show("Usuario o contraseña incorrectos")
        End If
    End Sub
End Class
