Imports wflFacturacion
Public Class pwiaumentaprecioporproveedor

    Public Shared Function AumentaPrecio_Proveedores_obtenerLista(ByVal cadena As String) As DataSet
        Try
            AumentaPrecio_Proveedores_obtenerLista = wflAumentaPrecios.Proveedores_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function AumentaPrecio_Articulos_obtenerArticulosPorProveedor(ByVal cadena As String, idProveedor As Integer) As DataSet
        Try
            AumentaPrecio_Articulos_obtenerArticulosPorProveedor = wflAumentaPrecios.Articulos_obtenerArticulosPorProveedor(cadena, idproveedor)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Sub AumentaPrecio_actualizarPrecios(ByVal cadena As String, dstPrecios As DataSet)
        Try
            wflAumentaPrecios.actualizarPrecios(cadena, dstPrecios)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Sub
End Class
