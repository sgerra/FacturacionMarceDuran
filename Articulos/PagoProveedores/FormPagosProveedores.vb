Public Class FormPagosProveedores
    Dim nroprovee As Integer
    Dim idsoc As Integer
    Dim NroPago As Integer
    Dim DtOc As New DataSet
    Dim dtBon As New DataSet
    Dim dtCheques As New DataSet
    Dim dtEfectivo As New DataSet
    Dim dtDeposito As New DataSet
    Dim Pagado As Double
    Dim aPagar As Double
    Dim resto As Double
    Dim otrosconceptos As Double
    Dim dtFacPend As New DataSet
    Dim dtFacaPagar As New DataSet
    Dim dtPagosProv As New DataSet
    Dim dtPagosProvDet As New DataSet
    Dim auxDtBanco As New DataSet
    Dim exito As Boolean
    Dim i As Integer

    Public Sub AbrirPagos(nroprove As Long, nombre As String, idsociedad As Long)

        nroprovee = nroprove
        idsoc = idsociedad
        LlenarFacturasPendientes(nroprove, idsoc)
        CargarSaldo(nroprovee, idsoc)
        '---inicializo el dataset de las facturas a pagar
        dtFacaPagar = pwiCtaCte.wflPagosProveedores_Compras_obtenerFacturasImpagas(My.Settings.cadena, -100)


        Me.Text = "Generación de un Nuevo Pago"
        'FormPagosProveedores.Caption = "Orden de Pago Nº " & nropago & "-" & " Número de Pago Nº:  " & nropagoprove
        Me.dtFecPago.Value = Now
        Me.LblProveedor.Text = nombre
        'FormPagosProveedores.LblSaldoAFavor = saldoafavor
        DtOc = pwiOtrosConceptos.wflPagosProveedores_OtrosConceptos_obtenerLista(My.Settings.cadena, NroPago)
        DtOc.Tables(0).Columns.Add("orden")
        dtBon = pwiBonificaciones.wflPagosProveedores_Bonificaciones_obtenerLista(My.Settings.cadena, NroPago)
        dtBon.Tables(0).Columns.Add("orden")
        dtCheques = pwiCheques.wflPagosProveedores_Cheques_obtenerPorNroPago(My.Settings.cadena, NroPago)
        dtCheques.Tables(0).Columns.Add("orden")
        dtCheques.Tables(0).Columns.Add("bancoNombre")
        dtEfectivo = pwiEfectivo.wflPagosProveedores_Efectivo_obtenerPorNroPago(My.Settings.cadena, NroPago, 1)
        dtEfectivo.Tables(0).Columns.Add("orden")
        dtEfectivo.Tables(0).Columns.Add("NombreMoneda")

        dtDeposito = pwiDepositos.wflPagosProveedores_Depositos_obtenerPorNroPago(My.Settings.cadena, NroPago, 1)
        dtDeposito.Tables(0).Columns.Add("orden")
        dtDeposito.Tables(0).Columns.Add("bancoNombre")

        dtPagosProv = pwiPagoProveedores.PagoProveedores_obtenerRegistro(My.Settings.cadena, -1)

        dtPagosProvDet = pwiPagoProveedores.PagoProveedoresDetalles_obtenerRegistro(My.Settings.cadena, -1)

        Me.comboEstado.Text = "Abierto"
        ActualizaTotal()
        CommandAceptarAgregar.Visible = True
        CommandAceptarModificar.Visible = False
        Me.ShowDialog()

    End Sub


    Public Sub ModificarPagos(nroprove As Long, nombre As String, idsociedad As Long, nropa As Integer)

        nroprovee = nroprove
        idsoc = idsociedad
        NroPago = nropa
        CargarSaldo(nroprovee, idsoc)
        '---inicializo el dataset de las facturas a pagar
        dtFacPend = pwiCtaCte.wflPagosProveedores_Compras_obtenerFacturasImpagas(My.Settings.cadena, nroprove)
        dtFacaPagar = pwiCtaCte.wflPagosProveedores_Compras_obtenerFacturasImpagas(My.Settings.cadena, -100)

        Me.Text = "Modificación de Pago Abierto"
        'FormPagosProveedores.Caption = "Orden de Pago Nº " & nropago & "-" & " Número de Pago Nº:  " & nropagoprove
        Me.dtFecPago.Value = Now
        Me.LblProveedor.Text = nombre
        'FormPagosProveedores.LblSaldoAFavor = saldoafavor
        DtOc = pwiOtrosConceptos.wflPagosProveedores_OtrosConceptos_obtenerLista(My.Settings.cadena, nropago)
        DtOc.Tables(0).Columns.Add("orden")

        For Each dr As DataRow In DtOc.Tables(0).Rows
            Me.TextOC.Text = CDbl(Me.TextOC.Text) + dr("poc_monto")
        Next

        dtBon = pwiBonificaciones.wflPagosProveedores_Bonificaciones_obtenerLista(My.Settings.cadena, nropago)
        dtBon.Tables(0).Columns.Add("orden")
        For Each dr As DataRow In dtBon.Tables(0).Rows
            Me.TextBon.Text = CDbl(Me.TextBon.Text) + dr("bon_monto")
        Next
        Me.TextBo.Text = Me.TextBon.Text


        dtCheques = pwiCheques.wflPagosProveedores_Cheques_obtenerPorNroPago(My.Settings.cadena, nropago)
        dtCheques.Tables(0).Columns.Add("orden")
        dtCheques.Tables(0).Columns.Add("bancoNombre")
        i = 0
        For Each dr As DataRow In dtCheques.Tables(0).Rows
            auxDtBanco = pwiPagoProveedores.Bancos_obtenerRegistro(dr("pcp_banco"), My.Settings.cadena)
            dr("bancoNombre") = auxDtBanco.Tables(0).Rows(0)("ban_nombanco")
            dr("orden") = i
            Me.txtcheques.Text = CDbl(Me.txtcheques.Text) + dr("pcp_monto")
            i = i + 1
        Next


        dtEfectivo = pwiEfectivo.wflPagosProveedores_Efectivo_obtenerPorNroPago(My.Settings.cadena, nropago, 1)
        dtEfectivo.Tables(0).Columns.Add("orden")
        dtEfectivo.Tables(0).Columns.Add("NombreMoneda")
        i = 0
        For Each dr As DataRow In dtEfectivo.Tables(0).Rows
            dr("orden") = i
            dr("NombreMoneda") = "Pesos"
            Me.txtefectivo.Text = CDbl(Me.txtefectivo.Text) + dr("pde_monto")

            i = i + 1
        Next


        dtDeposito = pwiDepositos.wflPagosProveedores_Depositos_obtenerPorNroPago(My.Settings.cadena, nropago, 1)
        dtDeposito.Tables(0).Columns.Add("orden")
        dtDeposito.Tables(0).Columns.Add("bancoNombre")
        i = 0
        For Each dr As DataRow In dtDeposito.Tables(0).Rows
            dr("orden") = i
            auxDtBanco = pwiPagoProveedores.Bancos_obtenerRegistro(dr("dep_idbanco"), My.Settings.cadena)
            dr("bancoNombre") = auxDtBanco.Tables(0).Rows(0)("ban_nombanco")
            Me.txtdeposito.Text = CDbl(Me.txtdeposito.Text) + dr("dep_totaldepo")
            i = i + 1
        Next

        dtPagosProv = pwiPagoProveedores.PagoProveedores_obtenerRegistro(My.Settings.cadena, nropago)
        Me.dtFecPago.Value = dtPagosProv.Tables(0).Rows(0)("ppr_fecpago")
        Me.lblSaldoafavor.Text = dtPagosProv.Tables(0).Rows(0)("ppr_saldopagoant")
        Me.lblResto.Text = dtPagosProv.Tables(0).Rows(0)("ppr_saldopagoprox")
        Me.txtobservaciones.Text = dtPagosProv.Tables(0).Rows(0)("ppr_observaciones")

        dtPagosProvDet = pwiPagoProveedores.PagoProveedoresDetalles_obtenerRegistro(My.Settings.cadena, nropago)
        CargarGrillaFacturasPagoAbierto(dtPagosProvDet)

        'Seteo el dataset que contiene las facturas incluidas en el pago
        Dim j As Integer = 0
        For Each dr As DataRow In dtPagosProvDet.Tables(0).Rows
            dtFacaPagar.Tables(0).Rows.Add()
            dtFacaPagar.Tables(0).Rows(j)("idcompra") = dr("ppd_idcompra")
            dtFacaPagar.Tables(0).Rows(j)("fecha") = dr("ppd_feccom")
            dtFacaPagar.Tables(0).Rows(j)("Proveedor") = nombre
            dtFacaPagar.Tables(0).Rows(j)("total") = dr("ppd_totalfac")
            dtFacaPagar.Tables(0).Rows(j)("idestado") = 1
            dtFacaPagar.Tables(0).Rows(j)("Estado") = "Factura"
            dtFacaPagar.Tables(0).Rows(j)("idproveedor") = nroprove
            dtFacaPagar.Tables(0).Rows(j)("pagada") = False
            dtFacaPagar.Tables(0).Rows(j)("nrofactura") = dr("ppd_nrofac")
            dtFacaPagar.Tables(0).Rows(j)("idtipofact") = 1
            dtFacaPagar.Tables(0).Rows(j)("codigo") = dr("ppd_tipfac")
            dtFacaPagar.Tables(0).Rows(j)("saldo") = dr("ppd_totalfac")

            j = j + 1
        Next

        LlenarFacturasPendientes(nroprove, idsoc)

        Me.comboEstado.Text = "Abierto"
        ActualizaTotal()
        ActualizarMontosTotales()
        commandAceptarAgregar.Visible = False
        commandAceptarModificar.Visible = True
        Me.ShowDialog()

    End Sub


    Private Sub LlenarFacturasPendientes(ByVal nroProve As Integer, idsoc As Integer)

        dtFacPend = pwiCtaCte.wflPagosProveedores_Compras_obtenerFacturasImpagas(My.Settings.cadena, nroProve)
        CargarGrillaFacturasPendientes(dtFacPend)

    End Sub
    Private Sub CargarGrillaFacturasPendientes(dt As DataSet)

        Dim lngNroError As Long

        Try
            lngNroError = 0
            DataGridFacturasPendientes.Rows.Clear()

            For Each row In dt.Tables(0).Rows
                If Not EstaenGrilla(row("idcompra")) Then
                    DataGridFacturasPendientes.Rows.Add(row("idcompra"), row("nrofactura"), row("codigo"), row("fecha"), row("saldo"))
                    ' Me fijo si la fecha de la FT es anterior a la del pago y las sugiero
                    If row("fecha") < Now Then
                        DataFactuAPagar.Rows.Add(row("idcompra"), row("nrofactura"), row("codigo"), row("fecha"), row("saldo"))
                        ActualizarSaldosFactu(row("saldo"))
                        ActualizarMontosTotales()
                    End If


                End If
            Next


        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try

    End Sub
    Private Function EstaenGrilla(idcompra As Integer) As Boolean
        Dim i As Integer
        EstaenGrilla = False
        For i = 0 To DataFactuAPagar.Rows.Count - 2
            If DataFactuAPagar.Rows(i).Cells("idcom").Value = idcompra Then
                EstaenGrilla = True
                Exit Function
            End If
        Next

    End Function
    Private Sub CargarSaldo(nroprove As Integer, idsoc As Integer)
        Dim dt As New DataSet

        dt = pwiCtaCte.SaldosProve_obtenerRegistro(My.Settings.cadena, nroprove)

        If dt.Tables(0).Rows.Count > 0 Then
            Me.lblSaldoafavor.Text = dt.Tables(0).Rows(0).Item("sal_saldo")
        End If
    End Sub
    Private Sub ActualizaTotal()
        If Val(Me.lblSaldoafavor.Text) > 0 Then
            Me.TextTotal.Text = CDbl(Me.TextTotFact.Text) - CDbl(TextBon.Text) + CDbl(Me.TextOC.Text) - CDbl(Me.lblSaldoafavor.Text)
        Else
            TextTotal.Text = CDbl(TextTotFact.Text) - CDbl(TextBon.Text) + CDbl(TextOC.Text) - CDbl(Me.lblSaldoafavor.Text)
        End If
        Me.lblResto.Text = FormatNumber(CDbl(Me.TextTotalPagado.Text) - CDbl(TextTotal.Text), 2)
    End Sub

    Private Sub FormPagosProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOc.Click
        Dim totalOc As Double
        FormOtrosConceptos.Abrir(nroprovee, NroPago, DtOc)

        For Each dr In DtOc.Tables(0).Rows
            totalOc = totalOc + dr("poc_monto")
        Next
        Me.TextOC.Text = totalOc
        ActualizarSaldosFactu(CDbl(Me.lblSaldoafavor.Text))
        ActualizarMontosTotales()

    End Sub

    Private Sub btnBoni_Click(sender As Object, e As EventArgs) Handles btnBoni.Click
        Dim totalBoni As Double
        FormBonificaciones.Abrir(nroprovee, NroPago, dtBon)

        For Each dr In dtBon.Tables(0).Rows
            totalBoni = totalBoni + dr("bon_monto")
        Next
        Me.TextBo.Text = totalBoni
        Me.TextBon.Text = totalBoni
        ActualizarSaldosFactu(CDbl(Me.lblSaldoafavor.Text))
        ActualizarMontosTotales()
    End Sub

    Private Sub btncheques_Click(sender As Object, e As EventArgs) Handles btncheques.Click
        Dim totalCheques As Double
        FormCheques.Abrir(nroprovee, NroPago, dtCheques)

        For Each dr In dtCheques.Tables(0).Rows
            totalCheques = totalCheques + dr("pcp_monto")
        Next
        Me.txtcheques.Text = totalCheques
        ActualizarMontosTotales()
    End Sub

    
    Private Sub btnefectivo_Click(sender As Object, e As EventArgs) Handles btnefectivo.Click
        Dim totalEfectivo As Double
        FormEfectivo.Abrir(nroprovee, NroPago, dtEfectivo)

        For Each dr In dtEfectivo.Tables(0).Rows
            totalEfectivo = totalEfectivo + dr("pde_monto")
        Next
        Me.txtefectivo.Text = totalEfectivo
        ActualizarMontosTotales()
    End Sub

    Private Sub btndeposito_Click(sender As Object, e As EventArgs) Handles btndeposito.Click
        Dim totalDeposito As Double
        FormDepositos.Abrir(nroprovee, NroPago, dtDeposito)

        For Each dr In dtDeposito.Tables(0).Rows
            totalDeposito = totalDeposito + dr("dep_totaldepo")
        Next
        Me.txtdeposito.Text = totalDeposito
        ActualizarMontosTotales()
    End Sub

    Private Sub commandAceptarAgregar_Click(sender As Object, e As EventArgs) Handles commandAceptarAgregar.Click
        Dim dtaux As New DataSet

        If MsgBox("¿ Desea guardar el pago ? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Aviso al operador") = 6 Then
            If comboEstado.Text <> "" Then

                If Val(Me.lblSaldoafavor.Text) > 0 Then
                    Pagado = FormatNumber(Val(TextTotalPagado.Text) + Val(TextBon.Text) + Val(lblSaldoafavor.Text), 2)
                Else
                    Pagado = FormatNumber(Val(TextTotalPagado.Text) + Val(TextBon.Text), 2)
                End If
                
                aPagar = FormatNumber(Val(TextTotFact.Text) + Val(TextOC.Text), 2)
                resto = FormatNumber(Pagado - aPagar, 2)
                '----------------------------------------------------------------------
                dtaux = pwiPagoProveedores.PagoProveedores_obtenerUltimoNroPago(My.Settings.cadena, "ppr_nropago")
                NroPago = dtaux.Tables(0).Rows(0)("ultimo")
                '-------Armo el dataset de pagosproveedores y pagosproveedores_detalles
                dtPagosProv.Tables(0).Rows.Add()
                dtPagosProv.Tables(0).Rows(0).Item("ppr_idpago") = -1
                dtPagosProv.Tables(0).Rows(0).Item("ppr_fecpago") = Me.dtFecPago.Value
                dtPagosProv.Tables(0).Rows(0).Item("ppr_codprov") = nroprovee
                dtPagosProv.Tables(0).Rows(0).Item("ppr_idusuario") = 1
                dtPagosProv.Tables(0).Rows(0).Item("ppr_comprobante") = "P"
                dtPagosProv.Tables(0).Rows(0).Item("ppr_impoefectivo") = Me.txtefectivo.Text
                dtPagosProv.Tables(0).Rows(0).Item("ppr_impocheques") = Me.txtcheques.Text
                dtPagosProv.Tables(0).Rows(0).Item("ppr_saldopagoant") = Me.lblSaldoafavor.Text
                dtPagosProv.Tables(0).Rows(0).Item("ppr_saldopagoprox") = Me.lblResto.Text
                dtPagosProv.Tables(0).Rows(0).Item("ppr_bonificaciones") = Me.TextBo.Text
                dtPagosProv.Tables(0).Rows(0).Item("ppr_otrosconceptos") = Me.TextOC.Text
                dtPagosProv.Tables(0).Rows(0).Item("ppr_depopago") = Me.txtdeposito.Text
                dtPagosProv.Tables(0).Rows(0).Item("ppr_impototal") = Me.TextTotalPagado.Text
                If Me.comboEstado.Text = "Abierto" Then
                    dtPagosProv.Tables(0).Rows(0).Item("ppr_estado") = "A"
                Else
                    dtPagosProv.Tables(0).Rows(0).Item("ppr_estado") = "C"
                End If
                dtPagosProv.Tables(0).Rows(0).Item("ppr_nropago") = NroPago
                dtPagosProv.Tables(0).Rows(0).Item("ppr_observaciones") = Me.txtobservaciones.Text
                '----------------------------------------------------------------------------

                Dim auxrow As DataRow
                For Each row As DataGridViewRow In DataFactuAPagar.Rows

                    If Not IsNothing(row.Cells("nrofac").Value) Then


                        auxrow = dtPagosProvDet.Tables(0).NewRow
                        auxrow("ppd_iddet") = -1
                        auxrow("ppd_idCompra") = row.Cells("idcom").Value
                        auxrow("ppd_tipfac") = row.Cells("tipofac").Value
                        auxrow("ppd_nrofac") = row.Cells("nrofac").Value
                        auxrow("ppd_totalfac") = row.Cells("monto").Value
                        auxrow("ppd_deposito") = "CASA CENTRAL"
                        auxrow("ppd_feccom") = Now
                        auxrow("ppd_nropago") = NroPago
                        dtPagosProvDet.Tables(0).Rows.Add(auxrow)
                    End If
                Next

                '----------------------------------------------------------------------------

                'GuardarPagoProveedores(nropagonuevo, Bonificacion, tchp, TchTer, Tefe, factuapagar, exito, Pagado, apagar, resto, FormPagosProveedores, nroprovee, Val(TextBoni.Text), nroprovee, CR, Totrospagos, otrosconceptos, nropagoprovenuevo, TotalaPagar, pagadoimpre, idsoc, Depopago)
                exito = False
                pwiPagoProveedores.PagoProveedores_GuardarPago(dtBon, dtCheques, dtEfectivo, dtFacaPagar, exito, dtPagosProv, dtPagosProvDet, dtDeposito, DtOc, My.Settings.cadena, nroprovee, NroPago)

                MsgBox("El pago nro. " & NroPago & " se guardó con exito", vbOKOnly, "Aviso al operador")
                Me.Close()

            End If

            Else
                MsgBox("No puede dejar el ESTADO del pago en blanco")
                Exit Sub
            End If
            'MsgBox("No hay facturas cargadas para el pago. " & Chr(13) & "Cargue una factura y vuelva a intentarlo.")
            'End If

    End Sub

    
   
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim indice As String
        Dim saldo As Double
        Dim tipo As String

        If DataGridFacturasPendientes.CurrentCell.Selected = True Then
            indice = DataGridFacturasPendientes.CurrentRow.Index.ToString
            saldo = DataGridFacturasPendientes.CurrentRow.Cells(4).Value
            dtFacaPagar.Tables(0).ImportRow(dtFacPend.Tables(0).Rows(indice))
            dtFacPend.Tables(0).Rows(indice).Delete()
            CargarGrillaFacturasPendientes(dtFacPend)
            CargarGrillaFacturasaPagar(dtFacaPagar)
            ActualizarSaldosFactu(saldo)
            ActualizarMontosTotales()
        Else
            MsgBox("Seleccione una fila válida", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Aviso")
        End If

    End Sub

    Private Sub CargarGrillaFacturasaPagar(dt As DataSet)

        Dim lngNroError As Long

        Try
            lngNroError = 0
            DataFactuAPagar.Rows.Clear()
            For Each row In dt.Tables(0).Rows
                DataFactuAPagar.Rows.Add(row("idcompra"), row("nrofactura"), row("codigo"), row("fecha"), row("saldo"))
            Next


        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try

    End Sub
    Private Sub CargarGrillaFacturasPagoAbierto(dt As DataSet)

        Dim lngNroError As Long

        Try
            lngNroError = 0
            DataFactuAPagar.Rows.Clear()
            For Each row In dt.Tables(0).Rows
                DataFactuAPagar.Rows.Add(row("ppd_idcompra"), row("ppd_nrofac"), row("ppd_tipfac"), row("ppd_feccom"), row("ppd_totalfac"))
                Me.TextTotFact.Text = CDbl(Me.TextTotFact.Text) + row("ppd_totalfac")
            Next


        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try

    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Dim indice As String
        Dim dblsaldo As Double
        If DataFactuAPagar.CurrentCell.Selected = True Then
            indice = DataFactuAPagar.CurrentRow.Index.ToString
            dtFacPend.Tables(0).ImportRow(dtFacaPagar.Tables(0).Rows(indice))
            dblsaldo = DataFactuAPagar.CurrentRow.Cells(4).Value
            dtFacaPagar.Tables(0).Rows(indice).Delete()
            CargarGrillaFacturasPendientes(dtFacPend)
            CargarGrillaFacturasaPagar(dtFacaPagar)
            ActualizarSaldosFactu(-dblsaldo)
            ActualizarMontosTotales()
        Else
            MsgBox("Seleccione una fila válida", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Public Sub ActualizarMontosTotales()
        Dim resto As Double
        Me.TextTotalPagado.Text = CDbl(Me.txtcheques.Text) + CDbl(Me.txtefectivo.Text) + CDbl(Me.txtdeposito.Text)
        resto = FormatNumber(CDbl(Me.TextTotalPagado.Text) - CDbl(Me.TextTotal.Text), 2)
        Me.lblResto.Text = resto
    End Sub

    Public Sub ActualizarSaldosFactu(saldo As Double)

        Me.TextTotFact.Text = FormatNumber(CDbl(TextTotFact.Text) + saldo, 2)
        If CDbl(Me.lblSaldoafavor.Text) < 0 Then
            Me.TextTotal.Text = FormatNumber(CDbl(Me.TextTotFact.Text) - CDbl(Me.TextBon.Text) + CDbl(Me.TextOC.Text) - CDbl(Me.lblSaldoafavor.Text), 2)
        Else
            TextTotal.Text = FormatNumber(CDbl(Me.TextTotFact.Text) - CDbl(Me.TextBon.Text) + Val(Me.TextOC.Text) - CDbl(Me.lblSaldoafavor.Text), 2)
        End If

    End Sub

    Private Sub commandAceptarModificar_Click(sender As Object, e As EventArgs) Handles commandAceptarModificar.Click
        Dim dtaux As New DataSet

        If MsgBox("¿ Desea guardar el pago ? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Aviso al operador") = 6 Then
            If comboEstado.Text <> "" Then

                If Val(Me.lblSaldoafavor.Text) > 0 Then
                    Pagado = FormatNumber(Val(TextTotalPagado.Text) + Val(TextBon.Text) + Val(lblSaldoafavor.Text), 2)
                Else
                    Pagado = FormatNumber(Val(TextTotalPagado.Text) + Val(TextBon.Text), 2)
                End If

                aPagar = FormatNumber(Val(TextTotFact.Text) + Val(TextOC.Text), 2)
                resto = FormatNumber(Pagado - aPagar, 2)
                '----------------------------------------------------------------------

                '-------Armo el dataset de pagosproveedores y pagosproveedores_detalles
                dtPagosProv.Tables(0).Rows(0).Item("ppr_idpago") = -1
                dtPagosProv.Tables(0).Rows(0).Item("ppr_fecpago") = Me.dtFecPago.Value
                dtPagosProv.Tables(0).Rows(0).Item("ppr_codprov") = nroprovee
                dtPagosProv.Tables(0).Rows(0).Item("ppr_idusuario") = 1
                dtPagosProv.Tables(0).Rows(0).Item("ppr_comprobante") = "P"
                dtPagosProv.Tables(0).Rows(0).Item("ppr_impoefectivo") = Me.txtefectivo.Text
                dtPagosProv.Tables(0).Rows(0).Item("ppr_impocheques") = Me.txtcheques.Text
                dtPagosProv.Tables(0).Rows(0).Item("ppr_saldopagoant") = Me.lblSaldoafavor.Text
                dtPagosProv.Tables(0).Rows(0).Item("ppr_saldopagoprox") = Me.lblResto.Text
                dtPagosProv.Tables(0).Rows(0).Item("ppr_bonificaciones") = Me.TextBo.Text
                dtPagosProv.Tables(0).Rows(0).Item("ppr_otrosconceptos") = Me.TextOC.Text
                dtPagosProv.Tables(0).Rows(0).Item("ppr_depopago") = Me.txtdeposito.Text
                dtPagosProv.Tables(0).Rows(0).Item("ppr_impototal") = Me.TextTotalPagado.Text
                If Me.comboEstado.Text = "Abierto" Then
                    dtPagosProv.Tables(0).Rows(0).Item("ppr_estado") = "A"
                Else
                    dtPagosProv.Tables(0).Rows(0).Item("ppr_estado") = "C"
                End If
                dtPagosProv.Tables(0).Rows(0).Item("ppr_nropago") = NroPago
                dtPagosProv.Tables(0).Rows(0).Item("ppr_observaciones") = Me.txtobservaciones.Text
                '----------------------------------------------------------------------------
                'piso para reasignar el dataset
                dtPagosProvDet = pwiPagoProveedores.PagoProveedoresDetalles_obtenerRegistro(My.Settings.cadena, -1)
                '----------------------------------------------------------------------------
                Dim auxrow As DataRow
                For Each row As DataGridViewRow In DataFactuAPagar.Rows

                    If Not IsNothing(row.Cells("nrofac").Value) Then


                        auxrow = dtPagosProvDet.Tables(0).NewRow
                        auxrow("ppd_iddet") = -1
                        auxrow("ppd_idCompra") = row.Cells("idcom").Value
                        auxrow("ppd_tipfac") = row.Cells("tipofac").Value
                        auxrow("ppd_nrofac") = row.Cells("nrofac").Value
                        auxrow("ppd_totalfac") = row.Cells("monto").Value
                        auxrow("ppd_deposito") = "CASA CENTRAL"
                        auxrow("ppd_feccom") = Now
                        auxrow("ppd_nropago") = NroPago
                        dtPagosProvDet.Tables(0).Rows.Add(auxrow)
                    End If
                Next

                '----------------------------------------------------------------------------

                'GuardarPagoProveedores(nropagonuevo, Bonificacion, tchp, TchTer, Tefe, factuapagar, exito, Pagado, apagar, resto, FormPagosProveedores, nroprovee, Val(TextBoni.Text), nroprovee, CR, Totrospagos, otrosconceptos, nropagoprovenuevo, TotalaPagar, pagadoimpre, idsoc, Depopago)
                exito = False
                pwiPagoProveedores.PagoProveedores_ModificarPago(dtBon, dtCheques, dtEfectivo, dtFacaPagar, exito, dtPagosProv, dtPagosProvDet, dtDeposito, DtOc, My.Settings.cadena, nroprovee)

                MsgBox("El pago nro. " & NroPago & " se guardó con exito", vbOKOnly, "Aviso al operador")
                Me.Close()

            End If

        Else
            MsgBox("No puede dejar el ESTADO del pago en blanco")
            Exit Sub
        End If
        'MsgBox("No hay facturas cargadas para el pago. " & Chr(13) & "Cargue una factura y vuelva a intentarlo.")
        'End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        If MsgBox("¿Desea salir sin grabar?", MsgBoxStyle.Information + vbYesNoCancel, "Aviso al operador") = 6 Then
            Me.Close()
        End If
    End Sub
End Class