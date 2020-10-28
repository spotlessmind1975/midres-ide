﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsTilesetWindow
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
        Me.ButtonFromProject = New System.Windows.Forms.Button()
        Me.ButtonRestore = New System.Windows.Forms.Button()
        Me.ButtonApply = New System.Windows.Forms.Button()
        Me.TabControlOptions = New System.Windows.Forms.TabControl()
        Me.TabPageTileset = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxTilesetReverse = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTilesetMulticolor = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TrackBarTilesetThresholdLuminance = New System.Windows.Forms.TrackBar()
        Me.TextBoxTilesetHeaderFileName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CheckBoxTilesetVerbose = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTilesetDebug = New System.Windows.Forms.CheckBox()
        Me.TextBoxBankNumber = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxTilesetBinaryFilename = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControlOptions.SuspendLayout()
        Me.TabPageTileset.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
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
        Me.TabPageTileset.Controls.Add(Me.GroupBox8)
        Me.TabPageTileset.Location = New System.Drawing.Point(4, 29)
        Me.TabPageTileset.Name = "TabPageTileset"
        Me.TabPageTileset.Size = New System.Drawing.Size(699, 188)
        Me.TabPageTileset.TabIndex = 5
        Me.TabPageTileset.Text = "Tileset"
        Me.TabPageTileset.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.CheckBoxTilesetReverse)
        Me.GroupBox8.Controls.Add(Me.CheckBoxTilesetMulticolor)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Controls.Add(Me.TrackBarTilesetThresholdLuminance)
        Me.GroupBox8.Controls.Add(Me.TextBoxTilesetHeaderFileName)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.CheckBoxTilesetVerbose)
        Me.GroupBox8.Controls.Add(Me.CheckBoxTilesetDebug)
        Me.GroupBox8.Controls.Add(Me.TextBoxBankNumber)
        Me.GroupBox8.Controls.Add(Me.Label10)
        Me.GroupBox8.Controls.Add(Me.TextBoxTilesetBinaryFilename)
        Me.GroupBox8.Controls.Add(Me.Label5)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(690, 182)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        '
        'CheckBoxTilesetReverse
        '
        Me.CheckBoxTilesetReverse.AutoSize = True
        Me.CheckBoxTilesetReverse.Location = New System.Drawing.Point(531, 92)
        Me.CheckBoxTilesetReverse.Name = "CheckBoxTilesetReverse"
        Me.CheckBoxTilesetReverse.Size = New System.Drawing.Size(127, 24)
        Me.CheckBoxTilesetReverse.TabIndex = 13
        Me.CheckBoxTilesetReverse.Text = "Enable reverse"
        Me.CheckBoxTilesetReverse.UseVisualStyleBackColor = True
        '
        'CheckBoxTilesetMulticolor
        '
        Me.CheckBoxTilesetMulticolor.AutoSize = True
        Me.CheckBoxTilesetMulticolor.Location = New System.Drawing.Point(365, 92)
        Me.CheckBoxTilesetMulticolor.Name = "CheckBoxTilesetMulticolor"
        Me.CheckBoxTilesetMulticolor.Size = New System.Drawing.Size(148, 24)
        Me.CheckBoxTilesetMulticolor.TabIndex = 12
        Me.CheckBoxTilesetMulticolor.Text = "Enable multicolor"
        Me.CheckBoxTilesetMulticolor.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(361, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(146, 20)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Threshold luminance"
        '
        'TrackBarTilesetThresholdLuminance
        '
        Me.TrackBarTilesetThresholdLuminance.BackColor = System.Drawing.SystemColors.Window
        Me.TrackBarTilesetThresholdLuminance.Location = New System.Drawing.Point(365, 48)
        Me.TrackBarTilesetThresholdLuminance.Maximum = 255
        Me.TrackBarTilesetThresholdLuminance.Name = "TrackBarTilesetThresholdLuminance"
        Me.TrackBarTilesetThresholdLuminance.Size = New System.Drawing.Size(316, 56)
        Me.TrackBarTilesetThresholdLuminance.TabIndex = 10
        '
        'TextBoxTilesetHeaderFileName
        '
        Me.TextBoxTilesetHeaderFileName.Location = New System.Drawing.Point(132, 89)
        Me.TextBoxTilesetHeaderFileName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxTilesetHeaderFileName.Name = "TextBoxTilesetHeaderFileName"
        Me.TextBoxTilesetHeaderFileName.Size = New System.Drawing.Size(209, 27)
        Me.TextBoxTilesetHeaderFileName.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 20)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Include filename"
        '
        'CheckBoxTilesetVerbose
        '
        Me.CheckBoxTilesetVerbose.AutoSize = True
        Me.CheckBoxTilesetVerbose.Location = New System.Drawing.Point(11, 152)
        Me.CheckBoxTilesetVerbose.Name = "CheckBoxTilesetVerbose"
        Me.CheckBoxTilesetVerbose.Size = New System.Drawing.Size(132, 24)
        Me.CheckBoxTilesetVerbose.TabIndex = 7
        Me.CheckBoxTilesetVerbose.Text = "Verbose output"
        Me.CheckBoxTilesetVerbose.UseVisualStyleBackColor = True
        '
        'CheckBoxTilesetDebug
        '
        Me.CheckBoxTilesetDebug.AutoSize = True
        Me.CheckBoxTilesetDebug.Location = New System.Drawing.Point(188, 152)
        Me.CheckBoxTilesetDebug.Name = "CheckBoxTilesetDebug"
        Me.CheckBoxTilesetDebug.Size = New System.Drawing.Size(153, 24)
        Me.CheckBoxTilesetDebug.TabIndex = 6
        Me.CheckBoxTilesetDebug.Text = "Enable debugging"
        Me.CheckBoxTilesetDebug.UseVisualStyleBackColor = True
        '
        'TextBoxBankNumber
        '
        Me.TextBoxBankNumber.Location = New System.Drawing.Point(132, 55)
        Me.TextBoxBankNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxBankNumber.Name = "TextBoxBankNumber"
        Me.TextBoxBankNumber.Size = New System.Drawing.Size(209, 27)
        Me.TextBoxBankNumber.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Bank number"
        '
        'TextBoxTilesetBinaryFilename
        '
        Me.TextBoxTilesetBinaryFilename.Location = New System.Drawing.Point(132, 20)
        Me.TextBoxTilesetBinaryFilename.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxTilesetBinaryFilename.Name = "TextBoxTilesetBinaryFilename"
        Me.TextBoxTilesetBinaryFilename.Size = New System.Drawing.Size(209, 27)
        Me.TextBoxTilesetBinaryFilename.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Binary filename"
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
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.TrackBarTilesetThresholdLuminance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonFromGlobal As Button
    Friend WithEvents ButtonFromProject As Button
    Friend WithEvents ButtonRestore As Button
    Friend WithEvents ButtonApply As Button
    Friend WithEvents TabControlOptions As TabControl
    Friend WithEvents TabPageTileset As TabPage
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents CheckBoxTilesetReverse As CheckBox
    Friend WithEvents CheckBoxTilesetMulticolor As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TrackBarTilesetThresholdLuminance As TrackBar
    Friend WithEvents TextBoxTilesetHeaderFileName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CheckBoxTilesetVerbose As CheckBox
    Friend WithEvents CheckBoxTilesetDebug As CheckBox
    Friend WithEvents TextBoxBankNumber As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxTilesetBinaryFilename As TextBox
    Friend WithEvents Label5 As Label
End Class