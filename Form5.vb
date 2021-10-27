Imports System.ComponentModel

Public Class Form5
    Private Sub SachbearbeiterBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SachbearbeiterBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SachbearbeiterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._WSL_AdressenDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_WSL_AdressenDataSet.Sachbearbeiter". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.SachbearbeiterTableAdapter.Fill(Me._WSL_AdressenDataSet.Sachbearbeiter)


        Dim foundIndex As Integer = SachbearbeiterBindingSource.Find("Login", Environment.UserName)
        SachbearbeiterBindingSource.Position = foundIndex
        If AdminCheckBox.Checked = True Then
            PNL_Admin.Enabled = True
            BindingNavigatorDeleteItem.Enabled = True
        End If

    End Sub

    Private Sub BTN_Schliessen_Click(sender As Object, e As EventArgs) Handles BTN_Schliessen.Click

        Dim foundIndex As Integer = SachbearbeiterBindingSource.Find("Login", Environment.UserName)
        'MsgBox(foundIndex)
        If foundIndex <> -1 Then
            'Tabelle ist noch mit ALLEN Usern gefüllt!...
            Hauptform.SachbearbeiterBindingSource.Position = Hauptform.SachbearbeiterBindingSource.Find("Login", Environment.UserName)
            Hauptform.lblUser.ForeColor = Color.Black
            Hauptform.lblUser.Text = SachbearbeiterTableAdapter.ScalarSachbearbeiter(foundIndex + 1)

            'anschließend Tabelle mit aktiven Usern füllen und den gefundenen markieren:
            Hauptform.SachbearbeiterTableAdapter.FillByAktive(Hauptform._WSL_AdressenDataSet.Sachbearbeiter)
            Hauptform.SachbearbeiterBindingSource.Position = Hauptform.SachbearbeiterBindingSource.Find("Login", Environment.UserName)

        Else
            MsgBox("Ihr Login wurde nicht erkannt. Bitte Ihre Benutzerdaten prüfen/korrigieren oder ergänzen.", vbExclamation)
            Hauptform.lblUser.Text = "Sachbearbeiter nicht erkannt"
            Hauptform.lblUser.ForeColor = Color.Red
        End If


        Me.Close()

    End Sub

    Private Sub SachbearbeiterBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles SachbearbeiterBindingSource.PositionChanged
        'MsgBox(SachbearbeiterBindingSource.Position)
        Select Case SachbearbeiterBindingSource.Position
            Case 0 To 1
                PNL_Edit.Enabled = False
            Case Else
                PNL_Edit.Enabled = Enabled
        End Select
    End Sub
End Class