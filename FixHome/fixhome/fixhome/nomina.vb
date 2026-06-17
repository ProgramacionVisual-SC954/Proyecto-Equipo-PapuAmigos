Public Class nomina

    Private empleados As New List(Of Empleado)


    Public Class Empleado
        Public Property Nombre As String
        Public Property Sueldo As Double
    End Class

    Private Sub nomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTitulo.Text = "SISTEMA DE NÓMINA"

        dgvEmpleados.ColumnCount = 2
        dgvEmpleados.Columns(0).Name = "Nombre"
        dgvEmpleados.Columns(1).Name = "Sueldo"

        dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        empleados.Clear()

        empleados.Add(New Empleado With {.Nombre = "Juan Pérez", .Sueldo = 12000})
        empleados.Add(New Empleado With {.Nombre = "María López", .Sueldo = 15000})
        empleados.Add(New Empleado With {.Nombre = "Carlos Díaz", .Sueldo = 18000})
        empleados.Add(New Empleado With {.Nombre = "Ana Torres", .Sueldo = 14000})
        empleados.Add(New Empleado With {.Nombre = "Luis García", .Sueldo = 16000})

        dgvEmpleados.Rows.Clear()

        For Each emp In empleados
            dgvEmpleados.Rows.Add(emp.Nombre, emp.Sueldo)
        Next

        lblTotalEmp.Text = "Total de empleados: " & empleados.Count

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim total As Double = 0

        For Each emp In empleados
            total += emp.Sueldo
        Next

        lblTotalNomina.Text = "Total nómina: $ " & total.ToString("N2")

    End Sub


End Class