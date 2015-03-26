<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarCajas
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btncontinua = New System.Windows.Forms.Button()
        Me.txtNroCaja = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.btnNroCaja = New System.Windows.Forms.RadioButton()
        Me.btnFecha = New System.Windows.Forms.RadioButton()
        Me.btnNueva = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GrillaArticulos = New System.Windows.Forms.DataGridView()
        Me.NroCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAper = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraAper = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCierre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraCierre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cerrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoIni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCerar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrillaArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btncontinua)
        Me.GroupBox1.Controls.Add(Me.txtNroCaja)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.btnNroCaja)
        Me.GroupBox1.Controls.Add(Me.btnFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(103, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(726, 77)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda de articulos"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(580, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Volver Busqueda"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btncontinua
        '
        Me.btncontinua.Location = New System.Drawing.Point(580, 40)
        Me.btncontinua.Name = "btncontinua"
        Me.btncontinua.Size = New System.Drawing.Size(134, 23)
        Me.btncontinua.TabIndex = 4
        Me.btncontinua.Text = "Continúa Buscando"
        Me.btncontinua.UseVisualStyleBackColor = True
        '
        'txtNroCaja
        '
        Me.txtNroCaja.Location = New System.Drawing.Point(185, 43)
        Me.txtNroCaja.Name = "txtNroCaja"
        Me.txtNroCaja.Size = New System.Drawing.Size(293, 20)
        Me.txtNroCaja.TabIndex = 3
        Me.txtNroCaja.Visible = False
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(185, 43)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(293, 20)
        Me.txtFecha.TabIndex = 2
        '
        'btnNroCaja
        '
        Me.btnNroCaja.AutoSize = True
        Me.btnNroCaja.Location = New System.Drawing.Point(390, 11)
        Me.btnNroCaja.Name = "btnNroCaja"
        Me.btnNroCaja.Size = New System.Drawing.Size(170, 17)
        Me.btnNroCaja.TabIndex = 1
        Me.btnNroCaja.TabStop = True
        Me.btnNroCaja.Text = "Búsqueda por Número de Caja"
        Me.btnNroCaja.UseVisualStyleBackColor = True
        '
        'btnFecha
        '
        Me.btnFecha.AutoSize = True
        Me.btnFecha.Location = New System.Drawing.Point(60, 20)
        Me.btnFecha.Name = "btnFecha"
        Me.btnFecha.Size = New System.Drawing.Size(121, 17)
        Me.btnFecha.TabIndex = 0
        Me.btnFecha.TabStop = True
        Me.btnFecha.Text = "Búsqueda por fecha"
        Me.btnFecha.UseVisualStyleBackColor = True
        '
        'btnNueva
        '
        Me.btnNueva.Location = New System.Drawing.Point(927, 220)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(75, 23)
        Me.btnNueva.TabIndex = 6
        Me.btnNueva.Text = "Nueva Caja"
        Me.btnNueva.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(370, 449)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GrillaArticulos
        '
        Me.GrillaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroCaja, Me.FechaAper, Me.HoraAper, Me.FechaCierre, Me.HoraCierre, Me.Cerrada, Me.SaldoIni, Me.SaldoFinal})
        Me.GrillaArticulos.Location = New System.Drawing.Point(61, 117)
        Me.GrillaArticulos.Name = "GrillaArticulos"
        Me.GrillaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaArticulos.Size = New System.Drawing.Size(842, 292)
        Me.GrillaArticulos.TabIndex = 4
        '
        'NroCaja
        '
        Me.NroCaja.HeaderText = "Nro.Caja"
        Me.NroCaja.Name = "NroCaja"
        Me.NroCaja.Width = 85
        '
        'FechaAper
        '
        Me.FechaAper.HeaderText = "Fecha de Apertura"
        Me.FechaAper.Name = "FechaAper"
        '
        'HoraAper
        '
        Me.HoraAper.HeaderText = "Hora de Apertura"
        Me.HoraAper.Name = "HoraAper"
        '
        'FechaCierre
        '
        Me.FechaCierre.HeaderText = "Fecha de Cierre"
        Me.FechaCierre.Name = "FechaCierre"
        '
        'HoraCierre
        '
        Me.HoraCierre.HeaderText = "Hora de Cierre"
        Me.HoraCierre.Name = "HoraCierre"
        '
        'Cerrada
        '
        Me.Cerrada.HeaderText = "Cerrada"
        Me.Cerrada.Name = "Cerrada"
        '
        'SaldoIni
        '
        Me.SaldoIni.HeaderText = "Saldo Inicial"
        Me.SaldoIni.Name = "SaldoIni"
        '
        'SaldoFinal
        '
        Me.SaldoFinal.HeaderText = "Saldo Final"
        Me.SaldoFinal.Name = "SaldoFinal"
        '
        'btnCerar
        '
        Me.btnCerar.Location = New System.Drawing.Point(927, 263)
        Me.btnCerar.Name = "btnCerar"
        Me.btnCerar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerar.TabIndex = 8
        Me.btnCerar.Text = "Cerrar Caja"
        Me.btnCerar.UseVisualStyleBackColor = True
        '
        'FormBuscarCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 494)
        Me.Controls.Add(Me.btnCerar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GrillaArticulos)
        Me.Name = "FormBuscarCajas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Cajas Diarias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GrillaArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btncontinua As System.Windows.Forms.Button
    Friend WithEvents txtNroCaja As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents btnNroCaja As System.Windows.Forms.RadioButton
    Friend WithEvents btnFecha As System.Windows.Forms.RadioButton
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GrillaArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents NroCaja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAper As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoraAper As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaCierre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoraCierre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cerrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoIni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCerar As System.Windows.Forms.Button
End Class
