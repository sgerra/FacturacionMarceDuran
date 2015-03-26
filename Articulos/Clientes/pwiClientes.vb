Imports wflFacturacion
Public Class pwiClientes
    Public Shared Function wflClientes_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflClientes_obtenerLista = wflClientes.wflClientes_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflClientes_obtenerRegistro(ByVal cadena As String, lngIdCliente As Integer) As DataSet
        Try
            wflClientes_obtenerRegistro = wflClientes.wflClientes_obtenerRegistro(cadena, lngIdCliente)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflClientes_actualizarRegistro(ByVal cadena As String, dtcliente As DataSet, ByRef strmensaje As String) As Integer
        Try
            wflClientes_actualizarRegistro = wflClientes.wflClientes_actualizarRegistro(cadena, dtcliente, strmensaje)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflClientes_insertarcliente(ByVal cadena As String, dtcliente As DataSet, ByRef strmensaje As String) As Integer
        Try
            wflClientes_insertarcliente = wflClientes.wflClientes_insertarCliente(cadena, dtcliente, strmensaje)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflClientes_eliminarcliente(ByVal cadena As String, cli_idcliente As Integer, ByRef strmensaje As String) As Boolean
        Try
            wflClientes_eliminarcliente = wflClientes.wflClientes_eliminarCliente(cadena, cli_idcliente, strmensaje)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflClientes_CondicionesIva_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflClientes_CondicionesIva_obtenerLista = wflClientes.wflClientes_obtenerCondicionesIva(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflClientes_ListasPrecios_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflClientes_ListasPrecios_obtenerLista = wflClientes.wflClientes_obtenerListasPrecios(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflClientes_Depositos_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflClientes_Depositos_obtenerLista = wflClientes.wflClientes_obtenerDepositos(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflClientes_Provincias_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflClientes_Provincias_obtenerLista = wflClientes.wflClientes_obtenerListaProvincias(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflClientes_Ciudades_obtenerLista(ByVal cadena As String, lngIdProvincias As Integer) As DataSet
        Try
            wflClientes_Ciudades_obtenerLista = wflClientes.wflClientes_obtenerListaCiudades(cadena, lngIdProvincias)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
