Public Class FormCambioClave

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgPregunta("¿Desea cancelar ?") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub FormCambioClave_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Abrir(ByRef cambio As Boolean)
        CambioClave = cambio
        ShowDialog()
        If CambioClave Then
            cambio = CambioClave
        End If
    End Sub
    Private Function VerificarDatos() As Boolean

        VerificarDatos = True

        If TextOldPass.Text = "" Then
            MsgAtencion("No puede dejar la contraseña actual en blanco")
            TextOldPass.Focus()
            VerificarDatos = False
            Exit Function
        End If

        If TextNewPass.Text = "" Then
            MsgAtencion("No puede dejar la nueva contraseña en blanco")
            TextNewPass.Focus()
            VerificarDatos = False
            Exit Function
        End If

        If TextNewPass2.Text = "" Then
            MsgAtencion("Por favor, repita la nueva contraseña")
            TextNewPass2.Focus()
            VerificarDatos = False
            Exit Function
        End If

        If TextNewPass.Text <> TextNewPass2.Text Then
            MsgAtencion("La nueva contraseña y su repetición no son iguales")
            TextNewPass.Focus()
            VerificarDatos = False
            Exit Function
        End If


    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cambio As Boolean
        Dim dstUsuario As New DataSet
        If MsgPregunta("¿Está seguro de cambiar su contraseña ?") = 6 Then

            If VerificarDatos() Then
                dstUsuario = pwiUsuarios.wflUsuarios_Usuarios_obtenerUsuarioPorNombre(My.Settings.cadena, NomUsuario, My.Settings.sucursal)
                dstUsuario.Tables(0).Rows(0)("usu_clave") = encript(TextNewPass.Text)
                dstUsuario.Tables(0).Rows(0)("usu_entrada") = "S"
                pwiUsuarios.wflUsuarios_Usuarios_actualizarRegistro(My.Settings.cadena, dstUsuario)
                cambio = True
                If cambio Then
                    MsgInformacion("El cambio de password se ha realizado con éxito")
                    CambioClave = True
                    Me.Close()
                Else
                    MsgAtencion("El cambio de clave no se ha realizado. Su contraseña actual no esta bien escrita")
                    TextOldPass.Focus()
                End If


            End If


        End If
    End Sub

    Private Sub TextOldPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextOldPass.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextOldPass_TextChanged(sender As Object, e As EventArgs) Handles TextOldPass.TextChanged

    End Sub

    Private Sub TextNewPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNewPass.KeyPress
      
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextNewPass_TextChanged(sender As Object, e As EventArgs) Handles TextNewPass.TextChanged

    End Sub

    Private Sub TextNewPass2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNewPass2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TextNewPass2_TextChanged(sender As Object, e As EventArgs) Handles TextNewPass2.TextChanged

    End Sub
End Class