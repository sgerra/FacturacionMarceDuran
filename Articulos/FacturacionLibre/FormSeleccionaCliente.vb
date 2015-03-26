Public Class FormSeleccionaCliente
    Dim dstClientes As New DataSet
    Dim dstClienteSele As New DataSet
    Public Sub Abrir(ByRef dstCli As DataSet)
        Try

            GrillaClientes.Rows.Clear()

            Me.txtCodigo.Text = ""
            Me.txtNombreFantasia.Text = ""

            dstClientes = pwiFacturacionLibre.wflFacturacionLibre_Clientes_obtenerLista(My.Settings.cadena)

            dstClienteSele = dstCli
            CargarGrillaClientes()
            Me.ShowDialog()
            dstCli = dstClienteSele
        Catch ex As Exception
            MsgBox("Se ha producido un error en la aplicación" + "  " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub CargarGrillaClientes()

        Dim lngNroError As Long

        Try
            lngNroError = 0
            GrillaClientes.Rows.Clear()
            For Each row In dstClientes.Tables(0).Rows
                GrillaClientes.Rows.Add(row("cli_idcliente"), row("cli_razonsocial"), row("cli_nombrefantasia"))
            Next

        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try
    End Sub

    Private Sub FrmSeleccionaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub txtNombreFantasia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreFantasia.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub


    Private Sub txtNombreFantasia_TextChanged(sender As Object, e As EventArgs) Handles txtNombreFantasia.TextChanged
        For i As Integer = 0 To Me.GrillaClientes.Rows.Count - 2
            If Me.GrillaClientes.Rows(i).Cells(2).Value.ToString.Contains(Me.txtNombreFantasia.Text) Then
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
            strabuscar = (txtNombreFantasia.Text).ToUpper
            For i As Integer = GrillaClientes.CurrentRow.Index + 1 To Me.GrillaClientes.Rows.Count - 2
                If Me.GrillaClientes.Rows(i).Cells(2).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaClientes.CurrentCell = Me.GrillaClientes.Rows(i).Cells(0)
                    Exit Sub
                End If

            Next i

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
            strabuscar = (txtNombreFantasia.Text).ToUpper
            For i As Integer = GrillaClientes.CurrentRow.Index - 1 To 0
                If Me.GrillaClientes.Rows(i).Cells(1).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaClientes.CurrentCell = Me.GrillaClientes.Rows(i).Cells(1)
                    Exit Sub
                End If

            Next i

        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click


        If GrillaClientes.SelectedRows.Count > 0 Then
            dstClienteSele = pwiFacturacionLibre.wflFacturacionLibre_Clientes_obtenerDetalle(My.Settings.cadena, GrillaClientes.CurrentRow.Cells(0).Value)
            Me.Close()
        End If


    End Sub

    Private Sub GrillaClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaClientes.CellContentClick

    End Sub

    Private Sub GrillaClientes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaClientes.CellContentDoubleClick

        dstClienteSele = pwiFacturacionLibre.wflFacturacionLibre_Clientes_obtenerDetalle(My.Settings.cadena, GrillaClientes.CurrentRow.Cells(0).Value)
        Me.Close()

    End Sub
End Class