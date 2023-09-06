<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrecio
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
        Me.GuardarF2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirF12ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMediaHora = New System.Windows.Forms.TextBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVehiculo = New Guna.UI.WinForms.GunaComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarF2ToolStripMenuItem, Me.SalirF12ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(353, 45)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'SalirF12ToolStripMenuItem
        '
        Me.SalirF12ToolStripMenuItem.Image = Global.Programa_parqueo.My.Resources.Resources.Salir
        Me.SalirF12ToolStripMenuItem.Name = "SalirF12ToolStripMenuItem"
        Me.SalirF12ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.SalirF12ToolStripMenuItem.Size = New System.Drawing.Size(80, 41)
        Me.SalirF12ToolStripMenuItem.Text = "Salir F12"
        Me.SalirF12ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtMediaHora)
        Me.GroupBox1.Controls.Add(Me.txtHora)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Location = New System.Drawing.Point(27, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 101)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quetzaltes"
        '
        'txtMediaHora
        '
        Me.txtMediaHora.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMediaHora.Location = New System.Drawing.Point(46, 55)
        Me.txtMediaHora.MaximumSize = New System.Drawing.Size(100, 30)
        Me.txtMediaHora.MinimumSize = New System.Drawing.Size(100, 30)
        Me.txtMediaHora.Name = "txtMediaHora"
        Me.txtMediaHora.Size = New System.Drawing.Size(100, 30)
        Me.txtMediaHora.TabIndex = 1
        Me.txtMediaHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHora
        '
        Me.txtHora.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHora.Location = New System.Drawing.Point(170, 55)
        Me.txtHora.MaximumSize = New System.Drawing.Size(100, 30)
        Me.txtHora.MinimumSize = New System.Drawing.Size(100, 30)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(100, 30)
        Me.txtHora.TabIndex = 5
        Me.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(42, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1/2 Hora"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(166, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "1 Hora"
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
        Me.txtVehiculo.Location = New System.Drawing.Point(122, 64)
        Me.txtVehiculo.Name = "txtVehiculo"
        Me.txtVehiculo.OnHoverItemBaseColor = System.Drawing.Color.Cyan
        Me.txtVehiculo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.txtVehiculo.Radius = 2
        Me.txtVehiculo.Size = New System.Drawing.Size(95, 31)
        Me.txtVehiculo.StartIndex = 0
        Me.txtVehiculo.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(23, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Vehículo:"
        '
        'FrmPrecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 214)
        Me.Controls.Add(Me.txtVehiculo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(369, 253)
        Me.Name = "FrmPrecio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Precio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GuardarF2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirF12ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMediaHora As TextBox
    Friend WithEvents txtHora As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVehiculo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label5 As Label
End Class
