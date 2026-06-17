<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_principal
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
        btnPagos = New Button()
        btnNomina = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(86, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.Location = New Point(86, 118)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(241, 23)
        btnRegistrar.TabIndex = 1
        btnRegistrar.Text = "Registrar"
        btnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' btnConsultar
        ' 
        btnConsultar.Location = New Point(86, 195)
        btnConsultar.Name = "btnConsultar"
        btnConsultar.Size = New Size(241, 23)
        btnConsultar.TabIndex = 2
        btnConsultar.Text = "Consultar"
        btnConsultar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(86, 279)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(241, 23)
        btnEditar.TabIndex = 3
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(451, 118)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(241, 23)
        btnEliminar.TabIndex = 4
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnPagos
        ' 
        btnPagos.Location = New Point(451, 195)
        btnPagos.Name = "btnPagos"
        btnPagos.Size = New Size(241, 23)
        btnPagos.TabIndex = 5
        btnPagos.Text = "Calcular pagos mensuales"
        btnPagos.UseVisualStyleBackColor = True
        ' 
        ' btnNomina
        ' 
        btnNomina.Location = New Point(451, 279)
        btnNomina.Name = "btnNomina"
        btnNomina.Size = New Size(241, 23)
        btnNomina.TabIndex = 6
        btnNomina.Text = "Mostrar total de empleados / nómina"
        btnNomina.UseVisualStyleBackColor = True
        ' 
        ' menu_principal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnNomina)
        Controls.Add(btnPagos)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnConsultar)
        Controls.Add(btnRegistrar)
        Controls.Add(Label1)
        Name = "menu_principal"
        Text = " "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnPagos As Button
    Friend WithEvents btnNomina As Button
End Class
