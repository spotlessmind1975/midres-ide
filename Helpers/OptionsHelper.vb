Imports System.IO
Imports System.Xml.Serialization

Module OptionsHelper

    Public Sub LoadOptions()

        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\MIDRES-IDE"

        Try
            MkDir(path)
        Catch i As IOException

        End Try

        Try
            Dim fc As String = My.Computer.FileSystem.ReadAllText(path & "\options")

            Dim p As Integer = InStr(fc, "<Options")
            If p > 0 Then

                fc = Mid(fc, p)

                Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(Options))

                GlobalVars.CurrentOptions = xmlSerializer.Deserialize(New StringReader(fc))

            End If
        Catch e As FileNotFoundException

            GlobalVars.CurrentOptions = New Options

        End Try

        CompleteOptionsCC65()

    End Sub

    Public Sub CompleteOptionsCC65()

        Dim c As Collection = GlobalVars.CurrentOptions.CC65.Warnings

        If Not c.Contains("Unreachable code") Then
            Dim e = New CC65WarningEntry("Unreachable code", False)
            c.Add(e, "Unreachable code")
        End If


    End Sub
    Public Sub SaveOptions()
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\MIDRES-IDE"

        Try
            MkDir(path)
        Catch i As IOException

        End Try

        Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(Options))

        Dim ms As MemoryStream = New MemoryStream()
        Dim sw As StreamWriter = New StreamWriter(ms, System.Text.Encoding.UTF8)

        xmlSerializer.Serialize(sw, GlobalVars.CurrentOptions)

        My.Computer.FileSystem.WriteAllBytes(path & "\options", ms.ToArray(), False)
    End Sub

    Public Sub UpdateOptionsEmulators(_options_window As OptionsEmulatorsWindow, Optional _options As OptionsEmulators = Nothing)

        If (_options Is Nothing) Then
            _options = GlobalVars.CurrentOptions.Emulators
            _options_window.ButtonFromProject.Visible = False
            _options_window.ButtonFromParent.Visible = False
        Else
            _options_window.ButtonFromProject.Visible = True
            _options_window.ButtonFromParent.Visible = True
        End If

        _options_window.CheckBoxALTIRRA.Checked = _options.AltirraEnabled
        _options_window.TextBoxALTIRRAPath.Text = _options.AltirraPath
        _options_window.CheckBoxATARI800.Checked = _options.Atari800Enabled
        _options_window.TextBoxATARI800Path.Text = _options.Atari800Path
        _options_window.CheckBoxYAPE.Checked = _options.YapeEnabled
        _options_window.TextBoxYAPEPath.Text = _options.YapePath
        _options_window.CheckBoxVICE.Checked = _options.ViceEnabled
        _options_window.TextBoxVICEPath.Text = _options.VicePath

    End Sub

    Public Sub UpdateOptionsOther(_options_window As OptionsOtherWindow, Optional _options As OptionsOther = Nothing)

        If (_options Is Nothing) Then
            _options = GlobalVars.CurrentOptions.Other
            _options_window.ButtonFromProject.Visible = False
            _options_window.ButtonFromParent.Visible = False
        Else
            _options_window.ButtonFromProject.Visible = True
            _options_window.ButtonFromParent.Visible = True
        End If

        _options_window.CheckBoxPlus4.Checked = _options.Plus4
        _options_window.CheckBoxC16.Checked = _options.C16
        _options_window.CheckBoxVic20.Checked = _options.Vic20
        _options_window.CheckBoxVic2024.Checked = _options.Vic2024
        _options_window.CheckBoxC64.Checked = _options.C64
        _options_window.CheckBoxC128.Checked = _options.C128
        _options_window.CheckBoxAtari.Checked = _options.Atari
        _options_window.CheckBoxAtariLo.Checked = _options.Atarilo

    End Sub

    Public Sub UpdateOptionsMake(_options_window As OptionsMakeWindow, Optional _options As OptionsMake = Nothing)

        If (_options Is Nothing) Then
            _options = GlobalVars.CurrentOptions.Make
            _options_window.ButtonFromProject.Visible = False
            _options_window.ButtonFromParent.Visible = False
        Else
            _options_window.ButtonFromProject.Visible = True
            _options_window.ButtonFromParent.Visible = True
        End If

        _options_window.TextBoxMakeFileName.Text = _options.MakeFilename
        Select Case _options.Kind
            Case OptionsMake.KindGeneration.STATICAL
                _options_window.RadioButtonStaticMakefile.Checked = True
            Case OptionsMake.KindGeneration.DYNAMICAL
                _options_window.RadioButtonDynamicMakefile.Checked = True
            Case OptionsMake.KindGeneration.INTERNAL
                _options_window.RadioButtonInternal.Checked = True
        End Select
        _options_window.TextBoxAdditionalParams.Text = _options.AdditionalParams
        _options_window.TextBoxActionBuild.Text = _options.ActionBuild
        _options_window.TextBoxActionClean.Text = _options.ActionClean

        _options_window.TextBoxExecutableFileName.Text = _options.ExecutableFilename
        _options_window.CheckBoxDiskImage.Checked = _options.DiskImage
        _options_window.TextBoxDiskImageFilename.Text = _options.DiskImageFilename

        _options_window.CheckBoxPlus4.Checked = _options.Plus4
        _options_window.CheckBoxC16.Checked = _options.C16
        _options_window.CheckBoxVic20.Checked = _options.Vic20
        _options_window.CheckBoxVic2024.Checked = _options.Vic2024
        _options_window.CheckBoxC64.Checked = _options.C64
        _options_window.CheckBoxC128.Checked = _options.C128
        _options_window.CheckBoxAtari.Checked = _options.Atari
        _options_window.CheckBoxAtariLo.Checked = _options.Atarilo

    End Sub

    Public Sub UpdateOptionsCC65(_options_window As OptionsCC65Window, Optional _options As OptionsCC65 = Nothing)

        If (_options Is Nothing) Then
            _options = GlobalVars.CurrentOptions.CC65
            _options_window.ButtonFromProject.Visible = False
            _options_window.ButtonFromParent.Visible = False
        Else
            _options_window.ButtonFromProject.Visible = True
            _options_window.ButtonFromParent.Visible = True
        End If

        Dim c As Collection = _options.Warnings

        _options_window.CheckedListBoxCC65Warnings.Items.Clear()
        For i = 1 To c.Count
            _options_window.CheckedListBoxCC65Warnings.Items.Add(c(i).Pattern, c(i).Ignored)
        Next

        _options_window.CheckBoxPlus4.Checked = _options.Plus4
        _options_window.CheckBoxC16.Checked = _options.C16
        _options_window.CheckBoxVic20.Checked = _options.Vic20
        _options_window.CheckBoxVic2024.Checked = _options.Vic2024
        _options_window.CheckBoxC64.Checked = _options.C64
        _options_window.CheckBoxC128.Checked = _options.C128
        _options_window.CheckBoxAtari.Checked = _options.Atari
        _options_window.CheckBoxAtariLo.Checked = _options.Atarilo

        _options_window.CheckBoxAllCDecl.Checked = _options.AllCDecl
        _options_window.CheckBoxLocalStrings.Checked = _options.LocalStrings
        _options_window.CheckBoxStaticLocals.Checked = _options.StaticLocals
        _options_window.DataGridViewSymbols.Columns.Clear()
        _options_window.DataGridViewSymbols.Rows.Clear()
        _options_window.DataGridViewSymbols.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Name", .Width = 250})
        _options_window.DataGridViewSymbols.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Value", .Width = 370})
        For Each symbol In _options.Symbols
            If Trim(symbol) <> "" Then
                Dim parts() As String = symbol.split("=")
                If UBound(parts) = 0 Then
                    _options_window.DataGridViewSymbols.Rows.Add(parts(0), Nothing)
                Else
                    _options_window.DataGridViewSymbols.Rows.Add(parts(0), parts(1))
                End If
            End If
        Next
        _options_window.DataGridViewIncludeDirs.Columns.Clear()
        _options_window.DataGridViewIncludeDirs.Rows.Clear()
        _options_window.DataGridViewIncludeDirs.Columns.Add(New DataGridViewTextBoxColumn() With {.HeaderText = "Path", .Width = 620})
        For Each includeDir In _options.IncludeDirs
            If Trim(includeDir) <> "" Then
                _options_window.DataGridViewIncludeDirs.Rows.Add(includeDir)
            End If
        Next
        _options_window.CheckBoxOptimizeCode.Checked = _options.OptimizeCode
        _options_window.CheckBoxOptimizeCodeInline.Checked = _options.OptimizeCodeInline
        _options_window.CheckBoxRegisterVars.Checked = _options.RegisterVars
        _options_window.CheckBoxInlineFunctions.Checked = _options.InlineFunctions
        _options_window.CheckBoxInlineStdFunctions.Checked = _options.InlineStdFunctions
        _options_window.CheckBoxAddSource.Checked = _options.AddSource
        _options_window.CheckBoxSuppressWarnings.Checked = _options.SuppressWarnings
        _options_window.CheckBoxDebugInfo.Checked = _options.DebugInfo
        _options_window.CheckBoxSignedChars.Checked = _options.SignedChars
        _options_window.TextBoxBinaryFileName.Text = _options.OutputFile
        _options_window.TextBoxBssName.Text = _options.BssName
        _options_window.CheckBoxCheckStack.Checked = _options.CheckStack
        _options_window.TextBoxCodeName.Text = _options.CodeName
        _options_window.CheckBoxCodeSizeEnabled.Checked = _options.CodeSizeEnabled
        _options_window.TrackBarCodeSize.Value = _options.CodeSize
        _options_window.CheckBoxCpu65C02.Checked = _options.Cpu65C02
        _options_window.CheckBoxCreateDep.Checked = _options.CreateDep
        _options_window.TextBoxDependencyFileName.Text = _options.CreateDepFilename
        _options_window.CheckBoxCreateFullDep.Checked = _options.CreateFullDep
        _options_window.TextBoxCreateFullDepFileName.Text = _options.CreateFullDepFilename
        _options_window.CheckBoxDepTarget.Checked = _options.DepTarget
        _options_window.TextBoxDepTargetFileName.Text = _options.DepTargetFilename
        _options_window.TextBoxDataName.Text = _options.DataName
        _options_window.CheckBoxForgetIncPath.Checked = _options.ForgetIncPath
        _options_window.CheckBoxRegisterSpaceEnabled.Checked = _options.RegisterSpaceEnabled
        _options_window.TrackBarRegisterSpace.Value = _options.RegisterSpace
        _options_window.TextBoxRoDataName.Text = _options.RodataName
        Select Case _options.StandardLanguage
            Case OptionsCC65.LanguageEnum.CC65
                _options_window.RadioButtonCC65.Checked = True
            Case OptionsCC65.LanguageEnum.C89
                _options_window.RadioButtonC89.Checked = True
            Case OptionsCC65.LanguageEnum.C99
                _options_window.RadioButtonC99.Checked = True
        End Select
        _options_window.CheckBoxWritableStrings.Checked = _options.WritableStrings

    End Sub

    Public Sub UpdateOptionsTileset(_options_window As OptionsTilesetWindow, Optional _options As OptionsTileset = Nothing)

        If (_options Is Nothing) Then
            _options = GlobalVars.CurrentOptions.Tileset
            _options_window.ButtonFromProject.Visible = False
        Else
            _options_window.ButtonFromProject.Visible = True
        End If

        _options_window.TextBoxTilesetBinaryFilename.Text = _options.BinaryFilename
        _options_window.TextBoxBankNumber.Text = _options.BankNumber
        _options_window.TextBoxTilesetHeaderFileName.Text = _options.HeaderFilename
        _options_window.TrackBarTilesetThresholdLuminance.Value = _options.ThresholdLuminance
        _options_window.CheckBoxTilesetMulticolor.Checked = _options.Multicolor
        _options_window.CheckBoxTilesetReverse.Checked = _options.Reverse

    End Sub

    Public Sub UpdateOptionsGenerated(_options_window As OptionsGeneratedWindow, Optional _options As OptionsGenerated = Nothing)

        Dim kinds As Collection = New Collection
        kinds.Add(FolderEntry.KindEnum.EXECUTABLE)
        kinds.Add(FolderEntry.KindEnum.LIBRARY)
        kinds.Add(FolderEntry.KindEnum.TILESET)
        Dim folders As Collection = GlobalVars.CurrentProject.GetFoldersByKind(kinds)

        _options_window.CheckedListBoxDependency.Items.Clear()

        For Each folder In folders
            _options_window.CheckedListBoxDependency.Items.Add(folder.Name, _options.Dependencies.Contains(folder.GetHashCode()))
        Next
        _options_window.folders = folders

        _options_window.CheckBoxPlus4.Checked = _options.Plus4
        _options_window.CheckBoxC16.Checked = _options.C16
        _options_window.CheckBoxVic20.Checked = _options.Vic20
        _options_window.CheckBoxVic2024.Checked = _options.Vic2024
        _options_window.CheckBoxC64.Checked = _options.C64
        _options_window.CheckBoxC128.Checked = _options.C128
        _options_window.CheckBoxAtari.Checked = _options.Atari
        _options_window.CheckBoxAtariLo.Checked = _options.Atarilo

    End Sub

    Public Sub ApplyOptionsEmulators(_options_window As OptionsEmulatorsWindow, Optional _options As OptionsEmulators = Nothing)

        If (_options Is Nothing) Then
            _options = GlobalVars.CurrentOptions.Emulators
        End If

        _options.AltirraEnabled = _options_window.CheckBoxALTIRRA.Checked
        _options.AltirraPath = _options_window.TextBoxALTIRRAPath.Text
        _options.Atari800Enabled = _options_window.CheckBoxATARI800.Checked
        _options.Atari800Path = _options_window.TextBoxATARI800Path.Text
        _options.YapeEnabled = _options_window.CheckBoxYAPE.Checked
        _options.YapePath = _options_window.TextBoxYAPEPath.Text
        _options.ViceEnabled = _options_window.CheckBoxVICE.Checked
        _options.VicePath = _options_window.TextBoxVICEPath.Text

    End Sub

    Public Sub ApplyOptionsMake(_options_window As OptionsMakeWindow, Optional _options As OptionsMake = Nothing)

        If (_options Is Nothing) Then
            _options = GlobalVars.CurrentOptions.Make
        End If

        _options.MakeFilename = _options_window.TextBoxMakeFileName.Text
        If _options_window.RadioButtonStaticMakefile.Checked Then
            _options.Kind = OptionsMake.KindGeneration.STATICAL
        ElseIf _options_window.RadioButtonDynamicMakefile.Checked Then
            _options.Kind = OptionsMake.KindGeneration.DYNAMICAL
        ElseIf _options_window.RadioButtonInternal.Checked Then
            _options.Kind = OptionsMake.KindGeneration.INTERNAL
        End If
        _options.AdditionalParams = _options_window.TextBoxAdditionalParams.Text
        _options.ActionBuild = _options_window.TextBoxActionBuild.Text
        _options.ActionClean = _options_window.TextBoxActionClean.Text
        _options.DiskImage = _options_window.CheckBoxDiskImage.Checked
        _options.DiskImageFilename = _options_window.TextBoxDiskImageFilename.Text
        _options.ExecutableFilename = _options_window.TextBoxExecutableFileName.Text

        _options.Plus4 = _options_window.CheckBoxPlus4.Checked
        _options.C16 = _options_window.CheckBoxC16.Checked
        _options.Vic20 = _options_window.CheckBoxVic20.Checked
        _options.Vic2024 = _options_window.CheckBoxVic2024.Checked
        _options.C64 = _options_window.CheckBoxC64.Checked
        _options.C128 = _options_window.CheckBoxC128.Checked
        _options.Atari = _options_window.CheckBoxAtari.Checked
        _options.Atarilo = _options_window.CheckBoxAtariLo.Checked

    End Sub

    Public Sub ApplyOptionsOther(_options_window As OptionsOtherWindow, Optional _options As OptionsOther = Nothing)

        If (_options Is Nothing) Then
            _options = GlobalVars.CurrentOptions.Other
        End If

        _options.Plus4 = _options_window.CheckBoxPlus4.Checked
        _options.C16 = _options_window.CheckBoxC16.Checked
        _options.Vic20 = _options_window.CheckBoxVic20.Checked
        _options.Vic2024 = _options_window.CheckBoxVic2024.Checked
        _options.C64 = _options_window.CheckBoxC64.Checked
        _options.C128 = _options_window.CheckBoxC128.Checked
        _options.Atari = _options_window.CheckBoxAtari.Checked
        _options.Atarilo = _options_window.CheckBoxAtariLo.Checked

    End Sub

    Public Sub ApplyOptionsCC65(_options_window As OptionsCC65Window, Optional _options As OptionsCC65 = Nothing)

        If (_options Is Nothing) Then
            _options = GlobalVars.CurrentOptions.CC65
        End If

        Dim c As Collection = _options.Warnings

        For i = 1 To _options_window.CheckedListBoxCC65Warnings.Items.Count
            If (_options_window.CheckedListBoxCC65Warnings.GetItemCheckState(i - 1) = CheckState.Checked) Then
                c(_options_window.CheckedListBoxCC65Warnings.Items(i - 1)).Ignored = True
            Else
                c(_options_window.CheckedListBoxCC65Warnings.Items(i - 1)).Ignored = False
            End If
        Next

        _options.Plus4 = _options_window.CheckBoxPlus4.Checked
        _options.C16 = _options_window.CheckBoxC16.Checked
        _options.Vic20 = _options_window.CheckBoxVic20.Checked
        _options.Vic2024 = _options_window.CheckBoxVic2024.Checked
        _options.C64 = _options_window.CheckBoxC64.Checked
        _options.C128 = _options_window.CheckBoxC128.Checked
        _options.Atari = _options_window.CheckBoxAtari.Checked
        _options.Atarilo = _options_window.CheckBoxAtariLo.Checked

        _options.AllCDecl = _options_window.CheckBoxAllCDecl.Checked
        _options.LocalStrings = _options_window.CheckBoxLocalStrings.Checked
        _options.StaticLocals = _options_window.CheckBoxStaticLocals.Checked
        _options.Symbols.Clear()
        For Each row In _options_window.DataGridViewSymbols.Rows
            If Not (row.cells(1).Value Is Nothing) Then
                _options.Symbols.Add(row.cells(0).Value & "=" & row.cells(1).Value)
            ElseIf Not (row.cells(0).Value Is Nothing) Then
                _options.Symbols.Add(row.cells(0).Value)
            End If
        Next
        _options.IncludeDirs.Clear()
        For Each row In _options_window.DataGridViewIncludeDirs.Rows
            If Not (row.cells(0).Value Is Nothing) Then
                _options.IncludeDirs.Add(row.cells(0).Value)
            End If
        Next
        _options.OptimizeCode = _options_window.CheckBoxOptimizeCode.Checked
        _options.OptimizeCodeInline = _options_window.CheckBoxOptimizeCodeInline.Checked
        _options.RegisterVars = _options_window.CheckBoxRegisterVars.Checked
        _options.InlineFunctions = _options_window.CheckBoxInlineFunctions.Checked
        _options.InlineStdFunctions = _options_window.CheckBoxInlineStdFunctions.Checked
        _options.AddSource = _options_window.CheckBoxAddSource.Checked
        _options.SuppressWarnings = _options_window.CheckBoxSuppressWarnings.Checked
        _options.DebugInfo = _options_window.CheckBoxDebugInfo.Checked
        _options.SignedChars = _options_window.CheckBoxSignedChars.Checked
        _options.OutputFile = _options_window.TextBoxBinaryFileName.Text
        _options.BssName = _options_window.TextBoxBssName.Text
        _options.CheckStack = _options_window.CheckBoxCheckStack.Checked
        _options.CodeName = _options_window.TextBoxCodeName.Text
        _options.CodeSizeEnabled = _options_window.CheckBoxCodeSizeEnabled.Checked
        _options.CodeSize = _options_window.TrackBarCodeSize.Value
        _options.Cpu65C02 = _options_window.CheckBoxCpu65C02.Checked
        _options.CreateDep = _options_window.CheckBoxCreateDep.Checked
        _options.CreateDepFilename = _options_window.TextBoxDependencyFileName.Text
        _options.CreateFullDep = _options_window.CheckBoxCreateFullDep.Checked
        _options.CreateFullDepFilename = _options_window.TextBoxCreateFullDepFileName.Text
        _options.DepTarget = _options_window.CheckBoxDepTarget.Checked
        _options.DepTargetFilename = _options_window.TextBoxDepTargetFileName.Text
        _options.DataName = _options_window.TextBoxDataName.Text
        _options.ForgetIncPath = _options_window.CheckBoxForgetIncPath.Checked
        _options.RegisterSpaceEnabled = _options_window.CheckBoxRegisterSpaceEnabled.Checked
        _options.RegisterSpace = _options_window.TrackBarRegisterSpace.Value
        _options.RodataName = _options_window.TextBoxRoDataName.Text
        If _options_window.RadioButtonCC65.Checked Then
            _options.StandardLanguage = OptionsCC65.LanguageEnum.CC65
        ElseIf _options_window.RadioButtonC89.Checked Then
            _options.StandardLanguage = OptionsCC65.LanguageEnum.C89
        ElseIf _options_window.RadioButtonC99.Checked Then
            _options.StandardLanguage = OptionsCC65.LanguageEnum.C99
        End If
        _options.WritableStrings = _options_window.CheckBoxWritableStrings.Checked

    End Sub

    Public Sub ApplyOptionsTileset(_options_window As OptionsTilesetWindow, Optional _options As OptionsTileset = Nothing)

        _options.BinaryFilename = _options_window.TextBoxTilesetBinaryFilename.Text
        _options.BankNumber = _options_window.TextBoxBankNumber.Text
        _options.HeaderFilename = _options_window.TextBoxTilesetHeaderFileName.Text
        _options.ThresholdLuminance = _options_window.TrackBarTilesetThresholdLuminance.Value
        _options.Multicolor = _options_window.CheckBoxTilesetMulticolor.Checked
        _options.Reverse = _options_window.CheckBoxTilesetReverse.Checked

    End Sub

    Public Sub ApplyOptionsGenerated(_options_window As OptionsGeneratedWindow, Optional _options As OptionsGenerated = Nothing)

        If (_options Is Nothing) Then
            Exit Sub
        End If

        Dim kinds As Collection = New Collection
        kinds.Add(FolderEntry.KindEnum.EXECUTABLE)
        kinds.Add(FolderEntry.KindEnum.LIBRARY)
        kinds.Add(FolderEntry.KindEnum.TILESET)
        Dim folders As Collection = _options_window.Folders

        _options.Dependencies.Clear()

        For i = 0 To folders.Count - 1
            If _options_window.CheckedListBoxDependency.GetItemChecked(i) Then
                _options.Dependencies.Add(folders.Item(i + 1), folders.Item(i + 1).GetHashCode())
            End If
        Next

        _options.Plus4 = _options_window.CheckBoxPlus4.Checked
        _options.C16 = _options_window.CheckBoxC16.Checked
        _options.Vic20 = _options_window.CheckBoxVic20.Checked
        _options.Vic2024 = _options_window.CheckBoxVic2024.Checked
        _options.C64 = _options_window.CheckBoxC64.Checked
        _options.C128 = _options_window.CheckBoxC128.Checked
        _options.Atari = _options_window.CheckBoxAtari.Checked
        _options.Atarilo = _options_window.CheckBoxAtariLo.Checked

    End Sub
    Public Function ShowOptionsMakeWindow(_options As OptionsMake, _title As String, Optional _kind As FolderEntry.KindEnum = Nothing) As OptionsMakeWindow
        Dim ow As OptionsMakeWindow

        ow = New OptionsMakeWindow With {
            .MdiParent = MainContainer,
            .CurrentOptions = _options
        }
        ow.Text = _title
        ow.Show()

        Return ow

    End Function

    Public Function ShowOptionsTilesetWindow(_options As OptionsTileset, _title As String, Optional _kind As FolderEntry.KindEnum = Nothing) As OptionsTilesetWindow
        Dim ow As OptionsTilesetWindow

        ow = New OptionsTilesetWindow With {
            .MdiParent = MainContainer,
            .CurrentOptions = _options
        }
        ow.Text = _title
        ow.Show()

        Return ow

    End Function

    Public Function ShowOptionsCC65Window(_options As OptionsCC65, _title As String, Optional _kind As FolderEntry.KindEnum = Nothing) As OptionsCC65Window
        Dim ow As OptionsCC65Window

        ow = New OptionsCC65Window With {
            .MdiParent = MainContainer,
            .CurrentOptions = _options
        }
        ow.Text = _title
        ow.Show()

        Return ow

    End Function

    Public Function ShowOptionsOtherWindow(_options As OptionsOther, _title As String, Optional _kind As FolderEntry.KindEnum = Nothing) As OptionsOtherWindow
        Dim ow As OptionsOtherWindow

        ow = New OptionsOtherWindow With {
            .MdiParent = MainContainer,
            .CurrentOptions = _options
        }
        ow.Text = _title
        ow.Show()

        Return ow

    End Function

    Public Function ShowOptionsEmulatorsWindow(_options As OptionsEmulators, _title As String) As OptionsEmulatorsWindow
        Dim ow As OptionsEmulatorsWindow

        ow = New OptionsEmulatorsWindow With {
            .MdiParent = MainContainer,
            .CurrentOptions = _options
        }
        ow.Text = _title
        ow.Show()

        Return ow

    End Function
    Public Function ShowOptionsGeneratedWindow(_options As OptionsGenerated, _title As String) As OptionsGeneratedWindow
        Dim ow As OptionsGeneratedWindow

        ow = New OptionsGeneratedWindow With {
            .MdiParent = MainContainer,
            .CurrentOptions = _options
        }
        ow.Text = _title
        ow.Show()

        Return ow

    End Function

End Module
