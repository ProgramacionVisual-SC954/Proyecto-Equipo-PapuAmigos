<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nomina
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
        lblTotalEmp = New Label()
        lblTotalNomina = New Label()
        dgvEmpleados = New DataGridView()
        btnCargar = New Button()
        btnCalcular = New Button()
        CType(dgvEmpleados, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(110, 39)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(123, 15)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "SISTEMA DE NÓMINA"
        ' 
        ' lblTotalEmp
        ' 
        lblTotalEmp.AutoSize = True
        lblTotalEmp.Location = New Point(110, 73)
        lblTotalEmp.Name = "lblTotalEmp"
        lblTotalEmp.Size = New Size(113, 15)
        lblTotalEmp.TabIndex = 1
        lblTotalEmp.Text = "Total de empleados:"
        ' 
        ' lblTotalNomina
        ' 
        lblTotalNomina.AutoSize = True
        lblTotalNomina.Location = New Point(110, 106)
        lblTotalNomina.Name = "lblTotalNomina"
        lblTotalNomina.Size = New Size(80, 15)
        lblTotalNomina.TabIndex = 2
        lblTotalNomina.Text = "Total nómina:"
        ' 
        ' dgvEmpleados
        ' 
        dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmpleados.Location = New Point(110, 144)
        dgvEmpleados.Name = "dgvEmpleados"
        dgvEmpleados.Size = New Size(392, 234)
        dgvEmpleados.TabIndex = 3
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(358, 35)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(122, 23)
        btnCargar.TabIndex = 4
        btnCargar.Text = "Cargar empleados"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(358, 65)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(122, 23)
        btnCalcular.TabIndex = 5
        btnCalcular.Text = "Calcular nómina"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' nomina
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(526, 450)
        Controls.Add(btnCalcular)
        Controls.Add(btnCargar)
        Controls.Add(dgvEmpleados)
        Controls.Add(lblTotalNomina)
        Controls.Add(lblTotalEmp)
        Controls.Add(lblTitulo)
        Name = "nomina"
        Text = "nomina"
        CType(dgvEmpleados, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblTotalEmp As Label
    Friend WithEvents lblTotalNomina As Label
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnCalcular As Button
End Class
