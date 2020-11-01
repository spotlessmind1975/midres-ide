Imports System.Collections.ObjectModel
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Xml.Serialization
Imports Microsoft.VisualBasic.FileIO
Module MainContainerHelper

    Public Function FilterForFolderKind(_kind As FolderEntry.KindEnum) As String

        Dim defaultFilter As String = "C source (*.c)|*.c|C include (*.h)|*.h|CC65/CL65 configure file (*.cfg)|*.cfg|MAKE file (makefile*.*)|makefile*.*|Any file (*.*)|*.*"

        Select Case _kind
            Case FolderEntry.KindEnum.FOLDER, FolderEntry.KindEnum.EXECUTABLE, FolderEntry.KindEnum.LIBRARY
                Return defaultFilter
            Case FolderEntry.KindEnum.TILESET
                Return "PNG image (*.png)|*.png|JPEG image (*.jpg)|*.jpg|BINary file (*.bin)|*.bin|Any file (*.*)|*.*"
        End Select

        Return defaultFilter
    End Function
    Public Function OpenDialogEx(Optional _folder_entry As FolderEntry = Nothing, Optional _multiple As Boolean = False)

        Dim path As String = ""

        Dim ofd As OpenFileDialog = New OpenFileDialog With {
            .Filter = FilterForFolderKind(_folder_entry.Kind),
            .FilterIndex = GlobalVars.LastExtensionUsed,
            .Multiselect = _multiple
        }

        If Not (_folder_entry Is Nothing) Then
            path = GetRootPath() & "\" & _folder_entry.Path
            ofd.InitialDirectory = path
        End If

        Dim result As DialogResult = ofd.ShowDialog()

        If (result = DialogResult.OK) Then
            GlobalVars.LastExtensionUsed = ofd.FilterIndex
            If _multiple Then
                Return ofd.FileNames
            Else
                Return ofd.FileName
            End If
        Else
            Return Nothing
        End If

    End Function
    Public Function OpenFolderDialogEx(Optional _starting_path As String = "") As String

        If (_starting_path = "") Then
            _starting_path = GetRootPath()
        End If

        Dim fbd As FolderBrowserDialog = New FolderBrowserDialog
        fbd.SelectedPath = _starting_path

        Dim result As DialogResult = fbd.ShowDialog()

        If (result = DialogResult.OK) Then
            Return fbd.SelectedPath
        Else
            Return Nothing
        End If

    End Function

    Public Sub LoadKeywords()

        Dim a = Assembly.GetExecutingAssembly()
        Dim resourceName As String = "midres_ide.midres_symbols.txt"

        Dim s As Stream = a.GetManifestResourceStream(resourceName)
        Dim sr As StreamReader = New StreamReader(s)
        Dim symbols = sr.ReadToEnd()

        GlobalVars.FunctionsAndDataTypes = "char const int long " &
                                            symbols.Replace(vbCrLf, " ").Replace(vbLf, " ").Replace("  ", " ") &
                                            "short signed struct unsigned void mr_pippero"

    End Sub
    Public Sub LoadRecentOpenedFiles()

        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\MIDRES-IDE"

        Try
            MkDir(path)
        Catch i As IOException

        End Try

        Try
            Dim fc As String = My.Computer.FileSystem.ReadAllText(path & "\recentopenedfiles")

            Dim p As Integer = InStr(fc, "<RecentFileCollection")
            If p > 0 Then

                fc = Mid(fc, p)

                Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(RecentFileCollection))

                GlobalVars.RecentOpenedFiles = xmlSerializer.Deserialize(New StringReader(fc))

            End If
        Catch e As FileNotFoundException

            GlobalVars.RecentOpenedFiles = New RecentFileCollection

        End Try

    End Sub

    Public Sub SaveRecentOpenedFiles()
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\MIDRES-IDE"

        Try
            MkDir(path)
        Catch i As IOException

        End Try

        Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(RecentFileCollection))

        Dim ms As MemoryStream = New MemoryStream()
        Dim sw As StreamWriter = New StreamWriter(ms, System.Text.Encoding.UTF8)

        xmlSerializer.Serialize(sw, GlobalVars.RecentOpenedFiles)

        My.Computer.FileSystem.WriteAllBytes(path & "\recentopenedfiles", ms.ToArray(), False)
    End Sub

    Public Sub UpdateRecentOpenedFiles(_main_container As MainContainer)

        If GlobalVars.RecentOpenedFiles.Items.Count > 0 Then
            _main_container.RecentlyOpenedToolStripMenuItem.Visible = True
            _main_container.RecentlyOpenedToolStripMenuItem.DropDownItems.Clear()
            Dim t As ToolStripMenuItem = New ToolStripMenuItem("Latest files opened:")
            _main_container.RecentlyOpenedToolStripMenuItem.DropDownItems.Add(t)
            t.Enabled = False
            Dim t2 As ToolStripSeparator = New ToolStripSeparator()
            _main_container.RecentlyOpenedToolStripMenuItem.DropDownItems.Add(t2)
            t2.Enabled = False
            For i = 1 To GlobalVars.RecentOpenedFiles.Items.Count
                Dim lbl As String
                Dim pe As RecentFileEntry = GlobalVars.RecentOpenedFiles.Items(i)
                Dim k As Keys
                Select Case i
                    Case 1
                        k = Keys.Control Or Keys.D1
                    Case 2
                        k = Keys.Control Or Keys.D2
                    Case 3
                        k = Keys.Control Or Keys.D3
                    Case 4
                        k = Keys.Control Or Keys.D4
                    Case 5
                        k = Keys.Control Or Keys.D5
                    Case 6
                        k = Keys.Control Or Keys.D6
                    Case 7
                        k = Keys.Control Or Keys.D7
                End Select
                If pe.Name = "" Then
                    lbl = pe.Filename
                Else
                    lbl = pe.Name & " (" & pe.Filename & ")"
                End If

                t = New ToolStripMenuItem(lbl, Nothing, New EventHandler(AddressOf _main_container.RecentyOpenedFilesToolStripMenuItem_Click)) With {
                    .Tag = i,
                    .ShortcutKeys = k
                }
                _main_container.RecentlyOpenedToolStripMenuItem.DropDownItems.Add(t)
            Next i
        Else
            _main_container.RecentlyOpenedToolStripMenuItem.Visible = False
        End If


    End Sub
    Public Function OpenSourceWindow(_main_container As MainContainer, Optional text As String = "", Optional filename As String = "") As SourceEditor

        Dim sourceEditor As SourceEditor
        sourceEditor = New SourceEditor With {
            .MdiParent = _main_container
        }
        sourceEditor.ScintillaSource.Text = text
        sourceEditor.ScintillaSource.EmptyUndoBuffer()
        sourceEditor.Changed = False
        ParseIdeConfigurationInSource(text, sourceEditor)
        If (filename <> "") Then
            sourceEditor.Text = Path.GetFullPath(filename)
        Else
            sourceEditor.Text = "(new file)"
        End If
        sourceEditor.Show()

        OpenSourceWindow = sourceEditor

    End Function
    Public Function OpenFileEx(_filename As String, _main_container As MainContainer, Optional _read_only As Boolean = False) As SourceEditor

        Dim openedSourceEditor As SourceEditor = Nothing

        If (GlobalVars.OpenedSourceEditors.Contains(_filename)) Then

            openedSourceEditor = GlobalVars.OpenedSourceEditors.Item(_filename)
            openedSourceEditor.OnlyRead = _read_only
            openedSourceEditor.Show()
            openedSourceEditor.BringToFront()

        Else

            Try
                Dim content As String = My.Computer.FileSystem.ReadAllText(_filename)

                openedSourceEditor = OpenSourceWindow(_main_container, content, _filename)
                openedSourceEditor.FileName = _filename
                openedSourceEditor.OnlyRead = _read_only

                GlobalVars.OpenedSourceEditors.Add(openedSourceEditor, _filename)

            Catch e As FileNotFoundException

            End Try

        End If

        OpenFileEx = openedSourceEditor

    End Function

    Public Sub OpenFile(_main_container As MainContainer)

        Dim filename As String = OpenDialogEx()

        If Not (filename Is Nothing) Then

            GlobalVars.LastOpenedFilePath = Path.GetDirectoryName(filename)

            Dim sourceEditor As SourceEditor = OpenFileEx(filename, _main_container)

            Dim recentFile As RecentFileEntry = New RecentFileEntry(sourceEditor.Text, "")

            GlobalVars.RecentOpenedFiles.Add(recentFile)

            UpdateRecentOpenedFiles(_main_container)

        End If

    End Sub

    Public Function OpenSaveDialogEx() As String

        Dim sfd = New SaveFileDialog()

        Dim result As DialogResult = sfd.ShowDialog()

        If result = DialogResult.OK Then

            Return Path.GetFullPath(sfd.FileName)

        Else

            Return Nothing

        End If

    End Function

    Public Sub SaveFile(_source_editor As SourceEditor, Optional _filename As String = "")

        Dim filename As String

        If (_filename = "") Then

            filename = OpenSaveDialogEx()

            If filename Is Nothing Then
                Exit Sub
            End If

        Else

            filename = Path.GetFullPath(_filename)

        End If

        If (GlobalVars.OpenedSourceEditors.Contains(filename)) Then

            GlobalVars.OpenedSourceEditors.Remove(filename)

        End If

        My.Computer.FileSystem.WriteAllText(filename, _source_editor.ScintillaSource.Text, False, System.Text.Encoding.ASCII)

        GlobalVars.OpenedSourceEditors.Add(_source_editor, filename)

        _source_editor.Changed = False

    End Sub

    Public Sub CloseFileEx(_source_editor As SourceEditor)

        If (GlobalVars.OpenedSourceEditors.Contains(_source_editor.FileName)) Then

            GlobalVars.OpenedSourceEditors.Remove(_source_editor.FileName)

        End If

    End Sub

    Public Sub ExitProgram()

        SaveOptions()

        SaveRecentOpenedFiles()

        SaveRecentOpenedProjects()

        End

    End Sub

    Public Sub ClearAllMarkers()
        For Each e In GlobalVars.OpenedSourceEditors
            Dim scintilla = e.selfScintillaSource
            Try
                For Each line In scintilla.Lines
                    line.MarkerDelete(0)
                    line.MarkerDelete(1)
                    line.MarkerDelete(2)
                    line.MarkerDelete(3)
                Next
            Catch exc As TargetInvocationException

            End Try
        Next
    End Sub

    Public Sub UpdateAllMenuEntries()
        For Each e In GlobalVars.OpenedSourceEditors
            e.UpdateMenuEntries()
        Next
    End Sub

    Public Sub UpdateMenuEntries(_main_container As MainContainer)

        If GlobalVars.CurrentProject Is Nothing Then
            _main_container.SaveToolStripMenuItem1.Enabled = False
            _main_container.SaveAsToolStripMenuItem1.Enabled = False
        Else
            _main_container.SaveToolStripMenuItem1.Enabled = True
            _main_container.SaveAsToolStripMenuItem1.Enabled = True
        End If

    End Sub

    Private Function ExtractLine(_content As String, _start As Integer)

        Dim startLine As Integer = InStrRev(_content, vbCrLf, _start)
        Dim endLine As Integer = InStr(_start, _content, vbCrLf)

        If (startLine = 0) Then
            startLine = 1
        Else
            startLine += 1
        End If

        Return Mid(_content, startLine, endLine - startLine)

    End Function
    Public Function FindInFile(_filename As String, _find_replace_dialog As FindReplaceDialog) As Collection

        Dim searchResultCollection As Collection = New Collection

        Dim content As String = My.Computer.FileSystem.ReadAllText(_filename)
        Dim searchText As String = _find_replace_dialog.SearchText

        If _find_replace_dialog.Regex Then
            Dim rx As Regex = New Regex(searchText)

            Dim mc As MatchCollection = rx.Matches(content, 0)

            If mc.Count > 0 Then
                For Each m As Match In mc
                    If m.Success Then

                        Dim s As SearchResult = New SearchResult(_filename, 0, ExtractLine(content, m.Index), m.Value, m.Index, Len(m.Value))

                        searchResultCollection.Add(s)

                    End If

                Next

            End If

        Else

            Dim p As Integer = 1

            While p > 0

                If _find_replace_dialog.MatchCase Then
                    If _find_replace_dialog.MatchWholeWord Then
                        p = InStr(p + 1, content, " " & searchText & " ")
                    Else
                        p = InStr(p + 1, content, searchText)
                    End If
                Else
                    If _find_replace_dialog.MatchWholeWord Then
                        p = InStr(p + 1, LCase(content), " " & LCase(searchText) & " ")
                    Else
                        p = InStr(p + 1, LCase(content), LCase(searchText))
                    End If
                End If

                If p > 0 Then

                    Dim s As SearchResult = New SearchResult(_filename, 0, ExtractLine(content, p), Mid(content, p, Len(_find_replace_dialog.SearchText)), p, Len(_find_replace_dialog.SearchText))

                    searchResultCollection.Add(s)

                End If

            End While

        End If

        Return searchResultCollection

    End Function
    Public Sub FindAll(_find_replace_dialog As FindReplaceDialog, _main_container As MainContainer)

        Dim PartialSearchResultCollection As Collection

        ClearSearchResult()

        Dim fileMasks = _find_replace_dialog.SearchFileMask.Split(";")

        Dim fileList As ReadOnlyCollection(Of String) = FileSystem.GetFiles(Path.GetFullPath(_find_replace_dialog.SearchPath), Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, fileMasks)

        For Each fileName In fileList
            PartialSearchResultCollection = FindInFile(fileName, _find_replace_dialog)
            For Each searchResult In PartialSearchResultCollection
                GlobalVars.SearchResultCollection.Add(searchResult)
            Next
        Next

        UpdateSearchResult(_main_container, "Results for " & _find_replace_dialog.SearchText & " in " & _find_replace_dialog.SearchPath & " [" & _find_replace_dialog.SearchFileMask & "]")

    End Sub

    Public Sub LoadProjectEx(_filename As String)

        Try
            Dim fc As String = My.Computer.FileSystem.ReadAllText(_filename)

            Dim p As Integer = InStr(fc, "<Project")
            If p > 0 Then

                fc = Mid(fc, p)

                Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(Project))

                GlobalVars.CurrentProject = xmlSerializer.Deserialize(New StringReader(fc))
                GlobalVars.CurrentProject.RootPath = Path.GetDirectoryName(_filename)
                GlobalVars.CurrentProject.Resolve()

            End If
        Catch e As FileNotFoundException

        End Try

    End Sub

    Public Sub SaveProjectEx(_filename)

        Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(Project))

        Dim ms As MemoryStream = New MemoryStream()
        Dim sw As StreamWriter = New StreamWriter(ms, System.Text.Encoding.UTF8)

        xmlSerializer.Serialize(sw, GlobalVars.CurrentProject)

        My.Computer.FileSystem.WriteAllBytes(_filename, ms.ToArray(), False)

    End Sub

    Public Sub OpenProject()
        Dim ofd As OpenFileDialog = New OpenFileDialog With {
            .Filter = "MIDRES PROJECT source (*.midresproj)|*.midresproj|Any file (*.*)|*.*"
        }

        Dim result As DialogResult = ofd.ShowDialog()

        If (result = DialogResult.OK) Then

            LoadProjectEx(ofd.FileName)

            UpdateProjectExplorer()

            ProjectExplorer.Text = Path.GetFullPath(ofd.FileName)

            GlobalVars.RecentOpenedProjects.Add(New RecentFileEntry(ofd.FileName, GlobalVars.CurrentProject.Name))

            UpdateRecentOpenedProjects(MainContainer)

        End If

    End Sub

    Public Sub SaveProject(Optional _filename As String = "")

        Dim filename = _filename
        Dim sfd = New SaveFileDialog()

        If (_filename = "(no name)" Or filename = "") Then

            sfd.ShowHelp = True

            Dim result As DialogResult = sfd.ShowDialog()

            If result = DialogResult.OK Then

                filename = Path.GetFullPath(sfd.FileName)

            Else

                Exit Sub

            End If

        Else

            filename = Path.GetFullPath(filename)

        End If

        SaveProjectEx(filename)
        ProjectExplorer.Text = Path.GetFullPath(filename)

    End Sub

    Public Sub LoadRecentOpenedProjects()

        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\MIDRES-IDE"

        Try
            MkDir(path)
        Catch i As IOException

        End Try

        Try
            Dim fc As String = My.Computer.FileSystem.ReadAllText(path & "\recentopenedprojects")

            Dim p As Integer = InStr(fc, "<RecentFileCollection")
            If p > 0 Then

                fc = Mid(fc, p)

                Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(RecentFileCollection))

                GlobalVars.RecentOpenedProjects = xmlSerializer.Deserialize(New StringReader(fc))

            End If
        Catch e As FileNotFoundException

            GlobalVars.RecentOpenedProjects = New RecentFileCollection

        End Try

    End Sub

    Public Sub SaveRecentOpenedProjects()
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\MIDRES-IDE"

        Try
            MkDir(path)
        Catch i As IOException

        End Try

        Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(RecentFileCollection))

        Dim ms As MemoryStream = New MemoryStream()
        Dim sw As StreamWriter = New StreamWriter(ms, System.Text.Encoding.UTF8)

        xmlSerializer.Serialize(sw, GlobalVars.RecentOpenedProjects)

        My.Computer.FileSystem.WriteAllBytes(path & "\recentopenedprojects", ms.ToArray(), False)
    End Sub

    Public Sub UpdateRecentOpenedProjects(_main_container As MainContainer)

        If GlobalVars.RecentOpenedProjects.Items.Count > 0 Then
            _main_container.RecentOpenedProjectsToolStripMenuItem.Visible = True
            _main_container.RecentOpenedProjectsToolStripMenuItem.DropDownItems.Clear()
            Dim t As ToolStripMenuItem = New ToolStripMenuItem("Latest projects opened:")
            _main_container.RecentOpenedProjectsToolStripMenuItem.DropDownItems.Add(t)
            t.Enabled = False
            Dim t2 As ToolStripSeparator = New ToolStripSeparator()
            _main_container.RecentOpenedProjectsToolStripMenuItem.DropDownItems.Add(t2)
            t2.Enabled = False
            For i = 1 To GlobalVars.RecentOpenedProjects.Items.Count
                Dim lbl As String
                Dim pe As RecentFileEntry = GlobalVars.RecentOpenedProjects.Items(i)
                Dim k As Keys
                Select Case i
                    Case 1
                        k = Keys.Shift Or Keys.Control Or Keys.D1
                    Case 2
                        k = Keys.Shift Or Keys.Control Or Keys.D2
                    Case 3
                        k = Keys.Shift Or Keys.Control Or Keys.D3
                    Case 4
                        k = Keys.Shift Or Keys.Control Or Keys.D4
                    Case 5
                        k = Keys.Shift Or Keys.Control Or Keys.D5
                    Case 6
                        k = Keys.Shift Or Keys.Control Or Keys.D6
                    Case 7
                        k = Keys.Shift Or Keys.Control Or Keys.D7
                End Select
                If pe.Name = "" Then
                    lbl = pe.Filename
                Else
                    lbl = pe.Name & " (" & pe.Filename & ")"
                End If
                t = New ToolStripMenuItem(lbl, Nothing, New EventHandler(AddressOf _main_container.RecentOpenedProjectsToolStripMenuItem_Click)) With {
                    .Tag = i,
                    .ShortcutKeys = k
                }
                _main_container.RecentOpenedProjectsToolStripMenuItem.DropDownItems.Add(t)
            Next i
        Else
            _main_container.RecentOpenedProjectsToolStripMenuItem.Visible = False
        End If

    End Sub

End Module
