<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCerrarCaja
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelAbrirCaja = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRegistrarA = New System.Windows.Forms.Button()
        Me.cbEmpleadoA = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAbrirCaja.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1034, 611)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelAbrirCaja
        '
        Me.PanelAbrirCaja.BackColor = System.Drawing.Color.LightGray
        Me.PanelAbrirCaja.Controls.Add(Me.Button1)
        Me.PanelAbrirCaja.Controls.Add(Me.btnRegistrarA)
        Me.PanelAbrirCaja.Controls.Add(Me.cbEmpleadoA)
        Me.PanelAbrirCaja.Controls.Add(Me.Label2)
        Me.PanelAbrirCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelAbrirCaja.Location = New System.Drawing.Point(22, 172)
        Me.PanelAbrirCaja.Name = "PanelAbrirCaja"
        Me.PanelAbrirCaja.Size = New System.Drawing.Size(991, 387)
        Me.PanelAbrirCaja.TabIndex = 68
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(200, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(734, 81)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnRegistrarA
        '
        Me.btnRegistrarA.BackColor = System.Drawing.Color.DarkGreen
        Me.btnRegistrarA.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarA.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarA.Location = New System.Drawing.Point(200, 143)
        Me.btnRegistrarA.Name = "btnRegistrarA"
        Me.btnRegistrarA.Size = New System.Drawing.Size(734, 113)
        Me.btnRegistrarA.TabIndex = 60
        Me.btnRegistrarA.Text = "Ingresar Monto"
        Me.btnRegistrarA.UseVisualStyleBackColor = False
        '
        'cbEmpleadoA
        '
        Me.cbEmpleadoA.FormattingEnabled = True
        Me.cbEmpleadoA.Location = New System.Drawing.Point(200, 63)
        Me.cbEmpleadoA.Name = "cbEmpleadoA"
        Me.cbEmpleadoA.Size = New System.Drawing.Size(734, 37)
        Me.cbEmpleadoA.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 29)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Empleado/a:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(402, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 43)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Abrir Caja"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCerrarCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 611)
        Me.Controls.Add(Me.PanelAbrirCaja)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmCerrarCaja"
        Me.Text = "frmCerrarCaja"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAbrirCaja.ResumeLayout(False)
        Me.PanelAbrirCaja.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelAbrirCaja As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnRegistrarA As Button
    Friend WithEvents cbEmpleadoA As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
