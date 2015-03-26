Public Class FormModiPermi
    Dim dstPermiPorFormu As New DataSet
    Dim idPerfilSele As Integer
    Public Sub Abrir(idPerfil As Integer, perfil As String)
        dstPermiPorFormu = pwiPermisos.ObtenerPermisosPorFormu(My.Settings.cadena, idPerfil)
        CargarGrillaPermisos()
        Me.lblPerfil.Text = perfil
        idPerfilSele = idPerfil
        ShowDialog()
    End Sub
    Private Sub CargarGrillaPermisos()
        Dim lngNroError As Long

        Try
            lngNroError = 0



            For Each row In dstPermiPorFormu.Tables(0).Rows
                GrillaPermisos.Rows.Add(row("ppf_id"), row("itm_checkmenu"), row("ppf_permisos"))
            Next


        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New FormAgregaPermiso
        frm.Abrir(dstPermiPorFormu, idPerfilSele)
        GrillaPermisos.Rows.Clear()
        CargarGrillaPermisos()
    End Sub

    Private Sub FormModiPermi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim intOrden As Integer
        If MsgBox("¿Desea eliminar el permiso seleccionado?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = 6 Then
            intOrden = GrillaPermisos.CurrentRow.Cells(0).RowIndex

            dstPermiPorFormu.Tables(0).Rows(intOrden).Delete()
            dstPermiPorFormu.Tables(0).AcceptChanges()
            GrillaPermisos.Rows.Clear()
            CargarGrillaPermisos()


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgPregunta("¿Desea cancelar la operación?") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgPregunta("¿Desea guardar los cambios realizados?") = vbYes Then
            Dim exito As Boolean = False
            pwiPermisos.GuardarPermisos(My.Settings.cadena, dstPermiPorFormu, idPerfilSele, exito)
            MsgInformacion("El registro se grabó con éxito")
            Me.Close()
        End If
    End Sub
End Class