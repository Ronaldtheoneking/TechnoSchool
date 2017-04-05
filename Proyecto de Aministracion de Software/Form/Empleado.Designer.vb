<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpleado))
        Me.PbxEditar = New System.Windows.Forms.PictureBox()
        Me.PbxAtras = New System.Windows.Forms.PictureBox()
        Me.PbxGuardar = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CboSexo = New System.Windows.Forms.ComboBox()
        Me.LsvEmpleados = New System.Windows.Forms.ListView()
        Me.ChNombres = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellidos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChContraseña = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSexo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCorreo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChIdEmpleado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TxtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PbxAgregar = New System.Windows.Forms.PictureBox()
        Me.CmsEmpleado = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PbxEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxAtras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PbxAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsEmpleado.SuspendLayout()
        Me.SuspendLayout()
        '
        'PbxEditar
        '
        Me.PbxEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxEditar.Image = CType(resources.GetObject("PbxEditar.Image"), System.Drawing.Image)
        Me.PbxEditar.Location = New System.Drawing.Point(351, 520)
        Me.PbxEditar.Name = "PbxEditar"
        Me.PbxEditar.Size = New System.Drawing.Size(48, 52)
        Me.PbxEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxEditar.TabIndex = 40
        Me.PbxEditar.TabStop = False
        '
        'PbxAtras
        '
        Me.PbxAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxAtras.Image = CType(resources.GetObject("PbxAtras.Image"), System.Drawing.Image)
        Me.PbxAtras.Location = New System.Drawing.Point(498, 525)
        Me.PbxAtras.Name = "PbxAtras"
        Me.PbxAtras.Size = New System.Drawing.Size(43, 47)
        Me.PbxAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxAtras.TabIndex = 39
        Me.PbxAtras.TabStop = False
        '
        'PbxGuardar
        '
        Me.PbxGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxGuardar.Image = CType(resources.GetObject("PbxGuardar.Image"), System.Drawing.Image)
        Me.PbxGuardar.Location = New System.Drawing.Point(91, 522)
        Me.PbxGuardar.Name = "PbxGuardar"
        Me.PbxGuardar.Size = New System.Drawing.Size(43, 47)
        Me.PbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxGuardar.TabIndex = 38
        Me.PbxGuardar.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(-1, 539)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 62)
        Me.Panel2.TabIndex = 36
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 62)
        Me.Panel1.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(265, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 27)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Empleado"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(293, 107)
        Me.TxtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(157, 20)
        Me.TxtUsuario.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 108)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Usuario"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(293, 142)
        Me.TxtContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(157, 20)
        Me.TxtContraseña.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(186, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Contraseña"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(136, 178)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(157, 20)
        Me.TxtNombre.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 182)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Nombre"
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(136, 225)
        Me.TxtApellidos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(157, 20)
        Me.TxtApellidos.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 229)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(66, 283)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 16)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Sexo"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(449, 279)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(157, 20)
        Me.TxtCorreo.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(361, 283)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Correo"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(449, 225)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(157, 20)
        Me.TxtTelefono.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(346, 229)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 16)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Telefono"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(449, 178)
        Me.TxtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(157, 20)
        Me.TxtDireccion.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(342, 182)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 16)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Dirección"
        '
        'CboSexo
        '
        Me.CboSexo.FormattingEnabled = True
        Me.CboSexo.Location = New System.Drawing.Point(136, 278)
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Size = New System.Drawing.Size(157, 21)
        Me.CboSexo.TabIndex = 62
        '
        'LsvEmpleados
        '
        Me.LsvEmpleados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdEmpleado, Me.ChNombres, Me.ChApellidos, Me.ChUsuario, Me.ChContraseña, Me.ChSexo, Me.ChDireccion, Me.ChTelefono, Me.ChCorreo})
        Me.LsvEmpleados.ContextMenuStrip = Me.CmsEmpleado
        Me.LsvEmpleados.Location = New System.Drawing.Point(6, 311)
        Me.LsvEmpleados.Name = "LsvEmpleados"
        Me.LsvEmpleados.Size = New System.Drawing.Size(643, 200)
        Me.LsvEmpleados.TabIndex = 63
        Me.LsvEmpleados.UseCompatibleStateImageBehavior = False
        Me.LsvEmpleados.View = System.Windows.Forms.View.Details
        '
        'ChNombres
        '
        Me.ChNombres.Text = "Nombres"
        Me.ChNombres.Width = 90
        '
        'ChApellidos
        '
        Me.ChApellidos.Text = "Apellidos"
        Me.ChApellidos.Width = 77
        '
        'ChUsuario
        '
        Me.ChUsuario.Text = "Usuario"
        '
        'ChContraseña
        '
        Me.ChContraseña.Text = "Contraseña"
        Me.ChContraseña.Width = 68
        '
        'ChSexo
        '
        Me.ChSexo.Text = "Sexo"
        '
        'ChDireccion
        '
        Me.ChDireccion.Text = "Direccion"
        '
        'ChTelefono
        '
        Me.ChTelefono.Text = "Telefono"
        '
        'ChCorreo
        '
        Me.ChCorreo.Text = "Correo"
        Me.ChCorreo.Width = 100
        '
        'ChIdEmpleado
        '
        Me.ChIdEmpleado.Text = "IdEmpleado"
        '
        'TxtIdEmpleado
        '
        Me.TxtIdEmpleado.Enabled = False
        Me.TxtIdEmpleado.Location = New System.Drawing.Point(293, 70)
        Me.TxtIdEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdEmpleado.Name = "TxtIdEmpleado"
        Me.TxtIdEmpleado.Size = New System.Drawing.Size(157, 20)
        Me.TxtIdEmpleado.TabIndex = 64
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(157, 71)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 16)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Cod. Empleado"
        '
        'PbxAgregar
        '
        Me.PbxAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxAgregar.Image = CType(resources.GetObject("PbxAgregar.Image"), System.Drawing.Image)
        Me.PbxAgregar.Location = New System.Drawing.Point(215, 520)
        Me.PbxAgregar.Name = "PbxAgregar"
        Me.PbxAgregar.Size = New System.Drawing.Size(48, 52)
        Me.PbxAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxAgregar.TabIndex = 66
        Me.PbxAgregar.TabStop = False
        '
        'CmsEmpleado
        '
        Me.CmsEmpleado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsEmpleado.Name = "CmsEmpleado"
        Me.CmsEmpleado.Size = New System.Drawing.Size(153, 70)
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
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 602)
        Me.Controls.Add(Me.PbxAgregar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtIdEmpleado)
        Me.Controls.Add(Me.LsvEmpleados)
        Me.Controls.Add(Me.CboSexo)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PbxEditar)
        Me.Controls.Add(Me.PbxAtras)
        Me.Controls.Add(Me.PbxGuardar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmEmpleado"
        Me.Text = "Empleado"
        CType(Me.PbxEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxAtras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PbxAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsEmpleado.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PbxEditar As PictureBox
    Friend WithEvents PbxAtras As PictureBox
    Friend WithEvents PbxGuardar As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CboSexo As ComboBox
    Friend WithEvents LsvEmpleados As ListView
    Friend WithEvents ChIdEmpleado As ColumnHeader
    Friend WithEvents ChNombres As ColumnHeader
    Friend WithEvents ChApellidos As ColumnHeader
    Friend WithEvents ChUsuario As ColumnHeader
    Friend WithEvents ChContraseña As ColumnHeader
    Friend WithEvents ChSexo As ColumnHeader
    Friend WithEvents ChDireccion As ColumnHeader
    Friend WithEvents ChTelefono As ColumnHeader
    Friend WithEvents ChCorreo As ColumnHeader
    Friend WithEvents TxtIdEmpleado As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PbxAgregar As PictureBox
    Friend WithEvents CmsEmpleado As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
