Imports dtlFacturacion
Public Class brlPermisosPorFormu

    Public Shared Function obtenerLista(ByVal cadena As String, idPerfil As Integer) As DataSet
        Try

            obtenerLista = dtlPermisosPorFormu.obtenerLista(cadena, idperfil)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerRegistro(ByVal cadena As String, id As Integer) As DataSet
        Try

            obtenerRegistro = dtlPermisosPorFormu.obtenerRegistro(cadena, id)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function eliminarRegistro(ByVal cadena As String, idPerfil As Integer) As Boolean
        Try

            eliminarRegistro = dtlPermisosPorFormu.eliminarRegistro(cadena, idPerfil)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function insertarRegistro(ByVal cadena As String, ppf_idformu As Integer, _
                                            ppf_idperfil As Integer, ppf_permisos As String) As Integer
        Try

            Dim dtPermi As New DataSet
            dtPermi = brlPermisosPorFormu.obtenerRegistro(cadena, -1)
            dtPermi.Tables(0).Rows.Add()

            dtPermi.Tables(0).Rows(0)("ppf_id") = -1
            dtPermi.Tables(0).Rows(0)("ppf_idformu") = ppf_idformu
            dtPermi.Tables(0).Rows(0)("ppf_idperfil") = ppf_idperfil
            dtPermi.Tables(0).Rows(0)("ppf_permisos") = ppf_permisos

            insertarRegistro = dtlPermisosPorFormu.insertarRegistro(dtPermi, cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerPermisos(ByVal cadena As String, idFormu As Integer, idPerfil As Integer) As DataSet
        Try

            obtenerPermisos = dtlPermisosPorFormu.obtenerPermisos(cadena, idFormu, idPerfil)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
