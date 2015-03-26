Imports dtlFacturacion
Public Class brlTFactura

    Public Shared Function obtenerLista(ByVal cadena As String) As DataSet
        Try

            obtenerLista = dtltFactura.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerRegistro(ByVal strCampo As String, ByVal cadena As String) As DataSet
        Try

            obtenerRegistro = dtltFactura.obtenerRegistro(strCampo, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function actualizarRegistro(ByVal strcampo As String, ByVal cadena As String) As Integer
        Try

            dtltFactura.actualizarRegistro(strcampo, cadena)


        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

End Class
