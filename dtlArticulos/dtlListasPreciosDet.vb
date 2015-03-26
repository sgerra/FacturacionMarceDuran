Imports System.Data.SqlClient
Public Class dtlListasPreciosDet
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
            'defino el comando, en este caso, sin parametros.
            command = New SqlCommand()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "ListasPreciosDet_obtenerLista"
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

    Public Shared Function obtenerRegistro(ByVal cadena As String, lpr_id_lista As Integer, lngcodart As Integer) As DataSet
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
            command.CommandText = "ListasPreciosDet_obtenerRegistro"
            command.Parameters.Add("@codart", SqlDbType.Int).Value = lngcodart
            command.Parameters.Add("@lpd_lpr_id", SqlDbType.Int).Value = lpr_id_lista
            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn
            adapter.Fill(ds)
            obtenerRegistro = ds

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Registro" + "|" + ex.Message)
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
            command.CommandText = "ListasPreciosDet_insertarRegistro"
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
            command.CommandText = "ListasPreciosDet_actualizarRegistro"
            actualizarRegistro = command.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Insertar Registro" + "|" + ex.Message)
        End Try

    End Function

    Public Shared Function EliminarRegistro(ByVal cadena As String, codart As Integer, idlista As Integer) As Boolean
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
            command.CommandText = "ListasPreciosDet_EliminarRegistro"
            command.Parameters.Add(New SqlParameter("@idlista", idlista))
            command.Parameters.Add(New SqlParameter("@codart", codart))
            command.ExecuteScalar()
            EliminarRegistro = True

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista " + "|" + ex.Message)

        End Try
    End Function


    Public Shared Function actualizarPrecios(ByVal cadena As String, ByVal lngCodart As Integer, dblprecio As Double) As Long
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


            command.Connection = miConn
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.Add(New SqlParameter("@codart", lngCodart))
            command.Parameters.Add(New SqlParameter("@preciocosto", dblprecio))
            command.CommandText = "precios_ActualizaciondePreciosPorArticulo"
            actualizarPrecios = command.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Insertar Registro" + "|" + ex.Message)
        End Try

    End Function

    Public Shared Function obtenerListaNovedades(ByVal cadena As String, idlista As Integer) As DataSet
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
            command.CommandText = "ListasPreciosDet_obtenerListaNovedades"
            command.Parameters.Add(New SqlParameter("@idlista", idlista))
            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerListaNovedades = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "obtener Lista " + "|" + ex.Message)

        End Try
    End Function
End Class
