Imports System.Data.SqlClient

Public Class FrmComputadora
    'Dim cmd As New SqlCommand
    'Dim dt As DataTable
    'Dim da As New SqlDataAdapter

    Private Sub PbxAtras_Click(sender As Object, e As EventArgs) Handles PbxAtras.Click
        FrmPantallaPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub FrmComputadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarDgv()
    End Sub

    Private Sub PbxAgregar_Click(sender As Object, e As EventArgs) Handles PbxAgregar.Click
        Call CargarMarca()
        Call CargarModelo()
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
        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarModelo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Modelo")
                CboModelo.DataSource = ds.Tables(0)
                CboModelo.DisplayMember = ds.Tables(0).Columns("Modelo").ToString
                CboModelo.ValueMember = ds.Tables(0).Columns("IdMarca").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CargarMarca()
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
        Call AgregarComputadora()
        Call CargarDgv()
    End Sub

    Private Sub AgregarComputadora()
        cn.Open()
        Try
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

End Class