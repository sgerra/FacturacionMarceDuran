Public Class FormAgregaDeposito
    Dim dt As New DataSet
    Dim lngNroPago As Integer
    Public Sub AbrirDeposito(nroPago As Integer, idProveedor As Integer, ByRef dataD As DataSet)
        Dim dtBancos As New DataSet
        Dim dtAux As New DataTable
        dt = dataD
        Me.txtnroboleta.Text = ""
        Me.txtmonto.Value = 0
        lngNroPago = nroPago
        dtBancos = pwiCheques.wflPagosProveedores_BancosVigentes(My.Settings.cadena)
        dtAux = dtBancos.Tables(0)
        If dtAux.Rows.Count > 0 Then
            cmbBanco.DataSource = dtAux
            cmbBanco.ValueMember = dtAux.Columns(0).ToString()
            cmbBanco.DisplayMember = dtAux.Columns(1).ToString()
        End If
        Me.Refresh()
        Me.ShowDialog()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim auxDt As New DataSet
        If ValidarCampos Then
            If MsgBox("¿Desea guardar el depósito?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = vbYes Then
                dt.Tables(0).Rows.Add()
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("orden") = dt.Tables(0).Rows.Count - 1
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("dep_id") = -1
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("dep_fecha") = Me.dtFecha.Value
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("dep_idbanco") = cmbBanco.SelectedValue
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("dep_nroboleta") = CInt(Me.txtnroboleta.Text)
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("dep_totaldepo") = CDbl(Me.txtmonto.Value)
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("dep_nropago") = lngNroPago
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("banconombre") = cmbBanco.Text
                Me.Close()
            End If
        End If
    End Sub
    Private Function ValidarCampos() As Boolean
        ValidarCampos = True
        If Me.txtnroboleta.Text = "" Then
            MsgBox("Ingrese el número de boleta", vbOKOnly, "Aviso al operador")
            Me.txtnroboleta.Focus()
            ValidarCampos = False
            Exit Function
        End If

        If Me.txtmonto.Value = 0 Then
            MsgBox("Ingrese el monto del depósito", vbOKOnly, "Aviso al operador")
            Me.txtnroboleta.Focus()
            ValidarCampos = False
            Exit Function
        End If
    End Function
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgBox("¿Desea cancelar la carga del depósito?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtmonto_GotFocus(sender As Object, e As EventArgs) Handles txtmonto.GotFocus
        Me.txtmonto.SelectionStart = 0
        Me.txtmonto.SelectionLength = Len(Me.txtmonto.Text)
    End Sub

    Private Sub txtmonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmonto.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtmonto_TextChanged(sender As Object, e As EventArgs) Handles txtmonto.TextChanged

    End Sub

    Private Sub dtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtFecha.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbBanco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbBanco.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    
    Private Sub cmbBanco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBanco.SelectedIndexChanged

    End Sub

    Private Sub txtnroboleta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnroboleta.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtnroboleta_TextChanged(sender As Object, e As EventArgs) Handles txtnroboleta.TextChanged

    End Sub
End Class