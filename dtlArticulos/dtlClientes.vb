Imports System.Data.SqlClient
Public Class dtlClientes

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
            'ConfigurationManager.AppSettings.Get("connection String")

            'defino el comando, en este caso, sin parametros.
            command = New SqlCommand()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "Clientes_ObtenerLista"

            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerLista = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista " + "|" + ex.Message)

        End Try
    End Function
    Public Shared Function insertarRegistro(ByVal cadena As String, ByVal dstClientes As DataSet) As Long
        'Recupera un articulo de la base y lo guarda en un dataset 
        Dim miConn As SqlConnection
        Dim command As New SqlCommand
        Dim objField As DataColumn
        Dim par As SqlParameter
        Try
            miConn = New SqlConnection()
            miConn.ConnectionString = cadena
            miConn.Open()
            ' Hacer recorrido de la coleccion de parametros y ejecutar el SP

            For Each objField In dstClientes.Tables(0).Columns
                par = New SqlParameter(objField.ColumnName, dstClientes.Tables(0).Rows(0).Item(objField.Ordinal)) 'objField.MaxLength)
                'par.Value = IIf(Not IsNothing(dsarticulos.Tables(0).Rows(0).Item(objField.Ordinal)), dsarticulos.Tables(0).Rows(0).Item(objField.Ordinal), System.DBNull.Value)
                ' GetDBType(objField.DataType),
                command.Parameters.Add(par)

            Next objField
            command.Connection = miConn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "Clientes_insertarRegistro"
            insertarRegistro = command.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "clientes_insertarRegistro" + "|" + ex.Message)
        End Try


    End Function
    Public Shared Function GetDBType(ByVal theType As System.Type) As SqlDbType
        Dim param As SqlParameter
        Dim tc As System.ComponentModel.TypeConverter

        param = New SqlParameter()
        tc = System.ComponentModel.TypeDescriptor.GetConverter(param.DbType)
        If (tc.CanConvertFrom(theType)) Then
            param.DbType = tc.ConvertFrom(theType.Name)
        Else

            'Forzado
            param.DbType = tc.ConvertFrom(theType.Name)
        End If

        GetDBType = param.SqlDbType

    End Function
    Public Shared Function actualizarRegistro(ByVal cadena As String, ByVal dstClientes As DataSet) As Long
        'Recupera un articulo de la base y lo guarda en un dataset 
        Dim miConn As SqlConnection
        Dim command As New SqlCommand
        Dim objField As DataColumn
        Dim par As SqlParameter
        Try
            miConn = New SqlConnection()
            miConn.ConnectionString = cadena
            miConn.Open()
            ' Hacer recorrido de la coleccion de parametros y ejecutar el SP

            For Each objField In dstClientes.Tables(0).Columns
                par = New SqlParameter(objField.ColumnName, dstClientes.Tables(0).Rows(0).Item(objField.Ordinal))
                command.Parameters.Add(par)
            Next objField

            command.Connection = miConn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "Clientes_actualizarRegistro"
            actualizarRegistro = command.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Clientes_Actualizar Registro" + "|" + ex.Message)
        End Try


    End Function

    Public Shared Function obtenerRegistro(ByVal cadena As String, ByVal lngIdCli As Long) As DataSet
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
            command.CommandText = "Clientes_obtenerRegistro"
            command.Parameters.Add(New SqlParameter("@idcliente", lngIdCli))

            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerRegistro = ds

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Clientes_ObtenerRegistro" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function EliminarRegistro(ByVal cadena As String, cli_idcliente As Integer) As Boolean
        'Recupera un articulo de la base y lo guarda en un dataset 
        Dim miConn As SqlConnection
        Dim command As SqlCommand
        Dim ds As New DataSet
        Try
            miConn = New SqlConnection()
            miConn.ConnectionString = cadena
            miConn.Open()

            'defino el comando, en este caso, sin parametros.
            command = New SqlCommand()
            command.Connection = miConn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "Clientes_EliminarRegistro"
            command.Parameters.Add(New SqlParameter("@cli_idcliente", cli_idcliente))
            command.ExecuteScalar()
            EliminarRegistro = True

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista " + "|" + ex.Message)

        End Try
    End Function

    Public Shared Function obtenerDetalle(ByVal cadena As String, ByVal lngIdCli As Long) As DataSet
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
            command.CommandText = "Clientes_obtenerDetalle"
            command.Parameters.Add(New SqlParameter("@idcliente", lngIdCli))

            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerDetalle = ds

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Clientes_ObtenerRegistro" + "|" + ex.Message)
        End Try
    End Function
End Class
