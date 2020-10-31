Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class OptionsOutput

    Implements IXmlSerializable

    Private _binaryFileName As String
    Private _complete As Boolean

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

    Public Function ShallowClone() As OptionsOutput
        Return DirectCast(Me.MemberwiseClone(), OptionsOutput)
    End Function

    Public Function DeepClone() As OptionsOutput
        Return ShallowClone()
    End Function

End Class