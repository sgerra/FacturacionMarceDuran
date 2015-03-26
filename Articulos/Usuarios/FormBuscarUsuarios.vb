Public Class FormBuscarUsuarios
    Dim dstUsuarios As New DataSet
    Private Sub CargarGrillaUsuarios()
        Dim lngNroError As Long

        Try
            lngNroError = 0
            GrillaUsuarios.Rows.Clear()
            If Not dstUsuarios Is Nothing Then
                For Each row In dstUsuarios.Tables(0).Rows
                    GrillaUsuarios.Rows.Add(row("usu_id"), row("usu_identi"))
                Next
            End If

        Catch ex As Exception
            Throw New Exception("Error " + "Cargar grilla" + "|" + ex.Message)

        End Try


    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btncontinua_Click(sender As Object, e As EventArgs) Handles btncontinua.Click
        For i As Integer = GrillaUsuarios.CurrentRow.Index + 1 To Me.GrillaUsuarios.Rows.Count - 2
            'For x As Integer = 0 To Me.GrillaArticulos.ColumnCount - 1
            If Me.GrillaUsuarios.Rows(i).Cells(1).Value.ToString.Contains(Me.txtUsuarios.Text) Then
                Me.GrillaUsuarios.CurrentCell = Me.GrillaUsuarios.Rows(i).Cells(1)
                Exit Sub
            End If
            'Next x
        Next i
    End Sub

    Private Sub txtUsuarios_TextChanged(sender As Object, e As EventArgs) Handles txtUsuarios.TextChanged
        For i As Integer = 0 To Me.GrillaUsuarios.Rows.Count - 2
            'For x As Integer = 0 To Me.GrillaArticulos.ColumnCount - 1
            If Me.GrillaUsuarios.Rows(i).Cells(1).Value.ToString.Contains(Me.txtUsuarios.Text) Then
                Me.GrillaUsuarios.CurrentCell = Me.GrillaUsuarios.Rows(i).Cells(1)
                Exit Sub
            End If
            'Next x
        Next i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        For i As Integer = GrillaUsuarios.CurrentRow.Index - 1 To 0 Step -1
            If Me.GrillaUsuarios.Rows(i).Cells(1).Value.ToString.Contains(Me.txtUsuarios.Text) Then
                Me.GrillaUsuarios.CurrentCell = Me.GrillaUsuarios.Rows(i).Cells(1)
                Exit Sub
            End If
        Next i
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frm As New FormAltaUsuarios
        frm.AbrirFormulario()
        FormBuscarUsuarios_Load(sender, e)

    End Sub

    Private Sub FormBuscarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dstUsuarios = pwiUsuarios.wflUsuarios_obtenerListaUsuarios(My.Settings.cadena, My.Settings.sucursal)

            If dstUsuarios.Tables(0).Rows.Count > 0 Then
                CargarGrillaUsuarios()
            End If

            Me.GrillaUsuarios.ClearSelection()
            Me.GrillaUsuarios.CurrentCell = Me.GrillaUsuarios.Rows(Me.GrillaUsuarios.RowCount - 2).Cells(0)

        Catch ex As Exception
            MsgBox("Se ha producido un error en la aplicación" + "  " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub btnCerar_Click(sender As Object, e As EventArgs) Handles btnCerar.Click
        Dim codigo As String
        Dim FormModifica As New FormModificaUsuario


        If GrillaUsuarios.CurrentCell.Selected = True Then
            codigo = GrillaUsuarios.Item(0, GrillaUsuarios.CurrentCell.RowIndex).Value
            FormModifica.AbrirFormulario(codigo)
            FormBuscarUsuarios_Load(sender, e)
        Else
            MsgBox("Seleccione una fila válida", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim codigo As String


        If GrillaUsuarios.CurrentCell.Selected = True Then
            If MsgPregunta("¿Esta seguro de eliminar el usuario?") = vbYes Then
                'TODO ver si tiene transacciones realizadas
                codigo = GrillaUsuarios.Item(0, GrillaUsuarios.CurrentCell.RowIndex).Value
                If pwiUsuarios.wflUsuarios_Usuarios_eliminarRegistro(My.Settings.cadena, codigo) Then
                    MsgInformacion("El usuario se eliminó con éxito")
                    FormBuscarUsuarios_Load(sender, e)
                End If

            End If
        Else
            MsgBox("Seleccione una fila válida", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Aviso")
        End If
    End Sub

End Class