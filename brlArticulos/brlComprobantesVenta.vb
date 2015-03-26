Imports dtlFacturacion
Public Class brlComprobantesVenta
    Public Shared Function obtenerRegistro(ByVal cadena As String, lngNroCom As Integer) As DataSet
        Try

            obtenerRegistro = dtlComprobantesVenta.obtenerRegistro(cadena, lngNroCom)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function insertarRegistro(ByVal cadena As String, ByVal dsComprobantesVenta As DataSet) As Integer
        Try

            insertarRegistro = dtlComprobantesVenta.insertarRegistro(cadena, dsComprobantesVenta)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
