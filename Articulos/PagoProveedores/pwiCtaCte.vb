Imports wflFacturacion
Public Class pwiCtaCte

    Public Shared Function Pagoproveedores_obtenerLista(ByVal cadena As String, idProv As Integer) As DataSet
        Try
            Pagoproveedores_obtenerLista = wflPagosProveedores.PagosProveedores_obtenerLista(cadena, idProv)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function SaldosProve_obtenerRegistro(ByVal cadena As String, idProv As Integer) As DataSet
        Try
            SaldosProve_obtenerRegistro = wflPagosProveedores.SaldosProve_obtenerRegistro(cadena, idProv)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function PagosProveedoresDetalles_obtenerLista(ByVal cadena As String, idProv As Integer) As DataSet
        Try
            PagosProveedoresDetalles_obtenerLista = wflPagosProveedores.PagosProveedoresDetalles_obtenerLista(cadena, idProv)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Bonificaciones_obtenerLista(ByVal cadena As String, nroPago As Integer) As DataSet
        Try
            Bonificaciones_obtenerLista = wflPagosProveedores.Bonificaciones_obtenerLista(cadena, nroPago)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function OtrosConceptos_obtenerLista(ByVal cadena As String, nroPago As Integer) As DataSet
        Try
            OtrosConceptos_obtenerLista = wflPagosProveedores.OtrosConceptos_obtenerLista(cadena, nroPago)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflPagosProveedores_Compras_obtenerFacturasImpagas(ByVal cadena As String, idproveedor As Integer) As DataSet
        Try
            wflPagosProveedores_Compras_obtenerFacturasImpagas = wflPagosProveedores.Compras_obtenerFacturasImpagasPorProveedor(cadena, idproveedor)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflPagosProveedores_Bonificaciones_obtenerPorProve(ByVal cadena As String, idproveedor As Integer) As DataSet
        Try
            wflPagosProveedores_Bonificaciones_obtenerPorProve = wflPagosProveedores.Bonificaciones_obtenerBonificacionesPorProveedor(cadena, idproveedor)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflPagosProveedores_obtenerPagosAbiertos(ByVal cadena As String, idproveedor As Integer) As DataSet
        Try
            wflPagosProveedores_obtenerPagosAbiertos = wflPagosProveedores.PagosProveedores_obtenerPagosAbiertos(cadena, idproveedor)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    
End Class
