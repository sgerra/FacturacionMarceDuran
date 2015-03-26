Public Class FormAgregaPermiso
    Dim dt As New DataSet
    Dim dtMenu As New DataSet
    Dim idFormu As Integer
    Dim idMenu As Integer
    Dim idPerfil As Integer
    Private Sub FormAgregaPermiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Abrir(ByRef dtPermisos As DataSet, idper As Integer)
        idPerfil = idper
        dtMenu = pwiPermisos.ObtenerItemMenu(My.Settings.cadena)
        Cargar_Combobox(dtMenu.Tables(0), Me.cmbItem)
        dt = dtPermisos
        ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim auxDt As New DataSet
        If validarCampos Then
            If MsgBox("¿Desea guardar el permiso?", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Information, "Aviso al operador") = vbYes Then
                If Not Existe Then
                    dt.Tables(0).Rows.Add()
                    ObtenerDatos()
                    dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("ppf_id") = -1
                    dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("ppf_idformu") = idFormu
                    dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("ppf_idperfil") = idPerfil
                    dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("ppf_permisos") = Me.textPermiso.Text
                    dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("itm_idtem") = Me.cmbItem.SelectedValue
                    dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("itm_iditemmenu") = Me.cmbItem.SelectedValue
                    dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("itm_checkmenu") = Me.cmbItem.Text
                    dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("itm_frm_id") = idFormu
                    dt.Tables(0).Rows(dt.Tables(0).Rows.Count - 1)("itm_men_id") = idMenu
                    Me.Close()
                Else
                    MsgAtencion("El elemento que intenta ingresar ya existe")
                End If
            End If
            End If
    End Sub
    Public Function Existe()
        Existe = False

        For Each dr As DataRow In dt.Tables(0).Rows
            If dr("itm_idtem") = Me.cmbItem.SelectedValue Then
                Existe = True
                Exit For
            End If
        Next

    End Function
    Public Sub ObtenerDatos()


        For Each dr As DataRow In dtMenu.Tables(0).Rows
            If dr("itm_idtem") = cmbItem.SelectedValue Then
                idFormu = dr("itm_frm_id")
                idMenu = dr("itm_men_id")
                Exit For
            End If
        Next


    End Sub
    Private Function ValidarCampos() As Boolean
        ValidarCampos = True
        If Me.cmbItem.Text = "" Then
            MsgBox("Ingrese el item del menú", vbOKOnly, "Aviso al operador")
            Me.cmbItem.Focus()
            ValidarCampos = False
            Exit Function
        End If

        If Me.textPermiso.Text = "" Then
            MsgBox("Ingrese permiso con el formato correcto", vbOKOnly, "Aviso al operador")
            Me.cmbItem.Focus()
            ValidarCampos = False
            Exit Function
        End If


    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgPregunta("¿Desea cancelar la operación?") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub textPermiso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textPermiso.KeyPress
       
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        e.KeyChar = UCase(e.KeyChar)

        If e.KeyChar <> "A" And e.KeyChar <> "B" And e.KeyChar <> "M" And e.KeyChar <> "C" Then
            e.Handled = True
        End If

    End Sub

    Private Sub textPermiso_ReadOnlyChanged(sender As Object, e As EventArgs) Handles textPermiso.ReadOnlyChanged

    End Sub

    Private Sub textPermiso_TextChanged(sender As Object, e As EventArgs) Handles textPermiso.TextChanged

    End Sub
End Class