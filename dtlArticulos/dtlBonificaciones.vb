﻿Imports System.Data.SqlClient
Public Class dtlBonificaciones
    Public Shared Function obtenerRegistro(ByVal lngIdBon As Long, ByVal cadena As String) As DataSet
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
            command.CommandText = "Bonificaciones_obtenerRegistro"
            command.Parameters.Add(New SqlParameter("@bon_idbon", lngIdBon))

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
            command.CommandText = "Bonificaciones_ObtenerLista"
            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerLista = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista " + "|" + ex.Message)

        End Try
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
            command.CommandText = "Bonificaciones_insertarRegistro"
            insertarRegistro = command.ExecuteScalar
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Insertar Registro" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function EliminarRegistro(ByVal cadena As String, idprov As Integer, nroPago As Integer) As Boolean
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
            command.CommandText = "Bonificaciones_EliminarRegistro"
            command.Parameters.Add(New SqlParameter("@bon_nroprove", idprov))
            command.Parameters.Add(New SqlParameter("@bon_nropago", nroPago))
            command.ExecuteScalar()
            EliminarRegistro = True

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista " + "|" + ex.Message)

        End Try
    End Function

    Public Shared Function obtenerSaldoBoni(ByVal cadena As String, lngIdProveedor As Integer) As Double
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
            command.CommandText = "Bonificaciones_obtenerSaldoBoniPorProveedor"
            command.Parameters.Add(New SqlParameter("@idproveedor", lngIdProveedor))
            obtenerSaldoBoni = command.ExecuteScalar


        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Registro" + "|" + ex.Message)
        End Try
    End Function
End Class
