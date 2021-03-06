﻿Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class FileEntry

    Implements IXmlSerializable

    Private _persistentHashCode As Object
    Public Enum KindEnum
        NORMAL = 0
        GENERATED = 1
    End Enum

    Private _name As String
    Private _filename As String
    Private _description As String
    Private _kind As KindEnum

    Private _generated As OptionsGenerated
    Private _cc65 As OptionsCC65
    Private _other As OptionsOther


    Public Sub New(Optional filename As String = "", Optional name As String = "", Optional description As String = "")
        If filename = "" Then
            name = "(no name)"
        ElseIf name = "" Then
            name = filename
        End If

        _filename = filename
        _name = name
        _description = description
    End Sub

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Filename As String
        Get
            Return _filename
        End Get
        Set(value As String)
            _filename = value
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

    Public Property Generated As OptionsGenerated
        Get
            Return _generated
        End Get
        Set(value As OptionsGenerated)
            _generated = value
        End Set
    End Property

    Public Property CC65 As OptionsCC65
        Get
            Return _cc65
        End Get
        Set(value As OptionsCC65)
            _cc65 = value
        End Set
    End Property

    Public Property Other As OptionsOther
        Get
            Return _other
        End Get
        Set(value As OptionsOther)
            _other = value
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

    Public Sub ReadXml(reader As XmlReader) Implements IXmlSerializable.ReadXml

        reader.ReadStartElement()
        reader.MoveToContent()

        While reader.NodeType <> System.Xml.XmlNodeType.EndElement
            While reader.NodeType = System.Xml.XmlNodeType.Whitespace
                reader.Read()
            End While

            If reader.NodeType <> System.Xml.XmlNodeType.EndElement Then
                Select Case reader.Name
                    Case "PHC"
                        _persistentHashCode = reader.ReadElementContentAsString()
                    Case "Name"
                        _name = reader.ReadElementContentAsString()
                    Case "Filename"
                        _filename = reader.ReadElementContentAsString()
                    Case "Description"
                        _description = reader.ReadElementContentAsString()
                    Case "Kind"
                        _kind = reader.ReadElementContentAsInt()
                    Case "CurrentOptions", "Generated"
                        Dim pe As OptionsGenerated = New OptionsGenerated
                        pe.ReadXml(reader)
                        _generated = pe
                    Case "CC65"
                        Dim pe As OptionsCC65 = New OptionsCC65
                        pe.ReadXml(reader)
                        _cc65 = pe
                    Case "Other"
                        Dim pe As OptionsOther = New OptionsOther
                        pe.ReadXml(reader)
                        _other = pe
                    Case Else
                        reader.ReadElementContentAsString()
                End Select
            End If
        End While

        If reader.NodeType <> System.Xml.XmlNodeType.None Then
            reader.ReadEndElement()
        End If

    End Sub

    Public Sub WriteXml(writer As XmlWriter) Implements IXmlSerializable.WriteXml
        writer.WriteStartElement("PHC")
        writer.WriteString(_persistentHashCode)
        writer.WriteEndElement()
        writer.WriteStartElement("Name")
        writer.WriteString(_name)
        writer.WriteEndElement()
        writer.WriteStartElement("Filename")
        writer.WriteString(_filename)
        writer.WriteEndElement()
        writer.WriteStartElement("Description")
        writer.WriteString(_description)
        writer.WriteEndElement()
        writer.WriteStartElement("Kind")
        writer.WriteString(_kind)
        writer.WriteEndElement()
        If Not (_generated Is Nothing) Then
            writer.WriteStartElement("Generated")
            DirectCast(_generated, OptionsGenerated).WriteXml(writer)
            writer.WriteEndElement()
        End If
        If Not (_cc65 Is Nothing) Then
            writer.WriteStartElement("CC65")
            DirectCast(_cc65, OptionsCC65).WriteXml(writer)
            writer.WriteEndElement()
        End If
        If Not (_other Is Nothing) Then
            writer.WriteStartElement("Other")
            DirectCast(_other, OptionsOther).WriteXml(writer)
            writer.WriteEndElement()
        End If
    End Sub

    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Return Nothing
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim entry = TryCast(obj, FileEntry)
        Return entry IsNot Nothing AndAlso
               _name = entry._name AndAlso
               _description = entry._description AndAlso
               _filename = entry._filename
    End Function

    Public Overrides Function GetHashCode() As Integer
        If _persistentHashCode Is Nothing Then
            _persistentHashCode = (_name, _description, _filename, DateTime.Now().ToLongTimeString()).GetHashCode()
        End If
        Return _persistentHashCode
    End Function

    Public Function ShallowClone() As FileEntry
        Return DirectCast(Me.MemberwiseClone(), FileEntry)
    End Function

    Public Sub Resolve(_project As Project)

        If Not (_generated Is Nothing) Then
            _generated.Resolve(_project)
        End If

    End Sub

End Class
