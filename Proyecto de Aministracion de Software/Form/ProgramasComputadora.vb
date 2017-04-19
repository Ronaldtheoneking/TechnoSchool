Imports System.Data.SqlClient

Public Class FrmProgramasComputadora
    Dim Estado As Boolean

    Private Sub PbxAtras_Click(sender As Object, e As EventArgs) Handles PbxAtras.Click
        FrmPantallaPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub FrmProgramasComputadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarComputadora()
    End Sub

    Private Sub CargarComputadora()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarComputadoras"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "IdComputadora")
                CboComputadora.DataSource = ds.Tables(0)
                CboComputadora.DisplayMember = ds.Tables(0).Columns("IdComputadora").ToString
                CboComputadora.ValueMember = ds.Tables(0).Columns("IdComputadora").ToString
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CboComputadora_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboComputadora.SelectionChangeCommitted
        Call CargarLsv()
        Call CargarLsvComputadora()
    End Sub

    Private Sub CargarLsv()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Using cmd As New SqlCommand

            Try
                cn.Open()

                With cmd
                    .CommandText = "Sp_MostrarProgramasComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                    .Parameters.Add("@IdComputadora", SqlDbType.Int).Value = CboComputadora.SelectedValue

                End With

                Dim MostrarProgramas As SqlDataReader
                MostrarProgramas = cmd.ExecuteReader
                LsvProgramaComputadora.Items.Clear()

                While MostrarProgramas.Read = True
                    With LsvProgramaComputadora.Items.Add(MostrarProgramas("IdProgramaComputadora").ToString)
                        .SubItems.Add(MostrarProgramas("IdPrograma").ToString)
                        .SubItems.Add(MostrarProgramas("NombrePrograma").ToString)
                        .SubItems.Add(MostrarProgramas("TipoPrograma").ToString)
                        .SubItems.Add(MostrarProgramas("TipoLicencia").ToString)
                        .SubItems.Add(MostrarProgramas("NombreUsuario").ToString)
                        .SubItems.Add(MostrarProgramas("FechaInstalacion").ToString)
                        .SubItems.Add(MostrarProgramas("FechaVencimientoLicencia").ToString)


                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al listar los programas" + ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub CargarLsvComputadora()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Using cmd As New SqlCommand

            Try
                cn.Open()

                With cmd
                    .CommandText = "Sp_MostrarIdComputadoras"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                    .Parameters.Add("@IdComputadora", SqlDbType.Int).Value = CboComputadora.SelectedValue

                End With

                Dim MostrarComputadoras As SqlDataReader
                MostrarComputadoras = cmd.ExecuteReader
                LsvComputadoras.Items.Clear()

                While MostrarComputadoras.Read = True
                    With LsvComputadoras.Items.Add(MostrarComputadoras("IdComputadora").ToString)
                        .SubItems.Add(MostrarComputadoras("Marca").ToString)
                        .SubItems.Add(MostrarComputadoras("Modelo").ToString)
                        .SubItems.Add(MostrarComputadoras("CapacidadMemoria").ToString)
                        .SubItems.Add(MostrarComputadoras("CapDiscoDuro").ToString)
                        .SubItems.Add(MostrarComputadoras("TarjetaVideo").ToString)
                        .SubItems.Add(MostrarComputadoras("Capacidad").ToString)
                        .SubItems.Add(MostrarComputadoras("UnidadOptica").ToString)
                        .SubItems.Add(MostrarComputadoras("Disponible").ToString)


                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al listar las Computadoras" + ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub PbxAgregar_Click(sender As Object, e As EventArgs) Handles PbxAgregar.Click
        CboComputadora.Enabled = False
        Call CargarProgramas()
        Call CargarEmpleado()
    End Sub

    Private Sub CargarProgramas()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarProgramas"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "NombrePrograma")
                CboPrograma.DataSource = ds.Tables(0)
                CboPrograma.DisplayMember = ds.Tables(0).Columns("NombrePrograma").ToString
                CboPrograma.ValueMember = ds.Tables(0).Columns("IdPrograma").ToString
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CargarEmpleado()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarEmpleados"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "NombreUsuario")
                CboEmpleado.DataSource = ds.Tables(0)
                CboEmpleado.DisplayMember = ds.Tables(0).Columns("NombreUsuario").ToString
                CboEmpleado.ValueMember = ds.Tables(0).Columns("IdEmpleado").ToString
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub AgregarProgramaComputadora()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Try
            cn.Open()

            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_AgregarProgramaComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@IdPrograma", SqlDbType.Int).Value = CInt(CboPrograma.SelectedValue)
                    .Parameters.Add("@IdComputadora", SqlDbType.Int).Value = CInt(CboComputadora.SelectedValue)
                    .Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = CInt(CboEmpleado.SelectedValue)
                    .Parameters.Add("@FechaInstalacion", SqlDbType.Date).Value = dtpFechaInstalacion.Text
                    .Parameters.Add("@FechaVencimientoLicencia", SqlDbType.Date).Value = DtpFechaVencimiento.Text


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
            Call AgregarProgramaComputadora()
            Call CargarLsv()
            Call Limpiar()
        End If

    End Sub

    Private Sub Limpiar()
        CboPrograma.Text = ""
        CboEmpleado.Text = ""
        TxtIdProgComputadora.Clear()
    End Sub

    Private Sub BtnCambiar_Click(sender As Object, e As EventArgs) Handles BtnCambiar.Click
        CboComputadora.Enabled = True
        Call Limpiar()
        TxtIdProgComputadora.Text = ""
    End Sub

    Private Sub PbxEditar_Click(sender As Object, e As EventArgs) Handles PbxEditar.Click
        Call EditarProgramaComputadora()
        Call Limpiar()
        Call CargarLsv()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call CargarProgramas()
        Call CargarEmpleado()

        TxtIdProgComputadora.Text = LsvProgramaComputadora.FocusedItem.SubItems(0).Text
        CboPrograma.Text = LsvProgramaComputadora.FocusedItem.SubItems(2).Text
        CboEmpleado.Text = LsvProgramaComputadora.FocusedItem.SubItems(5).Text
        dtpFechaInstalacion.Text = LsvProgramaComputadora.FocusedItem.SubItems(6).Text
        DtpFechaVencimiento.Text = LsvProgramaComputadora.FocusedItem.SubItems(7).Text
    End Sub

    Private Sub EditarProgramaComputadora()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Try
            cn.Open()

            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_EditarProgramaComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@IdProgramaComputadora", SqlDbType.Int).Value = CInt(TxtIdProgComputadora.Text)
                    .Parameters.Add("@IdPrograma", SqlDbType.Int).Value = CInt(CboPrograma.SelectedValue)
                    .Parameters.Add("@IdComputadora", SqlDbType.Int).Value = CInt(CboComputadora.SelectedValue)
                    .Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = CInt(CboEmpleado.SelectedValue)
                    .Parameters.Add("@FechaInstalacion", SqlDbType.Date).Value = dtpFechaInstalacion.Text
                    .Parameters.Add("@FechaVencimientoLicencia", SqlDbType.Date).Value = DtpFechaVencimiento.Text


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

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Esta Seguro de eliminar el registro?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call EliminarProgramaComputadora()
            Call CargarLsv()
        End If
    End Sub

    Private Sub EliminarProgramaComputadora()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If


        Try
            cn.Open()

            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_EliminarProgramaComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@IdProgramaComputadora", SqlDbType.Int).Value = CInt(LsvProgramaComputadora.FocusedItem.SubItems(0).Text)

                    .ExecuteNonQuery()
                    MsgBox("Registro Eliminado con éxito")
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Function Validar()
        If CboComputadora.Text = Nothing Or CboEmpleado.Text = Nothing Or CboPrograma.Text = Nothing Then
            MessageBox.Show("Seleccione todas las opciones para guardar cambios", "Tecno School", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Estado = False
        Else
            Estado = True
        End If

        Return Estado
    End Function

End Class