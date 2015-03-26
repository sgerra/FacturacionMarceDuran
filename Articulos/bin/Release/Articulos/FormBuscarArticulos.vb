Imports AppFacturacion.pltFacturacion
Public Class FormBuscarArticulos
    Dim ds As DataSet
    Private dt As DataTable
    Dim iniciando As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cadena As String
        Try
            iniciando = True
            cadena = My.Settings.cadena
            txtdescri.Text = ""
            GrillaArticulos.DataSource = pltFacturacion.ObtenerLista(cadena).Tables(0)
            dt = pltFacturacion.ObtenerLista(cadena).Tables(0)
            'codigo de articulo 
            GrillaArticulos.Columns("codart").HeaderText = "Codigo"
            GrillaArticulos.Columns("codart").Width = 0
            GrillaArticulos.Columns("codart").Visible = False
            GrillaArticulos.Columns("codart").ReadOnly = True
            GrillaArticulos.Columns("codart").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            'Descripcion
            GrillaArticulos.Columns("desc").HeaderText = "Descripcion"
            GrillaArticulos.Columns("desc").Width = 100
            GrillaArticulos.Columns("desc").Visible = True
            GrillaArticulos.Columns("desc").ReadOnly = True
            GrillaArticulos.Columns("desc").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            'Codigo de barras
            GrillaArticulos.Columns("cod").HeaderText = "Codigo de Barras"
            GrillaArticulos.Columns("cod").Width = 100
            GrillaArticulos.Columns("cod").Visible = True
            GrillaArticulos.Columns("cod").ReadOnly = True
            GrillaArticulos.Columns("cod").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            'Precio
            GrillaArticulos.Columns("costo").HeaderText = "Precio"
            GrillaArticulos.Columns("costo").Width = 80
            GrillaArticulos.Columns("costo").Visible = True
            GrillaArticulos.Columns("costo").ReadOnly = True
            GrillaArticulos.Columns("costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            iniciando = False
        Catch ex As Exception
            MsgBox("Se ha producido un error en la aplicación" + "  " + ex.Message, MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrillaArticulos.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim Vista As New DataView
        ' Vista.Table = ds.Tables(0)
        ' Vista.RowFilter = "Descri like '%" & txtdescri.Text & "%'"
        ' Vista.Sort = "Descri"
        ' GrillaArticulos.DataSource = Vista
        ' GrillaArticulos.Update()
    End Sub

    Private Sub txtdescri_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescri.TextChanged

        If Not iniciando Then
            ' Buscar en el DataTable usando el método Select
            ' que es como un filtro WHERE en una cadena de selección.

            ' El resultado se devuelve como un array de tipo DataRow
            Dim filas() As DataRow

            ' Si solo quieres mostrar los que empiecen por lo escrito.
            ' Al escribir "s" se buscarán los que empiecen por esa letra.
            filas = dt.Select("[desc] LIKE '" & txtdescri.Text & "%'")

            ' Borrar los elementos anteriores
            Me.listaarticulos.Items.Clear()

            ' Si hay datos, mostrar los apellidos
            If filas.Length > 0 Then

                ' Recorrer cada fila y mostrar los apellidos
                For Each dr As DataRow In filas

                    Me.listaarticulos.Items.Add( _
                                dr("codart").ToString & ", " & _
                                dr("desc").ToString)

                Next
            End If
        End If

    End Sub

    Private Sub listaarticulos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles listaarticulos.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            Me.txtdescri.Text = Me.listaarticulos.SelectedItem.ToString

            ' Buscarlo en el DataGridView (de forma manual, no conozco otra forma...)

            ' Eliminar las selecciones anteriores
            Me.GrillaArticulos.ClearSelection()

            ' Recorrer las filas para buscar el Apellido indicado
            For Each fila As DataGridViewRow In Me.GrillaArticulos.Rows
                ' Si es el mismo apellido del textBox

                ' Curiosamente si no son los mismos datos
                ' se produce un error de que d.Cells(...) es Nothing
                ' En realidad de "curioso" no tiene nada,
                ' es que es la última fila, que está vacía...
                If fila.Cells("codart").Value Is Nothing _
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

                    If codigo = fila.Cells("codart").Value.ToString _
                    AndAlso descripcion = fila.Cells("descri").Value.ToString Then
                        ' Seleccionamos la fila
                        Me.GrillaArticulos.Rows(fila.Index).Selected = True
                        ' nos aseguramos de que sea visible
                        Me.GrillaArticulos.FirstDisplayedScrollingRowIndex = fila.Index
                        Exit For
                    End If
                Else
                    If Me.txtdescri.Text = fila.Cells("descart").Value.ToString Then
                        ' Seleccionamos la fila
                        Me.GrillaArticulos.Rows(fila.Index).Selected = True
                        ' nos aseguramos de que sea visible
                        Me.GrillaArticulos.FirstDisplayedScrollingRowIndex = fila.Index
                        Exit For
                    End If
                End If
            Next

        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdagregar.Click
        Dim frm As New FormArticulos
        frm.Abrirformulario(-1)
    End Sub

    Private Sub cmdcerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcerrar.Click
        Close()
    End Sub

    Private Sub cmdmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmodificar.Click
        Dim codigo As String
        Dim FormModifica As New FormArticulos


        If GrillaArticulos.CurrentCell.Selected = True Then
            codigo = GrillaArticulos.Item(0, GrillaArticulos.CurrentCell.RowIndex).Value
            FormModifica.Abrirformulario(codigo)
            Close()
        Else
            MsgBox("Seleccione una fila válida", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Aviso")
        End If

    End Sub
End Class