Imports AppFacturacion.pwiFacturacion
Public Class FormPideCodart
    Dim clsFactura As New pwiFacturacion
    Dim cadena As String
    Private Sub FormPideCodart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cadena = My.Settings.cadena
    End Sub

    Private Sub txtcodigobarras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigobarras.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            clsFactura.ValidarIngresoArt(Me, cadena)
        End If
    End Sub

    Private Sub txtcodigobarras_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodigobarras.TextChanged

    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Me.Hide()
    End Sub
End Class