Module BBraun
    Public strLcat As String
    Public strLlot As String
    Public strLCz As String
    Public strLsk As String
    Public strLsize As String
    Public gintEnterCounter As Integer
    Public Sub PrintZPL()
        Dim s As String
        Dim pd As New PrintDialog()
        Dim res As Boolean

        s = zplcodes(0)
        s = s.Replace("LABELREF", strLcat)
        s = s.Replace("LABELLOT", strLlot)
        s = s.Replace("LABELCZ", ZebraPrint.GetZPLutf8Code(strLCz))
        s = s.Replace("LABELSK", ZebraPrint.GetZPLutf8Code(strLsk))
        s = s.Replace("LABELSIZE", strLsize)
        s = s.Replace("LABELQTY", Form1.TextBoxPld.Text)


        ' Open the printer dialog box, and then allow the user to select a printer.
        res = ZebraPrint.SendStringToPrinter(Trim(Form1.ComboBoxPrinter.Text), s)


    End Sub
    Public Sub ProcessCode(code As String, sarzs As String)
        Dim prCode As String
        Dim srtMeret As String
        Dim prSarzs As String
        Dim outTxt As String
        prCode = Mid(code, 6, 9)
        prSarzs = Mid(sarzs, 3, 4)
        outTxt = vbNullString
        For i = 0 To cimkenames.Count - 1
            If cimkenames(i) = prCode Then
                srtMeret = cimkesizes(i)
                outTxt = prCode & "    " & prSarzs & "    " & srtMeret
                Form1.LabelKat.Text = outTxt
                Form1.LabelCze.Text = cimkecze(i)
                Form1.LabelSvk.Text = cimkesvk(i)
                strLcat = prCode
                strLlot = prSarzs
                strLsize = srtMeret
                strLCz = cimkecze(i)
                strLsk = cimkesvk(i)
            End If
        Next
    End Sub
    Public Sub ProcessManual()
        Dim prCode As String
        Dim srtMeret As String
        Dim prSarzs As String
        Dim outTxt As String
        prCode = InputBox("Cikkszám")
        prSarzs = InputBox("Sarzs")
        outTxt = vbNullString
        For i = 0 To cimkenames.Count - 1
            If cimkenames(i) = prCode Then
                srtMeret = cimkesizes(i)
                outTxt = prCode & "    " & prSarzs & "    " & srtMeret
                Form1.LabelKat.Text = outTxt
                Form1.LabelCze.Text = cimkecze(i)
                Form1.LabelSvk.Text = cimkesvk(i)
                strLcat = prCode
                strLlot = prSarzs
                strLsize = srtMeret
                strLCz = cimkecze(i)
                strLsk = cimkesvk(i)
            End If
        Next
        Form1.TextBoxPld.SelectAll()
        Form1.TextBoxPld.Focus()
        gintEnterCounter = 0

    End Sub
End Module
