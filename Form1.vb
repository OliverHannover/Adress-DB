﻿
Public Class Hauptform
    Public IDBeleg As Integer
    Dim AdresseNeu As Boolean = False
    Dim KontaktNeu As Boolean = False
    Dim Suchstring As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_WSL_AdressenDataSet.LogTabelle". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.LogTabelleTableAdapter.Fill(Me._WSL_AdressenDataSet.LogTabelle)

        Me.BelegeMitAdresseTableAdapter.Fill(Me._WSL_AdressenDataSet.BelegeMitAdresse)
        Me.BelegeTableAdapter.Fill(Me._WSL_AdressenDataSet.Belege)
        Me.KonfigurationTableAdapter.Fill(Me._WSL_AdressenDataSet.Konfiguration)
        Me.LogTabelleTableAdapter.Fill(Me._WSL_AdressenDataSet.LogTabelle)
        Me.DocuwareCSVTableAdapter.Fill(Me._WSL_AdressenDataSet.DocuwareCSV)
        Me.KontakteMitAdresseTableAdapter.Fill(Me._WSL_AdressenDataSet.KontakteMitAdresse)

        'Liste wird mit ALLEN Usern gefüllt, auch den inaktiven (für die Usererkennung)!
        Me.SachbearbeiterTableAdapter.Fill(Me._WSL_AdressenDataSet.Sachbearbeiter)

        Me.Width = 1175
        Me.Height = 680

        lblTrefferAnzahl.Text = "Trefferanzahl" 'Starttext
        gbKonto.Visible = False 'Groupboxen Konto, Adresse, Kontakt ausblenden
        TC_Adresse.Visible = False
        TC_Kontakt.Visible = False
        TC_Beleg.Visible = False
        LBL_Hinweis.Visible = False
        LBL_BBBesuchterKontakt.Text = String.Empty
        'LBL_IDFirmenName.Text = String.Empty
        LBL_IDFirmenName.Text = "0"
        lblHinweisKeinTreffer.Visible = False
        TB_FirmenName.Select()

        'zuerst (wichtig) Combobox Anrede füllen
        With Me.AnredeComboBox
            .Items.Add("Hr.")
            .Items.Add("Hr. Dr.")
            .Items.Add("Fr.")
            .Items.Add("Fr. Dr.")
            .Items.Add("Mr.")
            .Items.Add("Mrs.")
            .SelectedIndex = 0
        End With



        DocuwareCSVDataGridView.Sort(DocuwareCSVDataGridView.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub Hauptform_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'Benutzer erkennen in der Tabelle mit ALLEN Usern - auch inaktive:
        Dim foundIndex As Integer = SachbearbeiterBindingSource.Find("Login", Environment.UserName)
        If foundIndex < 0 Then
            MsgBox("Ihr Login wurde nicht erkannt. Bitte im Menü über Einstellungen/Benutzerliste Ihre Benutzerdaten prüfen/korrigieren oder ergänzen.", vbExclamation)
            lblUser.Text = "Sachbearbeiter nicht erkannt"
            lblUser.ForeColor = Color.Red
        Else
            'Username in das Label schreiben
            lblUser.Text = SachbearbeiterTableAdapter.ScalarSachbearbeiter(foundIndex + 1)
        End If

        'Dann die Tabelle nur mit den aktiven füllen und weiter geht es...
        Me.SachbearbeiterTableAdapter.FillByAktive(Me._WSL_AdressenDataSet.Sachbearbeiter)
        foundIndex = SachbearbeiterBindingSource.Find("Login", Environment.UserName)
        SachbearbeiterBindingSource.Position = foundIndex

        'Combobox Vorlagen füllen
        FillVorlagen()

    End Sub

    Private Sub BTN_Suche_Click(sender As Object, e As EventArgs) Handles BTN_Suche.Click
        'MsgBox("Starte Suche...")
        LBL_Hinweis.Visible = False 'DocuWare-Hinweis
        Suchstring = TB_FirmenName.Text

        If TB_FirmenName.Text <> String.Empty Then

            Try
                Me.FirmenNameTableAdapter.SucheFirmenName(Me._WSL_AdressenDataSet.FirmenName, TB_FirmenName.Text)
            Catch ex As System.Exception
                MsgBox("FirmenName")
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            lblTrefferAnzahl.Text = CB_FirmenName.Items.Count & " Treffer"
        Else
            MsgBox("Bitte einen Suchbegriff eingeben", vbExclamation)
        End If

        'MsgBox("beende Suche.")
    End Sub

    Private Sub btnNeuesKonto_Click(sender As Object, e As EventArgs) Handles btnNeuesKonto.Click
        KontoForm.Show()
    End Sub

    Private Sub LBL_FirmenName_TextChanged(sender As Object, e As EventArgs) Handles LBL_FirmenName.TextChanged
        'gefundenen/ausgewählten Firmennamen in die Suchtextbox zurück schreiben:

        If LBL_FirmenName.Text <> String.Empty Then
            TB_FirmenName.Text = LBL_FirmenName.Text
        End If
        'MsgBox(IDFirmenName & " LBL_(ohneID)FirmenName_TextChanged")

    End Sub

    Private Sub LBL_IDFirmenName_TextChanged(sender As Object, e As EventArgs) Handles LBL_IDFirmenName.TextChanged
        'Das Label lblIDFirmenName ist an die Datenquelle 'FirmenNameTableAdapter' gebunden. Ändert sich dieser
        'oder wird ein anderer Datensatz davon selektiert, ändert sich auch der Text im Label.
        Dim IDFirmenName As Double

        IDFirmenName = Val(LBL_IDFirmenName.Text)
        'MsgBox("ID=" & IDFirmenName & " LBL_IDFirmenName_TextChanged")

        If IDFirmenName <> 0 Then
            'Es wurden Treffer gefunden ----------------------------------------------------
            'MsgBox("Treffer gefunden")
            gbKonto.Visible = True 'Groupboxen Konto, Adresse, Kontakt einblenden
            TC_Adresse.Visible = True
            TC_Kontakt.Visible = True
            TC_Beleg.Visible = True
            CB_FirmenName.Enabled = True
            lblHinweisKeinTreffer.Visible = False
            'Alle anderen Tableadapter werden erst neu befüllt, wenn lblIDFirmenName auch einen Wert <> 0 zurück gibt!
            AlleTableAdapterAktualisieren(CInt(IDFirmenName))
        Else
            'keine Treffer -----------------------------------------------------------------
            'MsgBox("keine Treffer gefunden")
            gbKonto.Visible = False 'Groupboxen Konto, Adresse, Kontakt ausblenden
            TC_Adresse.Visible = False
            TC_Kontakt.Visible = False
            TC_Beleg.Visible = False
            CB_FirmenName.Enabled = False
            lblHinweisKeinTreffer.Visible = True
            lblHinweisKeinTreffer.Text = "0 Treffer! Speichern, um diesen Geschäftspartner neu anzulegen."
            TB_FirmenName.Text = Suchstring
        End If

    End Sub

    Private Sub btnSpeichern_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        '1) Neuen Geschäftspartner anlegen
        '2) FirmenName / Name Geschäftspartner ändern/aktualisieren
        '3) Adresse neu anlegen
        '4) Kontakt neu anlegen
        '5) TableUpdate Adressen bei Änderung
        '6) TableUpdate Kontakte bei Änderung



        '1) #####################################################################################################################
        'Neuen Geschäftspartner anlegen:
        'Ein Datensatz in FirmenNamen ergänzen + LeadKonto in Konto ergänzen, wenn:
        'ComboBox leer, TextBox FirmenName hat Wert und Hinweislabel sichtbar
        If CB_FirmenName.Items.Count = 0 And TB_FirmenName.Text <> "" And lblHinweisKeinTreffer.Visible = True Then
            'MsgBox("Neuen Geschäftspartner anlegen")
            'Abfrage ob gespeichert werden soll


            Dim Result As DialogResult
            Result = MessageBox.Show("Folgenden Geschäftspartner anlegen:" & vbNewLine & vbNewLine &
                         "auf RECHTSCHREIBUNG achten...!" & vbNewLine & vbNewLine &
                           TB_FirmenName.Text, "Neuen Geschäftspartner anlegen", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = System.Windows.Forms.DialogResult.Yes Then
                NeuenFirmenNamenAnlegen()
            ElseIf Result = System.Windows.Forms.DialogResult.No Then
                'exit the procedure
                Exit Sub
            End If


            Exit Sub 'keine weiteren IF/Then-Prüfungen! KEIN WEITERER PROZESSABLAUF!
        End If ' Ende neuen Geschäftspartner anlegen

        '2) #####################################################################################################################

        Dim IDFirmenName As Integer

        'FirmenName / Name Geschäftspartner ändern/aktualisieren
        If TB_FirmenName.Text <> CB_FirmenName.Text And TB_FirmenName.Text <> String.Empty And Val(LBL_IDFirmenName.Text) <> 0 Then
            'MsgBox("Geschäftspartner umbenennen")

            IDFirmenName = CInt(LBL_IDFirmenName.Text)
            Dim FirmenNameNeu As String = TB_FirmenName.Text
            Dim FirmenNameAlt As String = CB_FirmenName.Text

            'Abfrage ob Umbenennen oder neu anlegen?
            Dim intAnswer As Integer
            intAnswer = MessageBox.Show("auf RECHTSCHREIBUNG achten...!" & vbNewLine & vbNewLine &
                                        "'Ja' für Umbenennen: " & FirmenNameAlt & " --> " & FirmenNameNeu & vbNewLine & vbNewLine &
                                        "'Nein' für NEU anlegen: " & FirmenNameNeu, "Geschäftspartner umbenennen oder neu?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            Select Case intAnswer
                Case vbYes
                    Try
                        'Datensatz FirmenName schreiben
                        FirmenNameTableAdapter.UpdateFirmenName(FirmenNameNeu, Environment.UserName, Now.ToString, IDFirmenName)
                        Logging(3, IDFirmenName, IDFirmenName, FirmenNameAlt & " --> " & FirmenNameNeu) ' LogTabelle schreiben
                    Catch ex As Exception
                        MsgBox("Umbenennen fehlgeschlagen", vbExclamation)
                    End Try


                    MsgBox("Firmenname umbenannt")

                    'DocuWare-Datei schreiben:
                    BTN_Suche.PerformClick()
                    SaveToCSV()


                    Exit Sub
                Case vbNo
                    'MsgBox("neu anlegen")
                    NeuenFirmenNamenAnlegen()
                    Exit Sub
                Case vbCancel
                    'MsgBox("Abbrechen")
                    Exit Sub
            End Select
            Exit Sub 'keine weiteren IF/Then-Prüfungen!
        End If 'FirmenName/Geschäftspartner umbenennen

        '3) #####################################################################################################################

        Dim IDAdresse As Integer

        'Adresse neu anlegen
        If AdresseNeu = True And OrtTextBox.Text <> String.Empty Then
            'MsgBox("Adresse neu anlegen")
            'Wert aus Konfig-Tabelle holen
            IDAdresse = CInt(KonfigurationTableAdapter.ScalarIDAdresse())
            IDFirmenName = CInt(LBL_IDFirmenName.Text)


            'Datensatz Adresse hinzufügen
            Try
                AdressenTableAdapter.Insert(IDAdresse,
                                           IDFirmenName,
                                            CInt(IDKontoTextBox.Text),
                                            AdresstypTextBox.Text,
                                            StraßeTextBox.Text,
                                            PostfachTextBox.Text,
                                            PLZTextBox.Text,
                                            OrtTextBox.Text,
                                            BundeslandTextBox.Text,
                                            LandTextBox.Text,
                                            UStIdNrTextBox.Text,
                                            WebseiteTextBox.Text)

                'Nächsten Wert in der Konfig-Tabelle aktualisieren
                Me.KonfigurationTableAdapter.UpdateIDAdresse((IDAdresse + 1), IDAdresse)

                Logging(4, IDAdresse, IDFirmenName, OrtTextBox.Text) ' LogTabelle schreiben

            Catch ex As System.Exception
                MsgBox("Fehler beim hinzufügen einer Adresse")
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            AdresseNeu = False
            lblAdresseNeu.Visible = False
            LBL_IDKontoZuAdresse.ForeColor = Color.Black
            TC_Adresse.SelectedIndex = 0
            OrtTextBox.BackColor = Color.White

        ElseIf AdresseNeu = True And OrtTextBox.Text = String.Empty Then
            MsgBox("Bitte einen Ort für Adresse erfassen!", vbExclamation, "Neue Adresse Anlegen")
            OrtTextBox.Select()
            OrtTextBox.BackColor = Color.MistyRose
            Exit Sub 'keine weiteren IF/Then-Prüfungen!
        End If

        '4) #####################################################################################################################
        'Kontakt neu anlegen

        Dim IDKontakt As Integer

        If KontaktNeu = True And NachnameTextBox.Text <> String.Empty Then
            'MsgBox("Kontakt neu anlegen")
            'Wert aus Konfig-Tabelle holen
            IDKontakt = CInt(Me.KonfigurationTableAdapter.ScalarIDKontakt())
            IDFirmenName = CInt(LBL_IDFirmenName.Text)

            'Datensatz Kontakt hinzufügen
            Try
                KontakteTableAdapter.Insert(IDKontakt,
                                            IDFirmenName,
                                            NachnameTextBox.Text,
                                            VornameTextBox.Text,
                                            EmailAddresseTextBox.Text,
                                            PositionTextBox.Text,
                                            TelefonGeschaeftlichTextBox.Text,
                                            TelefonPrivatTextBox.Text,
                                            MobiltelefonTextBox.Text,
                                            FaxnummerTextBox.Text,
                                            CInt(IDAdresseTextBox.Text),
                                            AnredeComboBox.Text)

                'Nächsten Wert in der Konfig-Tabelle aktualisieren
                Me.KonfigurationTableAdapter.UpdateIDKontakt((IDKontakt + 1), IDKontakt)
                Logging(6, IDKontakt, IDFirmenName, NachnameTextBox.Text) ' LogTabelle schreiben

            Catch ex As System.Exception
                MsgBox("Fehler beim hinzufügen eines Kontaktes")
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            KontaktNeu = False
            lblKontaktNeu.Visible = False
            LBL_IDAdresseZuKontakt.ForeColor = Color.Black
            TC_Kontakt.SelectedIndex = 0
            NachnameTextBox.BackColor = Color.White

        ElseIf KontaktNeu = True And NachnameTextBox.Text = String.Empty Then
            MsgBox("Bitte einen Nachnamen bei Kontakt erfassen!", vbExclamation, "Neuen Kontakt anlegen")
            NachnameTextBox.Select()
            NachnameTextBox.BackColor = Color.MistyRose
            Exit Sub 'keine weiteren IF/Then-Prüfungen!
        End If

        '5) #####################################################################################################################
        'TableUpdate Adressen bei Änderung
        'MsgBox(tcAdresse.SelectedIndex.ToString)
        If AdresseNeu = False And TC_Adresse.SelectedIndex = 1 And OrtTextBox.Text <> String.Empty Then
            'MsgBox("Adresse ändern")
            IDFirmenName = CInt(LBL_IDFirmenName.Text)


            Try
                AdressenTableAdapter.UpdateAdressen(IDFirmenName,
                                                    CInt(IDKontoTextBox.Text),
                                                    AdresstypTextBox.Text,
                                                    StraßeTextBox.Text,
                                                    PostfachTextBox.Text,
                                                    PLZTextBox.Text,
                                                    OrtTextBox.Text,
                                                    BundeslandTextBox.Text,
                                                    LandTextBox.Text,
                                                    UStIdNrTextBox.Text,
                                                    WebseiteTextBox.Text,
                                                    CInt(LBL_IDAdresse.Text))

                Logging(5, CInt(LBL_IDAdresse.Text), IDFirmenName, OrtTextBox.Text) ' LogTabelle schreiben

            Catch ex As Exception
                MsgBox("Fehler bei Adresse ändern", vbExclamation)
            End Try

            MsgBox("Adresse geändert")
            TC_Adresse.SelectedIndex = 0
            'Exit Sub 'keine weiteren IF/Then-Prüfungen!
        End If

        '6) #####################################################################################################################
        'TableUpdate Kontakte bei Änderung
        If KontaktNeu = False And TC_Kontakt.SelectedIndex = 1 And NachnameTextBox.Text <> String.Empty Then
            'MsgBox("Kontakt ändern")
            IDFirmenName = CInt(LBL_IDFirmenName.Text)

            Try
                KontakteTableAdapter.UpdateKontakte(IDFirmenName,
                                                    NachnameTextBox.Text,
                                                    VornameTextBox.Text,
                                                    EmailAddresseTextBox.Text,
                                                    PositionTextBox.Text,
                                                    TelefonGeschaeftlichTextBox.Text,
                                                    TelefonPrivatTextBox.Text,
                                                    MobiltelefonTextBox.Text,
                                                    FaxnummerTextBox.Text,
                                                    CInt(IDAdresseTextBox.Text),
                                                    AnredeComboBox.Text,
                                                    CInt(LBL_IDKontakt.Text))

                Logging(7, CInt(LBL_IDKontakt.Text), IDFirmenName, NachnameTextBox.Text) ' LogTabelle schreiben

            Catch ex As Exception
                MsgBox("Fehler bei Kontakt ändern", vbExclamation)
            End Try

            MsgBox("Kontakt geändert")
            TC_Kontakt.SelectedIndex = 0
            'Exit Sub 'keine weiteren IF/Then-Prüfungen!
        End If


        'Schluss ############################################################################################################### 
        'TableAdapter aktualisieren und aktuellen Satz markieren
        AlleTableAdapterAktualisieren(IDFirmenName)

        IDFirmenNameInAdresseSatzMarkieren(IDFirmenName, IDAdresse)
        IDFirmenNameInKontakteSatzMarkieren(IDFirmenName, IDKontakt)

    End Sub

    Private Sub EmailAddresseLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles EmailAddresseLinkLabel.LinkClicked
        System.Diagnostics.Process.Start("mailto:" & EmailAddresseTextBox.Text)
    End Sub

    Private Sub btnKontoZuAdresse_Click(sender As Object, e As EventArgs) Handles btnKontoZuAdresse.Click
        IDKontoTextBox.Text = lblIDKonto.Text
    End Sub

    Private Sub btnAdresseZuKontakt_Click(sender As Object, e As EventArgs) Handles btnAdresseZuKontakt.Click
        IDAdresseTextBox.Text = LBL_IDAdresse.Text
    End Sub

    Private Sub cbFirmenName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_FirmenName.SelectedIndexChanged
        If CB_FirmenName.Items.Count <> 0 Then
            TB_FirmenName.Text = CB_FirmenName.Text
        End If
    End Sub

    Private Sub btnNeueAdresse_Click(sender As Object, e As EventArgs) Handles btnNeueAdresse.Click
        'Marker setzen
        AdresseNeu = True
        lblAdresseNeu.Visible = True

        AdresstypTextBox.Text = String.Empty
        StraßeTextBox.Text = String.Empty
        PostfachTextBox.Text = String.Empty
        PLZTextBox.Text = String.Empty
        OrtTextBox.Text = String.Empty
        OrtTextBox.BackColor = Color.MistyRose
        BundeslandTextBox.Text = String.Empty
        LandTextBox.Text = String.Empty
        UStIdNrTextBox.Text = String.Empty
        WebseiteTextBox.Text = String.Empty
        WebseiteLinkLabel.Text = String.Empty
        IDKontoTextBox.Text = lblIDKonto.Text

        AdresstypTextBox.Enabled = True
        StraßeTextBox.Enabled = True
        PostfachTextBox.Enabled = True
        PLZTextBox.Enabled = True
        OrtTextBox.Enabled = True
        BundeslandTextBox.Enabled = True
        LandTextBox.Enabled = True
        UStIdNrTextBox.Enabled = True
        WebseiteTextBox.Enabled = True

    End Sub

    Private Sub btnMapsSuche_Click(sender As Object, e As EventArgs) Handles BTN_MapsSuche.Click

        Dim strasse As String = LBL_Strasse.Text
        Dim ort As String = LBL_Ort.Text
        Dim land As String = LBL_Land.Text
        Dim plz As String = LBL_PLZ.Text
        Dim i As Integer

        Try
            Dim querryAddress As New System.Text.StringBuilder

            querryAddress.Append("https://www.google.de/maps/place/")

            If LBL_Strasse.Text <> String.Empty Then
                querryAddress.Append(strasse + "," & "+")
                i = 1
            End If
            If LBL_Ort.Text <> String.Empty Then
                querryAddress.Append(ort + "," & "+")
                i = i + 1
            End If
            If LBL_Land.Text <> String.Empty Then
                querryAddress.Append(land + "," & "+")
                i = i + 1
            End If
            If LBL_PLZ.Text <> String.Empty Then
                querryAddress.Append(plz)
                i = i + 1
            End If
            'MsgBox(querryAddress.ToString)
            If i > 0 Then
                System.Diagnostics.Process.Start(querryAddress.ToString)
            Else
                MsgBox("Nicht genügend Daten vorhanden")
            End If
        Catch ex As Exception
            MsgBox("Fehler bei der Bildung der Suchzeichenfolge für Google", vbExclamation)

        End Try

    End Sub

    Private Sub TelefonGeschaeftlichLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TelefonGeschaeftlichLinkLabel.LinkClicked
        Dim LinkString As String = TelefonGeschaeftlichLinkLabel.Text
        System.Diagnostics.Process.Start("callto:" & LinkString)
    End Sub

    Private Sub TelefonPrivatLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TelefonPrivatLinkLabel.LinkClicked
        Dim LinkString As String = TelefonPrivatLinkLabel.Text
        System.Diagnostics.Process.Start("callto:" & LinkString)
    End Sub

    Private Sub MobiltelefonLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MobiltelefonLinkLabel.LinkClicked
        Dim LinkString As String = MobiltelefonLinkLabel.Text
        System.Diagnostics.Process.Start("callto:" & LinkString)
    End Sub

    Private Sub WebseiteLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles WebseiteLinkLabel.LinkClicked
        Dim LinkString As String = WebseiteLinkLabel.Text
        Try
            System.Diagnostics.Process.Start(LinkString.ToString)
        Catch ex As System.Exception
            MsgBox("Öffnen des Links nicht möglich")
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnNeuerKontakt_Click(sender As Object, e As EventArgs) Handles btnNeuerKontakt.Click
        'Marker setzen
        KontaktNeu = True
        lblKontaktNeu.Visible = True

        AnredeComboBox.Text = String.Empty
        NachnameTextBox.Text = String.Empty
        NachnameTextBox.BackColor = Color.MistyRose
        VornameTextBox.Text = String.Empty
        EmailAddresseTextBox.Text = String.Empty
        PositionTextBox.Text = String.Empty
        TelefonGeschaeftlichTextBox.Text = String.Empty
        TelefonPrivatTextBox.Text = String.Empty
        MobiltelefonTextBox.Text = String.Empty
        FaxnummerTextBox.Text = String.Empty
        WebseiteLinkLabel.Text = String.Empty
        'Falls noch keine Adresse vorhanden ist:
        Dim IDAdresse As Double
        If LBL_IDAdresse.Text <> String.Empty Then
            IDAdresse = Val(LBL_IDAdresse.Text)
        End If
        IDAdresseTextBox.Text = IDAdresse.ToString

        AnredeComboBox.Enabled = True
        NachnameTextBox.Enabled = True
        VornameTextBox.Enabled = True
        EmailAddresseTextBox.Enabled = True
        PositionTextBox.Enabled = True
        TelefonGeschaeftlichTextBox.Enabled = True
        TelefonPrivatTextBox.Enabled = True
        MobiltelefonTextBox.Enabled = True
        FaxnummerTextBox.Enabled = True
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        AdresseNeu = False
        lblAdresseNeu.Visible = False
        TC_Adresse.SelectedIndex = 0
        AdresseNeu = False
        OrtTextBox.BackColor = Color.White

        TC_Kontakt.SelectedIndex = 0
        lblKontaktNeu.Visible = False
        KontaktNeu = False
        NachnameTextBox.BackColor = Color.White

        LBL_Hinweis.Visible = False 'DocuWare-Hinweis

        'Felder auf der Belegseite leeren
        Select Case TC_Beleg.SelectedIndex
            Case 0
                TB_BBWeitereBesucher.Text = String.Empty
                TB_BBWeitereKontakte.Text = String.Empty
                TB_BBThema.Text = String.Empty
                TB_BBThema.BackColor = Color.White
            Case 1
                TB_DIVFaxnummer.Text = String.Empty
                TB_DIVFaxnummer.BackColor = Color.White

                TB_DIVThema.Text = String.Empty
                TB_DIVThema.BackColor = Color.White
        End Select



        AlleTableAdapterAktualisieren(CInt(LBL_IDFirmenName.Text))

    End Sub

    Private Sub LBL_IDAdresseZuKontakt_TextChanged(sender As Object, e As EventArgs) Handles LBL_IDAdresseZuKontakt.TextChanged
        'ID-Zuordnungslabel rot färben, wenn nicht zugeordnet
        If LBL_IDAdresseZuKontakt.Text = String.Empty And LBL_IDKontakt.Text <> String.Empty Or
            LBL_IDAdresseZuKontakt.Text = "0" And LBL_IDKontakt.Text <> String.Empty Then
            LBL_IDAdresseZuKontakt.Text = "Kontakt hat keine Adresse!"
            LBL_IDAdresseZuKontakt.ForeColor = Color.Red
        Else
            LBL_IDAdresseZuKontakt.ForeColor = Color.Black

            Dim IDAdresse = Val(LBL_IDAdresseZuKontakt.Text)
            StraßeLabel3.Text = KontakteMitAdresseTableAdapter.ScalarStrasseInKontakteMitAdresse(IDAdresse)
            OrtLabel3.Text = KontakteMitAdresseTableAdapter.ScalarOrtInKontakteMitAdresse(IDAdresse)



        End If
    End Sub

    Private Sub LBL_IDKontoZuAdresse_TextChanged(sender As Object, e As EventArgs) Handles LBL_IDKontoZuAdresse.TextChanged
        'ID-Zuordnungslabel rot färben, wenn nicht zugeordnet
        If LBL_IDKontoZuAdresse.Text = String.Empty And LBL_IDAdresse.Text <> String.Empty Or
            LBL_IDKontoZuAdresse.Text = "0" And LBL_IDAdresse.Text <> String.Empty Then
            LBL_IDKontoZuAdresse.Text = "Adresse nicht zugeordnet!"
            LBL_IDKontoZuAdresse.ForeColor = Color.Red
        Else
            LBL_IDKontoZuAdresse.ForeColor = Color.Black
        End If
    End Sub

    Private Sub LBL_IDAdresse_TextChanged(sender As Object, e As EventArgs) Handles LBL_IDAdresse.TextChanged
        If LBL_IDAdresse.Text = "" Then
            AdresstypTextBox.Enabled = False
            StraßeTextBox.Enabled = False
            PostfachTextBox.Enabled = False
            PLZTextBox.Enabled = False
            OrtTextBox.Enabled = False
            BundeslandTextBox.Enabled = False
            LandTextBox.Enabled = False
            UStIdNrTextBox.Enabled = False
            WebseiteTextBox.Enabled = False
            Try
                BTN_MapsSuche.Enabled = False
            Catch ex As Exception

            End Try
        Else
            AdresstypTextBox.Enabled = True
            StraßeTextBox.Enabled = True
            PostfachTextBox.Enabled = True
            PLZTextBox.Enabled = True
            OrtTextBox.Enabled = True
            BundeslandTextBox.Enabled = True
            LandTextBox.Enabled = True
            UStIdNrTextBox.Enabled = True
            WebseiteTextBox.Enabled = True
            Try
                BTN_MapsSuche.Enabled = True
            Catch ex As Exception

            End Try
        End If

        'ID-Zuordnungslabel rot färben: Falls es leer ist, das TextänderungsEvent auslösen für das Label:
        If LBL_IDKontoZuAdresse.Text = String.Empty And LBL_IDAdresse.Text <> String.Empty Then
            LBL_IDKontoZuAdresse.Text = "-"
        End If

        AdresseBauen()

    End Sub

    Private Sub LBL_IDKontakt_TextChanged(sender As Object, e As EventArgs) Handles LBL_IDKontakt.TextChanged
        'MsgBox("LBL_IDKontakt.TextChanged")
        Form3.LBL_IDKontakt.Text = Me.LBL_IDKontakt.Text

        'Wenn KEIN Kontakt, dann:
        If LBL_IDKontakt.Text = String.Empty Then
            AnredeComboBox.Enabled = False
            NachnameTextBox.Enabled = False
            VornameTextBox.Enabled = False
            EmailAddresseTextBox.Enabled = False
            PositionTextBox.Enabled = False
            TelefonGeschaeftlichTextBox.Enabled = False
            TelefonPrivatTextBox.Enabled = False
            MobiltelefonTextBox.Enabled = False
            FaxnummerTextBox.Enabled = False
            GB_Anrede.Enabled = False
            RB_OhneAnrede.Checked = True
            Try
                BTN_ZuOutlook.Enabled = False
            Catch ex As Exception

            End Try
        Else 'Wenn Kontakt, dann
            AnredeComboBox.Enabled = True
            NachnameTextBox.Enabled = True
            VornameTextBox.Enabled = True
            EmailAddresseTextBox.Enabled = True
            PositionTextBox.Enabled = True
            TelefonGeschaeftlichTextBox.Enabled = True
            TelefonPrivatTextBox.Enabled = True
            MobiltelefonTextBox.Enabled = True
            FaxnummerTextBox.Enabled = True
            GB_Anrede.Enabled = True
            RB_MitAnrede.Checked = True
            Try
                BTN_ZuOutlook.Enabled = True
            Catch ex As Exception

            End Try
            LBL_BBBesuchterKontakt.Text = LBL_Anrede.Text & " " & LBL_Vorname.Text & " " & LBL_Nachname.Text
        End If

        'ID-Zuordnungslabel rot färben: Falls es leer ist, das TextänderungsEvent auslösen für das Label:
        If LBL_IDAdresseZuKontakt.Text = String.Empty And LBL_IDKontakt.Text <> String.Empty Then
            LBL_IDAdresseZuKontakt.Text = "-"
        End If

        AdresseBauen()

    End Sub

    Private Sub BTN_ZuOutlook_Click(sender As Object, e As EventArgs) Handles BTN_ZuOutlook.Click

        Dim IDKontakt As Double = Val(LBL_IDKontakt.Text)
        Try
            Form3.KontakteMitAdresseTableAdapter.SucheAllesVonKontakt(Form3._WSL_AdressenDataSet.KontakteMitAdresse, IDKontakt)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Form3.LBL_FirmenName.Text = Me.LBL_FirmenName.Text
        Form3.Show()
    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub BTN_DocErzeugen_Click(sender As Object, e As EventArgs) Handles BTN_DocErzeugen.Click

        Dim BelegName As String
        IDBeleg = CInt(Me.KonfigurationTableAdapter.ScalarIDBeleg())
        Dim IDKonto As Integer

        'Die TabSeite mit 'Besuchsbericht' wird angezeigt, dann..
        If TC_Beleg.SelectedIndex = 0 Then

            If TB_BBThema.Text = String.Empty Then
                MsgBox("Bitte das Thema des Besuchs erfassen!", vbExclamation, "Neuen BB anlegen")
                TB_BBThema.Select()
                TB_BBThema.BackColor = Color.MistyRose
                Exit Sub
            End If


            'Falls die Adresse keine Konto-ID hat, wird die ID aus "Konto" gnommen!
            If LBL_BBIDKonto.Text <> String.Empty Then
                IDKonto = CInt(LBL_BBIDKonto.Text)
            Else
                IDKonto = CInt(lblIDKonto.Text)
            End If

            BelegName = "Besuchsbericht.dotx"

            'Datensatz Adresse hinzufügen
            Try
                BelegeTableAdapter.Insert(IDBeleg,
                                           CInt(LBL_IDFirmenName.Text),
                                           LBL_FirmenName.Text,
                                           DTP_BBDatum.Value,
                                           CInt(LBL_IDAdresse.Text),
                                           IDKonto,
                                           CB_BBKuerzel.Text,
                                           LBL_BBBesuchterKontakt.Text,
                                           TB_BBWeitereKontakte.Text,
                                           TB_BBThema.Text,
                                           TB_BBWeitereBesucher.Text,
                                            Environment.UserName,
                                            BelegName)

                'Nächsten Wert in der Konfig-Tabelle aktualisieren
                Me.KonfigurationTableAdapter.UpdateIDBeleg((IDBeleg + 1), IDBeleg)
                'MsgBox("Neuer Wert IDBesuch: " & Me.KonfigurationTableAdapter.ScalarIDBesuch())

                Logging(8, IDBeleg, CInt(LBL_IDFirmenName.Text), BelegName & " / " & TB_BBThema.Text) ' LogTabelle schreiben mit BB!

            Catch ex As System.Exception
                MsgBox("Fehler beim hinzufügen eines neuen Besuchsberichtes")
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            WordStarten(BelegName)

            'Aktuellen Satz in Tabelle markieren
            IDBBInBesucheMitAdresse(CInt(LBL_IDFirmenName.Text), IDBeleg)

        End If



        'Erzeugen eines anderen Beleges: #####################################################################

        If TC_Beleg.SelectedIndex = 1 Then
            BelegName = CB_Vorlagen.Text

            'Falls keine belege geladen werden konnten, kann auch kein Dokument erzeugt wertden:
            If BelegName = String.Empty Then Exit Sub

            'Das Feld Thema soll immer ausgefüllt sein:
            If TB_DIVThema.Text = String.Empty Then
                MsgBox("Bitte einen Betreff erfassen!", vbExclamation, "kein Betreff")
                TB_DIVThema.Select()
                TB_DIVThema.BackColor = Color.MistyRose
                Exit Sub
            End If

            'Falls die FAX-Vorlage gewählt wurde, sollte auch eine FAX-Nummer angegeben werden:
            If Mid(CB_Vorlagen.Text, 1, 3) = "Fax" And TB_DIVFaxnummer.Text = String.Empty Then
                MsgBox("Bitte eine Fax-Nummererfassen!", vbExclamation, "Faxnummer fehlt")
                TB_DIVFaxnummer.Select()
                TB_DIVFaxnummer.BackColor = Color.MistyRose
                Exit Sub
            End If

            'Falls die Adresse keine Konto-ID hat, wird die ID aus "Konto" gnommen!
            If LBL_DIVIDKonto.Text <> String.Empty Then
                IDKonto = CInt(LBL_DIVIDKonto.Text)
            Else
                IDKonto = CInt(lblIDKonto.Text)
            End If



            'Datensatz Adresse hinzufügen
            Try
                BelegeTableAdapter.Insert(IDBeleg,
                                       CInt(LBL_IDFirmenName.Text),
                                       LBL_FirmenName.Text,
                                       DTP_Diverse.Value,
                                       CInt(LBL_IDAdresse.Text),
                                       IDKonto,
                                       CB_DIVSachbearbeiter.Text,
                                       LBL_Anrede.Text & " " & LBL_Vorname.Text & " " & LBL_Nachname.Text,
                                       "",
                                       TB_DIVThema.Text,
                                       "",
                                        Environment.UserName,
                                        BelegName)

                'Nächsten Wert in der Konfig-Tabelle aktualisieren
                Me.KonfigurationTableAdapter.UpdateIDBeleg((IDBeleg + 1), IDBeleg)
                'MsgBox("Neuer Wert IDBesuch: " & Me.KonfigurationTableAdapter.ScalarIDBesuch())
                Logging(9, IDBeleg, CInt(LBL_IDFirmenName.Text), BelegName & " / " & TB_DIVThema.Text) ' LogTabelle schreiben mit BB!

            Catch ex As System.Exception
                MsgBox("Fehler beim hinzufügen eines neuen Besuchsberichtes")
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            WordStarten(BelegName)

            TB_DIVThema.BackColor = Color.White
            TB_DIVFaxnummer.BackColor = Color.White

            'Aktuellen Satz in Tabelle markieren
            IDBBInBesucheMitAdresse(CInt(LBL_IDFirmenName.Text), IDBeleg)

        End If


    End Sub

    Private Sub BenutzerlisteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BenutzerlisteToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub CB_Vorlagen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Vorlagen.SelectedIndexChanged
        'Wenn eine Vorlage ausgewählt wird, wirtd geschaut, ob die Vorlage ein Sprachkennzeichen enthält:
        Dim Datei As String = CB_Vorlagen.Text
        Dim Endung8 As String
        Dim Endung2 As String
        Endung8 = Microsoft.VisualBasic.Strings.Right(Datei, 8)
        Endung2 = Mid(Endung8, 1, 3)
        If Endung2 = "_UK" Then
            LBL_Sprache.Text = "englisch"
        Else
            LBL_Sprache.Text = "deutsch"
        End If
    End Sub

    Private Sub RB_OhneAnrede_CheckedChanged(sender As Object, e As EventArgs) Handles RB_OhneAnrede.CheckedChanged
        AdresseBauen()
    End Sub

    Private Sub RB_MitAnrede_CheckedChanged(sender As Object, e As EventArgs) Handles RB_MitAnrede.CheckedChanged
        AdresseBauen()
    End Sub

    Public Sub AdresseBauen()
        If RB_OhneAnrede.Checked = True Then
            Me.LBL_DIVAdresse.Text = Me.LBL_FirmenName.Text & vbNewLine &
                                    Me.LBL_Strasse.Text & vbNewLine &
                                    Me.LBL_PLZ.Text & " " & Me.LBL_Ort.Text & vbNewLine &
                                    Me.LBL_Land.Text
        ElseIf RB_MitAnrede.Checked = True Then
            Me.LBL_DIVAdresse.Text = Me.LBL_FirmenName.Text & vbNewLine &
                                    Me.LBL_Anrede.Text & " " & Me.LBL_Vorname.Text & " " & LBL_Nachname.Text & vbNewLine &
                                    Me.LBL_Strasse.Text & vbNewLine &
                                    Me.LBL_PLZ.Text & " " & Me.LBL_Ort.Text & vbNewLine &
                                    Me.LBL_Land.Text
        End If

    End Sub

    Private Sub LBL_Anrede_TextChanged(sender As Object, e As EventArgs) Handles LBL_Anrede.TextChanged
        AdresseBauen()
    End Sub

    Private Sub LBL_Sprache_TextChanged(sender As Object, e As EventArgs) Handles LBL_Sprache.TextChanged
        If LBL_Sprache.Text = "englisch" Then
            With LBL_DIVJobtitle
                .DataBindings.Clear()
                .DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "EnglJobtitle", True))
                .Enabled = True
            End With
        ElseIf LBL_Sprache.Text = "deutsch" Then
            With LBL_DIVJobtitle
                .DataBindings.Clear()
                .DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "Jobtitle", True))
                .Enabled = True
            End With
        End If
    End Sub


    Private Sub InfoÜberAdressenDBToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InfoÜberAdressenDBToolStripMenuItem1.Click
        AboutBox1.Show()
    End Sub

    Private Sub DocuWareDateiManuellToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocuWareDateiManuellToolStripMenuItem.Click
        SaveToCSV()
    End Sub

    Private Sub AktivitätslogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AktivitätslogToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub SchließenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SchließenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BTN_DeleteUser_Click(sender As Object, e As EventArgs) Handles BTN_DeleteUser.Click
        Dim IDKOntakt As Integer = CInt(LBL_IDKontakt.Text)
        Dim Nachname As String = NachnameTextBox.Text


        If KontaktNeu <> True Then

            Dim intAnswer As Integer
            intAnswer = MessageBox.Show("Ein Kontakt sollte nur dann gelöscht werden," & vbNewLine & "wenn er das Unternehmen verlassen hat!" & vbNewLine _
                         & vbNewLine & "Kontakt löschen?", "Kontakt löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            Select Case intAnswer
                Case vbYes
                    Try
                        KontakteTableAdapter.DeleteKontakt(IDKOntakt) ' LogTabelle schreiben
                    Catch ex As Exception
                        MsgBox("Fehler beim Löschen des Kontakts", vbExclamation)
                    End Try

                    Me.KontakteTableAdapter.SucheIDFirmenNameInKontakte(Me._WSL_AdressenDataSet.Kontakte, CType(LBL_IDFirmenName.Text, Integer?))
                    MsgBox("Kontakt gelöscht")
                    Logging(10, IDKOntakt, CInt(LBL_IDFirmenName.Text), Nachname)
                    TC_Kontakt.SelectedIndex = 0

                Case vbNo
                    'exit the procedure
                    Exit Sub

            End Select

        End If

    End Sub

    Private Sub HilfeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HilfeToolStripMenuItem.Click
        Dim Helplink As String = KonfigurationTableAdapter.ScalarHilfelink()
        System.Diagnostics.Process.Start(Helplink)
    End Sub
End Class