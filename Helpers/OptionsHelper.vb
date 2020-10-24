Imports System.IO
Imports System.Xml.Serialization

Module OptionsHelper

    Public Sub LoadOptions()

        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\MIDRES-IDE"

        Try
            MkDir(path)
        Catch i As IOException

        End Try

        Try
            Dim fc As String = My.Computer.FileSystem.ReadAllText(path & "\options")

            Dim p As Integer = InStr(fc, "<Options")
            If p > 0 Then

                fc = Mid(fc, p)

                Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(Options))

                GlobalVars.CurrentOptions = xmlSerializer.Deserialize(New StringReader(fc))

            End If
        Catch e As FileNotFoundException

            GlobalVars.CurrentOptions = New Options

        End Try

        CompleteOptionsCC65()

    End Sub

    Public Sub CompleteOptionsCC65()

        Dim c As Collection = GlobalVars.CurrentOptions.CC65.Warnings

        If Not c.Contains("Unreachable code") Then
            Dim e = New CC65WarningEntry("Unreachable code", False)
            c.Add(e, "Unreachable code")
        End If


    End Sub
    Public Sub SaveOptions()
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\MIDRES-IDE"

        Try
            MkDir(path)
        Catch i As IOException

        End Try

        Dim xmlSerializer As XmlSerializer = New XmlSerializer(GetType(Options))

        Dim ms As MemoryStream = New MemoryStream()
        Dim sw As StreamWriter = New StreamWriter(ms, System.Text.Encoding.UTF8)

        xmlSerializer.Serialize(sw, GlobalVars.CurrentOptions)

        My.Computer.FileSystem.WriteAllBytes(path & "\options", ms.ToArray(), False)
    End Sub

    Public Sub UpdateOptions(_options_window As OptionsWindow, Optional _options As Options = Nothing)

        If GlobalVars.CurrentProject Is Nothing Then
            _options_window.ButtonFromProject.Visible = False
        Else
            _options_window.ButtonFromProject.Visible = True
        End If

        If (_options Is Nothing) Then
            _options = GlobalVars.CurrentOptions
            _options_window.ButtonRestore.Visible = True
        Else
            _options_window.ButtonRestore.Visible = False
        End If

        _options_window.CheckBoxALTIRRA.Checked = _options.Emulators.AltirraEnabled
        _options_window.TextBoxALTIRRAPath.Text = _options.Emulators.AltirraPath
        _options_window.CheckBoxATARI800.Checked = _options.Emulators.Atari800Enabled
        _options_window.TextBoxATARI800Path.Text = _options.Emulators.Atari800Path
        _options_window.CheckBoxYAPE.Checked = _options.Emulators.YapeEnabled
        _options_window.TextBoxYAPEPath.Text = _options.Emulators.YapePath
        _options_window.CheckBoxVICE.Checked = _options.Emulators.ViceEnabled
        _options_window.TextBoxVICEPath.Text = _options.Emulators.VicePath

        Dim c As Collection = _options.CC65.Warnings

        _options_window.CheckedListBoxCC65Warnings.Items.Clear()
        For i = 1 To c.Count
            _options_window.CheckedListBoxCC65Warnings.Items.Add(c(i).Pattern, c(i).Ignored)
        Next

        _options_window.CheckBoxPlus4.Checked = _options.CC65.Plus4
        _options_window.CheckBoxC16.Checked = _options.CC65.C16
        _options_window.CheckBoxVic20.Checked = _options.CC65.Vic20
        _options_window.CheckBoxVic2024.Checked = _options.CC65.Vic2024
        _options_window.CheckBoxC64.Checked = _options.CC65.C64
        _options_window.CheckBoxC128.Checked = _options.CC65.C128
        _options_window.CheckBoxAtari.Checked = _options.CC65.Atari
        _options_window.CheckBoxAtariLo.Checked = _options.CC65.Atarilo

        _options_window.TextBoxMakeFileName.Text = _options.Make.MakeFilename
        _options_window.RadioButtonStaticMakefile.Checked = _options.Make.DynamicMakefile
        _options_window.TextBoxAdditionalParams.Text = _options.Make.AdditionalParams
        _options_window.TextBoxActionBuild.Text = _options.Make.ActionBuild
        _options_window.TextBoxActionClean.Text = _options.Make.ActionClean

        _options_window.TextBoxBinaryFileName.Text = _options.Output.BinaryFilename
        _options_window.RadioButtonComplete.Checked = _options.Output.complete

    End Sub

    Public Sub ApplyOptions(_options_window As OptionsWindow, Optional _options As Options = Nothing)

        If (_options Is Nothing) Then
            _options = GlobalVars.CurrentOptions
        End If

        _options.Emulators.AltirraEnabled = _options_window.CheckBoxALTIRRA.Checked
        _options.Emulators.AltirraPath = _options_window.TextBoxALTIRRAPath.Text
        _options.Emulators.Atari800Enabled = _options_window.CheckBoxATARI800.Checked
        _options.Emulators.Atari800Path = _options_window.TextBoxATARI800Path.Text
        _options.Emulators.YapeEnabled = _options_window.CheckBoxYAPE.Checked
        _options.Emulators.YapePath = _options_window.TextBoxYAPEPath.Text
        _options.Emulators.ViceEnabled = _options_window.CheckBoxVICE.Checked
        _options.Emulators.VicePath = _options_window.TextBoxVICEPath.Text

        Dim c As Collection = _options.CC65.Warnings

        For i = 1 To _options_window.CheckedListBoxCC65Warnings.Items.Count
            If (_options_window.CheckedListBoxCC65Warnings.GetItemCheckState(i - 1) = CheckState.Checked) Then
                c(_options_window.CheckedListBoxCC65Warnings.Items(i - 1)).Ignored = True
            Else
                c(_options_window.CheckedListBoxCC65Warnings.Items(i - 1)).Ignored = False
            End If
        Next

        _options.CC65.Plus4 = _options_window.CheckBoxPlus4.Checked
        _options.CC65.C16 = _options_window.CheckBoxC16.Checked
        _options.CC65.Vic20 = _options_window.CheckBoxVic20.Checked
        _options.CC65.Vic2024 = _options_window.CheckBoxVic2024.Checked
        _options.CC65.C64 = _options_window.CheckBoxC64.Checked
        _options.CC65.C128 = _options_window.CheckBoxC128.Checked
        _options.CC65.Atari = _options_window.CheckBoxAtari.Checked
        _options.CC65.Atarilo = _options_window.CheckBoxAtariLo.Checked

        _options.Make.MakeFilename = _options_window.TextBoxMakeFileName.Text
        _options.Make.DynamicMakefile = _options_window.RadioButtonStaticMakefile.Checked
        _options.Make.AdditionalParams = _options_window.TextBoxAdditionalParams.Text
        _options.Make.ActionBuild = _options_window.TextBoxActionBuild.Text
        _options.Make.ActionClean = _options_window.TextBoxActionClean.Text

        _options.Output.BinaryFilename = _options_window.TextBoxBinaryFileName.Text
        _options.Output.complete = _options_window.RadioButtonComplete.Checked

        UpdateAllMenuEntries()

    End Sub

    Public Function showOptionsWindow(_options As Options, _title As String) As OptionsWindow
        Dim ow As OptionsWindow

        ow = New OptionsWindow With {
            .MdiParent = MainContainer,
            .CurrentOptions = _options
        }
        ow.Text = _title
        ow.Show()

        Return ow

    End Function

    Public Function ChooseBestOptions() As Options
        If Not (GlobalVars.CurrentProject Is Nothing) Then
            Return GlobalVars.CurrentProject.CurrentOptions
        ElseIf Not (GlobalVars.CurrentOptions Is Nothing) Then
            Return GlobalVars.CurrentOptions
        End If
        Return New Options
    End Function
End Module
