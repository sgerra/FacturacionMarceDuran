Imports System.IO
Public Class FormobtenerNovedades
    Dim dstUsuarios As New DataSet
    Dim dstSucursales As New DataSet
    Dim strIP As String
    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub FormobtenerNovedades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dstUsuarios = pwiobtenerNovedades.SucursalesCajas_obtenerUsuarios(My.Settings.cadena, My.Settings.sucursal)
        dstUsuarios.Tables(0).Rows.Add()
        dstUsuarios.Tables(0).Rows(dstUsuarios.Tables(0).Rows.Count - 1)("usu_id") = 99
        dstUsuarios.Tables(0).Rows(dstUsuarios.Tables(0).Rows.Count - 1)("usu_identi") = "Todos"
        dstUsuarios.Tables(0).Rows(dstUsuarios.Tables(0).Rows.Count - 1)("usu_idsucursal") = My.Settings.sucursal
        Cargar_Combobox(dstUsuarios.Tables(0), cmbUsuarios)


        dstSucursales = pwiobtenerNovedades.SucursalesCajas_obtenerLista(My.Settings.cadena, My.Settings.sucursal)

        GrillaCajas.Rows.Clear()

        For Each row As DataRow In dstSucursales.Tables(0).Rows

            GrillaCajas.Rows.Add(row("nombrepc"))

        Next



    End Sub

    Private Sub btnobtener_Click(sender As Object, e As EventArgs) Handles btnobtener.Click
        'Copio el archivo a una carpeta local asi hago el resúmen
        Dim idusuario As Integer
        Dim NombreArchivo As String
        Dim i As Integer = 0



        idusuario = cmbUsuarios.SelectedValue

        For Each dt As DataRow In dstSucursales.Tables(0).Rows

            'CopiarArchivos(dt("ip"), dt("carpeta"))
            '--Obtengo el archivo desde una carpeta local. Antes deberia copiarlo 
            'NombreArchivo = Application.StartupPath & "\comprobantesVenta" & Format(Now, "yyyyMMdd") & "_" & dt("nro_caja") & ".txt"

            NombreArchivo = dt("ip") & dt("carpeta") & "ComprobanteVenta.txt"

            Dim objStreamReader As StreamReader
            Dim strLine As String

            If System.IO.File.Exists(NombreArchivo) = True Then

                objStreamReader = New StreamReader(NombreArchivo)

                Dim dblSumaToria As Double = 0
                Dim intCantidad As Integer = 0
                Do While Not objStreamReader.EndOfStream

                    strLine = objStreamReader.ReadLine
                    Dim total As String = Split(strLine, ";")(8)
                    Dim intIdusuario As String = Split(strLine, ";")(9)

                    Dim dblTotal = CDbl(total.Replace(",", "."))

                    If idusuario = intIdusuario Then
                        intCantidad = intCantidad + 1
                        dblSumaToria = dblSumaToria + dblTotal
                    End If



                Loop
                GrillaCajas.Rows(i).Cells(1).Value = FormatNumber(dblSumaToria, 2)
                GrillaCajas.Rows(i).Cells(2).Value = intCantidad
                i = i + 1
            End If
        Next

    End Sub
    Private Sub CopiarArchivos(ipPC As String, strCarpeta As String)
        Dim FileToCopy As String
        Dim NewCopy As String
        Dim NombreArchivo As String
        Dim NroCaja As Integer = 1

        NombreArchivo = "ComprobanteVenta"

        FileToCopy = ipPC & strCarpeta & NombreArchivo & ".txt"
        NewCopy = "C:\comprobantesVenta" & Format(Now, "yyyyMMdd") & "_" & NroCaja & ".txt"

        If System.IO.File.Exists(FileToCopy) = True Then

            System.IO.File.Copy(FileToCopy, NewCopy, True)
            'System.IO.File.Delete(FileToCopy)
        End If
    End Sub
End Class