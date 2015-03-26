Public Class FormPide
    Dim descart As String
    Dim precio As Double
    Dim codigo As String
    Dim CodBarras As String
    Dim pcompra As Double
    Dim gri As DataGridView
    Dim tot As Double

    Private Sub FormPide_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Cargar_Formulario(des As String, pr As Double, cod As String, cb As String, pc As Double, grilla As DataGridView, ByRef total As Double)
        descart = des
        precio = pr
        codigo = cod
        CodBarras = cb
        pcompra = pc
        lbldescart.Text = descart
        gri = grilla
        tot = total
        Me.txtprecio.Focus()
        ShowDialog()
        total = tot
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        Dim Pingresado As Double
        Dim PTotal As Double
        pwiFacturacion.InsertarFilasEnGrilla(codigo, descart, CDbl(txtprecio.Value), dblcantidad, FormatNumber(CDbl(txtprecio.Text) * dblcantidad, 2), CodBarras, pcompra, gri)
        TotalPcompra = TotalPcompra + (pcompra * dblcantidad)
        Pingresado = CDbl(txtprecio.Text) * dblcantidad
        PTotal = tot
        tot = FormatNumber(PTotal + Pingresado, 2)


        Me.Close()

    End Sub

    Private Sub txtprecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtprecio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged

    End Sub
End Class