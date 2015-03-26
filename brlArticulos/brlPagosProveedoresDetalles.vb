Imports dtlFacturacion
Public Class brlPagosProveedoresDetalles
    Public Shared Function obtenerLista(ByVal cadena As String, NroPago As Integer) As DataSet
        Try

            obtenerLista = dtlPagosProveedoresDetalles.obtenerLista(cadena, NroPago)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function insertarRegistro(ByVal tipfac As String, nrofac As String, dblTotalFac As Double, idCompra As Integer, _
                                            NroPago As Integer, ByVal strdeposito As String, dtFeccom As Date, ByVal cadena As String) As Integer
        Try

            Dim dt As New DataSet

            dt = dtlPagosProveedoresDetalles.obtenerRegistro(-1, cadena)

            dt.Tables(0).Rows.Add()
            dt.Tables(0).Rows(0).Item("ppd_iddet") = -1
            dt.Tables(0).Rows(0).Item("ppd_tipfac") = tipfac
            dt.Tables(0).Rows(0).Item("ppd_nrofac") = nrofac
            dt.Tables(0).Rows(0).Item("ppd_totalfac") = dblTotalFac
            dt.Tables(0).Rows(0).Item("ppd_idcompra") = idCompra
            dt.Tables(0).Rows(0).Item("ppd_deposito") = strdeposito
            dt.Tables(0).Rows(0).Item("ppd_feccom") = dtfeccom
            dt.Tables(0).Rows(0).Item("ppd_nropago") = NroPago

            insertarRegistro = dtlPagosProveedoresDetalles.insertarRegistro(dt, cadena)


        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function obtenerRegistro(ByVal cadena As String, lngNroPago As Integer) As DataSet
        Try

            obtenerRegistro = dtlPagosProveedoresDetalles.obtenerRegistro(lngNroPago, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function EliminarRegistro(ByVal cadena As String, lngNroPAgo As Integer) As Boolean
        Try

            EliminarRegistro = dtlPagosProveedoresDetalles.EliminarRegistro(cadena, lngNroPAgo)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
