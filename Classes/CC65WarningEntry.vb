Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class CC65WarningEntry

    Implements IXmlSerializable

    Private _ignored As Boolean
    Private _pattern As String

    Public Sub New(pattern As String, ignored As Boolean)
        _pattern = pattern
        _ignored = ignored
    End Sub

    Public Sub New()

    End Sub

    Public ReadOnly Property Pattern As String
        Get
            Return _pattern
        End Get
    End Property

    Public Property Ignored As Boolean
        Get
            Return _ignored
        End Get
        Set(value As Boolean)
            _ignored = value
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
                    Case "Pattern"
                        _pattern = reader.ReadElementContentAsString()
                    Case "Ignored"
                        _ignored = reader.ReadElementContentAsBoolean()
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
        writer.WriteStartElement("Pattern")
        writer.WriteString(_pattern)
        writer.WriteEndElement()
        writer.WriteStartElement("Ignored")
        If (_ignored) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()
    End Sub

    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Return Nothing
    End Function

    Public Function ShallowClone() As CC65WarningEntry
        Return DirectCast(Me.MemberwiseClone(), CC65WarningEntry)
    End Function

End Class
