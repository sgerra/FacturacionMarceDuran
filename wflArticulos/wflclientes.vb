Imports brlFacturacion
Public Class wflClientes
    Public Shared Function wflClientes_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflClientes_obtenerLista = brlClientes.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflClientes_obtenerRegistro(ByVal cadena As String, lngIdCliente As Integer) As DataSet
        Try
            wflClientes_obtenerRegistro = brlClientes.obtenerRegistro(cadena, lngIdcliente)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflClientes_actualizarRegistro(ByVal cadena As String, dstcliente As DataSet, ByRef strMensaje As String) As Integer
        Try
            wflClientes_actualizarRegistro = brlClientes.ActualizarCliente(cadena, dstcliente)
            strMensaje = "El registro se actualizó con éxito"

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflClientes_insertarCliente(ByVal cadena As String, dstcliente As DataSet, ByRef strMensaje As String) As Integer
        Try
            wflClientes_insertarCliente = brlClientes.InsertarCliente(cadena, dstcliente)
            strMensaje = "El registro se actualizó con éxito"

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflClientes_eliminarCliente(ByVal cadena As String, cli_idCliente As Integer, ByRef strMensaje As String) As Boolean
        Try
            wflClientes_eliminarCliente = brlClientes.eliminarRegistro(cadena, cli_idCliente)
            strMensaje = "El registro se actualizó con éxito"

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflClientes_obtenerCondicionesIva(ByVal cadena As String) As DataSet
        Try
            wflClientes_obtenerCondicionesIva = brlCondicionesIVA.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflClientes_obtenerListasPrecios(ByVal cadena As String) As DataSet
        Try
            wflClientes_obtenerListasPrecios = brlListasPrecios.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflClientes_obtenerDepositos(ByVal cadena As String) As DataSet
        Try
            wflClientes_obtenerDepositos = brlDepositos.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflClientes_obtenerListaProvincias(ByVal cadena As String) As DataSet
        Try
            wflClientes_obtenerListaProvincias = brlProvincias.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflClientes_obtenerListaCiudades(ByVal cadena As String, lngIdProvincia As Integer) As DataSet
        Try
            wflClientes_obtenerListaCiudades = brlCiudades.obtenerLista(cadena, lngIdProvincia)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

   

End Class
