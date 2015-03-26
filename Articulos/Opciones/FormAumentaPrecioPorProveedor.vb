Public Class FormAumentaPrecioPorProveedor
    Dim dstArticulos As New DataSet
    Private Sub FormAumentaPrecioPorProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtProv As New DataTable


        '-------------Cargo los combos de la pantalla con Dataset--------------------------------------------
        dtProv = pwiSeleccionaProv.Pagoproveedores_Proveedores_obtenerLista(My.Settings.cadena).Tables(0)
        Cargar_Combobox(dtProv, CmbProveedor)
    End Sub

    Private Sub CmbProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProveedor.SelectedIndexChanged

    End Sub

    Private Sub CmbProveedor_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CmbProveedor.SelectionChangeCommitted
        Dim i As Integer

        Try

            dstArticulos = pwiaumentaprecioporproveedor.AumentaPrecio_Articulos_obtenerArticulosPorProveedor(My.Settings.cadena, CmbProveedor.SelectedValue)

            GrillaArticulos.Rows.Clear()

            For Each row In dstArticulos.Tables(0).Rows
                GrillaArticulos.Rows.Add(row("codart"), row("desc"), row("costo"), True)
            Next
            chkTodos.Checked = True

        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        Dim ff As Boolean
        If chkTodos.Checked = False Then
            ff = False
            GrillaArticulos.Enabled = True
        Else
            ff = True
            GrillaArticulos.Enabled = False
        End If
        For i = 0 To GrillaArticulos.Rows.Count - 2
            GrillaArticulos.Rows(i).Cells("seleccion").Value = ff
        Next i
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        If MsgPregunta("¿Desea aumentar los precios de los articulos seleccionados?") Then
            Dim dst As New DataSet
            dst.Tables.Add("Articulos")
            dst.Tables(0).Columns.Add("codart")
            dst.Tables(0).Columns.Add("costo")

            For i = 0 To GrillaArticulos.Rows.Count - 2

                If GrillaArticulos.Rows(i).Cells("seleccion").Value = True Then

                    dst.Tables(0).Rows.Add()
                    dst.Tables(0).Rows(dst.Tables(0).Rows.Count - 1)("codart") = GrillaArticulos.Rows(i).Cells("codart").Value
                    dst.Tables(0).Rows(dst.Tables(0).Rows.Count - 1)("costo") = GrillaArticulos.Rows(i).Cells("costo").Value + (GrillaArticulos.Rows(i).Cells("costo").Value * TextPorc.Text) / 100
                End If

            Next
            pwiaumentaprecioporproveedor.AumentaPrecio_actualizarPrecios(My.Settings.cadena, dst)
            MsgInformacion("El proeso de aumento de precios por proveedor finalizó con éxito")
        End If
    End Sub
End Class