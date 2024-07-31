Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el formulario principal como contenedor MDI
        Me.IsMdiContainer = True

        Me.MaximizeBox = False ' Desactiva el botón de maximizar
        Me.MinimizeBox = False ' Desactiva el botón de minimizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Desactiva la capacidad de redimensionar verticalmente
    End Sub



    Private Sub IngresosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IngresosToolStripMenuItem1.Click
        Dim frm As New frmIngresos()

        ' Establecer el formulario hijo como un formulario hijo del formulario principal
        'frm.MdiParent = Me

        ' Establecer el tamaño fijo del formulario hijo
        frm.Size = New Size(1100, 600) ' Tamaño fijo, por ejemplo, 400x300 píxeles

        ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(-7, 56)

        ' Mostrar el formulario hijo
        frm.ShowDialog()
    End Sub

    Private Sub GastosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem1.Click
        Dim frm As New frmGastos()

        ' Establecer el formulario hijo como un formulario hijo del formulario principal
        'frm.MdiParent = Me

        ' Establecer el tamaño fijo del formulario hijo
        frm.Size = New Size(1100, 600) ' Tamaño fijo, por ejemplo, 400x300 píxeles

        ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(-7, 56)

        ' Mostrar el formulario hijo
        frm.ShowDialog()
    End Sub

    Private Sub MetodosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MetodosToolStripMenuItem1.Click
        Dim frm As New frmMetodosTransaccion()

        ' Establecer el formulario hijo como un formulario hijo del formulario principal
        'frm.MdiParent = Me

        ' Establecer el tamaño fijo del formulario hijo
        frm.Size = New Size(810, 540) ' Tamaño fijo, por ejemplo, 400x300 píxeles

        ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(-7, 56)

        ' Mostrar el formulario hijo
        frm.ShowDialog()
    End Sub

    Private Sub CategoriasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem1.Click
        Dim frm As New frmCategorias()

        ' Establecer el formulario hijo como un formulario hijo del formulario principal
        'frm.MdiParent = Me

        ' Establecer el tamaño fijo del formulario hijo
        frm.Size = New Size(810, 540) ' Tamaño fijo, por ejemplo, 400x300 píxeles

        ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(-7, 56)

        ' Mostrar el formulario hijo
        frm.ShowDialog()
    End Sub

    Private Sub TiposDeTransaccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeTransaccionToolStripMenuItem.Click
        Dim frm As New frmTipos()

        ' Establecer el formulario hijo como un formulario hijo del formulario principal
        'frm.MdiParent = Me

        ' Establecer el tamaño fijo del formulario hijo
        frm.Size = New Size(810, 540) ' Tamaño fijo, por ejemplo, 400x300 píxeles

        ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(-7, 56)

        ' Mostrar el formulario hijo
        frm.ShowDialog()
    End Sub

    Private Sub NuevoProductoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoProductoToolStripMenuItem1.Click
        Dim frm As New frmNuevoProducto()

        ' Establecer el formulario hijo como un formulario hijo del formulario principal
        'frm.MdiParent = Me

        ' Establecer el tamaño fijo del formulario hijo
        frm.Size = New Size(420, 420) ' Tamaño fijo, por ejemplo, 400x300 píxeles

        ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(-7, 56)

        ' Mostrar el formulario hijo
        frm.ShowDialog()
    End Sub

    Private Sub GestionarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarProductosToolStripMenuItem.Click
        Dim frm As New frmGestionarProductos()

        ' Establecer el formulario hijo como un formulario hijo del formulario principal
        'frm.MdiParent = Me

        ' Establecer el tamaño fijo del formulario hijo
        frm.Size = New Size(650, 550) ' Tamaño fijo, por ejemplo, 400x300 píxeles

        ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(-7, 56)

        ' Mostrar el formulario hijo
        frm.ShowDialog()
    End Sub

    Private Sub NuevoProveedorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoProveedorToolStripMenuItem1.Click
        Dim frm As New frmNuevoProveedor()

        ' Establecer el formulario hijo como un formulario hijo del formulario principal
        'frm.MdiParent = Me

        ' Establecer el tamaño fijo del formulario hijo
        frm.Size = New Size(500, 500) ' Tamaño fijo, por ejemplo, 400x300 píxeles

        ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(-7, 56)

        ' Mostrar el formulario hijo
        frm.ShowDialog()
    End Sub

    Private Sub GestionarProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GestionarProveedoresToolStripMenuItem1.Click
        Dim frm As New frmGestionarProveedores()

        ' Establecer el formulario hijo como un formulario hijo del formulario principal
        'frm.MdiParent = Me

        ' Establecer el tamaño fijo del formulario hijo
        frm.Size = New Size(900, 600) ' Tamaño fijo, por ejemplo, 400x300 píxeles

        ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(-7, 56)

        ' Mostrar el formulario hijo
        frm.ShowDialog()
    End Sub

    Private Sub AsociarProductosProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsociarProductosProveedoresToolStripMenuItem.Click
        Dim frm As New frmAsociarPedidosProveedores()

        ' Establecer el formulario hijo como un formulario hijo del formulario principal
        'frm.MdiParent = Me

        ' Establecer el tamaño fijo del formulario hijo
        frm.Size = New Size(500, 350) ' Tamaño fijo, por ejemplo, 400x300 píxeles

        ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(-7, 56)

        ' Mostrar el formulario hijo
        frm.ShowDialog()
    End Sub

    Private Sub GestionarProductosProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarProductosProveedoresToolStripMenuItem.Click
        Dim frm As New frmGestionarPedidosProveeedores()

        ' Establecer el formulario hijo como un formulario hijo del formulario principal
        'frm.MdiParent = Me

        ' Establecer el tamaño fijo del formulario hijo
        frm.Size = New Size(950, 600) ' Tamaño fijo, por ejemplo, 400x300 píxeles

        ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(-7, 56)

        ' Mostrar el formulario hijo
        frm.ShowDialog()
    End Sub

    Private Sub RealizarPedidosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RealizarPedidosToolStripMenuItem1.Click
        Dim frm As New frmRealizarPedidos()

        ' Establecer el formulario hijo como un formulario hijo del formulario principal
        'frm.MdiParent = Me

        ' Establecer el tamaño fijo del formulario hijo
        frm.Size = New Size(1250, 620) ' Tamaño fijo, por ejemplo, 400x300 píxeles

        ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(-7, 56)

        ' Mostrar el formulario hijo
        frm.ShowDialog()
    End Sub

    Private Sub GestionarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarCajaToolStripMenuItem.Click
        Dim frm As New frmGestionarCaja()

        ' Establecer el formulario hijo como un formulario hijo del formulario principal
        'frm.MdiParent = Me

        ' Establecer el tamaño fijo del formulario hijo
        frm.Size = New Size(810, 800) ' Tamaño fijo, por ejemplo, 400x300 píxeles

        ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(-7, 56)

        ' Mostrar el formulario hijo
        frm.ShowDialog()
    End Sub

    Private Sub EmpleadosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem2.Click
        Dim frm As New frmEmpleados()

        ' Establecer el formulario hijo como un formulario hijo del formulario principal
        'frm.MdiParent = Me

        ' Establecer el tamaño fijo del formulario hijo
        frm.Size = New Size(810, 540) ' Tamaño fijo, por ejemplo, 400x300 píxeles

        ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(-7, 56)

        ' Mostrar el formulario hijo
        frm.ShowDialog()
    End Sub

    Private Sub CajaToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CajaToolStripMenuItem2.Click
        Dim frm As New frmGestionarCaja()

        ' Establecer el formulario hijo como un formulario hijo del formulario principal
        'frm.MdiParent = Me

        ' Establecer el tamaño fijo del formulario hijo
        frm.Size = New Size(800, 500) ' Tamaño fijo, por ejemplo, 400x300 píxeles

        ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(-7, 56)

        ' Mostrar el formulario hijo
        frm.ShowDialog()
    End Sub

    Private Sub CerrarCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarCajaToolStripMenuItem.Click
        Dim frm As New frmCerrarCaja()

        ' Establecer el formulario hijo como un formulario hijo del formulario principal
        'frm.MdiParent = Me

        ' Establecer el tamaño fijo del formulario hijo
        frm.Size = New Size(800, 500) ' Tamaño fijo, por ejemplo, 400x300 píxeles

        ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(-7, 56)

        ' Mostrar el formulario hijo
        frm.ShowDialog()
    End Sub
End Class

