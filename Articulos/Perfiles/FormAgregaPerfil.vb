Public Class FormAgregaPerfil

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgPregunta("¿Desea cancelar?") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If MsgPregunta("¿Desea guardar el perfil?") = vbYes Then
            Dim exito As Boolean = False
            pwiPerfiles.GuardarPerfil(My.Settings.cadena, Me.textPerfil.Text, exito)
            If exito Then
                MsgInformacion("El perfil se grabó con éxito")
                Me.Close()
            End If
        End If
    End Sub
End Class