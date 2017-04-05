<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComputadora
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComputadora))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PbxEditar = New System.Windows.Forms.PictureBox()
        Me.PbxAtras = New System.Windows.Forms.PictureBox()
        Me.PbxGuardar = New System.Windows.Forms.PictureBox()
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboMarca = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PbxAgregar = New System.Windows.Forms.PictureBox()
        Me.CboCapacidad = New System.Windows.Forms.ComboBox()
        Me.CmsComputadora = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LsvComputadoras = New System.Windows.Forms.ListView()
        Me.ChIdComputadora = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChMarca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChModelo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChMemoriaRam = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDiscoDuro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTarjetaVideo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCapacidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChUnidadOptica = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDisponible = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TxtNumComputadora = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PbxEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxAtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsComputadora.SuspendLayout()
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
        'PbxEditar
        '
        Me.PbxEditar.Image = CType(resources.GetObject("PbxEditar.Image"), System.Drawing.Image)
        Me.PbxEditar.Location = New System.Drawing.Point(358, 520)
        Me.PbxEditar.Name = "PbxEditar"
        Me.PbxEditar.Size = New System.Drawing.Size(48, 52)
        Me.PbxEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxEditar.TabIndex = 34
        Me.PbxEditar.TabStop = False
        '
        'PbxAtras
        '
        Me.PbxAtras.Image = CType(resources.GetObject("PbxAtras.Image"), System.Drawing.Image)
        Me.PbxAtras.Location = New System.Drawing.Point(505, 525)
        Me.PbxAtras.Name = "PbxAtras"
        Me.PbxAtras.Size = New System.Drawing.Size(43, 47)
        Me.PbxAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxAtras.TabIndex = 33
        Me.PbxAtras.TabStop = False
        '
        'PbxGuardar
        '
        Me.PbxGuardar.Image = CType(resources.GetObject("PbxGuardar.Image"), System.Drawing.Image)
        Me.PbxGuardar.Location = New System.Drawing.Point(97, 525)
        Me.PbxGuardar.Name = "PbxGuardar"
        Me.PbxGuardar.Size = New System.Drawing.Size(43, 47)
        Me.PbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxGuardar.TabIndex = 32
        Me.PbxGuardar.TabStop = False
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
        Me.Label1.Location = New System.Drawing.Point(98, 164)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Modelo "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 20)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Cap. Memoria Ram"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 273)
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
        Me.Label6.Location = New System.Drawing.Point(353, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 20)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Unidad Optica"
        '
        'TxtDiscoDuro
        '
        Me.TxtDiscoDuro.Location = New System.Drawing.Point(176, 275)
        Me.TxtDiscoDuro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDiscoDuro.Name = "TxtDiscoDuro"
        Me.TxtDiscoDuro.Size = New System.Drawing.Size(153, 20)
        Me.TxtDiscoDuro.TabIndex = 43
        '
        'ChkDisponible
        '
        Me.ChkDisponible.AutoSize = True
        Me.ChkDisponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDisponible.Location = New System.Drawing.Point(482, 274)
        Me.ChkDisponible.Name = "ChkDisponible"
        Me.ChkDisponible.Size = New System.Drawing.Size(112, 24)
        Me.ChkDisponible.TabIndex = 44
        Me.ChkDisponible.Text = "Disponible"
        Me.ChkDisponible.UseVisualStyleBackColor = True
        '
        'CboModelo
        '
        Me.CboModelo.FormattingEnabled = True
        Me.CboModelo.Location = New System.Drawing.Point(176, 166)
        Me.CboModelo.Name = "CboModelo"
        Me.CboModelo.Size = New System.Drawing.Size(153, 21)
        Me.CboModelo.TabIndex = 45
        '
        'CboMemoriaRam
        '
        Me.CboMemoriaRam.FormattingEnabled = True
        Me.CboMemoriaRam.Location = New System.Drawing.Point(176, 221)
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
        Me.CboUnidadOptica.Location = New System.Drawing.Point(482, 222)
        Me.CboUnidadOptica.Name = "CboUnidadOptica"
        Me.CboUnidadOptica.Size = New System.Drawing.Size(153, 21)
        Me.CboUnidadOptica.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(382, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 20)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Capacidad"
        '
        'CboMarca
        '
        Me.CboMarca.FormattingEnabled = True
        Me.CboMarca.Location = New System.Drawing.Point(176, 112)
        Me.CboMarca.Name = "CboMarca"
        Me.CboMarca.Size = New System.Drawing.Size(153, 21)
        Me.CboMarca.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(98, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 20)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Marca"
        '
        'PbxAgregar
        '
        Me.PbxAgregar.Image = CType(resources.GetObject("PbxAgregar.Image"), System.Drawing.Image)
        Me.PbxAgregar.Location = New System.Drawing.Point(216, 520)
        Me.PbxAgregar.Name = "PbxAgregar"
        Me.PbxAgregar.Size = New System.Drawing.Size(48, 52)
        Me.PbxAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxAgregar.TabIndex = 54
        Me.PbxAgregar.TabStop = False
        '
        'CboCapacidad
        '
        Me.CboCapacidad.FormattingEnabled = True
        Me.CboCapacidad.Location = New System.Drawing.Point(482, 168)
        Me.CboCapacidad.Name = "CboCapacidad"
        Me.CboCapacidad.Size = New System.Drawing.Size(153, 21)
        Me.CboCapacidad.TabIndex = 55
        '
        'CmsComputadora
        '
        Me.CmsComputadora.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsComputadora.Name = "CmsComputadora"
        Me.CmsComputadora.Size = New System.Drawing.Size(118, 48)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'LsvComputadoras
        '
        Me.LsvComputadoras.CheckBoxes = True
        Me.LsvComputadoras.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdComputadora, Me.ChMarca, Me.ChModelo, Me.ChMemoriaRam, Me.ChDiscoDuro, Me.ChTarjetaVideo, Me.ChCapacidad, Me.ChUnidadOptica, Me.ChDisponible})
        Me.LsvComputadoras.ContextMenuStrip = Me.CmsComputadora
        Me.LsvComputadoras.Location = New System.Drawing.Point(7, 304)
        Me.LsvComputadoras.Name = "LsvComputadoras"
        Me.LsvComputadoras.Size = New System.Drawing.Size(641, 200)
        Me.LsvComputadoras.TabIndex = 56
        Me.LsvComputadoras.UseCompatibleStateImageBehavior = False
        Me.LsvComputadoras.View = System.Windows.Forms.View.Details
        '
        'ChIdComputadora
        '
        Me.ChIdComputadora.Text = "Num. Computadora"
        Me.ChIdComputadora.Width = 113
        '
        'ChMarca
        '
        Me.ChMarca.Text = "Marca"
        '
        'ChModelo
        '
        Me.ChModelo.Text = "Modelo"
        '
        'ChMemoriaRam
        '
        Me.ChMemoriaRam.Text = "Cap. Memoria Ram"
        Me.ChMemoriaRam.Width = 103
        '
        'ChDiscoDuro
        '
        Me.ChDiscoDuro.Text = "Cap. Disco Duro"
        Me.ChDiscoDuro.Width = 97
        '
        'ChTarjetaVideo
        '
        Me.ChTarjetaVideo.Text = "Tarjeta Video"
        Me.ChTarjetaVideo.Width = 79
        '
        'ChCapacidad
        '
        Me.ChCapacidad.Text = "Capacidad"
        Me.ChCapacidad.Width = 69
        '
        'ChUnidadOptica
        '
        Me.ChUnidadOptica.Text = "Unidad Optica"
        Me.ChUnidadOptica.Width = 86
        '
        'ChDisponible
        '
        Me.ChDisponible.Text = "Disponible"
        Me.ChDisponible.Width = 67
        '
        'TxtNumComputadora
        '
        Me.TxtNumComputadora.Enabled = False
        Me.TxtNumComputadora.Location = New System.Drawing.Point(176, 72)
        Me.TxtNumComputadora.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNumComputadora.Name = "TxtNumComputadora"
        Me.TxtNumComputadora.Size = New System.Drawing.Size(153, 20)
        Me.TxtNumComputadora.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 20)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Num. Computadora"
        '
        'FrmComputadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 602)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtNumComputadora)
        Me.Controls.Add(Me.LsvComputadoras)
        Me.Controls.Add(Me.CboCapacidad)
        Me.Controls.Add(Me.PbxGuardar)
        Me.Controls.Add(Me.PbxAgregar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CboMarca)
        Me.Controls.Add(Me.Label7)
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
        Me.Controls.Add(Me.PbxEditar)
        Me.Controls.Add(Me.PbxAtras)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmComputadora"
        Me.Text = "Computadora"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PbxEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxAtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsComputadora.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PbxEditar As PictureBox
    Friend WithEvents PbxAtras As PictureBox
    Friend WithEvents PbxGuardar As PictureBox
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
    Friend WithEvents Label7 As Label
    Friend WithEvents CboMarca As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PbxAgregar As PictureBox
    Friend WithEvents CboCapacidad As ComboBox
    Friend WithEvents CmsComputadora As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LsvComputadoras As ListView
    Friend WithEvents ChIdComputadora As ColumnHeader
    Friend WithEvents ChMarca As ColumnHeader
    Friend WithEvents ChModelo As ColumnHeader
    Friend WithEvents ChMemoriaRam As ColumnHeader
    Friend WithEvents ChDiscoDuro As ColumnHeader
    Friend WithEvents ChTarjetaVideo As ColumnHeader
    Friend WithEvents ChCapacidad As ColumnHeader
    Friend WithEvents ChUnidadOptica As ColumnHeader
    Friend WithEvents ChDisponible As ColumnHeader
    Friend WithEvents TxtNumComputadora As TextBox
    Friend WithEvents Label9 As Label
End Class
