Imports System.IO

Module Library

    Public Function GetRootPath() As String
        If Not (GlobalVars.CurrentProject Is Nothing) Then
            Return GlobalVars.CurrentProject.RootPath
        Else
            Return GlobalVars.LastOpenedFilePath
        End If
    End Function

    Public Sub SetRootPath(_absolute_path As String)
        If Not (GlobalVars.CurrentProject Is Nothing) Then
            GlobalVars.CurrentProject.RootPath = _absolute_path
        Else
            GlobalVars.LastOpenedFilePath = _absolute_path
        End If
    End Sub

    Public Function GetFullPathForElement(_filename As String, Optional _element As FolderEntry = Nothing) As String

        Dim elementPath As String = ""

        If Not (_element Is Nothing) Then
            elementPath = (_element.Path & "\")
        End If

        Return Path.GetFullPath(GetRootPath() & "\" & elementPath & _filename)

    End Function
End Module
