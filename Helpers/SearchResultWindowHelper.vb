Module SearchResultWindowHelper

    Public Sub ClearSearchResult()
        GlobalVars.SearchResultCollection.Clear()
    End Sub

    Public Sub UpdateSearchResult(_main_container As MainContainer, _title As String)

        Dim line As String

        SearchResultWindow.MdiParent = _main_container
        SearchResultWindow.Text = _title

        SearchResultWindow.ListBoxSearchResult.Items.Clear()

        For Each rs In GlobalVars.SearchResultCollection
            line = rs.content & " (" & rs.filename & ":" & rs.line & ")"
            SearchResultWindow.ListBoxSearchResult.Items.Add(line)
        Next

        If (GlobalVars.SearchResultCollection.Count > 0) Then
            SearchResultWindow.Show()
            SearchResultWindow.BringToFront()
        Else
            SearchResultWindow.Hide()
        End If

    End Sub

End Module
