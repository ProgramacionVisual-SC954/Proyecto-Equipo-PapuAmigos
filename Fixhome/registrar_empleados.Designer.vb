<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registrar_empleados
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
        lblNombre = New Label()
        lblPuesto = New Label()
        txtNombre = New TextBox()
        txtPuesto = New TextBox()
        btnRegistrar = New Button()
        btnCerrar = New Button()
        SuspendLayout()
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.ForeColor = SystemColors.ControlLightLight
        lblNombre.Location = New Point(326, 105)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(56, 15)
        lblNombre.TabIndex = 0
        lblNombre.Text = "NOMBRE"
        ' 
        ' lblPuesto
        ' 
        lblPuesto.AutoSize = True
        lblPuesto.ForeColor = SystemColors.ControlLightLight
        lblPuesto.Location = New Point(327, 139)
        lblPuesto.Name = "lblPuesto"
        lblPuesto.Size = New Size(49, 15)
        lblPuesto.TabIndex = 1
        lblPuesto.Text = "PUESTO"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(413, 102)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 2
        ' 
        ' txtPuesto
        ' 
        txtPuesto.Location = New Point(413, 139)
        txtPuesto.Name = "txtPuesto"
        txtPuesto.Size = New Size(100, 23)
        txtPuesto.TabIndex = 3
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Location = New Point(424, 181)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(75, 23)
        btnRegistrar.TabIndex = 4
        btnRegistrar.Text = "REGISTRAR"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackColor = Color.Crimson
        btnCerrar.ForeColor = SystemColors.ControlLightLight
        btnCerrar.Location = New Point(424, 220)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(75, 23)
        btnCerrar.TabIndex = 5
        btnCerrar.Text = "Cerrar"
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' registrar_empleados
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateBlue
        ClientSize = New Size(800, 450)
        Controls.Add(btnCerrar)
        Controls.Add(btnRegistrar)
        Controls.Add(txtPuesto)
        Controls.Add(txtNombre)
        Controls.Add(lblPuesto)
        Controls.Add(lblNombre)
        Name = "registrar_empleados"
        Text = "Registro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblPuesto As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPuesto As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnCerrar As Button
End Class
