Imports dtlFacturacion
Public Class brlListasPreciosDet
    Public Shared Function obtenerLista(ByVal cadena As String, lngCodart As Integer) As DataSet
        Try

            obtenerLista = dtlListasPreciosDet.obtenerLista(cadena, lngCodart)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function obtenerListaNovedades(ByVal cadena As String, lngidlista As Integer) As DataSet
        Try

            obtenerListaNovedades = dtlListasPreciosDet.obtenerListaNovedades(cadena, lngidlista)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function insertarRegistro(ByVal cadena As String, lpd_lpr_id As Integer, lpd_lpr_codart As Integer, _
                                            lpd_precioC As Double, lpd_porcDesc As Double, lpd_montoDesc As Double, _
                                            lpd_porcpercep As Double, lpd_montopercep As Double, lpd_precioSubTotal As Double, _
                                            lpd_porcUtil As Double, lpd_utilidad As Double, lpd_porcIva As Double, _
                                            lpd_montoIva As Double, lpd_precioVta As Double, lpd_fecModiPr As Date, _
                                            lpd_idusuario As Integer, lpd_modificado As String) As Integer

        Try
            Dim dst As New DataSet
            dst = dtlListasPreciosDet.obtenerRegistro(cadena, -1, -1)
            dst.Tables(0).Rows.Add()
            dst.Tables(0).Rows(0)("lpd_lpr_id") = lpd_lpr_id
            dst.Tables(0).Rows(0)("lpd_art_codart") = lpd_lpr_codart
            dst.Tables(0).Rows(0)("lpd_precioC") = lpd_precioC
            dst.Tables(0).Rows(0)("lpd_porcdesc") = lpd_porcDesc
            dst.Tables(0).Rows(0)("lpd_montodesc") = lpd_montoDesc
            dst.Tables(0).Rows(0)("lpd_porcpercep") = lpd_porcpercep
            dst.Tables(0).Rows(0)("lpd_montopercep") = lpd_montopercep
            dst.Tables(0).Rows(0)("lpd_precioSubtotal") = lpd_precioSubTotal
            dst.Tables(0).Rows(0)("lpd_porcutil") = lpd_porcUtil
            dst.Tables(0).Rows(0)("lpd_utilidad") = lpd_utilidad
            dst.Tables(0).Rows(0)("lpd_porciva") = lpd_porcIva
            dst.Tables(0).Rows(0)("lpd_montoiva") = lpd_montoIva
            dst.Tables(0).Rows(0)("lpd_preciovta") = lpd_precioVta
            dst.Tables(0).Rows(0)("lpd_fecmodipr") = lpd_fecModiPr
            dst.Tables(0).Rows(0)("lpd_idusuario") = lpd_idusuario
            dst.Tables(0).Rows(0)("lpd_modificado") = lpd_modificado

            insertarRegistro = dtlListasPreciosDet.insertarRegistro(dst, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function actualizarRegistro(ByVal cadena As String, lpd_lpr_id As Integer, lpd_lpr_codart As Integer, _
                                            lpd_precioC As Double, lpd_porcDesc As Double, lpd_montoDesc As Double, _
                                            lpd_porcpercep As Double, lpd_montopercep As Double, lpd_precioSubTotal As Double, _
                                            lpd_porcUtil As Double, lpd_utilidad As Double, lpd_porcIva As Double, _
                                            lpd_montoIva As Double, lpd_precioVta As Double, lpd_fecModiPr As Date, _
                                            lpd_idusuario As Integer, lpd_modificado As String) As Integer

        Try
            Dim dst As New DataSet
            dst = dtlListasPreciosDet.obtenerRegistro(cadena, lpd_lpr_id, lpd_lpr_codart)
            If dst.Tables(0).Rows.Count > 0 Then
                dst.Tables(0).Rows(0)("lpd_precioC") = lpd_precioC
                dst.Tables(0).Rows(0)("lpd_porcdesc") = lpd_porcDesc
                dst.Tables(0).Rows(0)("lpd_montodesc") = lpd_montoDesc
                dst.Tables(0).Rows(0)("lpd_porcpercep") = lpd_porcpercep
                dst.Tables(0).Rows(0)("lpd_montopercep") = lpd_montopercep
                dst.Tables(0).Rows(0)("lpd_precioSubtotal") = lpd_precioSubTotal
                dst.Tables(0).Rows(0)("lpd_porcutil") = lpd_porcUtil
                dst.Tables(0).Rows(0)("lpd_utilidad") = lpd_utilidad
                dst.Tables(0).Rows(0)("lpd_porciva") = lpd_porcIva
                dst.Tables(0).Rows(0)("lpd_montoiva") = lpd_montoIva
                dst.Tables(0).Rows(0)("lpd_preciovta") = lpd_precioVta
                dst.Tables(0).Rows(0)("lpd_fecmodipr") = lpd_fecModiPr
                dst.Tables(0).Rows(0)("lpd_idusuario") = lpd_idusuario
                dst.Tables(0).Rows(0)("lpd_modificado") = lpd_modificado

                actualizarRegistro = dtlListasPreciosDet.actualizarRegistro(dst, cadena)

            Else
                dst.Tables(0).Rows.Add()
                dst.Tables(0).Rows(0)("lpd_lpr_id") = lpd_lpr_id
                dst.Tables(0).Rows(0)("lpd_art_codart") = lpd_lpr_codart
                dst.Tables(0).Rows(0)("lpd_precioC") = lpd_precioC
                dst.Tables(0).Rows(0)("lpd_porcdesc") = lpd_porcDesc
                dst.Tables(0).Rows(0)("lpd_montodesc") = lpd_montoDesc
                dst.Tables(0).Rows(0)("lpd_porcpercep") = lpd_porcpercep
                dst.Tables(0).Rows(0)("lpd_montopercep") = lpd_montopercep
                dst.Tables(0).Rows(0)("lpd_precioSubtotal") = lpd_precioSubTotal
                dst.Tables(0).Rows(0)("lpd_porcutil") = lpd_porcUtil
                dst.Tables(0).Rows(0)("lpd_utilidad") = lpd_utilidad
                dst.Tables(0).Rows(0)("lpd_porciva") = lpd_porcIva
                dst.Tables(0).Rows(0)("lpd_montoiva") = lpd_montoIva
                dst.Tables(0).Rows(0)("lpd_preciovta") = lpd_precioVta
                dst.Tables(0).Rows(0)("lpd_fecmodipr") = lpd_fecModiPr
                dst.Tables(0).Rows(0)("lpd_idusuario") = lpd_idusuario
                dst.Tables(0).Rows(0)("lpd_modificado") = lpd_modificado

                actualizarRegistro = dtlListasPreciosDet.insertarRegistro(dst, cadena)

            End If

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function eliminarRegistro(ByVal cadena As String, lngCodart As Integer, idlista As Integer) As Boolean
        Try

            eliminarRegistro = dtlListasPreciosDet.EliminarRegistro(cadena, lngCodart, idlista)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function actualizarPrecios(ByVal cadena As String, lngCodart As Integer, dblPrecio As Double) As Long
        Try

            actualizarPrecios = dtlListasPreciosDet.actualizarPrecios(cadena, lngCodart, dblPrecio)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
