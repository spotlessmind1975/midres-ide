Imports System.IO
Imports System.Text.RegularExpressions

Module TilesetHelper

    Public Function GenerateImage2TileCommandLine(_working_directory As String, _folder_entry As FolderEntry, _output_filename As String, Optional _bank_number As Integer = 0, Optional _header_file As String = Nothing, Optional _threshold_luminance As Integer = 16, Optional _multicolor As Boolean = False, Optional _reverse As Boolean = False) As String

        Dim CommandLine As String = ""

        For Each file In _folder_entry.Files
            CommandLine &= " -i " & GetFullPathForElement(file.filename, _folder_entry)
        Next
        CommandLine = CommandLine & " -o " & GetFullPathForElement(_output_filename)
        If _bank_number > 0 Then
            CommandLine &= " -b " & _bank_number
        End If
        If Not (_header_file Is Nothing) Then
            CommandLine &= " -g " & GetFullPathForElement(_header_file)
        End If
        If _threshold_luminance > 0 Then
            CommandLine &= " -l " & _threshold_luminance
        End If
        If _multicolor Then
            CommandLine &= " -m "
        End If
        If _reverse Then
            CommandLine &= " -r "
        End If

        Return CommandLine

    End Function
    Private Function Image2Tile(_working_directory As String, _folder_entry As FolderEntry, _output_filename As String, Optional _bank_number As Integer = 0, Optional _header_file As String = Nothing, Optional _threshold_luminance As Integer = 16, Optional _multicolor As Boolean = False, Optional _reverse As Boolean = False) As String

        Dim commandLine As String = GenerateImage2TileCommandLine(_working_directory, _folder_entry, _output_filename, _bank_number, _header_file, _threshold_luminance, _multicolor, _reverse)

        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("img2tile64.exe", commandLine) With {
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

        Return sOutputError

    End Function

    Public Function ParseImg2TileErrors(_working_directory As String, _output As String, _options As Options) As Integer

        ClearErrorOutput()

        UpdateErrorOutput(MainContainer)

        Dim partCounts As Integer = 0
        Dim parts() = _output.Split(vbCrLf)

        For Each part In parts
            Dim warning As Integer = 0
            Dim linker As Boolean = False
            If (Trim(part) <> "") Then

                If (InStr(part, "ERROR:")) Then
                    warning = 2
                End If
                If (warning > 0) Then

                    Dim rx As Regex

                    rx = New Regex("ERROR:([^:]*): (.*)", RegexOptions.Compiled Or RegexOptions.IgnoreCase)

                    Dim matches As MatchCollection = rx.Matches(part)

                    For Each match As Match In matches

                        Dim groups As GroupCollection = match.Groups

                        Dim fileName = Path.GetFullPath((_working_directory & "\" & groups.Item(1).Value).Replace(vbCrLf, "").Replace(vbLf, ""))
                        Dim message = groups.Item(2).Value

                        partCounts += 1

                        AddErrorOutput(fileName, 0, message, warning, 0)

                    Next

                Else
                    AddErrorOutput("", 0, part, 0, 0)
                End If

            End If
        Next

        If (partCounts > 0) Then
            UpdateErrorOutput(MainContainer)
        End If

        Return partCounts

    End Function

    Public Sub PrepareTilesetFolder(_folder_entry As FolderEntry)

        Dim options As Options = _folder_entry.CurrentOptions

        If options Is Nothing Then
            options = GlobalVars.CurrentProject.CurrentOptions
            If options Is Nothing Then
                options = GlobalVars.CurrentOptions
            End If
        End If

        Dim binaryFileName As String = options.Tileset.BinaryFilename
        Dim headerFileName As String = options.Tileset.HeaderFilename

        If binaryFileName = "" Then
            MsgBox("Cannot prepare tileset since the output file name is undefined.", vbOKOnly, "CANNOT PREPARE TILESET")
            Exit Sub
        End If

        File.Delete(GetFullPathForElement(binaryFileName))

        ClearAllMarkers()

        ClearErrorOutput()

        Dim errorString = Image2Tile(Path.GetDirectoryName(GetFullPathForElement(binaryFileName)), _folder_entry, binaryFileName, options.Tileset.BankNumber, headerFileName, options.Tileset.ThresholdLuminance, options.Tileset.Multicolor, options.Tileset.Reverse)

        If ParseImg2TileErrors(Path.GetDirectoryName(GetFullPathForElement(binaryFileName)), errorString, options) = 0 Then
            If (File.Exists(GetFullPathForElement(binaryFileName))) Then
                MsgBox("Tiles has been built.", vbOKOnly, "SUCCESSFUL PREPARE")
            Else
                MsgBox("Tiles has NOT been built.", vbOKOnly, "FAILED PREPARE")
            End If
        End If

    End Sub

End Module
