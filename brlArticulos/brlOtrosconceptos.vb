Imports dtlFacturacion
Public Class brlOtrosconceptos
    Public Shared Function obtenerLista(ByVal cadena As String, NroPago As Integer) As DataSet
        Try

            obtenerLista = dtlOtrosConceptos.obtenerLista(cadena, NroPago)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function insertarRegistro(ByVal poc_fecha As Date, poc_idprove As Integer, poc_descripcion As String, _
                                            poc_monto As Double, poc_comprobante As String, poc_nropago As Integer, ByVal cadena As String) As Integer
        Try
            Dim dt As New DataSet

            dt = dtlOtrosConceptos.obtenerRegistro(-1, cadena)

            dt.Tables(0).Rows.Add()
            dt.Tables(0).Rows(0).Item("poc_id") = -1
            dt.Tables(0).Rows(0).Item("poc_fecha") = poc_fecha
            dt.Tables(0).Rows(0).Item("poc_idprove") = poc_idprove
            dt.Tables(0).Rows(0).Item("poc_descripcion") = poc_descripcion
            dt.Tables(0).Rows(0).Item("poc_monto") = poc_monto
            dt.Tables(0).Rows(0).Item("poc_comprobante") = poc_comprobante
            dt.Tables(0).Rows(0).Item("poc_nropago") = poc_nropago

            insertarRegistro = dtlOtrosConceptos.insertarRegistro(dt, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerRegistro(ByVal lngIdOc As Integer, ByVal cadena As String) As DataSet
        Try

            obtenerRegistro = dtlOtrosConceptos.obtenerRegistro(lngIdOc, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function EliminarRegistro(ByVal cadena As String, lngNroPAgo As Integer) As Boolean
        Try

            EliminarRegistro = dtlOtrosConceptos.EliminarRegistro(cadena, lngNroPAgo)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function SumarSaldo(ByVal cadena As String, idProv As Integer) As Double
        Try

            Sumarsaldo = dtlOtrosConceptos.obtenerSaldo(cadena, idProv)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
