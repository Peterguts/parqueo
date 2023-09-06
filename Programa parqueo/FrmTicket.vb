Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Security.Cryptography
Imports Microsoft.VisualBasic.ApplicationServices
Imports ZXing

Public Class FrmTicket
    Public band As Boolean = False
    Dim inicio As Boolean = True
    'LOAD
    Private Sub FrmTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establecer la propiedad KeyPreview en True
        Me.KeyPreview = True

        If Not cnx.State = 1 Then
            If Not conectar() Then
                MsgBox("Error al intentar conecar la base de datos.!", MsgBoxStyle.Critical, "ERROR")
            End If
        End If
        inicio = True

        txtVehiculo.Text = "Carro"
        RadioButonFinalizar.Checked = True
        llenarMarca()
        espacio()
        llenarLista()
        txtPlaca.Focus()
    End Sub

    'EVENTOS
    '--------------------------------------------------------------------------------------------------------------
    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        LHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LFecha.Text = DateTime.Now.ToLongDateString()
    End Sub
    Private Sub FrmTicket_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmPrincipal.BringToFront()
        If FormularioEstaAbierto("FrmEditar") Then
            FrmEditar.Close()
        End If
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        DesmarcarFilaSeleccionada()
    End Sub
    Private Sub GroupTicket_Enter(sender As Object, e As EventArgs) Handles GroupTicket.Enter
        DesmarcarFilaSeleccionada()
    End Sub
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter
        DesmarcarFilaSeleccionada()
    End Sub
    Private Sub FrmTicket_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'ENTER.
        If e.KeyCode = Keys.Enter Then

            If txtBarra.Focused() = True And txtBarra.Text.Length = 16 Then
                If RadioButonFinalizar.Checked = True Then
                    finalizar(txtBarra.Text)
                End If

                If RadioButonReImprimir.Checked = True Then
                    etiqueta()
                End If

                If RadioButonEditar.Checked = True Then
                    If FormularioEstaAbierto("FrmEditar") Then
                        FrmEditar.Close()
                    End If

                    With FrmEditar
                        Dim rs As New ADODB.Recordset
                        rs.Open("Select * from ticket where barra = '" & txtBarra.Text & "'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
                        If Not rs.EOF Then
                            .LId.Text = rs.Fields("id").Value.ToString
                            .LBarra.Text = rs.Fields("barra").Value.ToString
                            .LEstado.Text = rs.Fields("estado").Value.ToString
                            .txtVehiculo.Text = rs.Fields("vehiculo").Value.ToString
                            .llenarMarca()
                            .txtMarca.Text = rs.Fields("marca").Value.ToString
                            .txtEntrada.Text = rs.Fields("entrada").Value.ToString
                            .txtSalida.Text = rs.Fields("salida").Value.ToString
                            .txtColor.Text = rs.Fields("color").Value.ToString
                            .txtPlaca.Text = rs.Fields("placa").Value.ToString
                            .txtObservaviones.Text = rs.Fields("descripcion").Value.ToString
                            If rs.Fields("especial").Value = 1 Then
                                .switchEspecial.Checked = True
                            Else
                                .switchEspecial.Checked = False
                            End If
                            If rs.Fields("llave").Value = 1 Then
                                .CheckLlave.Checked = True
                            Else
                                .CheckLlave.Checked = False
                            End If
                            .Show()
                            .BringToFront()
                            .txtPlaca.Focus()
                        Else
                            MsgBox("Barra no encontrada.!", MsgBoxStyle.Critical, "ERROR")
                        End If
                        If rs.State = 1 Then rs.Close()
                    End With
                End If

                If RadioButonBuscar.Checked = True Then
                    With FrmBuscar
                        .tipo = "TICKET"
                        .LblBuscarPor.Text = "Buscar por: Barra (completa), fecha (01/01/0000), marca, placas."
                        .TxtBuscar.Focus()
                        .ClientSize = New Size(880, 600)
                        .Show()
                        .BringToFront()
                    End With
                End If
            Else
                e.SuppressKeyPress = True ' Evita que se emita el sonido de Windows al presionar Enter

                Dim currentControl As Control = Me.ActiveControl
                Me.SelectNextControl(currentControl, True, True, True, True)
            End If
        End If

        If e.Control Then
            If (txtColor.Focused() = True Or txtMarca.Focused() = True Or txtVehiculo.Focused() = True) Then
                btnGenerar.Focus()
            End If
        End If

        'NUEVO
        If e.Control AndAlso e.KeyCode = Keys.N Then
            txtPlaca.Focus()
            txtPlaca.Clear()
            txtDescripcion.Clear()
            SwitchEspecial.Checked = False
            CheckLlave.Checked = False
            txtBarra.Clear()
            txtVehiculo.Text = "Carro"
            txtMarca.SelectedIndex = -1
            txtColor.SelectedIndex = -1
        End If

        'Verificar si se presionó la combinación de teclas CTRL + G
        If e.Control AndAlso e.KeyCode = Keys.G Then
            btnGenerar.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.C Then
            txtPlaca.Focus()
            txtPlaca.Clear()
            txtDescripcion.Clear()
            txtBarra.Clear()
            txtVehiculo.Text = "Carro"
            txtMarca.SelectedIndex = -1
            txtColor.SelectedIndex = -1
        End If

        If e.Control AndAlso e.KeyCode = Keys.M Then
            txtPlaca.Focus()
            txtPlaca.Clear()
            txtDescripcion.Clear()
            txtBarra.Clear()
            txtVehiculo.Text = "Moto"
            txtMarca.SelectedIndex = -1
            txtColor.SelectedIndex = -1
        End If

        If e.Control AndAlso e.KeyCode = Keys.T Then
            If SwitchEspecial.Checked = True Then
                SwitchEspecial.Checked = False
            Else
                SwitchEspecial.Checked = True
            End If
            txtPlaca.Focus()
            txtPlaca.Clear()
            txtDescripcion.Clear()
            txtBarra.Clear()
            txtVehiculo.Text = "Carro"
            txtMarca.SelectedIndex = -1
            txtColor.SelectedIndex = -1
        End If

        If e.Control AndAlso e.KeyCode = Keys.K Then
            If CheckLlave.Checked = True Then
                CheckLlave.Checked = False
            Else
                CheckLlave.Checked = True
            End If
            txtPlaca.Focus()
            txtPlaca.Clear()
            txtDescripcion.Clear()
            txtBarra.Clear()
            txtVehiculo.Text = "Carro"
            txtMarca.SelectedIndex = -1
            txtColor.SelectedIndex = -1
        End If

        If e.Control AndAlso e.KeyCode = Keys.F Then
            RadioButonFinalizar.Checked = True
            txtPlaca.Clear()
            txtDescripcion.Clear()
            SwitchEspecial.Checked = False
            CheckLlave.Checked = False
            txtBarra.Clear()
            txtVehiculo.Text = "Carro"
            txtMarca.SelectedIndex = -1
            txtColor.SelectedIndex = -1
        End If

        If e.Control AndAlso e.KeyCode = Keys.B Then
            RadioButonBuscar.Checked = True

        End If

        If e.Control AndAlso e.KeyCode = Keys.E Then
            RadioButonEditar.Checked = True
            txtBarra.Clear()
            txtBarra.Focus()
        End If

        If e.Control AndAlso e.KeyCode = Keys.R Then
            RadioButonReImprimir.Checked = True
        End If
    End Sub
    'CAMBIAR COLOR DE FONDO PARA EL COMBOBOX.
    Private Sub txtColor_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtColor.SelectedValueChanged
        Try
            If txtColor.SelectedItem Is Nothing Then
                txtColor.BaseColor = Color.FromArgb(255, 255, 255)
                txtColor.ForeColor = Color.Black
                Exit Sub
            End If
            txtColor.BaseColor = funcionColores(txtColor.SelectedItem.ToString)

            ' Cambiar el color del texto en función del brillo del color seleccionado
            If txtColor.BaseColor.GetBrightness() < 0.5 Then
                txtColor.ForeColor = Color.White
            Else
                txtColor.ForeColor = Color.Black
            End If
        Catch ex As Exception
            errores("Colores ", Me.Name, ex.Message)
        End Try
    End Sub
    Function funcionColores(ByVal colorName As String)
        Try
            ' Obtener el color seleccionado del ComboBox
            'Dim colorName As String = txtColor.SelectedItem.ToString()
            If Not colorName.Length > 0 Then
                Return Color.FromArgb(255, 255, 255)
            End If

            ' Validar el color seleccionado utilizando una estructura Select Case
            Select Case colorName
                Case "Blanco"
                    Return Color.FromArgb(255, 255, 255)
                    'txtColor.BorderColor = Color.FromArgb(0, 0, 0)
                Case "Negro"
                    Return Color.FromArgb(0, 0, 0)
                    'txtColor.BorderColor = Color.FromArgb(0, 0, 0)
                Case "Gris"
                    Return Color.FromArgb(128, 128, 128)
                    'txtColor.BorderColor = Color.FromArgb(128, 128, 128)
                Case "Plateado"
                    Return Color.FromArgb(192, 192, 192)
                    'txtColor.BorderColor = Color.FromArgb(192, 192, 192)
                Case "Azul"
                    Return Color.FromArgb(0, 0, 255)
                    'txtColor.BorderColor = Color.FromArgb(0, 0, 255)
                Case "Rojo"
                    Return Color.FromArgb(255, 0, 0)
                    'txtColor.BorderColor = Color.FromArgb(255, 0, 0)
                Case "Verde"
                    Return Color.FromArgb(0, 128, 0)
                    'txtColor.BorderColor = Color.FromArgb(0, 128, 0)
                Case "Marrón"
                    Return Color.FromArgb(165, 42, 42)
                    'txtColor.BorderColor = Color.FromArgb(165, 42, 42)
                Case "Celeste"
                    Return Color.FromArgb(51, 193, 255)
                Case "Rosado"
                    Return Color.FromArgb(249, 51, 255)
                Case "Corinto"
                    Return Color.FromArgb(144, 12, 63)
                Case "Beige"
                    Return Color.FromArgb(245, 245, 220)
                   ' txtColor.BorderColor = Color.FromArgb(245, 245, 220)
                Case "Dorado"
                    Return Color.FromArgb(255, 215, 0)
                   ' txtColor.BorderColor = Color.FromArgb(255, 215, 0)
                Case "Amarillo"
                    Return Color.FromArgb(255, 255, 0)
                    'txtColor.BorderColor = Color.FromArgb(255, 255, 0)
                Case "Naranja"
                    Return Color.FromArgb(255, 165, 0)
                Case "Cafe"
                    Return Color.FromArgb(128, 64, 0)
                    'txtColor.BorderColor = Color.FromArgb(255, 165, 0)
                Case "Plata"
                    Return Color.FromArgb(192, 192, 192)
                    'txtColor.BorderColor = Color.FromArgb(192, 192, 192)
                Case "Bronce"
                    Return Color.FromArgb(205, 127, 50)
                   ' txtColor.BorderColor = Color.FromArgb(205, 127, 50)
                Case "Champagne"
                    Return Color.FromArgb(247, 231, 206)
                    'txtColor.BorderColor = Color.FromArgb(247, 231, 206)
                Case "Verde oliva"
                    Return Color.FromArgb(128, 128, 0)
                    'txtColor.BorderColor = Color.FromArgb(128, 128, 0)
                Case "Azul marino"
                    Return Color.FromArgb(0, 0, 128)
                    'txtColor.BorderColor = Color.FromArgb(0, 0, 128)
                Case "Granate"
                    Return Color.FromArgb(128, 0, 0)
                    'txtColor.BorderColor = Color.FromArgb(128, 0, 0)
                Case "Azul claro"
                    Return Color.FromArgb(135, 206, 250)
                   ' txtColor.BorderColor = Color.FromArgb(135, 206, 250)
                Case "Gris oscuro"
                    Return Color.FromArgb(64, 64, 64)
                   ' txtColor.BorderColor = Color.FromArgb(64, 64, 64)
                Case "Azul metálico"
                    Return Color.FromArgb(0, 47, 167)
                    'txtColor.BorderColor = Color.FromArgb(0, 47, 167)
                Case "Verde oscuro"
                    Return Color.FromArgb(0, 100, 0)
                    'txtColor.BorderColor = Color.FromArgb(0, 100, 0)
                Case "Burdeos"
                    Return Color.FromArgb(128, 0, 32)
                   ' txtColor.BorderColor = Color.FromArgb(128, 0, 32)
                Case "Verde claro"
                    Return Color.FromArgb(144, 238, 144)
                   ' txtColor.BorderColor = Color.FromArgb(144, 238, 144)
                Case "Marrón oscuro"
                    Return Color.FromArgb(101, 67, 33)
                   ' txtColor.BorderColor = Color.FromArgb(101, 67, 33)
                Case "Blanco perla"
                    Return Color.FromArgb(234, 224, 200)
                   ' txtColor.BorderColor = Color.FromArgb(234, 224, 200)
                Case "Rojo fuego"
                    Return Color.FromArgb(178, 34, 34)
                   ' txtColor.BorderColor = Color.FromArgb(178, 34, 34)
                Case "Gris claro"
                    Return Color.FromArgb(211, 211, 211)
                   ' txtColor.BorderColor = Color.FromArgb(211, 211, 211)
                Case "Azul eléctrico"
                    Return Color.FromArgb(0, 0, 255)
                    ' txtColor.BorderColor = Color.FromArgb(0, 0, 255)
                    ' Agregar más casos para el resto de los colores
                Case "Otro"
                    Return Color.FromArgb(255, 255, 255)
            End Select
        Catch ex As Exception
            errores("Pintar colores", Me.Name, Err.Description)
        End Try
    End Function
    Private Sub RadioButonBuscar_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButonBuscar.CheckedChanged
        If RadioButonBuscar.Checked = True Then
            RadioButonBuscar.ForeColor = Color.Black
            RadioButonBuscar.Font = New Font(RadioButonBuscar.Font, FontStyle.Bold)

            With FrmBuscar
                .tipo = "TICKET"
                .LblBuscarPor.Text = "Buscar por: Barra (completa), fecha (01/01/0000), marca, placas."
                .TxtBuscar.Text = txtBarra.Text
                .TxtBuscar.Focus()
                .ClientSize = New Size(880, 600)
                .Show()
                .BringToFront()
            End With
        Else
            RadioButonBuscar.ForeColor = Color.DimGray
            RadioButonBuscar.Font = New Font(RadioButonBuscar.Font, FontStyle.Regular)
        End If
    End Sub
    Private Sub RadioButonBuscar_Click(sender As Object, e As EventArgs) Handles RadioButonBuscar.Click
        If RadioButonBuscar.Checked = True Then
            With FrmBuscar
                .tipo = "TICKET"
                .LblBuscarPor.Text = "Buscar por: Barra (completa), fecha (01/01/0000), marca, placas."
                .TxtBuscar.Text = txtBarra.Text
                .TxtBuscar.Focus()
                .Show()
                .BringToFront()
            End With
        End If
    End Sub
    Private Sub RadioButonEditar_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButonEditar.CheckedChanged
        If RadioButonEditar.Checked = True Then
            RadioButonEditar.ForeColor = Color.Black
            RadioButonEditar.Font = New Font(RadioButonEditar.Font, FontStyle.Bold)
            txtBarra.Focus()
        Else
            RadioButonEditar.ForeColor = Color.DimGray
            RadioButonEditar.Font = New Font(RadioButonEditar.Font, FontStyle.Regular)
        End If
    End Sub
    Private Sub RadioButonFinalizar_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButonFinalizar.CheckedChanged
        If RadioButonFinalizar.Checked = True Then
            RadioButonFinalizar.ForeColor = Color.Black
            RadioButonFinalizar.Font = New Font(RadioButonFinalizar.Font, FontStyle.Bold)
            txtBarra.Focus()
        Else
            RadioButonFinalizar.ForeColor = Color.DimGray
            RadioButonFinalizar.Font = New Font(RadioButonFinalizar.Font, FontStyle.Regular)
        End If
    End Sub
    Private Sub RadioButonReImprimir_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButonReImprimir.CheckedChanged
        If RadioButonReImprimir.Checked = True Then
            RadioButonReImprimir.ForeColor = Color.Black
            RadioButonReImprimir.Font = New Font(RadioButonReImprimir.Font, FontStyle.Bold)
            txtBarra.Focus()
        Else
            RadioButonReImprimir.ForeColor = Color.DimGray
            RadioButonReImprimir.Font = New Font(RadioButonReImprimir.Font, FontStyle.Regular)
        End If
    End Sub
    Private Sub ListHistorial_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles ListHistorial.DataBindingComplete
        DesmarcarFilaSeleccionada()
    End Sub
    Private Sub txtVehiculo_Enter(sender As Object, e As EventArgs) Handles txtVehiculo.Enter
        txtVehiculo.BorderColor = Color.Black
    End Sub
    Private Sub txtVehiculo_Leave(sender As Object, e As EventArgs) Handles txtVehiculo.Leave
        txtVehiculo.BorderColor = Color.Silver
    End Sub
    Private Sub txtMarca_Enter(sender As Object, e As EventArgs) Handles txtMarca.Enter
        txtMarca.BorderColor = Color.Black
    End Sub
    Private Sub txtMarca_Leave(sender As Object, e As EventArgs) Handles txtMarca.Leave
        txtMarca.BorderColor = Color.Silver
    End Sub
    Private Sub txtColor_Enter(sender As Object, e As EventArgs) Handles txtColor.Enter
        txtColor.BorderColor = Color.Black
    End Sub
    Private Sub txtColor_Leave(sender As Object, e As EventArgs) Handles txtColor.Leave
        txtColor.BorderColor = Color.Silver
    End Sub
    Private Sub btnGenerar_Enter(sender As Object, e As EventArgs) Handles btnGenerar.Enter
        btnGenerar.BaseColor = Color.DarkCyan
        btnGenerar.ForeColor = Color.White
    End Sub
    Private Sub btnGenerar_Leave(sender As Object, e As EventArgs) Handles btnGenerar.Leave
        btnGenerar.BaseColor = Color.GreenYellow
        btnGenerar.ForeColor = Color.Black
    End Sub
    Private Sub CheckLlave_CheckedChanged(sender As Object, e As EventArgs) Handles CheckLlave.CheckedChanged
        If CheckLlave.Checked = True Then
            ImagenLlave.Visible = True
        Else
            ImagenLlave.Visible = False
        End If
    End Sub
    Private Sub txtVehiculo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtVehiculo.SelectedIndexChanged
        llenarMarca()
    End Sub
    Private Sub ListHistorial_MouseClick(sender As Object, e As MouseEventArgs) Handles ListHistorial.MouseClick
        If ListHistorial.CurrentRow IsNot Nothing Then
            txtBarra.Focus()
            txtBarra.Text = ListHistorial.Rows(ListHistorial.CurrentRow.Index).Cells(1).Value
        End If
    End Sub

    'FUNCIONES
    '--------------------------------------------------------------------------------------------------------------
    Sub llenarMarca()
        Try
            txtMarca.Items.Clear()
            Dim rs As New ADODB.Recordset
            cnx.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            rs.Open("Select concat(marca, ' ', modelo) as Marca from marca where vehiculo = '" & txtVehiculo.Text & "'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            While Not rs.EOF
                txtMarca.Items.Add(rs.Fields(0).Value)
                rs.MoveNext()
            End While
            If txtVehiculo.Text = "Moto" Then
                txtMarca.Text = ""
            End If
        Catch ex As Exception
            errores("Llenar marca", Me.Name, ex.Message)
        End Try
    End Sub
    Dim prtSettings As New PrinterSettings
    Sub etiqueta()
        Try
            If prtSettings Is Nothing Then
                prtSettings = New PrinterSettings
            End If

            If seleccionarImpresora() = False Then Return

            If PrintDocument1 Is Nothing Then
                PrintDocument1 = New System.Drawing.Printing.PrintDocument
                AddHandler PrintDocument1.PrintPage, AddressOf PrintDocument1_PrintPage
            End If

            Dim xCustomSize As New PaperSize("Custom", 300, 800)
            prtSettings.DefaultPageSettings.Margins.Bottom = 15
            prtSettings.DefaultPageSettings.Margins.Top = 0
            prtSettings.DefaultPageSettings.Margins.Left = 10
            prtSettings.DefaultPageSettings.Margins.Right = 0
            prtSettings.DefaultPageSettings.PaperSize = xCustomSize
            prtSettings.DefaultPageSettings.Landscape = False
            PrintDocument1.PrinterSettings = prtSettings

            ' Imprimir el documento
            PrintDocument1.Print()

            Me.BringToFront()
            'Dim prtPrev As New PrintPreviewDialog
            'prtPrev.Document = PrintDocument1
            '    prtPrev.Text = "Previsualizar documento"
            '    prtPrev.Width = (Screen.PrimaryScreen.WorkingArea.Width)
            '    prtPrev.Height = (Screen.PrimaryScreen.WorkingArea.Height)
            '    prtPrev.PrintPreviewControl.Zoom = 1.0
            '    prtPrev.WindowState = FormWindowState.Maximized
            'prtPrev.ShowDialog()


            'PrintDocument1.DefaultPageSettings.Margins.Bottom = 0
            'PrintDocument1.DefaultPageSettings.Margins.Top = 5
            'PrintDocument1.DefaultPageSettings.Margins.Left = 0
            'PrintDocument1.DefaultPageSettings.Margins.Right = 0
            '' Configurar el tamaño del papel en función de los márgenes disponibles
            'PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Custom", 200, 600)

            'Dim printDialog1 As New PrintDialog()
            'printDialog1.Document = PrintDocument1
            'If printDialog1.ShowDialog() = DialogResult.OK Then
            '    Dim prtPrev As New PrintPreviewDialog
            '    prtPrev.Document = PrintDocument1
            '    prtPrev.Text = "Previsualizar documento"
            '    prtPrev.Width = (Screen.PrimaryScreen.WorkingArea.Width)
            '    prtPrev.Height = (Screen.PrimaryScreen.WorkingArea.Height)
            '    prtPrev.PrintPreviewControl.Zoom = 1.0
            '    prtPrev.WindowState = FormWindowState.Maximized
            '    prtPrev.ShowDialog()

            '    ' Imprimir el documento
            '    'PrintDocument1.Print()
            'End If

        Catch ex As Exception
            errores("Imprimir.", Me.Name, ex.Message)
        End Try
    End Sub
    Private Function seleccionarImpresora() As Boolean
        Try
            Dim prtDialog As New PrintDialog
            If prtSettings Is Nothing Then
                prtSettings = New PrinterSettings
            End If

            With prtDialog
                .AllowPrintToFile = False
                .AllowSelection = False
                .AllowSomePages = False
                .PrintToFile = False
                .ShowHelp = False
                .ShowNetwork = True

                .PrinterSettings = prtSettings
            End With

            ' Establecer la impresora predeterminada
            prtSettings.PrinterName = New PrinterSettings().PrinterName
            Return True
        Catch ex As Exception
            errores("Obtener impresora", Me.Name, Err.Description)
            Return False
        End Try
    End Function
    Sub llenarLista()
        Try
            ListHistorial.DataSource = Nothing
            dataFinalizado.DataSource = Nothing

            Dim rs As New ADODB.Recordset
            cnx.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            Dim fech As String = Format(Now, "yyyy-MM-dd")
            Dim da As New System.Data.OleDb.OleDbDataAdapter
            Dim ds As New DataSet
            Dim sql As String = ""

            rs.Open("Select * from ticket where estado = 'ACTIVO' and DATE(fecha) <> '" & fech & "'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not rs.EOF Then
                If inicio Then
                    MsgBox("Tiene tickets activos de otro día.!", MsgBoxStyle.Information, "TICKETS")
                    inicio = False
                End If
                sql = "Select id, barra as Barra, placa as Placa, marca as Marca, color as Color,
                DATE_FORMAT(entrada, '%d-%m-%Y %h:%i:%s %p') as Entrada,
                DATE_FORMAT(salida, '%h:%i:%s %p') as Salida, 
                estado as Estado, total as Total, tiempo as Tiempo from (
                Select * from ticket where estado = 'ACTIVO' and fecha <> '" & fech & "'
                union all
                SELECT * from ticket where DATE(fecha) = '" & fech & "' and estado <> 'FINALIZADO') as tabla order by fecha, hour(fecha);"
            Else
                sql = "SELECT id, barra as Barra, placa as Placa, marca as Marca, color as Color,
                DATE_FORMAT(entrada, '%d-%m-%Y %h:%i:%s %p') as Entrada,
                DATE_FORMAT(salida, '%h:%i:%s %p') as Salida,  
                estado as Estado, total as Total, tiempo as Tiempo from ticket where DATE(fecha) = '" & fech & "' and estado <> 'FINALIZADO' order by fecha, hour(fecha);"
            End If
            If rs.State = 1 Then rs.Close()

            rs.Open(sql, cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not rs.EOF Then
                da.Fill(ds, rs, "Table")
                ListHistorial.DataSource = ds.Tables("Table")

                If ListHistorial.Columns.Count > 0 Then
                    ListHistorial.Columns(0).Visible = False
                    ListHistorial.Columns(1).Visible = False
                End If
            End If
            If rs.State = 1 Then rs.Close()

            For Each colum As DataGridViewColumn In ListHistorial.Columns
                ListHistorial.Columns(colum.Index).SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            For Each row As DataGridViewRow In ListHistorial.Rows
                ListHistorial.Rows(row.Index).DefaultCellStyle.BackColor = funcionColores(ListHistorial.Rows(row.Index).Cells(4).Value.ToString)
                If ListHistorial.Rows(row.Index).Cells(4).Value.ToString.Equals("Negro") Or ListHistorial.Rows(row.Index).Cells(4).Value.ToString.Equals("Azul") Or ListHistorial.Rows(row.Index).Cells(4).Value.ToString.Equals("Corinto") Then
                    ListHistorial.Rows(row.Index).DefaultCellStyle.ForeColor = Color.White
                Else
                    ListHistorial.Rows(row.Index).DefaultCellStyle.ForeColor = Color.Black
                End If

            Next

            ' Establecer la vista en las últimas filas
            If ListHistorial.Rows.Count > 0 Then
                Dim lastRowIndex As Integer = ListHistorial.Rows.Count - 1
                ListHistorial.FirstDisplayedScrollingRowIndex = lastRowIndex
            End If

            '----------------------------------------------------------------------------------------------------
            'TICKETS FINALIZADOS 
            Dim ds1 As New DataSet
            Dim da1 As New System.Data.OleDb.OleDbDataAdapter
            sql = "Select id, barra as Barra, placa as Placa, marca as Marca, color as Color,
                DATE_FORMAT(entrada, '%d-%m-%Y %h:%i:%s %p') as Entrada,
                DATE_FORMAT(salida, '%h:%i:%s %p') as Salida, 
                estado as Estado, total as Total, tiempo as Tiempo from (
                SELECT * from ticket where DATE(fecha) = '" & fech & "' and estado = 'FINALIZADO') as tabla order by fecha, hour(fecha);"
            If rs.State = 1 Then rs.Close()
            rs.Open(sql, cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not rs.EOF Then
                da1.Fill(ds1, rs, "Table")
                dataFinalizado.DataSource = ds1.Tables("Table")

                If dataFinalizado.Columns.Count > 0 Then
                    dataFinalizado.Columns(0).Visible = False
                    dataFinalizado.Columns(1).Visible = False
                End If
            End If
            If rs.State = 1 Then rs.Close()

            For Each colum As DataGridViewColumn In dataFinalizado.Columns
                dataFinalizado.Columns(colum.Index).SortMode = DataGridViewColumnSortMode.NotSortable
            Next

            For Each row As DataGridViewRow In dataFinalizado.Rows
                'dataFinalizado.Rows(row.Index).DefaultCellStyle.ForeColor = Color.Black
                dataFinalizado.Rows(row.Index).DefaultCellStyle.BackColor = funcionColores(dataFinalizado.Rows(row.Index).Cells(4).Value.ToString)
                If dataFinalizado.Rows(row.Index).Cells(4).Value.ToString.Equals("Negro") Or dataFinalizado.Rows(row.Index).Cells(4).Value.ToString.Equals("Azul") Then
                    dataFinalizado.Rows(row.Index).DefaultCellStyle.ForeColor = Color.White
                Else
                    dataFinalizado.Rows(row.Index).DefaultCellStyle.ForeColor = Color.Black
                End If
            Next

            ' Establecer la vista en las últimas filas
            If dataFinalizado.Rows.Count > 0 Then
                Dim lastRowIndex As Integer = dataFinalizado.Rows.Count - 1
                dataFinalizado.FirstDisplayedScrollingRowIndex = lastRowIndex
            End If

            DesmarcarFilaSeleccionada()

        Catch ex As Exception
            errores("Llenar lista.", Me.Name, ex.Message)
        End Try
    End Sub
    Sub espacio()
        Try
            Dim carro As Integer = 0
            Dim carroLlave As Integer = 0
            Dim moto As Integer = 0
            Dim motoLlave As Integer = 0
            Dim rs As New ADODB.Recordset
            rs.Open("Select * from espacio", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not rs.EOF Then
                carro = CInt(rs.Fields(0).Value)
                carroLlave = CInt(rs.Fields(1).Value)
                moto = CInt(rs.Fields(2).Value)
                motoLlave = CInt(rs.Fields(3).Value)

                If rs.State = 1 Then rs.Close()

                rs.Open("SELECT vehiculo, llave FROM ticket where estado = 'ACTIVO'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
                While Not rs.EOF
                    Select Case rs.Fields(0).Value.ToString
                        Case "Carro"
                            If rs.Fields(1).Value = 0 Then
                                carro -= 1
                            ElseIf rs.Fields(1).Value = 1 Then
                                carroLlave -= 1
                            End If

                        Case "Moto"
                            If rs.Fields(1).Value = 0 Then
                                moto -= 1
                            ElseIf rs.Fields(1).Value = 1 Then
                                motoLlave -= 1
                            End If

                    End Select

                    rs.MoveNext()
                End While

                txtCarroSin.Text = carro
                txtCarroCon.Text = carroLlave
                txtMotoSin.Text = moto

                If CInt(txtCarroSin.Text) <= 0 Then
                    txtCarroSin.BackColor = Color.OrangeRed
                Else
                    txtCarroSin.BackColor = Color.GreenYellow
                End If

                If CInt(txtCarroCon.Text) <= 0 Then
                    txtCarroCon.BackColor = Color.OrangeRed
                Else
                    txtCarroCon.BackColor = Color.GreenYellow
                End If

                If CInt(txtMotoSin.Text) <= 0 Then
                    txtMotoSin.BackColor = Color.OrangeRed
                Else
                    txtMotoSin.BackColor = Color.GreenYellow
                End If
            End If
            If rs.State = 1 Then rs.Close()

        Catch ex As Exception
            errores("Espacios disponibles.", Me.Name, ex.Message)
        End Try

    End Sub
    'BOTON GENERAR TICKET
    '--------------------------------------------------------------------------------------------------------------
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If Not txtVehiculo.Text.Length > 0 Then Exit Sub

        Try
            Dim id As Integer = 0
            Dim rsMax As New ADODB.Recordset
            rsMax.Open("Select ifnull(max(id) + 1, 1) from ticket", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            If Not rsMax.EOF Then
                id = CInt(rsMax.Fields(0).Value)
            End If
            If rsMax.State = 1 Then rsMax.Close()

            Dim barra As String = crearBarra(id)
            If barra <> 0 Then
                Dim rs As New ADODB.Recordset
                rs.Open("Select * from ticket where 1 = 0", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
                If rs.EOF Then
                    rs.AddNew()
                    rs.Fields("id").Value = id
                    'BARRA CONFORMADA POR: DIA MES AÑO ID Y DEBE TENER 16 CARACTERES.
                    '0707202310000000
                    rs.Fields("barra").Value = barra
                    rs.Fields("entrada").Value = Now
                    rs.Fields("salida").Value = Now
                    rs.Fields("fecha").Value = Now
                    rs.Fields("marca").Value = txtMarca.Text
                    rs.Fields("color").Value = txtColor.Text
                    rs.Fields("descripcion").Value = txtDescripcion.Text
                    rs.Fields("vehiculo").Value = txtVehiculo.Text
                    rs.Fields("total").Value = 0
                    rs.Fields("estado").Value = "ACTIVO"
                    rs.Fields("placa").Value = txtPlaca.Text
                    rs.Fields("tiempo").Value = ""
                    If CheckLlave.Checked = True Then
                        rs.Fields("llave").Value = 1
                    Else
                        rs.Fields("llave").Value = 0
                    End If
                    If SwitchEspecial.Checked = True Then
                        rs.Fields("especial").Value = 1
                    Else
                        rs.Fields("especial").Value = 0
                    End If
                    txtBarra.Text = barra
                    rs.Update()

                    llenarLista()
                    espacio()
                    If SwitchEspecial.Checked = False Then
                        etiqueta()
                    End If
                    limpiar()
                    txtColor.SelectedIndex = -1
                    txtMarca.SelectedIndex = -1
                    txtPlaca.Focus()
                End If
                If rs.State = 1 Then rs.Close()
            Else
                'Forzar una excepción por el error de la barra
                Throw New Exception("Error al crear barra: " & barra & ".")
            End If
        Catch ex As Exception
            errores("Generar ticket.", Me.Name, ex.Message)
        End Try
    End Sub
    Function crearBarra(ByVal id As String) As String
        crearBarra = "0"

        Dim fecha As DateTime = DateTime.Now.ToString("dd/MM/yyyy") ' O cualquier otra fecha que desees utilizar

        Dim dia As String = fecha.Day.ToString("00") ' Asegura que tenga 2 dígitos con ceros a la izquierda si es necesario
        Dim mes As String = fecha.Month.ToString("00") ' Asegura que tenga 2 dígitos con ceros a la izquierda si es necesario
        Dim año As String = fecha.Year.ToString("0000")

        While Not id.Length = 8
            If id.Length < 8 Then
                id &= "0"
            End If
        End While

        crearBarra = dia & mes & año & id

        If crearBarra.ToString.Length = 16 Then
            Return crearBarra
        Else
            Return 0
        End If
    End Function
    Sub finalizar(ByVal barra As String)
        Try
            Dim total As Double = 0
            Dim rs As New ADODB.Recordset
            rs.Open("Select * from ticket where barra = '" & txtBarra.Text & "'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
            If Not rs.EOF Then
                If rs.Fields("estado").Value.ToString <> "ACTIVO" Then
                    MsgBox("Ticket ya finalizado.!", MsgBoxStyle.Information, "TICKET FINALIZADO")
                    If rs.State = 1 Then rs.Close()
                    Exit Sub
                End If

                Dim horaSalida As DateTime = DateTime.Now.ToShortDateString() & " " & DateTime.Now.ToString("HH:mm")
                Dim horaEntrada As DateTime = Format(rs.Fields("entrada").Value, "dd-MM-yyyy HH:mm")

                Dim horaMensaje As String
                ' Obtener la fecha actual y combinarla con la hora actual formateada en 24 horas
                Dim diferenciaTiempo As TimeSpan = horaSalida - horaEntrada

                horaMensaje = "Tiempo transcurrido: " & diferenciaTiempo.Hours & ":" & diferenciaTiempo.Minutes & " minutos."
                Dim tiempo As String
                If diferenciaTiempo.Minutes.ToString.Length = 1 Then
                    tiempo = diferenciaTiempo.Hours & ":0" & diferenciaTiempo.Minutes
                Else
                    tiempo = diferenciaTiempo.Hours & ":" & diferenciaTiempo.Minutes
                End If

                Dim dias As Integer = diferenciaTiempo.Days
                Dim horas As Integer = diferenciaTiempo.Hours
                Dim minutos As Integer = diferenciaTiempo.Minutes
                Dim segundos As Integer = diferenciaTiempo.Seconds

                Dim precioHora As Double = 0
                Dim precioMedia As Double = 0

                Dim rsPrecio As New ADODB.Recordset
                rsPrecio.Open("Select * from precio where vehiculo = '" & rs.Fields("vehiculo").Value & "'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
                If Not rsPrecio.EOF Then
                    precioHora = rsPrecio.Fields("hora").Value
                    precioMedia = rsPrecio.Fields("media").Value
                End If
                If rsPrecio.State = 1 Then rsPrecio.Close()

                Dim mensaje As String = ""
                Dim fechaFin As TimeSpan = horaEntrada.TimeOfDay
                Dim nuevaDuracion As TimeSpan
                If precioHora > 0 And precioMedia > 0 Then
                    If minutos > 30 Then
                        horas += 1
                        band = True
                        If dias > 0 Then
                            horas += dias * 24
                        End If

                        'fechaFin = fechaFin.Add(TimeSpan.FromDays(dias))
                        fechaFin = fechaFin.Add(TimeSpan.FromHours(horas))

                        'agregar los minutos faltantes a la hora de salida. 60 - minutos
                        nuevaDuracion = diferenciaTiempo.Add(TimeSpan.FromMinutes((60 - minutos)))
                        If nuevaDuracion.Days > 0 Then
                            If nuevaDuracion.Hours = 1 Then
                                If nuevaDuracion.Days = 1 Then
                                    mensaje = "Cobro por: " & nuevaDuracion.Days & " día y " & nuevaDuracion.Hours & " hora."
                                Else
                                    mensaje = "Cobro por: " & nuevaDuracion.Days & " días y " & nuevaDuracion.Hours & " hora."
                                End If
                            Else
                                If nuevaDuracion.Days = 1 Then
                                    mensaje = "Cobro por: " & nuevaDuracion.Days & " día y " & nuevaDuracion.Hours & " horas con " & nuevaDuracion.Minutes & " minutos."
                                Else
                                    mensaje = "Cobro por: " & nuevaDuracion.Days & " días y " & nuevaDuracion.Hours & " horas con " & nuevaDuracion.Minutes & " minutos."
                                End If
                            End If
                        Else
                            If nuevaDuracion.Hours > 0 Then
                                If nuevaDuracion.Hours = 1 Then
                                    mensaje = "Cobro por: " & nuevaDuracion.Hours & " hora."
                                Else
                                    mensaje = "Cobro por: " & nuevaDuracion.Hours & " horas."
                                End If
                            End If
                        End If
                    ElseIf minutos <= 30 Then

                        If dias > 0 Then
                            horas += dias * 24
                        End If

                        fechaFin = fechaFin.Add(TimeSpan.FromHours(horas))
                        fechaFin = fechaFin.Add(TimeSpan.FromMinutes(30))

                        'AGREGAMOS PARA LOS MINUTOS COBRADOS.
                        total += precioMedia
                        nuevaDuracion = diferenciaTiempo.Add(TimeSpan.FromMinutes((30 - minutos)))

                        If nuevaDuracion.Days > 0 Then
                            If nuevaDuracion.Hours = 1 Then
                                If nuevaDuracion.Days = 1 Then
                                    mensaje = "Cobro por: " & nuevaDuracion.Days & " día y " & nuevaDuracion.Hours & " hora con " & nuevaDuracion.Minutes & " minutos."
                                End If
                            Else
                                If nuevaDuracion.Days = 1 Then
                                    mensaje = "Cobro por: " & nuevaDuracion.Days & " día y " & nuevaDuracion.Hours & " horas con " & nuevaDuracion.Minutes & " minutos."
                                Else
                                    mensaje = "Cobro por: " & nuevaDuracion.Days & " días y " & nuevaDuracion.Hours & " horas con " & nuevaDuracion.Minutes & " minutos."
                                End If
                            End If
                        Else
                            If nuevaDuracion.Hours > 0 Then
                                If nuevaDuracion.Hours = 1 Then
                                    mensaje = "Cobro por: " & nuevaDuracion.Hours & " hora con " & nuevaDuracion.Minutes & " minutos."
                                Else
                                    mensaje = "Cobro por: " & nuevaDuracion.Hours & " horas con " & nuevaDuracion.Minutes & " minutos."
                                End If
                            Else
                                mensaje = "Cobro por: " & nuevaDuracion.Minutes & " minutos."
                            End If
                        End If
                    End If

                    total += horas * precioHora

                    band = False
                    With FrmCobro
                        If horas > 0 Then
                            .LDescrip.Text = mensaje
                            .LTiempoExacto.Text = horaMensaje
                            .LCobro.Text = "Q" & total
                        Else
                            .LDescrip.Text = mensaje
                            .LTiempoExacto.Text = horaMensaje
                            .LCobro.Text = "Q" & total
                        End If
                        .ShowDialog()
                        .BringToFront()
                    End With
                Else
                    MsgBox("Por favor, verificar precios.!", MsgBoxStyle.Critical, "PRECIO INCORRECTO")
                End If

                If band Then
                    'If MsgBox("¿Desea finalizar el ticket seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "FINALIZAR TICKET") = vbYes Then
                    Dim fechaActual As DateTime = Now
                    Dim cadena As String = fechaActual.ToShortDateString
                    Dim salida As DateTime = cadena & " " & fechaFin.Hours & ":" & fechaFin.Minutes & ":" & Now.Second

                    Dim i As Integer = 0
                    Dim sql As String = "Update ticket set estado = 'FINALIZADO', salida = '" & Format(salida, "yyyy-MM-dd HH:mm:ss") & "', total = " & total & ", fecha = '" & Format(Now, "yyyy-MM-dd HH:mm:ss") & "', tiempo = '" & tiempo & "' WHERE barra = '" & txtBarra.Text & "'"
                    cnx.Execute(sql, i)
                    If Not i > 0 Then
                        MsgBox("No se pudo editar.!", MsgBoxStyle.Critical, "ERROR")
                    End If
                End If

                txtPlaca.Focus()
                txtPlaca.Clear()
                txtDescripcion.Clear()
                SwitchEspecial.Checked = False
                CheckLlave.Checked = False
                txtBarra.Clear()
                txtVehiculo.Text = "Carro"
                txtMarca.SelectedIndex = -1
                txtColor.SelectedIndex = -1

                llenarLista()
                espacio()
            End If
            If rs.State = 1 Then rs.Close()
        Catch ex As Exception
            errores("Calcular total.", Me.Name, ex.Message)
        End Try
    End Sub

    Sub limpiar()
        txtPlaca.Clear()
        txtDescripcion.Clear()
        CheckLlave.Checked = False
        txtBarra.Clear()
        txtVehiculo.Focus()
    End Sub
    '---------------------------------------------------------------------------------------------------------------
    'IMPRIMIR TICKET CON CODIGO DE BARRAS.
    Private printFont As Font
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim yPos As Integer = 5

        Dim rs As New ADODB.Recordset
        rs.Open("Select * from ticket where barra = '" & txtBarra.Text & "'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            If rs.Fields("llave").Value = 1 Then
                'IMPRIMIMOS EL CODIGO DE BARRA.
                e.Graphics.DrawImage(imagenKey.Image, 0, yPos, 20, 20)
            End If

            ' Fuente para el título en negrita
            Dim titleFont As New Font("Arial", 10, FontStyle.Bold)
            ' Fuente para el contenido en letra normal
            Dim contentFont As New Font("Arial", 7, FontStyle.Regular)

            ' Asignar la fuente al documento de impresión
            printFont = titleFont

            Dim leftMargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Left

            ' Obtener la anchura del texto
            Dim titleWidth As Single = e.Graphics.MeasureString("GRAN PARQUEO", printFont).Width
            Dim subTitleWidth As Single = e.Graphics.MeasureString("XELA CENTRO", printFont).Width

            ' Calcular la posición horizontal centrada
            Dim titleXPos As Single = (e.MarginBounds.Width - titleWidth) / 2
            Dim subTitleXPos As Single = (e.MarginBounds.Width - subTitleWidth) / 2

            ' Imprimir el título centrado
            e.Graphics.DrawString("GRAN PARQUEO", printFont, Brushes.Black, titleXPos, yPos)
            yPos += printFont.GetHeight(e.Graphics)

            ' Imprimir el subtítulo centrado
            e.Graphics.DrawString("XELA CENTRO", printFont, Brushes.Black, subTitleXPos, yPos)
            yPos += printFont.GetHeight(e.Graphics) + 5

            Dim rightMargin As Integer = e.PageBounds.Width

            ' Texto a imprimir
            Dim text As String = "10 Av. entre 7a y 8a. Calle Zona 1, Quetzaltenango sobre la terraza del Nuevo Mercado del Centro Zona 1" & vbCrLf & vbCrLf

            ' Centrar el texto verticalmente
            Dim textHeight As Single = printFont.GetHeight(e.Graphics)

            ' Imprimir el texto centrado
            e.Graphics.DrawString(text, contentFont, Brushes.Black, New RectangleF(leftMargin, yPos, rightMargin, e.PageBounds.Height))
            yPos += printFont.GetHeight(e.Graphics) * 2


            Dim letraNegrita As New Font("Arial", 8, FontStyle.Bold)

            If rs.Fields("especial").Value = 1 Then
                e.Graphics.DrawString("CLIENTE ESPECIAL", letraNegrita, Brushes.Black, New RectangleF(leftMargin, yPos, rightMargin, e.PageBounds.Height))
                yPos += contentFont.GetHeight(e.Graphics)
            End If

            ' Imprimir el texto centrado
            e.Graphics.DrawString("Fecha y hora de entrada:           Vehículo:", contentFont, Brushes.Black, New RectangleF(leftMargin, yPos, rightMargin, e.PageBounds.Height))
            yPos += contentFont.GetHeight(e.Graphics)

            e.Graphics.DrawString(Format(rs.Fields("entrada").Value, "dd-MM-yyyy hh:mm tt") & "         " & rs.Fields("vehiculo").Value, letraNegrita, Brushes.Black, New RectangleF(leftMargin, yPos, rightMargin, e.PageBounds.Height))
            yPos += contentFont.GetHeight(e.Graphics)

            ' Imprimi vehiculo
            e.Graphics.DrawString("Modelo y Color:", contentFont, Brushes.Black, New RectangleF(leftMargin, yPos, rightMargin, e.PageBounds.Height))
            yPos += contentFont.GetHeight(e.Graphics)

            e.Graphics.DrawString(rs.Fields("marca").Value.ToString & " - " & rs.Fields("color").Value, letraNegrita, Brushes.Black, New RectangleF(leftMargin, yPos, rightMargin, e.PageBounds.Height))
            yPos += contentFont.GetHeight(e.Graphics)

            ' Imprimir el texto centrado
            e.Graphics.DrawString(rs.Fields("vehiculo").Value & " con placas: ", contentFont, Brushes.Black, New RectangleF(leftMargin, yPos, rightMargin, e.PageBounds.Height))
            'yPos += contentFont.GetHeight(e.Graphics)

            e.Graphics.DrawString(rs.Fields("placa").Value, letraNegrita, Brushes.Black, New RectangleF(90, yPos, rightMargin, e.PageBounds.Height))
            yPos += printFont.GetHeight(e.Graphics) + 3

            'GENERAMOS EL CODIGO DE BARRA.
            ImagenBarra.Image = Nothing
            Dim generador As New BarcodeWriter
            generador.Format = BarcodeFormat.CODE_128
            ImagenBarra.Image = generador.Write(rs.Fields("barra").Value.ToString)

            'IMPRIMIMOS EL CODIGO DE BARRA.
            e.Graphics.DrawImage(ImagenBarra.Image, 50, yPos, 170, 70)

            text = "Tarifa: Q10.00 HORA, Q5.00 1/2 HORA O FRACCION" & vbCrLf &
                   "Horario de 7:00 a 18:45 horas, todos los dias."

            ' Centrar el texto verticalmente
            textHeight = printFont.GetHeight(e.Graphics)

            yPos += 70

            ' Imprimir el texto centrado
            e.Graphics.DrawString(text, contentFont, Brushes.Black, New RectangleF(leftMargin, yPos, rightMargin, e.PageBounds.Height))
            yPos += printFont.GetHeight(e.Graphics) + 10


            ' Obtener la anchura del texto de las "Condiciones"
            Dim conditionsWidth As Single = e.Graphics.MeasureString("C O N D I C I O N E S", contentFont).Width

            ' Calcular la posición horizontal centrada para el párrafo "Condiciones"
            Dim conditionsXPos As Single = (e.PageBounds.Width - conditionsWidth) / 2

            ' Obtener la altura del párrafo "Condiciones"
            Dim conditionsHeight As Single = e.Graphics.MeasureString("C O N D I C I O N E S", contentFont).Height

            ' Calcular la posición vertical para el párrafo "Condiciones" centrado
            Dim conditionsYPos As Single = e.PageBounds.Height - conditionsHeight - 10


            ' Imprimir el párrafo "Condiciones" centrado
            e.Graphics.DrawString("C O N D I C I O N E S", contentFont, Brushes.Black, conditionsXPos, yPos)
            yPos += printFont.GetHeight(e.Graphics) + 5

            text = "1. El vehículo se estaciona por cuenta y riesgo del propietario." & vbCrLf &
                    "2. Si el cliente extravía el ticket deberá demostrar " & vbCrLf & "fehacientemente la propiedad de su vehículo y cancelar la cantidad de Q10.00 más tiempo transcurrido." & vbCrLf &
                    "3. La empresa no se responsabiliza por daños causados a propiedades de terceras personas cuando estos sean " & vbCrLf & "producidos en circunstancias ajenas a este establecimiento." & vbCrLf &
                    "4. Los vehículos deben cerrarse con llave, la empresa no se responsabiliza por objetos dentro de los vehículos."

            ' Calcular la posición horizontal centrada para el párrafo "Condiciones"
            conditionsXPos = (e.PageBounds.Width - conditionsWidth) / 2

            ' Imprimir el texto centrado
            e.Graphics.DrawString(text, contentFont, Brushes.Black, New RectangleF(leftMargin, yPos, rightMargin, e.PageBounds.Height))
            yPos += printFont.GetHeight(e.Graphics) * 8
            e.Graphics.DrawString(".", contentFont, Brushes.Black, 0, yPos)
        End If
    End Sub
    Private Sub DesmarcarFilaSeleccionada()
        If ListHistorial.CurrentRow IsNot Nothing Then
            ListHistorial.CurrentRow.Selected = False
        End If

        If dataFinalizado.CurrentRow IsNot Nothing Then
            dataFinalizado.CurrentRow.Selected = False
        End If
    End Sub
    Private Sub dataFinalizado_MouseClick(sender As Object, e As MouseEventArgs) Handles dataFinalizado.MouseClick
        If dataFinalizado.CurrentRow IsNot Nothing Then
            txtBarra.Focus()
            txtBarra.Text = dataFinalizado.Rows(dataFinalizado.CurrentRow.Index).Cells(1).Value
        End If
    End Sub
    Private Sub dataFinalizado_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dataFinalizado.DataBindingComplete
        DesmarcarFilaSeleccionada()
    End Sub
End Class