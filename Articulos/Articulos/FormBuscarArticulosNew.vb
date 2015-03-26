Public Class FormBuscarArticulosNew
    Dim cadena As String
    Dim dt As New DataSet
    Private Sub FormBuscarArticulosNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GrillaArticulos.Rows.Clear()
        GrillaArticulos.Columns.Clear()

        cadena = My.Settings.cadena

        GrillaArticulos.Columns.Add("Codart", "Codigo")
        GrillaArticulos.Columns("codart").Width = 80
        GrillaArticulos.Columns("codart").Visible = True
        GrillaArticulos.Columns("codart").ReadOnly = True
        GrillaArticulos.Columns("codart").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'Descripcion
        GrillaArticulos.Columns.Add("desc", "Descripción")
        GrillaArticulos.Columns("desc").Width = 400
        GrillaArticulos.Columns("desc").Visible = True
        GrillaArticulos.Columns("desc").ReadOnly = True
        GrillaArticulos.Columns("desc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        'Codigo de barras
        GrillaArticulos.Columns.Add("codigobarras", "Codigo de barras")
        GrillaArticulos.Columns("codigobarras").Width = 150
        GrillaArticulos.Columns("codigobarras").Visible = True
        GrillaArticulos.Columns("codigobarras").ReadOnly = False
        GrillaArticulos.Columns("codigobarras").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dt = pwiFacturacion.ObtenerLista(cadena)

        CargarGrillaArticulos()

    End Sub
    Private Sub CargarGrillaArticulos()

        Dim lngNroError As Long

        Try
            lngNroError = 0
            GrillaArticulos.Rows.Clear()
            For Each row In dt.Tables(0).Rows
                GrillaArticulos.Rows.Add(row("codart"), row("desc"), row("cod"))
            Next

        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        For i As Integer = 0 To Me.GrillaArticulos.Rows.Count - 2
            'For x As Integer = 0 To Me.GrillaArticulos.ColumnCount - 1
            If Me.GrillaArticulos.Rows(i).Cells(0).Value.ToString.Contains(Me.txtCodigo.Text) Then
                Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(0)
                Exit Sub
            End If
            'Next x
        Next i
    End Sub


    Private Sub txtdescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescripcion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged
        For i As Integer = 0 To Me.GrillaArticulos.Rows.Count - 2
            If Me.GrillaArticulos.Rows(i).Cells(1).Value.ToString.Contains(Me.txtdescripcion.Text) Then
                Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(0)
                Exit Sub
            End If
            'Next x
        Next i
    End Sub

    Private Sub btncontinua_Click(sender As Object, e As EventArgs) Handles btncontinua.Click
        Dim strabuscar As String


        If txtCodigo.Text <> "" Then
            strabuscar = (txtCodigo.Text).ToUpper
            For i As Integer = GrillaArticulos.CurrentRow.Index + 1 To Me.GrillaArticulos.Rows.Count - 2
                If Me.GrillaArticulos.Rows(i).Cells(0).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(0)
                    Exit Sub
                End If

            Next i

        Else
            strabuscar = (txtdescripcion.Text).ToUpper
            For i As Integer = GrillaArticulos.CurrentRow.Index + 1 To Me.GrillaArticulos.Rows.Count - 2
                If Me.GrillaArticulos.Rows(i).Cells(1).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(0)
                    Exit Sub
                End If

            Next i

        End If

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdagregar.Click
        Dim frm As New FormArticulos
        frm.Abrirformulario(-1)
        FormBuscarArticulosNew_Load(sender, e)
    End Sub

    Private Sub cmdcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcerrar.Click
        Close()
    End Sub

    Private Sub cmdmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmodificar.Click
        Dim codigo As String
        Dim FormModifica As New FormModificarArticulos


        If GrillaArticulos.CurrentCell.Selected = True Then
            codigo = GrillaArticulos.Item(0, GrillaArticulos.CurrentCell.RowIndex).Value
            FormModifica.Abrirformulario(codigo)
            FormBuscarArticulosNew_Load(sender, e)
        Else
            MsgBox("Seleccione una fila válida", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Aviso")
        End If

    End Sub

    Private Sub cmdcerrar_Click_1(sender As Object, e As EventArgs) Handles cmdcerrar.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strabuscar As String


        If txtCodigo.Text <> "" Then
            strabuscar = (txtCodigo.Text).ToUpper
            For i As Integer = GrillaArticulos.CurrentRow.Index - 1 To 0 Step -1
                If Me.GrillaArticulos.Rows(i).Cells(0).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(0)
                    Exit Sub
                End If

            Next i

        Else
            strabuscar = (txtdescripcion.Text).ToUpper
            For i As Integer = GrillaArticulos.CurrentRow.Index - 1 To 0
                If Me.GrillaArticulos.Rows(i).Cells(1).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(1)
                    Exit Sub
                End If

            Next i

        End If

    End Sub
End Class