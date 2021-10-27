Option Strict Off

Imports System.IO
Imports System.Data

Module Module1

    Private wdAnw As Object
    Private wdDok As Object

    Public Sub NeuenFirmenNamenAnlegen()
        'Komplett neuer Geschäftspartner wird angelegt. Dieser bekommt immer eine neue IDFirmenName und wird zunächst mit einer Leadnummer angelegt.
        'MsgBox("Neuen Geschäftspartner anlegen")

        'hole die nächste freie IDFirmenName
        Dim IDFirmenName As Double = Hauptform.KonfigurationTableAdapter.ScalarIDFirmenName()
        Dim FirmenName As String = Hauptform.TB_FirmenName.Text

        'hole die nächste freie Leadnummer
        Dim Leadnummer As Double = Hauptform.KonfigurationTableAdapter.ScalarLeadnummer()
        Dim KontoName As String = "Lead-" & Year(Now).ToString

        'Datensatz FirmenName schreiben
        Hauptform.FirmenNameTableAdapter.Insert(IDFirmenName, FirmenName, Environment.UserName, Now, False)
        Logging(1, IDFirmenName, IDFirmenName, FirmenName)

        'Datensatz Konto schreiben - zunächst mit der Leadnummer!
        Hauptform.KontoTableAdapter.Insert(Leadnummer, IDFirmenName, KontoName, Now)
        Logging(2, Leadnummer, IDFirmenName, KontoName)

        'DatensatzSuche wiederholen
        Try
            Hauptform.FirmenNameTableAdapter.SucheFirmenName(Hauptform._WSL_AdressenDataSet.FirmenName, Hauptform.TB_FirmenName.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Werte in der Konfigurations-Tabelle aktualisieren (IDFirmenName + Leadnummer)
        Hauptform.KonfigurationTableAdapter.UpdateIDFirmenName(IDFirmenName + 1, IDFirmenName)
        Hauptform.KonfigurationTableAdapter.UpdateLeadnummer(Leadnummer + 1, Leadnummer)

        AlleTableAdapterAktualisieren(IDFirmenName)

        'DocuWare-Datei schreiben:
        SaveToCSV()

        'versch Einstellungen:
        With Hauptform
            .gbKonto.Visible = True
            .lblHinweisKeinTreffer.Visible = False
            .gbKonto.Visible = True 'Groupboxen Konto, Adresse, Kontakt einblenden
            .TC_Adresse.Visible = True
            .TC_Kontakt.Visible = True
            .TB_FirmenName.Text = Hauptform.CB_FirmenName.Text
            .lblTrefferAnzahl.Text = Hauptform.CB_FirmenName.Items.Count & " Treffer"
            .AdressenDataGridView.Visible = True
            .KontakteDataGridView.Visible = True
        End With
    End Sub

    Public Sub IDFirmenNameInAdresseSatzMarkieren(IDFirmenName As Double, IDAdresse As Double)

        'AdressenTableAdapter aktualisieren, geänderten Satz auswählen
        Try
            Hauptform.AdressenTableAdapter.SucheIDFirmenNameInAdressen(Hauptform._WSL_AdressenDataSet.Adressen, IDFirmenName)
        Catch ex As System.Exception
            MsgBox("lblIDFirmenName in Adressen suchen - Fehler")
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'geänderten Datensatz selektieren
        Dim foundIndex As Integer = Hauptform.AdressenBindingSource.Find("IDAdresse", IDAdresse)
        Hauptform.AdressenBindingSource.Position = foundIndex

    End Sub

    Public Sub IDFirmenNameInKontakteSatzMarkieren(IDFirmenName As Integer, IDKontakt As Integer)

        'KontakteTableAdapter aktualisieren, geänderten Satz auswählen
        Try
            Hauptform.KontakteTableAdapter.SucheIDFirmenNameInKontakte(Hauptform._WSL_AdressenDataSet.Kontakte, IDFirmenName)
        Catch ex As System.Exception
            MsgBox("lblIDFirmenName in Kontakte suchen - Fehler")
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'geänderten Datensatz selektieren
        Dim foundIndex As Integer = Hauptform.KontakteBindingSource.Find("IDKontakt", IDKontakt)
        Hauptform.KontakteBindingSource.Position = foundIndex

        If Hauptform.LBL_IDAdresseZuKontakt.Text = String.Empty And Hauptform.LBL_IDKontakt.Text <> String.Empty Or
        Hauptform.LBL_IDAdresseZuKontakt.Text = "0" And Hauptform.LBL_IDKontakt.Text <> String.Empty Then
            Hauptform.LBL_IDAdresseZuKontakt.Text = "Kontakt hat keine Adresse!"
            Hauptform.LBL_IDAdresseZuKontakt.ForeColor = Color.Red
        Else
            Hauptform.LBL_IDAdresseZuKontakt.ForeColor = Color.Black
        End If

    End Sub


    Public Sub IDBBInBesucheMitAdresse(IDFirmenName As Integer, IDBeleg As Integer)

        'BesucheTableAdapter aktualisieren, geänderten Satz auswählen
        Try
            Hauptform.BelegeMitAdresseTableAdapter.SucheIDFirmenNameInBelegeMitAdresse(Hauptform._WSL_AdressenDataSet.BelegeMitAdresse, IDFirmenName)
        Catch ex As System.Exception
            MsgBox("lblIDFirmenName in Besuche suchen - Fehler")
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'geänderten Datensatz selektieren
        Dim foundIndex As Integer = Hauptform.BelegeMitAdresseBindingSource.Find("IDBeleg", IDBeleg)
        'MsgBox(foundIndex & " " & IDBeleg)
        Hauptform.BelegeMitAdresseBindingSource.Position = foundIndex

    End Sub

    Public Sub AlleTableAdapterAktualisieren(IDFirmenName As Integer)
        'Das Label ist eine eine Datenquelle gebunden. Je nach selektiertem Satz ändert sich der Inhalt.
        'Wenn sich der Text das Labels ändert, muss auch der KontoTableAdapter immer mit den Werten des aktuellen Geschäftspartners gefüllt werden:
        'MsgBox("Alle Adapter aktualisieren")

        Hauptform.KontakteDataGridView.DataSource = ""
        Hauptform.KontakteDataGridView.Refresh()

        Hauptform.AdressenDataGridView.DataSource = ""
        Hauptform.AdressenDataGridView.Refresh()

        Try
            Hauptform.BelegeMitAdresseTableAdapter.SucheIDFirmenNameInBelegeMitAdresse(Hauptform._WSL_AdressenDataSet.BelegeMitAdresse, IDFirmenName)
            Hauptform.KontakteMitAdresseTableAdapter.SucheIDFirmenNameInKontakteMitAdresse(Hauptform._WSL_AdressenDataSet.KontakteMitAdresse, IDFirmenName)

            Hauptform.KontoTableAdapter.SucheIDFirmenNameInKonto(Hauptform._WSL_AdressenDataSet.Konto, IDFirmenName)
            Hauptform.AdressenTableAdapter.SucheIDFirmenNameInAdressen(Hauptform._WSL_AdressenDataSet.Adressen, IDFirmenName)
            Hauptform.KontakteTableAdapter.SucheIDFirmenNameInKontakte(Hauptform._WSL_AdressenDataSet.Kontakte, IDFirmenName)

            Hauptform.DocuwareCSVTableAdapter.Fill(Hauptform._WSL_AdressenDataSet.DocuwareCSV)
        Catch ex As System.Exception
            MsgBox("lblIDFirmenName ohne Inhalt - Fehler")

        End Try

        'MsgBox("Datagrid leer und ungebunden, neu gesucht...")
        Hauptform.KontakteDataGridView.DataSource = Hauptform.KontakteBindingSource
        Hauptform.AdressenDataGridView.DataSource = Hauptform.AdressenBindingSource

    End Sub


    Sub WordStarten(Belegtyp As String)
        ' öffnet den Word-Besuchsbericht und füllt den Kopf mit markierten Daten,
        Dim Pfad As String
        Pfad = Hauptform.KonfigurationTableAdapter.ScalarVorlagenpfad().ToString
        If Right(Pfad, 1) <> "\" Then Pfad += "\"
        Pfad += Belegtyp

        On Error Resume Next
        wdAnw = GetObject("Word.Application") 'Bestehende Word-Instanz suchen
        Select Case Err.Number
            Case 0 'Alles paletti
            Case 429 'Es gibt soweit keine Word-Instanz
                Err.Clear()
                wdAnw = CreateObject("Word.Application") 'Word-Instanz erzeugen
                If Err.Number > 0 Then
                    BadOrHappyEnd(Err.Number, Err.Description)
                    Cursor.Current = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
            Case Else 'Unerwarteter Fehler
                BadOrHappyEnd(Err.Number, Err.Description)
                Cursor.Current = System.Windows.Forms.Cursors.Default
                Exit Sub
        End Select
        On Error GoTo 0
        '
        wdAnw.Visible = True 'Instanz sichtbar machen
        wdAnw.WindowState = 0
        '
        'Je nach dem, ob das Dokument bereits geöffnet ist oder nicht wird verbunden
        'bzw. geöffnet. Diese Differenzierung geschieht implizit.
        On Error Resume Next

        ' wdDok = wdAnw.Documents.Open(Filename:=Pfad)
        wdDok = wdAnw.Documents.Add(Template:=Pfad)
        If Err.Number > 0 Then 'Wenn Arbeitsmappe nicht existiert oder unerwarteter Fehler
            BadOrHappyEnd(Err.Number, Err.Description)
            Cursor.Current = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If
        On Error GoTo 0


        'Schlüsseltexte werden gesucht und durch Zellinhalte ersetzt
        wdAnw.Selection.Find.Text = "#FirmenName"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.LBL_FirmenName.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#BBBerichtNr"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.IDBeleg
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#Strasse"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.LBL_BBStrasse.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#PLZ"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.LBL_BBPLZ.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#Ort"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.LBL_BBOrt.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#Region"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.LBL_BBRegion.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#Land"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.LBL_BBLand.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#VAT_ID"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.UStIdNrLabel2.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#KontAnrede"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.LBL_Anrede.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#KontVorname"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.LBL_Vorname.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#KontNachname"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.LBL_Nachname.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#KontEmail"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.EmailAddresseLinkLabel.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#KontTelGesch"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.TelefonGeschaeftlichLinkLabel.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#KontTelPriv"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.TelefonPrivatLinkLabel.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#KontTelMobil"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.MobiltelefonLinkLabel.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#BBWeitereKontakte"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.TB_BBWeitereKontakte.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#BBDatum"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.DTP_BBDatum.Value
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#BBvonWem"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.CB_BBKuerzel.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#BBweitereBesucher"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.TB_BBWeitereBesucher.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#BBThema"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.TB_BBThema.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#BriefBetreff"
        wdAnw.Selection.Find.Replacement.Text = Hauptform.TB_DIVThema.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#KontoNr" 'Es soll die zugeordnete Kontonummer aus der Adresse benutzt werden. Ist diese leer, wird das Konto-Label ausgelesen
        If Hauptform.LBL_BBIDKonto.Text <> "" Then
            wdAnw.Selection.Find.Replacement.Text = Hauptform.LBL_BBIDKonto.Text
        Else
            wdAnw.Selection.Find.Replacement.Text = Hauptform.lblIDKonto.Text
        End If
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#KomplAdresse" 'Komplette Adresse wie angezeigt auf Briefseite mit od. ohne Anrede
        'In der Adresse befinden sich obstruse Leerzeichen. die entfernt werden müssen. Kein Ahnung, woher die kommen!
        Dim Adresse As String
        Adresse = Replace(Hauptform.LBL_DIVAdresse.Text, Chr(13), "")
        'wdAnw.Selection.Find.Replacement.Text = FrmAdressName.lblBriefKomplettAdresse.Caption
        wdAnw.Selection.Find.Replacement.Text = Adresse
        wdAnw.Selection.Find.Execute(Replace:=2)
        Debug.Print(Adresse)

        wdAnw.Selection.Find.Text = "#FaxNr" 'Komplette Adresse wie angezeigt auf Briefseite mit od. ohne Anrede
        wdAnw.Selection.Find.Replacement.Text = Hauptform.TB_DIVFaxnummer.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#DW" 'Durchwahl
        wdAnw.Selection.Find.Replacement.Text = Hauptform.LBL_DIVDurchwahl.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#Datum" 'Briefdatum
        wdAnw.Selection.Find.Replacement.Text = Hauptform.DTP_Diverse.Value.ToShortDateString
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#Sachbearbeiter" 'Sachbearbeiter
        wdAnw.Selection.Find.Replacement.Text = Hauptform.CB_DIVSachbearbeiter.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#BriefPosition" 'Position Sachbearbeiter
        wdAnw.Selection.Find.Replacement.Text = Hauptform.LBL_DIVJobtitle.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "#Email" 'Email Sachbearbeiter
        wdAnw.Selection.Find.Replacement.Text = Hauptform.LBL_DIVEmail.Text
        wdAnw.Selection.Find.Execute(Replace:=2)

        wdAnw.Selection.Find.Text = "^010"
        wdAnw.Selection.Find.Replacement.Text = "^011"
        wdAnw.Selection.Find.Execute(Replace:=2)


        wdAnw.ActiveDocument.Fields.Update 'aktualisiert automatisch die Felder im Dokument

        wdAnw = Nothing
        wdDok = Nothing

        BadOrHappyEnd(Err.Number, Err.Description)
    End Sub

    Private Sub BadOrHappyEnd(rc As Long, fehler As String)
        If rc > 0 Then
            MsgBox(fehler, vbExclamation)
        End If
        wdDok = Nothing 'Aufräumen
        wdAnw = Nothing
    End Sub


    Public Sub SaveToCSV()
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        'Build the CSV file data as a Comma separated string.
        Dim csv As String = String.Empty
        'MsgBox(Form1.DocuwareCSVDataGridView.RowCount)

        'DocuwareCSVDataGridView.Sort(DocuwareCSVDataGridView.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

        'Add the Header row for CSV file.
        For Each column As DataGridViewColumn In Hauptform.DocuwareCSVDataGridView.Columns
            csv += column.HeaderText.ToString() & ";"c
        Next

        'Add new line.
        csv += vbCr & vbLf

        'Adding the Rows
        For Each row As DataGridViewRow In Hauptform.DocuwareCSVDataGridView.Rows
            For Each cell As DataGridViewCell In row.Cells
                'Add the Data rows.
                'csv += cell.Value.ToString().Replace(",", ";") & ","c
                csv += cell.Value.ToString() & ";"c
            Next
            'Add new line.
            csv += vbCr & vbLf
        Next

        'Exporting to Excel
        Dim folderPath As String
        'Pfad und Dateiname aus der Datenbank auslesen:
        folderPath = Hauptform.KonfigurationTableAdapter.ScalarDWPfad().ToString & Hauptform.KonfigurationTableAdapter.ScalarDWDateiname().ToString
        'MsgBox(folderPath)
        File.WriteAllText(folderPath, csv)
        'File.WriteAllText(folderPath & "DataGridViewExport.csv", csv)

        Hauptform.LBL_Hinweis.Visible = True
        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Sub

    Public Sub Logging(Typ As Integer, IDInTabelle As Integer, IDFirmenName As Integer, Hinweis As String)
        'Alle Änderungen werden hier übergeben und in die Log-TAbelle geschrieben

        Dim Meldung As String = String.Empty
        Dim Tabelle As String = String.Empty


        Select Case Typ
            Case 1
                Meldung = "Neuer Geschäftspartner angelegt"
                Tabelle = "FirmenName"
            Case 2
                Meldung = "Neues Konto angelegt"
                Tabelle = "Konto"
            Case 3
                Meldung = "Name des Geschäftspartners geändert"
                Tabelle = "FirmenName"
            Case 4
                Meldung = "Neue Adresse angelegt"
                Tabelle = "Adressen"
            Case 5
                Meldung = "Adresse geändert"
                Tabelle = "Adressen"
            Case 6
                Meldung = "Neuen Kontakt angelegt"
                Tabelle = "Kontakte"
            Case 7
                Meldung = "Kontakt geändert"
                Tabelle = "Kontakte"
            Case 8
                Meldung = "Besuchsbericht erstellt"
                Tabelle = "Belege"
            Case 9
                Meldung = Hauptform.CB_Vorlagen.Text & " erstellt"
                Tabelle = "Belege"
            Case 10
                Meldung = "Kontakt gelöscht"
                Tabelle = "Kontakte"
        End Select

        Hauptform.LogTabelleTableAdapter.Insert(Meldung, Tabelle, IDInTabelle, Hinweis, Environment.UserName, Now, IDFirmenName)
    End Sub


    Public Sub FillVorlagen()
        Dim fname As String, pfad As String
        pfad = Hauptform.KonfigurationTableAdapter.ScalarVorlagenpfad().ToString 'anpassen
        If Right(pfad, 1) <> "\" Then pfad += "\"

        'MsgBox(pfad)

        fname = Dir(pfad & "*.dotx")
        'MsgBox(fname)
        If fname <> String.Empty Then
            Do While fname <> ""
                'MsgBox(fname)
                If fname <> "Besuchsbericht.dotx" Then 'der Besuchsbericht soll NICHT eingelesen werden!
                    Hauptform.CB_Vorlagen.Items.Add(fname)
                End If
                fname = Dir()
            Loop
            Hauptform.CB_Vorlagen.SelectedIndex = 0
        Else
            MsgBox("Der Vorlagenordner auf N:\.. wurde nicht gefunden! BItte Info an den Administrator", vbExclamation)

        End If

    End Sub

End Module
