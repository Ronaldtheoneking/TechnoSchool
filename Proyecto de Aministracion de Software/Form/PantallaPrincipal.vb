Public Class FrmPantallaPrincipal
    Private Sub LblComputadoras_Click(sender As Object, e As EventArgs) Handles LblComputadoras.Click
        FrmComputadora.Show()
        Me.Hide()
    End Sub

    Private Sub LblProgramas_Click(sender As Object, e As EventArgs) Handles LblProgramas.Click
        FrmProgramas.Show()
        Me.Hide()
    End Sub

    Private Sub LblEmpleado_Click(sender As Object, e As EventArgs) Handles LblEmpleado.Click
        FrmEmpleado.Show()
        Me.Hide()
    End Sub

    Private Sub LblProgramasComputadora_Click(sender As Object, e As EventArgs) Handles LblProgramasComputadora.Click
        FrmProgramasComputadora.Show()
        Me.Hide()
    End Sub

    Private Sub LblCerrar_Click(sender As Object, e As EventArgs) Handles LblCerrar.Click
        FrmInicioSesion.Show()
        Me.Close()
    End Sub

    Private Sub FrmPantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblNombreUsuario.Text = UsuarioActivo.NombreCompleto
    End Sub
End Class