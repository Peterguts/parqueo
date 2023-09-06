Imports System.Drawing.Printing

Public Class FrmReportes
    Private Sub FrmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establecer la propiedad KeyPreview en True
        Me.KeyPreview = True

        If Not cnx.State = 1 Then
            If Not conectar() Then
                MsgBox("Error al intentar conecar la base de datos.!", MsgBoxStyle.Critical, "ERROR")
            End If
        End If
    End Sub
    Dim prtSettings As New PrinterSettings
    '----------------------------------------------------------------------------------------------------
    'BOTONES
    Private Sub btnGenerarDiario_Click(sender As Object, e As EventArgs) Handles btnGenerarDiario.Click
        Try
            If prtSettings Is Nothing Then
                prtSettings = New PrinterSettings
            End If

            If seleccionarImpresora() = False Then Return

            If PrintDocument1 Is Nothing Then
                PrintDocument1 = New System.Drawing.Printing.PrintDocument
                AddHandler PrintDocument1.PrintPage, AddressOf PrintDocument1_PrintPage
            End If

            Dim xCustomSize As New PaperSize("Custom", 300, 500)
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

        Catch ex As Exception
            errores("Imprimir.", Me.Name, ex.Message)
        End Try
        'Try
        '    'Dim rs As New ADODB.Recordset
        '    'rs.Open("Select * from ticket where fecha = '" & Format(txtFechaDiaria.Value, "yyyy-MM-dd") & "' and estado = 'ACTIVO'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        '    'If Not rs.EOF Then
        '    '    MsgBox("Existen documentos activos este día.!", MsgBoxStyle.Information, "TICKETS ACTIVOS")
        '    '    If rs.State = 1 Then rs.Close()
        '    '    Exit Sub
        '    'End If

        '    PrintDocument1.DefaultPageSettings.Margins.Bottom = 0
        '    PrintDocument1.DefaultPageSettings.Margins.Top = 5
        '    PrintDocument1.DefaultPageSettings.Margins.Left = 0
        '    PrintDocument1.DefaultPageSettings.Margins.Right = 0
        '    ' Configurar el tamaño del papel en función de los márgenes disponibles
        '    PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Custom", 200, 500)

        '    Dim printDialog1 As New PrintDialog()
        '    printDialog1.Document = PrintDocument1
        '    If printDialog1.ShowDialog() = DialogResult.OK Then
        '        Dim prtPrev As New PrintPreviewDialog
        '        prtPrev.Document = PrintDocument1
        '        prtPrev.Text = "Previsualizar documento"
        '        prtPrev.Width = (Screen.PrimaryScreen.WorkingArea.Width)
        '        prtPrev.Height = (Screen.PrimaryScreen.WorkingArea.Height)
        '        prtPrev.PrintPreviewControl.Zoom = 1.0
        '        prtPrev.WindowState = FormWindowState.Maximized
        '        prtPrev.ShowDialog()
        '    End If

        'Catch ex As Exception
        '    errores("Calcular total.", Me.Name, ex.Message)
        'End Try
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
            'With prtDialog
            '    .AllowPrintToFile = False
            '    .AllowSelection = False
            '    .AllowSomePages = False
            '    .PrintToFile = False
            '    .ShowHelp = False
            '    .ShowNetwork = True

            '    .PrinterSettings = prtSettings

            '    If .ShowDialog() = DialogResult.OK Then
            '        prtSettings = .PrinterSettings
            '    Else
            '        Return False
            '    End If
            'End With

            Return True
        Catch ex As Exception
            errores("Obtener impresora", Me.Name, Err.Description)
            Return False
        End Try
    End Function
    Private Sub btnGenerarFechas_Click(sender As Object, e As EventArgs) Handles btnGenerarFechas.Click
        Try
            If prtSettings Is Nothing Then
                prtSettings = New PrinterSettings
            End If

            If seleccionarImpresora() = False Then Return

            If PrintDocument2 Is Nothing Then
                PrintDocument2 = New System.Drawing.Printing.PrintDocument
                AddHandler PrintDocument2.PrintPage, AddressOf PrintDocument1_PrintPage
            End If

            Dim xCustomSize As New PaperSize("Custom", 300, 500)
            prtSettings.DefaultPageSettings.Margins.Bottom = 15
            prtSettings.DefaultPageSettings.Margins.Top = 0
            prtSettings.DefaultPageSettings.Margins.Left = 10
            prtSettings.DefaultPageSettings.Margins.Right = 0
            prtSettings.DefaultPageSettings.PaperSize = xCustomSize
            prtSettings.DefaultPageSettings.Landscape = False
            PrintDocument2.PrinterSettings = prtSettings

            ' Imprimir el documento
            PrintDocument2.Print()

            Me.BringToFront()

        Catch ex As Exception
            errores("Imprimir.", Me.Name, ex.Message)
        End Try


        'Try
        '    PrintDocument2.DefaultPageSettings.Margins.Bottom = 0
        '    PrintDocument2.DefaultPageSettings.Margins.Top = 5
        '    PrintDocument2.DefaultPageSettings.Margins.Left = 0
        '    PrintDocument2.DefaultPageSettings.Margins.Right = 0
        '    ' Configurar el tamaño del papel en función de los márgenes disponibles
        '    PrintDocument2.DefaultPageSettings.PaperSize = New PaperSize("Custom", 200, 500)

        '    Dim printDialog2 As New PrintDialog()
        '    printDialog2.Document = PrintDocument2
        '    If printDialog2.ShowDialog() = DialogResult.OK Then
        '        Dim prtPrev As New PrintPreviewDialog
        '        prtPrev.Document = PrintDocument2
        '        prtPrev.Text = "Previsualizar documento"
        '        prtPrev.Width = (Screen.PrimaryScreen.WorkingArea.Width)
        '        prtPrev.Height = (Screen.PrimaryScreen.WorkingArea.Height)
        '        prtPrev.PrintPreviewControl.Zoom = 1.0
        '        prtPrev.WindowState = FormWindowState.Maximized
        '        prtPrev.ShowDialog()
        '    End If
        'Catch ex As Exception
        '    errores("Calcular total.", Me.Name, ex.Message)
        'End Try
    End Sub

    '----------------------------------------------------------------------------------------------------
    'IMPRESION
    'REPORTE DIARIO
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim printFont As Font
        Dim yPos As Integer = 15
        Dim xPos As Integer = 5
        ' Fuente para el título en negrita
        Dim titleFont As New Font("Arial", 10, FontStyle.Bold)
        ' Fuente para el título en negrita
        Dim subTitleFont As New Font("Arial", 6.8, FontStyle.Bold)
        ' Fuente para el contenido en letra normal
        Dim contentFont As New Font("Arial", 8, FontStyle.Regular)

        ' Asignar la fuente al documento de impresión
        printFont = titleFont

        ' Imprimir el título centrado
        e.Graphics.DrawString("REPORTE ACTUAL", printFont, Brushes.Black, xPos, yPos)
        yPos += printFont.GetHeight(e.Graphics) + 5

        ' Asignar la fuente al documento de impresión
        printFont = titleFont

        e.Graphics.DrawString("Impresión: ", contentFont, Brushes.Black, xPos, yPos)
        e.Graphics.DrawString(Format(Now, "dd/MM/yyyy hh:mm tt"), subTitleFont, Brushes.Black, xPos + 65, yPos)
        yPos += subTitleFont.GetHeight(e.Graphics)

        e.Graphics.DrawString("Fecha para reporte: ", contentFont, Brushes.Black, xPos, yPos)
        e.Graphics.DrawString(Format(txtFechaDiaria.Value, "dd/MM/yyyy"), subTitleFont, Brushes.Black, xPos + 110, yPos)
        yPos += subTitleFont.GetHeight(e.Graphics) + 10

        'ANULADOS
        Dim rs As New ADODB.Recordset
        cnx.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Dim fecha As Date = txtFechaDiaria.Value
        rs.Open("Select ifnull(count(*), 0) as contador, ifnull(sum(total), 0) as totales from parqueo.ticket where DATE(fecha) = '" & Format(fecha, "yyyy-MM-dd") & "' and estado = 'ANULADO'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rs.Fields(0).Value > 0 Then
            e.Graphics.DrawString("TICKETS ANULADOS (" & rs.Fields(0).Value & ")", subTitleFont, Brushes.Black, xPos, yPos)
            yPos += subTitleFont.GetHeight(e.Graphics) + 3

            e.Graphics.DrawString("Suma total: ", subTitleFont, Brushes.Black, xPos, yPos)
            e.Graphics.DrawString("Q" & rs.Fields(1).Value, subTitleFont, Brushes.Black, xPos + 130, yPos)
            yPos += subTitleFont.GetHeight(e.Graphics) + 5
        End If
        If rs.State = 1 Then rs.Close()

        'ESPECIALES
        rs.Open("Select ifnull(count(*), 0) as contador, ifnull(sum(total), 0) as totales from parqueo.ticket where DATE(fecha) = '" & Format(fecha, "yyyy-MM-dd") & "' and especial = 1 and estado = 'FINALIZADO'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rs.Fields(0).Value > 0 Then
            e.Graphics.DrawString("TICKETS ESPECIALES (" & rs.Fields(0).Value & ")", subTitleFont, Brushes.Black, xPos, yPos)
            yPos += subTitleFont.GetHeight(e.Graphics) + 3

            e.Graphics.DrawString("Suma total: ", subTitleFont, Brushes.Black, xPos, yPos)
            e.Graphics.DrawString("Q" & rs.Fields(1).Value, subTitleFont, Brushes.Black, xPos + 130, yPos)
            yPos += subTitleFont.GetHeight(e.Graphics) + 5
        End If
        If rs.State = 1 Then rs.Close()

        'ACTIVOS
        rs.Open("Select ifnull(count(*), 0) as contador, ifnull(sum(total), 0) as totales from ticket where DATE(fecha) = '" & Format(txtFechaDiaria.Value, "yyyy-MM-dd") & "' and estado = 'ACTIVO'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rs.Fields(0).Value > 0 Then
            e.Graphics.DrawString("TICKETS ACTIVOS (" & rs.Fields(0).Value & ")", subTitleFont, Brushes.Black, xPos, yPos)
            yPos += subTitleFont.GetHeight(e.Graphics) + 3

            e.Graphics.DrawString("Suma total: ", subTitleFont, Brushes.Black, xPos, yPos)
            e.Graphics.DrawString("Q" & rs.Fields(1).Value, subTitleFont, Brushes.Black, xPos + 130, yPos)
            yPos += subTitleFont.GetHeight(e.Graphics) + 5
        End If
        If rs.State = 1 Then rs.Close()

        'FINALIZADOS
        rs.Open("Select ifnull(count(*), 0) as contador, ifnull(sum(total), 0) as totales from parqueo.ticket where DATE(fecha) = '" & Format(fecha, "yyyy-MM-dd") & "' and estado = 'FINALIZADO' and especial = 0", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rs.Fields(0).Value > 0 Then
            e.Graphics.DrawString("TICKETS FINALIZADOS (" & rs.Fields(0).Value & ")", subTitleFont, Brushes.Black, xPos, yPos)
            yPos += subTitleFont.GetHeight(e.Graphics) + 3

            e.Graphics.DrawString("Suma total: ", subTitleFont, Brushes.Black, xPos, yPos)
            e.Graphics.DrawString("Q" & rs.Fields(1).Value, subTitleFont, Brushes.Black, xPos + 130, yPos)
            yPos += subTitleFont.GetHeight(e.Graphics) + 5
        End If
        If rs.State = 1 Then rs.Close()

        e.Graphics.DrawString("Impreso por el usuario: " & usuId, contentFont, Brushes.Black, xPos, yPos)
        e.Graphics.DrawString(".", contentFont, Brushes.Black, xPos, yPos + 20)
    End Sub
    'REPORTE POR FECHAS
    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim printFont As Font
        Dim yPos As Integer = 15
        Dim xPos As Integer = 5
        ' Fuente para el título en negrita
        Dim titleFont As New Font("Arial", 10, FontStyle.Bold)
        ' Fuente para el título en negrita
        Dim subTitleFont As New Font("Arial", 6.8, FontStyle.Bold)
        ' Fuente para el contenido en letra normal
        Dim contentFont As New Font("Arial", 8, FontStyle.Regular)

        ' Asignar la fuente al documento de impresión
        printFont = titleFont

        ' Imprimir el título centrado
        e.Graphics.DrawString("REPORTE HISTORICO", printFont, Brushes.Black, xPos, yPos)
        yPos += printFont.GetHeight(e.Graphics) + 5

        ' Asignar la fuente al documento de impresión
        printFont = titleFont

        e.Graphics.DrawString("Impreso: ", contentFont, Brushes.Black, xPos, yPos)
        e.Graphics.DrawString(Format(Now, "dd/MM/yyyy hh:mm tt"), subTitleFont, Brushes.Black, xPos + 65, yPos)
        yPos += subTitleFont.GetHeight(e.Graphics)

        e.Graphics.DrawString("Fecha para reporte: ", contentFont, Brushes.Black, xPos, yPos)
        e.Graphics.DrawString(Format(txtFechaDiaria.Value, "dd/MM/yyyy"), subTitleFont, Brushes.Black, xPos + 110, yPos)
        yPos += subTitleFont.GetHeight(e.Graphics) + 10

        'ANULADOS
        Dim rs As New ADODB.Recordset
        cnx.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Dim fecha As Date = txtFechaInicio.Value
        rs.Open("Select ifnull(count(*), 0) as contador, ifnull(sum(total), 0) as totales from parqueo.ticket_historico where DATE(fecha) = '" & Format(fecha, "yyyy-MM-dd") & "' and estado = 'ANULADO'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rs.Fields(0).Value > 0 Then
            e.Graphics.DrawString("TICKETS ANULADOS (" & rs.Fields(0).Value & ")", subTitleFont, Brushes.Black, xPos, yPos)
            yPos += subTitleFont.GetHeight(e.Graphics) + 3

            e.Graphics.DrawString("Suma total: ", subTitleFont, Brushes.Black, xPos, yPos)
            e.Graphics.DrawString("Q" & rs.Fields(1).Value, subTitleFont, Brushes.Black, xPos + 130, yPos)
            yPos += subTitleFont.GetHeight(e.Graphics) + 5
        End If
        If rs.State = 1 Then rs.Close()

        'ESPECIALES
        rs.Open("Select ifnull(count(*), 0) as contador, ifnull(sum(total), 0) as totales from parqueo.ticket_historico where DATE(fecha) = '" & Format(fecha, "yyyy-MM-dd") & "' and especial = 1 and estado = 'FINALIZADO'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rs.Fields(0).Value > 0 Then
            e.Graphics.DrawString("TICKETS ESPECIALES (" & rs.Fields(0).Value & ")", subTitleFont, Brushes.Black, xPos, yPos)
            yPos += subTitleFont.GetHeight(e.Graphics) + 3

            e.Graphics.DrawString("Suma total: ", subTitleFont, Brushes.Black, xPos, yPos)
            e.Graphics.DrawString("Q" & rs.Fields(1).Value, subTitleFont, Brushes.Black, xPos + 130, yPos)
            yPos += subTitleFont.GetHeight(e.Graphics) + 5
        End If
        If rs.State = 1 Then rs.Close()

        'ACTIVOS
        rs.Open("Select ifnull(count(*), 0) as contador, ifnull(sum(total), 0) as totales from ticket_historico where DATE(fecha) = '" & Format(txtFechaDiaria.Value, "yyyy-MM-dd") & "' and estado = 'ACTIVO'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rs.Fields(0).Value > 0 Then
            e.Graphics.DrawString("TICKETS ACTIVOS (" & rs.Fields(0).Value & ")", subTitleFont, Brushes.Black, xPos, yPos)
            yPos += subTitleFont.GetHeight(e.Graphics) + 3

            e.Graphics.DrawString("Suma total: ", subTitleFont, Brushes.Black, xPos, yPos)
            e.Graphics.DrawString("Q" & rs.Fields(1).Value, subTitleFont, Brushes.Black, xPos + 130, yPos)
            yPos += subTitleFont.GetHeight(e.Graphics) + 5
        End If
        If rs.State = 1 Then rs.Close()

        'FINALIZADOS
        rs.Open("Select ifnull(count(*), 0) as contador, ifnull(sum(total), 0) as totales from parqueo.ticket_historico where DATE(fecha) = '" & Format(fecha, "yyyy-MM-dd") & "' and estado = 'FINALIZADO' and especial = 0", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If rs.Fields(0).Value > 0 Then
            e.Graphics.DrawString("TICKETS FINALIZADOS (" & rs.Fields(0).Value & ")", subTitleFont, Brushes.Black, xPos, yPos)
            yPos += subTitleFont.GetHeight(e.Graphics) + 3

            e.Graphics.DrawString("Suma total: ", subTitleFont, Brushes.Black, xPos, yPos)
            e.Graphics.DrawString("Q" & rs.Fields(1).Value, subTitleFont, Brushes.Black, xPos + 130, yPos)
            yPos += subTitleFont.GetHeight(e.Graphics) + 5
        End If
        If rs.State = 1 Then rs.Close()

        e.Graphics.DrawString("Impreso por el usuario: " & usuId, contentFont, Brushes.Black, xPos, yPos)
        e.Graphics.DrawString(".", contentFont, Brushes.Black, xPos, yPos + 20)
    End Sub
End Class