Public Class Eliminar

    ' Simulación de una base de datos temporal en memoria (Lista de usuarios)
    ' Nota: En el futuro, esto lo conectarás a SQL Server, MySQL o Access.
    ' Simulación de una base de datos con más usuarios de prueba
    Private BaseDatosUsuarios As New Dictionary(Of String, String) From {
        {"101", "Juan Pérez"},
        {"102", "María López"},
        {"103", "Carlos Díaz"},
        {"104", "Jorge Sam"},
        {"105", "Ana Rodríguez"},
        {"106", "Kevin Martínez"},
        {"107", "Sofía Castro"},
        {"108", "Luis Alvardo"}
    }


    Private UsuarioEncontradoId As String = ""

    ' --- EVENTO DEL BOTÓN BUSCAR ---
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim idABuscar As String = txtBuscarId.Text.Trim()

        ' Validar que el campo no esté vacío
        If String.IsNullOrEmpty(idABuscar) Then
            MessageBox.Show("Por favor, ingresa un ID para buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Buscar en la "Base de Datos"
        If BaseDatosUsuarios.ContainsKey(idABuscar) Then
            UsuarioEncontradoId = idABuscar
            lblResultado.Text = "Usuario encontrado: " & BaseDatosUsuarios(idABuscar)
            lblResultado.ForeColor = Color.DarkGreen
            btnEliminar.Enabled = True ' Activamos el botón de borrar de forma segura
        Else
            UsuarioEncontradoId = ""
            lblResultado.Text = "Usuario no registrado en el sistema."
            lblResultado.ForeColor = Color.Red
            btnEliminar.Enabled = False ' Mantenemos el botón apagado
        End If
    End Sub

    ' --- EVENTO DEL BOTÓN ELIMINAR ---
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Preguntar siempre antes de borrar datos (Confirmación de seguridad)
        Dim respuesta As DialogResult = MessageBox.Show(
            "¿Estás completamente seguro de que deseas eliminar a " & BaseDatosUsuarios(UsuarioEncontradoId) & "?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If respuesta = DialogResult.Yes Then
            ' Eliminar del diccionario/base de datos
            BaseDatosUsuarios.Remove(UsuarioEncontradoId)

            ' Limpiar la interfaz para la siguiente operación
            MessageBox.Show("El usuario ha sido eliminado correctamente del sistema.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtBuscarId.Clear()
            lblResultado.Text = ""
            UsuarioEncontradoId = ""
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub Eliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
