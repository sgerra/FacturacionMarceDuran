
Public Class FormBuscarArtFactu
    Dim dstArticulos As New DataSet
    Dim idLista As Integer
    Private Sub FormBuscarArtFactu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Abrir(idlistaSeleccionada As Integer)

        dstArticulos = pwiFacturacion.wflEmisionFactura_ObtenerListaArticulos(My.Settings.cadena, idlistaSeleccionada)
        idLista = idlistaSeleccionada
        If dstArticulos.Tables(0).Rows.Count > 0 Then
            CargarGrillaArticulos()
        End If
        Me.btnCodBar.Checked = False
        Me.txtCodbar.Visible = False
        Me.txtdescri.Visible = True
        Me.btnDescri.Checked = True
        ShowDialog()
    End Sub
    Private Sub CargarGrillaArticulos()
        Dim lngNroError As Long

        Try
            lngNroError = 0
            Dim i As Integer

            i = 1
            If Not dstArticulos Is Nothing Then
                For Each row In dstArticulos.Tables(0).Rows
                    GrillaArticulos.Rows.Add(row("codart"), row("desc"), row("cod"), row("lpd_precioVta"))
                Next
            End If

        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try


    End Sub

    Private Sub txtdescri_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescri.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

    Private Sub txtdescri_TextChanged(sender As Object, e As EventArgs) Handles txtdescri.TextChanged
        For i As Integer = 0 To Me.GrillaArticulos.Rows.Count - 2
            'For x As Integer = 0 To Me.GrillaArticulos.ColumnCount - 1
            If Me.GrillaArticulos.Rows(i).Cells(1).Value.ToString.Contains(Me.txtdescri.Text) Then
                Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(1)
                Exit Sub
            End If
            'Next x
        Next i
        ''If Filtro(txtdescri.Text).Rows.Count > 0 Then
        ''    GrillaArticulos.DataSource = Filtro(txtdescri.Text)
        ''End If
    End Sub

    'Private Function Filtro(txtbuscar As String) As DataTable
    '    Dim dt As New DataTable
    '    Dim str As String = "SELECT codart, [desc],cod,lpd_precioVta FROM ARTICULOS,Listaprecios_det WHERE codart=lpd_art_codart AND lpd_lpr_id=" & idLista & " AND [desc] like '%" & txtbuscar & "%'"
    '    Dim da As New OleDb.OleDbDataAdapter(Str, My.Settings.cadena)
    '    da.Fill(dt)
    '    Return dt
    'End Function

    Private Sub btncontinua_Click(sender As Object, e As EventArgs) Handles btncontinua.Click
        Dim strabuscar As String


        If txtdescri.Visible = True Then
            strabuscar = (txtdescri.Text).ToUpper
            For i As Integer = GrillaArticulos.CurrentRow.Index + 1 To Me.GrillaArticulos.Rows.Count - 2
                If Me.GrillaArticulos.Rows(i).Cells(1).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(1)
                    Exit Sub
                End If

            Next i

        Else
            strabuscar = (txtCodbar.Text).ToUpper
            For i As Integer = GrillaArticulos.CurrentRow.Index + 1 To Me.GrillaArticulos.Rows.Count - 2
                If Me.GrillaArticulos.Rows(i).Cells(2).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(2)
                    Exit Sub
                End If

            Next i

        End If



       
    End Sub

    Private Sub btnCodBar_CheckedChanged(sender As Object, e As EventArgs) Handles btnCodBar.CheckedChanged
        If btnCodBar.Checked = False Then
            Me.btnCodBar.Checked = False
            Me.txtCodbar.Visible = False
            Me.txtdescri.Visible = True
            Me.btnDescri.Checked = True
        Else
            Me.btnCodBar.Checked = True
            Me.txtCodbar.Visible = True
            Me.txtdescri.Visible = False
            Me.btnDescri.Checked = False
        End If
    End Sub

    Private Sub btnDescri_CheckedChanged(sender As Object, e As EventArgs) Handles btnDescri.CheckedChanged
        If btnDescri.Checked = True Then
            Me.btnCodBar.Checked = False
            Me.txtCodbar.Visible = False
            Me.txtdescri.Visible = True
            Me.btnDescri.Checked = True
        Else
            Me.btnCodBar.Checked = True
            Me.txtCodbar.Visible = True
            Me.txtdescri.Visible = False
            Me.btnDescri.Checked = False
            
        End If
    End Sub

    Private Sub txtCodbar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodbar.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper
    End Sub

    Private Sub txtCodbar_TextChanged(sender As Object, e As EventArgs) Handles txtCodbar.TextChanged
        For i As Integer = 0 To Me.GrillaArticulos.Rows.Count - 2
            'For x As Integer = 0 To Me.GrillaArticulos.ColumnCount - 1
            If Me.GrillaArticulos.Rows(i).Cells(2).Value.ToString.Contains(Me.txtCodbar.Text) Then
                Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(2)
                Exit Sub
            End If
            'Next x
        Next i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strabuscar As String


        If txtdescri.Visible = True Then
            strabuscar = (txtdescri.Text).ToUpper
            For i As Integer = GrillaArticulos.CurrentRow.Index - 1 To 0 Step -1
                If Me.GrillaArticulos.Rows(i).Cells(1).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(1)
                    Exit Sub
                End If

            Next i

        Else
            strabuscar = (txtCodbar.Text).ToUpper
            For i As Integer = GrillaArticulos.CurrentRow.Index - 1 To 0
                If Me.GrillaArticulos.Rows(i).Cells(2).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(2)
                    Exit Sub
                End If

            Next i

        End If

    End Sub

    
    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click

        If GrillaArticulos.CurrentCell.Selected = True Then
            CodartBuscado = GrillaArticulos.Item(0, GrillaArticulos.CurrentCell.RowIndex).Value
            CodigoBarrasBuscado = GrillaArticulos.Item(2, GrillaArticulos.CurrentCell.RowIndex).Value
            Me.Close()
        End If
    End Sub
End Class