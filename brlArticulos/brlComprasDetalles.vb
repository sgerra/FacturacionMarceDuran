Imports dtlFacturacion
Public Class brlComprasDetalles
    Public Shared Function obtenerLista(ByVal cadena As String, idcompra As Integer) As DataSet
        Try

            obtenerLista = dtlComprasDetalles.obtenerLista(cadena, idCompra)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerRegistro(ByVal lngIdCompra As Integer, ByVal cadena As String) As DataSet
        Try

            obtenerRegistro = dtlComprasDetalles.obtenerRegistro(lngIdCompra, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function insertarRegistro(ByVal idCompra As Integer, codart As Integer, descri As String, _
                                            cantidad As Double, idunidad As Integer, precio As Double, _
                                            porciva As Double, montoiva As Double, porcImpInt As Double, _
                                            montoImpInt As Double, porcDto As Double, montoDto As Double, _
                                            punitfinal As Double, total As Double, porcPercep As Double,
                                            montoPercep As Double, ByVal cadena As String) As Integer
        Try
            Dim dt As New DataSet

            dt = dtlComprasDetalles.obtenerRegistro(-1, cadena)

            dt.Tables(0).Rows.Add()
            dt.Tables(0).Rows(0).Item("iddet") = -1
            dt.Tables(0).Rows(0).Item("idCompra") = idCompra
            dt.Tables(0).Rows(0).Item("codart") = codart
            dt.Tables(0).Rows(0).Item("descri") = descri
            dt.Tables(0).Rows(0).Item("cantidad") = cantidad
            dt.Tables(0).Rows(0).Item("idunidad") = idunidad
            dt.Tables(0).Rows(0).Item("precio") = precio
            dt.Tables(0).Rows(0).Item("porciva") = porciva
            dt.Tables(0).Rows(0).Item("montoiva") = montoiva
            dt.Tables(0).Rows(0).Item("porcutil") = porcImpInt
            dt.Tables(0).Rows(0).Item("montoutil") = montoImpInt
            dt.Tables(0).Rows(0).Item("porcdto") = porcDto
            dt.Tables(0).Rows(0).Item("montodto") = montoDto
            dt.Tables(0).Rows(0).Item("punitfinal") = punitfinal
            dt.Tables(0).Rows(0).Item("total") = total
            dt.Tables(0).Rows(0).Item("porcpercep") = porcpercep
            dt.Tables(0).Rows(0).Item("montopercep") = montopercep


            insertarRegistro = dtlComprasDetalles.insertarRegistro(dt, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function actualizarRegistro(ByVal idDet As Integer, ByVal idCompra As Integer, codart As Integer, descri As String, _
                                            cantidad As Double, idunidad As Integer, precio As Double, _
                                            porciva As Double, montoiva As Double, porcImpInt As Double, _
                                            montoImpInt As Double, porcDto As Double, montoDto As Double, _
                                            punitfinal As Double, total As Double, ByVal cadena As String) As Integer
        Try
            Dim dt As New DataSet


            dt = dtlComprasDetalles.obtenerRegistro(idDet, cadena)

            dt.Tables(0).Rows(0).Item("idCompra") = idCompra
            dt.Tables(0).Rows(0).Item("codart") = codart
            dt.Tables(0).Rows(0).Item("descri") = descri
            dt.Tables(0).Rows(0).Item("cantidad") = cantidad
            dt.Tables(0).Rows(0).Item("idunidad") = idunidad
            dt.Tables(0).Rows(0).Item("precio") = precio
            dt.Tables(0).Rows(0).Item("porciva") = porciva
            dt.Tables(0).Rows(0).Item("montoiva") = montoiva
            dt.Tables(0).Rows(0).Item("porcimpint") = porcImpInt
            dt.Tables(0).Rows(0).Item("montoimpint") = montoImpInt
            dt.Tables(0).Rows(0).Item("porcdto") = porcDto
            dt.Tables(0).Rows(0).Item("montodto") = montoDto
            dt.Tables(0).Rows(0).Item("punitfinal") = punitfinal
            dt.Tables(0).Rows(0).Item("total") = total


            actualizarRegistro = dtlComprasDetalles.actualizarRegistro(dt, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function eliminarDetalleporIdCompra(ByVal idCompra As Integer, cadena As String) As Integer
        Try

            dtlComprasDetalles.eliminarRegistrosPorIdCompra(idCompra, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
