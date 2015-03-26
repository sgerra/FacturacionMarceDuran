Imports System.Data.SqlClient
Public Class dtlUsuarios
    Public Shared Function obtenerLista(ByVal cadena As String, idSucursal As Integer) As DataSet
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
            command.Parameters.Add(New SqlParameter("@idsucursal", idSucursal))
            command.CommandText = "Usuarios_obtenerLista"
            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerLista = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista para Grilla " + "|" + ex.Message)

        End Try
    End Function

    Public Shared Function obtenerRegistro(ByVal cadena As String, lngIdUsuario As Integer) As DataSet
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
            command.CommandText = "Usuarios_obtenerRegistro"
            command.Parameters.Add(New SqlParameter("@usu_id", lngIdUsuario))
            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerRegistro = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista para Grilla " + "|" + ex.Message)

        End Try
    End Function
    Public Shared Function insertarRegistro(ByVal cadena As String, ByVal dstUsuario As DataSet) As Long
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

            For Each objField In dstUsuario.Tables(0).Columns
                par = New SqlParameter(objField.ColumnName, dstUsuario.Tables(0).Rows(0).Item(objField.Ordinal))
                command.Parameters.Add(par)
            Next objField

            command.Connection = miConn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "Usuarios_insertarRegistro"
            insertarRegistro = command.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "USuarios_InsertarRegistro" + "|" + ex.Message)
        End Try


    End Function

    Public Shared Function actualizarRegistro(ByVal cadena As String, ByVal dstUsuario As DataSet) As Long
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

            For Each objField In dstUsuario.Tables(0).Columns
                par = New SqlParameter(objField.ColumnName, dstUsuario.Tables(0).Rows(0).Item(objField.Ordinal))
                command.Parameters.Add(par)
            Next objField

            command.Connection = miConn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "Usuarios_actualizarRegistro"
            actualizarRegistro = command.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "USuarios_InsertarRegistro" + "|" + ex.Message)
        End Try


    End Function
    Public Shared Function eliminarRegistro(ByVal cadena As String, lngIdUsuario As Integer) As Boolean
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
            command.CommandText = "Usuarios_EliminarRegistro"
            command.Parameters.Add(New SqlParameter("@usu_id", lngIdUsuario))
            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            eliminarRegistro = True
        Catch ex As Exception
            eliminarRegistro = False
            Throw New Exception("Error en DTL" + "Obtener Lista para Grilla " + "|" + ex.Message)
        End Try
    End Function
End Class
