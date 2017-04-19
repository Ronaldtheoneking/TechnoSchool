Imports System.Data.SqlClient

Public Class FrmProgramas
    Dim Estado As Boolean

    Private Sub PbxAtras_Click(sender As Object, e As EventArgs) Handles PbxAtras.Click
        FrmPantallaPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub FrmProgramas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarLsv()
    End Sub

    Private Sub PbxAgregar_Click(sender As Object, e As EventArgs) Handles PbxAgregar.Click
        Call CargarTipoPrograma()
        Call CargarTipoLicencia()
        TxtNombrePrograma.Focus()
    End Sub

    Private Sub CargarTipoPrograma()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarTipoPrograma"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoPrograma")
                CboTipoPrograma.DataSource = ds.Tables(0)
                CboTipoPrograma.DisplayMember = ds.Tables(0).Columns("TipoPrograma").ToString
                CboTipoPrograma.ValueMember = ds.Tables(0).Columns("IdTipoPrograma").ToString
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CargarTipoLicencia()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarTipolicencia"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoLicencia")
                CboTipoLicencia.DataSource = ds.Tables(0)
                CboTipoLicencia.DisplayMember = ds.Tables(0).Columns("TipoLicencia").ToString
                CboTipoLicencia.ValueMember = ds.Tables(0).Columns("IdTipoLicencia").ToString
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CargarLsv()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Using cmd As New SqlCommand

            Try
                cn.Open()

                With cmd
                    .CommandText = "Sp_MostrarProgramas"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                End With

                Dim MostrarProgramas As SqlDataReader
                MostrarProgramas = cmd.ExecuteReader
                LsvProgramas.Items.Clear()

                While MostrarProgramas.Read = True
                    With LsvProgramas.Items.Add(MostrarProgramas("IdPrograma").ToString)
                        .SubItems.Add(MostrarProgramas("NombrePrograma").ToString)
                        .SubItems.Add(MostrarProgramas("TipoPrograma").ToString)
                        .SubItems.Add(MostrarProgramas("TipoLicencia").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al listar los Programas" + ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub PbxGuardar_Click(sender As Object, e As EventArgs) Handles PbxGuardar.Click
        Call Validar()

        If Estado = True Then
            Call AgregarPrograma()
            Call Limpiar()
            Call CargarLsv()
        End If

    End Sub

    Private Sub AgregarPrograma()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Try
            cn.Open()

            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_AgregarPrograma"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@NombrePrograma", SqlDbType.NVarChar).Value = TxtNombrePrograma.Text
                    .Parameters.Add("@IdTipoPrograma", SqlDbType.NVarChar).Value = CboTipoPrograma.SelectedValue
                    .Parameters.Add("@IdTipoLicencia", SqlDbType.NVarChar).Value = CboTipoLicencia.SelectedValue

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

    Private Sub Limpiar()
        TxtIdPrograma.Clear()
        TxtNombrePrograma.Clear()
        CboTipoPrograma.Text = ""
        CboTipoLicencia.Text = ""
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call CargarTipoPrograma()
        Call CargarTipoLicencia()

        TxtIdPrograma.Text = LsvProgramas.FocusedItem.SubItems(0).Text
        TxtNombrePrograma.Text = LsvProgramas.FocusedItem.SubItems(1).Text
        CboTipoPrograma.Text = LsvProgramas.FocusedItem.SubItems(2).Text
        CboTipoLicencia.Text = LsvProgramas.FocusedItem.SubItems(3).Text
    End Sub

    Private Sub PbxEditar_Click(sender As Object, e As EventArgs) Handles PbxEditar.Click
        Call EditarPrograma()
        Call Limpiar()
        Call CargarLsv()
    End Sub

    Private Sub EditarPrograma()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Try
            cn.Open()

            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_EditarPrograma"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@IdPrograma", SqlDbType.Int).Value = CInt(TxtIdPrograma.Text)
                    .Parameters.Add("@NombrePrograma", SqlDbType.NVarChar).Value = TxtNombrePrograma.Text
                    .Parameters.Add("@IdTipoPrograma", SqlDbType.NVarChar).Value = CboTipoPrograma.SelectedValue
                    .Parameters.Add("@IdTipoLicencia", SqlDbType.NVarChar).Value = CboTipoLicencia.SelectedValue

                    .ExecuteNonQuery()
                    MsgBox("Registro modificado con éxito")
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
            Call EliminarPrograma()
            Call CargarLsv()
        End If
    End Sub

    Private Sub EliminarPrograma()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If


        Try
            cn.Open()

            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_EliminarPrograma"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@IdPrograma", SqlDbType.Int).Value = CInt(LsvProgramas.FocusedItem.SubItems(0).Text)

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
        If TxtNombrePrograma.Text = Nothing Or CboTipoPrograma.Text = Nothing Or CboTipoLicencia.Text = Nothing Then
            MessageBox.Show("Seleccione todas las opciones para guardar cambios", "Tecno School", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Estado = False
        Else
            Estado = True
        End If

        Return Estado
    End Function

    Public Sub BuscarPrograma()

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Using cmd As New SqlCommand
            Try
                cn.Open()
                With cmd
                    .CommandText = "Sp_BuscarPrograma"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                    .Parameters.Add("@IdPrograma", SqlDbType.Int).Value = CInt(TxtBusqueda.Text)
                End With

                Dim MostrarPrograma As SqlDataReader
                MostrarPrograma = cmd.ExecuteReader()
                LsvProgramas.Items.Clear()

                While MostrarPrograma.Read = True
                    With LsvProgramas.Items.Add(MostrarPrograma("IdPrograma").ToString)
                        .SubItems.Add(MostrarPrograma("NombrePrograma").ToString)
                        .SubItems.Add(MostrarPrograma("TipoPrograma").ToString)
                        .SubItems.Add(MostrarPrograma("TipoLicencia").ToString)

                    End With

                End While
            Catch ex As Exception
            Finally
                cn.Close()


            End Try
        End Using
    End Sub


    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Call BuscarPrograma()
    End Sub

    Private Sub BtnMostrarTodo_Click(sender As Object, e As EventArgs) Handles BtnMostrarTodo.Click
        Call CargarLsv()
    End Sub
End Class