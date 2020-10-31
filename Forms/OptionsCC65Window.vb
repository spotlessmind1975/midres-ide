Public Class OptionsCC65Window

    Private _currentOptions As OptionsCC65
    Public Property CurrentOptions As OptionsCC65
        Get
            Return _currentOptions
        End Get
        Set(value As OptionsCC65)
            _currentOptions = value
            UpdateOptionsCC65(Me, _currentOptions)
        End Set
    End Property

    Private Sub ResizeMe()
        TabControlOptions.Left = 0
        TabControlOptions.Width = Me.Width - 16
        TabControlOptions.Top = 0
        TabControlOptions.Height = Me.Height
    End Sub

    Private Sub OptionsWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeMe()
        UpdateOptionsCC65(Me, CurrentOptions)
    End Sub

    Private Sub OptionsWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ResizeMe()
    End Sub

    Private Sub ButtonRestore_Click(sender As Object, e As EventArgs) Handles ButtonRestore.Click

        UpdateOptionsCC65(Me, CurrentOptions)

    End Sub

    Private Sub ButtonApply_Click(sender As Object, e As EventArgs) Handles ButtonApply.Click

        ApplyOptionsCC65(Me, CurrentOptions)

        If (CurrentOptions Is Nothing) Then
            SaveOptions()
        End If

    End Sub

    Private Sub ButtonFromGlobal_Click(sender As Object, e As EventArgs) Handles ButtonFromGlobal.Click
        UpdateOptionsCC65(Me, GlobalVars.CurrentOptions.CC65)
    End Sub

    Private Sub ButtonFromProject_Click(sender As Object, e As EventArgs) Handles ButtonFromProject.Click
        UpdateOptionsCC65(Me, GlobalVars.CurrentProject.CurrentOptions.CC65)
    End Sub

    Private Sub CheckBoxRegisterVars_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRegisterVars.CheckedChanged
        TrackBarRegisterSpace.Enabled = CheckBoxRegisterVars.Checked
    End Sub

    Private Sub CheckBoxForgetIncPath_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxForgetIncPath.CheckedChanged
        ListBoxIncludeDirs.Enabled = Not CheckBoxForgetIncPath.Checked
    End Sub

    Private Sub CheckBoxSuppressWarnings_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSuppressWarnings.CheckedChanged
        CheckedListBoxCC65Warnings.Enabled = Not CheckBoxSuppressWarnings.Checked
    End Sub
End Class