Imports dtlFacturacion

Public Class brlCompras

    Public Shared Function obtenerLista(ByVal cadena As String) As DataSet
        Try

            obtenerLista = dtlCompras.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerRegistro(ByVal lngIdCompra As Integer, ByVal cadena As String) As DataSet
        Try

            obtenerRegistro = dtlCompras.obtenerRegistro(lngIdCompra, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function insertarRegistro(ByVal dsCompras As DataSet, ByVal cadena As String) As Integer
        Try

            insertarRegistro = dtlCompras.insertarRegistro(dsCompras, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function actualizarRegistro(ByVal dsCompras As DataSet, ByVal cadena As String) As Integer
        Try

            actualizarRegistro = dtlCompras.actualizarRegistro(dsCompras, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerFacturasImpagas(ByVal cadena As String, idProve As Integer) As DataView
        Try
            Dim dtFac As New DataSet
            dtFac = dtlCompras.obtenerLista(cadena)

            'filtro las facturas impagas
            dtFac.Tables(0).DefaultView.RowFilter = "idproveedor=" & idProve & " and pagada=0 and idEstado<>2"

            obtenerFacturasImpagas = dtFac.Tables(0).DefaultView

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function SumarFacturas(ByVal cadena As String, idProv As Integer) As Double
        Try

            SumarFacturas = dtlCompras.obtenerSaldoFacturas(cadena, idProv)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
