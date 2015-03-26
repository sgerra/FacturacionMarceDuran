Imports dtlFacturacion
Public Class brlClientes
    Public Shared Function obtenerLista(ByVal cadena As String) As DataSet
        Try

            obtenerLista = dtlClientes.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function InsertarCliente(ByVal cadena As String, ByVal dstClientes As DataSet) As Integer
        Try
            dtlClientes.insertarRegistro(cadena, dstClientes)
        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function ActualizarCliente(ByVal cadena As String, ByVal dstClientes As DataSet) As Integer
        Try
            dtlClientes.actualizarRegistro(cadena, dstClientes)
        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Actualizar Articulo" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function ExisteCliente(ByVal cadena As String, idcliente As Integer) As Boolean
        Dim ds As New DataSet
        Try
            ds = dtlClientes.obtenerRegistro(cadena, idcliente)
            If ds.Tables(0).Rows.Count > 0 Then
                ExisteCliente = True
            Else
                ExisteCliente = False
            End If
            
        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Existe Cliente" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerClientesporListaDeposito(ByVal cadena As String, idLista As Integer, iddeposito As Integer) As DataView
        Try

            Dim auxDatasaet As DataSet
            Dim newDataset As New DataSet

            'obtenego los articulos
            auxDatasaet = dtlClientes.obtenerLista(cadena)
            'filtro los articulos
            auxDatasaet.Tables(0).DefaultView.RowFilter = "cli_listaprecios=" & idLista & " cli_iddeposito=" & iddeposito

            obtenerClientesporListaDeposito = auxDatasaet.Tables(0).DefaultView

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Clientes por Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerRegistro(ByVal cadena As String, ByVal lngIdCli As Integer) As DataSet
        Try

            obtenerRegistro = dtlClientes.obtenerRegistro(cadena, lngIdCli)
        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Articulo" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function obtenerDetalle(ByVal cadena As String, ByVal lngIdCli As Integer) As DataSet
        Try

            obtenerDetalle = dtlClientes.obtenerDetalle(cadena, lngIdCli)
        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Articulo" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function eliminarRegistro(ByVal cadena As String, ByVal lngIdCli As Integer) As Boolean
        Try

            eliminarRegistro = dtlClientes.EliminarRegistro(cadena, lngIdCli)
        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Articulo" + "|" + ex.Message)
        End Try
    End Function

End Class
