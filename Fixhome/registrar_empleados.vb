Public Class registrar_empleados


    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        If txtNombre.Text = "" Or txtPuesto.Text = "" Then
            MessageBox.Show("Complete todos los campos.", "Aviso")
            Exit Sub
        End If

        MessageBox.Show("Empleado registrado correctamente." &
                        vbCrLf &
                        "Nombre: " & txtNombre.Text &
                        vbCrLf &
                        "Puesto: " & txtPuesto.Text,
                        "Registro Exitoso")

        txtNombre.Clear()
        txtPuesto.Clear()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class