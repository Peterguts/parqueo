Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Public Class FrmBuscar
    Public tipo As String = ""
    Private Sub FrmBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not cnx.State = 1 Then
            If Not conectar() Then
                MsgBox("Error al intentar conecar la base de datos.!", MsgBoxStyle.Critical, "ERROR")
                Exit Sub
            End If
        End If

        If tipo = "TICKET" Then
            Me.ClientSize = New Size(880, 600)
        End If
    End Sub
    Private Sub TxtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBuscar.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Try
                If tipo = "USUARIO" Then
                    llenar("Select login as Usuario, clave as Contraseña, nombre as Nombre, tipo as Permiso from usuario where nombre like '%" & TxtBuscar.Text & "%'")
                End If

                If tipo = "MARCA" Then
                    llenar("Select id, vehiculo as Vehiculo, marca as Marca, modelo as Modelo, descripcion as Descripcion from marca where vehiculo = '" & TxtBuscar.Text & "' or marca like '%" & TxtBuscar.Text & "%' or modelo like '%" & TxtBuscar.Text & "%'")
                    If DataGridView1.RowCount > 0 Then
                        DataGridView1.Columns(0).Visible = False
                    End If
                End If

                If tipo = "TICKET" Then
                    Dim sql As String = ""
                    Dim texto As String = TxtBuscar.Text
                    Dim esFecha As Boolean = False

                    ' Validar si es una fecha
                    Dim fecha As DateTime
                    If DateTime.TryParseExact(texto, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, fecha) Then
                        esFecha = True
                    End If

                    If esFecha Then
                        Dim fech As Date = TxtBuscar.Text
                        sql = "Select id, vehiculo as Vehiculo, placa as Placa, if(llave=1,'SI', 'NO') as Llave, fecha as Fecha, entrada as Entrada, salida as Salida, marca as Marca, color as Color, barra as Barra, estado as Estado, if(especial=1,'SI', 'NO') as Especial from ticket where fecha like '" & Format(fech, "yyyy-MM-dd") & "%' order by fecha asc"
                    Else
                        sql = "Select id, vehiculo as Vehiculo, placa as Placa, if(llave=1,'SI', 'NO') as Llave, fecha as Fecha, entrada as Entrada, salida as Salida, marca as Marca, color as Color, barra as Barra, estado as Estado, if(especial=1,'SI', 'NO') as Especial from ticket where barra = '" & TxtBuscar.Text & "' or placa like '%" & TxtBuscar.Text & "%' or marca like '%" & TxtBuscar.Text & "%' order by fecha asc"
                    End If

                    llenar(sql)
                    If DataGridView1.Columns.Count > 0 Then
                        DataGridView1.Columns(0).Visible = False
                    End If
                End If
            Catch ex As Exception
                errores("Buscar " & tipo, Me.Name, ex.Message)
            End Try
        End If
    End Sub
    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        If Not DataGridView1.CurrentRow Is Nothing Then
            If tipo = "USUARIO" Then
                With FrmUsuario
                    .txtUsuario.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value.ToString
                    .txtClave.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value.ToString
                    .txtNombre.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value.ToString
                    .txtPermiso.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value.ToString
                    .txtUsuario.Focus()
                    .Show()
                    .BringToFront()
                End With
                Me.Close()
            End If

            If tipo = "MARCA" Then
                With FrmMarca
                    .LId.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value.ToString
                    .txtVehiculo.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value.ToString
                    .txtMarca.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value.ToString
                    .txtModelo.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value.ToString
                    .txtDescripcion.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value.ToString
                    .Show()
                    .txtMarca.Focus()
                    .BringToFront()
                End With
                Me.Close()
            End If

            If tipo = "TICKET" Then
                With FrmTicket
                    .txtBarra.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(9).Value.ToString
                    .Show()
                    .txtBarra.Focus()
                    .BringToFront()
                End With
                Me.Close()
            End If
        End If
    End Sub

    'FUNCION.
    Sub llenar(sql As String)
        Try
            Dim da As New System.Data.OleDb.OleDbDataAdapter
            Dim ds As New DataSet
            Dim rs As New ADODB.Recordset
            DataGridView1.DataSource = Nothing
            rs.Open(sql, cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            da.Fill(ds, rs, "Tabla")
            DataGridView1.DataSource = ds.Tables("Tabla")
            If rs.State = 1 Then rs.Close()
        Catch ex As Exception
            errores("Llenar grid " & tipo, Me.Name, ex.Message)
        End Try
    End Sub
End Class