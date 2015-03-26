Imports brlFacturacion
Public Class wflEmisionFactura
    Public Shared Function wflEmisionFactura_obtenerArticuloFacturacion(ByVal cadena As String, lngIdArticulo As Integer, idlista As Integer) As DataSet
        Try
            wflEmisionFactura_obtenerArticuloFacturacion = brlArticulos.obtenerArticuloFacturacion(cadena, lngIdArticulo, idlista)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflEmisionFactura_obtenerFormasPago(ByVal cadena As String) As DataSet
        Try
            wflEmisionFactura_obtenerFormasPago = brlTFormasPago.obtenerLista(cadena)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflEmisionFactura_comprobantesVenta_obtenerRegistro(ByVal cadena As String, lngNrocom As Integer) As DataSet
        Try
            wflEmisionFactura_comprobantesVenta_obtenerRegistro = brlComprobantesVenta.obtenerRegistro(cadena, lngNrocom)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflEmisionFactura_comprobantesVentaDetalle_obtenerRegistro(ByVal cadena As String, lngNrocom As Integer) As DataSet
        Try
            wflEmisionFactura_comprobantesVentaDetalle_obtenerRegistro = brlComprobantesVentaDetalle.obtenerRegistro(cadena, lngNrocom)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function


    Public Shared Function wflEmisionFactura_GuardarComprobante(ByVal cadena As String, dstComprobante As DataSet, _
                                                                dstDeta As DataSet, iddeposito As Integer) As Boolean
        Try

            Dim ultimoNrocom As Integer
            Dim dstTFact As New DataSet
            dstTFact = brlTFactura.obtenerRegistro("T", cadena)
            If dstTFact.Tables(0).Rows.Count > 0 Then
                ultimoNrocom = dstTFact.Tables(0).Rows(0)("ultimo")
            End If

            dstComprobante.Tables(0).Rows(0)("cvt_nrocom") = ultimoNrocom
            Dim intResult As Integer = brlComprobantesVenta.insertarRegistro(cadena, dstComprobante)

            For Each dr As DataRow In dstDeta.Tables(0).Rows
                intResult = brlComprobantesVentaDetalle.insertarRegistro(cadena, ultimoNrocom, dr("cvd_codart"), dr("cvd_descart"), dr("cvd_cantidad"), dr("cvd_precunit"), dr("cvd_totart"), dr("cvd_idrubro"))

            Next

            'Actualizo el ultimo
            brlTFactura.actualizarRegistro("T", cadena)

            '----Me fijo si controla stock
            For Each dr As DataRow In dstDeta.Tables(0).Rows
                If brlStockPorDeposito.obtenerRegistro(cadena, dr("cvd_codart"), iddeposito).Tables(0).Rows.Count > 0 Then
                    brlStockPorDeposito.DescontarStockActual(cadena, dr("cvd_codart"), iddeposito, dr("cvd_cantidad"))
                End If
            Next


            '--------------------------------------------------------------------------------



            wflEmisionFactura_GuardarComprobante = True

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflEmisionFactura_obtenerListaArticulos(ByVal cadena As String, idlista As Integer) As DataSet
        Try
            wflEmisionFactura_obtenerListaArticulos = brlArticulos.ObtenerListaParaGrilla(cadena, idlista)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflEmisionFactura_ExisteCajaAbierta(ByVal cadena As String, idUsuario As Integer, lngIdsucursal As Integer) As Boolean
        Try
            wflEmisionFactura_ExisteCajaAbierta = brlCajasDiarias.ExisteCajaAbierta(cadena, idUsuario, lngIdsucursal)

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function



End Class
