Imports System.Data.SqlClient
Public Class dtlComprasDetalles
    Public Shared Function obtenerRegistro(ByVal lngIdDet As Long, ByVal cadena As String) As DataSet
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
            command.CommandText = "ComprasDetalles_obtenerRegistro"
            command.Parameters.Add(New SqlParameter("@lngIdDet", lngIdDet))

            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerRegistro = ds

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Registro" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function obtenerLista(ByVal cadena As String, idCompra As Integer) As DataSet
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
            command.CommandText = "ComprasDetalles_obtenerLista"
            command.Parameters.Add(New SqlParameter("@idcompra", idCompra))
            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerLista = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista " + "|" + ex.Message)

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
    Public Shared Function insertarRegistro(ByVal dsCompras As DataSet, ByVal cadena As String) As Long
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

            For Each objField In dsCompras.Tables(0).Columns
                par = New SqlParameter(objField.ColumnName, dsCompras.Tables(0).Rows(0).Item(objField.Ordinal))
                command.Parameters.Add(par)
            Next objField

            command.Connection = miConn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "ComprasDetalles_insertarRegistro"
            insertarRegistro = command.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Insertar Registro" + "|" + ex.Message)
        End Try


    End Function

    Public Shared Function actualizarRegistro(ByVal dsCompras As DataSet, ByVal cadena As String) As Long
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

            For Each objField In dsCompras.Tables(0).Columns
                par = New SqlParameter(objField.ColumnName, dsCompras.Tables(0).Rows(0).Item(objField.Ordinal))
                command.Parameters.Add(par)
            Next objField

            command.Connection = miConn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "ComprasDetalles_actualizarRegistro"
            actualizarRegistro = command.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Registro" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function eliminarRegistrosPorIdCompra(ByVal idcompra As Integer, ByVal cadena As String) As Long
        'Recupera un articulo de la base y lo guarda en un dataset 
        Dim miConn As SqlConnection
        Dim command As New SqlCommand

        Try
            miConn = New SqlConnection()
            miConn.ConnectionString = cadena
            miConn.Open()
            ' Hacer recorrido de la coleccion de parametros y ejecutar el SP

            command.Connection = miConn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "ComprasDetalles_eliminarRegistroPorIdcompra"
            command.Parameters.Add(New SqlParameter("@idcompra", idcompra))
            eliminarRegistrosPorIdCompra = command.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Insertar Registro" + "|" + ex.Message)
        End Try


    End Function
End Class
