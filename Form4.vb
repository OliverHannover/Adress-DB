Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BelegeTableAdapter.Fill(Me._WSL_AdressenDataSet.Belege)
        Me.KontakteTableAdapter.Fill(Me._WSL_AdressenDataSet.Kontakte)
        Me.AdressenTableAdapter.Fill(Me._WSL_AdressenDataSet.Adressen)
        Me.KontoTableAdapter.Fill(Me._WSL_AdressenDataSet.Konto)
        Me.FirmenNameTableAdapter.Fill(Me._WSL_AdressenDataSet.FirmenName)
        Me.SachbearbeiterTableAdapter.FillByAktive(Me._WSL_AdressenDataSet.Sachbearbeiter)
        Me.KonfigurationTableAdapter.Fill(Me._WSL_AdressenDataSet.Konfiguration)

        Dim foundIndex As Integer = SachbearbeiterBindingSource.Find("Login", Environment.UserName)
        SachbearbeiterBindingSource.Position = foundIndex
        If AdminCheckBox.Checked = True Then
            TC_Administration.Enabled = True
            BTN_Alle.Enabled = True
            BTN_Aktuell.Enabled = True
        Else
            TC_Administration.Enabled = False
            BTN_Alle.Enabled = False
            BTN_Aktuell.Enabled = False
        End If


    End Sub

    Private Sub BTN_Vorlagenpfad_Click(sender As Object, e As EventArgs) Handles BTN_Vorlagenpfad.Click
        'MsgBox("Vorlagenpfad ist " & Me.KonfigurationTableAdapter.ScalarVorlagenpfad().ToString)

        FolderBrowserDialog1.SelectedPath = Me.KonfigurationTableAdapter.ScalarVorlagenpfad().ToString
        FolderBrowserDialog1.ShowDialog()
        Dim files As String = FolderBrowserDialog1.SelectedPath
        VorlagenpfadTextBox.Text = files & "\"
    End Sub

    Private Sub BTN_Schliessen_Click(sender As Object, e As EventArgs) Handles BTN_Schliessen.Click

        Me.Close()
    End Sub

    Private Sub BTN_Speichern_Click(sender As Object, e As EventArgs) Handles BTN_Speichern.Click
        Try
            KonfigurationTableAdapter.UpdateAlles(CInt(IDFirmenNameTextBox.Text),
                                                 CInt(LeadnummerTextBox.Text),
                                                 CInt(KundennummerTextBox.Text),
                                                 CInt(LieferantennummerTextBox.Text),
                                                 CInt(IDAdresseTextBox.Text),
                                                 CInt(IDKontaktTextBox.Text),
                                                 CInt(IDBesuchTextBox.Text),
                                                 VorlagenpfadTextBox.Text,
                                                 DWpfadTextBox.Text,
                                                 DWDateinameTextBox.Text,
                                                 HilfelinkTextBox.Text)
        Catch ex As Exception
            MsgBox("Update der Konfigurations-Tabelle fehlgeschlagen")

        End Try
        MsgBox("Update der Konfigurations-Tabelle erfolgreich")

    End Sub


    Private Sub BTN_Aktuell_Click(sender As Object, e As EventArgs) Handles BTN_Aktuell.Click

        Dim IDFirmenName As Integer
        If Hauptform.LBL_IDFirmenName.Text <> String.Empty Then IDFirmenName = CInt(Hauptform.LBL_IDFirmenName.Text)
        Try
            Me.FirmenNameTableAdapter.SucheAktiveIDFirmenNameInFirmenName(Me._WSL_AdressenDataSet.FirmenName, IDFirmenName)
            Me.KontoTableAdapter.SucheIDFirmenNameInKonto(Me._WSL_AdressenDataSet.Konto, IDFirmenName)
            Me.AdressenTableAdapter.SucheIDFirmenNameInAdressen(Me._WSL_AdressenDataSet.Adressen, IDFirmenName)
            Me.KontakteTableAdapter.SucheIDFirmenNameInKontakte(Me._WSL_AdressenDataSet.Kontakte, IDFirmenName)
            Me.BelegeTableAdapter.SucheIDFirmenNameInBelege(Me._WSL_AdressenDataSet.Belege, IDFirmenName)
        Catch ex As System.Exception
            MsgBox("lblIDFirmenName ohne Inhalt - Fehler")
        End Try

        AlleTableAdapterAktualisieren(IDFirmenName)
    End Sub

    Private Sub BTN_Alle_Click(sender As Object, e As EventArgs) Handles BTN_Alle.Click
        Me.KontakteTableAdapter.Fill(Me._WSL_AdressenDataSet.Kontakte)
        Me.AdressenTableAdapter.Fill(Me._WSL_AdressenDataSet.Adressen)
        Me.KontoTableAdapter.Fill(Me._WSL_AdressenDataSet.Konto)
        Me.FirmenNameTableAdapter.Fill(Me._WSL_AdressenDataSet.FirmenName)
        Me.BelegeTableAdapter.Fill(Me._WSL_AdressenDataSet.Belege)
    End Sub

    Private Sub BTN_DWPfad_Click(sender As Object, e As EventArgs) Handles BTN_DWPfad.Click
        'MsgBox("DW-Dateinpfad ist " & Me.KonfigurationTableAdapter.ScalarDWPfad().ToString)

        FolderBrowserDialog1.SelectedPath = Me.KonfigurationTableAdapter.ScalarDWPfad().ToString
        FolderBrowserDialog1.ShowDialog()
        Dim files As String = FolderBrowserDialog1.SelectedPath
        DWpfadTextBox.Text = files & "\"
    End Sub

    Private Sub BNAV_BelegeSaveItem_Click(sender As Object, e As EventArgs) Handles BNAV_BelegeSaveItem.Click
        Me.Validate()
        Me.BelegeBindingSource.EndEdit()
        Me.BelegeTableAdapter.Update(Me._WSL_AdressenDataSet.Belege)

        BTN_Aktuell.PerformClick()

    End Sub

    Private Sub BNAV_FirmenNameSave_Click(sender As Object, e As EventArgs) Handles BNAV_FirmenNameSave.Click
        Me.Validate()
        Me.FirmenNameBindingSource.EndEdit()
        Me.FirmenNameTableAdapter.Update(Me._WSL_AdressenDataSet.FirmenName)

        BTN_Aktuell.PerformClick()
    End Sub

    Private Sub BNAV_KontoSave_Click(sender As Object, e As EventArgs) Handles BNAV_KontoSave.Click
        Me.Validate()
        Me.KontoBindingSource.EndEdit()
        Me.KontoTableAdapter.Update(Me._WSL_AdressenDataSet.Konto)

        BTN_Aktuell.PerformClick()
    End Sub

    Private Sub BNAV_AdressenSave_Click(sender As Object, e As EventArgs) Handles BNAV_AdressenSave.Click
        Me.Validate()
        Me.AdressenBindingSource.EndEdit()
        Me.AdressenTableAdapter.Update(Me._WSL_AdressenDataSet.Adressen)

        BTN_Aktuell.PerformClick()
    End Sub

    Private Sub BNAV_KontakteSave_Click(sender As Object, e As EventArgs) Handles BNAV_KontakteSave.Click
        Me.Validate()
        Me.KontakteBindingSource.EndEdit()
        Me.KontakteTableAdapter.Update(Me._WSL_AdressenDataSet.Kontakte)

        BTN_Aktuell.PerformClick()
    End Sub
End Class