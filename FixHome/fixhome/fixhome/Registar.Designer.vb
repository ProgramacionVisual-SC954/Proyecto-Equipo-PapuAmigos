<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registar
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
        txtId = New TextBox()
        txtNombre = New TextBox()
        txtPuesto = New TextBox()
        txtDepartamento = New TextBox()
        btnRegistrar = New TextBox()
        lblResultado = New Label()
        SuspendLayout()
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(222, 61)
        txtId.Name = "txtId"
        txtId.Size = New Size(100, 23)
        txtId.TabIndex = 0
        txtId.Text = "Id"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(222, 111)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 1
        txtNombre.Text = "Nombre"
        ' 
        ' txtPuesto
        ' 
        txtPuesto.Location = New Point(236, 158)
        txtPuesto.Name = "txtPuesto"
        txtPuesto.Size = New Size(100, 23)
        txtPuesto.TabIndex = 2
        txtPuesto.Text = "Puesto"
        ' 
        ' txtDepartamento
        ' 
        txtDepartamento.Location = New Point(233, 219)
        txtDepartamento.Name = "txtDepartamento"
        txtDepartamento.Size = New Size(100, 23)
        txtDepartamento.TabIndex = 3
        txtDepartamento.Text = "Departamento"
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Location = New Point(502, 89)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(100, 23)
        btnRegistrar.TabIndex = 4
        btnRegistrar.Text = "Registrar"
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(513, 193)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(59, 15)
        lblResultado.TabIndex = 5
        lblResultado.Text = "Resultado"
        ' 
        ' Registar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResultado)
        Controls.Add(btnRegistrar)
        Controls.Add(txtDepartamento)
        Controls.Add(txtPuesto)
        Controls.Add(txtNombre)
        Controls.Add(txtId)
        Name = "Registar"
        Text = "Registar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPuesto As TextBox
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents btnRegistrar As TextBox
    Friend WithEvents lblResultado As Label
End Class
