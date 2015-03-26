Imports wflFacturacion
Public Class pwiCompras

    Public Shared Function wflCompras_tposFactura_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflCompras_tposFactura_obtenerLista = wflCompras.tiposfactura_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflCompras_FormasPagoProv_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflCompras_FormasPagoProv_obtenerLista = wflCompras.FormasPagoProv_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflCompras_TposEstadosFactura_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflCompras_TposEstadosFactura_obtenerLista = wflCompras.TposEstadosFactura_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflCompras_Proveedores_obtenerLista(ByVal cadena As String) As DataSet
        Try
            wflCompras_Proveedores_obtenerLista = wflCompras.Proveedores_obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflCompras_Articulos_obtenerPorductosPorProveedor(ByVal cadena As String, idproveedor As Integer) As DataView
        Try
            'wflCompras_Articulos_obtenerPorductosPorProveedor = wflCompras.Compras_obtenerArticulosPorProveedor(cadena, idproveedor)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflCompras_Articulos_obtenerProductosPorId(ByVal cadena As String, codart As Long) As DataSet
        Try
            wflCompras_Articulos_obtenerProductosPorId = wflCompras.Articulos_obtenerProductosPorId(cadena, codart)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflCompras_Articulos_obtenerProductosPorCodigoBarras(ByVal cadena As String, codart As String) As DataSet
        Try
            wflCompras_Articulos_obtenerProductosPorCodigoBarras = wflCompras.Articulos_obtenerProductosPorCodigoBarras(cadena, codart)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflCompras_insertarRegistro(ByVal cadena As String, data As DataGridView, idformaPago As Integer, idtipoF As Integer, _
                                                       idestado As Integer, idproveedor As Integer, strMensaje As String, _
                                                       strNroFactura As String, dtFechaCompra As Date, strObservaciones As String, _
                                                       dblPbase As Double, dblIva As Double, dblImpInt As Double, _
                                                       dblPercepIva As Double, dblPercepIB As Double, dblDto As Double, dblTotal As Double, _
                                                       dtFecEntrega As Date, ByRef idcompra As Integer) As Boolean
        Try
            Dim oCompras As New DataSet
            '-----------Armo el dataset para la tabla de compras (datos de la cabecera y los totales)
            oCompras = wflCompras.Compras_obtenerRegistro(cadena, -1)
            oCompras.Tables(0).Rows.Add()
            oCompras.Tables(0).Rows(0).Item("idCompra") = -1
            oCompras.Tables(0).Rows(0).Item("NroFactura") = strNroFactura
            oCompras.Tables(0).Rows(0).Item("fecha") = dtFechaCompra
            oCompras.Tables(0).Rows(0).Item("fechaentrega") = dtFecEntrega
            oCompras.Tables(0).Rows(0).Item("idcondPago") = idformaPago
            oCompras.Tables(0).Rows(0).Item("idTipoFact") = idtipoF
            oCompras.Tables(0).Rows(0).Item("idEstado") = idestado
            oCompras.Tables(0).Rows(0).Item("idproveedor") = idproveedor
            oCompras.Tables(0).Rows(0).Item("observaciones") = strObservaciones
            oCompras.Tables(0).Rows(0).Item("PbaseTot") = dblPbase
            oCompras.Tables(0).Rows(0).Item("ivaTot") = dblIva
            oCompras.Tables(0).Rows(0).Item("ImpIntTot") = dblImpInt
            oCompras.Tables(0).Rows(0).Item("percepIvaTot") = dblPercepIva
            oCompras.Tables(0).Rows(0).Item("percepIBTot") = dblPercepIB
            oCompras.Tables(0).Rows(0).Item("descuentoTot") = dblDto
            oCompras.Tables(0).Rows(0).Item("total") = dblTotal
            oCompras.Tables(0).Rows(0).Item("pagada") = 0
            oCompras.Tables(0).Rows(0).Item("idsoc") = 1
            oCompras.Tables(0).Rows(0).Item("saldo") = dblTotal
            '------------------------------------------------------------------------------------------------
            '--------------------Armo el dataset para la tabla de compras detalles...para eso recorro la grilla
            Dim oComprasDetalles As New DataSet
            oComprasDetalles = wflCompras.ComprasDetalles_obtenerRegistro(cadena, -1)
            oComprasDetalles.Tables(0).Columns.Add("actualizar")
            Dim auxrow As DataRow
            For Each row As DataGridViewRow In data.Rows

                If Not IsNothing(row.Cells("codart").Value) Then
                    'Dim cell2 As DataGridViewComboBoxCell = TryCast(row.Cells("desc"), DataGridViewComboBoxCell)

                    auxrow = oComprasDetalles.Tables(0).NewRow
                    auxrow("iddet") = -1
                    auxrow("idCompra") = -1
                    auxrow("codart") = row.Cells("codart").Value
                    auxrow("descri") = row.Cells("desc").Value
                    auxrow("cantidad") = row.Cells("cantidad").Value
                    auxrow("idunidad") = row.Cells("uni_id").Value
                    auxrow("precio") = 0 'row.Cells("costo").Value
                    auxrow("porciva") = 0 'row.Cells("porciva").Value
                    auxrow("montoiva") = 0 'row.Cells("iva").Value
                    auxrow("porcpercep") = 0 'row.Cells("porcimpint").Value
                    auxrow("montopercep") = 0 'row.Cells("impint").Value
                    auxrow("porcdto") = 0 'row.Cells("porcdto").Value
                    auxrow("montodto") = 0 'row.Cells("dto").Value
                    auxrow("porcutil") = 0 'row.Cells("porcdto").Value
                    auxrow("montoutil") = 0 'row.Cells("dto").Value
                    auxrow("punitfinal") = row.Cells("lpd_preciovto").Value
                    auxrow("total") = row.Cells("total").Value

                    'If row.Cells("actualizar").Value = True Then
                    'auxrow("actualizar") = True
                    'Else
                    auxrow("actualizar") = False
                    'End If
                    oComprasDetalles.Tables(0).Rows.Add(auxrow)
                End If
            Next

            wflCompras.Compras_GuardarCompra(cadena, oCompras, oComprasDetalles, strMensaje, idcompra)
            wflCompras_insertarRegistro = True


        Catch ex As Exception
            wflCompras_insertarRegistro = False
            Throw New Exception("Error en PWI " + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function wflCompras_obtenerUltimacompra(ByVal cadena As String, idProveedor As Integer) As DataSet
        Try
            wflCompras_obtenerUltimacompra = wflCompras.Compras_obtenerUltimaCompra(cadena, idproveedor)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function wflComprasDetalles_obtenerRegistro(ByVal cadena As String, idDet As Integer) As DataSet
        Try
            wflComprasDetalles_obtenerRegistro = wflCompras.ComprasDetalles_obtenerRegistro(cadena, idDet)

        Catch ex As Exception
            Throw New Exception("Error en PWI" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
  
End Class
