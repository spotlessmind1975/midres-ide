Imports System.IO
Imports ScintillaNET

Public Class MainContainer

    Private _optionsWindow As OptionsWindow
    Private _optionsMakeWindow As OptionsMakeWindow
    Private _optionsCC64Window As OptionsCC65Window
    Private _optionsEmulatorsWindow As OptionsEmulatorsWindow
    Private _optionsTilesetWindow As OptionsTilesetWindow
    Private _optionsOtherWindow As OptionsOtherWindow

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

        OpenSourceWindow(Me)

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        OpenFile(Me)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)

        ExitProgram()

    End Sub

    Private Sub MainContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Scintilla.SetDestroyHandleBehavior(True)

        LoadKeywords()

        LoadOptions()

        LoadRecentOpenedProjects()

        LoadRecentOpenedFiles()

        UpdateRecentOpenedFiles(Me)

        UpdateRecentOpenedProjects(Me)

    End Sub

    Public Sub RecentyOpenedFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecentyOpenedFilesToolStripMenuItem.Click

        OpenFileEx(GlobalVars.RecentOpenedFiles.Items(DirectCast(sender, ToolStripMenuItem).Tag).FileName, Me)

    End Sub

    Private Sub VisualizzaGuidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizzaGuidaToolStripMenuItem1.Click, VisualizzaGuidaToolStripMenuItem1.Click

        ShowHelpGuide()

    End Sub

    Private Sub InformazioniSuMIDRESIDEToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles InformazioniSuMIDRESIDEToolStripMenuItem.Click

        SplashScreen.TimerAutoHide.Enabled = False
        SplashScreen.Show()

    End Sub
    Private Sub OutputWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutputWindowToolStripMenuItem.Click
        UpdateOutput(Me)
    End Sub

    Private Sub MainContainer_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        SplashScreen.MdiParent = Me
        SplashScreen.Show()
        SplashScreen.BringToFront()
        UpdateMenuEntries(Me)
    End Sub

    Private Sub FindInFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindInFilesToolStripMenuItem.Click

        FindReplaceDialog.Replace = False
        FindReplaceDialog.EditForm = Nothing
        FindReplaceDialog.currentFolder = Nothing
        If ProjectExplorer.Visible Then
            Dim tp As TreeNode = ProjectExplorer.TreeViewProject.SelectedNode
            If Not (tp Is Nothing) Then
                If TypeOf tp.Tag Is FolderEntry Then
                    FindReplaceDialog.currentFolder = tp.Tag
                End If
            End If
        End If
        FindReplaceDialog.ShowDialog()

    End Sub

    Private Sub EditMakefileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditMakefileToolStripMenuItem.Click

        Dim fn As String = ""

        If ProjectExplorer.Visible Then
            Dim tp As TreeNode = ProjectExplorer.TreeViewProject.SelectedNode
            If Not (tp Is Nothing) Then
                If TypeOf tp.Tag Is FolderEntry Then
                    fn = tp.Tag.CurrentOptions.Make.MakeFile
                    fn = GetFullPathForElement(fn, tp.Tag)
                End If
            Else
                fn = GlobalVars.CurrentProject.CurrentOptions.Make.MakeFilename
                fn = GetFullPathForElement(fn)
            End If
        Else
            fn = GlobalVars.CurrentOptions.Make.MakeFilename
            fn = GetFullPathForElement(fn)
        End If

        If Not File.Exists(fn) Then
            MsgBox("The file " & fn & " is missing.", vbOKOnly, "CANNOT OPEN MAKEFILE")
            Exit Sub
        End If

        Dim editor As SourceEditor = OpenFileEx(fn, Me)

        If ProjectExplorer.Visible Then
            Dim tp As TreeNode = ProjectExplorer.TreeViewProject.SelectedNode
            If Not (tp Is Nothing) Then
                If TypeOf tp.Tag Is FolderEntry Then
                    editor.CurrentFolder = tp.Tag
                End If
            End If
        End If

        editor.FormalLexer = Lexer.Container

    End Sub

    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        Dim filename As String = OpenSaveDialogEx()
        If Not (filename Is Nothing) Then
            My.Computer.FileSystem.WriteAllText(filename, "<Project></Project>", False, System.Text.Encoding.ASCII)
            GlobalVars.CurrentProject = New Project(Path.GetFileNameWithoutExtension(filename)) With {
                .CurrentOptions = GlobalVars.CurrentOptions,
                .RootPath = Path.GetDirectoryName(filename)
            }
            UpdateProjectExplorer()
            ProjectExplorer.Text = Path.GetFileNameWithoutExtension(filename)
        End If
    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        OpenProject()
        UpdateMenuEntries(Me)
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        SaveProject(ProjectExplorer.Text)
        UpdateMenuEntries(Me)
    End Sub

    Private Sub SaveAsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem1.Click
        SaveProject()
        UpdateMenuEntries(Me)
    End Sub

    Public Sub RecentOpenedProjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecentOpenedProjectsToolStripMenuItem.Click

        Dim i As Integer = DirectCast(sender, ToolStripMenuItem).Tag

        If i > 0 Then
            Dim filename As String = GlobalVars.RecentOpenedProjects.Items(i).filename

            LoadProjectEx(filename)

            UpdateProjectExplorer()
            ProjectExplorer.Text = filename
            UpdateMenuEntries(Me)
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ExitProgram()
    End Sub

    Private Sub ProjectExplorerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectExplorerToolStripMenuItem.Click
        ProjectExplorer.Show()
        ProjectExplorer.BringToFront()
    End Sub

    Private Sub MakeOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MakeOptionsToolStripMenuItem.Click
        If Not (_optionsMakeWindow Is Nothing) Then
            If _optionsMakeWindow.IsDisposed Then
                _optionsMakeWindow = Nothing
            End If
        End If
        If _optionsMakeWindow Is Nothing Then
            _optionsMakeWindow = ShowOptionsMakeWindow(Nothing, "Global make options")
        Else
            _optionsMakeWindow.Show()
        End If


    End Sub

    Private Sub CompileOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompileOptionsToolStripMenuItem.Click
        If Not (_optionsCC64Window Is Nothing) Then
            If _optionsCC64Window.IsDisposed Then
                _optionsCC64Window = Nothing
            End If
        End If
        If _optionsCC64Window Is Nothing Then
            _optionsCC64Window = ShowOptionsCC65Window(Nothing, "Global compile options")
        Else
            _optionsCC64Window.Show()
        End If

    End Sub

    Private Sub EmulatorOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmulatorOptionsToolStripMenuItem.Click
        If Not (_optionsEmulatorsWindow Is Nothing) Then
            If _optionsEmulatorsWindow.IsDisposed Then
                _optionsEmulatorsWindow = Nothing
            End If
        End If

        If _optionsEmulatorsWindow Is Nothing Then
            _optionsEmulatorsWindow = ShowOptionsEmulatorsWindow(Nothing, "Global emulators options")
        Else
            _optionsEmulatorsWindow.Show()
        End If

    End Sub

    Private Sub TilesetOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TilesetOptionsToolStripMenuItem.Click
        If Not (_optionsTilesetWindow Is Nothing) Then
            If _optionsTilesetWindow.IsDisposed Then
                _optionsTilesetWindow = Nothing
            End If
        End If

        If _optionsTilesetWindow Is Nothing Then
            _optionsTilesetWindow = ShowOptionsTilesetWindow(Nothing, "Global emulators options")
        Else
            _optionsTilesetWindow.Show()
        End If
    End Sub

    Private Sub MakeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MakeToolStripMenuItem1.Click
        ShowOptionsMakeWindow(GlobalVars.CurrentProject.CurrentOptions.Make, "Project's make options")
    End Sub

    Private Sub CompileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompileToolStripMenuItem.Click
        ShowOptionsCC65Window(GlobalVars.CurrentProject.CurrentOptions.CC65, "Project's compile options")
    End Sub

    Private Sub EmulatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmulatorToolStripMenuItem.Click
        ShowOptionsEmulatorsWindow(GlobalVars.CurrentProject.CurrentOptions.Emulators, "Project's emulators options")
    End Sub

    Private Sub TilesetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TilesetToolStripMenuItem.Click
        ShowOptionsTilesetWindow(GlobalVars.CurrentProject.CurrentOptions.Tileset, "Project's tileset options")
    End Sub

    Private Sub FileOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileOptionsToolStripMenuItem.Click
        If Not (_optionsOtherWindow Is Nothing) Then
            If _optionsOtherWindow.IsDisposed Then
                _optionsOtherWindow = Nothing
            End If
        End If

        If _optionsOtherWindow Is Nothing Then
            _optionsOtherWindow = ShowOptionsOtherWindow(Nothing, "Global file options")
        Else
            _optionsOtherWindow.Show()
        End If

    End Sub
End Class