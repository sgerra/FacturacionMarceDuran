Public Class FormAgregaBoni
    Dim dt As New DataSet
    Dim lngNroProve As Integer
    Private Sub FormAgregaBoni_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgBox("¿Desea cancelar la carga de la bonificación?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = vbYes Then
            Me.Close()
        End If
    End Sub

    Public Sub AbrirBoni(nroPago As Integer, idProveedor As Integer, ByRef dataB As DataSet)
        Me.LblNroPago.Text = nroPago
        lngNroProve = idProveedor
        Me.txtdescriBon.Text = ""
        Me.txtMontoBon.Value = 0
        Me.txtNroBon.Text = ""
        dt = dataB
        Me.ShowDialog()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim auxDt As New DataSet
        If validarCampos Then
            If MsgBox("¿Desea guardar la bonificación?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = vbYes Then
                dt.Tables(0).Rows.Add()
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("orden") = dt.Tables(0).Rows.Count - 1
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("bon_idbon") = -1
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("bon_fecha") = CDate(Now)
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("bon_nrobon") = Me.txtNroBon.Text
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("bon_nroprove") = lngNroProve
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("bon_concepto") = Me.txtdescriBon.Text
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("bon_monto") = CDbl(Me.txtMontoBon.Value)
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("bon_comprobante") = "B"
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("bon_usada") = 1
                dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("bon_nropago") = LblNroPago.Text
                Me.Close()

            End If
        End If
    End Sub
    Private Function ValidarCampos() As Boolean
        ValidarCampos = True
        If Me.txtNroBon.Text = "" Then
            MsgBox("Ingrese el número de bonificación", vbOKOnly, "Aviso al operador")
            Me.txtNroBon.Focus()
            ValidarCampos = False
            Exit Function
        End If

        If Me.txtdescriBon.Text = "" Then
            MsgBox("Ingrese la descripción de la bonificación", vbOKOnly, "Aviso al operador")
            Me.txtdescriBon.Focus()
            ValidarCampos = False
            Exit Function
        End If

        If Me.txtMontoBon.Value = 0 Then
            MsgBox("Ingrese el monto de la bonificación", vbOKOnly, "Aviso al operador")
            Me.txtMontoBon.Focus()
            ValidarCampos = False
            Exit Function
        End If


    End Function

    Private Sub txtNroBon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNroBon.KeyPress
       
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtNroBon_TextChanged(sender As Object, e As EventArgs) Handles txtNroBon.TextChanged

    End Sub

    Private Sub txtdescriBon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescriBon.KeyPress
        
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtdescriBon_TextChanged(sender As Object, e As EventArgs) Handles txtdescriBon.TextChanged

    End Sub

    Private Sub txtMontoBon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontoBon.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtMontoBon_TextChanged(sender As Object, e As EventArgs) Handles txtMontoBon.TextChanged

    End Sub
End Class