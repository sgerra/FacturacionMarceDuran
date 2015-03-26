Imports System.Windows.Forms
'Imports System.Globalization


Public Class FormPrincipal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Agregar código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregar código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del primario.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer = 0

    Private Sub ABMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMToolStripMenuItem.Click
        Dim frm As New FormBuscarArticulosNew
        frm.ShowDialog()
    End Sub

    Private Sub FormPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'System.Threading.Thread.CurrentThread.CurrentCulture = New CultureInfo("es-ES")
        'System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ","
        'System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = "."

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Está seguro de salir del sistema ?", MsgBoxStyle.YesNoCancel, "Aviso") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub FacturaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaciónToolStripMenuItem.Click

    End Sub

    Private Sub EmitirFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmitirFacturaToolStripMenuItem.Click
        Dim factura As New FormEmiteFac
        factura.AbrirFormulario()
    End Sub

    Private Sub AltaDeFacturasDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComprasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem1.Click
        Dim facturaCompra As New FormBuscaPedido
        facturaCompra.AbrirFormulario()
    End Sub

    Private Sub PagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem.Click
        Dim form As New FormDeudaProvePpal
        form.ShowDialog()
    End Sub

    
    Private Sub ABMToolStripMenuItem2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ABMToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ABMToolStripMenuItem1.Click
        Dim frm As New FormBuscarClientesNew
        frm.ShowDialog()
    End Sub

    Private Sub AdministraciónDeCajasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministraciónDeCajasToolStripMenuItem.Click
        Dim frm As New FormBuscarCajas
        frm.ShowDialog()
    End Sub

    Private Sub ABMToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles ABMToolStripMenuItem2.Click
        Dim frm As New FormBuscarUsuarios
        frm.ShowDialog()
    End Sub

    Private Sub ABMPermisosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMPermisosToolStripMenuItem.Click
        Dim frm As New FormBuscarPerfiles

        frm.ShowDialog()

    End Sub

    Private Sub ABMPerfilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABMPerfilesToolStripMenuItem.Click
        Dim frm As New FormPerfiles

        frm.ShowDialog()
    End Sub

    Private Sub FacturacionLibreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturacionLibreToolStripMenuItem.Click
        Dim frm As New FormFacturacionLibre
        frm.ShowDialog()
    End Sub

    Private Sub ArmarNovedadesParaEnvioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArmarNovedadesParaEnvioToolStripMenuItem.Click
        Dim frm As New FormPrepararNovedades
        frm.ShowDialog()
    End Sub

    Private Sub ObtenerNovedadesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ObtenerNovedadesToolStripMenuItem1.Click
        Dim frm As New FormobtenerNovedades
        frm.ShowDialog()
    End Sub

    Private Sub AumentarPreciosPorProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AumentarPreciosPorProveedorToolStripMenuItem.Click
        Dim frm As New FormAumentaPrecioPorProveedor

        frm.ShowDialog()
    End Sub
End Class
