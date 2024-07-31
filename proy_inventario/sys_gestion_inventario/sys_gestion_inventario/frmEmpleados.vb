Imports System.Data.SqlClient

Public Class frmEmpleados
    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generarId()

        llenarEmpleados()
        Me.txtBuscarEmpleado.Clear()
        Me.dgvEmpleados.Focus()

        Me.txtNombre.Focus()

        Me.MaximizeBox = False ' Desactiva el botón de maximizar
        Me.MinimizeBox = False ' Desactiva el botón de minimizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Desactiva la capacidad de redimensionar verticalmente

        ' Asignar el evento KeyPress al TextBox txtCantidad
        AddHandler txtDni.KeyPress, AddressOf funciones.SoloNumerosEnteros
        AddHandler txtTelefono.KeyPress, AddressOf funciones.SoloNumerosEnteros
    End Sub

    Private Sub Agregar()
        If Me.txtCodigo.Text <> "" AndAlso Me.txtNombre.Text <> "" AndAlso Me.txtApellido.Text <> "" AndAlso txtDni.Text <> "" AndAlso txtTelefono.Text <> "" AndAlso txtCorreo.Text <> "" AndAlso txtDireccion.Text <> "" Then
            cmd.Connection = conexion.conexion
            cmd.CommandType = CommandType.Text
            Dim sql As String = "INSERT INTO empleados (idEmpleado, nombre, apellido, dni, telefono, correo, direccion) VALUES (@idEmpleado, @nombre, @apellido, @dni, @telefono, @correo, @direccion)"
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@idEmpleado", Me.txtCodigo.Text)
            cmd.Parameters.AddWithValue("@nombre", Me.txtNombre.Text)
            cmd.Parameters.AddWithValue("@apellido", Me.txtApellido.Text)
            cmd.Parameters.AddWithValue("@dni", Me.txtDni.Text)
            cmd.Parameters.AddWithValue("@telefono", Me.txtTelefono.Text)
            cmd.Parameters.AddWithValue("@correo", Me.txtCorreo.Text)
            cmd.Parameters.AddWithValue("@direccion", Me.txtDireccion.Text)

            Try
                If cmd.Connection.State = ConnectionState.Closed Then
                    cmd.Connection.Open()
                End If
                cmd.ExecuteNonQuery()
                Console.Beep()
                'llenarProductos()
                Me.txtCodigo.Clear()
                Me.txtNombre.Clear()
                Me.txtApellido.Clear()
                Me.txtDni.Clear()
                Me.txtTelefono.Clear()
                Me.txtCorreo.Clear()
                Me.txtDireccion.Clear()

                ' Configurar el color de fondo de los TextBox verde
                txtCodigo.BackColor = Color.PaleGreen
                txtNombre.BackColor = Color.PaleGreen
                txtApellido.BackColor = Color.PaleGreen
                txtDni.BackColor = Color.PaleGreen
                txtTelefono.BackColor = Color.PaleGreen
                txtCorreo.BackColor = Color.PaleGreen
                txtDireccion.BackColor = Color.PaleGreen
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
            txtNombre.BackColor = Color.LightSalmon
            txtApellido.BackColor = Color.LightSalmon
            txtDni.BackColor = Color.LightSalmon
            txtTelefono.BackColor = Color.LightSalmon
            txtCorreo.BackColor = Color.LightSalmon
            txtDireccion.BackColor = Color.LightSalmon
        End If
    End Sub


    Private Sub generarId()
        Dim wid_juicio As Integer ' Asegúrate de que esta variable esté definida
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "SELECT MAX(idEmpleado) FROM empleados"
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
        Me.txtNombre.Focus()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Agregar()
    End Sub

    'GESTIONAR EMPLEADOS

    Private Sub dgvEmpleados_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvEmpleados.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Evita el comportamiento predeterminado de la tecla Enter
            e.Handled = True

            ' Verifica si hay una fila seleccionada
            If dgvEmpleados.SelectedRows.Count > 0 Then
                Try
                    ' Captura los valores de las celdas
                    Dim IdEmpleadoSeleccionado As String = dgvEmpleados.SelectedRows(0).Cells("CODIGO").Value.ToString()
                    Dim NombreEmpleadoSeleccionado As String = dgvEmpleados.SelectedRows(0).Cells("NOMBRE").Value.ToString()
                    Dim ApellidoEmpleadoSeleccionado As String = dgvEmpleados.SelectedRows(0).Cells("APELLIDO").Value.ToString()
                    Dim DniEmpleadoSeleccionado As String = dgvEmpleados.SelectedRows(0).Cells("DNI").Value.ToString()
                    Dim TelefonoEmpleadoSeleccionado As String = dgvEmpleados.SelectedRows(0).Cells("TELEFONO").Value.ToString()
                    Dim CorreoEmpleadoSeleccionado As String = dgvEmpleados.SelectedRows(0).Cells("CORREO").Value.ToString()
                    Dim DireccionEmpleadoSeleccionado As String = dgvEmpleados.SelectedRows(0).Cells("DIRECCION").Value.ToString()

                    ' Opcional: Puedes asignar estos valores a variables de clase o a controles de otro formulario
                    ' Ejemplo:
                    ' Me.txtIdEmpleado.Text = IdEmpleadoSeleccionado
                    ' Me.txtNombreEmpleado.Text = NombreEmpleadoSeleccionado

                    ' Cierra el formulario actual
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Error al obtener los valores de las celdas seleccionadas: " & ex.Message, MsgBoxStyle.Exclamation)
                End Try
            Else
                MsgBox("No hay ninguna fila seleccionada.", MsgBoxStyle.Information)
            End If
        End If
    End Sub


    Private Sub llenarEmpleados()
        Try
            Me.txtBuscarEmpleado.Clear()

            ' Definir la consulta SQL
            Dim sql As String = "SELECT idEmpleado AS 'CODIGO', nombre AS NOMBRE, apellido as APELLIDO, dni as DNI, telefono as TELEFONO, correo as CORREO, direccion as DIRECCION FROM empleados"

            ' Crear un nuevo DataSet
            Dim ds As New DataSet

            ' Crear el adaptador de datos
            Using adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)
                ' Añadir la tabla "empleados" al DataSet
                ds.Tables.Add("empleados")

                ' Llenar la tabla "empleados" con los datos del adaptador
                adp.Fill(ds.Tables("empleados"))
            End Using

            ' Establecer la fuente de datos del DataGridView
            Me.dgvEmpleados.DataSource = ds.Tables("empleados")

            ' Configurar las propiedades del DataGridView (opcional)
            'Me.dgvEmpleados.AutoResizeColumns()
            'Me.dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Me.dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.dgvEmpleados.MultiSelect = False
            Me.dgvEmpleados.AllowUserToAddRows = False
        Catch ex As Exception
            MsgBox("Error al llenar los datos: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub deleteEmpleados()
        Try
            ' Verifica si hay una fila seleccionada
            If dgvEmpleados.CurrentRow Is Nothing Then
                MsgBox("No hay ningún empleado seleccionado.", MsgBoxStyle.Information, "Advertencia")
                Exit Sub
            End If

            ' Captura el ID del empleado seleccionado
            Dim idEmpleado As Integer = Convert.ToInt32(Me.dgvEmpleados.CurrentRow.Cells("CODIGO").Value)

            ' Configura el comando para eliminar el empleado
            cmd.Connection = conexion.conexion
            cmd.CommandType = CommandType.Text
            Dim sql As String = "DELETE FROM empleados WHERE idEmpleado = @id"
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", idEmpleado)

            ' Intenta abrir la conexión, ejecutar el comando y actualizar la lista de empleados
            Try
                If cmd.Connection.State = ConnectionState.Closed Then
                    cmd.Connection.Open()
                End If
                cmd.ExecuteNonQuery()
                Console.Beep()
                llenarEmpleados()
                limpiarG()
            Catch ex As Exception
                MsgBox("Error al eliminar el empleado: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                If cmd.Connection.State = ConnectionState.Open Then
                    cmd.Connection.Close()
                End If
            End Try
        Catch ex As Exception
            MsgBox("Error al obtener el empleado seleccionado: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub actualizarEmpleados()
        ' Obtener el ID del empleado seleccionado en el DataGridView
        If Me.txtCorreoG.Text = "" Then
            MsgBox("No hay ningun registro seleccionado.")
        Else
            Dim idEmpleado As Integer = Convert.ToInt32(Me.dgvEmpleados.CurrentRow.Cells(0).Value)

            ' Configurar la conexión y el comando SQL
            cmd.Connection = conexion.conexion
            cmd.CommandType = CommandType.Text
            Dim sql As String = "UPDATE empleados SET nombre = @nombre, apellido = @apellido, dni = @dni, telefono = @telefono, correo = @correo, direccion = @direccion WHERE idEmpleado = @idEmpleado"

            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nombre", Me.txtNombreG.Text)
            cmd.Parameters.AddWithValue("@apellido", Me.txtApellidoG.Text)
            cmd.Parameters.AddWithValue("@dni", Me.txtDniG.Text)
            cmd.Parameters.AddWithValue("@telefono", Me.txtTelefonoG.Text)
            cmd.Parameters.AddWithValue("@correo", Me.txtCorreoG.Text)
            cmd.Parameters.AddWithValue("@direccion", Me.txtDireccionG.Text)
            cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado)

            ' Verificar que todos los campos están completos
            If Me.txtNombreG.Text <> "" AndAlso Me.txtApellidoG.Text <> "" AndAlso Me.txtDniG.Text <> "" AndAlso Me.txtTelefonoG.Text <> "" AndAlso Me.txtCorreoG.Text <> "" AndAlso Me.txtDireccionG.Text <> "" Then
                Try
                    ' Abrir la conexión si está cerrada
                    If cmd.Connection.State = ConnectionState.Closed Then
                        cmd.Connection.Open()
                    End If
                    ' Ejecutar el comando SQL
                    cmd.ExecuteNonQuery()
                    ' Emitir un sonido de confirmación
                    Console.Beep()
                    ' Llamar a un método para llenar el DataGridView con los datos actualizados
                    llenarEmpleados()
                    ' Limpiar los campos de texto
                    Me.txtCodigoG.Clear()
                    Me.txtNombreG.Clear()
                    Me.txtApellidoG.Clear()
                    Me.txtDniG.Clear()
                    Me.txtTelefonoG.Clear()
                    Me.txtCorreoG.Clear()
                    Me.txtDireccionG.Clear()
                Catch ex As Exception
                    ' Mostrar mensaje de error
                    MsgBox(ex.ToString)
                Finally
                    ' Cerrar la conexión si está abierta
                    If cmd.Connection.State = ConnectionState.Open Then
                        cmd.Connection.Close()
                    End If
                End Try
            Else
                ' Mostrar mensaje si no todos los campos están completos
                MsgBox("Complete todos los campos.", MsgBoxStyle.Critical, "Error")
                Me.txtNombreG.Focus()
            End If
        End If
    End Sub

    Private Sub dgvEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellClick
        If e.RowIndex >= 0 Then
            ' Asegúrate de que estás accediendo a las celdas correctas en el DataGridView de empleados
            txtCodigoG.Text = dgvEmpleados.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNombreG.Text = dgvEmpleados.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtApellidoG.Text = dgvEmpleados.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtDniG.Text = dgvEmpleados.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtTelefonoG.Text = dgvEmpleados.Rows(e.RowIndex).Cells(4).Value.ToString()
            txtCorreoG.Text = dgvEmpleados.Rows(e.RowIndex).Cells(5).Value.ToString()
            txtDireccionG.Text = dgvEmpleados.Rows(e.RowIndex).Cells(6).Value.ToString()
        End If
    End Sub



    Private Sub dgvEmpleados_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEmpleados.SelectionChanged
        If dgvEmpleados.CurrentRow IsNot Nothing AndAlso dgvEmpleados.CurrentRow.Index >= 0 Then
            txtCodigoG.Text = dgvEmpleados.CurrentRow.Cells(0).Value.ToString()
            txtNombreG.Text = dgvEmpleados.CurrentRow.Cells(1).Value.ToString()
            txtApellidoG.Text = dgvEmpleados.CurrentRow.Cells(2).Value.ToString()
            txtDniG.Text = dgvEmpleados.CurrentRow.Cells(3).Value.ToString()
            txtTelefonoG.Text = dgvEmpleados.CurrentRow.Cells(4).Value.ToString()
            txtCorreoG.Text = dgvEmpleados.CurrentRow.Cells(5).Value.ToString()
            txtDireccionG.Text = dgvEmpleados.CurrentRow.Cells(6).Value.ToString()
        End If
    End Sub


    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        actualizarEmpleados()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        deleteEmpleados()
    End Sub

    Private Sub txtBuscarEmpleado_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEmpleado.TextChanged
        Dim filtro As String = ""
        filtro = $"NOMBRE LIKE '%{txtBuscarEmpleado.Text.Trim()}%'"
        CType(dgvEmpleados.DataSource, DataTable).DefaultView.RowFilter = filtro
    End Sub

    Private Sub limpiarG()
        Me.txtCodigoG.Clear()
        Me.txtNombreG.Clear()
        Me.txtApellidoG.Clear()
        Me.txtDniG.Clear()
        Me.txtTelefonoG.Clear()
        Me.txtCorreoG.Clear()
        Me.txtDireccionG.Clear()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        generarId()
    End Sub
End Class