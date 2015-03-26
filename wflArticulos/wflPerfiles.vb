Imports brlFacturacion
Public Class wflPerfiles
    Public Shared Function Perfiles_obtenerLista(ByVal cadena As String) As DataSet
        Try
            Perfiles_obtenerLista = brlPerfiles.obtenerPerfiles(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Perfiles_GuardarPerfil(ByVal cadena As String, strNombrePerfil As String, exito As Boolean) As Boolean
        Try

            brlPerfiles.GuardarPerfil(cadena, strNombrePerfil)

            exito = True
        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Perfiles_EliminarPerfil(ByVal cadena As String, idPerfil As Integer) As Boolean
        Try

            brlPerfiles.EliminarPerfil(cadena, idPerfil)
            brlPermisosPorFormu.eliminarRegistro(cadena, idPerfil)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

End Class
