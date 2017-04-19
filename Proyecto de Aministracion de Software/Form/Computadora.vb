Imports System.Data.SqlClient

Public Class FrmComputadora
    Dim Estado As Boolean

    Private Sub PbxAtras_Click(sender As Object, e As EventArgs) Handles PbxAtras.Click
        FrmPantallaPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub FrmComputadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarDgv()
    End Sub

    Private Sub PbxAgregar_Click(sender As Object, e As EventArgs) Handles PbxAgregar.Click

        Call CargarMarca()
        Call CargarCapMemoriaRam()
        Call CargarTarjetaVideo()
        Call CargarCapacidad()
        Call CargarTipoUnidadOptica()
    End Sub

    Private Sub CargarDgv()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Using cmd As New SqlCommand

            Try
                cn.Open()

                With cmd
                    .CommandText = "Sp_MostrarComputadoras"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

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

    Private Sub CargarModelo()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarModelo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                    .Parameters.Add("@IdMarca", SqlDbType.Int).Value = CboMarca.SelectedValue

                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Modelo")
                CboModelo.DataSource = ds.Tables(0)
                CboModelo.DisplayMember = ds.Tables(0).Columns("Modelo").ToString
                CboModelo.ValueMember = ds.Tables(0).Columns("IdModelo").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CargarMarca()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarMarca"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Marca")
                CboMarca.DataSource = ds.Tables(0)
                CboMarca.DisplayMember = ds.Tables(0).Columns("Marca").ToString
                CboMarca.ValueMember = ds.Tables(0).Columns("IdMarca").ToString
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CargarCapMemoriaRam()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarCapMemoriaRam"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "CapacidadMemoria")
                CboMemoriaRam.DataSource = ds.Tables(0)
                CboMemoriaRam.DisplayMember = ds.Tables(0).Columns("CapacidadMemoria").ToString
                CboMemoriaRam.ValueMember = ds.Tables(0).Columns("IdCapMemoriaRam").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CargarTarjetaVideo()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarTarjetaVideo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TarjetaVideo")
                CboTarjetaVideo.DataSource = ds.Tables(0)
                CboTarjetaVideo.DisplayMember = ds.Tables(0).Columns("TarjetaVideo").ToString
                CboTarjetaVideo.ValueMember = ds.Tables(0).Columns("IdTarjetaVideo").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CargarCapacidad()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarTarjetaVideo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Capacidad")
                CboCapacidad.DataSource = ds.Tables(0)
                CboCapacidad.DisplayMember = ds.Tables(0).Columns("Capacidad").ToString
                CboCapacidad.ValueMember = ds.Tables(0).Columns("IdTarjetaVideo").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CargarTipoUnidadOptica()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarTipoUnidadOptica"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "UnidadOptica")
                CboUnidadOptica.DataSource = ds.Tables(0)
                CboUnidadOptica.DisplayMember = ds.Tables(0).Columns("UnidadOptica").ToString
                CboUnidadOptica.ValueMember = ds.Tables(0).Columns("IdTipoUnidadOptica").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub PbxGuardar_Click(sender As Object, e As EventArgs) Handles PbxGuardar.Click
        Call Validar()

        If Estado = True Then
            Call AgregarComputadora()
            Call CargarDgv()
            Call Limpiar()
        End If

    End Sub

    Private Sub AgregarComputadora()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Try
            cn.Open()

            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_AgregarComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@IdModelo", SqlDbType.Int).Value = CboModelo.SelectedValue
                    .Parameters.Add("@IdCapMemoriaRam", SqlDbType.Int).Value = CboMemoriaRam.SelectedValue
                    .Parameters.Add("@CapDiscoDuro", SqlDbType.NVarChar).Value = TxtDiscoDuro.Text
                    .Parameters.Add("@IdTarjetaVideo", SqlDbType.Int).Value = CboTarjetaVideo.SelectedValue
                    .Parameters.Add("@IdTipoUnidadOptica", SqlDbType.Int).Value = CboUnidadOptica.SelectedValue
                    .Parameters.Add("@Disponible", SqlDbType.Bit).Value = ChkDisponible.CheckState

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

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TxtNumComputadora.Text = LsvComputadoras.FocusedItem.SubItems(0).Text
        CboMarca.Text = LsvComputadoras.FocusedItem.SubItems(1).Text
        CboModelo.Text = LsvComputadoras.FocusedItem.SubItems(2).Text
        CboMemoriaRam.Text = LsvComputadoras.FocusedItem.SubItems(3).Text
        TxtDiscoDuro.Text = LsvComputadoras.FocusedItem.SubItems(4).Text
        CboTarjetaVideo.Text = LsvComputadoras.FocusedItem.SubItems(5).Text
        CboCapacidad.Text = LsvComputadoras.FocusedItem.SubItems(6).Text
        CboUnidadOptica.Text = LsvComputadoras.FocusedItem.SubItems(7).Text

        Call CargarMarca()
        Call CargarCapMemoriaRam()
        Call CargarTarjetaVideo()
        Call CargarCapacidad()
        Call CargarTipoUnidadOptica()

    End Sub

    Private Sub EditarComputadora()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If


        Try
            cn.Open()

            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_EditarComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@IdComputadora", SqlDbType.Int).Value = CInt(TxtNumComputadora.Text)
                    .Parameters.Add("@IdModelo", SqlDbType.Int).Value = CboModelo.SelectedValue
                    .Parameters.Add("@IdCapMemoriaRam", SqlDbType.Int).Value = CboMemoriaRam.SelectedValue
                    .Parameters.Add("@CapDiscoDuro", SqlDbType.NVarChar).Value = TxtDiscoDuro.Text
                    .Parameters.Add("@IdTarjetaVideo", SqlDbType.Int).Value = CboTarjetaVideo.SelectedValue
                    .Parameters.Add("@IdTipoUnidadOptica", SqlDbType.Int).Value = CboUnidadOptica.SelectedValue
                    .Parameters.Add("@Disponible", SqlDbType.Bit).Value = ChkDisponible.CheckState

                    .ExecuteNonQuery()
                    MsgBox("Informacion de la computadora actualizada con éxito")
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Limpiar()
        CboMarca.Text = ""
        CboModelo.Text = ""
        CboMemoriaRam.Text = ""
        TxtDiscoDuro.Clear()
        CboTarjetaVideo.Text = ""
        CboCapacidad.Text = ""
        CboUnidadOptica.Text = ""
        ChkDisponible.CheckState = False
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If MessageBox.Show("¿Esta Seguro de eliminar el registro?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call EliminarComputadora()
            Call CargarDgv()

        End If
    End Sub

    Private Sub EliminarComputadora()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If


        Try
            cn.Open()

            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_EliminarComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@IdComputadora", SqlDbType.Int).Value = CInt(LsvComputadoras.FocusedItem.SubItems(0).Text)

                    .ExecuteNonQuery()
                    MsgBox("Registro de Computadora Eliminado con éxito")
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub PbxEditar_Click(sender As Object, e As EventArgs) Handles PbxEditar.Click
        Call EditarComputadora()
        Call CargarDgv()
        Call Limpiar()
    End Sub

    Private Sub CboMarca_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CboMarca.SelectionChangeCommitted
        Call CargarModelo()
    End Sub

    Private Function Validar()

        If CboMarca.Text = Nothing Or CboModelo.Text = Nothing Or CboMemoriaRam.Text = Nothing Or TxtDiscoDuro.Text = Nothing Or CboTarjetaVideo.Text = Nothing Or CboCapacidad.Text = Nothing Or CboTarjetaVideo.Text = Nothing Then
            MessageBox.Show("Seleccione todas las opciones para guardar cambios", "Tecno School", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Estado = False
        Else
            Estado = True
        End If

        Return Estado
    End Function

    Private Sub BuscarComputadora()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Using cmd As New SqlCommand

            Try
                cn.Open()

                With cmd
                    .CommandText = "Sp_BuscarComputadora"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                    .Parameters.Add("@IdComputadora", SqlDbType.Int).Value = CInt(TxtBusqueda.Text)

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
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Call BuscarComputadora()
    End Sub

    Private Sub BtnMostrarTodo_Click(sender As Object, e As EventArgs) Handles BtnMostrarTodo.Click
        Call CargarDgv()
    End Sub
End Class