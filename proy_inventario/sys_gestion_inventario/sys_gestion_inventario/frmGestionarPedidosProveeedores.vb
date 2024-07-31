Public Class frmGestionarPedidosProveeedores
    Private Sub frmGestionarPedidosProveeedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarProveedoresProductos()
        Me.txtBuscarProveedor.Clear()
        Me.MaximizeBox = False ' Desactiva el botón de maximizar
        Me.MinimizeBox = False ' Desactiva el botón de minimizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Desactiva la capacidad de redimensionar verticalmente
    End Sub
    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click



        flag_where = 1

        Dim metodoForm As New frmGestionarProveedores()
        metodoForm.Owner = Me ' Establecer el formulario principal como propietario
        metodoForm.ShowDialog()

        'Actualiza los campos en frmIngresos cuando frmMetodosTransaccion se cierra 
        txtIdProveedor.Text = metodoForm.IdProveedorSeleccionado
        txtProveedor.Text = metodoForm.ProveedorSeleccionado

        Me.btnProducto.Focus()
        flag_where = 0
    End Sub

    Private Sub dgvProveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellContentClick

    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        flag_where = 1

        Dim metodoForm As New frmGestionarProductos()
        metodoForm.Owner = Me ' Establecer el formulario principal como propietario
        metodoForm.ShowDialog()

        'Actualiza los campos en frmIngresos cuando frmMetodosTransaccion se cierra 
        txtIdProducto.Text = metodoForm.IdProductoSeleccionado
        txtProducto.Text = metodoForm.ProductoSeleccionado

        Me.btnProducto.Focus()
    End Sub

    Private Sub llenarProveedoresProductos()
        Me.txtBuscarProveedor.Clear()
        txtBuscarProducto.Clear()
        Dim sql As String = "select proveedores_productos.idProvPed as CODIDO, proveedores.nombre as PROVEEDOR,
                                    productos.nombre as PRODUCTO, proveedores.idProv as idProveedor, productos.id as idProducto
                                    from proveedores_productos 
                                    inner join productos on proveedores_productos.idProd = productos.id 
                                    inner join proveedores on proveedores_productos.idProv= proveedores.idProv"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("proveedores")
        adp.Fill(ds.Tables("proveedores"))
        Me.dgvProveedores.DataSource = ds.Tables("proveedores")

        ' Ocultar las columnas idProveedor y idProducto
        Me.dgvProveedores.Columns("idProveedor").Visible = False
        Me.dgvProveedores.Columns("idProducto").Visible = False
    End Sub

    Private Sub deleteProveedoresProductos()
        Dim wcp As Integer = Convert.ToInt32(Me.dgvProveedores.CurrentRow.Cells(0).Value)
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "DELETE FROM proveedores_productos WHERE idProvPed = @idProvPed"

        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@idProvPed", wcp)

        Try
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarProveedoresProductos()
            Me.txtCodigo.Clear()
            Me.txtIdProducto.Clear()
            Me.txtProducto.Clear()
            txtIdProveedor.Clear()
            Me.txtProveedor.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        End Try
    End Sub

    Private Sub actualizarProveedoresProductos()
        Dim wcp As Integer = Convert.ToInt32(Me.dgvProveedores.CurrentRow.Cells(0).Value)

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "UPDATE proveedores_productos SET idProv = @idProv, idProd = @idProd WHERE idProvPed = @idProvPed"

        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@idProv", Me.txtIdProveedor.Text)
        cmd.Parameters.AddWithValue("@idProd", Me.txtIdProducto.Text)
        cmd.Parameters.AddWithValue("@idProvPed", wcp)

        If Me.txtProducto.Text <> "" And Me.txtProveedor.Text <> "" Then
            Try
                If cmd.Connection.State = ConnectionState.Closed Then
                    cmd.Connection.Open()
                End If
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarProveedoresProductos()
                Me.txtCodigo.Clear()
                Me.txtIdProducto.Clear()
                Me.txtProducto.Clear()
                Me.txtIdProveedor.Clear()
                Me.txtProveedor.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                If cmd.Connection.State = ConnectionState.Open Then
                    cmd.Connection.Close()
                End If
            End Try
        Else
            MsgBox("Complete todos los campos.", MsgBoxStyle.Critical, "Error")
            Me.btnProveedor.Focus()
        End If
    End Sub

    Private Sub dgvProveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellClick
        If e.RowIndex >= 0 Then
            txtCodigo.Text = dgvProveedores.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtProveedor.Text = dgvProveedores.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtProducto.Text = dgvProveedores.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtIdProveedor.Text = dgvProveedores.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtIdProducto.Text = dgvProveedores.Rows(e.RowIndex).Cells(4).Value.ToString()
        End If
    End Sub

    'Private Sub dgvProductos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProductos.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If dgvProductos.CurrentRow IsNot Nothing AndAlso dgvProductos.CurrentRow.Index >= 0 Then
    '            txtCodigo2.Text = dgvProductos.CurrentRow.Cells(0).Value.ToString()
    '            txtNombre2.Text = dgvProductos.CurrentRow.Cells(1).Value.ToString()
    '            txtCantidad2.Text = dgvProductos.CurrentRow.Cells(2).Value.ToString()
    '        End If
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub dgvProveedores_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProveedores.SelectionChanged
        If dgvProveedores.CurrentRow IsNot Nothing AndAlso dgvProveedores.CurrentRow.Index >= 0 Then
            txtCodigo.Text = dgvProveedores.CurrentRow.Cells(0).Value.ToString()
            txtProveedor.Text = dgvProveedores.CurrentRow.Cells(1).Value.ToString()
            txtProducto.Text = dgvProveedores.CurrentRow.Cells(2).Value.ToString()
            txtIdProveedor.Text = dgvProveedores.CurrentRow.Cells(3).Value.ToString()
            txtIdProducto.Text = dgvProveedores.CurrentRow.Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        actualizarProveedoresProductos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        deleteProveedoresProductos()
    End Sub

    Private Sub txtBuscarProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProveedor.TextChanged
        Dim filtro As String = ""
        filtro = $"PROVEEDOR LIKE '%{txtBuscarProveedor.Text.Trim()}%'"
        CType(dgvProveedores.DataSource, DataTable).DefaultView.RowFilter = filtro
    End Sub

    Private Sub txtBuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProducto.TextChanged
        Dim filtro As String = ""
        filtro = $"PRODUCTO LIKE '%{txtBuscarProducto.Text.Trim()}%'"
        CType(dgvProveedores.DataSource, DataTable).DefaultView.RowFilter = filtro
    End Sub
End Class