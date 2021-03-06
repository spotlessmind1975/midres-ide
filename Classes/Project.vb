﻿Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class Project

    Implements IXmlSerializable

    Private _name As String
    Private _description As String
    Private _folders As Collection = New Collection
    Private _rootPath As String

    Private _currentOptions As Options
    Public Property CurrentOptions As Options
        Get
            Return _currentOptions
        End Get
        Set(value As Options)
            _currentOptions = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
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

    Public Property RootPath As String
        Get
            Return _rootPath
        End Get
        Set(value As String)
            _rootPath = value
        End Set
    End Property

    Public Sub New(name As String, Optional description As String = "")
        _name = name
        _description = description
        _folders = New Collection
        _currentOptions = New Options
    End Sub

    Public Sub New()

    End Sub
    Public Sub ReadXml(reader As XmlReader) Implements IXmlSerializable.ReadXml

        If Not reader.IsEmptyElement Then

            reader.ReadStartElement()
            reader.MoveToContent()

            If Not reader.IsEmptyElement Then
                While reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None
                    While reader.NodeType = System.Xml.XmlNodeType.Whitespace
                        reader.Read()
                    End While

                    If reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None Then
                        Select Case reader.Name
                            Case "Name"
                                _name = reader.ReadElementContentAsString()
                            Case "Description"
                                _description = reader.ReadElementContentAsString()
                            Case "Folder"
                                Dim pe As FolderEntry = New FolderEntry
                                pe.ReadXml(reader)
                                _folders.Add(pe, pe.GetHashCode())
                            Case "Options"
                                Dim pe As Options = New Options
                                pe.ReadXml(reader)
                                _currentOptions = pe
                            Case "Path"
                                reader.ReadElementContentAsString()
                            Case Else
                                If reader.NodeType = XmlNodeType.Text Then
                                    reader.ReadContentAsString()
                                Else
                                    reader.ReadElementContentAsString()
                                End If
                        End Select
                    End If
                End While
            End If

            If reader.NodeType <> System.Xml.XmlNodeType.None Then
                reader.ReadEndElement()
            End If

        Else
            reader.Read()
        End If

    End Sub

    Public Sub WriteXml(writer As XmlWriter) Implements IXmlSerializable.WriteXml
        writer.WriteStartElement("Name")
        writer.WriteString(_name)
        writer.WriteEndElement()
        writer.WriteStartElement("Description")
        writer.WriteString(_name)
        writer.WriteEndElement()
        For i = 1 To _folders.Count
            writer.WriteStartElement("Folder")
            DirectCast(_folders(i), FolderEntry).WriteXml(writer)
            writer.WriteEndElement()
        Next
        writer.WriteStartElement("Options")
        _currentOptions.WriteXml(writer)
        writer.WriteEndElement()
    End Sub

    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Throw New NotImplementedException()
    End Function

    Public Sub NormalizePaths()
        For Each folder In Folders
            folder.NormalizePaths()
        Next
    End Sub

    Public Function ShallowClone() As Project
        Return DirectCast(Me.MemberwiseClone(), Project)
    End Function

    Public Function DeepClone() As Project

        Dim p As Project = DirectCast(Me.MemberwiseClone(), Project)
        p._folders.Clear()

        For Each f In p._folders
            Dim folderCloned As FolderEntry = f.DeepClone()
            p._folders.Add(folderCloned, folderCloned.GetHashCode())
        Next

        p._currentOptions = _currentOptions.DeepClone()

        Return p
    End Function

    Public Function FindFolderByHash(_hashcode As String) As FolderEntry

        For Each folder In _folders
            Dim found As FolderEntry = folder.FindFolderByHash(_hashcode)
            If Not (found Is Nothing) Then
                Return found
            End If
        Next

        Return Nothing

    End Function

    Public Sub Resolve()

        For Each folder In _folders
            folder.Resolve(Me)
        Next

    End Sub

    Public Function GetFoldersByKind(_kinds As Collection) As Collection

        Dim result As Collection = New Collection

        For Each k In _kinds
            For Each folder In _folders
                Dim tmp As Collection = folder.GetFoldersByKind(k)
                For Each f In tmp
                    result.Add(f)
                Next
            Next
        Next

        Return result

    End Function

End Class
