Imports brlFacturacion
Public Class wflPagosProveedores

    Public Shared Function Proveedores_obtenerLista(ByVal cadena As String) As DataSet
        Try
            Proveedores_obtenerLista = brlProveedores.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function PagosProveedores_obtenerLista(ByVal cadena As String, idprov As Integer) As DataSet
        Try
            PagosProveedores_obtenerLista = brlPagosProveedores.obtenerLista(cadena, idprov)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function SaldosProve_obtenerRegistro(ByVal cadena As String, idprov As Integer) As DataSet
        Try
            SaldosProve_obtenerRegistro = brlSaldosProve.obtenerRegistro(idprov, cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function PagosProveedoresDetalles_obtenerLista(ByVal cadena As String, nroPago As Integer) As DataSet
        Try
            PagosProveedoresDetalles_obtenerLista = brlPagosProveedoresDetalles.obtenerLista(cadena, nroPago)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function Bonificaciones_obtenerLista(ByVal cadena As String, nroPago As Integer) As DataSet
        Try
            Dim myTable As New DataTable
            Dim myauxDt As DataView
            Dim myauxDaset As New DataSet
            myauxDt = brlBonificaciones.obtenerBonificacionesPorNroPago(cadena, nroPago)
            myTable = myauxDt.ToTable
            myauxDaset.Tables.Add(myTable)

            Bonificaciones_obtenerLista = myauxDaset

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function OtrosConceptos_obtenerLista(ByVal cadena As String, nroPago As Integer) As DataSet
        Try
            OtrosConceptos_obtenerLista = brlOtrosconceptos.obtenerLista(cadena, nroPago)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Compras_obtenerFacturasImpagasPorProveedor(ByVal cadena As String, idProv As Integer) As DataSet
        Try

            Dim myTable As New DataTable
            Dim myauxDt As DataView
            Dim myauxDaset As New DataSet
            myauxDt = brlCompras.obtenerFacturasImpagas(cadena, idProv)
            myTable = myauxDt.ToTable
            myauxDaset.Tables.Add(myTable)
            Compras_obtenerFacturasImpagasPorProveedor = myauxDaset
        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function Bonificaciones_obtenerBonificacionesPorProveedor(ByVal cadena As String, idproveedor As Integer) As DataSet
        Try

            Dim myauxDt As New DataView
            Dim myTable As New DataTable
            Dim myauxDaset As New DataSet

            myauxDt = brlBonificaciones.obtenerBonificacionesPorProveedor(cadena, idproveedor)
            myTable = myauxDt.ToTable
            myauxDaset.Tables.Add(myTable)

            Bonificaciones_obtenerBonificacionesPorProveedor = myauxDaset
        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
   
    Public Shared Function PagosProveedores_obtenerPagosAbiertos(ByVal cadena As String, idproveedor As Integer) As DataSet
        Try
            Dim myTable As New DataTable
            Dim myauxDt As DataView
            Dim myauxDaset As New DataSet
            myauxDt = brlPagosProveedores.obtenerPagosAbiertos(cadena, idproveedor)
            myTable = myauxDt.ToTable
            myauxDaset.Tables.Add(myTable)
            PagosProveedores_obtenerPagosAbiertos = myauxDaset

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Pagos Abiertos " + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function OtrosConceptos_obtenerRegistro(ByVal cadena As String, lngIdOC As Integer) As DataSet
        Try


            OtrosConceptos_obtenerRegistro = brlOtrosconceptos.obtenerRegistro(lngIdOC, cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Pagos Abiertos " + "|" + ex.Message)
        End Try
    End Function


    Public Shared Function Cheques_obtenerListaPorNroPago(ByVal cadena As String, nroPago As Integer) As DataSet
        Try
            Dim myTable As New DataTable
            Dim myauxDt As DataView
            Dim myauxDaset As New DataSet
            myauxDt = brlCheques.obtenerChequesPorNroPago(cadena, nroPago)
            myTable = myauxDt.ToTable
            myauxDaset.Tables.Add(myTable)

            Cheques_obtenerListaPorNroPago = myauxDaset

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Bancos_obtenerBancosVigentes(ByVal cadena As String) As DataSet
        Try


            Bancos_obtenerBancosVigentes = brlBancos.obtenerBancosVigentes(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Pagos Abiertos " + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Efectivo_obtenerLista(ByVal cadena As String, lngTpoMoneda As Integer) As DataSet
        Try


            Efectivo_obtenerLista = brlEfectivo.obtenerLista(cadena, lngTpoMoneda)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Pagos Abiertos " + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Monedas_obtenerLista(ByVal cadena As String) As DataSet
        Try


            Monedas_obtenerLista = brlMonedas.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Pagos Abiertos " + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function Efectivo_obtenerListaPorNroPago(ByVal cadena As String, nroPago As Integer, tpoMoneda As Integer) As DataSet
        Try
            Dim myTable As New DataTable
            Dim myauxDt As DataView
            Dim myauxDaset As New DataSet
            myauxDt = brlEfectivo.obtenerEfectivoPorNroPago(cadena, nroPago, tpomoneda)
            myTable = myauxDt.ToTable
            myauxDaset.Tables.Add(myTable)
            Efectivo_obtenerListaPorNroPago = myauxDaset

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Depositos_obtenerListaPorNroPago(ByVal cadena As String, nroPago As Integer, tpoMoneda As Integer) As DataSet
        Try
            Dim myTable As New DataTable
            Dim myauxDt As DataView
            Dim myauxDaset As New DataSet
            myauxDt = brlDepositosPagos.obtenerDepositosPorNroPago(cadena, nroPago, tpoMoneda)
            myTable = myauxDt.ToTable
            myauxDaset.Tables.Add(myTable)
            depositos_obtenerListaPorNroPago = myauxDaset

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Depositos_obtenerLista(ByVal cadena As String, lngTpoMoneda As Integer) As DataSet
        Try


            Depositos_obtenerLista = brlDepositosPagos.obtenerLista(cadena, lngTpoMoneda)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Pagos Abiertos " + "|" + ex.Message)
        End Try
    End Function


    Public Shared Sub GuardarPagoProveedores(dtboni As DataSet, dtcheques As DataSet, dtEfe As DataSet, dtfactuapagar As DataSet, _
                                      exito As Boolean, dtPagosProv As DataSet, dtPagosProvDet As DataSet, dtDepositos As DataSet, _
                                      dtOc As DataSet, cadena As String, lngNroProve As Integer, NroPago As Integer)

        Dim estado As String
        Dim NroAux As Integer
        Dim i As Integer
        estado = dtPagosProv.Tables(0).Rows(0)("ppr_estado")

        If estado = "C" Then
            ActualizarSaldoFacturas(dtfactuapagar, cadena)
            ActualizarSaldosProve(lngNroProve, dtPagosProv.Tables(0).Rows(0)("ppr_saldopagoprox"), cadena)
            'AltaCtaCte(chequespropios, idsoc) inserta los cheques en la ctacte bancaria
        End If
        '---Actualizo pagos a proveedores --------------------------------
        NroAux = brlPagosProveedores.insertarRegistro(dtPagosProv, cadena)
        '------Actualizo pagos a proveeedores detalles -------------------
        For Each dtrow As DataRow In dtPagosProvDet.Tables(0).Rows
            i = brlPagosProveedoresDetalles.insertarRegistro(dtrow("ppd_tipfac"), dtrow("ppd_nrofac"), dtrow("ppd_totalfac"), dtrow("ppd_idcompra"), NroPago, dtrow("ppd_deposito"), dtrow("ppd_feccom"), cadena)
        Next
        '-------Actualizo las bonificaciones ---------------
        For Each dtrow As DataRow In dtboni.Tables(0).Rows
            i = brlBonificaciones.insertarRegistro(dtrow("bon_fecha"), dtrow("bon_nrobon"), dtrow("bon_nroprove"), dtrow("bon_concepto"), dtrow("bon_monto"), dtrow("bon_comprobante"), dtrow("bon_usada"), NroPago, cadena)
        Next

        '---actualizo los cheques
        For Each dtrow As DataRow In dtcheques.Tables(0).Rows
            i = brlCheques.insertarRegistro(dtrow("pcp_nrocheque"), dtrow("pcp_banco"), dtrow("pcp_monto"), dtrow("pcp_fecemi"), dtrow("pcp_fecpago"), dtrow("pcp_soc_id"), NroPago, dtrow("pcp_origen"), cadena)
        Next
        '---Actualizo el efectivo
        For Each dtrow As DataRow In dtEfe.Tables(0).Rows
            i = brlEfectivo.insertarRegistro(dtrow("pde_tpomoneda"), dtrow("pde_monto"), NroPago, cadena)
        Next
        '----Actualizo los depositos
        For Each dtrow As DataRow In dtDepositos.Tables(0).Rows
            i = brlDepositosPagos.insertarRegistro(dtrow("dep_idbanco"), dtrow("dep_nroboleta"), dtrow("dep_fecha"), dtrow("dep_totaldepo"), NroPago, cadena)
        Next
        '----Actualizo Otros conceptos
        For Each dtrow As DataRow In dtOc.Tables(0).Rows
            i = brlOtrosconceptos.insertarRegistro(dtrow("poc_fecha"), dtrow("poc_idprove"), dtrow("poc_descripcion"), dtrow("poc_monto"), dtrow("poc_comprobante"), NroPago, cadena)
        Next

        'Actualizo el ultimo nro de pago
        brlUltimos.actualizarRegistro("ppr_nropago", cadena)

        exito = True


    End Sub


    Public Shared Sub ModificarPagoProveedores(dtboni As DataSet, dtcheques As DataSet, dtEfe As DataSet, dtfactuapagar As DataSet, _
                                     exito As Boolean, dtPagosProv As DataSet, dtPagosProvDet As DataSet, dtDepositos As DataSet, _
                                     dtOc As DataSet, cadena As String, lngNroProve As Integer)

        Dim estado As String
        Dim NroPago As Integer
        Dim i As Integer
        estado = dtPagosProv.Tables(0).Rows(0)("ppr_estado")
        NroPago = dtPagosProv.Tables(0).Rows(0)("ppr_nropago")

        '--Elimino lo guardado

        '---Elimino de pagos a proveedores
        brlPagosProveedores.EliminarRegistro(cadena, lngNroProve, NroPago)
        '---Elimino de pagos proveedores detalles
        brlPagosProveedoresDetalles.EliminarRegistro(cadena, NroPago)
        '--Elimino las bonificaciones
        brlBonificaciones.EliminarRegistro(cadena, lngNroProve, NroPago)
        '--Elimino los cheques
        brlCheques.EliminarRegistro(cadena, NroPago)
        '--Elimino el efectivo
        brlEfectivo.EliminarRegistro(cadena, NroPago)
        '--Elimino los depositos
        brlDepositosPagos.EliminarRegistro(cadena, NroPago)
        '--Elimino los otros conceptos
        brlOtrosconceptos.EliminarRegistro(cadena, NroPago)

        Dim NroPagoAux As Integer

        If estado = "C" Then
            ActualizarSaldoFacturas(dtfactuapagar, cadena)
            ActualizarSaldosProve(lngNroProve, dtPagosProv.Tables(0).Rows(0)("ppr_saldopagoprox"), cadena)
            'AltaCtaCte(chequespropios, idsoc) inserta los cheques en la ctacte bancaria
        End If
        '---Actualizo pagos a proveedores --------------------------------
        NroPagoAux = brlPagosProveedores.insertarRegistro(dtPagosProv, cadena)
        '------Actualizo pagos a proveeedores detalles -------------------
        For Each dtrow As DataRow In dtPagosProvDet.Tables(0).Rows
            i = brlPagosProveedoresDetalles.insertarRegistro(dtrow("ppd_tipfac"), dtrow("ppd_nrofac"), dtrow("ppd_totalfac"), dtrow("ppd_idcompra"), NroPago, dtrow("ppd_deposito"), dtrow("ppd_feccom"), cadena)
        Next
        '-------Actualizo las bonificaciones ---------------
        For Each dtrow As DataRow In dtboni.Tables(0).Rows
            i = brlBonificaciones.insertarRegistro(dtrow("bon_fecha"), dtrow("bon_nrobon"), dtrow("bon_nroprove"), dtrow("bon_concepto"), dtrow("bon_monto"), dtrow("bon_comprobante"), dtrow("bon_usada"), NroPago, cadena)
        Next

        '---actualizo los cheques
        For Each dtrow As DataRow In dtcheques.Tables(0).Rows
            i = brlCheques.insertarRegistro(dtrow("pcp_nrocheque"), dtrow("pcp_banco"), dtrow("pcp_monto"), dtrow("pcp_fecemi"), dtrow("pcp_fecpago"), dtrow("pcp_soc_id"), NroPago, dtrow("pcp_origen"), cadena)
        Next
        '---Actualizo el efectivo
        For Each dtrow As DataRow In dtEfe.Tables(0).Rows
            i = brlEfectivo.insertarRegistro(dtrow("pde_tpomoneda"), dtrow("pde_monto"), NroPago, cadena)
        Next
        '----Actualizo los depositos
        For Each dtrow As DataRow In dtDepositos.Tables(0).Rows
            i = brlDepositosPagos.insertarRegistro(dtrow("dep_idbanco"), dtrow("dep_nroboleta"), dtrow("dep_fecha"), dtrow("dep_totaldepo"), NroPago, cadena)
        Next
        '----Actualizo Otros conceptos
        For Each dtrow As DataRow In dtOc.Tables(0).Rows
            i = brlOtrosconceptos.insertarRegistro(dtrow("poc_fecha"), dtrow("poc_idprove"), dtrow("poc_descripcion"), dtrow("poc_monto"), dtrow("poc_comprobante"), NroPago, cadena)
        Next




        exito = True


    End Sub


    Private Shared Sub ActualizarSaldoFacturas(factuapagar As DataSet, cadena As String)
        Dim dt As New DataSet
        For Each dr As DataRow In factuapagar.Tables(0).Rows
            dt = brlCompras.obtenerRegistro(dr("idcompra"), cadena)
            dt.Tables(0).Rows(0)("pagada") = True
            dt.Tables(0).Rows(0)("saldo") = 0
            brlCompras.actualizarRegistro(dt, cadena)
        Next

    End Sub

    Private Shared Sub ActualizarSaldosProve(lngNroProve As Integer, resto As Double, cadena As String)
        Dim dt As New DataSet

        dt = brlSaldosProve.obtenerRegistro(lngNroProve, cadena)

        If dt.Tables(0).Rows.Count > 0 Then
            dt.Tables(0).Rows(0)("sal_saldo") = resto
            brlSaldosProve.actualizarRegistro(dt, cadena)
        Else
            dt.Tables(0).Rows.Add()
            dt.Tables(0).Rows(0)("sal_idprove") = lngNroProve
            dt.Tables(0).Rows(0)("sal_saldo") = resto
            dt.Tables(0).Rows(0)("sal_saldoini") = 0
            dt.Tables(0).Rows(0)("sal_idsociedad") = 1
            brlSaldosProve.insertarRegistro(dt, cadena)
        End If

    End Sub
    
    Public Shared Function PagosProveedores_obtenerRegistro(ByVal cadena As String, lngNroPago As Integer) As DataSet
        Try


            PagosProveedores_obtenerRegistro = brlPagosProveedores.obtenerRegistro(cadena, lngNroPago)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Registro " + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function PagosProveedoresDetalles_obtenerRegistro(ByVal cadena As String, lngNroPago As Integer) As DataSet
        Try


            PagosProveedoresDetalles_obtenerRegistro = brlPagosProveedoresDetalles.obtenerRegistro(cadena, lngNroPago)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Registro " + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Ultimos_obtenerRegistro(ByVal cadena As String, strCampo As String) As DataSet
        Try


            Ultimos_obtenerRegistro = brlUltimos.obtenerRegistro(strCampo, cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Registro " + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Bancos_obtenerRegistro(ByVal cadena As String, lngIdBanco As Integer) As DataSet
        Try


            Bancos_obtenerRegistro = brlBancos.obtenerRegistro(lngIdBanco, cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Registro " + "|" + ex.Message)
        End Try
    End Function


    Public Shared Sub PagosProveedores_obtenerSaldo(ByVal cadena As String, ByRef dstProve As DataSet)
        Try
            Dim dblsumaFacturas As Double
            Dim dblPagos As Double
            Dim dblBonificaciones As Double
            Dim dblOtrosConceptos As Double
            Dim dblSaldoIni As Double
            Dim dblSaldoTotal As Double
            Dim brlPa As New DataSet
            For Each dr As DataRow In dstProve.Tables(0).Rows

                dblsumaFacturas = brlCompras.SumarFacturas(cadena, dr("idproveedor"))
                dblPagos = brlPagosProveedores.SumarPagos(cadena, dr("idproveedor"))
                dblBonificaciones = brlBonificaciones.SumarBonificaciones(cadena, dr("idproveedor"))
                dblOtrosConceptos = brlOtrosconceptos.SumarSaldo(cadena, dr("idproveedor"))
                dblSaldoIni = brlSaldosProve.SaldosIni(cadena, dr("idproveedor"))
                dblSaldoTotal = FormatNumber(-dblsumaFacturas + dblPagos + dblBonificaciones - dblOtrosConceptos + dblSaldoIni, 2)
                brlPa = PagosProveedores_obtenerPagosAbiertos(cadena, dr("idproveedor"))

                If brlPa.Tables(0).Rows.Count > 0 Then
                    dr("pa") = "S"
                Else
                    dr("pa") = "N"
                End If


                dr("saldo") = dblSaldoTotal

            Next
        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Registro " + "|" + ex.Message)
        End Try
    End Sub
End Class
