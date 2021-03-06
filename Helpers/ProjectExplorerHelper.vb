﻿Imports System.IO
Imports Microsoft.Win32

Module ProjectExplorerHelper

    Public Function PopulateTreeViewWithFile(_file_entry As FileEntry) As TreeNode

        Dim s As TreeNode = New TreeNode(_file_entry.Name, 3, 3) With {
            .Tag = _file_entry,
            .ContextMenuStrip = ProjectExplorer.ContextMenuStripFile,
            .ToolTipText = _file_entry.Filename,
            .ImageIndex = FileToImageIndex(_file_entry),
            .SelectedImageIndex = FileToImageIndex(_file_entry)
        }

        Select Case _file_entry.Kind
            Case FileEntry.KindEnum.NORMAL
                If LCase(Path.GetExtension(_file_entry.Filename)) = ".c" Then
                    s.ContextMenuStrip = ProjectExplorer.ContextMenuStripSource
                Else
                    s.ContextMenuStrip = ProjectExplorer.ContextMenuStripFile
                End If
            Case FileEntry.KindEnum.GENERATED
                s.ContextMenuStrip = ProjectExplorer.ContextMenuStripGenerated
        End Select

        Return s

    End Function

    Public Function FolderToImageIndex(_folder_entry As FolderEntry)
        Select Case _folder_entry.Kind
            Case FolderEntry.KindEnum.FOLDER
                Return 2
            Case FolderEntry.KindEnum.LIBRARY
                If Not (_folder_entry.CurrentOptions Is Nothing) Then
                    Return 13
                End If
                Return 4
            Case FolderEntry.KindEnum.EXECUTABLE
                If Not (_folder_entry.CurrentOptions Is Nothing) Then
                    Return 14
                End If
                Return 5
            Case FolderEntry.KindEnum.TILESET
                Return 6
        End Select

        Return 2
    End Function

    Public Function FileToImageIndex(_file_entry As FileEntry)
        Select Case _file_entry.Kind
            Case FileEntry.KindEnum.NORMAL
                If Not (_file_entry.CC65 Is Nothing) Then
                    Return 12
                ElseIf Not (_file_entry.Other Is Nothing) Then
                    Return 15
                End If
                Return 3
            Case FileEntry.KindEnum.GENERATED
                If Not (_file_entry.Generated Is Nothing) Then
                    Return 16
                End If
                Return 10
        End Select

        Return 3
    End Function

    Public Function ProjectToImageIndex(_project As Project)
        If Not (_project.CurrentOptions Is Nothing) Then
            Return 17
        End If
        Return 1
    End Function
    Public Function PopulateTreeViewRicorsive(_folder_entry As FolderEntry) As TreeNode

        Dim t As TreeNode = New TreeNode(_folder_entry.Name, 2, 2) With {
            .Tag = _folder_entry,
            .ToolTipText = _folder_entry.Path,
            .ImageIndex = FolderToImageIndex(_folder_entry),
            .SelectedImageIndex = FolderToImageIndex(_folder_entry)
        }

        Select Case _folder_entry.Kind
            Case FolderEntry.KindEnum.FOLDER
                t.ContextMenuStrip = ProjectExplorer.ContextMenuStripFolder
            Case FolderEntry.KindEnum.LIBRARY
                t.ContextMenuStrip = ProjectExplorer.ContextMenuStripLibrary
            Case FolderEntry.KindEnum.EXECUTABLE
                t.ContextMenuStrip = ProjectExplorer.ContextMenuStripExecutable
            Case FolderEntry.KindEnum.TILESET
                t.ContextMenuStrip = ProjectExplorer.ContextMenuStripTileset
            Case Else
                t.ContextMenuStrip = ProjectExplorer.ContextMenuStripFolder
        End Select

        For Each folder In _folder_entry.Folders
            t.Nodes.Add(PopulateTreeViewRicorsive(folder))
        Next

        For Each file In _folder_entry.Files
            t.Nodes.Add(PopulateTreeViewWithFile(file))
        Next

        If _folder_entry.Opened Then
            t.Expand()
        End If

        Return t

    End Function

    Public Sub UpdateProjectExplorer()

        Dim p As Project = GlobalVars.CurrentProject
        Dim tv As TreeView = ProjectExplorer.TreeViewProject

        Dim treeViewProject As TreeView = ProjectExplorer.TreeViewProject

        tv.ShowNodeToolTips = True
        tv.Nodes.Clear()

        If Not (p Is Nothing) Then

            Dim t As TreeNode = New TreeNode(p.Name, 0, 0) With {
                .Tag = p,
                .ContextMenuStrip = ProjectExplorer.ContextMenuStripProject,
                .ToolTipText = GlobalVars.CurrentProject.RootPath,
                .ImageIndex = ProjectToImageIndex(GlobalVars.CurrentProject),
                .SelectedImageIndex = ProjectToImageIndex(GlobalVars.CurrentProject)
            }

            treeViewProject.Nodes.Add(t)

            For Each folder In p.Folders
                treeViewProject.Nodes(0).Nodes.Add(PopulateTreeViewRicorsive(folder))
            Next
            treeViewProject.Nodes(0).Expand()

            ProjectExplorer.MdiParent = MainContainer
            ProjectExplorer.Show()
        Else
            ProjectExplorer.Hide()
        End If

    End Sub

    Public Sub NormalizeProjectPath()

        Dim proj = GlobalVars.CurrentProject

        proj.NormalizePaths()

    End Sub

    Public Sub AddNewFolder(_project_explorer As ProjectExplorer)

        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is Project Or TypeOf tp.Tag Is FolderEntry Then

                Dim startingPath As String = ""

                If TypeOf tp.Tag Is FolderEntry Then
                    startingPath = GetFullPathForElement("", tp.Tag)
                End If

                Dim folderPath = OpenFolderDialogEx(startingPath)

                If Not (folderPath Is Nothing) Then
                    Dim rootFolder = tp.Tag

                    Dim f As FolderEntry = New FolderEntry(folderPath, folderPath.Replace(GetRootPath() & "\", ""))

                    rootFolder.Folders.Add(f, f.GetHashCode())

                    rootFolder.NormalizePaths()

                    tp.Nodes.Add(PopulateTreeViewRicorsive(f))

                End If

            End If
        End If
    End Sub

    Public Sub SetProjectRootPath(_project_explorer As ProjectExplorer)

        Dim projectNode As TreeNode = _project_explorer.TreeViewProject.Nodes(0)

        Dim path As String = OpenFolderDialogEx()

        If Not (path Is Nothing) Then
            GlobalVars.CurrentProject.RootPath = path
            projectNode.ToolTipText = path
            GlobalVars.CurrentProject.NormalizePaths()
        End If

    End Sub

    Public Sub AddExistingFile(_project_explorer As ProjectExplorer, Optional _multiple As Boolean = True)

        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is FolderEntry Then
                Dim filenames As String() = OpenDialogEx(tp.Tag, True)
                If Not (filenames Is Nothing) Then
                    For Each filename In filenames
                        Dim f As FileEntry = New FileEntry(filename, Path.GetFileName(filename))
                        tp.Tag.Files.Add(f, f.GetHashCode())
                        tp.Tag.NormalizePaths()
                        tp.Nodes.Add(PopulateTreeViewWithFile(f))
                    Next
                End If
            End If
        End If

    End Sub

    Public Sub AddNewFile(_project_explorer As ProjectExplorer)

        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is FolderEntry Then
                Dim filename As String = OpenSaveDialogEx()
                If Not (filename Is Nothing) Then
                    My.Computer.FileSystem.WriteAllText(filename, "", False, System.Text.Encoding.ASCII)
                    Dim f As FileEntry = New FileEntry(filename, Path.GetFileName(filename))
                    tp.Tag.Files.Add(f, f.GetHashCode())
                    tp.Tag.NormalizePaths()
                    tp.Nodes.Add(PopulateTreeViewWithFile(f))
                End If
            End If
        End If

    End Sub

    Public Sub RemoveFolder(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode
        Dim tpp As TreeNode = _project_explorer.TreeViewProject.SelectedNode.Parent

        If Not (tp Is Nothing) Then
            For i = 1 To tpp.Tag.Folders.Count
                If tpp.Tag.Folders(i).Equals(tp.Tag) Then
                    tpp.Tag.Folders.remove(i)
                    Exit For
                End If
            Next
            tpp.Nodes.Remove(tp)
        End If

    End Sub

    Public Sub ConsiderFolderAs(_project_explorer As ProjectExplorer, _kind As FolderEntry.KindEnum)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            tp.Tag.Kind = _kind
            Select Case _kind
                Case FolderEntry.KindEnum.FOLDER
                    tp.ContextMenuStrip = _project_explorer.ContextMenuStripFolder
                Case FolderEntry.KindEnum.LIBRARY
                    tp.ContextMenuStrip = _project_explorer.ContextMenuStripLibrary
                Case FolderEntry.KindEnum.EXECUTABLE
                    tp.ContextMenuStrip = _project_explorer.ContextMenuStripExecutable
                Case FolderEntry.KindEnum.TILESET
                    tp.ContextMenuStrip = _project_explorer.ContextMenuStripTileset
                Case Else
                    tp.ContextMenuStrip = _project_explorer.ContextMenuStripFolder
            End Select
            tp.ImageIndex = FolderToImageIndex(tp.Tag)
            tp.SelectedImageIndex = FolderToImageIndex(tp.Tag)
        End If

    End Sub

    Public Sub ConsiderFileAs(_project_explorer As ProjectExplorer, _kind As FileEntry.KindEnum)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            tp.Tag.Kind = _kind
            Select Case _kind
                Case FileEntry.KindEnum.NORMAL
                    If LCase(Path.GetExtension(tp.Tag.filename)) = ".c" Then
                        tp.ContextMenuStrip = _project_explorer.ContextMenuStripSource
                    Else
                        tp.ContextMenuStrip = _project_explorer.ContextMenuStripFile
                    End If
                Case FileEntry.KindEnum.GENERATED
                    tp.ContextMenuStrip = _project_explorer.ContextMenuStripGenerated
                Case Else
                    tp.ContextMenuStrip = _project_explorer.ContextMenuStripFile
            End Select
            tp.ImageIndex = FileToImageIndex(tp.Tag)
            tp.SelectedImageIndex = FileToImageIndex(tp.Tag)
        End If

    End Sub

    Public Sub OpenNodeFile(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode
        If Not (tp Is Nothing) Then
            Dim tpp As TreeNode = tp.Parent
            If Not (tpp Is Nothing) Then
                If TypeOf tp.Tag Is FileEntry Then
                    Dim filename As String = GetFullPathForElement(tp.Tag.filename, tpp.Tag)
                    Dim extension As String = Path.GetExtension(filename)
                    Select Case LCase(extension)
                        Case ".c", ".h"
                            Dim se As SourceEditor = OpenFileEx(filename, MainContainer, tp.Tag.Kind = FileEntry.KindEnum.GENERATED)
                        Case ".jpg", ".gif", ".png"
                            Shell("gimp-2.10.exe " & filename)
                        Case Else
                            Dim se As SourceEditor = OpenFileEx(filename, MainContainer)
                            se.CurrentFolder = tp.Parent.Tag
                            se.FormalLexer = ScintillaNET.Lexer.Container
                    End Select
                End If
            End If
        End If
    End Sub

    Public Sub RemoveFile(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode.Parent

        For i = 1 To tp.Tag.Files.Count
            If tp.Tag.files(i).Equals(_project_explorer.TreeViewProject.SelectedNode.Tag) Then
                tp.Tag.Files.remove(i)
                Exit For
            End If
        Next

        _project_explorer.TreeViewProject.SelectedNode.Parent.Nodes.Remove(_project_explorer.TreeViewProject.SelectedNode)
    End Sub

    Public Sub ShowOptionsWindowTileset(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is Project Then
                If tp.Tag.CurrentOptions Is Nothing Then
                    tp.Tag.CurrentOptions = New Options
                End If
                If tp.Tag.CurrentOptions.TileSet Is Nothing Then
                    tp.Tag.CurrentOptions.TileSet = GlobalVars.CurrentOptions.Tileset
                End If
                Dim ow As OptionsTilesetWindow = ShowOptionsTilesetWindow(tp.Tag.CurrentOptions.Tileset, "Tileset " & tp.Tag.name & " options")
                ow.TargetTreeNode = tp
            ElseIf TypeOf tp.Tag Is FolderEntry And tp.Tag.Kind = FolderEntry.KindEnum.TILESET Then
                Dim tp2 As TreeNode = tp
                If tp2.Tag.CurrentOptions Is Nothing Then
                    tp2.Tag.CurrentOptions = New Options
                End If
                If tp2.Tag.CurrentOptions.Tileset Is Nothing Then
                    While Not (tp2.Parent Is Nothing)
                        tp2 = tp2.Parent
                        If Not (tp2.Tag.currentOptions Is Nothing) Then
                            If Not (tp2.Tag.currentOptions.Tileset Is Nothing) Then
                                tp.Tag.currentOptions.Emulators = tp2.Tag.currentOptions.Emulators.deepClone()
                                Exit While
                            End If
                        End If
                    End While
                End If
                If tp.Tag.CurrentOptions.Tileset Is Nothing Then
                    tp.Tag.CurrentOptions.Tileset = GlobalVars.CurrentOptions.Tileset
                End If
                Dim ow As OptionsTilesetWindow = ShowOptionsTilesetWindow(tp.Tag.CurrentOptions.Tileset, "Tileset " & tp.Tag.name & " options")
                ow.TargetTreeNode = tp
            End If
        End If
    End Sub

    Public Sub ShowOptionsWindowEmulators(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is Project Then
                If tp.Tag.CurrentOptions Is Nothing Then
                    tp.Tag.CurrentOptions = New Options
                End If
                If tp.Tag.CurrentOptions.Emulators Is Nothing Then
                    tp.Tag.CurrentOptions.Emulators = GlobalVars.CurrentOptions.Emulators
                End If
                Dim ow As OptionsEmulatorsWindow = ShowOptionsEmulatorsWindow(tp.Tag.CurrentOptions.Emulators, "Emulators " & tp.Tag.name & " options")
                ow.TargetTreeNode = tp
            ElseIf TypeOf tp.Tag Is FolderEntry And tp.Tag.Kind = FolderEntry.KindEnum.EXECUTABLE Then
                Dim tp2 As TreeNode = tp
                If tp2.Tag.CurrentOptions Is Nothing Then
                    tp2.Tag.CurrentOptions = New Options
                End If
                If tp2.Tag.CurrentOptions.Emulators Is Nothing Then
                    While Not (tp2.Parent Is Nothing)
                        tp2 = tp2.Parent
                        If Not (tp2.Tag.currentOptions Is Nothing) Then
                            If Not (tp2.Tag.currentOptions.Emulators Is Nothing) Then
                                tp.Tag.currentOptions = New Options
                                tp.Tag.currentOptions.Emulators = tp2.Tag.currentOptions.Emulators.deepClone()
                                Exit While
                            End If
                        End If
                    End While
                End If
                If tp.Tag.CurrentOptions.Emulators Is Nothing Then
                    tp.Tag.CurrentOptions.Emulators = GlobalVars.CurrentOptions.Emulators
                End If
                Dim ow As OptionsEmulatorsWindow = ShowOptionsEmulatorsWindow(tp.Tag.CurrentOptions.Emulators, "Emulators " & tp.Tag.name & " options")
                ow.TargetTreeNode = tp
            End If
        End If
    End Sub

    Public Sub ShowOptionsWindowCC65(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is Project Then
                If tp.Tag.CurrentOptions Is Nothing Then
                    tp.Tag.CurrentOptions = New Options
                End If
                If tp.Tag.CurrentOptions.CC65 Is Nothing Then
                    tp.Tag.CurrentOptions.CC65 = GlobalVars.CurrentOptions.CC65
                End If
                Dim ow As OptionsCC65Window = ShowOptionsCC65Window(tp.Tag.CurrentOptions.CC65, "Compile " & tp.Tag.name & " options")
                ow.TargetTreeNode = tp
            ElseIf TypeOf tp.Tag Is FolderEntry Then
                If (tp.Tag.Kind = FolderEntry.KindEnum.EXECUTABLE Or tp.Tag.Kind = FolderEntry.KindEnum.LIBRARY) Then
                    Dim tp2 As TreeNode = tp
                    If tp2.Tag.CurrentOptions Is Nothing Then
                        tp2.Tag.CurrentOptions = New Options
                    End If
                    If tp2.Tag.CurrentOptions.CC65 Is Nothing Then
                        While Not (tp2.Parent Is Nothing)
                            tp2 = tp2.Parent
                            If Not (tp2.Tag.currentOptions Is Nothing) Then
                                If Not (tp2.Tag.currentOptions.CC65 Is Nothing) Then
                                    tp.Tag.currentOptions = New Options
                                    tp.Tag.currentOptions.CC65 = tp2.Tag.currentOptions.CC65.deepClone()
                                    Exit While
                                End If
                            End If
                        End While
                    End If
                    If tp.Tag.CurrentOptions.CC65 Is Nothing Then
                        tp.Tag.CurrentOptions.CC65 = GlobalVars.CurrentOptions.CC65
                    End If
                    Dim ow As OptionsCC65Window = ShowOptionsCC65Window(tp.Tag.CurrentOptions.CC65, "Compile " & tp.Tag.name & " options")
                    ow.TargetTreeNode = tp
                End If
            ElseIf TypeOf tp.Tag Is FileEntry Then
                Dim tp2 As TreeNode = tp
                If tp2.Tag.CC65 Is Nothing Then
                    While Not (tp2.Parent Is Nothing)
                        tp2 = tp2.Parent
                        If Not (tp2.Tag.currentOptions Is Nothing) Then
                            If Not (tp2.Tag.currentOptions.CC65 Is Nothing) Then
                                tp.Tag.CC65 = tp2.Tag.currentOptions.CC65.deepClone()
                                Exit While
                            End If
                        End If
                    End While
                End If
                If tp.Tag.CC65 Is Nothing Then
                    tp.Tag.cc65 = GlobalVars.CurrentOptions.CC65
                End If

                Dim ow As OptionsCC65Window = ShowOptionsCC65Window(tp.Tag.cc65, "Compile " & tp.Tag.name & " options")
                ow.TargetTreeNode = tp
            End If
        End If
    End Sub

    Public Sub ShowOptionsWindowOther(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is Project Then
                If tp.Tag.CurrentOptions Is Nothing Then
                    tp.Tag.CurrentOptions = New Options
                End If
                If tp.Tag.CurrentOptions.Other Is Nothing Then
                    tp.Tag.CurrentOptions.Other = GlobalVars.CurrentOptions.Other
                End If
                Dim ow As OptionsOtherWindow = ShowOptionsOtherWindow(tp.Tag.CurrentOptions.Other, "File " & tp.Tag.name & " options")
                ow.TargetTreeNode = tp
            ElseIf TypeOf tp.Tag Is FolderEntry Then
                If (tp.Tag.Kind = FolderEntry.KindEnum.EXECUTABLE Or tp.Tag.Kind = FolderEntry.KindEnum.LIBRARY) Then
                    Dim tp2 As TreeNode = tp
                    If tp2.Tag.CurrentOptions Is Nothing Then
                        tp2.Tag.CurrentOptions = New Options
                    End If
                    If tp2.Tag.CurrentOptions.Other Is Nothing Then
                        While Not (tp2.Parent Is Nothing)
                            tp2 = tp2.Parent
                            If Not (tp2.Tag.currentOptions Is Nothing) Then
                                If Not (tp2.Tag.currentOptions.Other Is Nothing) Then
                                    tp.Tag.currentOptions = New Options
                                    tp.Tag.currentOptions.Other = tp2.Tag.currentOptions.Other.deepClone()
                                    Exit While
                                End If
                            End If
                        End While
                    End If
                    If tp.Tag.CurrentOptions.Other Is Nothing Then
                        tp.Tag.CurrentOptions.Other = GlobalVars.CurrentOptions.Other
                    End If
                    Dim ow As OptionsOtherWindow = ShowOptionsOtherWindow(tp.Tag.CurrentOptions.Other, "File " & tp.Tag.name & " options")
                    ow.TargetTreeNode = tp
                End If
            ElseIf TypeOf tp.Tag Is FileEntry Then
                If (tp.Tag.Kind = FolderEntry.KindEnum.EXECUTABLE Or tp.Tag.Kind = FolderEntry.KindEnum.LIBRARY) Then
                    Dim tp2 As TreeNode = tp
                    If tp2.Tag.CC65 Is Nothing Then
                        While Not (tp2.Parent Is Nothing)
                            tp2 = tp2.Parent
                            If Not (tp2.Tag.currentOptions Is Nothing) Then
                                If Not (tp2.Tag.currentOptions.Other Is Nothing) Then
                                    tp.Tag.Other = tp2.Tag.currentOptions.Other.deepClone()
                                    Exit While
                                End If
                            End If
                        End While
                    End If
                    If tp.Tag.Other Is Nothing Then
                        tp.Tag.Other = GlobalVars.CurrentOptions.Other
                    End If
                    Dim ow As OptionsOtherWindow = ShowOptionsOtherWindow(tp.Tag.Other, "Compile " & tp.Tag.name & " options")
                    ow.TargetTreeNode = tp
                End If
            End If
        End If
    End Sub

    Public Sub ShowOptionsWindowMake(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode
        Dim windowtitle As String = ""

        If Not (tp Is Nothing) Then
            Dim tag As Object = Nothing
            If TypeOf tp.Tag Is Project Then
                If tp.Tag.CurrentOptions Is Nothing Then
                    tp.Tag.CurrentOptions = New Options
                End If
                If tp.Tag.CurrentOptions.Make Is Nothing Then
                    tp.Tag.CurrentOptions.Make = GlobalVars.CurrentOptions.Make
                End If
                Dim ow As OptionsMakeWindow = ShowOptionsMakeWindow(tag.CurrentOptions.Make, windowtitle)
                ow.TargetTreeNode = tp
            ElseIf (TypeOf tp.Tag Is FolderEntry And (tp.Tag.Kind = FolderEntry.KindEnum.EXECUTABLE Or tp.Tag.Kind = FolderEntry.KindEnum.LIBRARY)) Then
                Dim tp2 As TreeNode = tp
                If tp2.Tag.CurrentOptions Is Nothing Then
                    tp2.Tag.CurrentOptions = New Options
                End If
                If tp2.Tag.CurrentOptions.Other Is Nothing Then
                    While Not (tp2.Parent Is Nothing)
                        tp2 = tp2.Parent
                        If Not (tp2.Tag.currentOptions Is Nothing) Then
                            If Not (tp2.Tag.currentOptions.Other Is Nothing) Then
                                tp.Tag.currentOptions = New Options
                                tp.Tag.currentOptions.Make = tp2.Tag.currentOptions.Make.deepClone()
                                Exit While
                            End If
                        End If
                    End While
                End If
                If tp.Tag.CurrentOptions.Make Is Nothing Then
                    tp.Tag.CurrentOptions.Make = GlobalVars.CurrentOptions.Make
                End If
                Dim ow As OptionsMakeWindow = ShowOptionsMakeWindow(tp.Tag.CurrentOptions.Make, windowtitle)
                ow.TargetTreeNode = tp
            End If
        End If
    End Sub

    Public Sub ShowOptionsWindowGenerated(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is FileEntry And tp.Tag.Kind = FileEntry.KindEnum.GENERATED Then
                If tp.Tag.Generated Is Nothing Then
                    tp.Tag.Generated = New OptionsGenerated
                End If
                Dim ow As OptionsGeneratedWindow = ShowOptionsGeneratedWindow(tp.Tag.Generated, "Generated file " & tp.Tag.name & " options")
                ow.TargetTreeNode = tp
            End If
        End If
    End Sub

    Public Sub MakeLibraryFolderNodeForTarget(_project_explorer As ProjectExplorer, _target As String)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is FolderEntry And tp.Tag.Kind = FolderEntry.KindEnum.LIBRARY Then
                OutputWindow.CurrentFolder = tp.Tag
                AddOutputMessage(OutputEntry.LevelEnum.INFO, "MAKING [LIB] " & tp.Tag.Name & " (" & _target & ")")
                MakeLibraryFolderForTarget(tp.Tag, _target)
                AddOutputMessage(OutputEntry.LevelEnum.INFO, "DONE")
            End If
        End If

    End Sub

    Public Sub MakeExecutableFolderNodeForTarget(_project_explorer As ProjectExplorer, _target As String)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is FolderEntry And tp.Tag.Kind = FolderEntry.KindEnum.EXECUTABLE Then
                OutputWindow.CurrentFolder = tp.Tag
                AddOutputMessage(OutputEntry.LevelEnum.INFO, "MAKING [EXE] " & tp.Tag.Name & " (" & _target & ")")
                MakeExecutableFolderForTarget(tp.Tag, _target)
                AddOutputMessage(OutputEntry.LevelEnum.INFO, "DONE")
            End If
        End If

    End Sub

    Public Sub CompileObjectNodeForTarget(_project_explorer As ProjectExplorer, _target As String)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode
        Dim tpp As TreeNode = tp.Parent

        If Not (tp Is Nothing) And Not (tpp Is Nothing) Then
            If TypeOf tp.Tag Is FileEntry And LCase(Path.GetExtension(tp.Tag.filename)) = ".c" Then
                OutputWindow.CurrentFile = tp.Tag
                AddOutputMessage(OutputEntry.LevelEnum.INFO, "COMPILING " & tp.Tag.Name & " (" & _target & ")")
                CompileObjectForTarget(tp.Tag, tpp.Tag, _target)
                AddOutputMessage(OutputEntry.LevelEnum.INFO, "DONE")
            End If
        End If

    End Sub

    Public Sub ExecuteEmulatorFolderNodeForTarget(_project_explorer As ProjectExplorer, _target As String)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is FolderEntry And tp.Tag.Kind = FolderEntry.KindEnum.EXECUTABLE Then
                OutputWindow.CurrentFolder = tp.Tag
                AddOutputMessage(OutputEntry.LevelEnum.INFO, "RUNNING " & tp.Tag.Name & " (" & _target & ")")
                ExecuteEmulatorFolderForTarget(tp.Tag, _target)
                AddOutputMessage(OutputEntry.LevelEnum.INFO, "DONE")
            End If
        End If

    End Sub

    Public Sub ExpandIfFolderNode(_tree_node As TreeNode)
        If Not (_tree_node Is Nothing) Then
            If TypeOf _tree_node.Tag Is FolderEntry Then
                _tree_node.Tag.Opened = True
            End If
        End If
    End Sub

    Public Sub CollapseIfFolderNode(_tree_node As TreeNode)
        If Not (_tree_node Is Nothing) Then
            If TypeOf _tree_node.Tag Is FolderEntry Then
                _tree_node.Tag.Opened = False
            End If
        End If
    End Sub

    Public Sub UpdateProjectExplorerMenuEntriesForSpecificOptions(_project_explorer As ProjectExplorer, _options As Options)

        If Not (_options Is Nothing) Then
            _project_explorer.MakeToolStripMenuItem1.Visible = True
            _project_explorer.MakeToolStripMenuItem1.Enabled = True
            _project_explorer.RunToolStripMenuItem.Visible = True
            _project_explorer.RunToolStripMenuItem.Enabled = True
            _project_explorer.VIC20ToolStripMenuItem.Visible = _options.CC65.Vic20
            _project_explorer.VIC20ToolStripMenuItem.Enabled = _options.CC65.Vic20
            _project_explorer.VIC2024KBToolStripMenuItem.Visible = _options.CC65.Vic2024
            _project_explorer.VIC2024KBToolStripMenuItem.Enabled = _options.CC65.Vic2024
            _project_explorer.C64ToolStripMenuItem.Visible = _options.CC65.C64
            _project_explorer.C64ToolStripMenuItem.Enabled = _options.CC65.C64
            _project_explorer.C128ToolStripMenuItem.Visible = _options.CC65.C128
            _project_explorer.C128ToolStripMenuItem.Enabled = _options.CC65.C128
            _project_explorer.C16ToolStripMenuItem.Visible = _options.CC65.C16
            _project_explorer.C16ToolStripMenuItem.Enabled = _options.CC65.C16
            _project_explorer.PLUS4ToolStripMenuItem.Visible = _options.CC65.Plus4
            _project_explorer.PLUS4ToolStripMenuItem.Enabled = _options.CC65.Plus4
            _project_explorer.ATARI8BitToolStripMenuItem.Visible = _options.CC65.Atari
            _project_explorer.ATARI8BitToolStripMenuItem.Enabled = _options.CC65.Atari
            _project_explorer.ATARI8BitlowResToolStripMenuItem1.Visible = _options.CC65.Atarilo
            _project_explorer.ATARI8BitlowResToolStripMenuItem.Enabled = _options.CC65.Atarilo

            _project_explorer.VIC20ToolStripMenuItem1.Visible = _options.Emulators.ViceEnabled And _options.CC65.Vic20
            _project_explorer.VIC20ToolStripMenuItem1.Enabled = _options.Emulators.ViceEnabled And _options.CC65.Vic20
            _project_explorer.VIC2024KBToolStripMenuItem1.Visible = _options.Emulators.ViceEnabled And _options.CC65.Vic2024
            _project_explorer.VIC2024KBToolStripMenuItem1.Enabled = _options.Emulators.ViceEnabled And _options.CC65.Vic2024
            _project_explorer.C64ToolStripMenuItem1.Visible = _options.Emulators.ViceEnabled And _options.CC65.C64
            _project_explorer.C64ToolStripMenuItem1.Enabled = _options.Emulators.ViceEnabled And _options.CC65.C64
            _project_explorer.C128ToolStripMenuItem1.Visible = _options.Emulators.ViceEnabled And _options.CC65.C128
            _project_explorer.C128ToolStripMenuItem1.Enabled = _options.Emulators.ViceEnabled And _options.CC65.C128
            _project_explorer.C16ToolStripMenuItem1.Visible = _options.Emulators.ViceEnabled And _options.CC65.C16
            _project_explorer.C16ToolStripMenuItem1.Enabled = _options.Emulators.ViceEnabled And _options.CC65.C16
            _project_explorer.PLUS4ToolStripMenuItem1.Visible = (_options.Emulators.ViceEnabled Or _options.Emulators.YapeEnabled) And _options.CC65.Plus4
            _project_explorer.PLUS4ToolStripMenuItem1.Enabled = (_options.Emulators.ViceEnabled Or _options.Emulators.YapeEnabled) And _options.CC65.Plus4
            _project_explorer.ATARI8BitToolStripMenuItem1.Visible = (_options.Emulators.AltirraEnabled Or _options.Emulators.Atari800Enabled) And _options.CC65.Atari
            _project_explorer.ATARI8BitToolStripMenuItem1.Enabled = (_options.Emulators.AltirraEnabled Or _options.Emulators.Atari800Enabled) And _options.CC65.Atari
            _project_explorer.ATARI8BitlowResToolStripMenuItem1.Visible = (_options.Emulators.AltirraEnabled Or _options.Emulators.Atari800Enabled) And _options.CC65.Atarilo
            _project_explorer.ATARI8BitlowResToolStripMenuItem1.Enabled = (_options.Emulators.AltirraEnabled Or _options.Emulators.Atari800Enabled) And _options.CC65.Atarilo

            _project_explorer.VIC20ToolStripMenuItem2.Visible = _options.Emulators.ViceEnabled And _options.CC65.Vic20
            _project_explorer.VIC20ToolStripMenuItem2.Enabled = _options.Emulators.ViceEnabled And _options.CC65.Vic20
            _project_explorer.VIC2024KBToolStripMenuItem2.Visible = _options.Emulators.ViceEnabled And _options.CC65.Vic2024
            _project_explorer.VIC2024KBToolStripMenuItem2.Enabled = _options.Emulators.ViceEnabled And _options.CC65.Vic2024
            _project_explorer.C64ToolStripMenuItem2.Visible = _options.Emulators.ViceEnabled And _options.CC65.C64
            _project_explorer.C64ToolStripMenuItem2.Enabled = _options.Emulators.ViceEnabled And _options.CC65.C64
            _project_explorer.C128ToolStripMenuItem2.Visible = _options.Emulators.ViceEnabled And _options.CC65.C128
            _project_explorer.C128ToolStripMenuItem2.Enabled = _options.Emulators.ViceEnabled And _options.CC65.C128
            _project_explorer.C16ToolStripMenuItem2.Visible = _options.Emulators.ViceEnabled And _options.CC65.C16
            _project_explorer.C16ToolStripMenuItem2.Enabled = _options.Emulators.ViceEnabled And _options.CC65.C16
            _project_explorer.PLUS4ToolStripMenuItem2.Visible = (_options.Emulators.ViceEnabled Or _options.Emulators.YapeEnabled) And _options.CC65.Plus4
            _project_explorer.PLUS4ToolStripMenuItem2.Enabled = (_options.Emulators.ViceEnabled Or _options.Emulators.YapeEnabled) And _options.CC65.Plus4
            _project_explorer.ATARI8BitToolStripMenuItem2.Visible = (_options.Emulators.AltirraEnabled Or _options.Emulators.Atari800Enabled) And _options.CC65.Atari
            _project_explorer.ATARI8BitToolStripMenuItem2.Enabled = (_options.Emulators.AltirraEnabled Or _options.Emulators.Atari800Enabled) And _options.CC65.Atari
            _project_explorer.ATARI8BitlowResToolStripMenuItem2.Visible = (_options.Emulators.AltirraEnabled Or _options.Emulators.Atari800Enabled) And _options.CC65.Atarilo
            _project_explorer.ATARI8BitlowResToolStripMenuItem2.Enabled = (_options.Emulators.AltirraEnabled Or _options.Emulators.Atari800Enabled) And _options.CC65.Atarilo
        Else
            _project_explorer.MakeToolStripMenuItem1.Visible = False
            _project_explorer.RunToolStripMenuItem.Enabled = False
        End If

    End Sub

    Public Sub PrepareTilesetNodeFolder(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is FolderEntry And tp.Tag.Kind = FolderEntry.KindEnum.TILESET Then
                PrepareTilesetFolder(tp.Tag)
            End If
        End If
    End Sub

    Public Sub MoveFileOrFolderUnderFolder(_source_folder As FolderEntry, _file_or_folder As Object, _target_folder As FolderEntry)

        If TypeOf _file_or_folder Is FileEntry Then
            _source_folder.Files.Remove(_file_or_folder.GetHashCode().ToString())
            _target_folder.Files.Add(_file_or_folder, _file_or_folder.GetHashCode().ToString())
            Dim sourceFileName = GetFullPathForElement(_file_or_folder.FileName, _source_folder)
            Dim targetFileName = GetFullPathForElement(_file_or_folder.FileName, _target_folder)
            If File.Exists(sourceFileName) And Not File.Exists(targetFileName) Then
                FileCopy(sourceFileName, targetFileName)
            End If
        Else
            _source_folder.Folders.Remove(_file_or_folder.GetHashCode().ToString())
            _target_folder.Folders.Add(_file_or_folder, _file_or_folder.GetHashCode().ToString())
        End If

    End Sub
    Public Sub CopyElementInClipboard(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is FolderEntry Then
                Clipboard.SetText(tp.Tag.ToXML())
            End If
        End If
    End Sub

    Public Sub CutElementInClipboard(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is FolderEntry Then
                Clipboard.SetText(tp.Tag.ToXML())
                tp.Remove()
            End If
        End If
    End Sub

    Public Sub PasteClipboardAsChildElement(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is Project Then
                Dim sourceObject = Clipboard.GetText()
                If Not (sourceObject Is Nothing) Then
                    Try
                        Dim folderCloned As FolderEntry = FolderEntry.FromXML(sourceObject)
                        tp.Tag.folders.add(folderCloned, folderCloned.GetHashCode())
                        tp.Nodes.Add(PopulateTreeViewRicorsive(folderCloned))
                        GlobalVars.CurrentProject.Resolve()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            ElseIf TypeOf tp.Tag Is FolderEntry Then
                Dim sourceObject = Clipboard.GetText()
                If Not (sourceObject Is Nothing) Then
                    Try
                        Dim folderCloned As FolderEntry = FolderEntry.FromXML(sourceObject)
                        tp.Tag.folders.add(folderCloned, folderCloned.GetHashCode())
                        tp.Nodes.Add(PopulateTreeViewRicorsive(folderCloned))
                        GlobalVars.CurrentProject.Resolve()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub

    Public Sub PasteClipboardAsSameLevelElement(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode
        Dim tpp As TreeNode = tp.Parent

        If Not (tp Is Nothing) And Not (tpp Is Nothing) Then
            If TypeOf tp.Tag Is FolderEntry And TypeOf tpp.Tag Is FolderEntry Then
                Dim sourceObject = Clipboard.GetText()
                If Not (sourceObject Is Nothing) Then
                    Try
                        Dim folderCloned As FolderEntry = FolderEntry.FromXML(sourceObject)
                        tpp.Tag.folders.add(folderCloned, folderCloned.GetHashCode())
                        tpp.Nodes.Add(PopulateTreeViewRicorsive(folderCloned))
                        GlobalVars.CurrentProject.Resolve()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub

    Public Sub refreshImageForNode(_target_tree_node As TreeNode)

        If TypeOf _target_tree_node.Tag Is Project Then
            _target_tree_node.ImageIndex = ProjectToImageIndex(_target_tree_node.Tag)
            _target_tree_node.SelectedImageIndex = ProjectToImageIndex(_target_tree_node.Tag)
        ElseIf TypeOf _target_tree_node.Tag Is FolderEntry Then
            _target_tree_node.ImageIndex = FolderToImageIndex(_target_tree_node.Tag)
            _target_tree_node.SelectedImageIndex = FolderToImageIndex(_target_tree_node.Tag)
        ElseIf TypeOf _target_tree_node.Tag Is FileEntry Then
            _target_tree_node.ImageIndex = FileToImageIndex(_target_tree_node.Tag)
            _target_tree_node.SelectedImageIndex = FileToImageIndex(_target_tree_node.Tag)
        End If

    End Sub

    Public Sub removeOptionsCC65FromNode(_target_tree_node As TreeNode)

        If TypeOf _target_tree_node.Tag Is Project Then
            _target_tree_node.Tag.currentOptions.CC65 = Nothing
            refreshImageForNode(_target_tree_node)
        ElseIf TypeOf _target_tree_node.Tag Is FolderEntry Then
            _target_tree_node.Tag.currentOptions.CC65 = Nothing
            refreshImageForNode(_target_tree_node)
        ElseIf TypeOf _target_tree_node.Tag Is FileEntry Then
            _target_tree_node.Tag.cc65 = Nothing
            refreshImageForNode(_target_tree_node)
        End If

    End Sub

    Public Sub UpdateOptionsCC65FromParent(_options_window As OptionsCC65Window, _targetTreeNode As TreeNode)

        Dim tp2 As TreeNode = _targetTreeNode
        While Not (tp2.Parent Is Nothing)
            tp2 = tp2.Parent
            If Not (tp2.Tag.currentOptions Is Nothing) Then
                UpdateOptionsCC65(_options_window, tp2.Tag.CurrentOptions.CC65)
                Exit While
            End If
        End While

    End Sub

    Public Sub removeOptionsOtherFromNode(_target_tree_node As TreeNode)

        If TypeOf _target_tree_node.Tag Is Project Then
            _target_tree_node.Tag.currentOptions.other = Nothing
            refreshImageForNode(_target_tree_node)
        ElseIf TypeOf _target_tree_node.Tag Is FolderEntry Then
            _target_tree_node.Tag.currentOptions.other = Nothing
            refreshImageForNode(_target_tree_node)
        ElseIf TypeOf _target_tree_node.Tag Is FileEntry Then
            _target_tree_node.Tag.other = Nothing
            refreshImageForNode(_target_tree_node)
        End If

    End Sub

    Public Sub UpdateOptionsOtherFromParent(_options_window As OptionsOtherWindow, _targetTreeNode As TreeNode)

        Dim tp2 As TreeNode = _targetTreeNode
        While Not (tp2.Parent Is Nothing)
            tp2 = tp2.Parent
            If Not (tp2.Tag.currentOptions Is Nothing) Then
                UpdateOptionsOther(_options_window, tp2.Tag.CurrentOptions.Other)
                Exit While
            End If
        End While

    End Sub

    Public Sub removeOptionsMakeFromNode(_target_tree_node As TreeNode)

        If TypeOf _target_tree_node.Tag Is Project Then
            _target_tree_node.Tag.currentOptions.Make = Nothing
            refreshImageForNode(_target_tree_node)
        ElseIf TypeOf _target_tree_node.Tag Is FolderEntry Then
            _target_tree_node.Tag.currentOptions.Make = Nothing
            refreshImageForNode(_target_tree_node)
        ElseIf TypeOf _target_tree_node.Tag Is FileEntry Then
            _target_tree_node.Tag.Make = Nothing
            refreshImageForNode(_target_tree_node)
        End If

    End Sub

    Public Sub UpdateOptionsMakeFromParent(_options_window As OptionsMakeWindow, _targetTreeNode As TreeNode)

        Dim tp2 As TreeNode = _targetTreeNode
        While Not (tp2.Parent Is Nothing)
            tp2 = tp2.Parent
            If Not (tp2.Tag.currentOptions Is Nothing) Then
                UpdateOptionsMake(_options_window, tp2.Tag.CurrentOptions.Make)
                Exit While
            End If
        End While

    End Sub

    Public Sub removeOptionsEmulatorsFromNode(_target_tree_node As TreeNode)

        If TypeOf _target_tree_node.Tag Is Project Then
            _target_tree_node.Tag.currentOptions.Emulators = Nothing
            refreshImageForNode(_target_tree_node)
        ElseIf TypeOf _target_tree_node.Tag Is FolderEntry Then
            _target_tree_node.Tag.currentOptions.Emulators = Nothing
            refreshImageForNode(_target_tree_node)
        ElseIf TypeOf _target_tree_node.Tag Is FileEntry Then
            _target_tree_node.Tag.Emulators = Nothing
            refreshImageForNode(_target_tree_node)
        End If

    End Sub

    Public Sub removeOptionsGeneratedFromNode(_target_tree_node As TreeNode)

        If TypeOf _target_tree_node.Tag Is Project Then
            _target_tree_node.Tag.currentOptions.Generated = Nothing
            refreshImageForNode(_target_tree_node)
        ElseIf TypeOf _target_tree_node.Tag Is FolderEntry Then
            _target_tree_node.Tag.currentOptions.Generated = Nothing
            refreshImageForNode(_target_tree_node)
        ElseIf TypeOf _target_tree_node.Tag Is FileEntry Then
            _target_tree_node.Tag.Generated = Nothing
            refreshImageForNode(_target_tree_node)
        End If

    End Sub

    Public Sub UpdateOptionsEmulatorsFromParent(_options_window As OptionsEmulatorsWindow, _targetTreeNode As TreeNode)

        Dim tp2 As TreeNode = _targetTreeNode
        While Not (tp2.Parent Is Nothing)
            tp2 = tp2.Parent
            If Not (tp2.Tag.currentOptions Is Nothing) Then
                UpdateOptionsEmulators(_options_window, tp2.Tag.CurrentOptions.Emulators)
                Exit While
            End If
        End While

    End Sub

    Public Sub removeOptionsTilesetFromNode(_target_tree_node As TreeNode)

        If TypeOf _target_tree_node.Tag Is Project Then
            _target_tree_node.Tag.currentOptions.Tileset = Nothing
            refreshImageForNode(_target_tree_node)
        ElseIf TypeOf _target_tree_node.Tag Is FolderEntry Then
            _target_tree_node.Tag.currentOptions.Tileset = Nothing
            refreshImageForNode(_target_tree_node)
        End If

    End Sub

    Public Sub UpdateOptionsTilesetFromParent(_options_window As OptionsTilesetWindow, _targetTreeNode As TreeNode)

        Dim tp2 As TreeNode = _targetTreeNode
        While Not (tp2.Parent Is Nothing)
            tp2 = tp2.Parent
            If Not (tp2.Tag.currentOptions Is Nothing) Then
                UpdateOptionsTileset(_options_window, tp2.Tag.CurrentOptions.Tileset)
                Exit While
            End If
        End While

    End Sub

End Module
