Public Class GlobalVars

    Public Shared OpenedSourceEditors As Collection = New Collection

    Public Shared RecentOpenedFiles As RecentFileCollection = New RecentFileCollection

    Public Shared RecentOpenedProjects As RecentFileCollection = New RecentFileCollection

    Public Shared ErrorOutput As ErrorOutputCollection = New ErrorOutputCollection

    Public Shared CurrentFolder As FolderEntry
    Public Shared CurrentFolderNode As TreeNode

    Public Shared CurrentOptions As Options = New Options

    Public Shared SearchResultCollection As Collection = New Collection

    Public Shared LastOpenedFilePath As String = ""

    Public Shared LastExtensionUsed As Integer = 0

    Public Shared CurrentProject As Project

    Public Shared CKeywords = "break case catch checked continue default do else extern for goto if new NULL sizeof switch while"

    Public Shared FunctionsAndDataTypes = ""

End Class
