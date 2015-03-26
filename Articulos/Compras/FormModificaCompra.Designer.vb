<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModificaCompra
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
        Me.cmbProveedores = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.btnCancelaModifica = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1044, 91)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condiciones Generales"
        '
        'dtmFecEntrega
        '
        Me.dtmFecEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmFecEntrega.Location = New System.Drawing.Point(450, 57)
        Me.dtmFecEntrega.Name = "dtmFecEntrega"
        Me.dtmFecEntrega.Size = New System.Drawing.Size(124, 20)
        Me.dtmFecEntrega.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(349, 62)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 13)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Fecha Entrega:"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Location = New System.Drawing.Point(733, 56)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(185, 21)
        Me.cmbEstado.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(679, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Estado:"
        '
        'cmbtiposFactura
        '
        Me.cmbtiposFactura.FormattingEnabled = True
        Me.cmbtiposFactura.Location = New System.Drawing.Point(120, 65)
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
        Me.cmbFormasPAgoProv.FormattingEnabled = True
        Me.cmbFormasPAgoProv.Location = New System.Drawing.Point(733, 12)
        Me.cmbFormasPAgoProv.Name = "cmbFormasPAgoProv"
        Me.cmbFormasPAgoProv.Size = New System.Drawing.Size(185, 21)
        Me.cmbFormasPAgoProv.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(622, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Condición de Pago:"
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(450, 20)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(124, 20)
        Me.dtFecha.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(389, 20)
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
        'cmbProveedores
        '
        Me.cmbProveedores.FormattingEnabled = True
        Me.cmbProveedores.Location = New System.Drawing.Point(78, 32)
        Me.cmbProveedores.Name = "cmbProveedores"
        Me.cmbProveedores.Size = New System.Drawing.Size(284, 21)
        Me.cmbProveedores.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Proveedor:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GrillaArticulos)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtobservaciones)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbProveedores)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 169)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1318, 397)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del proveedor"
        '
        'GrillaArticulos
        '
        Me.GrillaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codart, Me.desc, Me.lpd_preciovto, Me.Cantidad, Me.uni_id, Me.uni_descripcion, Me.Total, Me.costo, Me.iva, Me.percep, Me.dto})
        Me.GrillaArticulos.Location = New System.Drawing.Point(17, 82)
        Me.GrillaArticulos.Name = "GrillaArticulos"
        Me.GrillaArticulos.Size = New System.Drawing.Size(831, 255)
        Me.GrillaArticulos.TabIndex = 23
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(368, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Cargar Porductos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(17, 343)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(878, 41)
        Me.txtobservaciones.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Observaciones:"
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
        Me.Importes.Location = New System.Drawing.Point(12, 572)
        Me.Importes.Name = "Importes"
        Me.Importes.Size = New System.Drawing.Size(1039, 77)
        Me.Importes.TabIndex = 13
        Me.Importes.TabStop = False
        Me.Importes.Text = "Totales"
        '
        'txttotal
        '
        Me.txttotal.AutoOpen = False
        Me.txttotal.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txttotal.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txttotal.Location = New System.Drawing.Point(728, 32)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(102, 18)
        Me.txttotal.TabIndex = 29
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
        Me.txtDto.Location = New System.Drawing.Point(516, 50)
        Me.txtDto.Name = "txtDto"
        Me.txtDto.Size = New System.Drawing.Size(102, 18)
        Me.txtDto.TabIndex = 28
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
        Me.txtIb.Location = New System.Drawing.Point(314, 52)
        Me.txtIb.Name = "txtIb"
        Me.txtIb.Size = New System.Drawing.Size(102, 18)
        Me.txtIb.TabIndex = 27
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
        Me.txtPercepIva.Location = New System.Drawing.Point(114, 53)
        Me.txtPercepIva.Name = "txtPercepIva"
        Me.txtPercepIva.Size = New System.Drawing.Size(102, 18)
        Me.txtPercepIva.TabIndex = 26
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
        Me.txtImpInt.Location = New System.Drawing.Point(516, 14)
        Me.txtImpInt.Name = "txtImpInt"
        Me.txtImpInt.Size = New System.Drawing.Size(102, 18)
        Me.txtImpInt.TabIndex = 25
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
        Me.txtIva.Location = New System.Drawing.Point(314, 11)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(102, 18)
        Me.txtIva.TabIndex = 24
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
        Me.txtPbase.Location = New System.Drawing.Point(114, 14)
        Me.txtPbase.Name = "txtPbase"
        Me.txtPbase.Size = New System.Drawing.Size(102, 18)
        Me.txtPbase.TabIndex = 23
        Me.txtPbase.Tag = Nothing
        Me.txtPbase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPbase.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPbase.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(671, 37)
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
        'btnCancelaModifica
        '
        Me.btnCancelaModifica.Location = New System.Drawing.Point(446, 655)
        Me.btnCancelaModifica.Name = "btnCancelaModifica"
        Me.btnCancelaModifica.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelaModifica.TabIndex = 16
        Me.btnCancelaModifica.Text = "Cancelar"
        Me.btnCancelaModifica.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(542, 655)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 17
        Me.btnModificar.Text = "Aceptar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'FormModificaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 684)
        Me.Controls.Add(Me.btnCancelaModifica)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Importes)
        Me.Name = "FormModificaCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Compra"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
    Friend WithEvents cmbProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Importes As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancelaModifica As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents dtmFecEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txttotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtDto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtIb As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtPercepIva As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtImpInt As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtIva As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtPbase As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents GrillaArticulos As System.Windows.Forms.DataGridView
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
