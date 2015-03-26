Imports wflFacturacion
Public Class pwiModuloGeneral
    Public Shared Function wflPerfiles_Formularios_obtenerRegistro(ByVal cadena As String, strNombreFormu As String) As DataSet
        Try
            wflPerfiles_Formularios_obtenerRegistro = wflPermisosPerfiles.formularios_obtenerRegistro(cadena, strNombreFormu)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflPerfiles_PermisosPorformu_obtenerPermisos(ByVal cadena As String, idFormu As Integer, idPerfil As Integer) As DataSet
        Try
            wflPerfiles_PermisosPorformu_obtenerPermisos = wflPermisosPerfiles.PermisosPorFormu_obtenerPermisos(cadena, idFormu, idPerfil)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
