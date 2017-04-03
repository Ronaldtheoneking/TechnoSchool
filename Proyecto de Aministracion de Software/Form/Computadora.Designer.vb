<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Computadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Computadora))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PbxAtras = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtDiscoDuro = New System.Windows.Forms.TextBox()
        Me.ChkDisponible = New System.Windows.Forms.CheckBox()
        Me.CboModelo = New System.Windows.Forms.ComboBox()
        Me.CboMemoriaRam = New System.Windows.Forms.ComboBox()
        Me.CboTarjetaVideo = New System.Windows.Forms.ComboBox()
        Me.CboUnidadOptica = New System.Windows.Forms.ComboBox()
        Me.DgvComputadora = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxAtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvComputadora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 62)
        Me.Panel1.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(234, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 27)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Computadora"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(300, 520)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(48, 52)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        '
        'PbxAtras
        '
        Me.PbxAtras.Image = CType(resources.GetObject("PbxAtras.Image"), System.Drawing.Image)
        Me.PbxAtras.Location = New System.Drawing.Point(447, 525)
        Me.PbxAtras.Name = "PbxAtras"
        Me.PbxAtras.Size = New System.Drawing.Size(43, 47)
        Me.PbxAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxAtras.TabIndex = 33
        Me.PbxAtras.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(148, 522)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(2, 539)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 62)
        Me.Panel2.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Modelo "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 20)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Cap. Memoria Ram"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Disco Duro"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(335, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 20)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Tarjeta de Video"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(353, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 20)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Unidad Optica"
        '
        'TxtDiscoDuro
        '
        Me.TxtDiscoDuro.Location = New System.Drawing.Point(172, 255)
        Me.TxtDiscoDuro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDiscoDuro.Name = "TxtDiscoDuro"
        Me.TxtDiscoDuro.Size = New System.Drawing.Size(157, 20)
        Me.TxtDiscoDuro.TabIndex = 43
        '
        'ChkDisponible
        '
        Me.ChkDisponible.AutoSize = True
        Me.ChkDisponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDisponible.Location = New System.Drawing.Point(482, 249)
        Me.ChkDisponible.Name = "ChkDisponible"
        Me.ChkDisponible.Size = New System.Drawing.Size(112, 24)
        Me.ChkDisponible.TabIndex = 44
        Me.ChkDisponible.Text = "Disponible"
        Me.ChkDisponible.UseVisualStyleBackColor = True
        '
        'CboModelo
        '
        Me.CboModelo.FormattingEnabled = True
        Me.CboModelo.Location = New System.Drawing.Point(176, 112)
        Me.CboModelo.Name = "CboModelo"
        Me.CboModelo.Size = New System.Drawing.Size(153, 21)
        Me.CboModelo.TabIndex = 45
        '
        'CboMemoriaRam
        '
        Me.CboMemoriaRam.FormattingEnabled = True
        Me.CboMemoriaRam.Location = New System.Drawing.Point(176, 182)
        Me.CboMemoriaRam.Name = "CboMemoriaRam"
        Me.CboMemoriaRam.Size = New System.Drawing.Size(153, 21)
        Me.CboMemoriaRam.TabIndex = 46
        '
        'CboTarjetaVideo
        '
        Me.CboTarjetaVideo.FormattingEnabled = True
        Me.CboTarjetaVideo.Location = New System.Drawing.Point(482, 112)
        Me.CboTarjetaVideo.Name = "CboTarjetaVideo"
        Me.CboTarjetaVideo.Size = New System.Drawing.Size(153, 21)
        Me.CboTarjetaVideo.TabIndex = 47
        '
        'CboUnidadOptica
        '
        Me.CboUnidadOptica.FormattingEnabled = True
        Me.CboUnidadOptica.Location = New System.Drawing.Point(482, 182)
        Me.CboUnidadOptica.Name = "CboUnidadOptica"
        Me.CboUnidadOptica.Size = New System.Drawing.Size(153, 21)
        Me.CboUnidadOptica.TabIndex = 48
        '
        'DgvComputadora
        '
        Me.DgvComputadora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvComputadora.Location = New System.Drawing.Point(7, 305)
        Me.DgvComputadora.Name = "DgvComputadora"
        Me.DgvComputadora.Size = New System.Drawing.Size(641, 200)
        Me.DgvComputadora.TabIndex = 49
        '
        'Computadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 602)
        Me.Controls.Add(Me.DgvComputadora)
        Me.Controls.Add(Me.CboUnidadOptica)
        Me.Controls.Add(Me.CboTarjetaVideo)
        Me.Controls.Add(Me.CboMemoriaRam)
        Me.Controls.Add(Me.CboModelo)
        Me.Controls.Add(Me.ChkDisponible)
        Me.Controls.Add(Me.TxtDiscoDuro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PbxAtras)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Computadora"
        Me.Text = "Computadora"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxAtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvComputadora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PbxAtras As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtDiscoDuro As TextBox
    Friend WithEvents ChkDisponible As CheckBox
    Friend WithEvents CboModelo As ComboBox
    Friend WithEvents CboMemoriaRam As ComboBox
    Friend WithEvents CboTarjetaVideo As ComboBox
    Friend WithEvents CboUnidadOptica As ComboBox
    Friend WithEvents DgvComputadora As DataGridView
End Class
