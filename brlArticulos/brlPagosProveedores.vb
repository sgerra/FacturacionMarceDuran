Imports dtlFacturacion
Public Class brlPagosProveedores
    Public Shared Function obtenerLista(ByVal cadena As String, idprov As Integer) As DataSet
        Try

            obtenerLista = dtlPagosProveedores.obtenerLista(cadena, idprov)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function obtenerRegistro(ByVal cadena As String, idpago As Integer) As DataSet
        Try

            obtenerRegistro = dtlPagosProveedores.obtenerRegistro(idpago, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function obtenerPagosAbiertos(ByVal cadena As String, idprov As Integer) As DataView

        Try
            Dim auxDt As New DataSet
            auxDt = dtlPagosProveedores.obtenerLista(cadena, idprov)

            'filtro los pagos abiertos
            auxDt.Tables(0).DefaultView.RowFilter = "ppr_estado = 'A'"

            obtenerPagosAbiertos = auxDt.Tables(0).DefaultView

            
        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function insertarRegistro(ByVal dsPagos As DataSet, ByVal cadena As String) As Integer
        Try

            insertarRegistro = dtlPagosProveedores.insertarRegistro(dsPagos, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function EliminarRegistro(ByVal cadena As String, lngIdProv As Integer, lngNroPAgo As Integer) As Boolean
        Try

            EliminarRegistro = dtlPagosProveedores.EliminarRegistro(cadena, lngIdProv, lngNroPAgo)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function SumarPagos(ByVal cadena As String, idProv As Integer) As Double
        Try

            SumarPagos = dtlPagosProveedores.obtenerSaldoPagos(cadena, idProv)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    
End Class
