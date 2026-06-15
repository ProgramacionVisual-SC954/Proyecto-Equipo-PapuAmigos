<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar
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
        lblResultado = New Label()
        btnEliminar = New Button()
        SuspendLayout()
        ' 
        ' txtBuscarId
        ' 
        txtBuscarId.Location = New Point(120, 147)
        txtBuscarId.Name = "txtBuscarId"
        txtBuscarId.Size = New Size(100, 23)
        txtBuscarId.TabIndex = 0
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(449, 71)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(157, 23)
        btnBuscar.TabIndex = 1
        btnBuscar.Text = "Buscar Usuario"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(162, 75)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(58, 15)
        lblResultado.TabIndex = 2
        lblResultado.Text = "................."
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Enabled = False
        btnEliminar.Location = New Point(488, 174)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(75, 23)
        btnEliminar.TabIndex = 3
        btnEliminar.Text = "Eliminar Usuario"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' Eliminar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnEliminar)
        Controls.Add(lblResultado)
        Controls.Add(btnBuscar)
        Controls.Add(txtBuscarId)
        Name = "Eliminar"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBuscarId As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnEliminar As Button
End Class
