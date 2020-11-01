Imports CefSharp.WinForms

Module HelpWindowHelper

    Private Sub ShowPage(_url As String, Optional _title As String = "Help On Line")

        HelpWindow.MdiParent = MainContainer
        HelpWindow.Show()
        HelpWindow.chromeBrowser = New ChromiumWebBrowser(_url)
        HelpWindow.ResizeMe()
        HelpWindow.Controls.Add(HelpWindow.chromeBrowser)
        HelpWindow.Text = _title

    End Sub
    Public Sub ShowHelpFor(_section As String, _class As String, _identifier As String, Optional _title As String = "Help On line")

        ShowPage("https://retroprogramming.iwashere.eu/" & _section & ":" & _class & ":" & _identifier, _title)

    End Sub

    Public Sub ShowHelpGuide()

        ShowPage("https://retroprogramming.iwashere.eu/midres_library:reference")

    End Sub

    Public Sub ShowHelpIfRequested(_e As KeyEventArgs, _section As String, _class As String, _identifier As String, Optional _title As String = "Help On line")
        If _e.KeyCode = Keys.F1 Then
            ShowHelpFor(_section, _class, _identifier, "Help for " & _title)
        End If
    End Sub
End Module
