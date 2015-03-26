<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCheques
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
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.cmdagregar = New System.Windows.Forms.Button()
        Me.GrillaCheques = New System.Windows.Forms.DataGridView()
        Me.Orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEmi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAcredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Banco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btncerrar = New System.Windows.Forms.Button()
        CType(Me.GrillaCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(671, 132)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEliminar.TabIndex = 9
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'cmdagregar
        '
        Me.cmdagregar.Location = New System.Drawing.Point(671, 88)
        Me.cmdagregar.Name = "cmdagregar"
        Me.cmdagregar.Size = New System.Drawing.Size(75, 23)
        Me.cmdagregar.TabIndex = 8
        Me.cmdagregar.Text = "Agregar"
        Me.cmdagregar.UseVisualStyleBackColor = True
        '
        'GrillaCheques
        '
        Me.GrillaCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaCheques.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Orden, Me.NroCheque, Me.FechaEmi, Me.FechaAcredit, Me.Banco, Me.Monto})
        Me.GrillaCheques.Location = New System.Drawing.Point(22, 53)
        Me.GrillaCheques.Name = "GrillaCheques"
        Me.GrillaCheques.Size = New System.Drawing.Size(624, 150)
        Me.GrillaCheques.TabIndex = 7
        '
        'Orden
        '
        Me.Orden.HeaderText = "Orden"
        Me.Orden.Name = "Orden"
        Me.Orden.Visible = False
        '
        'NroCheque
        '
        Me.NroCheque.HeaderText = "Nro. Cheque"
        Me.NroCheque.Name = "NroCheque"
        '
        'FechaEmi
        '
        Me.FechaEmi.HeaderText = "Fecha Emisión"
        Me.FechaEmi.Name = "FechaEmi"
        '
        'FechaAcredit
        '
        Me.FechaAcredit.HeaderText = "Fecha Acreditación"
        Me.FechaAcredit.Name = "FechaAcredit"
        '
        'Banco
        '
        Me.Banco.HeaderText = "Banco"
        Me.Banco.Name = "Banco"
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        '
        'btncerrar
        '
        Me.btncerrar.Location = New System.Drawing.Point(319, 229)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(75, 23)
        Me.btncerrar.TabIndex = 10
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.UseVisualStyleBackColor = True
        '
        'FormCheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 276)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.cmdagregar)
        Me.Controls.Add(Me.GrillaCheques)
        Me.Name = "FormCheques"
        Me.Text = "Ingreso de cheques"
        CType(Me.GrillaCheques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdEliminar As System.Windows.Forms.Button
    Friend WithEvents cmdagregar As System.Windows.Forms.Button
    Friend WithEvents GrillaCheques As System.Windows.Forms.DataGridView
    Friend WithEvents Orden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroCheque As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaEmi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAcredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Banco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btncerrar As System.Windows.Forms.Button
End Class
