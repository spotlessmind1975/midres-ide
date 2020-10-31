Public Class OptionsTilesetWindow

    Private _currentOptions As OptionsTileset
    Public Property CurrentOptions As OptionsTileset
        Get
            Return _currentOptions
        End Get
        Set(value As OptionsTileset)
            _currentOptions = value
            UpdateOptionsTileset(Me, _currentOptions)
        End Set
    End Property

    Private Sub ResizeMe()
        TabControlOptions.Left = 0
        TabControlOptions.Width = Me.Width - 16
        TabControlOptions.Top = 0
        TabControlOptions.Height = Me.Height
    End Sub

    Private Sub OptionsTilesetWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeMe()
        UpdateOptionsTileset(Me, CurrentOptions)
    End Sub

    Private Sub OptionsTilesetWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ResizeMe()
    End Sub

    Private Sub ButtonRestore_Click(sender As Object, e As EventArgs) Handles ButtonRestore.Click

        If (CurrentOptions Is Nothing) Then
            LoadOptions()
        End If

        UpdateOptionsTileset(Me, CurrentOptions)

    End Sub

    Private Sub ButtonApply_Click(sender As Object, e As EventArgs) Handles ButtonApply.Click

        ApplyOptionsTileset(Me, CurrentOptions)

        If (CurrentOptions Is Nothing) Then
            SaveOptions()
        End If

    End Sub

    Private Sub ButtonFromGlobal_Click(sender As Object, e As EventArgs) Handles ButtonFromGlobal.Click
        UpdateOptionsTileset(Me, GlobalVars.CurrentOptions.Tileset)
    End Sub

    Private Sub ButtonFromProject_Click(sender As Object, e As EventArgs) Handles ButtonFromProject.Click
        UpdateOptionsTileset(Me, GlobalVars.CurrentProject.CurrentOptions.Tileset)
    End Sub

End Class