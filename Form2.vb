

Public Class KontoForm

    Dim IDFirmenName As Integer

    Private Sub KontoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.PropertiesTableAdapter.Fill(Me._WSL_AdressenDataSet.properties)

        IDFirmenName = CInt(Hauptform.LBL_IDFirmenName.Text)
        Me.lblIDFirmenName.Text = IDFirmenName.ToString
        lblFirmenName.Text = Hauptform.LBL_FirmenName.Text

        lblKontoNummer.Text = String.Empty

        Try
            Me.KontoTableAdapter.SucheIDFirmenNameInKonto(_WSL_AdressenDataSet.Konto, IDFirmenName)
            'Me.FirmenNameTableAdapter.SucheAktiveIDFirmenNameInFirmenName(_WSL_AdressenDataSet.FirmenName, IDFirmenName)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnKontoSave_Click(sender As Object, e As EventArgs) Handles btnKontoSave.Click

        Dim KontoName As String = ""

        If rdbKundenNr.Checked = True Then
            KontoName = "Kunde"
            Dim KundenNummer As Double = Val(Me.PropertiesTableAdapter.ScalarWert("Kundennummer"))
            lblKontoNummer.Text = KundenNummer.ToString
            Me.PropertiesTableAdapter.UpdateWert(CStr(KundenNummer + 1), "KundenNummer")

        ElseIf rdbLieferantenNr.Checked = True Then
            KontoName = "Lieferant"
            Dim LieferantenNummer As Double = Val(Me.PropertiesTableAdapter.ScalarWert("Lieferantennummer"))
            lblKontoNummer.Text = LieferantenNummer.ToString
            Me.PropertiesTableAdapter.UpdateWert(CStr(LieferantenNummer + 1), "LieferantenNummer")

        End If

        Me.Refresh()

        'die neuen Daten in die Tabelle 'Konto' schreiben: 
        Dim IDKonto As Integer = CInt(lblKontoNummer.Text)
        Dim IDFirmenName As Integer = CInt(lblIDFirmenName.Text)
        KontoTableAdapter.Insert(IDKonto, IDFirmenName, KontoName, Now)

        Logging(2, IDKonto, IDFirmenName, KontoName) ' LogTabelle schreiben


        'Das DataGrid auf dem Hauptform aktualisieren (TableAdapter mit allen + neuen Werten füllen --> Suche ausführen)
        Try
            KontoTableAdapter.SucheIDFirmenNameInKonto(_WSL_AdressenDataSet.Konto, IDFirmenName)
            Hauptform.KontoTableAdapter.SucheIDFirmenNameInKonto(Hauptform._WSL_AdressenDataSet.Konto, IDFirmenName)
            Hauptform.DocuwareCSVTableAdapter.Fill(Hauptform._WSL_AdressenDataSet.DocuwareCSV)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        'Neue Docuware-Datei schreiben...
        SaveToCSV()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

End Class