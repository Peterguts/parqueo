<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSesion
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
        Me.btnAcceder = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsuario = New Guna.UI.WinForms.GunaTextBox()
        Me.txtClave = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAcceder
        '
        Me.btnAcceder.AnimationHoverSpeed = 0.07!
        Me.btnAcceder.AnimationSpeed = 0.03!
        Me.btnAcceder.BackColor = System.Drawing.Color.Transparent
        Me.btnAcceder.BaseColor = System.Drawing.Color.DarkSlateGray
        Me.btnAcceder.BorderColor = System.Drawing.Color.Black
        Me.btnAcceder.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAcceder.FocusedColor = System.Drawing.Color.Empty
        Me.btnAcceder.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcceder.ForeColor = System.Drawing.Color.White
        Me.btnAcceder.Image = Nothing
        Me.btnAcceder.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAcceder.Location = New System.Drawing.Point(61, 326)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAcceder.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAcceder.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAcceder.OnHoverImage = Nothing
        Me.btnAcceder.OnPressedColor = System.Drawing.Color.Black
        Me.btnAcceder.Radius = 5
        Me.btnAcceder.Size = New System.Drawing.Size(180, 42)
        Me.btnAcceder.TabIndex = 10
        Me.btnAcceder.Text = "Acceder"
        Me.btnAcceder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario:"
        '
        'txtUsuario
        '
        Me.txtUsuario.BaseColor = System.Drawing.Color.White
        Me.txtUsuario.BorderColor = System.Drawing.Color.Silver
        Me.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsuario.FocusedBaseColor = System.Drawing.Color.White
        Me.txtUsuario.FocusedBorderColor = System.Drawing.Color.Cyan
        Me.txtUsuario.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(40, 205)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.Size = New System.Drawing.Size(229, 32)
        Me.txtUsuario.TabIndex = 0
        '
        'txtClave
        '
        Me.txtClave.BaseColor = System.Drawing.Color.White
        Me.txtClave.BorderColor = System.Drawing.Color.Silver
        Me.txtClave.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtClave.FocusedBaseColor = System.Drawing.Color.White
        Me.txtClave.FocusedBorderColor = System.Drawing.Color.Cyan
        Me.txtClave.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtClave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(40, 268)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.SelectedText = ""
        Me.txtClave.Size = New System.Drawing.Size(229, 32)
        Me.txtClave.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña:"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.ErrorImage = Nothing
        Me.GunaPictureBox1.Image = Global.Programa_parqueo.My.Resources.Resources.usuario2
        Me.GunaPictureBox1.Location = New System.Drawing.Point(76, 12)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(147, 154)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'FrmSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(310, 391)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAcceder)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(326, 430)
        Me.MinimumSize = New System.Drawing.Size(326, 430)
        Me.Name = "FrmSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesion"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents btnAcceder As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuario As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtClave As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
End Class
