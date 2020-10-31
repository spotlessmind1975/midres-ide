<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsCC65Window
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
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxForgetIncPath = New System.Windows.Forms.CheckBox()
        Me.ListBoxIncludeDirs = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SymbolValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SymbolName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewSymbols = New System.Windows.Forms.DataGridView()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.TrackBarRegisterSpace = New System.Windows.Forms.TrackBar()
        Me.CheckBoxCpu65C02 = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CheckBoxSignedChars = New System.Windows.Forms.CheckBox()
        Me.CheckBoxInlineFunctions = New System.Windows.Forms.CheckBox()
        Me.TabPageSymbols = New System.Windows.Forms.TabPage()
        Me.CheckBoxRegisterVars = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOptimizeCode = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStaticLocals = New System.Windows.Forms.CheckBox()
        Me.TrackBarCodeSize = New System.Windows.Forms.TrackBar()
        Me.TabPageIncludeDirs = New System.Windows.Forms.TabPage()
        Me.CheckBoxAtariLo = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAtari = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC128 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC64 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVic2024 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOptimizeCodeInline = New System.Windows.Forms.CheckBox()
        Me.TabPageOptimizations = New System.Windows.Forms.TabPage()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.ButtonFromGlobal = New System.Windows.Forms.Button()
        Me.ButtonRestore = New System.Windows.Forms.Button()
        Me.ButtonApply = New System.Windows.Forms.Button()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxWritableStrings = New System.Windows.Forms.CheckBox()
        Me.TextBoxRoDataName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBoxDataName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBoxCodeName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxBssName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabPageSegments = New System.Windows.Forms.TabPage()
        Me.CheckBoxDebugInfo = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAddSource = New System.Windows.Forms.CheckBox()
        Me.CheckedListBoxCC65Warnings = New System.Windows.Forms.CheckedListBox()
        Me.CheckBoxSuppressWarnings = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCreateDep = New System.Windows.Forms.CheckBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxCheckStack = New System.Windows.Forms.CheckBox()
        Me.TabPageDebug = New System.Windows.Forms.TabPage()
        Me.CheckBoxVic20 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBoxBinaryFileName = New System.Windows.Forms.TextBox()
        Me.TabPageOutput = New System.Windows.Forms.TabPage()
        Me.TabControlOptions = New System.Windows.Forms.TabControl()
        Me.TabPageCC65 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonC99 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonC89 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCC65 = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxC16 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPlus4 = New System.Windows.Forms.CheckBox()
        Me.ButtonFromProject = New System.Windows.Forms.Button()
        Me.GroupBox10.SuspendLayout()
        CType(Me.DataGridViewSymbols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.TrackBarRegisterSpace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageSymbols.SuspendLayout()
        CType(Me.TrackBarCodeSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageIncludeDirs.SuspendLayout()
        Me.TabPageOptimizations.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.TabPageSegments.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.TabPageDebug.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPageOutput.SuspendLayout()
        Me.TabControlOptions.SuspendLayout()
        Me.TabPageCC65.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.CheckBoxForgetIncPath)
        Me.GroupBox10.Controls.Add(Me.ListBoxIncludeDirs)
        Me.GroupBox10.Controls.Add(Me.Label10)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(690, 182)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        '
        'CheckBoxForgetIncPath
        '
        Me.CheckBoxForgetIncPath.AutoSize = True
        Me.CheckBoxForgetIncPath.Location = New System.Drawing.Point(460, 11)
        Me.CheckBoxForgetIncPath.Name = "CheckBoxForgetIncPath"
        Me.CheckBoxForgetIncPath.Size = New System.Drawing.Size(212, 24)
        Me.CheckBoxForgetIncPath.TabIndex = 2
        Me.CheckBoxForgetIncPath.Text = "Forget include search paths"
        Me.CheckBoxForgetIncPath.UseVisualStyleBackColor = True
        '
        'ListBoxIncludeDirs
        '
        Me.ListBoxIncludeDirs.FormattingEnabled = True
        Me.ListBoxIncludeDirs.ItemHeight = 20
        Me.ListBoxIncludeDirs.Location = New System.Drawing.Point(6, 41)
        Me.ListBoxIncludeDirs.Name = "ListBoxIncludeDirs"
        Me.ListBoxIncludeDirs.Size = New System.Drawing.Size(675, 124)
        Me.ListBoxIncludeDirs.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Paths for include files:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Symbols defined"
        '
        'SymbolValue
        '
        Me.SymbolValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SymbolValue.HeaderText = "Value"
        Me.SymbolValue.MinimumWidth = 6
        Me.SymbolValue.Name = "SymbolValue"
        Me.SymbolValue.Width = 74
        '
        'SymbolName
        '
        Me.SymbolName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.SymbolName.HeaderText = "Name"
        Me.SymbolName.MinimumWidth = 6
        Me.SymbolName.Name = "SymbolName"
        Me.SymbolName.Width = 78
        '
        'DataGridViewSymbols
        '
        Me.DataGridViewSymbols.AllowUserToOrderColumns = True
        Me.DataGridViewSymbols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSymbols.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SymbolName, Me.SymbolValue})
        Me.DataGridViewSymbols.Location = New System.Drawing.Point(6, 33)
        Me.DataGridViewSymbols.Name = "DataGridViewSymbols"
        Me.DataGridViewSymbols.RowHeadersWidth = 51
        Me.DataGridViewSymbols.RowTemplate.Height = 24
        Me.DataGridViewSymbols.Size = New System.Drawing.Size(675, 143)
        Me.DataGridViewSymbols.TabIndex = 1
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.DataGridViewSymbols)
        Me.GroupBox9.Controls.Add(Me.Label5)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(690, 182)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        '
        'TrackBarRegisterSpace
        '
        Me.TrackBarRegisterSpace.BackColor = System.Drawing.SystemColors.Window
        Me.TrackBarRegisterSpace.Enabled = False
        Me.TrackBarRegisterSpace.Location = New System.Drawing.Point(349, 120)
        Me.TrackBarRegisterSpace.Name = "TrackBarRegisterSpace"
        Me.TrackBarRegisterSpace.Size = New System.Drawing.Size(332, 56)
        Me.TrackBarRegisterSpace.TabIndex = 9
        '
        'CheckBoxCpu65C02
        '
        Me.CheckBoxCpu65C02.AutoSize = True
        Me.CheckBoxCpu65C02.Location = New System.Drawing.Point(6, 134)
        Me.CheckBoxCpu65C02.Name = "CheckBoxCpu65C02"
        Me.CheckBoxCpu65C02.Size = New System.Drawing.Size(197, 24)
        Me.CheckBoxCpu65C02.TabIndex = 8
        Me.CheckBoxCpu65C02.Text = "Generate 65C02 opcodes"
        Me.CheckBoxCpu65C02.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(357, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(201, 20)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Accept larger code by factor:"
        '
        'CheckBoxSignedChars
        '
        Me.CheckBoxSignedChars.AutoSize = True
        Me.CheckBoxSignedChars.Location = New System.Drawing.Point(359, 14)
        Me.CheckBoxSignedChars.Name = "CheckBoxSignedChars"
        Me.CheckBoxSignedChars.Size = New System.Drawing.Size(224, 24)
        Me.CheckBoxSignedChars.TabIndex = 5
        Me.CheckBoxSignedChars.Text = "Default characters are signed"
        Me.CheckBoxSignedChars.UseVisualStyleBackColor = True
        '
        'CheckBoxInlineFunctions
        '
        Me.CheckBoxInlineFunctions.AutoSize = True
        Me.CheckBoxInlineFunctions.Location = New System.Drawing.Point(6, 104)
        Me.CheckBoxInlineFunctions.Name = "CheckBoxInlineFunctions"
        Me.CheckBoxInlineFunctions.Size = New System.Drawing.Size(218, 24)
        Me.CheckBoxInlineFunctions.TabIndex = 4
        Me.CheckBoxInlineFunctions.Text = "Inline some known functions"
        Me.CheckBoxInlineFunctions.UseVisualStyleBackColor = True
        '
        'TabPageSymbols
        '
        Me.TabPageSymbols.Controls.Add(Me.GroupBox9)
        Me.TabPageSymbols.Location = New System.Drawing.Point(4, 29)
        Me.TabPageSymbols.Name = "TabPageSymbols"
        Me.TabPageSymbols.Size = New System.Drawing.Size(699, 188)
        Me.TabPageSymbols.TabIndex = 6
        Me.TabPageSymbols.Text = "Symbols"
        Me.TabPageSymbols.UseVisualStyleBackColor = True
        '
        'CheckBoxRegisterVars
        '
        Me.CheckBoxRegisterVars.AutoSize = True
        Me.CheckBoxRegisterVars.Location = New System.Drawing.Point(359, 92)
        Me.CheckBoxRegisterVars.Name = "CheckBoxRegisterVars"
        Me.CheckBoxRegisterVars.Size = New System.Drawing.Size(305, 24)
        Me.CheckBoxRegisterVars.TabIndex = 3
        Me.CheckBoxRegisterVars.Text = "Enable register variables, space available:"
        Me.CheckBoxRegisterVars.UseVisualStyleBackColor = True
        '
        'CheckBoxOptimizeCode
        '
        Me.CheckBoxOptimizeCode.AutoSize = True
        Me.CheckBoxOptimizeCode.Location = New System.Drawing.Point(6, 44)
        Me.CheckBoxOptimizeCode.Name = "CheckBoxOptimizeCode"
        Me.CheckBoxOptimizeCode.Size = New System.Drawing.Size(129, 24)
        Me.CheckBoxOptimizeCode.TabIndex = 1
        Me.CheckBoxOptimizeCode.Text = "Optimize code"
        Me.CheckBoxOptimizeCode.UseVisualStyleBackColor = True
        '
        'CheckBoxStaticLocals
        '
        Me.CheckBoxStaticLocals.AutoSize = True
        Me.CheckBoxStaticLocals.Location = New System.Drawing.Point(6, 14)
        Me.CheckBoxStaticLocals.Name = "CheckBoxStaticLocals"
        Me.CheckBoxStaticLocals.Size = New System.Drawing.Size(205, 24)
        Me.CheckBoxStaticLocals.TabIndex = 0
        Me.CheckBoxStaticLocals.Text = "Make local variables static"
        Me.CheckBoxStaticLocals.UseVisualStyleBackColor = True
        '
        'TrackBarCodeSize
        '
        Me.TrackBarCodeSize.BackColor = System.Drawing.SystemColors.Window
        Me.TrackBarCodeSize.Location = New System.Drawing.Point(349, 60)
        Me.TrackBarCodeSize.Name = "TrackBarCodeSize"
        Me.TrackBarCodeSize.Size = New System.Drawing.Size(332, 56)
        Me.TrackBarCodeSize.TabIndex = 6
        '
        'TabPageIncludeDirs
        '
        Me.TabPageIncludeDirs.Controls.Add(Me.GroupBox10)
        Me.TabPageIncludeDirs.Location = New System.Drawing.Point(4, 29)
        Me.TabPageIncludeDirs.Name = "TabPageIncludeDirs"
        Me.TabPageIncludeDirs.Size = New System.Drawing.Size(699, 188)
        Me.TabPageIncludeDirs.TabIndex = 7
        Me.TabPageIncludeDirs.Text = "Include"
        Me.TabPageIncludeDirs.UseVisualStyleBackColor = True
        '
        'CheckBoxAtariLo
        '
        Me.CheckBoxAtariLo.AutoSize = True
        Me.CheckBoxAtariLo.Location = New System.Drawing.Point(231, 27)
        Me.CheckBoxAtariLo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxAtariLo.Name = "CheckBoxAtariLo"
        Me.CheckBoxAtariLo.Size = New System.Drawing.Size(145, 24)
        Me.CheckBoxAtariLo.TabIndex = 18
        Me.CheckBoxAtariLo.Text = "Atari (8 bit) [low]"
        Me.CheckBoxAtariLo.UseVisualStyleBackColor = True
        '
        'CheckBoxAtari
        '
        Me.CheckBoxAtari.AutoSize = True
        Me.CheckBoxAtari.Location = New System.Drawing.Point(231, 59)
        Me.CheckBoxAtari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxAtari.Name = "CheckBoxAtari"
        Me.CheckBoxAtari.Size = New System.Drawing.Size(107, 24)
        Me.CheckBoxAtari.TabIndex = 17
        Me.CheckBoxAtari.Text = "Atari (8 bit)"
        Me.CheckBoxAtari.UseVisualStyleBackColor = True
        '
        'CheckBoxC128
        '
        Me.CheckBoxC128.AutoSize = True
        Me.CheckBoxC128.Location = New System.Drawing.Point(136, 91)
        Me.CheckBoxC128.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxC128.Name = "CheckBoxC128"
        Me.CheckBoxC128.Size = New System.Drawing.Size(64, 24)
        Me.CheckBoxC128.TabIndex = 16
        Me.CheckBoxC128.Text = "C128"
        Me.CheckBoxC128.UseVisualStyleBackColor = True
        '
        'CheckBoxC64
        '
        Me.CheckBoxC64.AutoSize = True
        Me.CheckBoxC64.Location = New System.Drawing.Point(136, 59)
        Me.CheckBoxC64.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxC64.Name = "CheckBoxC64"
        Me.CheckBoxC64.Size = New System.Drawing.Size(56, 24)
        Me.CheckBoxC64.TabIndex = 15
        Me.CheckBoxC64.Text = "C64"
        Me.CheckBoxC64.UseVisualStyleBackColor = True
        '
        'CheckBoxVic2024
        '
        Me.CheckBoxVic2024.AutoSize = True
        Me.CheckBoxVic2024.Location = New System.Drawing.Point(9, 91)
        Me.CheckBoxVic2024.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxVic2024.Name = "CheckBoxVic2024"
        Me.CheckBoxVic2024.Size = New System.Drawing.Size(127, 24)
        Me.CheckBoxVic2024.TabIndex = 14
        Me.CheckBoxVic2024.Text = "VIC-20 (24 KB)"
        Me.CheckBoxVic2024.UseVisualStyleBackColor = True
        '
        'CheckBoxOptimizeCodeInline
        '
        Me.CheckBoxOptimizeCodeInline.AutoSize = True
        Me.CheckBoxOptimizeCodeInline.Location = New System.Drawing.Point(6, 74)
        Me.CheckBoxOptimizeCodeInline.Name = "CheckBoxOptimizeCodeInline"
        Me.CheckBoxOptimizeCodeInline.Size = New System.Drawing.Size(248, 24)
        Me.CheckBoxOptimizeCodeInline.TabIndex = 2
        Me.CheckBoxOptimizeCodeInline.Text = "Optimize code, inline more code"
        Me.CheckBoxOptimizeCodeInline.UseVisualStyleBackColor = True
        '
        'TabPageOptimizations
        '
        Me.TabPageOptimizations.Controls.Add(Me.GroupBox8)
        Me.TabPageOptimizations.Location = New System.Drawing.Point(4, 29)
        Me.TabPageOptimizations.Name = "TabPageOptimizations"
        Me.TabPageOptimizations.Size = New System.Drawing.Size(699, 188)
        Me.TabPageOptimizations.TabIndex = 5
        Me.TabPageOptimizations.Text = "Optimizations"
        Me.TabPageOptimizations.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TrackBarRegisterSpace)
        Me.GroupBox8.Controls.Add(Me.CheckBoxCpu65C02)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.CheckBoxSignedChars)
        Me.GroupBox8.Controls.Add(Me.CheckBoxInlineFunctions)
        Me.GroupBox8.Controls.Add(Me.CheckBoxRegisterVars)
        Me.GroupBox8.Controls.Add(Me.CheckBoxOptimizeCodeInline)
        Me.GroupBox8.Controls.Add(Me.CheckBoxOptimizeCode)
        Me.GroupBox8.Controls.Add(Me.CheckBoxStaticLocals)
        Me.GroupBox8.Controls.Add(Me.TrackBarCodeSize)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(690, 182)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        '
        'ButtonFromGlobal
        '
        Me.ButtonFromGlobal.Location = New System.Drawing.Point(310, 232)
        Me.ButtonFromGlobal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonFromGlobal.Name = "ButtonFromGlobal"
        Me.ButtonFromGlobal.Size = New System.Drawing.Size(125, 44)
        Me.ButtonFromGlobal.TabIndex = 9
        Me.ButtonFromGlobal.Text = "From Global"
        Me.ButtonFromGlobal.UseVisualStyleBackColor = True
        '
        'ButtonRestore
        '
        Me.ButtonRestore.Location = New System.Drawing.Point(0, 232)
        Me.ButtonRestore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonRestore.Name = "ButtonRestore"
        Me.ButtonRestore.Size = New System.Drawing.Size(125, 44)
        Me.ButtonRestore.TabIndex = 7
        Me.ButtonRestore.Text = "Restore"
        Me.ButtonRestore.UseVisualStyleBackColor = True
        '
        'ButtonApply
        '
        Me.ButtonApply.Location = New System.Drawing.Point(580, 232)
        Me.ButtonApply.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonApply.Name = "ButtonApply"
        Me.ButtonApply.Size = New System.Drawing.Size(125, 44)
        Me.ButtonApply.TabIndex = 6
        Me.ButtonApply.Text = "Apply"
        Me.ButtonApply.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.CheckBoxWritableStrings)
        Me.GroupBox12.Controls.Add(Me.TextBoxRoDataName)
        Me.GroupBox12.Controls.Add(Me.Label17)
        Me.GroupBox12.Controls.Add(Me.TextBoxDataName)
        Me.GroupBox12.Controls.Add(Me.Label16)
        Me.GroupBox12.Controls.Add(Me.TextBoxCodeName)
        Me.GroupBox12.Controls.Add(Me.Label14)
        Me.GroupBox12.Controls.Add(Me.TextBoxBssName)
        Me.GroupBox12.Controls.Add(Me.Label13)
        Me.GroupBox12.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(690, 182)
        Me.GroupBox12.TabIndex = 0
        Me.GroupBox12.TabStop = False
        '
        'CheckBoxWritableStrings
        '
        Me.CheckBoxWritableStrings.AutoSize = True
        Me.CheckBoxWritableStrings.Location = New System.Drawing.Point(343, 142)
        Me.CheckBoxWritableStrings.Name = "CheckBoxWritableStrings"
        Me.CheckBoxWritableStrings.Size = New System.Drawing.Size(214, 24)
        Me.CheckBoxWritableStrings.TabIndex = 8
        Me.CheckBoxWritableStrings.Text = "Make string literals writable"
        Me.CheckBoxWritableStrings.UseVisualStyleBackColor = True
        '
        'TextBoxRoDataName
        '
        Me.TextBoxRoDataName.Location = New System.Drawing.Point(73, 143)
        Me.TextBoxRoDataName.Name = "TextBoxRoDataName"
        Me.TextBoxRoDataName.Size = New System.Drawing.Size(244, 27)
        Me.TextBoxRoDataName.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 146)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 20)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "RODATA"
        '
        'TextBoxDataName
        '
        Me.TextBoxDataName.Location = New System.Drawing.Point(73, 101)
        Me.TextBoxDataName.Name = "TextBoxDataName"
        Me.TextBoxDataName.Size = New System.Drawing.Size(244, 27)
        Me.TextBoxDataName.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(21, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 20)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "DATA"
        '
        'TextBoxCodeName
        '
        Me.TextBoxCodeName.Location = New System.Drawing.Point(73, 59)
        Me.TextBoxCodeName.Name = "TextBoxCodeName"
        Me.TextBoxCodeName.Size = New System.Drawing.Size(244, 27)
        Me.TextBoxCodeName.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(19, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 20)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "CODE"
        '
        'TextBoxBssName
        '
        Me.TextBoxBssName.Location = New System.Drawing.Point(73, 20)
        Me.TextBoxBssName.Name = "TextBoxBssName"
        Me.TextBoxBssName.Size = New System.Drawing.Size(244, 27)
        Me.TextBoxBssName.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(33, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "BSS"
        '
        'TabPageSegments
        '
        Me.TabPageSegments.Controls.Add(Me.GroupBox12)
        Me.TabPageSegments.Location = New System.Drawing.Point(4, 29)
        Me.TabPageSegments.Name = "TabPageSegments"
        Me.TabPageSegments.Size = New System.Drawing.Size(699, 188)
        Me.TabPageSegments.TabIndex = 9
        Me.TabPageSegments.Text = "Segments"
        Me.TabPageSegments.UseVisualStyleBackColor = True
        '
        'CheckBoxDebugInfo
        '
        Me.CheckBoxDebugInfo.AutoSize = True
        Me.CheckBoxDebugInfo.Location = New System.Drawing.Point(6, 67)
        Me.CheckBoxDebugInfo.Name = "CheckBoxDebugInfo"
        Me.CheckBoxDebugInfo.Size = New System.Drawing.Size(225, 24)
        Me.CheckBoxDebugInfo.TabIndex = 1
        Me.CheckBoxDebugInfo.Text = "Add debug info to object file"
        Me.CheckBoxDebugInfo.UseVisualStyleBackColor = True
        '
        'CheckBoxAddSource
        '
        Me.CheckBoxAddSource.AutoSize = True
        Me.CheckBoxAddSource.Location = New System.Drawing.Point(6, 26)
        Me.CheckBoxAddSource.Name = "CheckBoxAddSource"
        Me.CheckBoxAddSource.Size = New System.Drawing.Size(211, 24)
        Me.CheckBoxAddSource.TabIndex = 0
        Me.CheckBoxAddSource.Text = "Include source as comment"
        Me.CheckBoxAddSource.UseVisualStyleBackColor = True
        '
        'CheckedListBoxCC65Warnings
        '
        Me.CheckedListBoxCC65Warnings.FormattingEnabled = True
        Me.CheckedListBoxCC65Warnings.Location = New System.Drawing.Point(297, 36)
        Me.CheckedListBoxCC65Warnings.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckedListBoxCC65Warnings.Name = "CheckedListBoxCC65Warnings"
        Me.CheckedListBoxCC65Warnings.Size = New System.Drawing.Size(387, 136)
        Me.CheckedListBoxCC65Warnings.TabIndex = 15
        '
        'CheckBoxSuppressWarnings
        '
        Me.CheckBoxSuppressWarnings.AutoSize = True
        Me.CheckBoxSuppressWarnings.Location = New System.Drawing.Point(297, 14)
        Me.CheckBoxSuppressWarnings.Name = "CheckBoxSuppressWarnings"
        Me.CheckBoxSuppressWarnings.Size = New System.Drawing.Size(297, 24)
        Me.CheckBoxSuppressWarnings.TabIndex = 14
        Me.CheckBoxSuppressWarnings.Text = "Suppress warnings, or ignore followings:"
        Me.CheckBoxSuppressWarnings.UseVisualStyleBackColor = True
        '
        'CheckBoxCreateDep
        '
        Me.CheckBoxCreateDep.AutoSize = True
        Me.CheckBoxCreateDep.Location = New System.Drawing.Point(6, 148)
        Me.CheckBoxCreateDep.Name = "CheckBoxCreateDep"
        Me.CheckBoxCreateDep.Size = New System.Drawing.Size(236, 24)
        Me.CheckBoxCreateDep.TabIndex = 3
        Me.CheckBoxCreateDep.Text = "Create a make dependency file"
        Me.CheckBoxCreateDep.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.CheckedListBoxCC65Warnings)
        Me.GroupBox11.Controls.Add(Me.CheckBoxSuppressWarnings)
        Me.GroupBox11.Controls.Add(Me.CheckBoxCreateDep)
        Me.GroupBox11.Controls.Add(Me.CheckBoxCheckStack)
        Me.GroupBox11.Controls.Add(Me.CheckBoxDebugInfo)
        Me.GroupBox11.Controls.Add(Me.CheckBoxAddSource)
        Me.GroupBox11.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(690, 182)
        Me.GroupBox11.TabIndex = 0
        Me.GroupBox11.TabStop = False
        '
        'CheckBoxCheckStack
        '
        Me.CheckBoxCheckStack.AutoSize = True
        Me.CheckBoxCheckStack.Location = New System.Drawing.Point(5, 107)
        Me.CheckBoxCheckStack.Name = "CheckBoxCheckStack"
        Me.CheckBoxCheckStack.Size = New System.Drawing.Size(237, 24)
        Me.CheckBoxCheckStack.TabIndex = 2
        Me.CheckBoxCheckStack.Text = "Generate stack overflow checks"
        Me.CheckBoxCheckStack.UseVisualStyleBackColor = True
        '
        'TabPageDebug
        '
        Me.TabPageDebug.Controls.Add(Me.GroupBox11)
        Me.TabPageDebug.Location = New System.Drawing.Point(4, 29)
        Me.TabPageDebug.Name = "TabPageDebug"
        Me.TabPageDebug.Size = New System.Drawing.Size(699, 188)
        Me.TabPageDebug.TabIndex = 8
        Me.TabPageDebug.Text = "Debug"
        Me.TabPageDebug.UseVisualStyleBackColor = True
        '
        'CheckBoxVic20
        '
        Me.CheckBoxVic20.AutoSize = True
        Me.CheckBoxVic20.Location = New System.Drawing.Point(9, 59)
        Me.CheckBoxVic20.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxVic20.Name = "CheckBoxVic20"
        Me.CheckBoxVic20.Size = New System.Drawing.Size(75, 24)
        Me.CheckBoxVic20.TabIndex = 13
        Me.CheckBoxVic20.Text = "VIC-20"
        Me.CheckBoxVic20.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 25)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Output file"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBoxBinaryFileName)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(4, 5)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(697, 164)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'TextBoxBinaryFileName
        '
        Me.TextBoxBinaryFileName.Location = New System.Drawing.Point(124, 28)
        Me.TextBoxBinaryFileName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxBinaryFileName.Name = "TextBoxBinaryFileName"
        Me.TextBoxBinaryFileName.Size = New System.Drawing.Size(209, 27)
        Me.TextBoxBinaryFileName.TabIndex = 1
        '
        'TabPageOutput
        '
        Me.TabPageOutput.Controls.Add(Me.GroupBox4)
        Me.TabPageOutput.Location = New System.Drawing.Point(4, 29)
        Me.TabPageOutput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageOutput.Name = "TabPageOutput"
        Me.TabPageOutput.Size = New System.Drawing.Size(699, 188)
        Me.TabPageOutput.TabIndex = 3
        Me.TabPageOutput.Text = "Output"
        Me.TabPageOutput.UseVisualStyleBackColor = True
        '
        'TabControlOptions
        '
        Me.TabControlOptions.Controls.Add(Me.TabPageOutput)
        Me.TabControlOptions.Controls.Add(Me.TabPageCC65)
        Me.TabControlOptions.Controls.Add(Me.TabPageOptimizations)
        Me.TabControlOptions.Controls.Add(Me.TabPageSymbols)
        Me.TabControlOptions.Controls.Add(Me.TabPageIncludeDirs)
        Me.TabControlOptions.Controls.Add(Me.TabPageDebug)
        Me.TabControlOptions.Controls.Add(Me.TabPageSegments)
        Me.TabControlOptions.Location = New System.Drawing.Point(3, 4)
        Me.TabControlOptions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlOptions.Name = "TabControlOptions"
        Me.TabControlOptions.SelectedIndex = 0
        Me.TabControlOptions.Size = New System.Drawing.Size(707, 221)
        Me.TabControlOptions.TabIndex = 5
        '
        'TabPageCC65
        '
        Me.TabPageCC65.Controls.Add(Me.GroupBox2)
        Me.TabPageCC65.Location = New System.Drawing.Point(4, 29)
        Me.TabPageCC65.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageCC65.Name = "TabPageCC65"
        Me.TabPageCC65.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageCC65.Size = New System.Drawing.Size(699, 188)
        Me.TabPageCC65.TabIndex = 1
        Me.TabPageCC65.Text = "Targets"
        Me.TabPageCC65.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(676, 160)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.RadioButtonC99)
        Me.GroupBox7.Controls.Add(Me.RadioButtonC89)
        Me.GroupBox7.Controls.Add(Me.RadioButtonCC65)
        Me.GroupBox7.Location = New System.Drawing.Point(391, 14)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(279, 122)
        Me.GroupBox7.TabIndex = 12
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "C language level"
        '
        'RadioButtonC99
        '
        Me.RadioButtonC99.AutoSize = True
        Me.RadioButtonC99.Location = New System.Drawing.Point(6, 81)
        Me.RadioButtonC99.Name = "RadioButtonC99"
        Me.RadioButtonC99.Size = New System.Drawing.Size(55, 24)
        Me.RadioButtonC99.TabIndex = 2
        Me.RadioButtonC99.TabStop = True
        Me.RadioButtonC99.Text = "C99"
        Me.RadioButtonC99.UseVisualStyleBackColor = True
        '
        'RadioButtonC89
        '
        Me.RadioButtonC89.AutoSize = True
        Me.RadioButtonC89.Location = New System.Drawing.Point(6, 51)
        Me.RadioButtonC89.Name = "RadioButtonC89"
        Me.RadioButtonC89.Size = New System.Drawing.Size(55, 24)
        Me.RadioButtonC89.TabIndex = 1
        Me.RadioButtonC89.TabStop = True
        Me.RadioButtonC89.Text = "C89"
        Me.RadioButtonC89.UseVisualStyleBackColor = True
        '
        'RadioButtonCC65
        '
        Me.RadioButtonCC65.AutoSize = True
        Me.RadioButtonCC65.Location = New System.Drawing.Point(6, 21)
        Me.RadioButtonCC65.Name = "RadioButtonCC65"
        Me.RadioButtonCC65.Size = New System.Drawing.Size(64, 24)
        Me.RadioButtonCC65.TabIndex = 0
        Me.RadioButtonCC65.TabStop = True
        Me.RadioButtonCC65.Text = "CC65"
        Me.RadioButtonCC65.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.CheckBoxAtariLo)
        Me.GroupBox6.Controls.Add(Me.CheckBoxAtari)
        Me.GroupBox6.Controls.Add(Me.CheckBoxC128)
        Me.GroupBox6.Controls.Add(Me.CheckBoxC64)
        Me.GroupBox6.Controls.Add(Me.CheckBoxVic2024)
        Me.GroupBox6.Controls.Add(Me.CheckBoxVic20)
        Me.GroupBox6.Controls.Add(Me.CheckBoxC16)
        Me.GroupBox6.Controls.Add(Me.CheckBoxPlus4)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 14)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(379, 122)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Enabled targets"
        '
        'CheckBoxC16
        '
        Me.CheckBoxC16.AutoSize = True
        Me.CheckBoxC16.Location = New System.Drawing.Point(9, 27)
        Me.CheckBoxC16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxC16.Name = "CheckBoxC16"
        Me.CheckBoxC16.Size = New System.Drawing.Size(56, 24)
        Me.CheckBoxC16.TabIndex = 12
        Me.CheckBoxC16.Text = "C16"
        Me.CheckBoxC16.UseVisualStyleBackColor = True
        '
        'CheckBoxPlus4
        '
        Me.CheckBoxPlus4.AutoSize = True
        Me.CheckBoxPlus4.Location = New System.Drawing.Point(136, 27)
        Me.CheckBoxPlus4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxPlus4.Name = "CheckBoxPlus4"
        Me.CheckBoxPlus4.Size = New System.Drawing.Size(78, 24)
        Me.CheckBoxPlus4.TabIndex = 11
        Me.CheckBoxPlus4.Text = "PLUS/4"
        Me.CheckBoxPlus4.UseVisualStyleBackColor = True
        '
        'ButtonFromProject
        '
        Me.ButtonFromProject.Location = New System.Drawing.Point(445, 232)
        Me.ButtonFromProject.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonFromProject.Name = "ButtonFromProject"
        Me.ButtonFromProject.Size = New System.Drawing.Size(125, 44)
        Me.ButtonFromProject.TabIndex = 8
        Me.ButtonFromProject.Text = "From Project"
        Me.ButtonFromProject.UseVisualStyleBackColor = True
        '
        'OptionsCC65Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 285)
        Me.Controls.Add(Me.ButtonFromGlobal)
        Me.Controls.Add(Me.ButtonRestore)
        Me.Controls.Add(Me.ButtonApply)
        Me.Controls.Add(Me.TabControlOptions)
        Me.Controls.Add(Me.ButtonFromProject)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OptionsCC65Window"
        Me.Text = "OptionsCC65Window"
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.DataGridViewSymbols, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.TrackBarRegisterSpace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageSymbols.ResumeLayout(False)
        CType(Me.TrackBarCodeSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageIncludeDirs.ResumeLayout(False)
        Me.TabPageOptimizations.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.TabPageSegments.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.TabPageDebug.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPageOutput.ResumeLayout(False)
        Me.TabControlOptions.ResumeLayout(False)
        Me.TabPageCC65.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents CheckBoxForgetIncPath As CheckBox
    Friend WithEvents ListBoxIncludeDirs As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SymbolValue As DataGridViewTextBoxColumn
    Friend WithEvents SymbolName As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewSymbols As DataGridView
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents TrackBarRegisterSpace As TrackBar
    Friend WithEvents CheckBoxCpu65C02 As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CheckBoxSignedChars As CheckBox
    Friend WithEvents CheckBoxInlineFunctions As CheckBox
    Friend WithEvents TabPageSymbols As TabPage
    Friend WithEvents CheckBoxRegisterVars As CheckBox
    Friend WithEvents CheckBoxOptimizeCode As CheckBox
    Friend WithEvents CheckBoxStaticLocals As CheckBox
    Friend WithEvents TrackBarCodeSize As TrackBar
    Friend WithEvents TabPageIncludeDirs As TabPage
    Friend WithEvents CheckBoxAtariLo As CheckBox
    Friend WithEvents CheckBoxAtari As CheckBox
    Friend WithEvents CheckBoxC128 As CheckBox
    Friend WithEvents CheckBoxC64 As CheckBox
    Friend WithEvents CheckBoxVic2024 As CheckBox
    Friend WithEvents CheckBoxOptimizeCodeInline As CheckBox
    Friend WithEvents TabPageOptimizations As TabPage
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents ButtonFromGlobal As Button
    Friend WithEvents ButtonRestore As Button
    Friend WithEvents ButtonApply As Button
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents CheckBoxWritableStrings As CheckBox
    Friend WithEvents TextBoxRoDataName As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBoxDataName As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBoxCodeName As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxBssName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TabPageSegments As TabPage
    Friend WithEvents CheckBoxDebugInfo As CheckBox
    Friend WithEvents CheckBoxAddSource As CheckBox
    Friend WithEvents CheckedListBoxCC65Warnings As CheckedListBox
    Friend WithEvents CheckBoxSuppressWarnings As CheckBox
    Friend WithEvents CheckBoxCreateDep As CheckBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents CheckBoxCheckStack As CheckBox
    Friend WithEvents TabPageDebug As TabPage
    Friend WithEvents CheckBoxVic20 As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBoxBinaryFileName As TextBox
    Friend WithEvents TabPageOutput As TabPage
    Friend WithEvents TabControlOptions As TabControl
    Friend WithEvents TabPageCC65 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents RadioButtonC99 As RadioButton
    Friend WithEvents RadioButtonC89 As RadioButton
    Friend WithEvents RadioButtonCC65 As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CheckBoxC16 As CheckBox
    Friend WithEvents CheckBoxPlus4 As CheckBox
    Friend WithEvents ButtonFromProject As Button
End Class
