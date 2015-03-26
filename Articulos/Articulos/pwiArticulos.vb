Imports wflFacturacion
Public Class pwiArticulos
    Public Shared Function wflArticulos_Proveedores_obtenerLista(cadena As String) As DataSet
        Try
            wflArticulos_Proveedores_obtenerLista = wflarticulos.Proveedores_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflArticulos_tRubros_obtenerLista(cadena As String) As DataSet
        Try
            wflArticulos_tRubros_obtenerLista = wflarticulos.tRubros_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflArticulos_Unidades_obtenerLista(cadena As String) As DataSet
        Try
            wflArticulos_Unidades_obtenerLista = wflarticulos.Unidades_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflArticulos_Etiquetas_obtenerLista(cadena As String) As DataSet
        Try
            wflArticulos_Etiquetas_obtenerLista = wflarticulos.Etiquetas_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflArticulos_ListasPrecios_obtenerLista(cadena As String) As DataSet
        Try
            wflArticulos_ListasPrecios_obtenerLista = wflarticulos.ListasPrecios_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflArticulos_ListasPreciosDet_obtenerLista(cadena As String, lngCodart As Integer) As DataSet
        Try
            wflArticulos_ListasPreciosDet_obtenerLista = wflarticulos.ListasPreciosDet_obtenerLista(cadena, lngcodart)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflArticulos_StockPorDeposito_obtenerLista(cadena As String, lngCodart As Integer) As DataSet
        Try
            wflArticulos_StockPorDeposito_obtenerLista = wflarticulos.StockPorDeposito_obtenerLista(cadena, lngCodart)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflArticulos_InsertarArticulos(ByVal cadena As String, ByVal dstarticulos As DataSet, dstListasPreciosDet As DataSet, dstStockPorDepo As DataSet, ByRef strMensaje As String) As Long
        Try
            wflArticulos_InsertarArticulos = wflarticulos.InsertarArticulo(cadena, dstarticulos, dstListasPreciosDet, dstStockPorDepo, strMensaje)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflArticulos_ModificarArticulos(ByVal cadena As String, ByVal dstarticulos As DataSet, dstListasPreciosDet As DataSet, dstStockPorDepo As DataSet, ByRef strMensaje As String) As Long
        Try
            wflArticulos_ModificarArticulos = wflarticulos.ModificarArticulo(cadena, dstarticulos, dstListasPreciosDet, dstStockPorDepo, strMensaje)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflArticulos_Articulos_obtenerRegistro(ByVal cadena As String, ByVal lngIdArticulo As Integer) As DataSet
        Try
            wflArticulos_Articulos_obtenerRegistro = wflarticulos.wflArticulos_obtenerRegistro(lngIdArticulo, cadena)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "obtener Registro" + "|" + ex.Message)
        End Try
    End Function
End Class
