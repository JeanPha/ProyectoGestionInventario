Imports System.Data.SqlClient

Public Class frmRealizarPedidos
    Private Sub frmRealizarPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenar el ComboBox con los proveedores
        llenarComboBoxProveedor()
        llenarRealizarProductos()
        llenarComboBoxProveedor2()
        llenarComboBoxMetodoPago()
        llenarComboBoxProveedorV()
        llenarComboBoxMetodoPagoV()
        llenarProductosRealizados()
        llenarPedidosEntregados()
        CalcularTotal()

        Me.MaximizeBox = False ' Desactiva el botón de maximizar
        Me.MinimizeBox = False ' Desactiva el botón de minimizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Desactiva la capacidad de redimensionar verticalmente



        Me.txtBuscarProveedor.Visible = False

        ' Hacer que el ComboBox sea readonly
        cbProveedor.DropDownStyle = ComboBoxStyle.DropDownList
        cbProveedor2.DropDownStyle = ComboBoxStyle.DropDownList
        cbProveedorV.DropDownStyle = ComboBoxStyle.DropDownList
        cbProveedorE.DropDownStyle = ComboBoxStyle.DropDownList
        cbFormaPago.DropDownStyle = ComboBoxStyle.DropDownList
        cbFormaPagoV.DropDownStyle = ComboBoxStyle.DropDownList
        cbFormaPagoE.DropDownStyle = ComboBoxStyle.DropDownList
        cbEstado.DropDownStyle = ComboBoxStyle.DropDownList
        cbEstadoPedido.DropDownStyle = ComboBoxStyle.DropDownList
        cbEstadoPedidoE.DropDownStyle = ComboBoxStyle.DropDownList

        DateTimePickerEntrega.DropDownAlign = ComboBoxStyle.DropDown
        DateTimePickerEntregaE.DropDownAlign = ComboBoxStyle.DropDown
        DateTimePickerEntregaV.DropDownAlign = ComboBoxStyle.DropDown
        DateTimePickerFechaFiltro.DropDownAlign = ComboBoxStyle.DropDown
        DateTimePickerRealizacion.DropDownAlign = ComboBoxStyle.DropDown
        DateTimePickerRealizacionV.DropDownAlign = ComboBoxStyle.DropDown
        DateTimePickerRealizacionE.DropDownAlign = ComboBoxStyle.DropDown

        cbEstado.Text = "REALIZADO"

        Me.txtCodigoV.ReadOnly = True

        Me.LbEstado.Visible = False
        Me.cbEstado.Visible = False

        Me.lbEstadoPedido.Visible = False
        Me.cbEstadoPedido.Visible = False



    End Sub



    Private Sub llenarComboBoxProveedor()
        Dim sql As String = "SELECT proveedores.nombre 	
                            FROM proveedores_productos
                                 INNER JOIN productos ON proveedores_productos.idProd = productos.id
                                 INNER JOIN proveedores ON proveedores_productos.idProv = proveedores.idProv
                                 GROUP BY proveedores.nombre"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        Try
            ds.Tables.Add("proveedores")
            adp.Fill(ds.Tables("proveedores"))

            Me.cbProveedor.DataSource = ds.Tables("proveedores")
            Me.cbProveedor.DisplayMember = "nombre" ' El nombre de la columna que deseas mostrar en el ComboBox
            Me.cbProveedor.ValueMember = "nombre" ' El nombre de la columna que deseas usar como valor (puede ser una columna diferente si deseas)

        Catch ex As Exception
            MsgBox("Error al llenar el ComboBox: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub llenarComboBoxProveedor2()
        Dim sql As String = "SELECT proveedores.nombre 	
                            FROM proveedores_productos
                                 INNER JOIN productos ON proveedores_productos.idProd = productos.id
                                 INNER JOIN proveedores ON proveedores_productos.idProv = proveedores.idProv
                                 GROUP BY proveedores.nombre"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        Try
            ds.Tables.Add("proveedores")
            adp.Fill(ds.Tables("proveedores"))

            Me.cbProveedor2.DataSource = ds.Tables("proveedores")
            Me.cbProveedor2.DisplayMember = "nombre" ' El nombre de la columna que deseas mostrar en el ComboBox
            Me.cbProveedor2.ValueMember = "nombre" ' El nombre de la columna que deseas usar como valor (puede ser una columna diferente si deseas)

        Catch ex As Exception
            MsgBox("Error al llenar el ComboBox: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub llenarComboBoxProveedorV()
        Dim sql As String = "SELECT proveedores.nombre 	
                            FROM proveedores_productos
                                 INNER JOIN productos ON proveedores_productos.idProd = productos.id
                                 INNER JOIN proveedores ON proveedores_productos.idProv = proveedores.idProv
                                 GROUP BY proveedores.nombre"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        Try
            ds.Tables.Add("proveedores")
            adp.Fill(ds.Tables("proveedores"))

            Me.cbProveedorV.DataSource = ds.Tables("proveedores")
            Me.cbProveedorV.DisplayMember = "nombre" ' El nombre de la columna que deseas mostrar en el ComboBox
            Me.cbProveedorV.ValueMember = "nombre" ' El nombre de la columna que deseas usar como valor (puede ser una columna diferente si deseas)

        Catch ex As Exception
            MsgBox("Error al llenar el ComboBox: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Private Sub llenarComboBoxMetodoPago()
        Dim sql As String = "SELECT nombreMetodo FROM metodos_transaccion"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        Try
            ' Añadir la tabla con un nombre descriptivo
            ds.Tables.Add("metodosPago")
            adp.Fill(ds.Tables("metodosPago"))

            ' Establecer la fuente de datos y el miembro de visualización del ComboBox
            Me.cbFormaPago.DataSource = ds.Tables("metodosPago")
            Me.cbFormaPago.DisplayMember = "nombreMetodo"
            Me.cbFormaPago.ValueMember = "nombreMetodo" ' Esto es opcional y depende de cómo quieras usar los datos

        Catch ex As Exception
            MsgBox("Error al llenar el ComboBox: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Private Sub llenarComboBoxMetodoPagoV()
        Dim sql As String = "SELECT nombreMetodo FROM metodos_transaccion"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        Try
            ' Añadir la tabla con un nombre descriptivo
            ds.Tables.Add("metodosPago")
            adp.Fill(ds.Tables("metodosPago"))

            ' Establecer la fuente de datos y el miembro de visualización del ComboBox
            Me.cbFormaPagoV.DataSource = ds.Tables("metodosPago")
            Me.cbFormaPagoV.DisplayMember = "nombreMetodo"
            Me.cbFormaPagoV.ValueMember = "nombreMetodo" ' Esto es opcional y depende de cómo quieras usar los datos

        Catch ex As Exception
            MsgBox("Error al llenar el ComboBox: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub llenarRealizarProductos()
        Dim sql As String = "SELECT proveedores_productos.idProvPed AS CODIGO, proveedores.nombre AS PROVEEDOR, 
                                    productos.nombre AS PRODUCTO, productos.cantidad as CANTIDAD
                             FROM proveedores_productos
                             INNER JOIN productos ON proveedores_productos.idProd = productos.id
                             INNER JOIN proveedores ON proveedores_productos.idProv = proveedores.idProv"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("productos")
        adp.Fill(ds.Tables("productos"))
        Me.dgvProductosProveedores.DataSource = ds.Tables("productos")

        ' Configurar los encabezados de columna en negrita
        With dgvProductosProveedores.ColumnHeadersDefaultCellStyle
            .Font = New Font(dgvProductosProveedores.Font, FontStyle.Bold)
        End With
    End Sub



    Private Sub cbProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProveedor.SelectedIndexChanged
        If cbProveedor.SelectedItem IsNot Nothing Then
            txtBuscarProveedor.Text = cbProveedor.SelectedValue.ToString()
            ' Aplicar el filtro cuando cambie el valor del ComboBox
            AplicarFiltroProveedor()
        End If
    End Sub

    Private Sub txtBuscarProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarProveedor.TextChanged
        AplicarFiltroProveedor()
    End Sub

    Private Sub AplicarFiltroProveedor()
        If dgvProductosProveedores.DataSource IsNot Nothing AndAlso TypeOf dgvProductosProveedores.DataSource Is DataTable Then
            Dim filtro As String = $"PROVEEDOR = '{txtBuscarProveedor.Text.Trim()}'"
            CType(dgvProductosProveedores.DataSource, DataTable).DefaultView.RowFilter = filtro
        End If
    End Sub

    'Realizar Pedidos
    Private Sub RegistrarPedido()
        ' Variables para almacenar los valores de los controles
        Dim proveedor As String = cbProveedor2.Text.Trim()
        Dim monto As Decimal = Convert.ToDecimal(txtMonto.Text.Trim())
        Dim formaPago As String = cbFormaPago.Text.Trim()
        Dim fechaPedido As Date = DateTimePickerRealizacion.Value.Date
        Dim fechaEntrega As Date = DateTimePickerEntrega.Value.Date
        Dim estado As String = cbEstado.Text.Trim()
        Dim estadoPedidoHecho = ""

        ' Consulta SQL para insertar los datos
        Dim sql As String = "INSERT INTO registrarPedidos (proveedor, monto, formaPago, fechaPedido, fechaEntrega, estadoPedido, estadoPedidoHecho) " &
                        "VALUES (@proveedor, @monto, @formaPago, @fechaPedido, @fechaEntrega, @estadoPedido, @estadoPedidoHecho)"

        ' Crear comando
        Using cmd As New SqlCommand(sql, conexion.getConexion())
            ' Agregar parámetros con sus valores
            cmd.Parameters.AddWithValue("@proveedor", proveedor)
            cmd.Parameters.AddWithValue("@monto", monto)
            cmd.Parameters.AddWithValue("@formaPago", formaPago)
            cmd.Parameters.AddWithValue("@fechaPedido", fechaPedido)
            cmd.Parameters.AddWithValue("@fechaEntrega", fechaEntrega)
            cmd.Parameters.AddWithValue("@estadoPedido", estado)
            cmd.Parameters.AddWithValue("@estadoPedidoHecho", estadoPedidoHecho)

            Try
                ' Abrir conexión
                conexion.conectar()

                ' Ejecutar comando
                cmd.ExecuteNonQuery()
                MessageBox.Show("Pedido registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Limpiar los controles
                cbProveedor2.SelectedIndex = -1
                txtMonto.Clear()
                cbFormaPago.SelectedIndex = -1
                DateTimePickerRealizacion.Value = DateTime.Now
                DateTimePickerEntrega.Value = DateTime.Now
                'cbEstado.SelectedIndex = -1

            Catch ex As Exception
                MessageBox.Show("Error al registrar el pedido: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Cerrar conexión
                conexion.cerrar()
            End Try
        End Using
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        ' Verificar si los campos están vacíos
        If String.IsNullOrEmpty(cbProveedor2.Text) Or
           String.IsNullOrEmpty(txtMonto.Text) Or
           String.IsNullOrEmpty(cbFormaPago.Text) Then
            MessageBox.Show("Complete todos los campos")
        Else
            RegistrarPedido()
            llenarProductosRealizados()
            llenarPedidosEntregados()
        End If
    End Sub
    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        funciones.SoloNumerosDecimales(sender, e)
    End Sub

    Private Sub llenarProductosRealizados()
        Dim sql As String = "SELECT 
                                idRegistrarPedidos AS CODIGO, 
                                proveedor AS PROVEEDOR,
                                monto AS MONTO, 
                                formaPago AS 'FORMA_PAGO',
                                fechaPedido AS 'FECHA_PEDIDO', 
                                fechaEntrega AS 'FECHA_ENTREGA', 
                                estadoPedido AS ESTADO
                            FROM 
                                registrarPedidos
                            WHERE 
                                estadoPedidoHecho = ''"

        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("productos")
        adp.Fill(ds.Tables("productos"))
        Me.dgvRealizarPedidos.DataSource = ds.Tables("productos")

        ' Configurar los encabezados de columna en negrita
        With dgvRealizarPedidos.ColumnHeadersDefaultCellStyle
            .Font = New Font(dgvRealizarPedidos.Font, FontStyle.Bold)
        End With
    End Sub

    Private Sub dgvRealizarPedidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRealizarPedidos.CellClick
        If e.RowIndex >= 0 Then
            txtCodigoV.Text = dgvRealizarPedidos.Rows(e.RowIndex).Cells(0).Value.ToString()
            cbProveedorV.Text = dgvRealizarPedidos.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtMontoV.Text = dgvRealizarPedidos.Rows(e.RowIndex).Cells(2).Value.ToString()
            cbFormaPagoV.Text = dgvRealizarPedidos.Rows(e.RowIndex).Cells(3).Value.ToString()
            DateTimePickerRealizacionV.Text = dgvRealizarPedidos.Rows(e.RowIndex).Cells(4).Value.ToString()
            DateTimePickerEntregaV.Text = dgvRealizarPedidos.Rows(e.RowIndex).Cells(5).Value.ToString()
            cbEstadoPedido.Text = dgvRealizarPedidos.Rows(e.RowIndex).Cells(6).Value.ToString()
        End If

        'Dim fechaSeleccionada As Date = DateTimePickerEntregaV.Value.Date
        'Dim fechaHoy As Date = DateTime.Now.Date

        'If fechaHoy >= fechaSeleccionada Then
        '    lbEstadoPedido.Visible = True
        '    cbEstadoPedido.Visible = True
        'Else
        '    lbEstadoPedido.Visible = False
        '    cbEstadoPedido.Visible = False
        'End If
    End Sub



    Private Sub dgvRealizarPedidos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvRealizarPedidos.SelectionChanged
        If dgvRealizarPedidos.CurrentRow IsNot Nothing AndAlso dgvRealizarPedidos.CurrentRow.Index >= 0 Then
            txtCodigoV.Text = dgvRealizarPedidos.CurrentRow.Cells(0).Value.ToString()
            cbProveedorV.Text = dgvRealizarPedidos.CurrentRow.Cells(1).Value.ToString()
            txtMontoV.Text = dgvRealizarPedidos.CurrentRow.Cells(2).Value.ToString()
            cbFormaPagoV.Text = dgvRealizarPedidos.CurrentRow.Cells(3).Value.ToString()
            DateTimePickerRealizacionV.Text = dgvRealizarPedidos.CurrentRow.Cells(4).Value.ToString()
            DateTimePickerEntregaV.Text = dgvRealizarPedidos.CurrentRow.Cells(5).Value.ToString()
            cbEstadoPedido.Text = dgvRealizarPedidos.CurrentRow.Cells(6).Value.ToString()
        End If

        'Dim fechaSeleccionada As Date = DateTimePickerEntregaV.Value.Date
        'Dim fechaHoy As Date = DateTime.Now.Date

        'If fechaHoy >= fechaSeleccionada Then
        '    lbEstadoPedido.Visible = True
        '    cbEstadoPedido.Visible = True
        'Else
        '    lbEstadoPedido.Visible = False
        '    cbEstadoPedido.Visible = False
        'End If
    End Sub

    Private Sub actualizarPedidos()
        ' Obtener el idRegistrarPedidos del TextBox txtCodigoV
        Dim idRegistrarPedidos As Integer = Convert.ToInt32(Me.txtCodigoV.Text)

        ' Configurar la conexión y el comando
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "UPDATE registrarPedidos SET proveedor = @proveedor, monto = @monto, formaPago = @formaPago, fechaPedido = @fechaPedido, fechaEntrega = @fechaEntrega, estadoPedido = @estadoPedido WHERE idRegistrarPedidos = @idRegistrarPedidos"

        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@proveedor", Me.cbProveedorV.Text)
        cmd.Parameters.AddWithValue("@monto", Convert.ToDecimal(Me.txtMontoV.Text))
        cmd.Parameters.AddWithValue("@formaPago", Me.cbFormaPagoV.Text)
        cmd.Parameters.AddWithValue("@fechaPedido", Me.DateTimePickerRealizacionV.Value.Date)
        cmd.Parameters.AddWithValue("@fechaEntrega", Me.DateTimePickerEntregaV.Value.Date)
        cmd.Parameters.AddWithValue("@idRegistrarPedidos", idRegistrarPedidos)
        cmd.Parameters.AddWithValue("@estadoPedido", "REALIZADO")

        ' Verificar que todos los campos estén completos
        If Me.cbProveedorV.Text <> "" AndAlso Me.txtMontoV.Text <> "" AndAlso Me.cbFormaPagoV.Text <> "" Then
            Try
                ' Abrir la conexión si está cerrada
                If cmd.Connection.State = ConnectionState.Closed Then
                    cmd.Connection.Open()
                End If

                ' Ejecutar el comando de actualización
                cmd.ExecuteNonQuery()
                Console.Beep()

                ' Llenar los pedidos para actualizar el DataGridView
                llenarProductosRealizados()

                ' Limpiar los controles
                Me.txtCodigoV.Clear()
                Me.cbProveedorV.SelectedIndex = -1
                Me.txtMontoV.Clear()
                Me.cbFormaPagoV.SelectedIndex = -1
                Me.DateTimePickerRealizacionV.Value = DateTime.Now
                Me.DateTimePickerEntregaV.Value = DateTime.Now
                'Me.cbEstadoPedido.SelectedIndex = -1

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                ' Cerrar la conexión si está abierta
                If cmd.Connection.State = ConnectionState.Open Then
                    cmd.Connection.Close()
                End If
            End Try
        Else
            ' Mostrar un mensaje si no se han completado todos los campos
            MsgBox("Complete todos los campos.", MsgBoxStyle.Critical, "Error")
            Me.cbProveedorV.Focus()
        End If
    End Sub

    Private Sub deletePedidos()
        ' Obtener el idRegistrarPedidos del TextBox txtCodigoV
        Dim idRegistrarPedidos As Integer = Convert.ToInt32(Me.txtCodigoV.Text)

        ' Configurar la conexión y el comando
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "DELETE FROM registrarPedidos WHERE idRegistrarPedidos = @idRegistrarPedidos"

        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@idRegistrarPedidos", idRegistrarPedidos)

        ' Verificar que el idRegistrarPedidos no esté vacío
        If Me.txtCodigoV.Text <> "" Then
            Try
                ' Abrir la conexión si está cerrada
                If cmd.Connection.State = ConnectionState.Closed Then
                    cmd.Connection.Open()
                End If

                ' Ejecutar el comando de eliminación
                cmd.ExecuteNonQuery()
                Console.Beep()

                ' Llenar los pedidos para actualizar el DataGridView
                llenarProductosRealizados()

                ' Limpiar los controles
                Me.txtCodigoV.Clear()
                Me.cbProveedorV.SelectedIndex = -1
                Me.txtMontoV.Clear()
                Me.cbFormaPagoV.SelectedIndex = -1
                Me.DateTimePickerRealizacionV.Value = DateTime.Now
                Me.DateTimePickerEntregaV.Value = DateTime.Now
                'Me.cbEstadoPedido.SelectedIndex = -1

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                ' Cerrar la conexión si está abierta
                If cmd.Connection.State = ConnectionState.Open Then
                    cmd.Connection.Close()
                End If
            End Try
        Else
            ' Mostrar un mensaje si no se ha seleccionado un pedido para eliminar
            MsgBox("Seleccione un pedido para eliminar.", MsgBoxStyle.Critical, "Error")
            Me.cbProveedorV.Focus()
        End If
    End Sub

    Private Sub DateTimePickerFechaFiltro_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFechaFiltro.ValueChanged
        Dim filtro As String = ""
        Dim fechaSeleccionada As String = DateTimePickerFechaFiltro.Value.ToString("yyyy-MM-dd")

        filtro = $"FECHA_ENTREGA = '{fechaSeleccionada}'"

        If CType(dgvRealizarPedidos.DataSource, DataTable) IsNot Nothing Then
            CType(dgvRealizarPedidos.DataSource, DataTable).DefaultView.RowFilter = filtro
            CalcularTotal()
        Else
            MessageBox.Show("No hay datos para filtrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnEditar_Click_1(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim fechaSeleccionada As Date = DateTimePickerEntregaV.Value.Date
        Dim fechaHoy As Date = DateTime.Now.Date
        If txtCodigoV.Text = "" Then
            MessageBox.Show("Seleccione un pedido")
        ElseIf fechaHoy > fechaSeleccionada Then
            MessageBox.Show("No se puede Editar pedidos con fecha anterior a la fecha de hoy.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            actualizarPedidos()
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim fechaSeleccionada As Date = DateTimePickerEntregaV.Value.Date
        Dim fechaHoy As Date = DateTime.Now.Date

        If txtCodigoV.Text = "" Or cbProveedorV.Text = "" Or txtMontoV.Text = "" Or cbFormaPago.Text = "" Then
            MessageBox.Show("Seleccione un pedido")
        ElseIf fechaHoy >= fechaSeleccionada Then
            MessageBox.Show("No se puede borrar pedidos con fecha anterior a la fecha de hoy.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            deletePedidos()
        End If

    End Sub





    Private Sub CalcularTotal()
        Dim total As Decimal = 0 ' Variable para almacenar la suma

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In dgvRealizarPedidos.Rows
            ' Verificar que la fila no sea nueva (para evitar filas vacías)
            If Not row.IsNewRow Then
                ' Sumar el valor de la columna 2 (índice 2 porque es basado en cero)
                total += Convert.ToDecimal(row.Cells(2).Value)
            End If
        Next

        ' Asignar el total al TextBox con el signo $
        txtTotal.Text = "$" & total.ToString("0.00")
    End Sub




    'PEDIDOS ENTREGADOS ----------------------------------

    Private Sub llenarPedidosEntregados()
        Dim sql As String = "SELECT 
                                    idRegistrarPedidos AS CODIGO, 
                                    proveedor AS PROVEEDOR,
                                    monto AS MONTO, 
                                    formaPago AS 'FORMA_PAGO',
                                    fechaPedido AS 'FECHA_PEDIDO', 
                                    fechaEntrega AS 'FECHA_ENTREGA', 
                                    estadoPedido AS ESTADO, 
                                    estadoPedidoHecho as CONDICION
                                FROM 
                                    registrarPedidos
                                WHERE 
                                    CONVERT(DATE, fechaEntrega) = CONVERT(DATE, GETDATE()) and estadoPedidoHecho = ''"

        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("productos")
        adp.Fill(ds.Tables("productos"))
        Me.dgvPedidosEntregados.DataSource = ds.Tables("productos")

        ' Configurar los encabezados de columna en negrita
        With dgvPedidosEntregados.ColumnHeadersDefaultCellStyle
            .Font = New Font(dgvPedidosEntregados.Font, FontStyle.Bold)
        End With
    End Sub

    Private Sub dgvPedidosEntregados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPedidosEntregados.CellClick
        If e.RowIndex >= 0 Then
            txtCodigoE.Text = dgvPedidosEntregados.Rows(e.RowIndex).Cells(0).Value.ToString()
            cbProveedorE.Text = dgvPedidosEntregados.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtMontoE.Text = dgvPedidosEntregados.Rows(e.RowIndex).Cells(2).Value.ToString()
            cbFormaPagoE.Text = dgvPedidosEntregados.Rows(e.RowIndex).Cells(3).Value.ToString()
            DateTimePickerRealizacionE.Text = dgvPedidosEntregados.Rows(e.RowIndex).Cells(4).Value.ToString()
            DateTimePickerEntregaE.Text = dgvPedidosEntregados.Rows(e.RowIndex).Cells(5).Value.ToString()
            cbEstadoPedidoE.Text = dgvPedidosEntregados.Rows(e.RowIndex).Cells(7).Value.ToString()
        End If

        'Dim fechaSeleccionada As Date = DateTimePickerEntregaV.Value.Date
        'Dim fechaHoy As Date = DateTime.Now.Date

        'If fechaHoy >= fechaSeleccionada Then
        '    lbEstadoPedido.Visible = True
        '    cbEstadoPedido.Visible = True
        'Else
        '    lbEstadoPedido.Visible = False
        '    cbEstadoPedido.Visible = False
        'End If
    End Sub



    Private Sub dgvPedidosEntregados_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPedidosEntregados.SelectionChanged
        If dgvPedidosEntregados.CurrentRow IsNot Nothing AndAlso dgvPedidosEntregados.CurrentRow.Index >= 0 Then
            txtCodigoE.Text = dgvPedidosEntregados.CurrentRow.Cells(0).Value.ToString()
            cbProveedorE.Text = dgvPedidosEntregados.CurrentRow.Cells(1).Value.ToString()
            txtMontoE.Text = dgvPedidosEntregados.CurrentRow.Cells(2).Value.ToString()
            cbFormaPagoE.Text = dgvPedidosEntregados.CurrentRow.Cells(3).Value.ToString()
            DateTimePickerRealizacionE.Text = dgvPedidosEntregados.CurrentRow.Cells(4).Value.ToString()
            DateTimePickerEntregaE.Text = dgvPedidosEntregados.CurrentRow.Cells(5).Value.ToString()
            cbEstadoPedidoE.Text = dgvPedidosEntregados.CurrentRow.Cells(7).Value.ToString()
        End If

        'Dim fechaSeleccionada As Date = DateTimePickerEntregaV.Value.Date
        'Dim fechaHoy As Date = DateTime.Now.Date

        'If fechaHoy >= fechaSeleccionada Then
        '    lbEstadoPedido.Visible = True
        '    cbEstadoPedido.Visible = True
        'Else
        '    lbEstadoPedido.Visible = False
        '    cbEstadoPedido.Visible = False
        'End If
    End Sub

    Private Sub RegistrarPedidoEntregado()
        ' Variables para almacenar los valores de los controles
        Dim proveedor As String = cbProveedorE.Text.Trim()
        Dim monto As Decimal = Convert.ToDecimal(txtMontoE.Text.Trim())
        Dim formaPago As String = cbFormaPagoE.Text.Trim()
        Dim fechaPedido As Date = DateTimePickerRealizacionE.Value.Date
        Dim fechaEntrega As Date = DateTimePickerEntregaE.Value.Date
        Dim estadoPedido As String = "REALIZADO"
        Dim estadoPedidoHecho As String = cbEstadoPedidoE.Text.Trim()
        Dim idRegistrarPedidos As Integer = txtCodigoE.Text

        ' Consulta SQL para insertar los datos
        Dim sql As String = "UPDATE registrarPedidos
                                SET 
                                    proveedor = @proveedor, 
                                    monto = @monto, 
                                    formaPago = @formaPago, 
                                    fechaPedido = @fechaPedido, 
                                    fechaEntrega = @fechaEntrega, 
                                    estadoPedido = @estadoPedido, 
                                    estadoPedidoHecho = @estadoPedidoHecho
                                WHERE 
                                    idRegistrarPedidos = @idRegistrarPedidos"

        ' Crear comando
        Using cmd As New SqlCommand(sql, conexion.getConexion())
            ' Agregar parámetros con sus valores
            cmd.Parameters.AddWithValue("@proveedor", proveedor)
            cmd.Parameters.AddWithValue("@monto", monto)
            cmd.Parameters.AddWithValue("@formaPago", formaPago)
            cmd.Parameters.AddWithValue("@fechaPedido", fechaPedido)
            cmd.Parameters.AddWithValue("@fechaEntrega", fechaEntrega)
            cmd.Parameters.AddWithValue("@estadoPedido", estadoPedido)
            cmd.Parameters.AddWithValue("@estadoPedidoHecho", estadoPedidoHecho)
            cmd.Parameters.AddWithValue("@idRegistrarPedidos", idRegistrarPedidos)


            Try
                ' Abrir conexión
                conexion.conectar()

                ' Ejecutar comando
                cmd.ExecuteNonQuery()
                MessageBox.Show("Pedido registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Limpiar los controles
                cbProveedor2.SelectedIndex = -1
                txtMonto.Clear()
                cbFormaPago.SelectedIndex = -1
                DateTimePickerRealizacion.Value = DateTime.Now
                DateTimePickerEntrega.Value = DateTime.Now
                'cbEstado.SelectedIndex = -1



            Catch ex As Exception
                MessageBox.Show("Error al registrar el pedido: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Cerrar conexión
                conexion.cerrar()
            End Try
        End Using
    End Sub

    Private Sub btnRegistrarPedidosEntregrados_Click(sender As Object, e As EventArgs) Handles btnRegistrarPedidosEntregrados.Click
        ' Verificar si los campos están vacíos
        If String.IsNullOrEmpty(cbEstadoPedidoE.Text) Then

            MessageBox.Show("Seleccione el estado del pedido")
        Else
            RegistrarPedidoEntregado()
            llenarPedidosEntregados()
        End If
    End Sub

    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged

    End Sub
End Class
