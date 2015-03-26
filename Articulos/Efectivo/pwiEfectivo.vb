Imports wflFacturacion
Public Class pwiEfectivo
    Public Shared Function wflPagosProveedores_obtenerEfectivo(ByVal cadena As String) As DataSet
        Try
            wflPagosProveedores_obtenerEfectivo = wflPagosProveedores.Efectivo_obtenerLista(cadena, 1)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflPagosProveedores_obtenerMonedas(ByVal cadena As String) As DataSet
        Try
            wflPagosProveedores_obtenerMonedas = wflPagosProveedores.Monedas_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflPagosProveedores_Efectivo_obtenerPorNroPago(ByVal cadena As String, NroPago As Integer, tpoMoneda As Integer) As DataSet
        Try
            wflPagosProveedores_Efectivo_obtenerPorNroPago = wflPagosProveedores.Efectivo_obtenerListaPorNroPago(cadena, NroPago, tpoMoneda)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
