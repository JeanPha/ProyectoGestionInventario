<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIngresos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvExpedientes = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnMetodo = New System.Windows.Forms.PictureBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtIdMetodo = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtMetodo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbCliente = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.gpConsultas = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEntrada1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbSaldos = New System.Windows.Forms.Label()
        Me.lbGastos = New System.Windows.Forms.Label()
        Me.lbIngresos = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Buscar = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New System.Windows.Forms.PictureBox()
        Me.btnEliminar = New System.Windows.Forms.PictureBox()
        Me.btnListo = New System.Windows.Forms.Button()
        CType(Me.dgvExpedientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnMetodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpConsultas.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvExpedientes
        '
        Me.dgvExpedientes.AllowUserToAddRows = False
        Me.dgvExpedientes.AllowUserToDeleteRows = False
        Me.dgvExpedientes.AllowUserToResizeColumns = False
        Me.dgvExpedientes.AllowUserToResizeRows = False
        Me.dgvExpedientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExpedientes.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvExpedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExpedientes.Location = New System.Drawing.Point(12, 161)
        Me.dgvExpedientes.Name = "dgvExpedientes"
        Me.dgvExpedientes.ReadOnly = True
        Me.dgvExpedientes.RowHeadersWidth = 62
        Me.dgvExpedientes.RowTemplate.Height = 28
        Me.dgvExpedientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExpedientes.Size = New System.Drawing.Size(1356, 416)
        Me.dgvExpedientes.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(153, 122)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1215, 26)
        Me.TextBox1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnListo)
        Me.Panel1.Location = New System.Drawing.Point(1408, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(208, 455)
        Me.Panel1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Controls.Add(Me.btnMetodo)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.txtIdMetodo)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.txtMetodo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbCliente)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.lbFecha)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(12, 596)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1356, 244)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'btnMetodo
        '
        Me.btnMetodo.Image = Global.sys_gestion_inventario.My.Resources.Resources.search
        Me.btnMetodo.Location = New System.Drawing.Point(1212, 45)
        Me.btnMetodo.Name = "btnMetodo"
        Me.btnMetodo.Size = New System.Drawing.Size(59, 46)
        Me.btnMetodo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMetodo.TabIndex = 57
        Me.btnMetodo.TabStop = False
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(795, 162)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(395, 26)
        Me.txtFecha.TabIndex = 56
        '
        'txtIdMetodo
        '
        Me.txtIdMetodo.Location = New System.Drawing.Point(795, 6)
        Me.txtIdMetodo.Name = "txtIdMetodo"
        Me.txtIdMetodo.ReadOnly = True
        Me.txtIdMetodo.Size = New System.Drawing.Size(395, 26)
        Me.txtIdMetodo.TabIndex = 55
        Me.txtIdMetodo.Visible = False
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(194, 162)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(395, 26)
        Me.txtMonto.TabIndex = 52
        '
        'txtMetodo
        '
        Me.txtMetodo.Location = New System.Drawing.Point(795, 59)
        Me.txtMetodo.Name = "txtMetodo"
        Me.txtMetodo.ReadOnly = True
        Me.txtMetodo.Size = New System.Drawing.Size(395, 26)
        Me.txtMetodo.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 29)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "MONTO:"
        '
        'lbCliente
        '
        Me.lbCliente.AutoSize = True
        Me.lbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCliente.Location = New System.Drawing.Point(633, 55)
        Me.lbCliente.Name = "lbCliente"
        Me.lbCliente.Size = New System.Drawing.Size(133, 29)
        Me.lbCliente.TabIndex = 35
        Me.lbCliente.Text = "METODO:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(795, 194)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(395, 26)
        Me.DateTimePicker1.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 29)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "CODIGO:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(194, 59)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(395, 26)
        Me.txtCodigo.TabIndex = 25
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFecha.Location = New System.Drawing.Point(633, 158)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(105, 29)
        Me.lbFecha.TabIndex = 34
        Me.lbFecha.Text = "FECHA:"
        '
        'gpConsultas
        '
        Me.gpConsultas.BackColor = System.Drawing.Color.DimGray
        Me.gpConsultas.Controls.Add(Me.Label9)
        Me.gpConsultas.Controls.Add(Me.txtEntrada1)
        Me.gpConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpConsultas.ForeColor = System.Drawing.Color.Navy
        Me.gpConsultas.Location = New System.Drawing.Point(1408, 596)
        Me.gpConsultas.Name = "gpConsultas"
        Me.gpConsultas.Size = New System.Drawing.Size(208, 244)
        Me.gpConsultas.TabIndex = 43
        Me.gpConsultas.TabStop = False
        Me.gpConsultas.Text = "CONSULTAS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 26)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Ingrese el Forma"
        '
        'txtEntrada1
        '
        Me.txtEntrada1.Location = New System.Drawing.Point(6, 137)
        Me.txtEntrada1.Name = "txtEntrada1"
        Me.txtEntrada1.Size = New System.Drawing.Size(198, 26)
        Me.txtEntrada1.TabIndex = 71
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.lbSaldos)
        Me.Panel2.Controls.Add(Me.lbGastos)
        Me.Panel2.Controls.Add(Me.lbIngresos)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1604, 70)
        Me.Panel2.TabIndex = 44
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.sys_gestion_inventario.My.Resources.Resources.logo_de_express_7__1_
        Me.PictureBox2.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(118, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 72
        Me.PictureBox2.TabStop = False
        '
        'lbSaldos
        '
        Me.lbSaldos.AutoSize = True
        Me.lbSaldos.BackColor = System.Drawing.Color.AliceBlue
        Me.lbSaldos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSaldos.ForeColor = System.Drawing.Color.Navy
        Me.lbSaldos.Location = New System.Drawing.Point(1123, 22)
        Me.lbSaldos.Name = "lbSaldos"
        Me.lbSaldos.Size = New System.Drawing.Size(79, 25)
        Me.lbSaldos.TabIndex = 64
        Me.lbSaldos.Text = "Saldos"
        '
        'lbGastos
        '
        Me.lbGastos.AutoSize = True
        Me.lbGastos.BackColor = System.Drawing.Color.AliceBlue
        Me.lbGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGastos.ForeColor = System.Drawing.Color.DarkRed
        Me.lbGastos.Location = New System.Drawing.Point(716, 23)
        Me.lbGastos.Name = "lbGastos"
        Me.lbGastos.Size = New System.Drawing.Size(80, 25)
        Me.lbGastos.TabIndex = 63
        Me.lbGastos.Text = "Gastos"
        '
        'lbIngresos
        '
        Me.lbIngresos.AutoSize = True
        Me.lbIngresos.BackColor = System.Drawing.Color.AliceBlue
        Me.lbIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIngresos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbIngresos.Location = New System.Drawing.Point(314, 23)
        Me.lbIngresos.Name = "lbIngresos"
        Me.lbIngresos.Size = New System.Drawing.Size(95, 25)
        Me.lbIngresos.TabIndex = 62
        Me.lbIngresos.Text = "Ingresos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(612, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 22)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "GASTOS:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(1022, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 22)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "SALDOS:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(190, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 22)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "INGRESOS:"
        '
        'Buscar
        '
        Me.Buscar.AutoSize = True
        Me.Buscar.BackColor = System.Drawing.SystemColors.ControlText
        Me.Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buscar.ForeColor = System.Drawing.Color.White
        Me.Buscar.Location = New System.Drawing.Point(12, 122)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(93, 26)
        Me.Buscar.TabIndex = 2
        Me.Buscar.Text = "Buscar:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1634, 898)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(68, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 25)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Eliminar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(64, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 25)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Modificar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(77, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 25)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Nuevo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.DimGray
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(26, 316)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 25)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "F3"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DimGray
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(26, 178)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 25)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "F2"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.DimGray
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(26, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 25)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "F1"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.White
        Me.btnNuevo.Image = Global.sys_gestion_inventario.My.Resources.Resources.plus
        Me.btnNuevo.Location = New System.Drawing.Point(67, 36)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(94, 82)
        Me.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnNuevo.TabIndex = 35
        Me.btnNuevo.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.Image = Global.sys_gestion_inventario.My.Resources.Resources.actualize_arrows_couple_in_circle
        Me.btnModificar.Location = New System.Drawing.Point(67, 162)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(94, 82)
        Me.btnModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnModificar.TabIndex = 37
        Me.btnModificar.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.Image = Global.sys_gestion_inventario.My.Resources.Resources.rounded_remove_button
        Me.btnEliminar.Location = New System.Drawing.Point(67, 288)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(94, 82)
        Me.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEliminar.TabIndex = 36
        Me.btnEliminar.TabStop = False
        '
        'btnListo
        '
        Me.btnListo.BackColor = System.Drawing.Color.DarkGreen
        Me.btnListo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListo.ForeColor = System.Drawing.Color.White
        Me.btnListo.Location = New System.Drawing.Point(47, 376)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(136, 71)
        Me.btnListo.TabIndex = 34
        Me.btnListo.Text = "LISTO"
        Me.btnListo.UseVisualStyleBackColor = False
        '
        'frmIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1634, 898)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.gpConsultas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.dgvExpedientes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmIngresos"
        Me.Text = "frmIngresos"
        CType(Me.dgvExpedientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnMetodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpConsultas.ResumeLayout(False)
        Me.gpConsultas.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvExpedientes As DataGridView
    Friend WithEvents Buscar As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtIdMetodo As TextBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtMetodo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbCliente As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lbFecha As Label
    Friend WithEvents gpConsultas As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEntrada1 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbSaldos As Label
    Friend WithEvents lbGastos As Label
    Friend WithEvents lbIngresos As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnMetodo As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnNuevo As PictureBox
    Friend WithEvents btnModificar As PictureBox
    Friend WithEvents btnEliminar As PictureBox
    Friend WithEvents btnListo As Button
End Class
