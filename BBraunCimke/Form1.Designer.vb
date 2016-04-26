<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonEng = New System.Windows.Forms.Button()
        Me.ButtonHun = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelKat = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelCze = New System.Windows.Forms.Label()
        Me.LabelSvk = New System.Windows.Forms.Label()
        Me.TextBoxKat = New System.Windows.Forms.TextBox()
        Me.TextBoxSarzs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxPld = New System.Windows.Forms.TextBox()
        Me.ComboBoxPrinter = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.56287!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.31737!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonEng, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonHun, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelKat, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelCze, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelSvk, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxKat, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxSarzs, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxPld, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBoxPrinter, 1, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(668, 381)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ButtonEng
        '
        Me.ButtonEng.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonEng.Location = New System.Drawing.Point(570, 3)
        Me.ButtonEng.Name = "ButtonEng"
        Me.ButtonEng.Size = New System.Drawing.Size(95, 48)
        Me.ButtonEng.TabIndex = 0
        Me.ButtonEng.Text = "Angol"
        Me.ButtonEng.UseVisualStyleBackColor = True
        '
        'ButtonHun
        '
        Me.ButtonHun.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonHun.Location = New System.Drawing.Point(570, 57)
        Me.ButtonHun.Name = "ButtonHun"
        Me.ButtonHun.Size = New System.Drawing.Size(95, 48)
        Me.ButtonHun.TabIndex = 1
        Me.ButtonHun.Text = "Magyar"
        Me.ButtonHun.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 54)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kat.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 54)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sarzs:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Beolvasva:"
        '
        'LabelKat
        '
        Me.LabelKat.AutoSize = True
        Me.LabelKat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelKat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelKat.Location = New System.Drawing.Point(127, 108)
        Me.LabelKat.Name = "LabelKat"
        Me.LabelKat.Size = New System.Drawing.Size(437, 54)
        Me.LabelKat.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 54)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cseh:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 54)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Szlovák:"
        '
        'LabelCze
        '
        Me.LabelCze.AutoSize = True
        Me.LabelCze.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCze.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelCze.Location = New System.Drawing.Point(127, 162)
        Me.LabelCze.Name = "LabelCze"
        Me.LabelCze.Size = New System.Drawing.Size(437, 54)
        Me.LabelCze.TabIndex = 8
        '
        'LabelSvk
        '
        Me.LabelSvk.AutoSize = True
        Me.LabelSvk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelSvk.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelSvk.Location = New System.Drawing.Point(127, 216)
        Me.LabelSvk.Name = "LabelSvk"
        Me.LabelSvk.Size = New System.Drawing.Size(437, 54)
        Me.LabelSvk.TabIndex = 9
        '
        'TextBoxKat
        '
        Me.TextBoxKat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxKat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxKat.Location = New System.Drawing.Point(127, 3)
        Me.TextBoxKat.Name = "TextBoxKat"
        Me.TextBoxKat.Size = New System.Drawing.Size(437, 31)
        Me.TextBoxKat.TabIndex = 1
        '
        'TextBoxSarzs
        '
        Me.TextBoxSarzs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxSarzs.Location = New System.Drawing.Point(127, 57)
        Me.TextBoxSarzs.Name = "TextBoxSarzs"
        Me.TextBoxSarzs.Size = New System.Drawing.Size(205, 31)
        Me.TextBoxSarzs.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 57)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nyomtató:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 54)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Példány:"
        '
        'TextBoxPld
        '
        Me.TextBoxPld.Dock = System.Windows.Forms.DockStyle.Left
        Me.TextBoxPld.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxPld.Location = New System.Drawing.Point(127, 273)
        Me.TextBoxPld.Name = "TextBoxPld"
        Me.TextBoxPld.Size = New System.Drawing.Size(100, 31)
        Me.TextBoxPld.TabIndex = 15
        Me.TextBoxPld.Text = "1"
        '
        'ComboBoxPrinter
        '
        Me.ComboBoxPrinter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ComboBoxPrinter.FormattingEnabled = True
        Me.ComboBoxPrinter.Items.AddRange(New Object() {"S4M_regi", "Z6Mplus"})
        Me.ComboBoxPrinter.Location = New System.Drawing.Point(127, 327)
        Me.ComboBoxPrinter.Name = "ComboBoxPrinter"
        Me.ComboBoxPrinter.Size = New System.Drawing.Size(437, 28)
        Me.ComboBoxPrinter.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 381)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "BBraun címkenyomtatás ZPL Zebra S4M"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ButtonEng As Button
    Friend WithEvents ButtonHun As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelKat As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelCze As Label
    Friend WithEvents LabelSvk As Label
    Friend WithEvents TextBoxKat As TextBox
    Friend WithEvents TextBoxSarzs As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxPld As TextBox
    Friend WithEvents ComboBoxPrinter As ComboBox
End Class
