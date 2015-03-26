Imports wflFacturacion
Public Class pwiArmarNoveedades
    Public Shared Function Articulos_ArmarNovedades(ByVal cadena As String) As DataSet
        Try
            Articulos_ArmarNovedades = wflarticulos.wflArticulos_armarNovedades(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Usuarios_ArmarNovedades(ByVal cadena As String, idSucursal As Integer) As DataSet
        Try
            Usuarios_ArmarNovedades = wflUsuarios.wflUsuarios_obtenerListaUsuarios(cadena, idsucursal)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function Clientes_ArmarNovedades(ByVal cadena As String) As DataSet
        Try
            Clientes_ArmarNovedades = wflClientes.wflClientes_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function FormasPago_ArmarNovedades(ByVal cadena As String) As DataSet
        Try
            FormasPago_ArmarNovedades = wflFormasPago.wflFormasPago_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflPrepararNovedades_obtenerListaPrecios(ByVal cadena As String, lngidLista As Integer) As DataSet
        Try
            wflPrepararNovedades_obtenerListaPrecios = wflPrepararNovedades.wflPrepararNovedades_obtenerListaPrecios(cadena, lngidlista)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
