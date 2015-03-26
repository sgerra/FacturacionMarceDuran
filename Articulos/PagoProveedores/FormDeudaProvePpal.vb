Public Class FormDeudaProvePpal
    Dim dstProv As New DataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FormDeudaProvePpal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '-------------Cargo los combos de la pantalla con Dataset--------------------------------------------
        dstProv = pwiSeleccionaProv.Pagoproveedores_Proveedores_obtenerLista(My.Settings.cadena)
        dstProv.Tables(0).Columns.Add("Saldo")
        dstProv.Tables(0).Columns.Add("PA")
        pwiPagoProveedores.PagosProveedores_obtenerSaldo(My.Settings.cadena, dstProv)
        CargarGrillaSaldos()
    End Sub
    Private Sub CargarGrillaSaldos()
        Dim lngNroError As Long
        Dim fila As Integer
        Try
            lngNroError = 0
            fila = 0


            For Each row In dstProv.Tables(0).Rows
                GrillaSaldos.Rows.Add(row("idproveedor"), row("nombreproveedor"), row("saldo"), row("pa"))
                If row("saldo") < 0 Then
                    Me.GrillaSaldos.Rows(fila).Cells("saldo").Style.ForeColor = Color.Red
                Else
                    Me.GrillaSaldos.Rows(fila).Cells("saldo").Style.ForeColor = Color.Blue
                End If

                fila = fila + 1
            Next


        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New FormCtaCte

        frm.Abrir(GrillaSaldos.CurrentRow.Cells(0).Value, GrillaSaldos.CurrentRow.Cells(1).Value)
    End Sub
End Class