<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CajaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GastosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetodosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeTransaccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoProductoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoProveedorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsociarProductosProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarProductosProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarPedidosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresosToolStripMenuItem, Me.CajaToolStripMenuItem, Me.PedidosToolStripMenuItem1, Me.EmpleadosToolStripMenuItem1, Me.CajaToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1363, 37)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CajaToolStripMenuItem1
        '
        Me.CajaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CajaToolStripMenuItem2, Me.CerrarCajaToolStripMenuItem})
        Me.CajaToolStripMenuItem1.Name = "CajaToolStripMenuItem1"
        Me.CajaToolStripMenuItem1.Size = New System.Drawing.Size(82, 33)
        Me.CajaToolStripMenuItem1.Text = "Caja"
        '
        'CajaToolStripMenuItem2
        '
        Me.CajaToolStripMenuItem2.Name = "CajaToolStripMenuItem2"
        Me.CajaToolStripMenuItem2.Size = New System.Drawing.Size(270, 38)
        Me.CajaToolStripMenuItem2.Text = "Abrir Caja"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.sys_gestion_inventario.My.Resources.Resources.fondo21
        Me.PictureBox1.Location = New System.Drawing.Point(0, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1363, 591)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresosToolStripMenuItem1, Me.GastosToolStripMenuItem1, Me.MetodosToolStripMenuItem1, Me.CategoriasToolStripMenuItem1, Me.TiposDeTransaccionToolStripMenuItem})
        Me.IngresosToolStripMenuItem.Image = Global.sys_gestion_inventario.My.Resources.Resources.inventario1
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(265, 33)
        Me.IngresosToolStripMenuItem.Text = "gestion de Gastos"
        '
        'IngresosToolStripMenuItem1
        '
        Me.IngresosToolStripMenuItem1.Name = "IngresosToolStripMenuItem1"
        Me.IngresosToolStripMenuItem1.Size = New System.Drawing.Size(366, 38)
        Me.IngresosToolStripMenuItem1.Text = "Ingresos"
        '
        'GastosToolStripMenuItem1
        '
        Me.GastosToolStripMenuItem1.Name = "GastosToolStripMenuItem1"
        Me.GastosToolStripMenuItem1.Size = New System.Drawing.Size(366, 38)
        Me.GastosToolStripMenuItem1.Text = "Gastos"
        '
        'MetodosToolStripMenuItem1
        '
        Me.MetodosToolStripMenuItem1.Name = "MetodosToolStripMenuItem1"
        Me.MetodosToolStripMenuItem1.Size = New System.Drawing.Size(366, 38)
        Me.MetodosToolStripMenuItem1.Text = "Metodos"
        '
        'CategoriasToolStripMenuItem1
        '
        Me.CategoriasToolStripMenuItem1.Name = "CategoriasToolStripMenuItem1"
        Me.CategoriasToolStripMenuItem1.Size = New System.Drawing.Size(366, 38)
        Me.CategoriasToolStripMenuItem1.Text = "Categorias"
        '
        'TiposDeTransaccionToolStripMenuItem
        '
        Me.TiposDeTransaccionToolStripMenuItem.Name = "TiposDeTransaccionToolStripMenuItem"
        Me.TiposDeTransaccionToolStripMenuItem.Size = New System.Drawing.Size(366, 38)
        Me.TiposDeTransaccionToolStripMenuItem.Text = "Tipos de Transaccion"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionarCajaToolStripMenuItem})
        Me.CajaToolStripMenuItem.Image = Global.sys_gestion_inventario.My.Resources.Resources.carrito11
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(106, 33)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'GestionarCajaToolStripMenuItem
        '
        Me.GestionarCajaToolStripMenuItem.Name = "GestionarCajaToolStripMenuItem"
        Me.GestionarCajaToolStripMenuItem.Size = New System.Drawing.Size(291, 38)
        Me.GestionarCajaToolStripMenuItem.Text = "Gestionar Caja"
        '
        'PedidosToolStripMenuItem1
        '
        Me.PedidosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ProveedoresToolStripMenuItem1, Me.PedidosToolStripMenuItem2})
        Me.PedidosToolStripMenuItem1.Image = Global.sys_gestion_inventario.My.Resources.Resources.add1
        Me.PedidosToolStripMenuItem1.Name = "PedidosToolStripMenuItem1"
        Me.PedidosToolStripMenuItem1.Size = New System.Drawing.Size(147, 33)
        Me.PedidosToolStripMenuItem1.Text = "Pedidos"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoProductoToolStripMenuItem1, Me.GestionarProductosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(265, 38)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'NuevoProductoToolStripMenuItem1
        '
        Me.NuevoProductoToolStripMenuItem1.Name = "NuevoProductoToolStripMenuItem1"
        Me.NuevoProductoToolStripMenuItem1.Size = New System.Drawing.Size(359, 38)
        Me.NuevoProductoToolStripMenuItem1.Text = "Nuevo Producto"
        '
        'GestionarProductosToolStripMenuItem
        '
        Me.GestionarProductosToolStripMenuItem.Name = "GestionarProductosToolStripMenuItem"
        Me.GestionarProductosToolStripMenuItem.Size = New System.Drawing.Size(359, 38)
        Me.GestionarProductosToolStripMenuItem.Text = "Gestionar Productos"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoProveedorToolStripMenuItem1, Me.GestionarProveedoresToolStripMenuItem1})
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(265, 38)
        Me.ProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'NuevoProveedorToolStripMenuItem1
        '
        Me.NuevoProveedorToolStripMenuItem1.Name = "NuevoProveedorToolStripMenuItem1"
        Me.NuevoProveedorToolStripMenuItem1.Size = New System.Drawing.Size(387, 38)
        Me.NuevoProveedorToolStripMenuItem1.Text = "Nuevo Proveedor"
        '
        'GestionarProveedoresToolStripMenuItem1
        '
        Me.GestionarProveedoresToolStripMenuItem1.Name = "GestionarProveedoresToolStripMenuItem1"
        Me.GestionarProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(387, 38)
        Me.GestionarProveedoresToolStripMenuItem1.Text = "Gestionar Proveedores"
        '
        'PedidosToolStripMenuItem2
        '
        Me.PedidosToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsociarProductosProveedoresToolStripMenuItem, Me.GestionarProductosProveedoresToolStripMenuItem, Me.RealizarPedidosToolStripMenuItem1})
        Me.PedidosToolStripMenuItem2.Name = "PedidosToolStripMenuItem2"
        Me.PedidosToolStripMenuItem2.Size = New System.Drawing.Size(265, 38)
        Me.PedidosToolStripMenuItem2.Text = "Pedidos"
        '
        'AsociarProductosProveedoresToolStripMenuItem
        '
        Me.AsociarProductosProveedoresToolStripMenuItem.Name = "AsociarProductosProveedoresToolStripMenuItem"
        Me.AsociarProductosProveedoresToolStripMenuItem.Size = New System.Drawing.Size(532, 38)
        Me.AsociarProductosProveedoresToolStripMenuItem.Text = "Asociar productos - Proveedores"
        '
        'GestionarProductosProveedoresToolStripMenuItem
        '
        Me.GestionarProductosProveedoresToolStripMenuItem.Name = "GestionarProductosProveedoresToolStripMenuItem"
        Me.GestionarProductosProveedoresToolStripMenuItem.Size = New System.Drawing.Size(532, 38)
        Me.GestionarProductosProveedoresToolStripMenuItem.Text = "Gestionar Productos - Proveedores"
        '
        'RealizarPedidosToolStripMenuItem1
        '
        Me.RealizarPedidosToolStripMenuItem1.Name = "RealizarPedidosToolStripMenuItem1"
        Me.RealizarPedidosToolStripMenuItem1.Size = New System.Drawing.Size(532, 38)
        Me.RealizarPedidosToolStripMenuItem1.Text = "Realizar Pedidos"
        '
        'EmpleadosToolStripMenuItem1
        '
        Me.EmpleadosToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem2})
        Me.EmpleadosToolStripMenuItem1.Image = Global.sys_gestion_inventario.My.Resources.Resources.clientes1
        Me.EmpleadosToolStripMenuItem1.Name = "EmpleadosToolStripMenuItem1"
        Me.EmpleadosToolStripMenuItem1.Size = New System.Drawing.Size(183, 33)
        Me.EmpleadosToolStripMenuItem1.Text = "Empleados"
        '
        'EmpleadosToolStripMenuItem2
        '
        Me.EmpleadosToolStripMenuItem2.Name = "EmpleadosToolStripMenuItem2"
        Me.EmpleadosToolStripMenuItem2.Size = New System.Drawing.Size(246, 38)
        Me.EmpleadosToolStripMenuItem2.Text = "Empleados"
        '
        'CerrarCajaToolStripMenuItem
        '
        Me.CerrarCajaToolStripMenuItem.Name = "CerrarCajaToolStripMenuItem"
        Me.CerrarCajaToolStripMenuItem.Size = New System.Drawing.Size(270, 38)
        Me.CerrarCajaToolStripMenuItem.Text = "Cerrar Caja"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1363, 628)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IngresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IngresosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MetodosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TiposDeTransaccionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoProductoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestionarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NuevoProveedorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestionarProveedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PedidosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AsociarProductosProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarProductosProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RealizarPedidosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GestionarCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CerrarCajaToolStripMenuItem As ToolStripMenuItem
End Class
