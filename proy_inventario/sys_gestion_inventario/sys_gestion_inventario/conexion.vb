Module conexion
    Public cmd As New SqlClient.SqlCommand
    Public dr As SqlClient.SqlDataReader
    Public conexion As New SqlClient.SqlConnection("Data Source=DESKTOP-4DU3JSJ\SQLEXPRESS;Initial Catalog=sys_inventario;Integrated Security=false;user id=sa;password=12345")

    Public Sub conectar() 'FUNCION PARA ABRIR LA CONEXION
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            cmd.Connection = conexion
        Catch ex As Exception
            MsgBox("Error al conectar con el servidor.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub cerrar() 'FUNCION PARA CERRAR LA CONEXION
        Try
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al cerrar la conexión con el servidor.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Function getConexion() As SqlClient.SqlConnection
        Return conexion
    End Function
End Module





