﻿Imports System.Data.SqlClient
Public Class dtlListasPrecios
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
            'defino el comando, en este caso, sin parametros.
            command = New SqlCommand()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "ListasPrecios_obtenerLista"

            adapter = New SqlDataAdapter()
            adapter.SelectCommand = command
            adapter.SelectCommand.Connection = miConn

            adapter.Fill(ds)

            obtenerLista = ds
        Catch ex As Exception
            Throw New Exception("Error en DTL" + "obtener Lista " + "|" + ex.Message)

        End Try
    End Function
End Class
