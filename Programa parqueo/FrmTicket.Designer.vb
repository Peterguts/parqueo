<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTicket
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LHora = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.GroupHistorial = New System.Windows.Forms.GroupBox()
        Me.dataFinalizado = New System.Windows.Forms.DataGridView()
        Me.ListHistorial = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SwitchEspecial = New Guna.UI.WinForms.GunaSwitch()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ImagenLlave = New System.Windows.Forms.PictureBox()
        Me.CheckLlave = New Guna.UI.WinForms.GunaSwitch()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVehiculo = New Guna.UI.WinForms.GunaComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGenerar = New Guna.UI.WinForms.GunaButton()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtColor = New Guna.UI.WinForms.GunaComboBox()
        Me.txtMarca = New Guna.UI.WinForms.GunaComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupMoto = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMotoSin = New System.Windows.Forms.TextBox()
        Me.imagenKey = New System.Windows.Forms.PictureBox()
        Me.ImagenBarra = New System.Windows.Forms.PictureBox()
        Me.GroupCarro = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCarroCon = New System.Windows.Forms.TextBox()
        Me.txtCarroSin = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBarra = New System.Windows.Forms.TextBox()
        Me.RadioButonBuscar = New Guna.UI.WinForms.GunaRadioButton()
        Me.RadioButonFinalizar = New Guna.UI.WinForms.GunaRadioButton()
        Me.RadioButonEditar = New Guna.UI.WinForms.GunaRadioButton()
        Me.RadioButonReImprimir = New Guna.UI.WinForms.GunaRadioButton()
        Me.GroupTicket = New System.Windows.Forms.GroupBox()
        Me.GroupHistorial.SuspendLayout()
        CType(Me.dataFinalizado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImagenLlave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupMoto.SuspendLayout()
        CType(Me.imagenKey, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupCarro.SuspendLayout()
        Me.GroupTicket.SuspendLayout()
        Me.SuspendLayout()
        '
        'LHora
        '
        Me.LHora.AutoSize = True
        Me.LHora.Font = New System.Drawing.Font("Segoe UI", 74.0!, System.Drawing.FontStyle.Bold)
        Me.LHora.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.LHora.Location = New System.Drawing.Point(0, 27)
        Me.LHora.Name = "LHora"
        Me.LHora.Size = New System.Drawing.Size(284, 131)
        Me.LHora.TabIndex = 0
        Me.LHora.Text = "Hora"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LFecha.ForeColor = System.Drawing.Color.LimeGreen
        Me.LFecha.Location = New System.Drawing.Point(21, 140)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(90, 37)
        Me.LFecha.TabIndex = 1
        Me.LFecha.Text = "Fecha"
        '
        'Tiempo
        '
        Me.Tiempo.Enabled = True
        '
        'GroupHistorial
        '
        Me.GroupHistorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupHistorial.BackColor = System.Drawing.Color.Transparent
        Me.GroupHistorial.Controls.Add(Me.dataFinalizado)
        Me.GroupHistorial.Controls.Add(Me.ListHistorial)
        Me.GroupHistorial.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.GroupHistorial.ForeColor = System.Drawing.Color.Red
        Me.GroupHistorial.Location = New System.Drawing.Point(12, 205)
        Me.GroupHistorial.Name = "GroupHistorial"
        Me.GroupHistorial.Size = New System.Drawing.Size(634, 462)
        Me.GroupHistorial.TabIndex = 2
        Me.GroupHistorial.TabStop = False
        Me.GroupHistorial.Text = "Historial de tickets"
        '
        'dataFinalizado
        '
        Me.dataFinalizado.AllowUserToAddRows = False
        Me.dataFinalizado.AllowUserToDeleteRows = False
        Me.dataFinalizado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataFinalizado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dataFinalizado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dataFinalizado.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dataFinalizado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataFinalizado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataFinalizado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataFinalizado.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataFinalizado.Location = New System.Drawing.Point(6, 35)
        Me.dataFinalizado.Name = "dataFinalizado"
        Me.dataFinalizado.ReadOnly = True
        Me.dataFinalizado.RowHeadersWidth = 25
        Me.dataFinalizado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataFinalizado.Size = New System.Drawing.Size(622, 214)
        Me.dataFinalizado.TabIndex = 1
        '
        'ListHistorial
        '
        Me.ListHistorial.AllowUserToAddRows = False
        Me.ListHistorial.AllowUserToDeleteRows = False
        Me.ListHistorial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ListHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.ListHistorial.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.ListHistorial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListHistorial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ListHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListHistorial.DefaultCellStyle = DataGridViewCellStyle4
        Me.ListHistorial.Location = New System.Drawing.Point(6, 255)
        Me.ListHistorial.Name = "ListHistorial"
        Me.ListHistorial.ReadOnly = True
        Me.ListHistorial.RowHeadersWidth = 25
        Me.ListHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListHistorial.Size = New System.Drawing.Size(622, 201)
        Me.ListHistorial.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.SwitchEspecial)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtPlaca)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ImagenLlave)
        Me.GroupBox1.Controls.Add(Me.CheckLlave)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtVehiculo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtColor)
        Me.GroupBox1.Controls.Add(Me.txtMarca)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LFecha)
        Me.GroupBox1.Controls.Add(Me.LHora)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1160, 187)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generar Ticket"
        '
        'SwitchEspecial
        '
        Me.SwitchEspecial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SwitchEspecial.BaseColor = System.Drawing.SystemColors.Control
        Me.SwitchEspecial.CheckedOffColor = System.Drawing.Color.DarkGray
        Me.SwitchEspecial.CheckedOnColor = System.Drawing.Color.DarkTurquoise
        Me.SwitchEspecial.FillColor = System.Drawing.Color.White
        Me.SwitchEspecial.Location = New System.Drawing.Point(962, 28)
        Me.SwitchEspecial.Name = "SwitchEspecial"
        Me.SwitchEspecial.Size = New System.Drawing.Size(28, 21)
        Me.SwitchEspecial.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label12.Location = New System.Drawing.Point(880, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 21)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Especial:"
        '
        'txtPlaca
        '
        Me.txtPlaca.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPlaca.BackColor = System.Drawing.Color.White
        Me.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlaca.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlaca.ForeColor = System.Drawing.Color.Black
        Me.txtPlaca.Location = New System.Drawing.Point(587, 54)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(157, 30)
        Me.txtPlaca.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label11.Location = New System.Drawing.Point(587, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 21)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Placa:"
        '
        'ImagenLlave
        '
        Me.ImagenLlave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImagenLlave.Image = Global.Programa_parqueo.My.Resources.Resources.llave
        Me.ImagenLlave.Location = New System.Drawing.Point(784, 140)
        Me.ImagenLlave.Name = "ImagenLlave"
        Me.ImagenLlave.Size = New System.Drawing.Size(43, 41)
        Me.ImagenLlave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenLlave.TabIndex = 23
        Me.ImagenLlave.TabStop = False
        Me.ImagenLlave.Visible = False
        '
        'CheckLlave
        '
        Me.CheckLlave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckLlave.BaseColor = System.Drawing.SystemColors.Control
        Me.CheckLlave.CheckedOffColor = System.Drawing.Color.DarkGray
        Me.CheckLlave.CheckedOnColor = System.Drawing.Color.DarkTurquoise
        Me.CheckLlave.FillColor = System.Drawing.Color.White
        Me.CheckLlave.Location = New System.Drawing.Point(815, 111)
        Me.CheckLlave.Name = "CheckLlave"
        Me.CheckLlave.Size = New System.Drawing.Size(28, 29)
        Me.CheckLlave.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label6.Location = New System.Drawing.Point(755, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 21)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Llave:"
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
        Me.txtVehiculo.Location = New System.Drawing.Point(492, 55)
        Me.txtVehiculo.Name = "txtVehiculo"
        Me.txtVehiculo.OnHoverItemBaseColor = System.Drawing.Color.Cyan
        Me.txtVehiculo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.txtVehiculo.Radius = 2
        Me.txtVehiculo.Size = New System.Drawing.Size(89, 31)
        Me.txtVehiculo.StartIndex = 0
        Me.txtVehiculo.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label5.Location = New System.Drawing.Point(487, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Vehículo:"
        '
        'btnGenerar
        '
        Me.btnGenerar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGenerar.AnimationHoverSpeed = 0.07!
        Me.btnGenerar.AnimationSpeed = 0.03!
        Me.btnGenerar.BackColor = System.Drawing.Color.Transparent
        Me.btnGenerar.BaseColor = System.Drawing.Color.GreenYellow
        Me.btnGenerar.BorderColor = System.Drawing.Color.Black
        Me.btnGenerar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGenerar.FocusedColor = System.Drawing.Color.Empty
        Me.btnGenerar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.ForeColor = System.Drawing.Color.Black
        Me.btnGenerar.Image = Nothing
        Me.btnGenerar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGenerar.Location = New System.Drawing.Point(849, 111)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.OnHoverBaseColor = System.Drawing.Color.DarkCyan
        Me.btnGenerar.OnHoverBorderColor = System.Drawing.Color.DarkCyan
        Me.btnGenerar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGenerar.OnHoverImage = Nothing
        Me.btnGenerar.OnPressedColor = System.Drawing.Color.Black
        Me.btnGenerar.Radius = 5
        Me.btnGenerar.Size = New System.Drawing.Size(305, 66)
        Me.btnGenerar.TabIndex = 20
        Me.btnGenerar.Text = "Generar e imprimir ticket"
        Me.btnGenerar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.Location = New System.Drawing.Point(492, 113)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(257, 66)
        Me.txtDescripcion.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label4.Location = New System.Drawing.Point(488, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Descripción (Opcional):"
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
        Me.txtColor.Items.AddRange(New Object() {"Blanco", "Negro", "Gris", "Plateado", "Azul", "Rojo", "Verde", "Marrón", "Cafe", "Corinto", "Celeste", "Rosado", "Beige", "Dorado", "Amarillo", "Naranja", "Plata", "Otro"})
        Me.txtColor.Location = New System.Drawing.Point(1001, 55)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.OnHoverItemBaseColor = System.Drawing.Color.Black
        Me.txtColor.OnHoverItemForeColor = System.Drawing.Color.White
        Me.txtColor.Radius = 2
        Me.txtColor.Size = New System.Drawing.Size(153, 31)
        Me.txtColor.TabIndex = 10
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
        Me.txtMarca.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.ForeColor = System.Drawing.Color.Black
        Me.txtMarca.FormattingEnabled = True
        Me.txtMarca.Location = New System.Drawing.Point(750, 55)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.OnHoverItemBaseColor = System.Drawing.Color.Black
        Me.txtMarca.OnHoverItemForeColor = System.Drawing.Color.White
        Me.txtMarca.Radius = 2
        Me.txtMarca.Size = New System.Drawing.Size(246, 28)
        Me.txtMarca.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label3.Location = New System.Drawing.Point(996, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Color:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label2.Location = New System.Drawing.Point(745, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Marca:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.GroupMoto)
        Me.GroupBox2.Controls.Add(Me.GroupCarro)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(652, 387)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 280)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Espacios Disponibles"
        '
        'GroupMoto
        '
        Me.GroupMoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupMoto.Controls.Add(Me.Label9)
        Me.GroupMoto.Controls.Add(Me.txtMotoSin)
        Me.GroupMoto.Controls.Add(Me.imagenKey)
        Me.GroupMoto.Controls.Add(Me.ImagenBarra)
        Me.GroupMoto.Location = New System.Drawing.Point(277, 34)
        Me.GroupMoto.Name = "GroupMoto"
        Me.GroupMoto.Size = New System.Drawing.Size(237, 240)
        Me.GroupMoto.TabIndex = 1
        Me.GroupMoto.TabStop = False
        Me.GroupMoto.Text = "Moto"
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(67, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 21)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Disponibles"
        '
        'txtMotoSin
        '
        Me.txtMotoSin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMotoSin.BackColor = System.Drawing.Color.GreenYellow
        Me.txtMotoSin.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotoSin.Location = New System.Drawing.Point(71, 70)
        Me.txtMotoSin.Name = "txtMotoSin"
        Me.txtMotoSin.ReadOnly = True
        Me.txtMotoSin.Size = New System.Drawing.Size(100, 43)
        Me.txtMotoSin.TabIndex = 40
        Me.txtMotoSin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'imagenKey
        '
        Me.imagenKey.Image = Global.Programa_parqueo.My.Resources.Resources.llave_de_la_puerta
        Me.imagenKey.Location = New System.Drawing.Point(236, -11)
        Me.imagenKey.Name = "imagenKey"
        Me.imagenKey.Size = New System.Drawing.Size(19, 17)
        Me.imagenKey.TabIndex = 3
        Me.imagenKey.TabStop = False
        Me.imagenKey.Visible = False
        '
        'ImagenBarra
        '
        Me.ImagenBarra.Location = New System.Drawing.Point(261, -11)
        Me.ImagenBarra.Name = "ImagenBarra"
        Me.ImagenBarra.Size = New System.Drawing.Size(19, 17)
        Me.ImagenBarra.TabIndex = 2
        Me.ImagenBarra.TabStop = False
        Me.ImagenBarra.Visible = False
        '
        'GroupCarro
        '
        Me.GroupCarro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupCarro.Controls.Add(Me.Label7)
        Me.GroupCarro.Controls.Add(Me.Label8)
        Me.GroupCarro.Controls.Add(Me.txtCarroCon)
        Me.GroupCarro.Controls.Add(Me.txtCarroSin)
        Me.GroupCarro.Location = New System.Drawing.Point(13, 34)
        Me.GroupCarro.Name = "GroupCarro"
        Me.GroupCarro.Size = New System.Drawing.Size(258, 240)
        Me.GroupCarro.TabIndex = 0
        Me.GroupCarro.TabStop = False
        Me.GroupCarro.Text = "Carro"
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(76, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Sin llave"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(76, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 21)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Con llave"
        '
        'txtCarroCon
        '
        Me.txtCarroCon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCarroCon.BackColor = System.Drawing.Color.GreenYellow
        Me.txtCarroCon.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarroCon.Location = New System.Drawing.Point(80, 149)
        Me.txtCarroCon.Name = "txtCarroCon"
        Me.txtCarroCon.ReadOnly = True
        Me.txtCarroCon.Size = New System.Drawing.Size(100, 43)
        Me.txtCarroCon.TabIndex = 35
        Me.txtCarroCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCarroSin
        '
        Me.txtCarroSin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCarroSin.BackColor = System.Drawing.Color.GreenYellow
        Me.txtCarroSin.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCarroSin.Location = New System.Drawing.Point(80, 70)
        Me.txtCarroSin.Name = "txtCarroSin"
        Me.txtCarroSin.ReadOnly = True
        Me.txtCarroSin.Size = New System.Drawing.Size(100, 43)
        Me.txtCarroSin.TabIndex = 30
        Me.txtCarroSin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrintDocument1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(150, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Escanear la barra:"
        '
        'txtBarra
        '
        Me.txtBarra.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold)
        Me.txtBarra.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.txtBarra.Location = New System.Drawing.Point(44, 120)
        Me.txtBarra.Name = "txtBarra"
        Me.txtBarra.Size = New System.Drawing.Size(436, 36)
        Me.txtBarra.TabIndex = 25
        Me.txtBarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadioButonBuscar
        '
        Me.RadioButonBuscar.BaseColor = System.Drawing.SystemColors.Control
        Me.RadioButonBuscar.CheckedOffColor = System.Drawing.Color.DimGray
        Me.RadioButonBuscar.CheckedOnColor = System.Drawing.Color.GreenYellow
        Me.RadioButonBuscar.FillColor = System.Drawing.Color.White
        Me.RadioButonBuscar.ForeColor = System.Drawing.Color.DimGray
        Me.RadioButonBuscar.Location = New System.Drawing.Point(401, 44)
        Me.RadioButonBuscar.MaximumSize = New System.Drawing.Size(97, 33)
        Me.RadioButonBuscar.MinimumSize = New System.Drawing.Size(97, 33)
        Me.RadioButonBuscar.Name = "RadioButonBuscar"
        Me.RadioButonBuscar.Size = New System.Drawing.Size(97, 33)
        Me.RadioButonBuscar.TabIndex = 24
        Me.RadioButonBuscar.Text = "Buscar"
        '
        'RadioButonFinalizar
        '
        Me.RadioButonFinalizar.BaseColor = System.Drawing.SystemColors.Control
        Me.RadioButonFinalizar.CheckedOffColor = System.Drawing.Color.DimGray
        Me.RadioButonFinalizar.CheckedOnColor = System.Drawing.Color.GreenYellow
        Me.RadioButonFinalizar.FillColor = System.Drawing.Color.White
        Me.RadioButonFinalizar.ForeColor = System.Drawing.Color.DimGray
        Me.RadioButonFinalizar.Location = New System.Drawing.Point(37, 44)
        Me.RadioButonFinalizar.MaximumSize = New System.Drawing.Size(114, 33)
        Me.RadioButonFinalizar.MinimumSize = New System.Drawing.Size(114, 33)
        Me.RadioButonFinalizar.Name = "RadioButonFinalizar"
        Me.RadioButonFinalizar.Size = New System.Drawing.Size(114, 33)
        Me.RadioButonFinalizar.TabIndex = 21
        Me.RadioButonFinalizar.Text = "Finalizar"
        '
        'RadioButonEditar
        '
        Me.RadioButonEditar.BaseColor = System.Drawing.SystemColors.Control
        Me.RadioButonEditar.CheckedOffColor = System.Drawing.Color.DimGray
        Me.RadioButonEditar.CheckedOnColor = System.Drawing.Color.GreenYellow
        Me.RadioButonEditar.FillColor = System.Drawing.Color.White
        Me.RadioButonEditar.ForeColor = System.Drawing.Color.DimGray
        Me.RadioButonEditar.Location = New System.Drawing.Point(157, 44)
        Me.RadioButonEditar.MaximumSize = New System.Drawing.Size(90, 33)
        Me.RadioButonEditar.MinimumSize = New System.Drawing.Size(90, 33)
        Me.RadioButonEditar.Name = "RadioButonEditar"
        Me.RadioButonEditar.Size = New System.Drawing.Size(90, 33)
        Me.RadioButonEditar.TabIndex = 22
        Me.RadioButonEditar.Text = "Editar"
        '
        'RadioButonReImprimir
        '
        Me.RadioButonReImprimir.BaseColor = System.Drawing.SystemColors.Control
        Me.RadioButonReImprimir.CheckedOffColor = System.Drawing.Color.DimGray
        Me.RadioButonReImprimir.CheckedOnColor = System.Drawing.Color.GreenYellow
        Me.RadioButonReImprimir.FillColor = System.Drawing.Color.White
        Me.RadioButonReImprimir.ForeColor = System.Drawing.Color.DimGray
        Me.RadioButonReImprimir.Location = New System.Drawing.Point(253, 44)
        Me.RadioButonReImprimir.MaximumSize = New System.Drawing.Size(142, 33)
        Me.RadioButonReImprimir.MinimumSize = New System.Drawing.Size(142, 33)
        Me.RadioButonReImprimir.Name = "RadioButonReImprimir"
        Me.RadioButonReImprimir.Size = New System.Drawing.Size(142, 33)
        Me.RadioButonReImprimir.TabIndex = 23
        Me.RadioButonReImprimir.Text = "Reimprimir"
        '
        'GroupTicket
        '
        Me.GroupTicket.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupTicket.BackColor = System.Drawing.Color.White
        Me.GroupTicket.Controls.Add(Me.RadioButonReImprimir)
        Me.GroupTicket.Controls.Add(Me.RadioButonEditar)
        Me.GroupTicket.Controls.Add(Me.RadioButonFinalizar)
        Me.GroupTicket.Controls.Add(Me.RadioButonBuscar)
        Me.GroupTicket.Controls.Add(Me.txtBarra)
        Me.GroupTicket.Controls.Add(Me.Label1)
        Me.GroupTicket.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupTicket.ForeColor = System.Drawing.Color.Red
        Me.GroupTicket.Location = New System.Drawing.Point(652, 205)
        Me.GroupTicket.Name = "GroupTicket"
        Me.GroupTicket.Size = New System.Drawing.Size(520, 176)
        Me.GroupTicket.TabIndex = 8
        Me.GroupTicket.TabStop = False
        Me.GroupTicket.Text = "Manejo de ticket"
        '
        'FrmTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1184, 679)
        Me.Controls.Add(Me.GroupTicket)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupHistorial)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(1200, 718)
        Me.Name = "FrmTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ticket"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupHistorial.ResumeLayout(False)
        CType(Me.dataFinalizado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ImagenLlave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupMoto.ResumeLayout(False)
        Me.GroupMoto.PerformLayout()
        CType(Me.imagenKey, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupCarro.ResumeLayout(False)
        Me.GroupCarro.PerformLayout()
        Me.GroupTicket.ResumeLayout(False)
        Me.GroupTicket.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LHora As Label
    Friend WithEvents LFecha As Label
    Friend WithEvents Tiempo As Timer
    Friend WithEvents GroupHistorial As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGenerar As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtColor As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtMarca As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupMoto As GroupBox
    Friend WithEvents GroupCarro As GroupBox
    Friend WithEvents txtVehiculo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ImagenLlave As PictureBox
    Friend WithEvents CheckLlave As Guna.UI.WinForms.GunaSwitch
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ImagenBarra As PictureBox
    Friend WithEvents imagenKey As PictureBox
    Friend WithEvents txtCarroSin As TextBox
    Friend WithEvents txtCarroCon As TextBox
    Friend WithEvents txtMotoSin As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ListHistorial As DataGridView
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents SwitchEspecial As Guna.UI.WinForms.GunaSwitch
    Friend WithEvents Label12 As Label
    Friend WithEvents dataFinalizado As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBarra As TextBox
    Friend WithEvents RadioButonBuscar As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents RadioButonFinalizar As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents RadioButonEditar As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents RadioButonReImprimir As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GroupTicket As GroupBox
End Class
