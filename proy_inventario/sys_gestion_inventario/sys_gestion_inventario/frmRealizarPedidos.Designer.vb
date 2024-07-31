<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRealizarPedidos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvProductosProveedores = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscarProveedor = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.LbEstado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbFormaPago = New System.Windows.Forms.ComboBox()
        Me.cbProveedor2 = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerEntrega = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerRealizacion = New System.Windows.Forms.DateTimePicker()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.cbEstadoPedido = New System.Windows.Forms.ComboBox()
        Me.lbEstadoPedido = New System.Windows.Forms.Label()
        Me.PanelButton = New System.Windows.Forms.Panel()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCodigoV = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DateTimePickerFechaFiltro = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbFormaPagoV = New System.Windows.Forms.ComboBox()
        Me.cbProveedorV = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerEntregaV = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerRealizacionV = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMontoV = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dgvRealizarPedidos = New System.Windows.Forms.DataGridView()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvPedidosEntregados = New System.Windows.Forms.DataGridView()
        Me.cbEstadoPedidoE = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRegistrarPedidosEntregrados = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCodigoE = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbFormaPagoE = New System.Windows.Forms.ComboBox()
        Me.cbProveedorE = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerEntregaE = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerRealizacionE = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtMontoE = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductosProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.PanelButton.SuspendLayout()
        CType(Me.dgvRealizarPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvPedidosEntregados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1841, 871)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(423, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 48)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Realizar Pedidos"
        '
        'dgvProductosProveedores
        '
        Me.dgvProductosProveedores.AllowUserToAddRows = False
        Me.dgvProductosProveedores.AllowUserToDeleteRows = False
        Me.dgvProductosProveedores.AllowUserToResizeColumns = False
        Me.dgvProductosProveedores.AllowUserToResizeRows = False
        Me.dgvProductosProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductosProveedores.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvProductosProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductosProveedores.Location = New System.Drawing.Point(53, 201)
        Me.dgvProductosProveedores.Name = "dgvProductosProveedores"
        Me.dgvProductosProveedores.ReadOnly = True
        Me.dgvProductosProveedores.RowHeadersWidth = 62
        Me.dgvProductosProveedores.RowTemplate.Height = 28
        Me.dgvProductosProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductosProveedores.Size = New System.Drawing.Size(1660, 578)
        Me.dgvProductosProveedores.TabIndex = 62
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1841, 871)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 56
        Me.PictureBox2.TabStop = False
        '
        'cbProveedor
        '
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.Location = New System.Drawing.Point(192, 123)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(377, 33)
        Me.cbProveedor.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(53, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 25)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Proveedor:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 36)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(2388, 1227)
        Me.TabControl1.TabIndex = 71
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtBuscarProveedor)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.cbProveedor)
        Me.TabPage1.Controls.Add(Me.dgvProductosProveedores)
        Me.TabPage1.Controls.Add(Me.PictureBox3)
        Me.TabPage1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(2380, 1189)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Realizar Pedidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(706, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(353, 48)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Realizar Pedidos"
        '
        'txtBuscarProveedor
        '
        Me.txtBuscarProveedor.Location = New System.Drawing.Point(808, 131)
        Me.txtBuscarProveedor.Name = "txtBuscarProveedor"
        Me.txtBuscarProveedor.Size = New System.Drawing.Size(455, 30)
        Me.txtBuscarProveedor.TabIndex = 71
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(2370, 1179)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.cbEstado)
        Me.TabPage2.Controls.Add(Me.LbEstado)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.cbFormaPago)
        Me.TabPage2.Controls.Add(Me.cbProveedor2)
        Me.TabPage2.Controls.Add(Me.DateTimePickerEntrega)
        Me.TabPage2.Controls.Add(Me.DateTimePickerRealizacion)
        Me.TabPage2.Controls.Add(Me.btnRegistrar)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtMonto)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.PictureBox4)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(2380, 1189)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Registrar Pedidos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cbEstado
        '
        Me.cbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"REALIZADO", "PAGADO", "A PAGAR"})
        Me.cbEstado.Location = New System.Drawing.Point(736, 554)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(493, 34)
        Me.cbEstado.TabIndex = 92
        '
        'LbEstado
        '
        Me.LbEstado.AutoSize = True
        Me.LbEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbEstado.Location = New System.Drawing.Point(496, 557)
        Me.LbEstado.Name = "LbEstado"
        Me.LbEstado.Size = New System.Drawing.Size(213, 26)
        Me.LbEstado.TabIndex = 91
        Me.LbEstado.Text = "Estado del Pedido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(724, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(376, 48)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Registrar Pedidos"
        '
        'cbFormaPago
        '
        Me.cbFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormaPago.FormattingEnabled = True
        Me.cbFormaPago.Location = New System.Drawing.Point(735, 313)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(493, 34)
        Me.cbFormaPago.TabIndex = 71
        '
        'cbProveedor2
        '
        Me.cbProveedor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor2.FormattingEnabled = True
        Me.cbProveedor2.Location = New System.Drawing.Point(735, 148)
        Me.cbProveedor2.Name = "cbProveedor2"
        Me.cbProveedor2.Size = New System.Drawing.Size(493, 34)
        Me.cbProveedor2.TabIndex = 70
        '
        'DateTimePickerEntrega
        '
        Me.DateTimePickerEntrega.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerEntrega.Location = New System.Drawing.Point(735, 480)
        Me.DateTimePickerEntrega.Name = "DateTimePickerEntrega"
        Me.DateTimePickerEntrega.Size = New System.Drawing.Size(494, 32)
        Me.DateTimePickerEntrega.TabIndex = 14
        '
        'DateTimePickerRealizacion
        '
        Me.DateTimePickerRealizacion.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerRealizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerRealizacion.Location = New System.Drawing.Point(735, 398)
        Me.DateTimePickerRealizacion.Name = "DateTimePickerRealizacion"
        Me.DateTimePickerRealizacion.Size = New System.Drawing.Size(494, 32)
        Me.DateTimePickerRealizacion.TabIndex = 13
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Location = New System.Drawing.Point(735, 646)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(493, 85)
        Me.btnRegistrar.TabIndex = 12
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(501, 481)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(207, 26)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Fecha de Entrega:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(459, 398)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(248, 26)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Fecha de Realizacion:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(524, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 26)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Forma de Pago:"
        '
        'txtMonto
        '
        Me.txtMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.Location = New System.Drawing.Point(735, 231)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(494, 32)
        Me.txtMonto.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(620, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Monto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(576, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Proveedor:"
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox4.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox4.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(2370, 1179)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.txtTotal)
        Me.TabPage3.Controls.Add(Me.cbEstadoPedido)
        Me.TabPage3.Controls.Add(Me.lbEstadoPedido)
        Me.TabPage3.Controls.Add(Me.PanelButton)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.txtCodigoV)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.DateTimePickerFechaFiltro)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.cbFormaPagoV)
        Me.TabPage3.Controls.Add(Me.cbProveedorV)
        Me.TabPage3.Controls.Add(Me.DateTimePickerEntregaV)
        Me.TabPage3.Controls.Add(Me.DateTimePickerRealizacionV)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.txtMontoV)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.dgvRealizarPedidos)
        Me.TabPage3.Controls.Add(Me.PictureBox5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(2380, 1189)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Pedidos Realizados"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(1329, 115)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(374, 48)
        Me.txtTotal.TabIndex = 94
        '
        'cbEstadoPedido
        '
        Me.cbEstadoPedido.FormattingEnabled = True
        Me.cbEstadoPedido.Items.AddRange(New Object() {"", "PAGADO", "A PAGAR"})
        Me.cbEstadoPedido.Location = New System.Drawing.Point(929, 717)
        Me.cbEstadoPedido.Name = "cbEstadoPedido"
        Me.cbEstadoPedido.Size = New System.Drawing.Size(357, 33)
        Me.cbEstadoPedido.TabIndex = 93
        '
        'lbEstadoPedido
        '
        Me.lbEstadoPedido.AutoSize = True
        Me.lbEstadoPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstadoPedido.Location = New System.Drawing.Point(716, 720)
        Me.lbEstadoPedido.Name = "lbEstadoPedido"
        Me.lbEstadoPedido.Size = New System.Drawing.Size(176, 25)
        Me.lbEstadoPedido.TabIndex = 92
        Me.lbEstadoPedido.Text = "Estado del Pedido:"
        '
        'PanelButton
        '
        Me.PanelButton.Controls.Add(Me.btnBorrar)
        Me.PanelButton.Controls.Add(Me.btnEditar)
        Me.PanelButton.Location = New System.Drawing.Point(1506, 554)
        Me.PanelButton.Name = "PanelButton"
        Me.PanelButton.Size = New System.Drawing.Size(200, 191)
        Me.PanelButton.TabIndex = 91
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.Maroon
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.ForeColor = System.Drawing.Color.White
        Me.btnBorrar.Location = New System.Drawing.Point(27, 104)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(145, 47)
        Me.btnBorrar.TabIndex = 83
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Blue
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.White
        Me.btnEditar.Location = New System.Drawing.Point(27, 43)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(145, 47)
        Me.btnEditar.TabIndex = 82
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(721, 28)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(407, 48)
        Me.Label17.TabIndex = 89
        Me.Label17.Text = "Pedidos Realizados"
        '
        'txtCodigoV
        '
        Me.txtCodigoV.Location = New System.Drawing.Point(239, 560)
        Me.txtCodigoV.Name = "txtCodigoV"
        Me.txtCodigoV.ReadOnly = True
        Me.txtCodigoV.Size = New System.Drawing.Size(357, 30)
        Me.txtCodigoV.TabIndex = 88
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(119, 564)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 25)
        Me.Label16.TabIndex = 87
        Me.Label16.Text = "Codigo:"
        '
        'DateTimePickerFechaFiltro
        '
        Me.DateTimePickerFechaFiltro.Location = New System.Drawing.Point(262, 129)
        Me.DateTimePickerFechaFiltro.Name = "DateTimePickerFechaFiltro"
        Me.DateTimePickerFechaFiltro.Size = New System.Drawing.Size(503, 30)
        Me.DateTimePickerFechaFiltro.TabIndex = 85
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(35, 131)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(172, 25)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "Buscar por Fecha:"
        '
        'cbFormaPagoV
        '
        Me.cbFormaPagoV.FormattingEnabled = True
        Me.cbFormaPagoV.Location = New System.Drawing.Point(927, 559)
        Me.cbFormaPagoV.Name = "cbFormaPagoV"
        Me.cbFormaPagoV.Size = New System.Drawing.Size(357, 33)
        Me.cbFormaPagoV.TabIndex = 81
        '
        'cbProveedorV
        '
        Me.cbProveedorV.FormattingEnabled = True
        Me.cbProveedorV.Location = New System.Drawing.Point(239, 612)
        Me.cbProveedorV.Name = "cbProveedorV"
        Me.cbProveedorV.Size = New System.Drawing.Size(357, 33)
        Me.cbProveedorV.TabIndex = 80
        '
        'DateTimePickerEntregaV
        '
        Me.DateTimePickerEntregaV.Location = New System.Drawing.Point(929, 666)
        Me.DateTimePickerEntregaV.Name = "DateTimePickerEntregaV"
        Me.DateTimePickerEntregaV.Size = New System.Drawing.Size(357, 30)
        Me.DateTimePickerEntregaV.TabIndex = 79
        '
        'DateTimePickerRealizacionV
        '
        Me.DateTimePickerRealizacionV.Location = New System.Drawing.Point(927, 611)
        Me.DateTimePickerRealizacionV.Name = "DateTimePickerRealizacionV"
        Me.DateTimePickerRealizacionV.Size = New System.Drawing.Size(357, 30)
        Me.DateTimePickerRealizacionV.TabIndex = 78
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(718, 669)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(173, 25)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Fecha de Entrega:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(686, 616)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(205, 25)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Fecha de Realizacion:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(739, 559)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 25)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "Forma de Pago:"
        '
        'txtMontoV
        '
        Me.txtMontoV.Location = New System.Drawing.Point(238, 664)
        Me.txtMontoV.Name = "txtMontoV"
        Me.txtMontoV.Size = New System.Drawing.Size(357, 30)
        Me.txtMontoV.TabIndex = 74
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(127, 669)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 25)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Monto:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(92, 620)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 25)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "Proveedor:"
        '
        'dgvRealizarPedidos
        '
        Me.dgvRealizarPedidos.AllowUserToAddRows = False
        Me.dgvRealizarPedidos.AllowUserToDeleteRows = False
        Me.dgvRealizarPedidos.AllowUserToResizeColumns = False
        Me.dgvRealizarPedidos.AllowUserToResizeRows = False
        Me.dgvRealizarPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRealizarPedidos.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvRealizarPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRealizarPedidos.Location = New System.Drawing.Point(12, 187)
        Me.dgvRealizarPedidos.Name = "dgvRealizarPedidos"
        Me.dgvRealizarPedidos.ReadOnly = True
        Me.dgvRealizarPedidos.RowHeadersWidth = 62
        Me.dgvRealizarPedidos.RowTemplate.Height = 28
        Me.dgvRealizarPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRealizarPedidos.Size = New System.Drawing.Size(1694, 348)
        Me.dgvRealizarPedidos.TabIndex = 63
        '
        'PictureBox5
        '
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox5.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox5.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(2370, 1179)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvPedidosEntregados)
        Me.TabPage4.Controls.Add(Me.cbEstadoPedidoE)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.Panel1)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.txtCodigoE)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Controls.Add(Me.cbFormaPagoE)
        Me.TabPage4.Controls.Add(Me.cbProveedorE)
        Me.TabPage4.Controls.Add(Me.DateTimePickerEntregaE)
        Me.TabPage4.Controls.Add(Me.DateTimePickerRealizacionE)
        Me.TabPage4.Controls.Add(Me.Label22)
        Me.TabPage4.Controls.Add(Me.Label23)
        Me.TabPage4.Controls.Add(Me.Label24)
        Me.TabPage4.Controls.Add(Me.txtMontoE)
        Me.TabPage4.Controls.Add(Me.Label25)
        Me.TabPage4.Controls.Add(Me.Label26)
        Me.TabPage4.Controls.Add(Me.PictureBox6)
        Me.TabPage4.Location = New System.Drawing.Point(4, 34)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(2380, 1189)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Pedidos Entregados"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvPedidosEntregados
        '
        Me.dgvPedidosEntregados.AllowUserToAddRows = False
        Me.dgvPedidosEntregados.AllowUserToDeleteRows = False
        Me.dgvPedidosEntregados.AllowUserToResizeColumns = False
        Me.dgvPedidosEntregados.AllowUserToResizeRows = False
        Me.dgvPedidosEntregados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPedidosEntregados.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvPedidosEntregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidosEntregados.Location = New System.Drawing.Point(19, 151)
        Me.dgvPedidosEntregados.Name = "dgvPedidosEntregados"
        Me.dgvPedidosEntregados.ReadOnly = True
        Me.dgvPedidosEntregados.RowHeadersWidth = 62
        Me.dgvPedidosEntregados.RowTemplate.Height = 28
        Me.dgvPedidosEntregados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPedidosEntregados.Size = New System.Drawing.Size(1794, 392)
        Me.dgvPedidosEntregados.TabIndex = 113
        '
        'cbEstadoPedidoE
        '
        Me.cbEstadoPedidoE.FormattingEnabled = True
        Me.cbEstadoPedidoE.Items.AddRange(New Object() {"PAGADO", "A PAGAR"})
        Me.cbEstadoPedidoE.Location = New System.Drawing.Point(919, 718)
        Me.cbEstadoPedidoE.Name = "cbEstadoPedidoE"
        Me.cbEstadoPedidoE.Size = New System.Drawing.Size(357, 33)
        Me.cbEstadoPedidoE.TabIndex = 112
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(706, 721)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(176, 25)
        Me.Label18.TabIndex = 111
        Me.Label18.Text = "Estado del Pedido:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnRegistrarPedidosEntregrados)
        Me.Panel1.Location = New System.Drawing.Point(1447, 589)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 125)
        Me.Panel1.TabIndex = 110
        '
        'btnRegistrarPedidosEntregrados
        '
        Me.btnRegistrarPedidosEntregrados.BackColor = System.Drawing.Color.DarkGreen
        Me.btnRegistrarPedidosEntregrados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarPedidosEntregrados.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarPedidosEntregrados.Location = New System.Drawing.Point(28, 39)
        Me.btnRegistrarPedidosEntregrados.Name = "btnRegistrarPedidosEntregrados"
        Me.btnRegistrarPedidosEntregrados.Size = New System.Drawing.Size(145, 47)
        Me.btnRegistrarPedidosEntregrados.TabIndex = 91
        Me.btnRegistrarPedidosEntregrados.Text = "Registrar"
        Me.btnRegistrarPedidosEntregrados.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(652, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(617, 48)
        Me.Label19.TabIndex = 109
        Me.Label19.Text = "Registrar Pedidos Entregados"
        '
        'txtCodigoE
        '
        Me.txtCodigoE.Location = New System.Drawing.Point(229, 561)
        Me.txtCodigoE.Name = "txtCodigoE"
        Me.txtCodigoE.ReadOnly = True
        Me.txtCodigoE.Size = New System.Drawing.Size(357, 30)
        Me.txtCodigoE.TabIndex = 108
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(109, 565)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 25)
        Me.Label20.TabIndex = 107
        Me.Label20.Text = "Codigo:"
        '
        'cbFormaPagoE
        '
        Me.cbFormaPagoE.FormattingEnabled = True
        Me.cbFormaPagoE.Location = New System.Drawing.Point(917, 560)
        Me.cbFormaPagoE.Name = "cbFormaPagoE"
        Me.cbFormaPagoE.Size = New System.Drawing.Size(357, 33)
        Me.cbFormaPagoE.TabIndex = 103
        '
        'cbProveedorE
        '
        Me.cbProveedorE.FormattingEnabled = True
        Me.cbProveedorE.Location = New System.Drawing.Point(229, 613)
        Me.cbProveedorE.Name = "cbProveedorE"
        Me.cbProveedorE.Size = New System.Drawing.Size(357, 33)
        Me.cbProveedorE.TabIndex = 102
        '
        'DateTimePickerEntregaE
        '
        Me.DateTimePickerEntregaE.Location = New System.Drawing.Point(919, 667)
        Me.DateTimePickerEntregaE.Name = "DateTimePickerEntregaE"
        Me.DateTimePickerEntregaE.Size = New System.Drawing.Size(357, 30)
        Me.DateTimePickerEntregaE.TabIndex = 101
        '
        'DateTimePickerRealizacionE
        '
        Me.DateTimePickerRealizacionE.Location = New System.Drawing.Point(917, 612)
        Me.DateTimePickerRealizacionE.Name = "DateTimePickerRealizacionE"
        Me.DateTimePickerRealizacionE.Size = New System.Drawing.Size(357, 30)
        Me.DateTimePickerRealizacionE.TabIndex = 100
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(708, 670)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(173, 25)
        Me.Label22.TabIndex = 99
        Me.Label22.Text = "Fecha de Entrega:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(676, 617)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(205, 25)
        Me.Label23.TabIndex = 98
        Me.Label23.Text = "Fecha de Realizacion:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(729, 560)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(152, 25)
        Me.Label24.TabIndex = 97
        Me.Label24.Text = "Forma de Pago:"
        '
        'txtMontoE
        '
        Me.txtMontoE.Location = New System.Drawing.Point(228, 665)
        Me.txtMontoE.Name = "txtMontoE"
        Me.txtMontoE.Size = New System.Drawing.Size(357, 30)
        Me.txtMontoE.TabIndex = 96
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(117, 670)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(73, 25)
        Me.Label25.TabIndex = 95
        Me.Label25.Text = "Monto:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(82, 621)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(108, 25)
        Me.Label26.TabIndex = 94
        Me.Label26.Text = "Proveedor:"
        '
        'PictureBox6
        '
        Me.PictureBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox6.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox6.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(2374, 1183)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'frmRealizarPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1841, 871)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmRealizarPedidos"
        Me.Text = "frmRealizarPedidos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductosProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.PanelButton.ResumeLayout(False)
        CType(Me.dgvRealizarPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dgvPedidosEntregados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvProductosProveedores As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cbProveedor As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtBuscarProveedor As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePickerEntrega As DateTimePicker
    Friend WithEvents DateTimePickerRealizacion As DateTimePicker
    Friend WithEvents cbProveedor2 As ComboBox
    Friend WithEvents cbFormaPago As ComboBox
    Friend WithEvents dgvRealizarPedidos As DataGridView
    Friend WithEvents cbFormaPagoV As ComboBox
    Friend WithEvents cbProveedorV As ComboBox
    Friend WithEvents DateTimePickerEntregaV As DateTimePicker
    Friend WithEvents DateTimePickerRealizacionV As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtMontoV As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents DateTimePickerFechaFiltro As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCodigoV As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelButton As Panel
    Friend WithEvents cbEstadoPedido As ComboBox
    Friend WithEvents lbEstadoPedido As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents LbEstado As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents dgvPedidosEntregados As DataGridView
    Friend WithEvents cbEstadoPedidoE As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCodigoE As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cbFormaPagoE As ComboBox
    Friend WithEvents cbProveedorE As ComboBox
    Friend WithEvents DateTimePickerEntregaE As DateTimePicker
    Friend WithEvents DateTimePickerRealizacionE As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txtMontoE As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnRegistrarPedidosEntregrados As Button
End Class
