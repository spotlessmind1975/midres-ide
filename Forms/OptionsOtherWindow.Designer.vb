<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsOtherWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsOtherWindow))
        Me.TabTargets = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CheckBoxAtariLo = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAtari = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC128 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC64 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVic2024 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVic20 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC16 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPlus4 = New System.Windows.Forms.CheckBox()
        Me.TabControlOptions = New System.Windows.Forms.TabControl()
        Me.ButtonFromParent = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonFromGlobal = New System.Windows.Forms.Button()
        Me.ButtonRestore = New System.Windows.Forms.Button()
        Me.ButtonApply = New System.Windows.Forms.Button()
        Me.ButtonFromProject = New System.Windows.Forms.Button()
        Me.TabTargets.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControlOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabTargets
        '
        Me.TabTargets.Controls.Add(Me.Panel3)
        Me.TabTargets.Location = New System.Drawing.Point(4, 29)
        Me.TabTargets.Name = "TabTargets"
        Me.TabTargets.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTargets.Size = New System.Drawing.Size(703, 182)
        Me.TabTargets.TabIndex = 0
        Me.TabTargets.Text = "Targets"
        Me.TabTargets.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.CheckBoxAtariLo)
        Me.Panel3.Controls.Add(Me.CheckBoxAtari)
        Me.Panel3.Controls.Add(Me.CheckBoxC128)
        Me.Panel3.Controls.Add(Me.CheckBoxC64)
        Me.Panel3.Controls.Add(Me.CheckBoxVic2024)
        Me.Panel3.Controls.Add(Me.CheckBoxVic20)
        Me.Panel3.Controls.Add(Me.CheckBoxC16)
        Me.Panel3.Controls.Add(Me.CheckBoxPlus4)
        Me.Panel3.Location = New System.Drawing.Point(5, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(692, 174)
        Me.Panel3.TabIndex = 1
        '
        'CheckBoxAtariLo
        '
        Me.CheckBoxAtariLo.AutoSize = True
        Me.CheckBoxAtariLo.Location = New System.Drawing.Point(443, 32)
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
        Me.CheckBoxAtari.Location = New System.Drawing.Point(443, 64)
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
        Me.CheckBoxC128.Location = New System.Drawing.Point(258, 96)
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
        Me.CheckBoxC64.Location = New System.Drawing.Point(258, 64)
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
        Me.CheckBoxVic2024.Location = New System.Drawing.Point(4, 96)
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
        Me.CheckBoxVic20.Location = New System.Drawing.Point(4, 64)
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
        Me.CheckBoxC16.Location = New System.Drawing.Point(4, 32)
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
        Me.CheckBoxPlus4.Location = New System.Drawing.Point(258, 32)
        Me.CheckBoxPlus4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxPlus4.Name = "CheckBoxPlus4"
        Me.CheckBoxPlus4.Size = New System.Drawing.Size(166, 24)
        Me.CheckBoxPlus4.TabIndex = 19
        Me.CheckBoxPlus4.Text = "Commodore PLUS/4"
        Me.CheckBoxPlus4.UseVisualStyleBackColor = True
        '
        'TabControlOptions
        '
        Me.TabControlOptions.Controls.Add(Me.TabTargets)
        Me.TabControlOptions.Location = New System.Drawing.Point(5, 7)
        Me.TabControlOptions.Name = "TabControlOptions"
        Me.TabControlOptions.SelectedIndex = 0
        Me.TabControlOptions.Size = New System.Drawing.Size(711, 215)
        Me.TabControlOptions.TabIndex = 16
        '
        'ButtonFromParent
        '
        Me.ButtonFromParent.Image = CType(resources.GetObject("ButtonFromParent.Image"), System.Drawing.Image)
        Me.ButtonFromParent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonFromParent.Location = New System.Drawing.Point(460, 225)
        Me.ButtonFromParent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonFromParent.Name = "ButtonFromParent"
        Me.ButtonFromParent.Size = New System.Drawing.Size(79, 44)
        Me.ButtonFromParent.TabIndex = 22
        Me.ButtonFromParent.Text = "parent"
        Me.ButtonFromParent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonFromParent.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Image = CType(resources.GetObject("ButtonRemove.Image"), System.Drawing.Image)
        Me.ButtonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRemove.Location = New System.Drawing.Point(13, 227)
        Me.ButtonRemove.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(85, 42)
        Me.ButtonRemove.TabIndex = 21
        Me.ButtonRemove.Text = "remove"
        Me.ButtonRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'ButtonFromGlobal
        '
        Me.ButtonFromGlobal.Image = CType(resources.GetObject("ButtonFromGlobal.Image"), System.Drawing.Image)
        Me.ButtonFromGlobal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonFromGlobal.Location = New System.Drawing.Point(286, 224)
        Me.ButtonFromGlobal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonFromGlobal.Name = "ButtonFromGlobal"
        Me.ButtonFromGlobal.Size = New System.Drawing.Size(79, 44)
        Me.ButtonFromGlobal.TabIndex = 20
        Me.ButtonFromGlobal.Text = "global"
        Me.ButtonFromGlobal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonFromGlobal.UseVisualStyleBackColor = True
        '
        'ButtonRestore
        '
        Me.ButtonRestore.Image = CType(resources.GetObject("ButtonRestore.Image"), System.Drawing.Image)
        Me.ButtonRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRestore.Location = New System.Drawing.Point(106, 226)
        Me.ButtonRestore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonRestore.Name = "ButtonRestore"
        Me.ButtonRestore.Size = New System.Drawing.Size(85, 42)
        Me.ButtonRestore.TabIndex = 18
        Me.ButtonRestore.Text = "restore"
        Me.ButtonRestore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRestore.UseVisualStyleBackColor = True
        '
        'ButtonApply
        '
        Me.ButtonApply.Image = CType(resources.GetObject("ButtonApply.Image"), System.Drawing.Image)
        Me.ButtonApply.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonApply.Location = New System.Drawing.Point(642, 225)
        Me.ButtonApply.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonApply.Name = "ButtonApply"
        Me.ButtonApply.Size = New System.Drawing.Size(69, 44)
        Me.ButtonApply.TabIndex = 17
        Me.ButtonApply.Text = "apply"
        Me.ButtonApply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonApply.UseVisualStyleBackColor = True
        '
        'ButtonFromProject
        '
        Me.ButtonFromProject.Image = CType(resources.GetObject("ButtonFromProject.Image"), System.Drawing.Image)
        Me.ButtonFromProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonFromProject.Location = New System.Drawing.Point(373, 225)
        Me.ButtonFromProject.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonFromProject.Name = "ButtonFromProject"
        Me.ButtonFromProject.Size = New System.Drawing.Size(79, 44)
        Me.ButtonFromProject.TabIndex = 19
        Me.ButtonFromProject.Text = "project"
        Me.ButtonFromProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonFromProject.UseVisualStyleBackColor = True
        '
        'OptionsOtherWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 279)
        Me.Controls.Add(Me.ButtonFromParent)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.ButtonFromGlobal)
        Me.Controls.Add(Me.ButtonRestore)
        Me.Controls.Add(Me.ButtonApply)
        Me.Controls.Add(Me.ButtonFromProject)
        Me.Controls.Add(Me.TabControlOptions)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OptionsOtherWindow"
        Me.Text = "OptionsOtherWindow"
        Me.TabTargets.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabControlOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabTargets As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CheckBoxAtariLo As CheckBox
    Friend WithEvents CheckBoxAtari As CheckBox
    Friend WithEvents CheckBoxC128 As CheckBox
    Friend WithEvents CheckBoxC64 As CheckBox
    Friend WithEvents CheckBoxVic2024 As CheckBox
    Friend WithEvents CheckBoxVic20 As CheckBox
    Friend WithEvents CheckBoxC16 As CheckBox
    Friend WithEvents CheckBoxPlus4 As CheckBox
    Friend WithEvents TabControlOptions As TabControl
    Friend WithEvents ButtonFromParent As Button
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents ButtonFromGlobal As Button
    Friend WithEvents ButtonRestore As Button
    Friend WithEvents ButtonApply As Button
    Friend WithEvents ButtonFromProject As Button
End Class
