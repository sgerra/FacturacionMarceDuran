Imports wflFacturacion
Public Class pwiPagoProveedores
    Public Shared Function PagoProveedores_obtenerRegistro(ByVal cadena As String, lngNroPago As Integer) As DataSet
        Try
            PagoProveedores_obtenerRegistro = wflPagosProveedores.PagosProveedores_obtenerRegistro(cadena, lngNroPago)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function PagoProveedoresDetalles_obtenerRegistro(ByVal cadena As String, lngNroPago As Integer) As DataSet
        Try
            PagoProveedoresDetalles_obtenerRegistro = wflPagosProveedores.PagosProveedoresDetalles_obtenerRegistro(cadena, lngNroPago)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function PagoProveedores_obtenerUltimoNroPago(ByVal cadena As String, strCampo As String) As DataSet
        Try
            PagoProveedores_obtenerUltimoNroPago = wflPagosProveedores.Ultimos_obtenerRegistro(cadena, strCampo)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Sub PagoProveedores_GuardarPago(dtboni As DataSet, dtcheques As DataSet, dtEfe As DataSet, _
                                                       dtfactuapagar As DataSet, exito As Boolean, dtPagosProv As DataSet, dtPagosProvDet As DataSet, dtDepositos As DataSet, dtOc As DataSet, cadena As String, lngNroProve As Integer, nropago As Integer)
        Try
            wflPagosProveedores.GuardarPagoProveedores(dtboni, dtcheques, dtEfe, dtfactuapagar, exito, dtPagosProv, dtPagosProvDet, dtDepositos, dtOc, cadena, lngNroProve, nropago)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Sub

    Public Shared Sub PagoProveedores_ModificarPago(dtboni As DataSet, dtcheques As DataSet, dtEfe As DataSet, _
                                                       dtfactuapagar As DataSet, exito As Boolean, dtPagosProv As DataSet, dtPagosProvDet As DataSet, dtDepositos As DataSet, dtOc As DataSet, cadena As String, lngNroProve As Integer)
        Try
            wflPagosProveedores.ModificarPagoProveedores(dtboni, dtcheques, dtEfe, dtfactuapagar, exito, dtPagosProv, dtPagosProvDet, dtDepositos, dtOc, cadena, lngNroProve)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Sub
    Public Shared Function Bancos_obtenerRegistro(lngIdBanco As Integer, cadena As String) As DataSet
        Try
            Bancos_obtenerRegistro = wflPagosProveedores.Bancos_obtenerRegistro(cadena, lngIdBanco)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Sub PagosProveedores_obtenerSaldo(cadena As String, ByRef dstProve As DataSet)
        Try
            wflPagosProveedores.PagosProveedores_obtenerSaldo(cadena, dstProve)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Sub
End Class
