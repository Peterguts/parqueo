Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not cnx.State = 1 Then
            If Not conectar() Then
                MsgBox("Error al intentar conecar la base de datos.!", MsgBoxStyle.Critical, "ERROR")
            End If
        End If

        If permiso.Equals("ADMINISTRADOR") Then
            MantenimientoToolStripMenuItem.Visible = True
            CierreToolStripMenuItem.Visible = True
        End If
    End Sub
    Private Sub FrmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmSesion.Close()
    End Sub

    'BOTONES
    '---------------------------------------------------------------------------------------------------------
    Private Sub MarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarcaToolStripMenuItem.Click
        FrmMarca.MdiParent = Me
        FrmMarca.Show()
    End Sub
    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        FrmUsuario.MdiParent = Me
        FrmUsuario.Show()
    End Sub
    Private Sub PrecioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrecioToolStripMenuItem.Click
        FrmPrecio.MdiParent = Me
        FrmPrecio.Show()
    End Sub
    Private Sub EspacioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspacioToolStripMenuItem.Click
        FrmEspacio.Show()
        FrmEspacio.MdiParent = Me
    End Sub
    Private Sub GenerarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarToolStripMenuItem.Click
        FrmTicket.Show()
    End Sub
    Private Sub MensualToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub CierreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreToolStripMenuItem.Click
        If MsgBox("¿Esta seguro de hacer el cierre mensual?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "SALIR") = vbYes Then
            Try
                Dim rs As New ADODB.Recordset
                rs.Open("Select count(*) from ticket where estado = 'ACTIVO'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
                If Not rs.EOF Then
                    If rs.Fields(0).Value > 0 Then
                        MsgBox("Tiene documentos activos.!" & vbCrLf & "NO ES POSIBLE HACER EL CIERRE.!", MsgBoxStyle.Critical, "CIERRE NO REALIZADO")
                        If rs.State = 1 Then rs.Close()
                        Exit Sub
                    End If
                End If
                If rs.State = 1 Then rs.Close()

                MsgBox("Espere hasta que el proceso haya terminado.!" & vbCrLf & "Se le mostrará un mensaje en pantalla...", MsgBoxStyle.Information, "CIERRE")

                cnx.BeginTrans()
                rs.Open("Select * from ticket order by fecha asc", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
                While Not rs.EOF
                    Dim mes As Integer = 0
                    Dim anio As Integer = 0
                    Dim fecha As Date = Format(rs.Fields("fecha").Value, "dd/MM/yyyy")

                    mes = fecha.Month
                    anio = fecha.Year

                    Dim rsNuevo As New ADODB.Recordset
                    rsNuevo.Open("Select * from ticket_historico where 1 = 0", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
                    If rsNuevo.EOF Then
                        rsNuevo.AddNew()
                        rsNuevo.Fields("id").Value = 0
                        rsNuevo.Fields("mes").Value = mes
                        rsNuevo.Fields("anio").Value = anio
                        rsNuevo.Fields("barra").Value = rs.Fields("barra").Value
                        rsNuevo.Fields("vehiculo").Value = rs.Fields("vehiculo").Value
                        rsNuevo.Fields("entrada").Value = rs.Fields("entrada").Value
                        rsNuevo.Fields("salida").Value = rs.Fields("salida").Value
                        rsNuevo.Fields("fecha").Value = Format(rs.Fields("fecha").Value, "yyyy-MM-dd hh:mm:ss tt")
                        rsNuevo.Fields("marca").Value = rs.Fields("marca").Value.ToString
                        rsNuevo.Fields("color").Value = rs.Fields("color").Value.ToString
                        rsNuevo.Fields("descripcion").Value = rs.Fields("descripcion").Value.ToString
                        rsNuevo.Fields("total").Value = rs.Fields("total").Value
                        rsNuevo.Fields("llave").Value = rs.Fields("llave").Value
                        rsNuevo.Fields("estado").Value = rs.Fields("estado").Value
                        rsNuevo.Fields("placa").Value = rs.Fields("placa").Value.ToString
                        rsNuevo.Fields("tiempo").Value = rs.Fields("tiempo").Value
                        rsNuevo.Update()
                    End If
                    If rsNuevo.State = 1 Then rsNuevo.Close()

                    rs.MoveNext()
                End While
                If rs.State = 1 Then rs.Close()

                cnx.CommitTrans()

            Catch ex As Exception
                cnx.RollbackTrans()
            errores("Cierre mensual.", Me.Name, ex.Message)
            End Try
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea salir de la aplicación?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "SALIR") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        FrmReportes.Show()
        FrmReportes.MdiParent = Me
    End Sub
End Class