﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarClientesNew
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btncontinua = New System.Windows.Forms.Button()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdcerrar = New System.Windows.Forms.Button()
        Me.cmdeliminar = New System.Windows.Forms.Button()
        Me.cmdmodificar = New System.Windows.Forms.Button()
        Me.cmdagregar = New System.Windows.Forms.Button()
        Me.GrillaClientes = New System.Windows.Forms.DataGridView()
        Me.cli_idcliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cli_razonsocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrillaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(807, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Volver Busqueda"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btncontinua
        '
        Me.btncontinua.Location = New System.Drawing.Point(807, 42)
        Me.btncontinua.Name = "btncontinua"
        Me.btncontinua.Size = New System.Drawing.Size(134, 23)
        Me.btncontinua.TabIndex = 6
        Me.btncontinua.Text = "Continúa Buscando"
        Me.btncontinua.UseVisualStyleBackColor = True
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(349, 28)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(430, 20)
        Me.txtdescripcion.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(88, 28)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(149, 20)
        Me.txtCodigo.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btncontinua)
        Me.GroupBox1.Controls.Add(Me.txtdescripcion)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(987, 70)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda de articulos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(259, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'cmdcerrar
        '
        Me.cmdcerrar.Location = New System.Drawing.Point(437, 443)
        Me.cmdcerrar.Name = "cmdcerrar"
        Me.cmdcerrar.Size = New System.Drawing.Size(85, 24)
        Me.cmdcerrar.TabIndex = 18
        Me.cmdcerrar.Text = "Cerrar"
        Me.cmdcerrar.UseVisualStyleBackColor = True
        '
        'cmdeliminar
        '
        Me.cmdeliminar.Location = New System.Drawing.Point(937, 291)
        Me.cmdeliminar.Name = "cmdeliminar"
        Me.cmdeliminar.Size = New System.Drawing.Size(85, 25)
        Me.cmdeliminar.TabIndex = 17
        Me.cmdeliminar.Text = "Eliminar"
        Me.cmdeliminar.UseVisualStyleBackColor = True
        '
        'cmdmodificar
        '
        Me.cmdmodificar.Location = New System.Drawing.Point(937, 251)
        Me.cmdmodificar.Name = "cmdmodificar"
        Me.cmdmodificar.Size = New System.Drawing.Size(85, 25)
        Me.cmdmodificar.TabIndex = 16
        Me.cmdmodificar.Text = "Modificar"
        Me.cmdmodificar.UseVisualStyleBackColor = True
        '
        'cmdagregar
        '
        Me.cmdagregar.Location = New System.Drawing.Point(937, 210)
        Me.cmdagregar.MaximumSize = New System.Drawing.Size(1200, 400)
        Me.cmdagregar.Name = "cmdagregar"
        Me.cmdagregar.Size = New System.Drawing.Size(85, 25)
        Me.cmdagregar.TabIndex = 15
        Me.cmdagregar.Text = "Agregar"
        Me.cmdagregar.UseVisualStyleBackColor = True
        '
        'GrillaClientes
        '
        Me.GrillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cli_idcliente, Me.cli_razonsocial})
        Me.GrillaClientes.Location = New System.Drawing.Point(12, 101)
        Me.GrillaClientes.Name = "GrillaClientes"
        Me.GrillaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaClientes.Size = New System.Drawing.Size(848, 303)
        Me.GrillaClientes.TabIndex = 14
        '
        'cli_idcliente
        '
        Me.cli_idcliente.HeaderText = "Nro.Cliente"
        Me.cli_idcliente.Name = "cli_idcliente"
        '
        'cli_razonsocial
        '
        Me.cli_razonsocial.HeaderText = "Razón Social"
        Me.cli_razonsocial.Name = "cli_razonsocial"
        Me.cli_razonsocial.Width = 500
        '
        'FormBuscarClientesNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 491)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdcerrar)
        Me.Controls.Add(Me.cmdeliminar)
        Me.Controls.Add(Me.cmdmodificar)
        Me.Controls.Add(Me.cmdagregar)
        Me.Controls.Add(Me.GrillaClientes)
        Me.Name = "FormBuscarClientesNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Búsqueda de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GrillaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btncontinua As System.Windows.Forms.Button
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdcerrar As System.Windows.Forms.Button
    Friend WithEvents cmdeliminar As System.Windows.Forms.Button
    Friend WithEvents cmdmodificar As System.Windows.Forms.Button
    Friend WithEvents cmdagregar As System.Windows.Forms.Button
    Friend WithEvents GrillaClientes As System.Windows.Forms.DataGridView
    Friend WithEvents cli_idcliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cli_razonsocial As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
