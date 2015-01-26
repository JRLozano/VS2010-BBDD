<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Juego
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
        Me.components = New System.ComponentModel.Container()
        Me.lblOp1 = New System.Windows.Forms.Label()
        Me.TbRes1 = New System.Windows.Forms.TextBox()
        Me.BPause = New System.Windows.Forms.Button()
        Me.mensajes = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblOp1
        '
        Me.lblOp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOp1.Location = New System.Drawing.Point(152, 70)
        Me.lblOp1.Name = "lblOp1"
        Me.lblOp1.Size = New System.Drawing.Size(116, 20)
        Me.lblOp1.TabIndex = 0
        Me.lblOp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TbRes1
        '
        Me.TbRes1.Location = New System.Drawing.Point(274, 70)
        Me.TbRes1.Name = "TbRes1"
        Me.TbRes1.Size = New System.Drawing.Size(100, 20)
        Me.TbRes1.TabIndex = 2
        '
        'BPause
        '
        Me.BPause.Location = New System.Drawing.Point(191, 174)
        Me.BPause.Name = "BPause"
        Me.BPause.Size = New System.Drawing.Size(130, 60)
        Me.BPause.TabIndex = 4
        Me.BPause.Text = "Pausa"
        Me.BPause.UseVisualStyleBackColor = True
        '
        'mensajes
        '
        Me.mensajes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mensajes.Location = New System.Drawing.Point(148, 124)
        Me.mensajes.Name = "mensajes"
        Me.mensajes.Size = New System.Drawing.Size(225, 27)
        Me.mensajes.TabIndex = 5
        Me.mensajes.Text = "Mensajes"
        Me.mensajes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 271)
        Me.Controls.Add(Me.mensajes)
        Me.Controls.Add(Me.BPause)
        Me.Controls.Add(Me.TbRes1)
        Me.Controls.Add(Me.lblOp1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Juego"
        Me.Text = "Juego"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOp1 As System.Windows.Forms.Label
    Friend WithEvents TbRes1 As System.Windows.Forms.TextBox
    Friend WithEvents BPause As System.Windows.Forms.Button
    Friend WithEvents mensajes As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
