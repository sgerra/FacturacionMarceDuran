Public Class FormCheques
    Dim idProv As Integer
    Dim Npago As Integer
    Dim DtCheque As DataSet
    Public Sub Abrir(lngIdProveedor As Integer, lngNroPago As Integer, ByRef dtChP As DataSet)
        idProv = lngIdProveedor
        Npago = lngNroPago
        DtCheque = dtChP
        GrillaCheques.Rows.Clear()
        CargarGrillaChequesPropios()
        Me.ShowDialog()
    End Sub
    Private Sub CargarGrillaChequesPropios()
        Dim lngNroError As Long

        Try
            lngNroError = 0
            Dim i As Integer

            i = 1
            If Not DtCheque Is Nothing Then
                For Each row In DtCheque.Tables(0).Rows
                    GrillaCheques.Rows.Add(row("orden"), row("pcp_nrocheque"), row("pcp_fecemi"), row("pcp_fecpago"), row("banconombre"), row("pcp_monto"))
                Next
            End If

        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try


    End Sub

    Private Sub FormCheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdagregar_Click(sender As Object, e As EventArgs) Handles cmdagregar.Click
        FormAgregaCheques.AbrirCheques(Npago, idProv, DtCheque)
        GrillaCheques.Rows.Clear()
        CargarGrillaChequesPropios()
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Dim intOrden As Integer
        If MsgBox("¿Desea eliminar el cheque?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = 6 Then
            intOrden = GrillaCheques.CurrentRow.Cells(0).Value

            DtCheque.Tables(0).Rows(intOrden).Delete()
            GrillaCheques.Rows.Clear()
            CargarGrillaChequesPropios()


        End If
    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub
End Class