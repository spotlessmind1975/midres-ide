Imports System.IO
Imports ScintillaNET

Public Class MainContainer

    Private _optionsWindow As OptionsWindow
    Private _optionsCC64Window As OptionsCC65Window

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
        UpdateErrorOutput(Me)
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
        FindReplaceDialog.ShowDialog()

    End Sub

    Private Sub EditMakefileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditMakefileToolStripMenuItem.Click

        Dim fn As String = ""

        If Not (GlobalVars.CurrentFolder Is Nothing) Then
            fn = GlobalVars.CurrentFolder.CurrentOptions.Make.MakeFilename
        ElseIf Not (GlobalVars.CurrentProject Is Nothing) Then
            fn = GlobalVars.CurrentProject.CurrentOptions.Make.MakeFilename
        Else
            fn = GlobalVars.CurrentOptions.Make.MakeFilename
        End If

        fn = GetFullPathForElement(fn, GlobalVars.CurrentFolder)

        If Not File.Exists(fn) Then
            MsgBox("The file " & fn & " is missing.", vbOKOnly, "CANNOT OPEN MAKEFILE")
            Exit Sub
        End If

        Dim editor As SourceEditor = OpenFileEx(fn, Me)
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
        ShowOptionsMakeWindow(GlobalVars.CurrentOptions.Make, "Global make options")
    End Sub

    Private Sub CompileOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompileOptionsToolStripMenuItem.Click
        If _optionsCC64Window Is Nothing Then
            _optionsCC64Window = ShowOptionsCC65Window(Nothing, "Global compile options")
        ElseIf _optionsCC64Window.IsDisposed Then
            _optionsCC64Window = ShowOptionsCC65Window(Nothing, "Global compile options")
        Else
            _optionsCC64Window.Show()
        End If

    End Sub

    Private Sub EmulatorOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmulatorOptionsToolStripMenuItem.Click
        ShowOptionsEmulatorsWindow(GlobalVars.CurrentOptions.Emulators, "Global emulators options")
    End Sub

    Private Sub TilesetOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TilesetOptionsToolStripMenuItem.Click
        ShowOptionsTilesetWindow(GlobalVars.CurrentOptions.Tileset, "Global tileset options")
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
End Class