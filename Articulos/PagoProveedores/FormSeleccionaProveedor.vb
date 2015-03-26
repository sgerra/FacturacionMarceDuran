
Public Class FormSeleccionaProveedor

    Private Sub FormSeleccionaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtProv As New DataTable


        '-------------Cargo los combos de la pantalla con Dataset--------------------------------------------
        dtProv = pwiSeleccionaProv.Pagoproveedores_Proveedores_obtenerLista(My.Settings.cadena).Tables(0)
        Cargar_Combobox(dtProv, cmbProv)
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
        Dim frm As New FormCtaCte

        frm.Abrir(Me.cmbProv.SelectedValue, cmbProv.Text)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class