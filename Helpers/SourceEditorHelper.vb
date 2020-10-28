Imports System.IO
Imports System.Text.RegularExpressions
Imports ScintillaNET
Imports System.Threading.Thread
Imports System.Windows.Forms.VisualStyles

Module SourceEditorHelper

    Public Sub ParseIdeConfigurationInSource(_source As String, _source_editor As SourceEditor)

        Dim rx As New Regex("midresIde\.([^\:]+)\:*([^\;]*)",
               RegexOptions.Compiled Or RegexOptions.IgnoreCase)

        Dim matches As MatchCollection = rx.Matches(_source)

        For Each match As Match In matches
            Dim groups As GroupCollection = match.Groups
            Select Case LCase(groups.Item(1).Value)
                Case "makecommandline"
                    _source_editor.MakeCommandLine = groups.Item(2).Value
                Case "executablename"
                    _source_editor.ExecutableName = groups.Item(2).Value
                Case Else
                    MsgBox("Warning: configuration parameter midresIde." & groups.Item(1).Value & " is unknown.", vbOKOnly, "UNKNOWN IDE CONFIGURATION'S PARAMETER")
            End Select
        Next
    End Sub

    Public Function GetExecutableName(_executable_name As String, _target As String)
        Dim support As String = ""

        Select Case _target
            Case "c16"
                support = "d64"
            Case "c64"
                support = "d64"
            Case "c128"
                support = "d64"
            Case "vic20"
                support = "d64"
            Case "vic2024"
                support = "d64"
            Case "plus4"
                support = "d64"
            Case "atari"
                support = "atr"
            Case "atarilo"
                support = "atr"
        End Select

        Return _executable_name.Replace("{target}", _target).Replace("{support}", support)

    End Function


    Public Function FocusOnFilenameAndLine(_filename As String, _line As Integer, _main_container As MainContainer, _warning As Integer) As Integer

        Dim se As SourceEditor = OpenFileEx(_filename, _main_container)

        Dim scintilla As Scintilla = se.ScintillaSource

        scintilla.Lines(_line - 1).MarkerAdd((_warning - 1) * 2)
        scintilla.Lines(_line - 1).MarkerAdd((_warning - 1) * 2 + 1)

        Dim linesOnScreen As Integer = scintilla.LinesOnScreen - 2
        Dim xStart As Integer = scintilla.Lines(_line - (linesOnScreen / 2)).Position
        Dim xEnd As Integer = scintilla.Lines(_line + (linesOnScreen / 2)).Position
        scintilla.ScrollRange(xStart, xEnd)
        se.BringToFront()
        se.Show()

        Return se.ScintillaSource.Markers.Count

    End Function

    Public Sub FocusOnFilenameAndPosition(_filename As String, _position As Integer, _main_container As MainContainer)

        Dim se As SourceEditor = OpenFileEx(_filename, _main_container)

        Dim scintilla As Scintilla = se.ScintillaSource

        scintilla.GotoPosition(_position)

        se.BringToFront()
        se.Show()

    End Sub

    Public Function FocusOnFilenameAndMarker(_filename As String, _line As Integer, _main_container As MainContainer, _warning As Integer) As Integer

        Dim se As SourceEditor = OpenFileEx(_filename, _main_container)

        Dim scintilla As Scintilla = se.ScintillaSource

        Dim linesOnScreen As Integer = scintilla.LinesOnScreen - 2
        Dim xStart As Integer = scintilla.Lines(_line - (linesOnScreen / 2)).Position
        Dim xEnd As Integer = scintilla.Lines(_line + (linesOnScreen / 2)).Position
        scintilla.ScrollRange(xStart, xEnd)
        se.BringToFront()
        se.Show()

        Return se.ScintillaSource.Markers.Count

    End Function

    Friend Sub FindNext(_source_editor As SourceEditor, _find_dialog As FindReplaceDialog, _replace_text As String, _replace_all As Boolean)

        Dim scintillaSource = _source_editor.ScintillaSource

        Dim linesOnScreen As Integer = scintillaSource.LinesOnScreen - 2

        If scintillaSource.SelectionStart >= 0 Then
            scintillaSource.TargetStart = scintillaSource.SelectionStart + 1
        End If

        scintillaSource.TargetEnd = (scintillaSource.Text.Count - 1)

        scintillaSource.SearchFlags = SearchFlags.None

        If _find_dialog.MatchCase Then
            scintillaSource.SearchFlags = scintillaSource.SearchFlags Or SearchFlags.MatchCase
        End If
        If _find_dialog.MatchWholeWord Then
            scintillaSource.SearchFlags = scintillaSource.SearchFlags Or SearchFlags.WholeWord
        End If
        If _find_dialog.Regex Then
            scintillaSource.SearchFlags = scintillaSource.SearchFlags Or SearchFlags.Regex
        End If

        If Not _replace_all Then

            Dim p As Integer

            p = scintillaSource.SearchInTarget(_find_dialog.SearchText)

            If p < 0 Then

                MsgBox("Text not found")

            Else

                'Dim xStart As Integer = p - (linesOnScreen / 2) * 20
                'Dim xEnd As Integer = p + (linesOnScreen / 2) * 20
                'scintillaSource.ScrollRange(xStart, xEnd)
                scintillaSource.GotoPosition(p)

                scintillaSource.SelectionStart = p
                scintillaSource.SelectionEnd = scintillaSource.SelectionStart + Len(_find_dialog.SearchText)
                If Not _replace_text Is Nothing Then
                    scintillaSource.ReplaceSelection(_replace_text)
                End If
            End If

        Else
            Dim p As Integer = 0

            While p >= 0

                scintillaSource.TargetStart = p
                scintillaSource.TargetEnd = (scintillaSource.Text.Count - 1)

                p = scintillaSource.SearchInTarget(_find_dialog.SearchText)

                If p > 0 Then

                    'Dim xStart As Integer = p - (linesOnScreen / 2) * 20
                    'Dim xEnd As Integer = p + (linesOnScreen / 2) * 20
                    'scintillaSource.ScrollRange(xStart, xEnd)

                    scintillaSource.GotoPosition(p)

                    scintillaSource.SelectionStart = p
                    scintillaSource.SelectionEnd = scintillaSource.SelectionStart + Len(_find_dialog.SearchText)
                    If Not _replace_text Is Nothing Then
                        scintillaSource.ReplaceSelection(_replace_text)
                        p += (Len(_replace_text) - Len(_find_dialog.SearchText)) + 1
                    End If
                End If

            End While

        End If

        scintillaSource.Focus()

    End Sub

    Public Sub MakeFileForTarget(_source_editor As SourceEditor, _target As String)

        ParseIdeConfigurationInSource(_source_editor.ScintillaSource.Text, _source_editor)

        Dim path = System.IO.Path.GetDirectoryName(_source_editor.Text)

        path = GetRootPath()

        If _source_editor.ExecutableName = "" Then
            MsgBox("Cannot make executable file, since ExecutableName parameter is missing.", vbOKOnly, "CANNOT RUN MAKEFILE")
            Exit Sub
        End If

        MakeFileForTargetInternal(_source_editor.ExecutableName, _source_editor.MakeCommandLine, _target, path, GlobalVars.CurrentOptions, True)

    End Sub

    Public Sub MakeCurrentSource(_source_editor As SourceEditor, _target As String)
        If GlobalVars.CurrentFolder Is Nothing Then
            MakeFileForTarget(_source_editor, _target)
        Else
            If GlobalVars.CurrentFolder.Kind = FolderEntry.KindEnum.EXECUTABLE Then
                MakeExecutableFolderForTarget(GlobalVars.CurrentFolder, _target)
            Else
                MakeLibraryFolderForTarget(GlobalVars.CurrentFolder, _target)
            End If
        End If
    End Sub

    Public Sub UpdateMenuEntriesForSpecificOptions(_source_editor As SourceEditor, _options As Options)

        If Not (_options Is Nothing) Then
            _source_editor.CompileForToolStripMenuItem.Visible = True
            _source_editor.CompileForToolStripMenuItem.Enabled = True
            _source_editor.RunOnToolStripMenuItem.Visible = True
            _source_editor.RunOnToolStripMenuItem.Enabled = True
            _source_editor.VIC20ToolStripMenuItem.Visible = _options.CC65.Vic20
            _source_editor.VIC20ToolStripMenuItem.Enabled = _options.CC65.Vic20
            _source_editor.VIC2024KBToolStripMenuItem.Visible = _options.CC65.Vic2024
            _source_editor.VIC2024KBToolStripMenuItem.Enabled = _options.CC65.Vic2024
            _source_editor.C64ToolStripMenuItem.Visible = _options.CC65.C64
            _source_editor.C64ToolStripMenuItem.Enabled = _options.CC65.C64
            _source_editor.C128ToolStripMenuItem.Visible = _options.CC65.C128
            _source_editor.C128ToolStripMenuItem.Enabled = _options.CC65.C128
            _source_editor.C16ToolStripMenuItem.Visible = _options.CC65.C16
            _source_editor.C16ToolStripMenuItem.Enabled = _options.CC65.C16
            _source_editor.PLUS4ToolStripMenuItem.Visible = _options.CC65.Plus4
            _source_editor.PLUS4ToolStripMenuItem.Enabled = _options.CC65.Plus4
            _source_editor.ATARI8BitToolStripMenuItem.Visible = _options.CC65.Atari
            _source_editor.ATARI8BitToolStripMenuItem.Enabled = _options.CC65.Atari
            _source_editor.ATARI8BitlowResolutionToolStripMenuItem.Visible = _options.CC65.Atarilo
            _source_editor.ATARI8BitlowResolutionToolStripMenuItem.Enabled = _options.CC65.Atarilo

            _source_editor.VIC20ToolStripMenuItem1.Visible = _options.Emulators.ViceEnabled And _options.CC65.Vic20
            _source_editor.VIC20ToolStripMenuItem1.Enabled = _options.Emulators.ViceEnabled And _options.CC65.Vic20
            _source_editor.VIC2024KBToolStripMenuItem1.Visible = _options.Emulators.ViceEnabled And _options.CC65.Vic2024
            _source_editor.VIC2024KBToolStripMenuItem1.Enabled = _options.Emulators.ViceEnabled And _options.CC65.Vic2024
            _source_editor.C64ToolStripMenuItem1.Visible = _options.Emulators.ViceEnabled And _options.CC65.C64
            _source_editor.C64ToolStripMenuItem1.Enabled = _options.Emulators.ViceEnabled And _options.CC65.C64
            _source_editor.C128ToolStripMenuItem1.Visible = _options.Emulators.ViceEnabled And _options.CC65.C128
            _source_editor.C128ToolStripMenuItem1.Enabled = _options.Emulators.ViceEnabled And _options.CC65.C128
            _source_editor.C16ToolStripMenuItem1.Visible = _options.Emulators.ViceEnabled And _options.CC65.C16
            _source_editor.C16ToolStripMenuItem1.Enabled = _options.Emulators.ViceEnabled And _options.CC65.C16
            _source_editor.PLUS4ToolStripMenuItem1.Visible = (_options.Emulators.ViceEnabled Or _options.Emulators.YapeEnabled) And _options.CC65.Plus4
            _source_editor.PLUS4ToolStripMenuItem1.Enabled = (_options.Emulators.ViceEnabled Or _options.Emulators.YapeEnabled) And _options.CC65.Plus4
            _source_editor.ATARI8BitToolStripMenuItem1.Visible = (_options.Emulators.AltirraEnabled Or _options.Emulators.Atari800Enabled) And _options.CC65.Atari
            _source_editor.ATARI8BitToolStripMenuItem1.Enabled = (_options.Emulators.AltirraEnabled Or _options.Emulators.Atari800Enabled) And _options.CC65.Atari
            _source_editor.ATARI8BitlowResolutionToolStripMenuItem1.Visible = (_options.Emulators.AltirraEnabled Or _options.Emulators.Atari800Enabled) And _options.CC65.Atarilo
            _source_editor.ATARI8BitlowResolutionToolStripMenuItem1.Enabled = (_options.Emulators.AltirraEnabled Or _options.Emulators.Atari800Enabled) And _options.CC65.Atarilo
        Else
            _source_editor.CompileForToolStripMenuItem.Visible = False
            _source_editor.CompileForToolStripMenuItem.Enabled = False
            _source_editor.RunOnToolStripMenuItem.Visible = False
            _source_editor.RunOnToolStripMenuItem.Enabled = False
            _source_editor.VIC20ToolStripMenuItem1.Enabled = False
            _source_editor.VIC2024KBToolStripMenuItem1.Enabled = False
            _source_editor.C64ToolStripMenuItem1.Enabled = False
            _source_editor.C128ToolStripMenuItem1.Enabled = False
            _source_editor.C16ToolStripMenuItem1.Enabled = False
            _source_editor.PLUS4ToolStripMenuItem1.Enabled = False
            _source_editor.ATARI8BitToolStripMenuItem1.Enabled = False
            _source_editor.ATARI8BitlowResolutionToolStripMenuItem1.Enabled = False
        End If

    End Sub

End Module
