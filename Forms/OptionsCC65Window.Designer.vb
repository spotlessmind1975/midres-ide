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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsCC65Window))
        Me.TabPageSymbols = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridViewSymbols = New System.Windows.Forms.DataGridView()
        Me.SymbolName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SymbolValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPageIncludeDirs = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridViewIncludeDirs = New System.Windows.Forms.DataGridView()
        Me.Path = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckBoxForgetIncPath = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPageOptimizations = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelCodeSize = New System.Windows.Forms.Label()
        Me.CheckBoxRegisterSpaceEnabled = New System.Windows.Forms.CheckBox()
        Me.LabelRegisterSpace = New System.Windows.Forms.Label()
        Me.CheckBoxInlineStdFunctions = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCodeSizeEnabled = New System.Windows.Forms.CheckBox()
        Me.TrackBarRegisterSpace = New System.Windows.Forms.TrackBar()
        Me.CheckBoxSignedChars = New System.Windows.Forms.CheckBox()
        Me.CheckBoxInlineFunctions = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRegisterVars = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOptimizeCodeInline = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOptimizeCode = New System.Windows.Forms.CheckBox()
        Me.CheckBoxStaticLocals = New System.Windows.Forms.CheckBox()
        Me.TrackBarCodeSize = New System.Windows.Forms.TrackBar()
        Me.ButtonFromGlobal = New System.Windows.Forms.Button()
        Me.ButtonRestore = New System.Windows.Forms.Button()
        Me.ButtonApply = New System.Windows.Forms.Button()
        Me.TabPageSegments = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.CheckBoxLocalStrings = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAllCDecl = New System.Windows.Forms.CheckBox()
        Me.CheckBoxWritableStrings = New System.Windows.Forms.CheckBox()
        Me.TextBoxRoDataName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBoxDataName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBoxCodeName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxBssName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabPageDebug = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.CheckedListBoxCC65Warnings = New System.Windows.Forms.CheckedListBox()
        Me.CheckBoxSuppressWarnings = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCheckStack = New System.Windows.Forms.CheckBox()
        Me.CheckBoxDebugInfo = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAddSource = New System.Windows.Forms.CheckBox()
        Me.TabPageOutput = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxDepTargetFileName = New System.Windows.Forms.TextBox()
        Me.CheckBoxDepTarget = New System.Windows.Forms.CheckBox()
        Me.TextBoxCreateFullDepFileName = New System.Windows.Forms.TextBox()
        Me.CheckBoxCreateFullDep = New System.Windows.Forms.CheckBox()
        Me.TextBoxDependencyFileName = New System.Windows.Forms.TextBox()
        Me.CheckBoxCreateDep = New System.Windows.Forms.CheckBox()
        Me.TextBoxBinaryFileName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabControlOptions = New System.Windows.Forms.TabControl()
        Me.TabPageCC65 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxAtariLo = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAtari = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC128 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC64 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVic2024 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVic20 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC16 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPlus4 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxCpu65C02 = New System.Windows.Forms.CheckBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButtonC99 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonC89 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCC65 = New System.Windows.Forms.RadioButton()
        Me.ButtonFromProject = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonFromParent = New System.Windows.Forms.Button()
        Me.TabPageSymbols.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridViewSymbols, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageIncludeDirs.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridViewIncludeDirs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageOptimizations.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.TrackBarRegisterSpace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarCodeSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageSegments.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabPageDebug.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TabPageOutput.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControlOptions.SuspendLayout()
        Me.TabPageCC65.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPageSymbols
        '
        Me.TabPageSymbols.Controls.Add(Me.Panel4)
        Me.TabPageSymbols.Location = New System.Drawing.Point(4, 29)
        Me.TabPageSymbols.Name = "TabPageSymbols"
        Me.TabPageSymbols.Size = New System.Drawing.Size(699, 188)
        Me.TabPageSymbols.TabIndex = 6
        Me.TabPageSymbols.Text = "Symbols"
        Me.TabPageSymbols.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DataGridViewSymbols)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(5, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(691, 190)
        Me.Panel4.TabIndex = 0
        '
        'DataGridViewSymbols
        '
        Me.DataGridViewSymbols.AllowUserToOrderColumns = True
        Me.DataGridViewSymbols.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSymbols.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SymbolName, Me.SymbolValue})
        Me.DataGridViewSymbols.Location = New System.Drawing.Point(6, 18)
        Me.DataGridViewSymbols.Name = "DataGridViewSymbols"
        Me.DataGridViewSymbols.RowHeadersWidth = 51
        Me.DataGridViewSymbols.RowTemplate.Height = 24
        Me.DataGridViewSymbols.Size = New System.Drawing.Size(680, 169)
        Me.DataGridViewSymbols.TabIndex = 3
        '
        'SymbolName
        '
        Me.SymbolName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SymbolName.HeaderText = "Name"
        Me.SymbolName.MinimumWidth = 6
        Me.SymbolName.Name = "SymbolName"
        Me.SymbolName.Width = 325
        '
        'SymbolValue
        '
        Me.SymbolValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SymbolValue.HeaderText = "Value"
        Me.SymbolValue.MinimumWidth = 6
        Me.SymbolValue.Name = "SymbolValue"
        Me.SymbolValue.Width = 300
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Symbols defined"
        '
        'TabPageIncludeDirs
        '
        Me.TabPageIncludeDirs.Controls.Add(Me.Panel5)
        Me.TabPageIncludeDirs.Location = New System.Drawing.Point(4, 29)
        Me.TabPageIncludeDirs.Name = "TabPageIncludeDirs"
        Me.TabPageIncludeDirs.Size = New System.Drawing.Size(699, 188)
        Me.TabPageIncludeDirs.TabIndex = 7
        Me.TabPageIncludeDirs.Text = "Include"
        Me.TabPageIncludeDirs.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.DataGridViewIncludeDirs)
        Me.Panel5.Controls.Add(Me.CheckBoxForgetIncPath)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(691, 187)
        Me.Panel5.TabIndex = 1
        '
        'DataGridViewIncludeDirs
        '
        Me.DataGridViewIncludeDirs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewIncludeDirs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Path})
        Me.DataGridViewIncludeDirs.Location = New System.Drawing.Point(8, 28)
        Me.DataGridViewIncludeDirs.Name = "DataGridViewIncludeDirs"
        Me.DataGridViewIncludeDirs.RowHeadersWidth = 51
        Me.DataGridViewIncludeDirs.Size = New System.Drawing.Size(679, 156)
        Me.DataGridViewIncludeDirs.TabIndex = 6
        '
        'Path
        '
        Me.Path.HeaderText = "Path"
        Me.Path.MinimumWidth = 6
        Me.Path.Name = "Path"
        Me.Path.Width = 630
        '
        'CheckBoxForgetIncPath
        '
        Me.CheckBoxForgetIncPath.AutoSize = True
        Me.CheckBoxForgetIncPath.Location = New System.Drawing.Point(517, 3)
        Me.CheckBoxForgetIncPath.Name = "CheckBoxForgetIncPath"
        Me.CheckBoxForgetIncPath.Size = New System.Drawing.Size(212, 24)
        Me.CheckBoxForgetIncPath.TabIndex = 5
        Me.CheckBoxForgetIncPath.Text = "Forget include search paths"
        Me.CheckBoxForgetIncPath.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 20)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Paths for include files:"
        '
        'TabPageOptimizations
        '
        Me.TabPageOptimizations.Controls.Add(Me.Panel3)
        Me.TabPageOptimizations.Location = New System.Drawing.Point(4, 29)
        Me.TabPageOptimizations.Name = "TabPageOptimizations"
        Me.TabPageOptimizations.Size = New System.Drawing.Size(699, 188)
        Me.TabPageOptimizations.TabIndex = 5
        Me.TabPageOptimizations.Text = "Optimizations"
        Me.TabPageOptimizations.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.LabelCodeSize)
        Me.Panel3.Controls.Add(Me.CheckBoxRegisterSpaceEnabled)
        Me.Panel3.Controls.Add(Me.LabelRegisterSpace)
        Me.Panel3.Controls.Add(Me.CheckBoxInlineStdFunctions)
        Me.Panel3.Controls.Add(Me.CheckBoxCodeSizeEnabled)
        Me.Panel3.Controls.Add(Me.TrackBarRegisterSpace)
        Me.Panel3.Controls.Add(Me.CheckBoxSignedChars)
        Me.Panel3.Controls.Add(Me.CheckBoxInlineFunctions)
        Me.Panel3.Controls.Add(Me.CheckBoxRegisterVars)
        Me.Panel3.Controls.Add(Me.CheckBoxOptimizeCodeInline)
        Me.Panel3.Controls.Add(Me.CheckBoxOptimizeCode)
        Me.Panel3.Controls.Add(Me.CheckBoxStaticLocals)
        Me.Panel3.Controls.Add(Me.TrackBarCodeSize)
        Me.Panel3.Location = New System.Drawing.Point(5, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(693, 187)
        Me.Panel3.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(673, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "%"
        '
        'LabelCodeSize
        '
        Me.LabelCodeSize.BackColor = System.Drawing.SystemColors.Control
        Me.LabelCodeSize.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCodeSize.Location = New System.Drawing.Point(635, 40)
        Me.LabelCodeSize.Name = "LabelCodeSize"
        Me.LabelCodeSize.Size = New System.Drawing.Size(36, 29)
        Me.LabelCodeSize.TabIndex = 26
        Me.LabelCodeSize.Text = "100"
        Me.LabelCodeSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBoxRegisterSpaceEnabled
        '
        Me.CheckBoxRegisterSpaceEnabled.AutoSize = True
        Me.CheckBoxRegisterSpaceEnabled.Location = New System.Drawing.Point(362, 109)
        Me.CheckBoxRegisterSpaceEnabled.Name = "CheckBoxRegisterSpaceEnabled"
        Me.CheckBoxRegisterSpaceEnabled.Size = New System.Drawing.Size(130, 24)
        Me.CheckBoxRegisterSpaceEnabled.TabIndex = 25
        Me.CheckBoxRegisterSpaceEnabled.Text = "Register space:"
        Me.CheckBoxRegisterSpaceEnabled.UseVisualStyleBackColor = True
        '
        'LabelRegisterSpace
        '
        Me.LabelRegisterSpace.BackColor = System.Drawing.SystemColors.Control
        Me.LabelRegisterSpace.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRegisterSpace.Location = New System.Drawing.Point(635, 136)
        Me.LabelRegisterSpace.Name = "LabelRegisterSpace"
        Me.LabelRegisterSpace.Size = New System.Drawing.Size(36, 29)
        Me.LabelRegisterSpace.TabIndex = 24
        Me.LabelRegisterSpace.Text = "6"
        Me.LabelRegisterSpace.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CheckBoxInlineStdFunctions
        '
        Me.CheckBoxInlineStdFunctions.AutoSize = True
        Me.CheckBoxInlineStdFunctions.Location = New System.Drawing.Point(9, 136)
        Me.CheckBoxInlineStdFunctions.Name = "CheckBoxInlineStdFunctions"
        Me.CheckBoxInlineStdFunctions.Size = New System.Drawing.Size(233, 24)
        Me.CheckBoxInlineStdFunctions.TabIndex = 23
        Me.CheckBoxInlineStdFunctions.Text = "Inline some standard functions"
        Me.CheckBoxInlineStdFunctions.UseVisualStyleBackColor = True
        '
        'CheckBoxCodeSizeEnabled
        '
        Me.CheckBoxCodeSizeEnabled.AutoSize = True
        Me.CheckBoxCodeSizeEnabled.Location = New System.Drawing.Point(362, 15)
        Me.CheckBoxCodeSizeEnabled.Name = "CheckBoxCodeSizeEnabled"
        Me.CheckBoxCodeSizeEnabled.Size = New System.Drawing.Size(223, 24)
        Me.CheckBoxCodeSizeEnabled.TabIndex = 22
        Me.CheckBoxCodeSizeEnabled.Text = "Accept larger code by factor:"
        Me.CheckBoxCodeSizeEnabled.UseVisualStyleBackColor = True
        '
        'TrackBarRegisterSpace
        '
        Me.TrackBarRegisterSpace.BackColor = System.Drawing.SystemColors.Window
        Me.TrackBarRegisterSpace.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.TrackBarRegisterSpace.Enabled = False
        Me.TrackBarRegisterSpace.Location = New System.Drawing.Point(352, 139)
        Me.TrackBarRegisterSpace.Maximum = 255
        Me.TrackBarRegisterSpace.Minimum = 1
        Me.TrackBarRegisterSpace.Name = "TrackBarRegisterSpace"
        Me.TrackBarRegisterSpace.Size = New System.Drawing.Size(286, 56)
        Me.TrackBarRegisterSpace.TabIndex = 21
        Me.TrackBarRegisterSpace.Value = 6
        '
        'CheckBoxSignedChars
        '
        Me.CheckBoxSignedChars.AutoSize = True
        Me.CheckBoxSignedChars.Location = New System.Drawing.Point(9, 3)
        Me.CheckBoxSignedChars.Name = "CheckBoxSignedChars"
        Me.CheckBoxSignedChars.Size = New System.Drawing.Size(224, 24)
        Me.CheckBoxSignedChars.TabIndex = 19
        Me.CheckBoxSignedChars.Text = "Default characters are signed"
        Me.CheckBoxSignedChars.UseVisualStyleBackColor = True
        '
        'CheckBoxInlineFunctions
        '
        Me.CheckBoxInlineFunctions.AutoSize = True
        Me.CheckBoxInlineFunctions.Location = New System.Drawing.Point(9, 109)
        Me.CheckBoxInlineFunctions.Name = "CheckBoxInlineFunctions"
        Me.CheckBoxInlineFunctions.Size = New System.Drawing.Size(271, 24)
        Me.CheckBoxInlineFunctions.TabIndex = 18
        Me.CheckBoxInlineFunctions.Text = "Eagerly inline some known functions"
        Me.CheckBoxInlineFunctions.UseVisualStyleBackColor = True
        '
        'CheckBoxRegisterVars
        '
        Me.CheckBoxRegisterVars.AutoSize = True
        Me.CheckBoxRegisterVars.Location = New System.Drawing.Point(9, 161)
        Me.CheckBoxRegisterVars.Name = "CheckBoxRegisterVars"
        Me.CheckBoxRegisterVars.Size = New System.Drawing.Size(193, 24)
        Me.CheckBoxRegisterVars.TabIndex = 17
        Me.CheckBoxRegisterVars.Text = "Enable register variables"
        Me.CheckBoxRegisterVars.UseVisualStyleBackColor = True
        '
        'CheckBoxOptimizeCodeInline
        '
        Me.CheckBoxOptimizeCodeInline.AutoSize = True
        Me.CheckBoxOptimizeCodeInline.Location = New System.Drawing.Point(9, 78)
        Me.CheckBoxOptimizeCodeInline.Name = "CheckBoxOptimizeCodeInline"
        Me.CheckBoxOptimizeCodeInline.Size = New System.Drawing.Size(248, 24)
        Me.CheckBoxOptimizeCodeInline.TabIndex = 16
        Me.CheckBoxOptimizeCodeInline.Text = "Optimize code, inline more code"
        Me.CheckBoxOptimizeCodeInline.UseVisualStyleBackColor = True
        '
        'CheckBoxOptimizeCode
        '
        Me.CheckBoxOptimizeCode.AutoSize = True
        Me.CheckBoxOptimizeCode.Location = New System.Drawing.Point(9, 53)
        Me.CheckBoxOptimizeCode.Name = "CheckBoxOptimizeCode"
        Me.CheckBoxOptimizeCode.Size = New System.Drawing.Size(129, 24)
        Me.CheckBoxOptimizeCode.TabIndex = 15
        Me.CheckBoxOptimizeCode.Text = "Optimize code"
        Me.CheckBoxOptimizeCode.UseVisualStyleBackColor = True
        '
        'CheckBoxStaticLocals
        '
        Me.CheckBoxStaticLocals.AutoSize = True
        Me.CheckBoxStaticLocals.Location = New System.Drawing.Point(9, 28)
        Me.CheckBoxStaticLocals.Name = "CheckBoxStaticLocals"
        Me.CheckBoxStaticLocals.Size = New System.Drawing.Size(205, 24)
        Me.CheckBoxStaticLocals.TabIndex = 14
        Me.CheckBoxStaticLocals.Text = "Make local variables static"
        Me.CheckBoxStaticLocals.UseVisualStyleBackColor = True
        '
        'TrackBarCodeSize
        '
        Me.TrackBarCodeSize.BackColor = System.Drawing.SystemColors.Window
        Me.TrackBarCodeSize.Enabled = False
        Me.TrackBarCodeSize.Location = New System.Drawing.Point(352, 43)
        Me.TrackBarCodeSize.Maximum = 200
        Me.TrackBarCodeSize.Minimum = 100
        Me.TrackBarCodeSize.Name = "TrackBarCodeSize"
        Me.TrackBarCodeSize.Size = New System.Drawing.Size(286, 56)
        Me.TrackBarCodeSize.TabIndex = 20
        Me.TrackBarCodeSize.Value = 100
        '
        'ButtonFromGlobal
        '
        Me.ButtonFromGlobal.Image = CType(resources.GetObject("ButtonFromGlobal.Image"), System.Drawing.Image)
        Me.ButtonFromGlobal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonFromGlobal.Location = New System.Drawing.Point(280, 231)
        Me.ButtonFromGlobal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonFromGlobal.Name = "ButtonFromGlobal"
        Me.ButtonFromGlobal.Size = New System.Drawing.Size(79, 44)
        Me.ButtonFromGlobal.TabIndex = 9
        Me.ButtonFromGlobal.Text = "global"
        Me.ButtonFromGlobal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonFromGlobal.UseVisualStyleBackColor = True
        '
        'ButtonRestore
        '
        Me.ButtonRestore.Image = CType(resources.GetObject("ButtonRestore.Image"), System.Drawing.Image)
        Me.ButtonRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRestore.Location = New System.Drawing.Point(100, 233)
        Me.ButtonRestore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonRestore.Name = "ButtonRestore"
        Me.ButtonRestore.Size = New System.Drawing.Size(85, 42)
        Me.ButtonRestore.TabIndex = 7
        Me.ButtonRestore.Text = "restore"
        Me.ButtonRestore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRestore.UseVisualStyleBackColor = True
        '
        'ButtonApply
        '
        Me.ButtonApply.Image = CType(resources.GetObject("ButtonApply.Image"), System.Drawing.Image)
        Me.ButtonApply.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonApply.Location = New System.Drawing.Point(636, 232)
        Me.ButtonApply.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonApply.Name = "ButtonApply"
        Me.ButtonApply.Size = New System.Drawing.Size(69, 44)
        Me.ButtonApply.TabIndex = 6
        Me.ButtonApply.Text = "apply"
        Me.ButtonApply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonApply.UseVisualStyleBackColor = True
        '
        'TabPageSegments
        '
        Me.TabPageSegments.Controls.Add(Me.Panel7)
        Me.TabPageSegments.Location = New System.Drawing.Point(4, 29)
        Me.TabPageSegments.Name = "TabPageSegments"
        Me.TabPageSegments.Size = New System.Drawing.Size(699, 188)
        Me.TabPageSegments.TabIndex = 9
        Me.TabPageSegments.Text = "Building"
        Me.TabPageSegments.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.CheckBoxLocalStrings)
        Me.Panel7.Controls.Add(Me.CheckBoxAllCDecl)
        Me.Panel7.Controls.Add(Me.CheckBoxWritableStrings)
        Me.Panel7.Controls.Add(Me.TextBoxRoDataName)
        Me.Panel7.Controls.Add(Me.Label17)
        Me.Panel7.Controls.Add(Me.TextBoxDataName)
        Me.Panel7.Controls.Add(Me.Label16)
        Me.Panel7.Controls.Add(Me.TextBoxCodeName)
        Me.Panel7.Controls.Add(Me.Label14)
        Me.Panel7.Controls.Add(Me.TextBoxBssName)
        Me.Panel7.Controls.Add(Me.Label13)
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(693, 187)
        Me.Panel7.TabIndex = 0
        '
        'CheckBoxLocalStrings
        '
        Me.CheckBoxLocalStrings.AutoSize = True
        Me.CheckBoxLocalStrings.Location = New System.Drawing.Point(353, 79)
        Me.CheckBoxLocalStrings.Name = "CheckBoxLocalStrings"
        Me.CheckBoxLocalStrings.Size = New System.Drawing.Size(113, 24)
        Me.CheckBoxLocalStrings.TabIndex = 21
        Me.CheckBoxLocalStrings.Text = "Local strings"
        Me.CheckBoxLocalStrings.UseVisualStyleBackColor = True
        '
        'CheckBoxAllCDecl
        '
        Me.CheckBoxAllCDecl.AutoSize = True
        Me.CheckBoxAllCDecl.Location = New System.Drawing.Point(353, 49)
        Me.CheckBoxAllCDecl.Name = "CheckBoxAllCDecl"
        Me.CheckBoxAllCDecl.Size = New System.Drawing.Size(263, 24)
        Me.CheckBoxAllCDecl.TabIndex = 20
        Me.CheckBoxAllCDecl.Tag = "Option '--all-cdecl'"
        Me.CheckBoxAllCDecl.Text = "Make functions default to __cdecl__"
        Me.CheckBoxAllCDecl.UseVisualStyleBackColor = True
        '
        'CheckBoxWritableStrings
        '
        Me.CheckBoxWritableStrings.AutoSize = True
        Me.CheckBoxWritableStrings.Location = New System.Drawing.Point(353, 19)
        Me.CheckBoxWritableStrings.Name = "CheckBoxWritableStrings"
        Me.CheckBoxWritableStrings.Size = New System.Drawing.Size(214, 24)
        Me.CheckBoxWritableStrings.TabIndex = 19
        Me.CheckBoxWritableStrings.Text = "Make string literals writable"
        Me.CheckBoxWritableStrings.UseVisualStyleBackColor = True
        '
        'TextBoxRoDataName
        '
        Me.TextBoxRoDataName.Location = New System.Drawing.Point(83, 142)
        Me.TextBoxRoDataName.Name = "TextBoxRoDataName"
        Me.TextBoxRoDataName.Size = New System.Drawing.Size(244, 27)
        Me.TextBoxRoDataName.TabIndex = 18
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 145)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 20)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "RODATA"
        '
        'TextBoxDataName
        '
        Me.TextBoxDataName.Location = New System.Drawing.Point(83, 100)
        Me.TextBoxDataName.Name = "TextBoxDataName"
        Me.TextBoxDataName.Size = New System.Drawing.Size(244, 27)
        Me.TextBoxDataName.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(31, 103)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 20)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "DATA"
        '
        'TextBoxCodeName
        '
        Me.TextBoxCodeName.Location = New System.Drawing.Point(83, 58)
        Me.TextBoxCodeName.Name = "TextBoxCodeName"
        Me.TextBoxCodeName.Size = New System.Drawing.Size(244, 27)
        Me.TextBoxCodeName.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 20)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "CODE"
        '
        'TextBoxBssName
        '
        Me.TextBoxBssName.Location = New System.Drawing.Point(83, 19)
        Me.TextBoxBssName.Name = "TextBoxBssName"
        Me.TextBoxBssName.Size = New System.Drawing.Size(244, 27)
        Me.TextBoxBssName.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(43, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 20)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "BSS"
        '
        'TabPageDebug
        '
        Me.TabPageDebug.Controls.Add(Me.Panel6)
        Me.TabPageDebug.Location = New System.Drawing.Point(4, 29)
        Me.TabPageDebug.Name = "TabPageDebug"
        Me.TabPageDebug.Size = New System.Drawing.Size(699, 188)
        Me.TabPageDebug.TabIndex = 8
        Me.TabPageDebug.Text = "Debug"
        Me.TabPageDebug.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.CheckedListBoxCC65Warnings)
        Me.Panel6.Controls.Add(Me.CheckBoxSuppressWarnings)
        Me.Panel6.Controls.Add(Me.CheckBoxCheckStack)
        Me.Panel6.Controls.Add(Me.CheckBoxDebugInfo)
        Me.Panel6.Controls.Add(Me.CheckBoxAddSource)
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(693, 187)
        Me.Panel6.TabIndex = 0
        '
        'CheckedListBoxCC65Warnings
        '
        Me.CheckedListBoxCC65Warnings.FormattingEnabled = True
        Me.CheckedListBoxCC65Warnings.Location = New System.Drawing.Point(257, 39)
        Me.CheckedListBoxCC65Warnings.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckedListBoxCC65Warnings.Name = "CheckedListBoxCC65Warnings"
        Me.CheckedListBoxCC65Warnings.Size = New System.Drawing.Size(429, 136)
        Me.CheckedListBoxCC65Warnings.TabIndex = 20
        '
        'CheckBoxSuppressWarnings
        '
        Me.CheckBoxSuppressWarnings.AutoSize = True
        Me.CheckBoxSuppressWarnings.Location = New System.Drawing.Point(257, 13)
        Me.CheckBoxSuppressWarnings.Name = "CheckBoxSuppressWarnings"
        Me.CheckBoxSuppressWarnings.Size = New System.Drawing.Size(297, 24)
        Me.CheckBoxSuppressWarnings.TabIndex = 19
        Me.CheckBoxSuppressWarnings.Text = "Suppress warnings, or ignore followings:"
        Me.CheckBoxSuppressWarnings.UseVisualStyleBackColor = True
        '
        'CheckBoxCheckStack
        '
        Me.CheckBoxCheckStack.AutoSize = True
        Me.CheckBoxCheckStack.Location = New System.Drawing.Point(11, 121)
        Me.CheckBoxCheckStack.Name = "CheckBoxCheckStack"
        Me.CheckBoxCheckStack.Size = New System.Drawing.Size(237, 24)
        Me.CheckBoxCheckStack.TabIndex = 18
        Me.CheckBoxCheckStack.Text = "Generate stack overflow checks"
        Me.CheckBoxCheckStack.UseVisualStyleBackColor = True
        '
        'CheckBoxDebugInfo
        '
        Me.CheckBoxDebugInfo.AutoSize = True
        Me.CheckBoxDebugInfo.Location = New System.Drawing.Point(12, 81)
        Me.CheckBoxDebugInfo.Name = "CheckBoxDebugInfo"
        Me.CheckBoxDebugInfo.Size = New System.Drawing.Size(225, 24)
        Me.CheckBoxDebugInfo.TabIndex = 17
        Me.CheckBoxDebugInfo.Text = "Add debug info to object file"
        Me.CheckBoxDebugInfo.UseVisualStyleBackColor = True
        '
        'CheckBoxAddSource
        '
        Me.CheckBoxAddSource.AutoSize = True
        Me.CheckBoxAddSource.Location = New System.Drawing.Point(12, 39)
        Me.CheckBoxAddSource.Name = "CheckBoxAddSource"
        Me.CheckBoxAddSource.Size = New System.Drawing.Size(211, 24)
        Me.CheckBoxAddSource.TabIndex = 16
        Me.CheckBoxAddSource.Text = "Include source as comment"
        Me.CheckBoxAddSource.UseVisualStyleBackColor = True
        '
        'TabPageOutput
        '
        Me.TabPageOutput.Controls.Add(Me.Panel1)
        Me.TabPageOutput.Location = New System.Drawing.Point(4, 29)
        Me.TabPageOutput.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageOutput.Name = "TabPageOutput"
        Me.TabPageOutput.Size = New System.Drawing.Size(699, 188)
        Me.TabPageOutput.TabIndex = 3
        Me.TabPageOutput.Text = "Output"
        Me.TabPageOutput.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBoxDepTargetFileName)
        Me.Panel1.Controls.Add(Me.CheckBoxDepTarget)
        Me.Panel1.Controls.Add(Me.TextBoxCreateFullDepFileName)
        Me.Panel1.Controls.Add(Me.CheckBoxCreateFullDep)
        Me.Panel1.Controls.Add(Me.TextBoxDependencyFileName)
        Me.Panel1.Controls.Add(Me.CheckBoxCreateDep)
        Me.Panel1.Controls.Add(Me.TextBoxBinaryFileName)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(698, 190)
        Me.Panel1.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(347, 32)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Available variables: {target} indicates the platform; {source} is the filename wi" &
    "thout the extension."
        '
        'TextBoxDepTargetFileName
        '
        Me.TextBoxDepTargetFileName.Enabled = False
        Me.TextBoxDepTargetFileName.Location = New System.Drawing.Point(395, 139)
        Me.TextBoxDepTargetFileName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxDepTargetFileName.Name = "TextBoxDepTargetFileName"
        Me.TextBoxDepTargetFileName.Size = New System.Drawing.Size(295, 27)
        Me.TextBoxDepTargetFileName.TabIndex = 17
        '
        'CheckBoxDepTarget
        '
        Me.CheckBoxDepTarget.AutoSize = True
        Me.CheckBoxDepTarget.Location = New System.Drawing.Point(377, 113)
        Me.CheckBoxDepTarget.Name = "CheckBoxDepTarget"
        Me.CheckBoxDepTarget.Size = New System.Drawing.Size(214, 24)
        Me.CheckBoxDepTarget.TabIndex = 16
        Me.CheckBoxDepTarget.Text = "Use this dependency target:"
        Me.CheckBoxDepTarget.UseVisualStyleBackColor = True
        '
        'TextBoxCreateFullDepFileName
        '
        Me.TextBoxCreateFullDepFileName.Enabled = False
        Me.TextBoxCreateFullDepFileName.Location = New System.Drawing.Point(395, 83)
        Me.TextBoxCreateFullDepFileName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxCreateFullDepFileName.Name = "TextBoxCreateFullDepFileName"
        Me.TextBoxCreateFullDepFileName.Size = New System.Drawing.Size(295, 27)
        Me.TextBoxCreateFullDepFileName.TabIndex = 15
        '
        'CheckBoxCreateFullDep
        '
        Me.CheckBoxCreateFullDep.AutoSize = True
        Me.CheckBoxCreateFullDep.Location = New System.Drawing.Point(377, 57)
        Me.CheckBoxCreateFullDep.Name = "CheckBoxCreateFullDep"
        Me.CheckBoxCreateFullDep.Size = New System.Drawing.Size(264, 24)
        Me.CheckBoxCreateFullDep.TabIndex = 14
        Me.CheckBoxCreateFullDep.Text = "Create a full make dependency file:"
        Me.CheckBoxCreateFullDep.UseVisualStyleBackColor = True
        '
        'TextBoxDependencyFileName
        '
        Me.TextBoxDependencyFileName.Enabled = False
        Me.TextBoxDependencyFileName.Location = New System.Drawing.Point(395, 27)
        Me.TextBoxDependencyFileName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxDependencyFileName.Name = "TextBoxDependencyFileName"
        Me.TextBoxDependencyFileName.Size = New System.Drawing.Size(295, 27)
        Me.TextBoxDependencyFileName.TabIndex = 13
        '
        'CheckBoxCreateDep
        '
        Me.CheckBoxCreateDep.AutoSize = True
        Me.CheckBoxCreateDep.Location = New System.Drawing.Point(377, 8)
        Me.CheckBoxCreateDep.Name = "CheckBoxCreateDep"
        Me.CheckBoxCreateDep.Size = New System.Drawing.Size(239, 24)
        Me.CheckBoxCreateDep.TabIndex = 12
        Me.CheckBoxCreateDep.Text = "Create a make dependency file:"
        Me.CheckBoxCreateDep.UseVisualStyleBackColor = True
        '
        'TextBoxBinaryFileName
        '
        Me.TextBoxBinaryFileName.Location = New System.Drawing.Point(8, 27)
        Me.TextBoxBinaryFileName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxBinaryFileName.Name = "TextBoxBinaryFileName"
        Me.TextBoxBinaryFileName.Size = New System.Drawing.Size(344, 27)
        Me.TextBoxBinaryFileName.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Output file"
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
        Me.TabPageCC65.Controls.Add(Me.Panel2)
        Me.TabPageCC65.Location = New System.Drawing.Point(4, 29)
        Me.TabPageCC65.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageCC65.Name = "TabPageCC65"
        Me.TabPageCC65.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageCC65.Size = New System.Drawing.Size(699, 188)
        Me.TabPageCC65.TabIndex = 1
        Me.TabPageCC65.Text = "Targets"
        Me.TabPageCC65.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox6)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.GroupBox7)
        Me.Panel2.Location = New System.Drawing.Point(6, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(684, 183)
        Me.Panel2.TabIndex = 1
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
        Me.GroupBox6.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(378, 125)
        Me.GroupBox6.TabIndex = 19
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Enabled targets"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxCpu65C02)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 51)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CPU specific"
        '
        'CheckBoxCpu65C02
        '
        Me.CheckBoxCpu65C02.AutoSize = True
        Me.CheckBoxCpu65C02.Location = New System.Drawing.Point(9, 25)
        Me.CheckBoxCpu65C02.Name = "CheckBoxCpu65C02"
        Me.CheckBoxCpu65C02.Size = New System.Drawing.Size(197, 24)
        Me.CheckBoxCpu65C02.TabIndex = 15
        Me.CheckBoxCpu65C02.Text = "Generate 65C02 opcodes"
        Me.CheckBoxCpu65C02.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.RadioButtonC99)
        Me.GroupBox7.Controls.Add(Me.RadioButtonC89)
        Me.GroupBox7.Controls.Add(Me.RadioButtonCC65)
        Me.GroupBox7.Location = New System.Drawing.Point(387, 1)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(294, 179)
        Me.GroupBox7.TabIndex = 17
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "C language level"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 32)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "This is the default mode. It is like c99 mode, but additional features are enable" &
    "d."
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "This enables a few features from the C99 standard."
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "This disables anything that is illegal in C89/C90"
        '
        'RadioButtonC99
        '
        Me.RadioButtonC99.AutoSize = True
        Me.RadioButtonC99.Location = New System.Drawing.Point(7, 128)
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
        Me.RadioButtonC89.Location = New System.Drawing.Point(7, 75)
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
        'ButtonFromProject
        '
        Me.ButtonFromProject.Image = CType(resources.GetObject("ButtonFromProject.Image"), System.Drawing.Image)
        Me.ButtonFromProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonFromProject.Location = New System.Drawing.Point(367, 232)
        Me.ButtonFromProject.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonFromProject.Name = "ButtonFromProject"
        Me.ButtonFromProject.Size = New System.Drawing.Size(79, 44)
        Me.ButtonFromProject.TabIndex = 8
        Me.ButtonFromProject.Text = "project"
        Me.ButtonFromProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonFromProject.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Image = CType(resources.GetObject("ButtonRemove.Image"), System.Drawing.Image)
        Me.ButtonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRemove.Location = New System.Drawing.Point(7, 234)
        Me.ButtonRemove.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(85, 42)
        Me.ButtonRemove.TabIndex = 10
        Me.ButtonRemove.Text = "remove"
        Me.ButtonRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'ButtonFromParent
        '
        Me.ButtonFromParent.Image = CType(resources.GetObject("ButtonFromParent.Image"), System.Drawing.Image)
        Me.ButtonFromParent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonFromParent.Location = New System.Drawing.Point(454, 232)
        Me.ButtonFromParent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonFromParent.Name = "ButtonFromParent"
        Me.ButtonFromParent.Size = New System.Drawing.Size(79, 44)
        Me.ButtonFromParent.TabIndex = 11
        Me.ButtonFromParent.Text = "parent"
        Me.ButtonFromParent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonFromParent.UseVisualStyleBackColor = True
        '
        'OptionsCC65Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 285)
        Me.Controls.Add(Me.ButtonFromParent)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.ButtonFromGlobal)
        Me.Controls.Add(Me.ButtonRestore)
        Me.Controls.Add(Me.ButtonApply)
        Me.Controls.Add(Me.TabControlOptions)
        Me.Controls.Add(Me.ButtonFromProject)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OptionsCC65Window"
        Me.Text = "OptionsCC65Window"
        Me.TabPageSymbols.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridViewSymbols, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageIncludeDirs.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DataGridViewIncludeDirs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageOptimizations.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.TrackBarRegisterSpace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarCodeSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageSegments.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.TabPageDebug.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.TabPageOutput.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControlOptions.ResumeLayout(False)
        Me.TabPageCC65.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TrackBarRegisterSpace As TrackBar
    Friend WithEvents CheckBoxSignedChars As CheckBox
    Friend WithEvents CheckBoxInlineFunctions As CheckBox
    Friend WithEvents TabPageSymbols As TabPage
    Friend WithEvents CheckBoxRegisterVars As CheckBox
    Friend WithEvents CheckBoxOptimizeCode As CheckBox
    Friend WithEvents CheckBoxStaticLocals As CheckBox
    Friend WithEvents TrackBarCodeSize As TrackBar
    Friend WithEvents TabPageIncludeDirs As TabPage
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
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents CheckBoxCheckStack As CheckBox
    Friend WithEvents TabPageDebug As TabPage
    Friend WithEvents TabPageOutput As TabPage
    Friend WithEvents TabControlOptions As TabControl
    Friend WithEvents TabPageCC65 As TabPage
    Friend WithEvents ButtonFromProject As Button
    Friend WithEvents CheckBoxCodeSizeEnabled As CheckBox
    Friend WithEvents CheckBoxAllCDecl As CheckBox
    Friend WithEvents CheckBoxInlineStdFunctions As CheckBox
    Friend WithEvents CheckBoxLocalStrings As CheckBox
    Friend WithEvents LabelRegisterSpace As Label
    Friend WithEvents CheckBoxRegisterSpaceEnabled As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxDepTargetFileName As TextBox
    Friend WithEvents CheckBoxDepTarget As CheckBox
    Friend WithEvents TextBoxCreateFullDepFileName As TextBox
    Friend WithEvents CheckBoxCreateFullDep As CheckBox
    Friend WithEvents TextBoxDependencyFileName As TextBox
    Friend WithEvents CheckBoxCreateDep As CheckBox
    Friend WithEvents TextBoxBinaryFileName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CheckBoxAtariLo As CheckBox
    Friend WithEvents CheckBoxAtari As CheckBox
    Friend WithEvents CheckBoxC128 As CheckBox
    Friend WithEvents CheckBoxC64 As CheckBox
    Friend WithEvents CheckBoxVic2024 As CheckBox
    Friend WithEvents CheckBoxVic20 As CheckBox
    Friend WithEvents CheckBoxC16 As CheckBox
    Friend WithEvents CheckBoxPlus4 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBoxCpu65C02 As CheckBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButtonC99 As RadioButton
    Friend WithEvents RadioButtonC89 As RadioButton
    Friend WithEvents RadioButtonCC65 As RadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelCodeSize As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridViewSymbols As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DataGridViewIncludeDirs As DataGridView
    Friend WithEvents CheckBoxForgetIncPath As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents SymbolName As DataGridViewTextBoxColumn
    Friend WithEvents SymbolValue As DataGridViewTextBoxColumn
    Friend WithEvents Path As DataGridViewTextBoxColumn
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents ButtonFromParent As Button
End Class
