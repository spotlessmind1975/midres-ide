Public Class OptionsOtherWindow

    Private _targetTreeNode As TreeNode

    Public Property TargetTreeNode As TreeNode
        Get
            Return _targetTreeNode
        End Get
        Set(value As TreeNode)
            _targetTreeNode = value
        End Set
    End Property


    Private _currentOptions As OptionsOther
    Public Property CurrentOptions As OptionsOther
        Get
            Return _currentOptions
        End Get
        Set(value As OptionsOther)
            _currentOptions = value
            UpdateOptionsOther(Me, _currentOptions)
        End Set
    End Property

    Private Sub ResizeMe()

    End Sub

    Private Sub OptionsWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeMe()
        UpdateOptionsOther(Me, CurrentOptions)
    End Sub

    Private Sub OptionsWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ResizeMe()
    End Sub

    Private Sub ButtonRestore_Click(sender As Object, e As EventArgs)

        UpdateOptionsOther(Me, CurrentOptions)

    End Sub

    Private Sub ButtonFromGlobal_Click(sender As Object, e As EventArgs)
        UpdateOptionsOther(Me, GlobalVars.CurrentOptions.Other)
    End Sub

    Private Sub ButtonFromProject_Click(sender As Object, e As EventArgs)
        UpdateOptionsOther(Me, GlobalVars.CurrentProject.CurrentOptions.Other)
    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        removeOptionsOtherFromNode(_targetTreeNode)
    End Sub

    Private Sub ButtonFromParent_Click(sender As Object, e As EventArgs) Handles ButtonFromParent.Click
        UpdateOptionsOtherFromParent(Me, _targetTreeNode)
    End Sub

    Private Sub ButtonApply_Click_1(sender As Object, e As EventArgs) Handles ButtonApply.Click

        ApplyOptionsOther(Me, CurrentOptions)

        If (CurrentOptions Is Nothing) Then
            SaveOptions()
        End If

        If Not (_targetTreeNode Is Nothing) Then
            refreshImageForNode(_targetTreeNode)
        End If

        Me.Close()

    End Sub
End Class