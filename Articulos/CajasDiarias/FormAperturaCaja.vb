Public Class FormAperturaCaja
    Dim dstCaja As New DataSet
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgPregunta("¿Está seguro de cancelar?") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If MsgPregunta("¿Está seguro de abrir la caja?") = vbYes Then
            '---------------------------Me fijo si el usuario no tiene una caja abierta----

            If Not pwiCajasDiarias.wflCajasDiarias_ExisteCajaAbierta(My.Settings.cadena, idUsuario, My.Settings.sucursal) Then
                '-----otengo una caja vacia y la cargo con los datos
                dstCaja = pwiCajasDiarias.wflCajasDiarias_obtenerRegistro(My.Settings.cadena, -1)
                dstCaja.Tables(0).Rows.Add()
                dstCaja.Tables(0).Rows(0)("caj_f_apertura") = CDate(Me.dtFecha.Value)
                dstCaja.Tables(0).Rows(0)("caj_h_apertura") = Format(Me.dtHora.Value, "hh:mm:ss")
                dstCaja.Tables(0).Rows(0)("caj_idusuario") = idUsuario
                dstCaja.Tables(0).Rows(0)("caj_saldoinicial") = CDbl(Me.txtSaldo.Value)
                dstCaja.Tables(0).Rows(0)("caj_h_apertura") = Format(Me.dtHora.Value, "hh:mm:ss")
                dstCaja.Tables(0).Rows(0)("caj_cerrada") = "N"
                dstCaja.Tables(0).Rows(0)("caj_idsucursal") = My.Settings.sucursal

                Dim lngIdCaja As Integer = pwiCajasDiarias.wflCajasDiarias_AbrirCajaDiaria(My.Settings.cadena, dstCaja)

                MsgInformacion("La caja " & lngIdCaja & " se abrió con éxito")
                Me.Close()
            Else
                MsgAtencion("El usuario ya posee una caja abierta. Por favor cierre la caja e intentelo nuevamente")

            End If
        End If
    End Sub

    Private Sub FormAperturaCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSaldo.Value = 0
        Me.LblUsuario.Text = NomUsuario
        Me.txtSaldo.Focus()
    End Sub
End Class