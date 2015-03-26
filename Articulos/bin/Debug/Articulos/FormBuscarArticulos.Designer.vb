<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarArticulos
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
        Me.GrillaArticulos = New System.Windows.Forms.DataGridView()
        Me.txtdescri = New System.Windows.Forms.TextBox()
        Me.OptDescripcion = New System.Windows.Forms.RadioButton()
        Me.listaarticulos = New System.Windows.Forms.ListBox()
        Me.cmdagregar = New System.Windows.Forms.Button()
        Me.cmdmodificar = New System.Windows.Forms.Button()
        Me.cmdeliminar = New System.Windows.Forms.Button()
        Me.cmdcerrar = New System.Windows.Forms.Button()
        CType(Me.GrillaArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrillaArticulos
        '
        Me.GrillaArticulos.AllowUserToAddRows = False
        Me.GrillaArticulos.AllowUserToDeleteRows = False
        Me.GrillaArticulos.AllowUserToOrderColumns = True
        Me.GrillaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaArticulos.Location = New System.Drawing.Point(36, 196)
        Me.GrillaArticulos.Name = "GrillaArticulos"
        Me.GrillaArticulos.ReadOnly = True
        Me.GrillaArticulos.Size = New System.Drawing.Size(567, 179)
        Me.GrillaArticulos.TabIndex = 1
        '
        'txtdescri
        '
        Me.txtdescri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtdescri.Location = New System.Drawing.Point(36, 44)
        Me.txtdescri.Name = "txtdescri"
        Me.txtdescri.Size = New System.Drawing.Size(567, 20)
        Me.txtdescri.TabIndex = 2
        '
        'OptDescripcion
        '
        Me.OptDescripcion.AutoSize = True
        Me.OptDescripcion.Location = New System.Drawing.Point(36, 21)
        Me.OptDescripcion.Name = "OptDescripcion"
        Me.OptDescripcion.Size = New System.Drawing.Size(81, 17)
        Me.OptDescripcion.TabIndex = 3
        Me.OptDescripcion.TabStop = True
        Me.OptDescripcion.Text = "Descripción"
        Me.OptDescripcion.UseVisualStyleBackColor = True
        '
        'listaarticulos
        '
        Me.listaarticulos.FormattingEnabled = True
        Me.listaarticulos.Location = New System.Drawing.Point(36, 70)
        Me.listaarticulos.Name = "listaarticulos"
        Me.listaarticulos.Size = New System.Drawing.Size(567, 108)
        Me.listaarticulos.TabIndex = 5
        '
        'cmdagregar
        '
        Me.cmdagregar.Location = New System.Drawing.Point(621, 225)
        Me.cmdagregar.MaximumSize = New System.Drawing.Size(1200, 400)
        Me.cmdagregar.Name = "cmdagregar"
        Me.cmdagregar.Size = New System.Drawing.Size(85, 25)
        Me.cmdagregar.TabIndex = 6
        Me.cmdagregar.Text = "Agregar"
        Me.cmdagregar.UseVisualStyleBackColor = True
        '
        'cmdmodificar
        '
        Me.cmdmodificar.Location = New System.Drawing.Point(621, 266)
        Me.cmdmodificar.Name = "cmdmodificar"
        Me.cmdmodificar.Size = New System.Drawing.Size(85, 25)
        Me.cmdmodificar.TabIndex = 7
        Me.cmdmodificar.Text = "Modificar"
        Me.cmdmodificar.UseVisualStyleBackColor = True
        '
        'cmdeliminar
        '
        Me.cmdeliminar.Location = New System.Drawing.Point(621, 306)
        Me.cmdeliminar.Name = "cmdeliminar"
        Me.cmdeliminar.Size = New System.Drawing.Size(85, 25)
        Me.cmdeliminar.TabIndex = 8
        Me.cmdeliminar.Text = "Eliminar"
        Me.cmdeliminar.UseVisualStyleBackColor = True
        '
        'cmdcerrar
        '
        Me.cmdcerrar.Location = New System.Drawing.Point(319, 399)
        Me.cmdcerrar.Name = "cmdcerrar"
        Me.cmdcerrar.Size = New System.Drawing.Size(85, 24)
        Me.cmdcerrar.TabIndex = 9
        Me.cmdcerrar.Text = "Cerrar"
        Me.cmdcerrar.UseVisualStyleBackColor = True
        '
        'FormBuscarArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 435)
        Me.Controls.Add(Me.cmdcerrar)
        Me.Controls.Add(Me.cmdeliminar)
        Me.Controls.Add(Me.cmdmodificar)
        Me.Controls.Add(Me.cmdagregar)
        Me.Controls.Add(Me.listaarticulos)
        Me.Controls.Add(Me.OptDescripcion)
        Me.Controls.Add(Me.txtdescri)
        Me.Controls.Add(Me.GrillaArticulos)
        Me.Name = "FormBuscarArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Articulos"
        CType(Me.GrillaArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrillaArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents txtdescri As System.Windows.Forms.TextBox
    Friend WithEvents OptDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents listaarticulos As System.Windows.Forms.ListBox
    Friend WithEvents cmdagregar As System.Windows.Forms.Button
    Friend WithEvents cmdmodificar As System.Windows.Forms.Button
    Friend WithEvents cmdeliminar As System.Windows.Forms.Button
    Friend WithEvents cmdcerrar As System.Windows.Forms.Button
End Class
