Public Class FormAgregaArticulos
    Dim dstDepositos As New DataSet
    Dim dstArticulos As New DataSet
    Dim dstPedidoAux As DataSet
    Dim blnPAso As Boolean
    Private Sub FormAgregaArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub


    Public Sub Abrir(idProveedor As Integer, ByRef dstPedidoDetalle As DataSet)
        Try
            dstDepositos = pwiAgregaArticulos.wflCompras_obtenerDepositos(My.Settings.cadena)

            GrillaArticulos.Rows.Clear()
            GrillaArticulos.Columns.Clear()

            GrillaArticulos.Columns.Add("Codart", "Codigo")
            GrillaArticulos.Columns("codart").Width = 80
            GrillaArticulos.Columns("codart").Visible = True
            GrillaArticulos.Columns("codart").ReadOnly = True
            GrillaArticulos.Columns("codart").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            'Descripcion
            GrillaArticulos.Columns.Add("desc", "Descripción")
            GrillaArticulos.Columns("desc").Width = 400
            GrillaArticulos.Columns("desc").Visible = True
            GrillaArticulos.Columns("desc").ReadOnly = True
            GrillaArticulos.Columns("desc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            'Codigo de barras
            GrillaArticulos.Columns.Add("cant", "Cantidad")
            GrillaArticulos.Columns("cant").Width = 80
            GrillaArticulos.Columns("cant").Visible = True
            GrillaArticulos.Columns("cant").ReadOnly = False
            GrillaArticulos.Columns("cant").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


            'Precio
            GrillaArticulos.Columns.Add("costo", "Costo")
            GrillaArticulos.Columns("costo").Width = 80
            GrillaArticulos.Columns("costo").Visible = True ''''destape
            GrillaArticulos.Columns("costo").ReadOnly = True
            GrillaArticulos.Columns("costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            GrillaArticulos.Columns.Add("punitfinal", "Precio")
            GrillaArticulos.Columns("punitfinal").Width = 80
            GrillaArticulos.Columns("punitfinal").Visible = True
            GrillaArticulos.Columns("punitfinal").ReadOnly = True
            GrillaArticulos.Columns("punitfinal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            GrillaArticulos.Columns.Add("porciva", "PorcIva")
            GrillaArticulos.Columns("porciva").Width = 80
            GrillaArticulos.Columns("porciva").Visible = True ''destape
            GrillaArticulos.Columns("porciva").ReadOnly = True
            GrillaArticulos.Columns("porciva").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            GrillaArticulos.Columns.Add("porcutil", "Porcutil")
            GrillaArticulos.Columns("porcutil").Width = 80
            GrillaArticulos.Columns("porcutil").Visible = True ''destape
            GrillaArticulos.Columns("porcutil").ReadOnly = True
            GrillaArticulos.Columns("porcutil").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            GrillaArticulos.Columns.Add("porcdto", "PorcDto")
            GrillaArticulos.Columns("porcdto").Width = 80
            GrillaArticulos.Columns("porcdto").Visible = True ''destape
            GrillaArticulos.Columns("porcdto").ReadOnly = True
            GrillaArticulos.Columns("porcdto").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            GrillaArticulos.Columns.Add("porcPercep", "PorcPercep")
            GrillaArticulos.Columns("porcPercep").Width = 80
            GrillaArticulos.Columns("porcPercep").Visible = True ''destape
            GrillaArticulos.Columns("porcPercep").ReadOnly = True
            GrillaArticulos.Columns("porcPercep").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


            'Precio
            GrillaArticulos.Columns.Add("uniid", "Unidad")
            GrillaArticulos.Columns("uniid").Width = 70
            GrillaArticulos.Columns("uniid").Visible = False
            GrillaArticulos.Columns("uniid").ReadOnly = True
            GrillaArticulos.Columns("uniid").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            GrillaArticulos.Columns.Add("unidad", "Unidad")
            GrillaArticulos.Columns("unidad").Width = 70
            GrillaArticulos.Columns("unidad").Visible = True
            GrillaArticulos.Columns("unidad").ReadOnly = True
            GrillaArticulos.Columns("unidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            For Each dr As DataRow In dstDepositos.Tables(0).Rows
                GrillaArticulos.Columns.Add("stk" & dr("iddeposito"), "Stk" & dr("deposito"))
                GrillaArticulos.Columns("STK" & dr("iddeposito")).Width = 80
                GrillaArticulos.Columns("STK" & dr("iddeposito")).Visible = True
                GrillaArticulos.Columns("STK" & dr("iddeposito")).ReadOnly = True
                GrillaArticulos.Columns("STK" & dr("iddeposito")).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Next

            GrillaArticulos.Columns.Add("total", "Total")
            GrillaArticulos.Columns("total").Width = 70
            GrillaArticulos.Columns("total").Visible = True
            GrillaArticulos.Columns("total").ReadOnly = True
            GrillaArticulos.Columns("total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            dstArticulos = pwiAgregaArticulos.wflCompras_obtenerArticulosPorProveedor(My.Settings.cadena, idProveedor)

            dstPedidoAux = dstPedidoDetalle
            CargarGrillaArticulos()
            CargarCantidadesPedido()
            Me.ShowDialog()

        Catch ex As Exception
            MsgBox("Se ha producido un error en la aplicación" + "  " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub CargarGrillaArticulos()

        Dim lngNroError As Long

        Try
            lngNroError = 0
            GrillaArticulos.Rows.Clear()
            For Each row In dstArticulos.Tables(0).Rows
                GrillaArticulos.Rows.Add(row("codart"), row("desc"), 0, row("costo"), row("lpd_precioVta"), row("lpd_porciva"), row("lpd_porcutil"), row("lpd_porcdesc"), row("lpd_porcPercep"), row("uni_id"), row("uni_descripcion"))
            Next

        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try
    End Sub

    Private Sub CargarCantidadesPedido()

        Dim lngNroError As Long
        Dim Codart As Integer
        Dim dblCantidad As Double
        Dim dblTotal As Double
        Try
            lngNroError = 0

            For Each dr As DataRow In dstPedidoAux.Tables(0).Rows

                Codart = dr("codart")
                dblCantidad = dr("cantidad")
                dblTotal = dr("total")
                For i = 0 To GrillaArticulos.Rows.Count - 2
                    If GrillaArticulos.Rows(i).Cells("codart").Value = Codart Then
                        GrillaArticulos.Rows(i).Cells("cant").Value = dblCantidad
                        GrillaArticulos.Rows(i).Cells("total").Value = dblTotal
                        i = i + 1
                    End If
                Next
            Next
        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try
    End Sub
    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        For i As Integer = 0 To Me.GrillaArticulos.Rows.Count - 2
            'For x As Integer = 0 To Me.GrillaArticulos.ColumnCount - 1
            If Me.GrillaArticulos.Rows(i).Cells(0).Value.ToString.Contains(Me.txtCodigo.Text) Then
                Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(0)
                Exit Sub
            End If
            'Next x
        Next i
    End Sub

    Private Sub txtdescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescripcion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged
        For i As Integer = 0 To Me.GrillaArticulos.Rows.Count - 2
            If Me.GrillaArticulos.Rows(i).Cells(1).Value.ToString.Contains(Me.txtdescripcion.Text) Then
                Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(0)
                Exit Sub
            End If
            'Next x
        Next i
    End Sub

    Private Sub btncontinua_Click(sender As Object, e As EventArgs) Handles btncontinua.Click
        Dim strabuscar As String


        If txtCodigo.Text <> "" Then
            strabuscar = (txtCodigo.Text).ToUpper
            For i As Integer = GrillaArticulos.CurrentRow.Index + 1 To Me.GrillaArticulos.Rows.Count - 2
                If Me.GrillaArticulos.Rows(i).Cells(0).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(0)
                    Exit Sub
                End If

            Next i

        Else
            strabuscar = (txtdescripcion.Text).ToUpper
            For i As Integer = GrillaArticulos.CurrentRow.Index + 1 To Me.GrillaArticulos.Rows.Count - 2
                If Me.GrillaArticulos.Rows(i).Cells(1).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(0)
                    Exit Sub
                End If

            Next i

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strabuscar As String


        If txtCodigo.Text <> "" Then
            strabuscar = (txtCodigo.Text).ToUpper
            For i As Integer = GrillaArticulos.CurrentRow.Index - 1 To 0 Step -1
                If Me.GrillaArticulos.Rows(i).Cells(0).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(0)
                    Exit Sub
                End If

            Next i

        Else
            strabuscar = (txtdescripcion.Text).ToUpper
            For i As Integer = GrillaArticulos.CurrentRow.Index - 1 To 0
                If Me.GrillaArticulos.Rows(i).Cells(1).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(1)
                    Exit Sub
                End If

            Next i

        End If

    End Sub

    
   
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgPregunta("¿Desea cancelar?") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If MsgPregunta("¿Desea confirmar la selección?") = vbYes Then
            dstPedidoAux.Tables(0).Rows.Clear()
            blnPAso = False
            For i = 0 To GrillaArticulos.Rows.Count - 2
                If GrillaArticulos.Rows(i).Cells("cant").Value <> 0 Then
                    dstPedidoAux.Tables(0).Rows.Add()
                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("iddet") = -1
                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("idCompra") = -1
                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("codart") = GrillaArticulos.Rows(i).Cells("codart").Value
                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("descri") = GrillaArticulos.Rows(i).Cells("desc").Value
                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("cantidad") = GrillaArticulos.Rows(i).Cells("cant").Value
                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("idunidad") = GrillaArticulos.Rows(i).Cells("uniid").Value
                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("precio") = GrillaArticulos.Rows(i).Cells("costo").Value
                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("porciva") = GrillaArticulos.Rows(i).Cells("porciva").Value
                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("montoiva") = GrillaArticulos.Rows(i).Cells("costo").Value * (GrillaArticulos.Rows(i).Cells("porciva").Value / 100)

                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("porcdto") = GrillaArticulos.Rows(i).Cells("porcdto").Value
                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("montodto") = (GrillaArticulos.Rows(i).Cells("costo").Value + dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("montoiva")) * (GrillaArticulos.Rows(i).Cells("porcdto").Value / 100)

                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("porcPercep") = GrillaArticulos.Rows(i).Cells("porcPercep").Value
                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("montoPercep") = (GrillaArticulos.Rows(i).Cells("costo").Value + dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("montoiva") - dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("montodto")) * (GrillaArticulos.Rows(i).Cells("porcPercep").Value / 100)
                    

                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("porcutil") = GrillaArticulos.Rows(i).Cells("porcutil").Value
                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("montoutil") = ((dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("precio") + dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("montoiva") + dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("montopercep") - dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("montodto")) * GrillaArticulos.Rows(i).Cells("porcutil").Value) / 100


                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("punitfinal") = GrillaArticulos.Rows(i).Cells("punitfinal").Value
                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("total") = GrillaArticulos.Rows(i).Cells("total").Value

                    dstPedidoAux.Tables(0).Rows(dstPedidoAux.Tables(0).Rows.Count - 1)("uni_descripcion") = GrillaArticulos.Rows(i).Cells("unidad").Value
                    blnPAso = True
                End If

            Next

            If blnPAso Then
                Me.Close()
            Else
                MsgAtencion("Debe ingresar al menos un articulo en el pedido")
            End If
        End If
    End Sub

    Private Sub GrillaArticulos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaArticulos.CellEndEdit
        Dim canti As Double

        canti = GrillaArticulos.CurrentRow.Cells("cant").Value
        If e.ColumnIndex = 2 Then
            GrillaArticulos.CurrentRow.Cells("total").Value = FormatNumber((GrillaArticulos.CurrentRow.Cells("punitfinal").Value) * canti, 2)
        End If
    End Sub

    Private Sub GrillaArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaArticulos.CellContentClick

    End Sub
End Class