Public Class Personensuche
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_IDKontakt.Text = String.Empty
        'LBL_FirmenName.Text = String.Empty

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LBL_IDKontakt.Text <> String.Empty Then
            Hauptform.TB_FirmenName.Text = LBL_FirmenName.Text
            Hauptform.BTN_Suche.PerformClick()

            Dim foundIndex As Integer = Hauptform.KontakteBindingSource.Find("IDKontakt", LBL_IDKontakt.Text)
            'MsgBox(foundIndex & " " & IDBeleg)
            Hauptform.KontakteBindingSource.Position = foundIndex
        End If

        Me.Close()

    End Sub
End Class