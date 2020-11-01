<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorOutputWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErrorOutputWindow))
        Me.ListBoxOutput = New System.Windows.Forms.ListBox()
        Me.ContextMenuStripWarnings = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.IgnoreMessagenextTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnThisfolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnThisProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GloballyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnThisFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripWarnings.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxOutput
        '
        Me.ListBoxOutput.ContextMenuStrip = Me.ContextMenuStripWarnings
        Me.ListBoxOutput.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxOutput.FormattingEnabled = True
        Me.ListBoxOutput.ItemHeight = 17
        Me.ListBoxOutput.Location = New System.Drawing.Point(25, 53)
        Me.ListBoxOutput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBoxOutput.Name = "ListBoxOutput"
        Me.ListBoxOutput.Size = New System.Drawing.Size(960, 548)
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
        'OnThisfolderToolStripMenuItem
        '
        Me.OnThisfolderToolStripMenuItem.Name = "OnThisfolderToolStripMenuItem"
        Me.OnThisfolderToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OnThisfolderToolStripMenuItem.Text = "On this &folder"
        '
        'OnThisProjectToolStripMenuItem
        '
        Me.OnThisProjectToolStripMenuItem.Name = "OnThisProjectToolStripMenuItem"
        Me.OnThisProjectToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OnThisProjectToolStripMenuItem.Text = "On this project"
        '
        'GloballyToolStripMenuItem
        '
        Me.GloballyToolStripMenuItem.Name = "GloballyToolStripMenuItem"
        Me.GloballyToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.GloballyToolStripMenuItem.Text = "Globally"
        '
        'OnThisFileToolStripMenuItem
        '
        Me.OnThisFileToolStripMenuItem.Name = "OnThisFileToolStripMenuItem"
        Me.OnThisFileToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OnThisFileToolStripMenuItem.Text = "On this file"
        '
        'ErrorOutputWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 571)
        Me.Controls.Add(Me.ListBoxOutput)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ErrorOutputWindow"
        Me.Text = "Errors"
        Me.ContextMenuStripWarnings.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxOutput As ListBox
    Friend WithEvents ContextMenuStripWarnings As ContextMenuStrip
    Friend WithEvents IgnoreMessagenextTimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnThisfolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnThisProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GloballyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnThisFileToolStripMenuItem As ToolStripMenuItem
End Class
