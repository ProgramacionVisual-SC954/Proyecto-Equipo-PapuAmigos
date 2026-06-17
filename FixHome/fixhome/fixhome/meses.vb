Public Class meses

    Private Sub meses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitulo.Text = "SIMULADOR DE PAGO MENSUAL"
        lblResultado.Text = ""
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Try
            Dim monto As Double
            Dim tasaAnual As Double
            Dim mesesCredito As Integer

            If txtMonto.Text = "" Or txtTtxtMeses.Text = "" Or txtMeses.Text = "" Then
                MessageBox.Show("Completa todos los campos.")
                Exit Sub
            End If

            monto = Double.Parse(txtMonto.Text)
            tasaAnual = Double.Parse(txtTtxtMeses.Text)
            mesesCredito = Integer.Parse(txtMeses.Text)

            If monto <= 0 Or tasaAnual < 0 Or mesesCredito <= 0 Then
                MessageBox.Show("Ingresa valores mayores a cero.")
                Exit Sub
            End If
            Dim tasaMensual As Double = (tasaAnual / 12) / 100

            Dim pago As Double
            If tasaMensual = 0 Then
                pago = monto / mesesCredito
            Else
                pago = (monto * tasaMensual) / (1 - Math.Pow(1 + tasaMensual, -mesesCredito))
            End If

            lblResultado.Text = "Pago mensual: $ " & Math.Round(pago, 2).ToString("N2")

        Catch ex As Exception
            MessageBox.Show("Error: ingresa solo números válidos.")
        End Try

    End Sub

End Class