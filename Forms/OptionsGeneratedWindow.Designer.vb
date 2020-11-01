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
        Me.TabPageTileset = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.CheckedListBoxDependency = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonApply = New System.Windows.Forms.Button()
        Me.TabControlOptions = New System.Windows.Forms.TabControl()
        Me.TabPageTileset.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TabControlOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPageTileset
        '
        Me.TabPageTileset.Controls.Add(Me.GroupBox8)
        Me.TabPageTileset.Location = New System.Drawing.Point(4, 29)
        Me.TabPageTileset.Name = "TabPageTileset"
        Me.TabPageTileset.Size = New System.Drawing.Size(699, 188)
        Me.TabPageTileset.TabIndex = 5
        Me.TabPageTileset.Text = "Details"
        Me.TabPageTileset.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.CheckedListBoxDependency)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(690, 182)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        '
        'CheckedListBoxDependency
        '
        Me.CheckedListBoxDependency.FormattingEnabled = True
        Me.CheckedListBoxDependency.Location = New System.Drawing.Point(10, 46)
        Me.CheckedListBoxDependency.Name = "CheckedListBoxDependency"
        Me.CheckedListBoxDependency.Size = New System.Drawing.Size(674, 114)
        Me.CheckedListBoxDependency.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Set dependency for this file:"
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
        Me.TabControlOptions.Controls.Add(Me.TabPageTileset)
        Me.TabControlOptions.Location = New System.Drawing.Point(12, 11)
        Me.TabControlOptions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlOptions.Name = "TabControlOptions"
        Me.TabControlOptions.SelectedIndex = 0
        Me.TabControlOptions.Size = New System.Drawing.Size(707, 221)
        Me.TabControlOptions.TabIndex = 10
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
        Me.TabPageTileset.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.TabControlOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPageTileset As TabPage
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents CheckedListBoxDependency As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonApply As Button
    Friend WithEvents TabControlOptions As TabControl
End Class
