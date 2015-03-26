Public Class pwiPerfiles

    Public Shared Function GuardarPerfil(ByVal cadena As String, strNombrePerfil As String, exito As Boolean) As Integer
        Try
            wflFacturacion.wflPerfiles.Perfiles_GuardarPerfil(cadena, strNombrePerfil, exito)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Articulos" + "|" + ex.Message)
        End Try

    End Function

    Public Shared Function eliminarPerfil(ByVal cadena As String, idPerfil As Integer) As Integer
        Try
            wflFacturacion.wflPerfiles.Perfiles_EliminarPerfil(cadena, idPerfil)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Articulos" + "|" + ex.Message)
        End Try

    End Function
End Class
