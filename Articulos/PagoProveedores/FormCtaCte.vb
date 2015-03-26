Public Class FormCtaCte
    Dim DsCtaCte As New DataSet
    Dim idProv As Integer
    Dim strNombreProve As String
    Private Sub FormCtaCte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Abrir(idprove As Integer, NomProv As String)
        MostrarDetalleCuenta(idprove)
        idProv = idprove
        strNombreProve = NomProv
        Me.ShowDialog()
    End Sub


    Private Sub MostrarDetalleCuenta(idp As Integer)
        Dim dtPagos As New DataTable
        Dim dtSaldos As New DataTable

        If DsCtaCte Is Nothing Then
            DsCtaCte = New DataSet
        End If

        '---------------Inicializo el dataset que guardar todo------------------------------
        DsCtaCte.Tables.Add()
        DsCtaCte.Tables(0).Columns.Add("Fecha", Type.GetType("System.DateTime"))
        DsCtaCte.Tables(0).Columns.Add("FechaV", Type.GetType("System.DateTime"))
        DsCtaCte.Tables(0).Columns.Add("NroCom", Type.GetType("System.String"))
        DsCtaCte.Tables(0).Columns.Add("Concepto", Type.GetType("System.String"))
        DsCtaCte.Tables(0).Columns.Add("Debe", Type.GetType("System.Double"))
        DsCtaCte.Tables(0).Columns.Add("Haber", Type.GetType("System.Double"))
        DsCtaCte.Tables(0).Columns.Add("Comprobantes", Type.GetType("System.String"))
        DsCtaCte.Tables(0).Columns.Add("Saldo", Type.GetType("System.Double"))
        DsCtaCte.Tables(0).Columns.Add("idcompra", Type.GetType("System.Int32"))
        DsCtaCte.Tables(0).Columns.Add("estado", Type.GetType("System.String"))
        '------------------------------------------------------------------------------------

        '----Obtengo la cabecera de los pagos--------------------------------------------
        dtPagos = pwiCtaCte.Pagoproveedores_obtenerLista(My.Settings.cadena, idp).Tables(0)
        '---------------------------------------------------------------------------------

        '------Obtengo los saldos del proveedor--------------------------------------------
        dtSaldos = pwiCtaCte.SaldosProve_obtenerRegistro(My.Settings.cadena, idp).Tables(0)
        '--------Los cargo en el dataset---------------------------------------------------
        If dtSaldos.Rows.Count > 0 Then
            For Each row In dtSaldos.Rows

                CargarDataset(Now.Date, 1, "SALDO INICIAL", "SI", row("sal_saldoini"), 0, 0, "")


            Next
        Else
            CargarDataset(Now.Date, 1, "SALDO INICIAL", "SI", 0, 0, 0, "")
        End If
        '-----------------------------------------------------------------------------------

        'Recorro el dataset de pagos para armar la grilla de detalle de pagos
        Dim nropago As Integer
        Dim dtPagoDetalle As New DataSet
        Dim dtbonificaciones As New DataSet
        Dim dtOtrosConceptos As New DataSet
        Dim estado As String
        For i = 0 To dtPagos.Rows.Count - 1

            nropago = dtPagos.Rows(i).Item("ppr_nropago")
            estado = dtPagos.Rows(i).Item("ppr_estado")
            dtPagoDetalle = pwiCtaCte.PagosProveedoresDetalles_obtenerLista(My.Settings.cadena, nropago)

            For Each row In dtPagoDetalle.Tables(0).Rows
                CargarDataset(CDate("01/01/1900"), row("ppd_nrofac"), row("descri"), "F", row("ppd_totalfac"), 0, row("ppd_idcompra"), "")
            Next

            ' Agrego las bonificaciones, si es que hay***************************************
            dtbonificaciones = pwiCtaCte.Bonificaciones_obtenerLista(My.Settings.cadena, nropago)
            If Not dtbonificaciones Is Nothing Then
                For Each row In dtbonificaciones.Tables(0).Rows
                    CargarDataset(row("bon_fecha"), row("bon_nrobon"), row("bon_concepto"), "B", 0, row("bon_monto"), 0, "")
                Next
            End If

            ' Agrego los otros conceptos, si es que hay***************************************
            dtOtrosConceptos = pwiCtaCte.OtrosConceptos_obtenerLista(My.Settings.cadena, nropago)

            For Each row In dtOtrosConceptos.Tables(0).Rows
                CargarDataset(row("poc_fecha"), row("poc_id"), row("poc_descripcion"), row("poc_comprobante"), row("poc_monto"), 0, 0, "")
            Next

            CargarDataset(dtPagos.Rows(i).Item("ppr_fecpago"), dtPagos.Rows(i).Item("ppr_nropago"), "PAGO", dtPagos.Rows(i).Item("ppr_comprobante"), 0, dtPagos.Rows(i).Item("ppr_impototal"), 0, estado)

        Next

        '-----------CARGO FACTURAS IMPAGAS------------------------------------------------------------------------
        Dim dtFacImp As New DataSet

        dtFacImp = pwiCtaCte.wflPagosProveedores_Compras_obtenerFacturasImpagas(My.Settings.cadena, idp)


        For i = 0 To dtFacImp.Tables(0).Rows.Count - 1
            If Not EstaenCtaCte(dtFacImp.Tables(0).Rows(i).Item("idcompra")) Then
                CargarDataset(dtFacImp.Tables(0).Rows(i).Item("fecha"), dtFacImp.Tables(0).Rows(i).Item("nrofactura"), dtFacImp.Tables(0).Rows(i).Item("estado"), "F", dtFacImp.Tables(0).Rows(i).Item("total"), 0, dtFacImp.Tables(0).Rows(i).Item("idcompra"), "")
            End If
        Next

        '----------------------------------------------------------------------------------
        '------Obtengo bonificaciones NO utilizadas----------------------------------------
        Dim dtBoniNoUsadas As New DataSet
        dtBoniNoUsadas = pwiCtaCte.wflPagosProveedores_Bonificaciones_obtenerPorProve(My.Settings.cadena, nropago)

        For Each row In dtBoniNoUsadas.Tables(0).Rows
            CargarDataset(row("bon_fecha"), row("bon_nrobon"), row("bon_concepto"), "B", 0, row("bon_monto"), 0, "")
        Next

        'Faltan los depósitos..... no los agregue porque por ahora no se puede cargar por afuera, solo en los pagos.
       


        '--------------------------Cargo la grilla que se muestra

        Dim x As Integer
        x = 0
        For Each row In DsCtaCte.Tables(0).Rows
            CargarGrillaCtaCte(row("fecha"), row("nrocom"), row("concepto"), row("debe"), row("haber"), row("saldo"), GrillaCtaCte)
            If row("saldo") < 0 Then
                Me.GrillaCtaCte.Rows(x).Cells("saldo").Style.ForeColor = Color.Red
            Else
                Me.GrillaCtaCte.Rows(x).Cells("saldo").Style.ForeColor = Color.Blue
            End If
            If row("estado") = "A" Then
                Me.GrillaCtaCte.Rows(x).DefaultCellStyle.BackColor = Color.Bisque
            End If

            If row("estado") = "C" Then
                Me.GrillaCtaCte.Rows(x).DefaultCellStyle.BackColor = Color.LightBlue
            End If

            x = x + 1
        Next
    End Sub
    Private Sub CargarDataset(ByVal dtfecha As Date, ByVal nrocomp As String, _
                              ByVal concepto As String, ByVal comprobante As String, ByVal debe As Double, _
                              ByVal haber As Double, idcompra As Integer, estado As String)
        Dim i As Integer

        i = DsCtaCte.Tables(0).Rows.Count

        DsCtaCte.Tables(0).Rows.Add()
        DsCtaCte.Tables(0).Rows(i).Item("Fecha") = dtfecha
        DsCtaCte.Tables(0).Rows(i).Item("NroCom") = nrocomp
        DsCtaCte.Tables(0).Rows(i).Item("Concepto") = concepto
        DsCtaCte.Tables(0).Rows(i).Item("debe") = debe
        DsCtaCte.Tables(0).Rows(i).Item("haber") = haber
        DsCtaCte.Tables(0).Rows(i).Item("comprobantes") = comprobante
        If i = 0 Then
            DsCtaCte.Tables(0).Rows(i).Item("saldo") = debe
        Else
            DsCtaCte.Tables(0).Rows(i).Item("saldo") = FormatNumber(DsCtaCte.Tables(0).Rows(i - 1).Item("saldo") - debe + haber, 2)
        End If
        DsCtaCte.Tables(0).Rows(i).Item("idcompra") = idcompra
        DsCtaCte.Tables(0).Rows(i).Item("estado") = estado


    End Sub
    Private Sub CargarGrillaCtaCte(ByVal dtfecha As Date, nrocomp As String, concepto As String, debe As Double, haber As Double, saldo As Double, _
                                    ByRef grilla As System.Windows.Forms.DataGridView)
        Dim lngNroError As Long

        Try
            lngNroError = 0
            grilla.Rows.Add(dtfecha, nrocomp, concepto, debe, haber, saldo)
        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try
    End Sub

    Private Sub GrillaCtaCte_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaCtaCte.CellContentClick

    End Sub

    Private Sub btnnuevopago_Click(sender As Object, e As EventArgs) Handles btnnuevopago.Click
        Dim frm As New FormPagosProveedores
        Dim auxDt As New DataSet

        auxDt = pwiCtaCte.wflPagosProveedores_obtenerPagosAbiertos(My.Settings.cadena, idProv)

        If auxDt.Tables(0).Rows.Count = 0 Then 'No hay pagos abiertos
            frm.AbrirPagos(idProv, strNombreProve, 1)
            GrillaCtaCte.Rows.Clear()
            DsCtaCte = Nothing
            MostrarDetalleCuenta(idProv)
        Else
            MsgBox("Existe un pago abierto, por favor cierre el pago y vuelva a intentarlo", vbOKOnly + vbInformation, "Aviso al operador")
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NroPago As Integer
        Dim auxDt As New DataSet
        Dim frm As New FormPagosProveedores
        If GrillaCtaCte.CurrentRow.Selected = True Then
            If GrillaCtaCte.CurrentRow.Cells(2).Value = "PAGO" Then
                NroPago = GrillaCtaCte.CurrentRow.Cells(1).Value
                auxDt = pwiCtaCte.wflPagosProveedores_obtenerPagosAbiertos(My.Settings.cadena, idProv)

                If auxDt.Tables(0).Rows.Count > 0 Then 'Hay pagos abiertos

                    If NroPago = auxDt.Tables(0).Rows(0)("ppr_nropago") Then
                        frm.ModificarPagos(idProv, strNombreProve, 1, NroPago)
                        GrillaCtaCte.Rows.Clear()
                        DsCtaCte = Nothing
                        MostrarDetalleCuenta(idProv)
                    Else
                        MsgBox("El pago seleccionado se encuentra cerrado. Por favor seleccione otro.", vbInformation + vbOKOnly, "Aviso al operador")
                    End If
                Else
                    MsgBox("No existen pagos abiertos", vbInformation + vbOKOnly, "Aviso al operador")
                End If
            Else
                MsgBox("Seleccione una fila que contenga un pago", vbInformation + vbOKOnly, "Aviso al operador")
            End If
        End If
    End Sub
    Private Function EstaenCtaCte(idcompra As Integer)
        EstaenCtaCte = False

        For Each dr As DataRow In DsCtaCte.Tables(0).Rows
            If dr("idcompra") = idcompra Then
                EstaenCtaCte = True
                Exit Function
            End If
        Next


    End Function

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("¿Desea imprimir el pago?", MsgBoxStyle.YesNoCancel, "Aviso al operador") = MsgBoxResult.Yes Then
            Dim frm As New FormImprimePago
            Dim NroPago As Integer
            Dim auxDt As New DataSet

            If GrillaCtaCte.CurrentRow.Selected = True Then
                If GrillaCtaCte.CurrentRow.Cells(2).Value = "PAGO" Then
                    NroPago = GrillaCtaCte.CurrentRow.Cells(1).Value
                    frm.AbrirFormulario(NroPago)
                Else
                    MsgBox("Seleccione una fila que contenga un pago", vbInformation + vbOKOnly, "Aviso al operador")
                End If
            End If
        End If
    End Sub
End Class