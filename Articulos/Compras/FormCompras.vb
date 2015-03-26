Imports System.Globalization
Public Class FormCompras
    Private bJustChanged As Boolean
    Private sInputString As String
    Dim strMensaje As String


    Public Shared Function Cargar_Combobox(ByVal dt As DataTable, ByRef cbx As Windows.Forms.ComboBox)
        If dt.Rows.Count > 0 Then
            cbx.DataSource = dt
            cbx.ValueMember = dt.Columns(0).ToString()
            cbx.DisplayMember = dt.Columns(1).ToString()
        End If
        Return Nothing
    End Function
    Public Sub AbrirFormulario(ByVal idCompra As Integer)

        If idCompra = 0 Then
            Me.ShowDialog()
        Else

        End If

    End Sub
    Private Sub FormCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        '----------------------------Obtengo la ultima compra del proveedor------------------------------------
        



        '------------------------------------------------------------------------------------------------------

    End Sub
    Private Sub cmbProveedores_DropDownClosed(sender As Object, e As EventArgs) Handles cmbProveedores.DropDownClosed
        'obtener los productos del proveedor
        Dim idprov As Integer = cmbProveedores.SelectedIndex.ToString() + 1
        Dim dr As DataView

        dr = pwiCompras.wflCompras_Articulos_obtenerPorductosPorProveedor(My.Settings.cadena, idprov)
        Dim comboboxColumn As DataGridViewComboBoxColumn = GrillaArticulos.Columns("desc")
        comboboxColumn.DataSource = dr
        comboboxColumn.DisplayMember = "desc"
        comboboxColumn.ValueMember = "codart"

        Dim comboboxColumn2 As DataGridViewComboBoxColumn = GrillaArticulos.Columns("Codart")
        comboboxColumn2.DataSource = dr
        comboboxColumn2.DisplayMember = "cod"
        comboboxColumn2.ValueMember = "codart"

        GrillaArticulos.AutoGenerateColumns = False

    End Sub

    Private Sub GrillaArticulos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaArticulos.CellEndEdit
        Dim Canti As Double
        Dim PorcIva As Double
        Dim PorcImpInt As Double
        Dim PorcDto As Double
        Dim fila As Integer

        Canti = GrillaArticulos.CurrentRow.Cells("cantidad").Value
        If e.ColumnIndex = 1 Then

            PorcIva = GrillaArticulos.CurrentRow.Cells("Porciva").Value
            GrillaArticulos.CurrentRow.Cells("iva").Value = (GrillaArticulos.CurrentRow.Cells("costo").Value * GrillaArticulos.CurrentRow.Cells("Porciva").Value) / 100
            PorcImpInt = GrillaArticulos.CurrentRow.Cells("PorcImpInt").Value
            GrillaArticulos.CurrentRow.Cells("impint").Value = (CDbl(GrillaArticulos.CurrentRow.Cells("costo").Value) * PorcImpInt) / 100
            PorcDto = GrillaArticulos.CurrentRow.Cells("Porcdto").Value
            GrillaArticulos.CurrentRow.Cells("dto").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value) * PorcDto) / 100
            GrillaArticulos.CurrentRow.Cells("Punit").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value - GrillaArticulos.CurrentRow.Cells("dto").Value))
            GrillaArticulos.CurrentRow.Cells("total").Value = (GrillaArticulos.CurrentRow.Cells("punit").Value) * Canti
            CalcularTotales()

            fila = GrillaArticulos.CurrentRow.Index + 1
        End If

        If e.ColumnIndex = 2 Then

            PorcIva = GrillaArticulos.CurrentRow.Cells("Porciva").Value
            GrillaArticulos.CurrentRow.Cells("iva").Value = (GrillaArticulos.CurrentRow.Cells("costo").Value * GrillaArticulos.CurrentRow.Cells("Porciva").Value) / 100
            PorcImpInt = GrillaArticulos.CurrentRow.Cells("PorcImpInt").Value
            GrillaArticulos.CurrentRow.Cells("impint").Value = (CDbl(GrillaArticulos.CurrentRow.Cells("costo").Value) * PorcImpInt) / 100
            PorcDto = GrillaArticulos.CurrentRow.Cells("Porcdto").Value
            GrillaArticulos.CurrentRow.Cells("dto").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value) * PorcDto) / 100
            GrillaArticulos.CurrentRow.Cells("Punit").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value - GrillaArticulos.CurrentRow.Cells("dto").Value))
            GrillaArticulos.CurrentRow.Cells("total").Value = FormatNumber((GrillaArticulos.CurrentRow.Cells("punit").Value) * Canti, 2)
            CalcularTotales()

            fila = GrillaArticulos.CurrentRow.Index + 1
        End If

        If e.ColumnIndex = 6 Then 'porc de iva

            PorcIva = GrillaArticulos.CurrentRow.Cells("Porciva").Value
            GrillaArticulos.CurrentRow.Cells("iva").Value = (GrillaArticulos.CurrentRow.Cells("costo").Value * GrillaArticulos.CurrentRow.Cells("Porciva").Value) / 100
            PorcImpInt = GrillaArticulos.CurrentRow.Cells("PorcImpInt").Value
            GrillaArticulos.CurrentRow.Cells("impint").Value = (CDbl(GrillaArticulos.CurrentRow.Cells("costo").Value) * PorcImpInt) / 100
            PorcDto = GrillaArticulos.CurrentRow.Cells("Porcdto").Value
            GrillaArticulos.CurrentRow.Cells("dto").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value) * PorcDto) / 100
            GrillaArticulos.CurrentRow.Cells("Punit").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value - GrillaArticulos.CurrentRow.Cells("dto").Value))
            GrillaArticulos.CurrentRow.Cells("total").Value = FormatNumber((GrillaArticulos.CurrentRow.Cells("punit").Value) * Canti, 2)
            CalcularTotales()

            fila = GrillaArticulos.CurrentRow.Index + 1
        End If

        If e.ColumnIndex = 9 Then ' porc de dto
            PorcDto = GrillaArticulos.CurrentRow.Cells("Porcdto").Value
            GrillaArticulos.CurrentRow.Cells("dto").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value) * PorcDto) / 100
            GrillaArticulos.CurrentRow.Cells("Punit").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value - GrillaArticulos.CurrentRow.Cells("dto").Value))
            GrillaArticulos.CurrentRow.Cells("total").Value = (GrillaArticulos.CurrentRow.Cells("punit").Value) * Canti
            CalcularTotales()
        End If

        If e.ColumnIndex = 8 Then 'porcentaje imp int
            PorcImpInt = GrillaArticulos.CurrentRow.Cells("PorcImpInt").Value
            GrillaArticulos.CurrentRow.Cells("impint").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value) + GrillaArticulos.CurrentRow.Cells("iva").Value) * PorcImpInt / 100
            GrillaArticulos.CurrentRow.Cells("Punit").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value - GrillaArticulos.CurrentRow.Cells("dto").Value))
            GrillaArticulos.CurrentRow.Cells("total").Value = (GrillaArticulos.CurrentRow.Cells("punit").Value) * Canti
            CalcularTotales()
        End If

        If e.ColumnIndex = 5 Then 'columna de precio
            PorcIva = GrillaArticulos.CurrentRow.Cells("PorcIva").Value
            GrillaArticulos.CurrentRow.Cells("iva").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value) * PorcIva) / 100
            GrillaArticulos.CurrentRow.Cells("Punit").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value - GrillaArticulos.CurrentRow.Cells("dto").Value))
            GrillaArticulos.CurrentRow.Cells("total").Value = (GrillaArticulos.CurrentRow.Cells("punit").Value) * Canti
            CalcularTotales()
            GrillaArticulos.CurrentRow.Cells("actualizar").Value = True
        End If


    End Sub

    Private Sub GrillaArticulos_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles GrillaArticulos.EditingControlShowing

        Dim dgvCombo As DataGridViewComboBoxEditingControl = TryCast(e.Control, DataGridViewComboBoxEditingControl)

        If dgvCombo IsNot Nothing Then
            '
            ' se remueve el handler previo que pudiera tener asociado, a causa ediciones previas de la celda
            ' evitando asi que se ejecuten varias veces el evento
            '

            RemoveHandler dgvCombo.DropDownClosed, New EventHandler(AddressOf dvgCombo_DropDownClosed)
            AddHandler dgvCombo.DropDownClosed, New EventHandler(AddressOf dvgCombo_DropDownClosed)

        End If

    End Sub

    Private Sub dvgCombo_DropDownClosed(sender As Object, e As EventArgs)
        '
        ' se recupera el valor del combo
        ' a modo de ejemplo se escribe en consola el valor seleccionado
        '
        ' Dim combo As ComboBox = TryCast(sender, ComboBox)
        '
        ' se accede a la fila actual, para trabajr con otor de sus campos
        ' en este caso se marca el check si se cambia la seleccion
        '

        Try

            '
            ' se obtiene por el id la info del articulo
            '
            If GrillaArticulos.CurrentRow.Cells("codart").Selected = False Then
                Dim combo As ComboBox = TryCast(sender, ComboBox)
                Dim row As DataGridViewRow = GrillaArticulos.CurrentRow
                Dim cell As DataGridViewComboBoxCell = TryCast(row.Cells("codart"), DataGridViewComboBoxCell)
                Dim Canti As Double
                Dim datosArticulo As DataSet = pwiCompras.wflCompras_Articulos_obtenerProductosPorId(My.Settings.cadena, combo.SelectedValue)


                cell.Value = datosArticulo.Tables(0).Rows(0)("codart")
                GrillaArticulos.CurrentRow.Cells("idunidad").Value = datosArticulo.Tables(0).Rows(0)("uni_id")
                GrillaArticulos.CurrentRow.Cells("unidad").Value = datosArticulo.Tables(0).Rows(0)("uni_descripcion")
                If datosArticulo.Tables(0).Rows(0)("uni_id") <> 3 Then
                    GrillaArticulos.CurrentRow.Cells("costo").Value = datosArticulo.Tables(0).Rows(0)("costo")
                    GrillaArticulos.CurrentRow.Cells("Porciva").Value = datosArticulo.Tables(0).Rows(0)("lpd_porciva")
                    GrillaArticulos.CurrentRow.Cells("iva").Value = datosArticulo.Tables(0).Rows(0)("lpd_montoiva")
                Else
                    GrillaArticulos.CurrentRow.Cells("costo").Value = datosArticulo.Tables(0).Rows(0)("costoGranel")
                    GrillaArticulos.CurrentRow.Cells("Porciva").Value = datosArticulo.Tables(0).Rows(0)("lpd_porciva")
                    GrillaArticulos.CurrentRow.Cells("iva").Value = (datosArticulo.Tables(0).Rows(0)("costoGranel") * GrillaArticulos.CurrentRow.Cells("Porciva").Value) / 100
                End If
                Canti = GrillaArticulos.CurrentRow.Cells("cantidad").Value
                GrillaArticulos.CurrentRow.Cells("PorcImpInt").Value = 0
                GrillaArticulos.CurrentRow.Cells("impint").Value = (datosArticulo.Tables(0).Rows(0)("costo") * GrillaArticulos.CurrentRow.Cells("Porcimpint").Value) / 100
                GrillaArticulos.CurrentRow.Cells("Porcdto").Value = 0
                GrillaArticulos.CurrentRow.Cells("dto").Value = (datosArticulo.Tables(0).Rows(0)("costo") * GrillaArticulos.CurrentRow.Cells("Porcdto").Value) / 100
                GrillaArticulos.CurrentRow.Cells("Punit").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value - GrillaArticulos.CurrentRow.Cells("dto").Value))
                GrillaArticulos.CurrentRow.Cells("total").Value = (GrillaArticulos.CurrentRow.Cells("punit").Value) * Canti

            Else
                Dim combo2 As ComboBox = TryCast(sender, ComboBox)
                Dim row2 As DataGridViewRow = GrillaArticulos.CurrentRow
                Dim cell2 As DataGridViewComboBoxCell = TryCast(row2.Cells("desc"), DataGridViewComboBoxCell)
                Dim Canti As Double
                Dim datosArticulo As DataSet = pwiCompras.wflCompras_Articulos_obtenerProductosPorId(My.Settings.cadena, combo2.SelectedValue)

                cell2.Value = datosArticulo.Tables(0).Rows(0)("codart")
                GrillaArticulos.CurrentRow.Cells("idunidad").Value = datosArticulo.Tables(0).Rows(0)("uni_id")
                GrillaArticulos.CurrentRow.Cells("unidad").Value = datosArticulo.Tables(0).Rows(0)("uni_descripcion")
                If datosArticulo.Tables(0).Rows(0)("uni_id") <> 3 Then
                    GrillaArticulos.CurrentRow.Cells("costo").Value = datosArticulo.Tables(0).Rows(0)("costo")
                    GrillaArticulos.CurrentRow.Cells("Porciva").Value = datosArticulo.Tables(0).Rows(0)("lpd_porciva")
                    GrillaArticulos.CurrentRow.Cells("iva").Value = datosArticulo.Tables(0).Rows(0)("lpd_montoiva")
                Else
                    GrillaArticulos.CurrentRow.Cells("costo").Value = datosArticulo.Tables(0).Rows(0)("costoGranel")
                    GrillaArticulos.CurrentRow.Cells("Porciva").Value = datosArticulo.Tables(0).Rows(0)("lpd_porciva")
                    GrillaArticulos.CurrentRow.Cells("iva").Value = (datosArticulo.Tables(0).Rows(0)("costoGranel") * GrillaArticulos.CurrentRow.Cells("Porciva").Value) / 100
                End If
                Canti = GrillaArticulos.CurrentRow.Cells("cantidad").Value
                GrillaArticulos.CurrentRow.Cells("PorcImpInt").Value = 0
                GrillaArticulos.CurrentRow.Cells("impint").Value = (datosArticulo.Tables(0).Rows(0)("costo") * GrillaArticulos.CurrentRow.Cells("Porcimpint").Value) / 100
                GrillaArticulos.CurrentRow.Cells("Porcdto").Value = 0
                GrillaArticulos.CurrentRow.Cells("dto").Value = (datosArticulo.Tables(0).Rows(0)("costo") * GrillaArticulos.CurrentRow.Cells("Porcdto").Value) / 100
                GrillaArticulos.CurrentRow.Cells("Punit").Value = ((GrillaArticulos.CurrentRow.Cells("costo").Value + GrillaArticulos.CurrentRow.Cells("iva").Value + GrillaArticulos.CurrentRow.Cells("impint").Value - GrillaArticulos.CurrentRow.Cells("dto").Value))
                GrillaArticulos.CurrentRow.Cells("total").Value = (GrillaArticulos.CurrentRow.Cells("punit").Value) * Canti
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnProd_Click(sender As Object, e As EventArgs) Handles btnProd.Click
        GrillaArticulos.Enabled = True
        'cmbProveedores.Enabled = False
        Dim auxDt As New DataSet
        auxDt = pwiCompras.wflCompras_obtenerUltimacompra(My.Settings.cadena, Me.cmbProveedores.SelectedValue)

        If Not IsNothing(auxDt) Then
            CargarGrillaUltimo(auxDt)
        End If

    End Sub
    Private Sub CargarGrillaUltimo(dt As DataSet)

        Dim lngNroError As Long

        Try
            lngNroError = 0
            GrillaUltimo.Rows.Clear()
            For Each row In dt.Tables(0).Rows
                GrillaUltimo.Rows.Add(row("codart"), row("descri"), row("cantidad"), row("uni_descripcion"))

            Next


        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try

    End Sub
    Private Sub CalcularTotales()
        Dim i As Integer
        Dim SumaPbase As Double = 0
        Dim SumaIva As Double = 0
        Dim SumaImpInt As Double = 0
        Dim SumaDto As Double = 0
        'Para calcular los totales debo recorrer la grilla

        For i = 0 To GrillaArticulos.Rows.Count - 2
            SumaPbase = SumaPbase + (GrillaArticulos.Rows(i).Cells("Costo").Value) * CDbl(GrillaArticulos.Rows(i).Cells("Cantidad").Value)
            SumaIva = SumaIva + (GrillaArticulos.Rows(i).Cells("iva").Value) * CDbl(GrillaArticulos.Rows(i).Cells("Cantidad").Value)
            SumaImpInt = SumaImpInt + (GrillaArticulos.Rows(i).Cells("impint").Value) * CDbl(GrillaArticulos.Rows(i).Cells("Cantidad").Value)
            SumaDto = SumaDto + (GrillaArticulos.Rows(i).Cells("dto").Value) * CDbl(GrillaArticulos.Rows(i).Cells("Cantidad").Value)


        Next

        Me.txtPbase.Text = FormatNumber(SumaPbase, 2)
        Me.txtiva.Text = FormatNumber(SumaIva, 2)
        Me.txtImpInt.Text = FormatNumber(SumaImpInt, 2)
        Me.txtDto.Text = FormatNumber(SumaDto, 2)

        Me.txttotal.Text = FormatNumber(SumaPbase + SumaIva + SumaImpInt - SumaDto, 2)

    End Sub
    Private Function ModificarTotales()
        Me.txttotal.Text = CDbl(Me.txtPbase.Text) + CDbl(Me.txtiva.Text) + CDbl(Me.txtImpInt.Text) + CDbl(Me.txtPercepIva.Text) + CDbl(Me.txtIB.Text) - CDbl(Me.txtDto.Text)
    End Function

    Private Sub GrillaArticulos_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaArticulos.RowEnter
        Dim fila As Integer
        If e.ColumnIndex = 1 Then
            If Me.GrillaArticulos.CurrentCell Is Nothing Then Return

            ' Eliminamos la selección de la celda actual.
            '
            Me.GrillaArticulos.Rows(e.RowIndex).Selected = False

            ' Seleccionamos la celda correspondiente a la segunda
            ' columna de la fila o renglón actual.
            '

            Dim textBoxCell As DataGridViewTextBoxCell = _
            TryCast(Me.GrillaArticulos.Item(2, GrillaArticulos.CurrentRow.Index),  _
            DataGridViewTextBoxCell)

            textBoxCell.Selected = True



        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgBox("¿Está seguro que desea salir sin grabar el pedido?", vbYesNoCancel, "Aviso al operador") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim idcompra As Integer
        Dim i As Double
        If MsgBox("¿Desea grabar los datos del pedido?", MsgBoxStyle.YesNo, "Aviso al operador") = MsgBoxResult.Yes Then
            If pwiCompras.wflCompras_insertarRegistro(My.Settings.cadena, GrillaArticulos, Me.cmbFormasPAgoProv.SelectedValue, _
                                                   Me.cmbtiposFactura.SelectedValue, Me.cmbEstado.SelectedValue, _
                                                   Me.cmbProveedores.SelectedValue, strMensaje, Me.txtNroFactura.Text, _
                                                   Me.dtFecha.Value, Me.txtobservaciones.Text, CDbl(Me.txtPbase.Text), _
                                                   CDbl(Me.txtIva.Text), CDbl(Me.txtImpInt.Text), CDbl(Me.txtPercepIva.Text), _
                                                   CDbl(Me.txtIb.Text), CDbl(Me.txtDto.Text), CDbl(Me.txttotal.Text), CDate(dtmFecEntrega.Value), idcompra) Then
                MsgBox("El pedido se ha grabado con éxito", vbOKOnly, "Aviso al operador")
                If MsgBox("¿Desea imprimir el pedido?", MsgBoxStyle.YesNoCancel, "Aviso al operador") = MsgBoxResult.Yes Then
                    Dim frm As New FormImprimeReporte
                    frm.AbrirFormulario(idcompra)
                End If
                Me.Close()

            End If
        End If
    End Sub

    '*****************************trabajo con las cajas para formatear importes
    Private Function ReFormat(ByVal sTxt As String) As String
        If Len(sTxt) > 1 Then
            sInputString = UnFormatText(sTxt)
        Else
            sInputString = sTxt
        End If
        ReFormat = SetColonAndDot(sInputString)
    End Function
    Private Function SetColonAndDot(ByVal sTxt As String) As String
        Dim lg As Integer
        lg = Len(sTxt)
        Select Case lg
            Case 0
                SetColonAndDot = "0,00" & sTxt
            Case 1
                SetColonAndDot = "0,0" & sTxt
            Case 2
                SetColonAndDot = "0," & sTxt
            Case Else
                If lg > 5 And lg < 9 Then
                    SetColonAndDot = Microsoft.VisualBasic.Left(sTxt, lg - 5) & "." & Microsoft.VisualBasic.Mid(sTxt, lg - 4, 3) & "," & Microsoft.VisualBasic.Right(sTxt, 2)
                ElseIf lg > 8 And lg < 12 Then
                    SetColonAndDot = Microsoft.VisualBasic.Left(sTxt, lg - 8) & "." & Microsoft.VisualBasic.Mid(sTxt, lg - 7, 3) & "." & Microsoft.VisualBasic.Mid(sTxt, lg - 4, 3) & "," & Microsoft.VisualBasic.Right(sTxt, 2)
                ElseIf lg > 11 And lg < 15 Then
                    SetColonAndDot = Microsoft.VisualBasic.Left(sTxt, lg - 11) & "." & Microsoft.VisualBasic.Mid(sTxt, lg - 10, 3) & "." & Microsoft.VisualBasic.Mid(sTxt, lg - 7, 3) & "." & Microsoft.VisualBasic.Mid(sTxt, lg - 4, 3) & "," & Microsoft.VisualBasic.Right(sTxt, 2)
                ElseIf lg > 14 Then
                    SetColonAndDot = Microsoft.VisualBasic.Left(sTxt, lg - 14) & "." & Microsoft.VisualBasic.Mid(sTxt, lg - 13, 3) & "." & Microsoft.VisualBasic.Mid(sTxt, lg - 10, 3) & "." & Microsoft.VisualBasic.Mid(sTxt, lg - 7, 3) & "." & Microsoft.VisualBasic.Mid(sTxt, lg - 4, 3) & "," & Microsoft.VisualBasic.Right(sTxt, 2)
                Else
                    SetColonAndDot = Microsoft.VisualBasic.Left(sTxt, lg - 2) & "," & Microsoft.VisualBasic.Right(sTxt, 2)
                    ' SetColonAndDot = Microsoft.VisualBasic.Mid(sTxt, Len(lg) - (Len(lg) - 1), 1) & "." & Microsoft.VisualBasic.Right(sTxt, 2) & "," & "00"
                End If
        End Select
    End Function
    Private Function UnFormatText(ByVal sTxt As String) As String
        Dim i As Integer, sResult As String, sSign As String, bZerosDone As Boolean
        sResult = ""
        For i = 1 To Len(sTxt)
            sSign = Mid(sTxt, i, 1)
            If sSign <> "," And sSign <> "." Then
                'cuts out all dots and colons
                If sSign <> "0" Or bZerosDone Then
                    ' cuts out all zeros until another number follows
                    sResult = sResult & sSign
                    bZerosDone = True
                End If
            End If
        Next
        UnFormatText = sResult
    End Function


    Private Sub txtPercepIva_TextChanged(sender As Object, e As EventArgs)
        If Me.txtPercepIva.Text = "" Then Exit Sub
        If bJustChanged Then
            bJustChanged = False
        Else
            bJustChanged = True
            Me.txtPercepIva.Text = ReFormat(Me.txtPercepIva.Text)
            ' setting Cursor back to the end of the number
            Me.txtPercepIva.SelectionStart = Len(Me.txtPercepIva.Text)
            Me.txtPercepIva.SelectionLength = 0
        End If
    End Sub
    Private Sub txtPercepIva_GotFocus(sender As Object, e As EventArgs)
        Me.txtPercepIva.SelectionStart = 0
        Me.txtPercepIva.SelectionLength = Len(Me.txtPercepIva.Text)
    End Sub

    Private Sub txtPercepIva_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPercepIva_LostFocus(sender As Object, e As EventArgs)
        ModificarTotales()
    End Sub

    Private Sub txtPbase_GotFocus(sender As Object, e As EventArgs)
        Me.txtPbase.SelectionStart = 0
        Me.txtPbase.SelectionLength = Len(Me.txtPbase.Text)
    End Sub

    Private Sub txtPbase_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        CalcularTotal()
    End Sub


    Private Sub txtPbase_TextChanged(sender As Object, e As EventArgs)
        If Me.txtPbase.Text = "" Then Exit Sub
        If bJustChanged Then
            bJustChanged = False
        Else
            bJustChanged = True
            Me.txtPbase.Text = ReFormat(Me.txtPbase.Text)
            ' setting Cursor back to the end of the number
            Me.txtPbase.SelectionStart = Len(Me.txtPbase.Text)
            Me.txtPbase.SelectionLength = 0
        End If
    End Sub

    Private Sub txtiva_GotFocus(sender As Object, e As EventArgs)
        Me.txtIva.SelectionStart = 0
        Me.txtIva.SelectionLength = Len(Me.txtIva.Text)
    End Sub

    Private Sub txtiva_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        CalcularTotal()
    End Sub

    Private Sub txtiva_LostFocus(sender As Object, e As EventArgs)
        ModificarTotales()
    End Sub

    Private Sub txtiva_TextChanged(sender As Object, e As EventArgs)
        If Me.txtIva.Text = "" Then Exit Sub
        If bJustChanged Then
            bJustChanged = False
        Else
            bJustChanged = True
            Me.txtIva.Text = ReFormat(Me.txtIva.Text)
            ' setting Cursor back to the end of the number
            Me.txtIva.SelectionStart = Len(Me.txtIva.Text)
            Me.txtIva.SelectionLength = 0
        End If
    End Sub
    '******************************ImpInt

    Private Sub txtimpint_GotFocus(sender As Object, e As EventArgs)
        Me.txtImpInt.SelectionStart = 0
        Me.txtImpInt.SelectionLength = Len(Me.txtIva.Text)
    End Sub

    Private Sub txtimpint_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        CalcularTotal()
    End Sub

    Private Sub txtimpint_LostFocus(sender As Object, e As EventArgs)
        ModificarTotales()
    End Sub

    Private Sub txtimpint_TextChanged(sender As Object, e As EventArgs)
        If Me.txtImpInt.Text = "" Then Exit Sub
        If bJustChanged Then
            bJustChanged = False
        Else
            bJustChanged = True
            Me.txtImpInt.Text = ReFormat(Me.txtImpInt.Text)
            ' setting Cursor back to the end of the number
            Me.txtImpInt.SelectionStart = Len(Me.txtImpInt.Text)
            Me.txtImpInt.SelectionLength = 0
        End If
    End Sub
    '*****************IB************************************************************************************

    Private Sub txtib_GotFocus(sender As Object, e As EventArgs)
        Me.txtIb.SelectionStart = 0
        Me.txtIb.SelectionLength = Len(Me.txtIb.Text)
    End Sub

    Private Sub txtib_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        CalcularTotal()
    End Sub

    Private Sub txtib_TextChanged(sender As Object, e As EventArgs)
        If Me.txtIb.Text = "" Then Exit Sub
        If bJustChanged Then
            bJustChanged = False
        Else
            bJustChanged = True
            Me.txtIb.Text = ReFormat(Me.txtIb.Text)
            ' setting Cursor back to the end of the number
            Me.txtIb.SelectionStart = Len(Me.txtIb.Text)
            Me.txtIb.SelectionLength = 0
        End If
        CalcularTotal()
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

    Private Sub txtDto_TextChanged(sender As Object, e As EventArgs)
        If Me.txtIb.Text = "" Then Exit Sub
        If bJustChanged Then
            bJustChanged = False
        Else
            bJustChanged = True
            Me.txtDto.Text = ReFormat(Me.txtDto.Text)
            ' setting Cursor back to the end of the number
            Me.txtDto.SelectionStart = Len(Me.txtDto.Text)
            Me.txtDto.SelectionLength = 0
        End If
    End Sub
    '*****************************************TOTAL******************************************************************

    Private Sub txttotal_GotFocus(sender As Object, e As EventArgs)
        Me.txttotal.SelectionStart = 0
        Me.txttotal.SelectionLength = Len(Me.txttotal.Text)
    End Sub

    Private Sub txttotal_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs)
        If Me.txttotal.Text = "" Then Exit Sub
        If bJustChanged Then
            bJustChanged = False
        Else
            bJustChanged = True
            Me.txttotal.Text = ReFormat(Me.txttotal.Text)
            ' setting Cursor back to the end of the number
            Me.txttotal.SelectionStart = Len(Me.txttotal.Text)
            Me.txttotal.SelectionLength = 0
        End If
    End Sub
    
    Private Sub GrillaArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaArticulos.CellContentClick

    End Sub

    Private Sub txtPbase_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtPbase.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        CalcularTotal()
    End Sub
    Private Sub txtIva_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtIva.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        CalcularTotal()
    End Sub

    

    Private Sub txtImpInt_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtImpInt.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        CalcularTotal()
    End Sub

    Private Sub txtImpInt_TextChanged_1(sender As Object, e As EventArgs) Handles txtImpInt.TextChanged

    End Sub

    Private Sub txtPercepIva_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtPercepIva.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        CalcularTotal()
    End Sub

    Private Sub txtPercepIva_TextChanged_1(sender As Object, e As EventArgs) Handles txtPercepIva.TextChanged

    End Sub

    Private Sub txtIb_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtIb.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        CalcularTotal()
    End Sub

    Private Sub txtIb_TextChanged_1(sender As Object, e As EventArgs) Handles txtIb.TextChanged

    End Sub

    Private Sub txtDto_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtDto.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
        CalcularTotal()
    End Sub

    Private Sub CalcularTotal()
        Me.txttotal.Value = CDbl(Me.txtPbase.Value) + CDbl(Me.txtIva.Value) + CDbl(Me.txtImpInt.Value) + CDbl(Me.txtPercepIva.Value) + CDbl(Me.txtIb.Value) - CDbl(Me.txtDto.Value)
    End Sub

    Private Sub cmbProveedores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProveedores.SelectedIndexChanged

    End Sub
End Class