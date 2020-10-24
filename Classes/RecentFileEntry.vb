Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class RecentFileEntry

    Implements IXmlSerializable

    Private _filename As String
    Private _name As String

    Public Sub New(fileName As String, name As String)
        _filename = fileName
    End Sub

    Public Sub New()

    End Sub

    Public ReadOnly Property Filename As Object
        Get
            Return _filename
        End Get
    End Property

    Public ReadOnly Property Name As Object
        Get
            Return _name
        End Get
    End Property
    Public Sub ReadXml(reader As XmlReader) Implements IXmlSerializable.ReadXml

        While reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None
            While reader.NodeType = System.Xml.XmlNodeType.Whitespace
                reader.Read()
            End While

            If reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None Then
                Select Case reader.Name
                    Case "Name"
                        _name = reader.ReadElementContentAsString()
                    Case "FileName"
                        _filename = reader.ReadElementContentAsString()
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
        writer.WriteStartElement("Name")
        writer.WriteString(_name)
        writer.WriteEndElement()
        writer.WriteStartElement("FileName")
        writer.WriteString(_filename)
        writer.WriteEndElement()
    End Sub

    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Return Nothing
    End Function

    Public Function ShallowClone() As RecentFileEntry
        Return DirectCast(Me.MemberwiseClone(), RecentFileEntry)
    End Function

    Public Function DeepClone() As RecentFileEntry
        Return ShallowClone()
    End Function

End Class
