Imports brlFacturacion
Public Class wflobtenerNovedades

    Public Shared Function wflobtenerNovedades_obtenerSucursalesCajas(ByVal cadena As String, idSucursal As Integer) As DataSet
        Try

            wflobtenerNovedades_obtenerSucursalesCajas = brlSucursalesCajas.obtenerLista(cadena, idSucursal)
        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Armar Novedades" + "|" + ex.Message)
        End Try

    End Function

    Public Shared Function wflUsuarios_obtenerListaUsuarios(ByVal cadena As String, idsucursal As Integer) As DataSet
        Try
            wflUsuarios_obtenerListaUsuarios = brlUsuarios.obtenerListaUsuarios(cadena, idsucursal)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

End Class
