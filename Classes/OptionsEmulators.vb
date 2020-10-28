Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class OptionsEmulators

    Implements IXmlSerializable

    Private _viceEnabled As Boolean
    Private _vicePath As String
    Private _altirraEnabled As Boolean
    Private _altirraPath As String
    Private _atari800Enabled As Boolean
    Private _atari800Path As String
    Private _yapeEnabled As Boolean
    Private _yapePath As String

    Public Sub New()

    End Sub

    Public Property ViceEnabled As Boolean
        Get
            Return _viceEnabled
        End Get
        Set(value As Boolean)
            _viceEnabled = value
        End Set
    End Property

    Public Property VicePath As String
        Get
            Return _vicePath
        End Get
        Set(value As String)
            _vicePath = value
        End Set
    End Property

    Public Property AltirraEnabled As Boolean
        Get
            Return _altirraEnabled
        End Get
        Set(value As Boolean)
            _altirraEnabled = value
        End Set
    End Property

    Public Property AltirraPath As String
        Get
            Return _altirraPath
        End Get
        Set(value As String)
            _altirraPath = value
        End Set
    End Property

    Public Property Atari800Enabled As Boolean
        Get
            Return _atari800Enabled
        End Get
        Set(value As Boolean)
            _atari800Enabled = value
        End Set
    End Property

    Public Property Atari800Path As String
        Get
            Return _atari800Path
        End Get
        Set(value As String)
            _atari800Path = value
        End Set
    End Property

    Public Property YapeEnabled As Boolean
        Get
            Return _yapeEnabled
        End Get
        Set(value As Boolean)
            _yapeEnabled = value
        End Set
    End Property

    Public Property YapePath As String
        Get
            Return _yapePath
        End Get
        Set(value As String)
            _yapePath = value
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
                    Case "ViceEnabled"
                        _viceEnabled = reader.ReadElementContentAsBoolean()
                    Case "VicePath"
                        _vicePath = reader.ReadElementContentAsString()
                    Case "AltirraEnabled"
                        _altirraEnabled = reader.ReadElementContentAsBoolean()
                    Case "AltirraPath"
                        _altirraPath = reader.ReadElementContentAsString()
                    Case "Atari800Enabled"
                        _atari800Enabled = reader.ReadElementContentAsBoolean()
                    Case "Atari800Path"
                        _atari800Path = reader.ReadElementContentAsString()
                    Case "YapeEnabled"
                        _yapeEnabled = reader.ReadElementContentAsBoolean()
                    Case "YapePath"
                        _yapePath = reader.ReadElementContentAsString()
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
        writer.WriteStartElement("ViceEnabled")
        If (_viceEnabled) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("VicePath")
        writer.WriteString(_vicePath)
        writer.WriteEndElement()

        writer.WriteStartElement("AltirraEnabled")
        If (_altirraEnabled) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("AltirraPath")
        writer.WriteString(_altirraPath)
        writer.WriteEndElement()

        writer.WriteStartElement("Atari800Enabled")
        If (_atari800Enabled) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("Atari800Path")
        writer.WriteString(_atari800Path)
        writer.WriteEndElement()

        writer.WriteStartElement("YapeEnabled")
        If (_yapeEnabled) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("YapePath")
        writer.WriteString(_yapePath)
        writer.WriteEndElement()

    End Sub

    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Return Nothing
    End Function

    Public Function ShallowClone() As OptionsEmulators
        Return DirectCast(Me.MemberwiseClone(), OptionsEmulators)
    End Function

    Public Function DeepClone() As OptionsEmulators
        Return ShallowClone()
    End Function

End Class
