Imports System.Data
Imports System.Data.Common
Imports System.Windows.Forms
Imports wflFacturacion

Public Class pwiFacturacion
    Dim ds As New DataSet
    Dim Strcadena As String
    Dim clsgrilla As DataGridView
    

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
    Public Shared Function ObtenerClientes(ByVal cadena As String) As DataSet
        Try
            ObtenerClientes = wflClientes.wflClientes_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function ObtenerLista(ByVal cadena As String) As DataSet
        Try
            ObtenerLista = wflarticulos.ObtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function obtenerArticuloFacturacion(ByVal cadena As String, lngIdArticulo As Integer, idLista As Integer) As DataSet
        Try
            obtenerArticuloFacturacion = wflEmisionFactura.wflEmisionFactura_obtenerArticuloFacturacion(cadena, lngIdArticulo, idLista)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function ExisteArticulo(ByVal cadena As String, strcodigoBarras As String) As DataSet
        Try
            ExisteArticulo = wflarticulos.ObtenerArticuloPorCodigoBarras(strcodigoBarras, cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    
    Public Function ActualizarTotal(ByVal grilla As DataGridView) As Double
        Dim i As Integer
        Dim suma As Double

        For i = 1 To grilla.Rows.Count - 1
            suma = suma + grilla.Rows(i).Cells(4).Value
        Next
        ActualizarTotal = suma
    End Function
    ''Public Sub MostrarFormularioPidePrecio(ByVal frm As Form, ByVal cadena As String, ByVal grilla As DataGridView, ByVal codigobarras As String)

    ''    If wflFacturacion.wflarticulos.ExisteArticulo(cadena, codigobarras) Then
    ''        ds = wflFacturacion.wflarticulos.ObtenerListaParaGrilla(cadena, codigobarras)
    ''        ds.Tables(0).Rows(0).Item("cantidad") = 1
    ''        frm.Controls.Item("txtcodigobarras").Text = codigobarras
    ''        frm.Controls.Item("txtcodigobarras").Enabled = False
    ''        frm.Controls.Item("lbldescripcion").Text = ds.Tables(0).Rows(0).Item("descri")
    ''        frm.ShowDialog()
    ''        ds.Tables(0).Rows(0).Item("precio") = frm.Controls.Item("txtprecio").Text
    ''        ds.Tables(0).Rows(0).Item("total") = ds.Tables(0).Rows(0).Item("precio")
    ''        InsertarFilasEnGrilla(ds.Tables(0).Rows(0), grilla)
    ''    Else
    ''        MsgBox("El articulo ingresado no se encuentra en la base de datos")
    ''    End If

    ''End Sub
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
            'InsertarFilasEnGrilla(ds.Tables(0).Rows(0), grilla)
        Else
            ds.Tables(0).Rows(0).Item("precio") = 1
            ds.Tables(0).Rows(0).Item("total") = Cantidad
            'InsertarFilasEnGrilla(ds.Tables(0).Rows(0), grilla)
        End If


    End Sub
    Public Shared Sub InsertarFilasEnGrilla(codart As String, descri As String, precio As Double, _
                                            cantidad As Double, total As Double, codbarra As String, costo As Double, _
                                            ByVal grilla As DataGridView)
        Dim i As Integer
        Dim dt As New DataGridViewRow

        i = grilla.Rows.Count - 1
        dt.CreateCells(grilla)
        dt.Cells(0).Value = codart
        dt.Cells(1).Value = descri
        dt.Cells(2).Value = precio
        dt.Cells(3).Value = cantidad
        dt.Cells(4).Value = total
        dt.Cells(5).Value = codbarra
        dt.Cells(6).Value = costo
        grilla.Rows.Insert(i, dt)

    End Sub
    Public Sub ValidarIngresoArt(ByVal Form As Form, ByVal cadena As String)
        Dim codigobarras As String

        codigobarras = Form.Controls.Item("txtcodigobarras").Text
        'If wflFacturacion.wflarticulos.ExisteArticulo(cadena, codigobarras) Then
        '    '    inserto = False

        '    'Trae los valoes del articulo ingresado
        '    ds = wflFacturacion.wflarticulos.ObtenerListaParaGrilla(cadena, codigobarras)
        '    Form.Controls.Item("lbldescripcion").Text = ds.Tables(0).Rows(0).Item("descri")
        '    If codigobarras <> "1" And codigobarras <> "4" Then
        '        Form.Controls.Item("txtprecio").Text = ds.Tables(0).Rows(0).Item("precio")
        '    Else
        '        Form.Controls.Item("txtprecio").Text = 1
        '    End If
        'End If

    End Sub

    Public Shared Function obtenerFormasPago(ByVal cadena As String) As DataSet
        Try
            obtenerFormasPago = wflEmisionFactura.wflEmisionFactura_obtenerFormasPago(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflComprobantesVenta_obtenerRegistro(ByVal cadena As String, lngNroCom As Integer) As DataSet
        Try
            wflComprobantesVenta_obtenerRegistro = wflEmisionFactura.wflEmisionFactura_comprobantesVenta_obtenerRegistro(cadena, lngNroCom)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflComprobantesVentaDetalle_obtenerRegistro(ByVal cadena As String, lngNroCom As Integer) As DataSet
        Try
            wflComprobantesVentaDetalle_obtenerRegistro = wflEmisionFactura.wflEmisionFactura_comprobantesVentaDetalle_obtenerRegistro(cadena, lngNroCom)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflEmisionFactura_GuardarComprobante(ByVal cadena As String, dscomprobante As DataSet, dsdeta As DataSet, iddeposito As Integer) As Boolean
        Try
            wflEmisionFactura_GuardarComprobante = wflEmisionFactura.wflEmisionFactura_GuardarComprobante(cadena, dscomprobante, dsdeta, iddeposito)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflEmisionFactura_ObtenerListaArticulos(ByVal cadena As String, idLista As Integer) As DataSet
        Try
            wflEmisionFactura_ObtenerListaArticulos = wflEmisionFactura.wflEmisionFactura_obtenerListaArticulos(cadena, idLista)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflEmisionFactura_ExisteCajaAbierta(cadena As String, idUsuario As Integer, lngIdsucursal As Integer) As Boolean
        Try
            wflEmisionFactura_ExisteCajaAbierta = wflEmisionFactura.wflEmisionFactura_ExisteCajaAbierta(cadena, idUsuario, lngIdsucursal)


        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
