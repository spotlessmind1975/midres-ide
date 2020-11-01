<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OptionsTilesetWindow
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
        Me.ButtonFromProject = New System.Windows.Forms.Button()
        Me.ButtonRestore = New System.Windows.Forms.Button()
        Me.ButtonApply = New System.Windows.Forms.Button()
        Me.TabControlOptions = New System.Windows.Forms.TabControl()
        Me.TabPageTileset = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBoxTilesetReverse = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTilesetMulticolor = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TrackBarTilesetThresholdLuminance = New System.Windows.Forms.TrackBar()
        Me.TextBoxTilesetHeaderFileName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxBankNumber = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxTilesetBinaryFilename = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelThresholdLuminance = New System.Windows.Forms.Label()
        Me.TabControlOptions.SuspendLayout()
        Me.TabPageTileset.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TrackBarTilesetThresholdLuminance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonFromGlobal
        '
        Me.ButtonFromGlobal.Location = New System.Drawing.Point(313, 233)
        Me.ButtonFromGlobal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonFromGlobal.Name = "ButtonFromGlobal"
        Me.ButtonFromGlobal.Size = New System.Drawing.Size(125, 44)
        Me.ButtonFromGlobal.TabIndex = 9
        Me.ButtonFromGlobal.Text = "From Global"
        Me.ButtonFromGlobal.UseVisualStyleBackColor = True
        '
        'ButtonFromProject
        '
        Me.ButtonFromProject.Location = New System.Drawing.Point(448, 233)
        Me.ButtonFromProject.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonFromProject.Name = "ButtonFromProject"
        Me.ButtonFromProject.Size = New System.Drawing.Size(125, 44)
        Me.ButtonFromProject.TabIndex = 8
        Me.ButtonFromProject.Text = "From Project"
        Me.ButtonFromProject.UseVisualStyleBackColor = True
        '
        'ButtonRestore
        '
        Me.ButtonRestore.Location = New System.Drawing.Point(3, 233)
        Me.ButtonRestore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonRestore.Name = "ButtonRestore"
        Me.ButtonRestore.Size = New System.Drawing.Size(125, 44)
        Me.ButtonRestore.TabIndex = 7
        Me.ButtonRestore.Text = "Restore"
        Me.ButtonRestore.UseVisualStyleBackColor = True
        '
        'ButtonApply
        '
        Me.ButtonApply.Location = New System.Drawing.Point(583, 233)
        Me.ButtonApply.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonApply.Name = "ButtonApply"
        Me.ButtonApply.Size = New System.Drawing.Size(125, 44)
        Me.ButtonApply.TabIndex = 6
        Me.ButtonApply.Text = "Apply"
        Me.ButtonApply.UseVisualStyleBackColor = True
        '
        'TabControlOptions
        '
        Me.TabControlOptions.Controls.Add(Me.TabPageTileset)
        Me.TabControlOptions.Location = New System.Drawing.Point(6, 5)
        Me.TabControlOptions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlOptions.Name = "TabControlOptions"
        Me.TabControlOptions.SelectedIndex = 0
        Me.TabControlOptions.Size = New System.Drawing.Size(707, 221)
        Me.TabControlOptions.TabIndex = 5
        '
        'TabPageTileset
        '
        Me.TabPageTileset.Controls.Add(Me.Panel1)
        Me.TabPageTileset.Location = New System.Drawing.Point(4, 29)
        Me.TabPageTileset.Name = "TabPageTileset"
        Me.TabPageTileset.Size = New System.Drawing.Size(699, 188)
        Me.TabPageTileset.TabIndex = 5
        Me.TabPageTileset.Text = "Generate"
        Me.TabPageTileset.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelThresholdLuminance)
        Me.Panel1.Controls.Add(Me.CheckBoxTilesetReverse)
        Me.Panel1.Controls.Add(Me.CheckBoxTilesetMulticolor)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TrackBarTilesetThresholdLuminance)
        Me.Panel1.Controls.Add(Me.TextBoxTilesetHeaderFileName)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.TextBoxBankNumber)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TextBoxTilesetBinaryFilename)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 182)
        Me.Panel1.TabIndex = 0
        '
        'CheckBoxTilesetReverse
        '
        Me.CheckBoxTilesetReverse.AutoSize = True
        Me.CheckBoxTilesetReverse.Location = New System.Drawing.Point(556, 128)
        Me.CheckBoxTilesetReverse.Name = "CheckBoxTilesetReverse"
        Me.CheckBoxTilesetReverse.Size = New System.Drawing.Size(127, 24)
        Me.CheckBoxTilesetReverse.TabIndex = 23
        Me.CheckBoxTilesetReverse.Text = "Enable reverse"
        Me.CheckBoxTilesetReverse.UseVisualStyleBackColor = True
        '
        'CheckBoxTilesetMulticolor
        '
        Me.CheckBoxTilesetMulticolor.AutoSize = True
        Me.CheckBoxTilesetMulticolor.Location = New System.Drawing.Point(300, 128)
        Me.CheckBoxTilesetMulticolor.Name = "CheckBoxTilesetMulticolor"
        Me.CheckBoxTilesetMulticolor.Size = New System.Drawing.Size(148, 24)
        Me.CheckBoxTilesetMulticolor.TabIndex = 22
        Me.CheckBoxTilesetMulticolor.Text = "Enable multicolor"
        Me.CheckBoxTilesetMulticolor.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(296, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(146, 20)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Threshold luminance"
        '
        'TrackBarTilesetThresholdLuminance
        '
        Me.TrackBarTilesetThresholdLuminance.BackColor = System.Drawing.SystemColors.Window
        Me.TrackBarTilesetThresholdLuminance.Location = New System.Drawing.Point(287, 72)
        Me.TrackBarTilesetThresholdLuminance.Maximum = 255
        Me.TrackBarTilesetThresholdLuminance.Name = "TrackBarTilesetThresholdLuminance"
        Me.TrackBarTilesetThresholdLuminance.Size = New System.Drawing.Size(343, 56)
        Me.TrackBarTilesetThresholdLuminance.TabIndex = 20
        '
        'TextBoxTilesetHeaderFileName
        '
        Me.TextBoxTilesetHeaderFileName.Location = New System.Drawing.Point(7, 140)
        Me.TextBoxTilesetHeaderFileName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxTilesetHeaderFileName.Name = "TextBoxTilesetHeaderFileName"
        Me.TextBoxTilesetHeaderFileName.Size = New System.Drawing.Size(209, 27)
        Me.TextBoxTilesetHeaderFileName.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 20)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Include filename"
        '
        'TextBoxBankNumber
        '
        Me.TextBoxBankNumber.Location = New System.Drawing.Point(7, 85)
        Me.TextBoxBankNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxBankNumber.Name = "TextBoxBankNumber"
        Me.TextBoxBankNumber.Size = New System.Drawing.Size(209, 27)
        Me.TextBoxBankNumber.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Bank number"
        '
        'TextBoxTilesetBinaryFilename
        '
        Me.TextBoxTilesetBinaryFilename.Location = New System.Drawing.Point(7, 30)
        Me.TextBoxTilesetBinaryFilename.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxTilesetBinaryFilename.Name = "TextBoxTilesetBinaryFilename"
        Me.TextBoxTilesetBinaryFilename.Size = New System.Drawing.Size(209, 27)
        Me.TextBoxTilesetBinaryFilename.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Binary filename"
        '
        'LabelThresholdLuminance
        '
        Me.LabelThresholdLuminance.BackColor = System.Drawing.SystemColors.Control
        Me.LabelThresholdLuminance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelThresholdLuminance.Location = New System.Drawing.Point(636, 72)
        Me.LabelThresholdLuminance.Name = "LabelThresholdLuminance"
        Me.LabelThresholdLuminance.Size = New System.Drawing.Size(36, 29)
        Me.LabelThresholdLuminance.TabIndex = 25
        Me.LabelThresholdLuminance.Text = "6"
        Me.LabelThresholdLuminance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OptionsTilesetWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 282)
        Me.Controls.Add(Me.ButtonFromGlobal)
        Me.Controls.Add(Me.ButtonFromProject)
        Me.Controls.Add(Me.ButtonRestore)
        Me.Controls.Add(Me.ButtonApply)
        Me.Controls.Add(Me.TabControlOptions)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OptionsTilesetWindow"
        Me.Text = "OptionsTilesetWindow"
        Me.TabControlOptions.ResumeLayout(False)
        Me.TabPageTileset.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TrackBarTilesetThresholdLuminance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonFromGlobal As Button
    Friend WithEvents ButtonFromProject As Button
    Friend WithEvents ButtonRestore As Button
    Friend WithEvents ButtonApply As Button
    Friend WithEvents TabControlOptions As TabControl
    Friend WithEvents TabPageTileset As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBoxTilesetReverse As CheckBox
    Friend WithEvents CheckBoxTilesetMulticolor As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TrackBarTilesetThresholdLuminance As TrackBar
    Friend WithEvents TextBoxTilesetHeaderFileName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBoxBankNumber As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxTilesetBinaryFilename As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelThresholdLuminance As Label
End Class
