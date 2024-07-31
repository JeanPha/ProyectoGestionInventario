<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMetodos
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
        Me.dgvMetodos = New System.Windows.Forms.DataGridView()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.cboMetodos = New System.Windows.Forms.ComboBox()
        Me.btnAgregarMetodo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtMontoMetodo = New System.Windows.Forms.TextBox()
        Me.lbAbrir = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbCerrar = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMetodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(968, 722)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'dgvMetodos
        '
        Me.dgvMetodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMetodos.Location = New System.Drawing.Point(48, 241)
        Me.dgvMetodos.Name = "dgvMetodos"
        Me.dgvMetodos.RowHeadersWidth = 62
        Me.dgvMetodos.RowTemplate.Height = 28
        Me.dgvMetodos.Size = New System.Drawing.Size(864, 288)
        Me.dgvMetodos.TabIndex = 1
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'cboMetodos
        '
        Me.cboMetodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMetodos.FormattingEnabled = True
        Me.cboMetodos.Location = New System.Drawing.Point(270, 113)
        Me.cboMetodos.Name = "cboMetodos"
        Me.cboMetodos.Size = New System.Drawing.Size(443, 34)
        Me.cboMetodos.TabIndex = 2
        '
        'btnAgregarMetodo
        '
        Me.btnAgregarMetodo.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAgregarMetodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarMetodo.ForeColor = System.Drawing.Color.White
        Me.btnAgregarMetodo.Location = New System.Drawing.Point(748, 132)
        Me.btnAgregarMetodo.Name = "btnAgregarMetodo"
        Me.btnAgregarMetodo.Size = New System.Drawing.Size(164, 83)
        Me.btnAgregarMetodo.TabIndex = 3
        Me.btnAgregarMetodo.Text = "Agregar"
        Me.btnAgregarMetodo.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(48, 575)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(864, 78)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtMontoMetodo
        '
        Me.txtMontoMetodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoMetodo.Location = New System.Drawing.Point(270, 183)
        Me.txtMontoMetodo.Name = "txtMontoMetodo"
        Me.txtMontoMetodo.Size = New System.Drawing.Size(443, 32)
        Me.txtMontoMetodo.TabIndex = 5
        '
        'lbAbrir
        '
        Me.lbAbrir.AutoSize = True
        Me.lbAbrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAbrir.Location = New System.Drawing.Point(358, 20)
        Me.lbAbrir.Name = "lbAbrir"
        Me.lbAbrir.Size = New System.Drawing.Size(208, 46)
        Me.lbAbrir.TabIndex = 6
        Me.lbAbrir.Text = "Abrir Caja"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Monto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 26)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Metodo de Pago:"
        '
        'lbCerrar
        '
        Me.lbCerrar.AutoSize = True
        Me.lbCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCerrar.Location = New System.Drawing.Point(358, 20)
        Me.lbCerrar.Name = "lbCerrar"
        Me.lbCerrar.Size = New System.Drawing.Size(237, 46)
        Me.lbCerrar.TabIndex = 10
        Me.lbCerrar.Text = "Cerrar Caja"
        '
        'frmMetodos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 722)
        Me.Controls.Add(Me.lbCerrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbAbrir)
        Me.Controls.Add(Me.txtMontoMetodo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAgregarMetodo)
        Me.Controls.Add(Me.cboMetodos)
        Me.Controls.Add(Me.dgvMetodos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMetodos"
        Me.Text = "frmMetodos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMetodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvMetodos As DataGridView
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents cboMetodos As ComboBox
    Friend WithEvents btnAgregarMetodo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtMontoMetodo As TextBox
    Friend WithEvents lbAbrir As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbCerrar As Label
End Class
