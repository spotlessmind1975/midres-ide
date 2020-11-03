Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class Options

    Implements IXmlSerializable

    Private _make As OptionsMake = New OptionsMake

    Private _ide As OptionsIDE = New OptionsIDE

    Private _emulators As OptionsEmulators = New OptionsEmulators

    Private _cc65 As OptionsCC65 = New OptionsCC65

    Private _tileset As OptionsTileset = New OptionsTileset

    Private _other As OptionsOther = New OptionsOther

    Public Property Make As OptionsMake
        Get
            Return _make
        End Get
        Set(value As OptionsMake)
            _make = value
        End Set
    End Property

    Public Property IDE As OptionsIDE
        Get
            Return _ide
        End Get
        Set(value As OptionsIDE)
            _ide = value
        End Set
    End Property

    Public Property Emulators As OptionsEmulators
        Get
            Return _emulators
        End Get
        Set(value As OptionsEmulators)
            _emulators = value
        End Set
    End Property

    Public Property CC65 As OptionsCC65
        Get
            Return _cc65
        End Get
        Set(value As OptionsCC65)
            _cc65 = value
        End Set
    End Property

    Public Property Tileset As OptionsTileset
        Get
            Return _tileset
        End Get
        Set(value As OptionsTileset)
            _tileset = value
        End Set
    End Property

    Public Property Other As OptionsOther
        Get
            Return _other
        End Get
        Set(value As OptionsOther)
            _other = value
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
                            Case "OptionsMake"
                                Dim pe As OptionsMake = New OptionsMake
                                pe.ReadXml(reader)
                                _make = pe
                            Case "OptionsOutput"
                                '' ignore
                                If Not (reader.IsEmptyElement) Then
                                    reader.ReadStartElement()
                                    reader.MoveToContent()
                                    Do
                                        reader.Skip()
                                    Loop While reader.NodeType <> System.Xml.XmlNodeType.EndElement
                                    reader.ReadEndElement()
                                Else
                                    reader.Read()
                                End If
                            Case "OptionsIDE"
                                Dim pe As OptionsIDE = New OptionsIDE
                                pe.ReadXml(reader)
                                _ide = pe
                            Case "OptionsEmulators"
                                Dim pe As OptionsEmulators = New OptionsEmulators
                                pe.ReadXml(reader)
                                _emulators = pe
                            Case "OptionsCC65"
                                Dim pe As OptionsCC65 = New OptionsCC65
                                pe.ReadXml(reader)
                                _cc65 = pe
                            Case "OptionsTileset"
                                Dim pe As OptionsTileset = New OptionsTileset
                                pe.ReadXml(reader)
                                _tileset = pe
                            Case "OptionsOther"
                                Dim pe As OptionsOther = New OptionsOther
                                pe.ReadXml(reader)
                                _other = pe
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
        writer.WriteStartElement("OptionsMake")
        DirectCast(_make, OptionsMake).WriteXml(writer)
        writer.WriteEndElement()
        writer.WriteStartElement("OptionsIDE")
        DirectCast(_ide, OptionsIDE).WriteXml(writer)
        writer.WriteEndElement()
        writer.WriteStartElement("OptionsEmulators")
        DirectCast(_emulators, OptionsEmulators).WriteXml(writer)
        writer.WriteEndElement()
        writer.WriteStartElement("OptionsCC65")
        DirectCast(_cc65, OptionsCC65).WriteXml(writer)
        writer.WriteEndElement()
        writer.WriteStartElement("OptionsTileset")
        DirectCast(_tileset, OptionsTileset).WriteXml(writer)
        writer.WriteEndElement()
        writer.WriteStartElement("OptionsOther")
        DirectCast(_other, OptionsOther).WriteXml(writer)
        writer.WriteEndElement()
    End Sub

    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Throw New NotImplementedException()
    End Function

    Public Function ShallowClone() As Options
        Return DirectCast(Me.MemberwiseClone(), Options)
    End Function

    Public Function DeepClone() As Options
        Dim o As Options = DirectCast(Me.MemberwiseClone(), Options)
        o._make = _make.DeepClone()
        o._ide = _ide.DeepClone()
        o._emulators = _emulators.DeepClone()
        o._cc65 = _cc65.DeepClone()
        o._tileset = _tileset.DeepClone()
        Return o
    End Function

End Class
