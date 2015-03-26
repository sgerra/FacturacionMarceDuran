Imports System.Data.SqlClient
Public Class dtlComprobantesVenta
    Public Shared Function obtenerRegistro(ByVal cadena As String, ByVal lngNroCom As Integer) As DataSet
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
            command.CommandText = "ComprobantesVenta_obtenerRegistro"
            command.Parameters.Add(New SqlParameter("@cvt_nrocom", lngNroCom))

            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerRegistro = ds

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Registro" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function insertarRegistro(ByVal cadena As String, ByVal dstComprobanteVenta As DataSet) As Long
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

            For Each objField In dstComprobanteVenta.Tables(0).Columns
                par = New SqlParameter(objField.ColumnName, dstComprobanteVenta.Tables(0).Rows(0).Item(objField.Ordinal)) 'objField.MaxLength)
                'par.Value = IIf(Not IsNothing(dsarticulos.Tables(0).Rows(0).Item(objField.Ordinal)), dsarticulos.Tables(0).Rows(0).Item(objField.Ordinal), System.DBNull.Value)
                ' GetDBType(objField.DataType),
                command.Parameters.Add(par)

            Next objField
            command.Connection = miConn
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "ComprobantesVenta_insertarRegistro"
            insertarRegistro = command.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "clientes_insertarRegistro" + "|" + ex.Message)
        End Try


    End Function
End Class
