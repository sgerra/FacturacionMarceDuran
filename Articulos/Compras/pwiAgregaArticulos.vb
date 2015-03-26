Imports wflFacturacion
Public Class pwiAgregaArticulos

    Public Shared Function wflCompras_obtenerDepositos(ByVal cadena As String) As DataSet
        Try
            wflCompras_obtenerDepositos = wflCompras.Compras_obtenerDepositos(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflCompras_obtenerArticulosPorProveedor(ByVal cadena As String, idProveedor As Integer) As DataSet
        Try
            wflCompras_obtenerArticulosPorProveedor = wflCompras.Compras_obtenerArticulosPorProveedor(cadena, idProveedor)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
