Public Class SearchResultWindow
    Private Sub ResizeMe()
        ListBoxSearchResult.Left = 0
        ListBoxSearchResult.Width = Me.Width - 16
        ListBoxSearchResult.Top = 0
        ListBoxSearchResult.Height = Me.Height - 40
    End Sub

    Private Sub SearchResultWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeMe()
    End Sub

    Private Sub SearchResultWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ResizeMe()
    End Sub

    Private Sub ListBoxSearchResult_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxSearchResult.DoubleClick
        If ListBoxSearchResult.SelectedIndex > -1 Then
            Dim sr As SearchResult = GlobalVars.SearchResultCollection(ListBoxSearchResult.SelectedIndex + 1)
            If (sr.Filename <> "") Then
                FocusOnFilenameAndPosition(sr.Filename, sr.Start, Me.MdiParent)
            End If
        End If
    End Sub
End Class