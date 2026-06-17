Public Class Registar
    ' Simulación de base de datos
    Private BaseDatosEmpleados As New Dictionary(Of String, String()) From {
        {"101", {"Juan Pérez", "Gerente", "Administración"}},
        {"102", {"María López", "Contadora", "Finanzas"}},
        {"103", {"Carlos Díaz", "Programador", "Sistemas"}}
    }

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        Dim id As String = txtId.Text.Trim()
        Dim nombre As String = txtNombre.Text.Trim()
        Dim puesto As String = txtPuesto.Text.Trim()
        Dim departamento As String = txtDepartamento.Text.Trim()

        ' Validar campos vacíos
        If String.IsNullOrEmpty(id) Or
           String.IsNullOrEmpty(nombre) Or
           String.IsNullOrEmpty(puesto) Or
           String.IsNullOrEmpty(departamento) Then

            MessageBox.Show(
                "Todos los campos son obligatorios.",
                "Validación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning)

            Exit Sub
        End If

        ' Verificar que el ID no exista
        If BaseDatosEmpleados.ContainsKey(id) Then

            MessageBox.Show(
                "Ya existe un empleado registrado con ese ID.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            Exit Sub
        End If

        ' Registrar empleado
        BaseDatosEmpleados.Add(id, New String() {
            nombre,
            puesto,
            departamento
        })

        lblResultado.Text = "Empleado registrado correctamente."
        lblResultado.ForeColor = Color.DarkGreen

        MessageBox.Show(
            "Registro realizado con éxito.",
            "Éxito",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

        ' Limpiar campos
        txtId.Clear()
        txtNombre.Clear()
        txtPuesto.Clear()
        txtDepartamento.Clear()

        txtId.Focus()

    End Sub

    Private Sub RegistrarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblResultado.Text = ""

    End Sub
End Class