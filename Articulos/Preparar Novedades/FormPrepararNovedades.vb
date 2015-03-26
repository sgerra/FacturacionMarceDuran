Imports System.IO
Public Class FormPrepararNovedades
    Dim dstArticulos As New DataSet
    Dim dstUsuarios As New DataSet
    Dim dstClientes As New DataSet
    Dim dstFormasPago As New DataSet
    Dim dstListasPreciosDet As New DataSet
    Dim objStreamWriter As StreamWriter

    Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        Dim dblPrecioCosto As String
        Dim dblPrecioVenta As String
        Dim dblPrecioGranel As String
        Dim dblUnidadesGranel As String
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        dstArticulos = pwiArmarNoveedades.Articulos_ArmarNovedades(My.Settings.cadena)
        AbrirArchivo(Application.StartupPath & ("\Articulos.txt"))
        For Each dr As DataRow In dstArticulos.Tables(0).Rows
            dblPrecioCosto = Replace(dr("PrecioCosto"), ".", ",")
            dblPrecioVenta = Replace(dr("PrecioVenta"), ".", ",")
            dblPrecioGranel = Replace(dr("CostoGranel"), ".", ",")
            dblUnidadesGranel = Replace(dr("unidadesGranel"), ".", ",")

            EscribirLinea(dr("codart") & ";" & dr("desc") & ";" & dr("cod") & ";" & dblPrecioCosto & ";" & dblPrecioVenta & ";" & dr("idlista") & ";" & dr("unidad") & ";" & dblPrecioGranel & ";" & dblUnidadesGranel)

        Next
        Cursor = System.Windows.Forms.Cursors.Default
        CerrarArchivo()
        MsgInformacion("El proceso ha finalizado con éxito")
    End Sub

    Private Sub EscribirLinea(linea As String)
        objStreamWriter.WriteLine(linea)
    End Sub

    Private Sub AbrirArchivo(ruta As String)
        objStreamWriter = New StreamWriter(ruta, False, System.Text.Encoding.Unicode)
    End Sub
    Private Sub CerrarArchivo()
        objStreamWriter.Close()
    End Sub

    
    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click

        Cursor = System.Windows.Forms.Cursors.WaitCursor
        dstUsuarios = pwiArmarNoveedades.Usuarios_ArmarNovedades(My.Settings.cadena, My.Settings.sucursal)
        AbrirArchivo(Application.StartupPath & ("\Usuarios.txt"))
        For Each dr As DataRow In dstUsuarios.Tables(0).Rows

            EscribirLinea(dr("usu_id") & ";" & dr("usu_identi") & ";" & dr("usu_clave") & ";" & dr("usu_prf_id"))

        Next
        CerrarArchivo()
        Cursor = System.Windows.Forms.Cursors.Default
        MsgInformacion("El proceso ha finalizado con éxito")
    End Sub

    Private Sub btnclientes_Click(sender As Object, e As EventArgs) Handles btnclientes.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        dstClientes = pwiArmarNoveedades.Clientes_ArmarNovedades(My.Settings.cadena)
        AbrirArchivo(Application.StartupPath & ("\Clientes.txt"))
        For Each dr As DataRow In dstClientes.Tables(0).Rows

            EscribirLinea(dr("cli_idcliente") & ";" & dr("cli_nombrefantasia") & ";" & dr("cli_listaprecios") & ";" & Trim(dr("lpr_descripcion")) & ";" & dr("cli_iddeposito"))

        Next
        CerrarArchivo()
        Cursor = System.Windows.Forms.Cursors.Default
        MsgInformacion("El proceso ha finalizado con éxito")
    End Sub

    Private Sub btnformaPago_Click(sender As Object, e As EventArgs) Handles btnformaPago.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        dstFormasPago = pwiArmarNoveedades.FormasPago_ArmarNovedades(My.Settings.cadena)
        AbrirArchivo(Application.StartupPath & ("\FormasPago.txt"))
        For Each dr As DataRow In dstFormasPago.Tables(0).Rows

            EscribirLinea(dr("cod") & ";" & dr("descri"))

        Next
        CerrarArchivo()
        Cursor = System.Windows.Forms.Cursors.Default
        MsgInformacion("El proceso ha finalizado con éxito")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cursor = System.Windows.Forms.Cursors.WaitCursor
        dstListasPreciosDet = pwiArmarNoveedades.wflPrepararNovedades_obtenerListaPrecios(My.Settings.cadenaWEB, 1)
        AbrirArchivo(Application.StartupPath & ("\ListasPreciosDet.txt"))
        For Each dr As DataRow In dstListasPreciosDet.Tables(0).Rows

            EscribirLinea(dr("lpd_art_codart") & ";" & dr("lpd_precioVta"))

        Next
        CerrarArchivo()
        Cursor = System.Windows.Forms.Cursors.Default
        MsgInformacion("El proceso ha finalizado con éxito")
    End Sub
End Class