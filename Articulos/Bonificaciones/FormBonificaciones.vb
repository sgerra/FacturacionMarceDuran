Public Class FormBonificaciones
    Dim idProv As Integer
    Dim Npago As Integer
    Dim DtBon As DataSet
    Private Sub FormBonificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Abrir(lngIdProveedor As Integer, lngNroPago As Integer, ByRef dtB As DataSet)
        idProv = lngIdProveedor
        Npago = lngNroPago
        DtBon = dtB
        GrillaBonificaciones.Rows.Clear()
        CargarGrillaBoni()
        Me.ShowDialog()
    End Sub
    Private Sub CargarGrillaBoni()
        Dim lngNroError As Long

        Try
            lngNroError = 0
            Dim i As Integer

            i = 1
            If Not DtBon Is Nothing Then
                For Each row In DtBon.Tables(0).Rows
                    GrillaBonificaciones.Rows.Add(row("orden"), row("bon_fecha"), row("bon_nrobon"), row("bon_concepto"), row("bon_monto"))
                Next
            End If

        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try


    End Sub

    Private Sub cmdagregar_Click(sender As Object, e As EventArgs) Handles cmdagregar.Click
        FormAgregaBoni.AbrirBoni(Npago, idProv, DtBon)
        GrillaBonificaciones.Rows.Clear()
        CargarGrillaBoni()
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Dim intOrden As Integer
        If MsgBox("¿Desea eliminar la bonificación?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = 6 Then
            intOrden = GrillaBonificaciones.CurrentRow.Cells(0).Value

            DtBon.Tables(0).Rows(intOrden).Delete()
            GrillaBonificaciones.Rows.Clear()
            CargarGrillaBoni()


        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class