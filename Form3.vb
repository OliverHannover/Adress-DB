Option Strict Off
Public Class Form3

    Dim tmpContact As Contact

    ' declared like Outlook does
    Private Const olFolderContacts As Long = 10

    ' Log errors into this file (File path is App.Path)
    'Private Const errFile As String = "error.log"

    ' Switch to turn off the logging functionality
    ' Shouldn't be turned off, only unexpected errors were logged
    Private Const doErrorLogging As Boolean = True


    Public Structure Contact
        Public CompanyName As String
        Public LastName As String
        Public FirstName As String
        Public JobTitle As String
        Public Email1Address As String
        Public BusinessTelephoneNumber As String
        Public HomeTelephoneNumber As String
        Public MobileTelephoneNumber As String
        Public BusinessFaxNumber As String
        Public BusinessAddressStreet As String
        Public BusinessAddressPostalCode As String
        Public BusinessAddressCity As String
        Public BusinessAddressState As String
        Public BusinessAddressCountry As String
        Public BusinessHomePage As String
    End Structure

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_WSL_AdressenDataSet.KontakteMitAdresse". Sie können sie bei Bedarf verschieben oder entfernen.
        ' Me.KontakteMitAdresseTableAdapter.Fill(Me._WSL_AdressenDataSet.KontakteMitAdresse)

        Initialisierung()

    End Sub

    Public Function Initialisierung() As Boolean

        PNL_GefundenerKontakt.Visible = False
        LBL_Hinweis.Visible = True

        Dim olContID As Integer
        Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        olContID = findContact(LBL_FirmenName.Text, NachnameLabel1.Text, VornameLabel1.Text)
        LBL_olContID.Text = CStr(olContID)

        If olContID <> 0 Then
            Initialisierung = True
            'With getContact(findContact(LBL_FirmenName.Text, NachnameLabel1.Text, VornameLabel1.Text))
            With getContact(olContID)
                LBLGEF_FirmenName.Text = .CompanyName
                LBLGEF_Nachname.Text = .LastName
                LBLGEF_Vorname.Text = .FirstName
                LBLGEF_Position.Text = .JobTitle
                LBLGEF_Email.Text = .Email1Address
                LBLGEF_TelefonGesch.Text = .BusinessTelephoneNumber
                LBLGEF_TelefonPriv.Text = .HomeTelephoneNumber
                LBLGEF_Mobiltelefon.Text = .MobileTelephoneNumber
                LBLGEF_Faxnummer.Text = .BusinessFaxNumber
                LBLGEF_Strasse.Text = .BusinessAddressStreet
                LBLGEF_PLZ.Text = .BusinessAddressPostalCode
                LBLGEF_Ort.Text = .BusinessAddressCity
                LBLGEF_Bundesland.Text = .BusinessAddressState
                LBLGEF_Land.Text = .BusinessAddressCountry
                LBLGEF_Website.Text = .BusinessHomePage
            End With
            PNL_GefundenerKontakt.Visible = True
            LBL_Hinweis.Visible = False
        Else
            Initialisierung = False
        End If

        Cursor.Current = System.Windows.Forms.Cursors.Default

    End Function


    Private Sub BTN_hinzufügen_Click(sender As Object, e As EventArgs) Handles BTN_hinzufügen.Click
        If PNL_GefundenerKontakt.Visible = True Then

            Dim Result As DialogResult
            Result = MessageBox.Show("Der Kontakt ist bereits vorhanden. Soll der Kontakt 'zusätzlich' hinzugefügt werden?", "Kontakt hinzufügen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                ' Einfach nichts machen, weiter in der Funktion...
            ElseIf Result = System.Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If


        Dim newContact As Contact

        With newContact
            .CompanyName = LBL_FirmenName.Text
            .LastName = NachnameLabel1.Text
            .FirstName = VornameLabel1.Text
            .JobTitle = PositionLabel1.Text
            .Email1Address = EmailAddresseLabel1.Text
            .BusinessTelephoneNumber = TelefonGeschaeftlichLabel1.Text
            .HomeTelephoneNumber = TelefonPrivatLabel1.Text
            .MobileTelephoneNumber = MobiltelefonLabel1.Text
            .BusinessFaxNumber = FaxnummerLabel1.Text
            .BusinessAddressStreet = StraßeLabel1.Text
            .BusinessAddressPostalCode = PLZLabel1.Text
            .BusinessAddressCity = OrtLabel1.Text
            .BusinessAddressState = BundeslandLabel1.Text
            .BusinessAddressCountry = LandLabel1.Text
            .BusinessHomePage = WebseiteLabel1.Text
        End With

        If addContact(newContact) <> 0 Then
            MsgBox("Kontakt erfolgreich hinzugefügt")
            Me.Close()
        Else
            MsgBox("Hinzufügen des Kontaktes ist fehlgeschlagen")
            Me.Close()
        End If


    End Sub


    Public Function isOutlookInstalled() As Boolean
        ' Tries to create an instance of Outlook
        ' Returnes true if successful, otherwise false

        Dim olApp As Object

        On Error GoTo errHandler

        olApp = CreateObject("Outlook.Application")
        isOutlookInstalled = True
        olApp = Nothing

        Exit Function
errHandler:
        If Err.Number = 429 Then
            ' Can't create Object -> Outlook is not installed
            ' Don't need to log as error.
        Else
            MsgBox("Function isOutlookInstalled() returned with error")
        End If
        isOutlookInstalled = False
    End Function

    Public Function getContactFolderCount() As Integer
        ' Returnes the number of contacts in the Outlook contacts folder,
        ' returnes zero if Outlook is not installed

        Dim olApp As Object
        Dim olNameSpace As Object
        Dim olFolder As Object

        On Error GoTo errHandler

        If Not isOutlookInstalled() Then
            getContactFolderCount = 0
        Else
            olApp = CreateObject("Outlook.Application")
            olNameSpace = olApp.GetNamespace("MAPI")
            olFolder = olNameSpace.GetDefaultFolder(olFolderContacts)

            getContactFolderCount = olFolder.Items.Count

            olFolder = Nothing
            olNameSpace = Nothing
            olApp = Nothing
        End If

        Exit Function
errHandler:
        MsgBox("Function getContactFolderCount() returned with error")
        getContactFolderCount = 0
    End Function

    Public Function getContact(index As Integer) As Contact
        ' Returnes the Outlook contact information of the entry,
        ' containes only the information which siemens mobile supports.
        ' Returnes Nothing if Outlook is not installed or
        ' the specified entry doesn't exist.

        Dim olApp As Object
        Dim olNameSpace As Object
        Dim olFolder As Object
        Dim olContact As Object


        On Error GoTo errHandler

        If Not isOutlookInstalled() Then
            'getContact = Nothing
        ElseIf getContactFolderCount() < index Then
            'getContact = Nothing
        Else
            olApp = CreateObject("Outlook.Application")
            olNameSpace = olApp.GetNamespace("MAPI")
            olFolder = olNameSpace.GetDefaultFolder(olFolderContacts)
            olContact = olFolder.Items(index)

            With tmpContact
                .CompanyName = olContact.CompanyName
                .LastName = olContact.LastName
                .FirstName = olContact.FirstName
                .JobTitle = olContact.JobTitle
                .Email1Address = olContact.Email1Address
                .BusinessTelephoneNumber = olContact.BusinessTelephoneNumber
                .HomeTelephoneNumber = olContact.HomeTelephoneNumber
                .MobileTelephoneNumber = olContact.MobileTelephoneNumber
                .BusinessFaxNumber = olContact.BusinessFaxNumber
                .BusinessAddressStreet = olContact.BusinessAddressStreet
                .BusinessAddressPostalCode = olContact.BusinessAddressPostalCode
                .BusinessAddressCity = olContact.BusinessAddressCity
                .BusinessAddressState = olContact.BusinessAddressState
                .BusinessAddressCountry = olContact.BusinessAddressCountry
                .BusinessHomePage = olContact.BusinessHomePage
            End With


            olContact = Nothing
            olFolder = Nothing
            olNameSpace = Nothing
            olApp = Nothing

            getContact = tmpContact
        End If

        Exit Function
errHandler:
        MsgBox("Function getContact() returned with error")
        'getContact = Nothing
    End Function

    Public Function modifyContact(index As Integer, modContact As Contact) As Boolean
        ' Sets the new information to the outlook contact entry
        ' with the specified index.
        ' Returnes True if successful, 
        ' otherwise False (e.G. if entry doesn't exist)

        Dim olApp As Object
        Dim olNameSpace As Object
        Dim olFolder As Object
        Dim olContact As Object

        On Error GoTo errHandler

        If Not isOutlookInstalled() Then
            modifyContact = False
        ElseIf getContactFolderCount() < index Then
            modifyContact = False
        Else
            olApp = CreateObject("Outlook.Application")
            olNameSpace = olApp.GetNamespace("MAPI")
            olFolder = olNameSpace.GetDefaultFolder(olFolderContacts)
            olContact = olFolder.Items(index)

            With olContact
                .CompanyName = modContact.CompanyName
                .LastName = modContact.LastName
                .FirstName = modContact.FirstName
                .JobTitle = modContact.JobTitle
                .Email1Address = modContact.Email1Address
                .BusinessTelephoneNumber = modContact.BusinessTelephoneNumber
                .HomeTelephoneNumber = modContact.HomeTelephoneNumber
                .MobileTelephoneNumber = modContact.MobileTelephoneNumber
                .BusinessFaxNumber = modContact.BusinessFaxNumber
                .BusinessAddressStreet = modContact.BusinessAddressStreet
                .BusinessAddressPostalCode = modContact.BusinessAddressPostalCode
                .BusinessAddressCity = modContact.BusinessAddressCity
                .BusinessAddressState = modContact.BusinessAddressState
                .BusinessAddressCountry = modContact.BusinessAddressCountry
                .BusinessHomePage = modContact.BusinessHomePage
                .Save
            End With

            olContact = Nothing
            olFolder = Nothing
            olNameSpace = Nothing
            olApp = Nothing

            modifyContact = True
        End If

        Exit Function
errHandler:
        MsgBox("Function modifyContact() returned with error")
        modifyContact = False
    End Function

    Public Function addContact(newContact As Contact) As Integer
        ' Adds the new contact to the outlook contact folder
        ' Returnes Tthe index of the new entry, Zero if creation failed

        Dim olApp As Object
        Dim olNameSpace As Object
        Dim olFolder As Object
        Dim olContact As Object

        On Error GoTo errHandler

        If Not isOutlookInstalled() Then
            addContact = 0
        Else
            olApp = CreateObject("Outlook.Application")
            olNameSpace = olApp.GetNamespace("MAPI")
            olFolder = olNameSpace.GetDefaultFolder(olFolderContacts)
            olContact = olFolder.Items.Add

            With olContact
                .CompanyName = newContact.CompanyName
                .LastName = newContact.LastName
                .FirstName = newContact.FirstName
                .JobTitle = newContact.JobTitle
                .Email1Address = newContact.Email1Address
                .BusinessTelephoneNumber = newContact.BusinessTelephoneNumber
                .HomeTelephoneNumber = newContact.HomeTelephoneNumber
                .MobileTelephoneNumber = newContact.MobileTelephoneNumber
                .BusinessFaxNumber = newContact.BusinessFaxNumber
                .BusinessAddressStreet = newContact.BusinessAddressStreet
                .BusinessAddressPostalCode = newContact.BusinessAddressPostalCode
                .BusinessAddressCity = newContact.BusinessAddressCity
                .BusinessAddressState = newContact.BusinessAddressState
                .BusinessAddressCountry = newContact.BusinessAddressCountry
                .BusinessHomePage = newContact.BusinessHomePage
                .Save
            End With

            olContact = Nothing
            olFolder = Nothing
            olNameSpace = Nothing
            olApp = Nothing

            addContact = getContactFolderCount()
        End If

        Exit Function
errHandler:
        MsgBox("Function addContact() returned with error")
        addContact = 0
    End Function

    Public Function deleteContact(index As Integer) As Boolean
        ' Deletes the specified entry from the Outlook contact folder
        ' Returnes True if successful, 
        ' otherwise False (e.G. if entry doesn't exist)
        'MsgBox("deleteContact aufgerufen")

        Dim olApp As Object
        Dim olNameSpace As Object
        Dim olFolder As Object
        Dim olContact As Object

        On Error GoTo errHandler

        If Not isOutlookInstalled() Then
            deleteContact = False
        ElseIf getContactFolderCount() < index Then
            deleteContact = False
        Else
            olApp = CreateObject("Outlook.Application")
            olNameSpace = olApp.GetNamespace("MAPI")
            olFolder = olNameSpace.GetDefaultFolder(olFolderContacts)
            olContact = olFolder.Items(index)

            olContact.Delete

            olContact = Nothing
            olFolder = Nothing
            olNameSpace = Nothing
            olApp = Nothing

            deleteContact = True
        End If

        Exit Function
errHandler:
        MsgBox("Function deleteContact() returned with error")
        deleteContact = False
    End Function

    Public Function findContact(FirmenName As String, LastName As String, Optional FirstName As String = vbNullString) As Integer
        ' Searches for specified entry in the Outlook contact folder
        ' Returnes the index if found, otherwise Zero

        Dim olApp As Object
        Dim olNameSpace As Object
        Dim olFolder As Object 'Object
        Dim olContact As Object 'Object

        Dim i As Integer

        On Error GoTo errHandler

        If Not isOutlookInstalled() Then
            findContact = 0
        Else
            olApp = CreateObject("Outlook.Application")
            olNameSpace = olApp.GetNamespace("MAPI")
            olFolder = olNameSpace.GetDefaultFolder(olFolderContacts)

            findContact = 0

            For i = 1 To olFolder.Items.Count
                'MsgBox(olFolder.Items.Count)
                olContact = olFolder.Items(i)

                If LCase(olContact.LastName) = LCase(LastName) And LCase(olContact.CompanyName) = LCase(FirmenName) Then
                    If FirstName = "" Then
                        findContact = i
                        Exit For
                    ElseIf olContact.FirstName = FirstName Then
                        findContact = i
                        Exit For
                    End If
                End If
            Next i

            olContact = Nothing
            olFolder = Nothing
            olNameSpace = Nothing
            olApp = Nothing
        End If

        'MsgBox("Kontakt-Nummer: " & findContact)
        Exit Function
errHandler:
        MsgBox("Function findContact() returned with error")
        findContact = 0
    End Function



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BTN_aktualisieren_Click(sender As Object, e As EventArgs) Handles BTN_aktualisieren.Click
        Dim modContact As Contact
        Dim Index As Integer
        Index = Val(LBL_olContID.Text)

        With modContact
            .CompanyName = LBL_FirmenName.Text
            .LastName = NachnameLabel1.Text
            '--------
            If VornameLabel1.Text <> String.Empty Then
                .FirstName = VornameLabel1.Text
            Else
                .FirstName = LBLGEF_Vorname.Text
            End If
            '--------
            If PositionLabel1.Text <> String.Empty Then
                .JobTitle = PositionLabel1.Text
            Else
                .JobTitle = LBLGEF_Position.Text
            End If
            '--------
            If EmailAddresseLabel1.Text <> String.Empty Then
                .Email1Address = EmailAddresseLabel1.Text
            Else
                .Email1Address = LBLGEF_Email.Text
            End If
            '--------
            If TelefonGeschaeftlichLabel1.Text <> String.Empty Then
                .BusinessTelephoneNumber = TelefonGeschaeftlichLabel1.Text
            Else
                .BusinessTelephoneNumber = LBLGEF_TelefonGesch.Text
            End If
            '--------
            If TelefonPrivatLabel1.Text <> String.Empty Then
                .HomeTelephoneNumber = TelefonPrivatLabel1.Text
            Else
                .HomeTelephoneNumber = LBLGEF_TelefonPriv.Text
            End If
            '--------
            If MobiltelefonLabel1.Text <> String.Empty Then
                .MobileTelephoneNumber = MobiltelefonLabel1.Text
            Else
                .MobileTelephoneNumber = LBLGEF_Mobiltelefon.Text
            End If
            '--------
            If FaxnummerLabel1.Text <> String.Empty Then
                .BusinessFaxNumber = FaxnummerLabel1.Text
            Else
                .BusinessFaxNumber = LBLGEF_Faxnummer.Text
            End If
            '--------
            If StraßeLabel1.Text <> String.Empty Then
                .BusinessAddressStreet = StraßeLabel1.Text
            Else
                .BusinessAddressStreet = LBLGEF_Strasse.Text
            End If
            '--------
            If PLZLabel1.Text <> String.Empty Then
                .BusinessAddressPostalCode = PLZLabel1.Text
            Else
                .BusinessAddressPostalCode = LBLGEF_PLZ.Text
            End If
            '--------
            If OrtLabel1.Text <> String.Empty Then
                .BusinessAddressCity = OrtLabel1.Text
            Else
                .BusinessAddressCity = LBLGEF_Ort.Text
            End If
            '--------
            If BundeslandLabel1.Text <> String.Empty Then
                .BusinessAddressState = BundeslandLabel1.Text
            Else
                .BusinessAddressState = LBLGEF_Bundesland.Text
            End If
            '--------
            If LandLabel1.Text <> String.Empty Then
                .BusinessAddressCountry = LandLabel1.Text
            Else
                .BusinessAddressCountry = LBLGEF_Land.Text
            End If
            '--------
            If WebseiteLabel1.Text <> String.Empty Then
                .BusinessHomePage = WebseiteLabel1.Text
            Else
                .BusinessHomePage = LBLGEF_Website.Text
            End If
        End With

        If modifyContact(Index, modContact) = True Then
            MsgBox("Kontakt erfolgreich geändert")
            Me.Hide()
        Else
            MsgBox("ändern des Kontaktes ist fehlgeschlagen")
            Me.Hide()
        End If



    End Sub

    Private Sub BTN_olContDelete_Click(sender As Object, e As EventArgs) Handles BTN_olContDelete.Click
        Dim olContID As Integer
        olContID = Val(LBL_olContID.Text)

        Dim Result As DialogResult
        Result = MessageBox.Show("Soll der Kontakt '" & LBLGEF_Nachname.Text & "', Kontaktnummer:" & olContID & " wirklich im Outlook gelöscht werden!", "Kontakt löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Result = System.Windows.Forms.DialogResult.Yes Then
            If deleteContact(olContID) = True Then
                MsgBox("gelöscht!")
                Initialisierung()
                'Me.Close()
            End If

        ElseIf Result = System.Windows.Forms.DialogResult.No Then
            'exit the procedure
            Exit Sub
        End If

    End Sub


End Class