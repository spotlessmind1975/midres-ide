<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OptionsMakeWindow
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonFromGlobal = New System.Windows.Forms.Button()
        Me.ButtonRestore = New System.Windows.Forms.Button()
        Me.ButtonApply = New System.Windows.Forms.Button()
        Me.TabPageOutput = New System.Windows.Forms.TabPage()
        Me.TabPageMake = New System.Windows.Forms.TabPage()
        Me.TabControlOptions = New System.Windows.Forms.TabControl()
        Me.TabPageCC65 = New System.Windows.Forms.TabPage()
        Me.ButtonFromProject = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxActionClean = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxActionBuild = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxAdditionalParams = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDynamicMakefile = New System.Windows.Forms.RadioButton()
        Me.RadioButtonStaticMakefile = New System.Windows.Forms.RadioButton()
        Me.TextBoxMakeFileName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBoxBinaryFileFormat = New System.Windows.Forms.GroupBox()
        Me.RadioButtonComplete = New System.Windows.Forms.RadioButton()
        Me.RadioButtonExecutable = New System.Windows.Forms.RadioButton()
        Me.TextBoxBinaryFileName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CheckBoxAtariLo = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAtari = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC128 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC64 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVic2024 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVic20 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC16 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPlus4 = New System.Windows.Forms.CheckBox()
        Me.TabPageOutput.SuspendLayout()
        Me.TabPageMake.SuspendLayout()
        Me.TabControlOptions.SuspendLayout()
        Me.TabPageCC65.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBoxBinaryFileFormat.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonFromGlobal
        '
        Me.ButtonFromGlobal.Location = New System.Drawing.Point(314, 235)
        Me.ButtonFromGlobal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonFromGlobal.Name = "ButtonFromGlobal"
        Me.ButtonFromGlobal.Size = New System.Drawing.Size(125, 44)
        Me.ButtonFromGlobal.TabIndex = 9
        Me.ButtonFromGlobal.Text = "From Global"
        Me.ButtonFromGlobal.UseVisualStyleBackColor = True
        '
        'ButtonRestore
        '
        Me.ButtonRestore.Location = New System.Drawing.Point(4, 235)
        Me.ButtonRestore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonRestore.Name = "ButtonRestore"
        Me.ButtonRestore.Size = New System.Drawing.Size(125, 44)
        Me.ButtonRestore.TabIndex = 7
        Me.ButtonRestore.Text = "Restore"
        Me.ButtonRestore.UseVisualStyleBackColor = True
        '
        'ButtonApply
        '
        Me.ButtonApply.Location = New System.Drawing.Point(584, 235)
        Me.ButtonApply.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonApply.Name = "ButtonApply"
        Me.ButtonApply.Size = New System.Drawing.Size(125, 44)
        Me.ButtonApply.TabIndex = 6
        Me.ButtonApply.Text = "Apply && Close"
        Me.ButtonApply.UseVisualStyleBackColor = True
        '
        'TabPageOutput
        '
        Me.TabPageOutput.Controls.Add(Me.Panel2)
        Me.TabPageOutput.Location = New System.Drawing.Point(4, 29)
        Me.TabPageOutput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageOutput.Name = "TabPageOutput"
        Me.TabPageOutput.Size = New System.Drawing.Size(699, 188)
        Me.TabPageOutput.TabIndex = 3
        Me.TabPageOutput.Text = "Output"
        Me.TabPageOutput.UseVisualStyleBackColor = True
        '
        'TabPageMake
        '
        Me.TabPageMake.Controls.Add(Me.Panel1)
        Me.TabPageMake.Location = New System.Drawing.Point(4, 29)
        Me.TabPageMake.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageMake.Name = "TabPageMake"
        Me.TabPageMake.Size = New System.Drawing.Size(699, 188)
        Me.TabPageMake.TabIndex = 4
        Me.TabPageMake.Text = "Make"
        Me.TabPageMake.UseVisualStyleBackColor = True
        '
        'TabControlOptions
        '
        Me.TabControlOptions.Controls.Add(Me.TabPageMake)
        Me.TabControlOptions.Controls.Add(Me.TabPageOutput)
        Me.TabControlOptions.Controls.Add(Me.TabPageCC65)
        Me.TabControlOptions.Location = New System.Drawing.Point(7, 7)
        Me.TabControlOptions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlOptions.Name = "TabControlOptions"
        Me.TabControlOptions.SelectedIndex = 0
        Me.TabControlOptions.Size = New System.Drawing.Size(707, 221)
        Me.TabControlOptions.TabIndex = 5
        '
        'TabPageCC65
        '
        Me.TabPageCC65.Controls.Add(Me.Panel3)
        Me.TabPageCC65.Location = New System.Drawing.Point(4, 29)
        Me.TabPageCC65.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageCC65.Name = "TabPageCC65"
        Me.TabPageCC65.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageCC65.Size = New System.Drawing.Size(699, 188)
        Me.TabPageCC65.TabIndex = 1
        Me.TabPageCC65.Text = "Targets"
        Me.TabPageCC65.UseVisualStyleBackColor = True
        '
        'ButtonFromProject
        '
        Me.ButtonFromProject.Location = New System.Drawing.Point(449, 235)
        Me.ButtonFromProject.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonFromProject.Name = "ButtonFromProject"
        Me.ButtonFromProject.Size = New System.Drawing.Size(125, 44)
        Me.ButtonFromProject.TabIndex = 8
        Me.ButtonFromProject.Text = "From Project"
        Me.ButtonFromProject.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBoxActionClean)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TextBoxActionBuild)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextBoxAdditionalParams)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.TextBoxMakeFileName)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 182)
        Me.Panel1.TabIndex = 0
        '
        'TextBoxActionClean
        '
        Me.TextBoxActionClean.Location = New System.Drawing.Point(160, 147)
        Me.TextBoxActionClean.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxActionClean.Name = "TextBoxActionClean"
        Me.TextBoxActionClean.Size = New System.Drawing.Size(109, 27)
        Me.TextBoxActionClean.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(156, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Action for clean"
        '
        'TextBoxActionBuild
        '
        Me.TextBoxActionBuild.Location = New System.Drawing.Point(22, 147)
        Me.TextBoxActionBuild.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxActionBuild.Name = "TextBoxActionBuild"
        Me.TextBoxActionBuild.Size = New System.Drawing.Size(109, 27)
        Me.TextBoxActionBuild.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Action for build"
        '
        'TextBoxAdditionalParams
        '
        Me.TextBoxAdditionalParams.Location = New System.Drawing.Point(22, 87)
        Me.TextBoxAdditionalParams.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxAdditionalParams.Name = "TextBoxAdditionalParams"
        Me.TextBoxAdditionalParams.Size = New System.Drawing.Size(188, 27)
        Me.TextBoxAdditionalParams.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Additional params"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButtonDynamicMakefile)
        Me.GroupBox5.Controls.Add(Me.RadioButtonStaticMakefile)
        Me.GroupBox5.Location = New System.Drawing.Point(343, 41)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(334, 91)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Kind of makefile"
        '
        'RadioButtonDynamicMakefile
        '
        Me.RadioButtonDynamicMakefile.AutoSize = True
        Me.RadioButtonDynamicMakefile.Location = New System.Drawing.Point(6, 60)
        Me.RadioButtonDynamicMakefile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonDynamicMakefile.Name = "RadioButtonDynamicMakefile"
        Me.RadioButtonDynamicMakefile.Size = New System.Drawing.Size(175, 24)
        Me.RadioButtonDynamicMakefile.TabIndex = 1
        Me.RadioButtonDynamicMakefile.TabStop = True
        Me.RadioButtonDynamicMakefile.Text = "Use dynamic makefile"
        Me.RadioButtonDynamicMakefile.UseVisualStyleBackColor = True
        '
        'RadioButtonStaticMakefile
        '
        Me.RadioButtonStaticMakefile.AutoSize = True
        Me.RadioButtonStaticMakefile.Location = New System.Drawing.Point(6, 28)
        Me.RadioButtonStaticMakefile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonStaticMakefile.Name = "RadioButtonStaticMakefile"
        Me.RadioButtonStaticMakefile.Size = New System.Drawing.Size(154, 24)
        Me.RadioButtonStaticMakefile.TabIndex = 0
        Me.RadioButtonStaticMakefile.TabStop = True
        Me.RadioButtonStaticMakefile.Text = "Use static makefile"
        Me.RadioButtonStaticMakefile.UseVisualStyleBackColor = True
        '
        'TextBoxMakeFileName
        '
        Me.TextBoxMakeFileName.Location = New System.Drawing.Point(22, 32)
        Me.TextBoxMakeFileName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxMakeFileName.Name = "TextBoxMakeFileName"
        Me.TextBoxMakeFileName.Size = New System.Drawing.Size(188, 27)
        Me.TextBoxMakeFileName.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 20)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Makefile filename"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.GroupBoxBinaryFileFormat)
        Me.Panel2.Controls.Add(Me.TextBoxBinaryFileName)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(693, 182)
        Me.Panel2.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(320, 77)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "It is possible to create ""dynamic"" names by using some variables, such as {target" &
    "} to indicate the target selected with the contextual menu or {support} for file" &
    " format."
        '
        'GroupBoxBinaryFileFormat
        '
        Me.GroupBoxBinaryFileFormat.Controls.Add(Me.RadioButtonComplete)
        Me.GroupBoxBinaryFileFormat.Controls.Add(Me.RadioButtonExecutable)
        Me.GroupBoxBinaryFileFormat.Location = New System.Drawing.Point(341, 25)
        Me.GroupBoxBinaryFileFormat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBoxBinaryFileFormat.Name = "GroupBoxBinaryFileFormat"
        Me.GroupBoxBinaryFileFormat.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBoxBinaryFileFormat.Size = New System.Drawing.Size(343, 133)
        Me.GroupBoxBinaryFileFormat.TabIndex = 6
        Me.GroupBoxBinaryFileFormat.TabStop = False
        Me.GroupBoxBinaryFileFormat.Text = "Binary format"
        '
        'RadioButtonComplete
        '
        Me.RadioButtonComplete.AutoSize = True
        Me.RadioButtonComplete.Location = New System.Drawing.Point(8, 75)
        Me.RadioButtonComplete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonComplete.Name = "RadioButtonComplete"
        Me.RadioButtonComplete.Size = New System.Drawing.Size(171, 24)
        Me.RadioButtonComplete.TabIndex = 1
        Me.RadioButtonComplete.TabStop = True
        Me.RadioButtonComplete.Text = "Complete (with data)"
        Me.RadioButtonComplete.UseVisualStyleBackColor = True
        '
        'RadioButtonExecutable
        '
        Me.RadioButtonExecutable.AutoSize = True
        Me.RadioButtonExecutable.Location = New System.Drawing.Point(8, 33)
        Me.RadioButtonExecutable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonExecutable.Name = "RadioButtonExecutable"
        Me.RadioButtonExecutable.Size = New System.Drawing.Size(134, 24)
        Me.RadioButtonExecutable.TabIndex = 0
        Me.RadioButtonExecutable.TabStop = True
        Me.RadioButtonExecutable.Text = "Executable only"
        Me.RadioButtonExecutable.UseVisualStyleBackColor = True
        '
        'TextBoxBinaryFileName
        '
        Me.TextBoxBinaryFileName.Location = New System.Drawing.Point(18, 34)
        Me.TextBoxBinaryFileName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxBinaryFileName.Name = "TextBoxBinaryFileName"
        Me.TextBoxBinaryFileName.Size = New System.Drawing.Size(317, 27)
        Me.TextBoxBinaryFileName.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 20)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Binary filename"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.CheckBoxAtariLo)
        Me.Panel3.Controls.Add(Me.CheckBoxAtari)
        Me.Panel3.Controls.Add(Me.CheckBoxC128)
        Me.Panel3.Controls.Add(Me.CheckBoxC64)
        Me.Panel3.Controls.Add(Me.CheckBoxVic2024)
        Me.Panel3.Controls.Add(Me.CheckBoxVic20)
        Me.Panel3.Controls.Add(Me.CheckBoxC16)
        Me.Panel3.Controls.Add(Me.CheckBoxPlus4)
        Me.Panel3.Location = New System.Drawing.Point(6, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(686, 174)
        Me.Panel3.TabIndex = 0
        '
        'CheckBoxAtariLo
        '
        Me.CheckBoxAtariLo.AutoSize = True
        Me.CheckBoxAtariLo.Location = New System.Drawing.Point(448, 32)
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
        Me.CheckBoxAtari.Location = New System.Drawing.Point(448, 64)
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
        Me.CheckBoxC128.Location = New System.Drawing.Point(263, 96)
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
        Me.CheckBoxC64.Location = New System.Drawing.Point(263, 64)
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
        Me.CheckBoxVic2024.Location = New System.Drawing.Point(9, 96)
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
        Me.CheckBoxVic20.Location = New System.Drawing.Point(9, 64)
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
        Me.CheckBoxC16.Location = New System.Drawing.Point(9, 32)
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
        Me.CheckBoxPlus4.Location = New System.Drawing.Point(263, 32)
        Me.CheckBoxPlus4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxPlus4.Name = "CheckBoxPlus4"
        Me.CheckBoxPlus4.Size = New System.Drawing.Size(166, 24)
        Me.CheckBoxPlus4.TabIndex = 19
        Me.CheckBoxPlus4.Text = "Commodore PLUS/4"
        Me.CheckBoxPlus4.UseVisualStyleBackColor = True
        '
        'OptionsMakeWindow
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
        Me.Name = "OptionsMakeWindow"
        Me.Text = "OptionsMakeWindow"
        Me.TabPageOutput.ResumeLayout(False)
        Me.TabPageMake.ResumeLayout(False)
        Me.TabControlOptions.ResumeLayout(False)
        Me.TabPageCC65.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBoxBinaryFileFormat.ResumeLayout(False)
        Me.GroupBoxBinaryFileFormat.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonFromGlobal As Button
    Friend WithEvents ButtonRestore As Button
    Friend WithEvents ButtonApply As Button
    Friend WithEvents TabPageOutput As TabPage
    Friend WithEvents TabPageMake As TabPage
    Friend WithEvents TabControlOptions As TabControl
    Friend WithEvents TabPageCC65 As TabPage
    Friend WithEvents ButtonFromProject As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBoxBinaryFileFormat As GroupBox
    Friend WithEvents RadioButtonComplete As RadioButton
    Friend WithEvents RadioButtonExecutable As RadioButton
    Friend WithEvents TextBoxBinaryFileName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxActionClean As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxActionBuild As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxAdditionalParams As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents RadioButtonDynamicMakefile As RadioButton
    Friend WithEvents RadioButtonStaticMakefile As RadioButton
    Friend WithEvents TextBoxMakeFileName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CheckBoxAtariLo As CheckBox
    Friend WithEvents CheckBoxAtari As CheckBox
    Friend WithEvents CheckBoxC128 As CheckBox
    Friend WithEvents CheckBoxC64 As CheckBox
    Friend WithEvents CheckBoxVic2024 As CheckBox
    Friend WithEvents CheckBoxVic20 As CheckBox
    Friend WithEvents CheckBoxC16 As CheckBox
    Friend WithEvents CheckBoxPlus4 As CheckBox
End Class
