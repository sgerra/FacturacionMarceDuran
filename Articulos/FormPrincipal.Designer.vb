<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmitirFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionLibreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMPerfilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMPermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministraciónDeCajasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreprarNovedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArmarNovedadesParaEnvioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObtenerNovedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObtenerNovedadesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.UtilidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AumentarPreciosPorProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArticulosToolStripMenuItem, Me.FacturaciónToolStripMenuItem, Me.ToolStripMenuItem1, Me.ProveedoresToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.PreprarNovedadesToolStripMenuItem, Me.ObtenerNovedadesToolStripMenuItem, Me.UtilidadesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(890, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMToolStripMenuItem})
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ArticulosToolStripMenuItem.Text = "Articulos"
        '
        'ABMToolStripMenuItem
        '
        Me.ABMToolStripMenuItem.Name = "ABMToolStripMenuItem"
        Me.ABMToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ABMToolStripMenuItem.Text = "ABM"
        '
        'FacturaciónToolStripMenuItem
        '
        Me.FacturaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmitirFacturaToolStripMenuItem, Me.FacturacionLibreToolStripMenuItem})
        Me.FacturaciónToolStripMenuItem.Name = "FacturaciónToolStripMenuItem"
        Me.FacturaciónToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.FacturaciónToolStripMenuItem.Text = "Facturación"
        '
        'EmitirFacturaToolStripMenuItem
        '
        Me.EmitirFacturaToolStripMenuItem.Name = "EmitirFacturaToolStripMenuItem"
        Me.EmitirFacturaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.EmitirFacturaToolStripMenuItem.Text = "Emitir Factura"
        '
        'FacturacionLibreToolStripMenuItem
        '
        Me.FacturacionLibreToolStripMenuItem.Name = "FacturacionLibreToolStripMenuItem"
        Me.FacturacionLibreToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.FacturacionLibreToolStripMenuItem.Text = "Facturacion Libre"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMToolStripMenuItem1})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.ToolStripMenuItem1.Text = "Clientes"
        '
        'ABMToolStripMenuItem1
        '
        Me.ABMToolStripMenuItem1.Name = "ABMToolStripMenuItem1"
        Me.ABMToolStripMenuItem1.Size = New System.Drawing.Size(100, 22)
        Me.ABMToolStripMenuItem1.Text = "ABM"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasToolStripMenuItem1, Me.PagosToolStripMenuItem})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ComprasToolStripMenuItem1
        '
        Me.ComprasToolStripMenuItem1.Name = "ComprasToolStripMenuItem1"
        Me.ComprasToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.ComprasToolStripMenuItem1.Text = "Compras"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMToolStripMenuItem2, Me.ABMPerfilesToolStripMenuItem, Me.ABMPermisosToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(72, 20)
        Me.ToolStripMenuItem2.Text = "Seguridad"
        '
        'ABMToolStripMenuItem2
        '
        Me.ABMToolStripMenuItem2.Name = "ABMToolStripMenuItem2"
        Me.ABMToolStripMenuItem2.Size = New System.Drawing.Size(151, 22)
        Me.ABMToolStripMenuItem2.Text = "ABM Usuarios"
        '
        'ABMPerfilesToolStripMenuItem
        '
        Me.ABMPerfilesToolStripMenuItem.Name = "ABMPerfilesToolStripMenuItem"
        Me.ABMPerfilesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ABMPerfilesToolStripMenuItem.Text = "ABM Perfiles"
        '
        'ABMPermisosToolStripMenuItem
        '
        Me.ABMPermisosToolStripMenuItem.Name = "ABMPermisosToolStripMenuItem"
        Me.ABMPermisosToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ABMPermisosToolStripMenuItem.Text = "ABM Permisos"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciónDeCajasToolStripMenuItem})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(85, 20)
        Me.ToolStripMenuItem3.Text = "Cajas Diarias"
        '
        'AdministraciónDeCajasToolStripMenuItem
        '
        Me.AdministraciónDeCajasToolStripMenuItem.Name = "AdministraciónDeCajasToolStripMenuItem"
        Me.AdministraciónDeCajasToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AdministraciónDeCajasToolStripMenuItem.Text = "Administración de Cajas"
        '
        'PreprarNovedadesToolStripMenuItem
        '
        Me.PreprarNovedadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArmarNovedadesParaEnvioToolStripMenuItem})
        Me.PreprarNovedadesToolStripMenuItem.Name = "PreprarNovedadesToolStripMenuItem"
        Me.PreprarNovedadesToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.PreprarNovedadesToolStripMenuItem.Text = "Preparar Novedades"
        '
        'ArmarNovedadesParaEnvioToolStripMenuItem
        '
        Me.ArmarNovedadesParaEnvioToolStripMenuItem.Name = "ArmarNovedadesParaEnvioToolStripMenuItem"
        Me.ArmarNovedadesParaEnvioToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.ArmarNovedadesParaEnvioToolStripMenuItem.Text = "Armar Novedades Para Envio"
        '
        'ObtenerNovedadesToolStripMenuItem
        '
        Me.ObtenerNovedadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ObtenerNovedadesToolStripMenuItem1})
        Me.ObtenerNovedadesToolStripMenuItem.Name = "ObtenerNovedadesToolStripMenuItem"
        Me.ObtenerNovedadesToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.ObtenerNovedadesToolStripMenuItem.Text = "Obtener Novedades"
        '
        'ObtenerNovedadesToolStripMenuItem1
        '
        Me.ObtenerNovedadesToolStripMenuItem1.Name = "ObtenerNovedadesToolStripMenuItem1"
        Me.ObtenerNovedadesToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.ObtenerNovedadesToolStripMenuItem1.Text = "Obtener Novedades "
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(890, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'UtilidadesToolStripMenuItem
        '
        Me.UtilidadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AumentarPreciosPorProveedorToolStripMenuItem})
        Me.UtilidadesToolStripMenuItem.Name = "UtilidadesToolStripMenuItem"
        Me.UtilidadesToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.UtilidadesToolStripMenuItem.Text = "Utilidades"
        '
        'AumentarPreciosPorProveedorToolStripMenuItem
        '
        Me.AumentarPreciosPorProveedorToolStripMenuItem.Name = "AumentarPreciosPorProveedorToolStripMenuItem"
        Me.AumentarPreciosPorProveedorToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.AumentarPreciosPorProveedorToolStripMenuItem.Text = "Aumentar Precios Por Proveedor"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FormPrincipal"
        Me.Text = "Sistema de Facturación .NET"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ArticulosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmitirFacturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministraciónDeCajasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMPerfilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMPermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturacionLibreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreprarNovedadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArmarNovedadesParaEnvioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ObtenerNovedadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ObtenerNovedadesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AumentarPreciosPorProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
