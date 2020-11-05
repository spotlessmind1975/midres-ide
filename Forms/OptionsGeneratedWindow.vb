Public Class OptionsGeneratedWindow

    Private _targetTreeNode As TreeNode

    Public Property TargetTreeNode As TreeNode
        Get
            Return _targetTreeNode
        End Get
        Set(value As TreeNode)
            _targetTreeNode = value
        End Set
    End Property


    Private _currentOptions As OptionsGenerated
    Private _folders As Collection

    Public Property CurrentOptions As OptionsGenerated
        Get
            Return _currentOptions
        End Get
        Set(value As OptionsGenerated)
            _currentOptions = value
            UpdateOptionsGenerated(Me, _currentOptions)
        End Set
    End Property

    Public Property Folders As Collection
        Get
            Return _folders
        End Get
        Set(value As Collection)
            _folders = value
        End Set
    End Property

    Private Sub ResizeMe()
        TabControlOptions.Left = 0
        TabControlOptions.Width = Me.Width - 16
        TabControlOptions.Top = 0
        TabControlOptions.Height = Me.Height
    End Sub

    Private Sub OptionsGeneratedWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeMe()
        UpdateOptionsGenerated(Me, CurrentOptions)
    End Sub

    Private Sub OptionsGeneratedWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ResizeMe()
    End Sub

    Private Sub ButtonApply_Click(sender As Object, e As EventArgs)

        ApplyOptionsGenerated(Me, CurrentOptions)

        If Not (_targetTreeNode Is Nothing) Then
            refreshImageForNode(_targetTreeNode)
        End If

        Me.Close()

    End Sub

    Private Sub CheckedListBoxDependency_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        removeOptionsGeneratedFromNode(_targetTreeNode)
    End Sub
End Class