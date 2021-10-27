Public Class Form6


    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_WSL_AdressenDataSet.LogTabelle". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.LogTabelleTableAdapter.Fill(Me._WSL_AdressenDataSet.LogTabelle)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_WSL_AdressenDataSet.LogTabelle". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.LogTabelleTableAdapter.Fill(Me._WSL_AdressenDataSet.LogTabelle)

    End Sub

    Private Sub BTN_Aktuell_Click(sender As Object, e As EventArgs) Handles BTN_Aktuell.Click
        Dim IDFirmenName = Val(Hauptform.LBL_IDFirmenName.Text)
        Try
            Me.LogTabelleTableAdapter.SucheIDFirmenNameInLogtabelle(Me._WSL_AdressenDataSet.LogTabelle, IDFirmenName)
        Catch ex As System.Exception
            MsgBox("lblIDFirmenName ohne Inhalt - Fehler")

        End Try
    End Sub

    Private Sub LogTabelleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LogTabelleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._WSL_AdressenDataSet)

    End Sub



    Private Sub BTN_Schliessen_Click(sender As Object, e As EventArgs) Handles BTN_Schliessen.Click
        Me.Close()
    End Sub

    Private Sub BTN_Alle_Click(sender As Object, e As EventArgs) Handles BTN_Alle.Click
        Me.LogTabelleTableAdapter.Fill(Me._WSL_AdressenDataSet.LogTabelle)
    End Sub

End Class