Imports dtlFacturacion
Public Class brlSaldosProve
    Public Shared Function obtenerRegistro(ByVal lngIdProv As Integer, ByVal cadena As String) As DataSet
        Try

            obtenerRegistro = dtlSaldosProve.obtenerRegistro(lngIdProv, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function actualizarRegistro(ByVal dSaldos As DataSet, ByVal cadena As String) As Integer
        Try

            actualizarRegistro = dtlSaldosProve.actualizarRegistro(dSaldos, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function insertarRegistro(ByVal dSaldos As DataSet, ByVal cadena As String) As Integer
        Try

            insertarRegistro = dtlSaldosProve.insertarRegistro(dSaldos, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function SaldosIni(ByVal cadena As String, idProv As Integer) As Double
        Try
            Dim dstSaldos As New DataSet
            Dim dblSaldoini As Double
            Dim dblSaldo As Double
            dstSaldos = obtenerRegistro(idProv, cadena)

            If dstSaldos.Tables(0).Rows.Count > 0 Then
                dblSaldoini = dstSaldos.Tables(0).Rows(0)("sal_saldoini")
                ' dblSaldo = dstSaldos.Tables(0).Rows(0)("sal_saldo")
                SaldosIni = dblSaldoini '+ dblSaldo
            End If


        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
