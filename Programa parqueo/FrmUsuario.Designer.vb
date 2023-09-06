<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPermiso = New System.Windows.Forms.ComboBox()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(579, 45)
        Me.MenuStrip1.TabIndex = 1
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
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(30, 91)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(293, 29)
        Me.txtUsuario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario:"
        '
        'txtClave
        '
        Me.txtClave.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(329, 91)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(229, 29)
        Me.txtClave.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(325, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contraseña:"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(30, 154)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(293, 29)
        Me.txtNombre.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(26, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(325, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Permisos:"
        '
        'txtPermiso
        '
        Me.txtPermiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPermiso.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermiso.FormattingEnabled = True
        Me.txtPermiso.Items.AddRange(New Object() {"ADMINISTRADOR", "USUARIO"})
        Me.txtPermiso.Location = New System.Drawing.Point(329, 154)
        Me.txtPermiso.Name = "txtPermiso"
        Me.txtPermiso.Size = New System.Drawing.Size(229, 29)
        Me.txtPermiso.TabIndex = 15
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 201)
        Me.Controls.Add(Me.txtPermiso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(595, 240)
        Me.MinimumSize = New System.Drawing.Size(595, 240)
        Me.Name = "FrmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuario"
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
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtClave As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPermiso As ComboBox
End Class
