Imports System.ComponentModel

Public Class Sachbearbeiter

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_WSL_AdressenDataSet.Sachbearbeiter". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.SachbearbeiterTableAdapter.Fill(Me._WSL_AdressenDataSet.Sachbearbeiter)


        Dim foundIndex As Integer = SachbearbeiterBindingSource.Find("Login", Environment.UserName)
        SachbearbeiterBindingSource.Position = foundIndex
        If AdminCheckBox.Checked = True Then
            PNL_Admin.Enabled = True
        End If


        lblBenutzerNeu.Visible = False

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
            Hauptform.BTN_Speichern.Visible = True
            Hauptform.BTN_DocErzeugen.Visible = True

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

    Private Sub BTN_NeuerSachbearbeiter_Click(sender As Object, e As EventArgs) Handles BTN_NeuerSachbearbeiter.Click
        lblBenutzerNeu.Visible = True


        With SachbearbeiterTextBox
            .DataBindings.Clear()
            .Text = String.Empty
        End With
        With KuerzelTextBox
            .DataBindings.Clear()
            .Text = String.Empty
        End With
        With LoginTextBox
            .DataBindings.Clear()
            .Text = Environment.UserName
        End With
        With DurchwahlTextBox
            .DataBindings.Clear()
            .Text = String.Empty
        End With
        With EmailTextBox
            .DataBindings.Clear()
            .Text = String.Empty
        End With
        With JobtitleTextBox
            .DataBindings.Clear()
            .Text = String.Empty
        End With
        With EnglJobtitleTextBox
            .DataBindings.Clear()
            .Text = String.Empty
        End With
    End Sub

    Private Sub BTN_Speichern_Click(sender As Object, e As EventArgs) Handles BTN_Speichern.Click

        'Prüfen, ob alle Felder ausgefüllt wurden
        For Each ctrl As Control In Me.PNL_Edit.Controls
            If TypeOf (ctrl) Is TextBox And ctrl.Text = String.Empty Then
                MsgBox("Bitte alle Felder ausfüllen!")
                Exit Sub
            End If
        Next

        If lblBenutzerNeu.Visible = True Then
            SachbearbeiterTableAdapter.Insert(SachbearbeiterTextBox.Text,
                                              LoginTextBox.Text,
                                              KuerzelTextBox.Text,
                                              Val(DurchwahlTextBox.Text),
                                              EmailTextBox.Text,
                                              JobtitleTextBox.Text,
                                              EnglJobtitleTextBox.Text,
                                              AktivCheckBox.Checked,
                                              False,
                                              False)
            'MsgBox("insert")
        ElseIf lblBenutzerNeu.Visible = False Then
            Try
                Me.Validate()
                Me.SachbearbeiterBindingSource.EndEdit()
                Me.SachbearbeiterTableAdapter.Update(Me._WSL_AdressenDataSet.Sachbearbeiter)

                'MsgBox("update " & CInt(IDSachbearbeiterLabel1.Text))
            Catch ex As Exception
                MsgBox("Update des Sachbearbeiters fehlgeschlagen", vbExclamation)
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try


        End If

        Me.SachbearbeiterTableAdapter.Fill(Me._WSL_AdressenDataSet.Sachbearbeiter)

        With SachbearbeiterTextBox
            .DataBindings.Clear()
            .DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "Sachbearbeiter", True))
        End With
        With KuerzelTextBox
            .DataBindings.Clear()
            .DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "Kuerzel", True))
        End With
        With LoginTextBox
            .DataBindings.Clear()
            .DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "Login", True))
        End With
        With DurchwahlTextBox
            .DataBindings.Clear()
            .DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "Durchwahl", True))
        End With
        With EmailTextBox
            .DataBindings.Clear()
            .DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "Email", True))
        End With
        With JobtitleTextBox
            .DataBindings.Clear()
            .DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "Jobtitle", True))
        End With
        With EnglJobtitleTextBox
            .DataBindings.Clear()
            .DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "EnglJobtitle", True))
        End With

        Dim foundIndex As Integer = SachbearbeiterBindingSource.Find("Login", Environment.UserName)
            SachbearbeiterBindingSource.Position = foundIndex

        lblBenutzerNeu.Visible = False

    End Sub


End Class