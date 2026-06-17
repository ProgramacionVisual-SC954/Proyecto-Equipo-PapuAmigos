<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuu
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
        Label1 = New Label()
        btnRegistrar = New Button()
        btnConsultar = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        btnCalcular = New Button()
        btnCerrar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Tai Le", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(226, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(315, 37)
        Label1.TabIndex = 0
        Label1.Text = "BIENVENIDO FIXHOME"
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Location = New Point(181, 152)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(105, 47)
        btnRegistrar.TabIndex = 1
        btnRegistrar.Text = "REGISTRO"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' btnConsultar
        ' 
        btnConsultar.Location = New Point(349, 152)
        btnConsultar.Name = "btnConsultar"
        btnConsultar.Size = New Size(105, 47)
        btnConsultar.TabIndex = 2
        btnConsultar.Text = "CONSULTAS"
        btnConsultar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(521, 152)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(105, 47)
        btnEditar.TabIndex = 3
        btnEditar.Text = "EDITAR"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(181, 235)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(105, 47)
        btnEliminar.TabIndex = 4
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(349, 235)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(105, 47)
        btnCalcular.TabIndex = 5
        btnCalcular.Text = "CALCULAR"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' btnCerrar
        ' 
        btnCerrar.BackColor = Color.Crimson
        btnCerrar.ForeColor = SystemColors.Control
        btnCerrar.Location = New Point(521, 235)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(105, 47)
        btnCerrar.TabIndex = 6
        btnCerrar.Text = "CERRAR"
        btnCerrar.UseVisualStyleBackColor = False
        ' 
        ' menuu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateBlue
        ClientSize = New Size(800, 450)
        Controls.Add(btnCerrar)
        Controls.Add(btnCalcular)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnConsultar)
        Controls.Add(btnRegistrar)
        Controls.Add(Label1)
        Name = "menuu"
        Text = "Menu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnCerrar As Button
End Class
