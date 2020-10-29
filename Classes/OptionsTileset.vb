Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class OptionsTileset

    Implements IXmlSerializable

    Private _binaryFileName As String
    Private _bankNumber As Integer
    Private _headerFileName As String
    Private _thresholdLuminance As Integer
    Private _multicolor As Boolean
    Private _reverse As Boolean

    Public Property BinaryFilename As String
        Get
            Return _binaryFileName
        End Get
        Set(value As String)
            _binaryFileName = value
        End Set
    End Property

    Public Property BankNumber As Integer
        Get
            Return _bankNumber
        End Get
        Set(value As Integer)
            _bankNumber = value
        End Set
    End Property


    Public Property HeaderFilename As String
        Get
            Return _headerFileName
        End Get
        Set(value As String)
            _headerFileName = value
        End Set
    End Property

    Public Property ThresholdLuminance As Integer
        Get
            Return _thresholdLuminance
        End Get
        Set(value As Integer)
            _thresholdLuminance = value
        End Set
    End Property

    Public Property Multicolor As Boolean
        Get
            Return _multicolor
        End Get
        Set(value As Boolean)
            _multicolor = value
        End Set
    End Property

    Public Property Reverse As Boolean
        Get
            Return _reverse
        End Get
        Set(value As Boolean)
            _reverse = value
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
                    Case "BinaryFileName"
                        _binaryFileName = reader.ReadElementContentAsString()
                    Case "BankNumber"
                        _bankNumber = reader.ReadElementContentAsInt()
                    Case "HeaderFileName"
                        _headerFileName = reader.ReadElementContentAsString()
                    Case "ThresholdLuminance"
                        _thresholdLuminance = reader.ReadElementContentAsInt()
                    Case "Multicolor"
                        _multicolor = reader.ReadElementContentAsBoolean()
                    Case "Reverse"
                        _reverse = reader.ReadElementContentAsBoolean()
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
        writer.WriteStartElement("BinaryFileName")
        writer.WriteString(_binaryFileName)
        writer.WriteEndElement()
        writer.WriteStartElement("BankNumber")
        writer.WriteString(_bankNumber)
        writer.WriteEndElement()
        writer.WriteStartElement("HeaderFileName")
        writer.WriteString(_headerFileName)
        writer.WriteEndElement()
        writer.WriteStartElement("ThresholdLuminance")
        writer.WriteString(_thresholdLuminance)
        writer.WriteEndElement()
        writer.WriteStartElement("Multicolor")
        If (_multicolor) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()
        writer.WriteStartElement("Reverse")
        If (_reverse) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()
    End Sub

    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Throw New NotImplementedException()
    End Function

    Public Function ShallowClone() As OptionsTileset
        Return DirectCast(Me.MemberwiseClone(), OptionsTileset)
    End Function

    Public Function DeepClone() As OptionsTileset
        Return ShallowClone()
    End Function

End Class