Public Class FormAgregaEfectivo
    Dim dt As New DataSet
    Dim lngNroPago As Integer
    Public Sub AbrirEfectivo(nroPago As Integer, idProveedor As Integer, ByRef dataEf As DataSet)
        Dim dtMoneda As New DataSet
        Dim dtAux As New DataTable
        Dim dtMonedas As New DataSet
        lngNroPago = nroPago

        Me.txtmonto.Value = 0
        dt = dataEf
        dtMonedas = pwiEfectivo.wflPagosProveedores_obtenerMonedas(My.Settings.cadena)
        dtAux = dtMonedas.Tables(0)
        If dtAux.Rows.Count > 0 Then
            cmbMoneda.DataSource = dtAux
            cmbMoneda.ValueMember = dtAux.Columns(0).ToString()
            cmbMoneda.DisplayMember = dtAux.Columns(1).ToString()
        End If
        Me.ShowDialog()
    End Sub

    Private Sub FormAgregaEfectivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgBox("¿Desea cancelar la carga del efectivo?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim auxDt As New DataSet
        If validarcampos Then
            If MsgBox("¿Desea guardar el efectivo?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = vbYes Then
                dt.Tables(0).Rows.Add()
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("orden") = dt.Tables(0).Rows.Count - 1
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("pde_idpde") = -1
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("pde_tpoMoneda") = cmbMoneda.SelectedValue
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("pde_monto") = CDbl(Me.txtmonto.Value)
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("pde_nropago") = lngNroPago
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("nombremoneda") = cmbMoneda.Text
                Me.Close()

            End If
        End If
    End Sub
    Private Function ValidarCampos() As Boolean
        ValidarCampos = True
        If Me.txtmonto.Value = 0 Then
            MsgBox("Ingrese el monto en efectivo", vbOKOnly, "Aviso al operador")
            Me.txtmonto.Focus()
            ValidarCampos = False
            Exit Function
        End If
    End Function

    Private Sub cmbMoneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbMoneda.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMoneda.SelectedIndexChanged
    
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
End Class