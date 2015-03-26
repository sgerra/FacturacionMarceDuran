Imports dtlFacturacion
Public Class brlUsuarios
    Public Shared Function obtenerListaUsuarios(ByVal cadena As String, idSucursal As Integer) As DataSet
        Try

            obtenerListaUsuarios = dtlUsuarios.obtenerLista(cadena, idSucursal)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerRegistro(ByVal cadena As String, lngIdUsuario As Integer) As DataSet
        Try

            obtenerRegistro = dtlUsuarios.obtenerRegistro(cadena, lngIdUsuario)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function insertarRegistro(ByVal cadena As String, dstUsuario As DataSet) As Integer
        Try

            insertarRegistro = dtlUsuarios.insertarRegistro(cadena, dstUsuario)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function actualizarRegistro(ByVal cadena As String, dstUsuario As DataSet) As Integer
        Try

            actualizarRegistro = dtlUsuarios.actualizarRegistro(cadena, dstUsuario)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function eliminarRegistro(ByVal cadena As String, lngIdUsuario As Integer) As Boolean
        Try

            eliminarRegistro = dtlUsuarios.eliminarRegistro(cadena, lngIdUsuario)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerUsuarioPorNombre(ByVal cadena As String, usu_identi As String, idSucursal As Integer) As DataView
        Try

            Dim auxDatasaet As DataSet
            Dim newDataset As New DataSet

            'obtenego los articulos
            auxDatasaet = dtlUsuarios.obtenerLista(cadena, idsucursal)
            'filtro los articulos
            auxDatasaet.Tables(0).DefaultView.RowFilter = "usu_identi=" & "'" & usu_identi & "'"

            obtenerUsuarioPorNombre = auxDatasaet.Tables(0).DefaultView

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Clientes por Lista" + "|" + ex.Message)
        End Try
    End Function

End Class
