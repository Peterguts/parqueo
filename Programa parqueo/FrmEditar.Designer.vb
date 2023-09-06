<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEditar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtVehiculo = New Guna.UI.WinForms.GunaComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMarca = New Guna.UI.WinForms.GunaComboBox()
        Me.txtColor = New Guna.UI.WinForms.GunaComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtObservaviones = New System.Windows.Forms.TextBox()
        Me.CheckLlave = New Guna.UI.WinForms.GunaSwitch()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEntrada = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSalida = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBarra = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnGuardar = New Guna.UI.WinForms.GunaButton()
        Me.LEstado = New System.Windows.Forms.Label()
        Me.LId = New System.Windows.Forms.Label()
        Me.btnAnular = New Guna.UI.WinForms.GunaButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.switchEspecial = New Guna.UI.WinForms.GunaSwitch()
        Me.SuspendLayout()
        '
        'txtVehiculo
        '
        Me.txtVehiculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVehiculo.BackColor = System.Drawing.Color.Transparent
        Me.txtVehiculo.BaseColor = System.Drawing.Color.White
        Me.txtVehiculo.BorderColor = System.Drawing.Color.Silver
        Me.txtVehiculo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtVehiculo.FocusedColor = System.Drawing.Color.Empty
        Me.txtVehiculo.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVehiculo.ForeColor = System.Drawing.Color.Black
        Me.txtVehiculo.FormattingEnabled = True
        Me.txtVehiculo.Items.AddRange(New Object() {"Carro", "Moto"})
        Me.txtVehiculo.Location = New System.Drawing.Point(39, 134)
        Me.txtVehiculo.Name = "txtVehiculo"
        Me.txtVehiculo.OnHoverItemBaseColor = System.Drawing.Color.Cyan
        Me.txtVehiculo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.txtVehiculo.Radius = 2
        Me.txtVehiculo.Size = New System.Drawing.Size(120, 31)
        Me.txtVehiculo.StartIndex = 0
        Me.txtVehiculo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(35, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 21)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Vehículo:"
        '
        'txtMarca
        '
        Me.txtMarca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarca.BackColor = System.Drawing.Color.Transparent
        Me.txtMarca.BaseColor = System.Drawing.Color.White
        Me.txtMarca.BorderColor = System.Drawing.Color.Silver
        Me.txtMarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtMarca.FocusedColor = System.Drawing.Color.Empty
        Me.txtMarca.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.ForeColor = System.Drawing.Color.Black
        Me.txtMarca.FormattingEnabled = True
        Me.txtMarca.Location = New System.Drawing.Point(166, 134)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.OnHoverItemBaseColor = System.Drawing.Color.Cyan
        Me.txtMarca.OnHoverItemForeColor = System.Drawing.Color.White
        Me.txtMarca.Radius = 2
        Me.txtMarca.Size = New System.Drawing.Size(216, 31)
        Me.txtMarca.TabIndex = 5
        '
        'txtColor
        '
        Me.txtColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtColor.BackColor = System.Drawing.Color.Transparent
        Me.txtColor.BaseColor = System.Drawing.Color.White
        Me.txtColor.BorderColor = System.Drawing.Color.Silver
        Me.txtColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtColor.FocusedColor = System.Drawing.Color.Transparent
        Me.txtColor.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.ForeColor = System.Drawing.Color.Black
        Me.txtColor.FormattingEnabled = True
        Me.txtColor.Items.AddRange(New Object() {"Blanco", "Negro", "Gris", "Plateado", "Azul", "Rojo", "Verde", "Marrón", "Beige", "Dorado", "Amarillo", "Naranja", "Plata", "Bronce", "Champagne", "Verde oliva", "Azul marino", "Granate", "Azul claro", "Gris oscuro", "Azul metálico", "Verde oscuro", "Burdeos", "Verde claro", "Marrón oscuro", "Blanco perla", "Negro metálico", "Rojo fuego", "Gris claro", "Azul eléctrico", "Otro"})
        Me.txtColor.Location = New System.Drawing.Point(388, 134)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.OnHoverItemBaseColor = System.Drawing.Color.Aqua
        Me.txtColor.OnHoverItemForeColor = System.Drawing.Color.White
        Me.txtColor.Radius = 2
        Me.txtColor.Size = New System.Drawing.Size(195, 31)
        Me.txtColor.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(375, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 21)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Color:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(157, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 21)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Marca:"
        '
        'txtPlaca
        '
        Me.txtPlaca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPlaca.BackColor = System.Drawing.Color.White
        Me.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaca.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.ForeColor = System.Drawing.Color.Black
        Me.txtPlaca.Location = New System.Drawing.Point(39, 202)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(135, 30)
        Me.txtPlaca.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(35, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 21)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Placa:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(229, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 37)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Editar ticket"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(35, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 21)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Observaciones:"
        '
        'txtObservaviones
        '
        Me.txtObservaviones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaviones.BackColor = System.Drawing.Color.White
        Me.txtObservaviones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaviones.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaviones.ForeColor = System.Drawing.Color.Black
        Me.txtObservaviones.Location = New System.Drawing.Point(39, 271)
        Me.txtObservaviones.Name = "txtObservaviones"
        Me.txtObservaviones.Size = New System.Drawing.Size(544, 30)
        Me.txtObservaviones.TabIndex = 25
        '
        'CheckLlave
        '
        Me.CheckLlave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckLlave.BaseColor = System.Drawing.SystemColors.Control
        Me.CheckLlave.CheckedOffColor = System.Drawing.Color.DarkGray
        Me.CheckLlave.CheckedOnColor = System.Drawing.Color.DarkTurquoise
        Me.CheckLlave.FillColor = System.Drawing.Color.White
        Me.CheckLlave.Location = New System.Drawing.Point(555, 110)
        Me.CheckLlave.Name = "CheckLlave"
        Me.CheckLlave.Size = New System.Drawing.Size(28, 21)
        Me.CheckLlave.TabIndex = 65
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(500, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 21)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Llave:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(176, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 21)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Fecha y hora Entrada:"
        '
        'txtEntrada
        '
        Me.txtEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEntrada.BackColor = System.Drawing.Color.White
        Me.txtEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEntrada.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntrada.ForeColor = System.Drawing.Color.Black
        Me.txtEntrada.Location = New System.Drawing.Point(180, 202)
        Me.txtEntrada.Name = "txtEntrada"
        Me.txtEntrada.ReadOnly = True
        Me.txtEntrada.Size = New System.Drawing.Size(202, 30)
        Me.txtEntrada.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(375, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 21)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Fecha y hora de salida:"
        '
        'txtSalida
        '
        Me.txtSalida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSalida.BackColor = System.Drawing.Color.White
        Me.txtSalida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSalida.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalida.ForeColor = System.Drawing.Color.Black
        Me.txtSalida.Location = New System.Drawing.Point(388, 202)
        Me.txtSalida.Name = "txtSalida"
        Me.txtSalida.ReadOnly = True
        Me.txtSalida.Size = New System.Drawing.Size(195, 30)
        Me.txtSalida.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(35, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 21)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Barra:"
        '
        'LBarra
        '
        Me.LBarra.AutoSize = True
        Me.LBarra.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBarra.ForeColor = System.Drawing.Color.Black
        Me.LBarra.Location = New System.Drawing.Point(91, 72)
        Me.LBarra.Name = "LBarra"
        Me.LBarra.Size = New System.Drawing.Size(28, 21)
        Me.LBarra.TabIndex = 42
        Me.LBarra.Text = "---"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(564, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 37)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "X"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.AnimationHoverSpeed = 0.07!
        Me.btnGuardar.AnimationSpeed = 0.03!
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BaseColor = System.Drawing.Color.DimGray
        Me.btnGuardar.BorderColor = System.Drawing.Color.Black
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGuardar.FocusedColor = System.Drawing.Color.Empty
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Nothing
        Me.btnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(39, 318)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.OnHoverBaseColor = System.Drawing.Color.DarkCyan
        Me.btnGuardar.OnHoverBorderColor = System.Drawing.Color.DarkCyan
        Me.btnGuardar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGuardar.OnHoverImage = Nothing
        Me.btnGuardar.OnPressedColor = System.Drawing.Color.Black
        Me.btnGuardar.Radius = 5
        Me.btnGuardar.Size = New System.Drawing.Size(265, 63)
        Me.btnGuardar.TabIndex = 44
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LEstado
        '
        Me.LEstado.AutoSize = True
        Me.LEstado.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEstado.ForeColor = System.Drawing.Color.Black
        Me.LEstado.Location = New System.Drawing.Point(35, 28)
        Me.LEstado.Name = "LEstado"
        Me.LEstado.Size = New System.Drawing.Size(71, 21)
        Me.LEstado.TabIndex = 45
        Me.LEstado.Text = "ACTIVO"
        '
        'LId
        '
        Me.LId.AutoSize = True
        Me.LId.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LId.ForeColor = System.Drawing.Color.Black
        Me.LId.Location = New System.Drawing.Point(433, 28)
        Me.LId.Name = "LId"
        Me.LId.Size = New System.Drawing.Size(24, 21)
        Me.LId.TabIndex = 46
        Me.LId.Text = "--"
        Me.LId.Visible = False
        '
        'btnAnular
        '
        Me.btnAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnular.AnimationHoverSpeed = 0.07!
        Me.btnAnular.AnimationSpeed = 0.03!
        Me.btnAnular.BackColor = System.Drawing.Color.Transparent
        Me.btnAnular.BaseColor = System.Drawing.Color.Red
        Me.btnAnular.BorderColor = System.Drawing.Color.Black
        Me.btnAnular.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAnular.FocusedColor = System.Drawing.Color.Empty
        Me.btnAnular.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnular.ForeColor = System.Drawing.Color.White
        Me.btnAnular.Image = Nothing
        Me.btnAnular.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAnular.Location = New System.Drawing.Point(310, 318)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.OnHoverBaseColor = System.Drawing.Color.DarkCyan
        Me.btnAnular.OnHoverBorderColor = System.Drawing.Color.DarkCyan
        Me.btnAnular.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAnular.OnHoverImage = Nothing
        Me.btnAnular.OnPressedColor = System.Drawing.Color.Black
        Me.btnAnular.Radius = 5
        Me.btnAnular.Size = New System.Drawing.Size(273, 63)
        Me.btnAnular.TabIndex = 47
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(267, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 21)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Especial:"
        '
        'switchEspecial
        '
        Me.switchEspecial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.switchEspecial.BaseColor = System.Drawing.SystemColors.Control
        Me.switchEspecial.CheckedOffColor = System.Drawing.Color.DarkGray
        Me.switchEspecial.CheckedOnColor = System.Drawing.Color.DarkTurquoise
        Me.switchEspecial.FillColor = System.Drawing.Color.White
        Me.switchEspecial.Location = New System.Drawing.Point(341, 110)
        Me.switchEspecial.Name = "switchEspecial"
        Me.switchEspecial.Size = New System.Drawing.Size(28, 21)
        Me.switchEspecial.TabIndex = 60
        '
        'FrmEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(619, 401)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.switchEspecial)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.LId)
        Me.Controls.Add(Me.LEstado)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LBarra)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSalida)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEntrada)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CheckLlave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtObservaviones)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPlaca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtVehiculo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtVehiculo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMarca As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtColor As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtObservaviones As TextBox
    Friend WithEvents CheckLlave As Guna.UI.WinForms.GunaSwitch
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEntrada As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSalida As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LBarra As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnGuardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents LEstado As Label
    Friend WithEvents LId As Label
    Friend WithEvents btnAnular As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label11 As Label
    Friend WithEvents switchEspecial As Guna.UI.WinForms.GunaSwitch
End Class
