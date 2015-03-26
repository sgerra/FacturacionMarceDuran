Public Class FormDepositos

    Dim idProv As Integer
    Dim Npago As Integer
    Dim DtDepositos As DataSet
    Public Sub Abrir(lngIdProveedor As Integer, lngNroPago As Integer, ByRef dtDep As DataSet)
        idProv = lngIdProveedor
        Npago = lngNroPago
        DtDepositos = dtDep
        GrillaDepositos.Rows.Clear()
        CargarGrillaDepositos()
        Me.ShowDialog()
    End Sub
    Private Sub CargarGrillaDepositos()
        Dim lngNroError As Long

        Try
            lngNroError = 0
            Dim i As Integer

            i = 1
            If Not DtDepositos Is Nothing Then
                For Each row In DtDepositos.Tables(0).Rows
                    GrillaDepositos.Rows.Add(row("orden"), row("dep_fecha"), row("banconombre"), row("dep_nroboleta"), row("dep_totaldepo"))
                Next
            End If

        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try


    End Sub
    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Dim intOrden As Integer
        If MsgBox("¿Desea eliminar el depósito?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = 6 Then
            intOrden = GrillaDepositos.CurrentRow.Cells(0).Value
            DtDepositos.Tables(0).Rows(intOrden).Delete()
            GrillaDepositos.Rows.Clear()
            CargarGrillaDepositos()
        End If
    End Sub

    Private Sub cmdagregar_Click(sender As Object, e As EventArgs) Handles cmdagregar.Click
        FormAgregaDeposito.AbrirDeposito(Npago, idProv, DtDepositos)

        GrillaDepositos.Rows.Clear()
        CargarGrillaDepositos()
    End Sub

    Private Sub FormDepositos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class