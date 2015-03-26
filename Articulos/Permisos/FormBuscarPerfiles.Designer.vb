<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarPerfiles
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
        Me.GrillaPerfiles = New System.Windows.Forms.DataGridView()
        Me.idperfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnmodificarPermi = New System.Windows.Forms.Button()
        CType(Me.GrillaPerfiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrillaPerfiles
        '
        Me.GrillaPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaPerfiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idperfil, Me.Perfil})
        Me.GrillaPerfiles.Location = New System.Drawing.Point(117, 84)
        Me.GrillaPerfiles.Name = "GrillaPerfiles"
        Me.GrillaPerfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaPerfiles.Size = New System.Drawing.Size(359, 150)
        Me.GrillaPerfiles.TabIndex = 0
        '
        'idperfil
        '
        Me.idperfil.HeaderText = "idperfil"
        Me.idperfil.Name = "idperfil"
        Me.idperfil.Visible = False
        '
        'Perfil
        '
        Me.Perfil.HeaderText = "Perfil"
        Me.Perfil.Name = "Perfil"
        Me.Perfil.Width = 300
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(269, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnmodificarPermi
        '
        Me.btnmodificarPermi.Location = New System.Drawing.Point(493, 136)
        Me.btnmodificarPermi.Name = "btnmodificarPermi"
        Me.btnmodificarPermi.Size = New System.Drawing.Size(104, 23)
        Me.btnmodificarPermi.TabIndex = 2
        Me.btnmodificarPermi.Text = "Modificar Permisos"
        Me.btnmodificarPermi.UseVisualStyleBackColor = True
        '
        'FormBuscarPerfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 319)
        Me.Controls.Add(Me.btnmodificarPermi)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GrillaPerfiles)
        Me.Name = "FormBuscarPerfiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perfiles para editar permisos"
        CType(Me.GrillaPerfiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrillaPerfiles As System.Windows.Forms.DataGridView
    Friend WithEvents idperfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Perfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnmodificarPermi As System.Windows.Forms.Button
End Class
