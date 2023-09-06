Imports System.Security.Cryptography

Public Class FrmPrecio
    Private Sub FrmPrecio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not cnx.State = 1 Then
            If Not conectar() Then
                MsgBox("Error al intentar conecar la base de datos.!", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            End If
        End If

        Try
            Dim rs As New ADODB.Recordset
            rs.Open("Select * from precio where vehiculo = '" & txtVehiculo.Text & "'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not rs.EOF Then
                txtMediaHora.Text = rs.Fields(1).Value
                txtHora.Text = rs.Fields(0).Value
                txtMediaHora.Focus()
            End If
            If rs.State = 1 Then rs.Close()

        Catch ex As Exception
            errores("Buscar precio", Me.Name, ex.Message)
        End Try
    End Sub

    'BOTONES
    Private Sub GuardarF2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarF2ToolStripMenuItem.Click
        Dim band As Boolean = False
        If Not txtVehiculo.Text.Length > 0 Then Exit Sub
        If Not IsNumeric(txtHora.Text) Then band = True
        If Not IsNumeric(txtMediaHora.Text) Then band = True

        If band Then
            MsgBox("Los valores deben ser numericos.!", MsgBoxStyle.Critical, "VALORES INCORRECTOS")
            Exit Sub
        End If

        Try
            If MsgBox("¿Desea actualizar los precios del parqueo?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "ACTUALIZAR") = vbYes Then
                Dim i As Integer = 0
                cnx.Execute("Update parqueo.precio set hora = " & CInt(txtHora.Text) & ", media = " & CInt(txtMediaHora.Text) & " where vehiculo = '" & txtVehiculo.Text & "';", i)
                If i > 0 Then
                    MsgBox("Se actualizaron los precios correctamente.!", MsgBoxStyle.Information, "ACTUALIZAR PRECIOS.")
                End If
            End If
        Catch ex As Exception
            errores("Actualizar precio", Me.Name, ex.Message)
        End Try
    End Sub
    Private Sub SalirF12ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirF12ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub txtVehiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtVehiculo.SelectedIndexChanged
        Try
            Dim rs As New ADODB.Recordset
            rs.Open("Select * from precio where vehiculo = '" & txtVehiculo.Text & "'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not rs.EOF Then
                txtMediaHora.Text = rs.Fields(1).Value
                txtHora.Text = rs.Fields(0).Value
                txtMediaHora.Focus()
            End If
            If rs.State = 1 Then rs.Close()

        Catch ex As Exception
            errores("Buscar precio", Me.Name, ex.Message)
        End Try
    End Sub
End Class