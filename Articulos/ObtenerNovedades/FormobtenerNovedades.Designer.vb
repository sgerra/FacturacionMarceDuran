<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormobtenerNovedades
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
        Me.cmbUsuarios = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrillaCajas = New System.Windows.Forms.DataGridView()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.btnobtener = New System.Windows.Forms.Button()
        Me.NroCaja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantTi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GrillaCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione el Usuario:"
        '
        'cmbUsuarios
        '
        Me.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUsuarios.FormattingEnabled = True
        Me.cmbUsuarios.Location = New System.Drawing.Point(140, 29)
        Me.cmbUsuarios.Name = "cmbUsuarios"
        Me.cmbUsuarios.Size = New System.Drawing.Size(228, 21)
        Me.cmbUsuarios.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Resúmen:"
        '
        'GrillaCajas
        '
        Me.GrillaCajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaCajas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroCaja, Me.Saldo, Me.CantTi})
        Me.GrillaCajas.Location = New System.Drawing.Point(73, 121)
        Me.GrillaCajas.Name = "GrillaCajas"
        Me.GrillaCajas.Size = New System.Drawing.Size(617, 247)
        Me.GrillaCajas.TabIndex = 3
        '
        'btncerrar
        '
        Me.btncerrar.Location = New System.Drawing.Point(306, 396)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(75, 23)
        Me.btncerrar.TabIndex = 4
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'btnobtener
        '
        Me.btnobtener.Location = New System.Drawing.Point(384, 29)
        Me.btnobtener.Name = "btnobtener"
        Me.btnobtener.Size = New System.Drawing.Size(75, 23)
        Me.btnobtener.TabIndex = 5
        Me.btnobtener.Text = "Obtener"
        Me.btnobtener.UseVisualStyleBackColor = True
        '
        'NroCaja
        '
        Me.NroCaja.HeaderText = "NroCaja"
        Me.NroCaja.Name = "NroCaja"
        '
        'Saldo
        '
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Width = 300
        '
        'CantTi
        '
        Me.CantTi.HeaderText = "Cantidad Tickets"
        Me.CantTi.Name = "CantTi"
        '
        'FormobtenerNovedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 431)
        Me.Controls.Add(Me.btnobtener)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.GrillaCajas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbUsuarios)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormobtenerNovedades"
        Me.Text = "obtener Novedades"
        CType(Me.GrillaCajas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbUsuarios As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GrillaCajas As System.Windows.Forms.DataGridView
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents btnobtener As System.Windows.Forms.Button
    Friend WithEvents NroCaja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantTi As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
