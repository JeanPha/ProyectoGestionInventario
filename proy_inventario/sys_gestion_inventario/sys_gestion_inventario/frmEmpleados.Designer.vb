<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.txtBuscarEmpleado = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.txtCodigoG = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDireccionG = New System.Windows.Forms.TextBox()
        Me.txtCorreoG = New System.Windows.Forms.TextBox()
        Me.txtNombreG = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTelefonoG = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDniG = New System.Windows.Forms.TextBox()
        Me.txtApellidoG = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1199, 764)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(25, 21)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1152, 731)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtCodigo)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtDireccion)
        Me.TabPage1.Controls.Add(Me.txtCorreo)
        Me.TabPage1.Controls.Add(Me.txtNombre)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtTelefono)
        Me.TabPage1.Controls.Add(Me.btnAgregar)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtDni)
        Me.TabPage1.Controls.Add(Me.txtApellido)
        Me.TabPage1.Controls.Add(Me.PictureBox4)
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1144, 698)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Nuevo Empleado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(413, 97)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(398, 26)
        Me.txtCodigo.TabIndex = 30
        Me.txtCodigo.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(265, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 24)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Nombre:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(413, 521)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(398, 26)
        Me.txtDireccion.TabIndex = 28
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(411, 442)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(400, 26)
        Me.txtCorreo.TabIndex = 27
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(411, 141)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(400, 26)
        Me.txtNombre.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(250, 522)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 24)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Direccion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(276, 443)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 24)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Correo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(331, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(480, 43)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Agregar Nuevo Empleado"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(256, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 24)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Telefono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(411, 365)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(400, 26)
        Me.txtTelefono.TabIndex = 21
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAgregar.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(411, 599)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(406, 55)
        Me.btnAgregar.TabIndex = 20
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(303, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 24)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "DNI:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(261, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Apellido:"
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(411, 292)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(400, 26)
        Me.txtDni.TabIndex = 17
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(411, 219)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(400, 26)
        Me.txtApellido.TabIndex = 16
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox4.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox4.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1138, 692)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1138, 692)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvEmpleados)
        Me.TabPage2.Controls.Add(Me.txtBuscarEmpleado)
        Me.TabPage2.Controls.Add(Me.btnBorrar)
        Me.TabPage2.Controls.Add(Me.btnActualizar)
        Me.TabPage2.Controls.Add(Me.txtCodigoG)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtDireccionG)
        Me.TabPage2.Controls.Add(Me.txtCorreoG)
        Me.TabPage2.Controls.Add(Me.txtNombreG)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.txtTelefonoG)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.txtDniG)
        Me.TabPage2.Controls.Add(Me.txtApellidoG)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.PictureBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1144, 698)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gestionar Empleados"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.AllowUserToResizeColumns = False
        Me.dgvEmpleados.AllowUserToResizeRows = False
        Me.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpleados.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Location = New System.Drawing.Point(23, 158)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.RowHeadersWidth = 62
        Me.dgvEmpleados.RowTemplate.Height = 28
        Me.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpleados.Size = New System.Drawing.Size(1101, 299)
        Me.dgvEmpleados.TabIndex = 88
        '
        'txtBuscarEmpleado
        '
        Me.txtBuscarEmpleado.Location = New System.Drawing.Point(275, 111)
        Me.txtBuscarEmpleado.Name = "txtBuscarEmpleado"
        Me.txtBuscarEmpleado.Size = New System.Drawing.Size(443, 26)
        Me.txtBuscarEmpleado.TabIndex = 87
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.Maroon
        Me.btnBorrar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBorrar.ForeColor = System.Drawing.Color.White
        Me.btnBorrar.Location = New System.Drawing.Point(1007, 590)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(117, 53)
        Me.btnBorrar.TabIndex = 86
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnActualizar.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnActualizar.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Location = New System.Drawing.Point(1007, 510)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(117, 55)
        Me.btnActualizar.TabIndex = 85
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'txtCodigoG
        '
        Me.txtCodigoG.Location = New System.Drawing.Point(165, 519)
        Me.txtCodigoG.Name = "txtCodigoG"
        Me.txtCodigoG.Size = New System.Drawing.Size(304, 26)
        Me.txtCodigoG.TabIndex = 84
        Me.txtCodigoG.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 486)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 24)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Nombre:"
        '
        'txtDireccionG
        '
        Me.txtDireccionG.Location = New System.Drawing.Point(684, 636)
        Me.txtDireccionG.Name = "txtDireccionG"
        Me.txtDireccionG.Size = New System.Drawing.Size(304, 26)
        Me.txtDireccionG.TabIndex = 82
        '
        'txtCorreoG
        '
        Me.txtCorreoG.Location = New System.Drawing.Point(682, 563)
        Me.txtCorreoG.Name = "txtCorreoG"
        Me.txtCorreoG.Size = New System.Drawing.Size(306, 26)
        Me.txtCorreoG.TabIndex = 81
        '
        'txtNombreG
        '
        Me.txtNombreG.Location = New System.Drawing.Point(165, 485)
        Me.txtNombreG.Name = "txtNombreG"
        Me.txtNombreG.Size = New System.Drawing.Size(306, 26)
        Me.txtNombreG.TabIndex = 80
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(521, 637)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 24)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Direccion:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(547, 564)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 24)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Correo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(527, 486)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 24)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "Telefono:"
        '
        'txtTelefonoG
        '
        Me.txtTelefonoG.Location = New System.Drawing.Point(682, 486)
        Me.txtTelefonoG.Name = "txtTelefonoG"
        Me.txtTelefonoG.Size = New System.Drawing.Size(306, 26)
        Me.txtTelefonoG.TabIndex = 76
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(57, 637)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 24)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "DNI:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(15, 564)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 24)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "Apellido:"
        '
        'txtDniG
        '
        Me.txtDniG.Location = New System.Drawing.Point(165, 636)
        Me.txtDniG.Name = "txtDniG"
        Me.txtDniG.Size = New System.Drawing.Size(306, 26)
        Me.txtDniG.TabIndex = 73
        '
        'txtApellidoG
        '
        Me.txtApellidoG.Location = New System.Drawing.Point(165, 563)
        Me.txtApellidoG.Name = "txtApellidoG"
        Me.txtApellidoG.Size = New System.Drawing.Size(306, 26)
        Me.txtApellidoG.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 111)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 24)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Buscar por Fecha:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(344, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(403, 43)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Gestionar Empleados"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo2
        Me.PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1138, 692)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1199, 764)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmEmpleados"
        Me.Text = "frmEmpleados"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtCodigoG As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDireccionG As TextBox
    Friend WithEvents txtCorreoG As TextBox
    Friend WithEvents txtNombreG As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtTelefonoG As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtDniG As TextBox
    Friend WithEvents txtApellidoG As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents txtBuscarEmpleado As TextBox
    Friend WithEvents dgvEmpleados As DataGridView
End Class
