Imports brlFacturacion
Public Class wflPrepararNovedades
    Public Shared Function wflPrepararNovedades_obtenerListaPrecios(ByVal cadena As String, lngidlista As Integer) As DataSet
        Try
            wflPrepararNovedades_obtenerListaPrecios = brlListasPreciosDet.obtenerListaNovedades(cadena, lngidlista)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

End Class
