<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OptionsMakeWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsMakeWindow))
        Me.TabPageExecutable = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckBoxDiskImage = New System.Windows.Forms.CheckBox()
        Me.TextBoxDiskImageFilename = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxExecutableFileName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPageMake = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxActionClean = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxActionBuild = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxAdditionalParams = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButtonInternal = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDynamicMakefile = New System.Windows.Forms.RadioButton()
        Me.RadioButtonStaticMakefile = New System.Windows.Forms.RadioButton()
        Me.TextBoxMakeFileName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabControlOptions = New System.Windows.Forms.TabControl()
        Me.TabPageStorage = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TabPageTargets = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CheckBoxAtariLo = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAtari = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC128 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC64 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVic2024 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVic20 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC16 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPlus4 = New System.Windows.Forms.CheckBox()
        Me.ButtonFromParent = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonFromGlobal = New System.Windows.Forms.Button()
        Me.ButtonRestore = New System.Windows.Forms.Button()
        Me.ButtonApply = New System.Windows.Forms.Button()
        Me.ButtonFromProject = New System.Windows.Forms.Button()
        Me.TabPageExecutable.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPageMake.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabControlOptions.SuspendLayout()
        Me.TabPageStorage.SuspendLayout()
        Me.TabPageTargets.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPageExecutable
        '
        Me.TabPageExecutable.Controls.Add(Me.Panel2)
        Me.TabPageExecutable.Location = New System.Drawing.Point(4, 29)
        Me.TabPageExecutable.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageExecutable.Name = "TabPageExecutable"
        Me.TabPageExecutable.Size = New System.Drawing.Size(699, 188)
        Me.TabPageExecutable.TabIndex = 3
        Me.TabPageExecutable.Text = "Executable"
        Me.TabPageExecutable.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CheckBoxDiskImage)
        Me.Panel2.Controls.Add(Me.TextBoxDiskImageFilename)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TextBoxExecutableFileName)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(693, 182)
        Me.Panel2.TabIndex = 0
        '
        'CheckBoxDiskImage
        '
        Me.CheckBoxDiskImage.AutoSize = True
        Me.CheckBoxDiskImage.Location = New System.Drawing.Point(355, 3)
        Me.CheckBoxDiskImage.Name = "CheckBoxDiskImage"
        Me.CheckBoxDiskImage.Size = New System.Drawing.Size(230, 24)
        Me.CheckBoxDiskImage.TabIndex = 13
        Me.CheckBoxDiskImage.Text = "Put all files on this disk image:"
        Me.CheckBoxDiskImage.UseVisualStyleBackColor = True
        '
        'TextBoxDiskImageFilename
        '
        Me.TextBoxDiskImageFilename.Location = New System.Drawing.Point(355, 34)
        Me.TextBoxDiskImageFilename.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxDiskImageFilename.Name = "TextBoxDiskImageFilename"
        Me.TextBoxDiskImageFilename.Size = New System.Drawing.Size(317, 27)
        Me.TextBoxDiskImageFilename.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(106, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(457, 77)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "It is possible to create ""dynamic"" names by using some variables, such as {target" &
    "} to indicate the target selected with the contextual menu or {support} for file" &
    " format."
        '
        'TextBoxExecutableFileName
        '
        Me.TextBoxExecutableFileName.Location = New System.Drawing.Point(18, 34)
        Me.TextBoxExecutableFileName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxExecutableFileName.Name = "TextBoxExecutableFileName"
        Me.TextBoxExecutableFileName.Size = New System.Drawing.Size(317, 27)
        Me.TextBoxExecutableFileName.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 20)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Executable filename"
        '
        'TabPageMake
        '
        Me.TabPageMake.Controls.Add(Me.Panel1)
        Me.TabPageMake.Location = New System.Drawing.Point(4, 29)
        Me.TabPageMake.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageMake.Name = "TabPageMake"
        Me.TabPageMake.Size = New System.Drawing.Size(699, 188)
        Me.TabPageMake.TabIndex = 4
        Me.TabPageMake.Text = "Make"
        Me.TabPageMake.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBoxActionClean)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TextBoxActionBuild)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextBoxAdditionalParams)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.TextBoxMakeFileName)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 182)
        Me.Panel1.TabIndex = 0
        '
        'TextBoxActionClean
        '
        Me.TextBoxActionClean.Location = New System.Drawing.Point(160, 147)
        Me.TextBoxActionClean.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxActionClean.Name = "TextBoxActionClean"
        Me.TextBoxActionClean.Size = New System.Drawing.Size(109, 27)
        Me.TextBoxActionClean.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(156, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Action for clean"
        '
        'TextBoxActionBuild
        '
        Me.TextBoxActionBuild.Location = New System.Drawing.Point(22, 147)
        Me.TextBoxActionBuild.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxActionBuild.Name = "TextBoxActionBuild"
        Me.TextBoxActionBuild.Size = New System.Drawing.Size(109, 27)
        Me.TextBoxActionBuild.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Action for build"
        '
        'TextBoxAdditionalParams
        '
        Me.TextBoxAdditionalParams.Location = New System.Drawing.Point(22, 87)
        Me.TextBoxAdditionalParams.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxAdditionalParams.Name = "TextBoxAdditionalParams"
        Me.TextBoxAdditionalParams.Size = New System.Drawing.Size(188, 27)
        Me.TextBoxAdditionalParams.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Additional params"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.RadioButtonInternal)
        Me.GroupBox5.Controls.Add(Me.RadioButtonDynamicMakefile)
        Me.GroupBox5.Controls.Add(Me.RadioButtonStaticMakefile)
        Me.GroupBox5.Location = New System.Drawing.Point(276, 7)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(401, 167)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Kind of generation"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(351, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Generate a new brand makefile and call ""make""."
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Look for an existing makefile and call ""make""."
        '
        'RadioButtonInternal
        '
        Me.RadioButtonInternal.AutoSize = True
        Me.RadioButtonInternal.Location = New System.Drawing.Point(6, 135)
        Me.RadioButtonInternal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonInternal.Name = "RadioButtonInternal"
        Me.RadioButtonInternal.Size = New System.Drawing.Size(285, 24)
        Me.RadioButtonInternal.TabIndex = 2
        Me.RadioButtonInternal.TabStop = True
        Me.RadioButtonInternal.Text = "Use internal procedure (w/out ""make"")"
        Me.RadioButtonInternal.UseVisualStyleBackColor = True
        '
        'RadioButtonDynamicMakefile
        '
        Me.RadioButtonDynamicMakefile.AutoSize = True
        Me.RadioButtonDynamicMakefile.Location = New System.Drawing.Point(6, 80)
        Me.RadioButtonDynamicMakefile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonDynamicMakefile.Name = "RadioButtonDynamicMakefile"
        Me.RadioButtonDynamicMakefile.Size = New System.Drawing.Size(175, 24)
        Me.RadioButtonDynamicMakefile.TabIndex = 1
        Me.RadioButtonDynamicMakefile.TabStop = True
        Me.RadioButtonDynamicMakefile.Text = "Use dynamic makefile"
        Me.RadioButtonDynamicMakefile.UseVisualStyleBackColor = True
        '
        'RadioButtonStaticMakefile
        '
        Me.RadioButtonStaticMakefile.AutoSize = True
        Me.RadioButtonStaticMakefile.Location = New System.Drawing.Point(6, 28)
        Me.RadioButtonStaticMakefile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RadioButtonStaticMakefile.Name = "RadioButtonStaticMakefile"
        Me.RadioButtonStaticMakefile.Size = New System.Drawing.Size(154, 24)
        Me.RadioButtonStaticMakefile.TabIndex = 0
        Me.RadioButtonStaticMakefile.TabStop = True
        Me.RadioButtonStaticMakefile.Text = "Use static makefile"
        Me.RadioButtonStaticMakefile.UseVisualStyleBackColor = True
        '
        'TextBoxMakeFileName
        '
        Me.TextBoxMakeFileName.Location = New System.Drawing.Point(22, 32)
        Me.TextBoxMakeFileName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxMakeFileName.Name = "TextBoxMakeFileName"
        Me.TextBoxMakeFileName.Size = New System.Drawing.Size(188, 27)
        Me.TextBoxMakeFileName.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 7)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 20)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Makefile filename"
        '
        'TabControlOptions
        '
        Me.TabControlOptions.Controls.Add(Me.TabPageMake)
        Me.TabControlOptions.Controls.Add(Me.TabPageExecutable)
        Me.TabControlOptions.Controls.Add(Me.TabPageStorage)
        Me.TabControlOptions.Controls.Add(Me.TabPageTargets)
        Me.TabControlOptions.Location = New System.Drawing.Point(7, 7)
        Me.TabControlOptions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlOptions.Name = "TabControlOptions"
        Me.TabControlOptions.SelectedIndex = 0
        Me.TabControlOptions.Size = New System.Drawing.Size(707, 221)
        Me.TabControlOptions.TabIndex = 5
        '
        'TabPageStorage
        '
        Me.TabPageStorage.Controls.Add(Me.Panel4)
        Me.TabPageStorage.Location = New System.Drawing.Point(4, 29)
        Me.TabPageStorage.Name = "TabPageStorage"
        Me.TabPageStorage.Size = New System.Drawing.Size(699, 188)
        Me.TabPageStorage.TabIndex = 5
        Me.TabPageStorage.Text = "Storage"
        Me.TabPageStorage.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(3, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(690, 177)
        Me.Panel4.TabIndex = 0
        '
        'TabPageTargets
        '
        Me.TabPageTargets.Controls.Add(Me.Panel3)
        Me.TabPageTargets.Location = New System.Drawing.Point(4, 29)
        Me.TabPageTargets.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageTargets.Name = "TabPageTargets"
        Me.TabPageTargets.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPageTargets.Size = New System.Drawing.Size(699, 188)
        Me.TabPageTargets.TabIndex = 1
        Me.TabPageTargets.Text = "Targets"
        Me.TabPageTargets.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.CheckBoxAtariLo)
        Me.Panel3.Controls.Add(Me.CheckBoxAtari)
        Me.Panel3.Controls.Add(Me.CheckBoxC128)
        Me.Panel3.Controls.Add(Me.CheckBoxC64)
        Me.Panel3.Controls.Add(Me.CheckBoxVic2024)
        Me.Panel3.Controls.Add(Me.CheckBoxVic20)
        Me.Panel3.Controls.Add(Me.CheckBoxC16)
        Me.Panel3.Controls.Add(Me.CheckBoxPlus4)
        Me.Panel3.Location = New System.Drawing.Point(6, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(686, 174)
        Me.Panel3.TabIndex = 0
        '
        'CheckBoxAtariLo
        '
        Me.CheckBoxAtariLo.AutoSize = True
        Me.CheckBoxAtariLo.Location = New System.Drawing.Point(448, 32)
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
        Me.CheckBoxAtari.Location = New System.Drawing.Point(448, 64)
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
        Me.CheckBoxC128.Location = New System.Drawing.Point(263, 96)
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
        Me.CheckBoxC64.Location = New System.Drawing.Point(263, 64)
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
        Me.CheckBoxVic2024.Location = New System.Drawing.Point(9, 96)
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
        Me.CheckBoxVic20.Location = New System.Drawing.Point(9, 64)
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
        Me.CheckBoxC16.Location = New System.Drawing.Point(9, 32)
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
        Me.CheckBoxPlus4.Location = New System.Drawing.Point(263, 32)
        Me.CheckBoxPlus4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBoxPlus4.Name = "CheckBoxPlus4"
        Me.CheckBoxPlus4.Size = New System.Drawing.Size(166, 24)
        Me.CheckBoxPlus4.TabIndex = 19
        Me.CheckBoxPlus4.Text = "Commodore PLUS/4"
        Me.CheckBoxPlus4.UseVisualStyleBackColor = True
        '
        'ButtonFromParent
        '
        Me.ButtonFromParent.Image = CType(resources.GetObject("ButtonFromParent.Image"), System.Drawing.Image)
        Me.ButtonFromParent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonFromParent.Location = New System.Drawing.Point(454, 230)
        Me.ButtonFromParent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonFromParent.Name = "ButtonFromParent"
        Me.ButtonFromParent.Size = New System.Drawing.Size(79, 44)
        Me.ButtonFromParent.TabIndex = 17
        Me.ButtonFromParent.Text = "parent"
        Me.ButtonFromParent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonFromParent.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Image = CType(resources.GetObject("ButtonRemove.Image"), System.Drawing.Image)
        Me.ButtonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRemove.Location = New System.Drawing.Point(7, 232)
        Me.ButtonRemove.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(85, 42)
        Me.ButtonRemove.TabIndex = 16
        Me.ButtonRemove.Text = "remove"
        Me.ButtonRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'ButtonFromGlobal
        '
        Me.ButtonFromGlobal.Image = CType(resources.GetObject("ButtonFromGlobal.Image"), System.Drawing.Image)
        Me.ButtonFromGlobal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonFromGlobal.Location = New System.Drawing.Point(280, 229)
        Me.ButtonFromGlobal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonFromGlobal.Name = "ButtonFromGlobal"
        Me.ButtonFromGlobal.Size = New System.Drawing.Size(79, 44)
        Me.ButtonFromGlobal.TabIndex = 15
        Me.ButtonFromGlobal.Text = "global"
        Me.ButtonFromGlobal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonFromGlobal.UseVisualStyleBackColor = True
        '
        'ButtonRestore
        '
        Me.ButtonRestore.Image = CType(resources.GetObject("ButtonRestore.Image"), System.Drawing.Image)
        Me.ButtonRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRestore.Location = New System.Drawing.Point(100, 231)
        Me.ButtonRestore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonRestore.Name = "ButtonRestore"
        Me.ButtonRestore.Size = New System.Drawing.Size(85, 42)
        Me.ButtonRestore.TabIndex = 13
        Me.ButtonRestore.Text = "restore"
        Me.ButtonRestore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRestore.UseVisualStyleBackColor = True
        '
        'ButtonApply
        '
        Me.ButtonApply.Image = CType(resources.GetObject("ButtonApply.Image"), System.Drawing.Image)
        Me.ButtonApply.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonApply.Location = New System.Drawing.Point(636, 230)
        Me.ButtonApply.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonApply.Name = "ButtonApply"
        Me.ButtonApply.Size = New System.Drawing.Size(69, 44)
        Me.ButtonApply.TabIndex = 12
        Me.ButtonApply.Text = "apply"
        Me.ButtonApply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonApply.UseVisualStyleBackColor = True
        '
        'ButtonFromProject
        '
        Me.ButtonFromProject.Image = CType(resources.GetObject("ButtonFromProject.Image"), System.Drawing.Image)
        Me.ButtonFromProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonFromProject.Location = New System.Drawing.Point(367, 230)
        Me.ButtonFromProject.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonFromProject.Name = "ButtonFromProject"
        Me.ButtonFromProject.Size = New System.Drawing.Size(79, 44)
        Me.ButtonFromProject.TabIndex = 14
        Me.ButtonFromProject.Text = "project"
        Me.ButtonFromProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonFromProject.UseVisualStyleBackColor = True
        '
        'OptionsMakeWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 282)
        Me.Controls.Add(Me.ButtonFromParent)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.ButtonFromGlobal)
        Me.Controls.Add(Me.ButtonRestore)
        Me.Controls.Add(Me.ButtonApply)
        Me.Controls.Add(Me.ButtonFromProject)
        Me.Controls.Add(Me.TabControlOptions)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "OptionsMakeWindow"
        Me.Text = "OptionsMakeWindow"
        Me.TabPageExecutable.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPageMake.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabControlOptions.ResumeLayout(False)
        Me.TabPageStorage.ResumeLayout(False)
        Me.TabPageTargets.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPageExecutable As TabPage
    Friend WithEvents TabPageMake As TabPage
    Friend WithEvents TabControlOptions As TabControl
    Friend WithEvents TabPageTargets As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxExecutableFileName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxActionClean As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxActionBuild As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxAdditionalParams As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents RadioButtonDynamicMakefile As RadioButton
    Friend WithEvents RadioButtonStaticMakefile As RadioButton
    Friend WithEvents TextBoxMakeFileName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CheckBoxAtariLo As CheckBox
    Friend WithEvents CheckBoxAtari As CheckBox
    Friend WithEvents CheckBoxC128 As CheckBox
    Friend WithEvents CheckBoxC64 As CheckBox
    Friend WithEvents CheckBoxVic2024 As CheckBox
    Friend WithEvents CheckBoxVic20 As CheckBox
    Friend WithEvents CheckBoxC16 As CheckBox
    Friend WithEvents CheckBoxPlus4 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButtonInternal As RadioButton
    Friend WithEvents TabPageStorage As TabPage
    Friend WithEvents CheckBoxDiskImage As CheckBox
    Friend WithEvents TextBoxDiskImageFilename As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ButtonFromParent As Button
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents ButtonFromGlobal As Button
    Friend WithEvents ButtonRestore As Button
    Friend WithEvents ButtonApply As Button
    Friend WithEvents ButtonFromProject As Button
End Class
