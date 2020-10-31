<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsEmulatorsWindow
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CheckBoxAtariLo = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAtari = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC128 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC64 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVic2024 = New System.Windows.Forms.CheckBox()
        Me.ButtonFromGlobal = New System.Windows.Forms.Button()
        Me.ButtonRestore = New System.Windows.Forms.Button()
        Me.ButtonApply = New System.Windows.Forms.Button()
        Me.CheckBoxVic20 = New System.Windows.Forms.CheckBox()
        Me.TabControlOptions = New System.Windows.Forms.TabControl()
        Me.TabPageEmulators = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxYAPEPath = New System.Windows.Forms.TextBox()
        Me.CheckBoxYAPE = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxATARI800Path = New System.Windows.Forms.TextBox()
        Me.CheckBoxATARI800 = New System.Windows.Forms.CheckBox()
        Me.TextBoxALTIRRAPath = New System.Windows.Forms.TextBox()
        Me.CheckBoxALTIRRA = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVICE = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxVICEPath = New System.Windows.Forms.TextBox()
        Me.TabPageCC65 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonC99 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonC89 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCC65 = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxC16 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPlus4 = New System.Windows.Forms.CheckBox()
        Me.ButtonFromProject = New System.Windows.Forms.Button()
        Me.TabControlOptions.SuspendLayout()
        Me.TabPageEmulators.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPageCC65.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBoxAtariLo
        '
        Me.CheckBoxAtariLo.AutoSize = True
        Me.CheckBoxAtariLo.Location = New System.Drawing.Point(231, 27)
        Me.CheckBoxAtariLo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxAtariLo.Name = "CheckBoxAtariLo"
        Me.CheckBoxAtariLo.Size = New System.Drawing.Size(145, 24)
        Me.CheckBoxAtariLo.TabIndex = 18
        Me.CheckBoxAtariLo.Text = "Atari (8 bit) [low]"
        Me.CheckBoxAtariLo.UseVisualStyleBackColor = True
        '
        'CheckBoxAtari
        '
        Me.CheckBoxAtari.AutoSize = True
        Me.CheckBoxAtari.Location = New System.Drawing.Point(231, 59)
        Me.CheckBoxAtari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxAtari.Name = "CheckBoxAtari"
        Me.CheckBoxAtari.Size = New System.Drawing.Size(107, 24)
        Me.CheckBoxAtari.TabIndex = 17
        Me.CheckBoxAtari.Text = "Atari (8 bit)"
        Me.CheckBoxAtari.UseVisualStyleBackColor = True
        '
        'CheckBoxC128
        '
        Me.CheckBoxC128.AutoSize = True
        Me.CheckBoxC128.Location = New System.Drawing.Point(136, 91)
        Me.CheckBoxC128.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxC128.Name = "CheckBoxC128"
        Me.CheckBoxC128.Size = New System.Drawing.Size(64, 24)
        Me.CheckBoxC128.TabIndex = 16
        Me.CheckBoxC128.Text = "C128"
        Me.CheckBoxC128.UseVisualStyleBackColor = True
        '
        'CheckBoxC64
        '
        Me.CheckBoxC64.AutoSize = True
        Me.CheckBoxC64.Location = New System.Drawing.Point(136, 59)
        Me.CheckBoxC64.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxC64.Name = "CheckBoxC64"
        Me.CheckBoxC64.Size = New System.Drawing.Size(56, 24)
        Me.CheckBoxC64.TabIndex = 15
        Me.CheckBoxC64.Text = "C64"
        Me.CheckBoxC64.UseVisualStyleBackColor = True
        '
        'CheckBoxVic2024
        '
        Me.CheckBoxVic2024.AutoSize = True
        Me.CheckBoxVic2024.Location = New System.Drawing.Point(9, 91)
        Me.CheckBoxVic2024.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxVic2024.Name = "CheckBoxVic2024"
        Me.CheckBoxVic2024.Size = New System.Drawing.Size(127, 24)
        Me.CheckBoxVic2024.TabIndex = 14
        Me.CheckBoxVic2024.Text = "VIC-20 (24 KB)"
        Me.CheckBoxVic2024.UseVisualStyleBackColor = True
        '
        'ButtonFromGlobal
        '
        Me.ButtonFromGlobal.Location = New System.Drawing.Point(313, 234)
        Me.ButtonFromGlobal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonFromGlobal.Name = "ButtonFromGlobal"
        Me.ButtonFromGlobal.Size = New System.Drawing.Size(125, 44)
        Me.ButtonFromGlobal.TabIndex = 9
        Me.ButtonFromGlobal.Text = "From Global"
        Me.ButtonFromGlobal.UseVisualStyleBackColor = True
        '
        'ButtonRestore
        '
        Me.ButtonRestore.Location = New System.Drawing.Point(3, 234)
        Me.ButtonRestore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonRestore.Name = "ButtonRestore"
        Me.ButtonRestore.Size = New System.Drawing.Size(125, 44)
        Me.ButtonRestore.TabIndex = 7
        Me.ButtonRestore.Text = "Restore"
        Me.ButtonRestore.UseVisualStyleBackColor = True
        '
        'ButtonApply
        '
        Me.ButtonApply.Location = New System.Drawing.Point(583, 234)
        Me.ButtonApply.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonApply.Name = "ButtonApply"
        Me.ButtonApply.Size = New System.Drawing.Size(125, 44)
        Me.ButtonApply.TabIndex = 6
        Me.ButtonApply.Text = "Apply"
        Me.ButtonApply.UseVisualStyleBackColor = True
        '
        'CheckBoxVic20
        '
        Me.CheckBoxVic20.AutoSize = True
        Me.CheckBoxVic20.Location = New System.Drawing.Point(9, 59)
        Me.CheckBoxVic20.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxVic20.Name = "CheckBoxVic20"
        Me.CheckBoxVic20.Size = New System.Drawing.Size(75, 24)
        Me.CheckBoxVic20.TabIndex = 13
        Me.CheckBoxVic20.Text = "VIC-20"
        Me.CheckBoxVic20.UseVisualStyleBackColor = True
        '
        'TabControlOptions
        '
        Me.TabControlOptions.Controls.Add(Me.TabPageEmulators)
        Me.TabControlOptions.Controls.Add(Me.TabPageCC65)
        Me.TabControlOptions.Location = New System.Drawing.Point(6, 6)
        Me.TabControlOptions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlOptions.Name = "TabControlOptions"
        Me.TabControlOptions.SelectedIndex = 0
        Me.TabControlOptions.Size = New System.Drawing.Size(707, 221)
        Me.TabControlOptions.TabIndex = 5
        '
        'TabPageEmulators
        '
        Me.TabPageEmulators.Controls.Add(Me.GroupBox1)
        Me.TabPageEmulators.Location = New System.Drawing.Point(4, 29)
        Me.TabPageEmulators.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageEmulators.Name = "TabPageEmulators"
        Me.TabPageEmulators.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageEmulators.Size = New System.Drawing.Size(699, 188)
        Me.TabPageEmulators.TabIndex = 0
        Me.TabPageEmulators.Text = "Emulators"
        Me.TabPageEmulators.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxYAPEPath)
        Me.GroupBox1.Controls.Add(Me.CheckBoxYAPE)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxATARI800Path)
        Me.GroupBox1.Controls.Add(Me.CheckBoxATARI800)
        Me.GroupBox1.Controls.Add(Me.TextBoxALTIRRAPath)
        Me.GroupBox1.Controls.Add(Me.CheckBoxALTIRRA)
        Me.GroupBox1.Controls.Add(Me.CheckBoxVICE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxVICEPath)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 221)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Path"
        '
        'TextBoxYAPEPath
        '
        Me.TextBoxYAPEPath.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxYAPEPath.Location = New System.Drawing.Point(265, 118)
        Me.TextBoxYAPEPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxYAPEPath.Name = "TextBoxYAPEPath"
        Me.TextBoxYAPEPath.Size = New System.Drawing.Size(345, 27)
        Me.TextBoxYAPEPath.TabIndex = 40
        '
        'CheckBoxYAPE
        '
        Me.CheckBoxYAPE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxYAPE.AutoSize = True
        Me.CheckBoxYAPE.Location = New System.Drawing.Point(6, 117)
        Me.CheckBoxYAPE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxYAPE.Name = "CheckBoxYAPE"
        Me.CheckBoxYAPE.Size = New System.Drawing.Size(168, 24)
        Me.CheckBoxYAPE.TabIndex = 39
        Me.CheckBoxYAPE.Text = "Enable YAPE support"
        Me.CheckBoxYAPE.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Path"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Path"
        '
        'TextBoxATARI800Path
        '
        Me.TextBoxATARI800Path.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxATARI800Path.Location = New System.Drawing.Point(265, 86)
        Me.TextBoxATARI800Path.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxATARI800Path.Name = "TextBoxATARI800Path"
        Me.TextBoxATARI800Path.Size = New System.Drawing.Size(345, 27)
        Me.TextBoxATARI800Path.TabIndex = 36
        '
        'CheckBoxATARI800
        '
        Me.CheckBoxATARI800.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxATARI800.AutoSize = True
        Me.CheckBoxATARI800.Location = New System.Drawing.Point(6, 85)
        Me.CheckBoxATARI800.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxATARI800.Name = "CheckBoxATARI800"
        Me.CheckBoxATARI800.Size = New System.Drawing.Size(202, 24)
        Me.CheckBoxATARI800.TabIndex = 35
        Me.CheckBoxATARI800.Text = "Enable ATARI 800 support"
        Me.CheckBoxATARI800.UseVisualStyleBackColor = True
        '
        'TextBoxALTIRRAPath
        '
        Me.TextBoxALTIRRAPath.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxALTIRRAPath.Location = New System.Drawing.Point(265, 54)
        Me.TextBoxALTIRRAPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxALTIRRAPath.Name = "TextBoxALTIRRAPath"
        Me.TextBoxALTIRRAPath.Size = New System.Drawing.Size(345, 27)
        Me.TextBoxALTIRRAPath.TabIndex = 34
        '
        'CheckBoxALTIRRA
        '
        Me.CheckBoxALTIRRA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxALTIRRA.AutoSize = True
        Me.CheckBoxALTIRRA.Location = New System.Drawing.Point(6, 54)
        Me.CheckBoxALTIRRA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxALTIRRA.Name = "CheckBoxALTIRRA"
        Me.CheckBoxALTIRRA.Size = New System.Drawing.Size(191, 24)
        Me.CheckBoxALTIRRA.TabIndex = 33
        Me.CheckBoxALTIRRA.Text = "Enable ALTIRRA support"
        Me.CheckBoxALTIRRA.UseVisualStyleBackColor = True
        '
        'CheckBoxVICE
        '
        Me.CheckBoxVICE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxVICE.AutoSize = True
        Me.CheckBoxVICE.Location = New System.Drawing.Point(6, 25)
        Me.CheckBoxVICE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxVICE.Name = "CheckBoxVICE"
        Me.CheckBoxVICE.Size = New System.Drawing.Size(165, 24)
        Me.CheckBoxVICE.TabIndex = 30
        Me.CheckBoxVICE.Text = "Enable VICE support"
        Me.CheckBoxVICE.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(221, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Path"
        '
        'TextBoxVICEPath
        '
        Me.TextBoxVICEPath.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxVICEPath.Location = New System.Drawing.Point(265, 23)
        Me.TextBoxVICEPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxVICEPath.Name = "TextBoxVICEPath"
        Me.TextBoxVICEPath.Size = New System.Drawing.Size(345, 27)
        Me.TextBoxVICEPath.TabIndex = 32
        '
        'TabPageCC65
        '
        Me.TabPageCC65.Controls.Add(Me.GroupBox2)
        Me.TabPageCC65.Location = New System.Drawing.Point(4, 29)
        Me.TabPageCC65.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageCC65.Name = "TabPageCC65"
        Me.TabPageCC65.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageCC65.Size = New System.Drawing.Size(699, 188)
        Me.TabPageCC65.TabIndex = 1
        Me.TabPageCC65.Text = "Targets"
        Me.TabPageCC65.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(676, 160)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.RadioButtonC99)
        Me.GroupBox7.Controls.Add(Me.RadioButtonC89)
        Me.GroupBox7.Controls.Add(Me.RadioButtonCC65)
        Me.GroupBox7.Location = New System.Drawing.Point(391, 14)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(279, 122)
        Me.GroupBox7.TabIndex = 12
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "C language level"
        '
        'RadioButtonC99
        '
        Me.RadioButtonC99.AutoSize = True
        Me.RadioButtonC99.Location = New System.Drawing.Point(6, 81)
        Me.RadioButtonC99.Name = "RadioButtonC99"
        Me.RadioButtonC99.Size = New System.Drawing.Size(55, 24)
        Me.RadioButtonC99.TabIndex = 2
        Me.RadioButtonC99.TabStop = True
        Me.RadioButtonC99.Text = "C99"
        Me.RadioButtonC99.UseVisualStyleBackColor = True
        '
        'RadioButtonC89
        '
        Me.RadioButtonC89.AutoSize = True
        Me.RadioButtonC89.Location = New System.Drawing.Point(6, 51)
        Me.RadioButtonC89.Name = "RadioButtonC89"
        Me.RadioButtonC89.Size = New System.Drawing.Size(55, 24)
        Me.RadioButtonC89.TabIndex = 1
        Me.RadioButtonC89.TabStop = True
        Me.RadioButtonC89.Text = "C89"
        Me.RadioButtonC89.UseVisualStyleBackColor = True
        '
        'RadioButtonCC65
        '
        Me.RadioButtonCC65.AutoSize = True
        Me.RadioButtonCC65.Location = New System.Drawing.Point(6, 21)
        Me.RadioButtonCC65.Name = "RadioButtonCC65"
        Me.RadioButtonCC65.Size = New System.Drawing.Size(64, 24)
        Me.RadioButtonCC65.TabIndex = 0
        Me.RadioButtonCC65.TabStop = True
        Me.RadioButtonCC65.Text = "CC65"
        Me.RadioButtonCC65.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CheckBoxAtariLo)
        Me.GroupBox6.Controls.Add(Me.CheckBoxAtari)
        Me.GroupBox6.Controls.Add(Me.CheckBoxC128)
        Me.GroupBox6.Controls.Add(Me.CheckBoxC64)
        Me.GroupBox6.Controls.Add(Me.CheckBoxVic2024)
        Me.GroupBox6.Controls.Add(Me.CheckBoxVic20)
        Me.GroupBox6.Controls.Add(Me.CheckBoxC16)
        Me.GroupBox6.Controls.Add(Me.CheckBoxPlus4)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 14)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(379, 122)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Enabled targets"
        '
        'CheckBoxC16
        '
        Me.CheckBoxC16.AutoSize = True
        Me.CheckBoxC16.Location = New System.Drawing.Point(9, 27)
        Me.CheckBoxC16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxC16.Name = "CheckBoxC16"
        Me.CheckBoxC16.Size = New System.Drawing.Size(56, 24)
        Me.CheckBoxC16.TabIndex = 12
        Me.CheckBoxC16.Text = "C16"
        Me.CheckBoxC16.UseVisualStyleBackColor = True
        '
        'CheckBoxPlus4
        '
        Me.CheckBoxPlus4.AutoSize = True
        Me.CheckBoxPlus4.Location = New System.Drawing.Point(136, 27)
        Me.CheckBoxPlus4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxPlus4.Name = "CheckBoxPlus4"
        Me.CheckBoxPlus4.Size = New System.Drawing.Size(78, 24)
        Me.CheckBoxPlus4.TabIndex = 11
        Me.CheckBoxPlus4.Text = "PLUS/4"
        Me.CheckBoxPlus4.UseVisualStyleBackColor = True
        '
        'ButtonFromProject
        '
        Me.ButtonFromProject.Location = New System.Drawing.Point(448, 234)
        Me.ButtonFromProject.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonFromProject.Name = "ButtonFromProject"
        Me.ButtonFromProject.Size = New System.Drawing.Size(125, 44)
        Me.ButtonFromProject.TabIndex = 8
        Me.ButtonFromProject.Text = "From Project"
        Me.ButtonFromProject.UseVisualStyleBackColor = True
        '
        'OptionsEmulatorsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 282)
        Me.Controls.Add(Me.ButtonFromGlobal)
        Me.Controls.Add(Me.ButtonRestore)
        Me.Controls.Add(Me.ButtonApply)
        Me.Controls.Add(Me.TabControlOptions)
        Me.Controls.Add(Me.ButtonFromProject)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OptionsEmulatorsWindow"
        Me.Text = "OptionsEmulatorsWindow"
        Me.TabControlOptions.ResumeLayout(False)
        Me.TabPageEmulators.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPageCC65.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CheckBoxAtariLo As CheckBox
    Friend WithEvents CheckBoxAtari As CheckBox
    Friend WithEvents CheckBoxC128 As CheckBox
    Friend WithEvents CheckBoxC64 As CheckBox
    Friend WithEvents CheckBoxVic2024 As CheckBox
    Friend WithEvents ButtonFromGlobal As Button
    Friend WithEvents ButtonRestore As Button
    Friend WithEvents ButtonApply As Button
    Friend WithEvents CheckBoxVic20 As CheckBox
    Friend WithEvents TabControlOptions As TabControl
    Friend WithEvents TabPageEmulators As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxYAPEPath As TextBox
    Friend WithEvents CheckBoxYAPE As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxATARI800Path As TextBox
    Friend WithEvents CheckBoxATARI800 As CheckBox
    Friend WithEvents TextBoxALTIRRAPath As TextBox
    Friend WithEvents CheckBoxALTIRRA As CheckBox
    Friend WithEvents CheckBoxVICE As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxVICEPath As TextBox
    Friend WithEvents TabPageCC65 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents RadioButtonC99 As RadioButton
    Friend WithEvents RadioButtonC89 As RadioButton
    Friend WithEvents RadioButtonCC65 As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CheckBoxC16 As CheckBox
    Friend WithEvents CheckBoxPlus4 As CheckBox
    Friend WithEvents ButtonFromProject As Button
End Class
