<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SourceEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SourceEditor))
        Me.ScintillaSource = New ScintillaNET.Scintilla()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompileForToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.C16ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIC20ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIC2024KBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.C64ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.C128ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PLUS4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ATARI8BitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ATARI8BitlowResolutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunOnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.C16ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIC20ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIC2024KBToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.C64ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.C128ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PLUS4ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ATARI8BitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ATARI8BitlowResolutionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ScintillaSource
        '
        Me.ScintillaSource.Location = New System.Drawing.Point(-6, 43)
        Me.ScintillaSource.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ScintillaSource.Name = "ScintillaSource"
        Me.ScintillaSource.Size = New System.Drawing.Size(1340, 824)
        Me.ScintillaSource.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.MakeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1070, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveasToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(274, 26)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveasToolStripMenuItem
        '
        Me.SaveasToolStripMenuItem.Image = CType(resources.GetObject("SaveasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveasToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.SaveasToolStripMenuItem.Name = "SaveasToolStripMenuItem"
        Me.SaveasToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveasToolStripMenuItem.Size = New System.Drawing.Size(274, 26)
        Me.SaveasToolStripMenuItem.Text = "Save &as..."
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(274, 26)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Checked = True
        Me.EditToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.FindToolStripMenuItem, Me.ReplaceToolStripMenuItem})
        Me.EditToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.CutToolStripMenuItem.Text = "C&ut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Image = CType(resources.GetObject("FindToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FindToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.FindToolStripMenuItem.Text = "&Find..."
        '
        'ReplaceToolStripMenuItem
        '
        Me.ReplaceToolStripMenuItem.Image = CType(resources.GetObject("ReplaceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReplaceToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem"
        Me.ReplaceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ReplaceToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.ReplaceToolStripMenuItem.Text = "&Replace..."
        '
        'MakeToolStripMenuItem
        '
        Me.MakeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompileForToolStripMenuItem, Me.RunOnToolStripMenuItem})
        Me.MakeToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
        Me.MakeToolStripMenuItem.Name = "MakeToolStripMenuItem"
        Me.MakeToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.MakeToolStripMenuItem.Text = "&Make"
        '
        'CompileForToolStripMenuItem
        '
        Me.CompileForToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.C16ToolStripMenuItem, Me.VIC20ToolStripMenuItem, Me.VIC2024KBToolStripMenuItem, Me.C64ToolStripMenuItem, Me.C128ToolStripMenuItem, Me.PLUS4ToolStripMenuItem, Me.ATARI8BitToolStripMenuItem, Me.ATARI8BitlowResolutionToolStripMenuItem})
        Me.CompileForToolStripMenuItem.Image = CType(resources.GetObject("CompileForToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CompileForToolStripMenuItem.Name = "CompileForToolStripMenuItem"
        Me.CompileForToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CompileForToolStripMenuItem.Text = "&Compile for"
        '
        'C16ToolStripMenuItem
        '
        Me.C16ToolStripMenuItem.Name = "C16ToolStripMenuItem"
        Me.C16ToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.C16ToolStripMenuItem.Size = New System.Drawing.Size(376, 26)
        Me.C16ToolStripMenuItem.Text = "C16"
        '
        'VIC20ToolStripMenuItem
        '
        Me.VIC20ToolStripMenuItem.Name = "VIC20ToolStripMenuItem"
        Me.VIC20ToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.VIC20ToolStripMenuItem.Size = New System.Drawing.Size(376, 26)
        Me.VIC20ToolStripMenuItem.Text = "VIC-20"
        '
        'VIC2024KBToolStripMenuItem
        '
        Me.VIC2024KBToolStripMenuItem.Name = "VIC2024KBToolStripMenuItem"
        Me.VIC2024KBToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.VIC2024KBToolStripMenuItem.Size = New System.Drawing.Size(376, 26)
        Me.VIC2024KBToolStripMenuItem.Text = "VIC-20 (24 KB)"
        '
        'C64ToolStripMenuItem
        '
        Me.C64ToolStripMenuItem.Name = "C64ToolStripMenuItem"
        Me.C64ToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.D6), System.Windows.Forms.Keys)
        Me.C64ToolStripMenuItem.Size = New System.Drawing.Size(376, 26)
        Me.C64ToolStripMenuItem.Text = "C64"
        '
        'C128ToolStripMenuItem
        '
        Me.C128ToolStripMenuItem.Name = "C128ToolStripMenuItem"
        Me.C128ToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.D8), System.Windows.Forms.Keys)
        Me.C128ToolStripMenuItem.Size = New System.Drawing.Size(376, 26)
        Me.C128ToolStripMenuItem.Text = "C128"
        '
        'PLUS4ToolStripMenuItem
        '
        Me.PLUS4ToolStripMenuItem.Name = "PLUS4ToolStripMenuItem"
        Me.PLUS4ToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.PLUS4ToolStripMenuItem.Size = New System.Drawing.Size(376, 26)
        Me.PLUS4ToolStripMenuItem.Text = "PLUS/4"
        '
        'ATARI8BitToolStripMenuItem
        '
        Me.ATARI8BitToolStripMenuItem.Name = "ATARI8BitToolStripMenuItem"
        Me.ATARI8BitToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ATARI8BitToolStripMenuItem.Size = New System.Drawing.Size(376, 26)
        Me.ATARI8BitToolStripMenuItem.Text = "ATARI (8 bit)"
        '
        'ATARI8BitlowResolutionToolStripMenuItem
        '
        Me.ATARI8BitlowResolutionToolStripMenuItem.Name = "ATARI8BitlowResolutionToolStripMenuItem"
        Me.ATARI8BitlowResolutionToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ATARI8BitlowResolutionToolStripMenuItem.Size = New System.Drawing.Size(376, 26)
        Me.ATARI8BitlowResolutionToolStripMenuItem.Text = "ATARI (8 bit) [low resolution]"
        '
        'RunOnToolStripMenuItem
        '
        Me.RunOnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.C16ToolStripMenuItem1, Me.VIC20ToolStripMenuItem1, Me.VIC2024KBToolStripMenuItem1, Me.C64ToolStripMenuItem1, Me.C128ToolStripMenuItem1, Me.PLUS4ToolStripMenuItem1, Me.ATARI8BitToolStripMenuItem1, Me.ATARI8BitlowResolutionToolStripMenuItem1})
        Me.RunOnToolStripMenuItem.Image = CType(resources.GetObject("RunOnToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RunOnToolStripMenuItem.Name = "RunOnToolStripMenuItem"
        Me.RunOnToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RunOnToolStripMenuItem.Text = "Run on"
        '
        'C16ToolStripMenuItem1
        '
        Me.C16ToolStripMenuItem1.Name = "C16ToolStripMenuItem1"
        Me.C16ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.C16ToolStripMenuItem1.Size = New System.Drawing.Size(333, 26)
        Me.C16ToolStripMenuItem1.Text = "C16"
        '
        'VIC20ToolStripMenuItem1
        '
        Me.VIC20ToolStripMenuItem1.Name = "VIC20ToolStripMenuItem1"
        Me.VIC20ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.VIC20ToolStripMenuItem1.Size = New System.Drawing.Size(333, 26)
        Me.VIC20ToolStripMenuItem1.Text = "VIC-20"
        '
        'VIC2024KBToolStripMenuItem1
        '
        Me.VIC2024KBToolStripMenuItem1.Name = "VIC2024KBToolStripMenuItem1"
        Me.VIC2024KBToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.VIC2024KBToolStripMenuItem1.Size = New System.Drawing.Size(333, 26)
        Me.VIC2024KBToolStripMenuItem1.Text = "VIC-20 (24 KB)"
        '
        'C64ToolStripMenuItem1
        '
        Me.C64ToolStripMenuItem1.Name = "C64ToolStripMenuItem1"
        Me.C64ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D6), System.Windows.Forms.Keys)
        Me.C64ToolStripMenuItem1.Size = New System.Drawing.Size(333, 26)
        Me.C64ToolStripMenuItem1.Text = "C64"
        '
        'C128ToolStripMenuItem1
        '
        Me.C128ToolStripMenuItem1.Name = "C128ToolStripMenuItem1"
        Me.C128ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D8), System.Windows.Forms.Keys)
        Me.C128ToolStripMenuItem1.Size = New System.Drawing.Size(333, 26)
        Me.C128ToolStripMenuItem1.Text = "C128"
        '
        'PLUS4ToolStripMenuItem1
        '
        Me.PLUS4ToolStripMenuItem1.Name = "PLUS4ToolStripMenuItem1"
        Me.PLUS4ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.PLUS4ToolStripMenuItem1.Size = New System.Drawing.Size(333, 26)
        Me.PLUS4ToolStripMenuItem1.Text = "PLUS/4"
        '
        'ATARI8BitToolStripMenuItem1
        '
        Me.ATARI8BitToolStripMenuItem1.Name = "ATARI8BitToolStripMenuItem1"
        Me.ATARI8BitToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ATARI8BitToolStripMenuItem1.Size = New System.Drawing.Size(333, 26)
        Me.ATARI8BitToolStripMenuItem1.Text = "ATARI (8 bit)"
        '
        'ATARI8BitlowResolutionToolStripMenuItem1
        '
        Me.ATARI8BitlowResolutionToolStripMenuItem1.Name = "ATARI8BitlowResolutionToolStripMenuItem1"
        Me.ATARI8BitlowResolutionToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ATARI8BitlowResolutionToolStripMenuItem1.Size = New System.Drawing.Size(333, 26)
        Me.ATARI8BitlowResolutionToolStripMenuItem1.Text = "ATARI (8 bit) [low resolution]"
        '
        'SourceEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 701)
        Me.Controls.Add(Me.ScintillaSource)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SourceEditor"
        Me.Text = "SourceEditor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ScintillaSource As ScintillaNET.Scintilla
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MakeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompileForToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents C64ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VIC20ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VIC2024KBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents C16ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PLUS4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ATARI8BitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ATARI8BitlowResolutionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunOnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents C64ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VIC20ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VIC2024KBToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents C16ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PLUS4ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ATARI8BitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ATARI8BitlowResolutionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents C128ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents C128ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReplaceToolStripMenuItem As ToolStripMenuItem
End Class
