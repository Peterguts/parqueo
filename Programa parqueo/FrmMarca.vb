Public Class FrmMarca
    Private Sub FrmMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not cnx.State = 1 Then
            If Not conectar() Then
                MsgBox("Error al intentar conecar la base de datos.!", MsgBoxStyle.Critical, "ERROR")
                Me.Close()
            End If
        End If
        NuevoF1ToolStripMenuItem.PerformClick()
    End Sub

    'BOTONES 
    Private Sub NuevoF1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoF1ToolStripMenuItem.Click
        txtMarca.Clear()
        txtDescripcion.Clear()
        txtModelo.Clear()
        txtMarca.Focus()

        Try
            Dim rs As New ADODB.Recordset
            rs.Open("Select ifnull(max(id) + 1,1) from marca", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not rs.EOF Then
                LId.Text = rs.Fields(0).Value
            Else
                LId.Text = 1
            End If
            If rs.State = 1 Then rs.Close()
        Catch ex As Exception
            errores("Buscar id", Me.Name, ex.Message)
        End Try
    End Sub
    Private Sub GuardarF2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarF2ToolStripMenuItem.Click
        If Not LId.Text.Length > 0 Then Exit Sub
        If Not txtMarca.Text.Length > 0 Then Exit Sub

        Try
            Dim rs As New ADODB.Recordset
            rs.Open("Select * from marca where id = '" & LId.Text & "' and marca = '" & txtMarca.Text & "'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
            If rs.EOF Then
                If MsgBox("¿Desea agregar nueva marca?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "MARCA NUEVA") = vbYes Then
                    rs.AddNew()
                    rs.Fields(0).Value = LId.Text
                    rs.Fields(1).Value = txtVehiculo.Text
                    rs.Fields(2).Value = txtMarca.Text
                    rs.Fields(3).Value = txtModelo.Text
                    rs.Fields(4).Value = txtDescripcion.Text
                    rs.Update()
                    MsgBox("Marca agregada correctamente.!", MsgBoxStyle.Information, "MARCA NUEVA")
                End If
            Else
                If MsgBox("¿Desea actualizar marca '" & txtMarca.Text & "'?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "MARCA NUEVA") = vbYes Then
                    rs.Fields(1).Value = txtVehiculo.Text
                    rs.Fields(2).Value = txtMarca.Text
                    rs.Fields(3).Value = txtModelo.Text
                    rs.Fields(4).Value = txtDescripcion.Text
                    rs.Update()
                    MsgBox("Marca actualizado correctamente.!", MsgBoxStyle.Information, "MARCA NUEVA")
                End If
            End If
            If rs.State = 1 Then rs.Close()

        Catch ex As Exception
            errores("Boton Guardar", Me.Name, ex.Message)
        End Try
    End Sub
    Private Sub BuscarF3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarF3ToolStripMenuItem.Click
        With FrmBuscar
            .LblBuscarPor.Text = "Buscar por: Vehículo, marca o modelo."
            .tipo = "MARCA"
            .TxtBuscar.Focus()
            .Show()
        End With
    End Sub
    Private Sub EliminarF4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarF4ToolStripMenuItem.Click
        Try
            Dim rs As New ADODB.Recordset
            rs.Open("Select * from marca where id = '" & LId.Text & "' and marca = '" & txtMarca.Text & "'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not rs.EOF Then
                If MsgBox("¿Desea eliminar marca '" & txtMarca.Text & "'?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "ELIMINAR MARCA") = vbYes Then
                    Dim i As Integer = 0
                    cnx.Execute("Delete from marca where id = '" & LId.Text & "' and marca = '" & txtMarca.Text & "'", i)
                    If i > 0 Then
                        MsgBox("Marca eliminada correctamente.!", MsgBoxStyle.Information, "MARCA ELIMINADA")
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