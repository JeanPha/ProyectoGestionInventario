Public Class frmNuevoProveedor
    Private Sub frmNuevoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.txtNombre.Focus()

        Me.MaximizeBox = False ' Desactiva el botón de maximizar
        Me.MinimizeBox = False ' Desactiva el botón de minimizar
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Desactiva la capacidad de redimensionar verticalmente

        ' Asignar el evento KeyPress al TextBox txtCantidad
        AddHandler txtTelefono.KeyPress, AddressOf funciones.SoloNumerosEnteros
    End Sub

    Private Sub Agregar()
        If Me.txtCodigo.Text <> "" AndAlso Me.txtNombre.Text <> "" AndAlso Me.txtTelefono.Text <> "" AndAlso Me.txtCorreo.Text <> "" AndAlso Me.txtDireccion.Text <> "" Then
            cmd.Connection = conexion.conexion
            cmd.CommandType = CommandType.Text
            Dim sql As String = "INSERT INTO proveedores (idProv, nombre, telefono, correo, direccion) VALUES (@idProv, @nombre, @telefono, @correo, @direccion)"
            cmd.CommandText = sql
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@idProv", Me.txtCodigo.Text)
            cmd.Parameters.AddWithValue("@nombre", Me.txtNombre.Text)
            cmd.Parameters.AddWithValue("@telefono", Convert.ToInt32(Me.txtTelefono.Text))
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
                Me.txtTelefono.Clear()
                Me.txtCorreo.Clear()
                Me.txtDireccion.Clear()

                ' Configurar el color de fondo de los TextBox verde
                txtCodigo.BackColor = Color.PaleGreen
                txtNombre.BackColor = Color.PaleGreen
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
            txtTelefono.BackColor = Color.LightSalmon
            txtCorreo.BackColor = Color.LightSalmon
            txtDireccion.BackColor = Color.LightSalmon
        End If
    End Sub

    Private Sub generarId()
        Dim wid_juicio As Integer ' Asegúrate de que esta variable esté definida
        cmd.Connection = conexion.conexion
        cmd.CommandType = CommandType.Text
        Dim sql As String = "SELECT MAX(idProv) FROM proveedores"
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        generarId()
    End Sub
End Class