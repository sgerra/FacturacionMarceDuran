Imports wflFacturacion
Public Class pwiUsuarios
    Public Shared Function wflUsuarios_obtenerListaUsuarios(ByVal cadena As String, idsucursal As Integer) As DataSet
        Try
            wflUsuarios_obtenerListaUsuarios = wflUsuarios.wflUsuarios_obtenerListaUsuarios(cadena, idSucursal)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflUsuarios_obtenerRegistro(ByVal cadena As String, lngIdUsuario As Integer) As DataSet
        Try
            wflUsuarios_obtenerRegistro = wflUsuarios.wflUsuarios_obtenerRegistro(cadena, lngIdUsuario)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflUsuarios_Perfiles_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflUsuarios_Perfiles_obtenerLista = wflUsuarios.wflUsuarios_Perfiles_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflUsuarios_Usuarios_insertarRegistro(ByVal cadena As String, dstUsuario As DataSet) As Boolean
        Try
            wflUsuarios_Usuarios_insertarRegistro = wflUsuarios.wflUsuarios_Usuarios_insertarRegistro(cadena, dstusuario)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "insertar registro" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflUsuarios_Usuarios_eliminarRegistro(ByVal cadena As String, lngIdUsuario As Integer) As Boolean
        Try
            wflUsuarios_Usuarios_eliminarRegistro = wflUsuarios.wflUsuarios_Usuarios_eliminarRegistro(cadena, lngIdUsuario)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "insertar registro" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflUsuarios_Usuarios_obtenerUsuarioPorNombre(ByVal cadena As String, usu_identi As String, idsucursal As Integer) As DataSet
        Try
            wflUsuarios_Usuarios_obtenerUsuarioPorNombre = wflUsuarios.wflUsuarios_Usuarios_obtenerUsuarioPorNombre(cadena, usu_identi, idsucursal)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "insertar registro" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflUsuarios_Usuarios_actualizarRegistro(ByVal cadena As String, dstUsuario As DataSet) As Boolean
        Try
            wflUsuarios_Usuarios_actualizarRegistro = wflUsuarios.wflUsuarios_Usuarios_actualizarRegistro(cadena, dstUsuario)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "insertar registro" + "|" + ex.Message)
        End Try
    End Function
End Class
