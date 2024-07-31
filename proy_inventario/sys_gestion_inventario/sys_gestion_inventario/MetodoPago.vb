Public Class MetodoPago
    Public Property idMetodo As Integer
    Public Property nombre As String

    Public Overrides Function ToString() As String
        Return nombre
    End Function
End Class
