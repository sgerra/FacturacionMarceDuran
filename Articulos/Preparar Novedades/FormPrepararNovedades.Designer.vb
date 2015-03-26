<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrepararNovedades
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
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnclientes = New System.Windows.Forms.Button()
        Me.btnformaPago = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnArticulos
        '
        Me.btnArticulos.Location = New System.Drawing.Point(107, 62)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(96, 23)
        Me.btnArticulos.TabIndex = 0
        Me.btnArticulos.Text = "Tabla Articulos"
        Me.btnArticulos.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Location = New System.Drawing.Point(225, 62)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(96, 23)
        Me.btnUsuarios.TabIndex = 1
        Me.btnUsuarios.Text = "Tabla Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnclientes
        '
        Me.btnclientes.Location = New System.Drawing.Point(349, 62)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(96, 23)
        Me.btnclientes.TabIndex = 2
        Me.btnclientes.Text = "Tabla Clientes"
        Me.btnclientes.UseVisualStyleBackColor = True
        '
        'btnformaPago
        '
        Me.btnformaPago.Location = New System.Drawing.Point(467, 62)
        Me.btnformaPago.Name = "btnformaPago"
        Me.btnformaPago.Size = New System.Drawing.Size(132, 23)
        Me.btnformaPago.TabIndex = 3
        Me.btnformaPago.Text = "Tabla Formas de Pago"
        Me.btnformaPago.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(338, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(107, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Tabla Listas de Precios"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormPrepararNovedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 205)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnformaPago)
        Me.Controls.Add(Me.btnclientes)
        Me.Controls.Add(Me.btnUsuarios)
        Me.Controls.Add(Me.btnArticulos)
        Me.Name = "FormPrepararNovedades"
        Me.Text = "Preparar Novedades"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnArticulos As System.Windows.Forms.Button
    Friend WithEvents btnUsuarios As System.Windows.Forms.Button
    Friend WithEvents btnclientes As System.Windows.Forms.Button
    Friend WithEvents btnformaPago As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
