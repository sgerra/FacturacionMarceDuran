Imports wflFacturacion
Public Class pwiobtenerNovedades
    Public Shared Function SucursalesCajas_obtenerLista(ByVal cadena As String, idSucursal As Integer) As DataSet
        Try
            SucursalesCajas_obtenerLista = wflobtenerNovedades.wflobtenerNovedades_obtenerSucursalesCajas(cadena, idSucursal)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function SucursalesCajas_obtenerUsuarios(ByVal cadena As String, idSucursal As Integer) As DataSet
        Try
            SucursalesCajas_obtenerUsuarios = wflobtenerNovedades.wflUsuarios_obtenerListaUsuarios(cadena, idSucursal)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function


End Class
