Module OutputWindowHelper

    Public Sub ClearOutput()
        GlobalVars.ErrorOutput.Items.Clear()
    End Sub

    Public Sub AddOutput(_filename As String, _line As Integer, _message As String, _kind As Integer, _marker As Integer)
        Dim entry As OutputEntry = New OutputEntry(OutputEntry.LevelEnum.INFO, _filename, _line, _message, _kind, _marker)
        GlobalVars.ErrorOutput.Items.Add(entry)
    End Sub

    Public Sub AddOutputMessage(_level As OutputEntry.LevelEnum, _message As String)
        Dim entry As OutputEntry = New OutputEntry(_level, "", 0, _message, 0, 0)
        GlobalVars.ErrorOutput.Items.Add(entry)
    End Sub

    Public Sub UpdateOutput(_main_container As MainContainer, Optional _folder_entry As FolderEntry = Nothing)

        Dim minLevel As OutputEntry.LevelEnum = OutputEntry.LevelEnum.INFO
        Dim line As String

        OutputWindow.MdiParent = _main_container

        minLevel = OutputWindow.ComboBoxOutputLevel.SelectedIndex

        OutputWindow.ListBoxOutput.Items.Clear()
        OutputWindow.OutputFiltered = New Collection()

        For Each ee In GlobalVars.ErrorOutput.Items
            If ee.level >= minLevel Then
                If ee.message <> "" Then
                    If ee.filename <> "" Then
                        line = ee.message & " (" & ee.filename & ":" & ee.line & ")"
                    Else
                        line = ee.message
                    End If
                    OutputWindow.ListBoxOutput.Items.Add(line)
                    OutputWindow.OutputFiltered.Add(ee)
                End If
            End If
        Next

        OutputWindow.Show()
        OutputWindow.BringToFront()

    End Sub

    Public Sub IgnoreMessageNextTime(_error_output_window As OutputWindow, _options_cc65 As OptionsCC65)

        Dim i As Integer = _error_output_window.ListBoxOutput.SelectedIndex

        If i > -1 Then

            Dim e As OutputEntry = GlobalVars.ErrorOutput.Items(i + 1)

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
