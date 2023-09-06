<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClave
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
        Me.txtClave = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuario = New Guna.UI.WinForms.GunaTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAcceder = New Guna.UI.WinForms.GunaButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.txtClave.Location = New System.Drawing.Point(37, 164)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.SelectedText = ""
        Me.txtClave.Size = New System.Drawing.Size(229, 32)
        Me.txtClave.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Contraseña:"
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
        Me.txtUsuario.Location = New System.Drawing.Point(37, 101)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.Size = New System.Drawing.Size(229, 32)
        Me.txtUsuario.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Usuario:"
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
        Me.btnAcceder.Location = New System.Drawing.Point(58, 222)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAcceder.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAcceder.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAcceder.OnHoverImage = Nothing
        Me.btnAcceder.OnPressedColor = System.Drawing.Color.Black
        Me.btnAcceder.Radius = 5
        Me.btnAcceder.Size = New System.Drawing.Size(180, 42)
        Me.btnAcceder.TabIndex = 15
        Me.btnAcceder.Text = "Aceptar"
        Me.btnAcceder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(23, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Llene campos solicitados"
        '
        'FrmClave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 305)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAcceder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Name = "FrmClave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtClave As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAcceder As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label3 As Label
End Class
