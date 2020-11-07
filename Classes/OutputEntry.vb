Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class OutputEntry

    Implements IXmlSerializable

    Public Enum LevelEnum
        TRACE = 0
        DEBUG = 1
        INFO = 2
        WARN = 3
        ERR = 4
        CRIT = 5
    End Enum

    Private _level As LevelEnum
    Private _filename As String
    Private _line As Integer
    Private _message As String
    Private _kind As Integer
    Private _marker As Integer

    Public Sub New(level As LevelEnum, fileName As String, line As Integer, message As String, kind As Integer, marker As Integer)
        _level = level
        _filename = fileName
        _line = line
        _message = message
        _kind = kind
        _marker = marker
    End Sub

    Public Sub New()

    End Sub

    Public ReadOnly Property Level As LevelEnum
        Get
            Return _level
        End Get
    End Property

    Public ReadOnly Property Filename As Object
        Get
            Return _filename
        End Get
    End Property

    Public ReadOnly Property Line As Object
        Get
            Return _line
        End Get
    End Property

    Public ReadOnly Property Message As Object
        Get
            Return _message
        End Get
    End Property

    Public ReadOnly Property Kind As Object
        Get
            Return _kind
        End Get
    End Property

    Public ReadOnly Property Marker As Object
        Get
            Return _marker
        End Get
    End Property

    Public Sub ReadXml(reader As XmlReader) Implements IXmlSerializable.ReadXml

        If Not reader.IsEmptyElement Then

            reader.ReadStartElement()
            reader.MoveToContent()

            While reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None
                While reader.NodeType = System.Xml.XmlNodeType.Whitespace
                    reader.Read()
                End While

                If reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None Then
                    Select Case reader.Name
                        Case "Level"
                            _level = reader.ReadElementContentAsInt()
                        Case "FileName"
                            _filename = reader.ReadElementContentAsString()
                        Case "Line"
                            _line = reader.ReadElementContentAsInt()
                        Case "Message"
                            _message = reader.ReadElementContentAsString()
                        Case "Kind"
                            _kind = reader.ReadElementContentAsInt()
                        Case "Marker"
                            _marker = reader.ReadElementContentAsInt()
                        Case Else
                            reader.ReadContentAsString()
                    End Select
                End If
            End While

            If reader.NodeType <> System.Xml.XmlNodeType.None Then
                reader.ReadEndElement()
            End If

        Else
            reader.Read()
        End If

    End Sub

    Public Sub WriteXml(writer As XmlWriter) Implements IXmlSerializable.WriteXml
        writer.WriteStartElement("Level")
        writer.WriteString(_level)
        writer.WriteEndElement()
        writer.WriteStartElement("FileName")
        writer.WriteString(_filename)
        writer.WriteEndElement()
        writer.WriteStartElement("Line")
        writer.WriteString(_line)
        writer.WriteEndElement()
        writer.WriteStartElement("Message")
        writer.WriteString(_message)
        writer.WriteEndElement()
        writer.WriteStartElement("Kind")
        writer.WriteString(_kind)
        writer.WriteEndElement()
        writer.WriteStartElement("Marker")
        writer.WriteString(_marker)
        writer.WriteEndElement()
    End Sub

    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Return Nothing
    End Function

    Public Function ShallowClone() As OutputEntry
        Return DirectCast(Me.MemberwiseClone(), OutputEntry)
    End Function

End Class
