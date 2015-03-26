Imports wflFacturacion
Public Class pwiStock

    Public Shared Function Depositos_obtenerLista(ByVal cadena As String) As DataSet
        Try
            Depositos_obtenerLista = wflarticulos.wflarticulos_Depositos_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
