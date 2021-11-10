Public Class Umkreissuche

    Dim dt As Data.DataTable

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.StaatenTableAdapter.Fill(Me._WSL_AdressenDataSet.Staaten)
        'Me.AdresseMitGeodatenTableAdapter.Fill(Me._WSL_AdressenDataSet.AdresseMitGeodaten)

        'zuerst (wichtig) Combobox Anrede füllen
        With Me.CB_Staat
            .Items.Add("Deutschland")
            .Items.Add("Österreich")
            .Items.Add("Schweiz")
            .SelectedIndex = 0
        End With

        BundeslandLabel1.Text = String.Empty
        LandkreisLabel1.Text = String.Empty
        LatitudeLabel1.Text = String.Empty
        LongitudeLabel1.Text = String.Empty
        LBL_Treffer.Text = String.Empty
        lbl_IDFirmenName.Text = String.Empty




    End Sub

    Private Sub Umkreissuche_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Hauptform.PNL_Geodaten.Visible = True Then
            CB_Staat.Text = Hauptform.LBL_Land.Text
            TB_PLZ.Text = Hauptform.LBL_PLZ.Text
            CB_Ort.Text = Hauptform.LBL_Ort.Text

        End If
    End Sub

    Private Sub TB_PLZ_TextChanged(sender As Object, e As EventArgs) Handles TB_PLZ.TextChanged

        Me.PLZ_GeodatenTableAdapter.SuchePLZInGeodaten(Me._WSL_AdressenDataSet.PLZ_Geodaten, LBL_Countrycode.Text, TB_PLZ.Text)

        'MsgBox(CB_Ort.Items.Count)
        If CB_Ort.Items.Count = 0 Then
            LBL_PLZungueltig.Visible = True
        Else
            LBL_PLZungueltig.Visible = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TB_PLZ.Text = String.Empty Or CB_Ort.Text = String.Empty Or TB_Entfernung.Text = String.Empty Then
            MsgBox("Bitte alle Felder ausfüllen", vbExclamation)
            Exit Sub
        End If

        Try
            'Me.AdresseMitGeodatenTableAdapter.SucheUmkreis(_WSL_AdressenDataSet.AdresseMitGeodaten, CDec(LatitudeLabel1.Text), CDec(LongitudeLabel1.Text), CDec(TB_Entfernung.Text))
            dt = AdresseMitGeodatenTableAdapter.GetDataUmkreis(CDec(LatitudeLabel1.Text), CDec(LongitudeLabel1.Text), CDec(TB_Entfernung.Text))
        Catch ex As Exception
            MsgBox("Fehler beim Abrufen der Entfernungen!")
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


        'Wenn die Datentable exisitiert, bzw mit Daten ngefüllt ist.. 
        If dt IsNot Nothing Then
            LBL_Treffer.Text = dt.Rows.Count.ToString

            dgv.DataSource = dt

            'dgv.Columns.RemoveAt(0)
            dgv.Columns.RemoveAt(6)
            dgv.Columns.RemoveAt(6)
            dgv.Columns(6).DefaultCellStyle.Format = ("N0")
            Me.dgv.Sort(Me.dgv.Columns(6), System.ComponentModel.ListSortDirection.Ascending)
            dgv.Columns(6).HeaderCell.SortGlyphDirection = SortOrder.Ascending
            'dgv.AutoResizeColumns()

            With dgv
                .Columns(0).Width = 200
                .Columns(0).HeaderText = "Firma"
                .Columns(1).HeaderText = "Art"
                .Columns(2).Width = 70
                .Columns(2).HeaderText = "Land"
                .Columns(2).Width = 50
                .Columns(6).HeaderText = "ca. km"
                .Columns(6).Width = 50
            End With

            With lbl_IDFirmenName
                .DataBindings.Clear()
                .DataBindings.Add(New System.Windows.Forms.Binding("Text", dt, "FirmenName", True))
            End With
        End If

    End Sub


    Private Sub TB_Entfernung_TextChanged(sender As Object, e As EventArgs) Handles TB_Entfernung.TextChanged
        Dim value As System.Int32
        ' muss static sein, da Auswertung erst bei nachfolgenden Aufrufen erfolgt
        Static errflag As Boolean
        ' vollständigen inhalt der Textbox holen
        Dim s As String = CType(sender, Control).Text
        ' beim nächsten Tastendruck zunächst ev. anstehenden Fehler löschen
        If errflag Then
            TB_Entfernung.Text = ""
            errflag = False
        End If
        ' überprüfen, ob Inhalt rein numerisch
        If System.Int32.TryParse(s, value) Then
            ' auf Werte von 1 bis 100 begrenzen
            If value > 200 Then value = 200
            'If value < 10 Then value = 10
            ' wieder zurückschreiben
            TB_Entfernung.Text = value.ToString
        Else
            ' nicht numerische Zeichen im String
            TB_Entfernung.Text = "10"
            errflag = True
        End If
    End Sub

    Private Sub CB_Staat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Staat.SelectedIndexChanged

        Dim foundIndex As Integer = StaatenBindingSource.Find("Staat", CB_Staat.Text)
        StaatenBindingSource.Position = foundIndex

    End Sub

    Private Sub BTN_Schliessen_Click(sender As Object, e As EventArgs) Handles BTN_Schliessen.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hauptform.TB_FirmenName.Text = lbl_IDFirmenName.Text
        Hauptform.BTN_Suche.PerformClick()

    End Sub


    Dim mRow As Integer = 0
    Dim newpage As Boolean = True
    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' sets it to show '...' for long text
        Dim fmt As New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = e.MarginBounds.Top
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow

        ' print the header text for a new page
        '   use a grey bg just like the control
        If newpage Then
            row = dgv.Rows(mRow)
            x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells
                ' since we are printing the control's view,
                ' skip invidible columns
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    ' reused in the data pront - should be a function
                    Select Case dgv.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(dgv.Columns(cell.ColumnIndex).HeaderText,
                                            dgv.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h

        End If
        newpage = False

        ' now print the data for each row
        Dim thisNDX As Int32
        For thisNDX = mRow To dgv.RowCount - 1
            ' no need to try to print the new row
            If dgv.Rows(thisNDX).IsNewRow Then Exit For

            row = dgv.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            ' reset X for data
            x = e.MarginBounds.Left

            ' print the data
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                    ' SAMPLE CODE: How To 
                    ' up a RowPrePaint rule
                    'If Convert.ToDecimal(row.Cells(5).Value) < 9.99 Then
                    '    Using br As New SolidBrush(Color.MistyRose)
                    '        e.Graphics.FillRectangle(br, rc)
                    '    End Using
                    'End If

                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case dgv.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                      dgv.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next
            y += h
            ' next row to print
            mRow = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                ' mRow -= 1   causes last row to rePrint on next page
                newpage = True
                Return
            End If
        Next
    End Sub

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint

        mRow = 0
        newpage = True
        PrintPreviewDialog1.PrintPreviewControl.StartPage = 0
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.0

    End Sub

    Private WithEvents pd_PrintDoc As New System.Drawing.Printing.PrintDocument
    Dim PDFirstLoad As Boolean = True


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        pd_PrintDoc = PrintDocument1
        PrintPreviewDialog1.Document = pd_PrintDoc
        PageSetupDialog1.Document = pd_PrintDoc
        PageSetupDialog1.EnableMetric = True
        PrintPreviewDialog1.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath)
        PrintPreviewDialog1.PrintPreviewControl.AutoZoom = True
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.1
        PrintPreviewDialog1.Document.DefaultPageSettings.Landscape = False
        PrintPreviewDialog1.Document.DefaultPageSettings.Margins = New Printing.Margins(79, 79, 79, 79)
        PrintPreviewDialog1.ShowIcon = True
        PrintPreviewDialog1.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub GetControlsFromDialog(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Shown

        If PDFirstLoad = True Then
            Dim ts As ToolStrip = CType(PrintPreviewDialog1.Controls(1), ToolStrip)
            Dim PrintButtonItem As ToolStripItem = ts.Items("printToolStripButton")
            With PrintButtonItem
                Dim MyPrintButtonItem As ToolStripItem
                MyPrintButtonItem = ts.Items.Add(.Text, .Image, New EventHandler(AddressOf Me.PrintDialog_Show))
                MyPrintButtonItem.DisplayStyle = ToolStripItemDisplayStyle.Image
                ts.Items.Insert(0, MyPrintButtonItem)
            End With
            ts.Items.Remove(PrintButtonItem)

            Dim MyPageSetupItem As ToolStripItem
            MyPageSetupItem = ts.Items.Add("Seite einrichten", Nothing, New EventHandler(AddressOf Me.PageDialog_Show))
            MyPageSetupItem.DisplayStyle = ToolStripItemDisplayStyle.Text
            ts.Items.Insert(8, MyPageSetupItem)
            PDFirstLoad = False
        Else
            Exit Sub
        End If
    End Sub

    Private Sub PageDialog_Show(sender As Object, e As EventArgs)

        If PageSetupDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            'MsgBox(PageSetupDialog1.PageSettings.Margins.ToString)

            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.Document.DefaultPageSettings = PageSetupDialog1.PageSettings

            'With PrintPreviewDialog1.Document.DefaultPageSettings
            '    .Margins = PageSetupDialog1.PageSettings.Margins
            '    .PaperSize = PageSetupDialog1.PageSettings.PaperSize
            '    .Landscape = PageSetupDialog1.PageSettings.Landscape
            'End With
            PrintPreviewDialog1.Invalidate()
        Else
            Exit Sub
        End If

    End Sub

    Private Sub PrintDialog_Show(sender As Object, e As EventArgs)

        If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDialog1.Document = PrintDocument1
            PrintDialog1.Document.Print()
        End If

    End Sub


End Class