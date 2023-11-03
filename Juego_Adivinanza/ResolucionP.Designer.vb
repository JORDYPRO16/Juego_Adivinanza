<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResolucionP
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblOP = New System.Windows.Forms.Label()
        Me.TxtRespuesta = New System.Windows.Forms.TextBox()
        Me.BtnResolver = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RCT = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RIC = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Problema a Resolver"
        '
        'LblOP
        '
        Me.LblOP.AutoSize = True
        Me.LblOP.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOP.Location = New System.Drawing.Point(42, 186)
        Me.LblOP.Name = "LblOP"
        Me.LblOP.Size = New System.Drawing.Size(98, 23)
        Me.LblOP.TabIndex = 1
        Me.LblOP.Text = "Operacion"
        '
        'TxtRespuesta
        '
        Me.TxtRespuesta.Location = New System.Drawing.Point(12, 248)
        Me.TxtRespuesta.Name = "TxtRespuesta"
        Me.TxtRespuesta.Size = New System.Drawing.Size(176, 26)
        Me.TxtRespuesta.TabIndex = 2
        '
        'BtnResolver
        '
        Me.BtnResolver.BackColor = System.Drawing.Color.LightGreen
        Me.BtnResolver.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnResolver.Location = New System.Drawing.Point(259, 142)
        Me.BtnResolver.Name = "BtnResolver"
        Me.BtnResolver.Size = New System.Drawing.Size(144, 110)
        Me.BtnResolver.TabIndex = 3
        Me.BtnResolver.Text = "Resolver"
        Me.BtnResolver.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Respuestas correctas"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(535, 103)
        Me.Panel1.TabIndex = 5
        '
        'RCT
        '
        Me.RCT.AutoSize = True
        Me.RCT.Location = New System.Drawing.Point(64, 344)
        Me.RCT.Name = "RCT"
        Me.RCT.Size = New System.Drawing.Size(42, 20)
        Me.RCT.TabIndex = 5
        Me.RCT.Text = "CDP"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(270, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 86)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Presione para salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-1, 381)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(204, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Respuestas incorrectas"
        '
        'RIC
        '
        Me.RIC.AutoSize = True
        Me.RIC.Location = New System.Drawing.Point(64, 404)
        Me.RIC.Name = "RIC"
        Me.RIC.Size = New System.Drawing.Size(42, 20)
        Me.RIC.TabIndex = 7
        Me.RIC.Text = "CDP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Resolusion de problemas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Juego_Adivinanza.My.Resources.Resources._9266919_education_math_school_learning_icon__1_
        Me.PictureBox1.Location = New System.Drawing.Point(31, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'ResolucionP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 468)
        Me.Controls.Add(Me.RIC)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RCT)
        Me.Controls.Add(Me.BtnResolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtRespuesta)
        Me.Controls.Add(Me.LblOP)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ResolucionP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ResolucionP"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblOP As Label
    Friend WithEvents TxtRespuesta As TextBox
    Friend WithEvents BtnResolver As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RCT As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RIC As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
