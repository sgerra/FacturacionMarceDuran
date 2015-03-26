Imports dtlFacturacion
Public Class brlCajaDiariaSaldosFormaPago
    Public Shared Function insertarRegistro(cds_caj_id As Integer, cds_codfp As Integer, cds_saldo As Double, cadena As String) As Integer
        Try


            Dim dt As DataSet = dtlCajaDiariaSaldosFormaPago.obtenerRegistro(cadena, -1)

            dt.Tables(0).Rows.Add()
            dt.Tables(0).Rows(0).Item("cds_id") = -1
            dt.Tables(0).Rows(0).Item("cds_caj_id") = cds_caj_id
            dt.Tables(0).Rows(0).Item("cds_codfp") = cds_codfp
            dt.Tables(0).Rows(0).Item("cds_saldo") = cds_saldo

            insertarRegistro = dtlCajaDiariaSaldosFormaPago.insertarRegistro(dt, cadena)


        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

End Class
