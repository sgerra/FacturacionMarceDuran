Public Class FormBuscarCajas
    Dim dstCajasDiarias As New DataSet
    Private Sub FormBuscarCajas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dstCajasDiarias = pwiCajasDiarias.wflCajasDiarias_obtenerListaCajas(My.Settings.cadena, My.Settings.sucursal)

            If dstCajasDiarias.Tables(0).Rows.Count > 0 Then
                CargarGrillaCajas()
            End If
            Me.btnFecha.Checked = False
            Me.txtFecha.Visible = False
            Me.txtNroCaja.Visible = True
            Me.btnNroCaja.Checked = True
            Me.GrillaArticulos.ClearSelection()
            Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(Me.GrillaArticulos.RowCount - 2).Cells(0)

        Catch ex As Exception
            MsgBox("Se ha producido un error en la aplicación" + "  " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub
    Private Sub CargarGrillaCajas()
        Dim lngNroError As Long

        Try
            lngNroError = 0
            Dim i As Integer

            i = 1
            If Not dstCajasDiarias Is Nothing Then
                For Each row In dstCajasDiarias.Tables(0).Rows
                    GrillaArticulos.Rows.Add(row("caj_id"), row("caj_f_apertura"), row("caj_h_apertura"), row("caj_f_cierre"), row("caj_h_cierre"), row("caj_cerrada"), row("caj_saldoinicial"), row("caj_saldofinal"))
                Next
            End If

        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try


    End Sub

    Private Sub btncontinua_Click(sender As Object, e As EventArgs) Handles btncontinua.Click
        Dim strabuscar As String


        If txtFecha.Visible = True Then
            strabuscar = (txtFecha.Text).ToUpper
            For i As Integer = GrillaArticulos.CurrentRow.Index + 1 To Me.GrillaArticulos.Rows.Count - 2
                If Me.GrillaArticulos.Rows(i).Cells(0).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(0)
                    Exit Sub
                End If

            Next i

        Else
            strabuscar = (txtNroCaja.Text).ToUpper
            For i As Integer = GrillaArticulos.CurrentRow.Index + 1 To Me.GrillaArticulos.Rows.Count - 2
                If Me.GrillaArticulos.Rows(i).Cells(1).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(0)
                    Exit Sub
                End If

            Next i

        End If

    End Sub

    Private Sub txtNroCaja_TextChanged(sender As Object, e As EventArgs) Handles txtNroCaja.TextChanged
        For i As Integer = 0 To Me.GrillaArticulos.Rows.Count - 2
            'For x As Integer = 0 To Me.GrillaArticulos.ColumnCount - 1
            If Me.GrillaArticulos.Rows(i).Cells(0).Value.ToString.Contains(Me.txtNroCaja.Text) Then
                Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(0)
                Exit Sub
            End If
            'Next x
        Next i
    End Sub

    Private Sub txtFecha_TextChanged(sender As Object, e As EventArgs) Handles txtFecha.TextChanged
        For i As Integer = 0 To Me.GrillaArticulos.Rows.Count - 2
            'For x As Integer = 0 To Me.GrillaArticulos.ColumnCount - 1
            If Me.GrillaArticulos.Rows(i).Cells(1).Value.ToString.Contains(Me.txtFecha.Text) Then
                Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(1)
                Exit Sub
            End If
            'Next x
        Next i
    End Sub

    Private Sub btnNroCaja_CheckedChanged(sender As Object, e As EventArgs) Handles btnNroCaja.CheckedChanged
        If btnNroCaja.Checked = True Then
            Me.btnFecha.Checked = False
            Me.txtFecha.Visible = False
            Me.txtNroCaja.Visible = True
            Me.btnNroCaja.Checked = True
        Else
            Me.btnFecha.Checked = True
            Me.txtFecha.Visible = True
            Me.txtNroCaja.Visible = False
            Me.btnNroCaja.Checked = False

        End If
    End Sub

    Private Sub btnFecha_CheckedChanged(sender As Object, e As EventArgs) Handles btnFecha.CheckedChanged
        If btnFecha.Checked = True Then
            Me.btnFecha.Checked = True
            Me.txtFecha.Visible = True
            Me.txtNroCaja.Visible = False
            Me.btnNroCaja.Checked = False
        Else
            Me.btnFecha.Checked = False
            Me.txtFecha.Visible = False
            Me.txtNroCaja.Visible = True
            Me.btnNroCaja.Checked = True

        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCerar_Click(sender As Object, e As EventArgs) Handles btnCerar.Click
        Dim frm As New FormDetalleCajaDiaria
        If GrillaArticulos.CurrentCell.Selected = True Then
            frm.AbrirCaja(GrillaArticulos.Item(0, GrillaArticulos.CurrentCell.RowIndex).Value, GrillaArticulos.Item(1, GrillaArticulos.CurrentCell.RowIndex).Value, GrillaArticulos.Item(2, GrillaArticulos.CurrentCell.RowIndex).Value)
            FormBuscarCajas_Load(sender, e)
        End If
    End Sub

    Private Sub btnNueva_Click(sender As Object, e As EventArgs) Handles btnNueva.Click
        Dim frm As New FormAperturaCaja
        frm.ShowDialog()
        FormBuscarCajas_Load(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strabuscar As String


        If txtNroCaja.Visible = True Then
            strabuscar = (txtNroCaja.Text).ToUpper
            For i As Integer = GrillaArticulos.CurrentRow.Index - 1 To 0 Step -1
                If Me.GrillaArticulos.Rows(i).Cells(0).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(0)
                    Exit Sub
                End If

            Next i

        Else
            strabuscar = (txtFecha.Text).ToUpper
            For i As Integer = GrillaArticulos.CurrentRow.Index - 1 To 0
                If Me.GrillaArticulos.Rows(i).Cells(1).Value.ToString.Contains(strabuscar) Then
                    Me.GrillaArticulos.CurrentCell = Me.GrillaArticulos.Rows(i).Cells(1)
                    Exit Sub
                End If

            Next i

        End If

    End Sub
End Class