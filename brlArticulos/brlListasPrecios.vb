﻿Imports dtlFacturacion
Public Class brlListasPrecios
    Public Shared Function obtenerLista(ByVal cadena As String) As DataSet
        Try

            obtenerLista = dtlListasPrecios.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
