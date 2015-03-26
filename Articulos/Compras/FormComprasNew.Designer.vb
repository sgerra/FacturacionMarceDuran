<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComprasNew
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtmFecEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbtiposFactura = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbFormasPAgoProv = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNroFactura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnProd = New System.Windows.Forms.Button()
        Me.cmbProveedores = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GrillaUltimo = New System.Windows.Forms.DataGridView()
        Me.Codarti = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Canti = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Uni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrillaArticulos = New System.Windows.Forms.DataGridView()
        Me.codart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lpd_preciovto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uni_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uni_descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.percep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Importes = New System.Windows.Forms.GroupBox()
        Me.txttotal = New C1.Win.C1Input.C1NumericEdit()
        Me.txtDto = New C1.Win.C1Input.C1NumericEdit()
        Me.txtIb = New C1.Win.C1Input.C1NumericEdit()
        Me.txtPercepIva = New C1.Win.C1Input.C1NumericEdit()
        Me.txtImpInt = New C1.Win.C1Input.C1NumericEdit()
        Me.txtIva = New C1.Win.C1Input.C1NumericEdit()
        Me.txtPbase = New C1.Win.C1Input.C1NumericEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GrillaUltimo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Importes.SuspendLayout()
        CType(Me.txttotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPercepIva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImpInt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPbase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtmFecEntrega)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cmbEstado)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbtiposFactura)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbFormasPAgoProv)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtFecha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNroFactura)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(807, 99)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condiciones Generales"
        '
        'dtmFecEntrega
        '
        Me.dtmFecEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmFecEntrega.Location = New System.Drawing.Point(434, 62)
        Me.dtmFecEntrega.Name = "dtmFecEntrega"
        Me.dtmFecEntrega.Size = New System.Drawing.Size(124, 20)
        Me.dtmFecEntrega.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(333, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Fecha Entrega:"
        '
        'cmbEstado
        '
        Me.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(613, 60)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(185, 21)
        Me.cmbEstado.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(564, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Estado:"
        '
        'cmbtiposFactura
        '
        Me.cmbtiposFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtiposFactura.FormattingEnabled = True
        Me.cmbtiposFactura.Location = New System.Drawing.Point(115, 64)
        Me.cmbtiposFactura.Name = "cmbtiposFactura"
        Me.cmbtiposFactura.Size = New System.Drawing.Size(185, 21)
        Me.cmbtiposFactura.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tipo de Factura:"
        '
        'cmbFormasPAgoProv
        '
        Me.cmbFormasPAgoProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormasPAgoProv.FormattingEnabled = True
        Me.cmbFormasPAgoProv.Location = New System.Drawing.Point(537, 19)
        Me.cmbFormasPAgoProv.Name = "cmbFormasPAgoProv"
        Me.cmbFormasPAgoProv.Size = New System.Drawing.Size(185, 21)
        Me.cmbFormasPAgoProv.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(431, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Condición de Pago:"
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(284, 17)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(124, 20)
        Me.dtFecha.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fecha:"
        '
        'txtNroFactura
        '
        Me.txtNroFactura.Location = New System.Drawing.Point(115, 17)
        Me.txtNroFactura.Name = "txtNroFactura"
        Me.txtNroFactura.Size = New System.Drawing.Size(100, 20)
        Me.txtNroFactura.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Número de Factura:"
        '
        'btnProd
        '
        Me.btnProd.Location = New System.Drawing.Point(422, 143)
        Me.btnProd.Name = "btnProd"
        Me.btnProd.Size = New System.Drawing.Size(111, 23)
        Me.btnProd.TabIndex = 17
        Me.btnProd.Text = "Cargar Porductos"
        Me.btnProd.UseVisualStyleBackColor = True
        '
        'cmbProveedores
        '
        Me.cmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProveedores.FormattingEnabled = True
        Me.cmbProveedores.Location = New System.Drawing.Point(91, 140)
        Me.cmbProveedores.Name = "cmbProveedores"
        Me.cmbProveedores.Size = New System.Drawing.Size(282, 21)
        Me.cmbProveedores.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Proveedor:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GrillaUltimo)
        Me.GroupBox3.Location = New System.Drawing.Point(827, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(515, 160)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos última compra"
        '
        'GrillaUltimo
        '
        Me.GrillaUltimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaUltimo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codarti, Me.Descri, Me.Canti, Me.Uni})
        Me.GrillaUltimo.Location = New System.Drawing.Point(27, 19)
        Me.GrillaUltimo.Name = "GrillaUltimo"
        Me.GrillaUltimo.Size = New System.Drawing.Size(457, 120)
        Me.GrillaUltimo.TabIndex = 14
        '
        'Codarti
        '
        Me.Codarti.HeaderText = "Codigo"
        Me.Codarti.Name = "Codarti"
        '
        'Descri
        '
        Me.Descri.HeaderText = "Descripción"
        Me.Descri.Name = "Descri"
        '
        'Canti
        '
        Me.Canti.HeaderText = "Cantidad"
        Me.Canti.Name = "Canti"
        '
        'Uni
        '
        Me.Uni.HeaderText = "Unidad"
        Me.Uni.Name = "Uni"
        '
        'GrillaArticulos
        '
        Me.GrillaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codart, Me.desc, Me.lpd_preciovto, Me.Cantidad, Me.uni_id, Me.uni_descripcion, Me.Total, Me.costo, Me.iva, Me.percep, Me.dto})
        Me.GrillaArticulos.Location = New System.Drawing.Point(24, 176)
        Me.GrillaArticulos.Name = "GrillaArticulos"
        Me.GrillaArticulos.Size = New System.Drawing.Size(831, 276)
        Me.GrillaArticulos.TabIndex = 21
        '
        'codart
        '
        Me.codart.HeaderText = "Código"
        Me.codart.Name = "codart"
        Me.codart.Width = 80
        '
        'desc
        '
        Me.desc.HeaderText = "Descripción"
        Me.desc.Name = "desc"
        Me.desc.Width = 300
        '
        'lpd_preciovto
        '
        Me.lpd_preciovto.HeaderText = "Precio"
        Me.lpd_preciovto.Name = "lpd_preciovto"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'uni_id
        '
        Me.uni_id.HeaderText = "uni_id"
        Me.uni_id.Name = "uni_id"
        Me.uni_id.Visible = False
        '
        'uni_descripcion
        '
        Me.uni_descripcion.HeaderText = "Unidad"
        Me.uni_descripcion.Name = "uni_descripcion"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        '
        'costo
        '
        Me.costo.HeaderText = "costo"
        Me.costo.Name = "costo"
        Me.costo.Visible = False
        '
        'iva
        '
        Me.iva.HeaderText = "iva"
        Me.iva.Name = "iva"
        Me.iva.Visible = False
        '
        'percep
        '
        Me.percep.HeaderText = "percep"
        Me.percep.Name = "percep"
        Me.percep.Visible = False
        '
        'dto
        '
        Me.dto.HeaderText = "dto"
        Me.dto.Name = "dto"
        Me.dto.Visible = False
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(24, 477)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(878, 41)
        Me.txtobservaciones.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Observaciones:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(564, 638)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 26
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(460, 638)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Importes
        '
        Me.Importes.Controls.Add(Me.txttotal)
        Me.Importes.Controls.Add(Me.txtDto)
        Me.Importes.Controls.Add(Me.txtIb)
        Me.Importes.Controls.Add(Me.txtPercepIva)
        Me.Importes.Controls.Add(Me.txtImpInt)
        Me.Importes.Controls.Add(Me.txtIva)
        Me.Importes.Controls.Add(Me.txtPbase)
        Me.Importes.Controls.Add(Me.Label14)
        Me.Importes.Controls.Add(Me.Label13)
        Me.Importes.Controls.Add(Me.Label12)
        Me.Importes.Controls.Add(Me.Label11)
        Me.Importes.Controls.Add(Me.Label10)
        Me.Importes.Controls.Add(Me.Label9)
        Me.Importes.Controls.Add(Me.Label8)
        Me.Importes.Location = New System.Drawing.Point(27, 536)
        Me.Importes.Name = "Importes"
        Me.Importes.Size = New System.Drawing.Size(1039, 77)
        Me.Importes.TabIndex = 24
        Me.Importes.TabStop = False
        Me.Importes.Text = "Totales"
        '
        'txttotal
        '
        Me.txttotal.AutoOpen = False
        Me.txttotal.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txttotal.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txttotal.Location = New System.Drawing.Point(787, 34)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(102, 18)
        Me.txttotal.TabIndex = 22
        Me.txttotal.Tag = Nothing
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txttotal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txttotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtDto
        '
        Me.txtDto.AutoOpen = False
        Me.txtDto.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtDto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtDto.Location = New System.Drawing.Point(510, 51)
        Me.txtDto.Name = "txtDto"
        Me.txtDto.Size = New System.Drawing.Size(102, 18)
        Me.txtDto.TabIndex = 21
        Me.txtDto.Tag = Nothing
        Me.txtDto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtIb
        '
        Me.txtIb.AutoOpen = False
        Me.txtIb.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtIb.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtIb.Location = New System.Drawing.Point(308, 53)
        Me.txtIb.Name = "txtIb"
        Me.txtIb.Size = New System.Drawing.Size(102, 18)
        Me.txtIb.TabIndex = 20
        Me.txtIb.Tag = Nothing
        Me.txtIb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIb.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIb.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtPercepIva
        '
        Me.txtPercepIva.AutoOpen = False
        Me.txtPercepIva.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtPercepIva.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtPercepIva.Location = New System.Drawing.Point(108, 54)
        Me.txtPercepIva.Name = "txtPercepIva"
        Me.txtPercepIva.Size = New System.Drawing.Size(102, 18)
        Me.txtPercepIva.TabIndex = 19
        Me.txtPercepIva.Tag = Nothing
        Me.txtPercepIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPercepIva.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPercepIva.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtImpInt
        '
        Me.txtImpInt.AutoOpen = False
        Me.txtImpInt.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtImpInt.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtImpInt.Location = New System.Drawing.Point(510, 20)
        Me.txtImpInt.Name = "txtImpInt"
        Me.txtImpInt.Size = New System.Drawing.Size(102, 18)
        Me.txtImpInt.TabIndex = 18
        Me.txtImpInt.Tag = Nothing
        Me.txtImpInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtImpInt.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImpInt.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtIva
        '
        Me.txtIva.AutoOpen = False
        Me.txtIva.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtIva.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtIva.Location = New System.Drawing.Point(308, 17)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(102, 18)
        Me.txtIva.TabIndex = 17
        Me.txtIva.Tag = Nothing
        Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIva.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIva.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtPbase
        '
        Me.txtPbase.AutoOpen = False
        Me.txtPbase.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtPbase.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtPbase.Location = New System.Drawing.Point(108, 20)
        Me.txtPbase.Name = "txtPbase"
        Me.txtPbase.Size = New System.Drawing.Size(102, 18)
        Me.txtPbase.TabIndex = 16
        Me.txtPbase.Tag = Nothing
        Me.txtPbase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPbase.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPbase.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(730, 37)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "TOTAL:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(447, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Descuento:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(246, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Percep.IB"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Percep.IVA:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(459, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Imp.Int.:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(273, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "IVA:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Precio Base:"
        '
        'FormComprasNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 676)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Importes)
        Me.Controls.Add(Me.txtobservaciones)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GrillaArticulos)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnProd)
        Me.Controls.Add(Me.cmbProveedores)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormComprasNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GrillaUltimo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Importes.ResumeLayout(False)
        Me.Importes.PerformLayout()
        CType(Me.txttotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPercepIva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImpInt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPbase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtmFecEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbtiposFactura As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbFormasPAgoProv As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNroFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnProd As System.Windows.Forms.Button
    Friend WithEvents cmbProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GrillaUltimo As System.Windows.Forms.DataGridView
    Friend WithEvents Codarti As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descri As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Canti As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Uni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrillaArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Importes As System.Windows.Forms.GroupBox
    Friend WithEvents txttotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtDto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtIb As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtPercepIva As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtImpInt As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtIva As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPbase As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents codart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lpd_preciovto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uni_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uni_descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iva As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents percep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dto As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
