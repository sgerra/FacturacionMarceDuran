Imports dtlFacturacion
Public Class brlPerfiles

    Public Shared Function obtenerPerfiles(ByVal cadena As String) As DataSet
        Try

            obtenerPerfiles = dtlPerfiles.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function GuardarPerfil(ByVal cadena As String, strNombrePerfil As String) As Boolean
        Try
            Dim dstPerfil As New DataSet
            dstPerfil = dtlPerfiles.obtenerRegistro(cadena, -1)

            dstPerfil.Tables(0).Rows.Add()
            dstPerfil.Tables(0).Rows(0)("prf_id") = -1
            dstPerfil.Tables(0).Rows(0)("prf_detperfil") = strNombrePerfil
            dtlPerfiles.insertarRegistro(cadena, dstPerfil)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function eliminarPerfil(ByVal cadena As String, idPerfil As Integer) As Boolean
        Try

            eliminarPerfil = dtlPerfiles.eliminarRegistro(cadena, idperfil)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
