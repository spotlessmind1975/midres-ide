Public Class OptionsTilesetWindow

    Private _targetTreeNode As TreeNode

    Public Property TargetTreeNode As TreeNode
        Get
            Return _targetTreeNode
        End Get
        Set(value As TreeNode)
            _targetTreeNode = value
        End Set
    End Property



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

    Private Sub ButtonRestore_Click(sender As Object, e As EventArgs)

        If (CurrentOptions Is Nothing) Then
            LoadOptions()
        End If

        UpdateOptionsTileset(Me, CurrentOptions)

    End Sub

    Private Sub ButtonApply_Click(sender As Object, e As EventArgs)

        ApplyOptionsTileset(Me, CurrentOptions)

        If (CurrentOptions Is Nothing) Then
            SaveOptions()
        End If

        If Not (_targetTreeNode Is Nothing) Then
            refreshImageForNode(_targetTreeNode)
        End If

        Me.Close()

    End Sub

    Private Sub ButtonFromGlobal_Click(sender As Object, e As EventArgs)
        UpdateOptionsTileset(Me, GlobalVars.CurrentOptions.Tileset)
    End Sub

    Private Sub ButtonFromProject_Click(sender As Object, e As EventArgs)
        UpdateOptionsTileset(Me, GlobalVars.CurrentProject.CurrentOptions.Tileset)
    End Sub

    Private Sub TrackBarTilesetThresholdLuminance_Scroll(sender As Object, e As EventArgs) Handles TrackBarTilesetThresholdLuminance.Scroll
        LabelThresholdLuminance.Text = TrackBarTilesetThresholdLuminance.Value
    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        removeOptionsTilesetFromNode(_targetTreeNode)
    End Sub
End Class