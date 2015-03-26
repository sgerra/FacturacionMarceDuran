Imports System.Data.SqlClient
Imports System.Data
Public Class dtlCompras
    Public Shared Function obtenerRegistro(ByVal lngIdCompra As Long, ByVal cadena As String) As DataSet
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
            command.CommandText = "Compras_obtenerRegistro"
            command.Parameters.Add(New SqlParameter("@lngIdCompra", lngIdCompra))

            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerRegistro = ds

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Registro" + "|" + ex.Message)
        End Try
    End Function
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
            command.CommandText = "Compras_obtenerLista"

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
            command.CommandText = "Compras_insertarRegistro"
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
            command.CommandText = "Compras_actualizarRegistro"
            actualizarRegistro = command.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Registro" + "|" + ex.Message)
        End Try


    End Function

    Public Shared Function obtenerSaldoFacturas(ByVal cadena As String, lngIdProveedor As Integer) As Double
        'Recupera un articulo de la base y lo guarda en un dataset 
        Dim miConn As SqlConnection
        Dim command As SqlCommand
        Dim ds As New DataSet
        Try
            'Instancio y defino la conexion:
            miConn = New SqlConnection()
            'El string de conexion es un atributo shared de la clase.
            miConn.ConnectionString = cadena
            miConn.Open()
            'ConfigurationManager.AppSettings.Get("connection String")

            'defino el comando, en este caso, sin parametros.
            command = New SqlCommand()
            command.Connection = miConn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "Compras_obtenerSaldoFacturasPorProveedor"
            command.Parameters.Add(New SqlParameter("@idproveedor", lngIdProveedor))
            obtenerSaldoFacturas = command.ExecuteScalar


        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Registro" + "|" + ex.Message)
        End Try
    End Function
End Class
