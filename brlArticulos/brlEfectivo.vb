Imports dtlFacturacion
Public Class brlEfectivo
    Public Shared Function obtenerLista(ByVal cadena As String, lngTpoMoneda As Integer) As DataSet
        Try

            obtenerLista = dtlEfectivo.obtenerLista(cadena, lngtpomoneda)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerEfectivoPorNroPago(ByVal cadena As String, nroPago As Integer, tpoMoneda As Integer) As DataView
        Try
            Dim dtEfe As New DataSet
            dtEfe = dtlEfectivo.obtenerLista(cadena, tpomoneda)

            'filtro las facturas impagas
            dtEfe.Tables(0).DefaultView.RowFilter = "pde_nropago=" & nroPago

            obtenerEfectivoPorNroPago = dtEfe.Tables(0).DefaultView

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function insertarRegistro(pde_tpomoneda As Integer, pde_monto As Double, _
                                            pde_nropago As Integer, ByVal cadena As String) As Integer
        Try
            Dim dt As New DataSet

            dt = dtlEfectivo.obtenerRegistro(-1, cadena)

            dt.Tables(0).Rows.Add()
            dt.Tables(0).Rows(0).Item("pde_idpde") = -1
            dt.Tables(0).Rows(0).Item("pde_tpomoneda") = pde_tpomoneda
            dt.Tables(0).Rows(0).Item("pde_monto") = pde_monto
            dt.Tables(0).Rows(0).Item("pde_nropago") = pde_nropago

            insertarRegistro = dtlEfectivo.insertarRegistro(dt, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function EliminarRegistro(ByVal cadena As String, lngNroPAgo As Integer) As Boolean
        Try

            EliminarRegistro = dtlEfectivo.EliminarRegistro(cadena, lngNroPAgo)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
