Public Class Editar

    ' Simulación de una base de datos temporal en memoria
    Private BaseDatosUsuarios As New Dictionary(Of String, String) From {
        {"101", "Juan Pérez"},
        {"102", "María López"},
        {"103", "Carlos Díaz"},
        {"104", "Jorge Sam"},
        {"105", "Ana Rodríguez"},
        {"106", "Kevin Martínez"},
        {"107", "Sofía Castro"},
        {"108", "Luis Alvarado"}
    }

    Private UsuarioEncontradoId As String = ""

    ' --- EVENTO DEL BOTÓN BUSCAR ---
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim idABuscar As String = txtBuscarId.Text.Trim()

        If String.IsNullOrEmpty(idABuscar) Then
            MessageBox.Show("Por favor, ingresa un ID para buscar.",
                            "Validación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        If BaseDatosUsuarios.ContainsKey(idABuscar) Then

            UsuarioEncontradoId = idABuscar

            txtNombre.Text = BaseDatosUsuarios(idABuscar)

            lblResultado.Text = "Usuario encontrado."
            lblResultado.ForeColor = Color.DarkGreen

            txtNombre.Enabled = True
            btnGuardar.Enabled = True

        Else

            UsuarioEncontradoId = ""

            txtNombre.Clear()

            lblResultado.Text = "Usuario no registrado en el sistema."
            lblResultado.ForeColor = Color.Red

            txtNombre.Enabled = False
            btnGuardar.Enabled = False

        End If

    End Sub

    ' --- EVENTO DEL BOTÓN GUARDAR ---
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim nuevoNombre As String = txtNombre.Text.Trim()

        If String.IsNullOrEmpty(nuevoNombre) Then
            MessageBox.Show("El nombre no puede estar vacío.",
                            "Validación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim respuesta As DialogResult = MessageBox.Show(
            "¿Deseas actualizar los datos del usuario?",
            "Confirmar edición",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If respuesta = DialogResult.Yes Then

            BaseDatosUsuarios(UsuarioEncontradoId) = nuevoNombre

            MessageBox.Show("Los datos fueron actualizados correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            txtBuscarId.Clear()
            txtNombre.Clear()

            lblResultado.Text = ""

            UsuarioEncontradoId = ""

            txtNombre.Enabled = False
            btnGuardar.Enabled = False

        End If

    End Sub

    Private Sub Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNombre.Enabled = False
        btnGuardar.Enabled = False

    End Sub

End Class