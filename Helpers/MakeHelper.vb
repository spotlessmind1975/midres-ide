Imports System.IO
Imports System.Text.RegularExpressions

Module MakeHelper

    Public Function SupportForTarget(_target As String, _output As OptionsMake) As String

        Dim support As String = "prg"

        If _output.Complete Then
            Select Case _target
                Case "c16"
                    support = "d64"
                Case "vic20"
                    support = "d64"
                Case "vic2024"
                    support = "d64"
                Case "c64"
                    support = "d64"
                Case "c128"
                    support = "d64"
                Case "plus4"
                    support = "d64"
                Case "atari"
                    support = "atr"
                Case "atarilo"
                    support = "atr"
            End Select
        Else
            support = _target
        End If

        Return support
    End Function

    Private Function MakeInternal(_working_directory As String, _action As String, _commandLine As String, _target As String) As String

        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("make.exe", _commandLine & " target=" & _target & " " & _action) With {
            .UseShellExecute = False,
            .RedirectStandardOutput = True,
            .RedirectStandardError = True,
            .WorkingDirectory = _working_directory
        }
        oProcess.StartInfo = oStartInfo

        Dim sOutputError As String = ""

        AddHandler oProcess.ErrorDataReceived, New DataReceivedEventHandler(Sub(s, e)
                                                                                sOutputError &= e.Data & vbCrLf
                                                                            End Sub)
        oProcess.Start()
        oProcess.BeginOutputReadLine()
        oProcess.BeginErrorReadLine()
        oProcess.WaitForExit()

        MakeInternal = sOutputError

    End Function

    Public Sub MakeFileForTargetInternal(_working_directory As String, _binary_filename As String, _commandLine As String, _target As String, _options As Options, _executable As Boolean)

        Dim actionBuild As String = _options.Make.ActionBuild
        Dim actionClean As String = _options.Make.ActionClean

        ClearAllMarkers()

        ClearErrorOutput()

        MakeInternal(_working_directory, actionClean, _commandLine, _target)

        Dim errorString = MakeInternal(_working_directory, actionBuild, _commandLine, _target)

        If ParseMakeErrors(_working_directory, errorString, _options.CC65) = 0 Then
            If (File.Exists(_binary_filename)) Then
                If _executable Then
                    If MsgBox("Program has been built for " & _target & "." & vbCrLf & "Run it?", vbYesNo, "SUCCESSFUL COMPILATION") = vbYes Then
                        ExecuteEmulatorInternal(_options, _binary_filename, _target)
                    End If
                Else
                    MsgBox("Library has been built for " & _target & ".", vbOKOnly, "SUCCESSFUL MAKE")
                End If
            Else
                MsgBox("Program has NOT been built for " & _target & ".", vbOKOnly, "COMPILATION FAILED")
            End If
        End If
    End Sub
    Public Function ParseMakeErrors(_working_directory As String, _output As String, _options As OptionsCC65) As Integer

        ClearErrorOutput()

        UpdateErrorOutput(MainContainer)

        Dim partCounts As Integer = 0
        Dim parts() = _output.Split(vbCrLf)

        For Each part In parts
            Dim compiler As Boolean = False
            Dim warning As Integer = 0
            Dim linker As Boolean = False
            If (Trim(part) <> "") Then

                If (InStr(part, "Warning:")) Then
                    warning = 1
                End If
                If (InStr(part, "Error:")) Then
                    warning = 2
                End If
                If (InStr(part, "ld65: ")) Then
                    linker = True
                End If
                If (InStr(part, "cc65.exe ")) Then
                    warning = 2
                    compiler = True
                End If
                If (warning > 0) Then

                    Dim rx As Regex

                    If (linker) Then
                        rx = New Regex("ld65: [^:]+: ([^\(]+)\(([0-9]+)\): (.*)", RegexOptions.Compiled Or RegexOptions.IgnoreCase)
                    Else
                        rx = New Regex("([^\(]+)\(([0-9]+)\): (.*)", RegexOptions.Compiled Or RegexOptions.IgnoreCase)
                    End If

                    Dim matches As MatchCollection = rx.Matches(part)

                    For Each match As Match In matches

                        Dim groups As GroupCollection = match.Groups

                        Dim fileName = Path.GetFullPath((_working_directory & "\" & groups.Item(1).Value).Replace(vbCrLf, "").Replace(vbLf, ""))
                        Dim lineNumber = groups.Item(2).Value
                        Dim message = groups.Item(3).Value

                        If (warning = 1 And _options.IgnoredWarning(message)) Then
                            Continue For
                        End If

                        partCounts += 1

                        Dim sourceEditor = OpenFileEx(fileName, MainContainer)

                        Dim scintilla = sourceEditor.ScintillaSource

                        AddErrorOutput(fileName, lineNumber, message, warning, FocusOnFilenameAndLine(fileName, lineNumber, MainContainer, warning))

                    Next

                Else
                    AddErrorOutput("", 0, part, 0, 0)
                End If

            End If

        Next

        If (partCounts > 0) Then
            UpdateErrorOutput(MainContainer)
        End If

        ParseMakeErrors = partCounts

    End Function

    Public Sub MakeLibraryFolderForTarget(_folder_entry As FolderEntry, _target As String)

        Dim options As Options = _folder_entry.CurrentOptions

        If options Is Nothing Then
            options = GlobalVars.CurrentProject.CurrentOptions
            If options Is Nothing Then
                options = GlobalVars.CurrentOptions
            End If
        End If

        Dim makeFileName As String = options.Make.MakeFilename
        Dim binaryFileName As String = options.Make.BinaryFilename
        Dim additionalParams As String = options.Make.AdditionalParams

        If binaryFileName = "" Then
            MsgBox("Cannot make library since the output file name is undefined.", vbOKOnly, "CANNOT MAKE LIBRARY")
            Exit Sub
        End If

        binaryFileName = binaryFileName.Replace("{target}", _target)

        Select Case options.Make.Kind
            Case OptionsMake.KindGeneration.STATICAL
                MakeFileForTargetInternal(Path.GetDirectoryName(GetFullPathForElement(makeFileName)), GetFullPathForElement(binaryFileName), additionalParams, _target, options, False)
            Case OptionsMake.KindGeneration.DYNAMICAL
                MsgBox(GenerateMakefile(binaryFileName, _folder_entry, _target))
            Case OptionsMake.KindGeneration.INTERNAL

        End Select

    End Sub

    Public Sub MakeExecutableFolderForTarget(_folder_entry As FolderEntry, _target As String)

        Dim options As Options = _folder_entry.CurrentOptions

        If options Is Nothing Then
            options = GlobalVars.CurrentProject.CurrentOptions
            If options Is Nothing Then
                options = GlobalVars.CurrentOptions
            End If
        End If

        Dim makeFileName As String = options.Make.MakeFilename
        Dim binaryFileName As String = options.Make.BinaryFilename
        Dim additionalParams As String = options.Make.AdditionalParams
        Dim executableName As String

        Dim support As String = SupportForTarget(_target, options.Make)

        If binaryFileName = "" Then
            MsgBox("Cannot make executable since the output file name is undefined.", vbOKOnly, "CANNOT MAKE EXECUTABLE")
            Exit Sub
        End If

        binaryFileName = binaryFileName.Replace("{target}", _target)
        binaryFileName = binaryFileName.Replace("{support}", support)

        Select Case options.Make.Kind
            Case OptionsMake.KindGeneration.STATICAL
                MakeFileForTargetInternal(Path.GetDirectoryName(GetFullPathForElement(makeFileName)), GetFullPathForElement(binaryFileName), additionalParams, _target, options, True)
            Case OptionsMake.KindGeneration.DYNAMICAL
                MsgBox(GenerateMakefile(binaryFileName, _folder_entry, _target))
            Case OptionsMake.KindGeneration.INTERNAL

        End Select



    End Sub

    Private Function GenerateCompileCommandLine(_working_directory As String, _source_filename As String, _target_filename As String, _target As String, _options As OptionsCC65) As String

        Dim commandLine As String = _source_filename

        commandLine &= " --target " & _target
        If _options.AllCDecl Then
            commandLine &= " --all-cdecl"
        End If
        If _options.StaticLocals Then
            commandLine &= " --static-locals"
        End If
        For Each symbol In _options.Symbols
            commandLine &= " -D" & symbol
        Next
        For Each includeDir In _options.IncludeDirs
            commandLine &= " --include-dir " & includeDir
        Next
        If _options.OptimizeCode Then
            commandLine &= " -O"
        End If
        If _options.OptimizeCodeInline Then
            commandLine &= " -Oi"
        End If
        If _options.RegisterVars Then
            commandLine &= " --register-vars"
        End If
        If _options.InlineFunctions Then
            commandLine &= " --eagerly-inline-funcs"
        ElseIf _options.InlineStdFunctions Then
            commandLine &= " --inline-stdfuncs"
        End If
        If _options.AddSource Then
            commandLine &= " --add-source"
        End If
        If _options.SuppressWarnings Then
            commandLine &= " -W"
        End If
        If _options.DebugInfo Then
            commandLine &= " -W"
        End If
        If _options.SignedChars Then
            commandLine &= " --signed-chars"
        End If
        If Trim(_target_filename) <> "" Then
            commandLine &= " -o " & _target_filename
        End If
        If Trim(_options.BssName) <> "" Then
            commandLine &= " --bss-name " & _options.BssName
        End If
        If _options.CheckStack Then
            commandLine &= " --check-stack"
        End If
        If Trim(_options.CodeName) <> "" Then
            commandLine &= " --code-name " & _options.CodeName
        End If
        If _options.CodeSizeEnabled Then
            commandLine &= " --code-size " & _options.CodeSize
        End If
        If _options.Cpu65C02 Then
            commandLine &= " --cpu 65C02"
        End If
        If _options.CreateDep Then
            commandLine &= " --create-dep " & _options.CreateDepFilename
        End If
        If _options.CreateFullDep Then
            commandLine &= " --create-full-dep " & _options.CreateFullDepFilename
        End If
        If (_options.CreateDep Or _options.CreateFullDep) And _options.DepTarget Then
            commandLine &= " --dep-target " & _options.DepTargetFilename
        End If
        If Trim(_options.DataName) <> "" Then
            commandLine &= " --data-name " & _options.DataName
        End If
        If _options.ForgetIncPath Then
            commandLine &= " --forget-inc-paths"
        End If
        If _options.RegisterSpaceEnabled Then
            commandLine &= " --register-space " & _options.RegisterSpace
        End If
        If Trim(_options.RodataName) <> "" Then
            commandLine &= " --rodata-name " & _options.RodataName
        End If
        If _options.StandardLanguage Then
            commandLine &= " --standard " & LCase(_options.StandardLanguage.ToString())
        End If
        If _options.WritableStrings Then
            commandLine &= " --writable-strings"
        End If

        Return commandLine

    End Function

    Private Function CompileInternal(_working_directory As String, _source_filename As String, _target_filename As String, _target As String, _options As OptionsCC65) As String

        Dim CommandLine As String = GenerateCompileCommandLine(_working_directory, _source_filename, _target_filename, _target, _options)

        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("cc65.exe", commandLine) With {
            .UseShellExecute = False,
            .RedirectStandardOutput = True,
            .RedirectStandardError = True,
            .WorkingDirectory = _working_directory
        }
        oProcess.StartInfo = oStartInfo

        Dim sOutputError As String = ""

        AddHandler oProcess.ErrorDataReceived, New DataReceivedEventHandler(Sub(s, e)
                                                                                sOutputError &= e.Data & vbCrLf
                                                                            End Sub)
        oProcess.Start()
        oProcess.BeginOutputReadLine()
        oProcess.BeginErrorReadLine()
        oProcess.WaitForExit()

        CompileInternal = sOutputError

    End Function

    Public Sub CompileFileForTargetInternal(_working_directory As String, _source_file As String, _target_file As String, _target As String, _options As OptionsCC65)

        ClearAllMarkers()

        ClearErrorOutput()

        Try
            MkDir(_working_directory)
        Catch ex As Exception

        End Try

        Dim errorString = CompileInternal(_working_directory, _source_file, _target_file, _target, _options)

        If ParseMakeErrors(_working_directory, errorString, _options) = 0 Then
            If (File.Exists(_target_file)) Then
                MsgBox("Object has been built for " & _target & ".")
            Else
                MsgBox("Object  has NOT been built for " & _target & ".", vbOKOnly, "COMPILATION FAILED")
            End If
        End If
    End Sub

    Public Sub CompileObjectForTarget(_file_entry As FileEntry, _folder_entry As FolderEntry, _target As String)

        Dim options As OptionsCC65 = _file_entry.CC65

        If options Is Nothing Then
            options = GlobalVars.CurrentProject.CurrentOptions.CC65
            If options Is Nothing Then
                options = GlobalVars.CurrentOptions.CC65
            End If
        End If

        Dim sourceFileName As String = GetFullPathForElement(_file_entry.Filename, _folder_entry)

        Dim binaryFileName As String = options.OutputFile

        If binaryFileName = "" Then
            binaryFileName = _file_entry.Filename.Replace(".c", ".o")
        Else
            binaryFileName = binaryFileName.Replace("{target}", _target)
            binaryFileName = binaryFileName.Replace("{source}", _file_entry.Filename)
        End If

        CompileFileForTargetInternal(Path.GetDirectoryName(GetFullPathForElement(binaryFileName)), sourceFileName, GetFullPathForElement(binaryFileName), _target, options)

    End Sub

    Public Function GenerateMakefileRecursive(_folder As FolderEntry, _target As String, _objectFiles As Collection, _libraryFiles As Collection) As String

        Dim MakeFileContent As String = ""

        For Each folder In _folder.Folders
            Select Case folder.Kind
                Case FolderEntry.KindEnum.TILESET

                Case Else
                    MakeFileContent &= GenerateMakefileRecursive(folder, _target, _objectFiles, _libraryFiles)
            End Select
        Next

        For Each file In _folder.Files
            If file.Kind = FileEntry.KindEnum.GENERATED Then
                If Not (file.generated) Is Nothing Then
                    If file.generated.hasTarget(_target) Then
                        For Each folder In file.generated.Dependencies
                            MakeFileContent &= GenerateMakefile(file.filename, folder, _target)
                        Next
                        Select Case LCase(Path.GetExtension(file.filename))
                            Case ".lib"
                                _libraryFiles.Add(file.filename)
                        End Select
                    End If
                Else
                    Select Case LCase(Path.GetExtension(file.filename))
                        Case ".lib"
                            _libraryFiles.Add(file.filename)
                    End Select
                End If

            Else
                Select Case LCase(Path.GetExtension(file.filename))
                    Case ".c"
                        Dim objectFileName As String = Nothing
                        Dim options As OptionsCC65 = file.cc65
                        If options Is Nothing Then
                            options = GlobalVars.CurrentProject.CurrentOptions.CC65
                            If options Is Nothing Then
                                options = GlobalVars.CurrentOptions.CC65
                            End If
                        End If

                        If (options Is Nothing) Then
                            objectFileName = file.Filename.Replace(".c", ".o")
                        Else
                            If options.hasTarget(_target) Then

                                objectFileName = options.OutputFile

                                If objectFileName = "" Then
                                    objectFileName = file.Filename.Replace(".c", ".o")
                                Else
                                    objectFileName = objectFileName.Replace("{target}", _target)
                                    objectFileName = objectFileName.Replace("{source}", file.Filename.Replace(".c", ".o"))
                                End If
                            End If
                        End If

                        If Not (objectFileName Is Nothing) Then
                            MakeFileContent &= objectFileName & ":" & vbTab & file.filename & vbCrLf
                            MakeFileContent &= vbTab & "cc65 " & GenerateCompileCommandLine("", file.filename, objectFileName, _target, options) & vbCrLf
                            _objectFiles.Add(objectFileName)
                        End If
                    Case ".h"
                    Case ".cfg"
                End Select
            End If
        Next

        Return MakeFileContent
    End Function

    Public Function GenerateMakefile(_output_file As String, _folder As FolderEntry, _target As String) As String

        Dim objectFiles As Collection = New Collection()
        Dim libraryFiles As Collection = New Collection()

        Dim MakeFileContent As String = GenerateMakefileRecursive(_folder, _target, objectFiles, libraryFiles)

        MakeFileContent &= _output_file & ":" & vbTab
        For Each obj In objectFiles
            MakeFileContent &= obj & " "
        Next
        For Each xlib In libraryFiles
            MakeFileContent &= xlib & " "
        Next
        MakeFileContent &= vbCrLf

        If _folder.Kind = FolderEntry.KindEnum.LIBRARY Then
            MakeFileContent &= vbTab & "ar65.exe r " & _output_file & " "
            For Each obj In objectFiles
                MakeFileContent &= obj & " "
            Next
            For Each xlib In libraryFiles
                MakeFileContent &= xlib & " "
            Next
            MakeFileContent &= vbCrLf
        Else
            Dim ldFlags As String = ""
            MakeFileContent &= vbTab & "cl65.exe -t " & _target & " " & ldFlags & " -o " & _output_file & " "
            For Each obj In objectFiles
                MakeFileContent &= obj & " "
            Next
            For Each xlib In libraryFiles
                MakeFileContent &= xlib & " "
            Next
            MakeFileContent &= vbCrLf
        End If

        Return MakeFileContent
    End Function

End Module
