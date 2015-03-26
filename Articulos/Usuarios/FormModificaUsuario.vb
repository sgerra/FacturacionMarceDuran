Public Class FormModificaUsuario
    Dim dstPerfiles As New DataSet
    Dim dstUsuario As New DataSet
    Private Sub FormModificaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub AbrirFormulario(usu_id As Integer)
        'Cargo los perfiles
        dstPerfiles = pwiUsuarios.wflUsuarios_Perfiles_obtenerLista(My.Settings.cadena)
        Cargar_Combobox(dstPerfiles.Tables(0), cmbPerfil)
        dstUsuario = pwiUsuarios.wflUsuarios_obtenerRegistro(My.Settings.cadena, usu_id)
        If dstUsuario.Tables(0).Rows.Count > 0 Then
            Me.txtUsuario.Text = dstUsuario.Tables(0).Rows(0)("usu_identi")
            Me.txtApeyNom.Text = dstUsuario.Tables(0).Rows(0)("usu_apeynom")
            Me.txtclave.Text = dstUsuario.Tables(0).Rows(0)("usu_clave")
            Me.txtclaverepe.Text = dstUsuario.Tables(0).Rows(0)("usu_clave")
            Me.cmbPerfil.SelectedValue = dstUsuario.Tables(0).Rows(0)("usu_prf_id")

            If dstUsuario.Tables(0).Rows(0)("usu_entrada") = "S" Then
                Me.cmbEntrada.Text = "SI"
            Else
                Me.cmbEntrada.Text = "NO"
            End If

            If dstUsuario.Tables(0).Rows(0)("usu_auditor") = "S" Then
                Me.cmbAuditor.Text = "SI"
            Else
                Me.cmbAuditor.Text = "NO"
            End If


        End If
        Me.ShowDialog()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgPregunta("¿Desea cancelar?") = vbYes Then
            Me.Close()
        End If
    End Sub
    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        e.KeyChar = UCase(e.KeyChar)

    End Sub

    Private Sub txtApeyNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApeyNom.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        e.KeyChar = UCase(e.KeyChar)

    End Sub

    Private Sub txtclave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtclave.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        e.KeyChar = UCase(e.KeyChar)

    End Sub
    Private Sub txtclaverepe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtclaverepe.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        e.KeyChar = UCase(e.KeyChar)

    End Sub
    Private Sub cmbPerfil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbPerfil.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        e.KeyChar = UCase(e.KeyChar)

    End Sub
    Private Sub cmbAuditor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbAuditor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        e.KeyChar = UCase(e.KeyChar)

    End Sub
    Private Sub cmbEntrada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbEntrada.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        e.KeyChar = UCase(e.KeyChar)

    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If ValidarCampos Then
            If MsgPregunta("¿Desea modificar el usuario?") = vbYes Then

                dstUsuario.Tables(0).Rows(0)("usu_identi") = Me.txtUsuario.Text
                dstUsuario.Tables(0).Rows(0)("usu_apeynom") = Me.txtApeyNom.Text
                dstUsuario.Tables(0).Rows(0)("usu_clave") = Me.txtclave.Text
                dstUsuario.Tables(0).Rows(0)("usu_prf_id") = Me.cmbPerfil.SelectedValue
                dstUsuario.Tables(0).Rows(0)("usu_entrada") = Mid(Me.cmbEntrada.Text, 1, 1)
                dstUsuario.Tables(0).Rows(0)("usu_auditor") = Mid(Me.cmbAuditor.Text, 1, 1)

                Dim cboolResult As Boolean = pwiUsuarios.wflUsuarios_Usuarios_actualizarRegistro(My.Settings.cadena, dstUsuario)

                If cboolResult Then
                    MsgInformacion("El usuario se guardó con éxito")
                    Me.Close()
                End If

            End If
        End If
    End Sub
    Private Function ValidarCampos() As Boolean
        ValidarCampos = True

        If Me.txtUsuario.Text = "" Then
            MsgAtencion("Debe completar el nombre de usuario")
            Me.txtUsuario.Focus()
            ValidarCampos = False
            Exit Function
        End If

        If Me.txtclave.Text = "" Then
            MsgAtencion("Debe completar la clave")
            Me.txtclave.Focus()
            ValidarCampos = False
            Exit Function
        End If

        If Me.txtclaverepe.Text = "" Then
            MsgAtencion("Debe completar la clave")
            Me.txtclaverepe.Focus()
            ValidarCampos = False
            Exit Function
        End If

        If String.Compare(Me.txtclave.Text, Trim(txtclaverepe.Text)) <> 0 Then
            MsgAtencion("Las claves difieren y deben ser iguales")
            Me.txtclave.Focus()
            ValidarCampos = False
            Exit Function
        End If

    End Function
End Class