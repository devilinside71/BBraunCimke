Public Class Form1

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
            gintEnterCounter = 0
        End If
    End Sub

    Private Sub TextBoxPld_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxPld.KeyDown
        If e.KeyCode = Keys.Enter Then
            gintEnterCounter = gintEnterCounter + 1
            If gintEnterCounter = 2 Then
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
                gintEnterCounter = 0
            End If
        End If
    End Sub

    Private Sub TextBoxKat_GotFocus(sender As Object, e As EventArgs) Handles TextBoxKat.GotFocus
        TextBoxKat.Text = ""
        TextBoxSarzs.Text = ""
        LabelCze.Text = ""
        LabelSvk.Text = ""
        LabelKat.Text = ""
        gintEnterCounter = 0
        TextBoxPld.SelectAll()
    End Sub

    Private Sub ButtonManual_Click(sender As Object, e As EventArgs) Handles ButtonManual.Click
        Call ProcessManual()
    End Sub
End Class
