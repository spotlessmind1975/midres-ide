﻿Imports System.IO
Imports System.Text.RegularExpressions

Module TilesetHelper

    Private Function Image2Tile(_working_directory As String, _input_filenames As Collection, _output_filename As String, Optional _bank_number As Integer = 0, Optional _debug As Boolean = False, Optional _header_file As String = Nothing, Optional _threshold_luminance As Integer = 16, Optional _multicolor As Boolean = False, Optional _reverse As Boolean = False, Optional _verbose As Boolean = False) As String

        Dim commandLine As String = ""

        For Each file In _input_filenames
            commandLine = commandLine & " -i " & file.filename
        Next
        commandLine = commandLine & " -o " & _output_filename
        If _bank_number > 0 Then
            commandLine = commandLine & " -b " & _bank_number
        End If
        If _debug Then
            commandLine = commandLine & " -d "
        End If
        If Not (_header_file Is Nothing) Then
            commandLine = commandLine & " -g " & _header_file
        End If
        If _threshold_luminance > 0 Then
            commandLine = commandLine & " -l " & _threshold_luminance
        End If
        If _multicolor Then
            commandLine = commandLine & " -m "
        End If
        If _reverse Then
            commandLine = commandLine & " -r "
        End If
        If _verbose Then
            commandLine = commandLine & " -v "
        End If

        MsgBox("img2tile64.exe " & commandLine & " !! " & _working_directory)

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
            AddErrorOutput("", 0, part, 0, 0)
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

        If binaryFileName = "" Then
            MsgBox("Cannot prepare tileset since the output file name is undefined.", vbOKOnly, "CANNOT PREPARE TILESET")
            Exit Sub
        End If

        File.Delete(binaryFileName)

        ClearAllMarkers()

        ClearErrorOutput()

        Dim errorString = Image2Tile(Path.GetDirectoryName(options.IDE.RootPath & "\" & _folder_entry.Path & "\" & binaryFileName), _folder_entry.Files, binaryFileName, options.Tileset.BankNumber, options.Tileset.Debug, options.Tileset.HeaderFilename, options.Tileset.ThresholdLuminance, options.Tileset.Multicolor, options.Tileset.Reverse, options.Tileset.Verbose)

        If ParseImg2TileErrors(Path.GetDirectoryName(options.IDE.RootPath & "\" & _folder_entry.Path & "\" & binaryFileName), errorString, options) = 0 Then
            If (File.Exists(options.IDE.RootPath & "\" & _folder_entry.Path & "\" & binaryFileName)) Then
                MsgBox("Tiles has been built.", vbOKOnly, "SUCCESSFUL PREPARE")
            Else
                MsgBox("Tiles has NOT been built.", vbOKOnly, "FAILED PREPARE")
            End If
        End If

    End Sub

End Module
