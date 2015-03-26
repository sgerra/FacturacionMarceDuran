Imports System.Data.SqlClient
Public Class dtlStockPorDeposito
    Public Shared Function obtenerLista(ByVal cadena As String, lngcodart As Integer) As DataSet
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
            command = New SqlCommand()
            'defino el comando, en este caso, sin parametros   command = New SqlCommand()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "StockPorDeposito_obtenerLista"
            command.Parameters.Add(New SqlParameter("@codart", lngcodart))
            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerLista = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "obtener Lista " + "|" + ex.Message)

        End Try
    End Function
    Public Shared Function insertarRegistro(ByVal dsListas As DataSet, ByVal cadena As String) As Long
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

            For Each objField In dsListas.Tables(0).Columns
                par = New SqlParameter(objField.ColumnName, dsListas.Tables(0).Rows(0).Item(objField.Ordinal))
                command.Parameters.Add(par)
            Next objField

            command.Connection = miConn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "StockPorDeposito_insertarRegistro"
            insertarRegistro = command.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Insertar Registro" + "|" + ex.Message)
        End Try


    End Function

    Public Shared Function actualizarRegistro(ByVal dsListas As DataSet, ByVal cadena As String) As Long
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

            For Each objField In dsListas.Tables(0).Columns
                par = New SqlParameter(objField.ColumnName, dsListas.Tables(0).Rows(0).Item(objField.Ordinal))
                command.Parameters.Add(par)
            Next objField

            command.Connection = miConn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "StockPorDeposito_actualizarRegistro"
            actualizarRegistro = command.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Insertar Registro" + "|" + ex.Message)
        End Try


    End Function

    Public Shared Function obtenerRegistro(ByVal cadena As String, lngcodart As Integer, lngIdDeposito As Integer) As DataSet
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
            command.CommandText = "StockPorDeposito_obtenerRegistro"
            command.Parameters.Add(New SqlParameter("@codart", lngcodart))
            command.Parameters.Add(New SqlParameter("@iddeposito", lngidDeposito))
            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerRegistro = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "obtener Lista " + "|" + ex.Message)

        End Try
    End Function

    Public Shared Function EliminarRegistro(ByVal cadena As String, codart As Integer, iddeposito As Integer) As Boolean
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
            command.CommandText = "StockPorDeposito_EliminarRegistro"
            command.Parameters.Add(New SqlParameter("@iddeposito", iddeposito))
            command.Parameters.Add(New SqlParameter("@codart", codart))
            command.ExecuteScalar()
            EliminarRegistro = True

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista " + "|" + ex.Message)

        End Try
    End Function

    
End Class
