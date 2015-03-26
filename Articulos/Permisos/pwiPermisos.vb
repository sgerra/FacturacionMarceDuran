Public Class pwiPermisos
    Public Shared Function ObtenerPerfiles(ByVal cadena As String) As DataSet
        Try
            ObtenerPerfiles = wflFacturacion.wflPermisosPerfiles.Perfiles_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Articulos" + "|" + ex.Message)
        End Try

    End Function

    Public Shared Function ObtenerPermisosPorFormu(ByVal cadena As String, idPerfil As Integer) As DataSet
        Try
            ObtenerPermisosPorFormu = wflFacturacion.wflPermisosPerfiles.PermisosPorFormu_obtenerLista(cadena, idPerfil)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Articulos" + "|" + ex.Message)
        End Try

    End Function
    Public Shared Function ObtenerItemMenu(ByVal cadena As String) As DataSet
        Try
            ObtenerItemMenu = wflFacturacion.wflPermisosPerfiles.ItemMenu_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Articulos" + "|" + ex.Message)
        End Try

    End Function

    Public Shared Function GuardarPermisos(ByVal cadena As String, dstPermisos As DataSet, idPerfil As Integer, exito As Boolean) As Integer
        Try
            wflFacturacion.wflPermisosPerfiles.GuardarPermisos(dstPermisos, idPerfil, exito, cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Articulos" + "|" + ex.Message)
        End Try

    End Function
End Class
