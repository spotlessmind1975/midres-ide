Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports ScintillaNET

Public Class SourceEditor

    Public selfScintillaSource As Scintilla

    Private _makeCommandLine As String
    Private _executableName As String
    Private _currentFolder As FolderEntry
    Private _formalLexer As Lexer = Lexer.Cpp

    Private _changed As Boolean
    Private _readOnly As Boolean
    Private _fileName As String

    Public Property Changed As String
        Get
            Return _changed
        End Get
        Set(value As String)
            _changed = value
        End Set
    End Property

    Public Property FileName As String
        Get
            Return _fileName
        End Get
        Set(value As String)
            _fileName = value
        End Set
    End Property
    Public Property OnlyRead As Boolean
        Get
            Return _readOnly
        End Get
        Set(value As Boolean)
            _readOnly = value
        End Set
    End Property

    Public Property MakeCommandLine As String
        Get
            Return _makeCommandLine
        End Get
        Set(value As String)
            _makeCommandLine = value
        End Set
    End Property

    Public Property ExecutableName As String
        Get
            Return _executableName
        End Get
        Set(value As String)
            _executableName = value
        End Set
    End Property

    Public WriteOnly Property CurrentFolder As FolderEntry
        Set(value As FolderEntry)
            _currentFolder = value
        End Set
    End Property


    Public WriteOnly Property FormalLexer As String
        Set(value As String)
            _formalLexer = value
            Init()
            If _currentFolder Is Nothing Then
                UpdateMenuEntriesForSpecificOptions(Me, Nothing)
            Else
                UpdateMenuEntriesForSpecificOptions(Me, _currentFolder.CurrentOptions)
            End If
        End Set
    End Property

    Private Sub SourceEditor_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ResizeMe()
    End Sub

    Private Sub Init()

        ScintillaSource.AutoCSeparator = " "
        ScintillaSource.AutoCIgnoreCase = true
        ScintillaSource.Lexer = _formalLexer

        If _formalLexer = Lexer.Cpp Then

            ScintillaSource.StyleResetDefault()
            ScintillaSource.Styles(Style.Default).Font = "Consolas"
            ScintillaSource.Styles(Style.Default).Font = "Consolas"
            ScintillaSource.Styles(Style.Default).Size = 10
            ScintillaSource.StyleClearAll()

            ScintillaSource.Styles(Style.Cpp.Default).ForeColor = Color.Silver
            ScintillaSource.Styles(Style.Cpp.Comment).ForeColor = Color.FromArgb(0, 128, 0)
            ScintillaSource.Styles(Style.Cpp.CommentLine).ForeColor = Color.FromArgb(0, 128, 0)
            ScintillaSource.Styles(Style.Cpp.CommentLineDoc).ForeColor = Color.FromArgb(128, 128, 128)
            ScintillaSource.Styles(Style.Cpp.Number).ForeColor = Color.Olive
            ScintillaSource.Styles(Style.Cpp.Word).ForeColor = Color.Blue
            ScintillaSource.Styles(Style.Cpp.Word2).ForeColor = Color.Blue
            ScintillaSource.Styles(Style.Cpp.String).ForeColor = Color.FromArgb(163, 21, 21)
            ScintillaSource.Styles(Style.Cpp.Character).ForeColor = Color.FromArgb(163, 21, 21)
            ScintillaSource.Styles(Style.Cpp.Verbatim).ForeColor = Color.FromArgb(163, 21, 21)
            ScintillaSource.Styles(Style.Cpp.StringEol).BackColor = Color.Pink
            ScintillaSource.Styles(Style.Cpp.Operator).ForeColor = Color.Purple
            ScintillaSource.Styles(Style.Cpp.Preprocessor).ForeColor = Color.Maroon

            ScintillaSource.Styles(Style.Cpp.Default + 64).ForeColor = Color.Silver
            ScintillaSource.Styles(Style.Cpp.Comment + 64).ForeColor = Color.FromArgb(0, 128, 0)
            ScintillaSource.Styles(Style.Cpp.CommentLine + 64).ForeColor = Color.FromArgb(0, 128, 0)
            ScintillaSource.Styles(Style.Cpp.CommentLineDoc + 64).ForeColor = Color.FromArgb(128, 128, 128)
            ScintillaSource.Styles(Style.Cpp.Number + 64).ForeColor = Color.Olive
            ScintillaSource.Styles(Style.Cpp.Word + 64).ForeColor = Color.Blue
            ScintillaSource.Styles(Style.Cpp.Word2 + 64).ForeColor = Color.Blue
            ScintillaSource.Styles(Style.Cpp.String + 64).ForeColor = Color.FromArgb(163, 21, 21)
            ScintillaSource.Styles(Style.Cpp.Character + 64).ForeColor = Color.FromArgb(163, 21, 21)
            ScintillaSource.Styles(Style.Cpp.Verbatim + 64).ForeColor = Color.FromArgb(163, 21, 21)
            ScintillaSource.Styles(Style.Cpp.StringEol + 64).BackColor = Color.Pink
            ScintillaSource.Styles(Style.Cpp.Operator + 64).ForeColor = Color.Purple
            ScintillaSource.Styles(Style.Cpp.Preprocessor + 64).ForeColor = Color.Maroon

            ScintillaSource.Margins(0).Width = 32
            ScintillaSource.Margins(0).Type = MarginType.Number

            ScintillaSource.Margins(1).Type = MarginType.Symbol
            ScintillaSource.Markers(0).Symbol = MarkerSymbol.Arrow
            ScintillaSource.Markers(0).SetForeColor(Color.Orange)
            ScintillaSource.Markers(0).SetBackColor(Color.Orange)
            ScintillaSource.Markers(1).Symbol = MarkerSymbol.Background
            ScintillaSource.Markers(1).SetBackColor(Color.Orange)
            ScintillaSource.Margins(2).Type = MarginType.Symbol
            ScintillaSource.Markers(2).Symbol = MarkerSymbol.FullRect
            ScintillaSource.Markers(2).SetForeColor(Color.LightSalmon)
            ScintillaSource.Markers(2).SetBackColor(Color.LightSalmon)
            ScintillaSource.Markers(2).Symbol = MarkerSymbol.Background
            ScintillaSource.Markers(2).SetBackColor(Color.LightSalmon)

            ScintillaSource.SetKeywords(0, GlobalVars.CKeywords)
            ScintillaSource.SetKeywords(1, GlobalVars.FunctionsAndDataTypes)
        ElseIf _formalLexer = Lexer.Container Then
            ScintillaSource.StyleResetDefault()
            ScintillaSource.Styles(Style.Default).Font = "Consolas"
            ScintillaSource.Styles(Style.Default).Font = "Consolas"
            ScintillaSource.Styles(Style.Default).Size = 10
            ScintillaSource.StyleClearAll()
        End If

    End Sub


    Private Sub SourceEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        selfScintillaSource = Me.ScintillaSource

        Init()

        If _currentFolder Is Nothing Then
            UpdateMenuEntriesForSpecificOptions(Me, Nothing)
        Else
            UpdateMenuEntriesForSpecificOptions(Me, _currentFolder.CurrentOptions)
        End If

        ResizeMe()

    End Sub

    Private Sub ResizeMe()
        ScintillaSource.Left = 0
        ScintillaSource.Width = Me.Width - 16
        ScintillaSource.Top = 0
        ScintillaSource.Height = Me.Height - 40
    End Sub
    Private Sub ScintillaSource_CharAdded(sender As Object, e As CharAddedEventArgs) Handles ScintillaSource.CharAdded

        Dim currentPos As Integer = ScintillaSource.CurrentPosition
        Dim wordStartPos As Integer = ScintillaSource.WordStartPosition(currentPos, True)

        Dim lenEntered As Integer = currentPos - wordStartPos

        If (lenEntered > 0) Then
            If (Not ScintillaSource.AutoCActive) Then
                ScintillaSource.AutoCShow(lenEntered, GlobalVars.FunctionsAndDataTypes)
            End If
        End If

    End Sub


    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFile(Me, Me.Text)
    End Sub

    Private Sub SaveasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveasToolStripMenuItem.Click
        SaveFile(Me)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        ExitProgram()

    End Sub

    Private Sub C64ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles C64ToolStripMenuItem.Click

        MakeCurrentSource(Me, "c64")

    End Sub

    Private Sub VIC20ToolStripMenuItem_Click(sender As Object, e As EventArgs)

        MakeCurrentSource(Me, "vic20")

    End Sub

    Private Sub VIC2024KBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VIC2024KBToolStripMenuItem.Click

        MakeCurrentSource(Me, "vic2024")

    End Sub

    Private Sub C16ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles C16ToolStripMenuItem.Click

        MakeCurrentSource(Me, "c16")

    End Sub

    Private Sub PLUS4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PLUS4ToolStripMenuItem.Click

        MakeCurrentSource(Me, "plus4")

    End Sub

    Private Sub ATARI8BitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ATARI8BitToolStripMenuItem.Click

        MakeCurrentSource(Me, "atari")

    End Sub

    Private Sub ATARI8BitlowResolutionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ATARI8BitlowResolutionToolStripMenuItem.Click

        MakeCurrentSource(Me, "atarilo")

    End Sub
    Private Sub SourceEditor_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        CloseFileEx(Me)

    End Sub

    Private Sub ScintillaSource_KeyUp(sender As Object, e As KeyEventArgs) Handles ScintillaSource.KeyDown

        Dim container As MainContainer = Me.MdiParent

        container.MainStatusStripLabel.Text = ScintillaSource.GetColumn(ScintillaSource.CurrentPosition) & ":" & ScintillaSource.CurrentLine

        If e.KeyCode = Keys.F1 Then

            Dim word As String = ScintillaSource.GetWordFromPosition(ScintillaSource.CurrentPosition)

            If word <> "" And LCase(Mid(word, 1, 3)) = "mr_" Then
                ShowHelpFor("midres_library", "reference", LCase(word), "Programing reference for " & word)
            End If

        End If


    End Sub

    Private Sub C64ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles C64ToolStripMenuItem1.Click

        If Not (_currentFolder Is Nothing) Then
            ExecuteEmulatorFolderForTarget(_currentFolder, "c64")
        End If

    End Sub

    Private Sub VIC20ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VIC20ToolStripMenuItem1.Click

        If Not (_currentFolder Is Nothing) Then
            ExecuteEmulatorFolderForTarget(_currentFolder, "vic20")
        End If

    End Sub

    Private Sub C128ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles C128ToolStripMenuItem.Click

        MakeFileForTarget(Me, "c128")

    End Sub

    Private Sub C128ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles C128ToolStripMenuItem1.Click

        If Not (_currentFolder Is Nothing) Then
            ExecuteEmulatorFolderForTarget(_currentFolder, "c128")
        End If

    End Sub

    Private Sub C16ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles C16ToolStripMenuItem1.Click

        If Not (_currentFolder Is Nothing) Then
            ExecuteEmulatorFolderForTarget(_currentFolder, "c16")
        End If

    End Sub

    Private Sub SourceEditor_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        If _changed Then
            Select Case MsgBox("The file has changed." & vbCrLf & "Save it?", vbYesNoCancel, "CHANGES NOT SAVED")
                Case vbYes
                    SaveFile(Me, Me.Text)
                Case vbNo

                Case vbCancel
                    e.Cancel = True
            End Select
        End If
    End Sub

    Private Sub ScintillaSource_TextChanged(sender As Object, e As EventArgs) Handles ScintillaSource.TextChanged
        _changed = True
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click

        If (Me.ScintillaSource.SelectedText <> "") Then
            FindReplaceDialog.TextBoxSearchText.Text = Me.ScintillaSource.SelectedText
        End If
        FindReplaceDialog.Replace = False
        FindReplaceDialog.EditForm = Me
        FindReplaceDialog.ShowDialog()

    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceToolStripMenuItem.Click

        If (Me.ScintillaSource.SelectedText <> "") Then
            FindReplaceDialog.TextBoxSearchText.Text = Me.ScintillaSource.SelectedText
        End If
        FindReplaceDialog.Replace = True
        FindReplaceDialog.EditForm = Me
        FindReplaceDialog.ShowDialog()

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click

        Clipboard.Clear()
        Clipboard.SetText(Me.ScintillaSource.SelectedText)

    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click

        Clipboard.Clear()
        Clipboard.SetText(Me.ScintillaSource.SelectedText)
        Me.ScintillaSource.ReplaceSelection("")

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click

        Me.ScintillaSource.ReplaceSelection(Clipboard.GetText)

    End Sub

    Private Sub VIC2024KBToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VIC2024KBToolStripMenuItem1.Click

        If Not (_currentFolder Is Nothing) Then
            ExecuteEmulatorFolderForTarget(_currentFolder, "vic2024")
        End If


    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ScintillaSource_GotFocus(sender As Object, e As EventArgs) Handles ScintillaSource.GotFocus
        If _currentFolder Is Nothing Then
            UpdateMenuEntriesForSpecificOptions(Me, Nothing)
        Else
            UpdateMenuEntriesForSpecificOptions(Me, _currentFolder.CurrentOptions)
        End If
    End Sub

    Private Sub VIC20ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles VIC20ToolStripMenuItem.Click
        MakeCurrentSource(Me, "vic20")
    End Sub

    Private Sub PLUS4ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PLUS4ToolStripMenuItem1.Click

        If Not (_currentFolder Is Nothing) Then
            ExecuteEmulatorFolderForTarget(_currentFolder, "plus4")
        End If

    End Sub

    Private Sub ATARI8BitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ATARI8BitToolStripMenuItem1.Click

        If Not (_currentFolder Is Nothing) Then
            ExecuteEmulatorFolderForTarget(_currentFolder, "atari")
        End If

    End Sub

    Private Sub ATARI8BitlowResolutionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ATARI8BitlowResolutionToolStripMenuItem1.Click
        If Not (_currentFolder Is Nothing) Then
            ExecuteEmulatorFolderForTarget(_currentFolder, "atarilo")
        End If

    End Sub

    Private Sub SourceEditor_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ScintillaSource.ReadOnly = _readOnly
        If _readOnly And InStr(Me.Text, "(read only)") = 0 Then
            Me.Text &= " (read only)"
        End If
    End Sub
End Class