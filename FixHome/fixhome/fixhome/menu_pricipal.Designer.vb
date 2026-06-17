<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu_pricipal
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(24, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(233, 32)
        Label1.TabIndex = 0
        Label1.Text = "Hola, Administrador"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(124, 105)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 54)
        Button1.TabIndex = 1
        Button1.Text = "Registrar empleados"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(124, 177)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 54)
        Button2.TabIndex = 2
        Button2.Text = "Consultar empleados"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(124, 248)
        Button3.Name = "Button3"
        Button3.Size = New Size(150, 54)
        Button3.TabIndex = 3
        Button3.Text = "Editar información"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(408, 105)
        Button4.Name = "Button4"
        Button4.Size = New Size(165, 54)
        Button4.TabIndex = 4
        Button4.Text = "Eliminar empleados"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(408, 177)
        Button5.Name = "Button5"
        Button5.Size = New Size(165, 54)
        Button5.TabIndex = 5
        Button5.Text = "Calcular pagos mensuales"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(408, 248)
        Button6.Name = "Button6"
        Button6.Size = New Size(165, 54)
        Button6.TabIndex = 6
        Button6.Text = "Mostrar el total de empleados y nómina"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' menu_pricipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(712, 392)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "menu_pricipal"
        Text = "menu_pricipal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
