Public Class frmAsociarPedidosProveedores
    Private Sub frmAsociarPedidosProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'generarId()
        btnProveedor.Focus()




    End Sub
    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        generarId()


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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        agregar()
    End Sub

    Private Sub Agregar()
        If Me.txtCodigo.Text <> "" AndAlso Me.txtProveedor.Text <> "" AndAlso Me.txtProducto.Text <> "" Then
            cmd.Connection = conexion.conexion
            cmd.CommandType = CommandType.Text
            Dim sql As String = "INSERT INTO proveedores_productos (idProvPed, idProv, idProd) VALUES (@idProvPed, @idProv, @idProd)"
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@idProvPed", Me.txtCodigo.Text)
            cmd.Parameters.AddWithValue("@idProv", Me.txtIdProveedor.Text)
            cmd.Parameters.AddWithValue("@idProd", Me.txtIdProducto.Text)


            Try
                If cmd.Connection.State = ConnectionState.Closed Then
                    cmd.Connection.Open()
                End If
                cmd.ExecuteNonQuery()
                Console.Beep()
                'llenarProductos()
                Me.txtCodigo.Clear()
                Me.txtIdProducto.Clear()
                txtProducto.Clear()
                txtIdProveedor.Clear()
                Me.txtProveedor.Clear()

                ' Configurar el color de fondo de los TextBox verde
                txtCodigo.BackColor = Color.PaleGreen
                txtProducto.BackColor = Color.PaleGreen
                txtProveedor.BackColor = Color.PaleGreen
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                If cmd.Connection.State = ConnectionState.Open Then
                    cmd.Connection.Close()
                End If
            End Try
        Else
            MsgBox("Complete todos los campos.", MsgBoxStyle.Critical, "Error")
            ' Configurar el color de fondo de los TextBox rojo
            txtCodigo.BackColor = Color.LightSalmon
            txtProducto.BackColor = Color.LightSalmon
            txtProveedor.BackColor = Color.LightSalmon
        End If
    End Sub

    Private Sub generarId()
        Dim wid_juicio As Integer ' Asegúrate de que esta variable esté definida
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "SELECT MAX(idProvPed) FROM proveedores_productos"
        cmd.CommandText = sql

        Try
            ' Abre la conexión si está cerrada
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If

            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                While dr.Read()
                    If IsDBNull(dr(0)) Then
                        wid_juicio = 1
                    Else
                        wid_juicio = Convert.ToInt32(dr(0)) + 1
                    End If
                End While
            Else
                wid_juicio = 1 ' Si no hay filas, empezamos con 1
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            ' Asegúrate de cerrar el DataReader
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
            ' Cierra la conexión si está abierta
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        End Try

        Me.txtCodigo.Text = wid_juicio.ToString()
        Me.btnProveedor.Focus()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class