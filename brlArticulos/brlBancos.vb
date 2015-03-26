Imports dtlFacturacion
Public Class brlBancos

    Public Shared Function obtenerBancosVigentes(ByVal cadena As String) As DataSet
        Try

            obtenerBancosVigentes = dtlBancos.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerRegistro(ByVal lngIdBanco As Integer, ByVal cadena As String) As DataSet
        Try

            obtenerRegistro = dtlBancos.obtenerRegistro(lngIdBanco, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
