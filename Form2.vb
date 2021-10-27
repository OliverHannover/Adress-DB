Public Class KontoForm
    Public KundenNummer As Double
    Public LieferantenNummer As Double

    Private Sub KontoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_WSL_AdressenDataSet.Konfiguration". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.KonfigurationTableAdapter.Fill(Me._WSL_AdressenDataSet.Konfiguration)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_WSL_AdressenDataSet.FirmenName". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.FirmenNameTableAdapter.Fill(Me._WSL_AdressenDataSet.FirmenName)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_WSL_AdressenDataSet.Konto". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.KontoTableAdapter.Fill(Me._WSL_AdressenDataSet.Konto)
        Me.lblIDFirmenName.Text = Hauptform.LBL_IDFirmenName.Text.ToString

        Dim IDFirmenName As Integer
        IDFirmenName = CInt(lblIDFirmenName.Text)

        Try
            Me.KontoTableAdapter.SucheIDFirmenNameInKonto(_WSL_AdressenDataSet.Konto, IDFirmenName)
            Me.FirmenNameTableAdapter.SucheAktiveIDFirmenNameInFirmenName(_WSL_AdressenDataSet.FirmenName, IDFirmenName)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Nächsten freien Nummern holen und anzeigen:
        KundenNummer = Val(Me.KonfigurationTableAdapter.ScalarKundennummer())
        LieferantenNummer = Val(Me.KonfigurationTableAdapter.ScalarLieferantennummer())

        lblKundenNr.Text = KundenNummer.ToString
        lblLieferantenNr.Text = LieferantenNummer.ToString

    End Sub

    Private Sub rdbKundenNr_CheckedChanged(sender As Object, e As EventArgs) Handles rdbKundenNr.CheckedChanged
        lblLieferantenNr.Enabled = False
        lblKundenNr.Enabled = True
    End Sub

    Private Sub rdbLieferantenNr_CheckedChanged(sender As Object, e As EventArgs) Handles rdbLieferantenNr.CheckedChanged
        lblLieferantenNr.Enabled = True
        lblKundenNr.Enabled = False
    End Sub

    Private Sub btnKontoSave_Click(sender As Object, e As EventArgs) Handles btnKontoSave.Click

        Dim IDKonto As Integer
        Dim IDFirmenName As Integer = CInt(lblIDFirmenName.Text)
        Dim KontoName As String = ""

        If rdbKundenNr.Checked = True Then
            IDKonto = CInt(lblKundenNr.Text)
            KontoName = "Kunde"
            Me.KonfigurationTableAdapter.UpdateKundennummer(CInt(KundenNummer + 1), CInt(KundenNummer))
        ElseIf rdbLieferantenNr.Checked = True Then
            IDKonto = CInt(lblLieferantenNr.Text)
            KontoName = "Lieferant"
            Me.KonfigurationTableAdapter.UpdateLieferantennummer(CInt(LieferantenNummer + 1), CInt(LieferantenNummer))
        End If

        KontoTableAdapter.Insert(IDKonto, IDFirmenName, KontoName, Now)
        Logging(2, IDKonto, IDFirmenName, KontoName) ' LogTabelle schreiben

        'Das DataGrid auf dem Hauptform aktualisieren (TableAdapter mit allen + neuen Werten füllen --> Suche ausführen)
        Dim IDAdNr As Double
        IDAdNr = Val(Hauptform.LBL_IDFirmenName.Text)
        Try
            Hauptform.KontoTableAdapter.SucheIDFirmenNameInKonto(Hauptform._WSL_AdressenDataSet.Konto, New System.Nullable(Of Decimal)(CType(IDAdNr, Decimal)))
            Hauptform.DocuwareCSVTableAdapter.Fill(Hauptform._WSL_AdressenDataSet.DocuwareCSV)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Neue Docuware-Datei schreiben...
        SaveToCSV()

        Me.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class