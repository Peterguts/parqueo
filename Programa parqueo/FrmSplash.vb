Public Class FrmSplash
    Private Sub FrmSplash_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        FrmPrincipal.Show()
        Me.Close()
    End Sub
End Class