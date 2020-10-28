Imports System.IO
Imports System.Text.RegularExpressions

Public Class FindReplaceDialog

    Private _editForm As SourceEditor
    Private _replace As Boolean

    Public WriteOnly Property Replace As Boolean
        Set(value As Boolean)
            _replace = value
        End Set
    End Property

    ReadOnly Property MatchCase As Boolean
        Get
            Return CheckBoxMatchCase.Checked
        End Get
    End Property

    ReadOnly Property MatchWholeWord As Boolean
        Get
            Return CheckBoxMatchWholeWord.Checked
        End Get
    End Property

    ReadOnly Property Regex As Boolean
        Get
            Return CheckBoxRegex.Checked
        End Get
    End Property

    ReadOnly Property SearchText As String
        Get
            Return TextBoxSearchText.Text
        End Get
    End Property
    ReadOnly Property ReplaceText As String
        Get
            Return TextBoxReplaceText.Text
        End Get
    End Property

    ReadOnly Property SearchPath As String
        Get
            Return TextBoxPath.Text
        End Get
    End Property

    ReadOnly Property SearchFileMask As String
        Get
            Return TextBoxFileMask.Text
        End Get
    End Property

    WriteOnly Property EditForm As SourceEditor
        Set
            _editForm = Value
            If _editForm Is Nothing Then
                LabelPath.Visible = True
                TextBoxPath.Visible = True
                LabelFileMask.Visible = True
                TextBoxFileMask.Visible = True
                TextBoxReplaceText.Visible = False
                ButtonReplace.Visible = False
                ButtonReplaceAll.Visible = False
                TextBoxPath.Text = GetFullPathForElement("", GlobalVars.CurrentFolder)
            Else
                LabelPath.Visible = False
                TextBoxPath.Visible = False
                LabelFileMask.Visible = False
                TextBoxFileMask.Visible = False
                If _replace Then
                    TextBoxReplaceText.Visible = True
                    LabelReplace.Visible = True
                    ButtonReplace.Visible = True
                    ButtonReplaceAll.Visible = True
                Else
                    TextBoxReplaceText.Visible = False
                    LabelReplace.Visible = False
                    ButtonReplace.Visible = False
                    ButtonReplaceAll.Visible = False
                End If
            End If
        End Set
    End Property

    Private Sub FindDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxSearchText.SelectAll()
        TextBoxSearchText.Focus()
    End Sub


    Private Sub ButtonFindNext_Click(sender As Object, e As EventArgs) Handles ButtonReplaceAll.Click, ButtonFindNext.Click
        If ValidateFields() Then
            If Not (_editForm Is Nothing) Then
                TimerFocus.Enabled = True
                FindNext(Me._editForm, Me, Nothing, False)
            Else
                FindAll(Me, MainContainer)
            End If
        End If
    End Sub

    Private Function ValidateFields() As Boolean

        If Len(Trim(TextBoxSearchText.Text)) = 0 Then
            MsgBox("Please, type the text to search.")
            TextBoxSearchText.Focus()
            Return False
        End If

        If CheckBoxRegex.Checked Then
            Try
                Dim r As Regex = New Regex(TextBoxSearchText.Text)
            Catch ex As Exception
                MsgBox("Regular expression is not valid.")
                TextBoxSearchText.Focus()
                Return False
            End Try
        End If

        Return True

    End Function

    Private Sub CheckBoxRegex_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRegex.CheckedChanged
        If CheckBoxRegex.Checked Then
            CheckBoxMatchCase.Enabled = False
            CheckBoxMatchWholeWord.Enabled = False
        Else
            CheckBoxMatchCase.Enabled = True
            CheckBoxMatchWholeWord.Enabled = True
        End If
    End Sub

    Private Sub TimerFocus_Tick(sender As Object, e As EventArgs) Handles TimerFocus.Tick
        TextBoxSearchText.Focus()
        TimerFocus.Enabled = False
    End Sub

    Private Sub ButtonReplace_Click(sender As Object, e As EventArgs) Handles ButtonReplace.Click
        If ValidateFields() Then
            TimerFocus.Enabled = True
            FindNext(Me._editForm, Me, TextBoxReplaceText.Text, False)
        End If
    End Sub

    Private Sub ButtonReplaceAll_Click(sender As Object, e As EventArgs) Handles ButtonReplaceAll.Click
        If ValidateFields() Then
            TimerFocus.Enabled = True
            FindNext(Me._editForm, Me, TextBoxReplaceText.Text, True)
        End If
    End Sub

    Private Sub TextBoxSearchText_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearchText.TextChanged

    End Sub

    Private Sub TextBoxSearchText_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxSearchText.KeyUp
        If e.KeyCode = Keys.Enter Then
            ButtonFindNext_Click(sender, e)
        End If
    End Sub

    Private Sub FindReplaceDialog_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TextBoxSearchText.Focus()
    End Sub

    Private Sub FindReplaceDialog_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class