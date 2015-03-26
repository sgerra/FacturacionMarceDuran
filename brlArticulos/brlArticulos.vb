Imports dtlFacturacion
Public Class brlArticulos

    Public Shared Function obtenerArticulo(ByVal lngIdArticulo As Long, ByVal cadena As String) As DataSet
        Try

            ObtenerArticulo = dtlFacturacion.dtlArticulos.obtenerArticulo(lngIdArticulo, cadena)
        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Articulo" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function obtenerArticuloPorcodigoBarras(ByVal codigobarras As String, ByVal cadena As String) As DataSet
        Try

            ObtenerArticuloPorcodigoBarras = dtlFacturacion.dtlArticulos.obtenerArticuloPorCodigoBarras(codigobarras, cadena)
        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Articulo Por Codigo Barras" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function obtenerLista(ByVal cadena As String) As DataSet
        Try

            obtenerLista = dtlFacturacion.dtlArticulos.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function ObtenerListaParaGrilla(ByVal cadena As String, ByVal idLista As Integer) As DataSet
        Try

            ObtenerListaParaGrilla = dtlFacturacion.dtlArticulos.ObtenerListaParaGrilla(cadena, idLista)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function InsertarArticulo(ByVal dsarticulos As DataSet, ByVal cadena As String) As Integer
        Try
            InsertarArticulo = dtlArticulos.InsertarArticulo(dsarticulos, cadena)
        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function ActualizarArticulo(ByVal dsarticulos As DataSet, ByVal cadena As String) As Integer
        Try
            dtlArticulos.actualizarRegistro(dsarticulos, cadena)
        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function ExisteArticulo(ByVal codigo As String, ByVal cadena As String) As Boolean
        Dim ds As New DataSet
        Try
            ds = dtlFacturacion.dtlArticulos.obtenerArticuloPorCodigoBarras(codigo, cadena)
            If ds.Tables(0).Rows.Count > 0 Then
                If ds.Tables(0).Rows(0).Item("codart") <> 0 Then
                    ExisteArticulo = True
                Else
                    ExisteArticulo = False
                End If
            Else
                ExisteArticulo = False
            End If
        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Existe Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerProductosPorProveedor(ByVal cadena As String, idProveedor As Integer) As DataView
        Try

            Dim auxDatasaet As DataSet
            Dim newDataset As New DataSet

            'obtenego los articulos
            auxDatasaet = dtlArticulos.obtenerLista(cadena)
            'filtro los articulos
            auxDatasaet.Tables(0).DefaultView.RowFilter = "idproveedor=" & idProveedor

            obtenerProductosPorProveedor = auxDatasaet.Tables(0).DefaultView

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function ActualizarPrecioPorArticulo(ByVal codart As Integer, dblPreciCosto As Double, ByVal cadena As String) As Integer
        Try
            dtlFacturacion.dtlArticulos.actualizarPrecioPorCodigoArticulo(codart, dblPreciCosto, cadena)
        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerRegistro(ByVal lngIdArticulo As Long, ByVal cadena As String) As DataSet
        Try

            obtenerRegistro = dtlArticulos.obtenerRegistro(lngIdArticulo, cadena)
        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerArticuloFacturacion(ByVal cadena As String, ByVal lngIdArticulo As Long, ByVal idLista As Integer) As DataSet
        Try

            obtenerArticuloFacturacion = dtlArticulos.obtenerArticuloFacturacion(cadena, lngIdArticulo, idlista)
        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerDetalle(ByVal cadena As String) As DataSet
        Try

            obtenerDetalle = dtlArticulos.ObtenerDetalle(cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function armarNovedades(ByVal cadena As String) As DataSet
        Try

            armarNovedades = dtlArticulos.ArmarNovedades(cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
