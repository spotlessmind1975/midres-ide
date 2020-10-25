Imports System.IO
Imports Microsoft.Win32

Module ProjectExplorerHelper

    Public Function PopulateTreeViewWithFile(_file_entry As FileEntry) As TreeNode

        Dim s As TreeNode = New TreeNode(_file_entry.Name, 3, 3) With {
            .Tag = _file_entry,
            .ContextMenuStrip = ProjectExplorer.ContextMenuStripFile,
            .ToolTipText = _file_entry.Filename
        }
        Return s
    End Function

    Public Function FolderKindToImageIndex(_kind As FolderEntry.KindEnum)
        Select Case _kind
            Case FolderEntry.KindEnum.FOLDER
                Return 2
            Case FolderEntry.KindEnum.LIBRARY
                Return 4
            Case FolderEntry.KindEnum.EXECUTABLE
                Return 5
        End Select

        Return 2
    End Function

    Public Function PopulateTreeViewRicorsive(_folder_entry As FolderEntry) As TreeNode

        Dim t As TreeNode = New TreeNode(_folder_entry.Name, 2, 2) With {
            .Tag = _folder_entry,
            .ToolTipText = _folder_entry.Path,
            .ImageIndex = FolderKindToImageIndex(_folder_entry.Kind),
            .SelectedImageIndex = FolderKindToImageIndex(_folder_entry.Kind)
        }

        Select Case _folder_entry.Kind
            Case FolderEntry.KindEnum.FOLDER
                t.ContextMenuStrip = ProjectExplorer.ContextMenuStripFolder
            Case FolderEntry.KindEnum.LIBRARY
                If Not (GlobalVars.CurrentFolder Is Nothing) Then
                    If GlobalVars.CurrentFolder.Equals(_folder_entry) Then
                        t.ImageIndex = 6
                    End If
                End If
                t.ContextMenuStrip = ProjectExplorer.ContextMenuStripLibrary
            Case FolderEntry.KindEnum.EXECUTABLE
                If Not (GlobalVars.CurrentFolder Is Nothing) Then
                    If GlobalVars.CurrentFolder.Equals(_folder_entry) Then
                        t.ImageIndex = 7
                    End If
                End If
                t.ContextMenuStrip = ProjectExplorer.ContextMenuStripExecutable
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
                .ToolTipText = GlobalVars.CurrentProject.CurrentOptions.IDE.RootPath
            }

            '' t.ContextMenu = ContextMenuStripProjectExplorer.ContextMenu
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
                    startingPath = GlobalVars.CurrentProject.CurrentOptions.IDE.RootPath & "\" & tp.Tag.Path
                End If

                Dim folderPath = OpenFolderDialogEx(startingPath)

                If Not (folderPath Is Nothing) Then
                    Dim rootFolder = tp.Tag

                    Dim f As FolderEntry = New FolderEntry(folderPath, folderPath.Replace(GlobalVars.CurrentProject.CurrentOptions.IDE.RootPath & "\", ""))

                    rootFolder.Folders.Add(f)

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
            GlobalVars.CurrentProject.CurrentOptions.IDE.RootPath = path
            projectNode.ToolTipText = path
            GlobalVars.CurrentProject.NormalizePaths()
        End If

    End Sub

    Public Sub AddExistingFile(_project_explorer As ProjectExplorer)

        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is FolderEntry Then
                Dim filename As String = OpenDialogEx()
                If Not (filename Is Nothing) Then
                    Dim f As FileEntry = New FileEntry(filename, Path.GetFileName(filename))
                    tp.Tag.Files.Add(f)
                    tp.Tag.NormalizePaths()
                    tp.Nodes.Add(PopulateTreeViewWithFile(f))
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
                    Dim f As FileEntry = New FileEntry(filename, Path.GetFileName(filename))
                    tp.Tag.Files.Add(f)
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
                Case Else
                    tp.ContextMenuStrip = _project_explorer.ContextMenuStripFolder
            End Select
            tp.ImageIndex = FolderKindToImageIndex(_kind)
            tp.SelectedImageIndex = FolderKindToImageIndex(_kind)
        End If

    End Sub

    Public Sub OpenNodeFile(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode
        If Not (tp Is Nothing) Then
            Dim tpp As TreeNode = tp.Parent
            If Not (tpp Is Nothing) Then
                If TypeOf tp.Tag Is FileEntry Then
                    Dim filename As String = GlobalVars.CurrentProject.CurrentOptions.IDE.RootPath & "\" & tpp.Tag.path & "\" & tp.Tag.filename
                    Dim se As SourceEditor = OpenFileEx(filename, MainContainer)
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

    Public Sub ShowOptionsWindowLibrary(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is FolderEntry And tp.Tag.Kind = FolderEntry.KindEnum.LIBRARY Then
                If tp.Tag.CurrentOptions Is Nothing Then
                    tp.Tag.CurrentOptions = ChooseBestOptions().DeepClone()
                End If
                showOptionsWindow(tp.Tag.CurrentOptions, "Library " & tp.Tag.name & " options")
            End If
        End If
    End Sub

    Public Sub ShowOptionsWindowExecutable(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is FolderEntry And tp.Tag.Kind = FolderEntry.KindEnum.EXECUTABLE Then
                If tp.Tag.CurrentOptions Is Nothing Then
                    tp.Tag.CurrentOptions = ChooseBestOptions().DeepClone()
                End If
                showOptionsWindow(tp.Tag.CurrentOptions, "Executable " & tp.Tag.name & " options")
            End If
        End If
    End Sub

    Public Sub MakeLibraryFolderNodeForTarget(_project_explorer As ProjectExplorer, _target As String)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is FolderEntry And tp.Tag.Kind = FolderEntry.KindEnum.LIBRARY Then
                ErrorOutputWindow.CurrentFolder = tp.Tag
                MakeLibraryFolderForTarget(tp.Tag, _target)
            End If
        End If

    End Sub

    Public Sub MakeExecutableFolderNodeForTarget(_project_explorer As ProjectExplorer, _target As String)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is FolderEntry And tp.Tag.Kind = FolderEntry.KindEnum.EXECUTABLE Then
                ErrorOutputWindow.CurrentFolder = tp.Tag
                MakeExecutableFolderForTarget(tp.Tag, _target)
            End If
        End If

    End Sub

    Public Sub ExecuteEmulatorFolderNodeForTarget(_project_explorer As ProjectExplorer, _target As String)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is FolderEntry And tp.Tag.Kind = FolderEntry.KindEnum.EXECUTABLE Then
                ErrorOutputWindow.CurrentFolder = tp.Tag
                ExecuteEmulatorFolderForTarget(tp.Tag, _target)
            End If
        End If

    End Sub

    Public Sub SetFolderAsActive(_project_explorer As ProjectExplorer)
        Dim tp As TreeNode = _project_explorer.TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            If TypeOf tp.Tag Is FolderEntry And (tp.Tag.Kind = FolderEntry.KindEnum.EXECUTABLE Or tp.Tag.kind = FolderEntry.KindEnum.LIBRARY) Then
                If Not (GlobalVars.CurrentFolderNode Is Nothing) Then
                    Select Case GlobalVars.CurrentFolderNode.Tag.Kind
                        Case FolderEntry.KindEnum.LIBRARY
                            GlobalVars.CurrentFolderNode.SelectedImageIndex = 4
                            GlobalVars.CurrentFolderNode.ImageIndex = 4
                        Case FolderEntry.KindEnum.EXECUTABLE
                            GlobalVars.CurrentFolderNode.ImageIndex = 5
                            GlobalVars.CurrentFolderNode.SelectedImageIndex = 5
                    End Select
                End If
                GlobalVars.CurrentFolder = tp.Tag
                GlobalVars.CurrentFolderNode = tp
                Select Case tp.Tag.Kind
                    Case FolderEntry.KindEnum.LIBRARY
                        tp.ImageIndex = 6
                        tp.SelectedImageIndex = 6
                    Case FolderEntry.KindEnum.EXECUTABLE
                        tp.ImageIndex = 7
                        tp.SelectedImageIndex = 7
                End Select
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
End Module
