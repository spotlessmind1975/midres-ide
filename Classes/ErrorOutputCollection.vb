Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class ErrorOutputCollection

    Implements IXmlSerializable

    Private _items As Collection = New Collection

    Public Property Items As Collection
        Get
            Return _items
        End Get
        Set(value As Collection)
            _items = value
        End Set
    End Property

    Public Sub ReadXml(reader As XmlReader) Implements IXmlSerializable.ReadXml

        reader.ReadStartElement()
        reader.MoveToContent()

        If Not reader.IsEmptyElement Then
            While reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None
                While reader.NodeType = System.Xml.XmlNodeType.Whitespace
                    reader.Read()
                End While

                If reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None Then
                    Select Case reader.Name
                        Case "ErrorOutputEntry"
                            Dim pe As ErrorOutputEntry = New ErrorOutputEntry
                            pe.ReadXml(reader)
                            _items.Add(pe)
                        Case Else
                            reader.ReadContentAsString()
                    End Select
                End If
            End While
        End If

        If reader.NodeType <> System.Xml.XmlNodeType.None Then
            reader.ReadEndElement()
        End If

    End Sub

    Public Sub WriteXml(writer As XmlWriter) Implements IXmlSerializable.WriteXml
        For i = 1 To _items.Count
            writer.WriteStartElement("ErrorOutputEntry")
            DirectCast(_items(i), ErrorOutputEntry).WriteXml(writer)
            writer.WriteEndElement()
        Next
    End Sub

    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Throw New NotImplementedException()
    End Function

    Public Function ShallowClone() As ErrorOutputCollection
        Return DirectCast(Me.MemberwiseClone(), ErrorOutputCollection)
    End Function

End Class
