Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Security.Cryptography
Imports ADODB

Module Generales
    Public usuId As String
    'Public cadena As String = "Driver=SQLite3 ODBC Driver;Database=C:\Parqueo\parqueo.s3db;"
    'Public cadena As String = "Provider=SQLiteOLEDB;;Database=C:\Parqueo\parqueo.s3db;"
    Public cnx As ADODB.Connection
    Public permiso As String
    Function conectar()
        Try
            cnx = New Connection
            'cnx.Open(cadena)
            'cnx.Open("DRIVER={MySQL ODBC 5.3 ANSI Driver};SERVER=127.0.0.1;DATABASE=parqueo;UID=root;PASSWORD=;")
            cnx.Open("Driver={MySQL ODBC 8.0 ANSI Driver};Server=127.0.0.1;Database=parqueo;UID=root;PASSWORD=ParqueoXela2023;")
            'cnx.Open("DRIVER={MySQL ODBC 5.3 ANSI Driver};SERVER=127.0.0.1;DATABASE=parqueo;UID=Peterguts;PASSWORD=Celada2002;")
            'cnx.Open("DRIVER={MySQL ODBC 5.3 ANSI Driver};SERVER=127.0.0.1;DATABASE=parqueo;UID=root;PASSWORD=;SSL Mode=NO;")
            If cnx.State = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function FormularioEstaAbierto(ByVal nombreFormulario As String) As Boolean
        For Each formulario As Form In My.Application.OpenForms
            If formulario.Name = nombreFormulario Then
                Return True
            End If
        Next

        Return False
    End Function
    Function crearBase() As Boolean
        crearBase = False
        'VERIFICAMOS QUE NO EXISTA LA BASE DE DATOS.
        If Not File.Exists("C:\Parqueo\parqueo.s3db") Then
            'CREAMOS LA CARPETA Y LA BASE DE DATOS.
            If Not Directory.Exists("C:\Parqueo") Then
                Directory.CreateDirectory("C:\Parqueo")

                If Directory.Exists("C:\Parqueo") Then
                    File.Create("C:\Parqueo\parqueo.s3db")
                End If
            End If
        End If

        If File.Exists("C:\Parqueo\parqueo.s3db") Then
            Dim conector As Connection
            conector = New Connection
            Try
                conector.Open("Driver=SQLite3 ODBC Driver;Database=C:\Parqueo\parqueo.s3db")
            Catch ex As Exception
                Application.Restart()
            End Try

            If conector.State = 1 Then
                Dim sql As String
                sql = "CREATE TABLE IF NOT EXISTS usuario (
                           login TEXT NOT NULL,
                           nombre TEXT DEFAULT NULL,
                           clave TEXT NOT NULL,
                           tipo TEXT NOT NULL,
                           PRIMARY KEY (login, tipo)
                       );"
                conector.Execute(sql)

                sql = "CREATE TABLE IF NOT EXISTS espacio (
                           carro INTEGER DEFAULT NULL,
                           carro_llave INTEGER DEFAULT NULL,
                           moto INTEGER DEFAULT NULL,
                           moto_llave INTEGER DEFAULT NULL
                       );"
                conector.Execute(sql)


                sql = "CREATE TABLE IF NOT EXISTS marca (
                        id INTEGER PRIMARY KEY,
                        marca TEXT NOT NULL,
                        modelo TEXT DEFAULT NULL,
                        descripcion TEXT DEFAULT ''
                       );"
                conector.Execute(sql)


                sql = "CREATE TABLE IF NOT EXISTS precio (
                           hora REAL NOT NULL,
                           media REAL NOT NULL
                       );"
                conector.Execute(sql)


                sql = "CREATE TABLE IF NOT EXISTS ticket (
                        id INTEGER NOT NULL,
                        barra TEXT NOT NULL,
                        entrada DATETIME DEFAULT NULL,
                        salida DATETIME DEFAULT NULL,
                        fecha DATETIME NOT NULL,
                        marca TEXT NOT NULL,
                        color TEXT DEFAULT NULL,
                        descripcion TEXT 'NULL' NULL,
                        total REAL DEFAULT NULL,
                        PRIMARY KEY (id, barra)
                       );"
                conector.Execute(sql)

                sql = "CREATE TABLE IF NOT EXISTS ticket_historico (
                        mes INTEGER NOT NULL,
                        anio INTEGER NOT NULL,
                        barra TEXT NOT NULL,
                        fecha DATETIME NOT NULL,
                        marca TEXT NOT NULL,
                        color TEXT DEFAULT NULL,
                        entrada DATETIME DEFAULT NULL,
                        salida DATETIME DEFAULT NULL,
                        descripcion TEXT 'NULL' NULL,
                        total REAL DEFAULT NULL,
                        PRIMARY KEY (mes, anio, barra)
                       );"
                conector.Execute(sql)

                crearBase = True

                If conector.State = 1 Then conector.Close()
            Else
                Application.Restart()
            End If
        End If
        Return crearBase
    End Function

    Function insertar(ByVal sql As String) As Boolean
        insertar = False
        Try
            If conectar() Then
                Dim i As Integer = 0
                cnx.Execute(sql, i)
                If i > 0 Then
                    insertar = True
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al ejecturar consulta: " & sql & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
        Return insertar
    End Function

    Sub errores(ByVal procedimiento As String, ByVal formulario As String, ByVal err As String)
        MsgBox("Procedimiento: " & procedimiento & vbCrLf & "Formulario: " & formulario & vbCrLf & "Error: " & err, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "ERROR")
        EnviarCorreo("Procedimiento: " & procedimiento & " Form: " & formulario & " Error: " & err)
    End Sub
    Public Sub EnviarCorreo(ByVal cuerpo As String)
        Try
            'Creación del mensaje
            Dim mensaje As New MailMessage()
            mensaje.Subject = "Error del programa parqueo"
            mensaje.Body = cuerpo & vbCrLf & Format(Now, "dd-MM-yyyy HH:mm")
            mensaje.IsBodyHtml = True
            'mensaje.Priority = System.Net.Mail.MailPriority.Normal
            mensaje.From = New MailAddress("xelacentroparqueo@gmail.com")
            mensaje.To.Add("pedrocelabeta@gmail.com")

            Dim smtp As New SmtpClient
            smtp.Credentials = New Net.NetworkCredential("xelacentroparqueo@gmail.com", "wmfxsjbjuinpfiwd")
            smtp.EnableSsl = True
            smtp.Host = "smtp.gmail.com"
            smtp.Port = 587
            smtp.Send(mensaje)
        Catch ex As Exception
            MsgBox("Error al enviar la notificacion del error.!", MsgBoxStyle.Critical, "ERROR")
        End Try
        'MsgBox("Correo enviado correctamente.!", MsgBoxStyle.Information, "CORREO ENVIADO")
    End Sub


    'Imports System.Security.Cryptography

    'Public Class Form1
    '    Private Sub btnGenerateBarcode_Click(sender As Object, e As EventArgs) Handles btnGenerateBarcode.Click
    '        Dim diaryId As String = "12345"
    '        Dim barcode As String = GenerateUniqueBarcode(diaryId)
    '        MessageBox.Show("Código de barras único: " & barcode)
    '    End Sub

    '    Private Function GenerateUniqueBarcode(data As String) As String
    '        ' Generar hash utilizando SHA-256
    '        Dim sha256Hash As SHA256 = SHA256.Create()
    '        Dim hashBytes As Byte() = sha256Hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(data))
    '        Dim hashString As String = BitConverter.ToString(hashBytes).Replace("-", "")

    '        ' Obtener los primeros 12 caracteres del hash como código de barras
    '        Dim barcode As String = hashString.Substring(0, 12)

    '        Return barcode
    '    End Function
    'End Class


End Module
