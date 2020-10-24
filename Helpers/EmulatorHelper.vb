Module EmulatorHelper

    Public Function ExecuteEmulatorInternal(_executable_name As String, _target As String) As String

        ExecuteEmulatorInternal = 0

        Select Case _target
            Case "c16"
                If (GlobalVars.CurrentOptions.Emulators.ViceEnabled) Then
                    ExecuteEmulatorInternal = Shell(GlobalVars.CurrentOptions.Emulators.VicePath & "xplus4.exe --model c16 " & _executable_name, AppWinStyle.NormalFocus)
                End If
            Case "c64"
                If (GlobalVars.CurrentOptions.Emulators.ViceEnabled) Then
                    ExecuteEmulatorInternal = Shell(GlobalVars.CurrentOptions.Emulators.VicePath & "x64.exe " & _executable_name, AppWinStyle.NormalFocus)
                End If
            Case "c128"
                If (GlobalVars.CurrentOptions.Emulators.ViceEnabled) Then
                    ExecuteEmulatorInternal = Shell(GlobalVars.CurrentOptions.Emulators.VicePath & "x128.exe " & _executable_name, AppWinStyle.NormalFocus)
                End If
            Case "vic20"
                If (GlobalVars.CurrentOptions.Emulators.ViceEnabled) Then
                    ExecuteEmulatorInternal = Shell(GlobalVars.CurrentOptions.Emulators.VicePath & "xvic.exe " & _executable_name, AppWinStyle.NormalFocus)
                End If
            Case "vic2024"
                If (GlobalVars.CurrentOptions.Emulators.ViceEnabled) Then
                    ExecuteEmulatorInternal = Shell(GlobalVars.CurrentOptions.Emulators.VicePath & "xvic.exe --memory 24k " & _executable_name, AppWinStyle.NormalFocus)
                End If
            Case "plus4"
                If (GlobalVars.CurrentOptions.Emulators.YapeEnabled) Then
                    ExecuteEmulatorInternal = Shell(GlobalVars.CurrentOptions.Emulators.YapePath & "yape.exe " & _executable_name, AppWinStyle.NormalFocus)
                ElseIf (GlobalVars.CurrentOptions.Emulators.ViceEnabled) Then
                    ExecuteEmulatorInternal = Shell(GlobalVars.CurrentOptions.Emulators.VicePath & "xplus4.exe " & _executable_name, AppWinStyle.NormalFocus)
                End If
            Case "atari"
                If (GlobalVars.CurrentOptions.Emulators.AltirraEnabled) Then
                    ExecuteEmulatorInternal = Shell(GlobalVars.CurrentOptions.Emulators.AltirraPath & "altirra.exe " & _executable_name, AppWinStyle.NormalFocus)
                ElseIf (GlobalVars.CurrentOptions.Emulators.Atari800Enabled) Then
                    ExecuteEmulatorInternal = Shell(GlobalVars.CurrentOptions.Emulators.VicePath & "atari800.exe " & _executable_name, AppWinStyle.NormalFocus)
                End If
            Case "atarilo"
                If (GlobalVars.CurrentOptions.Emulators.AltirraEnabled) Then
                    ExecuteEmulatorInternal = Shell(GlobalVars.CurrentOptions.Emulators.AltirraPath & "altirra.exe " & _executable_name, AppWinStyle.NormalFocus)
                ElseIf (GlobalVars.CurrentOptions.Emulators.Atari800Enabled) Then
                    ExecuteEmulatorInternal = Shell(GlobalVars.CurrentOptions.Emulators.VicePath & "atari800.exe " & _executable_name, AppWinStyle.NormalFocus)
                End If
        End Select

        Return ExecuteEmulatorInternal

    End Function

    Public Sub ExecuteEmulatorForTarget(_options As Options, _target As String)

        Dim binaryFileName As String = _options.Output.BinaryFilename
        Dim support As String = SupportForTarget(_target, _options.Output)

        If binaryFileName = "" Then
            MsgBox("Cannot execute program since the output file name is undefined.", vbOKOnly, "CANNOT RUN EXECUTABLE")
            Exit Sub
        End If

        binaryFileName = binaryFileName.Replace("{target}", _target)
        binaryFileName = binaryFileName.Replace("{support}", support)

        ExecuteEmulatorInternal(_options.IDE.RootPath & "\" & binaryFileName, _target)

    End Sub

    Public Sub ExecuteEmulatorFolderForTarget(_folder_entry As FolderEntry, _target As String)

        ExecuteEmulatorForTarget(_folder_entry.CurrentOptions, _target)

    End Sub
End Module
