Imports wflFacturacion
Public Class pwiCheques
    Public Shared Function wflPagosProveedores_Cheques_obtenerPorNroPago(ByVal cadena As String, NroPago As Integer) As DataSet
        Try
            wflPagosProveedores_Cheques_obtenerPorNroPago = wflPagosProveedores.Cheques_obtenerListaPorNroPago(cadena, NroPago)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflPagosProveedores_BancosVigentes(ByVal cadena As String) As DataSet
        Try
            wflPagosProveedores_BancosVigentes = wflPagosProveedores.Bancos_obtenerBancosVigentes(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function


End Class
