﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCobro
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.LCobro = New System.Windows.Forms.Label()
        Me.LDescrip = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.LTiempoExacto = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.SlateGray
        Me.btnAceptar.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(12, 210)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(255, 102)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'LCobro
        '
        Me.LCobro.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LCobro.AutoSize = True
        Me.LCobro.Font = New System.Drawing.Font("Segoe UI Black", 82.0!, System.Drawing.FontStyle.Bold)
        Me.LCobro.ForeColor = System.Drawing.Color.Black
        Me.LCobro.Location = New System.Drawing.Point(124, 49)
        Me.LCobro.Name = "LCobro"
        Me.LCobro.Size = New System.Drawing.Size(278, 146)
        Me.LCobro.TabIndex = 1
        Me.LCobro.Text = "Q20"
        Me.LCobro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LDescrip
        '
        Me.LDescrip.AutoSize = True
        Me.LDescrip.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDescrip.Location = New System.Drawing.Point(12, 9)
        Me.LDescrip.Name = "LDescrip"
        Me.LDescrip.Size = New System.Drawing.Size(310, 25)
        Me.LDescrip.TabIndex = 2
        Me.LDescrip.Text = "Total por 2 horas con 30 minutos."
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Red
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(270, 210)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(255, 102)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'LTiempoExacto
        '
        Me.LTiempoExacto.AutoSize = True
        Me.LTiempoExacto.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTiempoExacto.Location = New System.Drawing.Point(12, 34)
        Me.LTiempoExacto.Name = "LTiempoExacto"
        Me.LTiempoExacto.Size = New System.Drawing.Size(143, 25)
        Me.LTiempoExacto.TabIndex = 4
        Me.LTiempoExacto.Text = "Tiempo exacto"
        '
        'FrmCobro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(537, 324)
        Me.Controls.Add(Me.LTiempoExacto)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.LDescrip)
        Me.Controls.Add(Me.LCobro)
        Me.Controls.Add(Me.btnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(537, 324)
        Me.MinimumSize = New System.Drawing.Size(537, 324)
        Me.Name = "FrmCobro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cobro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents LCobro As Label
    Friend WithEvents LDescrip As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents LTiempoExacto As Label
End Class
