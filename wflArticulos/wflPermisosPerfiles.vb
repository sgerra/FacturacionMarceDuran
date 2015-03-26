Imports brlFacturacion
Public Class wflPermisosPerfiles
    Public Shared Function Perfiles_obtenerLista(ByVal cadena As String) As DataSet
        Try
            Perfiles_obtenerLista = brlPerfiles.obtenerPerfiles(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function PermisosPorFormu_obtenerLista(ByVal cadena As String, idPerfil As Integer) As DataSet
        Try
            PermisosPorFormu_obtenerLista = brlPermisosPorFormu.obtenerLista(cadena, idPerfil)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function ItemMenu_obtenerLista(ByVal cadena As String) As DataSet
        Try
            ItemMenu_obtenerLista = brlItemMenu.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Sub GuardarPermisos(dtPermi As DataSet, idperfil As Integer, exito As Boolean, cadena As String)

       
        Dim i As Integer

        brlPermisosPorFormu.eliminarRegistro(cadena, idperfil)

        '------Actualizo pagos a proveeedores detalles -------------------
        For Each dtrow As DataRow In dtPermi.Tables(0).Rows
            i = brlPermisosPorFormu.insertarRegistro(cadena, dtrow("ppf_idformu"), dtrow("ppf_idperfil"), dtrow("ppf_permisos"))
        Next
        exito = True


    End Sub

    Public Shared Function formularios_obtenerRegistro(ByVal cadena As String, strNombreformu As String) As DataSet
        Try
            formularios_obtenerRegistro = brlFormularios.obtenerRegistro(cadena, strNombreformu)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function PermisosPorFormu_obtenerPermisos(ByVal cadena As String, idFormu As Integer, idPerfil As Integer) As DataSet
        Try
            PermisosPorFormu_obtenerPermisos = brlPermisosPorFormu.obtenerPermisos(cadena, idFormu, idPerfil)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function


End Class
