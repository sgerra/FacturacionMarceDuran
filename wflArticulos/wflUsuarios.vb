Imports brlFacturacion
Public Class wflUsuarios
    Public Shared Function wflUsuarios_obtenerListaUsuarios(ByVal cadena As String, idsucursal As Integer) As DataSet
        Try
            wflUsuarios_obtenerListaUsuarios = brlUsuarios.obtenerListaUsuarios(cadena, idsucursal)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflUsuarios_obtenerRegistro(ByVal cadena As String, lngIdUsuario As Integer) As DataSet
        Try
            wflUsuarios_obtenerRegistro = brlUsuarios.obtenerRegistro(cadena, lngIdUsuario)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflUsuarios_Perfiles_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflUsuarios_Perfiles_obtenerLista = brlPerfiles.obtenerPerfiles(cadena)
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflUsuarios_Usuarios_insertarRegistro(ByVal cadena As String, dstUsuario As DataSet) As Boolean
        Try
            Dim intResul As Integer = brlUsuarios.insertarRegistro(cadena, dstUsuario)

            If intResul <> 0 Then
                wflUsuarios_Usuarios_insertarRegistro = True
            End If

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflUsuarios_Usuarios_actualizarRegistro(ByVal cadena As String, dstUsuario As DataSet) As Boolean
        Try
            Dim intResul As Integer = brlUsuarios.actualizarRegistro(cadena, dstUsuario)

            wflUsuarios_Usuarios_actualizarRegistro = True


        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflUsuarios_Usuarios_eliminarRegistro(ByVal cadena As String, ByVal lngIdUsuario As Integer) As Boolean
        Try
            wflUsuarios_Usuarios_eliminarRegistro = brlUsuarios.eliminarRegistro(cadena, lngIdUsuario)

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflUsuarios_Usuarios_obtenerUsuarioPorNombre(ByVal cadena As String, ByVal usu_identi As String, idSucursal As Integer) As DataSet
        Try
            Dim myTable As New DataTable
            Dim myauxDt As DataView
            Dim myauxDaset As New DataSet
            myauxDt = brlUsuarios.obtenerUsuarioPorNombre(cadena, usu_identi, idsucursal)
            myTable = myauxDt.ToTable
            myauxDaset.Tables.Add(myTable)
            wflUsuarios_Usuarios_obtenerUsuarioPorNombre = myauxDaset


        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    
End Class
