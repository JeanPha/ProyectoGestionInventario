Module ConsultaSqlIngresos
    Public sumaIngresos As Decimal = 0.0
    Public sumaCaja As Decimal = 0.0
    Public totalSumaIngresos As Decimal = 0.0

    Public sumaGastos As Decimal = 0.0
    Public diferencia As Decimal = 0.0

    Public Sub ActualizarSumaIngresos()
        If usuario = "jean" Then
            Try
                conexion.conectar() ' Abre la conexión

                ' Ejecutar el procedimiento almacenado
                Dim cmd As New SqlClient.SqlCommand("sp_calcularSumaIngresos", conexion.getConexion())
                cmd.CommandType = CommandType.StoredProcedure

                ' Ejecutar el procedimiento y obtener los resultados
                Using reader As SqlClient.SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Asignar los valores a las variables
                        If Not IsDBNull(reader("sumaIngresos")) Then
                            sumaIngresos = Convert.ToDecimal(reader("sumaIngresos"))
                        Else
                            sumaIngresos = 0.0
                        End If

                        If Not IsDBNull(reader("sumaCaja")) Then
                            sumaCaja = Convert.ToDecimal(reader("sumaCaja"))
                        Else
                            sumaCaja = 0.0
                        End If

                        If Not IsDBNull(reader("totalSumaIngresos")) Then
                            totalSumaIngresos = Convert.ToDecimal(reader("totalSumaIngresos"))
                        Else
                            totalSumaIngresos = 0.0
                        End If
                    End If
                End Using

            Catch ex As Exception
                MsgBox("Error al obtener los datos: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Finally
                conexion.cerrar() ' Cierra la conexión
            End Try
        Else
            sumaIngresos = 0.0
            sumaCaja = 0.0
            totalSumaIngresos = 0.0
        End If
    End Sub


    Public Sub ActualizarSumaGastos()
        If usuario = "jean" Then
            Try
                conexion.conectar() ' Abre la conexión
                Dim query As String = "SELECT SUM(montoGastos) FROM gastos"
                Using cmd As New SqlClient.SqlCommand(query, conexion.getConexion())
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        sumaGastos = Convert.ToDecimal(result)
                    Else
                        sumaGastos = 0.0 ' Si no hay gastos, establece el valor en cero
                    End If
                End Using
                'conexion.cerrar() ' Cierra la conexión
            Catch ex As Exception
                MsgBox("Error al obtener la suma de gastos: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            sumaGastos = 0.0
        End If
    End Sub

    Public Sub ActualizarDiferencia()
        If usuario = "jean" Then
            Try
                conexion.conectar() ' Abre la conexión
                Dim query As String = "SELECT (SELECT SUM(montoIngresos) FROM ingresos) - (SELECT SUM(montoGastos) FROM gastos) AS Diferencia"
                Using cmd As New SqlClient.SqlCommand(query, conexion.getConexion())
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        diferencia = Convert.ToDecimal(result)
                    Else
                        diferencia = sumaIngresos
                    End If
                End Using
                'conexion.cerrar() ' Cierra la conexión
            Catch ex As Exception
                MsgBox("Error al obtener la diferencia: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            diferencia = 0.0
        End If
    End Sub
End Module
