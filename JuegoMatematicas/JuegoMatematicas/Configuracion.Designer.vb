<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
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
        Me.lblTime = New System.Windows.Forms.Label()
        Me.GBDiff = New System.Windows.Forms.GroupBox()
        Me.RBdPers = New System.Windows.Forms.RadioButton()
        Me.RBdHard = New System.Windows.Forms.RadioButton()
        Me.RBdEasy = New System.Windows.Forms.RadioButton()
        Me.RBdMed = New System.Windows.Forms.RadioButton()
        Me.GBOps = New System.Windows.Forms.GroupBox()
        Me.CBoPot = New System.Windows.Forms.CheckBox()
        Me.CBoDiv = New System.Windows.Forms.CheckBox()
        Me.CBoMult = New System.Windows.Forms.CheckBox()
        Me.CBoSubs = New System.Windows.Forms.CheckBox()
        Me.CBoSum = New System.Windows.Forms.CheckBox()
        Me.BPlay = New System.Windows.Forms.Button()
        Me.TbTime = New System.Windows.Forms.TextBox()
        Me.CBotDecs = New System.Windows.Forms.CheckBox()
        Me.CBotNegat = New System.Windows.Forms.CheckBox()
        Me.GBOtros = New System.Windows.Forms.GroupBox()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.TbMin = New System.Windows.Forms.TextBox()
        Me.TbMax = New System.Windows.Forms.TextBox()
        Me.BAtras = New System.Windows.Forms.Button()
        Me.GBDiff.SuspendLayout()
        Me.GBOps.SuspendLayout()
        Me.GBOtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(312, 164)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(64, 13)
        Me.lblTime.TabIndex = 4
        Me.lblTime.Text = "Tiempo(min)"
        '
        'GBDiff
        '
        Me.GBDiff.Controls.Add(Me.RBdPers)
        Me.GBDiff.Controls.Add(Me.RBdHard)
        Me.GBDiff.Controls.Add(Me.RBdEasy)
        Me.GBDiff.Controls.Add(Me.RBdMed)
        Me.GBDiff.Location = New System.Drawing.Point(38, 33)
        Me.GBDiff.Name = "GBDiff"
        Me.GBDiff.Size = New System.Drawing.Size(101, 110)
        Me.GBDiff.TabIndex = 1
        Me.GBDiff.TabStop = False
        Me.GBDiff.Text = "Dificultad"
        '
        'RBdPers
        '
        Me.RBdPers.AutoSize = True
        Me.RBdPers.Location = New System.Drawing.Point(5, 86)
        Me.RBdPers.Name = "RBdPers"
        Me.RBdPers.Size = New System.Drawing.Size(91, 17)
        Me.RBdPers.TabIndex = 3
        Me.RBdPers.TabStop = True
        Me.RBdPers.Tag = "4"
        Me.RBdPers.Text = "Personalizado"
        Me.RBdPers.UseVisualStyleBackColor = True
        '
        'RBdHard
        '
        Me.RBdHard.AutoSize = True
        Me.RBdHard.Location = New System.Drawing.Point(4, 65)
        Me.RBdHard.Name = "RBdHard"
        Me.RBdHard.Size = New System.Drawing.Size(50, 17)
        Me.RBdHard.TabIndex = 2
        Me.RBdHard.TabStop = True
        Me.RBdHard.Tag = "3"
        Me.RBdHard.Text = "Dificil"
        Me.RBdHard.UseVisualStyleBackColor = True
        '
        'RBdEasy
        '
        Me.RBdEasy.AutoSize = True
        Me.RBdEasy.Location = New System.Drawing.Point(5, 19)
        Me.RBdEasy.Name = "RBdEasy"
        Me.RBdEasy.Size = New System.Drawing.Size(47, 17)
        Me.RBdEasy.TabIndex = 0
        Me.RBdEasy.TabStop = True
        Me.RBdEasy.Tag = "1"
        Me.RBdEasy.Text = "Facil"
        Me.RBdEasy.UseVisualStyleBackColor = True
        '
        'RBdMed
        '
        Me.RBdMed.AutoSize = True
        Me.RBdMed.Location = New System.Drawing.Point(5, 42)
        Me.RBdMed.Name = "RBdMed"
        Me.RBdMed.Size = New System.Drawing.Size(54, 17)
        Me.RBdMed.TabIndex = 1
        Me.RBdMed.TabStop = True
        Me.RBdMed.Tag = "2"
        Me.RBdMed.Text = "Medio"
        Me.RBdMed.UseVisualStyleBackColor = True
        '
        'GBOps
        '
        Me.GBOps.Controls.Add(Me.CBoPot)
        Me.GBOps.Controls.Add(Me.CBoDiv)
        Me.GBOps.Controls.Add(Me.CBoMult)
        Me.GBOps.Controls.Add(Me.CBoSubs)
        Me.GBOps.Controls.Add(Me.CBoSum)
        Me.GBOps.Location = New System.Drawing.Point(164, 33)
        Me.GBOps.Name = "GBOps"
        Me.GBOps.Size = New System.Drawing.Size(121, 133)
        Me.GBOps.TabIndex = 2
        Me.GBOps.TabStop = False
        Me.GBOps.Text = "Operaciones"
        '
        'CBoPot
        '
        Me.CBoPot.AutoSize = True
        Me.CBoPot.Location = New System.Drawing.Point(6, 110)
        Me.CBoPot.Name = "CBoPot"
        Me.CBoPot.Size = New System.Drawing.Size(73, 17)
        Me.CBoPot.TabIndex = 8
        Me.CBoPot.Tag = "4"
        Me.CBoPot.Text = "Potencias"
        Me.CBoPot.UseVisualStyleBackColor = True
        '
        'CBoDiv
        '
        Me.CBoDiv.AutoSize = True
        Me.CBoDiv.Location = New System.Drawing.Point(6, 87)
        Me.CBoDiv.Name = "CBoDiv"
        Me.CBoDiv.Size = New System.Drawing.Size(74, 17)
        Me.CBoDiv.TabIndex = 7
        Me.CBoDiv.Tag = "3"
        Me.CBoDiv.Text = "Divisiones"
        Me.CBoDiv.UseVisualStyleBackColor = True
        '
        'CBoMult
        '
        Me.CBoMult.AutoSize = True
        Me.CBoMult.Location = New System.Drawing.Point(6, 65)
        Me.CBoMult.Name = "CBoMult"
        Me.CBoMult.Size = New System.Drawing.Size(101, 17)
        Me.CBoMult.TabIndex = 6
        Me.CBoMult.Tag = "2"
        Me.CBoMult.Text = "Multiplicaciones"
        Me.CBoMult.UseVisualStyleBackColor = True
        '
        'CBoSubs
        '
        Me.CBoSubs.AutoSize = True
        Me.CBoSubs.Location = New System.Drawing.Point(6, 42)
        Me.CBoSubs.Name = "CBoSubs"
        Me.CBoSubs.Size = New System.Drawing.Size(59, 17)
        Me.CBoSubs.TabIndex = 5
        Me.CBoSubs.Tag = "1"
        Me.CBoSubs.Text = "Restas"
        Me.CBoSubs.UseVisualStyleBackColor = True
        '
        'CBoSum
        '
        Me.CBoSum.AutoSize = True
        Me.CBoSum.Location = New System.Drawing.Point(6, 19)
        Me.CBoSum.Name = "CBoSum"
        Me.CBoSum.Size = New System.Drawing.Size(58, 17)
        Me.CBoSum.TabIndex = 4
        Me.CBoSum.Tag = "0"
        Me.CBoSum.Text = "Sumas"
        Me.CBoSum.UseVisualStyleBackColor = True
        '
        'BPlay
        '
        Me.BPlay.Location = New System.Drawing.Point(345, 198)
        Me.BPlay.Name = "BPlay"
        Me.BPlay.Size = New System.Drawing.Size(123, 51)
        Me.BPlay.TabIndex = 14
        Me.BPlay.Text = "Comenzar"
        Me.BPlay.UseVisualStyleBackColor = True
        '
        'TbTime
        '
        Me.TbTime.Location = New System.Drawing.Point(394, 162)
        Me.TbTime.Name = "TbTime"
        Me.TbTime.Size = New System.Drawing.Size(100, 20)
        Me.TbTime.TabIndex = 13
        '
        'CBotDecs
        '
        Me.CBotDecs.AutoSize = True
        Me.CBotDecs.Location = New System.Drawing.Point(6, 19)
        Me.CBotDecs.Name = "CBotDecs"
        Me.CBotDecs.Size = New System.Drawing.Size(75, 17)
        Me.CBotDecs.TabIndex = 9
        Me.CBotDecs.Text = "Decimales"
        Me.CBotDecs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.CBotDecs.UseVisualStyleBackColor = True
        '
        'CBotNegat
        '
        Me.CBotNegat.AutoSize = True
        Me.CBotNegat.Location = New System.Drawing.Point(6, 42)
        Me.CBotNegat.Name = "CBotNegat"
        Me.CBotNegat.Size = New System.Drawing.Size(119, 17)
        Me.CBotNegat.TabIndex = 10
        Me.CBotNegat.Text = "Numeros Negativos"
        Me.CBotNegat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.CBotNegat.UseVisualStyleBackColor = True
        '
        'GBOtros
        '
        Me.GBOtros.Controls.Add(Me.CBotDecs)
        Me.GBOtros.Controls.Add(Me.CBotNegat)
        Me.GBOtros.Location = New System.Drawing.Point(309, 33)
        Me.GBOtros.Name = "GBOtros"
        Me.GBOtros.Size = New System.Drawing.Size(128, 64)
        Me.GBOtros.TabIndex = 3
        Me.GBOtros.TabStop = False
        Me.GBOtros.Text = "Otros"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(312, 141)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(76, 13)
        Me.lblMax.TabIndex = 16
        Me.lblMax.Text = "Limite Superior"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Location = New System.Drawing.Point(312, 119)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(69, 13)
        Me.lblMin.TabIndex = 17
        Me.lblMin.Text = "Limite Inferior"
        '
        'TbMin
        '
        Me.TbMin.Location = New System.Drawing.Point(394, 116)
        Me.TbMin.Name = "TbMin"
        Me.TbMin.Size = New System.Drawing.Size(100, 20)
        Me.TbMin.TabIndex = 11
        '
        'TbMax
        '
        Me.TbMax.Location = New System.Drawing.Point(394, 138)
        Me.TbMax.Name = "TbMax"
        Me.TbMax.Size = New System.Drawing.Size(100, 20)
        Me.TbMax.TabIndex = 12
        '
        'BAtras
        '
        Me.BAtras.Location = New System.Drawing.Point(43, 198)
        Me.BAtras.Name = "BAtras"
        Me.BAtras.Size = New System.Drawing.Size(123, 51)
        Me.BAtras.TabIndex = 15
        Me.BAtras.Text = "Atras"
        Me.BAtras.UseVisualStyleBackColor = True
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 271)
        Me.Controls.Add(Me.BAtras)
        Me.Controls.Add(Me.TbMax)
        Me.Controls.Add(Me.TbMin)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.GBOtros)
        Me.Controls.Add(Me.TbTime)
        Me.Controls.Add(Me.BPlay)
        Me.Controls.Add(Me.GBOps)
        Me.Controls.Add(Me.GBDiff)
        Me.Controls.Add(Me.lblTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Configuracion"
        Me.Text = "Configuración"
        Me.GBDiff.ResumeLayout(False)
        Me.GBDiff.PerformLayout()
        Me.GBOps.ResumeLayout(False)
        Me.GBOps.PerformLayout()
        Me.GBOtros.ResumeLayout(False)
        Me.GBOtros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents GBDiff As System.Windows.Forms.GroupBox
    Friend WithEvents GBOps As System.Windows.Forms.GroupBox
    Friend WithEvents BPlay As System.Windows.Forms.Button
    Friend WithEvents CBoPot As System.Windows.Forms.CheckBox
    Friend WithEvents CBoDiv As System.Windows.Forms.CheckBox
    Friend WithEvents CBoMult As System.Windows.Forms.CheckBox
    Friend WithEvents CBoSubs As System.Windows.Forms.CheckBox
    Friend WithEvents CBoSum As System.Windows.Forms.CheckBox
    Friend WithEvents TbTime As System.Windows.Forms.TextBox
    Friend WithEvents CBotDecs As System.Windows.Forms.CheckBox
    Friend WithEvents CBotNegat As System.Windows.Forms.CheckBox
    Friend WithEvents GBOtros As System.Windows.Forms.GroupBox
    Friend WithEvents RBdHard As System.Windows.Forms.RadioButton
    Friend WithEvents RBdMed As System.Windows.Forms.RadioButton
    Friend WithEvents RBdEasy As System.Windows.Forms.RadioButton
    Friend WithEvents RBdPers As System.Windows.Forms.RadioButton
    Friend WithEvents lblMax As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents TbMin As System.Windows.Forms.TextBox
    Friend WithEvents TbMax As System.Windows.Forms.TextBox
    Friend WithEvents BAtras As System.Windows.Forms.Button
End Class
