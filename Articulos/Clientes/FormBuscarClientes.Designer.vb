<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarClientes
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
        Me.cmdcerrar = New System.Windows.Forms.Button()
        Me.cmdeliminar = New System.Windows.Forms.Button()
        Me.cmdmodificar = New System.Windows.Forms.Button()
        Me.cmdagregar = New System.Windows.Forms.Button()
        Me.lstClientes = New System.Windows.Forms.ListBox()
        Me.OptDescripcion = New System.Windows.Forms.RadioButton()
        Me.txtdescri = New System.Windows.Forms.TextBox()
        Me.GrillaClientes = New System.Windows.Forms.DataGridView()
        CType(Me.GrillaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdcerrar
        '
        Me.cmdcerrar.Location = New System.Drawing.Point(324, 390)
        Me.cmdcerrar.Name = "cmdcerrar"
        Me.cmdcerrar.Size = New System.Drawing.Size(85, 24)
        Me.cmdcerrar.TabIndex = 17
        Me.cmdcerrar.Text = "Cerrar"
        Me.cmdcerrar.UseVisualStyleBackColor = True
        '
        'cmdeliminar
        '
        Me.cmdeliminar.Location = New System.Drawing.Point(626, 297)
        Me.cmdeliminar.Name = "cmdeliminar"
        Me.cmdeliminar.Size = New System.Drawing.Size(85, 25)
        Me.cmdeliminar.TabIndex = 16
        Me.cmdeliminar.Text = "Eliminar"
        Me.cmdeliminar.UseVisualStyleBackColor = True
        '
        'cmdmodificar
        '
        Me.cmdmodificar.Location = New System.Drawing.Point(626, 257)
        Me.cmdmodificar.Name = "cmdmodificar"
        Me.cmdmodificar.Size = New System.Drawing.Size(85, 25)
        Me.cmdmodificar.TabIndex = 15
        Me.cmdmodificar.Text = "Modificar"
        Me.cmdmodificar.UseVisualStyleBackColor = True
        '
        'cmdagregar
        '
        Me.cmdagregar.Location = New System.Drawing.Point(626, 216)
        Me.cmdagregar.MaximumSize = New System.Drawing.Size(1200, 400)
        Me.cmdagregar.Name = "cmdagregar"
        Me.cmdagregar.Size = New System.Drawing.Size(85, 25)
        Me.cmdagregar.TabIndex = 14
        Me.cmdagregar.Text = "Agregar"
        Me.cmdagregar.UseVisualStyleBackColor = True
        '
        'lstClientes
        '
        Me.lstClientes.FormattingEnabled = True
        Me.lstClientes.Location = New System.Drawing.Point(41, 61)
        Me.lstClientes.Name = "lstClientes"
        Me.lstClientes.Size = New System.Drawing.Size(567, 108)
        Me.lstClientes.TabIndex = 13
        '
        'OptDescripcion
        '
        Me.OptDescripcion.AutoSize = True
        Me.OptDescripcion.Location = New System.Drawing.Point(41, 12)
        Me.OptDescripcion.Name = "OptDescripcion"
        Me.OptDescripcion.Size = New System.Drawing.Size(81, 17)
        Me.OptDescripcion.TabIndex = 12
        Me.OptDescripcion.TabStop = True
        Me.OptDescripcion.Text = "Descripción"
        Me.OptDescripcion.UseVisualStyleBackColor = True
        '
        'txtdescri
        '
        Me.txtdescri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtdescri.Location = New System.Drawing.Point(41, 35)
        Me.txtdescri.Name = "txtdescri"
        Me.txtdescri.Size = New System.Drawing.Size(567, 20)
        Me.txtdescri.TabIndex = 11
        '
        'GrillaClientes
        '
        Me.GrillaClientes.AllowUserToAddRows = False
        Me.GrillaClientes.AllowUserToDeleteRows = False
        Me.GrillaClientes.AllowUserToOrderColumns = True
        Me.GrillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaClientes.Location = New System.Drawing.Point(41, 187)
        Me.GrillaClientes.Name = "GrillaClientes"
        Me.GrillaClientes.ReadOnly = True
        Me.GrillaClientes.Size = New System.Drawing.Size(567, 179)
        Me.GrillaClientes.TabIndex = 10
        '
        'FormBuscarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 469)
        Me.Controls.Add(Me.cmdcerrar)
        Me.Controls.Add(Me.cmdeliminar)
        Me.Controls.Add(Me.cmdmodificar)
        Me.Controls.Add(Me.cmdagregar)
        Me.Controls.Add(Me.lstClientes)
        Me.Controls.Add(Me.OptDescripcion)
        Me.Controls.Add(Me.txtdescri)
        Me.Controls.Add(Me.GrillaClientes)
        Me.Name = "FormBuscarClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM de Clientes"
        CType(Me.GrillaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdcerrar As System.Windows.Forms.Button
    Friend WithEvents cmdeliminar As System.Windows.Forms.Button
    Friend WithEvents cmdmodificar As System.Windows.Forms.Button
    Friend WithEvents cmdagregar As System.Windows.Forms.Button
    Friend WithEvents lstClientes As System.Windows.Forms.ListBox
    Friend WithEvents OptDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents txtdescri As System.Windows.Forms.TextBox
    Friend WithEvents GrillaClientes As System.Windows.Forms.DataGridView
End Class
