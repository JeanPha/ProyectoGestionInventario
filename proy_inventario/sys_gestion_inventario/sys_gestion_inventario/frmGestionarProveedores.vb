Public Class frmGestionarProveedores
    Private Sub frmGestionarPrveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarProveedores()
        Me.txtBuscar.Clear()
        Me.dgvProveedores.Focus()

        Me.MaximizeBox = False ' Desactiva el botón de maximizar
        Me.MinimizeBox = False ' Desactiva el botón de minimizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Desactiva la capacidad de redimensionar verticalmente

        If flag_where = 1 Then
            'Me.dgvProveedores.Focus()
            Me.Size = New Size(740, 415)
            'Me.txtBuscar.Visible = False

            ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
            Me.StartPosition = FormStartPosition.Manual
            Me.Location = New Point(-7, 56)

        End If
    End Sub

    Public IdProveedorSeleccionado As String
    Public ProveedorSeleccionado As String

    Private Sub dgvProveedores_keyDown(sender As Object, e As KeyEventArgs) Handles dgvProveedores.KeyDown
        If e.KeyCode = Keys.Enter Then

            ' Verifica si hay una fila seleccionada
            If dgvProveedores.SelectedRows.Count > 0 Then
                Try
                    ' Captura los valores de las celdas
                    IdProveedorSeleccionado = dgvProveedores.SelectedRows(0).Cells(0).Value.ToString()
                    ProveedorSeleccionado = dgvProveedores.SelectedRows(0).Cells(1).Value.ToString()

                    ' Cierra el formulario actual
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Error al obtener los valores de las celdas seleccionadas: " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        End If
    End Sub


    Private Sub llenarProveedores()
        Me.txtBuscar.Clear()
        Dim sql As String = "SELECT idProv AS 'CODIGO', nombre AS NOMBRE, telefono AS TELEFONO, correo as CORREO, direccion as DIRECCION FROM proveedores"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        ds.Tables.Add("proveedores")
        adp.Fill(ds.Tables("proveedores"))
        Me.dgvProveedores.DataSource = ds.Tables("proveedores")
    End Sub

    Private Sub deleteProveedores()
        Dim wcp As Integer = Convert.ToInt32(Me.dgvProveedores.CurrentRow.Cells(0).Value)
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "DELETE FROM proveedores WHERE idProv = @idProv"

        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@idProv", wcp)

        Try
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If
            cmd.ExecuteNonQuery()
            Console.Beep()
            llenarProveedores()
            Me.txtCodigo.Clear()
            Me.txtNombre.Clear()
            Me.txtTelefono.Clear()
            Me.txtCorreo.Clear()
            Me.txtDireccion.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
        End Try
    End Sub

    Private Sub actualizarProveedores()
        Dim wcp As Integer = Convert.ToInt32(Me.dgvProveedores.CurrentRow.Cells(0).Value)

        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "UPDATE proveedores SET nombre = @nombre, telefono = @telefono, correo = @correo, direccion = @direccion WHERE idProv = @idProv"

        cmd.CommandText = sql
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@nombre", Me.txtNombre.Text)
        cmd.Parameters.AddWithValue("@telefono", Convert.ToInt32(Me.txtTelefono.Text))
        cmd.Parameters.AddWithValue("@correo", Me.txtCorreo.Text)
        cmd.Parameters.AddWithValue("@direccion", Me.txtDireccion.Text)
        cmd.Parameters.AddWithValue("@idProv", wcp)

        If Me.txtNombre.Text <> "" AndAlso Me.txtTelefono.Text <> "" AndAlso Me.txtCorreo.Text <> "" AndAlso Me.txtDireccion.Text <> "" Then
            Try
                If cmd.Connection.State = ConnectionState.Closed Then
                    cmd.Connection.Open()
                End If
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarProveedores()
                Me.txtCodigo.Clear()
                Me.txtNombre.Clear()
                Me.txtTelefono.Clear()
                Me.txtCorreo.Clear()
                Me.txtDireccion.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                If cmd.Connection.State = ConnectionState.Open Then
                    cmd.Connection.Close()
                End If
            End Try
        Else
            MsgBox("Complete todos los campos.", MsgBoxStyle.Critical, "Error")
            Me.txtNombre.Focus()
        End If
    End Sub


    Private Sub dgvProoveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedores.CellClick
        If e.RowIndex >= 0 Then
            txtCodigo.Text = dgvProveedores.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNombre.Text = dgvProveedores.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtTelefono.Text = dgvProveedores.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtCorreo.Text = dgvProveedores.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtDireccion.Text = dgvProveedores.Rows(e.RowIndex).Cells(4).Value.ToString()
        End If
    End Sub

    'Private Sub dgvProveedores_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProveedores.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If dgvProveedores.CurrentRow IsNot Nothing AndAlso dgvProveedores.CurrentRow.Index >= 0 Then
    '            txtCodigo.Text = dgvProveedores.CurrentRow.Cells(0).Value.ToString()
    '            txtNombre.Text = dgvProveedores.CurrentRow.Cells(1).Value.ToString()
    '            txtTelefono.Text = dgvProveedores.CurrentRow.Cells(2).Value.ToString()
    '            txtCorreo.Text = dgvProveedores.CurrentRow.Cells(3).Value.ToString()
    '            txtDireccion.Text = dgvProveedores.CurrentRow.Cells(4).Value.ToString()
    '        End If
    '        e.Handled = True
    '    End If

    'End Sub

    Private Sub dgvProveedores_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProveedores.SelectionChanged
        If dgvProveedores.CurrentRow IsNot Nothing AndAlso dgvProveedores.CurrentRow.Index >= 0 Then
            txtCodigo.Text = dgvProveedores.CurrentRow.Cells(0).Value.ToString()
            txtNombre.Text = dgvProveedores.CurrentRow.Cells(1).Value.ToString()
            txtTelefono.Text = dgvProveedores.CurrentRow.Cells(2).Value.ToString()
            txtCorreo.Text = dgvProveedores.CurrentRow.Cells(3).Value.ToString()
            txtDireccion.Text = dgvProveedores.CurrentRow.Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        actualizarProveedores()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        deleteProveedores()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim filtro As String = ""
        filtro = $"NOMBRE LIKE '%{txtBuscar.Text.Trim()}%'"
        CType(dgvProveedores.DataSource, DataTable).DefaultView.RowFilter = filtro
    End Sub

End Class
