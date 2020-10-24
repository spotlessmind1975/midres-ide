Imports CefSharp.WinForms

Public Class HelpWindow

    Public Shared chromeBrowser As ChromiumWebBrowser

    Public Sub ResizeMe()
        If Not (chromeBrowser Is Nothing) Then
            chromeBrowser.Width = Me.Width - 16
            chromeBrowser.Left = 0
            chromeBrowser.Height = Me.Height
            chromeBrowser.Top = 0
        End If
    End Sub

    Private Sub HelpWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ResizeMe()

    End Sub

    Private Sub HelpWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ResizeMe()
    End Sub

End Class