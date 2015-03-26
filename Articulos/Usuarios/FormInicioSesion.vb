Public Class FormInicioSesion

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim clave As String
        Dim cambio As Boolean
        If datosCompletos() Then
            Dim dstUsuario As DataSet = pwiUsuarios.wflUsuarios_Usuarios_obtenerUsuarioPorNombre(My.Settings.cadena, textnombreusuario.Text, My.Settings.sucursal)
            If dstUsuario.Tables(0).Rows.Count > 0 Then
                idUsuario = dstUsuario.Tables(0).Rows(0)("usu_id")
                NomUsuario = dstUsuario.Tables(0).Rows(0)("usu_identi")
                idPerfilUsuario = dstUsuario.Tables(0).Rows(0)("usu_prf_id")
                clave = dstUsuario.Tables(0).Rows(0)("usu_clave")

                If Decript(clave) = textcontrasenia.Text Then

                    If dstUsuario.Tables(0).Rows(0)("usu_entrada") = "N" Then
                        cambio = False
                        FormCambioClave.Abrir(cambio)
                        If cambio Then
                            'ActualizarEntrada()
                            FormPrincipal.Show()
                        Else
                            MsgInformacion("Debe cambiar obligatoriamente la contraseña")
                            End
                        End If
                    Else
                        FormPrincipal.Show()
                    End If
                Else
                    MsgAtencion("La contraseña está mal ingresada")
                    textcontrasenia.Focus()
                End If
            Else
                MsgAtencion("El usuario ingresado no existe en la Base de Datos")
                textnombreusuario.Focus()
            End If

        Else
            MsgAtencion("No puede dejar el nombre de usuario y/o contraseña sin completar")
            textnombreusuario.Focus()
        End If

    End Sub
    Private Function datosCompletos() As Boolean
        datosCompletos = (Trim(Me.textnombreusuario.Text) <> "") And (Trim(Me.textcontrasenia.Text) <> "")
    End Function

    Private Sub FormInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub textnombreusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textnombreusuario.KeyPress
      
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub textnombreusuario_TextChanged(sender As Object, e As EventArgs) Handles textnombreusuario.TextChanged

    End Sub

    Private Sub textcontrasenia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textcontrasenia.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub textcontrasenia_TextChanged(sender As Object, e As EventArgs) Handles textcontrasenia.TextChanged

    End Sub
End Class