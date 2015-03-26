Imports dtlFacturacion
Public Class brlSucursalesCajas
    Public Shared Function obtenerLista(ByVal cadena As String, idSucursal As Integer) As DataSet
        Try

            obtenerLista = dtlSucursalesCajas.obtenerLista(cadena, idSucursal)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
