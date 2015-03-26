Imports System.Data.SqlClient
Public Class dtlPermisosPorFormu
    Public Shared Function obtenerLista(ByVal cadena As String, idPerfil As Integer) As DataSet
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
            command.CommandText = "PermisosPorFormulario_ObtenerLista"
            command.Parameters.Add(New SqlParameter("@ppf_idperfil", idperfil))
            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerLista = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista " + "|" + ex.Message)

        End Try
    End Function

    Public Shared Function obtenerRegistro(ByVal cadena As String, id As Integer) As DataSet
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
            command.CommandText = "PermisosPorFormulario_obtenerRegistro"
            command.Parameters.Add(New SqlParameter("@ppf_id", id))
            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerRegistro = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista " + "|" + ex.Message)

        End Try
    End Function

    Public Shared Function eliminarRegistro(ByVal cadena As String, idPerfil As Integer) As Boolean
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
            command.CommandText = "PermisosPorFormulario_eliminarRegistro"
            command.Parameters.Add(New SqlParameter("@ppf_idperfil", idPerfil))
            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            eliminarRegistro = True
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista " + "|" + ex.Message)

        End Try
    End Function

    Public Shared Function insertarRegistro(ByVal dsPermisos As DataSet, ByVal cadena As String) As Long
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

            For Each objField In dsPermisos.Tables(0).Columns
                par = New SqlParameter(objField.ColumnName, dsPermisos.Tables(0).Rows(0).Item(objField.Ordinal))
                command.Parameters.Add(par)
            Next objField

            command.Connection = miConn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "PermisosPorFormu_insertarRegistro"
            insertarRegistro = command.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Insertar Registro" + "|" + ex.Message)
        End Try


    End Function

    Public Shared Function obtenerPermisos(ByVal cadena As String, idFormu As Integer, idPerfil As Integer) As DataSet
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
            command.CommandText = "PermisosPorFormulario_obtenerPermisos"
            command.Parameters.Add(New SqlParameter("@idFormu", idFormu))
            command.Parameters.Add(New SqlParameter("@idPerfil", idPerfil))
            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn
            adapter.Fill(ds)

            obtenerPermisos = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista " + "|" + ex.Message)

        End Try
    End Function
End Class
