Imports System.Data.SqlClient
Public Class FrmInicioSesion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using cn As New SqlConnection(My.Settings.CadenaConexion)
            Try
                cn.Open()
                Dim user As String = Replace(TxtUsuario.Text, "'", "")
                Dim pass As String = TxtContraseña.Text
                Using cmd As New SqlCommand("SELECT * FROM Empleado WHERE NombreUsuario = '" & user & "' AND Contraseña = '" & pass & "'", cn)

                    Dim reader As SqlDataReader = cmd.ExecuteReader

                    If reader.HasRows Then
                        reader.Read()
                        UsuarioActivo.NombreCompleto = String.Format("Bienvenido {0} {1}", reader.GetValue(1), reader.GetValue(2))
                        FrmPantallaPrincipal.Show()
                        Me.Hide()
                    Else
                        MsgBox("Usuario y Contrasena invalido")
                    End If
                End Using

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub
End Class
