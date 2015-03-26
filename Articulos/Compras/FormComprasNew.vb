Public Class FormComprasNew
    Dim dstArticulos As New DataSet
    Dim dstPedidoDetalle As New DataSet
    Dim strMensaje As String
    Private Sub FormComprasNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dttiposFactura As New DataTable
        Dim dtFormasPagoProv As New DataTable
        Dim dtEstado As New DataTable
        Dim dtProv As New DataTable
        '-------------Cargo los combos de la pantalla con Dataset--------------------------------------------
        dttiposFactura = pwiCompras.wflCompras_tposFactura_obtenerLista(My.Settings.cadena).Tables(0)
        Cargar_Combobox(dttiposFactura, cmbtiposFactura)


        dtFormasPagoProv = pwiCompras.wflCompras_FormasPagoProv_obtenerLista(My.Settings.cadena).Tables(0)
        Cargar_Combobox(dtFormasPagoProv, cmbFormasPAgoProv)

        dtEstado = pwiCompras.wflCompras_TposEstadosFactura_obtenerLista(My.Settings.cadena).Tables(0)
        Cargar_Combobox(dtEstado, cmbEstado)

        dtProv = pwiCompras.wflCompras_Proveedores_obtenerLista(My.Settings.cadena).Tables(0)
        Cargar_Combobox(dtProv, cmbProveedores)
        '------------------------------------------------------------------------------------------------------
        '----------------------------Obtengo la ultima compra del proveedor------------------------------------

        dstPedidoDetalle = pwiCompras.wflComprasDetalles_obtenerRegistro(My.Settings.cadena, -1)
        dstPedidoDetalle.Tables(0).Columns.Add("uni_descripcion")

        Me.txtPbase.Value = 0
        Me.txtIva.Value = 0
        Me.txtPercepIva.Value = 0
        Me.txtIb.Value = 0
        Me.txtDto.Value = 0
        Me.txttotal.Value = 0
        '------------------------------------------------------------------------------------------------------
    End Sub
    Private Sub btnProd_Click(sender As Object, e As EventArgs) Handles btnProd.Click

        Dim auxDt As New DataSet
        auxDt = pwiCompras.wflCompras_obtenerUltimacompra(My.Settings.cadena, Me.cmbProveedores.SelectedValue)

        If Not IsNothing(auxDt) Then
            CargarGrillaUltimo(auxDt)
        End If
        FormAgregaArticulos.Abrir(Me.cmbProveedores.SelectedValue, dstPedidoDetalle)
        CargarGrillaArticulos()
        'VolCarTotales()
    End Sub
    Private Sub VolcarTotales()
        Dim i As Integer
        Dim SumaPbase As Double = 0
        Dim SumaIva As Double = 0
        Dim SumaPercep As Double = 0
        Dim SumaDto As Double = 0

        For i = 0 To GrillaArticulos.Rows.Count - 2
            SumaPbase = SumaPbase + (GrillaArticulos.Rows(i).Cells("Costo").Value) * CDbl(GrillaArticulos.Rows(i).Cells("Cantidad").Value)
            SumaIva = SumaIva + (GrillaArticulos.Rows(i).Cells("iva").Value) * CDbl(GrillaArticulos.Rows(i).Cells("Cantidad").Value)
            SumaPercep = SumaPercep + ((GrillaArticulos.Rows(i).Cells("Percep").Value) * CDbl(GrillaArticulos.Rows(i).Cells("Cantidad").Value))
            SumaDto = SumaDto + ((GrillaArticulos.Rows(i).Cells("dto").Value) * CDbl(GrillaArticulos.Rows(i).Cells("Cantidad").Value))
        Next

        Me.txtPbase.Text = FormatNumber(SumaPbase, 2)
        Me.txtIva.Text = FormatNumber(SumaIva, 2)
        Me.txtPercepIva.Text = FormatNumber(SumaPercep, 2)
        Me.txtDto.Text = FormatNumber(SumaDto, 2)
        ModificarTotales()

    End Sub

    Private Function ModificarTotales()
        Me.txttotal.Value = CDbl(Me.txtPbase.Value) + CDbl(Me.txtIva.Value) + CDbl(Me.txtImpInt.Value) + CDbl(Me.txtPercepIva.Value) + CDbl(Me.txtIb.Value) - CDbl(Me.txtDto.Value)
    End Function
    Private Sub CargarGrillaUltimo(dt As DataSet)

        Dim lngNroError As Long

        Try
            lngNroError = 0
            GrillaUltimo.Rows.Clear()
            For Each row In dt.Tables(0).Rows
                GrillaUltimo.Rows.Add(row("codart"), row("descri"), row("cantidad"), row("uni_descripcion"))

            Next


        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try
    End Sub
    Private Sub CargarGrillaArticulos()

        Dim lngNroError As Long

        Try
            lngNroError = 0
            GrillaArticulos.Rows.Clear()
            For Each row In dstPedidoDetalle.Tables(0).Rows
                GrillaArticulos.Rows.Add(row("codart"), row("descri"), row("punitfinal"), row("cantidad"), row("idunidad"), row("uni_descripcion"), row("total"), row("precio"), row("montoiva"), row("montopercep"), row("montodto"))
            Next

        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim idcompra As Integer
        Dim i As Double
        If MsgBox("¿Desea grabar los datos del pedido?", MsgBoxStyle.YesNo, "Aviso al operador") = MsgBoxResult.Yes Then
            If pwiCompras.wflCompras_insertarRegistro(My.Settings.cadena, GrillaArticulos, Me.cmbFormasPAgoProv.SelectedValue, _
                                                   Me.cmbtiposFactura.SelectedValue, Me.cmbEstado.SelectedValue, _
                                                   Me.cmbProveedores.SelectedValue, strMensaje, Me.txtNroFactura.Text, _
                                                   Me.dtFecha.Value, Me.txtobservaciones.Text, Me.txtPbase.Value, _
                                                   Me.txtIva.Value, Me.txtImpInt.Value, Me.txtPercepIva.Value, _
                                                   Me.txtIb.Value, Me.txtDto.Value, Me.txttotal.Value, CDate(dtmFecEntrega.Value), idcompra) Then
                MsgBox("El pedido se ha grabado con éxito", vbOKOnly, "Aviso al operador")
                If MsgBox("¿Desea imprimir el pedido?", MsgBoxStyle.YesNoCancel, "Aviso al operador") = MsgBoxResult.Yes Then
                    Dim frm As New FormImprimeReporte
                    frm.AbrirFormulario(idcompra)
                End If
                Me.Close()

            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgPregunta("¿Desea cancelar el pedido?") = vbYes Then
            Me.GrillaArticulos.Rows.Clear()
            Me.GrillaUltimo.Rows.Clear()
            Me.Close()
        End If
    End Sub

    '*****************************************TOTAL******************************************************************

    Private Sub txttotal_GotFocus(sender As Object, e As EventArgs)
        Me.txttotal.SelectionStart = 0
        Me.txttotal.SelectionLength = Len(Me.txttotal.Text)
    End Sub

    Private Sub txttotal_KeyPress(sender As Object, e As KeyPressEventArgs)
        
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPbase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPbase.KeyPress
        
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txtIva_GotFocus(sender As Object, e As EventArgs) Handles txtIva.GotFocus
        Me.txtIva.Value = CDbl(Me.txtPbase.Value) * (PorcIva / 100)
    End Sub
    Private Sub txtIva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIva.KeyPress
        
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txtImpInt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImpInt.KeyPress
        
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub
    Private Sub txtPercepIva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPercepIva.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txtIb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIb.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub
    Private Sub txtDto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CalcularTotal()
        Me.txttotal.Value = Me.txtPbase.Value + Me.txtIva.Value + Me.txtImpInt.Value + Me.txtPercepIva.Value + Me.txtIb.Value - Me.txtDto.Value
    End Sub

    Private Sub txtPbase_TextChanged(sender As Object, e As EventArgs) Handles txtPbase.TextChanged
        CalcularTotal()
    End Sub

    Private Sub txtIva_TextChanged(sender As Object, e As EventArgs) Handles txtIva.TextChanged
        CalcularTotal()
    End Sub

    Private Sub txtImpInt_TextChanged(sender As Object, e As EventArgs) Handles txtImpInt.TextChanged
        CalcularTotal()
    End Sub

    Private Sub txtPercepIva_TextChanged(sender As Object, e As EventArgs) Handles txtPercepIva.TextChanged
        CalcularTotal()
    End Sub

    Private Sub txtIb_TextChanged(sender As Object, e As EventArgs) Handles txtIb.TextChanged
        CalcularTotal()
    End Sub

    Private Sub txtDto_TextChanged(sender As Object, e As EventArgs) Handles txtDto.TextChanged
        CalcularTotal()
    End Sub
End Class