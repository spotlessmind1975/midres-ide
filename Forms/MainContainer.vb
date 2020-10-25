Imports System.IO
Imports ScintillaNET

Public Class MainContainer

    Private _optionsWindow As OptionsWindow

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

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

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
            fn = GlobalVars.CurrentFolder.CurrentOptions.IDE.RootPath & "\" & fn
        ElseIf Not (GlobalVars.CurrentProject Is Nothing) Then
            fn = GlobalVars.CurrentProject.CurrentOptions.Make.MakeFilename
            fn = GlobalVars.CurrentProject.CurrentOptions.IDE.RootPath & "\" & fn
        Else
            fn = GlobalVars.CurrentOptions.Make.MakeFilename
            fn = GlobalVars.CurrentOptions.IDE.RootPath & "\" & fn
        End If

        If Not File.Exists(fn) Then
            MsgBox("The file " & fn & " is missing.", vbOKOnly, "CANNOT OPEN MAKEFILE")
            Exit Sub
        End If

        Dim editor As SourceEditor = OpenFileEx(fn, Me)
        editor.FormalLexer = Lexer.Container

    End Sub

    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        GlobalVars.CurrentProject = New Project("(no name)") With {
            .CurrentOptions = GlobalVars.CurrentOptions
        }
        UpdateProjectExplorer()
        ProjectExplorer.Text = "(no name)"
    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        OpenProject()
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        SaveProject(ProjectExplorer.Text)
    End Sub

    Private Sub SaveAsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem1.Click
        SaveProject()
    End Sub

    Public Sub RecentOpenedProjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecentOpenedProjectsToolStripMenuItem.Click

        Dim i As Integer = DirectCast(sender, ToolStripMenuItem).Tag

        If i > 0 Then
            Dim filename As String = GlobalVars.RecentOpenedProjects.Items(i).filename

            LoadProjectEx(filename)

            UpdateProjectExplorer()
            ProjectExplorer.Text = filename
        End If

    End Sub

    Private Sub OptionsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        showOptionsWindow(GlobalVars.CurrentOptions, "Global options")
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ExitProgram()
    End Sub

    Private Sub ProjectExplorerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProjectExplorerToolStripMenuItem.Click
        ProjectExplorer.Show()
        ProjectExplorer.BringToFront()
    End Sub

End Class