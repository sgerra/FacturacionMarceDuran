Imports wflFacturacion
Public Class pwiDepositos

    Public Shared Function wflPagosProveedores_obtenerDepositos(ByVal cadena As String) As DataSet
        Try
            wflPagosProveedores_obtenerDepositos = wflPagosProveedores.depositos_obtenerLista(cadena, 1)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflPagosProveedores_Depositos_obtenerPorNroPago(ByVal cadena As String, NroPago As Integer, tpoMoneda As Integer) As DataSet
        Try
            wflPagosProveedores_Depositos_obtenerPorNroPago = wflPagosProveedores.Depositos_obtenerListaPorNroPago(cadena, NroPago, tpoMoneda)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
