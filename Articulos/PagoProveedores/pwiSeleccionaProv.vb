Imports wflFacturacion

Public Class pwiSeleccionaProv
    Public Shared Function Pagoproveedores_Proveedores_obtenerLista(ByVal cadena As String) As DataSet
        Try
            Pagoproveedores_Proveedores_obtenerLista = wflPagosProveedores.Proveedores_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
  
End Class
