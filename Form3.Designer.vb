<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim FirmenNameLabel As System.Windows.Forms.Label
        Dim NachnameLabel As System.Windows.Forms.Label
        Dim VornameLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim TelefonGeschaeftlichLabel As System.Windows.Forms.Label
        Dim TelefonPrivatLabel As System.Windows.Forms.Label
        Dim MobiltelefonLabel As System.Windows.Forms.Label
        Dim FaxnummerLabel As System.Windows.Forms.Label
        Dim EmailAddresseLabel As System.Windows.Forms.Label
        Dim StraßeLabel As System.Windows.Forms.Label
        Dim PLZLabel As System.Windows.Forms.Label
        Dim OrtLabel As System.Windows.Forms.Label
        Dim BundeslandLabel As System.Windows.Forms.Label
        Dim LandLabel As System.Windows.Forms.Label
        Dim WebseiteLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LBL_IDKontakt = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.KontakteMitAdresseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._WSL_AdressenDataSet = New Adress_DB._WSL_AdressenDataSet()
        Me.KontakteMitAdresseTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.KontakteMitAdresseTableAdapter()
        Me.TableAdapterManager = New Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager()
        Me.LBL_FirmenName = New System.Windows.Forms.Label()
        Me.NachnameLabel1 = New System.Windows.Forms.Label()
        Me.VornameLabel1 = New System.Windows.Forms.Label()
        Me.PositionLabel1 = New System.Windows.Forms.Label()
        Me.TelefonGeschaeftlichLabel1 = New System.Windows.Forms.Label()
        Me.TelefonPrivatLabel1 = New System.Windows.Forms.Label()
        Me.MobiltelefonLabel1 = New System.Windows.Forms.Label()
        Me.FaxnummerLabel1 = New System.Windows.Forms.Label()
        Me.EmailAddresseLabel1 = New System.Windows.Forms.Label()
        Me.StraßeLabel1 = New System.Windows.Forms.Label()
        Me.PLZLabel1 = New System.Windows.Forms.Label()
        Me.OrtLabel1 = New System.Windows.Forms.Label()
        Me.BundeslandLabel1 = New System.Windows.Forms.Label()
        Me.LandLabel1 = New System.Windows.Forms.Label()
        Me.WebseiteLabel1 = New System.Windows.Forms.Label()
        Me.BTN_aktualisieren = New System.Windows.Forms.Button()
        Me.LBLGEF_FirmenName = New System.Windows.Forms.Label()
        Me.LBLGEF_Nachname = New System.Windows.Forms.Label()
        Me.LBLGEF_Vorname = New System.Windows.Forms.Label()
        Me.LBLGEF_Position = New System.Windows.Forms.Label()
        Me.LBLGEF_Email = New System.Windows.Forms.Label()
        Me.LBLGEF_TelefonGesch = New System.Windows.Forms.Label()
        Me.LBLGEF_TelefonPriv = New System.Windows.Forms.Label()
        Me.LBLGEF_Mobiltelefon = New System.Windows.Forms.Label()
        Me.LBLGEF_Faxnummer = New System.Windows.Forms.Label()
        Me.LBLGEF_Strasse = New System.Windows.Forms.Label()
        Me.LBLGEF_PLZ = New System.Windows.Forms.Label()
        Me.LBLGEF_Ort = New System.Windows.Forms.Label()
        Me.LBLGEF_Bundesland = New System.Windows.Forms.Label()
        Me.LBLGEF_Land = New System.Windows.Forms.Label()
        Me.LBLGEF_Website = New System.Windows.Forms.Label()
        Me.PNL_GefundenerKontakt = New System.Windows.Forms.Panel()
        Me.BTN_olContDelete = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LBL_olContID = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_hinzufügen = New System.Windows.Forms.Button()
        Me.LBL_Hinweis = New System.Windows.Forms.Label()
        FirmenNameLabel = New System.Windows.Forms.Label()
        NachnameLabel = New System.Windows.Forms.Label()
        VornameLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        TelefonGeschaeftlichLabel = New System.Windows.Forms.Label()
        TelefonPrivatLabel = New System.Windows.Forms.Label()
        MobiltelefonLabel = New System.Windows.Forms.Label()
        FaxnummerLabel = New System.Windows.Forms.Label()
        EmailAddresseLabel = New System.Windows.Forms.Label()
        StraßeLabel = New System.Windows.Forms.Label()
        PLZLabel = New System.Windows.Forms.Label()
        OrtLabel = New System.Windows.Forms.Label()
        BundeslandLabel = New System.Windows.Forms.Label()
        LandLabel = New System.Windows.Forms.Label()
        WebseiteLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KontakteMitAdresseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._WSL_AdressenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_GefundenerKontakt.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'FirmenNameLabel
        '
        FirmenNameLabel.AutoSize = True
        FirmenNameLabel.Location = New System.Drawing.Point(28, 35)
        FirmenNameLabel.Name = "FirmenNameLabel"
        FirmenNameLabel.Size = New System.Drawing.Size(72, 13)
        FirmenNameLabel.TabIndex = 17
        FirmenNameLabel.Text = "Firmen Name:"
        '
        'NachnameLabel
        '
        NachnameLabel.AutoSize = True
        NachnameLabel.Location = New System.Drawing.Point(38, 49)
        NachnameLabel.Name = "NachnameLabel"
        NachnameLabel.Size = New System.Drawing.Size(62, 13)
        NachnameLabel.TabIndex = 18
        NachnameLabel.Text = "Nachname:"
        '
        'VornameLabel
        '
        VornameLabel.AutoSize = True
        VornameLabel.Location = New System.Drawing.Point(48, 63)
        VornameLabel.Name = "VornameLabel"
        VornameLabel.Size = New System.Drawing.Size(52, 13)
        VornameLabel.TabIndex = 19
        VornameLabel.Text = "Vorname:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(53, 76)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(47, 13)
        PositionLabel.TabIndex = 20
        PositionLabel.Text = "Position:"
        '
        'TelefonGeschaeftlichLabel
        '
        TelefonGeschaeftlichLabel.AutoSize = True
        TelefonGeschaeftlichLabel.Location = New System.Drawing.Point(13, 104)
        TelefonGeschaeftlichLabel.Name = "TelefonGeschaeftlichLabel"
        TelefonGeschaeftlichLabel.Size = New System.Drawing.Size(84, 13)
        TelefonGeschaeftlichLabel.TabIndex = 21
        TelefonGeschaeftlichLabel.Text = "Telefon (gesch):"
        '
        'TelefonPrivatLabel
        '
        TelefonPrivatLabel.AutoSize = True
        TelefonPrivatLabel.Location = New System.Drawing.Point(17, 118)
        TelefonPrivatLabel.Name = "TelefonPrivatLabel"
        TelefonPrivatLabel.Size = New System.Drawing.Size(81, 13)
        TelefonPrivatLabel.TabIndex = 22
        TelefonPrivatLabel.Text = "Telefon (privat):"
        '
        'MobiltelefonLabel
        '
        MobiltelefonLabel.AutoSize = True
        MobiltelefonLabel.Location = New System.Drawing.Point(30, 132)
        MobiltelefonLabel.Name = "MobiltelefonLabel"
        MobiltelefonLabel.Size = New System.Drawing.Size(67, 13)
        MobiltelefonLabel.TabIndex = 23
        MobiltelefonLabel.Text = "Mobiltelefon:"
        '
        'FaxnummerLabel
        '
        FaxnummerLabel.AutoSize = True
        FaxnummerLabel.Location = New System.Drawing.Point(33, 146)
        FaxnummerLabel.Name = "FaxnummerLabel"
        FaxnummerLabel.Size = New System.Drawing.Size(64, 13)
        FaxnummerLabel.TabIndex = 24
        FaxnummerLabel.Text = "Faxnummer:"
        '
        'EmailAddresseLabel
        '
        EmailAddresseLabel.AutoSize = True
        EmailAddresseLabel.Location = New System.Drawing.Point(18, 89)
        EmailAddresseLabel.Name = "EmailAddresseLabel"
        EmailAddresseLabel.Size = New System.Drawing.Size(82, 13)
        EmailAddresseLabel.TabIndex = 25
        EmailAddresseLabel.Text = "Email Addresse:"
        '
        'StraßeLabel
        '
        StraßeLabel.AutoSize = True
        StraßeLabel.Location = New System.Drawing.Point(56, 170)
        StraßeLabel.Name = "StraßeLabel"
        StraßeLabel.Size = New System.Drawing.Size(41, 13)
        StraßeLabel.TabIndex = 26
        StraßeLabel.Text = "Straße:"
        '
        'PLZLabel
        '
        PLZLabel.AutoSize = True
        PLZLabel.Location = New System.Drawing.Point(67, 184)
        PLZLabel.Name = "PLZLabel"
        PLZLabel.Size = New System.Drawing.Size(30, 13)
        PLZLabel.TabIndex = 28
        PLZLabel.Text = "PLZ:"
        '
        'OrtLabel
        '
        OrtLabel.AutoSize = True
        OrtLabel.Location = New System.Drawing.Point(73, 198)
        OrtLabel.Name = "OrtLabel"
        OrtLabel.Size = New System.Drawing.Size(24, 13)
        OrtLabel.TabIndex = 30
        OrtLabel.Text = "Ort:"
        '
        'BundeslandLabel
        '
        BundeslandLabel.AutoSize = True
        BundeslandLabel.Location = New System.Drawing.Point(31, 212)
        BundeslandLabel.Name = "BundeslandLabel"
        BundeslandLabel.Size = New System.Drawing.Size(66, 13)
        BundeslandLabel.TabIndex = 32
        BundeslandLabel.Text = "Bundesland:"
        '
        'LandLabel
        '
        LandLabel.AutoSize = True
        LandLabel.Location = New System.Drawing.Point(63, 226)
        LandLabel.Name = "LandLabel"
        LandLabel.Size = New System.Drawing.Size(34, 13)
        LandLabel.TabIndex = 34
        LandLabel.Text = "Land:"
        '
        'WebseiteLabel
        '
        WebseiteLabel.AutoSize = True
        WebseiteLabel.Location = New System.Drawing.Point(42, 240)
        WebseiteLabel.Name = "WebseiteLabel"
        WebseiteLabel.Size = New System.Drawing.Size(55, 13)
        WebseiteLabel.TabIndex = 36
        WebseiteLabel.Text = "Webseite:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(33, 235)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(55, 13)
        Label4.TabIndex = 50
        Label4.Text = "Webseite:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(55, 222)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(34, 13)
        Label5.TabIndex = 49
        Label5.Text = "Land:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(22, 209)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(66, 13)
        Label6.TabIndex = 48
        Label6.Text = "Bundesland:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(58, 183)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(30, 13)
        Label7.TabIndex = 47
        Label7.Text = "PLZ:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(47, 170)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(41, 13)
        Label8.TabIndex = 46
        Label8.Text = "Straße:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(7, 91)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(82, 13)
        Label9.TabIndex = 45
        Label9.Text = "Email Addresse:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(24, 147)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(64, 13)
        Label10.TabIndex = 44
        Label10.Text = "Faxnummer:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(22, 133)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(67, 13)
        Label11.TabIndex = 43
        Label11.Text = "Mobiltelefon:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(8, 119)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(81, 13)
        Label12.TabIndex = 42
        Label12.Text = "Telefon (privat):"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(5, 105)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(84, 13)
        Label13.TabIndex = 41
        Label13.Text = "Telefon (gesch):"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(41, 77)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(47, 13)
        Label14.TabIndex = 40
        Label14.Text = "Position:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(36, 63)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(52, 13)
        Label15.TabIndex = 39
        Label15.Text = "Vorname:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(27, 49)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(62, 13)
        Label16.TabIndex = 38
        Label16.Text = "Nachname:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(17, 35)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(72, 13)
        Label17.TabIndex = 37
        Label17.Text = "Firmen Name:"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Location = New System.Drawing.Point(64, 196)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(24, 13)
        Label24.TabIndex = 40
        Label24.Text = "Ort:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LBL_IDKontakt)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 38)
        Me.Panel1.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Adress_DB.My.Resources.Resources.outlook_groß
        Me.PictureBox1.Location = New System.Drawing.Point(7, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'LBL_IDKontakt
        '
        Me.LBL_IDKontakt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_IDKontakt.ForeColor = System.Drawing.Color.Gray
        Me.LBL_IDKontakt.Location = New System.Drawing.Point(624, 9)
        Me.LBL_IDKontakt.Name = "LBL_IDKontakt"
        Me.LBL_IDKontakt.Size = New System.Drawing.Size(100, 23)
        Me.LBL_IDKontakt.TabIndex = 2
        Me.LBL_IDKontakt.Text = "LBL_IDKontakt"
        Me.LBL_IDKontakt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(249, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Kontakt nach Outlook exportieren:"
        '
        'KontakteMitAdresseBindingSource
        '
        Me.KontakteMitAdresseBindingSource.DataMember = "KontakteMitAdresse"
        Me.KontakteMitAdresseBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        '_WSL_AdressenDataSet
        '
        Me._WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet"
        Me._WSL_AdressenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KontakteMitAdresseTableAdapter
        '
        Me.KontakteMitAdresseTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdressenTableAdapter = Nothing
        Me.TableAdapterManager.AT_PLZ_GeodatenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BelegeTableAdapter = Nothing
        Me.TableAdapterManager.CH_PLZ_GeodatenTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DE_PLZ_GeodatenTableAdapter = Nothing
        Me.TableAdapterManager.FirmenNameTableAdapter = Nothing
        Me.TableAdapterManager.KonfigurationTableAdapter = Nothing
        Me.TableAdapterManager.KontakteTableAdapter = Nothing
        Me.TableAdapterManager.KontoTableAdapter = Nothing
        Me.TableAdapterManager.LogTabelleTableAdapter = Nothing
        Me.TableAdapterManager.PLZ_GeodatenTableAdapter = Nothing
        Me.TableAdapterManager.SachbearbeiterTableAdapter = Nothing
        Me.TableAdapterManager.StaatenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LBL_FirmenName
        '
        Me.LBL_FirmenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_FirmenName.Location = New System.Drawing.Point(103, 35)
        Me.LBL_FirmenName.Name = "LBL_FirmenName"
        Me.LBL_FirmenName.Size = New System.Drawing.Size(250, 13)
        Me.LBL_FirmenName.TabIndex = 18
        Me.LBL_FirmenName.Text = "Firmenname GmbH"
        '
        'NachnameLabel1
        '
        Me.NachnameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteMitAdresseBindingSource, "Nachname", True))
        Me.NachnameLabel1.Location = New System.Drawing.Point(103, 49)
        Me.NachnameLabel1.Name = "NachnameLabel1"
        Me.NachnameLabel1.Size = New System.Drawing.Size(250, 13)
        Me.NachnameLabel1.TabIndex = 19
        Me.NachnameLabel1.Text = "Nachname"
        '
        'VornameLabel1
        '
        Me.VornameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteMitAdresseBindingSource, "Vorname", True))
        Me.VornameLabel1.Location = New System.Drawing.Point(103, 63)
        Me.VornameLabel1.Name = "VornameLabel1"
        Me.VornameLabel1.Size = New System.Drawing.Size(250, 13)
        Me.VornameLabel1.TabIndex = 20
        Me.VornameLabel1.Text = "Vorname"
        '
        'PositionLabel1
        '
        Me.PositionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteMitAdresseBindingSource, "Jobtitle", True))
        Me.PositionLabel1.Location = New System.Drawing.Point(103, 77)
        Me.PositionLabel1.Name = "PositionLabel1"
        Me.PositionLabel1.Size = New System.Drawing.Size(250, 13)
        Me.PositionLabel1.TabIndex = 21
        Me.PositionLabel1.Text = "Position"
        '
        'TelefonGeschaeftlichLabel1
        '
        Me.TelefonGeschaeftlichLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteMitAdresseBindingSource, "TelefonGeschaeftlich", True))
        Me.TelefonGeschaeftlichLabel1.Location = New System.Drawing.Point(103, 105)
        Me.TelefonGeschaeftlichLabel1.Name = "TelefonGeschaeftlichLabel1"
        Me.TelefonGeschaeftlichLabel1.Size = New System.Drawing.Size(250, 13)
        Me.TelefonGeschaeftlichLabel1.TabIndex = 22
        Me.TelefonGeschaeftlichLabel1.Text = "Tel gesch"
        '
        'TelefonPrivatLabel1
        '
        Me.TelefonPrivatLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteMitAdresseBindingSource, "TelefonPrivat", True))
        Me.TelefonPrivatLabel1.Location = New System.Drawing.Point(103, 119)
        Me.TelefonPrivatLabel1.Name = "TelefonPrivatLabel1"
        Me.TelefonPrivatLabel1.Size = New System.Drawing.Size(250, 13)
        Me.TelefonPrivatLabel1.TabIndex = 23
        Me.TelefonPrivatLabel1.Text = "Tel priv"
        '
        'MobiltelefonLabel1
        '
        Me.MobiltelefonLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteMitAdresseBindingSource, "Mobiltelefon", True))
        Me.MobiltelefonLabel1.Location = New System.Drawing.Point(103, 133)
        Me.MobiltelefonLabel1.Name = "MobiltelefonLabel1"
        Me.MobiltelefonLabel1.Size = New System.Drawing.Size(250, 13)
        Me.MobiltelefonLabel1.TabIndex = 24
        Me.MobiltelefonLabel1.Text = "Mobilnummer"
        '
        'FaxnummerLabel1
        '
        Me.FaxnummerLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteMitAdresseBindingSource, "Faxnummer", True))
        Me.FaxnummerLabel1.Location = New System.Drawing.Point(103, 147)
        Me.FaxnummerLabel1.Name = "FaxnummerLabel1"
        Me.FaxnummerLabel1.Size = New System.Drawing.Size(250, 13)
        Me.FaxnummerLabel1.TabIndex = 25
        Me.FaxnummerLabel1.Text = "Fax"
        '
        'EmailAddresseLabel1
        '
        Me.EmailAddresseLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteMitAdresseBindingSource, "EmailAddresse", True))
        Me.EmailAddresseLabel1.Location = New System.Drawing.Point(103, 91)
        Me.EmailAddresseLabel1.Name = "EmailAddresseLabel1"
        Me.EmailAddresseLabel1.Size = New System.Drawing.Size(250, 13)
        Me.EmailAddresseLabel1.TabIndex = 26
        Me.EmailAddresseLabel1.Text = "Email"
        '
        'StraßeLabel1
        '
        Me.StraßeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteMitAdresseBindingSource, "Straße", True))
        Me.StraßeLabel1.Location = New System.Drawing.Point(103, 170)
        Me.StraßeLabel1.Name = "StraßeLabel1"
        Me.StraßeLabel1.Size = New System.Drawing.Size(250, 13)
        Me.StraßeLabel1.TabIndex = 27
        Me.StraßeLabel1.Text = "Strasse"
        '
        'PLZLabel1
        '
        Me.PLZLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteMitAdresseBindingSource, "PLZ", True))
        Me.PLZLabel1.Location = New System.Drawing.Point(103, 184)
        Me.PLZLabel1.Name = "PLZLabel1"
        Me.PLZLabel1.Size = New System.Drawing.Size(250, 13)
        Me.PLZLabel1.TabIndex = 29
        Me.PLZLabel1.Text = "PLZ"
        '
        'OrtLabel1
        '
        Me.OrtLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteMitAdresseBindingSource, "Ort", True))
        Me.OrtLabel1.Location = New System.Drawing.Point(103, 198)
        Me.OrtLabel1.Name = "OrtLabel1"
        Me.OrtLabel1.Size = New System.Drawing.Size(250, 13)
        Me.OrtLabel1.TabIndex = 31
        Me.OrtLabel1.Text = "Stadt"
        '
        'BundeslandLabel1
        '
        Me.BundeslandLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteMitAdresseBindingSource, "Bundesland", True))
        Me.BundeslandLabel1.Location = New System.Drawing.Point(103, 212)
        Me.BundeslandLabel1.Name = "BundeslandLabel1"
        Me.BundeslandLabel1.Size = New System.Drawing.Size(250, 13)
        Me.BundeslandLabel1.TabIndex = 33
        Me.BundeslandLabel1.Text = "Niedersachsen"
        '
        'LandLabel1
        '
        Me.LandLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteMitAdresseBindingSource, "Land", True))
        Me.LandLabel1.Location = New System.Drawing.Point(103, 226)
        Me.LandLabel1.Name = "LandLabel1"
        Me.LandLabel1.Size = New System.Drawing.Size(250, 13)
        Me.LandLabel1.TabIndex = 35
        Me.LandLabel1.Text = "Land"
        '
        'WebseiteLabel1
        '
        Me.WebseiteLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteMitAdresseBindingSource, "Webseite", True))
        Me.WebseiteLabel1.Location = New System.Drawing.Point(103, 240)
        Me.WebseiteLabel1.Name = "WebseiteLabel1"
        Me.WebseiteLabel1.Size = New System.Drawing.Size(250, 13)
        Me.WebseiteLabel1.TabIndex = 37
        Me.WebseiteLabel1.Text = "www.website.de"
        '
        'BTN_aktualisieren
        '
        Me.BTN_aktualisieren.Image = Global.Adress_DB.My.Resources.Resources.AssignToUser_16x
        Me.BTN_aktualisieren.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_aktualisieren.Location = New System.Drawing.Point(246, 268)
        Me.BTN_aktualisieren.Name = "BTN_aktualisieren"
        Me.BTN_aktualisieren.Size = New System.Drawing.Size(90, 23)
        Me.BTN_aktualisieren.TabIndex = 38
        Me.BTN_aktualisieren.Text = "aktualisieren"
        Me.BTN_aktualisieren.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_aktualisieren.UseVisualStyleBackColor = True
        '
        'LBLGEF_FirmenName
        '
        Me.LBLGEF_FirmenName.AutoSize = True
        Me.LBLGEF_FirmenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLGEF_FirmenName.Location = New System.Drawing.Point(97, 35)
        Me.LBLGEF_FirmenName.Name = "LBLGEF_FirmenName"
        Me.LBLGEF_FirmenName.Size = New System.Drawing.Size(76, 13)
        Me.LBLGEF_FirmenName.TabIndex = 51
        Me.LBLGEF_FirmenName.Text = "FirmenName"
        '
        'LBLGEF_Nachname
        '
        Me.LBLGEF_Nachname.AutoSize = True
        Me.LBLGEF_Nachname.Location = New System.Drawing.Point(97, 49)
        Me.LBLGEF_Nachname.Name = "LBLGEF_Nachname"
        Me.LBLGEF_Nachname.Size = New System.Drawing.Size(59, 13)
        Me.LBLGEF_Nachname.TabIndex = 52
        Me.LBLGEF_Nachname.Text = "Nachname"
        '
        'LBLGEF_Vorname
        '
        Me.LBLGEF_Vorname.AutoSize = True
        Me.LBLGEF_Vorname.Location = New System.Drawing.Point(97, 63)
        Me.LBLGEF_Vorname.Name = "LBLGEF_Vorname"
        Me.LBLGEF_Vorname.Size = New System.Drawing.Size(49, 13)
        Me.LBLGEF_Vorname.TabIndex = 53
        Me.LBLGEF_Vorname.Text = "Vorname"
        '
        'LBLGEF_Position
        '
        Me.LBLGEF_Position.AutoSize = True
        Me.LBLGEF_Position.Location = New System.Drawing.Point(97, 77)
        Me.LBLGEF_Position.Name = "LBLGEF_Position"
        Me.LBLGEF_Position.Size = New System.Drawing.Size(44, 13)
        Me.LBLGEF_Position.TabIndex = 54
        Me.LBLGEF_Position.Text = "Position"
        '
        'LBLGEF_Email
        '
        Me.LBLGEF_Email.AutoSize = True
        Me.LBLGEF_Email.Location = New System.Drawing.Point(97, 91)
        Me.LBLGEF_Email.Name = "LBLGEF_Email"
        Me.LBLGEF_Email.Size = New System.Drawing.Size(32, 13)
        Me.LBLGEF_Email.TabIndex = 55
        Me.LBLGEF_Email.Text = "Email"
        '
        'LBLGEF_TelefonGesch
        '
        Me.LBLGEF_TelefonGesch.AutoSize = True
        Me.LBLGEF_TelefonGesch.Location = New System.Drawing.Point(97, 105)
        Me.LBLGEF_TelefonGesch.Name = "LBLGEF_TelefonGesch"
        Me.LBLGEF_TelefonGesch.Size = New System.Drawing.Size(75, 13)
        Me.LBLGEF_TelefonGesch.TabIndex = 56
        Me.LBLGEF_TelefonGesch.Text = "Telefon gesch"
        '
        'LBLGEF_TelefonPriv
        '
        Me.LBLGEF_TelefonPriv.AutoSize = True
        Me.LBLGEF_TelefonPriv.Location = New System.Drawing.Point(97, 119)
        Me.LBLGEF_TelefonPriv.Name = "LBLGEF_TelefonPriv"
        Me.LBLGEF_TelefonPriv.Size = New System.Drawing.Size(72, 13)
        Me.LBLGEF_TelefonPriv.TabIndex = 57
        Me.LBLGEF_TelefonPriv.Text = "Telefon privat"
        '
        'LBLGEF_Mobiltelefon
        '
        Me.LBLGEF_Mobiltelefon.AutoSize = True
        Me.LBLGEF_Mobiltelefon.Location = New System.Drawing.Point(97, 133)
        Me.LBLGEF_Mobiltelefon.Name = "LBLGEF_Mobiltelefon"
        Me.LBLGEF_Mobiltelefon.Size = New System.Drawing.Size(101, 13)
        Me.LBLGEF_Mobiltelefon.TabIndex = 58
        Me.LBLGEF_Mobiltelefon.Text = "Mobiltelefonnummer"
        '
        'LBLGEF_Faxnummer
        '
        Me.LBLGEF_Faxnummer.AutoSize = True
        Me.LBLGEF_Faxnummer.Location = New System.Drawing.Point(97, 147)
        Me.LBLGEF_Faxnummer.Name = "LBLGEF_Faxnummer"
        Me.LBLGEF_Faxnummer.Size = New System.Drawing.Size(61, 13)
        Me.LBLGEF_Faxnummer.TabIndex = 59
        Me.LBLGEF_Faxnummer.Text = "Faxnummer"
        '
        'LBLGEF_Strasse
        '
        Me.LBLGEF_Strasse.AutoSize = True
        Me.LBLGEF_Strasse.Location = New System.Drawing.Point(97, 170)
        Me.LBLGEF_Strasse.Name = "LBLGEF_Strasse"
        Me.LBLGEF_Strasse.Size = New System.Drawing.Size(42, 13)
        Me.LBLGEF_Strasse.TabIndex = 60
        Me.LBLGEF_Strasse.Text = "Strasse"
        '
        'LBLGEF_PLZ
        '
        Me.LBLGEF_PLZ.AutoSize = True
        Me.LBLGEF_PLZ.Location = New System.Drawing.Point(98, 183)
        Me.LBLGEF_PLZ.Name = "LBLGEF_PLZ"
        Me.LBLGEF_PLZ.Size = New System.Drawing.Size(60, 13)
        Me.LBLGEF_PLZ.TabIndex = 61
        Me.LBLGEF_PLZ.Text = "Postleitzahl"
        '
        'LBLGEF_Ort
        '
        Me.LBLGEF_Ort.AutoSize = True
        Me.LBLGEF_Ort.Location = New System.Drawing.Point(98, 196)
        Me.LBLGEF_Ort.Name = "LBLGEF_Ort"
        Me.LBLGEF_Ort.Size = New System.Drawing.Size(32, 13)
        Me.LBLGEF_Ort.TabIndex = 62
        Me.LBLGEF_Ort.Text = "Stadt"
        '
        'LBLGEF_Bundesland
        '
        Me.LBLGEF_Bundesland.AutoSize = True
        Me.LBLGEF_Bundesland.Location = New System.Drawing.Point(97, 209)
        Me.LBLGEF_Bundesland.Name = "LBLGEF_Bundesland"
        Me.LBLGEF_Bundesland.Size = New System.Drawing.Size(63, 13)
        Me.LBLGEF_Bundesland.TabIndex = 63
        Me.LBLGEF_Bundesland.Text = "Bundesland"
        '
        'LBLGEF_Land
        '
        Me.LBLGEF_Land.AutoSize = True
        Me.LBLGEF_Land.Location = New System.Drawing.Point(99, 222)
        Me.LBLGEF_Land.Name = "LBLGEF_Land"
        Me.LBLGEF_Land.Size = New System.Drawing.Size(31, 13)
        Me.LBLGEF_Land.TabIndex = 64
        Me.LBLGEF_Land.Text = "Land"
        '
        'LBLGEF_Website
        '
        Me.LBLGEF_Website.AutoSize = True
        Me.LBLGEF_Website.Location = New System.Drawing.Point(97, 235)
        Me.LBLGEF_Website.Name = "LBLGEF_Website"
        Me.LBLGEF_Website.Size = New System.Drawing.Size(85, 13)
        Me.LBLGEF_Website.TabIndex = 65
        Me.LBLGEF_Website.Text = "www.website.de"
        '
        'PNL_GefundenerKontakt
        '
        Me.PNL_GefundenerKontakt.BackColor = System.Drawing.Color.White
        Me.PNL_GefundenerKontakt.Controls.Add(Me.BTN_olContDelete)
        Me.PNL_GefundenerKontakt.Controls.Add(Me.LBLGEF_Website)
        Me.PNL_GefundenerKontakt.Controls.Add(Me.Panel3)
        Me.PNL_GefundenerKontakt.Controls.Add(Me.BTN_aktualisieren)
        Me.PNL_GefundenerKontakt.Controls.Add(Me.LBLGEF_TelefonGesch)
        Me.PNL_GefundenerKontakt.Controls.Add(Me.LBLGEF_Land)
        Me.PNL_GefundenerKontakt.Controls.Add(Label9)
        Me.PNL_GefundenerKontakt.Controls.Add(Me.LBLGEF_Bundesland)
        Me.PNL_GefundenerKontakt.Controls.Add(Label8)
        Me.PNL_GefundenerKontakt.Controls.Add(Me.LBLGEF_Ort)
        Me.PNL_GefundenerKontakt.Controls.Add(Label10)
        Me.PNL_GefundenerKontakt.Controls.Add(Me.LBLGEF_PLZ)
        Me.PNL_GefundenerKontakt.Controls.Add(Label12)
        Me.PNL_GefundenerKontakt.Controls.Add(Label24)
        Me.PNL_GefundenerKontakt.Controls.Add(Label7)
        Me.PNL_GefundenerKontakt.Controls.Add(Me.LBLGEF_Strasse)
        Me.PNL_GefundenerKontakt.Controls.Add(Label13)
        Me.PNL_GefundenerKontakt.Controls.Add(Me.LBLGEF_Faxnummer)
        Me.PNL_GefundenerKontakt.Controls.Add(Label14)
        Me.PNL_GefundenerKontakt.Controls.Add(Me.LBLGEF_Mobiltelefon)
        Me.PNL_GefundenerKontakt.Controls.Add(Label6)
        Me.PNL_GefundenerKontakt.Controls.Add(Me.LBLGEF_TelefonPriv)
        Me.PNL_GefundenerKontakt.Controls.Add(Label15)
        Me.PNL_GefundenerKontakt.Controls.Add(Label16)
        Me.PNL_GefundenerKontakt.Controls.Add(Me.LBLGEF_Email)
        Me.PNL_GefundenerKontakt.Controls.Add(Label5)
        Me.PNL_GefundenerKontakt.Controls.Add(Me.LBLGEF_Position)
        Me.PNL_GefundenerKontakt.Controls.Add(Label17)
        Me.PNL_GefundenerKontakt.Controls.Add(Me.LBLGEF_Vorname)
        Me.PNL_GefundenerKontakt.Controls.Add(Label11)
        Me.PNL_GefundenerKontakt.Controls.Add(Me.LBLGEF_Nachname)
        Me.PNL_GefundenerKontakt.Controls.Add(Label4)
        Me.PNL_GefundenerKontakt.Controls.Add(Me.LBLGEF_FirmenName)
        Me.PNL_GefundenerKontakt.Location = New System.Drawing.Point(5, 43)
        Me.PNL_GefundenerKontakt.Name = "PNL_GefundenerKontakt"
        Me.PNL_GefundenerKontakt.Size = New System.Drawing.Size(360, 294)
        Me.PNL_GefundenerKontakt.TabIndex = 40
        '
        'BTN_olContDelete
        '
        Me.BTN_olContDelete.BackColor = System.Drawing.Color.Red
        Me.BTN_olContDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_olContDelete.ForeColor = System.Drawing.Color.White
        Me.BTN_olContDelete.Image = Global.Adress_DB.My.Resources.Resources.DeleteUser_16x
        Me.BTN_olContDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_olContDelete.Location = New System.Drawing.Point(11, 268)
        Me.BTN_olContDelete.Name = "BTN_olContDelete"
        Me.BTN_olContDelete.Size = New System.Drawing.Size(90, 23)
        Me.BTN_olContDelete.TabIndex = 66
        Me.BTN_olContDelete.Text = "löschen"
        Me.BTN_olContDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_olContDelete.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.LBL_olContID)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(360, 27)
        Me.Panel3.TabIndex = 0
        '
        'LBL_olContID
        '
        Me.LBL_olContID.AutoSize = True
        Me.LBL_olContID.ForeColor = System.Drawing.Color.Gray
        Me.LBL_olContID.Location = New System.Drawing.Point(318, 8)
        Me.LBL_olContID.Name = "LBL_olContID"
        Me.LBL_olContID.Size = New System.Drawing.Size(18, 13)
        Me.LBL_olContID.TabIndex = 1
        Me.LBL_olContID.Text = "ID"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(233, 24)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Kontakt bereits vorhanden!"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(FirmenNameLabel)
        Me.Panel4.Controls.Add(Me.LBL_FirmenName)
        Me.Panel4.Controls.Add(WebseiteLabel)
        Me.Panel4.Controls.Add(Me.NachnameLabel1)
        Me.Panel4.Controls.Add(Me.WebseiteLabel1)
        Me.Panel4.Controls.Add(Me.VornameLabel1)
        Me.Panel4.Controls.Add(LandLabel)
        Me.Panel4.Controls.Add(NachnameLabel)
        Me.Panel4.Controls.Add(Me.LandLabel1)
        Me.Panel4.Controls.Add(VornameLabel)
        Me.Panel4.Controls.Add(BundeslandLabel)
        Me.Panel4.Controls.Add(PositionLabel)
        Me.Panel4.Controls.Add(Me.BundeslandLabel1)
        Me.Panel4.Controls.Add(Me.PositionLabel1)
        Me.Panel4.Controls.Add(OrtLabel)
        Me.Panel4.Controls.Add(EmailAddresseLabel)
        Me.Panel4.Controls.Add(Me.OrtLabel1)
        Me.Panel4.Controls.Add(Me.EmailAddresseLabel1)
        Me.Panel4.Controls.Add(PLZLabel)
        Me.Panel4.Controls.Add(Me.TelefonGeschaeftlichLabel1)
        Me.Panel4.Controls.Add(Me.PLZLabel1)
        Me.Panel4.Controls.Add(TelefonGeschaeftlichLabel)
        Me.Panel4.Controls.Add(StraßeLabel)
        Me.Panel4.Controls.Add(Me.TelefonPrivatLabel1)
        Me.Panel4.Controls.Add(Me.StraßeLabel1)
        Me.Panel4.Controls.Add(TelefonPrivatLabel)
        Me.Panel4.Controls.Add(FaxnummerLabel)
        Me.Panel4.Controls.Add(Me.MobiltelefonLabel1)
        Me.Panel4.Controls.Add(Me.FaxnummerLabel1)
        Me.Panel4.Controls.Add(MobiltelefonLabel)
        Me.Panel4.Location = New System.Drawing.Point(371, 43)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(360, 295)
        Me.Panel4.TabIndex = 41
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(360, 27)
        Me.Panel6.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Neuer Kontakt:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Gray
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.BTN_hinzufügen)
        Me.Panel5.Location = New System.Drawing.Point(0, 344)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(736, 43)
        Me.Panel5.TabIndex = 42
        '
        'Button1
        '
        Me.Button1.Image = Global.Adress_DB.My.Resources.Resources.Cancel_16x
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(477, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Abbrechen"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTN_hinzufügen
        '
        Me.BTN_hinzufügen.Image = Global.Adress_DB.My.Resources.Resources.AddUser_16x
        Me.BTN_hinzufügen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_hinzufügen.Location = New System.Drawing.Point(645, 10)
        Me.BTN_hinzufügen.Name = "BTN_hinzufügen"
        Me.BTN_hinzufügen.Size = New System.Drawing.Size(80, 23)
        Me.BTN_hinzufügen.TabIndex = 0
        Me.BTN_hinzufügen.Text = "hinzufügen"
        Me.BTN_hinzufügen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_hinzufügen.UseVisualStyleBackColor = True
        '
        'LBL_Hinweis
        '
        Me.LBL_Hinweis.AutoSize = True
        Me.LBL_Hinweis.Location = New System.Drawing.Point(69, 78)
        Me.LBL_Hinweis.Name = "LBL_Hinweis"
        Me.LBL_Hinweis.Size = New System.Drawing.Size(240, 104)
        Me.LBL_Hinweis.TabIndex = 43
        Me.LBL_Hinweis.Text = resources.GetString("LBL_Hinweis.Text")
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 389)
        Me.Controls.Add(Me.LBL_Hinweis)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PNL_GefundenerKontakt)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.Text = "Outlook-Export"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KontakteMitAdresseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._WSL_AdressenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_GefundenerKontakt.ResumeLayout(False)
        Me.PNL_GefundenerKontakt.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_hinzufügen As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LBL_IDKontakt As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents _WSL_AdressenDataSet As _WSL_AdressenDataSet
    Friend WithEvents KontakteMitAdresseBindingSource As BindingSource
    Friend WithEvents KontakteMitAdresseTableAdapter As _WSL_AdressenDataSetTableAdapters.KontakteMitAdresseTableAdapter
    Friend WithEvents TableAdapterManager As _WSL_AdressenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LBL_FirmenName As Label
    Friend WithEvents NachnameLabel1 As Label
    Friend WithEvents VornameLabel1 As Label
    Friend WithEvents PositionLabel1 As Label
    Friend WithEvents TelefonGeschaeftlichLabel1 As Label
    Friend WithEvents TelefonPrivatLabel1 As Label
    Friend WithEvents MobiltelefonLabel1 As Label
    Friend WithEvents FaxnummerLabel1 As Label
    Friend WithEvents EmailAddresseLabel1 As Label
    Friend WithEvents StraßeLabel1 As Label
    Friend WithEvents PLZLabel1 As Label
    Friend WithEvents OrtLabel1 As Label
    Friend WithEvents BundeslandLabel1 As Label
    Friend WithEvents LandLabel1 As Label
    Friend WithEvents WebseiteLabel1 As Label
    Friend WithEvents BTN_aktualisieren As Button
    Friend WithEvents LBLGEF_FirmenName As Label
    Friend WithEvents LBLGEF_Website As Label
    Friend WithEvents LBLGEF_Land As Label
    Friend WithEvents LBLGEF_Bundesland As Label
    Friend WithEvents LBLGEF_Ort As Label
    Friend WithEvents LBLGEF_PLZ As Label
    Friend WithEvents LBLGEF_Strasse As Label
    Friend WithEvents LBLGEF_Faxnummer As Label
    Friend WithEvents LBLGEF_Mobiltelefon As Label
    Friend WithEvents LBLGEF_TelefonPriv As Label
    Friend WithEvents LBLGEF_TelefonGesch As Label
    Friend WithEvents LBLGEF_Email As Label
    Friend WithEvents LBLGEF_Position As Label
    Friend WithEvents LBLGEF_Vorname As Label
    Friend WithEvents LBLGEF_Nachname As Label
    Friend WithEvents PNL_GefundenerKontakt As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LBL_Hinweis As Label
    Friend WithEvents LBL_olContID As Label
    Friend WithEvents BTN_olContDelete As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
