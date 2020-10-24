Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class OptionsIDE

    Implements IXmlSerializable

    Private _rootPath As String

    Private _sourcePath As String

    Private _dataPath As String

    Private _exePath As String

    Public Sub New()

    End Sub

    Public Property RootPath As String
        Get
            Return _rootPath
        End Get
        Set(value As String)
            _rootPath = value
        End Set
    End Property

    Public Property SourcePath As String
        Get
            Return _sourcePath
        End Get
        Set(value As String)
            _sourcePath = value
        End Set
    End Property

    Public Property DataPath As String
        Get
            Return _dataPath
        End Get
        Set(value As String)
            _dataPath = value
        End Set
    End Property

    Public Property ExePath As String
        Get
            Return _exePath
        End Get
        Set(value As String)
            _exePath = value
        End Set
    End Property
    Public Sub ReadXml(reader As XmlReader) Implements IXmlSerializable.ReadXml

        While reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None
            While reader.NodeType = System.Xml.XmlNodeType.Whitespace
                reader.Read()
            End While

            If reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None Then
                Select Case reader.Name
                    Case "RootPath"
                        _rootPath = reader.ReadElementContentAsString()
                    Case "SourcePath"
                        _sourcePath = reader.ReadElementContentAsString()
                    Case "DataPath"
                        _dataPath = reader.ReadElementContentAsString()
                    Case "ExePath"
                        _exePath = reader.ReadElementContentAsString()
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
        writer.WriteStartElement("RootPath")
        writer.WriteString(_rootPath)
        writer.WriteEndElement()
        writer.WriteStartElement("SourcePath")
        writer.WriteString(_sourcePath)
        writer.WriteEndElement()
        writer.WriteStartElement("DataPath")
        writer.WriteString(_dataPath)
        writer.WriteEndElement()
        writer.WriteStartElement("ExePath")
        writer.WriteString(_exePath)
        writer.WriteEndElement()
    End Sub

    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Return Nothing
    End Function

    Public Function ShallowClone() As OptionsIDE
        Return DirectCast(Me.MemberwiseClone(), OptionsIDE)
    End Function

    Public Function DeepClone() As OptionsIDE
        Return ShallowClone()
    End Function

End Class
