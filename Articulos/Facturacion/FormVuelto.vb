Public Class FormVuelto
    Dim dstFormas As New DataSet
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgPregunta("¿Desea cancelar ?") = vbYes Then
            Me.Close()
        End If
    End Sub

    Public Sub Abrir(dblTotFac As Double)
        dstFormas = pwiFacturacion.obtenerFormasPago(My.Settings.cadena)
        Cargar_Combobox(dstFormas.Tables(0), Me.cmbFormas)
        Me.lblTot.Text = dblTotFac
        Me.txtTotaldto.Value = dblTotFac
        Me.textdto.Value = 0
        ShowDialog()

    End Sub

    Public Function Cargar_Combobox(ByVal dt As DataTable, ByRef cbx As Windows.Forms.ComboBox)
        If dt.Rows.Count > 0 Then
            cbx.DataSource = dt
            cbx.ValueMember = dt.Columns(0).ToString()
            cbx.DisplayMember = dt.Columns(1).ToString()
        End If
        Return Nothing
    End Function

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles textdto.TextChanged
        If TextDto.Text <> "" Then
            txtTotaldto.Value = FormatNumber(CDbl(Me.lblTot.Text) - ((CDbl(Me.lblTot.Text) * CDbl(textdto.Value)) / 100), 2)
        Else
            txtTotaldto.Value = FormatNumber(CDbl(lblTot.Text), 2)
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtTotaldto.Text <> "" Then


            Vuelto = 0
            Paga = 0
            Descuento = CDbl(textdto.Value)
            TotalDto = CDbl(txtTotaldto.Text)
            MontoDesc = CDbl(lblTot.Text) - CDbl(txtTotaldto.Text)
            IdFormaPago = cmbFormas.SelectedValue
            AceptaPago = True
            Me.Close()

        Else
            MsgAtencion("Debe ingresar algun valor de pago")
            'txtP.SetFocus()
        End If
    End Sub

    Private Sub FormVuelto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class