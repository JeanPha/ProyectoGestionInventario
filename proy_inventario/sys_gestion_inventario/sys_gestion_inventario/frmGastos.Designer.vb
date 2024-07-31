<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGastos
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbSaldos = New System.Windows.Forms.Label()
        Me.lbGastos = New System.Windows.Forms.Label()
        Me.lbIngresos = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.dgvGastos = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.PictureBox()
        Me.btnModificar = New System.Windows.Forms.PictureBox()
        Me.btnEliminar = New System.Windows.Forms.PictureBox()
        Me.btnListo = New System.Windows.Forms.Button()
        Me.gpConsultas = New System.Windows.Forms.GroupBox()
        Me.rbCategoria = New System.Windows.Forms.RadioButton()
        Me.rbTipo = New System.Windows.Forms.RadioButton()
        Me.rbMetodo = New System.Windows.Forms.RadioButton()
        Me.txtEntrada1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTipo = New System.Windows.Forms.PictureBox()
        Me.btnCategoria = New System.Windows.Forms.PictureBox()
        Me.btnMetodo = New System.Windows.Forms.PictureBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIdTipo = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdCategoria = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIdMetodo = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtMetodo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbCliente = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lbFecha = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpConsultas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMetodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1718, 963)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lbSaldos)
        Me.Panel1.Controls.Add(Me.lbGastos)
        Me.Panel1.Controls.Add(Me.lbIngresos)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1718, 107)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.sys_gestion_inventario.My.Resources.Resources.logo_de_express_7__1_
        Me.PictureBox2.Location = New System.Drawing.Point(33, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(118, 71)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 71
        Me.PictureBox2.TabStop = False
        '
        'lbSaldos
        '
        Me.lbSaldos.AutoSize = True
        Me.lbSaldos.BackColor = System.Drawing.Color.AliceBlue
        Me.lbSaldos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSaldos.ForeColor = System.Drawing.Color.Navy
        Me.lbSaldos.Location = New System.Drawing.Point(1155, 27)
        Me.lbSaldos.Name = "lbSaldos"
        Me.lbSaldos.Size = New System.Drawing.Size(79, 25)
        Me.lbSaldos.TabIndex = 70
        Me.lbSaldos.Text = "Saldos"
        '
        'lbGastos
        '
        Me.lbGastos.AutoSize = True
        Me.lbGastos.BackColor = System.Drawing.Color.AliceBlue
        Me.lbGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGastos.ForeColor = System.Drawing.Color.DarkRed
        Me.lbGastos.Location = New System.Drawing.Point(726, 25)
        Me.lbGastos.Name = "lbGastos"
        Me.lbGastos.Size = New System.Drawing.Size(80, 25)
        Me.lbGastos.TabIndex = 69
        Me.lbGastos.Text = "Gastos"
        '
        'lbIngresos
        '
        Me.lbIngresos.AutoSize = True
        Me.lbIngresos.BackColor = System.Drawing.Color.AliceBlue
        Me.lbIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIngresos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbIngresos.Location = New System.Drawing.Point(293, 27)
        Me.lbIngresos.Name = "lbIngresos"
        Me.lbIngresos.Size = New System.Drawing.Size(95, 25)
        Me.lbIngresos.TabIndex = 68
        Me.lbIngresos.Text = "Ingresos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(622, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 22)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "GASTOS:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(1054, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 22)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "SALDOS:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(169, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 22)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "INGRESOS:"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Red
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(1489, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(73, 50)
        Me.btnCerrar.TabIndex = 36
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox3.Location = New System.Drawing.Point(0, 161)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1718, 803)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'dgvGastos
        '
        Me.dgvGastos.AllowUserToAddRows = False
        Me.dgvGastos.AllowUserToDeleteRows = False
        Me.dgvGastos.AllowUserToResizeColumns = False
        Me.dgvGastos.AllowUserToResizeRows = False
        Me.dgvGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGastos.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGastos.Location = New System.Drawing.Point(33, 92)
        Me.dgvGastos.Name = "dgvGastos"
        Me.dgvGastos.ReadOnly = True
        Me.dgvGastos.RowHeadersWidth = 62
        Me.dgvGastos.RowTemplate.Height = 28
        Me.dgvGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGastos.Size = New System.Drawing.Size(1265, 412)
        Me.dgvGastos.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.btnNuevo)
        Me.Panel4.Controls.Add(Me.btnModificar)
        Me.Panel4.Controls.Add(Me.btnEliminar)
        Me.Panel4.Controls.Add(Me.btnListo)
        Me.Panel4.Location = New System.Drawing.Point(1304, 92)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(255, 458)
        Me.Panel4.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(102, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Eliminar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(98, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 25)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Modificar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(111, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 25)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Nuevo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(60, 315)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 25)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "F3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(60, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 25)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "F2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DimGray
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(60, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 25)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "F1"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.White
        Me.btnNuevo.Image = Global.sys_gestion_inventario.My.Resources.Resources.plus
        Me.btnNuevo.Location = New System.Drawing.Point(101, 35)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(94, 82)
        Me.btnNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnNuevo.TabIndex = 24
        Me.btnNuevo.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.White
        Me.btnModificar.Image = Global.sys_gestion_inventario.My.Resources.Resources.actualize_arrows_couple_in_circle
        Me.btnModificar.Location = New System.Drawing.Point(101, 161)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(94, 82)
        Me.btnModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnModificar.TabIndex = 26
        Me.btnModificar.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.Image = Global.sys_gestion_inventario.My.Resources.Resources.rounded_remove_button
        Me.btnEliminar.Location = New System.Drawing.Point(101, 287)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(94, 82)
        Me.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEliminar.TabIndex = 25
        Me.btnEliminar.TabStop = False
        '
        'btnListo
        '
        Me.btnListo.BackColor = System.Drawing.Color.DarkGreen
        Me.btnListo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListo.ForeColor = System.Drawing.Color.White
        Me.btnListo.Location = New System.Drawing.Point(81, 375)
        Me.btnListo.Name = "btnListo"
        Me.btnListo.Size = New System.Drawing.Size(136, 71)
        Me.btnListo.TabIndex = 21
        Me.btnListo.Text = "LISTO"
        Me.btnListo.UseVisualStyleBackColor = False
        '
        'gpConsultas
        '
        Me.gpConsultas.BackColor = System.Drawing.Color.DimGray
        Me.gpConsultas.Controls.Add(Me.rbCategoria)
        Me.gpConsultas.Controls.Add(Me.rbTipo)
        Me.gpConsultas.Controls.Add(Me.rbMetodo)
        Me.gpConsultas.Controls.Add(Me.txtEntrada1)
        Me.gpConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpConsultas.ForeColor = System.Drawing.Color.Navy
        Me.gpConsultas.Location = New System.Drawing.Point(1304, 556)
        Me.gpConsultas.Name = "gpConsultas"
        Me.gpConsultas.Size = New System.Drawing.Size(255, 257)
        Me.gpConsultas.TabIndex = 60
        Me.gpConsultas.TabStop = False
        Me.gpConsultas.Text = "CONSULTAS"
        '
        'rbCategoria
        '
        Me.rbCategoria.AutoSize = True
        Me.rbCategoria.Location = New System.Drawing.Point(51, 65)
        Me.rbCategoria.Name = "rbCategoria"
        Me.rbCategoria.Size = New System.Drawing.Size(180, 24)
        Me.rbCategoria.TabIndex = 76
        Me.rbCategoria.TabStop = True
        Me.rbCategoria.Text = "POR CATEGORÍA"
        Me.rbCategoria.UseVisualStyleBackColor = True
        '
        'rbTipo
        '
        Me.rbTipo.AutoSize = True
        Me.rbTipo.Location = New System.Drawing.Point(51, 95)
        Me.rbTipo.Name = "rbTipo"
        Me.rbTipo.Size = New System.Drawing.Size(116, 24)
        Me.rbTipo.TabIndex = 75
        Me.rbTipo.TabStop = True
        Me.rbTipo.Text = "POR TIPO"
        Me.rbTipo.UseVisualStyleBackColor = True
        '
        'rbMetodo
        '
        Me.rbMetodo.AutoSize = True
        Me.rbMetodo.Location = New System.Drawing.Point(51, 35)
        Me.rbMetodo.Name = "rbMetodo"
        Me.rbMetodo.Size = New System.Drawing.Size(139, 24)
        Me.rbMetodo.TabIndex = 74
        Me.rbMetodo.TabStop = True
        Me.rbMetodo.Text = "POR FORMA"
        Me.rbMetodo.UseVisualStyleBackColor = True
        '
        'txtEntrada1
        '
        Me.txtEntrada1.Location = New System.Drawing.Point(17, 157)
        Me.txtEntrada1.Name = "txtEntrada1"
        Me.txtEntrada1.Size = New System.Drawing.Size(216, 26)
        Me.txtEntrada1.TabIndex = 71
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Controls.Add(Me.btnTipo)
        Me.GroupBox1.Controls.Add(Me.btnCategoria)
        Me.GroupBox1.Controls.Add(Me.btnMetodo)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtIdTipo)
        Me.GroupBox1.Controls.Add(Me.txtTipo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtIdCategoria)
        Me.GroupBox1.Controls.Add(Me.txtCategoria)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtIdMetodo)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.txtMetodo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lbCliente)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.lbFecha)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(33, 510)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1265, 303)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        '
        'btnTipo
        '
        Me.btnTipo.Image = Global.sys_gestion_inventario.My.Resources.Resources.search
        Me.btnTipo.Location = New System.Drawing.Point(1189, 90)
        Me.btnTipo.Name = "btnTipo"
        Me.btnTipo.Size = New System.Drawing.Size(59, 46)
        Me.btnTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnTipo.TabIndex = 69
        Me.btnTipo.TabStop = False
        '
        'btnCategoria
        '
        Me.btnCategoria.Image = Global.sys_gestion_inventario.My.Resources.Resources.search
        Me.btnCategoria.Location = New System.Drawing.Point(584, 90)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Size = New System.Drawing.Size(59, 46)
        Me.btnCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCategoria.TabIndex = 68
        Me.btnCategoria.TabStop = False
        '
        'btnMetodo
        '
        Me.btnMetodo.Image = Global.sys_gestion_inventario.My.Resources.Resources.search
        Me.btnMetodo.Location = New System.Drawing.Point(1189, 20)
        Me.btnMetodo.Name = "btnMetodo"
        Me.btnMetodo.Size = New System.Drawing.Size(59, 46)
        Me.btnMetodo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMetodo.TabIndex = 67
        Me.btnMetodo.TabStop = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(205, 161)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(373, 48)
        Me.txtDescripcion.TabIndex = 66
        Me.txtDescripcion.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 25)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "DESCRIPCIÓN:"
        '
        'txtIdTipo
        '
        Me.txtIdTipo.Location = New System.Drawing.Point(810, 74)
        Me.txtIdTipo.Name = "txtIdTipo"
        Me.txtIdTipo.ReadOnly = True
        Me.txtIdTipo.Size = New System.Drawing.Size(373, 26)
        Me.txtIdTipo.TabIndex = 64
        Me.txtIdTipo.Visible = False
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(810, 106)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(373, 26)
        Me.txtTipo.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(693, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 25)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "TIPO: "
        '
        'txtIdCategoria
        '
        Me.txtIdCategoria.Location = New System.Drawing.Point(205, 70)
        Me.txtIdCategoria.Name = "txtIdCategoria"
        Me.txtIdCategoria.ReadOnly = True
        Me.txtIdCategoria.Size = New System.Drawing.Size(373, 26)
        Me.txtIdCategoria.TabIndex = 60
        Me.txtIdCategoria.Visible = False
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(205, 102)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(373, 26)
        Me.txtCategoria.TabIndex = 58
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(29, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 25)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "CATEGORÍA:"
        '
        'txtIdMetodo
        '
        Me.txtIdMetodo.Location = New System.Drawing.Point(810, 1)
        Me.txtIdMetodo.Name = "txtIdMetodo"
        Me.txtIdMetodo.ReadOnly = True
        Me.txtIdMetodo.Size = New System.Drawing.Size(373, 26)
        Me.txtIdMetodo.TabIndex = 55
        Me.txtIdMetodo.Visible = False
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(810, 184)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(373, 26)
        Me.txtFecha.TabIndex = 54
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(205, 231)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(373, 26)
        Me.txtMonto.TabIndex = 52
        '
        'txtMetodo
        '
        Me.txtMetodo.Location = New System.Drawing.Point(810, 33)
        Me.txtMetodo.Name = "txtMetodo"
        Me.txtMetodo.ReadOnly = True
        Me.txtMetodo.Size = New System.Drawing.Size(373, 26)
        Me.txtMetodo.TabIndex = 50
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(75, 230)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 25)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "MONTO:"
        '
        'lbCliente
        '
        Me.lbCliente.AutoSize = True
        Me.lbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCliente.Location = New System.Drawing.Point(650, 34)
        Me.lbCliente.Name = "lbCliente"
        Me.lbCliente.Size = New System.Drawing.Size(114, 25)
        Me.lbCliente.TabIndex = 35
        Me.lbCliente.Text = "METODO:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(810, 216)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(373, 26)
        Me.DateTimePicker1.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(69, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 25)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "CODIGO:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(205, 29)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(373, 26)
        Me.txtCodigo.TabIndex = 25
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFecha.Location = New System.Drawing.Point(676, 184)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(92, 25)
        Me.lbFecha.TabIndex = 34
        Me.lbFecha.Text = "FECHA:"
        '
        'frmGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1145, 642)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gpConsultas)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.dgvGastos)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmGastos"
        Me.Text = "frmGastos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.btnNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpConsultas.ResumeLayout(False)
        Me.gpConsultas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMetodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbSaldos As Label
    Friend WithEvents lbGastos As Label
    Friend WithEvents lbIngresos As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents dgvGastos As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnNuevo As PictureBox
    Friend WithEvents btnModificar As PictureBox
    Friend WithEvents btnEliminar As PictureBox
    Friend WithEvents btnListo As Button
    Friend WithEvents gpConsultas As GroupBox
    Friend WithEvents rbCategoria As RadioButton
    Friend WithEvents rbTipo As RadioButton
    Friend WithEvents rbMetodo As RadioButton
    Friend WithEvents txtEntrada1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIdTipo As TextBox
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIdCategoria As TextBox
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtIdMetodo As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtMetodo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lbCliente As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lbFecha As Label
    Friend WithEvents btnTipo As PictureBox
    Friend WithEvents btnCategoria As PictureBox
    Friend WithEvents btnMetodo As PictureBox
End Class
