Imports System.Data.SqlClient

Public Class frmCerrarCaja
    Private Sub frmCerrarCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarComboBoxEmpleadoA()
        cbEmpleadoA.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub llenarComboBoxEmpleadoA()
        Dim sql As String = "SELECT idEmpleado, CONCAT(nombre, ' ', apellido) AS NombreCompleto FROM empleados"
        Dim ds As New DataSet
        Dim adp As New SqlClient.SqlDataAdapter(sql, conexion.conexion)

        Try
            ds.Tables.Add("empleados")
            adp.Fill(ds.Tables("empleados"))

            Me.cbEmpleadoA.DataSource = ds.Tables("empleados")
            Me.cbEmpleadoA.DisplayMember = "NombreCompleto" ' El nombre del alias de la columna concatenada
            Me.cbEmpleadoA.ValueMember = "idEmpleado" ' El idEmpleado que se usará para guardar
        Catch ex As Exception
            MsgBox("Error al llenar el ComboBox: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub




    Private Sub GuardarAperturaDeCaja(dgvMetodos As DataGridView)
        Dim fecha As Date = DateTime.Now

        ' Obtener el idEmpleado seleccionado en el ComboBox
        Dim idEmpleado As Integer = CType(cbEmpleadoA.SelectedItem, DataRowView)("idEmpleado")

        Try
            conexion.conectar() ' Abrir la conexión utilizando el método del módulo

            Using transaction As SqlTransaction = conexion.getConexion().BeginTransaction()
                Try
                    ' Insertar en abrirCaja
                    Dim queryAbrirCaja As String = "INSERT INTO cerrarCaja (idCaja, idMetodo, monto, fecha, idEmpleado) VALUES (@idCaja, @idMetodo, @monto, @fecha, @idEmpleado)"
                    Dim cmdAbrirCaja As New SqlCommand(queryAbrirCaja, conexion.getConexion(), transaction)

                    Dim idCaja As Integer = ObtenerIdCajaNuevo() ' Asume una función para obtener un nuevo idCaja

                    For Each row As DataGridViewRow In dgvMetodos.Rows
                        If Not row.IsNewRow Then
                            Dim idMetodo As Integer = Convert.ToInt32(row.Cells("idMetodo").Value)
                            Dim monto As Decimal = Convert.ToDecimal(row.Cells("monto").Value)

                            cmdAbrirCaja.Parameters.Clear()
                            cmdAbrirCaja.Parameters.AddWithValue("@idCaja", idCaja)
                            cmdAbrirCaja.Parameters.AddWithValue("@idMetodo", idMetodo)
                            cmdAbrirCaja.Parameters.AddWithValue("@monto", monto)
                            cmdAbrirCaja.Parameters.AddWithValue("@fecha", fecha)
                            cmdAbrirCaja.Parameters.AddWithValue("@idEmpleado", idEmpleado) ' Guardar idEmpleado
                            cmdAbrirCaja.ExecuteNonQuery()
                        End If
                    Next

                    transaction.Commit()
                    MessageBox.Show("Cierre de caja guardada correctamente.")
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("Error al guardar el cierre de caja: " & ex.Message)
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message)
        Finally
            'conexion.cerrar() ' Cerrar la conexión utilizando el método del módulo
        End Try
    End Sub



    Private Function ObtenerIdCajaNuevo() As Integer

        Dim idCaja As Integer
        Dim connectionString As String = "Data Source=DESKTOP-4DU3JSJ\SQLEXPRESS;Initial Catalog=sys_inventario;Integrated Security=False;User ID=sa;Password=12345"
        Dim sql As String = "SELECT ISNULL(MAX(idCaja), 0) + 1 FROM cerrarCaja"
        Using connection As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(sql, connection)
                connection.Open()
                idCaja = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
        Return idCaja
    End Function




    Private Sub btnRegistrarA_Click(sender As Object, e As EventArgs) Handles btnRegistrarA.Click
        caja = 2
        Dim frm As New frmMetodos()

        ' Establecer el formulario hijo como un formulario hijo del formulario principal
        'frm.MdiParent = Me

        ' Establecer el tamaño fijo del formulario hijo
        frm.Size = New Size(700, 500) ' Tamaño fijo, por ejemplo, 400x300 píxeles

        ' Posicionar el formulario hijo en la esquina superior izquierda, justo debajo del MenuStrip
        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(-7, 56)


        If frm.ShowDialog() = DialogResult.OK Then
            ' Aquí se obtiene el monto total desde frmMetodos y se guarda en la base de datos
            GuardarAperturaDeCaja(frm.dgvMetodos)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class