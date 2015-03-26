Imports dtlFacturacion
Public Class brlDepositosPagos
  

    Public Shared Function obtenerDepositosPorNroPago(ByVal cadena As String, nroPago As Integer, tpoMoneda As Integer) As DataView
        Try
            Dim dtDep As New DataSet
            dtDep = dtlDepositosPagos.obtenerLista(cadena, tpoMoneda)

            'filtro las facturas impagas
            dtDep.Tables(0).DefaultView.RowFilter = "dep_nropago=" & nroPago

            obtenerDepositosPorNroPago = dtDep.Tables(0).DefaultView

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerLista(ByVal cadena As String, lngTpoMoneda As Integer) As DataSet
        Try

            obtenerLista = dtlDepositosPagos.obtenerLista(cadena, lngTpoMoneda)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function insertarRegistro(dep_idbanco As Integer, dep_nroboleta As Integer, dep_fecha As Date, _
                                            dep_totaldepo As Double, dep_nropago As Integer, cadena As String) As Integer
        Try
            Dim dt As New DataSet

            dt = dtlDepositosPagos.obtenerRegistro(-1, cadena)

            dt.Tables(0).Rows.Add()
            dt.Tables(0).Rows(0).Item("dep_id") = -1
            dt.Tables(0).Rows(0).Item("dep_idbanco") = dep_idbanco
            dt.Tables(0).Rows(0).Item("dep_nroboleta") = dep_nroboleta
            dt.Tables(0).Rows(0).Item("dep_fecha") = dep_fecha
            dt.Tables(0).Rows(0).Item("dep_totaldepo") = dep_totaldepo
            dt.Tables(0).Rows(0).Item("dep_nropago") = dep_nropago

            insertarRegistro = dtlDepositosPagos.insertarRegistro(dt, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function EliminarRegistro(ByVal cadena As String, lngNroPAgo As Integer) As Boolean
        Try

            EliminarRegistro = dtlDepositosPagos.EliminarRegistro(cadena, lngNroPAgo)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
