Imports AppFacturacion.pwiFacturacion
Imports System.IO

Public Class FormArticulos
    Dim dstArticulos As DataSet
    Dim NuevoReg As DataRow
    Dim cadena As String
    Dim dstListasPrecios As New DataSet
    Dim dstListasPreciosDet As New DataSet
    Dim dstStockPorDepo As New DataSet
    Dim strMensaje As String
    Dim lngIdArticulo As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancelar.Click
        If MsgPregunta("¿Desea cancelar la carga del articulo ?") Then
            Me.Close()
        End If
    End Sub

    Private Sub FormArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cadena = My.Settings.cadena

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If MsgBox(" ¿Desea guardar el articulo ? ", MsgBoxStyle.YesNoCancel, "AVISO") = MsgBoxResult.Yes Then
            Try
                If validarCampos() Then

                    dstArticulos = pwiArticulos.wflArticulos_Articulos_obtenerRegistro(cadena, -1)
                    NuevoReg = dstArticulos.Tables(0).NewRow
                    NuevoReg("codart") = -1
                    NuevoReg("cod") = txtcb.Text
                    NuevoReg("desc") = txtdesc.Text
                    NuevoReg("rubro") = cmbrubro.SelectedValue
                    NuevoReg("costo") = CDbl(Me.txtPCosto.Value)
                    NuevoReg("activo") = "S"
                    NuevoReg("signo") = cmbSigno.SelectedItem
                    NuevoReg("idproveedor") = cmbProveedor.SelectedValue
                    NuevoReg("uni_id") = cmbUnidad.SelectedValue
                    NuevoReg("idetiqueta") = cmbEtiqueta.SelectedValue
                    NuevoReg("costogranel") = CDbl(Me.txtCostoGranel.Value)
                    NuevoReg("unidadesgranel") = CDbl(Me.txtUniGranel.Value)
                    If Not IsNothing(PictureBox1.Image) Then
                        Dim ms As New MemoryStream
                        PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif)
                        Dim pic As Byte() = ms.GetBuffer
                        NuevoReg("imagen") = pic
                    Else
                        Dim ms As New MemoryStream
                        Dim pic As Byte() = ms.GetBuffer

                        NuevoReg("imagen") = pic
                    End If
                    dstArticulos.Tables(0).Rows.Add(NuevoReg)
                    pwiArticulos.wflArticulos_InsertarArticulos(cadena, dstArticulos, dstListasPreciosDet, dstStockPorDepo, strMensaje)
                    MsgBox(strMensaje, vbInformation + vbOKOnly, "Aviso al operador")
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox("Se ha producido un error en la aplicación" + "  " + ex.Message, MsgBoxStyle.Critical, "Aviso")
            End Try
        End If
    End Sub
    Private Function validarCampos() As Boolean
        validarCampos = True
        If Me.txtcb.Text = "" Then
            MsgBox("Ingrese el código de barras", vbOKOnly, "Aviso al operador")
            Me.txtcb.Focus()
            validarCampos = False
            Exit Function
        End If

        If Me.txtdesc.Text = "" Then
            MsgBox("Ingrese la descripción del articulo", vbOKOnly, "Aviso al operador")
            Me.txtcb.Focus()
            validarCampos = False
            Exit Function
        End If

        If Me.txtPCosto.Value = 0 Then
            MsgBox("Ingrese el precio de costo del articulo", vbOKOnly, "Aviso al operador")
            Me.txtPCosto.Focus()
            validarCampos = False
            Exit Function
        End If


        If Me.cmbSigno.Text = "" Then
            MsgBox("Ingrese el signo del articulo", vbOKOnly, "Aviso al operador")
            Me.cmbSigno.Focus()
            validarCampos = False
            Exit Function
        End If

        If Me.chkStock.Checked = True Then
            If dstStockPorDepo.Tables(0).Rows.Count = 0 Then
                MsgBox("Al estar checkeado el control de stock, debe cargar al menos una linea", vbOKOnly, "Aviso al operador")
                validarCampos = False
                Exit Function
            End If
        End If
        Dim lista1Cargada As Boolean = False
        If dstListasPreciosDet.Tables(0).Rows.Count > 0 Then
            For Each dr As DataRow In dstListasPreciosDet.Tables(0).Rows
                If dr("lpr_id") = 1 Then
                    lista1Cargada = True
                    Exit For
                End If

            Next
        Else
            MsgInformacion("Debe cargar al menos una lista de precios")
            validarCampos = False
            Exit Function
        End If
        If Not lista1Cargada Then
            MsgInformacion("La lista número 1 se debe estar siempre cargada.")
            validarCampos = False
            Exit Function
        End If
    End Function

    Public Sub Abrirformulario(ByVal codigo As String)
        Try
            Dim dtProv As New DataTable
            Dim dtRub As New DataTable
            Dim dtUni As New DataTable
            Dim dtEti As New DataTable
            cadena = My.Settings.cadena


            '---Cargo el combo de proveedores------------------------------------------------------
            dtProv = pwiArticulos.wflArticulos_Proveedores_obtenerLista(cadena).Tables(0)
            Cargar_Combobox(dtProv, cmbProveedor)
            '---------------------------------------------------------------------------------------

            '---Cargo el combo de Rubros------------------------------------------------------
            dtRub = pwiArticulos.wflArticulos_tRubros_obtenerLista(cadena).Tables(0)
            Cargar_Combobox(dtRub, cmbrubro)
            '---------------------------------------------------------------------------------------

            '---Cargo el combo de Unidades------------------------------------------------------
            dtUni = pwiArticulos.wflArticulos_Unidades_obtenerLista(cadena).Tables(0)
            Cargar_Combobox(dtUni, cmbUnidad)
            '---------------------------------------------------------------------------------------

            '---Cargo el combo de Etiquetas------------------------------------------------------
            dtEti = pwiArticulos.wflArticulos_Etiquetas_obtenerLista(cadena).Tables(0)
            Cargar_Combobox(dtEti, cmbEtiqueta)
            '---------------------------------------------------------------------------------------
            ' ---Cargar Listas de Precios-----
            dstListasPrecios = pwiArticulos.wflArticulos_ListasPrecios_obtenerLista(cadena)

            CargarListasPrecios(dstListasPrecios)

            dstArticulos = pwiFacturacion.ObtenerArticulo(codigo, cadena)
            dstListasPreciosDet = pwiArticulos.wflArticulos_ListasPreciosDet_obtenerLista(cadena, codigo)
            dstListasPreciosDet.Tables(0).Columns.Add("eliminado")

            lngIdArticulo = -1

            dstStockPorDepo = pwiArticulos.wflArticulos_StockPorDeposito_obtenerLista(cadena, codigo)
            CargarGrillaStock()

            txtcb.Text = ""
            txtdesc.Text = ""
            txtCostoGranel.Value = 0
            txtPCosto.Value = 0
            btnaceptar.Visible = True
            Me.cmbSigno.SelectedIndex = 0
            Me.ShowDialog()
        Catch ex As Exception
            MsgBox("Se ha producido un error en la aplicación" + "  " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub
    Private Sub CargarListasPrecios(ds As DataSet)
        'Private Sub CargarGrillaBoni()
        Dim lngNroError As Long

        Try
            lngNroError = 0
            Dim i As Integer

            i = 1
            If Not ds Is Nothing Then
                For Each row In ds.Tables(0).Rows
                    DataGridListas.Rows.Add(row("lpr_id"), row("lpr_descripcion"), False, row("lpr_porcutil"))
                Next
            End If

        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try



    End Sub
    Public Shared Function Cargar_Combobox(ByVal dt As DataTable, ByRef cbx As Windows.Forms.ComboBox)
        If dt.Rows.Count > 0 Then
            cbx.DataSource = dt
            cbx.ValueMember = dt.Columns(0).ToString()
            cbx.DisplayMember = dt.Columns(1).ToString()
        End If
        Return Nothing
    End Function

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox(" ¿Desea modificar el articulo ? ", MsgBoxStyle.YesNoCancel, "AVISO") = MsgBoxResult.Yes Then
            Try
                dstArticulos.Tables(0).Rows(0).Item("cod") = txtcb.Text
                dstArticulos.Tables(0).Rows(0).Item("desc") = txtdesc.Text
                '       dstArticulos.Tables(0).Rows(0).Item("costo") = txtpcompra.Text
                '      dstArticulos.Tables(0).Rows(0).Item("costo_iva") = txtiva.Text
                '     dstArticulos.Tables(0).Rows(0).Item("precio") = txtpventa.Text
                '    dstArticulos.Tables(0).Rows(0).Item("activo") = cmbactivo.SelectedItem
                'pltFacturacion.ActualizarArticulo(cadena, dstArticulos)
                MsgBox("El articulo se ha modificado con éxito en la base de datos")
                Close()
                FormBuscarArticulos.ShowDialog()
            Catch ex As Exception
                MsgBox("Se ha producido un error en la aplicación" + "  " + ex.Message, MsgBoxStyle.Critical, "Aviso")
            End Try
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtUniGranel_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCostoGranel_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        Dim frm As New FormAgregaPrecio
        If Me.txtPCosto.Value > 0 Then
            frm.Abrir(dstListasPreciosDet, dstListasPrecios.Tables(0), CDbl(Me.txtPCosto.Value), lngIdArticulo)
            Me.GrillaPrecios.Rows.Clear()
            CargarGrillaPrecios()

        Else
            MsgBox("Antes de cargar los precios debe completar el precio de costo")
            Me.txtPCosto.Focus()
        End If
    End Sub
    Private Sub CargarGrillaPrecios()
        Dim lngNroError As Long

        Try
            lngNroError = 0
            Dim i As Integer

            i = 1
            If Not dstListasPreciosDet Is Nothing Then
                For Each row In dstListasPreciosDet.Tables(0).Rows
                    If row("eliminado") = "N" Then
                        GrillaPrecios.Rows.Add(row("lpd_lpr_id"), row("lpr_descripcion"), row("lpd_precioc"), row("lpd_porciva"), row("lpd_montoiva"), row("lpd_porcdesc"), row("lpd_montodesc"), row("lpd_porcpercep"), row("lpd_montopercep"), row("lpd_preciosubtotal"), row("lpd_porcutil"), row("lpd_utilidad"), row("lpd_preciovta"), row("lpd_fecmodipr"))
                    End If
                Next
            End If

        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try


    End Sub
    Private Sub CargarGrillaStock()
        Dim lngNroError As Long

        Try
            lngNroError = 0

            If Not dstStockPorDepo Is Nothing Then
                For Each row In dstStockPorDepo.Tables(0).Rows
                    If row("eliminado") = 0 Then
                        GrillaStock.Rows.Add(row("iddeposito"), row("deposito"), row("stockinicial"), row("stockmaximo"), row("stockminimo"), row("stockactual"), row("fechainv"))
                    End If
                Next
            End If

        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try


    End Sub
    Private Sub btnProagaCosto_Click(sender As Object, e As EventArgs) Handles btnProagaCosto.Click
        If CDbl(Me.txtPCosto.Value) > 0 Then
            PropagarCosto()
        Else
            MsgBox("Para propagar el costo, primero debe ingresar un monto ", vbInformation + vbOKOnly, "Aviso al operador")
        End If
    End Sub
    Private Sub PropagarCosto()

        For Each row As DataRow In dstListasPreciosDet.Tables(0).Rows

            row("lpd_precioc") = CDbl(Me.txtPCosto.Value)
            CalcularPrecios(row("lpd_precioc"), row("lpd_porciva"), row("lpd_montoiva"), row("lpd_porcdesc"), row("lpd_montodesc"), row("lpd_porcpercep"), row("lpd_montopercep"), row("lpd_preciosubtotal"), row("lpd_porcutil"), row("lpd_utilidad"), row("lpd_preciovta"))

        Next
        GrillaPrecios.Rows.Clear()
        CargarGrillaPrecios()
    End Sub


    Private Sub btnPropagaLista_Click(sender As Object, e As EventArgs) Handles btnPropagaLista.Click
        Dim i As Integer
        Dim idlista As Integer
        Dim porcUtil As Double
        Dim descrilista As String
        For i = 0 To DataGridListas.Rows.Count - 1
            If DataGridListas.Rows(i).Cells("elegido").Value = True Then
                idlista = DataGridListas.Rows(i).Cells("idlista").Value
                descrilista = DataGridListas.Rows(i).Cells("nombrelista").Value
                porcUtil = DataGridListas.Rows(i).Cells("porcganancia").Value
                If Not estaCargada(idlista) Then
                    CalcularPrecios(GrillaPrecios.Rows(0).Cells("Pbase").Value, GrillaPrecios.Rows(0).Cells("Porciva").Value, GrillaPrecios.Rows(0).Cells("Montoiva").Value, GrillaPrecios.Rows(0).Cells("Porcdto").Value, GrillaPrecios.Rows(0).Cells("Montodto").Value, _
                                    GrillaPrecios.Rows(0).Cells("Porcpercep").Value, GrillaPrecios.Rows(0).Cells("MontoPercep").Value, GrillaPrecios.Rows(0).Cells("PrecioSubt").Value, porcUtil, GrillaPrecios.Rows(0).Cells("Montoutil").Value, GrillaPrecios.Rows(0).Cells("PrecioVenta").Value)

                    dstListasPreciosDet.Tables(0).Rows.Add()
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpr_id") = idlista
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpd_lpr_id") = idlista
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpr_porcutil") = porcUtil
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpr_descripcion") = descrilista
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpd_art_codart") = -1
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpd_idusuario") = idUsuario
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpd_modificado") = "N"
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpd_precioc") = GrillaPrecios.Rows(0).Cells("Pbase").Value
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpd_porciva") = GrillaPrecios.Rows(0).Cells("Porciva").Value
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpd_montoiva") = GrillaPrecios.Rows(0).Cells("montoiva").Value
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpd_porcdesc") = GrillaPrecios.Rows(0).Cells("Porcdto").Value
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpd_montodesc") = GrillaPrecios.Rows(0).Cells("montodto").Value
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpd_porcpercep") = GrillaPrecios.Rows(0).Cells("Porcpercep").Value
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpd_Montopercep") = GrillaPrecios.Rows(0).Cells("Montopercep").Value
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpd_precioSubtotal") = GrillaPrecios.Rows(0).Cells("PrecioSubt").Value
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpd_porcutil") = porcUtil
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpd_utilidad") = GrillaPrecios.Rows(0).Cells("MontoUtil").Value
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpd_PrecioVta") = GrillaPrecios.Rows(0).Cells("PrecioVenta").Value
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("lpd_fecmodipr") = GrillaPrecios.Rows(0).Cells("fechamodi").Value
                    dstListasPreciosDet.Tables(0).Rows(dstListasPreciosDet.Tables(0).Rows.Count - 1)("eliminado") = "N"

                End If


            End If

        Next
        GrillaPrecios.Rows.Clear()
        CargarGrillaPrecios()
    End Sub
    Private Function estaCargada(idlista As Integer) As Boolean
        Dim x As Integer
        estaCargada = False
        For x = 0 To GrillaPrecios.Rows.Count - 1

            If GrillaPrecios.Rows(x).Cells("nrolista").Value = idlista Then
                estaCargada = True
                Exit Function
            End If

        Next
    End Function
    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        If GrillaPrecios.CurrentRow.Selected = True Then
            Dim p As Integer = GrillaPrecios.Rows(GrillaPrecios.CurrentRow.Index).Cells("nrolista").Value
            FormModificarPrecios.Abrir(GrillaPrecios.Rows(GrillaPrecios.CurrentRow.Index).Cells("nrolista").Value, GrillaPrecios.Rows(GrillaPrecios.CurrentRow.Index).Cells("Pbase").Value, GrillaPrecios.Rows(GrillaPrecios.CurrentRow.Index).Cells("Porciva").Value, GrillaPrecios.Rows(GrillaPrecios.CurrentRow.Index).Cells("Montoiva").Value, GrillaPrecios.Rows(GrillaPrecios.CurrentRow.Index).Cells("Porcdto").Value, GrillaPrecios.Rows(GrillaPrecios.CurrentRow.Index).Cells("Montodto").Value, _
                                    GrillaPrecios.Rows(GrillaPrecios.CurrentRow.Index).Cells("Porcpercep").Value, GrillaPrecios.Rows(GrillaPrecios.CurrentRow.Index).Cells("MontoPercep").Value, GrillaPrecios.Rows(GrillaPrecios.CurrentRow.Index).Cells("PrecioSubt").Value, GrillaPrecios.Rows(GrillaPrecios.CurrentRow.Index).Cells("Porcutil").Value, GrillaPrecios.Rows(GrillaPrecios.CurrentRow.Index).Cells("Montoutil").Value, GrillaPrecios.Rows(GrillaPrecios.CurrentRow.Index).Cells("PrecioVenta").Value, dstListasPrecios.Tables(0), dstListasPreciosDet)

            GrillaPrecios.Rows.Clear()
            CargarGrillaPrecios()
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub cmdeliminar_Click(sender As Object, e As EventArgs) Handles cmdeliminar.Click
        Dim i As Integer

        If MsgBox("¿Desea eliminar la lista?", vbYesNoCancel + vbInformation, "Aviso al operador") = 6 Then

            If GrillaPrecios.CurrentRow.Selected = True Then

                i = GrillaPrecios.Rows(GrillaPrecios.CurrentRow.Index).Cells("nrolista").Value

                For Each dr As DataRow In dstListasPreciosDet.Tables(0).Rows
                    If dr("lpr_id") = i Then
                        dr("eliminado") = "S"
                    End If
                Next

                GrillaPrecios.Rows.Clear()
                CargarGrillaPrecios()
            End If
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frm As New FormAgregaStock

        frm.Abrir(dstStockPorDepo, lngIdArticulo)
        GrillaStock.Rows.Clear()
        CargarGrillaStock()

    End Sub

    Private Sub btnModificaStock_Click(sender As Object, e As EventArgs) Handles btnModificaStock.Click
        If GrillaStock.CurrentRow.Selected = True Then

            FormModificaStock.Abrir(GrillaStock.Rows(GrillaStock.CurrentRow.Index).Cells("iddeposito").Value, _
                                     GrillaStock.Rows(GrillaStock.CurrentRow.Index).Cells("stockini").Value, _
                                     GrillaStock.Rows(GrillaStock.CurrentRow.Index).Cells("stockmax").Value, _
                                     GrillaStock.Rows(GrillaStock.CurrentRow.Index).Cells("stockmin").Value, _
                                     GrillaStock.Rows(GrillaStock.CurrentRow.Index).Cells("stockact").Value, _
                                     GrillaStock.Rows(GrillaStock.CurrentRow.Index).Cells("fecin").Value, _
                                     dstStockPorDepo)

            GrillaStock.Rows.Clear()
            CargarGrillaStock()
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim i As Integer

        If MsgBox("¿Desea eliminar el depósito?", vbYesNoCancel + vbInformation, "Aviso al operador") = 6 Then

            If GrillaStock.CurrentRow.Selected = True Then

                i = GrillaStock.Rows(GrillaStock.CurrentRow.Index).Cells("iddeposito").Value

                For Each dr As DataRow In dstStockPorDepo.Tables(0).Rows
                    If dr("iddeposito") = i Then
                        dr("eliminado") = 1
                    End If
                Next

                GrillaStock.Rows.Clear()
                CargarGrillaStock()
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.InitialDirectory = "C:\"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub chkListas_CheckedChanged(sender As Object, e As EventArgs) Handles chkListas.CheckedChanged
        If chkListas.Checked = True Then
            For i = 0 To DataGridListas.RowCount - 1
                If DataGridListas.Item(2, i).Value = False Then
                    DataGridListas.Item(2, i).Value = True
                End If
            Next
        Else
            For i = 0 To DataGridListas.RowCount - 1
                If DataGridListas.Item(2, i).Value = True Then
                    DataGridListas.Item(2, i).Value = False
                End If
            Next
        End If
    End Sub

    Private Sub txtdesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdesc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        e.KeyChar = UCase(e.KeyChar)

    End Sub

    Private Sub txtdesc_TextChanged(sender As Object, e As EventArgs) Handles txtdesc.TextChanged

    End Sub

    Private Sub txtcb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcb.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtcb_TextChanged(sender As Object, e As EventArgs) Handles txtcb.TextChanged

    End Sub

    Private Sub txtCostoGranel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostoGranel.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPCosto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    
    Private Sub txtPCosto_TextChanged(sender As Object, e As EventArgs) Handles txtPCosto.TextChanged

    End Sub

    Private Sub cmbrubro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbrubro.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbrubro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbrubro.SelectedIndexChanged

    End Sub

    Private Sub cmbProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbProveedor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProveedor.SelectedIndexChanged

    End Sub

    Private Sub cmbUnidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbUnidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbUnidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUnidad.SelectedIndexChanged

    End Sub

    Private Sub cmbUnidad_StyleChanged(sender As Object, e As EventArgs) Handles cmbUnidad.StyleChanged

    End Sub

    Private Sub cmbEtiqueta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbEtiqueta.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbEtiqueta_MouseMove(sender As Object, e As MouseEventArgs) Handles cmbEtiqueta.MouseMove

    End Sub

    Private Sub cmbEtiqueta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEtiqueta.SelectedIndexChanged

    End Sub

    Private Sub cmbSigno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbSigno.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbSigno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSigno.SelectedIndexChanged

    End Sub

    Private Sub chkStock_CheckedChanged(sender As Object, e As EventArgs) Handles chkStock.CheckedChanged

    End Sub

    Private Sub chkStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkStock.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtUniGranel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUniGranel.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtUniGranel_LostFocus(sender As Object, e As EventArgs) Handles txtUniGranel.LostFocus
        If CDbl(Me.txtUniGranel.Text) <> 0 Then
            Me.txtPCosto.Value = FormatNumber(CDbl(Me.txtCostoGranel.Value / Me.txtUniGranel.Text), 2)
        End If
    End Sub

    Private Sub txtUniGranel_TextChanged_1(sender As Object, e As EventArgs) Handles txtUniGranel.TextChanged

    End Sub
End Class