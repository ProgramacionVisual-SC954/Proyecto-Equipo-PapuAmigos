<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar
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
        txtBuscarId = New TextBox()
        btnBuscar = New Button()
        lblNombre = New Label()
        lblPuesto = New Label()
        lblDepartamento = New Label()
        lblResultado = New Label()
        SuspendLayout()
        ' 
        ' txtBuscarId
        ' 
        txtBuscarId.Location = New Point(282, 71)
        txtBuscarId.Name = "txtBuscarId"
        txtBuscarId.Size = New Size(100, 23)
        txtBuscarId.TabIndex = 0
        txtBuscarId.Text = "Buscar ID"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(448, 70)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(75, 23)
        btnBuscar.TabIndex = 1
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(282, 154)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(51, 15)
        lblNombre.TabIndex = 2
        lblNombre.Text = "Nombre"
        ' 
        ' lblPuesto
        ' 
        lblPuesto.AutoSize = True
        lblPuesto.Location = New Point(283, 184)
        lblPuesto.Name = "lblPuesto"
        lblPuesto.Size = New Size(43, 15)
        lblPuesto.TabIndex = 3
        lblPuesto.Text = "Puesto"
        ' 
        ' lblDepartamento
        ' 
        lblDepartamento.AutoSize = True
        lblDepartamento.Location = New Point(282, 228)
        lblDepartamento.Name = "lblDepartamento"
        lblDepartamento.Size = New Size(83, 15)
        lblDepartamento.TabIndex = 4
        lblDepartamento.Text = "Departamento"
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(283, 274)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(59, 15)
        lblResultado.TabIndex = 5
        lblResultado.Text = "Resultado"
        ' 
        ' Consultar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResultado)
        Controls.Add(lblDepartamento)
        Controls.Add(lblPuesto)
        Controls.Add(lblNombre)
        Controls.Add(btnBuscar)
        Controls.Add(txtBuscarId)
        Name = "Consultar"
        Text = "Consultar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBuscarId As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblPuesto As Label
    Friend WithEvents lblDepartamento As Label
    Friend WithEvents lblResultado As Label
End Class
