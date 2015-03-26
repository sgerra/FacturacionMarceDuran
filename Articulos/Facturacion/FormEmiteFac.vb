Imports AppFacturacion.pwiFacturacion
Imports System.IO.Ports
'Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Public Class FormEmiteFac
    Dim clsfactura As New pwiFacturacion
    Dim cadena As String
    Dim Valido As Boolean
    Dim dstClientes As New DataSet
    Dim idListaSeleccionada As Integer
    Dim dstArticulo As New DataSet
    Dim dstArticuloFact As New DataSet
    Dim TotalPCompra As Double


    Private Sub FormEmiteFac_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 73 Then 'Presiona I-> Graba el ticket e imprime en impresora comun
            Origen = "I"
            cmdAceptar_Click(sender, e)

        End If

        If e.KeyCode = 70 Then 'Presiona F-> Graba el ticket e imprime en impresora fiscal
            Origen = "F"
            cmdAceptar_Click(sender, e)
        End If

        'If KeyCode = vbKeyF5 Then
        '    FormConsuPrecio.Show vbModal
        'End If

        'If KeyCode = vbKeyF2 Then 'F2 Graba el ticket
        '    FormVentaDiaria.Show vbModal
        'End If

        'If KeyCode = vbKeyF8 Then 'F2 Graba el ticket
        '    HASAR1.Comenzar()
        '    HASAR1.ReporteZ()
        '    HASAR1.Finalizar()
        'End If

        If e.KeyCode = 46 Then
            'cmdEliminar_Click(sender, e)
        End If

        'If KeyCode = vbKeyF12 Then
        '    FormReimprime.Cargar_Form()
        'End If

        If e.KeyCode = 27 Then
            cmdCancelar_Click(sender, e)
        End If

    End Sub


    

    Private Sub FormEmiteFac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Permisos("FormEmiteFac", idPerfilUsuario) Then
            VerCadenaPermiso(strPermi)

            If Trim(strPermi) <> "" Then
                If Alta Then
                    Me.cmdAceptar.Enabled = True
                End If
            Else
                MsgAtencion("Su perfil no le permite la visualización del formulario")
            End If
        End If
    End Sub
    Public Sub AbrirFormulario()
        cadena = My.Settings.cadena

        If pwiFacturacion.wflEmisionFactura_ExisteCajaAbierta(My.Settings.cadena, idUsuario, My.Settings.sucursal) Then
            GrillaArticulos.Font = New Font("Arial ", 16, FontStyle.Regular)
            dstClientes = pwiFacturacion.ObtenerClientes(cadena)
            Cargar_Combobox(dstClientes.Tables(0), cmbcliente)
            cmbcliente.SelectedValue = 1
            Me.lblLista.Text = dstClientes.Tables(0).Rows(cmbcliente.SelectedIndex)("lpr_descripcion")
            idListaSeleccionada = dstClientes.Tables(0).Rows(cmbcliente.SelectedIndex)("lpr_id")
            lblTotal.Text = FormatNumber("0", 2)
            lblCantidad.Text = 0
            Me.textcodbar.Focus()
            ShowDialog()
        Else
            MsgAtencion("El usuario actual no posee una caja abierta. Por favor abra una caja y vuelva a intenatrlo")

        End If
    End Sub

    Private Sub TextCodigoBarras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textcodbar.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            If Mid(textcodbar.Text, 1, 1) <> "*" Then
                If Mid(Me.textcodbar.Text, 1, 1) <> "2" And Mid(Me.textcodbar.Text, 2, 6) <> "900000" Then
                    dstArticulo = pwiFacturacion.ExisteArticulo(cadena, Me.textcodbar.Text)
                    If dstArticulo.Tables(0).Rows.Count > 0 Then
                        '    inserto = False
                        If Len(textcodbar.Text) > 1 Then
                            ''            'Trae los valoes del articulo ingresado
                            dstArticuloFact = pwiFacturacion.obtenerArticuloFacturacion(cadena, dstArticulo.Tables(0).Rows(0)("codart"), idListaSeleccionada)
                            ''            'Inserta en la grilla los valores seleccionados
                            VolcarValoresArticulo()
                            pwiFacturacion.InsertarFilasEnGrilla(Me.TextCodigo.Text, Me.Lbldescripcion.Text, CDbl(TextPU.Text), CDbl(Me.TextCantidad.Text), CDbl(Me.LblTotalU.Text), Me.textcodbar.Text, CDbl(Me.textPCompra.Text), Me.GrillaArticulos)
                            ''            'Actualizo el Total
                            Me.lblTotal.Text = CDbl(Me.lblTotal.Text) + CDbl(Me.LblTotalU.Text)

                            ''            'Lo calculo cuando lo guardo 
                            TotalPCompra = TotalPCompra + (Val(textPCompra.Text) * Val(TextCantidad.Text))
                            ''            'HASAR1.ImprimirItem Lbldescripcion.Caption, CDbl(TextCantidad.Text), CDbl(lblTotal.Caption), 21, 0
                            ContarArticulos(CDbl(Me.TextCantidad.Text))
                            LimpiarCajas()
                        Else
                            dstArticuloFact = pwiFacturacion.obtenerArticuloFacturacion(cadena, dstArticulo.Tables(0).Rows(0)("codart"), idListaSeleccionada)
                            dblcantidad = 1
                            Dim auxTot = CDbl(Me.lblTotal.Text)
                            FormPide.Cargar_Formulario(dstArticuloFact.Tables(0).Rows(0)("desc"), dstArticuloFact.Tables(0).Rows(0)("lpd_preciovta"), dstArticuloFact.Tables(0).Rows(0)("codart"), textcodbar.Text, dstArticuloFact.Tables(0).Rows(0)("costo"), Me.GrillaArticulos, auxTot)
                            Me.lblTotal.Text = FormatNumber(auxTot, 2)
                            ContarArticulos(CDbl(dblcantidad))
                            LimpiarCajas()
                            textcodbar.Focus()

                            'TRAER ARTICULOS CANTIDAD

                        End If


                    Else
                        FormAtencion.ShowDialog()
                        Me.textcodbar.Text = ""
                        Me.textcodbar.Focus()



                    End If
                    Else
                        ' si el articulo es fiambre o producto propio
                        Dim PrecioFiambreAux As String
                        Dim CodigoFiambre As String
                        Dim preciofiambre As Double
                        CodigoFiambre = Mid(Me.textcodbar.Text, 2, 6)
                        dstArticulo = pwiFacturacion.ExisteArticulo(cadena, CodigoFiambre)
                        If dstArticulo.Tables(0).Rows.Count > 0 Then
                            PrecioFiambreAux = Mid(Me.textcodbar.Text, 8, 5)
                            preciofiambre = ConvertirPrecio(PrecioFiambreAux)
                        dstArticuloFact = pwiFacturacion.obtenerArticuloFacturacion(cadena, dstArticulo.Tables(0).Rows(0)("codart"), idListaSeleccionada)
                        '--------------------------------
                        Me.TextCodigo.Text = dstArticuloFact.Tables(0).Rows(0)("codart")
                        Me.TextCantidad.Text = "1"
                        Me.Lbldescripcion.Text = dstArticuloFact.Tables(0).Rows(0)("desc")
                        Me.TextPU.Text = preciofiambre
                        Me.LblStock.Text = dstArticuloFact.Tables(0).Rows(0)("stockactual")
                        Me.textPCompra.Text = dstArticuloFact.Tables(0).Rows(0)("lpd_precioC")
                        Me.LblTotalU.Text = CDbl(preciofiambre * CDbl(Me.TextCantidad.Text))

                        '-----------------------------------
                        pwiFacturacion.InsertarFilasEnGrilla(Me.TextCodigo.Text, Me.Lbldescripcion.Text, CDbl(preciofiambre), CDbl(Me.TextCantidad.Text), CDbl(Me.LblTotalU.Text), Me.textcodbar.Text, CDbl(Me.textPCompra.Text), Me.GrillaArticulos)
                            Me.lblTotal.Text = CDbl(Me.lblTotal.Text) + CDbl(Me.LblTotalU.Text)
                            TotalPCompra = TotalPCompra + (CDbl(textPCompra.Text) * CDbl(TextCantidad.Text))
                            ContarArticulos(CDbl(Me.TextCantidad.Text))
                            'CalcularTotal
                            'HASAR1.ImprimirItem Lbldescripcion.Caption, CDbl(TextCantidad.Text), CDbl(lblTotal.Caption), 21, 0
                            LimpiarCajas()
                        Else
                            FormAtencion.ShowDialog()
                            Me.textcodbar.Text = ""
                            Me.textcodbar.Focus()
                        End If
                    End If
                End If
            End If

    End Sub
    Private Sub cmbcliente_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbcliente.SelectionChangeCommitted
        Me.lblLista.Text = dstClientes.Tables(0).Rows(cmbcliente.SelectedIndex)("lpr_descripcion")
        idListaSeleccionada = dstClientes.Tables(0).Rows(cmbcliente.SelectedIndex)("cli_listaprecios")

    End Sub
    Private Sub ArmarGrilla(ByVal dg As DataGridView)

        dg.Columns.Add(("codart"), "Codigo")
        dg.Columns("codart").Width = 100
        dg.Columns("codart").Visible = True
        dg.Columns("codart").ReadOnly = True
        dg.Columns("codart").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft




        'Descripcion
        '   dg.Columns("descri").HeaderText = "Descripcion"
        dg.Columns.Add(("descri"), "Descripción")
        dg.Columns("descri").Width = 100
        dg.Columns("descri").Visible = True
        dg.Columns("descri").ReadOnly = True
        dg.Columns("descri").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        'Precio Unitario
        'dg.Columns("punitario").HeaderText = "Precio Unitario"
        dg.Columns.Add(("punitario"), "P.Unitario")
        dg.Columns("punitario").Width = 100
        dg.Columns("punitario").Visible = True
        dg.Columns("punitario").ReadOnly = True
        dg.Columns("punitario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        'Cantidad
        'dg.Columns("cantidad").HeaderText = "Cantidad"
        dg.Columns.Add(("cantidad"), "Cantidad")

        dg.Columns("cantidad").Width = 80
        dg.Columns("cantidad").Visible = True
        dg.Columns("cantidad").ReadOnly = True
        dg.Columns("cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        'dg.Columns("total").HeaderText = "Total"
        dg.Columns.Add(("total"), "Total")
        dg.Columns("total").Width = 80
        dg.Columns("total").Visible = True
        dg.Columns("total").ReadOnly = True
        dg.Columns("total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'Codigo de barras
        'dg.Columns("codbar").HeaderText = "Codigo de barras"
        dg.Columns.Add(("codbar"), "codbar")
        dg.Columns("codbar").Width = 80
        dg.Columns("codbar").Visible = False
        dg.Columns("codbar").ReadOnly = True
        dg.Columns("codbar").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        ' P.Compra
        'dg.Columns("pcompra").HeaderText = "P.Compra"
        dg.Columns.Add(("pcompra"), "pcompra")
        dg.Columns("pcompra").Width = 80
        dg.Columns("pcompra").Visible = False
        dg.Columns("pcompra").ReadOnly = True
        dg.Columns("pcompra").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


    End Sub

   
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cmbcliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcliente.SelectedIndexChanged

    End Sub
    Private Sub VolcarValoresArticulo()
        Me.TextCodigo.Text = dstArticuloFact.Tables(0).Rows(0)("codart")
        Me.TextCantidad.Text = "1"
        Me.Lbldescripcion.Text = dstArticuloFact.Tables(0).Rows(0)("desc")
        Me.TextPU.Text = dstArticuloFact.Tables(0).Rows(0)("lpd_precioVta")
        Me.LblStock.Text = IIf(Not IsDBNull(dstArticuloFact.Tables(0).Rows(0)("stockactual")), dstArticuloFact.Tables(0).Rows(0)("stockactual"), "Sin datos")
        Me.textPCompra.Text = dstArticuloFact.Tables(0).Rows(0)("lpd_precioC")
        Me.LblTotalU.Text = CDbl(dstArticuloFact.Tables(0).Rows(0)("lpd_preciovta") * CDbl(Me.TextCantidad.Text))

    End Sub
    Private Sub LimpiarCajas()
        Me.textcodbar.Text = ""
        Me.Lbldescripcion.Text = ""
        Me.LblStock.Text = ""
        Me.TextCantidad.Text = ""
        Me.TextCodigo.Text = "0"
        Me.textPCompra.Text = "0"
        Me.TextPU.Text = "0"
        Me.LblTotalU.Text = "0"
        Me.textcodbar.Focus()
    End Sub
    Private Sub ContarArticulos(cantidad As Double)
        If dstArticuloFact.Tables(0).Rows(0)("uni_id") <> 2 Then
            Me.lblCantidad.Text = CDbl(lblCantidad.Text) + cantidad
        Else
            lblCantidad.Text = CDbl(lblCantidad.Text) + 1
        End If
    End Sub

    Private Sub GrillaArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaArticulos.CellContentClick

    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Dim fila As Long = 0
        Dim codart As Long = 0
        If GrillaArticulos.CurrentRow.Cells("codart").Value <> 0 Then
            If MsgPregunta("Está seguro de eliminar el producto") = 6 Then
                If GrillaArticulos.CurrentRow.Cells.Count > 0 Then
                    codart = CLng(GrillaArticulos.CurrentRow.Cells("codart").Value)
                    Dim sele As Integer = GrillaArticulos.CurrentRow.Index
                    Me.lblTotal.Text = FormatNumber(CDbl(lblTotal.Text) - CDbl(GrillaArticulos.CurrentRow.Cells("Total").Value), 2)
                    TotalPCompra = TotalPCompra - (CDbl(GrillaArticulos.CurrentRow.Cells("cantidad").Value) * CDbl(GrillaArticulos.CurrentRow.Cells("punitario").Value))
                    dblcantidad = GrillaArticulos.CurrentRow.Cells("cantidad").Value
                    GrillaArticulos.Rows.RemoveAt(sele)

                    'Busco la unidad del articulo para descontar la cantidad o 1
                    If dstArticuloFact.Tables(0).Rows(0)("uni_id") <> 2 Then
                        Me.lblCantidad.Text = CDbl(lblCantidad.Text) - CDbl(dblcantidad)
                    Else
                        Me.lblCantidad.Text = CDbl(Me.lblCantidad.Text) - 1
                    End If
                    Me.textcodbar.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        Dim paso As Boolean

        paso = False

        ' Guardar en tablas que emulan facturación
        'GrabarFactura_Emulada(True, 1, HASAR1)


        If MsgPregunta("ATENCION: Esta operación CANCELARA el ticket. CANCELA ?") = vbYes Then

            paso = True
            '         HASAR1.CancelarComprobanteFiscal
            '        HASAR1.Finalizar
            Me.Close()


        End If
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim graba As Boolean
        'Dim ultimonro As Long
        'Dim Leyenda As String
        Dim Pbase As Double
        Dim Iva As Double
        Dim dstComprobantesVenta As New DataSet
        Dim dstComprobantesVentaDetalle As New DataSet
        If Origen <> "" Then
            If GrillaArticulos.Rows(0).Cells(0).Value <> "" Then
                If CDbl(lblTotal.Text) > 0 Then
                    graba = False
                    AceptaPago = False
                    FormVuelto.Abrir(Me.lblTotal.Text)
                    If AceptaPago Then

                        Pbase = CDbl(Me.lblTotal.Text) / (1 + (PorcIva / 100))
                        Iva = CDbl(Me.lblTotal.Text) - Pbase
                        'Cargo los datos generales del tiquet
                        dstComprobantesVenta = pwiFacturacion.wflComprobantesVenta_obtenerRegistro(cadena, -1)
                        dstComprobantesVenta.Tables(0).Rows.Add()
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_id") = -1
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_nrocom") = -1
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_tipcom") = 5 'lo fijo poruqe no se elije
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_idcliente") = cmbcliente.SelectedValue
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_fecha") = DtFechaEmi.Value
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_idcondiva") = 3
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_pbase") = Pbase
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_porciva") = PorcIva
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_totcom") = CDbl(Me.lblTotal.Text)
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_idusuario") = idUsuario
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_origen") = Origen
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_dto") = Descuento
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_totaldto") = TotalDto
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_formapago") = IdFormaPago
                        'Campos que agregue para la facturacion libre
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_condicionventa") = 1
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_remito") = ""
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_impuestos") = 0
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_subtotalI") = 0
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_montoiva") = 0
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_nrofactura") = ""
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_pagada") = 1
                        dstComprobantesVenta.Tables(0).Rows(0)("cvt_idsucursal") = My.Settings.cadena


                        'Cargo los elementos de la grilla
                        dstComprobantesVentaDetalle = pwiFacturacion.wflComprobantesVentaDetalle_obtenerRegistro(cadena, -1)
                        Dim j As Integer = 0

                        For j = 0 To GrillaArticulos.Rows.Count - 2

                            dstComprobantesVentaDetalle.Tables(0).Rows.Add()
                            dstComprobantesVentaDetalle.Tables(0).Rows(dstComprobantesVentaDetalle.Tables(0).Rows.Count - 1)("cvd_id") = -1
                            dstComprobantesVentaDetalle.Tables(0).Rows(dstComprobantesVentaDetalle.Tables(0).Rows.Count - 1)("cvd_nrocom") = -1
                            dstComprobantesVentaDetalle.Tables(0).Rows(dstComprobantesVentaDetalle.Tables(0).Rows.Count - 1)("cvd_codart") = GrillaArticulos.Rows(j).Cells("codart").Value
                            dstComprobantesVentaDetalle.Tables(0).Rows(dstComprobantesVentaDetalle.Tables(0).Rows.Count - 1)("cvd_descart") = GrillaArticulos.Rows(j).Cells("descri").Value
                            dstComprobantesVentaDetalle.Tables(0).Rows(dstComprobantesVentaDetalle.Tables(0).Rows.Count - 1)("cvd_cantidad") = GrillaArticulos.Rows(j).Cells("cantidad").Value
                            dstComprobantesVentaDetalle.Tables(0).Rows(dstComprobantesVentaDetalle.Tables(0).Rows.Count - 1)("cvd_precunit") = GrillaArticulos.Rows(j).Cells("punitario").Value
                            dstComprobantesVentaDetalle.Tables(0).Rows(dstComprobantesVentaDetalle.Tables(0).Rows.Count - 1)("cvd_totart") = GrillaArticulos.Rows(j).Cells("Total").Value
                            dstArticulo = pwiFacturacion.ObtenerArticulo(GrillaArticulos.Rows(j).Cells("codart").Value, cadena)
                            dstComprobantesVentaDetalle.Tables(0).Rows(dstComprobantesVentaDetalle.Tables(0).Rows.Count - 1)("cvd_idrubro") = dstArticulo.Tables(0).Rows(0)("rubro")

                        Next

                        graba = pwiFacturacion.wflEmisionFactura_GuardarComprobante(cadena, dstComprobantesVenta, dstComprobantesVentaDetalle, My.Settings.sucursal)

                        If graba Then


                            If Origen = "F" Then
                                '''ImprimirImpresoraComun()
                                'ImprimirTicketFiscal
                            Else

                                'ImprimirImpresoraComun()
                            End If
                            LimpiarCajas()
                            Me.lblCantidad.Text = "0"
                            Me.lblTotal.Text = "0"
                            GrillaArticulos.Rows.Clear()
                            FormEmiteFac_Load(sender, e)
                            '''''PrepararNuevoTicket()
                        End If
                    End If
                Else
                    MsgAtencion("Debe cargar al menos un articulo")
                End If
            Else
                MsgAtencion("No se puede guardar una factura con importe negativo")
            End If
            

        Else
            MsgAtencion("Presione I o F para guardar")
        End If

    End Sub

    'Public Sub ImprimirImpresoraComun()
    '    Dim cantidad As Double
    '    Dim Serie As SerialPort
    '    'ImprimirTitulo


    '    Serie = My.Computer.Ports.OpenSerialPort("COM1")
    '    Serie.Open()
    '    Serie.WriteLine(Chr(27) & "C" & Chr(40)) 'Setea cantidad de lineas verticales)
    '    Serie.WriteLine(Chr(27) & Chr(15) & "FIAMBRERIA VENETTO")
    '    Serie.WriteLine(Chr(27) & Chr(15) & "---------------------------------------")
    '    Serie.WriteLine(Chr(27) & Chr(15) & "Comprobante   X      Doc.No valido")
    '    Serie.WriteLine(Chr(27) & Chr(15) & "Interno              como factura")
    '    Serie.WriteLine(Chr(27) & Chr(15) & "Fecha:" & Me.DtFechaEmi.Value & " Hora:" & Hour(Now))
    '    Serie.WriteLine(Chr(27) & Chr(15) & "---------------------------------------")
    '    Serie.WriteLine(Chr(27) & Chr(15) & "Cant.      Articulo     P.U.    Importe")
    '    Serie.WriteLine(Chr(27) & Chr(15) & "---------------------------------------")

    '    Dim desc As String
    '    Dim canti As Integer
    '    Dim cantidadArticulos As Integer = 0
    '    Dim Punit As Double
    '    Dim leyenda As String = ""

    '    Dim Tot As String
    '    For i = 1 To Me.GrillaArticulos.Rows.Count - 2

    '        'ImprimirItem FormEmiteFac.GrillaArticulos.TextMatrix(i, 3),descripcion
    '        'FormEmiteFac.GrillaArticulos.TextMatrix(i, 5),cantidad
    '        'FormEmiteFac.GrillaArticulos.TextMatrix(i, 4) punitario
    '        If Len(Me.GrillaArticulos.Rows(i).Cells("descri").Value) >= 17 Then
    '            desc = Mid(Me.GrillaArticulos.Rows(i).Cells("descri").Value, 1, 17)
    '        Else
    '            Dim a As New String("", 17 - Len(Me.GrillaArticulos.Rows(i).Cells("descri").Value))
    '            desc = Me.GrillaArticulos.Rows(i).Cells("descri").Value & a

    '        End If

    '        canti = FormatNumber(Me.GrillaArticulos.Rows(i).Cells("cantidad").Value, 2)

    '        Punit = FormatNumber(Me.GrillaArticulos.Rows(i).Cells("punitario").Value, 2)

    '        Tot = Me.GrillaArticulos.Rows(i).Cells("total").Value 'FormatNumber(Me.GrillaArticulos.Rows(i).Cells("cantidad") * FormEmiteFac.GrillaArticulos.TextMatrix(i, 5), 2)
    '        Dim StrTot As New String(" ", 7 - Len(Total))
    '        Tot = StrTot & Tot
    '        Dim StrPunit As New String(" ", 6 - Len(Punit))

    '        canti = CDbl(Me.GrillaArticulos.Rows(i).Cells("cantidad").Value)
    '        Serie.WriteLine(Chr(27) & Chr(15) & FormatNumber(canti, 2) & Chr(9) & desc & Punit & Chr(9) & Tot)
    '        cantidadArticulos = cantidadArticulos + CDbl(canti)

    '    Next i

    '    Serie.WriteLine(Chr(27) & Chr(15) & "---------------------------------------")
    '    Serie.WriteLine(Chr(27) & Chr(15) & "                          TOTAL:" & FormatNumber(Me.lblTotal.Text, 2))
    '    If MontoDesc <> 0 Then
    '        Serie.WriteLine(Chr(27) & Chr(15) & "                        DESCUENTO:" & FormatNumber(MontoDesc, 2))
    '        Serie.WriteLine(Chr(27) & Chr(15) & "                        TOTAL C/ DTO:" & FormatNumber(TotalDto, 2))
    '    End If
    '    Serie.WriteLine(Chr(27) & Chr(15) & "      Son:" & cantidadArticulos; " Articulos")
    '    Serie.WriteLine(Chr(27) & Chr(15) & "      Exija su factura en Caja")



    '    Serie.WriteLine(Chr(12))
    '    Serie.WriteLine(Chr(12))
    '    Serie.WriteLine(Chr(27) & Chr(15) & " " & Leyenda)
    '    Serie.WriteLine(Chr(12))
    '    Serie.WriteLine(Chr(12))
    '    Serie.WriteLine(Chr(12))
    '    Serie.WriteLine(Chr(12))
    '    Serie.WriteLine(Chr(12))
    '    Serie.WriteLine(Chr(12))
    '    Serie.WriteLine(Chr(12))

    '    Serie.Close()
    '    'ImprimirTotales
    'End Sub

    'Private Sub imprimir()
    '    Dim objFSO As FileSystemObject
    '    Dim sW
    '    Dim Dato As String = ""

    '    objFSO = CreateObject("Scripting.FileSystemObject")
    '    sW = objFSO.CreateTextFile(NomImpresora)

    '    sW.WriteLine(Space(_MargLeft) & "----------------------------------------")
    '    Dato = "PRODUCTO   CANT  UND             PRECIO"
    '    sW.WriteLine(Space(_MargLeft) & Dato)
    '    sW.WriteLine(Space(_MargLeft) & "----------------------------------------")

    '    For Each r As DataRow In Dt.Rows

    '        Dato = r(0)

    '        sW.WriteLine(Dato)

    '        Nex()
    'End Sub
    'Public Sub ImprimirImpresoraComun()
    '    Dim cantidad As Double
    '    'ImprimirTitulo
    '   Open "COM1" For Output As #4

    '    Print(Chr(27) & "C" & Chr(40)) 'Setea cantidad de lineas verticales
    '    Print #4, Chr(27) & Chr(15); "FIAMBRERIA VENETTO"
    'Print #4, Chr(27) & Chr(15); "---------------------------------------"
    'Print #4, Chr(27) & Chr(15); "Comprobante   X      Doc.No valido"
    'Print #4, Chr(27) & Chr(15); "Interno              como factura"
    'Print #4, Chr(27) & Chr(15); "Fecha:" & FormEmiteFac.DTFechaEmi.Value & " Hora:" & Time
    'Print #4, Chr(27) & Chr(15); "---------------------------------------"
    'Print #4, Chr(27) & Chr(15); "Cant.      Articulo     P.U.    Importe"
    'Print #4, Chr(27) & Chr(15); "---------------------------------------"
    '    Print()
    '    filas = FormEmiteFac.GrillaArticulos.Rows - 2
    '    cantidadArticulos = 0
    '    For i = 1 To filas
    '        'ImprimirItem FormEmiteFac.GrillaArticulos.TextMatrix(i, 3),descripcion
    '        'FormEmiteFac.GrillaArticulos.TextMatrix(i, 5),cantidad
    '        'FormEmiteFac.GrillaArticulos.TextMatrix(i, 4) punitario
    '        If Len(FormEmiteFac.GrillaArticulos.TextMatrix(i, 3)) >= 17 Then
    '            descri = Mid(FormEmiteFac.GrillaArticulos.TextMatrix(i, 3), 1, 17)
    '        Else
    '            descri = FormEmiteFac.GrillaArticulos.TextMatrix(i, 3) & String$(17 - Len(FormEmiteFac.GrillaArticulos.TextMatrix(i, 3)), " ")
    '        End If
    '        Canti = FormatNumber(FormEmiteFac.GrillaArticulos.TextMatrix(i, 5), 2)
    '        Punit = FormatNumber(FormEmiteFac.GrillaArticulos.TextMatrix(i, 4), 2)
    '        Total = FormatNumber(FormEmiteFac.GrillaArticulos.TextMatrix(i, 4) * FormEmiteFac.GrillaArticulos.TextMatrix(i, 5), 2)
    '        Total = String$(7 - Len(Total), " ") & Total
    '        Punit = String$(6 - Len(Punit), " ") & Punit
    '        cantidad = CDbl(FormEmiteFac.GrillaArticulos.TextMatrix(i, 5))
    '     Print #4, Chr(27) & Chr(15) & FormatNumber(cantidad, 2) & Chr(9) & descri & Punit & Chr( _
    '     9) & Total
    '        cantidadArticulos = cantidadArticulos + CDbl(FormEmiteFac.GrillaArticulos.TextMatrix(i, 5))

    '    Next i

    'Print #4, Chr(27) & Chr(15); "---------------------------------------"
    'Print #4, Chr(27) & Chr(15); "                        TOTAL:" & FormatNumber(FormEmiteFac.LblTotfac.Caption, 2)
    '    If MontoDesc <> 0 Then
    '    Print #4, Chr(27) & Chr(15); "                        DESCUENTO:" & FormatNumber(MontoDesc, 2)
    '    Print #4, Chr(27) & Chr(15); "                        TOTAL C/ DTO:" & FormatNumber(TotalDto, 2)
    '    End If
    '    '    Print #4, Chr(27) & Chr(15); "                        PAGA CON:" & FormatNumber(Paga, 2)
    '    '    Print #4, Chr(27) & Chr(15); "                        VUELTO:" & FormatNumber(Vuelto, 2)
    'Print #4, Chr(27) & Chr(15); "      Son:" & cantidadArticulos; " Articulos"
    'Print #4, Chr(27) & Chr(15); "      Exija su factura en Caja"


    '    'Print #4, Chr(27) & "!" & Chr(0)
    '    'Print #4, Chr(12) 'Form feed
    'Print #4, Chr(12)
    'Print #4, Chr(12)
    'Print #4, Chr(27) & Chr(15); " " & Leyenda
    'Print #4, Chr(12)
    'Print #4, Chr(12)
    'Print #4, Chr(12)
    'Print #4, Chr(12)
    'Print #4, Chr(12)
    'Print #4, Chr(12)
    'Print #4, Chr(12)

    'Close #4
    '    'ImprimirTotales
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New FormBuscarArtFactu
        codartbuscado = 0
        frm.Abrir(idListaSeleccionada)
        If CodartBuscado <> 0 Then
            dstArticuloFact = pwiFacturacion.obtenerArticuloFacturacion(cadena, CodartBuscado, idListaSeleccionada)
            'Inserta en la grilla los valores seleccionados
            Me.textcodbar.Text = CodigoBarrasBuscado
            VolcarValoresArticulo()
        End If
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        If Me.textcodbar.Text <> "" Then
            pwiFacturacion.InsertarFilasEnGrilla(Me.TextCodigo.Text, Me.Lbldescripcion.Text, CDbl(TextPU.Text), CDbl(Me.TextCantidad.Text), CDbl(Me.LblTotalU.Text), Me.textcodbar.Text, CDbl(Me.textPCompra.Text), Me.GrillaArticulos)
            ''            'Actualizo el Total
            Me.lblTotal.Text = CDbl(Me.lblTotal.Text) + CDbl(Me.LblTotalU.Text)

            ''            'Lo calculo cuando lo guardo 
            TotalPCompra = TotalPCompra + (Val(textPCompra.Text) * Val(TextCantidad.Text))
            ''            'HASAR1.ImprimirItem Lbldescripcion.Caption, CDbl(TextCantidad.Text), CDbl(lblTotal.Caption), 21, 0
            ContarArticulos(CDbl(Me.TextCantidad.Text))
            LimpiarCajas()
        End If
    End Sub

    Private Sub textcodbar_TextChanged(sender As Object, e As EventArgs) Handles textcodbar.TextChanged

    End Sub
End Class