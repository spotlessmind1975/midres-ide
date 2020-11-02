Imports System.Xml
Imports System.Xml.Schema
Imports System.Xml.Serialization

Public Class OptionsCC65

    Implements IXmlSerializable

    Public Enum LanguageEnum

        '' This is the default mode. It is like c99 mode, but additional 
        '' features are enabled. Among these are "void data", non-standard 
        '' keywords without the underlines, unnamed function parameters 
        '' and the requirement for main() to return an int.
        CC65 = 0

        '' This disables anything that is illegal in C89/C90. 
        '' Among those things are // comments and the non-standard keywords 
        '' without underscores. Please note that cc65 is not a fully C89 
        '' compliant compiler despite this option. A few more things 
        '' (like floats) are missing.
        C89 = 1

        '' This enables a few features from the C99 standard. 
        '' With this option, // comments are allowed. It will 
        '' also cause warnings and even errors in a few situations 
        '' that are allowed with --standard c89. For example, a 
        '' call to a function without a prototype is an error in 
        '' this mode.
        C99 = 2
    End Enum


    Private _warnings As Collection = New Collection

    ''  -t sys                Set the target system
    '' --target sys          Set the target system
    Private _plus4 As Boolean
    Private _c16 As Boolean
    Private _vic20 As Boolean
    Private _vic2024 As Boolean
    Private _c64 As Boolean
    Private _c128 As Boolean
    Private _atari As Boolean
    Private _atarilo As Boolean

    '' --all-cdecl          Make functions default to __cdecl__
    Public _allCDecl As Boolean

    '' -Cl                   Make local variables static
    '' --static-locals       Make local variables static
    Private _staticLocals As Boolean

    '' -Dsym[=defn]          Define a symbol
    Private _symbols As Collection = New Collection

    '' -E                     Stop after the preprocessing stage

    ''  -I dir                Set an include directory search path
    ''  --include-dir dir     Set an include directory search path
    Private _includeDirs As Collection = New Collection

    ''  -O                    Optimize code
    Private _optimizeCode As Boolean

    ''  -Oi                   Optimize code, inline more code
    Private _optimizeCodeInline As Boolean

    ''  -Or                   Enable register variables
    ''  -r                    Enable register variables
    '' --register-vars        Enable register variables
    Private _registerVars As Boolean

    ''  -Os                     Inline some known functions
    ''  --eagerly-inline-funcs  Eagerly inline some known functions
    Private _inlineFunctions As Boolean

    '' --inline-stdfuncs        Inline some standard functions
    Private _inlineStdFunctions As Boolean

    ''  -T                    Include source as comment
    ''  --add-source          Include source as comment
    Private _addSource As Boolean

    '' -V                    Print the compiler version number
    '' --verbose             Increase verbosity
    '' --version             Print the compiler version number
    '' -W                    Suppress warnings
    Private _suppressWarnings As Boolean

    '' -d                    Debug mode
    '' --debug               Debug mode

    '' -g                    Add debug info to object file
    '' --debug-info          Add debug info to object file
    Private _debugInfo As Boolean

    '' --debug-opt name
    '' --list-opt-steps
    '' --debug-opt-output

    '' -h                    Help (this text)
    '' --help                Help (this text)

    '' -j                    Default characters are signed
    '' --signed-chars        Default characters are signed
    Private _signedChars As Boolean

    '' -mm model             Set the memory model
    Private _memoryModel As String

    '' -o name               Name the output file
    Private _outputFile As String = "obj\{target}\{source}.o"

    '' -v                    Increase verbosity

    '' --bss-name seg        Set the name of the BSS segment
    Private _bssName As String

    '' --check-stack         Generate stack overflow checks
    Private _checkStack As Boolean

    '' --code-name seg       Set the name of the CODE segment
    Private _codeName As String

    Private _codeSizeEnabled As Boolean

    '' --codesize x          Accept larger code by factor x
    Private _codeSize As Integer = 100

    '' --cpu type            Set cpu type
    Private _cpu65C02 As Boolean

    '' --create-dep name         Create a make dependency file
    Private _createDep As Boolean
    Private _createDepFilename As String

    '' create-full-dep name         Create a full make dependency file
    Private _createFullDep As Boolean
    Private _createFullDepFilename As String

    '' --dep-target target           Use this dependency target
    Private _depTarget As Boolean
    Private _depTargetFilename As String

    '' --data-name seg       Set the name of the DATA segment
    Private _dataName As String

    '' --forget-inc-paths    Forget include search paths
    Private _forgetIncPath As Boolean

    '' --local-strings               Emit string literals immediately
    Private _localStrings As Boolean

    '' --register-space b    Set space available for register variables
    ''                          The default value for this option is 6 (bytes).
    Private _registerSpaceEnabled As Boolean
    Private _registerSpace As Integer = 6

    '' --rodata-name seg     Set the name of the RODATA segment
    Private _rodataName As String

    '' --standard std        Language standard (c89, c99, cc65)
    Private _standardLanguage As LanguageEnum

    ''  --writable-strings    Make string literals writable
    Private _writableStrings As Boolean

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

    Public Property AllCDecl As Boolean
        Get
            Return _allCDecl
        End Get
        Set(value As Boolean)
            _allCDecl = value
        End Set
    End Property

    Public Property StaticLocals As Boolean
        Get
            Return _staticLocals
        End Get
        Set(value As Boolean)
            _staticLocals = value
        End Set
    End Property

    Public Property LocalStrings As Boolean
        Get
            Return _localStrings
        End Get
        Set(value As Boolean)
            _localStrings = value
        End Set
    End Property

    Public Property Symbols As Collection
        Get
            Return _symbols
        End Get
        Set(value As Collection)
            _symbols = value
        End Set
    End Property

    Public Property IncludeDirs As Collection
        Get
            Return _includeDirs
        End Get
        Set(value As Collection)
            _includeDirs = value
        End Set
    End Property

    Public Property OptimizeCode As Boolean
        Get
            Return _optimizeCode
        End Get
        Set(value As Boolean)
            _optimizeCode = value
        End Set
    End Property

    Public Property OptimizeCodeInline As Boolean
        Get
            Return _optimizeCodeInline
        End Get
        Set(value As Boolean)
            _optimizeCodeInline = value
        End Set
    End Property

    Public Property RegisterVars As Boolean
        Get
            Return _registerVars
        End Get
        Set(value As Boolean)
            _registerVars = value
        End Set
    End Property

    Public Property InlineFunctions As Boolean
        Get
            Return _inlineFunctions
        End Get
        Set(value As Boolean)
            _inlineFunctions = value
        End Set
    End Property

    Public Property InlineStdFunctions As Boolean
        Get
            Return _inlineStdFunctions
        End Get
        Set(value As Boolean)
            _inlineStdFunctions = value
        End Set
    End Property

    Public Property AddSource As Boolean
        Get
            Return _addSource
        End Get
        Set(value As Boolean)
            _addSource = value
        End Set
    End Property

    Public Property SuppressWarnings As Boolean
        Get
            Return _suppressWarnings
        End Get
        Set(value As Boolean)
            _suppressWarnings = value
        End Set
    End Property

    Public Property DebugInfo As Boolean
        Get
            Return _debugInfo
        End Get
        Set(value As Boolean)
            _debugInfo = value
        End Set
    End Property

    Public Property SignedChars As Boolean
        Get
            Return _signedChars
        End Get
        Set(value As Boolean)
            _signedChars = value
        End Set
    End Property

    Public Property OutputFile As String
        Get
            Return _outputFile
        End Get
        Set(value As String)
            _outputFile = value
        End Set
    End Property

    Public Property BssName As String
        Get
            Return _bssName
        End Get
        Set(value As String)
            _bssName = value
        End Set
    End Property

    Public Property CheckStack As Boolean
        Get
            Return _checkStack
        End Get
        Set(value As Boolean)
            _checkStack = value
        End Set
    End Property

    Public Property CodeName As String
        Get
            Return _codeName
        End Get
        Set(value As String)
            _codeName = value
        End Set
    End Property

    Public Property CodeSizeEnabled As Boolean
        Get
            Return _codeSizeEnabled
        End Get
        Set(value As Boolean)
            _codeSizeEnabled = value
        End Set
    End Property

    Public Property CodeSize As Integer
        Get
            Return _codeSize
        End Get
        Set(value As Integer)
            _codeSize = value
        End Set
    End Property

    Public Property Cpu65C02 As Boolean
        Get
            Return _cpu65C02
        End Get
        Set(value As Boolean)
            _cpu65C02 = value
        End Set
    End Property

    Public Property CreateDep As Boolean
        Get
            Return _createDep
        End Get
        Set(value As Boolean)
            _createDep = value
        End Set
    End Property

    Public Property CreateDepFilename As String
        Get
            Return _createDepFilename
        End Get
        Set(value As String)
            _createDepFilename = value
        End Set
    End Property

    Public Property CreateFullDep As Boolean
        Get
            Return _createFullDep
        End Get
        Set(value As Boolean)
            _createFullDep = value
        End Set
    End Property

    Public Property CreateFullDepFilename As String
        Get
            Return _createFullDepFilename
        End Get
        Set(value As String)
            _createFullDepFilename = value
        End Set
    End Property

    Public Property DepTarget As Boolean
        Get
            Return _depTarget
        End Get
        Set(value As Boolean)
            _depTarget = value
        End Set
    End Property

    Public Property DepTargetFilename As String
        Get
            Return _depTargetFilename
        End Get
        Set(value As String)
            _depTargetFilename = value
        End Set
    End Property

    Public Property DataName As String
        Get
            Return _dataName
        End Get
        Set(value As String)
            _dataName = value
        End Set
    End Property

    Public Property ForgetIncPath As Boolean
        Get
            Return _forgetIncPath
        End Get
        Set(value As Boolean)
            _forgetIncPath = value
        End Set
    End Property

    Public Property RegisterSpaceEnabled As Boolean
        Get
            Return _registerSpaceEnabled
        End Get
        Set(value As Boolean)
            _registerSpaceEnabled = value
        End Set
    End Property

    Public Property RegisterSpace As Integer
        Get
            Return _registerSpace
        End Get
        Set(value As Integer)
            _registerSpace = value
        End Set
    End Property

    Public Property RodataName As String
        Get
            Return _rodataName
        End Get
        Set(value As String)
            _rodataName = value
        End Set
    End Property

    Public Property StandardLanguage As LanguageEnum
        Get
            Return _standardLanguage
        End Get
        Set(value As LanguageEnum)
            _standardLanguage = value
        End Set
    End Property

    Public Property WritableStrings As Boolean
        Get
            Return _writableStrings
        End Get
        Set(value As Boolean)
            _writableStrings = value
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
                            Case "AllCDecl"
                                _allCDecl = reader.ReadElementContentAsBoolean()
                            Case "LocalStrings"
                                _localStrings = reader.ReadElementContentAsBoolean()
                            Case "StaticLocals"
                                _staticLocals = reader.ReadElementContentAsBoolean()
                            Case "Symbol"
                                _symbols.Add(reader.ReadElementContentAsString())
                            Case "IncludeDir"
                                _includeDirs.Add(reader.ReadElementContentAsString())
                            Case "OptimizeCode"
                                _optimizeCode = reader.ReadElementContentAsBoolean()
                            Case "OptimizeCodeInline"
                                _optimizeCodeInline = reader.ReadElementContentAsBoolean()
                            Case "RegisterVars"
                                _registerVars = reader.ReadElementContentAsBoolean()
                            Case "InlineFunctions"
                                _inlineFunctions = reader.ReadElementContentAsBoolean()
                            Case "InlineStdFunctions"
                                _inlineStdFunctions = reader.ReadElementContentAsBoolean()
                            Case "AddSource"
                                _addSource = reader.ReadElementContentAsBoolean()
                            Case "SuppressWarnings"
                                _suppressWarnings = reader.ReadElementContentAsBoolean()
                            Case "DebugInfo"
                                _debugInfo = reader.ReadElementContentAsBoolean()
                            Case "SignedChars"
                                _signedChars = reader.ReadElementContentAsBoolean()
                            Case "OutputFile"
                                _outputFile = reader.ReadElementContentAsString()
                            Case "BssName"
                                _bssName = reader.ReadElementContentAsString()
                            Case "CheckStack"
                                _checkStack = reader.ReadElementContentAsBoolean()
                            Case "CodeName"
                                _codeName = reader.ReadElementContentAsString()
                            Case "CodeSizeEnabled"
                                _codeSizeEnabled = reader.ReadElementContentAsBoolean()
                            Case "CodeSize"
                                _codeSize = reader.ReadElementContentAsInt()
                                If _codeSize < 100 Then _codeSize = 100
                                If _codeSize > 200 Then _codeSize = 200
                            Case "Cpu65C02"
                                _cpu65C02 = reader.ReadElementContentAsBoolean()
                            Case "CreateDep"
                                _createDep = reader.ReadElementContentAsBoolean()
                            Case "CreateDepFileName"
                                _createDepFilename = reader.ReadElementContentAsString()
                            Case "CreateFullDep"
                                _createFullDep = reader.ReadElementContentAsBoolean()
                            Case "CreateFullDepFileName"
                                _createFullDepFilename = reader.ReadElementContentAsString()
                            Case "DepTarget"
                                _depTarget = reader.ReadElementContentAsBoolean()
                            Case "DepTargetFileName"
                                _depTargetFilename = reader.ReadElementContentAsString()
                            Case "DataName"
                                _dataName = reader.ReadElementContentAsString()
                            Case "ForgetIncPath"
                                _forgetIncPath = reader.ReadElementContentAsBoolean()
                            Case "RegisterSpaceEnabled"
                                _registerSpaceEnabled = reader.ReadElementContentAsBoolean()
                            Case "RegisterSpace"
                                _registerSpace = reader.ReadElementContentAsInt()
                                If _registerSpace < 1 Then _registerSpace = 1
                                If _registerSpace > 255 Then _registerSpace = 255
                            Case "RodataName"
                                _rodataName = reader.ReadElementContentAsString()
                            Case "StandardLanguage"
                                _standardLanguage = reader.ReadElementContentAsInt()
                            Case "WritableStrings"
                                _writableStrings = reader.ReadElementContentAsBoolean()
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

        writer.WriteStartElement("AllCDecl")
        If (_allCDecl) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("StaticLocals")
        If (_staticLocals) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("LocalStrings")
        If (_localStrings) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        For Each symbol In _symbols
            writer.WriteStartElement("Symbol")
            writer.WriteString(symbol)
            writer.WriteEndElement()
        Next

        For Each includeDir In _includeDirs
            writer.WriteStartElement("IncludeDir")
            writer.WriteString(includeDir)
            writer.WriteEndElement()
        Next

        writer.WriteStartElement("OptimizeCode")
        If (_optimizeCode) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("OptimizeCodeInline")
        If (_optimizeCodeInline) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("RegisterVars")
        If (_registerVars) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("InlineFunctions")
        If (_inlineFunctions) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("InlineStdFunctions")
        If (_inlineStdFunctions) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("AddSource")
        If (_addSource) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("SuppressWarnings")
        If (_suppressWarnings) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("DebugInfo")
        If (_debugInfo) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("SignedChars")
        If (_signedChars) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("OutputFile")
        writer.WriteString(_outputFile)
        writer.WriteEndElement()

        writer.WriteStartElement("BssName")
        writer.WriteString(_bssName)
        writer.WriteEndElement()

        writer.WriteStartElement("CheckStack")
        If (_checkStack) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("CodeName")
        writer.WriteString(_codeName)
        writer.WriteEndElement()

        writer.WriteStartElement("CodeSize")
        writer.WriteString(_codeSize)
        writer.WriteEndElement()

        writer.WriteStartElement("Cpu65C02")
        If (_cpu65C02) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("CreateDep")
        If (_createDep) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("CreateDepFileName")
        writer.WriteString(_createDepFilename)
        writer.WriteEndElement()

        writer.WriteStartElement("CreateFullDep")
        If (_createFullDep) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("CreateFullDepFileName")
        writer.WriteString(_createDepFilename)
        writer.WriteEndElement()

        writer.WriteStartElement("DepTarget")
        If (_depTarget) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("DepTargetFileName")
        writer.WriteString(_depTargetFilename)
        writer.WriteEndElement()

        writer.WriteStartElement("DataName")
        writer.WriteString(_dataName)
        writer.WriteEndElement()

        writer.WriteStartElement("ForgetIncPath")
        If (_forgetIncPath) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()


        writer.WriteStartElement("RegisterSpaceEnabled")
        If (_registerSpaceEnabled) Then
            writer.WriteString("true")
        Else
            writer.WriteString("false")
        End If
        writer.WriteEndElement()

        writer.WriteStartElement("RegisterSpace")
        writer.WriteString(_registerSpace)
        writer.WriteEndElement()

        writer.WriteStartElement("RodataName")
        writer.WriteString(_rodataName)
        writer.WriteEndElement()

        writer.WriteStartElement("StandardLanguage")
        writer.WriteString(_standardLanguage)
        writer.WriteEndElement()

        writer.WriteStartElement("WritableStrings")
        If (_writableStrings) Then
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
