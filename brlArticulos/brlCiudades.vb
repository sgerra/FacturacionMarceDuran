Imports dtlFacturacion
Public Class brlCiudades
    Public Shared Function obtenerLista(ByVal cadena As String, lngIdProvincia As Integer) As DataSet
        Try

            obtenerLista = dtlCiudades.obtenerLista(cadena, lngIdProvincia)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
