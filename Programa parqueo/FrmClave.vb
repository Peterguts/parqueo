Public Class FrmClave
    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        If Not txtUsuario.Text.Length > 0 Then
            MsgBox("Usuario requerido.!", MsgBoxStyle.Critical, "USUARIO")
            txtUsuario.Focus()
            Exit Sub
        End If
        If Not txtClave.Text.Length > 0 Then
            MsgBox("Contraseña requerida.!", MsgBoxStyle.Critical, "CONTRASEÑA")
            txtClave.Focus()
            Exit Sub
        End If

        FrmEditar.usuario = txtUsuario.Text
        FrmEditar.clave = txtClave.Text
        Me.Close()
        If FormularioEstaAbierto("FrmEditar") Then
            FrmEditar.BringToFront()
        End If
    End Sub

    Private Sub FrmClave_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'ENTER.
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Evita que se emita el sonido de Windows al presionar Enter

            Dim currentControl As Control = Me.ActiveControl
            Me.SelectNextControl(currentControl, True, True, True, True)
        End If
    End Sub

    Private Sub FrmClave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Focus()
    End Sub
End Class