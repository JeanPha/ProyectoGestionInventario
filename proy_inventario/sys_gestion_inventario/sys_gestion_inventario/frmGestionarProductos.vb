Public Class frmGestionarProductos
    Private Sub frmGestionarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarProductos()
        Me.txtBuscar.Clear()
        Me.dgvProductos.Focus()

        Me.MaximizeBox = False ' Desactiva el botón de maximizar
        Me.MinimizeBox = False ' Desactiva el botón de minimizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Desactiva la capacidad de redimensionar verticalmente


        If flag_where = 1 Then
            'Me.dgvProveedores.Focus()
            Me.Size = New Size(500, 415)
            'Me.txtBuscar.Visible = False

            ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
            Me.StartPosition = FormStartPosition.Manual
            Me.Location = New Point(-7, 56)

        End If
    End Sub

    Public IdProductoSeleccionado As String
    Public ProductoSeleccionado As String

    Private Sub dgvProductos_keyDown(sender As Object, e As KeyEventArgs) Handles dgvProductos.KeyDown
        If e.KeyCode = Keys.Enter Then

            ' Verifica si hay una fila seleccionada
            If dgvProductos.SelectedRows.Count > 0 Then
                Try
                    ' Captura los valores de las celdas
                    IdProductoSeleccionado = dgvProductos.SelectedRows(0).Cells(0).Value.ToString()
                    ProductoSeleccionado = dgvProductos.SelectedRows(0).Cells(1).Value.ToString()

                    ' Cierra el formulario actual
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Error al obtener los valores de las celdas seleccionadas: " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        End If
    End Sub

    Private Sub llenarProductos()
        If flag_where = 1 Then
            Me.txtBuscar.Clear()
            Dim sql As String = "SELECT p.id AS 'CODIGO', p.nombre AS 'NOMBRE', p.cantidad AS 'CANTIDAD'
                                FROM productos p
                                    LEFT JOIN proveedores_productos pp ON p.id = pp.idProd
                                    WHERE pp.idProd IS NULL;"
            Dim ds As New DataSet
            Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

            ds.Tables.Add("productos")
            adp.Fill(ds.Tables("productos"))
            Me.dgvProductos.DataSource = ds.Tables("productos")

        Else

            Me.txtBuscar.Clear()
            Dim sql As String = "SELECT id AS 'CODIGO', nombre AS NOMBRE, cantidad AS CANTIDAD FROM productos"
            Dim ds As New DataSet
            Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

            ds.Tables.Add("productos")
            adp.Fill(ds.Tables("productos"))
            Me.dgvProductos.DataSource = ds.Tables("productos")
        End If

    End Sub

    Private Sub deleteProductos()
        Dim wcp As Integer = Convert.ToInt32(Me.dgvProductos.CurrentRow.Cells(0).Value)
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "DELETE FROM productos WHERE id = @id"

        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@id", wcp)

        Try
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarProductos()
            Me.txtCodigo2.Clear()
            Me.txtNombre2.Clear()
            Me.txtCantidad2.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        End Try
    End Sub

    Private Sub actualizarProductos()
        Dim wcp As Integer = Convert.ToInt32(Me.dgvProductos.CurrentRow.Cells(0).Value)

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "UPDATE productos SET nombre = @nombre, cantidad = @cantidad WHERE id = @id"

        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@nombre", Me.txtNombre2.Text)
        cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(Me.txtCantidad2.Text))
        cmd.Parameters.AddWithValue("@id", wcp)

        If Me.txtNombre2.Text <> "" And Me.txtCantidad2.Text <> "" Then
            Try
                If cmd.Connection.State = ConnectionState.Closed Then
                    cmd.Connection.Open()
                End If
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarProductos()
                Me.txtCodigo2.Clear()
                Me.txtNombre2.Clear()
                Me.txtCantidad2.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                If cmd.Connection.State = ConnectionState.Open Then
                    cmd.Connection.Close()
                End If
            End Try
        Else
            MsgBox("Complete todos los campos.", MsgBoxStyle.Critical, "Error")
            Me.txtNombre2.Focus()
        End If
    End Sub

    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        If e.RowIndex >= 0 Then
            txtCodigo2.Text = dgvProductos.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNombre2.Text = dgvProductos.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtCantidad2.Text = dgvProductos.Rows(e.RowIndex).Cells(2).Value.ToString()
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

    Private Sub dgvProductos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProductos.SelectionChanged
        If dgvProductos.CurrentRow IsNot Nothing AndAlso dgvProductos.CurrentRow.Index >= 0 Then
            txtCodigo2.Text = dgvProductos.CurrentRow.Cells(0).Value.ToString()
            txtNombre2.Text = dgvProductos.CurrentRow.Cells(1).Value.ToString()
            txtCantidad2.Text = dgvProductos.CurrentRow.Cells(2).Value.ToString()
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        actualizarProductos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        deleteProductos()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim filtro As String = ""
        filtro = $"NOMBRE LIKE '%{txtBuscar.Text.Trim()}%'"
        CType(dgvProductos.DataSource, DataTable).DefaultView.RowFilter = filtro
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class