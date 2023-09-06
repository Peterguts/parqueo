Imports System.Runtime.InteropServices

Public Class FrmUsuario
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not cnx.State = 1 Then
            If Not conectar() Then
                MsgBox("Error al intentar conecar la base de datos.!", MsgBoxStyle.Critical, "ERROR")
            End If
        End If
    End Sub

    'BOTONES
    Private Sub NuevoF1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoF1ToolStripMenuItem.Click
        txtUsuario.Clear()
        txtClave.Clear()
        txtNombre.Clear()
        txtPermiso.Text = ""
        txtUsuario.Focus()
    End Sub
    Private Sub GuardarF2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarF2ToolStripMenuItem.Click
        If Not txtUsuario.Text.Length > 0 Then Exit Sub
        If Not txtPermiso.Text.Length > 0 Then Exit Sub

        Try
            Dim rs As New ADODB.Recordset
            rs.Open("Select * from usuario where login = '" & txtUsuario.Text & "'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
            If rs.EOF Then
                If MsgBox("¿Desea agregar nuevo usuario?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "USUARIO NUEVO") = vbYes Then
                    rs.AddNew()
                    rs.Fields(0).Value = txtUsuario.Text
                    rs.Fields(1).Value = txtNombre.Text
                    rs.Fields(2).Value = txtClave.Text
                    rs.Fields(3).Value = txtPermiso.Text
                    rs.Update()
                    MsgBox("Usuario agregado correctamente.!", MsgBoxStyle.Information, "USUARIO NUEVO")
                End If
            Else
                If MsgBox("¿Desea actualizar usuario '" & txtUsuario.Text & "'?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "USUARIO NUEVO") = vbYes Then
                    rs.Fields(1).Value = txtNombre.Text
                    rs.Fields(2).Value = txtClave.Text
                    rs.Fields(3).Value = txtPermiso.Text
                    rs.Update()
                    MsgBox("Usuario actualizado correctamente.!", MsgBoxStyle.Information, "USUARIO NUEVO")
                End If
            End If
                If rs.State = 1 Then rs.Close()

        Catch ex As Exception
            errores("Boton Guardar", Me.Name, ex.Message)
        End Try
    End Sub
    Private Sub BuscarF3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarF3ToolStripMenuItem.Click
        With FrmBuscar
            .LblBuscarPor.Text = "Buscar por nombre de usuario:"
            .tipo = "USUARIO"
            .TxtBuscar.Focus()
            .Show()
        End With
    End Sub
    Private Sub EliminarF4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarF4ToolStripMenuItem.Click
        Try
            Dim rs As New ADODB.Recordset
            rs.Open("Select * from usuario where login = '" & txtUsuario.Text & "'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not rs.EOF Then
                If MsgBox("¿Desea eliminar usuario '" & txtUsuario.Text & "'?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "ELIMINAR USUARIO") = vbYes Then
                    Dim i As Integer = 0
                    cnx.Execute("Delete from usuario where login = '" & txtUsuario.Text & "'", i)
                    If i > 0 Then
                        MsgBox("Usuario eliminado correctamente.!", MsgBoxStyle.Information, "USUARIO ELIMINADO")
                        NuevoF1ToolStripMenuItem.PerformClick()
                    End If
                End If
            End If
            If rs.State = 1 Then rs.Close()
        Catch ex As Exception
            errores("Boton eliminar", Me.Name, ex.Message)
        End Try
    End Sub
    Private Sub SalirF12ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirF12ToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class