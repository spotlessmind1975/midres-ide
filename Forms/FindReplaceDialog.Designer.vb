<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindReplaceDialog
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindReplaceDialog))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxSearchText = New System.Windows.Forms.TextBox()
        Me.CheckBoxMatchCase = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMatchWholeWord = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRegex = New System.Windows.Forms.CheckBox()
        Me.ButtonReplaceAll = New System.Windows.Forms.Button()
        Me.TimerFocus = New System.Windows.Forms.Timer(Me.components)
        Me.TextBoxReplaceText = New System.Windows.Forms.TextBox()
        Me.LabelReplace = New System.Windows.Forms.Label()
        Me.ButtonReplace = New System.Windows.Forms.Button()
        Me.ButtonFindNext = New System.Windows.Forms.Button()
        Me.TextBoxPath = New System.Windows.Forms.TextBox()
        Me.LabelPath = New System.Windows.Forms.Label()
        Me.TextBoxFileMask = New System.Windows.Forms.TextBox()
        Me.LabelFileMask = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Find:"
        '
        'TextBoxSearchText
        '
        Me.TextBoxSearchText.Location = New System.Drawing.Point(73, 7)
        Me.TextBoxSearchText.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxSearchText.Name = "TextBoxSearchText"
        Me.TextBoxSearchText.Size = New System.Drawing.Size(333, 27)
        Me.TextBoxSearchText.TabIndex = 1
        '
        'CheckBoxMatchCase
        '
        Me.CheckBoxMatchCase.AutoSize = True
        Me.CheckBoxMatchCase.Location = New System.Drawing.Point(412, 6)
        Me.CheckBoxMatchCase.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxMatchCase.Name = "CheckBoxMatchCase"
        Me.CheckBoxMatchCase.Size = New System.Drawing.Size(105, 24)
        Me.CheckBoxMatchCase.TabIndex = 2
        Me.CheckBoxMatchCase.Text = "Match case"
        Me.CheckBoxMatchCase.UseVisualStyleBackColor = True
        '
        'CheckBoxMatchWholeWord
        '
        Me.CheckBoxMatchWholeWord.AutoSize = True
        Me.CheckBoxMatchWholeWord.Location = New System.Drawing.Point(412, 79)
        Me.CheckBoxMatchWholeWord.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxMatchWholeWord.Name = "CheckBoxMatchWholeWord"
        Me.CheckBoxMatchWholeWord.Size = New System.Drawing.Size(154, 24)
        Me.CheckBoxMatchWholeWord.TabIndex = 3
        Me.CheckBoxMatchWholeWord.Text = "Match whole word"
        Me.CheckBoxMatchWholeWord.UseVisualStyleBackColor = True
        '
        'CheckBoxRegex
        '
        Me.CheckBoxRegex.AutoSize = True
        Me.CheckBoxRegex.Location = New System.Drawing.Point(412, 43)
        Me.CheckBoxRegex.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxRegex.Name = "CheckBoxRegex"
        Me.CheckBoxRegex.Size = New System.Drawing.Size(72, 24)
        Me.CheckBoxRegex.TabIndex = 4
        Me.CheckBoxRegex.Text = "Regex"
        Me.CheckBoxRegex.UseVisualStyleBackColor = True
        '
        'ButtonReplaceAll
        '
        Me.ButtonReplaceAll.Location = New System.Drawing.Point(396, 115)
        Me.ButtonReplaceAll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonReplaceAll.Name = "ButtonReplaceAll"
        Me.ButtonReplaceAll.Size = New System.Drawing.Size(170, 32)
        Me.ButtonReplaceAll.TabIndex = 17
        Me.ButtonReplaceAll.Text = "REPL. ALL"
        Me.ButtonReplaceAll.UseVisualStyleBackColor = True
        Me.ButtonReplaceAll.Visible = False
        '
        'TimerFocus
        '
        Me.TimerFocus.Interval = 400
        '
        'TextBoxReplaceText
        '
        Me.TextBoxReplaceText.Location = New System.Drawing.Point(73, 42)
        Me.TextBoxReplaceText.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxReplaceText.Name = "TextBoxReplaceText"
        Me.TextBoxReplaceText.Size = New System.Drawing.Size(333, 27)
        Me.TextBoxReplaceText.TabIndex = 20
        Me.TextBoxReplaceText.Visible = False
        '
        'LabelReplace
        '
        Me.LabelReplace.AutoSize = True
        Me.LabelReplace.Location = New System.Drawing.Point(5, 42)
        Me.LabelReplace.Name = "LabelReplace"
        Me.LabelReplace.Size = New System.Drawing.Size(62, 25)
        Me.LabelReplace.TabIndex = 19
        Me.LabelReplace.Text = "Replace:"
        Me.LabelReplace.UseCompatibleTextRendering = True
        Me.LabelReplace.Visible = False
        '
        'ButtonReplace
        '
        Me.ButtonReplace.Location = New System.Drawing.Point(186, 115)
        Me.ButtonReplace.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonReplace.Name = "ButtonReplace"
        Me.ButtonReplace.Size = New System.Drawing.Size(170, 32)
        Me.ButtonReplace.TabIndex = 21
        Me.ButtonReplace.Text = "REPLACE"
        Me.ButtonReplace.UseVisualStyleBackColor = True
        Me.ButtonReplace.Visible = False
        '
        'ButtonFindNext
        '
        Me.ButtonFindNext.Location = New System.Drawing.Point(5, 115)
        Me.ButtonFindNext.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonFindNext.Name = "ButtonFindNext"
        Me.ButtonFindNext.Size = New System.Drawing.Size(136, 32)
        Me.ButtonFindNext.TabIndex = 22
        Me.ButtonFindNext.Text = "FIND"
        Me.ButtonFindNext.UseVisualStyleBackColor = True
        '
        'TextBoxPath
        '
        Me.TextBoxPath.Location = New System.Drawing.Point(73, 77)
        Me.TextBoxPath.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxPath.Name = "TextBoxPath"
        Me.TextBoxPath.Size = New System.Drawing.Size(189, 27)
        Me.TextBoxPath.TabIndex = 24
        Me.TextBoxPath.Text = ".\"
        Me.TextBoxPath.Visible = False
        '
        'LabelPath
        '
        Me.LabelPath.AutoSize = True
        Me.LabelPath.Location = New System.Drawing.Point(28, 77)
        Me.LabelPath.Name = "LabelPath"
        Me.LabelPath.Size = New System.Drawing.Size(39, 25)
        Me.LabelPath.TabIndex = 23
        Me.LabelPath.Text = "Path:"
        Me.LabelPath.UseCompatibleTextRendering = True
        Me.LabelPath.Visible = False
        '
        'TextBoxFileMask
        '
        Me.TextBoxFileMask.Location = New System.Drawing.Point(318, 77)
        Me.TextBoxFileMask.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxFileMask.Name = "TextBoxFileMask"
        Me.TextBoxFileMask.Size = New System.Drawing.Size(88, 27)
        Me.TextBoxFileMask.TabIndex = 26
        Me.TextBoxFileMask.Text = "*.c;*.h"
        Me.TextBoxFileMask.Visible = False
        '
        'LabelFileMask
        '
        Me.LabelFileMask.AutoSize = True
        Me.LabelFileMask.Location = New System.Drawing.Point(271, 77)
        Me.LabelFileMask.Name = "LabelFileMask"
        Me.LabelFileMask.Size = New System.Drawing.Size(45, 25)
        Me.LabelFileMask.TabIndex = 25
        Me.LabelFileMask.Text = "Mask:"
        Me.LabelFileMask.UseCompatibleTextRendering = True
        Me.LabelFileMask.Visible = False
        '
        'FindReplaceDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 158)
        Me.Controls.Add(Me.TextBoxFileMask)
        Me.Controls.Add(Me.LabelFileMask)
        Me.Controls.Add(Me.TextBoxPath)
        Me.Controls.Add(Me.LabelPath)
        Me.Controls.Add(Me.ButtonFindNext)
        Me.Controls.Add(Me.ButtonReplace)
        Me.Controls.Add(Me.TextBoxReplaceText)
        Me.Controls.Add(Me.LabelReplace)
        Me.Controls.Add(Me.ButtonReplaceAll)
        Me.Controls.Add(Me.CheckBoxRegex)
        Me.Controls.Add(Me.CheckBoxMatchWholeWord)
        Me.Controls.Add(Me.CheckBoxMatchCase)
        Me.Controls.Add(Me.TextBoxSearchText)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindReplaceDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Find"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxSearchText As TextBox
    Friend WithEvents CheckBoxMatchCase As CheckBox
    Friend WithEvents CheckBoxMatchWholeWord As CheckBox
    Friend WithEvents CheckBoxRegex As CheckBox
    Friend WithEvents ButtonReplaceAll As Button
    Friend WithEvents TimerFocus As Timer
    Friend WithEvents TextBoxReplaceText As TextBox
    Friend WithEvents LabelReplace As Label
    Friend WithEvents ButtonReplace As Button
    Friend WithEvents ButtonFindNext As Button
    Friend WithEvents TextBoxPath As TextBox
    Friend WithEvents LabelPath As Label
    Friend WithEvents TextBoxFileMask As TextBox
    Friend WithEvents LabelFileMask As Label
End Class
