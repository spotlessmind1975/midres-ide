<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OutputWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OutputWindow))
        Me.ListBoxOutput = New System.Windows.Forms.ListBox()
        Me.ContextMenuStripWarnings = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.IgnoreMessagenextTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnThisFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnThisfolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnThisProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GloballyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxOutputLevel = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStripWarnings.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxOutput
        '
        Me.ListBoxOutput.ContextMenuStrip = Me.ContextMenuStripWarnings
        Me.ListBoxOutput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ListBoxOutput.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxOutput.FormattingEnabled = True
        Me.ListBoxOutput.ItemHeight = 17
        Me.ListBoxOutput.Location = New System.Drawing.Point(3, 39)
        Me.ListBoxOutput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBoxOutput.Name = "ListBoxOutput"
        Me.ListBoxOutput.Size = New System.Drawing.Size(803, 514)
        Me.ListBoxOutput.TabIndex = 0
        '
        'ContextMenuStripWarnings
        '
        Me.ContextMenuStripWarnings.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStripWarnings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IgnoreMessagenextTimeToolStripMenuItem})
        Me.ContextMenuStripWarnings.Name = "ContextMenuStripWarnings"
        Me.ContextMenuStripWarnings.Size = New System.Drawing.Size(260, 28)
        '
        'IgnoreMessagenextTimeToolStripMenuItem
        '
        Me.IgnoreMessagenextTimeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnThisFileToolStripMenuItem, Me.OnThisfolderToolStripMenuItem, Me.OnThisProjectToolStripMenuItem, Me.GloballyToolStripMenuItem})
        Me.IgnoreMessagenextTimeToolStripMenuItem.Name = "IgnoreMessagenextTimeToolStripMenuItem"
        Me.IgnoreMessagenextTimeToolStripMenuItem.Size = New System.Drawing.Size(259, 24)
        Me.IgnoreMessagenextTimeToolStripMenuItem.Text = "Ignore message (next time)"
        '
        'OnThisFileToolStripMenuItem
        '
        Me.OnThisFileToolStripMenuItem.Name = "OnThisFileToolStripMenuItem"
        Me.OnThisFileToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.OnThisFileToolStripMenuItem.Text = "On this file"
        '
        'OnThisfolderToolStripMenuItem
        '
        Me.OnThisfolderToolStripMenuItem.Name = "OnThisfolderToolStripMenuItem"
        Me.OnThisfolderToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.OnThisfolderToolStripMenuItem.Text = "On this &folder"
        '
        'OnThisProjectToolStripMenuItem
        '
        Me.OnThisProjectToolStripMenuItem.Name = "OnThisProjectToolStripMenuItem"
        Me.OnThisProjectToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.OnThisProjectToolStripMenuItem.Text = "On this project"
        '
        'GloballyToolStripMenuItem
        '
        Me.GloballyToolStripMenuItem.Name = "GloballyToolStripMenuItem"
        Me.GloballyToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.GloballyToolStripMenuItem.Text = "Globally"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Minimum level to show"
        '
        'ComboBoxOutputLevel
        '
        Me.ComboBoxOutputLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxOutputLevel.FormattingEnabled = True
        Me.ComboBoxOutputLevel.Items.AddRange(New Object() {"TRACE - detailed info on program execution", "DEBUG - less detailed info on program execution", "INFO - main informational messages", "WARNINGS - warnings only", "ERRORS - errors only (not warnings)", "CRITICAL ERRORS - critical errors only (not simply errors)"})
        Me.ComboBoxOutputLevel.Location = New System.Drawing.Point(182, 4)
        Me.ComboBoxOutputLevel.Name = "ComboBoxOutputLevel"
        Me.ComboBoxOutputLevel.Size = New System.Drawing.Size(610, 28)
        Me.ComboBoxOutputLevel.TabIndex = 1
        '
        'OutputWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 571)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxOutputLevel)
        Me.Controls.Add(Me.ListBoxOutput)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OutputWindow"
        Me.Text = "Output"
        Me.ContextMenuStripWarnings.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxOutput As ListBox
    Friend WithEvents ContextMenuStripWarnings As ContextMenuStrip
    Friend WithEvents IgnoreMessagenextTimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnThisfolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnThisProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GloballyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnThisFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxOutputLevel As ComboBox
End Class
