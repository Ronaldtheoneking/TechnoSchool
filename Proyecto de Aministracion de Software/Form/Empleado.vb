Imports System.Data.SqlClient

Public Class FrmEmpleado
    Dim Estado As Boolean

    Private Sub PbxAtras_Click(sender As Object, e As EventArgs) Handles PbxAtras.Click
        FrmPantallaPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarLsv()
    End Sub

    Private Sub CargarLsv()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Using cmd As New SqlCommand

            Try
                cn.Open()

                With cmd
                    .CommandText = "Sp_MostrarEmpleados"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                End With

                Dim MostrarEmpleados As SqlDataReader
                MostrarEmpleados = cmd.ExecuteReader
                LsvEmpleados.Items.Clear()

                While MostrarEmpleados.Read = True
                    With LsvEmpleados.Items.Add(MostrarEmpleados("IdEmpleado").ToString)
                        .SubItems.Add(MostrarEmpleados("Nombres").ToString)
                        .SubItems.Add(MostrarEmpleados("Apellidos").ToString)
                        .SubItems.Add(MostrarEmpleados("NombreUsuario").ToString)
                        .SubItems.Add(MostrarEmpleados("Contraseña").ToString)
                        .SubItems.Add(MostrarEmpleados("Sexo").ToString)
                        .SubItems.Add(MostrarEmpleados("Direccion").ToString)
                        .SubItems.Add(MostrarEmpleados("Telefono").ToString)
                        .SubItems.Add(MostrarEmpleados("Correo").ToString)


                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al listar los Empleados" + ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub CargarSexo()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarSexo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Sexo")
                CboSexo.DataSource = ds.Tables(0)
                CboSexo.DisplayMember = ds.Tables(0).Columns("Sexo").ToString
                CboSexo.ValueMember = ds.Tables(0).Columns("IdSexo").ToString
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub PbxAgregar_Click(sender As Object, e As EventArgs) Handles PbxAgregar.Click
        TxtUsuario.Focus()
        Call CargarSexo()
    End Sub

    Private Sub AgregarEmpleado()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Try
            cn.Open()

            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_AgregarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@Nombres", SqlDbType.NVarChar).Value = TxtNombre.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar).Value = TxtApellidos.Text
                    .Parameters.Add("@NombreUsuario", SqlDbType.NVarChar).Value = TxtUsuario.Text
                    .Parameters.Add("@Contraseña", SqlDbType.NVarChar).Value = TxtContraseña.Text
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CboSexo.SelectedValue
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = TxtDireccion.Text
                    .Parameters.Add("@Telefono", SqlDbType.Char).Value = TxtTelefono.Text
                    .Parameters.Add("@Correo", SqlDbType.NVarChar).Value = TxtCorreo.Text

                    .ExecuteNonQuery()
                    MsgBox("Guardado con éxito")
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub PbxGuardar_Click(sender As Object, e As EventArgs) Handles PbxGuardar.Click
        Call Validar()

        If Estado = True Then
            Call AgregarEmpleado()
            Call CargarLsv()
            Call Limpiar()
        End If

    End Sub

    Private Sub Limpiar()
        TxtIdEmpleado.Clear()
        TxtUsuario.Clear()
        TxtContraseña.Clear()
        TxtNombre.Clear()
        TxtApellidos.Clear()
        CboSexo.Text = ""
        TxtDireccion.Clear()
        TxtTelefono.Clear()
        TxtCorreo.Clear()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtIdEmpleado.Text = LsvEmpleados.FocusedItem.SubItems(0).Text
        TxtNombre.Text = LsvEmpleados.FocusedItem.SubItems(1).Text
        TxtApellidos.Text = LsvEmpleados.FocusedItem.SubItems(2).Text
        TxtUsuario.Text = LsvEmpleados.FocusedItem.SubItems(3).Text
        TxtContraseña.Text = LsvEmpleados.FocusedItem.SubItems(4).Text
        CboSexo.Text = LsvEmpleados.FocusedItem.SubItems(5).Text
        TxtDireccion.Text = LsvEmpleados.FocusedItem.SubItems(6).Text
        TxtTelefono.Text = LsvEmpleados.FocusedItem.SubItems(7).Text
        TxtCorreo.Text = LsvEmpleados.FocusedItem.SubItems(8).Text

        Call CargarSexo()
    End Sub

    Private Sub EditarEmpleado()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Try
            cn.Open()

            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_EditarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = CInt(TxtIdEmpleado.Text)
                    .Parameters.Add("@Nombres", SqlDbType.NVarChar).Value = TxtNombre.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar).Value = TxtApellidos.Text
                    .Parameters.Add("@NombreUsuario", SqlDbType.NVarChar).Value = TxtUsuario.Text
                    .Parameters.Add("@Contraseña", SqlDbType.NVarChar).Value = TxtContraseña.Text
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CboSexo.SelectedValue
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = TxtDireccion.Text
                    .Parameters.Add("@Telefono", SqlDbType.Char).Value = TxtTelefono.Text
                    .Parameters.Add("@Correo", SqlDbType.NVarChar).Value = TxtCorreo.Text

                    .ExecuteNonQuery()
                    MsgBox("Registro Moodificado con éxito")
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub PbxEditar_Click(sender As Object, e As EventArgs) Handles PbxEditar.Click
        Call EditarEmpleado()
        Call CargarLsv()
        Call Limpiar()
    End Sub

    Private Sub EliminarEmpleado()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If


        Try
            cn.Open()

            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_EliminarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = CInt(LsvEmpleados.FocusedItem.SubItems(0).Text)

                    .ExecuteNonQuery()
                    MsgBox("Registro de Empleado Eliminado con éxito")
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Esta Seguro de eliminar el registro?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call EliminarEmpleado()
            Call CargarLsv()

        End If
    End Sub

    Private Function Validar()
        If TxtUsuario.Text = Nothing Or TxtContraseña.Text = Nothing Or TxtNombre.Text = Nothing Or TxtApellidos.Text = Nothing Or CboSexo.Text = Nothing Or TxtDireccion.Text = Nothing Then
            MessageBox.Show("Solo Pueden quedar vacios el numero de telefono y el correo", "Tecno School", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Estado = False
        Else
            Estado = True
        End If

        Return Estado
    End Function

    Private Sub BuscarEmpleado()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Using cmd As New SqlCommand

            Try
                cn.Open()

                With cmd
                    .CommandText = "Sp_BuscarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                    .Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = CInt(TxtBusqueda.Text)

                End With

                Dim MostrarEmpleados As SqlDataReader
                MostrarEmpleados = cmd.ExecuteReader
                LsvEmpleados.Items.Clear()

                While MostrarEmpleados.Read = True
                    With LsvEmpleados.Items.Add(MostrarEmpleados("IdEmpleado").ToString)
                        .SubItems.Add(MostrarEmpleados("Nombres").ToString)
                        .SubItems.Add(MostrarEmpleados("Apellidos").ToString)
                        .SubItems.Add(MostrarEmpleados("NombreUsuario").ToString)
                        .SubItems.Add(MostrarEmpleados("Contraseña").ToString)
                        .SubItems.Add(MostrarEmpleados("Sexo").ToString)
                        .SubItems.Add(MostrarEmpleados("Direccion").ToString)
                        .SubItems.Add(MostrarEmpleados("Telefono").ToString)
                        .SubItems.Add(MostrarEmpleados("Correo").ToString)


                    End With
                End While

            Catch ex As Exception
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Call BuscarEmpleado()
    End Sub

    Private Sub BtnMostrarTodo_Click(sender As Object, e As EventArgs) Handles BtnMostrarTodo.Click
        Call CargarLsv()
    End Sub
End Class