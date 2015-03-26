
Public Class FrmAgregaCliente
    Dim dstCliente As New DataSet
    Dim strMensaje As String
    Dim cadena As String

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If validarDatos Then
            If MsgPregunta("¿Desea actualizar los datos del cliente?") = vbYes Then
                ' tomo los datos y los gurado en el dataset
                dstCliente.Tables(0).Rows.Add()
                dstCliente.Tables(0).Rows(0)("cli_razonsocial") = Me.txtRazonSocial.Text
                dstCliente.Tables(0).Rows(0)("cli_apynom") = Me.txtApeyNom.Text
                dstCliente.Tables(0).Rows(0)("cli_nombrefantasia") = Me.txtNomFantasia.Text
                dstCliente.Tables(0).Rows(0)("cli_email") = Me.txtEmail.Text
                dstCliente.Tables(0).Rows(0)("cli_telefono") = Me.txtTel.Text
                dstCliente.Tables(0).Rows(0)("cli_telcel") = Me.txtTelCel.Text
                dstCliente.Tables(0).Rows(0)("cli_cativa") = Me.cmbIva.SelectedValue
                dstCliente.Tables(0).Rows(0)("cli_cuit") = Me.txtCUIT.Value
                dstCliente.Tables(0).Rows(0)("cli_listaprecios") = Me.cmbListaPrecios.SelectedValue
                dstCliente.Tables(0).Rows(0)("cli_iddeposito") = Me.cmbDepositos.SelectedValue
                dstCliente.Tables(0).Rows(0)("cli_idpcia") = IIf(Not IsNothing(Me.cmbProvincia.SelectedValue), Me.cmbProvincia.SelectedValue, 15)
                dstCliente.Tables(0).Rows(0)("cli_idciudad") = IIf(Not IsNothing(Me.cmbCiudad.SelectedValue), Me.cmbCiudad.SelectedValue, 5)
                dstCliente.Tables(0).Rows(0)("cli_obs") = Me.txtObservaciones.Text

                Dim intAct = pwiClientes.wflClientes_insertarcliente(My.Settings.cadena, dstCliente, strMensaje)
                MsgBox(strMensaje, vbInformation + vbOKOnly, "Aviso al operador")
                Me.Close()
            End If
        End If
    End Sub

    Private Function ValidarDatos()
        ValidarDatos = True

        If Me.txtApeyNom.Text = "" Then
            MsgInformacion("No puede dejar el Apellido y el Nombre sin completar")
            ValidarDatos = False
            Exit Function
        End If

        If Me.cmbListaPrecios.SelectedValue = 0 Then
            MsgAtencion("No puede dejar la lista de precios sin seleccionar")
            cmbListaPrecios.Focus()
            ValidarDatos = False
            Exit Function
        End If

        If Me.cmbDepositos.SelectedValue = 0 Then
            MsgAtencion("No puede dejar el depósito al que pertenece el cliente en blanco")
            cmbDepositos.Focus()
            ValidarDatos = False
            Exit Function
        End If

    End Function
    Public Sub Abrir()
        Dim dtCondicionesIva As New DataTable
        Dim dtListasPrecios As New DataTable
        Dim dtDepositos As New DataTable
        Dim dtProvincias As DataTable
        Dim dtCiudades As DataTable

        cadena = My.Settings.cadena
        '---Cargo el combo de condiciones iva------------------------------------------------------
        dtCondicionesIva = pwiClientes.wflClientes_CondicionesIva_obtenerLista(cadena).Tables(0)
        Cargar_Combobox(dtCondicionesIva, cmbIva)
        '---------------------------------------------------------------------------------------
        '---Cargo el combo de Listas de precios------------------------------------------------------
        dtListasPrecios = pwiClientes.wflClientes_ListasPrecios_obtenerLista(cadena).Tables(0)
        Cargar_Combobox(dtListasPrecios, cmbListaPrecios)
        '---------------------------------------------------------------------------------------
        '---Cargo el combo de Depositos------------------------------------------------------
        dtDepositos = pwiClientes.wflClientes_Depositos_obtenerLista(cadena).Tables(0)
        Cargar_Combobox(dtDepositos, cmbDepositos)
        '---------------------------------------------------------------------------------------
        '---Cargo el combo de Provincias------------------------------------------------------
        dtProvincias = pwiClientes.wflClientes_Provincias_obtenerLista(cadena).Tables(0)
        Cargar_Combobox(dtProvincias, cmbProvincia)
        cmbProvincia.SelectedValue = 15
        '---------------------------------------------------------------------------------------
        '---Cargo el combo de Provincias------------------------------------------------------
        dtCiudades = pwiClientes.wflClientes_Ciudades_obtenerLista(cadena, cmbProvincia.SelectedValue).Tables(0)
        Cargar_Combobox(dtCiudades, cmbCiudad)
        '---------------------------------------------------------------------------------------
        dstCliente = pwiClientes.wflClientes_obtenerRegistro(My.Settings.cadena, -1)
        Me.ShowDialog()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgPregunta("Esta seguro de salir?") = vbYes Then
            Me.Close()
        End If
    End Sub

    Public Shared Function Cargar_Combobox(ByVal dt As DataTable, ByRef cbx As Windows.Forms.ComboBox)
        If dt.Rows.Count > 0 Then
            cbx.DataSource = dt
            cbx.ValueMember = dt.Columns(0).ToString()
            cbx.DisplayMember = dt.Columns(1).ToString()
        End If
        Return Nothing
    End Function

    Private Sub FrmAgregaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class