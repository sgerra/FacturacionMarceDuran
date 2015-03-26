Imports wflFacturacion
Public Class pwiFacturacionLibre
    Public Shared Function wflFacturacionLibre_Clientes_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflFacturacionLibre_Clientes_obtenerLista = wflClientes.wflClientes_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflFacturacionLibre_Clientes_obtenerDetalle(ByVal cadena As String, idCliente As Integer) As DataSet
        Try
            wflFacturacionLibre_Clientes_obtenerDetalle = wflFacturacionLibre.Clientes_obtenerDetalle(cadena, idCliente)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflFacturacionLibre_tCondicionesVenta_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflFacturacionLibre_tCondicionesVenta_obtenerLista = wflFacturacionLibre.tCondicionesVenta_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflFacturacionLibre_TposEstadoFactura_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflFacturacionLibre_TposEstadoFactura_obtenerLista = wflFacturacionLibre.TposEstadosFactura_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflEmisionFactura_GuardarComprobante(ByVal cadena As String, dscomprobante As DataSet, dsdeta As DataSet, iddeposito As Integer, ByRef lngIdFactura As Integer) As Boolean
        Try
            wflEmisionFactura_GuardarComprobante = wflFacturacionLibre.wflFacturacionLibre_GuardarComprobante(cadena, dscomprobante, dsdeta, iddeposito, lngIdFactura)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
