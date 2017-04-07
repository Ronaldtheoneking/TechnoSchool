<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPantallaPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPantallaPrincipal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblProgramasComputadora = New System.Windows.Forms.Label()
        Me.LblEmpleado = New System.Windows.Forms.Label()
        Me.LblProgramas = New System.Windows.Forms.Label()
        Me.LblComputadoras = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblCerrar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblNombreUsuario = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.LblProgramasComputadora)
        Me.Panel1.Controls.Add(Me.LblEmpleado)
        Me.Panel1.Controls.Add(Me.LblProgramas)
        Me.Panel1.Controls.Add(Me.LblComputadoras)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 62)
        Me.Panel1.TabIndex = 13
        '
        'LblProgramasComputadora
        '
        Me.LblProgramasComputadora.AutoSize = True
        Me.LblProgramasComputadora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblProgramasComputadora.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProgramasComputadora.ForeColor = System.Drawing.Color.White
        Me.LblProgramasComputadora.Location = New System.Drawing.Point(454, 22)
        Me.LblProgramasComputadora.Name = "LblProgramasComputadora"
        Me.LblProgramasComputadora.Size = New System.Drawing.Size(171, 17)
        Me.LblProgramasComputadora.TabIndex = 19
        Me.LblProgramasComputadora.Text = "ProgramasComputadoras"
        '
        'LblEmpleado
        '
        Me.LblEmpleado.AutoSize = True
        Me.LblEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblEmpleado.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpleado.ForeColor = System.Drawing.Color.White
        Me.LblEmpleado.Location = New System.Drawing.Point(325, 22)
        Me.LblEmpleado.Name = "LblEmpleado"
        Me.LblEmpleado.Size = New System.Drawing.Size(72, 17)
        Me.LblEmpleado.TabIndex = 19
        Me.LblEmpleado.Text = "Empleado"
        '
        'LblProgramas
        '
        Me.LblProgramas.AutoSize = True
        Me.LblProgramas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblProgramas.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProgramas.ForeColor = System.Drawing.Color.White
        Me.LblProgramas.Location = New System.Drawing.Point(192, 22)
        Me.LblProgramas.Name = "LblProgramas"
        Me.LblProgramas.Size = New System.Drawing.Size(79, 17)
        Me.LblProgramas.TabIndex = 19
        Me.LblProgramas.Text = "Programas"
        '
        'LblComputadoras
        '
        Me.LblComputadoras.AutoSize = True
        Me.LblComputadoras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblComputadoras.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblComputadoras.ForeColor = System.Drawing.Color.White
        Me.LblComputadoras.Location = New System.Drawing.Point(32, 22)
        Me.LblComputadoras.Name = "LblComputadoras"
        Me.LblComputadoras.Size = New System.Drawing.Size(100, 17)
        Me.LblComputadoras.TabIndex = 18
        Me.LblComputadoras.Text = "Computadoras"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Controls.Add(Me.LblCerrar)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(0, 373)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 62)
        Me.Panel2.TabIndex = 14
        '
        'LblCerrar
        '
        Me.LblCerrar.AutoSize = True
        Me.LblCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblCerrar.Font = New System.Drawing.Font("Elephant", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCerrar.ForeColor = System.Drawing.Color.White
        Me.LblCerrar.Location = New System.Drawing.Point(12, 6)
        Me.LblCerrar.Name = "LblCerrar"
        Me.LblCerrar.Size = New System.Drawing.Size(97, 17)
        Me.LblCerrar.TabIndex = 20
        Me.LblCerrar.Text = "Cerrar Sesion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(233, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 14)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Esfuerzo, Sacrificio y Voluntad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Elephant", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(247, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 21)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "TECHNO SCHOOL"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(237, 129)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'LblNombreUsuario
        '
        Me.LblNombreUsuario.AutoSize = True
        Me.LblNombreUsuario.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblNombreUsuario.Location = New System.Drawing.Point(210, 279)
        Me.LblNombreUsuario.Name = "LblNombreUsuario"
        Me.LblNombreUsuario.Size = New System.Drawing.Size(107, 21)
        Me.LblNombreUsuario.TabIndex = 16
        Me.LblNombreUsuario.Text = "Bienvenido"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(443, 347)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 17
        '
        'FrmPantallaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 433)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LblNombreUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPantallaPrincipal"
        Me.Text = "PantallaPrincipal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblProgramasComputadora As Label
    Friend WithEvents LblEmpleado As Label
    Friend WithEvents LblProgramas As Label
    Friend WithEvents LblComputadoras As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblNombreUsuario As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents LblCerrar As Label
End Class
