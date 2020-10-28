Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class FileEntry

    Implements IXmlSerializable

    Private _name As String
    Private _filename As String
    Private _description As String

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

    Public Sub ReadXml(reader As XmlReader) Implements IXmlSerializable.ReadXml

        reader.ReadStartElement()
        reader.MoveToContent()

        While reader.NodeType <> System.Xml.XmlNodeType.EndElement
            While reader.NodeType = System.Xml.XmlNodeType.Whitespace
                reader.Read()
            End While

            If reader.NodeType <> System.Xml.XmlNodeType.EndElement Then
                Select Case reader.Name
                    Case "Name"
                        _name = reader.ReadElementContentAsString()
                    Case "Filename"
                        _filename = reader.ReadElementContentAsString()
                    Case "Description"
                        _description = reader.ReadElementContentAsString()
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
        writer.WriteStartElement("Filename")
        writer.WriteString(_filename)
        writer.WriteEndElement()
        writer.WriteStartElement("Description")
        writer.WriteString(_description)
        writer.WriteEndElement()
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
        Return (_name, _description, _filename).GetHashCode()
    End Function

    Public Function ShallowClone() As FileEntry
        Return DirectCast(Me.MemberwiseClone(), FileEntry)
    End Function

End Class
