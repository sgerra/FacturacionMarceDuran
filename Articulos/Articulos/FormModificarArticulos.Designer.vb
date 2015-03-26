<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModificarArticulos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkListas = New System.Windows.Forms.CheckBox()
        Me.btnPropagaLista = New System.Windows.Forms.Button()
        Me.DataGridListas = New System.Windows.Forms.DataGridView()
        Me.IdLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.elegido = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PorcGanancia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdeliminar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.GrillaPrecios = New System.Windows.Forms.DataGridView()
        Me.NroLista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pbase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoIva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcDto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoDto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcPercep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoPercep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioSubT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PorcUtil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MontoUtil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaModi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkStock = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbSigno = New System.Windows.Forms.ComboBox()
        Me.btnProagaCosto = New System.Windows.Forms.Button()
        Me.cmbEtiqueta = New System.Windows.Forms.ComboBox()
        Me.cmbUnidad = New System.Windows.Forms.ComboBox()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.cmbrubro = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCostoGranel = New C1.Win.C1Input.C1NumericEdit()
        Me.txtUniGranel = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPCosto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnModificaStock = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.GrillaStock = New System.Windows.Forms.DataGridView()
        Me.iddeposito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Deposito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockIni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockAct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.cmdcancelar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridListas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GrillaPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCostoGranel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUniGranel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GrillaStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1321, 624)
        Me.TabControl1.TabIndex = 32
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1313, 598)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Generales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(1012, 24)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(295, 312)
        Me.GroupBox5.TabIndex = 35
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Foto"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(109, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Cargar Imagen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(274, 247)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkListas)
        Me.GroupBox3.Controls.Add(Me.btnPropagaLista)
        Me.GroupBox3.Controls.Add(Me.DataGridListas)
        Me.GroupBox3.Location = New System.Drawing.Point(650, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(343, 211)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listas de Precios"
        '
        'chkListas
        '
        Me.chkListas.AutoSize = True
        Me.chkListas.Location = New System.Drawing.Point(34, 182)
        Me.chkListas.Name = "chkListas"
        Me.chkListas.Size = New System.Drawing.Size(98, 17)
        Me.chkListas.TabIndex = 48
        Me.chkListas.Text = "Todas las listas"
        Me.chkListas.UseVisualStyleBackColor = True
        '
        'btnPropagaLista
        '
        Me.btnPropagaLista.Location = New System.Drawing.Point(138, 178)
        Me.btnPropagaLista.Name = "btnPropagaLista"
        Me.btnPropagaLista.Size = New System.Drawing.Size(102, 23)
        Me.btnPropagaLista.TabIndex = 47
        Me.btnPropagaLista.Text = "Propagar Precios"
        Me.btnPropagaLista.UseVisualStyleBackColor = True
        '
        'DataGridListas
        '
        Me.DataGridListas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridListas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdLista, Me.NombreLista, Me.elegido, Me.PorcGanancia})
        Me.DataGridListas.Location = New System.Drawing.Point(23, 31)
        Me.DataGridListas.Name = "DataGridListas"
        Me.DataGridListas.Size = New System.Drawing.Size(298, 140)
        Me.DataGridListas.TabIndex = 0
        '
        'IdLista
        '
        Me.IdLista.HeaderText = "IdLista"
        Me.IdLista.Name = "IdLista"
        Me.IdLista.Visible = False
        '
        'NombreLista
        '
        Me.NombreLista.HeaderText = "Nombre"
        Me.NombreLista.Name = "NombreLista"
        '
        'elegido
        '
        Me.elegido.HeaderText = "Selección"
        Me.elegido.Name = "elegido"
        '
        'PorcGanancia
        '
        Me.PorcGanancia.HeaderText = "PorcGanancia"
        Me.PorcGanancia.Name = "PorcGanancia"
        Me.PorcGanancia.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdeliminar)
        Me.GroupBox2.Controls.Add(Me.cmdModificar)
        Me.GroupBox2.Controls.Add(Me.cmdAgregar)
        Me.GroupBox2.Controls.Add(Me.GrillaPrecios)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 370)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1256, 195)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listas de Precios"
        '
        'cmdeliminar
        '
        Me.cmdeliminar.Location = New System.Drawing.Point(1145, 118)
        Me.cmdeliminar.Name = "cmdeliminar"
        Me.cmdeliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmdeliminar.TabIndex = 3
        Me.cmdeliminar.Text = "Eliminar"
        Me.cmdeliminar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(1145, 80)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(75, 23)
        Me.cmdModificar.TabIndex = 2
        Me.cmdModificar.Text = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(1145, 36)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAgregar.TabIndex = 1
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'GrillaPrecios
        '
        Me.GrillaPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaPrecios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroLista, Me.Nombre, Me.Pbase, Me.PorcIva, Me.MontoIva, Me.PorcDto, Me.MontoDto, Me.PorcPercep, Me.MontoPercep, Me.PrecioSubT, Me.PorcUtil, Me.MontoUtil, Me.PrecioVenta, Me.FechaModi})
        Me.GrillaPrecios.Location = New System.Drawing.Point(16, 19)
        Me.GrillaPrecios.Name = "GrillaPrecios"
        Me.GrillaPrecios.Size = New System.Drawing.Size(1123, 150)
        Me.GrillaPrecios.TabIndex = 0
        '
        'NroLista
        '
        Me.NroLista.HeaderText = "Nro.Lista"
        Me.NroLista.Name = "NroLista"
        Me.NroLista.Width = 70
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "NombreLista"
        Me.Nombre.Name = "Nombre"
        '
        'Pbase
        '
        Me.Pbase.HeaderText = "P.Base"
        Me.Pbase.Name = "Pbase"
        Me.Pbase.Width = 70
        '
        'PorcIva
        '
        Me.PorcIva.HeaderText = "% Iva"
        Me.PorcIva.Name = "PorcIva"
        Me.PorcIva.Width = 70
        '
        'MontoIva
        '
        Me.MontoIva.HeaderText = "Monto Iva"
        Me.MontoIva.Name = "MontoIva"
        Me.MontoIva.Width = 70
        '
        'PorcDto
        '
        Me.PorcDto.HeaderText = "% Dto."
        Me.PorcDto.Name = "PorcDto"
        Me.PorcDto.Width = 70
        '
        'MontoDto
        '
        Me.MontoDto.HeaderText = "Monto Dto."
        Me.MontoDto.Name = "MontoDto"
        Me.MontoDto.Width = 70
        '
        'PorcPercep
        '
        Me.PorcPercep.HeaderText = "% Percep."
        Me.PorcPercep.Name = "PorcPercep"
        Me.PorcPercep.Width = 70
        '
        'MontoPercep
        '
        Me.MontoPercep.HeaderText = "Monto Percep."
        Me.MontoPercep.Name = "MontoPercep"
        '
        'PrecioSubT
        '
        Me.PrecioSubT.HeaderText = "Precio I y D"
        Me.PrecioSubT.Name = "PrecioSubT"
        Me.PrecioSubT.Width = 70
        '
        'PorcUtil
        '
        Me.PorcUtil.HeaderText = "% Utilidad"
        Me.PorcUtil.Name = "PorcUtil"
        Me.PorcUtil.Width = 70
        '
        'MontoUtil
        '
        Me.MontoUtil.HeaderText = "Monto Util"
        Me.MontoUtil.Name = "MontoUtil"
        Me.MontoUtil.Width = 70
        '
        'PrecioVenta
        '
        Me.PrecioVenta.HeaderText = "Precio Venta"
        Me.PrecioVenta.Name = "PrecioVenta"
        Me.PrecioVenta.Width = 70
        '
        'FechaModi
        '
        Me.FechaModi.HeaderText = "Fecha Modificación"
        Me.FechaModi.Name = "FechaModi"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkStock)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbSigno)
        Me.GroupBox1.Controls.Add(Me.btnProagaCosto)
        Me.GroupBox1.Controls.Add(Me.cmbEtiqueta)
        Me.GroupBox1.Controls.Add(Me.cmbUnidad)
        Me.GroupBox1.Controls.Add(Me.cmbProveedor)
        Me.GroupBox1.Controls.Add(Me.cmbrubro)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtCostoGranel)
        Me.GroupBox1.Controls.Add(Me.txtUniGranel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPCosto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtdesc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcb)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(590, 341)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Articulo"
        '
        'chkStock
        '
        Me.chkStock.AutoSize = True
        Me.chkStock.Location = New System.Drawing.Point(405, 208)
        Me.chkStock.Name = "chkStock"
        Me.chkStock.Size = New System.Drawing.Size(96, 17)
        Me.chkStock.TabIndex = 49
        Me.chkStock.Text = "Controla Stock"
        Me.chkStock.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(360, 177)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Signo:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbSigno
        '
        Me.cmbSigno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSigno.FormattingEnabled = True
        Me.cmbSigno.Items.AddRange(New Object() {"1", "-1"})
        Me.cmbSigno.Location = New System.Drawing.Point(405, 171)
        Me.cmbSigno.Name = "cmbSigno"
        Me.cmbSigno.Size = New System.Drawing.Size(121, 21)
        Me.cmbSigno.TabIndex = 47
        '
        'btnProagaCosto
        '
        Me.btnProagaCosto.Location = New System.Drawing.Point(252, 130)
        Me.btnProagaCosto.Name = "btnProagaCosto"
        Me.btnProagaCosto.Size = New System.Drawing.Size(102, 23)
        Me.btnProagaCosto.TabIndex = 46
        Me.btnProagaCosto.Text = "Propagar Costo"
        Me.btnProagaCosto.UseVisualStyleBackColor = True
        '
        'cmbEtiqueta
        '
        Me.cmbEtiqueta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEtiqueta.FormattingEnabled = True
        Me.cmbEtiqueta.Location = New System.Drawing.Point(117, 292)
        Me.cmbEtiqueta.Name = "cmbEtiqueta"
        Me.cmbEtiqueta.Size = New System.Drawing.Size(169, 21)
        Me.cmbEtiqueta.TabIndex = 45
        '
        'cmbUnidad
        '
        Me.cmbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnidad.FormattingEnabled = True
        Me.cmbUnidad.Location = New System.Drawing.Point(117, 251)
        Me.cmbUnidad.Name = "cmbUnidad"
        Me.cmbUnidad.Size = New System.Drawing.Size(169, 21)
        Me.cmbUnidad.TabIndex = 44
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Location = New System.Drawing.Point(117, 213)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(169, 21)
        Me.cmbProveedor.TabIndex = 43
        '
        'cmbrubro
        '
        Me.cmbrubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbrubro.FormattingEnabled = True
        Me.cmbrubro.Location = New System.Drawing.Point(117, 174)
        Me.cmbrubro.Name = "cmbrubro"
        Me.cmbrubro.Size = New System.Drawing.Size(169, 21)
        Me.cmbrubro.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Etiqueta:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(72, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Unidad:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Proveedor:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(72, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Rubro:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(291, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Unidades Por Granel:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCostoGranel
        '
        Me.txtCostoGranel.AutoOpen = False
        Me.txtCostoGranel.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtCostoGranel.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtCostoGranel.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtCostoGranel.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtCostoGranel.Location = New System.Drawing.Point(119, 95)
        Me.txtCostoGranel.Name = "txtCostoGranel"
        Me.txtCostoGranel.Size = New System.Drawing.Size(111, 18)
        Me.txtCostoGranel.TabIndex = 36
        Me.txtCostoGranel.Tag = Nothing
        Me.txtCostoGranel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCostoGranel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCostoGranel.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtUniGranel
        '
        Me.txtUniGranel.AutoOpen = False
        Me.txtUniGranel.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.[Integer]
        Me.txtUniGranel.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtUniGranel.FormatType = C1.Win.C1Input.FormatTypeEnum.[Integer]
        Me.txtUniGranel.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtUniGranel.Location = New System.Drawing.Point(405, 95)
        Me.txtUniGranel.Name = "txtUniGranel"
        Me.txtUniGranel.Size = New System.Drawing.Size(110, 18)
        Me.txtUniGranel.TabIndex = 35
        Me.txtUniGranel.Tag = Nothing
        Me.txtUniGranel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtUniGranel.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Costo a granel:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPCosto
        '
        Me.txtPCosto.AutoOpen = False
        Me.txtPCosto.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtPCosto.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtPCosto.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtPCosto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtPCosto.Location = New System.Drawing.Point(119, 138)
        Me.txtPCosto.Name = "txtPCosto"
        Me.txtPCosto.Size = New System.Drawing.Size(111, 18)
        Me.txtPCosto.TabIndex = 33
        Me.txtPCosto.Tag = Nothing
        Me.txtPCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPCosto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPCosto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Costo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(119, 55)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(324, 20)
        Me.txtdesc.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Descripción:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtcb
        '
        Me.txtcb.Location = New System.Drawing.Point(119, 19)
        Me.txtcb.Name = "txtcb"
        Me.txtcb.Size = New System.Drawing.Size(205, 20)
        Me.txtcb.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Código de barras:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1313, 598)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Stock por Depósito"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnModificaStock)
        Me.GroupBox4.Controls.Add(Me.btneliminar)
        Me.GroupBox4.Controls.Add(Me.btnAgregar)
        Me.GroupBox4.Controls.Add(Me.GrillaStock)
        Me.GroupBox4.Location = New System.Drawing.Point(52, 58)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(853, 194)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Stock por depósito"
        '
        'btnModificaStock
        '
        Me.btnModificaStock.Location = New System.Drawing.Point(723, 90)
        Me.btnModificaStock.Name = "btnModificaStock"
        Me.btnModificaStock.Size = New System.Drawing.Size(75, 23)
        Me.btnModificaStock.TabIndex = 3
        Me.btnModificaStock.Text = "Modificar"
        Me.btnModificaStock.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(723, 129)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 2
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(723, 52)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'GrillaStock
        '
        Me.GrillaStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.iddeposito, Me.Deposito, Me.StockIni, Me.StockMax, Me.StockMin, Me.StockAct, Me.FecIn})
        Me.GrillaStock.Location = New System.Drawing.Point(23, 31)
        Me.GrillaStock.Name = "GrillaStock"
        Me.GrillaStock.Size = New System.Drawing.Size(645, 140)
        Me.GrillaStock.TabIndex = 0
        '
        'iddeposito
        '
        Me.iddeposito.HeaderText = "iddeposito"
        Me.iddeposito.Name = "iddeposito"
        Me.iddeposito.Visible = False
        '
        'Deposito
        '
        Me.Deposito.HeaderText = "Depósito"
        Me.Deposito.Name = "Deposito"
        '
        'StockIni
        '
        Me.StockIni.HeaderText = "Stock Inicial"
        Me.StockIni.Name = "StockIni"
        '
        'StockMax
        '
        Me.StockMax.HeaderText = "Stock Máximo"
        Me.StockMax.Name = "StockMax"
        '
        'StockMin
        '
        Me.StockMin.HeaderText = "Stock Mínimo"
        Me.StockMin.Name = "StockMin"
        '
        'StockAct
        '
        Me.StockAct.HeaderText = "Stock Actual"
        Me.StockAct.Name = "StockAct"
        '
        'FecIn
        '
        Me.FecIn.HeaderText = "Fecha Inventario"
        Me.FecIn.Name = "FecIn"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(546, 653)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(82, 25)
        Me.btnModificar.TabIndex = 34
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'cmdcancelar
        '
        Me.cmdcancelar.Location = New System.Drawing.Point(445, 653)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(82, 25)
        Me.cmdcancelar.TabIndex = 33
        Me.cmdcancelar.Text = "Cancelar"
        Me.cmdcancelar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FormModificarArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1351, 702)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.cmdcancelar)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormModificarArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Articulos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridListas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GrillaPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtCostoGranel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUniGranel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPCosto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GrillaStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnPropagaLista As System.Windows.Forms.Button
    Friend WithEvents DataGridListas As System.Windows.Forms.DataGridView
    Friend WithEvents IdLista As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreLista As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents elegido As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents PorcGanancia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdeliminar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents GrillaPrecios As System.Windows.Forms.DataGridView
    Friend WithEvents NroLista As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pbase As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoIva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcDto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoDto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcPercep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoPercep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioSubT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PorcUtil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoUtil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioVenta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaModi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkStock As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbSigno As System.Windows.Forms.ComboBox
    Friend WithEvents btnProagaCosto As System.Windows.Forms.Button
    Friend WithEvents cmbEtiqueta As System.Windows.Forms.ComboBox
    Friend WithEvents cmbUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbrubro As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCostoGranel As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtUniGranel As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPCosto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcb As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificaStock As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents GrillaStock As System.Windows.Forms.DataGridView
    Friend WithEvents iddeposito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Deposito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockIni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockMax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockMin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockAct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecIn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents cmdcancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkListas As System.Windows.Forms.CheckBox
End Class
