Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class OptionsMake

    Implements IXmlSerializable

    Private _makeFilename As String
    Private _dynamicMakefile As Boolean
    Private _additionalParams As String
    Private _actionBuild As String
    Private _actionClean As String
    Private _binaryFileName As String
    Private _complete As Boolean

    Public Property MakeFilename As String
        Get
            Return _makeFilename
        End Get
        Set(value As String)
            _makeFilename = value
        End Set
    End Property

    Public Property DynamicMakefile As String
        Get
            Return _dynamicMakefile
        End Get
        Set(value As String)
            _dynamicMakefile = value
        End Set
    End Property

    Public Property AdditionalParams As String
        Get
            Return _additionalParams
        End Get
        Set(value As String)
            _additionalParams = value
        End Set
    End Property


    Public Property ActionBuild As String
        Get
            Return _actionBuild
        End Get
        Set(value As String)
            _actionBuild = value
        End Set
    End Property

    Public Property ActionClean As String
        Get
            Return _actionClean
        End Get
        Set(value As String)
            _actionClean = value
        End Set
    End Property

    Public Property BinaryFilename As String
        Get
            Return _binaryFileName
        End Get
        Set(value As String)
            _binaryFileName = value
        End Set
    End Property

    Public Property Complete As Boolean
        Get
            Return _complete
        End Get
        Set(value As Boolean)
            _complete = value
        End Set
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
                        Case "MakeFileName"
                            _makeFilename = reader.ReadElementContentAsString()
                        Case "DynamicMakefile"
                            _dynamicMakefile = reader.ReadElementContentAsBoolean()
                        Case "AdditionalParams"
                            _additionalParams = reader.ReadElementContentAsString()
                        Case "ActionBuild"
                            _actionBuild = reader.ReadElementContentAsString()
                        Case "ActionClean"
                            _actionClean = reader.ReadElementContentAsString()
                        Case "BinaryFileName"
                            _binaryFileName = reader.ReadElementContentAsString()
                        Case "Complete"
                            _complete = reader.ReadElementContentAsBoolean()
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
        writer.WriteStartElement("MakeFileName")
        writer.WriteString(_makeFilename)
        writer.WriteEndElement()
        writer.WriteStartElement("DynamicMakefile")
        If (_dynamicMakefile) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()
        writer.WriteStartElement("AdditionalParams")
        writer.WriteString(_additionalParams)
        writer.WriteEndElement()
        writer.WriteStartElement("ActionBuild")
        writer.WriteString(_actionBuild)
        writer.WriteEndElement()
        writer.WriteStartElement("ActionClean")
        writer.WriteString(_actionClean)
        writer.WriteEndElement()
        writer.WriteStartElement("BinaryFileName")
        writer.WriteString(_binaryFileName)
        writer.WriteEndElement()
        writer.WriteStartElement("Complete")
        If (_complete) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()
    End Sub

    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Throw New NotImplementedException()
    End Function

    Public Function ShallowClone() As OptionsMake
        Return DirectCast(Me.MemberwiseClone(), OptionsMake)
    End Function

    Public Function DeepClone() As OptionsMake
        Return ShallowClone()
    End Function

End Class
