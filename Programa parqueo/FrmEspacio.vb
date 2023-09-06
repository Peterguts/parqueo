Public Class FrmEspacio
    Private Sub FrmEspacio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not cnx.State = 1 Then
            If Not conectar() Then
                MsgBox("Error al intentar conecar la base de datos.!", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            End If
        End If

        txtCarroSin.Text = "0"
        txtCarroCon.Text = "0"
        txtMotoSin.Text = "0"
        txtMotoCon.Text = "0"

        Try
            Dim rs As New ADODB.Recordset
            rs.Open("Select * from espacio", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not rs.EOF Then
                txtCarroSin.Text = rs.Fields(0).Value
                txtCarroCon.Text = rs.Fields(1).Value
                txtMotoSin.Text = rs.Fields(2).Value
                txtMotoCon.Text = rs.Fields(3).Value
                txtCarroSin.Focus()
            End If
            If rs.State = 1 Then rs.Close()

        Catch ex As Exception
            errores("Buscar espacios", Me.Name, ex.Message)
        End Try
    End Sub

    'BOTONES
    Private Sub GuardarF2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarF2ToolStripMenuItem.Click
        Dim band As Boolean = False
        If Not IsNumeric(txtCarroSin.Text) Then band = True
        If Not IsNumeric(txtCarroCon.Text) Then band = True
        If Not IsNumeric(txtMotoSin.Text) Then band = True
        If Not IsNumeric(txtMotoCon.Text) Then band = True

        If band Then
            MsgBox("Los valores deben ser numericos.!", MsgBoxStyle.Critical, "VALORES INCORRECTOS")
            Exit Sub
        End If

        Try
            If MsgBox("¿Desea actualizar los espacios del parqueo?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "ACTUALIZAR") = vbYes Then
                Dim i As Integer = 0
                cnx.Execute("Update espacio set carro = " & CInt(txtCarroSin.Text) & ", carro_llave = " & CInt(txtCarroCon.Text) & ", moto = " & CInt(txtMotoSin.Text) & ", moto_llave = " & CInt(txtMotoCon.Text) & ";", i)
                If i > 0 Then
                    MsgBox("Se actualizaron los espacios correctamente.!", MsgBoxStyle.Information, "ACTUALIZAR ESPACIO.")
                Else
                    MsgBox("No se actualizo ningun espacio.!", MsgBoxStyle.Information, "ACTUALIZAR ESPACIO.")
                End If
            End If
        Catch ex As Exception
            errores("Actualizar precio", Me.Name, ex.Message)
        End Try
    End Sub
    Private Sub SalirF12ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirF12ToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class