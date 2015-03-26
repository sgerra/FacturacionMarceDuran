Imports brlFacturacion
Imports System.Transactions
Public Class wflCompras


    Public Shared Function tiposfactura_obtenerLista(ByVal cadena As String) As DataSet
        Try
            tiposfactura_obtenerLista = brlTFactura.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function FormasPagoProv_obtenerLista(ByVal cadena As String) As DataSet
        Try
            FormasPagoProv_obtenerLista = brlTFomaPagoProv.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function TposEstadosFactura_obtenerLista(ByVal cadena As String) As DataSet
        Try
            TposEstadosFactura_obtenerLista = brlTposEstadosFacturas.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Proveedores_obtenerLista(ByVal cadena As String) As DataSet
        Try
            Proveedores_obtenerLista = brlProveedores.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    'Public Shared Function Articulos_obtenerPorductosPorProveedor(ByVal cadena As String, idproveedor As Integer) As DataView
    '    Try
    '        Articulos_obtenerPorductosPorProveedor = brlArticulos.obtenerProductosPorProveedor(cadena, idproveedor)

    '    Catch ex As Exception
    '        Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
    '    End Try
    'End Function

    Public Shared Function Articulos_obtenerProductosPorId(ByVal cadena As String, codart As Long) As DataSet
        Try
            Articulos_obtenerProductosPorId = brlArticulos.obtenerArticulo(codart, cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Articulos_obtenerProductosPorCodigoBarras(ByVal cadena As String, codart As String) As DataSet
        Try
            Articulos_obtenerProductosPorCodigoBarras = brlArticulos.obtenerArticuloPorcodigoBarras(codart, cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Compras_obtenerRegistro(ByVal cadena As String, lngIdCompra As Integer) As DataSet
        Try
            Compras_obtenerRegistro = brlCompras.obtenerRegistro(lngIdCompra, cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    'Public Shared Function Compras_insertarRegistro(ByVal cadena As String, dsCompras As DataSet) As Integer
    '    Try
    '        brlCompras.insertarRegistro(dsCompras, cadena)

    '    Catch ex As Exception
    '        Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
    '    End Try
    'End Function

    Public Shared Function ComprasDetalles_obtenerRegistro(ByVal cadena As String, lngIdCompra As Integer) As DataSet
        Try
            ComprasDetalles_obtenerRegistro = brlComprasDetalles.obtenerRegistro(lngIdCompra, cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function ComprasDetalles_obtenerLista(ByVal cadena As String, lngIdCompra As Integer) As DataSet
        Try
            ComprasDetalles_obtenerLista = brlComprasDetalles.obtenerLista(cadena, lngIdCompra)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function

    Public Shared Sub Compras_GuardarCompra(ByVal cadena As String, Cabecera As DataSet, detalle As DataSet, ByRef mensaje As String, ByRef idCompra As Integer)
        Try




            '--Guardo la cabecera de la compra -----------------------
            idCompra = brlCompras.insertarRegistro(Cabecera, cadena)
            '---------Guardo el detalle de las compras-----------

            For Each row As DataRow In detalle.Tables(0).Rows

                brlComprasDetalles.insertarRegistro(idCompra, row.Item("codart"), row.Item("descri"), row.Item("cantidad"), _
                                                    row.Item("idunidad"), row.Item("precio"), row.Item("porciva"), _
                                                    row.Item("montoiva"), row.Item("porcutil"), row.Item("montoutil"), _
                                                    row.Item("porcdto"), row.Item("montodto"), row.Item("punitfinal"), _
                                                    row.Item("total"), row.Item("porcpercep"), row.Item("montopercep"), cadena)

                If row.Item("actualizar") = True Then
                    'actualziar precios! asi en la facturacion ya factura con precio nuevo!
                    brlArticulos.ActualizarPrecioPorArticulo(row.Item("codart"), row.Item("precio"), cadena)
                End If

            Next


            mensaje = "El pedido se guardo con exito"



        Catch ex As Exception
            mensaje = "Error"
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)

        End Try
    End Sub
    Public Shared Sub Compras_actualizarCompra(ByVal cadena As String, Cabecera As DataSet, detalle As DataSet, ByRef mensaje As String)
        Try


            '--Guardo la cabecera de la compra -----------------------
            brlCompras.actualizarRegistro(Cabecera, cadena)
            '-Elimino el detalle y vuelvo a insertarlo-----------------

            brlComprasDetalles.eliminarDetalleporIdCompra(Cabecera.Tables(0).Rows(0)("idcompra"), cadena)

            Dim idcompra As Integer = Cabecera.Tables(0).Rows(0)("idcompra")
            '---------Guardo el detalle de las compras----------------

            For Each row As DataRow In detalle.Tables(0).Rows

                brlComprasDetalles.insertarRegistro(idcompra, row.Item("codart"), row.Item("descri"), row.Item("cantidad"), _
                                                    row.Item("idunidad"), row.Item("precio"), row.Item("porciva"), _
                                                    row.Item("montoiva"), row.Item("porcutil"), row.Item("montoutil"), _
                                                    row.Item("porcdto"), row.Item("montodto"), row.Item("punitfinal"), _
                                                    row.Item("total"), row.Item("porcpercep"), row.Item("montopercep"), cadena)

            Next


            mensaje = "El pedido se guardo con exito"



        Catch ex As Exception
            mensaje = "Error"
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)

        End Try
    End Sub



    Public Shared Function Compras_obtenerLista(ByVal cadena As String) As DataView
        Try
            Dim ds As New DataSet
            Dim idestado As Integer = 2
            ds = brlCompras.obtenerLista(cadena)

            ds.Tables(0).DefaultView.RowFilter = "idestado='" & idestado & "'"

            Compras_obtenerLista = ds.Tables(0).DefaultView

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
    Public Shared Function Compras_obtenerUltimaCompra(ByVal cadena As String, idproveedor As Integer) As DataSet
        Try
            Dim myTable As New DataTable
            Dim myauxDt As DataSet
            Dim myauxDaset As New DataSet
            myauxDt = brlCompras.obtenerLista(cadena)
            myauxDt.Tables(0).DefaultView.RowFilter = "idproveedor=" & idproveedor
            myauxDt.Tables(0).DefaultView.Sort = "idcompra" & " DESC"
            Dim dv As DataView = myauxDt.Tables(0).DefaultView
            If dv.Count > 0 Then
                Dim idcompra As Integer = dv.Item(0)("idcompra")
                dv.RowFilter = "idcompra=" & idcompra
                myauxDaset.Tables.Add(dv.ToTable)

                Dim dt As New DataSet

                dt = brlComprasDetalles.obtenerLista(cadena, idcompra)

                Compras_obtenerUltimaCompra = dt
            Else
                Compras_obtenerUltimaCompra = Nothing
            End If

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Ultima Compra " + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Compras_obtenerArticulosPorProveedor(ByVal cadena As String, idproveedor As Integer) As DataSet
        Try
            Dim myTable As New DataTable
            Dim myauxDt As DataSet
            Dim myauxDaset As New DataSet
            myauxDt = brlArticulos.obtenerDetalle(cadena)
            myauxDt.Tables(0).DefaultView.RowFilter = "idproveedor=" & idproveedor
            Dim dv As DataView = myauxDt.Tables(0).DefaultView
            myTable = dv.ToTable
            myauxDaset.Tables.Add(myTable)
            Compras_obtenerArticulosPorProveedor = myauxDaset

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Ultima Compra " + "|" + ex.Message)
        End Try
    End Function

    Public Shared Function Compras_obtenerDepositos(ByVal cadena As String) As DataSet

        Try

            Compras_obtenerDepositos = brlDepositos.obtenerLista(cadena)

        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Ultima Compra " + "|" + ex.Message)
        End Try
    End Function
End Class
