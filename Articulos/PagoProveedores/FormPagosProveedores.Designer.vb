<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPagosProveedores
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblProveedor = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtFecPago = New System.Windows.Forms.DateTimePicker()
        Me.lblSaldoafavor = New System.Windows.Forms.Label()
        Me.DataGridFacturasPendientes = New System.Windows.Forms.DataGridView()
        Me.IdCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.DataFactuAPagar = New System.Windows.Forms.DataGridView()
        Me.IdCom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroFac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoFac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecCom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.comboEstado = New System.Windows.Forms.ComboBox()
        Me.TextOC = New System.Windows.Forms.TextBox()
        Me.TextBo = New System.Windows.Forms.TextBox()
        Me.btnOc = New System.Windows.Forms.Button()
        Me.btnBoni = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextTotFact = New System.Windows.Forms.TextBox()
        Me.TextBon = New System.Windows.Forms.TextBox()
        Me.TextTotal = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btncheques = New System.Windows.Forms.Button()
        Me.txtcheques = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnefectivo = New System.Windows.Forms.Button()
        Me.txtefectivo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btndeposito = New System.Windows.Forms.Button()
        Me.txtdeposito = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextTotalPagado = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.commandAceptarAgregar = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblResto = New System.Windows.Forms.Label()
        Me.commandAceptarModificar = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtobservaciones = New System.Windows.Forms.TextBox()
        CType(Me.DataGridFacturasPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataFactuAPagar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(164, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedor:"
        '
        'LblProveedor
        '
        Me.LblProveedor.AutoSize = True
        Me.LblProveedor.Location = New System.Drawing.Point(262, 13)
        Me.LblProveedor.Name = "LblProveedor"
        Me.LblProveedor.Size = New System.Drawing.Size(39, 13)
        Me.LblProveedor.TabIndex = 1
        Me.LblProveedor.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Saldo pago anterior $:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(449, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha:"
        '
        'dtFecPago
        '
        Me.dtFecPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecPago.Location = New System.Drawing.Point(515, 13)
        Me.dtFecPago.Name = "dtFecPago"
        Me.dtFecPago.Size = New System.Drawing.Size(200, 20)
        Me.dtFecPago.TabIndex = 4
        '
        'lblSaldoafavor
        '
        Me.lblSaldoafavor.AutoSize = True
        Me.lblSaldoafavor.Location = New System.Drawing.Point(233, 47)
        Me.lblSaldoafavor.Name = "lblSaldoafavor"
        Me.lblSaldoafavor.Size = New System.Drawing.Size(13, 13)
        Me.lblSaldoafavor.TabIndex = 5
        Me.lblSaldoafavor.Text = "0"
        '
        'DataGridFacturasPendientes
        '
        Me.DataGridFacturasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridFacturasPendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCompra, Me.NroFactura, Me.Tipo, Me.FechaCompra, Me.Saldo})
        Me.DataGridFacturasPendientes.Location = New System.Drawing.Point(6, 19)
        Me.DataGridFacturasPendientes.Name = "DataGridFacturasPendientes"
        Me.DataGridFacturasPendientes.Size = New System.Drawing.Size(690, 122)
        Me.DataGridFacturasPendientes.TabIndex = 6
        '
        'IdCompra
        '
        Me.IdCompra.HeaderText = "IdCompra"
        Me.IdCompra.Name = "IdCompra"
        '
        'NroFactura
        '
        Me.NroFactura.HeaderText = "Nro.Factura"
        Me.NroFactura.Name = "NroFactura"
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'FechaCompra
        '
        Me.FechaCompra.HeaderText = "Fecha Compra"
        Me.FechaCompra.Name = "FechaCompra"
        Me.FechaCompra.Width = 120
        '
        'Saldo
        '
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Width = 300
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.DataGridFacturasPendientes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(827, 153)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facturas pendientes de pago"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(716, 35)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 48
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'DataFactuAPagar
        '
        Me.DataFactuAPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataFactuAPagar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCom, Me.NroFac, Me.TipoFac, Me.FecCom, Me.Monto})
        Me.DataFactuAPagar.Location = New System.Drawing.Point(43, 19)
        Me.DataFactuAPagar.Name = "DataFactuAPagar"
        Me.DataFactuAPagar.Size = New System.Drawing.Size(488, 118)
        Me.DataFactuAPagar.TabIndex = 6
        '
        'IdCom
        '
        Me.IdCom.HeaderText = "IdCom"
        Me.IdCom.Name = "IdCom"
        '
        'NroFac
        '
        Me.NroFac.HeaderText = "Nro.Factura"
        Me.NroFac.Name = "NroFac"
        '
        'TipoFac
        '
        Me.TipoFac.HeaderText = "Tipo"
        Me.TipoFac.Name = "TipoFac"
        '
        'FecCom
        '
        Me.FecCom.HeaderText = "Fecha Compra"
        Me.FecCom.Name = "FecCom"
        Me.FecCom.Width = 120
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnQuitar)
        Me.GroupBox2.Controls.Add(Me.DataFactuAPagar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 222)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(674, 150)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Facturas a pagar"
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(563, 34)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitar.TabIndex = 49
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 387)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Estado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(274, 387)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Otros Conceptos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(572, 387)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Bonificaciones:"
        '
        'comboEstado
        '
        Me.comboEstado.DisplayMember = "0"
        Me.comboEstado.FormattingEnabled = True
        Me.comboEstado.Items.AddRange(New Object() {"Abierto", "Cerrado"})
        Me.comboEstado.Location = New System.Drawing.Point(75, 387)
        Me.comboEstado.Name = "comboEstado"
        Me.comboEstado.Size = New System.Drawing.Size(180, 21)
        Me.comboEstado.TabIndex = 12
        Me.comboEstado.ValueMember = "0"
        '
        'TextOC
        '
        Me.TextOC.Location = New System.Drawing.Point(397, 387)
        Me.TextOC.Name = "TextOC"
        Me.TextOC.Size = New System.Drawing.Size(111, 20)
        Me.TextOC.TabIndex = 13
        Me.TextOC.Text = "0"
        Me.TextOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBo
        '
        Me.TextBo.Location = New System.Drawing.Point(677, 386)
        Me.TextBo.Name = "TextBo"
        Me.TextBo.Size = New System.Drawing.Size(111, 20)
        Me.TextBo.TabIndex = 14
        Me.TextBo.Text = "0"
        Me.TextBo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnOc
        '
        Me.btnOc.Location = New System.Drawing.Point(515, 384)
        Me.btnOc.Name = "btnOc"
        Me.btnOc.Size = New System.Drawing.Size(40, 23)
        Me.btnOc.TabIndex = 15
        Me.btnOc.Text = "..."
        Me.btnOc.UseVisualStyleBackColor = True
        '
        'btnBoni
        '
        Me.btnBoni.Location = New System.Drawing.Point(794, 385)
        Me.btnBoni.Name = "btnBoni"
        Me.btnBoni.Size = New System.Drawing.Size(40, 23)
        Me.btnBoni.TabIndex = 16
        Me.btnBoni.Text = "..."
        Me.btnBoni.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(562, 427)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Total a Pagar $:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(264, 427)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Total Bonificaciones $:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 427)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Total Facturas $:"
        '
        'TextTotFact
        '
        Me.TextTotFact.Location = New System.Drawing.Point(123, 422)
        Me.TextTotFact.Name = "TextTotFact"
        Me.TextTotFact.Size = New System.Drawing.Size(111, 20)
        Me.TextTotFact.TabIndex = 20
        Me.TextTotFact.Text = "0"
        Me.TextTotFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBon
        '
        Me.TextBon.Location = New System.Drawing.Point(422, 422)
        Me.TextBon.Name = "TextBon"
        Me.TextBon.Size = New System.Drawing.Size(111, 20)
        Me.TextBon.TabIndex = 21
        Me.TextBon.Text = "0"
        Me.TextBon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextTotal
        '
        Me.TextTotal.Location = New System.Drawing.Point(677, 422)
        Me.TextTotal.Name = "TextTotal"
        Me.TextTotal.Size = New System.Drawing.Size(111, 20)
        Me.TextTotal.TabIndex = 22
        Me.TextTotal.Text = "0"
        Me.TextTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-21, 414)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(861, 3)
        Me.Panel1.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(-1, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(861, 2)
        Me.Panel2.TabIndex = 24
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(3, 451)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(837, 3)
        Me.Panel3.TabIndex = 25
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(-1, 143)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(861, 2)
        Me.Panel4.TabIndex = 24
        '
        'btncheques
        '
        Me.btncheques.Location = New System.Drawing.Point(794, 462)
        Me.btncheques.Name = "btncheques"
        Me.btncheques.Size = New System.Drawing.Size(40, 23)
        Me.btncheques.TabIndex = 31
        Me.btncheques.Text = "..."
        Me.btncheques.UseVisualStyleBackColor = True
        '
        'txtcheques
        '
        Me.txtcheques.Location = New System.Drawing.Point(677, 461)
        Me.txtcheques.Name = "txtcheques"
        Me.txtcheques.Size = New System.Drawing.Size(111, 20)
        Me.txtcheques.TabIndex = 30
        Me.txtcheques.Text = "0"
        Me.txtcheques.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(604, 466)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 15)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Cheques:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(3, 491)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(837, 3)
        Me.Panel5.TabIndex = 32
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(-1, 143)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(861, 2)
        Me.Panel6.TabIndex = 24
        '
        'btnefectivo
        '
        Me.btnefectivo.Location = New System.Drawing.Point(437, 511)
        Me.btnefectivo.Name = "btnefectivo"
        Me.btnefectivo.Size = New System.Drawing.Size(40, 23)
        Me.btnefectivo.TabIndex = 35
        Me.btnefectivo.Text = "..."
        Me.btnefectivo.UseVisualStyleBackColor = True
        '
        'txtefectivo
        '
        Me.txtefectivo.Location = New System.Drawing.Point(320, 513)
        Me.txtefectivo.Name = "txtefectivo"
        Me.txtefectivo.Size = New System.Drawing.Size(111, 20)
        Me.txtefectivo.TabIndex = 34
        Me.txtefectivo.Text = "0"
        Me.txtefectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(253, 514)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 15)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Efectivo:"
        '
        'btndeposito
        '
        Me.btndeposito.Location = New System.Drawing.Point(692, 513)
        Me.btndeposito.Name = "btndeposito"
        Me.btndeposito.Size = New System.Drawing.Size(40, 23)
        Me.btndeposito.TabIndex = 38
        Me.btndeposito.Text = "..."
        Me.btndeposito.UseVisualStyleBackColor = True
        '
        'txtdeposito
        '
        Me.txtdeposito.Location = New System.Drawing.Point(575, 515)
        Me.txtdeposito.Name = "txtdeposito"
        Me.txtdeposito.Size = New System.Drawing.Size(111, 20)
        Me.txtdeposito.TabIndex = 37
        Me.txtdeposito.Text = "0"
        Me.txtdeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(491, 516)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 15)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Depósitos:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(466, 561)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 15)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Diferencia:"
        '
        'TextTotalPagado
        '
        Me.TextTotalPagado.Location = New System.Drawing.Point(320, 560)
        Me.TextTotalPagado.Name = "TextTotalPagado"
        Me.TextTotalPagado.Size = New System.Drawing.Size(111, 20)
        Me.TextTotalPagado.TabIndex = 40
        Me.TextTotalPagado.Text = "0"
        Me.TextTotalPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(218, 563)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 15)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Total Pagado:"
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(356, 661)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 43
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'commandAceptarAgregar
        '
        Me.commandAceptarAgregar.Location = New System.Drawing.Point(437, 661)
        Me.commandAceptarAgregar.Name = "commandAceptarAgregar"
        Me.commandAceptarAgregar.Size = New System.Drawing.Size(75, 23)
        Me.commandAceptarAgregar.TabIndex = 44
        Me.commandAceptarAgregar.Text = "Aceptar"
        Me.commandAceptarAgregar.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Location = New System.Drawing.Point(6, 542)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(837, 3)
        Me.Panel7.TabIndex = 45
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Black
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Location = New System.Drawing.Point(-1, 143)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(861, 2)
        Me.Panel8.TabIndex = 24
        '
        'lblResto
        '
        Me.lblResto.AutoSize = True
        Me.lblResto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResto.Location = New System.Drawing.Point(549, 561)
        Me.lblResto.Name = "lblResto"
        Me.lblResto.Size = New System.Drawing.Size(15, 15)
        Me.lblResto.TabIndex = 46
        Me.lblResto.Text = "0"
        '
        'commandAceptarModificar
        '
        Me.commandAceptarModificar.Location = New System.Drawing.Point(437, 661)
        Me.commandAceptarModificar.Name = "commandAceptarModificar"
        Me.commandAceptarModificar.Size = New System.Drawing.Size(75, 23)
        Me.commandAceptarModificar.TabIndex = 47
        Me.commandAceptarModificar.Text = "Aceptar"
        Me.commandAceptarModificar.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Black
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Location = New System.Drawing.Point(-1, -1)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(837, 3)
        Me.Panel9.TabIndex = 46
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Black
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Location = New System.Drawing.Point(-1, 143)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(861, 2)
        Me.Panel10.TabIndex = 24
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Black
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Location = New System.Drawing.Point(6, 586)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(837, 3)
        Me.Panel11.TabIndex = 48
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.Black
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Location = New System.Drawing.Point(-1, 143)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(861, 2)
        Me.Panel12.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 596)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 15)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Observaciones:"
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(114, 599)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(726, 56)
        Me.txtobservaciones.TabIndex = 50
        '
        'FormPagosProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 691)
        Me.Controls.Add(Me.txtobservaciones)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.commandAceptarModificar)
        Me.Controls.Add(Me.lblResto)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.commandAceptarAgregar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextTotalPagado)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btndeposito)
        Me.Controls.Add(Me.txtdeposito)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnefectivo)
        Me.Controls.Add(Me.txtefectivo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btncheques)
        Me.Controls.Add(Me.txtcheques)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextTotal)
        Me.Controls.Add(Me.TextBon)
        Me.Controls.Add(Me.TextTotFact)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnBoni)
        Me.Controls.Add(Me.btnOc)
        Me.Controls.Add(Me.TextBo)
        Me.Controls.Add(Me.TextOC)
        Me.Controls.Add(Me.comboEstado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblSaldoafavor)
        Me.Controls.Add(Me.dtFecPago)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPagosProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos a Proveedores"
        CType(Me.DataGridFacturasPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataFactuAPagar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblProveedor As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtFecPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSaldoafavor As System.Windows.Forms.Label
    Friend WithEvents DataGridFacturasPendientes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataFactuAPagar As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents comboEstado As System.Windows.Forms.ComboBox
    Friend WithEvents TextOC As System.Windows.Forms.TextBox
    Friend WithEvents TextBo As System.Windows.Forms.TextBox
    Friend WithEvents btnOc As System.Windows.Forms.Button
    Friend WithEvents btnBoni As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextTotFact As System.Windows.Forms.TextBox
    Friend WithEvents TextBon As System.Windows.Forms.TextBox
    Friend WithEvents TextTotal As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btncheques As System.Windows.Forms.Button
    Friend WithEvents txtcheques As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnefectivo As System.Windows.Forms.Button
    Friend WithEvents txtefectivo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btndeposito As System.Windows.Forms.Button
    Friend WithEvents txtdeposito As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextTotalPagado As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents commandAceptarAgregar As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents lblResto As System.Windows.Forms.Label
    Friend WithEvents commandAceptarModificar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents IdCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroFactura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCompra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdCom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroFac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoFac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FecCom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtobservaciones As System.Windows.Forms.TextBox
End Class
