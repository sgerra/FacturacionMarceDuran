Imports wflFacturacion
Public Class pwiBonificaciones
    Public Shared Function wflPagosProveedores_Bonificaciones_obtenerLista(ByVal cadena As String, NroPago As Integer) As DataSet
        Try
            wflPagosProveedores_Bonificaciones_obtenerLista = wflPagosProveedores.Bonificaciones_obtenerLista(cadena, NroPago)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
