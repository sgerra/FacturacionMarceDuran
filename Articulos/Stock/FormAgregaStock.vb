Public Class FormAgregaStock
    Dim dstDepositos As DataSet
    Dim dsStockDepo As New DataSet
    Dim lngCodart As Integer
    Private Sub FormAgregaStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Abrir(ByRef dsStock As DataSet, codart As Integer)
        dstDepositos = pwiStock.Depositos_obtenerLista(My.Settings.cadena)
        Cargar_Combobox(dstDepositos.Tables(0), cmbDepositos)
        dsStockDepo = dsStock
        lngCodart = codart
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If MsgBox("¿Desea guardar los datos de stock?", vbInformation + vbYesNoCancel, "Aviso al operador") = MsgBoxResult.Yes Then

            dsStockDepo.Tables(0).Rows.Add()
            dsStockDepo.Tables(0).Rows(dsStockDepo.Tables(0).Rows.Count - 1)("iddeposito") = cmbDepositos.SelectedValue
            dsStockDepo.Tables(0).Rows(dsStockDepo.Tables(0).Rows.Count - 1)("deposito") = cmbDepositos.Text
            dsStockDepo.Tables(0).Rows(dsStockDepo.Tables(0).Rows.Count - 1)("codart") = lngcodart
            dsStockDepo.Tables(0).Rows(dsStockDepo.Tables(0).Rows.Count - 1)("stockinicial") = Me.txtStkIni.Value
            dsStockDepo.Tables(0).Rows(dsStockDepo.Tables(0).Rows.Count - 1)("stockactual") = Me.txtStkAct.Value
            dsStockDepo.Tables(0).Rows(dsStockDepo.Tables(0).Rows.Count - 1)("stockminimo") = Me.txtStkMin.Value
            dsStockDepo.Tables(0).Rows(dsStockDepo.Tables(0).Rows.Count - 1)("stockmaximo") = Me.txtStkMax.Value
            dsStockDepo.Tables(0).Rows(dsStockDepo.Tables(0).Rows.Count - 1)("fechainv") = Me.dtFecinv.Value
            dsStockDepo.Tables(0).Rows(dsStockDepo.Tables(0).Rows.Count - 1)("iddeposito1") = cmbDepositos.SelectedValue
            dsStockDepo.Tables(0).Rows(dsStockDepo.Tables(0).Rows.Count - 1)("comentario") = cmbDepositos.Text
            dsStockDepo.Tables(0).Rows(dsStockDepo.Tables(0).Rows.Count - 1)("sociedad") = idsociedad
            dsStockDepo.Tables(0).Rows(dsStockDepo.Tables(0).Rows.Count - 1)("eliminado") = 0
            MsgBox("El registro se guardó con éxito", vbInformation + vbOKOnly, "Aviso al operador")
            Me.Close()

        End If
    End Sub

    Private Sub cmbDepositos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbDepositos.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbDepositos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDepositos.SelectedIndexChanged

    End Sub

    Private Sub txtStkIni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStkIni.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtStkIni_TextChanged(sender As Object, e As EventArgs) Handles txtStkIni.TextChanged

    End Sub

    Private Sub txtStkMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStkMax.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtStkMax_TextChanged(sender As Object, e As EventArgs) Handles txtStkMax.TextChanged

    End Sub

    Private Sub txtStkMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStkMin.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtStkMin_TextChanged(sender As Object, e As EventArgs) Handles txtStkMin.TextChanged

    End Sub

    Private Sub txtStkAct_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStkAct.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtStkAct_TextChanged(sender As Object, e As EventArgs) Handles txtStkAct.TextChanged

    End Sub

    Private Sub dtFecinv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtFecinv.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub dtFecinv_ValueChanged(sender As Object, e As EventArgs) Handles dtFecinv.ValueChanged

    End Sub
End Class