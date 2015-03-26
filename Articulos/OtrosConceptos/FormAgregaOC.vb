Imports System.Globalization
Public Class FormAgregaOC
    Dim dt As New DataSet
    Dim lngNroProve As Integer
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgBox("¿Desea cancelar la carga del concepto?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = vbYes Then
            Me.Close()
        End If
    End Sub

    Public Sub AbrirOc(nroPago As Integer, idProveedor As Integer, ByRef dataOc As DataSet)
        Me.LblNroPago.Text = nroPago
        lngNroProve = idProveedor
        Me.txtdescriOc.Text = ""
        Me.txtmontoOc.Value = 0
        dt = dataOc
        Me.ShowDialog()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim auxDt As New DataSet
        If ValidarCampos() Then
            If MsgBox("¿Desea guardar el concepto?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = vbYes Then
                dt.Tables(0).Rows.Add()
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("orden") = dt.Tables(0).Rows.Count - 1
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("poc_id") = -1
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("poc_fecha") = CDate(Now)
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("poc_idprove") = lngNroProve
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("poc_descripcion") = Me.txtdescriOc.Text
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("poc_monto") = CDbl(Me.txtmontoOc.Value)
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("poc_comprobante") = "O"
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("poc_nropago") = CInt(Me.LblNroPago.Text)
                Me.Close()
            End If
        End If
    End Sub
    Private Function ValidarCampos() As Boolean
        ValidarCampos = True
        If Me.txtmontoOc.Value = 0 Then
            MsgBox("Ingrese el monto", vbOKOnly, "Aviso al operador")
            Me.txtmontoOc.Focus()
            ValidarCampos = False
            Exit Function
        End If
    End Function

    Private Sub txtdescriOc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescriOc.KeyPress
       
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdescriOc_TextChanged(sender As Object, e As EventArgs) Handles txtdescriOc.TextChanged

    End Sub

    Private Sub txtmontoOc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmontoOc.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtmontoOc_TextChanged(sender As Object, e As EventArgs) Handles txtmontoOc.TextChanged

    End Sub

    Private Sub FormAgregaOC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class