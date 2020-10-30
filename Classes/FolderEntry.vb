Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class FolderEntry

    Implements IXmlSerializable

    Private _currentOptions As Options

    Public Enum KindEnum
        FOLDER = 1
        LIBRARY = 2
        EXECUTABLE = 3
        TILESET = 4
    End Enum

    Private _name As String
    Private _description As String
    Private _path As String
    Private _kind As KindEnum
    Private _folders As Collection
    Private _files As Collection
    Private _opened As Boolean

    Public Sub New(path As String, Optional name As String = "", Optional description As String = "")
        _path = path
        _name = name
        _description = description
        _folders = New Collection
        _files = New Collection
    End Sub

    Public Sub New()
        _description = Description
        _folders = New Collection
        _files = New Collection
    End Sub

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Path As String
        Get
            Return _path
        End Get
        Set(value As String)
            _path = value
        End Set
    End Property

    Public Property Kind As KindEnum
        Get
            Return _kind
        End Get
        Set(value As KindEnum)
            _kind = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Public Property Folders As Collection
        Get
            Return _folders
        End Get
        Set(value As Collection)
            _folders = value
        End Set
    End Property

    Public Property Files As Collection
        Get
            Return _files
        End Get
        Set(value As Collection)
            _files = value
        End Set
    End Property

    Public Property CurrentOptions As Options
        Get
            Return _currentOptions
        End Get
        Set(value As Options)
            _currentOptions = value
        End Set
    End Property

    Public Property Opened As Boolean
        Get
            Return _opened
        End Get
        Set(value As Boolean)
            _opened = value
        End Set
    End Property

    Public Sub ReadXml(reader As XmlReader) Implements IXmlSerializable.ReadXml

        reader.ReadStartElement()
        reader.MoveToContent()

        While reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None
            While reader.NodeType = System.Xml.XmlNodeType.Whitespace
                reader.Read()
            End While

            If reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None Then
                Select Case reader.Name
                    Case "Name"
                        _name = reader.ReadElementContentAsString()
                    Case "Path"
                        _path = reader.ReadElementContentAsString()
                    Case "Description"
                        _description = reader.ReadElementContentAsString()
                    Case "Kind"
                        _kind = reader.ReadElementContentAsInt()
                    Case "CurrentOptions"
                        Dim pe As Options = New Options
                        pe.ReadXml(reader)
                        _currentOptions = pe
                    Case "Folder"
                        Dim pe As FolderEntry = New FolderEntry
                        pe.ReadXml(reader)
                        _folders.Add(pe, pe.GetHashCode())
                    Case "File"
                        Dim pe As FileEntry = New FileEntry
                        pe.ReadXml(reader)
                        _files.Add(pe, pe.GetHashCode())
                    Case "Opened"
                        _opened = reader.ReadElementContentAsBoolean()
                    Case Else
                        reader.ReadContentAsString()
                End Select
            End If
        End While

        If reader.NodeType <> System.Xml.XmlNodeType.None Then
            reader.ReadEndElement()
        End If

    End Sub

    Public Sub WriteXml(writer As XmlWriter) Implements IXmlSerializable.WriteXml
        writer.WriteStartElement("Name")
        writer.WriteString(_name)
        writer.WriteEndElement()
        writer.WriteStartElement("Path")
        writer.WriteString(_path)
        writer.WriteEndElement()
        writer.WriteStartElement("Description")
        writer.WriteString(_description)
        writer.WriteEndElement()
        writer.WriteStartElement("Kind")
        writer.WriteString(_kind)
        writer.WriteEndElement()
        If Not (_currentOptions Is Nothing) Then
            writer.WriteStartElement("CurrentOptions")
            DirectCast(_currentOptions, Options).WriteXml(writer)
            writer.WriteEndElement()
        End If
        For i = 1 To _folders.Count
            writer.WriteStartElement("Folder")
            DirectCast(_folders(i), FolderEntry).WriteXml(writer)
            writer.WriteEndElement()
        Next
        For i = 1 To _files.Count
            writer.WriteStartElement("File")
            DirectCast(_files(i), FileEntry).WriteXml(writer)
            writer.WriteEndElement()
        Next
        writer.WriteStartElement("Opened")
        If (_opened) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()
    End Sub

    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Return Nothing
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim entry = TryCast(obj, FolderEntry)
        Return entry IsNot Nothing AndAlso
               _name = entry._name AndAlso
               _description = entry._description
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return (_name, _description).GetHashCode()
    End Function

    Public Sub NormalizePaths()

        Dim parts
        parts = GetRootPath().Split("\")

        Dim partialPath As String = ""
        Dim replacePath As String = ""

        If InStr(_path, "\") > 0 Then
            For i = UBound(parts) To 0 Step -1
                partialPath = parts(0)
                For j = 1 To i
                    partialPath = partialPath & "\" & parts(j)
                Next
                If _path.Replace(partialPath & "\", "") <> _path Then
                    For j = i + 1 To UBound(parts)
                        replacePath = "..\" & replacePath
                    Next
                    _path = _path.Replace(partialPath & "\", replacePath)
                    Exit For
                End If
            Next
        Else
            partialPath = GetRootPath()
        End If

        parts = (partialPath & "\" & _path).Split("\")

        For Each folder In Folders
            folder.NormalizePaths()
        Next

        For Each file In Files
            replacePath = ""
            For i = UBound(parts) To 0 Step -1
                partialPath = parts(0)
                For j = 1 To i
                    partialPath = partialPath & "\" & parts(j)
                Next
                If file.filename.Replace(partialPath & "\", "") <> file.filename Then
                    For j = i + 1 To UBound(parts)
                        replacePath = "..\" & replacePath
                    Next
                    file.filename = file.filename.Replace(partialPath & "\", replacePath)
                    Exit For
                End If
            Next
        Next
    End Sub

    Public Function ShallowClone() As FolderEntry
        Return DirectCast(Me.MemberwiseClone(), FolderEntry)
    End Function

    Public Function DeepClone() As FolderEntry
        Dim fe As FolderEntry = DirectCast(Me.MemberwiseClone(), FolderEntry)
        fe._currentOptions = _currentOptions.DeepClone()
        Return fe
    End Function

    Public Function FindFolderByHash(_hashcode As String) As FolderEntry

        If Me.GetHashCode() = _hashcode Then
            Return Me
        End If

        For Each folder In _folders
            Dim found As FolderEntry = folder.FindFolderByHash(_hashcode)
            If Not (found Is Nothing) Then
                Return found
            End If
        Next

        Return Nothing

    End Function

    Public Sub Resolve(_project As Project)

        For Each folder In _folders
            folder.Resolve(_project)
        Next

        For Each file In _files
            file.Resolve(_project)
        Next

    End Sub

    Public Function GetFoldersByKind(_kind As FolderEntry.KindEnum) As Collection

        Dim result As Collection = New Collection

        If Me.Kind = _kind Then
            result.Add(Me)
        End If

        For Each folder In _folders
            Dim tmp As Collection = folder.GetFoldersByKind(_kind)
            For Each f In tmp
                result.Add(f)
            Next
        Next

        Return result

    End Function

    Public Sub InsertFileBefore(_target As FileEntry, _file As FileEntry)

        Dim c As Collection = New Collection

        For Each file In _files

            If file.Equals(_target) Then
                c.Add(_file, _file.GetHashCode())
            End If

            c.Add(file, file.GetHashCode())
        Next

        _files = c

    End Sub

End Class
