<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editar
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
        txtNombre = New TextBox()
        btnGuardar = New Button()
        lblResultado = New Label()
        SuspendLayout()
        ' 
        ' txtBuscarId
        ' 
        txtBuscarId.Location = New Point(350, 130)
        txtBuscarId.Name = "txtBuscarId"
        txtBuscarId.Size = New Size(100, 23)
        txtBuscarId.TabIndex = 0
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(449, 48)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(75, 23)
        btnBuscar.TabIndex = 1
        btnBuscar.Text = "buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(278, 48)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 2
        txtNombre.Text = "Ingresa Nombre"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(350, 266)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 3
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(350, 325)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(65, 15)
        lblResultado.TabIndex = 4
        lblResultado.Text = "Reseultado"
        ' 
        ' Editar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblResultado)
        Controls.Add(btnGuardar)
        Controls.Add(txtNombre)
        Controls.Add(btnBuscar)
        Controls.Add(txtBuscarId)
        Name = "Editar"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBuscarId As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblResultado As Label
End Class
