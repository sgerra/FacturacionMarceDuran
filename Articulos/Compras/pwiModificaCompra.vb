Imports wflFacturacion
Public Class pwiModificaCompra

    Public Sub wflCompras_obtenerCompra(ByVal cadena As String, lngIdCompra As Integer, ByRef dsCompra As DataSet, ByRef dsCompraDetalle As DataSet)
        Try


            dsCompra = wflCompras.Compras_obtenerRegistro(cadena, lngIdCompra)
            dsCompraDetalle = wflCompras.ComprasDetalles_obtenerLista(cadena, lngIdCompra)


        Catch ex As Exception
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Sub
    Public Shared Function wflCompras_actualizarRegistro(ByVal cadena As String, ByVal idCompra As Integer, data As DataGridView, idformaPago As Integer, idtipoF As Integer, _
                                                      idestado As Integer, idproveedor As Integer, strMensaje As String, _
                                                      strNroFactura As String, dtFechaCompra As Date, strObservaciones As String, _
                                                      dblPbase As Double, dblIva As Double, dblImpInt As Double, _
                                                      dblPercepIva As Double, dblPercepIB As Double, dblDto As Double, dblTotal As Double) As Boolean
        Try

            Dim oCompras As New DataSet
            '-----------Armo el dataset para la tabla de compras (datos de la cabecera y los totales)
            oCompras = wflCompras.Compras_obtenerRegistro(cadena, idCompra)
            If oCompras.Tables(0).Rows.Count > 0 Then
                oCompras.Tables(0).Rows(0).Item("NroFactura") = strNroFactura
                oCompras.Tables(0).Rows(0).Item("fecha") = dtFechaCompra
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
                oCompras.Tables(0).Rows(0).Item("saldo") = dblTotal
                oCompras.Tables(0).Rows(0).Item("pagada") = 0
            End If
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


            wflCompras.Compras_actualizarCompra(cadena, oCompras, oComprasDetalles, strMensaje)
            wflCompras_actualizarRegistro = True


        Catch ex As Exception
            wflCompras_actualizarRegistro = False
            Throw New Exception("Error en WFL" + "Obtener Lista" + "|" + ex.Message)
        End Try
    End Function
End Class
