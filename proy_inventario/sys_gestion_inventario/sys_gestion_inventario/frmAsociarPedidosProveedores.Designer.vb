<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsociarPedidosProveedores
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnProveedor = New System.Windows.Forms.PictureBox()
        Me.btnProducto = New System.Windows.Forms.PictureBox()
        Me.txtIdProveedor = New System.Windows.Forms.TextBox()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(703, 489)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(703, 489)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(49, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 26)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Producto:"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(193, 307)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.ReadOnly = True
        Me.txtProducto.Size = New System.Drawing.Size(386, 26)
        Me.txtProducto.TabIndex = 34
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAgregar.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(193, 384)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(386, 55)
        Me.btnAgregar.TabIndex = 33
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(35, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 26)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Proveedor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(69, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 26)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Codigo:"
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(193, 233)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(386, 26)
        Me.txtProveedor.TabIndex = 30
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(193, 164)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(386, 26)
        Me.txtCodigo.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(571, 43)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Asociar Pedidos - Proveedores"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(703, 489)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'btnProveedor
        '
        Me.btnProveedor.Image = Global.sys_gestion_inventario.My.Resources.Resources.search
        Me.btnProveedor.Location = New System.Drawing.Point(599, 221)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.Size = New System.Drawing.Size(59, 46)
        Me.btnProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnProveedor.TabIndex = 68
        Me.btnProveedor.TabStop = False
        '
        'btnProducto
        '
        Me.btnProducto.Image = Global.sys_gestion_inventario.My.Resources.Resources.search
        Me.btnProducto.Location = New System.Drawing.Point(599, 292)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(59, 46)
        Me.btnProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnProducto.TabIndex = 69
        Me.btnProducto.TabStop = False
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.Location = New System.Drawing.Point(193, 201)
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.Size = New System.Drawing.Size(386, 26)
        Me.txtIdProveedor.TabIndex = 70
        Me.txtIdProveedor.Visible = False
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(193, 275)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(386, 26)
        Me.txtIdProducto.TabIndex = 71
        Me.txtIdProducto.Visible = False
        '
        'frmAsociarPedidosProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 489)
        Me.Controls.Add(Me.txtIdProducto)
        Me.Controls.Add(Me.txtIdProveedor)
        Me.Controls.Add(Me.btnProducto)
        Me.Controls.Add(Me.btnProveedor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProveedor)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmAsociarPedidosProveedores"
        Me.Text = "frmAsociarPedidosProveedores"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnProveedor As PictureBox
    Friend WithEvents btnProducto As PictureBox
    Friend WithEvents txtIdProveedor As TextBox
    Friend WithEvents txtIdProducto As TextBox
End Class
