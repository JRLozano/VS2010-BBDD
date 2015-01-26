<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.lblNick = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.TbPass = New System.Windows.Forms.TextBox()
        Me.RBReg = New System.Windows.Forms.RadioButton()
        Me.RBIdent = New System.Windows.Forms.RadioButton()
        Me.BEntrar = New System.Windows.Forms.Button()
        Me.CBUsers = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblNick
        '
        Me.lblNick.AutoSize = True
        Me.lblNick.Location = New System.Drawing.Point(45, 54)
        Me.lblNick.Name = "lblNick"
        Me.lblNick.Size = New System.Drawing.Size(43, 13)
        Me.lblNick.TabIndex = 0
        Me.lblNick.Text = "Usuario"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(45, 82)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(61, 13)
        Me.lblPass.TabIndex = 1
        Me.lblPass.Text = "Contraseña"
        '
        'TbPass
        '
        Me.TbPass.Location = New System.Drawing.Point(120, 79)
        Me.TbPass.Name = "TbPass"
        Me.TbPass.Size = New System.Drawing.Size(100, 20)
        Me.TbPass.TabIndex = 3
        Me.TbPass.UseSystemPasswordChar = True
        '
        'RBReg
        '
        Me.RBReg.AutoSize = True
        Me.RBReg.Location = New System.Drawing.Point(101, 123)
        Me.RBReg.Name = "RBReg"
        Me.RBReg.Size = New System.Drawing.Size(78, 17)
        Me.RBReg.TabIndex = 4
        Me.RBReg.TabStop = True
        Me.RBReg.Text = "Registrarse"
        Me.RBReg.UseVisualStyleBackColor = True
        '
        'RBIdent
        '
        Me.RBIdent.AutoSize = True
        Me.RBIdent.Location = New System.Drawing.Point(101, 146)
        Me.RBIdent.Name = "RBIdent"
        Me.RBIdent.Size = New System.Drawing.Size(82, 17)
        Me.RBIdent.TabIndex = 5
        Me.RBIdent.TabStop = True
        Me.RBIdent.Text = "Identificarse"
        Me.RBIdent.UseVisualStyleBackColor = True
        '
        'BEntrar
        '
        Me.BEntrar.Location = New System.Drawing.Point(104, 182)
        Me.BEntrar.Name = "BEntrar"
        Me.BEntrar.Size = New System.Drawing.Size(75, 23)
        Me.BEntrar.TabIndex = 6
        Me.BEntrar.Text = "Entrar"
        Me.BEntrar.UseVisualStyleBackColor = True
        '
        'CBUsers
        '
        Me.CBUsers.FormattingEnabled = True
        Me.CBUsers.Location = New System.Drawing.Point(120, 46)
        Me.CBUsers.Name = "CBUsers"
        Me.CBUsers.Size = New System.Drawing.Size(100, 21)
        Me.CBUsers.TabIndex = 7
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.CBUsers)
        Me.Controls.Add(Me.BEntrar)
        Me.Controls.Add(Me.RBIdent)
        Me.Controls.Add(Me.RBReg)
        Me.Controls.Add(Me.TbPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblNick)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Registro"
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNick As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents TbPass As System.Windows.Forms.TextBox
    Friend WithEvents RBReg As System.Windows.Forms.RadioButton
    Friend WithEvents RBIdent As System.Windows.Forms.RadioButton
    Friend WithEvents BEntrar As System.Windows.Forms.Button
    Friend WithEvents CBUsers As System.Windows.Forms.ComboBox
End Class
