Imports brlFacturacion
Public Class wflAumentaPrecios
    Public Shared Function Proveedores_obtenerLista(ByVal cadena As String) As DataSet
        Try
            Proveedores_obtenerLista = brlProveedores.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Articulos_obtenerArticulosPorProveedor(ByVal cadena As String, idproveedor As Integer) As DataSet
        Try
            Dim myTable As New DataTable
            Dim myauxDt As DataSet
            Dim myauxDaset As New DataSet
            myauxDt = brlArticulos.obtenerDetalle(cadena)
            myauxDt.Tables(0).DefaultView.RowFilter = "idproveedor=" & idproveedor
            Dim dv As DataView = myauxDt.Tables(0).DefaultView
            myTable = dv.ToTable
            myauxDaset.Tables.Add(myTable)
            Articulos_obtenerArticulosPorProveedor = myauxDaset

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Sub actualizarPrecios(ByVal cadena As String, dstPrecios As DataSet)
        Try

            For Each dr As DataRow In dstPrecios.Tables(0).Rows

                brlListasPreciosDet.actualizarPrecios(cadena, dr("codart"), dr("costo"))

            Next

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Sub


End Class
