Public Class OptionsCC65Window

    Private _targetTreeNode As TreeNode

    Public Property TargetTreeNode As TreeNode
        Get
            Return _targetTreeNode
        End Get
        Set(value As TreeNode)
            _targetTreeNode = value
        End Set
    End Property

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

        If Not (_targetTreeNode Is Nothing) Then
            refreshImageForNode(_targetTreeNode)
        End If

        Me.Close()

    End Sub

    Private Sub ButtonFromGlobal_Click(sender As Object, e As EventArgs) Handles ButtonFromGlobal.Click
        UpdateOptionsCC65(Me, GlobalVars.CurrentOptions.CC65)
    End Sub

    Private Sub ButtonFromProject_Click(sender As Object, e As EventArgs) Handles ButtonFromProject.Click
        UpdateOptionsCC65(Me, GlobalVars.CurrentProject.CurrentOptions.CC65)
    End Sub

    Private Sub CheckBoxForgetIncPath_CheckedChanged(sender As Object, e As EventArgs)
        DataGridViewIncludeDirs.Enabled = Not CheckBoxForgetIncPath.Checked
    End Sub


    Private Sub CheckBoxCodeSizeEnabled_CheckedChanged(sender As Object, e As EventArgs)
        TrackBarCodeSize.Enabled = CheckBoxCodeSizeEnabled.Checked
    End Sub

    Private Sub CheckBoxAllCDecl_KeyUp(sender As Object, e As KeyEventArgs)
        ShowHelpIfRequested(e, "midres_ide", "cc65", "allcdecl", CheckBoxAllCDecl.Tag)
    End Sub

    Private Sub CheckBoxAllCDecl_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBoxCreateDep_CheckedChanged(sender As Object, e As EventArgs)
        TextBoxDependencyFileName.Enabled = CheckBoxCreateDep.Checked
        CheckBoxDepTarget.Enabled = CheckBoxCreateDep.Checked Or CheckBoxCreateFullDep.Checked
    End Sub

    Private Sub CheckBoxCreateFullDep_CheckedChanged(sender As Object, e As EventArgs)
        TextBoxCreateFullDepFileName.Enabled = CheckBoxCreateFullDep.Checked
    End Sub

    Private Sub CheckBoxDepTarget_CheckedChanged(sender As Object, e As EventArgs)
        TextBoxDepTargetFileName.Enabled = CheckBoxDepTarget.Enabled And CheckBoxDepTarget.Checked
    End Sub

    Private Sub TrackBarRegisterSpace_Scroll(sender As Object, e As EventArgs)
        LabelRegisterSpace.Text = TrackBarRegisterSpace.Value
    End Sub

    Private Sub TextBoxDepTargetFileName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxCreateFullDepFileName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TrackBarCodeSize_Scroll(sender As Object, e As EventArgs) Handles TrackBarCodeSize.Scroll
        LabelCodeSize.Text = TrackBarCodeSize.Value
    End Sub

    Private Sub CheckBoxCodeSizeEnabled_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBoxCodeSizeEnabled.CheckedChanged
        TrackBarCodeSize.Enabled = CheckBoxCodeSizeEnabled.Checked
    End Sub

    Private Sub CheckBoxCreateDep_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBoxCreateDep.CheckedChanged
        TextBoxDependencyFileName.Enabled = CheckBoxCreateDep.Checked
    End Sub

    Private Sub CheckBoxCreateFullDep_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBoxCreateFullDep.CheckedChanged
        TextBoxCreateFullDepFileName.Enabled = CheckBoxCreateFullDep.Checked
    End Sub

    Private Sub CheckBoxDepTarget_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBoxDepTarget.CheckedChanged
        TextBoxDepTargetFileName.Enabled = CheckBoxDepTarget.Checked
    End Sub

    Private Sub CheckBoxInlineFunctions_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBoxInlineFunctions.CheckedChanged
        If CheckBoxInlineFunctions.Checked Then
            CheckBoxInlineStdFunctions.Checked = True
            CheckBoxInlineStdFunctions.Enabled = False
        Else
            CheckBoxInlineStdFunctions.Enabled = True
        End If

    End Sub

    Private Sub CheckBoxRegisterSpaceEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRegisterSpaceEnabled.CheckedChanged
        TrackBarRegisterSpace.Enabled = CheckBoxRegisterSpaceEnabled.Checked
    End Sub

    Private Sub CheckBoxForgetIncPath_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBoxForgetIncPath.CheckedChanged
        DataGridViewIncludeDirs.Enabled = CheckBoxForgetIncPath.Checked
    End Sub

    Private Sub CheckBoxSuppressWarnings_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBoxSuppressWarnings.CheckedChanged
        CheckedListBoxCC65Warnings.Enabled = Not CheckBoxSuppressWarnings.Checked
    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        removeOptionsCC65FromNode(_targetTreeNode)
    End Sub

    Private Sub ButtonFromParent_Click(sender As Object, e As EventArgs) Handles ButtonFromParent.Click
        UpdateOptionsCC65FromParent(Me, _targetTreeNode)
    End Sub
End Class