<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tittle
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
        Me.BPlay = New System.Windows.Forms.Button()
        Me.BTop = New System.Windows.Forms.Button()
        Me.BHelp = New System.Windows.Forms.Button()
        Me.BExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BPlay
        '
        Me.BPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BPlay.Location = New System.Drawing.Point(200, 30)
        Me.BPlay.Name = "BPlay"
        Me.BPlay.Size = New System.Drawing.Size(130, 50)
        Me.BPlay.TabIndex = 1
        Me.BPlay.Text = "Jugar"
        Me.BPlay.UseVisualStyleBackColor = True
        '
        'BTop
        '
        Me.BTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTop.Location = New System.Drawing.Point(200, 86)
        Me.BTop.Name = "BTop"
        Me.BTop.Size = New System.Drawing.Size(130, 50)
        Me.BTop.TabIndex = 2
        Me.BTop.Text = "Puntuaciones"
        Me.BTop.UseVisualStyleBackColor = True
        '
        'BHelp
        '
        Me.BHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BHelp.Location = New System.Drawing.Point(200, 142)
        Me.BHelp.Name = "BHelp"
        Me.BHelp.Size = New System.Drawing.Size(130, 50)
        Me.BHelp.TabIndex = 3
        Me.BHelp.Text = "Ayuda"
        Me.BHelp.UseVisualStyleBackColor = True
        '
        'BExit
        '
        Me.BExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BExit.Location = New System.Drawing.Point(200, 198)
        Me.BExit.Name = "BExit"
        Me.BExit.Size = New System.Drawing.Size(130, 50)
        Me.BExit.TabIndex = 4
        Me.BExit.Text = "Salir"
        Me.BExit.UseVisualStyleBackColor = True
        '
        'Tittle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 271)
        Me.Controls.Add(Me.BExit)
        Me.Controls.Add(Me.BHelp)
        Me.Controls.Add(Me.BTop)
        Me.Controls.Add(Me.BPlay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Tittle"
        Me.Text = "Festival Matemático"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BPlay As System.Windows.Forms.Button
    Friend WithEvents BTop As System.Windows.Forms.Button
    Friend WithEvents BHelp As System.Windows.Forms.Button
    Friend WithEvents BExit As System.Windows.Forms.Button

End Class
