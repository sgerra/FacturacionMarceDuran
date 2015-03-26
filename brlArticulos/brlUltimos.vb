Imports dtlFacturacion
Public Class brlUltimos
    Public Shared Function obtenerRegistro(ByVal strCampo As String, ByVal cadena As String) As DataSet
        Try

            obtenerRegistro = dtlUltimos.obtenerRegistro(strCampo, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function actualizarRegistro(ByVal strcampo As String, ByVal cadena As String) As Integer
        Try

            dtlUltimos.actualizarRegistro(strcampo, cadena)


        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
