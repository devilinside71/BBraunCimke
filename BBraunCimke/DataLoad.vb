Imports System.Xml
Imports System.IO
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Imports Microsoft.Win32.SafeHandles

Module DataLoad
    Public labelnames As List(Of String) = New List(Of String)
    Public labelcodes As List(Of String) = New List(Of String)
    Public printernames As List(Of String) = New List(Of String)
    Public printerwinnames As List(Of String) = New List(Of String)
    Public cimkenames As List(Of String) = New List(Of String)
    Public cimkeeng As List(Of String) = New List(Of String)
    Public cimkeger As List(Of String) = New List(Of String)
    Public cimkecze As List(Of String) = New List(Of String)
    Public cimkesvk As List(Of String) = New List(Of String)
    Public cimkesizes As List(Of String) = New List(Of String)
    Public zplnames As List(Of String) = New List(Of String)
    Public zplcodes As List(Of String) = New List(Of String)
    Public Sub LoadCimkes()
        Dim m_xmlr As XmlTextReader
        'Create the XML Reader
        m_xmlr = New XmlTextReader("SzlovakCimke.xml")
        'Disable whitespace so that you don't have to read over whitespaces
        m_xmlr.WhitespaceHandling = WhitespaceHandling.None
        'read the xml declaration and advance to family tag
        m_xmlr.Read()
        'read the family tag
        m_xmlr.Read()
        'Load the Loop
        While Not m_xmlr.EOF
            'Go to the name tag
            m_xmlr.Read()
            'if not start element exit while loop
            If Not m_xmlr.IsStartElement() Then
                Exit While
            End If
            'Get the Gender Attribute Value
            cimkenames.Add(m_xmlr.GetAttribute("name"))
            'Read elements firstname and lastname
            m_xmlr.Read()
            'Get the firstName Element Value
            cimkeeng.Add(m_xmlr.ReadElementString("eng"))
            cimkeger.Add(m_xmlr.ReadElementString("ger"))
            cimkecze.Add(m_xmlr.ReadElementString("cze"))
            cimkesvk.Add(m_xmlr.ReadElementString("svk"))
            cimkesizes.Add(m_xmlr.ReadElementString("size"))
        End While
        'close the reader
        m_xmlr.Close()
    End Sub
    Public Sub LoadPrinters()
        Dim m_xmlr As XmlTextReader
        'Create the XML Reader
        m_xmlr = New XmlTextReader("Printers.xml")
        'Disable whitespace so that you don't have to read over whitespaces
        m_xmlr.WhitespaceHandling = WhitespaceHandling.None
        'read the xml declaration and advance to family tag
        m_xmlr.Read()
        'read the family tag
        m_xmlr.Read()
        'Load the Loop
        While Not m_xmlr.EOF
            'Go to the name tag
            m_xmlr.Read()
            'if not start element exit while loop
            If Not m_xmlr.IsStartElement() Then
                Exit While
            End If
            'Get the Gender Attribute Value
            printernames.Add(m_xmlr.GetAttribute("name"))
            'Read elements firstname and lastname
            m_xmlr.Read()
            'Get the firstName Element Value
            printerwinnames.Add(m_xmlr.ReadElementString("winname"))
        End While
        'close the reader
        m_xmlr.Close()

    End Sub
    Public Sub LoadZPLs()
        Dim m_xmlr As XmlTextReader
        'Create the XML Reader
        m_xmlr = New XmlTextReader("SloZPL.xml")
        'Disable whitespace so that you don't have to read over whitespaces
        m_xmlr.WhitespaceHandling = WhitespaceHandling.None
        'read the xml declaration and advance to family tag
        m_xmlr.Read()
        'read the family tag
        m_xmlr.Read()
        'Load the Loop
        While Not m_xmlr.EOF
            'Go to the name tag
            m_xmlr.Read()
            'if not start element exit while loop
            If Not m_xmlr.IsStartElement() Then
                Exit While
            End If
            'Get the Gender Attribute Value
            zplnames.Add(m_xmlr.GetAttribute("name"))
            'Read elements firstname and lastname
            m_xmlr.Read()
            'Get the firstName Element Value
            zplcodes.Add(m_xmlr.ReadElementString("code"))
        End While
        'close the reader
        m_xmlr.Close()
    End Sub
End Module
