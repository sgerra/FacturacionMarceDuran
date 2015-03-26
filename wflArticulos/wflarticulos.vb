Imports brlFacturacion
Imports System.Transactions
Public Class wflarticulos
    Public Shared Function ObtenerArticulo(ByVal lngIdArticulo As Long, ByVal cadena As String) As DataSet
        Try

            ObtenerArticulo = brlFacturacion.brlArticulos.ObtenerArticulo(lngIdArticulo, cadena)
        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Articulos" + "|" + ex.Message)
        End Try

    End Function

    Public Shared Function ObtenerArticuloPorCodigoBarras(ByVal codigobarras As String, ByVal cadena As String) As DataSet
        Try

            ObtenerArticuloPorCodigoBarras = brlFacturacion.brlArticulos.ObtenerArticuloPorcodigoBarras(codigobarras, cadena)
        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Articulo por codigo barras" + "|" + ex.Message)
        End Try

    End Function

    Public Shared Function ObtenerLista(ByVal cadena As String) As DataSet
        Try
            ObtenerLista = brlFacturacion.brlArticulos.ObtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function ObtenerListaParaGrilla(ByVal cadena As String, ByVal codigobarras As String) As DataSet
        Try
            ObtenerListaParaGrilla = brlFacturacion.brlArticulos.ObtenerListaParaGrilla(cadena, codigobarras)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista Para Grilla" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function InsertarArticulo(ByVal cadena As String, ByVal dstarticulos As DataSet, dstListaPrecios As DataSet, dsStock As DataSet, ByRef strMensaje As String) As Long
        Try
            Dim intResult As Integer

            If Not brlArticulos.ExisteArticulo(dstarticulos.Tables(0).Rows(0)("cod"), cadena) Then

                '-----Insertar el articulo en la tabla de articulos y obtengo el id ------------
                intResult = brlArticulos.InsertarArticulo(dstarticulos, cadena)
                '---------Grabo las listas de precios correspondientes ------------------
                For Each dr As DataRow In dstListaPrecios.Tables(0).Rows

                    brlListasPreciosDet.insertarRegistro(cadena, dr("lpd_lpr_id"), intResult, dr("lpd_precioC"), dr("lpd_porcDesc"), _
                                                         dr("lpd_montodesc"), dr("lpd_porcpercep"), dr("lpd_montopercep"), dr("lpd_preciosubtotal"), _
                                                         dr("lpd_porcutil"), dr("lpd_utilidad"), dr("lpd_porciva"), dr("lpd_montoiva"), dr("lpd_preciovta"), _
                                                         dr("lpd_fecmodipr"), dr("lpd_idusuario"), dr("lpd_modificado"))

                Next

                '--------------------------------------------------------------------------

                '---------Grabo los stock correspondientes ------------------
                For Each dr As DataRow In dsStock.Tables(0).Rows

                    brlStockPorDeposito.insertarRegistro(cadena, dr("iddeposito"), intResult, dr("stockInicial"), dr("stockActual"), dr("stockMinimo"), dr("stockMaximo"), dr("FechaInv"))

                Next

                '--------------------------------------------------------------------------
                strMensaje = "El articulo se grabó con éxito en la base de datos"

            Else
                strMensaje = "El articulo ya existe en la base de datos."

            End If

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function ModificarArticulo(ByVal cadena As String, ByVal dstarticulos As DataSet, dstListaPrecios As DataSet, dsStock As DataSet, ByRef strMensaje As String) As Long
        Try
            Dim intResult As Integer


            'Using scope As New TransactionScope()
            '-----Insertar el articulo en la tabla de articulos y obtengo el id ------------
            intResult = brlArticulos.ActualizarArticulo(dstarticulos, cadena)
            '---------Grabo las listas de precios correspondientes ------------------
            For Each dr As DataRow In dstListaPrecios.Tables(0).Rows
                If dr("eliminado") = "N" Then
                    brlListasPreciosDet.actualizarRegistro(cadena, dr("lpd_lpr_id"), dr("lpd_art_codart"), dr("lpd_precioC"), dr("lpd_porcDesc"), _
                                                         dr("lpd_montodesc"), dr("lpd_porcpercep"), dr("lpd_montopercep"), dr("lpd_preciosubtotal"), _
                                                         dr("lpd_porcutil"), dr("lpd_utilidad"), dr("lpd_porciva"), dr("lpd_montoiva"), dr("lpd_preciovta"), _
                                                         dr("lpd_fecmodipr"), dr("lpd_idusuario"), dr("lpd_modificado"))
                Else
                    brlListasPreciosDet.eliminarRegistro(cadena, dr("lpd_art_codart"), dr("lpd_lpr_id"))
                End If

            Next

            '--------------------------------------------------------------------------

            '---------Grabo los stock correspondientes ------------------
            For Each dr As DataRow In dsStock.Tables(0).Rows
                If dr("eliminado") = False Then
                    brlStockPorDeposito.actualizarRegistro(cadena, dr("iddeposito"), dr("codart"), dr("stockInicial"), dr("stockActual"), dr("stockMinimo"), dr("stockMaximo"), dr("FechaInv"))
                Else
                    brlStockPorDeposito.eliminarRegistro(cadena, dr("codart"), dr("iddeposito"))
                End If
            Next

            '--------------------------------------------------------------------------
            strMensaje = "El articulo se modificó con éxito"
            'scope.Complete()
            'End Using


        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function


    Public Shared Function Proveedores_obtenerLista(ByVal cadena As String) As DataSet
        Try
            Proveedores_obtenerLista = brlProveedores.obtenerLista(cadena)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function tRubros_obtenerLista(ByVal cadena As String) As DataSet
        Try
            tRubros_obtenerLista = brltRubros.obtenerLista(cadena)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function Unidades_obtenerLista(ByVal cadena As String) As DataSet
        Try
            Unidades_obtenerLista = brlUnidades.obtenerLista(cadena)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Etiquetas_obtenerLista(ByVal cadena As String) As DataSet
        Try
            Etiquetas_obtenerLista = brlEtiquetas.obtenerLista(cadena)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function ListasPrecios_obtenerLista(ByVal cadena As String) As DataSet
        Try
            ListasPrecios_obtenerLista = brlListasPrecios.obtenerLista(cadena)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function ListasPreciosDet_obtenerLista(ByVal cadena As String, lngCodart As Integer) As DataSet
        Try
            ListasPreciosDet_obtenerLista = brlListasPreciosDet.obtenerLista(cadena, lngCodart)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function StockPorDeposito_obtenerLista(ByVal cadena As String, lngCodart As Integer) As DataSet
        Try
            StockPorDeposito_obtenerLista = brlStockPorDeposito.obtenerLista(cadena, lngCodart)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflarticulos_Depositos_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflarticulos_Depositos_obtenerLista = brlDepositos.obtenerLista(cadena)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflArticulos_obtenerRegistro(ByVal lngIdArticulo As Long, ByVal cadena As String) As DataSet
        Try

            wflArticulos_obtenerRegistro = brlArticulos.obtenerRegistro(lngIdArticulo, cadena)
        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Articulos" + "|" + ex.Message)
        End Try

    End Function

    Public Shared Function wflArticulos_armarNovedades(ByVal cadena As String) As DataSet
        Try

            wflArticulos_armarNovedades = brlArticulos.armarNovedades(cadena)
        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Armar Novedades" + "|" + ex.Message)
        End Try

    End Function


End Class
