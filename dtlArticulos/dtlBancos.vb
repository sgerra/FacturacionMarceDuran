﻿Imports System.Data.SqlClient
Public Class dtlBancos
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
            command.CommandText = "Bancos_ObtenerLista"
            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerLista = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Lista " + "|" + ex.Message)

        End Try
    End Function
    Public Shared Function obtenerRegistro(ByVal lngIdBan As Long, ByVal cadena As String) As DataSet
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
            command.CommandText = "BancosGenerales_obtenerRegistro"
            command.Parameters.Add(New SqlParameter("@ban_idbanco", lngIdBan))

            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerRegistro = ds

        Catch ex As Exception
            Throw New Exception("Error en DTL" + "Obtener Registro" + "|" + ex.Message)
        End Try
    End Function
End Class
