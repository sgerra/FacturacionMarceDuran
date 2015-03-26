Imports wflFacturacion
Public Class pwiCajasDiarias
    Public Shared Function wflCajasDiarias_obtenerListaCajas(ByVal cadena As String, lngIdSuc As Integer) As DataSet
        Try
            wflCajasDiarias_obtenerListaCajas = wflCajasDiarias.wflCajasDiarias_obtenerListaCajas(cadena, lngIdSuc)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflCajasDiarias_obtenerRegistro(ByVal cadena As String, lngIdCaja As Integer) As DataSet
        Try
            wflCajasDiarias_obtenerRegistro = wflCajasDiarias.wflCajasDiarias_obtenerRegistro(cadena, lngIdCaja)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflCajasDiarias_obtenerDetalle(ByVal cadena As String, lngIdCaja As Integer) As DataSet
        Try
            wflCajasDiarias_obtenerDetalle = wflCajasDiarias.wflCajasDiarias_obtenerDetalle(cadena, lngIdCaja)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function


    Public Shared Function wflCajasDiariasDetalles_obtenerLista(ByVal cadena As String, lngIdCaja As Integer) As DataSet
        Try
            wflCajasDiariasDetalles_obtenerLista = wflCajasDiarias.wflCajasDiarias_CajasDetalles_obtenerLista(cadena, lngIdCaja)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflCajasDiarias_CajasDetalles_obtenerListaMovimientos(ByVal cadena As String, strFecha As String, strHora As String, lngIdUsuario As Integer) As DataSet
        Try
            wflCajasDiarias_CajasDetalles_obtenerListaMovimientos = wflCajasDiarias.wflCajasDiarias_CajasDetalles_obtenerListaMovimientos(cadena, strFecha, strHora, lngIdUsuario)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflCajasDiariasDetalles_obtenerFormasPago(ByVal cadena As String) As DataSet
        Try
            wflCajasDiariasDetalles_obtenerFormasPago = wflCajasDiarias.wflCajasDiarias_FormasPago_obtenerLista(cadena)


        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflCajasDiarias_CerrarCaja(cadena As String, dstCaja As DataSet, dstDetalleCaja As DataSet, dstFormasPago As DataSet) As Boolean
        Try
            wflCajasDiarias_CerrarCaja = wflCajasDiarias.wflCajasDiarias_CerrarCaja(cadena, dstCaja, dstDetalleCaja, dstFormasPago)


        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflCajasDiarias_ExisteCajaAbierta(cadena As String, idUsuario As Integer, lngIdsucursal As Integer) As Boolean
        Try
            wflCajasDiarias_ExisteCajaAbierta = wflCajasDiarias.wflCajasDiarias_ExisteCajaAbierta(cadena, idUsuario, lngIdsucursal)


        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflCajasDiarias_AbrirCajaDiaria(cadena As String, dstCaja As DataSet) As Integer
        Try
            wflCajasDiarias_AbrirCajadiaria = wflCajasDiarias.wflCajasDiarias_AbrirCajaDiaria(cadena, dstCaja)


        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    


End Class
