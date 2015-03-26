Public Class FormBuscarPerfiles
    Dim dstPerfiles As New DataSet
    Private Sub FormBuscarPerfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub btnmodificarPermi_Click(sender As Object, e As EventArgs) Handles btnmodificarPermi.Click
        Dim frm As New FormModiPermi

        If GrillaPerfiles.SelectedRows.Count > 0 Then
            frm.Abrir(GrillaPerfiles.CurrentRow.Cells(0).Value, GrillaPerfiles.CurrentRow.Cells(1).Value)
        Else
            MsgAtencion("Debe seleccionar al menos un perfil")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class