<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImprimePAgo
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
        Me.Cr = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Cr
        '
        Me.Cr.ActiveViewIndex = -1
        Me.Cr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cr.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cr.Location = New System.Drawing.Point(0, 0)
        Me.Cr.Name = "Cr"
        Me.Cr.Size = New System.Drawing.Size(747, 433)
        Me.Cr.TabIndex = 1
        '
        'FormImprimePago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 433)
        Me.Controls.Add(Me.Cr)
        Me.Name = "FormImprimePago"
        Me.Text = "FormImprimePago"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cr As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rpt As New PagosProveedores
End Class
