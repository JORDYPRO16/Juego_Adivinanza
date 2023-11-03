<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InicioJuegos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnJAdivinanza = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnRProblemas = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(439, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido al centro de juegos "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Juego de Adivinanza"
        '
        'BtnJAdivinanza
        '
        Me.BtnJAdivinanza.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnJAdivinanza.Image = Global.Juego_Adivinanza.My.Resources.Resources._1930264_check_complete_done_green_success_icon
        Me.BtnJAdivinanza.Location = New System.Drawing.Point(52, 196)
        Me.BtnJAdivinanza.Name = "BtnJAdivinanza"
        Me.BtnJAdivinanza.Size = New System.Drawing.Size(145, 98)
        Me.BtnJAdivinanza.TabIndex = 2
        Me.BtnJAdivinanza.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(321, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(314, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Resolusión de Problemas"
        '
        'BtnRProblemas
        '
        Me.BtnRProblemas.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnRProblemas.Image = Global.Juego_Adivinanza.My.Resources.Resources._1930264_check_complete_done_green_success_icon
        Me.BtnRProblemas.Location = New System.Drawing.Point(396, 196)
        Me.BtnRProblemas.Name = "BtnRProblemas"
        Me.BtnRProblemas.Size = New System.Drawing.Size(145, 98)
        Me.BtnRProblemas.TabIndex = 4
        Me.BtnRProblemas.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(246, 295)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 42)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "CERRAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'InicioJuegos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 386)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnRProblemas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnJAdivinanza)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InicioJuegos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InicioJuegos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnJAdivinanza As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnRProblemas As Button
    Friend WithEvents Button3 As Button
End Class
