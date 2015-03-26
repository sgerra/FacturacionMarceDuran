Imports System.Globalization
Public Class FormModificaCompra

    Dim strMensaje As String
    Dim pwiModifica As New pwiModificaCompra
    Dim Idcompra As Integer
    Dim dstArticulos As New DataSet
    Dim ds As New DataSet
    Dim dsdeta As New DataSet
    Public Shared Function Cargar_Combobox(ByVal dt As DataTable, ByRef cbx As Windows.Forms.ComboBox)
        If dt.Rows.Count > 0 Then
            cbx.DataSource = dt
            cbx.ValueMember = dt.Columns(0).ToString()
            cbx.DisplayMember = dt.Columns(1).ToString()
        End If
        Return Nothing
    End Function
    Public Sub AbrirFormulario(ByVal idCom As Integer)
        
        CargarCombos()
        Idcompra = idCom
        pwiModifica.wflCompras_obtenerCompra(My.Settings.cadena, Idcompra, ds, dsdeta)
        AsignarDatos(ds, dsdeta)
        Me.ShowDialog()

    End Sub
    Private Sub AsignarDatos(ds As DataSet, dsdeta As DataSet)
        Dim i As Integer

        '--------Asigno los datos de la cabecera de la factura
        Me.txtNroFactura.Text = ds.Tables(0).Rows(0)("nrofactura")
        Me.dtFecha.Value = ds.Tables(0).Rows(0)("fecha")
        Me.cmbFormasPAgoProv.SelectedValue = ds.Tables(0).Rows(0)("idcondpago")
        Me.cmbtiposFactura.SelectedValue = ds.Tables(0).Rows(0)("idtipofact")
        Me.cmbEstado.SelectedValue = ds.Tables(0).Rows(0)("idestado")
        Me.cmbProveedores.SelectedValue = ds.Tables(0).Rows(0)("idproveedor")
        Me.txtobservaciones.Text = ds.Tables(0).Rows(0)("observaciones")
        Me.txtPbase.Value = ds.Tables(0).Rows(0)("pbasetot")
        Me.txtIva.Value = ds.Tables(0).Rows(0)("ivatot")
        Me.txtImpInt.Value = ds.Tables(0).Rows(0)("impinttot")
        Me.txtPercepIva.Value = ds.Tables(0).Rows(0)("percepivatot")
        Me.txtIb.Value = ds.Tables(0).Rows(0)("percepIBtot")
        Me.txtDto.Value = ds.Tables(0).Rows(0)("descuentotot")
        Me.txttotal.Value = ds.Tables(0).Rows(0)("total")

        Dim idprov As Integer = cmbProveedores.SelectedIndex.ToString() + 1


        '------------Asignamos a la grilla-------------------------------------------------------------------
        For Each dr As DataRow In dsdeta.Tables(0).Rows
            GrillaArticulos.Rows.Add(dr("codart"), dr("descri"), _
                                     dr("punitfinal"), dr("cantidad"), dr("uni_id"), _
                                    dr("uni_descripcion"), dr("total"), dr("precio"), _
                                     dr("montoiva"), dr("montopercep"), dr("montodto"))

        Next




        'Anterior con combos!
        'For i = 0 To dsdeta.Tables(0).Rows.Count - 1


        '    'GrillaArticulos.Rows.Add(dsdeta.Tables(0).Rows(i)("iddet"), dsdeta.Tables(0).Rows(i)("codart"), "", dsdeta.Tables(0).Rows(i)("cantidad"), dsdeta.Tables(0).Rows(i)("uni_id"), dsdeta.Tables(0).Rows(i)("uni_descripcion"), _
        '    '                         dsdeta.Tables(0).Rows(i)("precio"), dsdeta.Tables(0).Rows(i)("porciva"), dsdeta.Tables(0).Rows(i)("montoiva"), _
        '    '                         dsdeta.Tables(0).Rows(i)("porci"), dsdeta.Tables(0).Rows(i)("montoimpint"), dsdeta.Tables(0).Rows(i)("porcdto"), _
        '    '                         dsdeta.Tables(0).Rows(i)("montodto"), dsdeta.Tables(0).Rows(i)("punitfinal"), dsdeta.Tables(0).Rows(i)("total"))
        '    'Dim row As DataGridViewRow = GrillaArticulos.Rows(i)
        '    'Dim cell As DataGridViewComboBoxCell = TryCast(row.Cells("codart"), DataGridViewComboBoxCell)
        '    'Dim row2 As DataGridViewRow = GrillaArticulos.Rows(i)
        '    'Dim cell2 As DataGridViewComboBoxCell = TryCast(row2.Cells("desc"), DataGridViewComboBoxCell)
        '    'cell2.Value = dsdeta.Tables(0).Rows(i)("codart")

        'Next

        '--------------------------------------------------------------------------------------------------------

    End Sub


    Private Sub CargarCombos()

        Dim dttiposFactura As New DataTable
        Dim dtFormasPagoProv As New DataTable
        Dim dtEstado As New DataTable
        Dim dtProv As New DataTable
        '-------------Cargo los combos de la pantalla con Dataset--------------------------------------------
        dttiposFactura = pwiCompras.wflCompras_tposFactura_obtenerLista(My.Settings.cadena).Tables(0)
        Cargar_Combobox(dttiposFactura, cmbtiposFactura)


        dtFormasPagoProv = pwiCompras.wflCompras_FormasPagoProv_obtenerLista(My.Settings.cadena).Tables(0)
        Cargar_Combobox(dtFormasPagoProv, cmbFormasPAgoProv)

        dtEstado = pwiCompras.wflCompras_TposEstadosFactura_obtenerLista(My.Settings.cadena).Tables(0)
        Cargar_Combobox(dtEstado, cmbEstado)

        dtProv = pwiCompras.wflCompras_Proveedores_obtenerLista(My.Settings.cadena).Tables(0)
        Cargar_Combobox(dtProv, cmbProveedores)
        '------------------------------------------------------------------------------------------------------


    End Sub
    'Private Sub cmbProveedores_DropDownClosed(sender As Object, e As EventArgs) Handles cmbProveedores.DropDownClosed
    '    'obtener los productos del proveedor
    '    Dim idprov As Integer = cmbProveedores.SelectedIndex.ToString() + 1
    '    Dim dr As DataView

    '    dr = pwiCompras.wflCompras_Articulos_obtenerPorductosPorProveedor(My.Settings.cadena, idprov)
    '    Dim comboboxColumn As DataGridViewComboBoxColumn = GrillaArticulos.Columns("desc")
    '    comboboxColumn.DataSource = dr
    '    comboboxColumn.DisplayMember = "desc"
    '    comboboxColumn.ValueMember = "codart"

    '    Dim comboboxColumn2 As DataGridViewComboBoxColumn = GrillaArticulos.Columns("Codart")
    '    comboboxColumn2.DataSource = dr
    '    comboboxColumn2.DisplayMember = "cod"
    '    comboboxColumn2.ValueMember = "codart"

    '    GrillaArticulos.AutoGenerateColumns = False

    'End Sub

    'Private Sub GrillaArticulos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
    '    Dim Canti As Double
    '    Dim PorcIva As Double
    '    Dim PorcImpInt As Double
    '    Dim PorcDto As Double
    '    Dim fila As Integer

    '    Canti = GrillaArticulos.CurrentRow.Cells("cantidad").Value
    '    If e.ColumnIndex = 3 Then

    '        PorcIva = GrillaArticulos.CurrentRow.Cells("Porciva").Value
    '        GrillaArticulos.CurrentRow.Cells("iva").Value = (GrillaArticulos.CurrentRow.Cells("costo").Value * GrillaArticulos.CurrentRow.Cells("Porciva").Value) / 100
    '        PorcImpInt = GrillaArticulos.CurrentRow.Cells("PorcImpInt").Value
    '        GrillaArticulos.CurrentRow.Cells("impint").Value = (CDbl(GrillaArticulos.CurrentRow.Cells("costo").Value) * PorcImpInt) / 100
    '        PorcDto = GrillaArticulos.CurrentRow.Cells("Porcdto").Value
    '        GrillaArticulos.CurrentRow.Cells("dto").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value) * PorcDto) / 100
    '        GrillaArticulos.CurrentRow.Cells("Punit").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value - GrillaArticulos.CurrentRow.Cells("dto").Value))
    '        GrillaArticulos.CurrentRow.Cells("total").Value = (GrillaArticulos.CurrentRow.Cells("punit").Value) * Canti
    '        CalcularTotales()

    '        fila = GrillaArticulos.CurrentRow.Index + 1
    '    End If

    '    If e.ColumnIndex = 11 Then
    '        PorcDto = GrillaArticulos.CurrentRow.Cells("Porcdto").Value
    '        GrillaArticulos.CurrentRow.Cells("dto").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value) * PorcDto) / 100
    '        GrillaArticulos.CurrentRow.Cells("Punit").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value - GrillaArticulos.CurrentRow.Cells("dto").Value))
    '        GrillaArticulos.CurrentRow.Cells("total").Value = (GrillaArticulos.CurrentRow.Cells("punit").Value) * Canti
    '        CalcularTotales()
    '    End If

    '    If e.ColumnIndex = 9 Then
    '        PorcImpInt = GrillaArticulos.CurrentRow.Cells("PorcImpInt").Value
    '        GrillaArticulos.CurrentRow.Cells("impint").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value) + GrillaArticulos.CurrentRow.Cells("iva").Value) * PorcImpInt / 100
    '        GrillaArticulos.CurrentRow.Cells("Punit").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value - GrillaArticulos.CurrentRow.Cells("dto").Value))
    '        GrillaArticulos.CurrentRow.Cells("total").Value = (GrillaArticulos.CurrentRow.Cells("punit").Value) * Canti
    '        CalcularTotales()
    '    End If

    '    If e.ColumnIndex = 7 Then
    '        PorcIva = GrillaArticulos.CurrentRow.Cells("PorcIva").Value
    '        GrillaArticulos.CurrentRow.Cells("iva").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value) * PorcIva) / 100
    '        GrillaArticulos.CurrentRow.Cells("Punit").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value - GrillaArticulos.CurrentRow.Cells("dto").Value))
    '        GrillaArticulos.CurrentRow.Cells("total").Value = (GrillaArticulos.CurrentRow.Cells("punit").Value) * Canti
    '        CalcularTotales()
    '    End If

    '    If e.ColumnIndex = 6 Then 'columna de precio
    '        PorcIva = GrillaArticulos.CurrentRow.Cells("PorcIva").Value
    '        GrillaArticulos.CurrentRow.Cells("iva").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value) * PorcIva) / 100
    '        GrillaArticulos.CurrentRow.Cells("Punit").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value - GrillaArticulos.CurrentRow.Cells("dto").Value))
    '        GrillaArticulos.CurrentRow.Cells("total").Value = (GrillaArticulos.CurrentRow.Cells("punit").Value) * Canti
    '        CalcularTotales()
    '        GrillaArticulos.CurrentRow.Cells("actualizar").Value = True
    '    End If

    'End Sub

    'Private Sub GrillaArticulos_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs)

    '    Dim dgvCombo As DataGridViewComboBoxEditingControl = TryCast(e.Control, DataGridViewComboBoxEditingControl)

    '    If dgvCombo IsNot Nothing Then
    '        '
    '        ' se remueve el handler previo que pudiera tener asociado, a causa ediciones previas de la celda
    '        ' evitando asi que se ejecuten varias veces el evento
    '        '

    '        RemoveHandler dgvCombo.DropDownClosed, New EventHandler(AddressOf dvgCombo_DropDownClosed)
    '        AddHandler dgvCombo.DropDownClosed, New EventHandler(AddressOf dvgCombo_DropDownClosed)

    '    End If

    'End Sub

    'Private Sub dvgCombo_DropDownClosed(sender As Object, e As EventArgs)
    '    '
    '    ' se recupera el valor del combo
    '    ' a modo de ejemplo se escribe en consola el valor seleccionado
    '    '
    '    ' Dim combo As ComboBox = TryCast(sender, ComboBox)
    '    '
    '    ' se accede a la fila actual, para trabajr con otor de sus campos
    '    ' en este caso se marca el check si se cambia la seleccion
    '    '

    '    Try

    '        '
    '        ' se obtiene por el id la info del articulo
    '        '
    '        If GrillaArticulos.CurrentRow.Cells("codart").Selected = False Then
    '            Dim combo As ComboBox = TryCast(sender, ComboBox)
    '            Dim row As DataGridViewRow = GrillaArticulos.CurrentRow
    '            Dim cell As DataGridViewComboBoxCell = TryCast(row.Cells("codart"), DataGridViewComboBoxCell)
    '            Dim Canti As Double
    '            Dim datosArticulo As DataSet = pwiCompras.wflCompras_Articulos_obtenerProductosPorId(My.Settings.cadena, combo.SelectedValue)


    '            cell.Value = datosArticulo.Tables(0).Rows(0)("codart")
    '            GrillaArticulos.CurrentRow.Cells("idunidad").Value = datosArticulo.Tables(0).Rows(0)("uni_id")

    '            If datosArticulo.Tables(0).Rows(0)("uni_id") <> 3 Then
    '                GrillaArticulos.CurrentRow.Cells("costo").Value = datosArticulo.Tables(0).Rows(0)("costo")
    '                GrillaArticulos.CurrentRow.Cells("Porciva").Value = datosArticulo.Tables(0).Rows(0)("lpd_porciva")
    '                GrillaArticulos.CurrentRow.Cells("iva").Value = datosArticulo.Tables(0).Rows(0)("lpd_montoiva")
    '            Else
    '                GrillaArticulos.CurrentRow.Cells("costo").Value = datosArticulo.Tables(0).Rows(0)("costoGranel")
    '                GrillaArticulos.CurrentRow.Cells("Porciva").Value = datosArticulo.Tables(0).Rows(0)("lpd_porciva")
    '                GrillaArticulos.CurrentRow.Cells("iva").Value = (datosArticulo.Tables(0).Rows(0)("costoGranel") * GrillaArticulos.CurrentRow.Cells("Porciva").Value) / 100
    '            End If

    '            GrillaArticulos.CurrentRow.Cells("unidad").Value = datosArticulo.Tables(0).Rows(0)("uni_descripcion")
    '            Canti = GrillaArticulos.CurrentRow.Cells("cantidad").Value
    '            GrillaArticulos.CurrentRow.Cells("PorcImpInt").Value = 0
    '            GrillaArticulos.CurrentRow.Cells("impint").Value = (datosArticulo.Tables(0).Rows(0)("costo") * GrillaArticulos.CurrentRow.Cells("Porcimpint").Value) / 100
    '            GrillaArticulos.CurrentRow.Cells("Porcdto").Value = 0
    '            GrillaArticulos.CurrentRow.Cells("dto").Value = (datosArticulo.Tables(0).Rows(0)("costo") * GrillaArticulos.CurrentRow.Cells("Porcdto").Value) / 100
    '            GrillaArticulos.CurrentRow.Cells("Punit").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value - GrillaArticulos.CurrentRow.Cells("dto").Value))
    '            GrillaArticulos.CurrentRow.Cells("total").Value = (GrillaArticulos.CurrentRow.Cells("punit").Value) * Canti

    '        Else
    '            Dim combo2 As ComboBox = TryCast(sender, ComboBox)
    '            Dim row2 As DataGridViewRow = GrillaArticulos.CurrentRow
    '            Dim cell2 As DataGridViewComboBoxCell = TryCast(row2.Cells("desc"), DataGridViewComboBoxCell)
    '            Dim Canti As Double
    '            Dim datosArticulo As DataSet = pwiCompras.wflCompras_Articulos_obtenerProductosPorId(My.Settings.cadena, combo2.SelectedValue)

    '            cell2.Value = datosArticulo.Tables(0).Rows(0)("codart")
    '            GrillaArticulos.CurrentRow.Cells("idunidad").Value = datosArticulo.Tables(0).Rows(0)("uni_id")

    '            If datosArticulo.Tables(0).Rows(0)("uni_id") <> 3 Then
    '                GrillaArticulos.CurrentRow.Cells("costo").Value = datosArticulo.Tables(0).Rows(0)("costo")
    '                GrillaArticulos.CurrentRow.Cells("Porciva").Value = datosArticulo.Tables(0).Rows(0)("lpd_porciva")
    '                GrillaArticulos.CurrentRow.Cells("iva").Value = datosArticulo.Tables(0).Rows(0)("lpd_montoiva")
    '            Else
    '                GrillaArticulos.CurrentRow.Cells("costo").Value = datosArticulo.Tables(0).Rows(0)("costoGranel")
    '                GrillaArticulos.CurrentRow.Cells("Porciva").Value = datosArticulo.Tables(0).Rows(0)("lpd_porciva")
    '                GrillaArticulos.CurrentRow.Cells("iva").Value = (datosArticulo.Tables(0).Rows(0)("costoGranel") * GrillaArticulos.CurrentRow.Cells("Porciva").Value) / 100
    '            End If


    '            GrillaArticulos.CurrentRow.Cells("unidad").Value = datosArticulo.Tables(0).Rows(0)("uni_descripcion")
    '            Canti = GrillaArticulos.CurrentRow.Cells("cantidad").Value
    '            GrillaArticulos.CurrentRow.Cells("PorcImpInt").Value = 0
    '            GrillaArticulos.CurrentRow.Cells("impint").Value = (datosArticulo.Tables(0).Rows(0)("costo") * GrillaArticulos.CurrentRow.Cells("Porcimpint").Value) / 100
    '            GrillaArticulos.CurrentRow.Cells("Porcdto").Value = 0
    '            GrillaArticulos.CurrentRow.Cells("dto").Value = (datosArticulo.Tables(0).Rows(0)("costo") * GrillaArticulos.CurrentRow.Cells("Porcdto").Value) / 100
    '            GrillaArticulos.CurrentRow.Cells("Punit").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value - GrillaArticulos.CurrentRow.Cells("dto").Value))
    '            GrillaArticulos.CurrentRow.Cells("total").Value = (GrillaArticulos.CurrentRow.Cells("punit").Value) * Canti
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub btnProd_Click(sender As Object, e As EventArgs)
        GrillaArticulos.Enabled = True
        cmbProveedores.Enabled = False
    End Sub

   

    Private Sub btnCancelaModifica_Click(sender As Object, e As EventArgs) Handles btnCancelaModifica.Click
        If MsgBox("¿Está seguro que desea salir sin grabar el pedido?", vbYesNoCancel, "Aviso al operador") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If MsgBox("¿Desea modificar los datos del pedido?", MsgBoxStyle.YesNo, "Aviso al operador") = MsgBoxResult.Yes Then
            If pwiModificaCompra.wflCompras_actualizarRegistro(My.Settings.cadena, Idcompra, GrillaArticulos, Me.cmbFormasPAgoProv.SelectedValue, _
                                                   Me.cmbtiposFactura.SelectedValue, Me.cmbEstado.SelectedValue, _
                                                   Me.cmbProveedores.SelectedValue, strMensaje, Me.txtNroFactura.Text, _
                                                   Me.dtFecha.Value, Me.txtobservaciones.Text, CDbl(Me.txtPbase.Value), _
                                                   CDbl(Me.txtIva.Value), CDbl(Me.txtImpInt.Value), CDbl(Me.txtPercepIva.Value), _
                                                   CDbl(Me.txtIb.Value), CDbl(Me.txtDto.Value), CDbl(Me.txttotal.Value)) Then

                MsgBox("El pedido se ha grabado con éxito", vbOKOnly, "Aviso al operador")
                If MsgBox("¿Desea imprimir el pedido?", MsgBoxStyle.YesNoCancel, "Aviso al operador") = MsgBoxResult.Yes Then
                    Dim frm As New FormImprimeReporte
                    frm.AbrirFormulario(Idcompra)
                End If
                Me.Close()

            End If
        End If
    End Sub
    Private Sub txtPercepIva_GotFocus(sender As Object, e As EventArgs)
        Me.txtPercepIva.SelectionStart = 0
        Me.txtPercepIva.SelectionLength = Len(Me.txtPercepIva.Text)
    End Sub

    

    Private Sub txtPercepIva_LostFocus(sender As Object, e As EventArgs)
        ModificarTotales()
    End Sub

    Private Sub txtPbase_GotFocus(sender As Object, e As EventArgs)
        Me.txtPbase.SelectionStart = 0
        Me.txtPbase.SelectionLength = Len(Me.txtPbase.Text)
    End Sub

    


    

    

    Private Sub txtiva_LostFocus(sender As Object, e As EventArgs)
        ModificarTotales()
    End Sub

   
    '******************************ImpInt

    Private Sub txtimpint_GotFocus(sender As Object, e As EventArgs)
        Me.txtImpInt.SelectionStart = 0
        Me.txtImpInt.SelectionLength = Len(Me.txtIva.Text)
    End Sub

    

    Private Sub txtimpint_LostFocus(sender As Object, e As EventArgs)
        ModificarTotales()
    End Sub

  
    '*****************IB************************************************************************************

    Private Sub txtib_GotFocus(sender As Object, e As EventArgs)
        Me.txtIb.SelectionStart = 0
        Me.txtIb.SelectionLength = Len(Me.txtIb.Text)
    End Sub

    

    Private Sub txtib_LostFocus(sender As Object, e As EventArgs)
        ModificarTotales()
    End Sub

    
    '********************Descuento**************************************************************************

    Private Sub txtDto_GotFocus(sender As Object, e As EventArgs)
        Me.txtDto.SelectionStart = 0
        Me.txtDto.SelectionLength = Len(Me.txtDto.Text)
    End Sub

    Private Sub txtDto_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtDto_LostFocus(sender As Object, e As EventArgs)
        ModificarTotales()
    End Sub

    
    '*****************************************TOTAL******************************************************************

    
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormAgregaArticulos.Abrir(Me.cmbProveedores.SelectedValue, dsdeta)
        CargarGrillaArticulos()
        'VolCarTotales()
    End Sub
    Private Sub VolcarTotales()
        Dim i As Integer
        Dim SumaPbase As Double = 0
        Dim SumaIva As Double = 0
        Dim SumaPercep As Double = 0
        Dim SumaDto As Double = 0

        For i = 0 To GrillaArticulos.Rows.Count - 2
            SumaPbase = SumaPbase + (GrillaArticulos.Rows(i).Cells("Costo").Value) * CDbl(GrillaArticulos.Rows(i).Cells("Cantidad").Value)
            SumaIva = SumaIva + (GrillaArticulos.Rows(i).Cells("iva").Value) * CDbl(GrillaArticulos.Rows(i).Cells("Cantidad").Value)
            SumaPercep = SumaPercep + ((GrillaArticulos.Rows(i).Cells("Percep").Value) * CDbl(GrillaArticulos.Rows(i).Cells("Cantidad").Value))
            SumaDto = SumaDto + ((GrillaArticulos.Rows(i).Cells("dto").Value) * CDbl(GrillaArticulos.Rows(i).Cells("Cantidad").Value))
        Next

        Me.txtPbase.Text = FormatNumber(SumaPbase, 2)
        Me.txtIva.Text = FormatNumber(SumaIva, 2)
        Me.txtPercepIva.Text = FormatNumber(SumaPercep, 2)
        Me.txtDto.Text = FormatNumber(SumaDto, 2)
        ModificarTotales()

    End Sub

    Private Function ModificarTotales()
        Me.txttotal.Value = CDbl(Me.txtPbase.Value) + CDbl(Me.txtIva.Value) + CDbl(Me.txtImpInt.Value) + CDbl(Me.txtPercepIva.Value) + CDbl(Me.txtIb.Value) - CDbl(Me.txtDto.Value)
    End Function
    Private Sub CargarGrillaArticulos()

        Dim lngNroError As Long

        Try
            lngNroError = 0
            GrillaArticulos.Rows.Clear()
            For Each row In dsdeta.Tables(0).Rows
                GrillaArticulos.Rows.Add(row("codart"), row("descri"), row("punitfinal"), row("cantidad"), row("idunidad"), row("uni_descripcion"), row("total"), row("precio"), row("montoiva"), row("montopercep"), row("montodto"))
            Next

        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub FormModificaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPbase_TextChanged(sender As Object, e As EventArgs) Handles txtPbase.TextChanged
        CalcularTotal()
    End Sub

    Private Sub txtIva_TextChanged(sender As Object, e As EventArgs) Handles txtIva.TextChanged
        CalcularTotal()
    End Sub
    Private Sub txtIva_GotFocus(sender As Object, e As EventArgs) Handles txtIva.GotFocus
        Me.txtIva.Value = CDbl(Me.txtPbase.Value) * (PorcIva / 100)
    End Sub
    Private Sub txtImpInt_TextChanged(sender As Object, e As EventArgs) Handles txtImpInt.TextChanged
        CalcularTotal()
    End Sub

    Private Sub txtPercepIva_TextChanged(sender As Object, e As EventArgs) Handles txtPercepIva.TextChanged
        CalcularTotal()
    End Sub

    Private Sub txtIb_TextChanged(sender As Object, e As EventArgs) Handles txtIb.TextChanged
        CalcularTotal()
    End Sub

    Private Sub txtDto_TextChanged(sender As Object, e As EventArgs) Handles txtDto.TextChanged
        CalcularTotal()
    End Sub

    Private Sub CalcularTotal()
        Me.txttotal.Value = Me.txtPbase.Value + Me.txtIva.Value + Me.txtImpInt.Value + Me.txtPercepIva.Value + Me.txtIb.Value - Me.txtDto.Value
    End Sub


    Private Sub txttotal_GotFocus(sender As Object, e As EventArgs)
        Me.txttotal.SelectionStart = 0
        Me.txttotal.SelectionLength = Len(Me.txttotal.Text)
    End Sub

    Private Sub txttotal_KeyPress(sender As Object, e As KeyPressEventArgs)

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPbase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPbase.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

   
    Private Sub txtIva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIva.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txtImpInt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImpInt.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub
    Private Sub txtPercepIva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPercepIva.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txtIb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIb.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub
End Class