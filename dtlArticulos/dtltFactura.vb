Imports System.Data.SqlClient
Imports System.Data

Public Class dtltFactura
    Public Shared Function obtenerLista(ByVal cadena As String) As DataSet
        'Recupera un articulo de la base y lo guarda en un dataset 
        Dim miConn As SqlConnection
        Dim command As SqlCommand
        Dim adapter As SqlDataAdapter
        Dim ds As New DataSet
        Try
            'Instancio y defino la conexion:
            miConn = New SqlConnection()
            'El string de conexion es un atributo shared de la clase.
            miConn.ConnectionString = cadena
            'defino el comando, en este caso, sin parametros.
            command = New SqlCommand()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "t_factura_ObtenerLista"

            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            ObtenerLista = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista " + "|" + ex.Message)

        End Try
    End Function

    Public Shared Function obtenerRegistro(ByVal strCampo As String, ByVal cadena As String) As DataSet
        'Recupera un articulo de la base y lo guarda en un dataset 
        Dim miConn As SqlConnection
        Dim command As SqlCommand
        Dim adapter As SqlDataAdapter
        Dim ds As New DataSet
        Try
            'Instancio y defino la conexion:
            miConn = New SqlConnection()
            'El string de conexion es un atributo shared de la clase.
            miConn.ConnectionString = cadena
            'ConfigurationManager.AppSettings.Get("connection String")

            'defino el comando, en este caso, sin parametros.
            command = New SqlCommand()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "tfactura_obtenerRegistro"
            command.Parameters.Add(New SqlParameter("@codigo", strCampo))

            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerRegistro = ds

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Registro" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function actualizarRegistro(ByVal strCampo As String, ByVal cadena As String) As Long
        'Recupera un articulo de la base y lo guarda en un dataset 
        Dim miConn As SqlConnection
        Dim command As New SqlCommand
        Dim objField As DataColumn
        Dim par As SqlParameter
        Try
            'Instancio y defino la conexion:
            miConn = New SqlConnection()
            'El string de conexion es un atributo shared de la clase.
            miConn.ConnectionString = cadena
            'ConfigurationManager.AppSettings.Get("connection String")
            miConn.Open()
            'defino el comando, en este caso, sin parametros.
            command = New SqlCommand()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "tFactura_actualizarRegistro"
            command.Parameters.Add(New SqlParameter("@codigo", strCampo))
            command.Connection = miConn
            command.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Registro" + "|" + ex.Message)
        End Try


    End Function

   
End Class
