Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class FileEntry

    Implements IXmlSerializable

    Private _persistentHashCode As Object
    Public Enum KindEnum
        NORMAL = 1
        GENERATED = 2
    End Enum

    Private _name As String
    Private _filename As String
    Private _description As String
    Private _kind As KindEnum

    Private _currentOptions As OptionsGenerated

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

    Public Property CurrentOptions As OptionsGenerated
        Get
            Return _currentOptions
        End Get
        Set(value As OptionsGenerated)
            _currentOptions = value
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
                    Case "Name"
                        _name = reader.ReadElementContentAsString()
                    Case "Filename"
                        _filename = reader.ReadElementContentAsString()
                    Case "Description"
                        _description = reader.ReadElementContentAsString()
                    Case "Kind"
                        _kind = reader.ReadElementContentAsInt()
                    Case "CurrentOptions"
                        Dim pe As OptionsGenerated = New OptionsGenerated
                        pe.ReadXml(reader)
                        _currentOptions = pe
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
        If Not (_currentOptions Is Nothing) Then
            writer.WriteStartElement("CurrentOptions")
            DirectCast(_currentOptions, OptionsGenerated).WriteXml(writer)
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

        If Not (_currentOptions Is Nothing) Then
            _currentOptions.Resolve(_project)
        End If

    End Sub

End Class
