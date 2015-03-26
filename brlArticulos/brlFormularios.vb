Imports dtlFacturacion
Public Class brlFormularios
    Public Shared Function obtenerRegistro(ByVal cadena As String, strNombreFormu As String) As DataSet
        Try

            obtenerRegistro = dtlFormularios.obtenerRegistro(cadena, strnombreformu)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
