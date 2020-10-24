Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class SearchResult

    Implements IXmlSerializable

    Private _filename As String
    Private _line As Integer
    Private _content As String
    Private _text As String
    Private _start As String
    Private _size As Integer

    Public Sub New(fileName As String, line As Integer, content As String, text As String, start As Integer, size As Integer)
        _filename = fileName
        _line = line
        _content = content
        _text = text
        _start = start
        _size = size
    End Sub

    Public Sub New()

    End Sub

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

    Public ReadOnly Property Content As Object
        Get
            Return _content
        End Get
    End Property

    Public ReadOnly Property Text As Object
        Get
            Return _text
        End Get
    End Property

    Public ReadOnly Property Size As Object
        Get
            Return _size
        End Get
    End Property

    Public ReadOnly Property Start As Object
        Get
            Return _start
        End Get
    End Property

    Public Sub ReadXml(reader As XmlReader) Implements IXmlSerializable.ReadXml

        While reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None
            While reader.NodeType = System.Xml.XmlNodeType.Whitespace
                reader.Read()
            End While

            If reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None Then
                Select Case reader.Name
                    Case "FileName"
                        _filename = reader.ReadElementContentAsString()
                    Case "Line"
                        _line = reader.ReadElementContentAsInt()
                    Case "Text"
                        _text = reader.ReadElementContentAsString()
                    Case "Start"
                        _start = reader.ReadElementContentAsInt()
                    Case "Size"
                        _size = reader.ReadElementContentAsInt()
                    Case Else
                        reader.Read()
                End Select
            End If
        End While

        If reader.NodeType <> System.Xml.XmlNodeType.None Then
            reader.ReadEndElement()
        End If

    End Sub

    Public Sub WriteXml(writer As XmlWriter) Implements IXmlSerializable.WriteXml
        writer.WriteStartElement("FileName")
        writer.WriteString(_filename)
        writer.WriteEndElement()
        writer.WriteStartElement("Line")
        writer.WriteString(_line)
        writer.WriteEndElement()
        writer.WriteStartElement("Text")
        writer.WriteString(_text)
        writer.WriteEndElement()
        writer.WriteStartElement("Start")
        writer.WriteString(_start)
        writer.WriteEndElement()
        writer.WriteStartElement("Size")
        writer.WriteString(_size)
        writer.WriteEndElement()
    End Sub

    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Return Nothing
    End Function

    Public Function ShallowClone() As SearchResult
        Return DirectCast(Me.MemberwiseClone(), SearchResult)
    End Function

    Public Function DeepClone() As SearchResult
        Return ShallowClone()
    End Function

End Class
