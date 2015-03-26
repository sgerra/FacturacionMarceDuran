Public Class FormDetalleCajaDiaria
    Dim dstCaja As New DataSet
    Dim dstDetalleCaja As New DataSet
    Dim dstFormasPago As New DataSet

    Private Sub FormDetalleCajaDiaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub AbrirCaja(nroCaja As Integer, fecha As Date, hora As Date)

        Try
            dstCaja = pwiCajasDiarias.wflCajasDiarias_obtenerDetalle(My.Settings.cadena, nroCaja)

            LblFecha.Text = dstCaja.Tables(0).Rows(0)("caj_f_apertura")
            LblUsuario.Text = dstCaja.Tables(0).Rows(0)("usu_identi")
            LblSaldo.Text = dstCaja.Tables(0).Rows(0)("caj_saldoinicial")

            dstDetalleCaja = pwiCajasDiarias.wflCajasDiarias_CajasDetalles_obtenerListaMovimientos(My.Settings.cadena, fecha, hora.TimeOfDay.ToString, idUsuario)

            CargarGrillaMovimientosCaja()
            dstFormasPago = pwiCajasDiarias.wflCajasDiariasDetalles_obtenerFormasPago(My.Settings.cadena)
            Dim colDecimal As DataColumn = New DataColumn("Monto")
            colDecimal.DataType = System.Type.GetType("System.Decimal")
            colDecimal.DefaultValue = 0
            dstFormasPago.Tables(0).Columns.Add(colDecimal)
            CargarImportes()
            CargarGrillaImportes()
            ShowDialog()
        Catch ex As Exception
            MsgBox("Error en la aplicación" & ex.Message)
        End Try

    End Sub
    Private Sub CargarImportes()
        Try

            For Each dr As DataRow In dstDetalleCaja.Tables(0).Rows

                For Each dFp As DataRow In dstFormasPago.Tables(0).Rows

                    If dFp("cod") = dr("cvt_formapago") Then
                        dFp("monto") = dFp("monto") + dr("cvt_totaldto")
                        Exit For
                    End If
                Next


            Next
        Catch ex As Exception
            Throw New Exception("Error " + "Cargar importes" + "|" + ex.Message)

        End Try
    End Sub
    Private Sub CargarGrillaImportes()
        Try

            Dim lngNroError As Integer = 0


            If Not dstFormasPago Is Nothing Then
                For Each row In dstFormasPago.Tables(0).Rows
                    GrillaImportes.Rows.Add(row("cod"), row("descri"), row("monto"))
                    lblSaldoFinal.Text = FormatNumber(CDbl(lblSaldoFinal.Text) + row("monto"), 2)
                Next
            End If

           
        Catch ex As Exception
            Throw New Exception("Error " + "Cargar importes" + "|" + ex.Message)

        End Try
    End Sub
    Private Sub CargarGrillaMovimientosCaja()
        Dim lngNroError As Long

        Try
            lngNroError = 0
            Dim i As Integer
            i = 1
            If Not dstDetalleCaja Is Nothing Then
                For Each row In dstDetalleCaja.Tables(0).Rows
                    GrillaMovimientos.Rows.Add(row("cvt_nrocom"), row("cvt_fecha"), row("descri"), row("cvt_totaldto"))
                Next
            End If


        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try


    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        If MsgPregunta("¿ Está seguro de cerrar la caja ?") = vbYes Then
            dstCaja.Tables(0).Rows(0)("caj_saldofinal") = CDbl(Me.lblSaldoFinal.Text)
            Dim intResult As Boolean = pwiCajasDiarias.wflCajasDiarias_CerrarCaja(My.Settings.cadena, dstCaja, dstDetalleCaja, dstFormasPago)
            If intResult Then
                MsgInformacion("La caja se cerro con éxito")
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgPregunta("¿Desea cancelar ?") = vbYes Then
            Me.Close()
        End If
    End Sub
End Class