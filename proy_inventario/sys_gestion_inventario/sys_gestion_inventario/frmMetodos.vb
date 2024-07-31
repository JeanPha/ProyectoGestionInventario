Imports System.Data.SqlClient

Public Class frmMetodos
    Private Sub frmMetodos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If caja = 1 Then
            Me.lbAbrir.Visible = True
            Me.lbCerrar.Visible = False
        ElseIf caja = 2 Then
            Me.lbAbrir.Visible = False
            Me.lbCerrar.Visible = True
        End If




        dgvMetodos.ReadOnly = True


        ' Inicializa las columnas
        dgvMetodos.Columns.Add("idMetodo", "ID Método")
        dgvMetodos.Columns.Add("nombre", "Método de Pago")
        dgvMetodos.Columns.Add("monto", "Monto")

        ' Establece los títulos de las columnas en negrita
        For Each column As DataGridViewColumn In dgvMetodos.Columns
            column.HeaderCell.Style.Font = New Font("Arial", 10, FontStyle.Bold)
        Next

        ' Opcional: Ajusta el ancho de las columnas para que se ajusten al contenido
        dgvMetodos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        AddHandler txtMontoMetodo.KeyPress, AddressOf funciones.SoloNumerosDecimales


        ' Cargar métodos de pago desde la base de datos
        CargarMetodosDePago()
    End Sub

    Private Sub CargarMetodosDePago()
        Dim sql As String = "SELECT idMetodo, nombre FROM Metodos"

        Try
            conexion.conectar() ' Abrir la conexión utilizando el método del módulo

            Using cmd As New SqlCommand(sql, conexion.getConexion())
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim idMetodo As Integer = reader.GetInt32(0)
                        Dim nombre As String = reader.GetString(1)
                        cboMetodos.Items.Add(New MetodoPago With {.idMetodo = idMetodo, .nombre = nombre})
                    End While
                End Using
            End Using

            cboMetodos.DisplayMember = "nombre"
            cboMetodos.ValueMember = "idMetodo"
        Catch ex As Exception
            MessageBox.Show("Error al cargar los métodos de pago: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.cerrar() ' Cerrar la conexión utilizando el método del módulo
        End Try
    End Sub


    Private Sub btnAgregarMetodo_Click(sender As Object, e As EventArgs) Handles btnAgregarMetodo.Click
        If Me.cboMetodos.Text = "" Or Me.txtMontoMetodo.Text = "" Then
            MsgBox("Complete todos los Campos")
        Else

            Dim metodoPago As MetodoPago = CType(cboMetodos.SelectedItem, MetodoPago)
            Dim idMetodo As Integer = metodoPago.idMetodo
            Dim nombre As String = metodoPago.nombre
            Dim monto As Decimal = Convert.ToDecimal(txtMontoMetodo.Text)

            dgvMetodos.Rows.Add(idMetodo, nombre, monto)
            Me.cboMetodos.Text = ""
            Me.txtMontoMetodo.Text = ""
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Lógica para guardar los datos en la base de datos
        Me.DialogResult = DialogResult.OK
        caja = 0
        Me.Close()

    End Sub
End Class