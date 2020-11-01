Imports System.IO
Imports Microsoft.Win32

Public Class ProjectExplorer

    Private _optionsWindow As OptionsWindow

    Private Sub StartRenaming()
        Dim tp As TreeNode = TreeViewProject.SelectedNode

        If Not (tp Is Nothing) Then
            TreeViewProject.LabelEdit = True
            If Not tp.IsEditing Then
                tp.BeginEdit()
            End If
        End If
    End Sub

    Private Sub ResizeMe()
        TreeViewProject.Left = 0
        TreeViewProject.Width = Me.Width - 16
        TreeViewProject.Top = 0
        TreeViewProject.Height = Me.Height - 40
    End Sub

    Private Sub ProjectExplorer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeMe()
        UpdateProjectExplorer()
    End Sub

    Private Sub ProjectExplorer_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ResizeMe()
    End Sub

    Private Sub ContextMenuStripProject_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripProject.Opening

    End Sub

    Private Sub RenameToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem1.Click
        StartRenaming()
    End Sub

    Private Sub TreeViewProject_AfterLabelEdit(sender As Object, e As NodeLabelEditEventArgs) Handles TreeViewProject.AfterLabelEdit

        e.Node.EndEdit(False)

        e.Node.Tag.Name = e.Label

    End Sub

    Private Sub AddFolderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddFolderToolStripMenuItem1.Click
        AddNewFolder(Me)
    End Sub

    Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem.Click
        StartRenaming()
    End Sub

    Private Sub AddFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFolderToolStripMenuItem.Click
        AddNewFolder(Me)
    End Sub

    Private Sub AddFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFileToolStripMenuItem.Click
        AddExistingFile(Me)
    End Sub

    Private Sub RenameToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem2.Click
        StartRenaming()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenNodeFile(Me)
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        RemoveFile(Me)
    End Sub

    Private Sub RemoveFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveFolderToolStripMenuItem.Click
        RemoveFolder(Me)
    End Sub

    Private Sub TreeViewProject_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeViewProject.NodeMouseClick
        If (e.Button = MouseButtons.Right) Then
            Dim tp As TreeNode = e.Node
            TreeViewProject.SelectedNode = tp
        End If
    End Sub

    Private Sub SetRootpathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetRootpathToolStripMenuItem.Click
        SetProjectRootPath(Me)
    End Sub

    Private Sub TreeViewProject_DoubleClick(sender As Object, e As EventArgs) Handles TreeViewProject.DoubleClick
        OpenNodeFile(Me)
    End Sub

    Private Sub TreeViewProject_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewProject.AfterSelect

    End Sub

    Private Sub PromoteAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromoteAsToolStripMenuItem.Click

    End Sub

    Private Sub FolderToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ConsiderFolderAs(Me, FolderEntry.KindEnum.FOLDER)
    End Sub

    Private Sub LibraryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibraryToolStripMenuItem.Click
        ConsiderFolderAs(Me, FolderEntry.KindEnum.LIBRARY)
    End Sub

    Private Sub ExecutableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExecutableToolStripMenuItem.Click
        ConsiderFolderAs(Me, FolderEntry.KindEnum.EXECUTABLE)
    End Sub

    Private Sub RenameToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem3.Click
        StartRenaming()
    End Sub

    Private Sub AddFolderToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AddFolderToolStripMenuItem2.Click
        AddNewFolder(Me)
    End Sub

    Private Sub AddfileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddfileToolStripMenuItem1.Click
        AddExistingFile(Me)
    End Sub

    Private Sub RemoveFolderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RemoveFolderToolStripMenuItem1.Click
        RemoveFolder(Me)
    End Sub

    Private Sub FolderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FolderToolStripMenuItem1.Click
        ConsiderFolderAs(Me, FolderEntry.KindEnum.FOLDER)
    End Sub

    Private Sub ExecutableToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExecutableToolStripMenuItem1.Click
        ConsiderFolderAs(Me, FolderEntry.KindEnum.EXECUTABLE)
    End Sub

    Private Sub RenameToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem4.Click
        StartRenaming()
    End Sub

    Private Sub AddFolderToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AddFolderToolStripMenuItem3.Click
        AddNewFolder(Me)
    End Sub

    Private Sub AddfileToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AddfileToolStripMenuItem2.Click
        AddExistingFile(Me)
    End Sub

    Private Sub RemoveFolderToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RemoveFolderToolStripMenuItem2.Click
        RemoveFolder(Me)
    End Sub

    Private Sub FolderToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FolderToolStripMenuItem2.Click
        ConsiderFolderAs(Me, FolderEntry.KindEnum.FOLDER)
    End Sub

    Private Sub LibraryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LibraryToolStripMenuItem1.Click
        ConsiderFolderAs(Me, FolderEntry.KindEnum.LIBRARY)
    End Sub


    Private Sub ExeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExeToolStripMenuItem.Click
        ShowOptionsWindowExecutable(Me)
    End Sub

    Private Sub ContextMenuStripLibrary_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripLibrary.Opening

    End Sub

    Private Sub ContextMenuStripExecutable_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripExecutable.Opening

    End Sub

    Private Sub C16ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles C16ToolStripMenuItem.Click
        MakeLibraryFolderNodeForTarget(Me, "c16")
    End Sub

    Private Sub VIC20ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIC20ToolStripMenuItem.Click
        MakeLibraryFolderNodeForTarget(Me, "vic20")
    End Sub

    Private Sub VIC2024KBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIC2024KBToolStripMenuItem.Click
        MakeLibraryFolderNodeForTarget(Me, "vic2024")
    End Sub

    Private Sub C64ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles C64ToolStripMenuItem.Click
        MakeLibraryFolderNodeForTarget(Me, "c64")
    End Sub

    Private Sub C128ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles C128ToolStripMenuItem.Click
        MakeLibraryFolderNodeForTarget(Me, "c128")
    End Sub

    Private Sub PLUS4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PLUS4ToolStripMenuItem.Click
        MakeLibraryFolderNodeForTarget(Me, "plus4")
    End Sub

    Private Sub ATARI8BitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ATARI8BitToolStripMenuItem.Click
        MakeLibraryFolderNodeForTarget(Me, "atari")
    End Sub

    Private Sub ATARI8BitlowResToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ATARI8BitlowResToolStripMenuItem.Click
        MakeLibraryFolderNodeForTarget(Me, "atarilo")
    End Sub

    Private Sub C16ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles C16ToolStripMenuItem1.Click
        MakeExecutableFolderNodeForTarget(Me, "c16")
    End Sub

    Private Sub VIC20ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VIC20ToolStripMenuItem1.Click
        MakeExecutableFolderNodeForTarget(Me, "vic20")
    End Sub

    Private Sub VIC2024KBToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VIC2024KBToolStripMenuItem1.Click
        MakeExecutableFolderNodeForTarget(Me, "vic2024")
    End Sub

    Private Sub C64ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles C64ToolStripMenuItem1.Click
        MakeExecutableFolderNodeForTarget(Me, "c64")
    End Sub

    Private Sub C128ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles C128ToolStripMenuItem1.Click
        MakeExecutableFolderNodeForTarget(Me, "c128")
    End Sub

    Private Sub PLUS4ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PLUS4ToolStripMenuItem1.Click
        MakeExecutableFolderNodeForTarget(Me, "plus4")
    End Sub

    Private Sub ATARI8BitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ATARI8BitToolStripMenuItem1.Click
        MakeExecutableFolderNodeForTarget(Me, "atari")
    End Sub

    Private Sub ATARI8BitlowResToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ATARI8BitlowResToolStripMenuItem1.Click
        MakeExecutableFolderNodeForTarget(Me, "atarilo")
    End Sub

    Private Sub C16ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles C16ToolStripMenuItem2.Click
        ExecuteEmulatorFolderNodeForTarget(Me, "c16")
    End Sub

    Private Sub SetAsactiveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SetAsactiveToolStripMenuItem1.Click
        SetFolderAsActive(Me)
    End Sub

    Private Sub SetAsactiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetAsactiveToolStripMenuItem.Click
        SetFolderAsActive(Me)
    End Sub

    Private Sub NewFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewFileToolStripMenuItem.Click
        AddNewFile(Me)
    End Sub

    Private Sub NewFileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewFileToolStripMenuItem1.Click
        AddNewFile(Me)
    End Sub

    Private Sub NewFileToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NewFileToolStripMenuItem2.Click
        AddNewFile(Me)
    End Sub

    Private Sub TreeViewProject_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles TreeViewProject.BeforeExpand
        ExpandIfFolderNode(e.Node)
    End Sub

    Private Sub TreeViewProject_BeforeCollapse(sender As Object, e As TreeViewCancelEventArgs) Handles TreeViewProject.BeforeCollapse
        CollapseIfFolderNode(e.Node)
    End Sub

    Private Sub VIC20ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles VIC20ToolStripMenuItem2.Click
        ExecuteEmulatorFolderNodeForTarget(Me, "vic20")
    End Sub

    Private Sub VIC2024KBToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles VIC2024KBToolStripMenuItem2.Click
        ExecuteEmulatorFolderNodeForTarget(Me, "vic2024")
    End Sub

    Private Sub C64ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles C64ToolStripMenuItem2.Click
        ExecuteEmulatorFolderNodeForTarget(Me, "c64")
    End Sub

    Private Sub C128ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles C128ToolStripMenuItem2.Click
        ExecuteEmulatorFolderNodeForTarget(Me, "c128")
    End Sub

    Private Sub PLUS4ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PLUS4ToolStripMenuItem2.Click
        ExecuteEmulatorFolderNodeForTarget(Me, "plus4")
    End Sub

    Private Sub ATARI8BitToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ATARI8BitToolStripMenuItem2.Click
        ExecuteEmulatorFolderNodeForTarget(Me, "atari")
    End Sub

    Private Sub ATARI8BitlowResToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ATARI8BitlowResToolStripMenuItem2.Click
        ExecuteEmulatorFolderNodeForTarget(Me, "atarilo")
    End Sub

    Private Sub TilesetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TilesetToolStripMenuItem.Click
        ConsiderFolderAs(Me, FolderEntry.KindEnum.TILESET)
    End Sub

    Private Sub TilesetToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TilesetToolStripMenuItem1.Click
        ConsiderFolderAs(Me, FolderEntry.KindEnum.TILESET)
    End Sub

    Private Sub OptionsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem2.Click
        ShowOptionsWindowTileset(Me)
    End Sub

    Private Sub AddFileToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AddFileToolStripMenuItem3.Click
        AddExistingFile(Me)
    End Sub

    Private Sub RenameToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem5.Click
        StartRenaming()
    End Sub

    Private Sub RemoveFolderToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles RemoveFolderToolStripMenuItem3.Click
        RemoveFolder(Me)
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        ConsiderFolderAs(Me, FolderEntry.KindEnum.FOLDER)
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        ConsiderFolderAs(Me, FolderEntry.KindEnum.LIBRARY)
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        ConsiderFolderAs(Me, FolderEntry.KindEnum.EXECUTABLE)
    End Sub

    Private Sub TilesetToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles TilesetToolStripMenuItem2.Click
        ConsiderFolderAs(Me, FolderEntry.KindEnum.TILESET)
    End Sub

    Private Sub PrepareToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrepareToolStripMenuItem.Click
        PrepareTilesetNodeFolder(Me)
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ConsiderFileAs(Me, FileEntry.KindEnum.NORMAL)
    End Sub

    Private Sub GeneratedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneratedToolStripMenuItem.Click
        ConsiderFileAs(Me, FileEntry.KindEnum.GENERATED)
    End Sub

    Private Sub NormalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem1.Click
        ConsiderFileAs(Me, FileEntry.KindEnum.NORMAL)
    End Sub

    Private Sub OptionsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem1.Click
        ShowOptionsWindowGenerated(Me)
    End Sub

    Private Sub RenameToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles RenameToolStripMenuItem6.Click
        StartRenaming()
    End Sub

    Private Sub RemoveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem1.Click
        RemoveFile(Me)
    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        OpenNodeFile(Me)
    End Sub

    Private Sub TreeViewProject_ItemDrag(sender As Object, e As ItemDragEventArgs) Handles TreeViewProject.ItemDrag
        DoDragDrop(e.Item, DragDropEffects.Move)
    End Sub

    Private Sub TreeViewProject_DragEnter(sender As Object, e As DragEventArgs) Handles TreeViewProject.DragEnter
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub TreeViewProject_DragOver(sender As Object, e As DragEventArgs) Handles TreeViewProject.DragOver

        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) = False Then Exit Sub

        Dim selectedTreeview As TreeView = CType(sender, TreeView)

        Dim pt As Point =
            CType(sender, TreeView).PointToClient(New Point(e.X, e.Y))
        Dim targetNode As TreeNode = selectedTreeview.GetNodeAt(pt)

        If Not (selectedTreeview.SelectedNode Is targetNode) Then
            selectedTreeview.SelectedNode = targetNode

            Dim dropNode As TreeNode =
                CType(e.Data.GetData("System.Windows.Forms.TreeNode"),
                TreeNode)

            Do Until targetNode Is Nothing
                If targetNode Is dropNode Then
                    e.Effect = DragDropEffects.None
                    Exit Sub
                End If
                targetNode = targetNode.Parent
            Loop
        End If

        e.Effect = DragDropEffects.Move

    End Sub

    Private Sub TreeViewProject_DragDrop(sender As Object, e As DragEventArgs) Handles TreeViewProject.DragDrop

        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", True) = False Then Exit Sub

        Dim selectedTreeview As TreeView = CType(sender, TreeView)

        Dim dropNode As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)

        Dim targetNode As TreeNode = selectedTreeview.SelectedNode

        If targetNode Is Nothing Then Exit Sub

        If (TypeOf targetNode.Tag Is FileEntry) And (TypeOf dropNode.Tag Is FileEntry) Then

            If (targetNode.Parent.Tag.Equals(dropNode.Parent.Tag)) Then

                targetNode.Parent.Tag.Files.Remove(dropNode.Tag.GetHashCode().ToString())
                targetNode.Parent.Tag.InsertFileBefore(targetNode.Tag, dropNode.Tag)

                dropNode.Remove()

                Dim i As Integer

                For i = 0 To targetNode.Parent.Nodes.Count
                    If targetNode.Parent.Nodes(i).Tag.Equals(targetNode.Tag) Then
                        targetNode.Parent.Nodes.Insert(i, dropNode)
                        Exit For
                    End If
                Next

                dropNode.EnsureVisible()

                selectedTreeview.SelectedNode = dropNode

            End If

        ElseIf (TypeOf targetNode.Tag Is FolderEntry) Then

            MoveFileOrFolderUnderFolder(dropNode.Parent.Tag, dropNode.Tag, targetNode.Tag)

            dropNode.Remove()

            targetNode.Nodes.Add(dropNode)

            dropNode.EnsureVisible()
            selectedTreeview.SelectedNode = dropNode

        Else
            Exit Sub
        End If


    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        CopyElementInClipboard(Me)
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        CopyElementInClipboard(Me)
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        CopyElementInClipboard(Me)
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        CopyElementInClipboard(Me)
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        CutElementInClipboard(Me)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        CutElementInClipboard(Me)
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem18.Click
        CutElementInClipboard(Me)
    End Sub

    Private Sub ToolStripMenuItem19_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem19.Click
        CutElementInClipboard(Me)
    End Sub

    Private Sub PasteasChildToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteasChildToolStripMenuItem.Click
        PasteClipboardAsChildElement(Me)
    End Sub

    Private Sub ToolStripMenuItem20_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem20.Click
        PasteClipboardAsChildElement(Me)
    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem21.Click
        PasteClipboardAsChildElement(Me)
    End Sub

    Private Sub PastesameLevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PastesameLevelToolStripMenuItem.Click
        PasteClipboardAsSameLevelElement(Me)
    End Sub

    Private Sub ToolStripMenuItem22_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem22.Click
        PasteClipboardAsSameLevelElement(Me)
    End Sub

    Private Sub ToolStripMenuItem23_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem23.Click
        PasteClipboardAsSameLevelElement(Me)
    End Sub

    Private Sub ToolStripMenuItem24_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem24.Click
        PasteClipboardAsSameLevelElement(Me)
    End Sub

    Private Sub MakeToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MakeToolStripMenuItem2.Click
        ShowOptionsWindowMake(Me)
    End Sub

    Private Sub CompileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompileToolStripMenuItem.Click
        ShowOptionsWindowCC65(Me)
    End Sub

    Private Sub EmulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmulatorToolStripMenuItem.Click
        ShowOptionsWindowEmulators(Me)

    End Sub

    Private Sub TilesetToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles TilesetToolStripMenuItem3.Click
        ShowOptionsWindowTileset(Me)
    End Sub

    Private Sub ToolStripMenuItem25_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem25.Click
        StartRenaming()
    End Sub

    Private Sub ToolStripMenuItem31_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem31.Click
        OpenNodeFile(Me)
    End Sub

    Private Sub ToolStripMenuItem32_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem32.Click
        RemoveFile(Me)
    End Sub

    Private Sub OptionsToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem3.Click
        ShowOptionsWindowCC65(Me)
    End Sub

    Private Sub ToolStripMenuItem35_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem35.Click
        CompileObjectNodeForTarget(Me, "c16")
    End Sub

    Private Sub ToolStripMenuItem36_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem36.Click
        CompileObjectNodeForTarget(Me, "vic20")
    End Sub

    Private Sub ToolStripMenuItem37_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem37.Click
        CompileObjectNodeForTarget(Me, "vic2024")
    End Sub

    Private Sub ToolStripMenuItem38_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem38.Click
        CompileObjectNodeForTarget(Me, "c64")
    End Sub

    Private Sub ToolStripMenuItem39_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem39.Click
        CompileObjectNodeForTarget(Me, "c128")
    End Sub

    Private Sub ToolStripMenuItem40_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem40.Click
        CompileObjectNodeForTarget(Me, "plus4")
    End Sub

    Private Sub ToolStripMenuItem41_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem41.Click
        CompileObjectNodeForTarget(Me, "atari")
    End Sub

    Private Sub ToolStripMenuItem42_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem42.Click
        CompileObjectNodeForTarget(Me, "atarilo")
    End Sub

    Private Sub MakeToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles MakeToolStripMenuItem3.Click
        ShowOptionsWindowMake(Me)
    End Sub

    Private Sub CompilerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompilerToolStripMenuItem.Click
        ShowOptionsWindowCC65(Me)
    End Sub
End Class