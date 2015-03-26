Imports brlFacturacion
Public Class wflFacturacionLibre
    Public Shared Function Clientes_obtenerDetalle(ByVal cadena As String, lngIdCliente As Integer) As DataSet
        Try
            Clientes_obtenerDetalle = brlClientes.obtenerDetalle(cadena, lngIdCliente)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function tCondicionesVenta_obtenerLista(ByVal cadena As String) As DataSet
        Try
            tCondicionesVenta_obtenerLista = brltCondicionesVenta.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function TposEstadosFactura_obtenerLista(ByVal cadena As String) As DataSet
        Try
            TposEstadosFactura_obtenerLista = brlTposEstadosFacturas.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflFacturacionLibre_GuardarComprobante(ByVal cadena As String, dstComprobante As DataSet, _
                                                              dstDeta As DataSet, iddeposito As Integer, ByRef lngIdFactura As Integer) As Boolean
        Try

            Dim ultimoNrocom As Integer
            Dim dstTFact As New DataSet
            dstTFact = brlTFactura.obtenerRegistro("A", cadena)
            If dstTFact.Tables(0).Rows.Count > 0 Then
                ultimoNrocom = dstTFact.Tables(0).Rows(0)("ultimo")
            End If
            lngIdFactura = ultimoNrocom
            dstComprobante.Tables(0).Rows(0)("cvt_nrocom") = ultimoNrocom
            Dim intResult As Integer = brlComprobantesVenta.insertarRegistro(cadena, dstComprobante)

            For Each dr As DataRow In dstDeta.Tables(0).Rows
                intResult = brlComprobantesVentaDetalle.insertarRegistro(cadena, ultimoNrocom, dr("cvd_codart"), dr("cvd_descart"), dr("cvd_cantidad"), dr("cvd_precunit"), dr("cvd_totart"), dr("cvd_idrubro"))
            Next

            'Actualizo el ultimo
            brlTFactura.actualizarRegistro("A", cadena)

            '----Me fijo si controla stock
            'For Each dr As DataRow In dstDeta.Tables(0).Rows
            '    If brlStockPorDeposito.obtenerRegistro(cadena, dr("cvd_codart"), iddeposito).Tables(0).Rows.Count > 0 Then
            '        brlStockPorDeposito.DescontarStockActual(cadena, dr("cvd_codart"), iddeposito, dr("cvd_cantidad"))
            '    End If
            'Next

            '--------------------------------------------------------------------------------
            wflFacturacionLibre_GuardarComprobante = True

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function
End Class
