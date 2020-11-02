Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class OptionsMake

    Implements IXmlSerializable

    Public Enum KindGeneration
        STATICAL = 0
        DYNAMICAL = 1
        INTERNAL = 1
    End Enum
    Private _makeFilename As String = "makefile"
    Private _kind As KindGeneration
    Private _additionalParams As String = ""
    Private _actionBuild As String = "all"
    Private _actionClean As String = "clean"
    Private _executableFileName As String = "exe/midres.{target}"
    Private _diskImage As Boolean = True
    Private _diskImageFileName As String = "exe/midres.{target}.{support}"
    Private _complete As Boolean = True

    Private _plus4 As Boolean
    Private _c16 As Boolean
    Private _vic20 As Boolean
    Private _vic2024 As Boolean
    Private _c64 As Boolean
    Private _c128 As Boolean
    Private _atari As Boolean
    Private _atarilo As Boolean
    Public Property MakeFilename As String
        Get
            Return _makeFilename
        End Get
        Set(value As String)
            _makeFilename = value
        End Set
    End Property

    Public Property Kind As KindGeneration
        Get
            Return _kind
        End Get
        Set(value As KindGeneration)
            _kind = value
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

    Public Property ExecutableFilename As String
        Get
            Return _executableFileName
        End Get
        Set(value As String)
            _executableFileName = value
        End Set
    End Property

    Public Property DiskImage As Boolean
        Get
            Return _diskImage
        End Get
        Set(value As Boolean)
            _diskImage = value
        End Set
    End Property

    Public Property DiskImageFilename As String
        Get
            Return _diskImageFileName
        End Get
        Set(value As String)
            _diskImageFileName = value
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

            While reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None
                While reader.NodeType = System.Xml.XmlNodeType.Whitespace
                    reader.Read()
                End While

                If reader.NodeType <> System.Xml.XmlNodeType.EndElement And reader.NodeType <> System.Xml.XmlNodeType.None Then
                    Select Case reader.Name
                        Case "MakeFileName"
                            _makeFilename = reader.ReadElementContentAsString()
                        Case "DynamicMakefile"
                            If (reader.ReadElementContentAsBoolean()) Then
                                _kind = KindGeneration.DYNAMICAL
                            Else
                                _kind = KindGeneration.STATICAL
                            End If
                        Case "Kind"
                            _kind = reader.ReadElementContentAsInt()
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
                        Case "AdditionalParams"
                            _additionalParams = reader.ReadElementContentAsString()
                        Case "ActionBuild"
                            _actionBuild = reader.ReadElementContentAsString()
                        Case "ActionClean"
                            _actionClean = reader.ReadElementContentAsString()
                        Case "BinaryFileName", "DiskImageFileName"
                            _diskImageFileName = reader.ReadElementContentAsString()
                        Case "Complete", "DiskImage"
                            _diskImage = reader.ReadElementContentAsBoolean()
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
        writer.WriteStartElement("Kind")
        writer.WriteString(_kind)
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
        writer.WriteStartElement("ExecutableImageFileName")
        writer.WriteString(_diskImageFileName)
        writer.WriteEndElement()
        writer.WriteStartElement("DiskImage")
        If (_diskImage) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()
        writer.WriteStartElement("DiskImageFileName")
        writer.WriteString(_diskImageFileName)
        writer.WriteEndElement()

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

    Public Function GetSchema() As XmlSchema Implements IXmlSerializable.GetSchema
        Throw New NotImplementedException()
    End Function

    Public Function ShallowClone() As OptionsMake
        Return DirectCast(Me.MemberwiseClone(), OptionsMake)
    End Function

    Public Function DeepClone() As OptionsMake
        Return ShallowClone()
    End Function

    Public Function hasTarget(_target) As Boolean

        Select Case _target
            Case "plus4"
                Return _plus4
            Case "c16"
                Return _c16
            Case "vic20"
                Return _vic20
            Case "vic2024"
                Return _vic2024
            Case "c64"
                Return _c64
            Case "c128"
                Return _c128
            Case "atari"
                Return _atari
            Case "atarilo"
                Return _atarilo
        End Select

        Return False

    End Function
End Class
