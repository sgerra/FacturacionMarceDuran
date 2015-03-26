Imports System.Data
Imports System.Data.Common
Imports System.Windows.Forms
Imports Facturacion.wflFacturacion

Public Class pltFacturacion
    Dim ds As New DataSet
    Dim Strcadena As String
    Dim clsgrilla As DataGridView
    Public Sub ArmarGrilla(ByVal dg As DataGridView)

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

    Public Shared Function ObtenerArticulo(ByVal lngIdArticulo As Long, ByVal cadena As String) As DataSet
        Try

            ObtenerArticulo = wflFacturacion.wflarticulos.ObtenerArticulo(lngIdArticulo, cadena)
        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Articulos" + "|" + ex.Message)
        End Try

    End Function

    Public Function ObtenerArticuloPorCodigoBarras(ByVal strcodigobarras As String, ByVal cadena As String) As DataSet
        Try

            ObtenerArticuloPorCodigoBarras = wflFacturacion.wflarticulos.ObtenerArticuloPorCodigoBarras(strcodigobarras, cadena)
        Catch ex As Exception
            Throw New Exception("Error en PLT" + "Obtener Articulos por codigo de barras" + "|" + ex.Message)
        End Try

    End Function
    Public Shared Function ObtenerLista(ByVal cadena As String) As DataSet
        Try
            ObtenerLista = wflFacturacion.wflarticulos.ObtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function ActualizarArticulo(ByVal cadena As String, ByVal dsarticulos As DataSet) As Long
        Try
            ActualizarArticulo = wflFacturacion.wflarticulos.ActualizarArticulo(cadena, dsarticulos)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function
    Public Function Validar_TextoIngresado(ByVal codigobarras As String, ByVal cadena As String, ByVal grilla As DataGridView, ByVal total As Label) As Boolean



        If Mid(codigobarras, 1, 1) <> "*" Then
            If wflFacturacion.wflarticulos.ExisteArticulo(cadena, codigobarras) Then
                '    inserto = False
                If Trim(codigobarras) <> "1" And Trim(codigobarras) <> "4" Then
                    'Trae los valoes del articulo ingresado
                    ds = wflFacturacion.wflarticulos.ObtenerListaParaGrilla(cadena, codigobarras)
                    'Inserta en la grilla los valores seleccionados
                    InsertarFilasEnGrilla(ds.Tables(0).Rows(0), grilla)
                    'Actualizo el Total

                    total.Text = Val(total.Text) + ds.Tables(0).Rows(0).Item("total")


                    Validar_TextoIngresado = True
                    'Lo calculo cuando lo guardo 
                    'TotalPCompra = TotalPCompra + (Val(TextPcompra.Text) * Val(TextCantidad.Text))
                    'HASAR1.ImprimirItem Lbldescripcion.Caption, CDbl(TextCantidad.Text), CDbl(lblTotal.Caption), 21, 0


                Else

                End If
            End If
        End If
        '            TraerValoresArticuloCantidad(TextCodBar.Text, descri, Precio, codigo, pcompra)
        '            Cantidad = 1
        '            FormPide.Cargar_Formulario(descri, Precio, codigo, TextCodBar.Text, pcompra)
        '            LimpiarCajas()
        '            If GrillaArticulos.Rows > 12 Then
        '                GrillaArticulos.TopRow = GrillaArticulos.Rows - 1
        '            End If
        '            TextCodBar.SetFocus()
        '        End If
        '    Else
        '        Mensaje("El articulo no está en la base de datos")
        '        TextCodBar.Text = ""

        '    End If
        'Else
        '    Cantidad = Mid$(TextCodBar.Text, 2, Len(TextCodBar.Text))
        '    FormPideCodart.Show(vbModal)
        '    LimpiarCajas()
        '    If GrillaArticulos.Rows > 12 Then
        '        GrillaArticulos.TopRow = GrillaArticulos.Rows - 1
        '    End If
        '    TextCodBar.SetFocus()
        'End If

        'End If
    End Function
    Public Shared Sub InsertarFilasEnGrilla(ByVal row As DataRow, ByVal grilla As DataGridView)
        Dim i As Integer
        Dim dt As New DataGridViewRow

        i = grilla.Rows.Count - 1
        dt.CreateCells(grilla)
        dt.Cells(0).Value = row.Item("codart")
        dt.Cells(1).Value = row.Item("descri")
        dt.Cells(2).Value = row.Item("precio")
        dt.Cells(3).Value = row.Item("cantidad")
        dt.Cells(4).Value = row.Item("total")
        dt.Cells(5).Value = row.Item("cod")
        dt.Cells(6).Value = row.Item("costo")
        grilla.Rows.Insert(i, dt)

    End Sub
    Public Function ActualizarTotal(ByVal grilla As DataGridView) As Double
        Dim i As Integer
        Dim suma As Double

        For i = 1 To grilla.Rows.Count - 1
            suma = suma + grilla.Rows(i).Cells(4).Value
        Next
        ActualizarTotal = suma
    End Function
    Public Sub MostrarFormularioPidePrecio(ByVal frm As Form, ByVal cadena As String, ByVal grilla As DataGridView, ByVal codigobarras As String)

        If wflFacturacion.wflarticulos.ExisteArticulo(cadena, codigobarras) Then
            ds = wflFacturacion.wflarticulos.ObtenerListaParaGrilla(cadena, codigobarras)
            ds.Tables(0).Rows(0).Item("cantidad") = 1
            frm.Controls.Item("txtcodigobarras").Text = codigobarras
            frm.Controls.Item("txtcodigobarras").Enabled = False
            frm.Controls.Item("lbldescripcion").Text = ds.Tables(0).Rows(0).Item("descri")
            frm.ShowDialog()
            ds.Tables(0).Rows(0).Item("precio") = frm.Controls.Item("txtprecio").Text
            ds.Tables(0).Rows(0).Item("total") = ds.Tables(0).Rows(0).Item("precio")
            InsertarFilasEnGrilla(ds.Tables(0).Rows(0), grilla)
        Else
            MsgBox("El articulo ingresado no se encuentra en la base de datos")
        End If

    End Sub
    Public Sub MostrarFormularioPideCodart(ByVal frm As Form, ByVal cadena As String, ByVal grilla As DataGridView, ByVal Cantidad As Double)
        Dim codigoPideArt As String


        clsgrilla = grilla
        frm.ShowDialog()
        codigoPideArt = frm.Controls.Item("txtcodigobarras").Text
        ds = wflFacturacion.wflarticulos.ObtenerListaParaGrilla(cadena, codigoPideArt)
        'Inserta en la grilla los valores seleccionados
        If codigoPideArt <> "1" And codigoPideArt <> "4" Then
            ds.Tables(0).Rows(0).Item("cantidad") = Cantidad
            ds.Tables(0).Rows(0).Item("total") = Cantidad * ds.Tables(0).Rows(0).Item("precio")
            InsertarFilasEnGrilla(ds.Tables(0).Rows(0), grilla)
        Else
            ds.Tables(0).Rows(0).Item("precio") = 1
            ds.Tables(0).Rows(0).Item("total") = Cantidad
            InsertarFilasEnGrilla(ds.Tables(0).Rows(0), grilla)
        End If


    End Sub
    Public Sub ValidarIngresoArt(ByVal Form As Form, ByVal cadena As String)
        Dim codigobarras As String

        codigobarras = Form.Controls.Item("txtcodigobarras").Text
        If wflFacturacion.wflarticulos.ExisteArticulo(cadena, codigobarras) Then
            '    inserto = False

            'Trae los valoes del articulo ingresado
            ds = wflFacturacion.wflarticulos.ObtenerListaParaGrilla(cadena, codigobarras)
            Form.Controls.Item("lbldescripcion").Text = ds.Tables(0).Rows(0).Item("descri")
            If codigobarras <> "1" And codigobarras <> "4" Then
                Form.Controls.Item("txtprecio").Text = ds.Tables(0).Rows(0).Item("precio")
            Else
                Form.Controls.Item("txtprecio").Text = 1
            End If
        End If

    End Sub
End Class
