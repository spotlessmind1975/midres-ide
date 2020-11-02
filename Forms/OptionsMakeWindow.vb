Public Class OptionsMakeWindow

    Private _currentOptions As OptionsMake
    Public Property CurrentOptions As OptionsMake
        Get
            Return _currentOptions
        End Get
        Set(value As OptionsMake)
            _currentOptions = value
            UpdateOptionsMake(Me, _currentOptions)
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
        UpdateOptionsMake(Me, CurrentOptions)
    End Sub

    Private Sub OptionsWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ResizeMe()
    End Sub

    Private Sub ButtonRestore_Click(sender As Object, e As EventArgs) Handles ButtonRestore.Click

        UpdateOptionsMake(Me, CurrentOptions)

    End Sub

    Private Sub ButtonApply_Click(sender As Object, e As EventArgs) Handles ButtonApply.Click

        ApplyOptionsMake(Me, CurrentOptions)

        If (CurrentOptions Is Nothing) Then
            SaveOptions()
        End If

        Me.Close()

    End Sub

    Private Sub ButtonFromGlobal_Click(sender As Object, e As EventArgs) Handles ButtonFromGlobal.Click
        UpdateOptionsMake(Me, GlobalVars.CurrentOptions.Make)
    End Sub

    Private Sub ButtonFromProject_Click(sender As Object, e As EventArgs) Handles ButtonFromProject.Click
        UpdateOptionsMake(Me, GlobalVars.CurrentProject.CurrentOptions.Make)
    End Sub

    Private Sub RadioButtonStaticMakefile_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonStaticMakefile.CheckedChanged
        TextBoxActionClean.Enabled = True
        TextBoxActionBuild.Enabled = True
        TextBoxAdditionalParams.Enabled = True
        TextBoxMakeFileName.Enabled = True
    End Sub

    Private Sub RadioButtonDynamicMakefile_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDynamicMakefile.CheckedChanged
        TextBoxActionClean.Enabled = False
        TextBoxActionBuild.Enabled = False
        TextBoxAdditionalParams.Enabled = False
        TextBoxMakeFileName.Enabled = True
    End Sub

    Private Sub RadioButtonInternal_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonInternal.CheckedChanged
        TextBoxActionClean.Enabled = False
        TextBoxActionBuild.Enabled = False
        TextBoxAdditionalParams.Enabled = False
        TextBoxMakeFileName.Enabled = False
    End Sub
End Class