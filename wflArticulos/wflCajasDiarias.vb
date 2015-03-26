Imports brlFacturacion
Public Class wflCajasDiarias
    Public Shared Function wflCajasDiarias_obtenerListaCajas(ByVal cadena As String, lngIdSuc As Integer) As DataSet
        Try
            wflCajasDiarias_obtenerListaCajas = brlCajasDiarias.obtenerListaCajas(cadena, lngIdSuc)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflCajasDiarias_obtenerRegistro(ByVal cadena As String, lngIdCaja As Integer) As DataSet
        Try
            wflCajasDiarias_obtenerRegistro = brlCajasDiarias.obtenerRegistro(cadena, lngIdCaja)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflCajasDiarias_obtenerDetalle(ByVal cadena As String, lngIdCaja As Integer) As DataSet
        Try
            wflCajasDiarias_obtenerDetalle = brlCajasDiarias.obtenerDetalle(cadena, lngIdCaja)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function


    Public Shared Function wflCajasDiarias_CajasDetalles_obtenerLista(ByVal cadena As String, lngIdCaja As Integer) As DataSet
        Try
            wflCajasDiarias_CajasDetalles_obtenerLista = brlCajasDiariasDetalles.obtenerLista(cadena, lngIdCaja)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflCajasDiarias_CajasDetalles_obtenerRegistro(ByVal cadena As String, lngIdCaja As Integer) As DataSet
        Try
            wflCajasDiarias_CajasDetalles_obtenerRegistro = brlCajasDiariasDetalles.obtenerRegistro(cadena, lngIdCaja)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflCajasDiarias_CajasDetalles_obtenerListaMovimientos(ByVal cadena As String, strFecha As String, strHora As String, idUsuario As Integer) As DataSet
        Try
            wflCajasDiarias_CajasDetalles_obtenerListaMovimientos = brlCajasDiariasDetalles.obtenerListaMovimientos(cadena, strFecha, strHora, idUsuario)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflCajasDiarias_FormasPago_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflCajasDiarias_FormasPago_obtenerLista = brlTFormasPago.obtenerLista(cadena)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflCajasDiarias_CerrarCaja(cadena As String, dstCaja As DataSet, dstDetalleCaja As DataSet, dstFormasPago As DataSet) As Boolean
        Try
            Dim intNroMov As Integer

            '----------------------------------------------------------
            Dim dstCajaAux As DataSet = brlCajasDiarias.obtenerRegistro(cadena, dstCaja.Tables(0).Rows(0)("caj_id"))

            dstCajaAux.Tables(0).Rows(0)("caj_saldofinal") = dstCaja.Tables(0).Rows(0)("caj_saldofinal")
            dstCajaAux.Tables(0).Rows(0)("caj_cerrada") = "S"
            dstCajaAux.Tables(0).Rows(0)("caj_f_cierre") = CDate(Now)
            dstCajaAux.Tables(0).Rows(0)("caj_h_cierre") = Now
            brlCajasDiarias.ActualizarCaja(cadena, dstCajaAux)
            '-------------------------------------------------------------------------------------------
            intNroMov = 1
            '------Grabo el detalle de la caja
            For Each row As DataRow In dstDetalleCaja.Tables(0).Rows

                brlCajasDiariasDetalles.insertarRegistro(dstCaja.Tables(0).Rows(0)("caj_id"), intNroMov, row.Item("cvt_nrocom"), row.Item("cvt_totaldto"), row.Item("descri"), 1, 0, cadena)

            Next

            '----Grabo el detalle de los saldos por moneda
            For Each row As DataRow In dstFormasPago.Tables(0).Rows
                brlCajaDiariaSaldosFormaPago.insertarRegistro(dstCaja.Tables(0).Rows(0)("caj_id"), row.Item("cod"), row.Item("monto"), cadena)
            Next
            wflCajasDiarias_CerrarCaja = True

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function


    Public Shared Function wflCajasDiarias_ExisteCajaAbierta(ByVal cadena As String, idUsuario As Integer, lngIdsucursal As Integer) As Boolean
        Try
            wflCajasDiarias_ExisteCajaAbierta = brlCajasDiarias.ExisteCajaAbierta(cadena, idUsuario, lngIdsucursal)

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflCajasDiarias_AbrirCajaDiaria(ByVal cadena As String, dstCaja As DataSet) As Integer
        Try
            wflCajasDiarias_AbrirCajaDiaria = brlCajasDiarias.insertarRegistro(cadena, dstCaja)

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

End Class
