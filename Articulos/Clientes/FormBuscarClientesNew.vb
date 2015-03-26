Public Class FormBuscarClientesNew
    Dim cadena As String
    Dim dt As New DataSet
    Private Sub FormBuscarClientesNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        cadena = My.Settings.cadena

        dt = pwiClientes.wflClientes_obtenerLista(cadena)

        CargarGrillaArticulos()

    End Sub
    Private Sub CargarGrillaArticulos()

        Dim lngNroError As Long

        Try
            lngNroError = 0
            GrillaClientes.Rows.Clear()

            For Each row In dt.Tables(0).Rows
                GrillaClientes.Rows.Add(row("cli_idcliente"), row("cli_razonsocial"))
            Next

        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        For i As Integer = 0 To Me.GrillaClientes.Rows.Count - 2
            'For x As Integer = 0 To Me.GrillaArticulos.ColumnCount - 1
            If Me.GrillaClientes.Rows(i).Cells(0).Value.ToString.Contains(Me.txtCodigo.Text) Then
                Me.GrillaClientes.CurrentCell = Me.GrillaClientes.Rows(i).Cells(0)
                Exit Sub
            End If
            'Next x
        Next i
    End Sub


    Private Sub txtdescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescripcion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged
        For i As Integer = 0 To Me.GrillaClientes.Rows.Count - 2
            If Me.GrillaClientes.Rows(i).Cells(1).Value.ToString.Contains(Me.txtdescripcion.Text) Then
                Me.GrillaClientes.CurrentCell = Me.GrillaClientes.Rows(i).Cells(0)
                Exit Sub
            End If
            'Next x
        Next i
    End Sub

    Private Sub btncontinua_Click(sender As Object, e As EventArgs) Handles btncontinua.Click
        Dim strabuscar As String


        If txtCodigo.Text <> "" Then
            strabuscar = (txtCodigo.Text).ToUpper
            For i As Integer = GrillaClientes.CurrentRow.Index + 1 To Me.GrillaClientes.Rows.Count - 2
                If Me.GrillaClientes.Rows(i).Cells(0).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaClientes.CurrentCell = Me.GrillaClientes.Rows(i).Cells(0)
                    Exit Sub
                End If

            Next i

        Else
            strabuscar = (txtdescripcion.Text).ToUpper
            For i As Integer = GrillaClientes.CurrentRow.Index + 1 To Me.GrillaClientes.Rows.Count - 2
                If Me.GrillaClientes.Rows(i).Cells(1).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaClientes.CurrentCell = Me.GrillaClientes.Rows(i).Cells(0)
                    Exit Sub
                End If

            Next i

        End If

    End Sub


    Private Sub GrillaArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaClientes.CellContentClick

    End Sub

    Private Sub cmdagregar_Click(sender As Object, e As EventArgs) Handles cmdagregar.Click
        Dim frm As New FrmAgregaCliente
        frm.Abrir()
        FormBuscarClientesNew_Load(sender, e)
    End Sub

    Private Sub cmdmodificar_Click(sender As Object, e As EventArgs) Handles cmdmodificar.Click
        Dim codigo As String
        Dim FormModifica As New FormModificaCliente


        If GrillaClientes.CurrentCell.Selected = True Then
            codigo = GrillaClientes.Item(0, GrillaClientes.CurrentCell.RowIndex).Value
            FormModifica.Abrir(codigo)
            FormBuscarClientesNew_Load(sender, e)
        Else
            MsgBox("Seleccione una fila válida", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Aviso")
        End If

    End Sub

    Private Sub cmdeliminar_Click(sender As Object, e As EventArgs) Handles cmdeliminar.Click
        Dim codigo As String
        Dim strMensaje As String = ""

        If GrillaClientes.CurrentCell.Selected = True Then
            codigo = GrillaClientes.Item(0, GrillaClientes.CurrentCell.RowIndex).Value
            If MsgPregunta("¿Está seguro de eliminar el cliente?") = vbYes Then

                pwiClientes.wflClientes_eliminarcliente(My.Settings.cadena, codigo, strMensaje)
                MsgInformacion("El cliente se eliminó con éxito")
                FormBuscarClientesNew_Load(sender, e)
            End If
        Else
            MsgBox("Seleccione una fila válida", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Aviso")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strabuscar As String


        If txtCodigo.Text <> "" Then
            strabuscar = (txtCodigo.Text).ToUpper
            For i As Integer = GrillaClientes.CurrentRow.Index - 1 To 0 Step -1
                If Me.GrillaClientes.Rows(i).Cells(0).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaClientes.CurrentCell = Me.GrillaClientes.Rows(i).Cells(0)
                    Exit Sub
                End If

            Next i

        Else
            strabuscar = (txtdescripcion.Text).ToUpper
            For i As Integer = GrillaClientes.CurrentRow.Index - 1 To 0
                If Me.GrillaClientes.Rows(i).Cells(1).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaClientes.CurrentCell = Me.GrillaClientes.Rows(i).Cells(1)
                    Exit Sub
                End If

            Next i

        End If

    End Sub

    Private Sub cmdcerrar_Click(sender As Object, e As EventArgs) Handles cmdcerrar.Click
        Me.Close()
    End Sub
End Class