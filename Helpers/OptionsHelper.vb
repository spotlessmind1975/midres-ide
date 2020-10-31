﻿Imports System.IO
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

    Public Sub UpdateOptions(_options_window As OptionsWindow, Optional _options As Options = Nothing)

        If GlobalVars.CurrentProject Is Nothing Then
            _options_window.ButtonFromProject.Visible = False
        Else
            _options_window.ButtonFromProject.Visible = True
        End If

        If (_options Is Nothing) Then
            _options = GlobalVars.CurrentOptions
            _options_window.ButtonRestore.Visible = True
        Else
            _options_window.ButtonRestore.Visible = False
        End If

        _options_window.CheckBoxALTIRRA.Checked = _options.Emulators.AltirraEnabled
        _options_window.TextBoxALTIRRAPath.Text = _options.Emulators.AltirraPath
        _options_window.CheckBoxATARI800.Checked = _options.Emulators.Atari800Enabled
        _options_window.TextBoxATARI800Path.Text = _options.Emulators.Atari800Path
        _options_window.CheckBoxYAPE.Checked = _options.Emulators.YapeEnabled
        _options_window.TextBoxYAPEPath.Text = _options.Emulators.YapePath
        _options_window.CheckBoxVICE.Checked = _options.Emulators.ViceEnabled
        _options_window.TextBoxVICEPath.Text = _options.Emulators.VicePath

        Dim c As Collection = _options.CC65.Warnings

        _options_window.CheckedListBoxCC65Warnings.Items.Clear()
        For i = 1 To c.Count
            _options_window.CheckedListBoxCC65Warnings.Items.Add(c(i).Pattern, c(i).Ignored)
        Next

        _options_window.CheckBoxPlus4.Checked = _options.CC65.Plus4
        _options_window.CheckBoxC16.Checked = _options.CC65.C16
        _options_window.CheckBoxVic20.Checked = _options.CC65.Vic20
        _options_window.CheckBoxVic2024.Checked = _options.CC65.Vic2024
        _options_window.CheckBoxC64.Checked = _options.CC65.C64
        _options_window.CheckBoxC128.Checked = _options.CC65.C128
        _options_window.CheckBoxAtari.Checked = _options.CC65.Atari
        _options_window.CheckBoxAtariLo.Checked = _options.CC65.Atarilo

        _options_window.CheckBoxStaticLocals.Checked = _options.CC65.StaticLocals
        For Each symbol In _options.CC65.Symbols
            Dim parts() As String = symbol.split("=")
            If UBound(parts) = 0 Then
                _options_window.DataGridViewSymbols.Rows.Add(parts(0), Nothing)
            Else
                _options_window.DataGridViewSymbols.Rows.Add(parts(0), parts(1))
            End If
        Next
        For Each includeDir In _options.CC65.IncludeDirs
            _options_window.ListBoxIncludeDirs.Items.Add(includeDir)
        Next
        _options_window.CheckBoxOptimizeCode.Checked = _options.CC65.OptimizeCode
        _options_window.CheckBoxOptimizeCodeInline.Checked = _options.CC65.OptimizeCodeInline
        _options_window.CheckBoxRegisterVars.Checked = _options.CC65.RegisterVars
        _options_window.CheckBoxInlineFunctions.Checked = _options.CC65.InlineFunctions
        _options_window.CheckBoxAddSource.Checked = _options.CC65.AddSource
        _options_window.CheckBoxSuppressWarnings.Checked = _options.CC65.SuppressWarnings
        _options_window.CheckBoxDebugInfo.Checked = _options.CC65.DebugInfo
        _options_window.CheckBoxSignedChars.Checked = _options.CC65.SignedChars
        '' _options_window.TextBoxOutputFile.Text = _options.CC65.OutputFile
        _options_window.TextBoxBssName.Text = _options.CC65.BssName
        _options_window.CheckBoxCheckStack.Checked = _options.CC65.CheckStack
        _options_window.TextBoxCodeName.Text = _options.CC65.CodeName
        _options_window.TrackBarCodeSize.Value = _options.CC65.CodeSize
        _options_window.CheckBoxCpu65C02.Checked = _options.CC65.Cpu65C02
        _options_window.CheckBoxCreateDep.Checked = _options.CC65.CreateDep
        _options_window.TextBoxDataName.Text = _options.CC65.DataName
        _options_window.CheckBoxForgetIncPath.Checked = _options.CC65.ForgetIncPath
        _options_window.TrackBarRegisterSpace.Value = _options.CC65.RegisterSpace
        _options_window.TextBoxRoDataName.Text = _options.CC65.RodataName
        Select Case _options.CC65.StandardLanguage
            Case OptionsCC65.LanguageEnum.CC65
                _options_window.RadioButtonCC65.Checked = True
            Case OptionsCC65.LanguageEnum.C89
                _options_window.RadioButtonC89.Checked = True
            Case OptionsCC65.LanguageEnum.C99
                _options_window.RadioButtonC99.Checked = True
        End Select
        _options_window.CheckBoxWritableStrings.Checked = _options.CC65.WritableStrings


        _options_window.TextBoxMakeFileName.Text = _options.Make.MakeFilename
        _options_window.RadioButtonStaticMakefile.Checked = _options.Make.DynamicMakefile
        _options_window.TextBoxAdditionalParams.Text = _options.Make.AdditionalParams
        _options_window.TextBoxActionBuild.Text = _options.Make.ActionBuild
        _options_window.TextBoxActionClean.Text = _options.Make.ActionClean

        _options_window.TextBoxBinaryFileName.Text = _options.Output.BinaryFilename
        _options_window.RadioButtonComplete.Checked = _options.Output.Complete

    End Sub

    Public Sub UpdateOptionsTileset(_options_window As OptionsTilesetWindow, Optional _options As Options = Nothing)

        If GlobalVars.CurrentProject Is Nothing Then
            _options_window.ButtonFromProject.Visible = False
        Else
            _options_window.ButtonFromProject.Visible = True
        End If

        If (_options Is Nothing) Then
            _options = GlobalVars.CurrentOptions
            _options_window.ButtonRestore.Visible = True
        Else
            _options_window.ButtonRestore.Visible = False
        End If

        _options_window.TextBoxTilesetBinaryFilename.Text = _options.Tileset.BinaryFilename
        _options_window.TextBoxBankNumber.Text = _options.Tileset.BankNumber
        _options_window.TextBoxTilesetHeaderFileName.Text = _options.Tileset.HeaderFilename
        _options_window.TrackBarTilesetThresholdLuminance.Value = _options.Tileset.ThresholdLuminance
        _options_window.CheckBoxTilesetMulticolor.Checked = _options.Tileset.Multicolor
        _options_window.CheckBoxTilesetReverse.Checked = _options.Tileset.Reverse

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

    End Sub

    Public Sub ApplyOptions(_options_window As OptionsWindow, Optional _options As Options = Nothing)

        If (_options Is Nothing) Then
            _options = GlobalVars.CurrentOptions
        End If

        _options.Emulators.AltirraEnabled = _options_window.CheckBoxALTIRRA.Checked
        _options.Emulators.AltirraPath = _options_window.TextBoxALTIRRAPath.Text
        _options.Emulators.Atari800Enabled = _options_window.CheckBoxATARI800.Checked
        _options.Emulators.Atari800Path = _options_window.TextBoxATARI800Path.Text
        _options.Emulators.YapeEnabled = _options_window.CheckBoxYAPE.Checked
        _options.Emulators.YapePath = _options_window.TextBoxYAPEPath.Text
        _options.Emulators.ViceEnabled = _options_window.CheckBoxVICE.Checked
        _options.Emulators.VicePath = _options_window.TextBoxVICEPath.Text

        Dim c As Collection = _options.CC65.Warnings

        For i = 1 To _options_window.CheckedListBoxCC65Warnings.Items.Count
            If (_options_window.CheckedListBoxCC65Warnings.GetItemCheckState(i - 1) = CheckState.Checked) Then
                c(_options_window.CheckedListBoxCC65Warnings.Items(i - 1)).Ignored = True
            Else
                c(_options_window.CheckedListBoxCC65Warnings.Items(i - 1)).Ignored = False
            End If
        Next

        _options.CC65.Plus4 = _options_window.CheckBoxPlus4.Checked
        _options.CC65.C16 = _options_window.CheckBoxC16.Checked
        _options.CC65.Vic20 = _options_window.CheckBoxVic20.Checked
        _options.CC65.Vic2024 = _options_window.CheckBoxVic2024.Checked
        _options.CC65.C64 = _options_window.CheckBoxC64.Checked
        _options.CC65.C128 = _options_window.CheckBoxC128.Checked
        _options.CC65.Atari = _options_window.CheckBoxAtari.Checked
        _options.CC65.Atarilo = _options_window.CheckBoxAtariLo.Checked

        _options.CC65.StaticLocals = _options_window.CheckBoxStaticLocals.Checked
        _options.CC65.Symbols.Clear()
        For Each row In _options_window.DataGridViewSymbols.Rows
            If Not (row.cells(0).Value Is Nothing) Then
                _options.CC65.Symbols.Add(row.cells(0).Value & "=" & row.cells(1).Value)
            Else
                _options.CC65.Symbols.Add(row.cells(0).Value)
            End If
        Next
        _options.CC65.IncludeDirs.Clear()
        For Each includeDir In _options_window.ListBoxIncludeDirs.Items
            _options.CC65.IncludeDirs.Add(includeDir)
        Next
        _options.CC65.OptimizeCode = _options_window.CheckBoxOptimizeCode.Checked
        _options.CC65.OptimizeCodeInline = _options_window.CheckBoxOptimizeCodeInline.Checked
        _options.CC65.RegisterVars = _options_window.CheckBoxRegisterVars.Checked
        _options.CC65.InlineFunctions = _options_window.CheckBoxInlineFunctions.Checked
        _options.CC65.AddSource = _options_window.CheckBoxAddSource.Checked
        _options.CC65.SuppressWarnings = _options_window.CheckBoxSuppressWarnings.Checked
        _options.CC65.DebugInfo = _options_window.CheckBoxDebugInfo.Checked
        _options.CC65.SignedChars = _options_window.CheckBoxSignedChars.Checked
        '' _options_window.TextBoxOutputFile.Text = _options.CC65.OutputFile
        _options.CC65.BssName = _options_window.TextBoxBssName.Text
        _options.CC65.CheckStack = _options_window.CheckBoxCheckStack.Checked
        _options.CC65.CodeName = _options_window.TextBoxCodeName.Text
        _options.CC65.CodeSize = _options_window.TrackBarCodeSize.Value
        _options.CC65.Cpu65C02 = _options_window.CheckBoxCpu65C02.Checked
        _options.CC65.CreateDep = _options_window.CheckBoxCreateDep.Checked
        _options.CC65.DataName = _options_window.TextBoxDataName.Text
        _options.CC65.ForgetIncPath = _options_window.CheckBoxForgetIncPath.Checked
        _options.CC65.RegisterSpace = _options_window.TrackBarRegisterSpace.Value
        _options.CC65.RodataName = _options_window.TextBoxRoDataName.Text
        If _options_window.RadioButtonCC65.Checked Then
            _options.CC65.StandardLanguage = OptionsCC65.LanguageEnum.CC65
        ElseIf _options_window.RadioButtonC89.Checked Then
            _options.CC65.StandardLanguage = OptionsCC65.LanguageEnum.C89
        ElseIf _options_window.RadioButtonC99.Checked Then
            _options.CC65.StandardLanguage = OptionsCC65.LanguageEnum.C99
        End If
        _options.CC65.WritableStrings = _options_window.CheckBoxWritableStrings.Checked

        _options.Make.MakeFilename = _options_window.TextBoxMakeFileName.Text
        _options.Make.DynamicMakefile = _options_window.RadioButtonStaticMakefile.Checked
        _options.Make.AdditionalParams = _options_window.TextBoxAdditionalParams.Text
        _options.Make.ActionBuild = _options_window.TextBoxActionBuild.Text
        _options.Make.ActionClean = _options_window.TextBoxActionClean.Text

        _options.Output.BinaryFilename = _options_window.TextBoxBinaryFileName.Text
        _options.Output.Complete = _options_window.RadioButtonComplete.Checked

        UpdateProjectExplorerMenuEntriesForSpecificOptions(ProjectExplorer, _options)

    End Sub

    Public Sub ApplyOptionsTileset(_options_window As OptionsTilesetWindow, Optional _options As Options = Nothing)

        If (_options Is Nothing) Then
            _options = GlobalVars.CurrentOptions
        End If

        _options.Tileset.BinaryFilename = _options_window.TextBoxTilesetBinaryFilename.Text
        _options.Tileset.BankNumber = _options_window.TextBoxBankNumber.Text
        _options.Tileset.HeaderFilename = _options_window.TextBoxTilesetHeaderFileName.Text
        _options.Tileset.ThresholdLuminance = _options_window.TrackBarTilesetThresholdLuminance.Value
        _options.Tileset.Multicolor = _options_window.CheckBoxTilesetMulticolor.Checked
        _options.Tileset.Reverse = _options_window.CheckBoxTilesetReverse.Checked

        UpdateProjectExplorerMenuEntriesForSpecificOptions(ProjectExplorer, _options)

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

    End Sub
    Public Function ShowOptionsWindow(_options As Options, _title As String, Optional _kind As FolderEntry.KindEnum = Nothing) As OptionsWindow
        Dim ow As OptionsWindow

        ow = New OptionsWindow With {
            .MdiParent = MainContainer,
            .CurrentOptions = _options
        }
        ow.Text = _title
        ow.Show()

        Return ow

    End Function

    Public Function ShowOptionsTilesetWindow(_options As Options, _title As String, Optional _kind As FolderEntry.KindEnum = Nothing) As OptionsTilesetWindow
        Dim ow As OptionsTilesetWindow

        ow = New OptionsTilesetWindow With {
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

    Public Function ChooseBestOptions() As Options
        If Not (GlobalVars.CurrentFolder Is Nothing) Then
            Return GlobalVars.CurrentFolder.CurrentOptions
        ElseIf Not (GlobalVars.CurrentProject Is Nothing) Then
            Return GlobalVars.CurrentProject.CurrentOptions
        ElseIf Not (GlobalVars.CurrentOptions Is Nothing) Then
            Return GlobalVars.CurrentOptions
        End If
        Return New Options
    End Function
End Module
