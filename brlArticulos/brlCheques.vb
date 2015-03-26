Imports dtlFacturacion
Public Class brlCheques
    Public Shared Function obtenerLista(ByVal cadena As String) As DataSet
        Try

            obtenerLista = dtlCheques.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function obtenerChequesPorNroPago(ByVal cadena As String, nroPago As Integer) As DataView
        Try
            Dim dtChe As New DataSet
            dtChe = dtlCheques.obtenerLista(cadena)

            'filtro las facturas impagas
            dtChe.Tables(0).DefaultView.RowFilter = "pcp_nropago=" & nroPago

            obtenerChequesPorNroPago = dtChe.Tables(0).DefaultView

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function insertarRegistro(pcp_nrocheque As String, pcp_banco As Integer, pcp_monto As Double, _
                                            pcp_fecemi As Date, pcp_fecpago As Date, pcp_soc_id As Integer, _
                                            pcp_nropago As Integer, pcp_origen As String, ByVal cadena As String) As Integer
        Try
            Dim dt As New DataSet

            dt = dtlCheques.obtenerRegistro(-1, cadena)

            dt.Tables(0).Rows.Add()
            dt.Tables(0).Rows(0).Item("pcp_idpcp") = -1
            dt.Tables(0).Rows(0).Item("pcp_nrocheque") = pcp_nrocheque
            dt.Tables(0).Rows(0).Item("pcp_banco") = pcp_banco
            dt.Tables(0).Rows(0).Item("pcp_monto") = pcp_monto
            dt.Tables(0).Rows(0).Item("pcp_fecemi") = pcp_fecemi
            dt.Tables(0).Rows(0).Item("pcp_fecpago") = pcp_fecpago
            dt.Tables(0).Rows(0).Item("pcp_soc_id") = pcp_soc_id
            dt.Tables(0).Rows(0).Item("pcp_nropago") = pcp_nropago
            dt.Tables(0).Rows(0).Item("pcp_origen") = pcp_origen

            insertarRegistro = dtlCheques.insertarRegistro(dt, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function EliminarRegistro(ByVal cadena As String, lngNroPAgo As Integer) As Boolean
        Try

            EliminarRegistro = dtlCheques.EliminarRegistro(cadena, lngNroPAgo)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
