Public Class OptionsOtherWindow

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

    Private Sub ButtonRestore_Click(sender As Object, e As EventArgs) Handles ButtonRestore.Click

        UpdateOptionsOther(Me, CurrentOptions)

    End Sub

    Private Sub ButtonApply_Click(sender As Object, e As EventArgs) Handles ButtonApply.Click

        ApplyOptionsOther(Me, CurrentOptions)

        If (CurrentOptions Is Nothing) Then
            SaveOptions()
        End If

        Me.Close()

    End Sub

    Private Sub ButtonFromGlobal_Click(sender As Object, e As EventArgs) Handles ButtonFromGlobal.Click
        UpdateOptionsOther(Me, GlobalVars.CurrentOptions.Other)
    End Sub

    Private Sub ButtonFromProject_Click(sender As Object, e As EventArgs) Handles ButtonFromProject.Click
        UpdateOptionsOther(Me, GlobalVars.CurrentProject.CurrentOptions.Other)
    End Sub


End Class