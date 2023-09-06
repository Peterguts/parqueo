Public Class FrmCobro
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        FrmTicket.band = True
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        FrmTicket.band = False
        Me.Close()
    End Sub

    Private Sub FrmCobro_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            FrmTicket.band = False
            Me.Close()
        End If

        If e.KeyCode = Keys.A Then
            FrmTicket.band = True
            Me.Close()
        End If
    End Sub
End Class