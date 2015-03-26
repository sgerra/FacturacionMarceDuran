Imports dtlFacturacion
Public Class brlBonificaciones
    Public Shared Function obtenerLista(ByVal cadena As String) As DataSet
        Try

            obtenerLista = dtlBonificaciones.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function obtenerBonificacionesPorNroPago(ByVal cadena As String, nroPago As Integer) As DataView
        Try
            Dim dtBon As New DataSet
            dtBon = dtlBonificaciones.obtenerLista(cadena)

            'filtro las facturas impagas
            dtBon.Tables(0).DefaultView.RowFilter = "bon_nropago=" & nroPago

            obtenerBonificacionesPorNroPago = dtBon.Tables(0).DefaultView

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function obtenerBonificacionesPorProveedor(ByVal cadena As String, idProve As Integer) As DataView
        Try
            Dim dtBon As New DataSet
            dtBon = dtlBonificaciones.obtenerLista(cadena)

            'filtro las facturas impagas
            dtBon.Tables(0).DefaultView.RowFilter = "bon_nroprove=" & idProve & " and bon_usada=0"

            obtenerBonificacionesPorProveedor = dtBon.Tables(0).DefaultView

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function insertarRegistro(bon_fecha As Date, bon_nrobon As String, bon_nroprove As Integer, _
                                            bon_concepto As String, bon_monto As Double, bon_comprobante As String, bon_usada As Integer,
                                            bon_nropago As Integer, ByVal cadena As String) As Integer
        Try
            Dim dt As New DataSet

            dt = dtlBonificaciones.obtenerRegistro(-1, cadena)

            dt.Tables(0).Rows.Add()
            dt.Tables(0).Rows(0).Item("bon_idbon") = -1
            dt.Tables(0).Rows(0).Item("bon_fecha") = bon_fecha
            dt.Tables(0).Rows(0).Item("bon_nrobon") = bon_nrobon
            dt.Tables(0).Rows(0).Item("bon_nroprove") = bon_nroprove
            dt.Tables(0).Rows(0).Item("bon_concepto") = bon_concepto
            dt.Tables(0).Rows(0).Item("bon_monto") = bon_monto
            dt.Tables(0).Rows(0).Item("bon_comprobante") = bon_comprobante
            dt.Tables(0).Rows(0).Item("bon_usada") = bon_usada
            dt.Tables(0).Rows(0).Item("bon_nropago") = bon_nropago

            insertarRegistro = dtlBonificaciones.insertarRegistro(dt, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function EliminarRegistro(ByVal cadena As String, lngIdProv As Integer, lngNroPAgo As Integer) As Boolean
        Try

            EliminarRegistro = dtlBonificaciones.EliminarRegistro(cadena, lngIdProv, lngNroPAgo)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function SumarBonificaciones(ByVal cadena As String, idProv As Integer) As Double
        Try

            SumarBonificaciones = dtlBonificaciones.obtenerSaldoBoni(cadena, idProv)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

End Class
