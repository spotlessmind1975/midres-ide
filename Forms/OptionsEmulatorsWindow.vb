Public Class OptionsEmulatorsWindow

    Private _currentOptions As OptionsEmulators
    Public Property CurrentOptions As OptionsEmulators
        Get
            Return _currentOptions
        End Get
        Set(value As OptionsEmulators)
            _currentOptions = value
            UpdateOptionsEmulators(Me, _currentOptions)
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
        UpdateOptionsEmulators(Me, CurrentOptions)
    End Sub

    Private Sub OptionsWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ResizeMe()
    End Sub

    Private Sub ButtonRestore_Click(sender As Object, e As EventArgs) Handles ButtonRestore.Click

        If (CurrentOptions Is Nothing) Then
            LoadOptions()
        End If

        UpdateOptionsEmulators(Me, CurrentOptions)

    End Sub

    Private Sub ButtonApply_Click(sender As Object, e As EventArgs) Handles ButtonApply.Click

        ApplyOptionsEmulators(Me, CurrentOptions)

        If (CurrentOptions Is Nothing) Then
            SaveOptions()
        End If

        Me.Close()

    End Sub

    Private Sub ButtonFromGlobal_Click(sender As Object, e As EventArgs) Handles ButtonFromGlobal.Click
        UpdateOptionsEmulators(Me, GlobalVars.CurrentOptions.Emulators)
    End Sub

    Private Sub ButtonFromProject_Click(sender As Object, e As EventArgs) Handles ButtonFromProject.Click
        UpdateOptionsEmulators(Me, GlobalVars.CurrentProject.CurrentOptions.Emulators)
    End Sub

End Class