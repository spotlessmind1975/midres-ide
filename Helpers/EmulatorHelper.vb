Module EmulatorHelper

    Public Function ExecuteEmulatorInternal(_options As Options, _executable_name As String, _target As String) As String

        ExecuteEmulatorInternal = 0

        Select Case _target
            Case "c16"
                If (_options.Emulators.ViceEnabled) Then
                    ExecuteEmulatorInternal = Shell(_options.Emulators.VicePath & "xplus4.exe --model c16 " & _executable_name, AppWinStyle.NormalFocus)
                End If
            Case "c64"
                If (_options.Emulators.ViceEnabled) Then
                    ExecuteEmulatorInternal = Shell(_options.Emulators.VicePath & "x64.exe " & _executable_name, AppWinStyle.NormalFocus)
                End If
            Case "c128"
                If (_options.Emulators.ViceEnabled) Then
                    ExecuteEmulatorInternal = Shell(_options.Emulators.VicePath & "x128.exe " & _executable_name, AppWinStyle.NormalFocus)
                End If
            Case "vic20"
                If (_options.Emulators.ViceEnabled) Then
                    ExecuteEmulatorInternal = Shell(_options.Emulators.VicePath & "xvic.exe " & _executable_name, AppWinStyle.NormalFocus)
                End If
            Case "vic2024"
                If (_options.Emulators.ViceEnabled) Then
                    ExecuteEmulatorInternal = Shell(_options.Emulators.VicePath & "xvic.exe --memory 24k " & _executable_name, AppWinStyle.NormalFocus)
                End If
            Case "plus4"
                If (_options.Emulators.YapeEnabled) Then
                    ExecuteEmulatorInternal = Shell(_options.Emulators.YapePath & "yape.exe " & _executable_name, AppWinStyle.NormalFocus)
                ElseIf (_options.Emulators.ViceEnabled) Then
                    ExecuteEmulatorInternal = Shell(_options.Emulators.VicePath & "xplus4.exe " & _executable_name, AppWinStyle.NormalFocus)
                End If
            Case "atari"
                If (_options.Emulators.AltirraEnabled) Then
                    ExecuteEmulatorInternal = Shell(_options.Emulators.AltirraPath & "altirra.exe " & _executable_name, AppWinStyle.NormalFocus)
                ElseIf (_options.Emulators.Atari800Enabled) Then
                    ExecuteEmulatorInternal = Shell(_options.Emulators.Atari800Path & "atari800.exe " & _executable_name, AppWinStyle.NormalFocus)
                End If
            Case "atarilo"
                If (_options.Emulators.AltirraEnabled) Then
                    ExecuteEmulatorInternal = Shell(_options.Emulators.AltirraPath & "altirra.exe " & _executable_name, AppWinStyle.NormalFocus)
                ElseIf (_options.Emulators.Atari800Enabled) Then
                    ExecuteEmulatorInternal = Shell(_options.Emulators.Atari800Path & "atari800.exe " & _executable_name, AppWinStyle.NormalFocus)
                End If
        End Select

        Return ExecuteEmulatorInternal

    End Function

    Public Sub ExecuteEmulatorForTarget(_folder_entry As FolderEntry, _target As String)

        Dim binaryFileName As String = _folder_entry.CurrentOptions.Make.BinaryFilename
        Dim support As String = SupportForTarget(_target, _folder_entry.CurrentOptions.Make)

        If binaryFileName = "" Then
            MsgBox("Cannot execute program since the output file name is undefined.", vbOKOnly, "CANNOT RUN EXECUTABLE")
            Exit Sub
        End If

        binaryFileName = binaryFileName.Replace("{target}", _target)
        binaryFileName = binaryFileName.Replace("{support}", support)

        ExecuteEmulatorInternal(_folder_entry.CurrentOptions, GetFullPathForElement(binaryFileName, _folder_entry), _target)

    End Sub

    Public Sub ExecuteEmulatorFolderForTarget(_folder_entry As FolderEntry, _target As String)

        ExecuteEmulatorForTarget(_folder_entry, _target)

    End Sub
End Module
