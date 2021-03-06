﻿Public Class OutputWindow
    Private _currentFolder As FolderEntry
    Private _currentFile As FileEntry
    Private _outputFiltered As Collection

    Public Property CurrentFolder As FolderEntry
        Get
            Return _currentFolder
        End Get
        Set(value As FolderEntry)
            _currentFolder = value
        End Set
    End Property

    Public Property CurrentFile As FileEntry
        Get
            Return _currentFile
        End Get
        Set(value As FileEntry)
            _currentFile = value
        End Set
    End Property

    Public Property OutputFiltered As Collection
        Get
            Return _outputFiltered
        End Get
        Set(value As Collection)
            _outputFiltered = value
        End Set
    End Property

    Private Sub ResizeMe()
        ComboBoxOutputLevel.Width = Me.Width - 16 - ComboBoxOutputLevel.Left
        ListBoxOutput.Left = 0
        ListBoxOutput.Width = Me.Width - 16
        ListBoxOutput.Top = ComboBoxOutputLevel.Top + ComboBoxOutputLevel.Height + 8
        ListBoxOutput.Height = Me.Height - 40 - ListBoxOutput.Top
        UpdateMenu()
    End Sub

    Private Sub ErrorOutputWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxOutputLevel.SelectedIndex = OutputEntry.LevelEnum.INFO
        ResizeMe()
    End Sub

    Private Sub ListBoxOutput_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxOutput.DoubleClick

        UpdateMenu()

        If ListBoxOutput.SelectedIndex > -1 Then
            Dim eoe As OutputEntry = _outputFiltered.Item(ListBoxOutput.SelectedIndex + 1)

            If (eoe.Filename <> "" And eoe.Line > 0) Then

                If (GlobalVars.OpenedSourceEditors.Contains(eoe.Filename)) Then
                    FocusOnFilenameAndMarker(eoe.Filename, eoe.Line, Me.MdiParent, eoe.Kind)
                Else
                    FocusOnFilenameAndLine(eoe.Filename, eoe.Line, Me.MdiParent, eoe.Kind)
                End If
            End If

        End If


    End Sub

    Private Sub ErrorOutputWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ResizeMe()
    End Sub

    Private Sub UpdateMenu()
        Dim i As Integer = ListBoxOutput.SelectedIndex

        If i > -1 Then

            Dim eoe As OutputEntry = GlobalVars.ErrorOutput.Items(i + 1)

            If eoe.Kind = 1 Then
                IgnoreMessagenextTimeToolStripMenuItem.Enabled = True
                If CurrentFile Is Nothing Then
                    OnThisFileToolStripMenuItem.Enabled = False
                Else
                    OnThisFileToolStripMenuItem.Enabled = True
                End If
                If CurrentFolder Is Nothing Then
                    OnThisfolderToolStripMenuItem.Enabled = False
                Else
                    OnThisfolderToolStripMenuItem.Enabled = True
                End If
                If GlobalVars.CurrentProject Is Nothing Then
                    OnThisProjectToolStripMenuItem.Enabled = False
                Else
                    OnThisProjectToolStripMenuItem.Enabled = True
                End If
            Else
                IgnoreMessagenextTimeToolStripMenuItem.Enabled = False
            End If
        End If
    End Sub
    Private Sub ListBoxOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxOutput.SelectedIndexChanged

        UpdateMenu()

    End Sub

    Private Sub OnThisfolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnThisfolderToolStripMenuItem.Click

        If Not (CurrentFolder Is Nothing) Then
            IgnoreMessageNextTime(Me, CurrentFolder.CurrentOptions.CC65)
        End If

        UpdateMenu()

    End Sub

    Private Sub OnThisProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnThisProjectToolStripMenuItem.Click

        If Not (GlobalVars.CurrentProject Is Nothing) Then
            IgnoreMessageNextTime(Me, GlobalVars.CurrentProject.CurrentOptions.CC65)
        End If

        UpdateMenu()

    End Sub

    Private Sub GloballyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GloballyToolStripMenuItem.Click

        If Not (GlobalVars.CurrentProject Is Nothing) Then
            IgnoreMessageNextTime(Me, GlobalVars.CurrentOptions.CC65)
        End If

        UpdateMenu()

    End Sub

    Private Sub ContextMenuStripWarnings_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripWarnings.Opening

    End Sub

    Private Sub OnThisFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnThisFileToolStripMenuItem.Click
        If Not (CurrentFile Is Nothing) Then
            IgnoreMessageNextTime(Me, CurrentFile.CC65)
        End If

        UpdateMenu()

    End Sub

    Private Sub ComboBoxOutputLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxOutputLevel.SelectedIndexChanged
        UpdateOutput(MainContainer)
    End Sub

    Private Sub ListBoxOutput_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ListBoxOutput.DrawItem
        e.DrawBackground()
        If e.Index >= 0 Then
            Dim level As OutputEntry.LevelEnum = _outputFiltered.Item(e.Index + 1).level
            Select Case level
                Case OutputEntry.LevelEnum.CRIT, OutputEntry.LevelEnum.ERR
                    e.Graphics.DrawString(ListBoxOutput.Items(e.Index), e.Font, Brushes.Red, e.Bounds.X, e.Bounds.Y)
                Case OutputEntry.LevelEnum.WARN
                    e.Graphics.DrawString(ListBoxOutput.Items(e.Index), e.Font, Brushes.Orange, e.Bounds.X, e.Bounds.Y)
                Case OutputEntry.LevelEnum.DEBUG, OutputEntry.LevelEnum.TRACE
                    e.Graphics.DrawString(ListBoxOutput.Items(e.Index), e.Font, Brushes.Gray, e.Bounds.X, e.Bounds.Y)
                Case OutputEntry.LevelEnum.INFO
                    e.Graphics.DrawString(ListBoxOutput.Items(e.Index), e.Font, Brushes.Black, e.Bounds.X, e.Bounds.Y)
            End Select
        End If
        e.DrawFocusRectangle()
    End Sub
End Class