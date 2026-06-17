Public Class Consultar

    ' Simulación de base de datos
    Private BaseDatosEmpleados As New Dictionary(Of String, String()) From {
        {"101", {"Juan Pérez", "Gerente", "Administración"}},
        {"102", {"María López", "Contadora", "Finanzas"}},
        {"103", {"Carlos Díaz", "Programador", "Sistemas"}},
        {"104", {"Jorge Sam", "Analista", "Sistemas"}},
        {"105", {"Ana Rodríguez", "Recursos Humanos", "RH"}},
        {"106", {"Kevin Martínez", "Técnico", "Soporte"}},
        {"107", {"Sofía Castro", "Diseñadora", "Marketing"}},
        {"108", {"Luis Alvarado", "Supervisor", "Producción"}}
    }

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim idEmpleado As String = txtBuscarId.Text.Trim()

        If String.IsNullOrEmpty(idEmpleado) Then
            MessageBox.Show("Ingrese un ID de empleado.",
                            "Validación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        If BaseDatosEmpleados.ContainsKey(idEmpleado) Then

            Dim datos() As String = BaseDatosEmpleados(idEmpleado)

            lblNombre.Text = datos(0)
            lblPuesto.Text = datos(1)
            lblDepartamento.Text = datos(2)

            lblResultado.Text = "Empleado encontrado."
            lblResultado.ForeColor = Color.DarkGreen

        Else

            lblNombre.Text = ""
            lblPuesto.Text = ""
            lblDepartamento.Text = ""

            lblResultado.Text = "Empleado no encontrado."
            lblResultado.ForeColor = Color.Red

        End If

    End Sub

    Private Sub ConsultarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblNombre.Text = ""
        lblPuesto.Text = ""
        lblDepartamento.Text = ""
        lblResultado.Text = ""

    End Sub
End Class