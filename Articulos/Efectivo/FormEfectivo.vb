Public Class FormEfectivo
    Dim idProv As Integer
    Dim Npago As Integer
    Dim DtEfectivo As DataSet
    Public Sub Abrir(lngIdProveedor As Integer, lngNroPago As Integer, ByRef dtEft As DataSet)
        idProv = lngIdProveedor
        Npago = lngNroPago
        DtEfectivo = dtEft
        GrillaEfectivo.Rows.Clear()
        CargarGrillaEfectivo()
        Me.ShowDialog()
    End Sub
    Private Sub CargarGrillaEfectivo()
        Dim lngNroError As Long

        Try
            lngNroError = 0
            Dim i As Integer

            i = 1
            If Not DtEfectivo Is Nothing Then
                For Each row In DtEfectivo.Tables(0).Rows
                    GrillaEfectivo.Rows.Add(row("orden"), row("nombreMoneda"), row("pde_Monto"))
                Next
            End If

        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try


    End Sub

    Private Sub FormEfectivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdagregar_Click(sender As Object, e As EventArgs) Handles cmdagregar.Click
        FormAgregaEfectivo.AbrirEfectivo(Npago, idProv, DtEfectivo)
        GrillaEfectivo.Rows.Clear()
        CargarGrillaEfectivo()
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Dim intOrden As Integer
        If MsgBox("¿Desea eliminar el efectivo?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = 6 Then
            intOrden = GrillaEfectivo.CurrentRow.Cells(0).Value

            DtEfectivo.Tables(0).Rows(intOrden).Delete()
            GrillaEfectivo.Rows.Clear()
            CargarGrillaEfectivo()


        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class