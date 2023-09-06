<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportes
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGenerarDiario = New System.Windows.Forms.Button()
        Me.txtFechaDiaria = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGenerarFechas = New System.Windows.Forms.Button()
        Me.txtFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGenerarDiario)
        Me.GroupBox1.Controls.Add(Me.txtFechaDiaria)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 117)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reporte Actual"
        '
        'btnGenerarDiario
        '
        Me.btnGenerarDiario.Location = New System.Drawing.Point(384, 31)
        Me.btnGenerarDiario.Name = "btnGenerarDiario"
        Me.btnGenerarDiario.Size = New System.Drawing.Size(162, 73)
        Me.btnGenerarDiario.TabIndex = 10
        Me.btnGenerarDiario.Text = "Generar diario"
        Me.btnGenerarDiario.UseVisualStyleBackColor = True
        '
        'txtFechaDiaria
        '
        Me.txtFechaDiaria.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaDiaria.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaDiaria.Location = New System.Drawing.Point(103, 53)
        Me.txtFechaDiaria.Name = "txtFechaDiaria"
        Me.txtFechaDiaria.Size = New System.Drawing.Size(176, 29)
        Me.txtFechaDiaria.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnGenerarFechas)
        Me.GroupBox2.Controls.Add(Me.txtFechaInicio)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(581, 146)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reporte Historico"
        '
        'btnGenerarFechas
        '
        Me.btnGenerarFechas.Location = New System.Drawing.Point(385, 47)
        Me.btnGenerarFechas.Name = "btnGenerarFechas"
        Me.btnGenerarFechas.Size = New System.Drawing.Size(162, 73)
        Me.btnGenerarFechas.TabIndex = 25
        Me.btnGenerarFechas.Text = "Generar Historico"
        Me.btnGenerarFechas.UseVisualStyleBackColor = True
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaInicio.Location = New System.Drawing.Point(104, 69)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.RightToLeftLayout = True
        Me.txtFechaInicio.Size = New System.Drawing.Size(176, 29)
        Me.txtFechaInicio.TabIndex = 15
        '
        'PrintDocument1
        '
        '
        'PrintDocument2
        '
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 293)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(621, 332)
        Me.MinimumSize = New System.Drawing.Size(621, 332)
        Me.Name = "FrmReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnGenerarDiario As Button
    Friend WithEvents txtFechaDiaria As DateTimePicker
    Friend WithEvents btnGenerarFechas As Button
    Friend WithEvents txtFechaInicio As DateTimePicker
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
End Class
