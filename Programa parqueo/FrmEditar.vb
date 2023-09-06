Imports System.Net.Http.Headers
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports Microsoft.Win32

Public Class FrmEditar
    Public usuario As String = ""
    Public clave As String = ""
    Private Sub FrmEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establecer la propiedad KeyPreview en True
        Me.KeyPreview = True

        If Not cnx.State = 1 Then
            If Not conectar() Then
                MsgBox("Error al intentar conecar la base de datos.!", MsgBoxStyle.Critical, "ERROR")
            End If
        End If
        txtVehiculo.Focus()
    End Sub

    '--------------------------------------------------------------------------------------------------------------
    'EVENTOS
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Me.Close()
    End Sub
    Private Sub txtColor_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtColor.SelectedValueChanged
        Try
            ' Obtener el color seleccionado del ComboBox
            Dim colorName As String = txtColor.SelectedItem.ToString()

            ' Validar el color seleccionado utilizando una estructura Select Case
            Select Case colorName
                Case "Blanco"
                    txtColor.BaseColor = Color.FromArgb(255, 255, 255)
                    'txtColor.BorderColor = Color.FromArgb(0, 0, 0)
                Case "Negro"
                    txtColor.BaseColor = Color.FromArgb(0, 0, 0)
                    'txtColor.BorderColor = Color.FromArgb(0, 0, 0)
                Case "Gris"
                    txtColor.BaseColor = Color.FromArgb(128, 128, 128)
                    'txtColor.BorderColor = Color.FromArgb(128, 128, 128)
                Case "Plateado"
                    txtColor.BaseColor = Color.FromArgb(192, 192, 192)
                    'txtColor.BorderColor = Color.FromArgb(192, 192, 192)
                Case "Azul"
                    txtColor.BaseColor = Color.FromArgb(0, 0, 255)
                    'txtColor.BorderColor = Color.FromArgb(0, 0, 255)
                Case "Rojo"
                    txtColor.BaseColor = Color.FromArgb(255, 0, 0)
                    'txtColor.BorderColor = Color.FromArgb(255, 0, 0)
                Case "Verde"
                    txtColor.BaseColor = Color.FromArgb(0, 128, 0)
                    'txtColor.BorderColor = Color.FromArgb(0, 128, 0)
                Case "Marrón"
                    txtColor.BaseColor = Color.FromArgb(165, 42, 42)
                    'txtColor.BorderColor = Color.FromArgb(165, 42, 42)
                Case "Beige"
                    txtColor.BaseColor = Color.FromArgb(245, 245, 220)
                   ' txtColor.BorderColor = Color.FromArgb(245, 245, 220)
                Case "Dorado"
                    txtColor.BaseColor = Color.FromArgb(255, 215, 0)
                   ' txtColor.BorderColor = Color.FromArgb(255, 215, 0)
                Case "Amarillo"
                    txtColor.BaseColor = Color.FromArgb(255, 255, 0)
                    'txtColor.BorderColor = Color.FromArgb(255, 255, 0)
                Case "Naranja"
                    txtColor.BaseColor = Color.FromArgb(255, 165, 0)
                    'txtColor.BorderColor = Color.FromArgb(255, 165, 0)
                Case "Plata"
                    txtColor.BaseColor = Color.FromArgb(192, 192, 192)
                    'txtColor.BorderColor = Color.FromArgb(192, 192, 192)
                Case "Bronce"
                    txtColor.BaseColor = Color.FromArgb(205, 127, 50)
                   ' txtColor.BorderColor = Color.FromArgb(205, 127, 50)
                Case "Champagne"
                    txtColor.BaseColor = Color.FromArgb(247, 231, 206)
                    'txtColor.BorderColor = Color.FromArgb(247, 231, 206)
                Case "Verde oliva"
                    txtColor.BaseColor = Color.FromArgb(128, 128, 0)
                    'txtColor.BorderColor = Color.FromArgb(128, 128, 0)
                Case "Azul marino"
                    txtColor.BaseColor = Color.FromArgb(0, 0, 128)
                    'txtColor.BorderColor = Color.FromArgb(0, 0, 128)
                Case "Granate"
                    txtColor.BaseColor = Color.FromArgb(128, 0, 0)
                    'txtColor.BorderColor = Color.FromArgb(128, 0, 0)
                Case "Azul claro"
                    txtColor.BaseColor = Color.FromArgb(135, 206, 250)
                   ' txtColor.BorderColor = Color.FromArgb(135, 206, 250)
                Case "Gris oscuro"
                    txtColor.BaseColor = Color.FromArgb(64, 64, 64)
                   ' txtColor.BorderColor = Color.FromArgb(64, 64, 64)
                Case "Azul metálico"
                    txtColor.BaseColor = Color.FromArgb(0, 47, 167)
                    'txtColor.BorderColor = Color.FromArgb(0, 47, 167)
                Case "Verde oscuro"
                    txtColor.BaseColor = Color.FromArgb(0, 100, 0)
                    'txtColor.BorderColor = Color.FromArgb(0, 100, 0)
                Case "Burdeos"
                    txtColor.BaseColor = Color.FromArgb(128, 0, 32)
                   ' txtColor.BorderColor = Color.FromArgb(128, 0, 32)
                Case "Verde claro"
                    txtColor.BaseColor = Color.FromArgb(144, 238, 144)
                   ' txtColor.BorderColor = Color.FromArgb(144, 238, 144)
                Case "Marrón oscuro"
                    txtColor.BaseColor = Color.FromArgb(101, 67, 33)
                   ' txtColor.BorderColor = Color.FromArgb(101, 67, 33)
                Case "Blanco perla"
                    txtColor.BaseColor = Color.FromArgb(234, 224, 200)
                   ' txtColor.BorderColor = Color.FromArgb(234, 224, 200)
                Case "Negro metálico"
                    txtColor.BaseColor = Color.FromArgb(26, 31, 32)
                    txtColor.BorderColor = Color.FromArgb(26, 31, 32)
                Case "Rojo fuego"
                    txtColor.BaseColor = Color.FromArgb(178, 34, 34)
                   ' txtColor.BorderColor = Color.FromArgb(178, 34, 34)
                Case "Gris claro"
                    txtColor.BaseColor = Color.FromArgb(211, 211, 211)
                   ' txtColor.BorderColor = Color.FromArgb(211, 211, 211)
                Case "Azul eléctrico"
                    txtColor.BaseColor = Color.FromArgb(0, 0, 255)
                    ' txtColor.BorderColor = Color.FromArgb(0, 0, 255)
                    ' Agregar más casos para el resto de los colores
            End Select

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
    Private Sub txtVehiculo_Enter(sender As Object, e As EventArgs) Handles txtVehiculo.Enter
        txtVehiculo.BorderColor = Color.Black
    End Sub
    Private Sub txtMarca_Enter(sender As Object, e As EventArgs) Handles txtMarca.Enter
        txtMarca.BorderColor = Color.Black
    End Sub
    Private Sub txtColor_Enter(sender As Object, e As EventArgs) Handles txtColor.Enter
        txtColor.BorderColor = Color.Black
    End Sub
    Private Sub txtVehiculo_Leave(sender As Object, e As EventArgs) Handles txtVehiculo.Leave
        txtVehiculo.BorderColor = Color.Silver
    End Sub
    Private Sub txtMarca_Leave(sender As Object, e As EventArgs) Handles txtMarca.Leave
        txtMarca.BorderColor = Color.Silver
    End Sub
    Private Sub txtColor_Leave(sender As Object, e As EventArgs) Handles txtColor.Leave
        txtColor.BorderColor = Color.Silver
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If LEstado.Text <> "FINALIZADO" And LEstado.Text <> "ANULADO" Then
                If MsgBox("Desea modificar el ticket seleccionado.!", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "MODIFICAR TICKET") = vbYes Then
                    Dim i As Integer = 0
                    Dim llave As Integer = 0
                    Dim especial As Integer = 0
                    If CheckLlave.Checked = True Then
                        llave = 1
                    End If
                    If switchEspecial.Checked = True Then
                        especial = 1
                    End If

                    cnx.Execute("Update ticket set vehiculo = '" & txtVehiculo.Text & "', marca = '" & txtMarca.Text & "', color = '" & txtColor.Text & "', llave = " & llave & ", placa = '" & txtPlaca.Text & "', descripcion = '" & txtObservaviones.Text & "', especial = " & especial & " where id = '" & LId.Text & "' and barra = '" & LBarra.Text & "'", i)
                    If i > 0 Then
                        MsgBox("Se guardo correctamente.!", MsgBoxStyle.Information, "GUARDADO")
                        Me.Close()
                        If FormularioEstaAbierto("FrmTicket") Then
                            FrmTicket.BringToFront()
                        Else
                            FrmTicket.Show()
                            FrmTicket.BringToFront()
                        End If
                    Else
                        'Forzar una excepción por el error de la barra
                        Throw New Exception("Error al modificar.")
                    End If
                End If
            Else
                MsgBox("Ticket no puede ser modificado.!", MsgBoxStyle.Critical, "NO ES POSIBLE MODIFICAR")
            End If

        Catch ex As Exception
            errores("Editar ticket.", Me.Name, ex.Message)
        End Try
    End Sub
    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Try
            If LEstado.Text <> "ANULADO" Then
                If MsgBox("¿Desea ANULAR el ticket seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "ANULAR TICKET") = vbYes Then
                    Dim rs As New ADODB.Recordset
                    rs.Open("Select * from usuario where login = '" & usuId & "'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
                    If Not rs.EOF Then
                        If Not rs.Fields("tipo").Value.ToString = "ADMINISTRADOR" Then
                            MsgBox("Usuario sin permiso necesarios.!", MsgBoxStyle.Critical, "FALTA DE PERMISO")
                            Exit Sub
                        End If
                        Dim i As Integer = 0
                        cnx.Execute("Update ticket set estado = 'ANULADO' where id = '" & LId.Text & "' and barra = '" & LBarra.Text & "'", i)
                        If i > 0 Then
                            MsgBox("Se guardo correctamente.!", MsgBoxStyle.Information, "GUARDADO")
                            Me.Close()
                            If FormularioEstaAbierto("FrmTicket") Then
                                FrmTicket.llenarLista()
                                FrmTicket.espacio()
                                FrmTicket.BringToFront()
                            Else
                                FrmTicket.Show()
                                FrmTicket.BringToFront()
                            End If
                        Else
                            'Forzar una excepción por el error de la barra
                            Throw New Exception("Error al anular.")
                        End If
                    Else
                        MsgBox("Contraseña incorrecta.!", MsgBoxStyle.Critical, "ERROR")
                        Exit Sub
                    End If
                    'Else
                    '    MsgBox("Debe ingresar una contraseña.!", MsgBoxStyle.Critical, "ERROR")
                    '    btnAnular.PerformClick()
                    'End If
                End If
            Else
                MsgBox("Ticket ya esta anulado.!", MsgBoxStyle.Critical, "TICKET")
            End If
        Catch ex As Exception
            errores("Editar ticket.", Me.Name, ex.Message)
        End Try
    End Sub


    'FUNCIONES
    '--------------------------------------------------------------------------------------------------------------
    Sub llenarMarca()
        Try
            txtMarca.Items.Clear()
            Dim rs As New ADODB.Recordset
            rs.Open("Select concat(marca, ' ', modelo) as Marca from marca where vehiculo = '" & txtVehiculo.Text & "'", cnx, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            While Not rs.EOF
                txtMarca.Items.Add(rs.Fields(0).Value)
                rs.MoveNext()
            End While
        Catch ex As Exception
            errores("Llenar marca", Me.Name, ex.Message)
        End Try
    End Sub
    Private Sub FrmEditar_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Evita que se emita el sonido de Windows al presionar Enter

            Dim currentControl As Control = Me.ActiveControl
            Me.SelectNextControl(currentControl, True, True, True, True)
        End If
    End Sub
    Public Function GetPassword() As String
        Dim password As String = String.Empty

        Dim passwordBox As New MaskedTextBox()
        passwordBox.PasswordChar = "*"c

        Dim prompt As String = "Ingrese la contraseña:"
        Dim caption As String = "Contraseña requerida"

        Dim result As DialogResult = MessageBox.Show(passwordBox, prompt, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        If result = DialogResult.OK Then
            password = passwordBox.Text
        End If

        Return password
    End Function

End Class