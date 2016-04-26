Public Class Form1
    Public strLcat As String
    Public strLlot As String
    Public strLCz As String
    Public strLsk As String
    Public strLsize As String
    Private mintEnterCounter As Integer

    Private Sub ButtonEng_Click(sender As Object, e As EventArgs) Handles ButtonEng.Click
        Call ZebraPrint.ChangeToEnKey()
    End Sub

    Private Sub ButtonHun_Click(sender As Object, e As EventArgs) Handles ButtonHun.Click
        Call ZebraPrint.ChangeToHuKey()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call LoadCimkes()
        Call LoadPrinters()
        Call LoadZPLs()
        ComboBoxPrinter.Items.Clear()
        For Each x In printerwinnames
            ComboBoxPrinter.Items.Add(x)
        Next
        ComboBoxPrinter.SelectedIndex = 0
    End Sub

    Private Sub TextBoxKat_TextChanged(sender As Object, e As EventArgs) Handles TextBoxKat.TextChanged
        Dim strKat As String
        strKat = Trim(TextBoxKat.Text)
        If Len(strKat) = 16 Then
            TextBoxSarzs.Focus()
            TextBoxSarzs.Clear()
        End If
    End Sub

    Private Sub TextBoxSarzs_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSarzs.TextChanged
        Dim strKat As String
        Dim strSarzs As String
        strKat = Trim(TextBoxKat.Text)
        strSarzs = Trim(TextBoxSarzs.Text)
        If Len(strKat) = 16 And Len(strSarzs) = 11 Then
            Call ProcessCode(strKat, strSarzs)
            TextBoxPld.SelectAll()
            TextBoxPld.Focus()
            mintEnterCounter = 0
        End If
    End Sub

    Private Sub TextBoxPld_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPld.KeyDown
        If e.KeyCode = Keys.Enter Then
            mintEnterCounter = mintEnterCounter + 1
            If mintEnterCounter = 2 Then
                'MsgBox("Nyomtat")
                If LabelKat.Text <> "" Then
                    Call PrintZPL()
                End If
                TextBoxKat.Text = ""
                TextBoxSarzs.Text = ""
                LabelCze.Text = ""
                LabelSvk.Text = ""
                LabelKat.Text = ""
                TextBoxKat.Focus()
                mintEnterCounter = 0
            End If
        End If
    End Sub

    Private Sub TextBoxKat_GotFocus(sender As Object, e As EventArgs) Handles TextBoxKat.GotFocus
        TextBoxKat.Text = ""
        TextBoxSarzs.Text = ""
        LabelCze.Text = ""
        LabelSvk.Text = ""
        LabelKat.Text = ""
        mintEnterCounter = 0
        TextBoxPld.SelectAll()
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
                LabelKat.Text = outTxt
                LabelCze.Text = cimkecze(i)
                LabelSvk.Text = cimkesvk(i)
                strLcat = prCode
                strLlot = prSarzs
                strLsize = srtMeret
                strLCz = cimkecze(i)
                strLsk = cimkesvk(i)
            End If
        Next
    End Sub
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
        s = s.Replace("LABELQTY", TextBoxPld.Text)


        ' Open the printer dialog box, and then allow the user to select a printer.
        res = ZebraPrint.SendStringToPrinter(Trim(ComboBoxPrinter.Text), s)


    End Sub
End Class
