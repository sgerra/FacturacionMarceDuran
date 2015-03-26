Imports dtlFacturacion
Public Class brlCajasDiarias

    Public Shared Function obtenerListaCajas(ByVal cadena As String, lngIdSuc As Integer) As DataSet
        Try

            obtenerListaCajas = dtlCajasDiarias.obtenerLista(cadena, lngIdSuc)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerRegistro(ByVal cadena As String, lngIdCaja As Integer) As DataSet
        Try

            obtenerRegistro = dtlCajasDiarias.obtenerRegistro(cadena, lngIdCaja)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerDetalle(ByVal cadena As String, lngIdCaja As Integer) As DataSet
        Try

            obtenerDetalle = dtlCajasDiarias.obtenerDetalle(cadena, lngIdCaja)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function ActualizarCaja(ByVal cadena As String, ByVal dstCaja As DataSet) As Integer
        Try
            dtlCajasDiarias.actualizarRegistro(cadena, dstCaja)
        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function ExisteCajaAbierta(ByVal cadena As String, ByVal idUsuario As Integer, lngIdSucursal As Integer) As Boolean
        Try


            ExisteCajaAbierta = False
            Dim dstCajas As New DataSet

            dstCajas = dtlCajasDiarias.obtenerLista(cadena, lngidSucursal)
            dstCajas.Tables(0).DefaultView.RowFilter = "caj_idusuario=" & idUsuario & "and caj_idsucursal=" & lngIdSucursal & "and caj_cerrada='N'"


            If dstCajas.Tables(0).DefaultView.Count > 0 Then
                ExisteCajaAbierta = True
            End If

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Existe Caja Abierta" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function insertarRegistro(ByVal cadena As String, dstCaja As DataSet) As Integer
        Try

            insertarRegistro = dtlCajasDiarias.insertarRegistro(cadena, dstCaja)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

End Class
