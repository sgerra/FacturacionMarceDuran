Public Class FormBuscarClientes
    Dim ds As DataSet
    Private dt As DataTable
    Dim iniciando As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cadena As String
        Try
            iniciando = True
            cadena = My.Settings.cadena
            txtdescri.Text = ""
            ds = pwiClientes.wflClientes_obtenerLista(cadena)
            GrillaClientes.DataSource = ds.Tables(0) 'pwiClientes.wflClientes_obtenerLista(cadena).Tables(0)
            dt = ds.Tables(0) 'pltFacturacion.ObtenerLista(cadena).Tables(0)
            'codigo de articulo 
            GrillaClientes.Columns("cli_idcliente").HeaderText = "Nro.Cliente"
            GrillaClientes.Columns("cli_idcliente").Width = 0
            GrillaClientes.Columns("cli_idcliente").Visible = False
            GrillaClientes.Columns("cli_idcliente").ReadOnly = True
            GrillaClientes.Columns("cli_idcliente").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            'Descripcion
            GrillaClientes.Columns("cli_razonsocial").HeaderText = "Razón Social"
            GrillaClientes.Columns("cli_razonsocial").Width = 100
            GrillaClientes.Columns("cli_razonsocial").Visible = True
            GrillaClientes.Columns("cli_razonsocial").ReadOnly = True
            GrillaClientes.Columns("cli_razonsocial").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            
            iniciando = False
        Catch ex As Exception
            MsgBox("Se ha producido un error en la aplicación" + "  " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub



    Private Sub txtdescri_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescri.TextChanged

        If Not iniciando Then
            ' Buscar en el DataTable usando el método Select
            ' que es como un filtro WHERE en una cadena de selección.

            ' El resultado se devuelve como un array de tipo DataRow
            Dim filas() As DataRow

            ' Si solo quieres mostrar los que empiecen por lo escrito.
            ' Al escribir "s" se buscarán los que empiecen por esa letra.
            filas = dt.Select("[cli_razonsocial] LIKE '" & txtdescri.Text & "%'")

            ' Borrar los elementos anteriores
            Me.lstClientes.Items.Clear()

            ' Si hay datos, mostrar los apellidos
            If filas.Length > 0 Then

                ' Recorrer cada fila y mostrar los apellidos
                For Each dr As DataRow In filas

                    Me.lstClientes.Items.Add( _
                                dr("cli_idcliente").ToString & ", " & _
                                dr("cli_razonsocial").ToString)

                Next
            End If
        End If

    End Sub

    Private Sub lstclientes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstClientes.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            Me.txtdescri.Text = Me.lstClientes.SelectedItem.ToString

            ' Buscarlo en el DataGridView (de forma manual, no conozco otra forma...)

            ' Eliminar las selecciones anteriores
            Me.GrillaClientes.ClearSelection()

            ' Recorrer las filas para buscar el Apellido indicado
            For Each fila As DataGridViewRow In Me.GrillaClientes.Rows
                ' Si es el mismo apellido del textBox

                ' Curiosamente si no son los mismos datos
                ' se produce un error de que d.Cells(...) es Nothing
                ' En realidad de "curioso" no tiene nada,
                ' es que es la última fila, que está vacía...
                If fila.Cells("cli_idcliente").Value Is Nothing _
                OrElse fila.Cells Is Nothing Then
                    Continue For
                End If

                ' Si se quiere tener en cuenta el nombre y los apellidos
                Dim i As Integer = Me.txtdescri.Text.IndexOf(",")

                If i > -1 Then
                    ' En este ejemplo, el formato es Apellidos, Nombre
                    Dim codigo, descripcion As String
                    codigo = Me.txtdescri.Text.Substring(0, i).TrimEnd()
                    descripcion = Me.txtdescri.Text.Substring(i + 1).TrimStart()

                    If codigo = fila.Cells("cli_idcliente").Value.ToString _
                    AndAlso descripcion = fila.Cells("cli_razonsocial").Value.ToString Then
                        ' Seleccionamos la fila
                        Me.GrillaClientes.Rows(fila.Index).Selected = True
                        ' nos aseguramos de que sea visible
                        Me.GrillaClientes.FirstDisplayedScrollingRowIndex = fila.Index
                        Exit For
                    End If
                Else
                    If Me.txtdescri.Text = fila.Cells("cli_razonsocial").Value.ToString Then
                        ' Seleccionamos la fila
                        Me.GrillaClientes.Rows(fila.Index).Selected = True
                        ' nos aseguramos de que sea visible
                        Me.GrillaClientes.FirstDisplayedScrollingRowIndex = fila.Index
                        Exit For
                    End If
                End If
            Next

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdagregar.Click
        Dim frm As New FrmAgregaCliente
        frm.Abrir()
        Form1_Load(sender, e)
    End Sub

    Private Sub cmdcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcerrar.Click
        Close()
    End Sub

    Private Sub cmdmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmodificar.Click
        Dim codigo As String
        Dim FormModifica As New FormModificaCliente


        If GrillaClientes.CurrentCell.Selected = True Then
            codigo = GrillaClientes.Item(0, GrillaClientes.CurrentCell.RowIndex).Value
            FormModifica.Abrir(codigo)
            Form1_Load(sender, e)
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
                Form1_Load(sender, e)
            End If
        Else
            MsgBox("Seleccione una fila válida", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Aviso")
        End If
    End Sub
End Class