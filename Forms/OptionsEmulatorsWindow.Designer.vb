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
        Me.ButtonFromGlobal = New System.Windows.Forms.Button()
        Me.ButtonRestore = New System.Windows.Forms.Button()
        Me.ButtonApply = New System.Windows.Forms.Button()
        Me.TabControlOptions = New System.Windows.Forms.TabControl()
        Me.TabPageEmulators = New System.Windows.Forms.TabPage()
        Me.TabPagePlatforms = New System.Windows.Forms.TabPage()
        Me.ButtonFromProject = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBoxAtariLo = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAtari = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC128 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC64 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVic2024 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVic20 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC16 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPlus4 = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxYAPEPath = New System.Windows.Forms.TextBox()
        Me.CheckBoxYAPE = New System.Windows.Forms.CheckBox()
        Me.TextBoxATARI800Path = New System.Windows.Forms.TextBox()
        Me.CheckBoxATARI800 = New System.Windows.Forms.CheckBox()
        Me.TextBoxALTIRRAPath = New System.Windows.Forms.TextBox()
        Me.CheckBoxALTIRRA = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVICE = New System.Windows.Forms.CheckBox()
        Me.TextBoxVICEPath = New System.Windows.Forms.TextBox()
        Me.TabControlOptions.SuspendLayout()
        Me.TabPageEmulators.SuspendLayout()
        Me.TabPagePlatforms.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.ButtonApply.Text = "Apply && Close"
        Me.ButtonApply.UseVisualStyleBackColor = True
        '
        'TabControlOptions
        '
        Me.TabControlOptions.Controls.Add(Me.TabPageEmulators)
        Me.TabControlOptions.Controls.Add(Me.TabPagePlatforms)
        Me.TabControlOptions.Location = New System.Drawing.Point(6, 6)
        Me.TabControlOptions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlOptions.Name = "TabControlOptions"
        Me.TabControlOptions.SelectedIndex = 0
        Me.TabControlOptions.Size = New System.Drawing.Size(707, 221)
        Me.TabControlOptions.TabIndex = 5
        '
        'TabPageEmulators
        '
        Me.TabPageEmulators.Controls.Add(Me.Panel2)
        Me.TabPageEmulators.Location = New System.Drawing.Point(4, 29)
        Me.TabPageEmulators.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageEmulators.Name = "TabPageEmulators"
        Me.TabPageEmulators.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageEmulators.Size = New System.Drawing.Size(699, 188)
        Me.TabPageEmulators.TabIndex = 0
        Me.TabPageEmulators.Text = "Emulators"
        Me.TabPageEmulators.UseVisualStyleBackColor = True
        '
        'TabPagePlatforms
        '
        Me.TabPagePlatforms.Controls.Add(Me.Panel1)
        Me.TabPagePlatforms.Location = New System.Drawing.Point(4, 29)
        Me.TabPagePlatforms.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPagePlatforms.Name = "TabPagePlatforms"
        Me.TabPagePlatforms.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPagePlatforms.Size = New System.Drawing.Size(699, 188)
        Me.TabPagePlatforms.TabIndex = 1
        Me.TabPagePlatforms.Text = "Platforms"
        Me.TabPagePlatforms.UseVisualStyleBackColor = True
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckBoxAtariLo)
        Me.Panel1.Controls.Add(Me.CheckBoxAtari)
        Me.Panel1.Controls.Add(Me.CheckBoxC128)
        Me.Panel1.Controls.Add(Me.CheckBoxC64)
        Me.Panel1.Controls.Add(Me.CheckBoxVic2024)
        Me.Panel1.Controls.Add(Me.CheckBoxVic20)
        Me.Panel1.Controls.Add(Me.CheckBoxC16)
        Me.Panel1.Controls.Add(Me.CheckBoxPlus4)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(695, 185)
        Me.Panel1.TabIndex = 1
        '
        'CheckBoxAtariLo
        '
        Me.CheckBoxAtariLo.AutoSize = True
        Me.CheckBoxAtariLo.Location = New System.Drawing.Point(480, 14)
        Me.CheckBoxAtariLo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxAtariLo.Name = "CheckBoxAtariLo"
        Me.CheckBoxAtariLo.Size = New System.Drawing.Size(215, 24)
        Me.CheckBoxAtariLo.TabIndex = 26
        Me.CheckBoxAtariLo.Text = "Atari (8 bit) [low resolution]"
        Me.CheckBoxAtariLo.UseVisualStyleBackColor = True
        '
        'CheckBoxAtari
        '
        Me.CheckBoxAtari.AutoSize = True
        Me.CheckBoxAtari.Location = New System.Drawing.Point(480, 46)
        Me.CheckBoxAtari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxAtari.Name = "CheckBoxAtari"
        Me.CheckBoxAtari.Size = New System.Drawing.Size(107, 24)
        Me.CheckBoxAtari.TabIndex = 25
        Me.CheckBoxAtari.Text = "Atari (8 bit)"
        Me.CheckBoxAtari.UseVisualStyleBackColor = True
        '
        'CheckBoxC128
        '
        Me.CheckBoxC128.AutoSize = True
        Me.CheckBoxC128.Location = New System.Drawing.Point(291, 78)
        Me.CheckBoxC128.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxC128.Name = "CheckBoxC128"
        Me.CheckBoxC128.Size = New System.Drawing.Size(143, 24)
        Me.CheckBoxC128.TabIndex = 24
        Me.CheckBoxC128.Text = "Commodore 128"
        Me.CheckBoxC128.UseVisualStyleBackColor = True
        '
        'CheckBoxC64
        '
        Me.CheckBoxC64.AutoSize = True
        Me.CheckBoxC64.Location = New System.Drawing.Point(291, 46)
        Me.CheckBoxC64.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxC64.Name = "CheckBoxC64"
        Me.CheckBoxC64.Size = New System.Drawing.Size(135, 24)
        Me.CheckBoxC64.TabIndex = 23
        Me.CheckBoxC64.Text = "Commodore 64"
        Me.CheckBoxC64.UseVisualStyleBackColor = True
        '
        'CheckBoxVic2024
        '
        Me.CheckBoxVic2024.AutoSize = True
        Me.CheckBoxVic2024.Location = New System.Drawing.Point(16, 78)
        Me.CheckBoxVic2024.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxVic2024.Name = "CheckBoxVic2024"
        Me.CheckBoxVic2024.Size = New System.Drawing.Size(246, 24)
        Me.CheckBoxVic2024.TabIndex = 22
        Me.CheckBoxVic2024.Text = "Commodore VIC-20 (exp. 24 KB)"
        Me.CheckBoxVic2024.UseVisualStyleBackColor = True
        '
        'CheckBoxVic20
        '
        Me.CheckBoxVic20.AutoSize = True
        Me.CheckBoxVic20.Location = New System.Drawing.Point(16, 46)
        Me.CheckBoxVic20.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxVic20.Name = "CheckBoxVic20"
        Me.CheckBoxVic20.Size = New System.Drawing.Size(163, 24)
        Me.CheckBoxVic20.TabIndex = 21
        Me.CheckBoxVic20.Text = "Commodore VIC-20"
        Me.CheckBoxVic20.UseVisualStyleBackColor = True
        '
        'CheckBoxC16
        '
        Me.CheckBoxC16.AutoSize = True
        Me.CheckBoxC16.Location = New System.Drawing.Point(16, 14)
        Me.CheckBoxC16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxC16.Name = "CheckBoxC16"
        Me.CheckBoxC16.Size = New System.Drawing.Size(135, 24)
        Me.CheckBoxC16.TabIndex = 20
        Me.CheckBoxC16.Text = "Commodore 16"
        Me.CheckBoxC16.UseVisualStyleBackColor = True
        '
        'CheckBoxPlus4
        '
        Me.CheckBoxPlus4.AutoSize = True
        Me.CheckBoxPlus4.Location = New System.Drawing.Point(291, 14)
        Me.CheckBoxPlus4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxPlus4.Name = "CheckBoxPlus4"
        Me.CheckBoxPlus4.Size = New System.Drawing.Size(166, 24)
        Me.CheckBoxPlus4.TabIndex = 19
        Me.CheckBoxPlus4.Text = "Commodore PLUS/4"
        Me.CheckBoxPlus4.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBoxYAPEPath)
        Me.Panel2.Controls.Add(Me.CheckBoxYAPE)
        Me.Panel2.Controls.Add(Me.TextBoxATARI800Path)
        Me.Panel2.Controls.Add(Me.CheckBoxATARI800)
        Me.Panel2.Controls.Add(Me.TextBoxALTIRRAPath)
        Me.Panel2.Controls.Add(Me.CheckBoxALTIRRA)
        Me.Panel2.Controls.Add(Me.CheckBoxVICE)
        Me.Panel2.Controls.Add(Me.TextBoxVICEPath)
        Me.Panel2.Location = New System.Drawing.Point(6, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(690, 183)
        Me.Panel2.TabIndex = 0
        '
        'TextBoxYAPEPath
        '
        Me.TextBoxYAPEPath.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxYAPEPath.Location = New System.Drawing.Point(389, 53)
        Me.TextBoxYAPEPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxYAPEPath.Name = "TextBoxYAPEPath"
        Me.TextBoxYAPEPath.Size = New System.Drawing.Size(280, 27)
        Me.TextBoxYAPEPath.TabIndex = 48
        '
        'CheckBoxYAPE
        '
        Me.CheckBoxYAPE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxYAPE.AutoSize = True
        Me.CheckBoxYAPE.Location = New System.Drawing.Point(366, 29)
        Me.CheckBoxYAPE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxYAPE.Name = "CheckBoxYAPE"
        Me.CheckBoxYAPE.Size = New System.Drawing.Size(168, 24)
        Me.CheckBoxYAPE.TabIndex = 47
        Me.CheckBoxYAPE.Text = "Enable YAPE support"
        Me.CheckBoxYAPE.UseVisualStyleBackColor = True
        '
        'TextBoxATARI800Path
        '
        Me.TextBoxATARI800Path.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxATARI800Path.Location = New System.Drawing.Point(389, 112)
        Me.TextBoxATARI800Path.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxATARI800Path.Name = "TextBoxATARI800Path"
        Me.TextBoxATARI800Path.Size = New System.Drawing.Size(279, 27)
        Me.TextBoxATARI800Path.TabIndex = 46
        '
        'CheckBoxATARI800
        '
        Me.CheckBoxATARI800.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxATARI800.AutoSize = True
        Me.CheckBoxATARI800.Location = New System.Drawing.Point(366, 90)
        Me.CheckBoxATARI800.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxATARI800.Name = "CheckBoxATARI800"
        Me.CheckBoxATARI800.Size = New System.Drawing.Size(202, 24)
        Me.CheckBoxATARI800.TabIndex = 45
        Me.CheckBoxATARI800.Text = "Enable ATARI 800 support"
        Me.CheckBoxATARI800.UseVisualStyleBackColor = True
        '
        'TextBoxALTIRRAPath
        '
        Me.TextBoxALTIRRAPath.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxALTIRRAPath.Location = New System.Drawing.Point(41, 112)
        Me.TextBoxALTIRRAPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxALTIRRAPath.Name = "TextBoxALTIRRAPath"
        Me.TextBoxALTIRRAPath.Size = New System.Drawing.Size(280, 27)
        Me.TextBoxALTIRRAPath.TabIndex = 44
        '
        'CheckBoxALTIRRA
        '
        Me.CheckBoxALTIRRA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxALTIRRA.AutoSize = True
        Me.CheckBoxALTIRRA.Location = New System.Drawing.Point(18, 90)
        Me.CheckBoxALTIRRA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxALTIRRA.Name = "CheckBoxALTIRRA"
        Me.CheckBoxALTIRRA.Size = New System.Drawing.Size(191, 24)
        Me.CheckBoxALTIRRA.TabIndex = 43
        Me.CheckBoxALTIRRA.Text = "Enable ALTIRRA support"
        Me.CheckBoxALTIRRA.UseVisualStyleBackColor = True
        '
        'CheckBoxVICE
        '
        Me.CheckBoxVICE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckBoxVICE.AutoSize = True
        Me.CheckBoxVICE.Location = New System.Drawing.Point(18, 29)
        Me.CheckBoxVICE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBoxVICE.Name = "CheckBoxVICE"
        Me.CheckBoxVICE.Size = New System.Drawing.Size(165, 24)
        Me.CheckBoxVICE.TabIndex = 41
        Me.CheckBoxVICE.Text = "Enable VICE support"
        Me.CheckBoxVICE.UseVisualStyleBackColor = True
        '
        'TextBoxVICEPath
        '
        Me.TextBoxVICEPath.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBoxVICEPath.Location = New System.Drawing.Point(41, 53)
        Me.TextBoxVICEPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxVICEPath.Name = "TextBoxVICEPath"
        Me.TextBoxVICEPath.Size = New System.Drawing.Size(280, 27)
        Me.TextBoxVICEPath.TabIndex = 42
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
        Me.TabPagePlatforms.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonFromGlobal As Button
    Friend WithEvents ButtonRestore As Button
    Friend WithEvents ButtonApply As Button
    Friend WithEvents TabControlOptions As TabControl
    Friend WithEvents TabPageEmulators As TabPage
    Friend WithEvents TabPagePlatforms As TabPage
    Friend WithEvents ButtonFromProject As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBoxAtariLo As CheckBox
    Friend WithEvents CheckBoxAtari As CheckBox
    Friend WithEvents CheckBoxC128 As CheckBox
    Friend WithEvents CheckBoxC64 As CheckBox
    Friend WithEvents CheckBoxVic2024 As CheckBox
    Friend WithEvents CheckBoxVic20 As CheckBox
    Friend WithEvents CheckBoxC16 As CheckBox
    Friend WithEvents CheckBoxPlus4 As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBoxYAPEPath As TextBox
    Friend WithEvents CheckBoxYAPE As CheckBox
    Friend WithEvents TextBoxATARI800Path As TextBox
    Friend WithEvents CheckBoxATARI800 As CheckBox
    Friend WithEvents TextBoxALTIRRAPath As TextBox
    Friend WithEvents CheckBoxALTIRRA As CheckBox
    Friend WithEvents CheckBoxVICE As CheckBox
    Friend WithEvents TextBoxVICEPath As TextBox
End Class
