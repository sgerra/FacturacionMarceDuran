Imports System.Data.SqlClient
Public Class dtlCajasDiariasDetalles

    Public Shared Function obtenerLista(ByVal cadena As String, lngIdCaja As Integer) As DataSet
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
            command.CommandText = "CajasDiariasDetalles_obtenerLista"
            command.Parameters.Add(New SqlParameter("@nroCaja", lngIdCaja))
            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerLista = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista para Grilla " + "|" + ex.Message)

        End Try
    End Function

    Public Shared Function obtenerRegistro(ByVal cadena As String, lngIdCaja As Integer) As DataSet
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
            command.CommandText = "CajasDiariasDetalles_obtenerRegistro"
            command.Parameters.Add(New SqlParameter("@nroCaja", lngIdCaja))
            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerRegistro = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista para Grilla " + "|" + ex.Message)

        End Try
    End Function

    Public Shared Function obtenerMovimientosCaja(ByVal cadena As String, strFecha As String, strHora As String, idusuario As Integer) As DataSet
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
            command.CommandText = "CajasDiariasDetalles_TraerDetalleCaja"
            command.Parameters.Add(New SqlParameter("@fecha", strFecha))
            command.Parameters.Add(New SqlParameter("@hora", strHora))
            command.Parameters.Add(New SqlParameter("@idusuario", idusuario))
            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerMovimientosCaja = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista para Grilla " + "|" + ex.Message)

        End Try
    End Function

    Public Shared Function insertarRegistro(ByVal dstDetaCaja As DataSet, ByVal cadena As String) As Long
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

            For Each objField In dstDetaCaja.Tables(0).Columns
                par = New SqlParameter(objField.ColumnName, dstDetaCaja.Tables(0).Rows(0).Item(objField.Ordinal)) 'objField.MaxLength)
                'par.Value = IIf(Not IsNothing(dsarticulos.Tables(0).Rows(0).Item(objField.Ordinal)), dsarticulos.Tables(0).Rows(0).Item(objField.Ordinal), System.DBNull.Value)
                ' GetDBType(objField.DataType),
                command.Parameters.Add(par)

            Next objField
            command.Connection = miConn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "CajaDiariaDetalle_insertarRegistro"
            insertarRegistro = command.ExecuteScalar

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Insertar detalle caja" + "|" + ex.Message)
        End Try


    End Function
End Class
