Imports brlFacturacion
Public Class wflFormasPago
    Public Shared Function wflFormasPago_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflFormasPago_obtenerLista = brlTFormasPago.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
