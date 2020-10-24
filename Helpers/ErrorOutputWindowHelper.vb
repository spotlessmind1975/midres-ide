Module ErrorOutputWindowHelper

    Public Sub ClearErrorOutput()
        GlobalVars.ErrorOutput.Items.Clear()
    End Sub

    Public Sub AddErrorOutput(_filename As String, _line As Integer, _message As String, _kind As Integer, _marker As Integer)
        Dim errorEntry As ErrorOutputEntry = New ErrorOutputEntry(_filename, _line, _message, _kind, _marker)
        GlobalVars.ErrorOutput.Items.Add(errorEntry)
    End Sub

    Public Sub UpdateErrorOutput(_main_container As MainContainer, Optional _folder_entry As FolderEntry = Nothing)

        Dim line As String

        ErrorOutputWindow.MdiParent = _main_container

        ErrorOutputWindow.ListBoxOutput.Items.Clear()

        For Each ee In GlobalVars.ErrorOutput.Items
            If ee.message <> "" Then
                If ee.filename <> "" Then
                    line = ee.message & " (" & ee.filename & ":" & ee.line & ")"
                Else
                    line = ee.message
                End If
                ErrorOutputWindow.ListBoxOutput.Items.Add(line)
            End If
        Next

        If (GlobalVars.ErrorOutput.Items.Count > 0) Then
            ErrorOutputWindow.Show()
            ErrorOutputWindow.BringToFront()
        Else
            ErrorOutputWindow.Hide()
        End If

    End Sub

    Public Sub IgnoreMessageNextTime(_error_output_window As ErrorOutputWindow, _options_cc65 As OptionsCC65)

        Dim i As Integer = _error_output_window.ListBoxOutput.SelectedIndex

        If i > -1 Then

            Dim e As ErrorOutputEntry = GlobalVars.ErrorOutput.Items(i + 1)

            If e.Kind = 1 Then

                If _options_cc65.Warnings.Contains(e.Message) Then
                    _options_cc65.Warnings.Item(e.Message).Ignored = True
                Else
                    Dim w As CC65WarningEntry = New CC65WarningEntry(e.Message, True)
                    _options_cc65.Warnings.Add(w, e.Message)
                End If
            End If
        End If

    End Sub
End Module
