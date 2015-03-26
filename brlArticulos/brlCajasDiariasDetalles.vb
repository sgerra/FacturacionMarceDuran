Imports dtlFacturacion
Public Class brlCajasDiariasDetalles

    Public Shared Function obtenerLista(ByVal cadena As String, lngIdCaja As Integer) As DataSet
        Try

            obtenerLista = dtlCajasDiariasDetalles.obtenerLista(cadena, lngIdCaja)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerRegistro(ByVal cadena As String, lngIdCaja As Integer) As DataSet
        Try

            obtenerRegistro = dtlCajasDiariasDetalles.obtenerRegistro(cadena, lngIdCaja)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function obtenerListaMovimientos(ByVal cadena As String, strFecha As String, strHora As String, idusuario As Integer) As DataSet
        Try

            obtenerListaMovimientos = dtlCajasDiariasDetalles.obtenerMovimientosCaja(cadena, strfecha, strhora, idusuario)

        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function


    Public Shared Function insertarRegistro(cdd_caj_id As Integer, cdd_nromov As Integer, _
                                            cdd_cvt_nrocom As Integer, cdd_cvt_totcom As Double, _
                                            cdd_descripcion As String, cdd_entrada As Integer, _
                                            cdd_salida As Integer, ByVal cadena As String) As Integer
        Try

           
            Dim dt As DataSet = dtlCajasDiariasDetalles.obtenerRegistro(cadena, -1)

            dt.Tables(0).Rows.Add()
            dt.Tables(0).Rows(0).Item("cdd_id") = -1
            dt.Tables(0).Rows(0).Item("cdd_caj_id") = cdd_caj_id
            dt.Tables(0).Rows(0).Item("cdd_cvt_nrocom") = cdd_cvt_nrocom
            dt.Tables(0).Rows(0).Item("cdd_cvt_totcom") = cdd_cvt_totcom
            dt.Tables(0).Rows(0).Item("cdd_descripcion") = cdd_descripcion
            dt.Tables(0).Rows(0).Item("cdd_entrada") = cdd_entrada
            dt.Tables(0).Rows(0).Item("cdd_salida") = cdd_salida


            insertarRegistro = dtlCajasDiariasDetalles.insertarRegistro(dt, cadena)


        Catch ex As Exception
            Throw New Exception("Error en BRL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function


End Class
