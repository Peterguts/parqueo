Public Class FrmSesion
    Private Sub FrmSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not conectar() Then
            MsgBox("Error al intentar conecar la base de datos.!", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    'BOTON
    Private Sub btnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click
        If Not txtUsuario.Text.Length > 0 Then Exit Sub
        If Not txtClave.Text.Length > 0 Then Exit Sub

        Try
            If Not cnx.State = 1 Then
                If Not conectar() Then
                    MsgBox("Error al intentar conecar la base de datos.!", MsgBoxStyle.Critical, "ERROR")
                    Exit Sub
                End If
            End If

            Dim rs As New ADODB.Recordset
            rs.Open("Select * from usuario where login = '" & txtUsuario.Text & "'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not rs.EOF Then
                If rs.Fields("clave").Value.ToString.Trim = txtClave.Text.Trim Then
                    usuId = rs.Fields("login").Value.ToString
                    permiso = rs.Fields("tipo").Value.ToString.ToUpper
                    FrmSplash.LblUsuario.Text = rs.Fields("nombre").Value
                    FrmSplash.Show()
                    Me.Hide()
                Else
                    MsgBox("Contraseña incorrecta.!", MsgBoxStyle.Critical, "CONTRASEÑA")
                End If
            Else
                    MsgBox("Usuario no encontrado.!", MsgBoxStyle.Critical, "USUARIO")
            End If
        Catch ex As Exception
            errores("Inicio de sesion.", Me.Name, ex.Message)
        End Try
    End Sub

    'EVENTOS
    '-----------------------------------------------------------------------------------------------
    Private Sub txtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        'If txtClave.Text = "CREAR DB" Then
        '    If crearBase() Then
        '        MsgBox("Base creada correctamente.!", MsgBoxStyle.Information, "CREAR DB")
        '    End If
        'End If
        'If txtClave.Text = "INSERTAR USUARIO" Then
        '    If insertar("Insert into usuario values ('admin', 'Administrador', 'admin12345678', 'ADMIN')") Then
        '        MsgBox("Se guardo usuario.!", MsgBoxStyle.Information, "INSERTAR")
        '    End If
        'End If
        'If txtClave.Text = "INSERTAR PRECIO" Then
        '    If insertar("Insert into precio values (10.00, 5.00)") Then
        '        MsgBox("Se guardo precio.!", MsgBoxStyle.Information, "INSERTAR")
        '    End If
        'End If
        'If txtClave.Text = "INSERTAR ESPACIO" Then
        '    If insertar("Insert into espacio values (10, 10, 10, 10)") Then
        '        MsgBox("Se guardo espacio.!", MsgBoxStyle.Information, "INSERTAR")
        '    End If
        'End If
    End Sub
    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) And txtUsuario.Text.Length > 0 Then
            txtClave.Focus()
        End If
    End Sub
    Private Sub txtClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClave.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) And txtClave.Text.Length > 0 Then
            btnAcceder.PerformClick()
        End If
    End Sub
End Class
