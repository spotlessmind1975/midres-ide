Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class OptionsGenerated

    Implements IXmlSerializable

    Private _dependenciesHashes As Collection = New Collection
    Private _dependencies As Collection = New Collection

    Public Property Dependencies As Collection
        Get
            Return _dependencies
        End Get
        Set(value As Collection)
            _dependencies = value
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
                    Case "FolderEntryHashCode"
                        _dependenciesHashes.Add(reader.ReadElementContentAsString())
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
        For Each folder In _dependencies
            writer.WriteStartElement("FolderEntryHashCode")
            writer.WriteString(folder.GetHashCode())
            writer.WriteEndElement()
        Next
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

    Public Sub Resolve(_project As Project)
        _dependencies.Clear()
        For Each hash In _dependenciesHashes
            Dim folder As FolderEntry = _project.findFolderByHash(hash)
            If Not (folder Is Nothing) Then
                _dependencies.Add(folder, folder.GetHashCode())
            End If
        Next
    End Sub
End Class