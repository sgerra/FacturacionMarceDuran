Imports System.Data.SqlClient
Imports System.Data


Public Class dtlArticulos


    Public Shared Function obtenerArticulo(ByVal lngIdArt As Long, ByVal cadena As String) As DataSet
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
            command.CommandText = "ObtenerArticulo"
            command.Parameters.Add(New SqlParameter("@codart", lngIdArt))

            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            ObtenerArticulo = ds

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Articulo" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function obtenerArticuloPorCodigoBarras(ByVal codigobarras As String, ByVal cadena As String) As DataSet
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
            command.CommandText = "Articulos_ObtenerArticuloPorCodigoBarras"

            ''Agrego los parametros del comando:
            'Dim sqlparam As New SqlParameter()
            'sqlparam.Value = id
            'sqlparam.Direction = ParameterDirection.Input
            'sqlparam.ParameterName = "@AfiliadoID"
            'sqlparam.DbType = DbType.Int32
            'command.Parameters.Add(sqlparam)

            command.Parameters.Add(New SqlParameter("@codigobarras", codigobarras))

            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            ObtenerArticuloPorCodigoBarras = ds

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Articulo Por Codigo Barras" + "|" + ex.Message)
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
            command.CommandText = "Articulos_ObtenerLista"

            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            ObtenerLista = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista " + "|" + ex.Message)

        End Try
    End Function
    Public Shared Function InsertarArticulo(ByVal dsarticulos As DataSet, ByVal cadena As String) As Long
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

            For Each objField In dsarticulos.Tables(0).Columns
                par = New SqlParameter(objField.ColumnName, dsarticulos.Tables(0).Rows(0).Item(objField.Ordinal)) 'objField.MaxLength)
                'par.Value = IIf(Not IsNothing(dsarticulos.Tables(0).Rows(0).Item(objField.Ordinal)), dsarticulos.Tables(0).Rows(0).Item(objField.Ordinal), System.DBNull.Value)
                ' GetDBType(objField.DataType),
                command.Parameters.Add(par)

            Next objField
            command.Connection = miConn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "Articulos_insertarRegistro"
            InsertarArticulo = command.ExecuteScalar

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Articulo" + "|" + ex.Message)
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
    Public Shared Function ObtenerListaParaGrilla(ByVal cadena As String, ByVal idlista As Integer) As DataSet
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
            command.CommandText = "Articulos_ObtenerListaParaGrilla"

            command.Parameters.Add(New SqlParameter("@idlista", idlista))


            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            ObtenerListaParaGrilla = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista para Grilla " + "|" + ex.Message)

        End Try
    End Function

    Public Shared Function actualizarPrecioPorCodigoArticulo(ByVal lngCodart As Long, ByVal dblPrecioCosto As Double, ByVal cadena As String) As DataSet
        'Recupera un articulo de la base y lo guarda en un dataset 
        Dim miConn As SqlConnection
        Dim command As SqlCommand

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
            command.CommandText = "precios_ActualizaciondePreciosPorArticulo"
            command.Parameters.Add(New SqlParameter("@codart", lngCodart))
            command.Parameters.Add(New SqlParameter("@preciocosto", dblPrecioCosto))
            command.Connection = miConn
            command.ExecuteNonQuery()


        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Registro" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function actualizarRegistro(ByVal dsArticulos As DataSet, ByVal cadena As String) As Long
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

            For Each objField In dsArticulos.Tables(0).Columns
                par = New SqlParameter(objField.ColumnName, dsArticulos.Tables(0).Rows(0).Item(objField.Ordinal))
                command.Parameters.Add(par)
            Next objField

            command.Connection = miConn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "Articulos_actualizarRegistro"
            actualizarRegistro = command.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Actualizar Registro" + "|" + ex.Message)
        End Try


    End Function

    Public Shared Function obtenerRegistro(ByVal lngIdArt As Long, ByVal cadena As String) As DataSet
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
            command.CommandText = "Articulos_obtenerRegistro"
            command.Parameters.Add(New SqlParameter("@codart", lngIdArt))

            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerRegistro = ds

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Articulo" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function obtenerArticuloFacturacion(ByVal cadena As String, ByVal idArtculo As Integer, ByVal idLista As Integer) As DataSet
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
            command.CommandText = "Articulos_obtenerArticuloFactura"

            command.Parameters.Add(New SqlParameter("@art_codart", idArtculo))
            command.Parameters.Add(New SqlParameter("@lpr_id", idLista))

            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerArticuloFacturacion = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista para Grilla " + "|" + ex.Message)

        End Try
    End Function

    Public Shared Function ObtenerDetalle(ByVal cadena As String) As DataSet
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
            command.CommandText = "Articulos_obtenerDetalle"

            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            ObtenerDetalle = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista para Grilla " + "|" + ex.Message)

        End Try
    End Function

    Public Shared Function ArmarNovedades(ByVal cadena As String) As DataSet
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
            command.CommandText = "Articulos_armarNovedades"

            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            ArmarNovedades = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista para Grilla " + "|" + ex.Message)

        End Try
    End Function

End Class




