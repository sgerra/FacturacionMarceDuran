Imports wflFacturacion
Public Class pwiAgregaOC
    Public Shared Function wflPagosProveedores_OtrosConceptos_obtenerRegistro(ByVal cadena As String, lngidOc As Integer) As DataSet
        Try
            wflPagosProveedores_OtrosConceptos_obtenerRegistro = wflPagosProveedores.OtrosConceptos_obtenerRegistro(cadena, lngidOc)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
