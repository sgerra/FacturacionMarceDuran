Public Class FormPerfiles
    Dim dstPerfiles As New DataSet
    Private Sub FormPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dstPerfiles = pwiPermisos.ObtenerPerfiles(My.Settings.cadena)
        CargarGrillaPerfiles()
    End Sub

    Private Sub CargarGrillaPerfiles()
        Dim lngNroError As Long

        Try
            lngNroError = 0



            For Each row In dstPerfiles.Tables(0).Rows
                GrillaPerfiles.Rows.Add(row("prf_id"), row("prf_detperfil"))
            Next


        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New FormAgregaPerfil
        frm.ShowDialog()
        Me.GrillaPerfiles.Rows.Clear()
        Me.CargarGrillaPerfiles()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim intOrden As Integer
        If MsgBox("¿Desea eliminar el perfil seleccionado?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = 6 Then
            intOrden = GrillaPerfiles.CurrentRow.Cells(0).Value
            pwiPerfiles.eliminarPerfil(My.Settings.cadena, intOrden)
            MsgInformacion("El perfil y sus permisos asociados se ha eliminado con exito")
            GrillaPerfiles.Rows.Clear()
            FormPerfiles_Load(sender, e)

        End If
    End Sub
End Class