Public Class FormBuscaPedido

    Private Sub FormBuscaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub AbrirFormulario()
        Dim ds As New DataView

        ds = pwiBuscarPedido.wflCompras_obtenerLista(My.Settings.cadena)


        CargarGrillaCompras(ds, GrillaPedidos)
        Me.ShowDialog()




    End Sub
    Private Sub CargarGrillaCompras(ByRef objrsCompras As DataView, ByRef grilla As System.Windows.Forms.DataGridView)
        Dim lngNroError As Long
        Dim i As Integer
        Try
            lngNroError = 0
            grilla.Rows.Clear()

            For Each row As DataRowView In objrsCompras

                grilla.Rows.Add(row("idcompra"), row("fecha"), row("proveedor"), row("total"))

            Next


        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frm As New FormComprasNew
        Dim ds As New DataView

        FormComprasNew.ShowDialog()

        GrillaPedidos.Rows.Clear()
        ds = pwiBuscarPedido.wflCompras_obtenerLista(My.Settings.cadena)

        If ds.Count > 0 Then
            CargarGrillaCompras(ds, GrillaPedidos)
            
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim frm As New FormModificaCompra
        Dim ds As New DataView

        frm.AbrirFormulario(GrillaPedidos.CurrentRow.Cells(0).Value)
        GrillaPedidos.Rows.Clear()
        ds = pwiBuscarPedido.wflCompras_obtenerLista(My.Settings.cadena)

        If ds.Count > 0 Then
            CargarGrillaCompras(ds, GrillaPedidos)
        End If


    End Sub

    Private Sub GrillaPedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaPedidos.CellContentClick

    End Sub

    Private Sub cmdImprimir_Click(sender As Object, e As EventArgs) Handles cmdImprimir.Click
        Dim frm As New FormImprimeReporte
        frm.AbrirFormulario(GrillaPedidos.CurrentRow.Cells(0).Value)
    End Sub
End Class