<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class meses
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblTitulo = New Label()
        lblMonto = New Label()
        lblTasa = New Label()
        lblMeses = New Label()
        lblResultado = New Label()
        txtMonto = New TextBox()
        txtTtxtMeses = New TextBox()
        txtMeses = New TextBox()
        btnCalcular = New Button()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(64, 49)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(181, 15)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "SIMULADOR DE PAGO MENSUAL"
        ' 
        ' lblMonto
        ' 
        lblMonto.AutoSize = True
        lblMonto.Location = New Point(64, 83)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(115, 15)
        lblMonto.TabIndex = 1
        lblMonto.Text = "Monto del préstamo"
        ' 
        ' lblTasa
        ' 
        lblTasa.AutoSize = True
        lblTasa.Location = New Point(64, 117)
        lblTasa.Name = "lblTasa"
        lblTasa.Size = New Size(83, 15)
        lblTasa.TabIndex = 2
        lblTasa.Text = "Tasa anual (%)"
        ' 
        ' lblMeses
        ' 
        lblMeses.AutoSize = True
        lblMeses.Location = New Point(64, 147)
        lblMeses.Name = "lblMeses"
        lblMeses.Size = New Size(79, 15)
        lblMeses.TabIndex = 3
        lblMeses.Text = "Plazo (meses)"
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(64, 177)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(10, 15)
        lblResultado.TabIndex = 4
        lblResultado.Text = ":"
        ' 
        ' txtMonto
        ' 
        txtMonto.Location = New Point(200, 80)
        txtMonto.Name = "txtMonto"
        txtMonto.Size = New Size(100, 23)
        txtMonto.TabIndex = 5
        ' 
        ' txtTtxtMeses
        ' 
        txtTtxtMeses.Location = New Point(200, 114)
        txtTtxtMeses.Name = "txtTtxtMeses"
        txtTtxtMeses.Size = New Size(100, 23)
        txtTtxtMeses.TabIndex = 6
        ' 
        ' txtMeses
        ' 
        txtMeses.Location = New Point(200, 147)
        txtMeses.Name = "txtMeses"
        txtMeses.Size = New Size(100, 23)
        txtMeses.TabIndex = 7
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(330, 105)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(109, 39)
        btnCalcular.TabIndex = 8
        btnCalcular.Text = "Calcular pago"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' meses
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(521, 519)
        Controls.Add(btnCalcular)
        Controls.Add(txtMeses)
        Controls.Add(txtTtxtMeses)
        Controls.Add(txtMonto)
        Controls.Add(lblResultado)
        Controls.Add(lblMeses)
        Controls.Add(lblTasa)
        Controls.Add(lblMonto)
        Controls.Add(lblTitulo)
        Name = "meses"
        Text = "meses"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents lblTasa As Label
    Friend WithEvents lblMeses As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtTtxtMeses As TextBox
    Friend WithEvents txtMeses As TextBox
    Friend WithEvents btnCalcular As Button
End Class
