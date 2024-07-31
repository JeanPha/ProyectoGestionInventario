Module funciones
    Public Sub SoloNumerosEnteros(sender As Object, e As KeyPressEventArgs)
        ' Permitir solo dígitos y teclas de control (como la tecla de retroceso)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Public Sub SoloNumerosDecimales(sender As Object, e As KeyPressEventArgs)
        Dim textBox As TextBox = CType(sender, TextBox)
        Dim text As String = textBox.Text

        ' Permitir solo dígitos, teclas de control, coma, punto y barra invertida
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse e.KeyChar = ","c OrElse e.KeyChar = "."c Then
            ' Si se presiona un punto, reemplazarlo por coma
            If e.KeyChar = "."c Then
                e.KeyChar = ","c
            End If

            ' Permitir solo una coma
            If (e.KeyChar = ","c AndAlso text.Contains(",")) Then
                e.Handled = True
            End If
        Else
            e.Handled = True
        End If
    End Sub
End Module

