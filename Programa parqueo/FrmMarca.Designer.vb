<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarca
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NuevoF1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarF2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarF3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarF4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirF12ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LId = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVehiculo = New Guna.UI.WinForms.GunaComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoF1ToolStripMenuItem, Me.GuardarF2ToolStripMenuItem, Me.BuscarF3ToolStripMenuItem, Me.EliminarF4ToolStripMenuItem, Me.SalirF12ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(529, 45)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NuevoF1ToolStripMenuItem
        '
        Me.NuevoF1ToolStripMenuItem.Image = Global.Programa_parqueo.My.Resources.Resources.Nuevo
        Me.NuevoF1ToolStripMenuItem.Name = "NuevoF1ToolStripMenuItem"
        Me.NuevoF1ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.NuevoF1ToolStripMenuItem.Size = New System.Drawing.Size(88, 41)
        Me.NuevoF1ToolStripMenuItem.Text = "Nuevo F1"
        Me.NuevoF1ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GuardarF2ToolStripMenuItem
        '
        Me.GuardarF2ToolStripMenuItem.Image = Global.Programa_parqueo.My.Resources.Resources.Guardar
        Me.GuardarF2ToolStripMenuItem.Name = "GuardarF2ToolStripMenuItem"
        Me.GuardarF2ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.GuardarF2ToolStripMenuItem.Size = New System.Drawing.Size(101, 41)
        Me.GuardarF2ToolStripMenuItem.Text = "Guardar F2"
        Me.GuardarF2ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BuscarF3ToolStripMenuItem
        '
        Me.BuscarF3ToolStripMenuItem.Image = Global.Programa_parqueo.My.Resources.Resources.Buscar
        Me.BuscarF3ToolStripMenuItem.Name = "BuscarF3ToolStripMenuItem"
        Me.BuscarF3ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.BuscarF3ToolStripMenuItem.Size = New System.Drawing.Size(91, 41)
        Me.BuscarF3ToolStripMenuItem.Text = "Buscar F3"
        Me.BuscarF3ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'EliminarF4ToolStripMenuItem
        '
        Me.EliminarF4ToolStripMenuItem.Image = Global.Programa_parqueo.My.Resources.Resources.Eliminar
        Me.EliminarF4ToolStripMenuItem.Name = "EliminarF4ToolStripMenuItem"
        Me.EliminarF4ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.EliminarF4ToolStripMenuItem.Size = New System.Drawing.Size(100, 41)
        Me.EliminarF4ToolStripMenuItem.Text = "Eliminar F4"
        Me.EliminarF4ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SalirF12ToolStripMenuItem
        '
        Me.SalirF12ToolStripMenuItem.Image = Global.Programa_parqueo.My.Resources.Resources.Salir
        Me.SalirF12ToolStripMenuItem.Name = "SalirF12ToolStripMenuItem"
        Me.SalirF12ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.SalirF12ToolStripMenuItem.Size = New System.Drawing.Size(80, 41)
        Me.SalirF12ToolStripMenuItem.Text = "Salir F12"
        Me.SalirF12ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(27, 154)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(341, 29)
        Me.txtDescripcion.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 21)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Descripción:"
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(262, 91)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(255, 29)
        Me.txtModelo.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(258, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 21)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Modelo:"
        '
        'txtMarca
        '
        Me.txtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMarca.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(27, 91)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(229, 29)
        Me.txtMarca.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 21)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Marca:"
        '
        'LId
        '
        Me.LId.AutoSize = True
        Me.LId.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LId.ForeColor = System.Drawing.Color.Black
        Me.LId.Location = New System.Drawing.Point(445, 58)
        Me.LId.Name = "LId"
        Me.LId.Size = New System.Drawing.Size(28, 21)
        Me.LId.TabIndex = 35
        Me.LId.Text = "---"
        Me.LId.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.LId.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(370, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 21)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Vehículo:"
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
        Me.txtVehiculo.Location = New System.Drawing.Point(374, 152)
        Me.txtVehiculo.Name = "txtVehiculo"
        Me.txtVehiculo.OnHoverItemBaseColor = System.Drawing.Color.Cyan
        Me.txtVehiculo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.txtVehiculo.Radius = 2
        Me.txtVehiculo.Size = New System.Drawing.Size(143, 31)
        Me.txtVehiculo.StartIndex = 0
        Me.txtVehiculo.TabIndex = 15
        '
        'FrmMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 211)
        Me.Controls.Add(Me.txtVehiculo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LId)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MaximumSize = New System.Drawing.Size(545, 250)
        Me.MinimumSize = New System.Drawing.Size(545, 250)
        Me.Name = "FrmMarca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marca"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NuevoF1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarF2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarF3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarF4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirF12ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LId As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVehiculo As Guna.UI.WinForms.GunaComboBox
End Class
