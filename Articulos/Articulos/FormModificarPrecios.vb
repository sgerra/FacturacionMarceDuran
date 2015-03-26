Public Class FormModificarPrecios
    Dim dstListasPrecios As New DataSet
    Dim dtListas As DataTable
    Dim idListaSele
    Public Sub Abrir(idlista As Integer, pcompra As Double, porcIva As Double, montoIva As Double, porcDto As Double, _
                     montodto As Double, porcPercep As Double, MontoPercep As Double, PSubtotal As Double, _
                     porcUtil As Double, MontoUtil As Double, PrecioVenta As Double, dtlistasP As DataTable, dstListasPre As DataSet)
        Cargar_Combobox(dtlistasP, cmbListas)
        cmbListas.SelectedValue = idlista
        Me.txtPC.Value = pcompra
        Me.txtPorcIva.Value = porcIva
        Me.txtMontoIva.Value = montoIva
        Me.txtporcdesc.Value = porcDto
        Me.txtmontoDesc.Value = montodto
        Me.txtPorcPercep.Value = porcPercep
        Me.txtMontoPercep.Value = MontoPercep
        Me.txtPrecioSubtotal.Value = PSubtotal
        Me.txtPorcUtil.Value = porcUtil
        Me.txtMontoUtil.Value = MontoUtil
        Me.txtPv.Value = PrecioVenta
        dtListas = dtlistasP
        dstListasPrecios = dstListasPre
        idListaSele = idlista
        Me.ShowDialog()
    End Sub
    Public Shared Function Cargar_Combobox(ByVal dt As DataTable, ByRef cbx As Windows.Forms.ComboBox)
        If dt.Rows.Count > 0 Then
            cbx.DataSource = dt
            cbx.ValueMember = dt.Columns(0).ToString()
            cbx.DisplayMember = dt.Columns(1).ToString()
        End If
        Return Nothing
    End Function

    Private Sub cmbListas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbListas.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub CalcularPrecios()
        Dim PrecioAux As Double


        '----------------Monto de IVA

        Me.txtMontoIva.Value = FormatNumber((CDbl(Me.txtPC.Value) * CDbl(txtPorcIva.Value)) / 100, 2)

        '---------------- Monto Descuento

        Me.txtmontoDesc.Value = FormatNumber((CDbl(Me.txtPC.Value) + CDbl(Me.txtMontoIva.Value)) * (CDbl(Me.txtporcdesc.Value) / 100), 2)

        '----------------Precio auxiliar: Precio de costo + iva - descuento-------
        PrecioAux = (CDbl(Me.txtPC.Value) + CDbl(Me.txtMontoIva.Value) - CDbl(Me.txtmontoDesc.Value))

        '---------------------Hallo la percepcion--------------------

        Me.txtMontoPercep.Value = FormatNumber(PrecioAux * (CDbl(txtPorcPercep.Value) / 100), 2)

        '---------------Encuentro el subtotal
        Me.txtPrecioSubtotal.Value = PrecioAux + CDbl(Me.txtMontoPercep.Value)

        '------------Le aplico la utilidad

        Me.txtMontoUtil.Value = FormatNumber(CDbl(Me.txtPrecioSubtotal.Value) * (CDbl(Me.txtPorcUtil.Value) / 100), 2)

        '------------------------------------------
        Me.txtPv.Value = CDbl(Me.txtPrecioSubtotal.Value) + CDbl(Me.txtMontoUtil.Value)

        '---------------------------------------------------------------------------

    End Sub

    Private Sub txtPC_TextChanged(sender As Object, e As EventArgs) Handles txtPC.TextChanged
        CalcularPrecios()
    End Sub

    Private Sub txtPorcIva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorcIva.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPorcIva_TextChanged(sender As Object, e As EventArgs) Handles txtPorcIva.TextChanged
        CalcularPrecios()
    End Sub

    Private Sub txtMontoIva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontoIva.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtMontoIva_TextChanged(sender As Object, e As EventArgs) Handles txtMontoIva.TextChanged
        CalcularPrecios()
    End Sub

    Private Sub txtporcdesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtporcdesc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtporcdesc_TextChanged(sender As Object, e As EventArgs) Handles txtporcdesc.TextChanged
        CalcularPrecios()
    End Sub

    Private Sub txtmontoDesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmontoDesc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtmontoDesc_TextChanged(sender As Object, e As EventArgs) Handles txtmontoDesc.TextChanged
        CalcularPrecios()
    End Sub

    Private Sub txtPorcPercep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorcPercep.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPorcPercep_TextChanged(sender As Object, e As EventArgs) Handles txtPorcPercep.TextChanged
        CalcularPrecios()
    End Sub

    Private Sub txtMontoPercep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontoPercep.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtMontoPercep_TextChanged(sender As Object, e As EventArgs) Handles txtMontoPercep.TextChanged
        CalcularPrecios()
    End Sub

    Private Sub txtPrecioSubtotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioSubtotal.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPrecioSubtotal_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioSubtotal.TextChanged
        CalcularPrecios()
    End Sub

    Private Sub txtPorcUtil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorcUtil.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPorcUtil_TextChanged(sender As Object, e As EventArgs) Handles txtPorcUtil.TextChanged
        CalcularPrecios()
    End Sub

    Private Sub txtMontoUtil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontoUtil.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtMontoUtil_TextChanged(sender As Object, e As EventArgs) Handles txtMontoUtil.TextChanged
        CalcularPrecios()
    End Sub

    Private Sub txtPv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPv.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPv_TextChanged(sender As Object, e As EventArgs) Handles txtPv.TextChanged
        CalcularPrecios()
    End Sub


    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If MsgBox("¿Desea guardar los datos?", vbYesNoCancel + vbInformation, "Aviso al operador") = MsgBoxResult.Yes Then


            For i = 0 To dstListasPrecios.Tables(0).Rows.Count - 2

                If dstListasPrecios.Tables(0).Rows(i)("lpr_id") = idListaSele Then

                    dstListasPrecios.Tables(0).Rows(i)("lpr_descripcion") = cmbListas.Text
                    dstListasPrecios.Tables(0).Rows(i)("lpd_lpr_id") = cmbListas.SelectedValue
                    dstListasPrecios.Tables(0).Rows(i)("lpd_art_codart") = -1
                    dstListasPrecios.Tables(0).Rows(i)("lpd_precioc") = CDbl(txtPC.Value)
                    dstListasPrecios.Tables(0).Rows(i)("lpd_porcdesc") = CDbl(Me.txtporcdesc.Value)
                    dstListasPrecios.Tables(0).Rows(i)("lpd_montodesc") = CDbl(Me.txtmontoDesc.Value)
                    dstListasPrecios.Tables(0).Rows(i)("lpd_porcpercep") = CDbl(Me.txtPorcPercep.Value)
                    dstListasPrecios.Tables(0).Rows(i)("lpd_montopercep") = CDbl(Me.txtMontoPercep.Value)
                    dstListasPrecios.Tables(0).Rows(i)("lpd_preciosubtotal") = CDbl(Me.txtPrecioSubtotal.Value)
                    dstListasPrecios.Tables(0).Rows(i)("lpd_porcutil") = CDbl(Me.txtPorcUtil.Value)
                    dstListasPrecios.Tables(0).Rows(i)("lpd_utilidad") = CDbl(Me.txtMontoUtil.Value)
                    dstListasPrecios.Tables(0).Rows(i)("lpd_porciva") = CDbl(Me.txtPorcIva.Value)
                    dstListasPrecios.Tables(0).Rows(i)("lpd_montoiva") = CDbl(Me.txtMontoIva.Value)
                    dstListasPrecios.Tables(0).Rows(i)("lpd_preciovta") = CDbl(Me.txtPv.Value)
                    dstListasPrecios.Tables(0).Rows(i)("lpd_fecmodipr") = CDate(Now)
                    dstListasPrecios.Tables(0).Rows(i)("lpd_idusuario") = idUsuario
                    dstListasPrecios.Tables(0).Rows(i)("lpd_modificado") = "S"
                    dstListasPrecios.Tables(0).Rows(i)("eliminado") = "N"
                    MsgBox("Los datos se guardaron con éxito", vbOK + vbInformation, "Aviso al operador")
                    Me.Close()
                End If
            Next
        End If

    End Sub
    Private Sub cmbListas_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbListas.SelectionChangeCommitted

        For Each dr As DataRow In dtListas.Rows
            If dr("lpr_id") = cmbListas.SelectedValue Then
                Me.txtPorcUtil.Value = dr("lpr_porcutil")
                Exit For
            End If
        Next

    End Sub

    Private Sub FormModificarPrecios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class