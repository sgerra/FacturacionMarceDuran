
Module ModuloGeneral
    Public PorcIva As Double = 21
    Public idUsuario As Double '=4
    Public NomUsuario As String '= "Administrador"
    Public idPerfilUsuario As Integer
    Public idsociedad As Integer = 1
    Public dblcantidad As Double
    Public TotalPcompra As Double

    Public Vuelto As Double
    Public Paga As Double
    Public AceptaPago As Boolean
    Public Descuento As Double
    Public TotalDto As Double
    Public MontoDesc As Double
    Public IdFormaPago As Integer
    Public Origen As String
    Public CodartBuscado As Integer
    Public CodigoBarrasBuscado As String
    Public CambioClave As Boolean
    Public strPermi As String
    Public Alta As Boolean
    Public Baja As Boolean
    Public Modi As Boolean
    Public Consu As Boolean



    Public Sub CalcularPrecios(ByRef precio_costo As Double, ByRef PorcIva As Double, ByRef MontoIva As Double, _
                            ByRef porcDesc As Double, ByRef MontoDesc As Double, ByRef porcPercep As Double, ByRef MontoPercep As Double, _
                            ByRef preciosubtotal As Double, ByRef porcUtil As Double, ByRef MontoUtil As Double, ByRef precioVta As Double)

        Dim PrecioAux As Double

        If precio_costo <> 0 Then
            '----------------Monto de IVA
            MontoIva = FormatNumber(((precio_costo) * CDbl(PorcIva)) / 100, 2)
            '---------------- Monto Descuento
            MontoDesc = FormatNumber((precio_costo + MontoIva) * (porcDesc / 100), 2)
            '----------------Precio auxiliar: Precio de costo + iva - descuento-------
            PrecioAux = (precio_costo + MontoIva - MontoDesc)

            '---------------------Hallo la percepcion--------------------
            MontoPercep = FormatNumber(PrecioAux * (porcPercep / 100), 2)

            '---------------Encuentro el subtotal
            preciosubtotal = PrecioAux + MontoPercep

            '------------Le aplico la utilidad

            MontoUtil = FormatNumber(preciosubtotal * (porcUtil / 100), 2)

            '------------------------------------------
            precioVta = preciosubtotal + MontoUtil

            '---------------------------------------------------------------------------

        End If

    End Sub

    Public Function MsgAtencion(strMensaje As String) As MsgBoxStyle
        MsgAtencion = MsgBox(strMensaje, vbCritical + vbOKOnly, "Aviso al operador")
    End Function

    Public Function MsgInformacion(strMensaje As String) As MsgBoxStyle
        MsgInformacion = MsgBox(strMensaje, vbInformation + vbOKOnly, "Aviso al operador")
    End Function

    Public Function MsgPregunta(strMensaje As String) As MsgBoxStyle
        MsgPregunta = MsgBox(strMensaje, vbQuestion + vbYesNoCancel, "Aviso al operador")
    End Function
    Public Function Cargar_Combobox(ByVal dt As DataTable, ByRef cbx As Windows.Forms.ComboBox)
        If dt.Rows.Count > 0 Then
            cbx.DataSource = dt
            cbx.ValueMember = dt.Columns(0).ToString()
            cbx.DisplayMember = dt.Columns(1).ToString()
        End If
        Return Nothing
    End Function
    Public Function ConvertirPrecio(PrecioAux As String) As Double
        Dim decimales As Double
        Dim ParteEntera As Double

        decimales = Val(Mid(PrecioAux, Len(PrecioAux) - 1, Len(PrecioAux)))
        ParteEntera = Val(Mid(PrecioAux, 1, 3))

        decimales = decimales / 100

        ConvertirPrecio = ParteEntera + decimales

    End Function
    Public Function encript(pass As String) As String
        Dim temp As String
        Dim temp1 As String
        Dim pos As Long
        Dim leng As Long
        Dim tim As Object
        Dim i As Long
        Dim Key As Long

        leng = Len(pass)
        tim = Mid(TimeOfDay.ToString, 1, 8)
        tim = Mid(tim, 1, Len(tim) - 3)
        tim = Mid(tim, Len(tim) - 1, 2) * Int(Rnd() * 100)
        For i = 1 To Len(CStr(tim))
            pos = pos + CInt(Mid(CStr(tim), i, 1))
        Next
        While pos > Len(pass)
            pos = pos Mod 10 + Int(Rnd() * 10)
            If pos = 0 Then
                pos = Len(pass) + 1
            End If
        End While
        If pos <= 2 Then
            pos = 3
        End If
        Key = Int((255 - 150 + 1) * Rnd() + 150)
        For i = 1 To Len(pass)
            If Asc(Mid(pass, i, 1)) > Key Then
                temp = temp & Chr(CInt(Asc(Mid(pass, i, 1))) - Key)
            ElseIf Asc(Mid(pass, i, 1)) < Key Then
                temp = temp & Chr(Key - CInt(Asc(Mid(pass, i, 1))))
            Else
                temp = temp & Chr(Asc(Mid(pass, i, 1)))
            End If
        Next
        temp1 = Mid(temp, 1, pos) & Chr(Key)
        temp1 = temp1 & Mid(temp, pos + 1, Len(temp))
        temp = Chr(pos + 150) & temp1
        encript = temp
    End Function


    Public Function Decript(pass As String) As String


        Dim pos As Long
        Dim Key As Long
        Dim temp As String
        Dim i As Long
        Dim temp1 As String = ""

        pos = Int(Asc(Mid(pass, 1, 1))) - 150
        Key = Asc(Mid(pass, pos + 2, 1))
        temp = Mid(pass, 1, pos + 1)
        pass = temp & Mid(pass, pos + 3, Len(pass))
        pass = Mid(pass, 2, Len(pass))
        For i = 1 To Len(pass)
            If Asc(Mid(pass, i, 1)) <> Key Then
                temp1 = temp1 & Chr(Key - CInt(Asc(Mid(pass, i, 1))))
            Else
                temp1 = temp1 & Chr(Asc(Mid(pass, i, 1)))
            End If
        Next
        Decript = temp1
    End Function


    Public Function Permisos(nombreformu As String, idperfilProc As Integer) As Boolean
        Dim IdFormu As Long
        Dim dstPermisos As New DataSet
        Permisos = False

        IdFormu = BuscarIdFormu(nombreformu)

        dstPermisos = pwiModuloGeneral.wflPerfiles_PermisosPorformu_obtenerPermisos(My.Settings.cadena, IdFormu, idperfilProc)


        If dstPermisos.Tables(0).Rows.Count > 0 Then
            Permisos = True
            strPermi = dstPermisos.Tables(0).Rows(0)("ppf_permisos")
        End If



    End Function
    Public Function BuscarIdFormu(nombreformu As String) As Long
        Dim dstFormu As New DataSet

        BuscarIdFormu = Nothing
        dstFormu = pwiModuloGeneral.wflPerfiles_Formularios_obtenerRegistro(My.Settings.cadena, nombreformu)

        If dstFormu.Tables(0).Rows.Count > 0 Then
            BuscarIdFormu = dstFormu.Tables(0).Rows(0)("frm_id")
        End If

    End Function

    Public Sub VerCadenaPermiso(permiso As String)
        Dim i As Long
        Dim letra As String

        Alta = False
        Baja = False
        Modi = False
        Consu = False
        For i = 1 To Len(permiso)

            letra = Mid(permiso, i, 1)

            If letra = "A" Then
                Alta = True
            End If

            If letra = "B" Then
                Baja = True
            End If

            If letra = "M" Then
                Modi = True
            End If

            If letra = "C" Then
                Consu = True
            End If
        Next i
        If Len(permiso) = 0 Then
            Consu = False
            Modi = False
            Alta = False
            Baja = False
        End If
    End Sub

    
End Module
