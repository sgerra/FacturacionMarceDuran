
Public Class FormOtrosConceptos
    Dim idProv As Integer
    Dim Npago As Integer
    Dim DtOC As DataSet
    Private Sub cmdagregar_Click(sender As Object, e As EventArgs) Handles cmdagregar.Click
        FormAgregaOC.AbrirOc(Npago, idProv, DtOC)
        GrillaOC.Rows.Clear()
        CargarGrillaOC()
    End Sub

    Private Sub FormOtrosConceptos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Abrir(lngIdProveedor As Integer, lngNroPago As Integer, ByRef dtO As DataSet)
        idProv = lngIdProveedor
        Npago = lngNroPago
        DtOC = dtO
        GrillaOC.Rows.Clear()
        CargarGrillaOC()
        Me.ShowDialog()
    End Sub

    Private Sub CargarGrillaOC()
        Dim lngNroError As Long

        Try
            lngNroError = 0



            For Each row In DtOC.Tables(0).Rows
                GrillaOC.Rows.Add(row("orden"), Npago, row("poc_descripcion"), row("poc_monto"))
            Next


        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try


    End Sub


    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Dim intOrden As Integer
        If MsgBox("¿Desea eliminar el concepto?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = 6 Then
            intOrden = GrillaOC.CurrentRow.Cells(0).Value

            DtOC.Tables(0).Rows(intOrden).Delete()
            GrillaOC.Rows.Clear()
            CargarGrillaOC()


        End If
    End Sub
End Class