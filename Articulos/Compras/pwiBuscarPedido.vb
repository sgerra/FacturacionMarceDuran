Imports wflFacturacion

Public Class pwiBuscarPedido

    Public Shared Function wflCompras_obtenerLista(ByVal cadena As String) As DataView
        Try
            wflCompras_obtenerLista = wflCompras.Compras_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
