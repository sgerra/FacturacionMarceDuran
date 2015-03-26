Public Class FormAgregaCheques
    Dim dt As New DataSet
    Dim lngNroPago As Integer

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim auxDt As New DataSet
        If validarcampos Then
            If MsgBox("¿Desea guardar el cheque?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = vbYes Then
                dt.Tables(0).Rows.Add()
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("orden") = dt.Tables(0).Rows.Count - 1
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("pcp_idpcp") = -1
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("pcp_nrocheque") = Me.txtNrocheque.Text
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("pcp_fecemi") = Me.dtFecEmi.Text
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("pcp_fecpago") = Me.dtFecPago.Text
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("pcp_banco") = cmbBanco.SelectedValue
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("pcp_monto") = CDbl(Me.txtMonto.Value)
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("pcp_soc_id") = 0
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("pcp_nropago") = lngNroPago
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("pcp_origen") = IIf(cmbOrigen.Text = "Propio", "P", "T")
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("banconombre") = cmbBanco.Text
                Me.Close()
            End If
        End If
    End Sub
    Private Function ValidarCampos() As Boolean
        ValidarCampos = True
        If Me.txtNrocheque.Text = "" Then
            MsgBox("Ingrese el número de cheque", vbOKOnly, "Aviso al operador")
            Me.txtNrocheque.Focus()
            ValidarCampos = False
            Exit Function
        End If

        If Me.txtmonto.Value = 0 Then
            MsgBox("Ingrese el monto del cheque", vbOKOnly, "Aviso al operador")
            Me.txtMonto.Focus()
            ValidarCampos = False
            Exit Function
        End If

        If Me.cmbOrigen.Text = "" Then
            MsgBox("Ingrese el origen del cheque", vbOKOnly, "Aviso al operador")
            Me.cmbOrigen.Focus()
            ValidarCampos = False
            Exit Function
        End If

        If Me.cmbBanco.Text = "" Then
            MsgBox("Ingrese el banco del cheque", vbOKOnly, "Aviso al operador")
            Me.cmbBanco.Focus()
            ValidarCampos = False
            Exit Function
        End If

    End Function
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgBox("¿Desea cancelar la carga del cheque?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = vbYes Then
            Me.Close()
        End If
    End Sub

    Public Sub AbrirCheques(nroPago As Integer, idProveedor As Integer, ByRef dataC As DataSet)
        Dim dtBancos As New DataSet
        Dim dtAux As New DataTable
        lngNroPago = nroPago
        Me.txtNrocheque.Text = ""
        Me.txtMonto.Value = 0
        dt = dataC
        dtBancos = pwiCheques.wflPagosProveedores_BancosVigentes(My.Settings.cadena)
        dtAux = dtBancos.Tables(0)
        If dtAux.Rows.Count > 0 Then
            cmbBanco.DataSource = dtAux
            cmbBanco.ValueMember = dtAux.Columns(0).ToString()
            cmbBanco.DisplayMember = dtAux.Columns(1).ToString()
        End If
        Me.ShowDialog()
    End Sub

    Private Sub FormAgregaCheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNrocheque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNrocheque.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtNrocheque_TextChanged(sender As Object, e As EventArgs) Handles txtNrocheque.TextChanged

    End Sub

    Private Sub dtFecEmi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtFecEmi.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub dtFecEmi_ValueChanged(sender As Object, e As EventArgs) Handles dtFecEmi.ValueChanged

    End Sub

    Private Sub dtFecPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtFecPago.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub dtFecPago_ValueChanged(sender As Object, e As EventArgs) Handles dtFecPago.ValueChanged

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

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtMonto_TextChanged(sender As Object, e As EventArgs) Handles txtMonto.TextChanged

    End Sub

    Private Sub cmbOrigen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbOrigen.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOrigen.SelectedIndexChanged

    End Sub

    Private Sub btnAceptar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnAceptar.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class