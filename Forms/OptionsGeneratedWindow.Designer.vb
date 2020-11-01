<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsGeneratedWindow
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
        Me.TabPageDetails = New System.Windows.Forms.TabPage()
        Me.ButtonApply = New System.Windows.Forms.Button()
        Me.TabControlOptions = New System.Windows.Forms.TabControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckedListBoxDependency = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPageTargets = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckBoxAtariLo = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAtari = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC128 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC64 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVic2024 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVic20 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC16 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPlus4 = New System.Windows.Forms.CheckBox()
        Me.TabPageDetails.SuspendLayout()
        Me.TabControlOptions.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPageTargets.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPageDetails
        '
        Me.TabPageDetails.Controls.Add(Me.Panel1)
        Me.TabPageDetails.Location = New System.Drawing.Point(4, 29)
        Me.TabPageDetails.Name = "TabPageDetails"
        Me.TabPageDetails.Size = New System.Drawing.Size(699, 188)
        Me.TabPageDetails.TabIndex = 5
        Me.TabPageDetails.Text = "Details"
        Me.TabPageDetails.UseVisualStyleBackColor = True
        '
        'ButtonApply
        '
        Me.ButtonApply.Location = New System.Drawing.Point(589, 239)
        Me.ButtonApply.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonApply.Name = "ButtonApply"
        Me.ButtonApply.Size = New System.Drawing.Size(125, 44)
        Me.ButtonApply.TabIndex = 11
        Me.ButtonApply.Text = "Apply && Close"
        Me.ButtonApply.UseVisualStyleBackColor = True
        '
        'TabControlOptions
        '
        Me.TabControlOptions.Controls.Add(Me.TabPageDetails)
        Me.TabControlOptions.Controls.Add(Me.TabPageTargets)
        Me.TabControlOptions.Location = New System.Drawing.Point(12, 11)
        Me.TabControlOptions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlOptions.Name = "TabControlOptions"
        Me.TabControlOptions.SelectedIndex = 0
        Me.TabControlOptions.Size = New System.Drawing.Size(707, 221)
        Me.TabControlOptions.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckedListBoxDependency)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 182)
        Me.Panel1.TabIndex = 0
        '
        'CheckedListBoxDependency
        '
        Me.CheckedListBoxDependency.FormattingEnabled = True
        Me.CheckedListBoxDependency.Location = New System.Drawing.Point(7, 31)
        Me.CheckedListBoxDependency.Name = "CheckedListBoxDependency"
        Me.CheckedListBoxDependency.Size = New System.Drawing.Size(674, 136)
        Me.CheckedListBoxDependency.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Set dependency for this file:"
        '
        'TabPageTargets
        '
        Me.TabPageTargets.Controls.Add(Me.Panel2)
        Me.TabPageTargets.Location = New System.Drawing.Point(4, 29)
        Me.TabPageTargets.Name = "TabPageTargets"
        Me.TabPageTargets.Size = New System.Drawing.Size(699, 188)
        Me.TabPageTargets.TabIndex = 6
        Me.TabPageTargets.Text = "Platforms"
        Me.TabPageTargets.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CheckBoxAtariLo)
        Me.Panel2.Controls.Add(Me.CheckBoxAtari)
        Me.Panel2.Controls.Add(Me.CheckBoxC128)
        Me.Panel2.Controls.Add(Me.CheckBoxC64)
        Me.Panel2.Controls.Add(Me.CheckBoxVic2024)
        Me.Panel2.Controls.Add(Me.CheckBoxVic20)
        Me.Panel2.Controls.Add(Me.CheckBoxC16)
        Me.Panel2.Controls.Add(Me.CheckBoxPlus4)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(690, 182)
        Me.Panel2.TabIndex = 0
        '
        'CheckBoxAtariLo
        '
        Me.CheckBoxAtariLo.AutoSize = True
        Me.CheckBoxAtariLo.Location = New System.Drawing.Point(457, 47)
        Me.CheckBoxAtariLo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxAtariLo.Name = "CheckBoxAtariLo"
        Me.CheckBoxAtariLo.Size = New System.Drawing.Size(215, 24)
        Me.CheckBoxAtariLo.TabIndex = 34
        Me.CheckBoxAtariLo.Text = "Atari (8 bit) [low resolution]"
        Me.CheckBoxAtariLo.UseVisualStyleBackColor = True
        '
        'CheckBoxAtari
        '
        Me.CheckBoxAtari.AutoSize = True
        Me.CheckBoxAtari.Location = New System.Drawing.Point(457, 79)
        Me.CheckBoxAtari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxAtari.Name = "CheckBoxAtari"
        Me.CheckBoxAtari.Size = New System.Drawing.Size(107, 24)
        Me.CheckBoxAtari.TabIndex = 33
        Me.CheckBoxAtari.Text = "Atari (8 bit)"
        Me.CheckBoxAtari.UseVisualStyleBackColor = True
        '
        'CheckBoxC128
        '
        Me.CheckBoxC128.AutoSize = True
        Me.CheckBoxC128.Location = New System.Drawing.Point(272, 111)
        Me.CheckBoxC128.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxC128.Name = "CheckBoxC128"
        Me.CheckBoxC128.Size = New System.Drawing.Size(143, 24)
        Me.CheckBoxC128.TabIndex = 32
        Me.CheckBoxC128.Text = "Commodore 128"
        Me.CheckBoxC128.UseVisualStyleBackColor = True
        '
        'CheckBoxC64
        '
        Me.CheckBoxC64.AutoSize = True
        Me.CheckBoxC64.Location = New System.Drawing.Point(272, 79)
        Me.CheckBoxC64.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxC64.Name = "CheckBoxC64"
        Me.CheckBoxC64.Size = New System.Drawing.Size(135, 24)
        Me.CheckBoxC64.TabIndex = 31
        Me.CheckBoxC64.Text = "Commodore 64"
        Me.CheckBoxC64.UseVisualStyleBackColor = True
        '
        'CheckBoxVic2024
        '
        Me.CheckBoxVic2024.AutoSize = True
        Me.CheckBoxVic2024.Location = New System.Drawing.Point(18, 111)
        Me.CheckBoxVic2024.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxVic2024.Name = "CheckBoxVic2024"
        Me.CheckBoxVic2024.Size = New System.Drawing.Size(246, 24)
        Me.CheckBoxVic2024.TabIndex = 30
        Me.CheckBoxVic2024.Text = "Commodore VIC-20 (exp. 24 KB)"
        Me.CheckBoxVic2024.UseVisualStyleBackColor = True
        '
        'CheckBoxVic20
        '
        Me.CheckBoxVic20.AutoSize = True
        Me.CheckBoxVic20.Location = New System.Drawing.Point(18, 79)
        Me.CheckBoxVic20.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxVic20.Name = "CheckBoxVic20"
        Me.CheckBoxVic20.Size = New System.Drawing.Size(163, 24)
        Me.CheckBoxVic20.TabIndex = 29
        Me.CheckBoxVic20.Text = "Commodore VIC-20"
        Me.CheckBoxVic20.UseVisualStyleBackColor = True
        '
        'CheckBoxC16
        '
        Me.CheckBoxC16.AutoSize = True
        Me.CheckBoxC16.Location = New System.Drawing.Point(18, 47)
        Me.CheckBoxC16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxC16.Name = "CheckBoxC16"
        Me.CheckBoxC16.Size = New System.Drawing.Size(135, 24)
        Me.CheckBoxC16.TabIndex = 28
        Me.CheckBoxC16.Text = "Commodore 16"
        Me.CheckBoxC16.UseVisualStyleBackColor = True
        '
        'CheckBoxPlus4
        '
        Me.CheckBoxPlus4.AutoSize = True
        Me.CheckBoxPlus4.Location = New System.Drawing.Point(272, 47)
        Me.CheckBoxPlus4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxPlus4.Name = "CheckBoxPlus4"
        Me.CheckBoxPlus4.Size = New System.Drawing.Size(166, 24)
        Me.CheckBoxPlus4.TabIndex = 27
        Me.CheckBoxPlus4.Text = "Commodore PLUS/4"
        Me.CheckBoxPlus4.UseVisualStyleBackColor = True
        '
        'OptionsGeneratedWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 292)
        Me.Controls.Add(Me.ButtonApply)
        Me.Controls.Add(Me.TabControlOptions)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OptionsGeneratedWindow"
        Me.Text = "OptionsGeneratedWindow"
        Me.TabPageDetails.ResumeLayout(False)
        Me.TabControlOptions.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPageTargets.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPageDetails As TabPage
    Friend WithEvents ButtonApply As Button
    Friend WithEvents TabControlOptions As TabControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckedListBoxDependency As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPageTargets As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CheckBoxAtariLo As CheckBox
    Friend WithEvents CheckBoxAtari As CheckBox
    Friend WithEvents CheckBoxC128 As CheckBox
    Friend WithEvents CheckBoxC64 As CheckBox
    Friend WithEvents CheckBoxVic2024 As CheckBox
    Friend WithEvents CheckBoxVic20 As CheckBox
    Friend WithEvents CheckBoxC16 As CheckBox
    Friend WithEvents CheckBoxPlus4 As CheckBox
End Class
