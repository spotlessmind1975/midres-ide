Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class RecentFileCollection

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

                If reader.NodeType <> System.Xml.XmlNodeType.EndElement Then
                    Select Case reader.Name
                        Case "RecentFileEntry"
                            Dim pe As RecentFileEntry = New RecentFileEntry
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
            writer.WriteStartElement("RecentFileEntry")
            DirectCast(_items(i), RecentFileEntry).WriteXml(writer)
            writer.WriteEndElement()
        Next
    End Sub

    Public Sub Add(item As RecentFileEntry)
        If _items.Count > 4 Then
            While _items.Count > 4
                _items.Remove(_items.Count() - 1)
            End While
        End If

        Dim newItems As Collection = New Collection

        For i = 1 To _items.Count
            If _items(i).FileName = item.Filename Then
                _items.Remove(i)
                Exit For
            End If
        Next

        newItems.Add(item)
        For i = 1 To _items.Count
            newItems.Add(_items(i))
        Next
        _items = newItems
    End Sub

    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Throw New NotImplementedException()
    End Function

    Public Function ShallowClone() As RecentFileCollection
        Return DirectCast(Me.MemberwiseClone(), RecentFileCollection)
    End Function

    Public Function DeepClone() As RecentFileCollection
        Return ShallowClone()
    End Function

End Class
