Imports wflFacturacion
Public Class pwiOtrosConceptos

    Public Shared Function wflPagosProveedores_OtrosConceptos_obtenerLista(ByVal cadena As String, NroPago As Integer) As DataSet
        Try
            wflPagosProveedores_OtrosConceptos_obtenerLista = wflPagosProveedores.OtrosConceptos_obtenerLista(cadena, nropago)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

End Class
