Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class OptionsCC65

    Implements IXmlSerializable

    Private _warnings As Collection = New Collection
    Private _plus4 As Boolean
    Private _c16 As Boolean
    Private _vic20 As Boolean
    Private _vic2024 As Boolean
    Private _c64 As Boolean
    Private _c128 As Boolean
    Private _atari As Boolean
    Private _atarilo As Boolean

    Public Property Warnings As Collection
        Get
            Return _warnings
        End Get
        Set(value As Collection)
            _warnings = value
        End Set
    End Property

    Public Property Plus4 As Boolean
        Get
            Return _plus4
        End Get
        Set(value As Boolean)
            _plus4 = value
        End Set
    End Property

    Public Property C16 As Boolean
        Get
            Return _c16
        End Get
        Set(value As Boolean)
            _c16 = value
        End Set
    End Property

    Public Property Vic20 As Boolean
        Get
            Return _vic20
        End Get
        Set(value As Boolean)
            _vic20 = value
        End Set
    End Property

    Public Property Vic2024 As Boolean
        Get
            Return _vic2024
        End Get
        Set(value As Boolean)
            _vic2024 = value
        End Set
    End Property

    Public Property C64 As Boolean
        Get
            Return _c64
        End Get
        Set(value As Boolean)
            _c64 = value
        End Set
    End Property

    Public Property C128 As Boolean
        Get
            Return _c128
        End Get
        Set(value As Boolean)
            _c128 = value
        End Set
    End Property

    Public Property Atari As Boolean
        Get
            Return _atari
        End Get
        Set(value As Boolean)
            _atari = value
        End Set
    End Property

    Public Property Atarilo As Boolean
        Get
            Return _atarilo
        End Get
        Set(value As Boolean)
            _atarilo = value
        End Set
    End Property

    Public Sub ReadXml(reader As XmlReader) Implements IXmlSerializable.ReadXml

        If Not reader.IsEmptyElement Then

            reader.ReadStartElement()
            reader.MoveToContent()

            If Not reader.IsEmptyElement Then
                While reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None
                    While reader.NodeType = System.Xml.XmlNodeType.Whitespace
                        reader.Read()
                    End While

                    If reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None Then
                        Select Case reader.Name
                            Case "CC65WarningEntry"
                                Dim pe As CC65WarningEntry = New CC65WarningEntry
                                pe.ReadXml(reader)
                                _warnings.Add(pe, pe.Pattern)
                            Case "Plus4"
                                _plus4 = reader.ReadElementContentAsBoolean()
                            Case "C16"
                                _c16 = reader.ReadElementContentAsBoolean()
                            Case "Vic20"
                                _vic20 = reader.ReadElementContentAsBoolean()
                            Case "Vic2024"
                                _vic2024 = reader.ReadElementContentAsBoolean()
                            Case "C64"
                                _c64 = reader.ReadElementContentAsBoolean()
                            Case "C128"
                                _c128 = reader.ReadElementContentAsBoolean()
                            Case "Atari"
                                _atari = reader.ReadElementContentAsBoolean()
                            Case "AtariLo"
                                _atarilo = reader.ReadElementContentAsBoolean()
                            Case Else
                                reader.ReadContentAsString()
                        End Select
                    End If
                End While
            End If

            If reader.NodeType <> System.Xml.XmlNodeType.None Then
                reader.ReadEndElement()
            End If
        Else
            reader.Read()
        End If


    End Sub

    Public Sub WriteXml(writer As XmlWriter) Implements IXmlSerializable.WriteXml
        For i = 1 To _warnings.Count
            writer.WriteStartElement("CC65WarningEntry")
            DirectCast(_warnings(i), CC65WarningEntry).WriteXml(writer)
            writer.WriteEndElement()
        Next
        writer.WriteStartElement("Plus4")
        If (_plus4) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()
        writer.WriteStartElement("C16")
        If (_c16) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()
        writer.WriteStartElement("Vic20")
        If (_vic20) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()
        writer.WriteStartElement("Vic2024")
        If (_vic2024) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()
        writer.WriteStartElement("C64")
        If (_c64) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()
        writer.WriteStartElement("C128")
        If (_c128) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()
        writer.WriteStartElement("Atari")
        If (_atari) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()
        writer.WriteStartElement("AtariLo")
        If (_atarilo) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

    End Sub

    Public Function IgnoredWarning(_message As String) As Boolean
        For i = 1 To _warnings.Count
            If (InStr(_message, _warnings(i).Pattern)) > 0 Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Throw New NotImplementedException()
    End Function

    Public Function ShallowClone() As OptionsCC65
        Return DirectCast(Me.MemberwiseClone(), OptionsCC65)
    End Function

    Public Function DeepClone() As OptionsCC65
        Return ShallowClone()
    End Function
End Class
