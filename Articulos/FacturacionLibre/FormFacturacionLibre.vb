Public Class FormFacturacionLibre
    Dim dstCliSele As New DataSet
    Dim dtCondVta As New DataSet
    Dim dtEstado As New DataSet
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnselecciona_Click(sender As Object, e As EventArgs) Handles btnselecciona.Click
        Dim frm As New FormSeleccionaCliente
        frm.Abrir(dstCliSele)

        If dstCliSele.Tables(0).Rows.Count > 0 Then
            Me.lblCliente.Text = dstCliSele.Tables(0).Rows(0)("cli_razonsocial")
            Me.LblCuit.Text = dstCliSele.Tables(0).Rows(0)("cli_cuit")
            Me.LblIva.Text = dstCliSele.Tables(0).Rows(0)("condicioniva")
        End If
    End Sub

    Private Sub FormFacturacionLibre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtCondVta = pwiFacturacionLibre.wflFacturacionLibre_tCondicionesVenta_obtenerLista(My.Settings.cadena)
        dtEstado = pwiFacturacionLibre.wflFacturacionLibre_TposEstadoFactura_obtenerLista(My.Settings.cadena)
        Cargar_Combobox(dtEstado.Tables(0), cmbEstado)
        Cargar_Combobox(dtCondVta.Tables(0), cmbCondVta)
    End Sub

    Private Sub GrillaArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaArticulos.CellContentClick

    End Sub

    Private Sub GrillaArticulos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaArticulos.CellEndEdit
        Dim dblCantidad As Double
        Dim dblPu As Double

        If e.ColumnIndex = 0 Then
            dblCantidad = GrillaArticulos.CurrentRow.Cells("Cantidad").Value
            If GrillaArticulos.CurrentRow.Cells("pu").Value <> 0 Then
                GrillaArticulos.CurrentRow.Cells("Importe").Value = GrillaArticulos.CurrentRow.Cells("pu").Value * GrillaArticulos.CurrentRow.Cells("cantidad").Value
            End If
        End If

        If e.ColumnIndex = 2 Then
            dblPu = GrillaArticulos.CurrentRow.Cells("pu").Value
            If GrillaArticulos.CurrentRow.Cells("cantidad").Value <> 0 Then
                GrillaArticulos.CurrentRow.Cells("Importe").Value = GrillaArticulos.CurrentRow.Cells("pu").Value * GrillaArticulos.CurrentRow.Cells("cantidad").Value
            End If
        End If

        CalcularTotales()


    End Sub

    Private Sub CalcularTotales()
        Dim dblSumaImpo As Double
        Dim i As Integer

        For i = 0 To GrillaArticulos.Rows.Count - 2
            dblSumaImpo = dblSumaImpo + GrillaArticulos.Rows.Item(i).Cells("Importe").Value
        Next
        '---Ponemos el subtotal recorriendo las filas
        txtSubTotal.Value = dblSumaImpo
        '---Ponemos el subtotal sumando los impuestos
        txtsubTotalI.Value = txtSubTotal.Value + txtimpuestos.Value
        '---Ponemos el IVA
        txtIva.Value = txtsubTotalI.Value * (PorcIva / 100)
        '---Ponemos el TOTAL
        txttotal.Value = txtsubTotalI.Value + txtIva.Value

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgPregunta("¿Desea cancelar la emisión de la factura") = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim graba As Boolean
        Dim Pbase As Double
        Dim DblImpuestos As Double
        Dim MontoIva As Double
        Dim dblSubTotalI As Double
        Dim dblTotal As Double
        Dim dstComprobantesVenta As New DataSet
        Dim dstComprobantesVentaDetalle As New DataSet
        Dim lngIdFactura As Integer

        If MsgPregunta("¿Está seguro de confirmar la factura?") = vbYes Then
            If GrillaArticulos.Rows(0).Cells(0).Value <> "" Then
                graba = False

                Pbase = txtSubTotal.Value
                DblImpuestos = txtimpuestos.Value
                dblSubTotalI = txtsubTotalI.Value
                MontoIva = txtIva.Value
                dblTotal = txttotal.Value

                'Cargo los datos generales del tiquet
                dstComprobantesVenta = pwiFacturacion.wflComprobantesVenta_obtenerRegistro(My.Settings.cadena, -1)
                dstComprobantesVenta.Tables(0).Rows.Add()
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_id") = -1
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_nrocom") = -1
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_tipcom") = 1 'lo fijo poruqe no se elije--Factura "A"
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_idcliente") = dstCliSele.Tables(0).Rows(0)("cli_idcliente")
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_fecha") = dtFechaEmi.Value
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_idcondiva") = dstCliSele.Tables(0).Rows(0)("cli_cativa")
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_pbase") = Pbase
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_porciva") = PorcIva
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_totcom") = dblTotal
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_idusuario") = idUsuario
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_origen") = "I"
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_dto") = 0
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_totaldto") = 0
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_formapago") = 0
                'Campos que agregue para la facturacion libre
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_condicionventa") = Me.cmbCondVta.SelectedValue
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_remito") = Me.txtRemito.Text
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_impuestos") = Me.txtimpuestos.Value
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_subtotalI") = Me.txtsubTotalI.Value
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_montoiva") = Me.txtIva.Value
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_nrofactura") = Me.txtNroFactura.Text
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_pagada") = 0
                dstComprobantesVenta.Tables(0).Rows(0)("cvt_idsucursal") = My.Settings.sucursal


                'Cargo los elementos de la grilla
                dstComprobantesVentaDetalle = pwiFacturacion.wflComprobantesVentaDetalle_obtenerRegistro(My.Settings.cadena, -1)
                Dim j As Integer = 0

                For j = 0 To GrillaArticulos.Rows.Count - 2

                    dstComprobantesVentaDetalle.Tables(0).Rows.Add()
                    dstComprobantesVentaDetalle.Tables(0).Rows(dstComprobantesVentaDetalle.Tables(0).Rows.Count - 1)("cvd_id") = -1
                    dstComprobantesVentaDetalle.Tables(0).Rows(dstComprobantesVentaDetalle.Tables(0).Rows.Count - 1)("cvd_nrocom") = -1
                    dstComprobantesVentaDetalle.Tables(0).Rows(dstComprobantesVentaDetalle.Tables(0).Rows.Count - 1)("cvd_codart") = 0
                    dstComprobantesVentaDetalle.Tables(0).Rows(dstComprobantesVentaDetalle.Tables(0).Rows.Count - 1)("cvd_descart") = GrillaArticulos.Rows(j).Cells("detalle").Value
                    dstComprobantesVentaDetalle.Tables(0).Rows(dstComprobantesVentaDetalle.Tables(0).Rows.Count - 1)("cvd_cantidad") = GrillaArticulos.Rows(j).Cells("cantidad").Value
                    dstComprobantesVentaDetalle.Tables(0).Rows(dstComprobantesVentaDetalle.Tables(0).Rows.Count - 1)("cvd_precunit") = GrillaArticulos.Rows(j).Cells("pu").Value
                    dstComprobantesVentaDetalle.Tables(0).Rows(dstComprobantesVentaDetalle.Tables(0).Rows.Count - 1)("cvd_totart") = GrillaArticulos.Rows(j).Cells("importe").Value
                    dstComprobantesVentaDetalle.Tables(0).Rows(dstComprobantesVentaDetalle.Tables(0).Rows.Count - 1)("cvd_idrubro") = 0

                Next

                graba = pwiFacturacionLibre.wflEmisionFactura_GuardarComprobante(My.Settings.cadena, dstComprobantesVenta, dstComprobantesVentaDetalle, My.Settings.sucursal, lngidFactura)

                If graba Then

                    If MsgBox("¿Desea imprimir la factura?", MsgBoxStyle.YesNoCancel, "Aviso al operador") = MsgBoxResult.Yes Then
                        Dim frm As New FormImprimeFactura
                        frm.AbrirFormulario(lngIdFactura)
                    End If
                    'If Origen = "F" Then
                    '''ImprimirImpresoraComun()
                    'ImprimirTicketFiscal
                    'Else

                    'ImprimirImpresoraComun()
                    'End If
                    'ImprimirFactura
                    'LimpiarCajas()
                    GrillaArticulos.Rows.Clear()
                    LimpiarCampos()
                    FormFacturacionLibre_Load(sender, e)
                    '''''PrepararNuevoTicket()
                End If

            Else
                MsgAtencion("Debe cargar al menos un articulo")
            End If

        End If

    End Sub
    Private Sub LimpiarCampos()
        Me.lblCliente.Text = ""
        Me.LblCuit.Text = ""
        Me.LblIva.Text = ""
        Me.txtNroFactura.Text = ""
        Me.txtRemito.Text = ""
        Me.txtSubTotal.Value = 0
        Me.txtimpuestos.Value = 0
        Me.txtsubTotalI.Value = 0
        Me.txtIva.Value = 0
        Me.txttotal.Value = 0
    End Sub
    Private Sub txtimpuestos_LostFocus(sender As Object, e As EventArgs) Handles txtimpuestos.LostFocus
        CalcularTotales()
    End Sub

    Private Sub txtimpuestos_TextChanged(sender As Object, e As EventArgs) Handles txtimpuestos.TextChanged

    End Sub
End Class