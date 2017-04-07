<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProgramas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProgramas))
        Me.PbxEditar = New System.Windows.Forms.PictureBox()
        Me.PbxAtras = New System.Windows.Forms.PictureBox()
        Me.PbxGuardar = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombrePrograma = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboTipoLicencia = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboTipoPrograma = New System.Windows.Forms.ComboBox()
        Me.LsvProgramas = New System.Windows.Forms.ListView()
        Me.ChIdPrograma = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombrePrograma = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoPrograma = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoLicencia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsProgramas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PbxAgregar = New System.Windows.Forms.PictureBox()
        Me.TxtIdPrograma = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PbxEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxAtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.CmsProgramas.SuspendLayout()
        CType(Me.PbxAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PbxEditar
        '
        Me.PbxEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxEditar.Image = CType(resources.GetObject("PbxEditar.Image"), System.Drawing.Image)
        Me.PbxEditar.Location = New System.Drawing.Point(350, 521)
        Me.PbxEditar.Name = "PbxEditar"
        Me.PbxEditar.Size = New System.Drawing.Size(48, 52)
        Me.PbxEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxEditar.TabIndex = 46
        Me.PbxEditar.TabStop = False
        '
        'PbxAtras
        '
        Me.PbxAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxAtras.Image = CType(resources.GetObject("PbxAtras.Image"), System.Drawing.Image)
        Me.PbxAtras.Location = New System.Drawing.Point(497, 526)
        Me.PbxAtras.Name = "PbxAtras"
        Me.PbxAtras.Size = New System.Drawing.Size(43, 47)
        Me.PbxAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxAtras.TabIndex = 45
        Me.PbxAtras.TabStop = False
        '
        'PbxGuardar
        '
        Me.PbxGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxGuardar.Image = CType(resources.GetObject("PbxGuardar.Image"), System.Drawing.Image)
        Me.PbxGuardar.Location = New System.Drawing.Point(88, 523)
        Me.PbxGuardar.Name = "PbxGuardar"
        Me.PbxGuardar.Size = New System.Drawing.Size(43, 47)
        Me.PbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxGuardar.TabIndex = 44
        Me.PbxGuardar.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(-1, 540)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 62)
        Me.Panel2.TabIndex = 42
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 62)
        Me.Panel1.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(255, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 27)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Programas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 179)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 16)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Tipo de Programa"
        '
        'TxtNombrePrograma
        '
        Me.TxtNombrePrograma.Location = New System.Drawing.Point(259, 121)
        Me.TxtNombrePrograma.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombrePrograma.Name = "TxtNombrePrograma"
        Me.TxtNombrePrograma.Size = New System.Drawing.Size(253, 20)
        Me.TxtNombrePrograma.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 122)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 16)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Nombre del Programa"
        '
        'CboTipoLicencia
        '
        Me.CboTipoLicencia.FormattingEnabled = True
        Me.CboTipoLicencia.Location = New System.Drawing.Point(259, 238)
        Me.CboTipoLicencia.Name = "CboTipoLicencia"
        Me.CboTipoLicencia.Size = New System.Drawing.Size(253, 21)
        Me.CboTipoLicencia.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(105, 239)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 16)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Tipo de Licencia "
        '
        'CboTipoPrograma
        '
        Me.CboTipoPrograma.FormattingEnabled = True
        Me.CboTipoPrograma.Location = New System.Drawing.Point(259, 178)
        Me.CboTipoPrograma.Name = "CboTipoPrograma"
        Me.CboTipoPrograma.Size = New System.Drawing.Size(253, 21)
        Me.CboTipoPrograma.TabIndex = 65
        '
        'LsvProgramas
        '
        Me.LsvProgramas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdPrograma, Me.ChNombrePrograma, Me.ChTipoPrograma, Me.ChTipoLicencia})
        Me.LsvProgramas.ContextMenuStrip = Me.CmsProgramas
        Me.LsvProgramas.GridLines = True
        Me.LsvProgramas.Location = New System.Drawing.Point(6, 292)
        Me.LsvProgramas.Name = "LsvProgramas"
        Me.LsvProgramas.Size = New System.Drawing.Size(643, 200)
        Me.LsvProgramas.TabIndex = 66
        Me.LsvProgramas.UseCompatibleStateImageBehavior = False
        Me.LsvProgramas.View = System.Windows.Forms.View.Details
        '
        'ChIdPrograma
        '
        Me.ChIdPrograma.Text = "Cod. Programa"
        Me.ChIdPrograma.Width = 139
        '
        'ChNombrePrograma
        '
        Me.ChNombrePrograma.Text = "Nombre Programa"
        Me.ChNombrePrograma.Width = 179
        '
        'ChTipoPrograma
        '
        Me.ChTipoPrograma.Text = "Tipo Programa"
        Me.ChTipoPrograma.Width = 162
        '
        'ChTipoLicencia
        '
        Me.ChTipoLicencia.Text = "Tipo Licencia"
        Me.ChTipoLicencia.Width = 157
        '
        'CmsProgramas
        '
        Me.CmsProgramas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsProgramas.Name = "CmsProgramas"
        Me.CmsProgramas.Size = New System.Drawing.Size(118, 48)
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
        'PbxAgregar
        '
        Me.PbxAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxAgregar.Image = CType(resources.GetObject("PbxAgregar.Image"), System.Drawing.Image)
        Me.PbxAgregar.Location = New System.Drawing.Point(216, 521)
        Me.PbxAgregar.Name = "PbxAgregar"
        Me.PbxAgregar.Size = New System.Drawing.Size(48, 52)
        Me.PbxAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxAgregar.TabIndex = 67
        Me.PbxAgregar.TabStop = False
        '
        'TxtIdPrograma
        '
        Me.TxtIdPrograma.Enabled = False
        Me.TxtIdPrograma.Location = New System.Drawing.Point(259, 69)
        Me.TxtIdPrograma.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdPrograma.Name = "TxtIdPrograma"
        Me.TxtIdPrograma.Size = New System.Drawing.Size(253, 20)
        Me.TxtIdPrograma.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 16)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Código del Programa"
        '
        'FrmProgramas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 602)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtIdPrograma)
        Me.Controls.Add(Me.PbxAgregar)
        Me.Controls.Add(Me.LsvProgramas)
        Me.Controls.Add(Me.CboTipoPrograma)
        Me.Controls.Add(Me.CboTipoLicencia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNombrePrograma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PbxEditar)
        Me.Controls.Add(Me.PbxAtras)
        Me.Controls.Add(Me.PbxGuardar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmProgramas"
        Me.Text = "Programas"
        CType(Me.PbxEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxAtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CmsProgramas.ResumeLayout(False)
        CType(Me.PbxAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PbxEditar As PictureBox
    Friend WithEvents PbxAtras As PictureBox
    Friend WithEvents PbxGuardar As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombrePrograma As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CboTipoLicencia As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CboTipoPrograma As ComboBox
    Friend WithEvents LsvProgramas As ListView
    Friend WithEvents PbxAgregar As PictureBox
    Friend WithEvents ChIdPrograma As ColumnHeader
    Friend WithEvents ChNombrePrograma As ColumnHeader
    Friend WithEvents ChTipoPrograma As ColumnHeader
    Friend WithEvents ChTipoLicencia As ColumnHeader
    Friend WithEvents TxtIdPrograma As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CmsProgramas As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
