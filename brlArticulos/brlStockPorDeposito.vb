Imports dtlFacturacion
Public Class brlStockPorDeposito
    Public Shared Function obtenerLista(ByVal cadena As String, lngCodart As Integer) As DataSet
        Try

            obtenerLista = dtlStockPorDeposito.obtenerLista(cadena, lngCodart)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function insertarRegistro(ByVal cadena As String, iddeposito As Integer, codart As Integer, stockInicial As Double, _
                                            stockactual As Double, stockMinimo As Double, stockMaximo As Double, FechaInv As Date) As Integer

        Try
            Dim dst As New DataSet
            dst = dtlStockPorDeposito.obtenerRegistro(cadena, -1, -1)
            dst.Tables(0).Rows.Add()
            dst.Tables(0).Rows(0)("iddeposito") = iddeposito
            dst.Tables(0).Rows(0)("codart") = codart
            dst.Tables(0).Rows(0)("stockInicial") = stockInicial
            dst.Tables(0).Rows(0)("stockActual") = stockactual
            dst.Tables(0).Rows(0)("stockMinimo") = stockMinimo
            dst.Tables(0).Rows(0)("stockMaximo") = stockMaximo
            dst.Tables(0).Rows(0)("FechaInv") = FechaInv

            insertarRegistro = dtlStockPorDeposito.insertarRegistro(dst, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function actualizarRegistro(ByVal cadena As String, iddeposito As Integer, codart As Integer, stockInicial As Double, _
                                            stockactual As Double, stockMinimo As Double, stockMaximo As Double, FechaInv As Date) As Integer

        Try
            Dim dst As New DataSet
            dst = dtlStockPorDeposito.obtenerRegistro(cadena, codart, iddeposito)
            If dst.Tables(0).Rows.Count > 0 Then
                dst.Tables(0).Rows(0)("iddeposito") = iddeposito
                dst.Tables(0).Rows(0)("codart") = codart
                dst.Tables(0).Rows(0)("stockInicial") = stockInicial
                dst.Tables(0).Rows(0)("stockActual") = stockactual
                dst.Tables(0).Rows(0)("stockMinimo") = stockMinimo
                dst.Tables(0).Rows(0)("stockMaximo") = stockMaximo
                dst.Tables(0).Rows(0)("FechaInv") = FechaInv
                actualizarRegistro = dtlStockPorDeposito.actualizarRegistro(dst, cadena)
            Else
                dst.Tables(0).Rows.Add()
                dst.Tables(0).Rows(0)("iddeposito") = iddeposito
                dst.Tables(0).Rows(0)("codart") = codart
                dst.Tables(0).Rows(0)("stockInicial") = stockInicial
                dst.Tables(0).Rows(0)("stockActual") = stockactual
                dst.Tables(0).Rows(0)("stockMinimo") = stockMinimo
                dst.Tables(0).Rows(0)("stockMaximo") = stockMaximo
                dst.Tables(0).Rows(0)("FechaInv") = FechaInv

                actualizarRegistro = dtlStockPorDeposito.insertarRegistro(dst, cadena)
            End If
        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function eliminarRegistro(ByVal cadena As String, lngCodart As Integer, iddeposito As Integer) As Boolean
        Try

            eliminarRegistro = dtlStockPorDeposito.EliminarRegistro(cadena, lngCodart, iddeposito)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerRegistro(ByVal cadena As String, lngCodart As Integer, iddeposito As Integer) As DataSet
        Try

            obtenerRegistro = dtlStockPorDeposito.obtenerRegistro(cadena, lngCodart, iddeposito)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function DescontarStockActual(ByVal cadena As String, lngCodart As Integer, iddeposito As Integer, dblCantidad As Double) As Boolean
        Try
            Dim dst As New DataSet
            dst = dtlStockPorDeposito.obtenerRegistro(cadena, lngCodart, iddeposito)

            If dst.Tables(0).Rows.Count > 0 Then

                dst.Tables(0).Rows(0)("stockactual") = dst.Tables(0).Rows(0)("stockactual") - dblCantidad

                Dim lngDep = dtlStockPorDeposito.actualizarRegistro(dst, cadena)
                DescontarStockActual = True

            End If


        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
