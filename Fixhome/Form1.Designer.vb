<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        btm_inicio = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(273, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(230, 65)
        Label1.TabIndex = 0
        Label1.Text = "HomeFix"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btm_inicio
        ' 
        btm_inicio.BackColor = Color.DeepSkyBlue
        btm_inicio.Location = New Point(319, 194)
        btm_inicio.Name = "btm_inicio"
        btm_inicio.Size = New Size(135, 47)
        btm_inicio.TabIndex = 1
        btm_inicio.Text = "INICIO"
        btm_inicio.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateBlue
        ClientSize = New Size(800, 450)
        Controls.Add(btm_inicio)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "INICIO"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btm_inicio As Button

End Class
