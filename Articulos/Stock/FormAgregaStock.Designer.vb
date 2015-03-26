<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgregaStock
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
        Me.cmbDepositos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStkIni = New C1.Win.C1Input.C1NumericEdit()
        Me.txtStkMax = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStkMin = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStkAct = New C1.Win.C1Input.C1NumericEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtFecinv = New System.Windows.Forms.DateTimePicker()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.txtStkIni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStkMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStkMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStkAct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbDepositos
        '
        Me.cmbDepositos.FormattingEnabled = True
        Me.cmbDepositos.Location = New System.Drawing.Point(120, 25)
        Me.cmbDepositos.Name = "cmbDepositos"
        Me.cmbDepositos.Size = New System.Drawing.Size(156, 21)
        Me.cmbDepositos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Depósito:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Stock Inicial:"
        '
        'txtStkIni
        '
        Me.txtStkIni.AutoOpen = False
        Me.txtStkIni.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.txtStkIni.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtStkIni.FormatType = C1.Win.C1Input.FormatTypeEnum.GeneralNumber
        Me.txtStkIni.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtStkIni.Location = New System.Drawing.Point(120, 71)
        Me.txtStkIni.Name = "txtStkIni"
        Me.txtStkIni.Size = New System.Drawing.Size(112, 18)
        Me.txtStkIni.TabIndex = 3
        Me.txtStkIni.Tag = Nothing
        Me.txtStkIni.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtStkMax
        '
        Me.txtStkMax.AutoOpen = False
        Me.txtStkMax.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.txtStkMax.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtStkMax.FormatType = C1.Win.C1Input.FormatTypeEnum.GeneralNumber
        Me.txtStkMax.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtStkMax.Location = New System.Drawing.Point(120, 118)
        Me.txtStkMax.Name = "txtStkMax"
        Me.txtStkMax.Size = New System.Drawing.Size(112, 18)
        Me.txtStkMax.TabIndex = 5
        Me.txtStkMax.Tag = Nothing
        Me.txtStkMax.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Stock Máximo:"
        '
        'txtStkMin
        '
        Me.txtStkMin.AutoOpen = False
        Me.txtStkMin.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.txtStkMin.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtStkMin.FormatType = C1.Win.C1Input.FormatTypeEnum.GeneralNumber
        Me.txtStkMin.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtStkMin.Location = New System.Drawing.Point(120, 159)
        Me.txtStkMin.Name = "txtStkMin"
        Me.txtStkMin.Size = New System.Drawing.Size(112, 18)
        Me.txtStkMin.TabIndex = 7
        Me.txtStkMin.Tag = Nothing
        Me.txtStkMin.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Stock Minimo:"
        '
        'txtStkAct
        '
        Me.txtStkAct.AutoOpen = False
        Me.txtStkAct.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.StandardNumber
        Me.txtStkAct.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtStkAct.FormatType = C1.Win.C1Input.FormatTypeEnum.GeneralNumber
        Me.txtStkAct.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtStkAct.Location = New System.Drawing.Point(120, 204)
        Me.txtStkAct.Name = "txtStkAct"
        Me.txtStkAct.Size = New System.Drawing.Size(112, 18)
        Me.txtStkAct.TabIndex = 9
        Me.txtStkAct.Tag = Nothing
        Me.txtStkAct.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Stock Actual:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fecha de Inventario:"
        '
        'dtFecinv
        '
        Me.dtFecinv.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecinv.Location = New System.Drawing.Point(120, 247)
        Me.dtFecinv.Name = "dtFecinv"
        Me.dtFecinv.Size = New System.Drawing.Size(112, 20)
        Me.dtFecinv.TabIndex = 11
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(121, 359)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(218, 359)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtStkAct)
        Me.GroupBox1.Controls.Add(Me.dtFecinv)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtStkMin)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtStkMax)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtStkIni)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbDepositos)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 328)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'FormAgregaStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 400)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormAgregaStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Stock"
        CType(Me.txtStkIni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStkMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStkMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStkAct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbDepositos As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStkIni As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtStkMax As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtStkMin As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStkAct As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtFecinv As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
