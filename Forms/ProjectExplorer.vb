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

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        _optionsWindow = showOptionsWindow(GlobalVars.CurrentProject.CurrentOptions, "Project options")
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

    Private Sub LibToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibToolStripMenuItem.Click
        ShowOptionsWindowLibrary(Me)
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
End Class