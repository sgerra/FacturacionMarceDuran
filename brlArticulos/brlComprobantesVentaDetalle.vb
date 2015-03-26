Imports dtlFacturacion
Public Class brlComprobantesVentaDetalle
    Public Shared Function obtenerRegistro(ByVal cadena As String, lngNroCom As Integer) As DataSet
        Try

            obtenerRegistro = dtlComprobantesVentaDetalle.obtenerRegistro(cadena, lngNroCom)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function insertarRegistro(ByVal cadena As String, NroCom As Integer, Codart As Integer, descart As String, _
                                            cantidad As Double, precUnit As Double, totArt As Double, idRubro As Integer) As Integer
        Try

            Dim auxReg As New DataSet
            auxReg = dtlComprobantesVentaDetalle.obtenerRegistro(cadena, -1)
            auxReg.Tables(0).Rows.Add()
            auxReg.Tables(0).Rows(0)("cvd_id") = -1
            auxReg.Tables(0).Rows(0)("cvd_nrocom") = NroCom
            auxReg.Tables(0).Rows(0)("cvd_codart") = Codart
            auxReg.Tables(0).Rows(0)("cvd_descart") = descart
            auxReg.Tables(0).Rows(0)("cvd_cantidad") = cantidad
            auxReg.Tables(0).Rows(0)("cvd_precunit") = precunit
            auxReg.Tables(0).Rows(0)("cvd_totart") = totArt
            auxReg.Tables(0).Rows(0)("cvd_idrubro") = idRubro

            insertarRegistro = dtlComprobantesVentaDetalle.insertarRegistro(cadena, auxReg)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
