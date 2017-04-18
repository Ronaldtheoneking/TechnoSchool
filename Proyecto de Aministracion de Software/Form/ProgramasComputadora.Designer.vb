<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProgramasComputadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProgramasComputadora))
        Me.PbxEditar = New System.Windows.Forms.PictureBox()
        Me.PbxAtras = New System.Windows.Forms.PictureBox()
        Me.PbxGuardar = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaInstalacion = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.CboPrograma = New System.Windows.Forms.ComboBox()
        Me.CboComputadora = New System.Windows.Forms.ComboBox()
        Me.CboEmpleado = New System.Windows.Forms.ComboBox()
        Me.PbxAgregar = New System.Windows.Forms.PictureBox()
        Me.CmsProgComputadora = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtIdProgComputadora = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnCambiar = New System.Windows.Forms.Button()
        Me.TctrlProgramas = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LsvProgramaComputadora = New System.Windows.Forms.ListView()
        Me.ChCodProgComp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChIdPrograma = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombrePrograma = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoPrograma = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoLicencia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEmpleado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFechaInstalacion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFechaVencimiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.PbxEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxAtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PbxAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsProgComputadora.SuspendLayout()
        Me.TctrlProgramas.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PbxEditar
        '
        Me.PbxEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxEditar.Image = CType(resources.GetObject("PbxEditar.Image"), System.Drawing.Image)
        Me.PbxEditar.Location = New System.Drawing.Point(347, 521)
        Me.PbxEditar.Name = "PbxEditar"
        Me.PbxEditar.Size = New System.Drawing.Size(48, 52)
        Me.PbxEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxEditar.TabIndex = 52
        Me.PbxEditar.TabStop = False
        '
        'PbxAtras
        '
        Me.PbxAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxAtras.Image = CType(resources.GetObject("PbxAtras.Image"), System.Drawing.Image)
        Me.PbxAtras.Location = New System.Drawing.Point(492, 526)
        Me.PbxAtras.Name = "PbxAtras"
        Me.PbxAtras.Size = New System.Drawing.Size(43, 47)
        Me.PbxAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxAtras.TabIndex = 51
        Me.PbxAtras.TabStop = False
        '
        'PbxGuardar
        '
        Me.PbxGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxGuardar.Image = CType(resources.GetObject("PbxGuardar.Image"), System.Drawing.Image)
        Me.PbxGuardar.Location = New System.Drawing.Point(92, 523)
        Me.PbxGuardar.Name = "PbxGuardar"
        Me.PbxGuardar.Size = New System.Drawing.Size(43, 47)
        Me.PbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxGuardar.TabIndex = 50
        Me.PbxGuardar.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(-1, 540)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 62)
        Me.Panel2.TabIndex = 48
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 62)
        Me.Panel1.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(182, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(277, 27)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Programas Computadora"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(63, 229)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 16)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Fecha Instalación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 186)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Empleado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 145)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Programa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 16)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Num. Computadora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(313, 229)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 16)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Fecha de Vencimiento"
        '
        'dtpFechaInstalacion
        '
        Me.dtpFechaInstalacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInstalacion.Location = New System.Drawing.Point(200, 225)
        Me.dtpFechaInstalacion.Name = "dtpFechaInstalacion"
        Me.dtpFechaInstalacion.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaInstalacion.TabIndex = 76
        '
        'DtpFechaVencimiento
        '
        Me.DtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaVencimiento.Location = New System.Drawing.Point(482, 225)
        Me.DtpFechaVencimiento.Name = "DtpFechaVencimiento"
        Me.DtpFechaVencimiento.Size = New System.Drawing.Size(96, 20)
        Me.DtpFechaVencimiento.TabIndex = 77
        '
        'CboPrograma
        '
        Me.CboPrograma.FormattingEnabled = True
        Me.CboPrograma.Location = New System.Drawing.Point(203, 144)
        Me.CboPrograma.Name = "CboPrograma"
        Me.CboPrograma.Size = New System.Drawing.Size(293, 21)
        Me.CboPrograma.TabIndex = 78
        '
        'CboComputadora
        '
        Me.CboComputadora.FormattingEnabled = True
        Me.CboComputadora.Location = New System.Drawing.Point(203, 102)
        Me.CboComputadora.Name = "CboComputadora"
        Me.CboComputadora.Size = New System.Drawing.Size(293, 21)
        Me.CboComputadora.TabIndex = 79
        '
        'CboEmpleado
        '
        Me.CboEmpleado.FormattingEnabled = True
        Me.CboEmpleado.Location = New System.Drawing.Point(202, 185)
        Me.CboEmpleado.Name = "CboEmpleado"
        Me.CboEmpleado.Size = New System.Drawing.Size(293, 21)
        Me.CboEmpleado.TabIndex = 80
        '
        'PbxAgregar
        '
        Me.PbxAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxAgregar.Image = CType(resources.GetObject("PbxAgregar.Image"), System.Drawing.Image)
        Me.PbxAgregar.Location = New System.Drawing.Point(216, 521)
        Me.PbxAgregar.Name = "PbxAgregar"
        Me.PbxAgregar.Size = New System.Drawing.Size(48, 52)
        Me.PbxAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxAgregar.TabIndex = 82
        Me.PbxAgregar.TabStop = False
        '
        'CmsProgComputadora
        '
        Me.CmsProgComputadora.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsProgComputadora.Name = "CmsProgComputadora"
        Me.CmsProgComputadora.Size = New System.Drawing.Size(118, 48)
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
        'TxtIdProgComputadora
        '
        Me.TxtIdProgComputadora.Enabled = False
        Me.TxtIdProgComputadora.Location = New System.Drawing.Point(200, 69)
        Me.TxtIdProgComputadora.Name = "TxtIdProgComputadora"
        Me.TxtIdProgComputadora.Size = New System.Drawing.Size(296, 20)
        Me.TxtIdProgComputadora.TabIndex = 84
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(74, 70)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 16)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Cod. Instalación"
        '
        'BtnCambiar
        '
        Me.BtnCambiar.Location = New System.Drawing.Point(521, 92)
        Me.BtnCambiar.Name = "BtnCambiar"
        Me.BtnCambiar.Size = New System.Drawing.Size(106, 38)
        Me.BtnCambiar.TabIndex = 86
        Me.BtnCambiar.Text = "Cambiar Computadora"
        Me.BtnCambiar.UseVisualStyleBackColor = True
        '
        'TctrlProgramas
        '
        Me.TctrlProgramas.AccessibleName = ""
        Me.TctrlProgramas.Controls.Add(Me.TabPage1)
        Me.TctrlProgramas.Controls.Add(Me.TabPage2)
        Me.TctrlProgramas.Location = New System.Drawing.Point(5, 303)
        Me.TctrlProgramas.Name = "TctrlProgramas"
        Me.TctrlProgramas.SelectedIndex = 0
        Me.TctrlProgramas.Size = New System.Drawing.Size(643, 200)
        Me.TctrlProgramas.TabIndex = 87
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LsvComputadoras)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(635, 174)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detalle Computadora"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LsvComputadoras
        '
        Me.LsvComputadoras.CheckBoxes = True
        Me.LsvComputadoras.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdComputadora, Me.ChMarca, Me.ChModelo, Me.ChMemoriaRam, Me.ChDiscoDuro, Me.ChTarjetaVideo, Me.ChCapacidad, Me.ChUnidadOptica, Me.ChDisponible})
        Me.LsvComputadoras.GridLines = True
        Me.LsvComputadoras.Location = New System.Drawing.Point(-3, 0)
        Me.LsvComputadoras.Name = "LsvComputadoras"
        Me.LsvComputadoras.Size = New System.Drawing.Size(641, 178)
        Me.LsvComputadoras.TabIndex = 57
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LsvProgramaComputadora)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(635, 174)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Programas Instalados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LsvProgramaComputadora
        '
        Me.LsvProgramaComputadora.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodProgComp, Me.ChIdPrograma, Me.ChNombrePrograma, Me.ChTipoPrograma, Me.ChTipoLicencia, Me.ChEmpleado, Me.ChFechaInstalacion, Me.ChFechaVencimiento})
        Me.LsvProgramaComputadora.ContextMenuStrip = Me.CmsProgComputadora
        Me.LsvProgramaComputadora.GridLines = True
        Me.LsvProgramaComputadora.Location = New System.Drawing.Point(-4, -8)
        Me.LsvProgramaComputadora.Name = "LsvProgramaComputadora"
        Me.LsvProgramaComputadora.Size = New System.Drawing.Size(643, 191)
        Me.LsvProgramaComputadora.TabIndex = 85
        Me.LsvProgramaComputadora.UseCompatibleStateImageBehavior = False
        Me.LsvProgramaComputadora.View = System.Windows.Forms.View.Details
        '
        'ChCodProgComp
        '
        Me.ChCodProgComp.Text = "Cod. Instalacion"
        Me.ChCodProgComp.Width = 90
        '
        'ChIdPrograma
        '
        Me.ChIdPrograma.Text = "Cod. Programa"
        Me.ChIdPrograma.Width = 85
        '
        'ChNombrePrograma
        '
        Me.ChNombrePrograma.Text = "Nombre Programa"
        Me.ChNombrePrograma.Width = 138
        '
        'ChTipoPrograma
        '
        Me.ChTipoPrograma.Text = "Tipo Programa"
        Me.ChTipoPrograma.Width = 98
        '
        'ChTipoLicencia
        '
        Me.ChTipoLicencia.Text = "Tipo Licencia"
        Me.ChTipoLicencia.Width = 85
        '
        'ChEmpleado
        '
        Me.ChEmpleado.Text = "Instalado Por"
        Me.ChEmpleado.Width = 77
        '
        'ChFechaInstalacion
        '
        Me.ChFechaInstalacion.Text = "Fecha Instalación"
        Me.ChFechaInstalacion.Width = 76
        '
        'ChFechaVencimiento
        '
        Me.ChFechaVencimiento.Text = "Vecha Vencimiento"
        Me.ChFechaVencimiento.Width = 80
        '
        'FrmProgramasComputadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 602)
        Me.Controls.Add(Me.TctrlProgramas)
        Me.Controls.Add(Me.BtnCambiar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtIdProgComputadora)
        Me.Controls.Add(Me.PbxAgregar)
        Me.Controls.Add(Me.CboEmpleado)
        Me.Controls.Add(Me.CboComputadora)
        Me.Controls.Add(Me.CboPrograma)
        Me.Controls.Add(Me.DtpFechaVencimiento)
        Me.Controls.Add(Me.dtpFechaInstalacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PbxEditar)
        Me.Controls.Add(Me.PbxAtras)
        Me.Controls.Add(Me.PbxGuardar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmProgramasComputadora"
        Me.Text = " "
        CType(Me.PbxEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxAtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PbxAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsProgComputadora.ResumeLayout(False)
        Me.TctrlProgramas.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PbxEditar As PictureBox
    Friend WithEvents PbxAtras As PictureBox
    Friend WithEvents PbxGuardar As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechaInstalacion As DateTimePicker
    Friend WithEvents DtpFechaVencimiento As DateTimePicker
    Friend WithEvents CboPrograma As ComboBox
    Friend WithEvents CboComputadora As ComboBox
    Friend WithEvents CboEmpleado As ComboBox
    Friend WithEvents PbxAgregar As PictureBox
    Friend WithEvents TxtIdProgComputadora As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnCambiar As Button
    Friend WithEvents CmsProgComputadora As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TctrlProgramas As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents LsvProgramaComputadora As ListView
    Friend WithEvents ChCodProgComp As ColumnHeader
    Friend WithEvents ChIdPrograma As ColumnHeader
    Friend WithEvents ChNombrePrograma As ColumnHeader
    Friend WithEvents ChTipoPrograma As ColumnHeader
    Friend WithEvents ChTipoLicencia As ColumnHeader
    Friend WithEvents ChEmpleado As ColumnHeader
    Friend WithEvents ChFechaInstalacion As ColumnHeader
    Friend WithEvents ChFechaVencimiento As ColumnHeader
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
End Class
