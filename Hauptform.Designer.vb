<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hauptform
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
        Dim AdresstypLabel As System.Windows.Forms.Label
        Dim StraßeLabel As System.Windows.Forms.Label
        Dim PLZLabel As System.Windows.Forms.Label
        Dim PostfachLabel As System.Windows.Forms.Label
        Dim OrtLabel As System.Windows.Forms.Label
        Dim BundeslandLabel As System.Windows.Forms.Label
        Dim LandLabel As System.Windows.Forms.Label
        Dim UStIdNrLabel As System.Windows.Forms.Label
        Dim WebseiteLabel As System.Windows.Forms.Label
        Dim AnredeLabel As System.Windows.Forms.Label
        Dim NachnameLabel As System.Windows.Forms.Label
        Dim VornameLabel As System.Windows.Forms.Label
        Dim EmailAddresseLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim TelefonGeschaeftlichLabel As System.Windows.Forms.Label
        Dim TelefonPrivatLabel As System.Windows.Forms.Label
        Dim MobiltelefonLabel As System.Windows.Forms.Label
        Dim FaxnummerLabel As System.Windows.Forms.Label
        Dim AdresstypLabel1 As System.Windows.Forms.Label
        Dim StraßeLabel1 As System.Windows.Forms.Label
        Dim PostfachLabel1 As System.Windows.Forms.Label
        Dim PLZLabel1 As System.Windows.Forms.Label
        Dim OrtLabel1 As System.Windows.Forms.Label
        Dim BundeslandLabel1 As System.Windows.Forms.Label
        Dim UStIdNrLabel1 As System.Windows.Forms.Label
        Dim WebseiteLabel1 As System.Windows.Forms.Label
        Dim AnredeLabel1 As System.Windows.Forms.Label
        Dim VornameLabel1 As System.Windows.Forms.Label
        Dim NachnameLabel1 As System.Windows.Forms.Label
        Dim EmailAddresseLabel1 As System.Windows.Forms.Label
        Dim PositionLabel1 As System.Windows.Forms.Label
        Dim TelefonGeschaeftlichLabel1 As System.Windows.Forms.Label
        Dim TelefonPrivatLabel1 As System.Windows.Forms.Label
        Dim MobiltelefonLabel1 As System.Windows.Forms.Label
        Dim FaxnummerLabel1 As System.Windows.Forms.Label
        Dim IDAdresseLabel As System.Windows.Forms.Label
        Dim IDKontoLabel As System.Windows.Forms.Label
        Dim IDLKontoLabel2 As System.Windows.Forms.Label
        Dim DirekterKontaktLabel As System.Windows.Forms.Label
        Dim WeitereKontakteLabel As System.Windows.Forms.Label
        Dim DatumLabel As System.Windows.Forms.Label
        Dim VonWemBesuchtLabel As System.Windows.Forms.Label
        Dim WeitereBesucherLabel As System.Windows.Forms.Label
        Dim ThemaLabel As System.Windows.Forms.Label
        Dim PLZLabel2 As System.Windows.Forms.Label
        Dim FaxnummerLabel3 As System.Windows.Forms.Label
        Dim SachbearbeiterLabel As System.Windows.Forms.Label
        Dim JobtitleLabel As System.Windows.Forms.Label
        Dim DurchwahlLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim IDKontoLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hauptform))
        Me.StraßeLabel2 = New System.Windows.Forms.Label()
        Me.OrtLabel2 = New System.Windows.Forms.Label()
        Me.TB_FirmenName = New System.Windows.Forms.TextBox()
        Me.BTN_Suche = New System.Windows.Forms.Button()
        Me.LBL_IDFirmenName = New System.Windows.Forms.Label()
        Me.FirmenNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._WSL_AdressenDataSet = New Adress_DB._WSL_AdressenDataSet()
        Me.lblIDKonto = New System.Windows.Forms.Label()
        Me.KontoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_FirmenName = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_NachnameSuche = New System.Windows.Forms.Button()
        Me.lblTrefferAnzahl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblHinweisKeinTreffer = New System.Windows.Forms.Label()
        Me.DocuwareCSVDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DocuwareCSVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LBL_IDAdresse = New System.Windows.Forms.Label()
        Me.AdressenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnNeueAdresse = New System.Windows.Forms.Button()
        Me.btnNeuerKontakt = New System.Windows.Forms.Button()
        Me.BTN_ZuOutlook = New System.Windows.Forms.Button()
        Me.BTN_MapsSuche = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNeuesKonto = New System.Windows.Forms.Button()
        Me.KontoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTN_Speichern = New System.Windows.Forms.Button()
        Me.btnKontoZuAdresse = New System.Windows.Forms.Button()
        Me.IDKontoTextBox = New System.Windows.Forms.TextBox()
        Me.WebseiteTextBox = New System.Windows.Forms.TextBox()
        Me.UStIdNrTextBox = New System.Windows.Forms.TextBox()
        Me.TB_Bundesland = New System.Windows.Forms.TextBox()
        Me.PostfachTextBox = New System.Windows.Forms.TextBox()
        Me.TB_PLZ = New System.Windows.Forms.TextBox()
        Me.StraßeTextBox = New System.Windows.Forms.TextBox()
        Me.AdresstypTextBox = New System.Windows.Forms.TextBox()
        Me.AdressenDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDAdresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDKonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddresseLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.KontakteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAdresseZuKontakt = New System.Windows.Forms.Button()
        Me.IDAdresseTextBox = New System.Windows.Forms.TextBox()
        Me.FaxnummerTextBox = New System.Windows.Forms.TextBox()
        Me.MobiltelefonTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonPrivatTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonGeschaeftlichTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddresseTextBox = New System.Windows.Forms.TextBox()
        Me.VornameTextBox = New System.Windows.Forms.TextBox()
        Me.NachnameTextBox = New System.Windows.Forms.TextBox()
        Me.AnredeComboBox = New System.Windows.Forms.ComboBox()
        Me.LBL_IDKontakt = New System.Windows.Forms.Label()
        Me.KontakteDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDKontakt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblKontaktHeader = New System.Windows.Forms.Label()
        Me.TC_Beleg = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CB_BBKuerzel = New System.Windows.Forms.ComboBox()
        Me.SachbearbeiterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_BBWeitereBesucher = New System.Windows.Forms.TextBox()
        Me.TB_BBWeitereKontakte = New System.Windows.Forms.TextBox()
        Me.LBL_BBRegion = New System.Windows.Forms.Label()
        Me.LBL_BBIDKonto = New System.Windows.Forms.Label()
        Me.LBL_BBBesuchterKontakt = New System.Windows.Forms.Label()
        Me.LBL_BBLand = New System.Windows.Forms.Label()
        Me.LBL_BBOrt = New System.Windows.Forms.Label()
        Me.LBL_BBPLZ = New System.Windows.Forms.Label()
        Me.LBL_BBStrasse = New System.Windows.Forms.Label()
        Me.TB_BBThema = New System.Windows.Forms.TextBox()
        Me.DTP_BBDatum = New System.Windows.Forms.DateTimePicker()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LBL_DIVIDKonto = New System.Windows.Forms.Label()
        Me.LBL_DIVEmail = New System.Windows.Forms.Label()
        Me.LBL_DIVDurchwahl = New System.Windows.Forms.Label()
        Me.LBL_DIVJobtitle = New System.Windows.Forms.Label()
        Me.CB_DIVSachbearbeiter = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TB_DIVThema = New System.Windows.Forms.TextBox()
        Me.DTP_Diverse = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBL_DIVAdresse = New System.Windows.Forms.Label()
        Me.GB_Anrede = New System.Windows.Forms.GroupBox()
        Me.RB_OhneAnrede = New System.Windows.Forms.RadioButton()
        Me.RB_MitAnrede = New System.Windows.Forms.RadioButton()
        Me.TB_DIVFaxnummer = New System.Windows.Forms.TextBox()
        Me.LBL_Sprache = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_Vorlagen = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDBelegDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KuerzelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KontaktDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ThemaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BelegnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BelegeMitAdresseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LBL_FirmenName = New System.Windows.Forms.Label()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.BTN_DocErzeugen = New System.Windows.Forms.Button()
        Me.TC_Adresse = New System.Windows.Forms.TabControl()
        Me.TabAdresseInfo = New System.Windows.Forms.TabPage()
        Me.LBL_CC = New System.Windows.Forms.Label()
        Me.StaatenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelLandAdressen = New System.Windows.Forms.Label()
        Me.PNL_Geodaten = New System.Windows.Forms.Panel()
        Me.LBL_Lat = New System.Windows.Forms.Label()
        Me.LBL_Long = New System.Windows.Forms.Label()
        Me.LBLLat = New System.Windows.Forms.Label()
        Me.LBLLong = New System.Windows.Forms.Label()
        Me.LBL_AdressHinweis = New System.Windows.Forms.Label()
        Me.LBL_IDKontoZuAdresse = New System.Windows.Forms.Label()
        Me.WebseiteLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.UStIdNrLabel2 = New System.Windows.Forms.Label()
        Me.LBL_Land = New System.Windows.Forms.Label()
        Me.BundeslandLabel2 = New System.Windows.Forms.Label()
        Me.LBL_Ort = New System.Windows.Forms.Label()
        Me.LBL_PLZ = New System.Windows.Forms.Label()
        Me.PostfachLabel2 = New System.Windows.Forms.Label()
        Me.LBL_Strasse = New System.Windows.Forms.Label()
        Me.AdresstypLabel2 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabAdresseBearbeiten = New System.Windows.Forms.TabPage()
        Me.LBL_PLZungueltig = New System.Windows.Forms.Label()
        Me.CB_Ort = New System.Windows.Forms.ComboBox()
        Me.LBL_Countrycode = New System.Windows.Forms.Label()
        Me.CB_Staat = New System.Windows.Forms.ComboBox()
        Me.lblAdresseNeu = New System.Windows.Forms.Label()
        Me.TC_Kontakt = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.OrtLabel3 = New System.Windows.Forms.Label()
        Me.StraßeLabel3 = New System.Windows.Forms.Label()
        Me.LBL_IDAdresseZuKontakt = New System.Windows.Forms.Label()
        Me.FaxnummerLabel2 = New System.Windows.Forms.Label()
        Me.MobiltelefonLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.TelefonPrivatLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.TelefonGeschaeftlichLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.PositionLabel2 = New System.Windows.Forms.Label()
        Me.LBL_Nachname = New System.Windows.Forms.Label()
        Me.LBL_Vorname = New System.Windows.Forms.Label()
        Me.LBL_Anrede = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.BTN_DeleteUser = New System.Windows.Forms.Button()
        Me.lblKontaktNeu = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocuWareDateiManuellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SchließenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BenutzerlisteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AktivitätslogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoÜberAdressenDBToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.KontakteMitAdresseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FirmenNameTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.FirmenNameTableAdapter()
        Me.KontoTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.KontoTableAdapter()
        Me.AdressenTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.AdressenTableAdapter()
        Me.TableAdapterManager = New Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager()
        Me.KontakteTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.KontakteTableAdapter()
        Me.SachbearbeiterTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter()
        Me.KontakteMitAdresseTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.KontakteMitAdresseTableAdapter()
        Me.DocuwareCSVTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.DocuwareCSVTableAdapter()
        Me.BelegeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BelegeTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.BelegeTableAdapter()
        Me.BelegeMitAdresseTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.BelegeMitAdresseTableAdapter()
        Me.LogTabelleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogTabelleTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.LogTabelleTableAdapter()
        Me.StaatenTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.StaatenTableAdapter()
        Me.AT_PLZ_GeodatenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AT_PLZ_GeodatenTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.AT_PLZ_GeodatenTableAdapter()
        Me.CH_PLZ_GeodatenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CH_PLZ_GeodatenTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.CH_PLZ_GeodatenTableAdapter()
        Me.DE_PLZ_GeodatenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DE_PLZ_GeodatenTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.DE_PLZ_GeodatenTableAdapter()
        Me.PropertiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PropertiesTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.propertiesTableAdapter()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.TLP_1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PNL_Konto = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        AdresstypLabel = New System.Windows.Forms.Label()
        StraßeLabel = New System.Windows.Forms.Label()
        PLZLabel = New System.Windows.Forms.Label()
        PostfachLabel = New System.Windows.Forms.Label()
        OrtLabel = New System.Windows.Forms.Label()
        BundeslandLabel = New System.Windows.Forms.Label()
        LandLabel = New System.Windows.Forms.Label()
        UStIdNrLabel = New System.Windows.Forms.Label()
        WebseiteLabel = New System.Windows.Forms.Label()
        AnredeLabel = New System.Windows.Forms.Label()
        NachnameLabel = New System.Windows.Forms.Label()
        VornameLabel = New System.Windows.Forms.Label()
        EmailAddresseLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        TelefonGeschaeftlichLabel = New System.Windows.Forms.Label()
        TelefonPrivatLabel = New System.Windows.Forms.Label()
        MobiltelefonLabel = New System.Windows.Forms.Label()
        FaxnummerLabel = New System.Windows.Forms.Label()
        AdresstypLabel1 = New System.Windows.Forms.Label()
        StraßeLabel1 = New System.Windows.Forms.Label()
        PostfachLabel1 = New System.Windows.Forms.Label()
        PLZLabel1 = New System.Windows.Forms.Label()
        OrtLabel1 = New System.Windows.Forms.Label()
        BundeslandLabel1 = New System.Windows.Forms.Label()
        UStIdNrLabel1 = New System.Windows.Forms.Label()
        WebseiteLabel1 = New System.Windows.Forms.Label()
        AnredeLabel1 = New System.Windows.Forms.Label()
        VornameLabel1 = New System.Windows.Forms.Label()
        NachnameLabel1 = New System.Windows.Forms.Label()
        EmailAddresseLabel1 = New System.Windows.Forms.Label()
        PositionLabel1 = New System.Windows.Forms.Label()
        TelefonGeschaeftlichLabel1 = New System.Windows.Forms.Label()
        TelefonPrivatLabel1 = New System.Windows.Forms.Label()
        MobiltelefonLabel1 = New System.Windows.Forms.Label()
        FaxnummerLabel1 = New System.Windows.Forms.Label()
        IDAdresseLabel = New System.Windows.Forms.Label()
        IDKontoLabel = New System.Windows.Forms.Label()
        IDLKontoLabel2 = New System.Windows.Forms.Label()
        DirekterKontaktLabel = New System.Windows.Forms.Label()
        WeitereKontakteLabel = New System.Windows.Forms.Label()
        DatumLabel = New System.Windows.Forms.Label()
        VonWemBesuchtLabel = New System.Windows.Forms.Label()
        WeitereBesucherLabel = New System.Windows.Forms.Label()
        ThemaLabel = New System.Windows.Forms.Label()
        PLZLabel2 = New System.Windows.Forms.Label()
        FaxnummerLabel3 = New System.Windows.Forms.Label()
        SachbearbeiterLabel = New System.Windows.Forms.Label()
        JobtitleLabel = New System.Windows.Forms.Label()
        DurchwahlLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        IDKontoLabel1 = New System.Windows.Forms.Label()
        CType(Me.FirmenNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._WSL_AdressenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KontoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DocuwareCSVDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocuwareCSVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdressenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.KontoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdressenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KontakteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KontakteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TC_Beleg.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SachbearbeiterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GB_Anrede.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BelegeMitAdresseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.TC_Adresse.SuspendLayout()
        Me.TabAdresseInfo.SuspendLayout()
        CType(Me.StaatenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_Geodaten.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabAdresseBearbeiten.SuspendLayout()
        Me.TC_Kontakt.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.KontakteMitAdresseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BelegeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogTabelleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AT_PLZ_GeodatenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CH_PLZ_GeodatenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DE_PLZ_GeodatenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.TLP_1.SuspendLayout()
        Me.PNL_Konto.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AdresstypLabel
        '
        AdresstypLabel.AutoSize = True
        AdresstypLabel.Location = New System.Drawing.Point(13, 37)
        AdresstypLabel.Name = "AdresstypLabel"
        AdresstypLabel.Size = New System.Drawing.Size(56, 13)
        AdresstypLabel.TabIndex = 4
        AdresstypLabel.Text = "Adresstyp:"
        '
        'StraßeLabel
        '
        StraßeLabel.AutoSize = True
        StraßeLabel.Location = New System.Drawing.Point(25, 88)
        StraßeLabel.Name = "StraßeLabel"
        StraßeLabel.Size = New System.Drawing.Size(41, 13)
        StraßeLabel.TabIndex = 6
        StraßeLabel.Text = "Straße:"
        '
        'PLZLabel
        '
        PLZLabel.AutoSize = True
        PLZLabel.Location = New System.Drawing.Point(36, 140)
        PLZLabel.Name = "PLZLabel"
        PLZLabel.Size = New System.Drawing.Size(30, 13)
        PLZLabel.TabIndex = 10
        PLZLabel.Text = "PLZ:"
        '
        'PostfachLabel
        '
        PostfachLabel.AutoSize = True
        PostfachLabel.Location = New System.Drawing.Point(14, 114)
        PostfachLabel.Name = "PostfachLabel"
        PostfachLabel.Size = New System.Drawing.Size(52, 13)
        PostfachLabel.TabIndex = 11
        PostfachLabel.Text = "Postfach:"
        '
        'OrtLabel
        '
        OrtLabel.AutoSize = True
        OrtLabel.Location = New System.Drawing.Point(42, 169)
        OrtLabel.Name = "OrtLabel"
        OrtLabel.Size = New System.Drawing.Size(31, 13)
        OrtLabel.TabIndex = 12
        OrtLabel.Text = "Ort: *"
        '
        'BundeslandLabel
        '
        BundeslandLabel.AutoSize = True
        BundeslandLabel.Location = New System.Drawing.Point(22, 196)
        BundeslandLabel.Name = "BundeslandLabel"
        BundeslandLabel.Size = New System.Drawing.Size(44, 13)
        BundeslandLabel.TabIndex = 14
        BundeslandLabel.Text = "Region:"
        '
        'LandLabel
        '
        LandLabel.AutoSize = True
        LandLabel.Location = New System.Drawing.Point(32, 63)
        LandLabel.Name = "LandLabel"
        LandLabel.Size = New System.Drawing.Size(34, 13)
        LandLabel.TabIndex = 16
        LandLabel.Text = "Land:"
        '
        'UStIdNrLabel
        '
        UStIdNrLabel.AutoSize = True
        UStIdNrLabel.Location = New System.Drawing.Point(12, 218)
        UStIdNrLabel.Name = "UStIdNrLabel"
        UStIdNrLabel.Size = New System.Drawing.Size(54, 13)
        UStIdNrLabel.TabIndex = 18
        UStIdNrLabel.Text = "USt Id Nr:"
        '
        'WebseiteLabel
        '
        WebseiteLabel.AutoSize = True
        WebseiteLabel.Location = New System.Drawing.Point(14, 247)
        WebseiteLabel.Name = "WebseiteLabel"
        WebseiteLabel.Size = New System.Drawing.Size(55, 13)
        WebseiteLabel.TabIndex = 20
        WebseiteLabel.Text = "Webseite:"
        '
        'AnredeLabel
        '
        AnredeLabel.AutoSize = True
        AnredeLabel.Location = New System.Drawing.Point(49, 40)
        AnredeLabel.Name = "AnredeLabel"
        AnredeLabel.Size = New System.Drawing.Size(44, 13)
        AnredeLabel.TabIndex = 3
        AnredeLabel.Text = "Anrede:"
        '
        'NachnameLabel
        '
        NachnameLabel.AutoSize = True
        NachnameLabel.Location = New System.Drawing.Point(34, 63)
        NachnameLabel.Name = "NachnameLabel"
        NachnameLabel.Size = New System.Drawing.Size(69, 13)
        NachnameLabel.TabIndex = 5
        NachnameLabel.Text = "Nachname: *"
        '
        'VornameLabel
        '
        VornameLabel.AutoSize = True
        VornameLabel.Location = New System.Drawing.Point(46, 88)
        VornameLabel.Name = "VornameLabel"
        VornameLabel.Size = New System.Drawing.Size(52, 13)
        VornameLabel.TabIndex = 7
        VornameLabel.Text = "Vorname:"
        '
        'EmailAddresseLabel
        '
        EmailAddresseLabel.AutoSize = True
        EmailAddresseLabel.Location = New System.Drawing.Point(16, 114)
        EmailAddresseLabel.Name = "EmailAddresseLabel"
        EmailAddresseLabel.Size = New System.Drawing.Size(82, 13)
        EmailAddresseLabel.TabIndex = 9
        EmailAddresseLabel.Text = "Email Addresse:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(51, 140)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(47, 13)
        PositionLabel.TabIndex = 11
        PositionLabel.Text = "Position:"
        '
        'TelefonGeschaeftlichLabel
        '
        TelefonGeschaeftlichLabel.AutoSize = True
        TelefonGeschaeftlichLabel.Location = New System.Drawing.Point(11, 166)
        TelefonGeschaeftlichLabel.Name = "TelefonGeschaeftlichLabel"
        TelefonGeschaeftlichLabel.Size = New System.Drawing.Size(84, 13)
        TelefonGeschaeftlichLabel.TabIndex = 13
        TelefonGeschaeftlichLabel.Text = "Telefon (gesch):"
        '
        'TelefonPrivatLabel
        '
        TelefonPrivatLabel.AutoSize = True
        TelefonPrivatLabel.Location = New System.Drawing.Point(22, 192)
        TelefonPrivatLabel.Name = "TelefonPrivatLabel"
        TelefonPrivatLabel.Size = New System.Drawing.Size(81, 13)
        TelefonPrivatLabel.TabIndex = 15
        TelefonPrivatLabel.Text = "Telefon (privat):"
        '
        'MobiltelefonLabel
        '
        MobiltelefonLabel.AutoSize = True
        MobiltelefonLabel.Location = New System.Drawing.Point(31, 218)
        MobiltelefonLabel.Name = "MobiltelefonLabel"
        MobiltelefonLabel.Size = New System.Drawing.Size(67, 13)
        MobiltelefonLabel.TabIndex = 17
        MobiltelefonLabel.Text = "Mobiltelefon:"
        '
        'FaxnummerLabel
        '
        FaxnummerLabel.AutoSize = True
        FaxnummerLabel.Location = New System.Drawing.Point(34, 244)
        FaxnummerLabel.Name = "FaxnummerLabel"
        FaxnummerLabel.Size = New System.Drawing.Size(64, 13)
        FaxnummerLabel.TabIndex = 19
        FaxnummerLabel.Text = "Faxnummer:"
        '
        'AdresstypLabel1
        '
        AdresstypLabel1.AutoSize = True
        AdresstypLabel1.Location = New System.Drawing.Point(21, 40)
        AdresstypLabel1.Name = "AdresstypLabel1"
        AdresstypLabel1.Size = New System.Drawing.Size(56, 13)
        AdresstypLabel1.TabIndex = 1
        AdresstypLabel1.Text = "Adresstyp:"
        '
        'StraßeLabel1
        '
        StraßeLabel1.AutoSize = True
        StraßeLabel1.Location = New System.Drawing.Point(36, 76)
        StraßeLabel1.Name = "StraßeLabel1"
        StraßeLabel1.Size = New System.Drawing.Size(41, 13)
        StraßeLabel1.TabIndex = 3
        StraßeLabel1.Text = "Straße:"
        '
        'PostfachLabel1
        '
        PostfachLabel1.AutoSize = True
        PostfachLabel1.Location = New System.Drawing.Point(25, 91)
        PostfachLabel1.Name = "PostfachLabel1"
        PostfachLabel1.Size = New System.Drawing.Size(52, 13)
        PostfachLabel1.TabIndex = 5
        PostfachLabel1.Text = "Postfach:"
        '
        'PLZLabel1
        '
        PLZLabel1.AutoSize = True
        PLZLabel1.Location = New System.Drawing.Point(47, 106)
        PLZLabel1.Name = "PLZLabel1"
        PLZLabel1.Size = New System.Drawing.Size(30, 13)
        PLZLabel1.TabIndex = 7
        PLZLabel1.Text = "PLZ:"
        '
        'OrtLabel1
        '
        OrtLabel1.AutoSize = True
        OrtLabel1.Location = New System.Drawing.Point(53, 121)
        OrtLabel1.Name = "OrtLabel1"
        OrtLabel1.Size = New System.Drawing.Size(24, 13)
        OrtLabel1.TabIndex = 9
        OrtLabel1.Text = "Ort:"
        '
        'BundeslandLabel1
        '
        BundeslandLabel1.AutoSize = True
        BundeslandLabel1.Location = New System.Drawing.Point(33, 136)
        BundeslandLabel1.Name = "BundeslandLabel1"
        BundeslandLabel1.Size = New System.Drawing.Size(44, 13)
        BundeslandLabel1.TabIndex = 11
        BundeslandLabel1.Text = "Region:"
        '
        'UStIdNrLabel1
        '
        UStIdNrLabel1.AutoSize = True
        UStIdNrLabel1.Location = New System.Drawing.Point(23, 171)
        UStIdNrLabel1.Name = "UStIdNrLabel1"
        UStIdNrLabel1.Size = New System.Drawing.Size(54, 13)
        UStIdNrLabel1.TabIndex = 15
        UStIdNrLabel1.Text = "USt Id Nr:"
        '
        'WebseiteLabel1
        '
        WebseiteLabel1.AutoSize = True
        WebseiteLabel1.Location = New System.Drawing.Point(22, 191)
        WebseiteLabel1.Name = "WebseiteLabel1"
        WebseiteLabel1.Size = New System.Drawing.Size(55, 13)
        WebseiteLabel1.TabIndex = 17
        WebseiteLabel1.Text = "Webseite:"
        '
        'AnredeLabel1
        '
        AnredeLabel1.AutoSize = True
        AnredeLabel1.Location = New System.Drawing.Point(50, 40)
        AnredeLabel1.Name = "AnredeLabel1"
        AnredeLabel1.Size = New System.Drawing.Size(44, 13)
        AnredeLabel1.TabIndex = 26
        AnredeLabel1.Text = "Anrede:"
        '
        'VornameLabel1
        '
        VornameLabel1.AutoSize = True
        VornameLabel1.Location = New System.Drawing.Point(42, 70)
        VornameLabel1.Name = "VornameLabel1"
        VornameLabel1.Size = New System.Drawing.Size(52, 13)
        VornameLabel1.TabIndex = 27
        VornameLabel1.Text = "Vorname:"
        '
        'NachnameLabel1
        '
        NachnameLabel1.AutoSize = True
        NachnameLabel1.Location = New System.Drawing.Point(32, 55)
        NachnameLabel1.Name = "NachnameLabel1"
        NachnameLabel1.Size = New System.Drawing.Size(62, 13)
        NachnameLabel1.TabIndex = 28
        NachnameLabel1.Text = "Nachname:"
        '
        'EmailAddresseLabel1
        '
        EmailAddresseLabel1.AutoSize = True
        EmailAddresseLabel1.Location = New System.Drawing.Point(12, 105)
        EmailAddresseLabel1.Name = "EmailAddresseLabel1"
        EmailAddresseLabel1.Size = New System.Drawing.Size(82, 13)
        EmailAddresseLabel1.TabIndex = 29
        EmailAddresseLabel1.Text = "Email Addresse:"
        '
        'PositionLabel1
        '
        PositionLabel1.AutoSize = True
        PositionLabel1.Location = New System.Drawing.Point(47, 85)
        PositionLabel1.Name = "PositionLabel1"
        PositionLabel1.Size = New System.Drawing.Size(47, 13)
        PositionLabel1.TabIndex = 29
        PositionLabel1.Text = "Position:"
        '
        'TelefonGeschaeftlichLabel1
        '
        TelefonGeschaeftlichLabel1.AutoSize = True
        TelefonGeschaeftlichLabel1.Location = New System.Drawing.Point(10, 130)
        TelefonGeschaeftlichLabel1.Name = "TelefonGeschaeftlichLabel1"
        TelefonGeschaeftlichLabel1.Size = New System.Drawing.Size(84, 13)
        TelefonGeschaeftlichLabel1.TabIndex = 30
        TelefonGeschaeftlichLabel1.Text = "Telefon (gesch):"
        '
        'TelefonPrivatLabel1
        '
        TelefonPrivatLabel1.AutoSize = True
        TelefonPrivatLabel1.Location = New System.Drawing.Point(11, 155)
        TelefonPrivatLabel1.Name = "TelefonPrivatLabel1"
        TelefonPrivatLabel1.Size = New System.Drawing.Size(81, 13)
        TelefonPrivatLabel1.TabIndex = 31
        TelefonPrivatLabel1.Text = "Telefon (privat):"
        '
        'MobiltelefonLabel1
        '
        MobiltelefonLabel1.AutoSize = True
        MobiltelefonLabel1.Location = New System.Drawing.Point(27, 180)
        MobiltelefonLabel1.Name = "MobiltelefonLabel1"
        MobiltelefonLabel1.Size = New System.Drawing.Size(67, 13)
        MobiltelefonLabel1.TabIndex = 32
        MobiltelefonLabel1.Text = "Mobiltelefon:"
        '
        'FaxnummerLabel1
        '
        FaxnummerLabel1.AutoSize = True
        FaxnummerLabel1.Location = New System.Drawing.Point(30, 205)
        FaxnummerLabel1.Name = "FaxnummerLabel1"
        FaxnummerLabel1.Size = New System.Drawing.Size(64, 13)
        FaxnummerLabel1.TabIndex = 33
        FaxnummerLabel1.Text = "Faxnummer:"
        '
        'IDAdresseLabel
        '
        IDAdresseLabel.AutoSize = True
        IDAdresseLabel.Location = New System.Drawing.Point(35, 227)
        IDAdresseLabel.Name = "IDAdresseLabel"
        IDAdresseLabel.Size = New System.Drawing.Size(59, 13)
        IDAdresseLabel.TabIndex = 34
        IDAdresseLabel.Text = "IDAdresse:"
        '
        'IDKontoLabel
        '
        IDKontoLabel.AutoSize = True
        IDKontoLabel.Location = New System.Drawing.Point(29, 215)
        IDKontoLabel.Name = "IDKontoLabel"
        IDKontoLabel.Size = New System.Drawing.Size(49, 13)
        IDKontoLabel.TabIndex = 20
        IDKontoLabel.Text = "IDKonto:"
        '
        'IDLKontoLabel2
        '
        IDLKontoLabel2.AutoSize = True
        IDLKontoLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLKontoLabel2.Location = New System.Drawing.Point(5, 33)
        IDLKontoLabel2.Name = "IDLKontoLabel2"
        IDLKontoLabel2.Size = New System.Drawing.Size(52, 13)
        IDLKontoLabel2.TabIndex = 3
        IDLKontoLabel2.Text = "ID-Konto:"
        '
        'DirekterKontaktLabel
        '
        DirekterKontaktLabel.AutoSize = True
        DirekterKontaktLabel.Location = New System.Drawing.Point(6, 55)
        DirekterKontaktLabel.Name = "DirekterKontaktLabel"
        DirekterKontaktLabel.Size = New System.Drawing.Size(98, 13)
        DirekterKontaktLabel.TabIndex = 7
        DirekterKontaktLabel.Text = "Besuchter Kontakt:"
        '
        'WeitereKontakteLabel
        '
        WeitereKontakteLabel.AutoSize = True
        WeitereKontakteLabel.Location = New System.Drawing.Point(3, 98)
        WeitereKontakteLabel.Name = "WeitereKontakteLabel"
        WeitereKontakteLabel.Size = New System.Drawing.Size(245, 13)
        WeitereKontakteLabel.TabIndex = 9
        WeitereKontakteLabel.Text = "Weitere Telnehmer des besuchten Unternehmens:"
        '
        'DatumLabel
        '
        DatumLabel.AutoSize = True
        DatumLabel.Location = New System.Drawing.Point(5, 138)
        DatumLabel.Name = "DatumLabel"
        DatumLabel.Size = New System.Drawing.Size(105, 13)
        DatumLabel.TabIndex = 11
        DatumLabel.Text = "Datum des Besuchs:"
        '
        'VonWemBesuchtLabel
        '
        VonWemBesuchtLabel.AutoSize = True
        VonWemBesuchtLabel.Location = New System.Drawing.Point(5, 178)
        VonWemBesuchtLabel.Name = "VonWemBesuchtLabel"
        VonWemBesuchtLabel.Size = New System.Drawing.Size(99, 13)
        VonWemBesuchtLabel.TabIndex = 13
        VonWemBesuchtLabel.Text = "Von Wem Besucht:"
        '
        'WeitereBesucherLabel
        '
        WeitereBesucherLabel.AutoSize = True
        WeitereBesucherLabel.Location = New System.Drawing.Point(5, 217)
        WeitereBesucherLabel.Name = "WeitereBesucherLabel"
        WeitereBesucherLabel.Size = New System.Drawing.Size(181, 13)
        WeitereBesucherLabel.TabIndex = 15
        WeitereBesucherLabel.Text = "Weitere Besucher von WSL (Kürzel):"
        '
        'ThemaLabel
        '
        ThemaLabel.AutoSize = True
        ThemaLabel.Location = New System.Drawing.Point(6, 257)
        ThemaLabel.Name = "ThemaLabel"
        ThemaLabel.Size = New System.Drawing.Size(50, 13)
        ThemaLabel.TabIndex = 17
        ThemaLabel.Text = "Thema *:"
        '
        'PLZLabel2
        '
        PLZLabel2.AutoSize = True
        PLZLabel2.Location = New System.Drawing.Point(226, 154)
        PLZLabel2.Name = "PLZLabel2"
        PLZLabel2.Size = New System.Drawing.Size(48, 13)
        PLZLabel2.TabIndex = 20
        PLZLabel2.Text = "Adresse:"
        '
        'FaxnummerLabel3
        '
        FaxnummerLabel3.AutoSize = True
        FaxnummerLabel3.Location = New System.Drawing.Point(52, 91)
        FaxnummerLabel3.Name = "FaxnummerLabel3"
        FaxnummerLabel3.Size = New System.Drawing.Size(64, 13)
        FaxnummerLabel3.TabIndex = 3
        FaxnummerLabel3.Text = "Faxnummer:"
        '
        'SachbearbeiterLabel
        '
        SachbearbeiterLabel.AutoSize = True
        SachbearbeiterLabel.Location = New System.Drawing.Point(37, 312)
        SachbearbeiterLabel.Name = "SachbearbeiterLabel"
        SachbearbeiterLabel.Size = New System.Drawing.Size(82, 13)
        SachbearbeiterLabel.TabIndex = 13
        SachbearbeiterLabel.Text = "Sachbearbeiter:"
        '
        'JobtitleLabel
        '
        JobtitleLabel.AutoSize = True
        JobtitleLabel.Location = New System.Drawing.Point(72, 336)
        JobtitleLabel.Name = "JobtitleLabel"
        JobtitleLabel.Size = New System.Drawing.Size(47, 13)
        JobtitleLabel.TabIndex = 15
        JobtitleLabel.Text = "Position:"
        '
        'DurchwahlLabel
        '
        DurchwahlLabel.AutoSize = True
        DurchwahlLabel.Location = New System.Drawing.Point(55, 362)
        DurchwahlLabel.Name = "DurchwahlLabel"
        DurchwahlLabel.Size = New System.Drawing.Size(61, 13)
        DurchwahlLabel.TabIndex = 17
        DurchwahlLabel.Text = "Durchwahl:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(81, 385)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 19
        EmailLabel.Text = "Email:"
        '
        'IDKontoLabel1
        '
        IDKontoLabel1.AutoSize = True
        IDKontoLabel1.Location = New System.Drawing.Point(67, 117)
        IDKontoLabel1.Name = "IDKontoLabel1"
        IDKontoLabel1.Size = New System.Drawing.Size(49, 13)
        IDKontoLabel1.TabIndex = 21
        IDKontoLabel1.Text = "IDKonto:"
        '
        'StraßeLabel2
        '
        Me.StraßeLabel2.AutoSize = True
        Me.StraßeLabel2.Location = New System.Drawing.Point(55, 242)
        Me.StraßeLabel2.Name = "StraßeLabel2"
        Me.StraßeLabel2.Size = New System.Drawing.Size(41, 13)
        Me.StraßeLabel2.TabIndex = 35
        Me.StraßeLabel2.Text = "Straße:"
        '
        'OrtLabel2
        '
        Me.OrtLabel2.AutoSize = True
        Me.OrtLabel2.Location = New System.Drawing.Point(70, 257)
        Me.OrtLabel2.Name = "OrtLabel2"
        Me.OrtLabel2.Size = New System.Drawing.Size(24, 13)
        Me.OrtLabel2.TabIndex = 36
        Me.OrtLabel2.Text = "Ort:"
        '
        'TB_FirmenName
        '
        Me.TB_FirmenName.BackColor = System.Drawing.SystemColors.Window
        Me.TB_FirmenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_FirmenName.Location = New System.Drawing.Point(103, 8)
        Me.TB_FirmenName.Name = "TB_FirmenName"
        Me.TB_FirmenName.Size = New System.Drawing.Size(327, 22)
        Me.TB_FirmenName.TabIndex = 1
        '
        'BTN_Suche
        '
        Me.BTN_Suche.Image = Global.Adress_DB.My.Resources.Resources.Search_16x
        Me.BTN_Suche.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Suche.Location = New System.Drawing.Point(457, 8)
        Me.BTN_Suche.Name = "BTN_Suche"
        Me.BTN_Suche.Size = New System.Drawing.Size(106, 23)
        Me.BTN_Suche.TabIndex = 2
        Me.BTN_Suche.Text = "Geschäftspartner"
        Me.BTN_Suche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Suche.UseVisualStyleBackColor = True
        '
        'LBL_IDFirmenName
        '
        Me.LBL_IDFirmenName.BackColor = System.Drawing.Color.Transparent
        Me.LBL_IDFirmenName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FirmenNameBindingSource, "IDFirmenName", True))
        Me.LBL_IDFirmenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_IDFirmenName.ForeColor = System.Drawing.Color.White
        Me.LBL_IDFirmenName.Location = New System.Drawing.Point(3, 34)
        Me.LBL_IDFirmenName.Name = "LBL_IDFirmenName"
        Me.LBL_IDFirmenName.Size = New System.Drawing.Size(94, 23)
        Me.LBL_IDFirmenName.TabIndex = 8
        Me.LBL_IDFirmenName.Text = "IDFirmenName"
        Me.LBL_IDFirmenName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FirmenNameBindingSource
        '
        Me.FirmenNameBindingSource.DataMember = "FirmenName"
        Me.FirmenNameBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        '_WSL_AdressenDataSet
        '
        Me._WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet"
        Me._WSL_AdressenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblIDKonto
        '
        Me.lblIDKonto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontoBindingSource, "IDKonto", True))
        Me.lblIDKonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDKonto.Location = New System.Drawing.Point(21, 84)
        Me.lblIDKonto.Name = "lblIDKonto"
        Me.lblIDKonto.Size = New System.Drawing.Size(117, 23)
        Me.lblIDKonto.TabIndex = 10
        Me.lblIDKonto.Text = "IDKonto"
        Me.lblIDKonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'KontoBindingSource
        '
        Me.KontoBindingSource.DataMember = "Konto"
        Me.KontoBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'CB_FirmenName
        '
        Me.CB_FirmenName.DataSource = Me.FirmenNameBindingSource
        Me.CB_FirmenName.DisplayMember = "FirmenName"
        Me.CB_FirmenName.Enabled = False
        Me.CB_FirmenName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_FirmenName.FormattingEnabled = True
        Me.CB_FirmenName.Location = New System.Drawing.Point(103, 36)
        Me.CB_FirmenName.Name = "CB_FirmenName"
        Me.CB_FirmenName.Size = New System.Drawing.Size(408, 27)
        Me.CB_FirmenName.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.TLP_1.SetColumnSpan(Me.Panel1, 3)
        Me.Panel1.Controls.Add(Me.BTN_NachnameSuche)
        Me.Panel1.Controls.Add(Me.lblTrefferAnzahl)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CB_FirmenName)
        Me.Panel1.Controls.Add(Me.TB_FirmenName)
        Me.Panel1.Controls.Add(Me.BTN_Suche)
        Me.Panel1.Controls.Add(Me.LBL_IDFirmenName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 69)
        Me.Panel1.TabIndex = 12
        '
        'BTN_NachnameSuche
        '
        Me.BTN_NachnameSuche.Image = Global.Adress_DB.My.Resources.Resources.Search_16x
        Me.BTN_NachnameSuche.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_NachnameSuche.Location = New System.Drawing.Point(604, 8)
        Me.BTN_NachnameSuche.Name = "BTN_NachnameSuche"
        Me.BTN_NachnameSuche.Size = New System.Drawing.Size(106, 23)
        Me.BTN_NachnameSuche.TabIndex = 20
        Me.BTN_NachnameSuche.Text = "Nachname"
        Me.BTN_NachnameSuche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_NachnameSuche.UseVisualStyleBackColor = True
        '
        'lblTrefferAnzahl
        '
        Me.lblTrefferAnzahl.AutoSize = True
        Me.lblTrefferAnzahl.BackColor = System.Drawing.Color.White
        Me.lblTrefferAnzahl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrefferAnzahl.Location = New System.Drawing.Point(517, 40)
        Me.lblTrefferAnzahl.Name = "lblTrefferAnzahl"
        Me.lblTrefferAnzahl.Size = New System.Drawing.Size(106, 17)
        Me.lblTrefferAnzahl.TabIndex = 19
        Me.lblTrefferAnzahl.Text = "Trefferanzahl"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Suchtext:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(334, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Umkreissuche D-A-CH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblHinweisKeinTreffer
        '
        Me.lblHinweisKeinTreffer.AutoSize = True
        Me.lblHinweisKeinTreffer.BackColor = System.Drawing.SystemColors.Control
        Me.lblHinweisKeinTreffer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHinweisKeinTreffer.ForeColor = System.Drawing.Color.Red
        Me.lblHinweisKeinTreffer.Location = New System.Drawing.Point(545, 4)
        Me.lblHinweisKeinTreffer.Name = "lblHinweisKeinTreffer"
        Me.lblHinweisKeinTreffer.Size = New System.Drawing.Size(192, 26)
        Me.lblHinweisKeinTreffer.TabIndex = 16
        Me.lblHinweisKeinTreffer.Text = "0 Treffer Hinweis"
        Me.lblHinweisKeinTreffer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DocuwareCSVDataGridView
        '
        Me.DocuwareCSVDataGridView.AllowUserToAddRows = False
        Me.DocuwareCSVDataGridView.AutoGenerateColumns = False
        Me.DocuwareCSVDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DocuwareCSVDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.DocuwareCSVDataGridView.DataSource = Me.DocuwareCSVBindingSource
        Me.DocuwareCSVDataGridView.Location = New System.Drawing.Point(9, 4)
        Me.DocuwareCSVDataGridView.Name = "DocuwareCSVDataGridView"
        Me.DocuwareCSVDataGridView.RowHeadersVisible = False
        Me.DocuwareCSVDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DocuwareCSVDataGridView.Size = New System.Drawing.Size(129, 122)
        Me.DocuwareCSVDataGridView.TabIndex = 23
        Me.DocuwareCSVDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "IDKonto"
        Me.DataGridViewTextBoxColumn15.HeaderText = "ID-Konto"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "FirmenName"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Adress-Name"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "KontoName"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Konto-Name"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "IDFirmenName"
        Me.DataGridViewTextBoxColumn19.HeaderText = "ID-Adress-Name"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DocuwareCSVBindingSource
        '
        Me.DocuwareCSVBindingSource.DataMember = "DocuwareCSV"
        Me.DocuwareCSVBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'LBL_IDAdresse
        '
        Me.LBL_IDAdresse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_IDAdresse.BackColor = System.Drawing.Color.Transparent
        Me.LBL_IDAdresse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "IDAdresse", True))
        Me.LBL_IDAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_IDAdresse.ForeColor = System.Drawing.Color.DarkGray
        Me.LBL_IDAdresse.Location = New System.Drawing.Point(203, 2)
        Me.LBL_IDAdresse.Name = "LBL_IDAdresse"
        Me.LBL_IDAdresse.Size = New System.Drawing.Size(80, 23)
        Me.LBL_IDAdresse.TabIndex = 3
        Me.LBL_IDAdresse.Text = "IDAdresse"
        Me.LBL_IDAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AdressenBindingSource
        '
        Me.AdressenBindingSource.DataMember = "Adressen"
        Me.AdressenBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'btnNeueAdresse
        '
        Me.btnNeueAdresse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNeueAdresse.BackColor = System.Drawing.Color.Green
        Me.btnNeueAdresse.ForeColor = System.Drawing.Color.White
        Me.btnNeueAdresse.Image = Global.Adress_DB.My.Resources.Resources.AddressEditor_16x
        Me.btnNeueAdresse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNeueAdresse.Location = New System.Drawing.Point(175, 5)
        Me.btnNeueAdresse.Name = "btnNeueAdresse"
        Me.btnNeueAdresse.Size = New System.Drawing.Size(105, 23)
        Me.btnNeueAdresse.TabIndex = 7
        Me.btnNeueAdresse.Text = "neue Adresse"
        Me.btnNeueAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNeueAdresse.UseVisualStyleBackColor = False
        '
        'btnNeuerKontakt
        '
        Me.btnNeuerKontakt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNeuerKontakt.BackColor = System.Drawing.Color.Green
        Me.btnNeuerKontakt.ForeColor = System.Drawing.Color.White
        Me.btnNeuerKontakt.Image = Global.Adress_DB.My.Resources.Resources.AddUser_16x
        Me.btnNeuerKontakt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNeuerKontakt.Location = New System.Drawing.Point(175, 5)
        Me.btnNeuerKontakt.Name = "btnNeuerKontakt"
        Me.btnNeuerKontakt.Size = New System.Drawing.Size(105, 23)
        Me.btnNeuerKontakt.TabIndex = 2
        Me.btnNeuerKontakt.Text = "neuer Kontakt"
        Me.btnNeuerKontakt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNeuerKontakt.UseVisualStyleBackColor = False
        '
        'BTN_ZuOutlook
        '
        Me.BTN_ZuOutlook.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_ZuOutlook.Image = CType(resources.GetObject("BTN_ZuOutlook.Image"), System.Drawing.Image)
        Me.BTN_ZuOutlook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_ZuOutlook.Location = New System.Drawing.Point(175, 282)
        Me.BTN_ZuOutlook.Name = "BTN_ZuOutlook"
        Me.BTN_ZuOutlook.Size = New System.Drawing.Size(105, 28)
        Me.BTN_ZuOutlook.TabIndex = 1
        Me.BTN_ZuOutlook.Text = "zu Outlook"
        Me.BTN_ZuOutlook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_ZuOutlook.UseVisualStyleBackColor = True
        '
        'BTN_MapsSuche
        '
        Me.BTN_MapsSuche.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_MapsSuche.Image = CType(resources.GetObject("BTN_MapsSuche.Image"), System.Drawing.Image)
        Me.BTN_MapsSuche.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_MapsSuche.Location = New System.Drawing.Point(176, 281)
        Me.BTN_MapsSuche.Name = "BTN_MapsSuche"
        Me.BTN_MapsSuche.Size = New System.Drawing.Size(105, 28)
        Me.BTN_MapsSuche.TabIndex = 1
        Me.BTN_MapsSuche.Text = "GMaps Suche"
        Me.BTN_MapsSuche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_MapsSuche.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(158, 27)
        Me.Panel4.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Konto"
        '
        'btnNeuesKonto
        '
        Me.btnNeuesKonto.Image = Global.Adress_DB.My.Resources.Resources.AccountGroup_16x
        Me.btnNeuesKonto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNeuesKonto.Location = New System.Drawing.Point(31, 36)
        Me.btnNeuesKonto.Name = "btnNeuesKonto"
        Me.btnNeuesKonto.Size = New System.Drawing.Size(100, 23)
        Me.btnNeuesKonto.TabIndex = 4
        Me.btnNeuesKonto.Text = "Neues Konto"
        Me.btnNeuesKonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNeuesKonto.UseVisualStyleBackColor = True
        '
        'KontoDataGridView
        '
        Me.KontoDataGridView.AllowUserToAddRows = False
        Me.KontoDataGridView.AllowUserToDeleteRows = False
        Me.KontoDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KontoDataGridView.AutoGenerateColumns = False
        Me.KontoDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.KontoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KontoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6})
        Me.KontoDataGridView.DataSource = Me.KontoBindingSource
        Me.KontoDataGridView.Location = New System.Drawing.Point(0, 112)
        Me.KontoDataGridView.Name = "KontoDataGridView"
        Me.KontoDataGridView.RowHeadersVisible = False
        Me.KontoDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.KontoDataGridView.Size = New System.Drawing.Size(161, 154)
        Me.KontoDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IDKonto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Konto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "KontoName"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Konto-Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "aktuell markiertes Konto:"
        '
        'BTN_Speichern
        '
        Me.BTN_Speichern.Image = Global.Adress_DB.My.Resources.Resources.Save_16x
        Me.BTN_Speichern.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Speichern.Location = New System.Drawing.Point(639, 10)
        Me.BTN_Speichern.Name = "BTN_Speichern"
        Me.BTN_Speichern.Size = New System.Drawing.Size(80, 23)
        Me.BTN_Speichern.TabIndex = 15
        Me.BTN_Speichern.Text = "Speichern"
        Me.BTN_Speichern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Speichern.UseVisualStyleBackColor = True
        '
        'btnKontoZuAdresse
        '
        Me.btnKontoZuAdresse.Location = New System.Drawing.Point(74, 270)
        Me.btnKontoZuAdresse.Name = "btnKontoZuAdresse"
        Me.btnKontoZuAdresse.Size = New System.Drawing.Size(92, 23)
        Me.btnKontoZuAdresse.TabIndex = 17
        Me.btnKontoZuAdresse.Text = "Konto zuord."
        Me.btnKontoZuAdresse.UseVisualStyleBackColor = True
        '
        'IDKontoTextBox
        '
        Me.IDKontoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IDKontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "IDKonto", True))
        Me.IDKontoTextBox.Enabled = False
        Me.IDKontoTextBox.Location = New System.Drawing.Point(172, 270)
        Me.IDKontoTextBox.Name = "IDKontoTextBox"
        Me.IDKontoTextBox.Size = New System.Drawing.Size(109, 20)
        Me.IDKontoTextBox.TabIndex = 23
        '
        'WebseiteTextBox
        '
        Me.WebseiteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebseiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Webseite", True))
        Me.WebseiteTextBox.Location = New System.Drawing.Point(74, 244)
        Me.WebseiteTextBox.Name = "WebseiteTextBox"
        Me.WebseiteTextBox.Size = New System.Drawing.Size(207, 20)
        Me.WebseiteTextBox.TabIndex = 9
        '
        'UStIdNrTextBox
        '
        Me.UStIdNrTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UStIdNrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "UStIdNr", True))
        Me.UStIdNrTextBox.Location = New System.Drawing.Point(74, 218)
        Me.UStIdNrTextBox.Name = "UStIdNrTextBox"
        Me.UStIdNrTextBox.Size = New System.Drawing.Size(207, 20)
        Me.UStIdNrTextBox.TabIndex = 8
        '
        'TB_Bundesland
        '
        Me.TB_Bundesland.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_Bundesland.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Bundesland", True))
        Me.TB_Bundesland.Location = New System.Drawing.Point(74, 192)
        Me.TB_Bundesland.Name = "TB_Bundesland"
        Me.TB_Bundesland.Size = New System.Drawing.Size(207, 20)
        Me.TB_Bundesland.TabIndex = 7
        '
        'PostfachTextBox
        '
        Me.PostfachTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PostfachTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Postfach", True))
        Me.PostfachTextBox.Location = New System.Drawing.Point(74, 112)
        Me.PostfachTextBox.Name = "PostfachTextBox"
        Me.PostfachTextBox.Size = New System.Drawing.Size(207, 20)
        Me.PostfachTextBox.TabIndex = 4
        '
        'TB_PLZ
        '
        Me.TB_PLZ.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "PLZ", True))
        Me.TB_PLZ.Location = New System.Drawing.Point(74, 138)
        Me.TB_PLZ.Name = "TB_PLZ"
        Me.TB_PLZ.Size = New System.Drawing.Size(92, 20)
        Me.TB_PLZ.TabIndex = 5
        '
        'StraßeTextBox
        '
        Me.StraßeTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StraßeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Straße", True))
        Me.StraßeTextBox.Location = New System.Drawing.Point(74, 86)
        Me.StraßeTextBox.Name = "StraßeTextBox"
        Me.StraßeTextBox.Size = New System.Drawing.Size(207, 20)
        Me.StraßeTextBox.TabIndex = 3
        '
        'AdresstypTextBox
        '
        Me.AdresstypTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdresstypTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Adresstyp", True))
        Me.AdresstypTextBox.Location = New System.Drawing.Point(74, 34)
        Me.AdresstypTextBox.Name = "AdresstypTextBox"
        Me.AdresstypTextBox.Size = New System.Drawing.Size(207, 20)
        Me.AdresstypTextBox.TabIndex = 1
        '
        'AdressenDataGridView
        '
        Me.AdressenDataGridView.AllowUserToAddRows = False
        Me.AdressenDataGridView.AllowUserToDeleteRows = False
        Me.AdressenDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdressenDataGridView.AutoGenerateColumns = False
        Me.AdressenDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.AdressenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdressenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDAdresse, Me.IDKonto, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn10})
        Me.AdressenDataGridView.DataSource = Me.AdressenBindingSource
        Me.AdressenDataGridView.Location = New System.Drawing.Point(6, 316)
        Me.AdressenDataGridView.Name = "AdressenDataGridView"
        Me.AdressenDataGridView.RowHeadersVisible = False
        Me.AdressenDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AdressenDataGridView.Size = New System.Drawing.Size(274, 169)
        Me.AdressenDataGridView.TabIndex = 6
        '
        'IDAdresse
        '
        Me.IDAdresse.DataPropertyName = "IDAdresse"
        Me.IDAdresse.HeaderText = "IDAdresse"
        Me.IDAdresse.Name = "IDAdresse"
        Me.IDAdresse.Visible = False
        '
        'IDKonto
        '
        Me.IDKonto.DataPropertyName = "IDKonto"
        Me.IDKonto.HeaderText = "Konto"
        Me.IDKonto.Name = "IDKonto"
        Me.IDKonto.Width = 47
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Straße"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Straße"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 110
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Ort"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Ort"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 115
        '
        'EmailAddresseLinkLabel
        '
        Me.EmailAddresseLinkLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "EmailAddresse", True))
        Me.EmailAddresseLinkLabel.Location = New System.Drawing.Point(100, 105)
        Me.EmailAddresseLinkLabel.Name = "EmailAddresseLinkLabel"
        Me.EmailAddresseLinkLabel.Size = New System.Drawing.Size(176, 15)
        Me.EmailAddresseLinkLabel.TabIndex = 26
        Me.EmailAddresseLinkLabel.TabStop = True
        Me.EmailAddresseLinkLabel.Text = "Email"
        Me.EmailAddresseLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'KontakteBindingSource
        '
        Me.KontakteBindingSource.DataMember = "Kontakte"
        Me.KontakteBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'btnAdresseZuKontakt
        '
        Me.btnAdresseZuKontakt.Location = New System.Drawing.Point(102, 267)
        Me.btnAdresseZuKontakt.Name = "btnAdresseZuKontakt"
        Me.btnAdresseZuKontakt.Size = New System.Drawing.Size(92, 23)
        Me.btnAdresseZuKontakt.TabIndex = 25
        Me.btnAdresseZuKontakt.Text = "Adresse zuord."
        Me.btnAdresseZuKontakt.UseVisualStyleBackColor = True
        '
        'IDAdresseTextBox
        '
        Me.IDAdresseTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IDAdresseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "IDAdresse", True))
        Me.IDAdresseTextBox.Enabled = False
        Me.IDAdresseTextBox.Location = New System.Drawing.Point(200, 267)
        Me.IDAdresseTextBox.Name = "IDAdresseTextBox"
        Me.IDAdresseTextBox.Size = New System.Drawing.Size(80, 20)
        Me.IDAdresseTextBox.TabIndex = 22
        '
        'FaxnummerTextBox
        '
        Me.FaxnummerTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FaxnummerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Faxnummer", True))
        Me.FaxnummerTextBox.Location = New System.Drawing.Point(104, 241)
        Me.FaxnummerTextBox.Name = "FaxnummerTextBox"
        Me.FaxnummerTextBox.Size = New System.Drawing.Size(176, 20)
        Me.FaxnummerTextBox.TabIndex = 20
        '
        'MobiltelefonTextBox
        '
        Me.MobiltelefonTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MobiltelefonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Mobiltelefon", True))
        Me.MobiltelefonTextBox.Location = New System.Drawing.Point(104, 215)
        Me.MobiltelefonTextBox.Name = "MobiltelefonTextBox"
        Me.MobiltelefonTextBox.Size = New System.Drawing.Size(176, 20)
        Me.MobiltelefonTextBox.TabIndex = 18
        '
        'TelefonPrivatTextBox
        '
        Me.TelefonPrivatTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TelefonPrivatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "TelefonPrivat", True))
        Me.TelefonPrivatTextBox.Location = New System.Drawing.Point(104, 189)
        Me.TelefonPrivatTextBox.Name = "TelefonPrivatTextBox"
        Me.TelefonPrivatTextBox.Size = New System.Drawing.Size(176, 20)
        Me.TelefonPrivatTextBox.TabIndex = 16
        '
        'TelefonGeschaeftlichTextBox
        '
        Me.TelefonGeschaeftlichTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TelefonGeschaeftlichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "TelefonGeschaeftlich", True))
        Me.TelefonGeschaeftlichTextBox.Location = New System.Drawing.Point(104, 163)
        Me.TelefonGeschaeftlichTextBox.Name = "TelefonGeschaeftlichTextBox"
        Me.TelefonGeschaeftlichTextBox.Size = New System.Drawing.Size(176, 20)
        Me.TelefonGeschaeftlichTextBox.TabIndex = 14
        '
        'PositionTextBox
        '
        Me.PositionTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Jobtitle", True))
        Me.PositionTextBox.Location = New System.Drawing.Point(104, 137)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(176, 20)
        Me.PositionTextBox.TabIndex = 12
        '
        'EmailAddresseTextBox
        '
        Me.EmailAddresseTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmailAddresseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "EmailAddresse", True))
        Me.EmailAddresseTextBox.Location = New System.Drawing.Point(104, 111)
        Me.EmailAddresseTextBox.Name = "EmailAddresseTextBox"
        Me.EmailAddresseTextBox.Size = New System.Drawing.Size(176, 20)
        Me.EmailAddresseTextBox.TabIndex = 10
        '
        'VornameTextBox
        '
        Me.VornameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VornameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Vorname", True))
        Me.VornameTextBox.Location = New System.Drawing.Point(104, 87)
        Me.VornameTextBox.Name = "VornameTextBox"
        Me.VornameTextBox.Size = New System.Drawing.Size(176, 20)
        Me.VornameTextBox.TabIndex = 8
        '
        'NachnameTextBox
        '
        Me.NachnameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NachnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Nachname", True))
        Me.NachnameTextBox.Location = New System.Drawing.Point(104, 62)
        Me.NachnameTextBox.Name = "NachnameTextBox"
        Me.NachnameTextBox.Size = New System.Drawing.Size(176, 20)
        Me.NachnameTextBox.TabIndex = 6
        '
        'AnredeComboBox
        '
        Me.AnredeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AnredeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Anrede", True))
        Me.AnredeComboBox.FormattingEnabled = True
        Me.AnredeComboBox.Location = New System.Drawing.Point(104, 37)
        Me.AnredeComboBox.Name = "AnredeComboBox"
        Me.AnredeComboBox.Size = New System.Drawing.Size(176, 21)
        Me.AnredeComboBox.TabIndex = 4
        '
        'LBL_IDKontakt
        '
        Me.LBL_IDKontakt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_IDKontakt.BackColor = System.Drawing.Color.Transparent
        Me.LBL_IDKontakt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "IDKontakt", True))
        Me.LBL_IDKontakt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_IDKontakt.ForeColor = System.Drawing.Color.DarkGray
        Me.LBL_IDKontakt.Location = New System.Drawing.Point(186, 1)
        Me.LBL_IDKontakt.Name = "LBL_IDKontakt"
        Me.LBL_IDKontakt.Size = New System.Drawing.Size(100, 23)
        Me.LBL_IDKontakt.TabIndex = 3
        Me.LBL_IDKontakt.Text = "IDKontakt"
        Me.LBL_IDKontakt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'KontakteDataGridView
        '
        Me.KontakteDataGridView.AllowUserToAddRows = False
        Me.KontakteDataGridView.AllowUserToDeleteRows = False
        Me.KontakteDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KontakteDataGridView.AutoGenerateColumns = False
        Me.KontakteDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.KontakteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KontakteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDKontakt, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn9})
        Me.KontakteDataGridView.DataSource = Me.KontakteBindingSource
        Me.KontakteDataGridView.Location = New System.Drawing.Point(6, 316)
        Me.KontakteDataGridView.Name = "KontakteDataGridView"
        Me.KontakteDataGridView.RowHeadersVisible = False
        Me.KontakteDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.KontakteDataGridView.Size = New System.Drawing.Size(274, 169)
        Me.KontakteDataGridView.TabIndex = 1
        '
        'IDKontakt
        '
        Me.IDKontakt.DataPropertyName = "IDKontakt"
        Me.IDKontakt.HeaderText = "IDKontakt"
        Me.IDKontakt.Name = "IDKontakt"
        Me.IDKontakt.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Vorname"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Vorname"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 140
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Nachname"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Nachname"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 140
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.lblKontaktHeader)
        Me.Panel3.Controls.Add(Me.LBL_IDKontakt)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(286, 27)
        Me.Panel3.TabIndex = 1
        '
        'lblKontaktHeader
        '
        Me.lblKontaktHeader.AutoSize = True
        Me.lblKontaktHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKontaktHeader.Location = New System.Drawing.Point(2, 2)
        Me.lblKontaktHeader.Name = "lblKontaktHeader"
        Me.lblKontaktHeader.Size = New System.Drawing.Size(71, 24)
        Me.lblKontaktHeader.TabIndex = 0
        Me.lblKontaktHeader.Text = "Kontakt"
        '
        'TC_Beleg
        '
        Me.TC_Beleg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TC_Beleg.Controls.Add(Me.TabPage1)
        Me.TC_Beleg.Controls.Add(Me.TabPage2)
        Me.TC_Beleg.Controls.Add(Me.TabPage3)
        Me.TC_Beleg.Location = New System.Drawing.Point(773, 78)
        Me.TC_Beleg.Name = "TC_Beleg"
        Me.TLP_1.SetRowSpan(Me.TC_Beleg, 2)
        Me.TC_Beleg.SelectedIndex = 0
        Me.TC_Beleg.Size = New System.Drawing.Size(494, 514)
        Me.TC_Beleg.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.CB_BBKuerzel)
        Me.TabPage1.Controls.Add(Me.TB_BBWeitereBesucher)
        Me.TabPage1.Controls.Add(Me.TB_BBWeitereKontakte)
        Me.TabPage1.Controls.Add(Me.LBL_BBRegion)
        Me.TabPage1.Controls.Add(Me.LBL_BBIDKonto)
        Me.TabPage1.Controls.Add(Me.LBL_BBBesuchterKontakt)
        Me.TabPage1.Controls.Add(Me.LBL_BBLand)
        Me.TabPage1.Controls.Add(Me.LBL_BBOrt)
        Me.TabPage1.Controls.Add(PLZLabel2)
        Me.TabPage1.Controls.Add(Me.LBL_BBPLZ)
        Me.TabPage1.Controls.Add(Me.LBL_BBStrasse)
        Me.TabPage1.Controls.Add(ThemaLabel)
        Me.TabPage1.Controls.Add(Me.TB_BBThema)
        Me.TabPage1.Controls.Add(WeitereBesucherLabel)
        Me.TabPage1.Controls.Add(VonWemBesuchtLabel)
        Me.TabPage1.Controls.Add(DatumLabel)
        Me.TabPage1.Controls.Add(Me.DTP_BBDatum)
        Me.TabPage1.Controls.Add(WeitereKontakteLabel)
        Me.TabPage1.Controls.Add(DirekterKontaktLabel)
        Me.TabPage1.Controls.Add(IDLKontoLabel2)
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(486, 488)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Besuchsbericht"
        '
        'CB_BBKuerzel
        '
        Me.CB_BBKuerzel.DataSource = Me.SachbearbeiterBindingSource
        Me.CB_BBKuerzel.DisplayMember = "Kuerzel"
        Me.CB_BBKuerzel.FormattingEnabled = True
        Me.CB_BBKuerzel.Location = New System.Drawing.Point(5, 194)
        Me.CB_BBKuerzel.Name = "CB_BBKuerzel"
        Me.CB_BBKuerzel.Size = New System.Drawing.Size(181, 21)
        Me.CB_BBKuerzel.TabIndex = 33
        '
        'SachbearbeiterBindingSource
        '
        Me.SachbearbeiterBindingSource.DataMember = "Sachbearbeiter"
        Me.SachbearbeiterBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'TB_BBWeitereBesucher
        '
        Me.TB_BBWeitereBesucher.Location = New System.Drawing.Point(6, 234)
        Me.TB_BBWeitereBesucher.Name = "TB_BBWeitereBesucher"
        Me.TB_BBWeitereBesucher.Size = New System.Drawing.Size(180, 20)
        Me.TB_BBWeitereBesucher.TabIndex = 32
        '
        'TB_BBWeitereKontakte
        '
        Me.TB_BBWeitereKontakte.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_BBWeitereKontakte.Location = New System.Drawing.Point(6, 114)
        Me.TB_BBWeitereKontakte.Name = "TB_BBWeitereKontakte"
        Me.TB_BBWeitereKontakte.Size = New System.Drawing.Size(477, 20)
        Me.TB_BBWeitereKontakte.TabIndex = 31
        '
        'LBL_BBRegion
        '
        Me.LBL_BBRegion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Bundesland", True))
        Me.LBL_BBRegion.Location = New System.Drawing.Point(226, 207)
        Me.LBL_BBRegion.Name = "LBL_BBRegion"
        Me.LBL_BBRegion.Size = New System.Drawing.Size(160, 14)
        Me.LBL_BBRegion.TabIndex = 30
        Me.LBL_BBRegion.Text = "Bundesland"
        '
        'LBL_BBIDKonto
        '
        Me.LBL_BBIDKonto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "IDKonto", True))
        Me.LBL_BBIDKonto.ForeColor = System.Drawing.Color.Gray
        Me.LBL_BBIDKonto.Location = New System.Drawing.Point(61, 33)
        Me.LBL_BBIDKonto.Name = "LBL_BBIDKonto"
        Me.LBL_BBIDKonto.Size = New System.Drawing.Size(49, 13)
        Me.LBL_BBIDKonto.TabIndex = 29
        Me.LBL_BBIDKonto.Text = "IDKonto"
        Me.LBL_BBIDKonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBL_BBBesuchterKontakt
        '
        Me.LBL_BBBesuchterKontakt.BackColor = System.Drawing.Color.Transparent
        Me.LBL_BBBesuchterKontakt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_BBBesuchterKontakt.Location = New System.Drawing.Point(6, 71)
        Me.LBL_BBBesuchterKontakt.Name = "LBL_BBBesuchterKontakt"
        Me.LBL_BBBesuchterKontakt.Size = New System.Drawing.Size(381, 23)
        Me.LBL_BBBesuchterKontakt.TabIndex = 28
        Me.LBL_BBBesuchterKontakt.Text = "Thomas Müller"
        Me.LBL_BBBesuchterKontakt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBL_BBLand
        '
        Me.LBL_BBLand.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Land", True))
        Me.LBL_BBLand.Location = New System.Drawing.Point(226, 222)
        Me.LBL_BBLand.Name = "LBL_BBLand"
        Me.LBL_BBLand.Size = New System.Drawing.Size(160, 12)
        Me.LBL_BBLand.TabIndex = 24
        Me.LBL_BBLand.Text = "Deutschland"
        '
        'LBL_BBOrt
        '
        Me.LBL_BBOrt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Ort", True))
        Me.LBL_BBOrt.Location = New System.Drawing.Point(271, 192)
        Me.LBL_BBOrt.Name = "LBL_BBOrt"
        Me.LBL_BBOrt.Size = New System.Drawing.Size(115, 14)
        Me.LBL_BBOrt.TabIndex = 23
        Me.LBL_BBOrt.Text = "Hannover"
        '
        'LBL_BBPLZ
        '
        Me.LBL_BBPLZ.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "PLZ", True))
        Me.LBL_BBPLZ.Location = New System.Drawing.Point(226, 192)
        Me.LBL_BBPLZ.Name = "LBL_BBPLZ"
        Me.LBL_BBPLZ.Size = New System.Drawing.Size(48, 14)
        Me.LBL_BBPLZ.TabIndex = 21
        Me.LBL_BBPLZ.Text = "30419"
        '
        'LBL_BBStrasse
        '
        Me.LBL_BBStrasse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Straße", True))
        Me.LBL_BBStrasse.Location = New System.Drawing.Point(226, 177)
        Me.LBL_BBStrasse.Name = "LBL_BBStrasse"
        Me.LBL_BBStrasse.Size = New System.Drawing.Size(160, 14)
        Me.LBL_BBStrasse.TabIndex = 20
        Me.LBL_BBStrasse.Text = "Strasse 24"
        '
        'TB_BBThema
        '
        Me.TB_BBThema.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_BBThema.Location = New System.Drawing.Point(6, 272)
        Me.TB_BBThema.Name = "TB_BBThema"
        Me.TB_BBThema.Size = New System.Drawing.Size(477, 20)
        Me.TB_BBThema.TabIndex = 18
        '
        'DTP_BBDatum
        '
        Me.DTP_BBDatum.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_BBDatum.Location = New System.Drawing.Point(5, 154)
        Me.DTP_BBDatum.Name = "DTP_BBDatum"
        Me.DTP_BBDatum.Size = New System.Drawing.Size(181, 20)
        Me.DTP_BBDatum.TabIndex = 12
        Me.DTP_BBDatum.Value = New Date(2021, 10, 11, 0, 0, 0, 0)
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(494, 26)
        Me.Panel5.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(2, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Besuchsbericht"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(IDKontoLabel1)
        Me.TabPage2.Controls.Add(Me.LBL_DIVIDKonto)
        Me.TabPage2.Controls.Add(EmailLabel)
        Me.TabPage2.Controls.Add(Me.LBL_DIVEmail)
        Me.TabPage2.Controls.Add(DurchwahlLabel)
        Me.TabPage2.Controls.Add(Me.LBL_DIVDurchwahl)
        Me.TabPage2.Controls.Add(JobtitleLabel)
        Me.TabPage2.Controls.Add(Me.LBL_DIVJobtitle)
        Me.TabPage2.Controls.Add(SachbearbeiterLabel)
        Me.TabPage2.Controls.Add(Me.CB_DIVSachbearbeiter)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.TB_DIVThema)
        Me.TabPage2.Controls.Add(Me.DTP_Diverse)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GB_Anrede)
        Me.TabPage2.Controls.Add(Me.TB_DIVFaxnummer)
        Me.TabPage2.Controls.Add(Me.LBL_Sprache)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(FaxnummerLabel3)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.CB_Vorlagen)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(486, 488)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Brief / Fax / TN / diverse"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LBL_DIVIDKonto
        '
        Me.LBL_DIVIDKonto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "IDKonto", True))
        Me.LBL_DIVIDKonto.Location = New System.Drawing.Point(122, 117)
        Me.LBL_DIVIDKonto.Name = "LBL_DIVIDKonto"
        Me.LBL_DIVIDKonto.Size = New System.Drawing.Size(100, 15)
        Me.LBL_DIVIDKonto.TabIndex = 22
        Me.LBL_DIVIDKonto.Text = "IDKonto"
        '
        'LBL_DIVEmail
        '
        Me.LBL_DIVEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "Email", True))
        Me.LBL_DIVEmail.Location = New System.Drawing.Point(122, 385)
        Me.LBL_DIVEmail.Name = "LBL_DIVEmail"
        Me.LBL_DIVEmail.Size = New System.Drawing.Size(255, 23)
        Me.LBL_DIVEmail.TabIndex = 20
        Me.LBL_DIVEmail.Text = "Email"
        '
        'LBL_DIVDurchwahl
        '
        Me.LBL_DIVDurchwahl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "Durchwahl", True))
        Me.LBL_DIVDurchwahl.Location = New System.Drawing.Point(122, 362)
        Me.LBL_DIVDurchwahl.Name = "LBL_DIVDurchwahl"
        Me.LBL_DIVDurchwahl.Size = New System.Drawing.Size(59, 23)
        Me.LBL_DIVDurchwahl.TabIndex = 18
        Me.LBL_DIVDurchwahl.Text = "-DW"
        '
        'LBL_DIVJobtitle
        '
        Me.LBL_DIVJobtitle.Location = New System.Drawing.Point(122, 336)
        Me.LBL_DIVJobtitle.Name = "LBL_DIVJobtitle"
        Me.LBL_DIVJobtitle.Size = New System.Drawing.Size(255, 23)
        Me.LBL_DIVJobtitle.TabIndex = 16
        Me.LBL_DIVJobtitle.Text = "Position"
        '
        'CB_DIVSachbearbeiter
        '
        Me.CB_DIVSachbearbeiter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_DIVSachbearbeiter.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "Sachbearbeiter", True))
        Me.CB_DIVSachbearbeiter.DataSource = Me.SachbearbeiterBindingSource
        Me.CB_DIVSachbearbeiter.DisplayMember = "Sachbearbeiter"
        Me.CB_DIVSachbearbeiter.FormattingEnabled = True
        Me.CB_DIVSachbearbeiter.Location = New System.Drawing.Point(125, 309)
        Me.CB_DIVSachbearbeiter.Name = "CB_DIVSachbearbeiter"
        Me.CB_DIVSachbearbeiter.Size = New System.Drawing.Size(291, 21)
        Me.CB_DIVSachbearbeiter.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(70, 263)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Datum:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Betreff / Thema *:"
        '
        'TB_DIVThema
        '
        Me.TB_DIVThema.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_DIVThema.Location = New System.Drawing.Point(125, 283)
        Me.TB_DIVThema.Name = "TB_DIVThema"
        Me.TB_DIVThema.Size = New System.Drawing.Size(291, 20)
        Me.TB_DIVThema.TabIndex = 11
        '
        'DTP_Diverse
        '
        Me.DTP_Diverse.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Diverse.Location = New System.Drawing.Point(125, 257)
        Me.DTP_Diverse.Name = "DTP_Diverse"
        Me.DTP_Diverse.Size = New System.Drawing.Size(233, 20)
        Me.DTP_Diverse.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBL_DIVAdresse)
        Me.GroupBox2.Location = New System.Drawing.Point(125, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 115)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Adresse"
        '
        'LBL_DIVAdresse
        '
        Me.LBL_DIVAdresse.AutoSize = True
        Me.LBL_DIVAdresse.Location = New System.Drawing.Point(11, 20)
        Me.LBL_DIVAdresse.Name = "LBL_DIVAdresse"
        Me.LBL_DIVAdresse.Size = New System.Drawing.Size(45, 13)
        Me.LBL_DIVAdresse.TabIndex = 0
        Me.LBL_DIVAdresse.Text = "Adresse"
        '
        'GB_Anrede
        '
        Me.GB_Anrede.Controls.Add(Me.RB_OhneAnrede)
        Me.GB_Anrede.Controls.Add(Me.RB_MitAnrede)
        Me.GB_Anrede.Location = New System.Drawing.Point(19, 136)
        Me.GB_Anrede.Name = "GB_Anrede"
        Me.GB_Anrede.Size = New System.Drawing.Size(100, 68)
        Me.GB_Anrede.TabIndex = 8
        Me.GB_Anrede.TabStop = False
        Me.GB_Anrede.Text = "Anrede"
        '
        'RB_OhneAnrede
        '
        Me.RB_OhneAnrede.AutoSize = True
        Me.RB_OhneAnrede.Location = New System.Drawing.Point(6, 41)
        Me.RB_OhneAnrede.Name = "RB_OhneAnrede"
        Me.RB_OhneAnrede.Size = New System.Drawing.Size(86, 17)
        Me.RB_OhneAnrede.TabIndex = 1
        Me.RB_OhneAnrede.Text = "ohne Anrede"
        Me.RB_OhneAnrede.UseVisualStyleBackColor = True
        '
        'RB_MitAnrede
        '
        Me.RB_MitAnrede.AutoSize = True
        Me.RB_MitAnrede.Checked = True
        Me.RB_MitAnrede.Location = New System.Drawing.Point(6, 18)
        Me.RB_MitAnrede.Name = "RB_MitAnrede"
        Me.RB_MitAnrede.Size = New System.Drawing.Size(75, 17)
        Me.RB_MitAnrede.TabIndex = 0
        Me.RB_MitAnrede.TabStop = True
        Me.RB_MitAnrede.Text = "mit Anrede"
        Me.RB_MitAnrede.UseVisualStyleBackColor = True
        '
        'TB_DIVFaxnummer
        '
        Me.TB_DIVFaxnummer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_DIVFaxnummer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Faxnummer", True))
        Me.TB_DIVFaxnummer.Location = New System.Drawing.Point(123, 89)
        Me.TB_DIVFaxnummer.Name = "TB_DIVFaxnummer"
        Me.TB_DIVFaxnummer.Size = New System.Drawing.Size(293, 20)
        Me.TB_DIVFaxnummer.TabIndex = 7
        '
        'LBL_Sprache
        '
        Me.LBL_Sprache.AutoSize = True
        Me.LBL_Sprache.Location = New System.Drawing.Point(122, 63)
        Me.LBL_Sprache.Name = "LBL_Sprache"
        Me.LBL_Sprache.Size = New System.Drawing.Size(45, 13)
        Me.LBL_Sprache.TabIndex = 6
        Me.LBL_Sprache.Text = "deutsch"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(64, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Sprache:"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(483, 27)
        Me.Panel2.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Brief / FAX / TN / div."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vorlage auswählen:"
        '
        'CB_Vorlagen
        '
        Me.CB_Vorlagen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_Vorlagen.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Vorlagen.FormattingEnabled = True
        Me.CB_Vorlagen.Location = New System.Drawing.Point(123, 34)
        Me.CB_Vorlagen.Name = "CB_Vorlagen"
        Me.CB_Vorlagen.Size = New System.Drawing.Size(293, 23)
        Me.CB_Vorlagen.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(486, 488)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Historie"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDBelegDataGridViewTextBoxColumn, Me.DatumDataGridViewTextBoxColumn, Me.KuerzelDataGridViewTextBoxColumn, Me.KontaktDataGridViewTextBoxColumn, Me.ThemaDataGridViewTextBoxColumn, Me.OrtDataGridViewTextBoxColumn, Me.BelegnameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BelegeMitAdresseBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(480, 482)
        Me.DataGridView1.TabIndex = 0
        '
        'IDBelegDataGridViewTextBoxColumn
        '
        Me.IDBelegDataGridViewTextBoxColumn.DataPropertyName = "IDBeleg"
        Me.IDBelegDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDBelegDataGridViewTextBoxColumn.Name = "IDBelegDataGridViewTextBoxColumn"
        Me.IDBelegDataGridViewTextBoxColumn.Width = 30
        '
        'DatumDataGridViewTextBoxColumn
        '
        Me.DatumDataGridViewTextBoxColumn.DataPropertyName = "Datum"
        Me.DatumDataGridViewTextBoxColumn.HeaderText = "Datum"
        Me.DatumDataGridViewTextBoxColumn.Name = "DatumDataGridViewTextBoxColumn"
        Me.DatumDataGridViewTextBoxColumn.Width = 70
        '
        'KuerzelDataGridViewTextBoxColumn
        '
        Me.KuerzelDataGridViewTextBoxColumn.DataPropertyName = "Kuerzel"
        Me.KuerzelDataGridViewTextBoxColumn.HeaderText = "Bearbeiter"
        Me.KuerzelDataGridViewTextBoxColumn.Name = "KuerzelDataGridViewTextBoxColumn"
        '
        'KontaktDataGridViewTextBoxColumn
        '
        Me.KontaktDataGridViewTextBoxColumn.DataPropertyName = "Kontakt"
        Me.KontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt"
        Me.KontaktDataGridViewTextBoxColumn.Name = "KontaktDataGridViewTextBoxColumn"
        '
        'ThemaDataGridViewTextBoxColumn
        '
        Me.ThemaDataGridViewTextBoxColumn.DataPropertyName = "Thema"
        Me.ThemaDataGridViewTextBoxColumn.HeaderText = "Thema"
        Me.ThemaDataGridViewTextBoxColumn.Name = "ThemaDataGridViewTextBoxColumn"
        '
        'OrtDataGridViewTextBoxColumn
        '
        Me.OrtDataGridViewTextBoxColumn.DataPropertyName = "Ort"
        Me.OrtDataGridViewTextBoxColumn.HeaderText = "Ort"
        Me.OrtDataGridViewTextBoxColumn.Name = "OrtDataGridViewTextBoxColumn"
        '
        'BelegnameDataGridViewTextBoxColumn
        '
        Me.BelegnameDataGridViewTextBoxColumn.DataPropertyName = "Belegname"
        Me.BelegnameDataGridViewTextBoxColumn.HeaderText = "Belegname"
        Me.BelegnameDataGridViewTextBoxColumn.Name = "BelegnameDataGridViewTextBoxColumn"
        '
        'BelegeMitAdresseBindingSource
        '
        Me.BelegeMitAdresseBindingSource.DataMember = "BelegeMitAdresse"
        Me.BelegeMitAdresseBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gray
        Me.TLP_1.SetColumnSpan(Me.Panel6, 3)
        Me.Panel6.Controls.Add(Me.LBL_FirmenName)
        Me.Panel6.Controls.Add(Me.btnAbbrechen)
        Me.Panel6.Controls.Add(Me.BTN_Speichern)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 598)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(764, 44)
        Me.Panel6.TabIndex = 20
        '
        'LBL_FirmenName
        '
        Me.LBL_FirmenName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FirmenNameBindingSource, "FirmenName", True))
        Me.LBL_FirmenName.ForeColor = System.Drawing.Color.White
        Me.LBL_FirmenName.Location = New System.Drawing.Point(9, 6)
        Me.LBL_FirmenName.Name = "LBL_FirmenName"
        Me.LBL_FirmenName.Size = New System.Drawing.Size(447, 16)
        Me.LBL_FirmenName.TabIndex = 17
        Me.LBL_FirmenName.Text = "FirmenName"
        Me.LBL_FirmenName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Image = Global.Adress_DB.My.Resources.Resources.Cancel_16x
        Me.btnAbbrechen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAbbrechen.Location = New System.Drawing.Point(480, 10)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(80, 23)
        Me.btnAbbrechen.TabIndex = 16
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'BTN_DocErzeugen
        '
        Me.BTN_DocErzeugen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_DocErzeugen.Image = Global.Adress_DB.My.Resources.Resources.Document_16x
        Me.BTN_DocErzeugen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_DocErzeugen.Location = New System.Drawing.Point(350, 10)
        Me.BTN_DocErzeugen.Name = "BTN_DocErzeugen"
        Me.BTN_DocErzeugen.Size = New System.Drawing.Size(131, 30)
        Me.BTN_DocErzeugen.TabIndex = 18
        Me.BTN_DocErzeugen.Text = "Dokument erzeugen"
        Me.BTN_DocErzeugen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_DocErzeugen.UseVisualStyleBackColor = True
        '
        'TC_Adresse
        '
        Me.TC_Adresse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TC_Adresse.Controls.Add(Me.TabAdresseInfo)
        Me.TC_Adresse.Controls.Add(Me.TabAdresseBearbeiten)
        Me.TC_Adresse.Location = New System.Drawing.Point(173, 78)
        Me.TC_Adresse.Name = "TC_Adresse"
        Me.TLP_1.SetRowSpan(Me.TC_Adresse, 2)
        Me.TC_Adresse.SelectedIndex = 0
        Me.TC_Adresse.Size = New System.Drawing.Size(294, 514)
        Me.TC_Adresse.TabIndex = 21
        '
        'TabAdresseInfo
        '
        Me.TabAdresseInfo.AutoScroll = True
        Me.TabAdresseInfo.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TabAdresseInfo.Controls.Add(Me.LBL_CC)
        Me.TabAdresseInfo.Controls.Add(Me.LabelLandAdressen)
        Me.TabAdresseInfo.Controls.Add(Me.PNL_Geodaten)
        Me.TabAdresseInfo.Controls.Add(Me.LBL_AdressHinweis)
        Me.TabAdresseInfo.Controls.Add(IDKontoLabel)
        Me.TabAdresseInfo.Controls.Add(Me.LBL_IDKontoZuAdresse)
        Me.TabAdresseInfo.Controls.Add(WebseiteLabel1)
        Me.TabAdresseInfo.Controls.Add(Me.AdressenDataGridView)
        Me.TabAdresseInfo.Controls.Add(Me.WebseiteLinkLabel)
        Me.TabAdresseInfo.Controls.Add(UStIdNrLabel1)
        Me.TabAdresseInfo.Controls.Add(Me.BTN_MapsSuche)
        Me.TabAdresseInfo.Controls.Add(Me.UStIdNrLabel2)
        Me.TabAdresseInfo.Controls.Add(Me.LBL_Land)
        Me.TabAdresseInfo.Controls.Add(BundeslandLabel1)
        Me.TabAdresseInfo.Controls.Add(Me.BundeslandLabel2)
        Me.TabAdresseInfo.Controls.Add(OrtLabel1)
        Me.TabAdresseInfo.Controls.Add(Me.LBL_Ort)
        Me.TabAdresseInfo.Controls.Add(PLZLabel1)
        Me.TabAdresseInfo.Controls.Add(Me.LBL_PLZ)
        Me.TabAdresseInfo.Controls.Add(PostfachLabel1)
        Me.TabAdresseInfo.Controls.Add(Me.PostfachLabel2)
        Me.TabAdresseInfo.Controls.Add(StraßeLabel1)
        Me.TabAdresseInfo.Controls.Add(Me.LBL_Strasse)
        Me.TabAdresseInfo.Controls.Add(AdresstypLabel1)
        Me.TabAdresseInfo.Controls.Add(Me.AdresstypLabel2)
        Me.TabAdresseInfo.Controls.Add(Me.Panel7)
        Me.TabAdresseInfo.Location = New System.Drawing.Point(4, 22)
        Me.TabAdresseInfo.Name = "TabAdresseInfo"
        Me.TabAdresseInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAdresseInfo.Size = New System.Drawing.Size(286, 488)
        Me.TabAdresseInfo.TabIndex = 0
        Me.TabAdresseInfo.Text = "Info"
        '
        'LBL_CC
        '
        Me.LBL_CC.AutoSize = True
        Me.LBL_CC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaatenBindingSource, "ISO2", True))
        Me.LBL_CC.Location = New System.Drawing.Point(251, 62)
        Me.LBL_CC.Name = "LBL_CC"
        Me.LBL_CC.Size = New System.Drawing.Size(22, 13)
        Me.LBL_CC.TabIndex = 29
        Me.LBL_CC.Text = "DE"
        Me.LBL_CC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StaatenBindingSource
        '
        Me.StaatenBindingSource.DataMember = "Staaten"
        Me.StaatenBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'LabelLandAdressen
        '
        Me.LabelLandAdressen.AutoSize = True
        Me.LabelLandAdressen.Location = New System.Drawing.Point(43, 62)
        Me.LabelLandAdressen.Name = "LabelLandAdressen"
        Me.LabelLandAdressen.Size = New System.Drawing.Size(34, 13)
        Me.LabelLandAdressen.TabIndex = 28
        Me.LabelLandAdressen.Text = "Land:"
        '
        'PNL_Geodaten
        '
        Me.PNL_Geodaten.Controls.Add(Me.LBL_Lat)
        Me.PNL_Geodaten.Controls.Add(Me.LBL_Long)
        Me.PNL_Geodaten.Controls.Add(Me.LBLLat)
        Me.PNL_Geodaten.Controls.Add(Me.LBLLong)
        Me.PNL_Geodaten.Location = New System.Drawing.Point(6, 278)
        Me.PNL_Geodaten.Name = "PNL_Geodaten"
        Me.PNL_Geodaten.Size = New System.Drawing.Size(147, 38)
        Me.PNL_Geodaten.TabIndex = 27
        '
        'LBL_Lat
        '
        Me.LBL_Lat.AutoSize = True
        Me.LBL_Lat.ForeColor = System.Drawing.Color.Gray
        Me.LBL_Lat.Location = New System.Drawing.Point(56, 3)
        Me.LBL_Lat.Name = "LBL_Lat"
        Me.LBL_Lat.Size = New System.Drawing.Size(47, 13)
        Me.LBL_Lat.TabIndex = 25
        Me.LBL_Lat.Text = "LBL_Lat"
        '
        'LBL_Long
        '
        Me.LBL_Long.AutoSize = True
        Me.LBL_Long.ForeColor = System.Drawing.Color.Gray
        Me.LBL_Long.Location = New System.Drawing.Point(56, 16)
        Me.LBL_Long.Name = "LBL_Long"
        Me.LBL_Long.Size = New System.Drawing.Size(56, 13)
        Me.LBL_Long.TabIndex = 26
        Me.LBL_Long.Text = "LBL_Long"
        '
        'LBLLat
        '
        Me.LBLLat.AutoSize = True
        Me.LBLLat.ForeColor = System.Drawing.Color.Gray
        Me.LBLLat.Location = New System.Drawing.Point(6, 3)
        Me.LBLLat.Name = "LBLLat"
        Me.LBLLat.Size = New System.Drawing.Size(48, 13)
        Me.LBLLat.TabIndex = 23
        Me.LBLLat.Text = "Latitude:"
        '
        'LBLLong
        '
        Me.LBLLong.AutoSize = True
        Me.LBLLong.ForeColor = System.Drawing.Color.Gray
        Me.LBLLong.Location = New System.Drawing.Point(3, 16)
        Me.LBLLong.Name = "LBLLong"
        Me.LBLLong.Size = New System.Drawing.Size(51, 13)
        Me.LBLLong.TabIndex = 24
        Me.LBLLong.Text = "Logitude:"
        '
        'LBL_AdressHinweis
        '
        Me.LBL_AdressHinweis.AutoSize = True
        Me.LBL_AdressHinweis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_AdressHinweis.ForeColor = System.Drawing.Color.Red
        Me.LBL_AdressHinweis.Location = New System.Drawing.Point(73, 237)
        Me.LBL_AdressHinweis.Name = "LBL_AdressHinweis"
        Me.LBL_AdressHinweis.Size = New System.Drawing.Size(123, 26)
        Me.LBL_AdressHinweis.TabIndex = 22
        Me.LBL_AdressHinweis.Text = "Adresse prüfen!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PLZ oder Ort unklar."
        Me.LBL_AdressHinweis.Visible = False
        '
        'LBL_IDKontoZuAdresse
        '
        Me.LBL_IDKontoZuAdresse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "IDKonto", True))
        Me.LBL_IDKontoZuAdresse.Location = New System.Drawing.Point(83, 215)
        Me.LBL_IDKontoZuAdresse.Name = "LBL_IDKontoZuAdresse"
        Me.LBL_IDKontoZuAdresse.Size = New System.Drawing.Size(190, 15)
        Me.LBL_IDKontoZuAdresse.TabIndex = 21
        Me.LBL_IDKontoZuAdresse.Text = "800000"
        '
        'WebseiteLinkLabel
        '
        Me.WebseiteLinkLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Webseite", True))
        Me.WebseiteLinkLabel.Location = New System.Drawing.Point(83, 191)
        Me.WebseiteLinkLabel.Name = "WebseiteLinkLabel"
        Me.WebseiteLinkLabel.Size = New System.Drawing.Size(190, 15)
        Me.WebseiteLinkLabel.TabIndex = 18
        Me.WebseiteLinkLabel.TabStop = True
        Me.WebseiteLinkLabel.Text = "www.weserland.de"
        '
        'UStIdNrLabel2
        '
        Me.UStIdNrLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "UStIdNr", True))
        Me.UStIdNrLabel2.Location = New System.Drawing.Point(83, 171)
        Me.UStIdNrLabel2.Name = "UStIdNrLabel2"
        Me.UStIdNrLabel2.Size = New System.Drawing.Size(190, 15)
        Me.UStIdNrLabel2.TabIndex = 16
        Me.UStIdNrLabel2.Text = "12-12345-698"
        '
        'LBL_Land
        '
        Me.LBL_Land.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Land", True))
        Me.LBL_Land.Location = New System.Drawing.Point(83, 62)
        Me.LBL_Land.Name = "LBL_Land"
        Me.LBL_Land.Size = New System.Drawing.Size(190, 15)
        Me.LBL_Land.TabIndex = 14
        Me.LBL_Land.Text = "Deutschland"
        '
        'BundeslandLabel2
        '
        Me.BundeslandLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Bundesland", True))
        Me.BundeslandLabel2.Location = New System.Drawing.Point(83, 136)
        Me.BundeslandLabel2.Name = "BundeslandLabel2"
        Me.BundeslandLabel2.Size = New System.Drawing.Size(190, 15)
        Me.BundeslandLabel2.TabIndex = 12
        Me.BundeslandLabel2.Text = "Niedersachsen"
        '
        'LBL_Ort
        '
        Me.LBL_Ort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Ort", True))
        Me.LBL_Ort.Location = New System.Drawing.Point(83, 121)
        Me.LBL_Ort.Name = "LBL_Ort"
        Me.LBL_Ort.Size = New System.Drawing.Size(190, 15)
        Me.LBL_Ort.TabIndex = 10
        Me.LBL_Ort.Text = "Hannover"
        '
        'LBL_PLZ
        '
        Me.LBL_PLZ.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "PLZ", True))
        Me.LBL_PLZ.Location = New System.Drawing.Point(83, 106)
        Me.LBL_PLZ.Name = "LBL_PLZ"
        Me.LBL_PLZ.Size = New System.Drawing.Size(190, 15)
        Me.LBL_PLZ.TabIndex = 8
        Me.LBL_PLZ.Text = "30419"
        '
        'PostfachLabel2
        '
        Me.PostfachLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Postfach", True))
        Me.PostfachLabel2.Location = New System.Drawing.Point(83, 91)
        Me.PostfachLabel2.Name = "PostfachLabel2"
        Me.PostfachLabel2.Size = New System.Drawing.Size(190, 15)
        Me.PostfachLabel2.TabIndex = 6
        Me.PostfachLabel2.Text = "12345"
        '
        'LBL_Strasse
        '
        Me.LBL_Strasse.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Straße", True))
        Me.LBL_Strasse.Location = New System.Drawing.Point(83, 76)
        Me.LBL_Strasse.Name = "LBL_Strasse"
        Me.LBL_Strasse.Size = New System.Drawing.Size(190, 15)
        Me.LBL_Strasse.TabIndex = 4
        Me.LBL_Strasse.Text = "Strasse 10"
        '
        'AdresstypLabel2
        '
        Me.AdresstypLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Adresstyp", True))
        Me.AdresstypLabel2.Location = New System.Drawing.Point(83, 40)
        Me.AdresstypLabel2.Name = "AdresstypLabel2"
        Me.AdresstypLabel2.Size = New System.Drawing.Size(190, 15)
        Me.AdresstypLabel2.TabIndex = 2
        Me.AdresstypLabel2.Text = "Rechnungsadresse"
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.Silver
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.LBL_IDAdresse)
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(289, 27)
        Me.Panel7.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(2, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Adresse"
        '
        'TabAdresseBearbeiten
        '
        Me.TabAdresseBearbeiten.AutoScroll = True
        Me.TabAdresseBearbeiten.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TabAdresseBearbeiten.Controls.Add(Me.LBL_PLZungueltig)
        Me.TabAdresseBearbeiten.Controls.Add(Me.CB_Ort)
        Me.TabAdresseBearbeiten.Controls.Add(Me.LBL_Countrycode)
        Me.TabAdresseBearbeiten.Controls.Add(Me.CB_Staat)
        Me.TabAdresseBearbeiten.Controls.Add(Me.lblAdresseNeu)
        Me.TabAdresseBearbeiten.Controls.Add(Me.btnNeueAdresse)
        Me.TabAdresseBearbeiten.Controls.Add(Me.btnKontoZuAdresse)
        Me.TabAdresseBearbeiten.Controls.Add(Me.IDKontoTextBox)
        Me.TabAdresseBearbeiten.Controls.Add(Me.AdresstypTextBox)
        Me.TabAdresseBearbeiten.Controls.Add(WebseiteLabel)
        Me.TabAdresseBearbeiten.Controls.Add(AdresstypLabel)
        Me.TabAdresseBearbeiten.Controls.Add(Me.WebseiteTextBox)
        Me.TabAdresseBearbeiten.Controls.Add(Me.StraßeTextBox)
        Me.TabAdresseBearbeiten.Controls.Add(UStIdNrLabel)
        Me.TabAdresseBearbeiten.Controls.Add(StraßeLabel)
        Me.TabAdresseBearbeiten.Controls.Add(Me.UStIdNrTextBox)
        Me.TabAdresseBearbeiten.Controls.Add(Me.TB_PLZ)
        Me.TabAdresseBearbeiten.Controls.Add(LandLabel)
        Me.TabAdresseBearbeiten.Controls.Add(PLZLabel)
        Me.TabAdresseBearbeiten.Controls.Add(Me.PostfachTextBox)
        Me.TabAdresseBearbeiten.Controls.Add(BundeslandLabel)
        Me.TabAdresseBearbeiten.Controls.Add(PostfachLabel)
        Me.TabAdresseBearbeiten.Controls.Add(Me.TB_Bundesland)
        Me.TabAdresseBearbeiten.Controls.Add(OrtLabel)
        Me.TabAdresseBearbeiten.Location = New System.Drawing.Point(4, 22)
        Me.TabAdresseBearbeiten.Name = "TabAdresseBearbeiten"
        Me.TabAdresseBearbeiten.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAdresseBearbeiten.Size = New System.Drawing.Size(286, 488)
        Me.TabAdresseBearbeiten.TabIndex = 1
        Me.TabAdresseBearbeiten.Text = "Bearbeiten / NEU"
        '
        'LBL_PLZungueltig
        '
        Me.LBL_PLZungueltig.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_PLZungueltig.AutoSize = True
        Me.LBL_PLZungueltig.ForeColor = System.Drawing.Color.Red
        Me.LBL_PLZungueltig.Location = New System.Drawing.Point(203, 141)
        Me.LBL_PLZungueltig.Name = "LBL_PLZungueltig"
        Me.LBL_PLZungueltig.Size = New System.Drawing.Size(70, 13)
        Me.LBL_PLZungueltig.TabIndex = 27
        Me.LBL_PLZungueltig.Text = "PLZ ungültig!"
        Me.LBL_PLZungueltig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_PLZungueltig.Visible = False
        '
        'CB_Ort
        '
        Me.CB_Ort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_Ort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_Ort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Ort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Ort", True))
        Me.CB_Ort.DataSource = Me.AdressenBindingSource
        Me.CB_Ort.DisplayMember = "Ort"
        Me.CB_Ort.FormattingEnabled = True
        Me.CB_Ort.Location = New System.Drawing.Point(74, 164)
        Me.CB_Ort.Name = "CB_Ort"
        Me.CB_Ort.Size = New System.Drawing.Size(207, 21)
        Me.CB_Ort.TabIndex = 6
        '
        'LBL_Countrycode
        '
        Me.LBL_Countrycode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_Countrycode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaatenBindingSource, "ISO2", True))
        Me.LBL_Countrycode.Location = New System.Drawing.Point(259, 57)
        Me.LBL_Countrycode.Name = "LBL_Countrycode"
        Me.LBL_Countrycode.Size = New System.Drawing.Size(22, 23)
        Me.LBL_Countrycode.TabIndex = 25
        Me.LBL_Countrycode.Text = "DE"
        Me.LBL_Countrycode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CB_Staat
        '
        Me.CB_Staat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_Staat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_Staat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Staat.DataSource = Me.StaatenBindingSource
        Me.CB_Staat.DisplayMember = "Staat"
        Me.CB_Staat.FormattingEnabled = True
        Me.CB_Staat.Location = New System.Drawing.Point(74, 59)
        Me.CB_Staat.Name = "CB_Staat"
        Me.CB_Staat.Size = New System.Drawing.Size(179, 21)
        Me.CB_Staat.TabIndex = 2
        '
        'lblAdresseNeu
        '
        Me.lblAdresseNeu.AutoSize = True
        Me.lblAdresseNeu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdresseNeu.ForeColor = System.Drawing.Color.Red
        Me.lblAdresseNeu.Location = New System.Drawing.Point(71, 10)
        Me.lblAdresseNeu.Name = "lblAdresseNeu"
        Me.lblAdresseNeu.Size = New System.Drawing.Size(33, 13)
        Me.lblAdresseNeu.TabIndex = 3
        Me.lblAdresseNeu.Text = "NEU"
        Me.lblAdresseNeu.Visible = False
        '
        'TC_Kontakt
        '
        Me.TC_Kontakt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TC_Kontakt.Controls.Add(Me.TabPage5)
        Me.TC_Kontakt.Controls.Add(Me.TabPage6)
        Me.TC_Kontakt.Location = New System.Drawing.Point(473, 78)
        Me.TC_Kontakt.Name = "TC_Kontakt"
        Me.TLP_1.SetRowSpan(Me.TC_Kontakt, 2)
        Me.TC_Kontakt.SelectedIndex = 0
        Me.TC_Kontakt.Size = New System.Drawing.Size(294, 514)
        Me.TC_Kontakt.TabIndex = 22
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TabPage5.Controls.Add(Me.OrtLabel2)
        Me.TabPage5.Controls.Add(Me.OrtLabel3)
        Me.TabPage5.Controls.Add(Me.StraßeLabel2)
        Me.TabPage5.Controls.Add(Me.StraßeLabel3)
        Me.TabPage5.Controls.Add(IDAdresseLabel)
        Me.TabPage5.Controls.Add(Me.BTN_ZuOutlook)
        Me.TabPage5.Controls.Add(Me.LBL_IDAdresseZuKontakt)
        Me.TabPage5.Controls.Add(Me.KontakteDataGridView)
        Me.TabPage5.Controls.Add(FaxnummerLabel1)
        Me.TabPage5.Controls.Add(Me.FaxnummerLabel2)
        Me.TabPage5.Controls.Add(MobiltelefonLabel1)
        Me.TabPage5.Controls.Add(Me.MobiltelefonLinkLabel)
        Me.TabPage5.Controls.Add(TelefonPrivatLabel1)
        Me.TabPage5.Controls.Add(Me.TelefonPrivatLinkLabel)
        Me.TabPage5.Controls.Add(TelefonGeschaeftlichLabel1)
        Me.TabPage5.Controls.Add(Me.TelefonGeschaeftlichLinkLabel)
        Me.TabPage5.Controls.Add(PositionLabel1)
        Me.TabPage5.Controls.Add(Me.PositionLabel2)
        Me.TabPage5.Controls.Add(EmailAddresseLabel1)
        Me.TabPage5.Controls.Add(NachnameLabel1)
        Me.TabPage5.Controls.Add(Me.LBL_Nachname)
        Me.TabPage5.Controls.Add(VornameLabel1)
        Me.TabPage5.Controls.Add(Me.LBL_Vorname)
        Me.TabPage5.Controls.Add(AnredeLabel1)
        Me.TabPage5.Controls.Add(Me.LBL_Anrede)
        Me.TabPage5.Controls.Add(Me.EmailAddresseLinkLabel)
        Me.TabPage5.Controls.Add(Me.Panel3)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(286, 488)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "Info"
        '
        'OrtLabel3
        '
        Me.OrtLabel3.Location = New System.Drawing.Point(100, 257)
        Me.OrtLabel3.Name = "OrtLabel3"
        Me.OrtLabel3.Size = New System.Drawing.Size(176, 15)
        Me.OrtLabel3.TabIndex = 37
        Me.OrtLabel3.Text = "---"
        '
        'StraßeLabel3
        '
        Me.StraßeLabel3.Location = New System.Drawing.Point(100, 242)
        Me.StraßeLabel3.Name = "StraßeLabel3"
        Me.StraßeLabel3.Size = New System.Drawing.Size(174, 15)
        Me.StraßeLabel3.TabIndex = 36
        Me.StraßeLabel3.Text = "---"
        '
        'LBL_IDAdresseZuKontakt
        '
        Me.LBL_IDAdresseZuKontakt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "IDAdresse", True))
        Me.LBL_IDAdresseZuKontakt.Location = New System.Drawing.Point(100, 227)
        Me.LBL_IDAdresseZuKontakt.Name = "LBL_IDAdresseZuKontakt"
        Me.LBL_IDAdresseZuKontakt.Size = New System.Drawing.Size(176, 15)
        Me.LBL_IDAdresseZuKontakt.TabIndex = 35
        Me.LBL_IDAdresseZuKontakt.Text = "IDAdresse"
        '
        'FaxnummerLabel2
        '
        Me.FaxnummerLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Faxnummer", True))
        Me.FaxnummerLabel2.Location = New System.Drawing.Point(100, 205)
        Me.FaxnummerLabel2.Name = "FaxnummerLabel2"
        Me.FaxnummerLabel2.Size = New System.Drawing.Size(176, 15)
        Me.FaxnummerLabel2.TabIndex = 34
        Me.FaxnummerLabel2.Text = "123456789"
        '
        'MobiltelefonLinkLabel
        '
        Me.MobiltelefonLinkLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Mobiltelefon", True))
        Me.MobiltelefonLinkLabel.Location = New System.Drawing.Point(100, 181)
        Me.MobiltelefonLinkLabel.Name = "MobiltelefonLinkLabel"
        Me.MobiltelefonLinkLabel.Size = New System.Drawing.Size(176, 15)
        Me.MobiltelefonLinkLabel.TabIndex = 33
        Me.MobiltelefonLinkLabel.TabStop = True
        Me.MobiltelefonLinkLabel.Text = "LinkLabel1"
        '
        'TelefonPrivatLinkLabel
        '
        Me.TelefonPrivatLinkLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "TelefonPrivat", True))
        Me.TelefonPrivatLinkLabel.Location = New System.Drawing.Point(100, 155)
        Me.TelefonPrivatLinkLabel.Name = "TelefonPrivatLinkLabel"
        Me.TelefonPrivatLinkLabel.Size = New System.Drawing.Size(176, 15)
        Me.TelefonPrivatLinkLabel.TabIndex = 32
        Me.TelefonPrivatLinkLabel.TabStop = True
        Me.TelefonPrivatLinkLabel.Text = "LinkLabel1"
        '
        'TelefonGeschaeftlichLinkLabel
        '
        Me.TelefonGeschaeftlichLinkLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "TelefonGeschaeftlich", True))
        Me.TelefonGeschaeftlichLinkLabel.Location = New System.Drawing.Point(100, 130)
        Me.TelefonGeschaeftlichLinkLabel.Name = "TelefonGeschaeftlichLinkLabel"
        Me.TelefonGeschaeftlichLinkLabel.Size = New System.Drawing.Size(176, 15)
        Me.TelefonGeschaeftlichLinkLabel.TabIndex = 31
        Me.TelefonGeschaeftlichLinkLabel.TabStop = True
        Me.TelefonGeschaeftlichLinkLabel.Text = "LinkLabel1"
        '
        'PositionLabel2
        '
        Me.PositionLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Jobtitle", True))
        Me.PositionLabel2.Location = New System.Drawing.Point(100, 85)
        Me.PositionLabel2.Name = "PositionLabel2"
        Me.PositionLabel2.Size = New System.Drawing.Size(176, 15)
        Me.PositionLabel2.TabIndex = 30
        Me.PositionLabel2.Text = "Macher"
        '
        'LBL_Nachname
        '
        Me.LBL_Nachname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Nachname", True))
        Me.LBL_Nachname.Location = New System.Drawing.Point(100, 55)
        Me.LBL_Nachname.Name = "LBL_Nachname"
        Me.LBL_Nachname.Size = New System.Drawing.Size(176, 15)
        Me.LBL_Nachname.TabIndex = 29
        Me.LBL_Nachname.Text = "Müller"
        '
        'LBL_Vorname
        '
        Me.LBL_Vorname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Vorname", True))
        Me.LBL_Vorname.Location = New System.Drawing.Point(100, 70)
        Me.LBL_Vorname.Name = "LBL_Vorname"
        Me.LBL_Vorname.Size = New System.Drawing.Size(176, 15)
        Me.LBL_Vorname.TabIndex = 28
        Me.LBL_Vorname.Text = "Klaus Wilhelm"
        '
        'LBL_Anrede
        '
        Me.LBL_Anrede.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Anrede", True))
        Me.LBL_Anrede.Location = New System.Drawing.Point(100, 40)
        Me.LBL_Anrede.Name = "LBL_Anrede"
        Me.LBL_Anrede.Size = New System.Drawing.Size(176, 15)
        Me.LBL_Anrede.TabIndex = 27
        Me.LBL_Anrede.Text = "Herr"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TabPage6.Controls.Add(Me.BTN_DeleteUser)
        Me.TabPage6.Controls.Add(Me.lblKontaktNeu)
        Me.TabPage6.Controls.Add(Me.btnAdresseZuKontakt)
        Me.TabPage6.Controls.Add(Me.btnNeuerKontakt)
        Me.TabPage6.Controls.Add(Me.IDAdresseTextBox)
        Me.TabPage6.Controls.Add(FaxnummerLabel)
        Me.TabPage6.Controls.Add(Me.FaxnummerTextBox)
        Me.TabPage6.Controls.Add(Me.AnredeComboBox)
        Me.TabPage6.Controls.Add(MobiltelefonLabel)
        Me.TabPage6.Controls.Add(AnredeLabel)
        Me.TabPage6.Controls.Add(Me.MobiltelefonTextBox)
        Me.TabPage6.Controls.Add(Me.NachnameTextBox)
        Me.TabPage6.Controls.Add(TelefonPrivatLabel)
        Me.TabPage6.Controls.Add(NachnameLabel)
        Me.TabPage6.Controls.Add(Me.TelefonPrivatTextBox)
        Me.TabPage6.Controls.Add(Me.VornameTextBox)
        Me.TabPage6.Controls.Add(TelefonGeschaeftlichLabel)
        Me.TabPage6.Controls.Add(VornameLabel)
        Me.TabPage6.Controls.Add(Me.TelefonGeschaeftlichTextBox)
        Me.TabPage6.Controls.Add(Me.EmailAddresseTextBox)
        Me.TabPage6.Controls.Add(PositionLabel)
        Me.TabPage6.Controls.Add(EmailAddresseLabel)
        Me.TabPage6.Controls.Add(Me.PositionTextBox)
        Me.TabPage6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(286, 488)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Bearbeiten / NEU"
        '
        'BTN_DeleteUser
        '
        Me.BTN_DeleteUser.BackColor = System.Drawing.Color.Red
        Me.BTN_DeleteUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DeleteUser.ForeColor = System.Drawing.Color.White
        Me.BTN_DeleteUser.Image = Global.Adress_DB.My.Resources.Resources.DeleteUser_16x
        Me.BTN_DeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_DeleteUser.Location = New System.Drawing.Point(6, 315)
        Me.BTN_DeleteUser.Name = "BTN_DeleteUser"
        Me.BTN_DeleteUser.Size = New System.Drawing.Size(75, 23)
        Me.BTN_DeleteUser.TabIndex = 27
        Me.BTN_DeleteUser.Text = "löschen"
        Me.BTN_DeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_DeleteUser.UseVisualStyleBackColor = False
        '
        'lblKontaktNeu
        '
        Me.lblKontaktNeu.AutoSize = True
        Me.lblKontaktNeu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKontaktNeu.ForeColor = System.Drawing.Color.Red
        Me.lblKontaktNeu.Location = New System.Drawing.Point(101, 10)
        Me.lblKontaktNeu.Name = "lblKontaktNeu"
        Me.lblKontaktNeu.Size = New System.Drawing.Size(33, 13)
        Me.lblKontaktNeu.TabIndex = 26
        Me.lblKontaktNeu.Text = "NEU"
        Me.lblKontaktNeu.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.ToolStripMenuItem1, Me.InfoToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1272, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocuWareDateiManuellToolStripMenuItem, Me.SchließenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'DocuWareDateiManuellToolStripMenuItem
        '
        Me.DocuWareDateiManuellToolStripMenuItem.Image = Global.Adress_DB.My.Resources.Resources.DocuWare_Logo
        Me.DocuWareDateiManuellToolStripMenuItem.Name = "DocuWareDateiManuellToolStripMenuItem"
        Me.DocuWareDateiManuellToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.DocuWareDateiManuellToolStripMenuItem.Text = "DocuWare-Datei manuell"
        '
        'SchließenToolStripMenuItem
        '
        Me.SchließenToolStripMenuItem.Image = Global.Adress_DB.My.Resources.Resources.CloseSolution_16x
        Me.SchließenToolStripMenuItem.Name = "SchließenToolStripMenuItem"
        Me.SchließenToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.SchließenToolStripMenuItem.Text = "Schließen"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BenutzerlisteToolStripMenuItem, Me.EinstellungenToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(90, 20)
        Me.ToolStripMenuItem1.Text = "Einstellungen"
        '
        'BenutzerlisteToolStripMenuItem
        '
        Me.BenutzerlisteToolStripMenuItem.Image = CType(resources.GetObject("BenutzerlisteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BenutzerlisteToolStripMenuItem.Name = "BenutzerlisteToolStripMenuItem"
        Me.BenutzerlisteToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.BenutzerlisteToolStripMenuItem.Text = "Benutzerliste"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.Image = CType(resources.GetObject("EinstellungenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.EinstellungenToolStripMenuItem.Text = "Administration"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AktivitätslogToolStripMenuItem, Me.InfoÜberAdressenDBToolStripMenuItem1, Me.HilfeToolStripMenuItem})
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'AktivitätslogToolStripMenuItem
        '
        Me.AktivitätslogToolStripMenuItem.Image = Global.Adress_DB.My.Resources.Resources.EnableLog_16x
        Me.AktivitätslogToolStripMenuItem.Name = "AktivitätslogToolStripMenuItem"
        Me.AktivitätslogToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.AktivitätslogToolStripMenuItem.Text = "Aktivitätslog"
        '
        'InfoÜberAdressenDBToolStripMenuItem1
        '
        Me.InfoÜberAdressenDBToolStripMenuItem1.Image = Global.Adress_DB.My.Resources.Resources.StatusInformation_16x
        Me.InfoÜberAdressenDBToolStripMenuItem1.Name = "InfoÜberAdressenDBToolStripMenuItem1"
        Me.InfoÜberAdressenDBToolStripMenuItem1.Size = New System.Drawing.Size(193, 22)
        Me.InfoÜberAdressenDBToolStripMenuItem1.Text = "Info über Adressen-DB"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.Image = Global.Adress_DB.My.Resources.Resources.F1Help_16x
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.HilfeToolStripMenuItem.Text = "Hilfe"
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(880, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(392, 25)
        Me.lblUser.TabIndex = 21
        Me.lblUser.Text = "Sachbearbeiter"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Silver
        Me.Panel8.Controls.Add(Me.BTN_DocErzeugen)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(773, 598)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(494, 44)
        Me.Panel8.TabIndex = 24
        '
        'KontakteMitAdresseBindingSource
        '
        Me.KontakteMitAdresseBindingSource.DataMember = "KontakteMitAdresse"
        Me.KontakteMitAdresseBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'FirmenNameTableAdapter
        '
        Me.FirmenNameTableAdapter.ClearBeforeFill = True
        '
        'KontoTableAdapter
        '
        Me.KontoTableAdapter.ClearBeforeFill = True
        '
        'AdressenTableAdapter
        '
        Me.AdressenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdressenTableAdapter = Nothing
        Me.TableAdapterManager.AT_PLZ_GeodatenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BelegeTableAdapter = Nothing
        Me.TableAdapterManager.CH_PLZ_GeodatenTableAdapter = Nothing
        Me.TableAdapterManager.DE_PLZ_GeodatenTableAdapter = Nothing
        Me.TableAdapterManager.FirmenNameTableAdapter = Me.FirmenNameTableAdapter
        Me.TableAdapterManager.KontakteTableAdapter = Nothing
        Me.TableAdapterManager.KontoTableAdapter = Nothing
        Me.TableAdapterManager.LogTabelleTableAdapter = Nothing
        Me.TableAdapterManager.PLZ_GeodatenTableAdapter = Nothing
        Me.TableAdapterManager.propertiesTableAdapter = Nothing
        Me.TableAdapterManager.SachbearbeiterTableAdapter = Nothing
        Me.TableAdapterManager.StaatenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete
        '
        'KontakteTableAdapter
        '
        Me.KontakteTableAdapter.ClearBeforeFill = True
        '
        'SachbearbeiterTableAdapter
        '
        Me.SachbearbeiterTableAdapter.ClearBeforeFill = True
        '
        'KontakteMitAdresseTableAdapter
        '
        Me.KontakteMitAdresseTableAdapter.ClearBeforeFill = True
        '
        'DocuwareCSVTableAdapter
        '
        Me.DocuwareCSVTableAdapter.ClearBeforeFill = True
        '
        'BelegeBindingSource
        '
        Me.BelegeBindingSource.DataMember = "Belege"
        Me.BelegeBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'BelegeTableAdapter
        '
        Me.BelegeTableAdapter.ClearBeforeFill = True
        '
        'BelegeMitAdresseTableAdapter
        '
        Me.BelegeMitAdresseTableAdapter.ClearBeforeFill = True
        '
        'LogTabelleBindingSource
        '
        Me.LogTabelleBindingSource.DataMember = "LogTabelle"
        Me.LogTabelleBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'LogTabelleTableAdapter
        '
        Me.LogTabelleTableAdapter.ClearBeforeFill = True
        '
        'StaatenTableAdapter
        '
        Me.StaatenTableAdapter.ClearBeforeFill = True
        '
        'AT_PLZ_GeodatenBindingSource
        '
        Me.AT_PLZ_GeodatenBindingSource.DataMember = "AT_PLZ_Geodaten"
        Me.AT_PLZ_GeodatenBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'AT_PLZ_GeodatenTableAdapter
        '
        Me.AT_PLZ_GeodatenTableAdapter.ClearBeforeFill = True
        '
        'CH_PLZ_GeodatenBindingSource
        '
        Me.CH_PLZ_GeodatenBindingSource.DataMember = "CH_PLZ_Geodaten"
        Me.CH_PLZ_GeodatenBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'CH_PLZ_GeodatenTableAdapter
        '
        Me.CH_PLZ_GeodatenTableAdapter.ClearBeforeFill = True
        '
        'DE_PLZ_GeodatenBindingSource
        '
        Me.DE_PLZ_GeodatenBindingSource.DataMember = "DE_PLZ_Geodaten"
        Me.DE_PLZ_GeodatenBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'DE_PLZ_GeodatenTableAdapter
        '
        Me.DE_PLZ_GeodatenTableAdapter.ClearBeforeFill = True
        '
        'PropertiesBindingSource
        '
        Me.PropertiesBindingSource.DataMember = "properties"
        Me.PropertiesBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'PropertiesTableAdapter
        '
        Me.PropertiesTableAdapter.ClearBeforeFill = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Silver
        Me.Panel9.Controls.Add(Me.Button1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(773, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(494, 69)
        Me.Panel9.TabIndex = 26
        '
        'TLP_1
        '
        Me.TLP_1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLP_1.ColumnCount = 4
        Me.TLP_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TLP_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TLP_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.TLP_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_1.Controls.Add(Me.Panel9, 3, 0)
        Me.TLP_1.Controls.Add(Me.TC_Beleg, 3, 1)
        Me.TLP_1.Controls.Add(Me.Panel1, 0, 0)
        Me.TLP_1.Controls.Add(Me.TC_Adresse, 1, 1)
        Me.TLP_1.Controls.Add(Me.Panel6, 0, 3)
        Me.TLP_1.Controls.Add(Me.Panel8, 3, 3)
        Me.TLP_1.Controls.Add(Me.PNL_Konto, 0, 1)
        Me.TLP_1.Controls.Add(Me.Panel10, 0, 2)
        Me.TLP_1.Controls.Add(Me.TC_Kontakt, 2, 1)
        Me.TLP_1.Location = New System.Drawing.Point(0, 25)
        Me.TLP_1.Name = "TLP_1"
        Me.TLP_1.RowCount = 4
        Me.TLP_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TLP_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 275.0!))
        Me.TLP_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TLP_1.Size = New System.Drawing.Size(1270, 645)
        Me.TLP_1.TabIndex = 27
        '
        'PNL_Konto
        '
        Me.PNL_Konto.BackColor = System.Drawing.Color.White
        Me.PNL_Konto.Controls.Add(Me.KontoDataGridView)
        Me.PNL_Konto.Controls.Add(Me.btnNeuesKonto)
        Me.PNL_Konto.Controls.Add(Me.lblIDKonto)
        Me.PNL_Konto.Controls.Add(Me.Label3)
        Me.PNL_Konto.Controls.Add(Me.Panel4)
        Me.PNL_Konto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNL_Konto.Location = New System.Drawing.Point(3, 78)
        Me.PNL_Konto.Name = "PNL_Konto"
        Me.PNL_Konto.Size = New System.Drawing.Size(164, 269)
        Me.PNL_Konto.TabIndex = 28
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.DocuwareCSVDataGridView)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(3, 353)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(164, 239)
        Me.Panel10.TabIndex = 29
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 673)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1272, 22)
        Me.StatusStrip1.TabIndex = 28
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(300, 16)
        Me.ToolStripProgressBar1.Visible = False
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(192, 17)
        Me.ToolStripStatusLabel1.Text = "DocuWare-Datei erfolgreich erstellt"
        Me.ToolStripStatusLabel1.Visible = False
        '
        'Hauptform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1272, 695)
        Me.Controls.Add(Me.lblHinweisKeinTreffer)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TLP_1)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Hauptform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adress-Datenbank"
        CType(Me.FirmenNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._WSL_AdressenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KontoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DocuwareCSVDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocuwareCSVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdressenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.KontoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdressenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KontakteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KontakteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TC_Beleg.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.SachbearbeiterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GB_Anrede.ResumeLayout(False)
        Me.GB_Anrede.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BelegeMitAdresseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.TC_Adresse.ResumeLayout(False)
        Me.TabAdresseInfo.ResumeLayout(False)
        Me.TabAdresseInfo.PerformLayout()
        CType(Me.StaatenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_Geodaten.ResumeLayout(False)
        Me.PNL_Geodaten.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.TabAdresseBearbeiten.ResumeLayout(False)
        Me.TabAdresseBearbeiten.PerformLayout()
        Me.TC_Kontakt.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        CType(Me.KontakteMitAdresseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BelegeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogTabelleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AT_PLZ_GeodatenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CH_PLZ_GeodatenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DE_PLZ_GeodatenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.TLP_1.ResumeLayout(False)
        Me.PNL_Konto.ResumeLayout(False)
        Me.PNL_Konto.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _WSL_AdressenDataSet As _WSL_AdressenDataSet
    Friend WithEvents FirmenNameBindingSource As BindingSource
    Friend WithEvents FirmenNameTableAdapter As _WSL_AdressenDataSetTableAdapters.FirmenNameTableAdapter
    Friend WithEvents TB_FirmenName As TextBox
    Friend WithEvents BTN_Suche As Button
    Friend WithEvents LBL_IDFirmenName As Label
    Friend WithEvents KontoBindingSource As BindingSource
    Friend WithEvents KontoTableAdapter As _WSL_AdressenDataSetTableAdapters.KontoTableAdapter
    Friend WithEvents lblIDKonto As Label
    Friend WithEvents CB_FirmenName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNeuesKonto As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblHinweisKeinTreffer As Label
    Friend WithEvents BTN_Speichern As Button
    Friend WithEvents AdressenBindingSource As BindingSource
    Friend WithEvents AdressenTableAdapter As _WSL_AdressenDataSetTableAdapters.AdressenTableAdapter
    Friend WithEvents AdressenDataGridView As DataGridView
    Friend WithEvents TableAdapterManager As _WSL_AdressenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TB_PLZ As TextBox
    Friend WithEvents StraßeTextBox As TextBox
    Friend WithEvents AdresstypTextBox As TextBox
    Friend WithEvents LBL_IDAdresse As Label
    Friend WithEvents PostfachTextBox As TextBox
    Friend WithEvents btnKontoZuAdresse As Button
    Friend WithEvents IDKontoTextBox As TextBox
    Friend WithEvents WebseiteTextBox As TextBox
    Friend WithEvents UStIdNrTextBox As TextBox
    Friend WithEvents TB_Bundesland As TextBox
    Friend WithEvents btnNeueAdresse As Button
    Friend WithEvents BTN_MapsSuche As Button
    Friend WithEvents lblTrefferAnzahl As Label
    Friend WithEvents KontoDataGridView As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnNeuerKontakt As Button
    Friend WithEvents BTN_ZuOutlook As Button
    Friend WithEvents lblKontaktHeader As Label
    Friend WithEvents KontakteBindingSource As BindingSource
    Friend WithEvents KontakteDataGridView As DataGridView
    Friend WithEvents btnAdresseZuKontakt As Button
    Friend WithEvents IDAdresseTextBox As TextBox
    Friend WithEvents FaxnummerTextBox As TextBox
    Friend WithEvents MobiltelefonTextBox As TextBox
    Friend WithEvents TelefonPrivatTextBox As TextBox
    Friend WithEvents TelefonGeschaeftlichTextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents EmailAddresseTextBox As TextBox
    Friend WithEvents VornameTextBox As TextBox
    Friend WithEvents NachnameTextBox As TextBox
    Friend WithEvents AnredeComboBox As ComboBox
    Friend WithEvents LBL_IDKontakt As Label
    Friend WithEvents KontakteTableAdapter As _WSL_AdressenDataSetTableAdapters.KontakteTableAdapter
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents TC_Beleg As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel6 As Panel
    Friend WithEvents EmailAddresseLinkLabel As LinkLabel
    Friend WithEvents TC_Adresse As TabControl
    Friend WithEvents TabAdresseInfo As TabPage
    Friend WithEvents WebseiteLinkLabel As LinkLabel
    Friend WithEvents UStIdNrLabel2 As Label
    Friend WithEvents LBL_Land As Label
    Friend WithEvents BundeslandLabel2 As Label
    Friend WithEvents LBL_Ort As Label
    Friend WithEvents LBL_PLZ As Label
    Friend WithEvents PostfachLabel2 As Label
    Friend WithEvents LBL_Strasse As Label
    Friend WithEvents AdresstypLabel2 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents TabAdresseBearbeiten As TabPage
    Friend WithEvents LBL_IDKontoZuAdresse As Label
    Friend WithEvents TC_Kontakt As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents LBL_IDAdresseZuKontakt As Label
    Friend WithEvents FaxnummerLabel2 As Label
    Friend WithEvents MobiltelefonLinkLabel As LinkLabel
    Friend WithEvents TelefonPrivatLinkLabel As LinkLabel
    Friend WithEvents TelefonGeschaeftlichLinkLabel As LinkLabel
    Friend WithEvents PositionLabel2 As Label
    Friend WithEvents LBL_Nachname As Label
    Friend WithEvents LBL_Vorname As Label
    Friend WithEvents LBL_Anrede As Label
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents IDKontakt As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents btnAbbrechen As Button
    Friend WithEvents lblAdresseNeu As Label
    Friend WithEvents lblKontaktNeu As Label
    Friend WithEvents LBL_FirmenName As Label
    Friend WithEvents OrtLabel3 As Label
    Friend WithEvents StraßeLabel3 As Label
    Friend WithEvents StraßeLabel2 As Label
    Friend WithEvents OrtLabel2 As Label
    Friend WithEvents DTP_BBDatum As DateTimePicker
    Friend WithEvents LBL_BBLand As Label
    Friend WithEvents LBL_BBOrt As Label
    Friend WithEvents LBL_BBPLZ As Label
    Friend WithEvents LBL_BBStrasse As Label
    Friend WithEvents TB_BBThema As TextBox
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents SachbearbeiterBindingSource As BindingSource
    Friend WithEvents SachbearbeiterTableAdapter As _WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter
    Friend WithEvents LBL_BBBesuchterKontakt As Label
    Friend WithEvents BTN_DocErzeugen As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BenutzerlisteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LBL_BBIDKonto As Label
    Friend WithEvents LBL_BBRegion As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents KontakteMitAdresseBindingSource As BindingSource
    Friend WithEvents KontakteMitAdresseTableAdapter As _WSL_AdressenDataSetTableAdapters.KontakteMitAdresseTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DocuwareCSVBindingSource As BindingSource
    Friend WithEvents DocuwareCSVTableAdapter As _WSL_AdressenDataSetTableAdapters.DocuwareCSVTableAdapter
    Friend WithEvents DocuwareCSVDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents CB_Vorlagen As ComboBox
    Friend WithEvents LBL_Sprache As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents GB_Anrede As GroupBox
    Friend WithEvents TB_DIVFaxnummer As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RB_OhneAnrede As RadioButton
    Friend WithEvents RB_MitAnrede As RadioButton
    Friend WithEvents LBL_DIVAdresse As Label
    Friend WithEvents DTP_Diverse As DateTimePicker
    Friend WithEvents LBL_DIVEmail As Label
    Friend WithEvents LBL_DIVDurchwahl As Label
    Friend WithEvents LBL_DIVJobtitle As Label
    Friend WithEvents CB_DIVSachbearbeiter As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TB_DIVThema As TextBox
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoÜberAdressenDBToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents TB_BBWeitereBesucher As TextBox
    Friend WithEvents TB_BBWeitereKontakte As TextBox
    Friend WithEvents CB_BBKuerzel As ComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents LBL_DIVIDKonto As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BelegeBindingSource As BindingSource
    Friend WithEvents BelegeTableAdapter As _WSL_AdressenDataSetTableAdapters.BelegeTableAdapter
    Friend WithEvents BelegeMitAdresseBindingSource As BindingSource
    Friend WithEvents BelegeMitAdresseTableAdapter As _WSL_AdressenDataSetTableAdapters.BelegeMitAdresseTableAdapter
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocuWareDateiManuellToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AktivitätslogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IDBelegDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KuerzelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KontaktDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ThemaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BelegnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SchließenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BTN_DeleteUser As Button
    Friend WithEvents LogTabelleBindingSource As BindingSource
    Friend WithEvents LogTabelleTableAdapter As _WSL_AdressenDataSetTableAdapters.LogTabelleTableAdapter
    Friend WithEvents HilfeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BTN_NachnameSuche As Button
    Friend WithEvents LBL_Countrycode As Label
    Friend WithEvents CB_Ort As ComboBox
    Friend WithEvents CB_Staat As ComboBox
    Friend WithEvents StaatenBindingSource As BindingSource
    Friend WithEvents StaatenTableAdapter As _WSL_AdressenDataSetTableAdapters.StaatenTableAdapter
    Friend WithEvents LBL_PLZungueltig As Label
    Friend WithEvents AT_PLZ_GeodatenBindingSource As BindingSource
    Friend WithEvents AT_PLZ_GeodatenTableAdapter As _WSL_AdressenDataSetTableAdapters.AT_PLZ_GeodatenTableAdapter
    Friend WithEvents CH_PLZ_GeodatenBindingSource As BindingSource
    Friend WithEvents CH_PLZ_GeodatenTableAdapter As _WSL_AdressenDataSetTableAdapters.CH_PLZ_GeodatenTableAdapter
    Friend WithEvents DE_PLZ_GeodatenBindingSource As BindingSource
    Friend WithEvents DE_PLZ_GeodatenTableAdapter As _WSL_AdressenDataSetTableAdapters.DE_PLZ_GeodatenTableAdapter
    Friend WithEvents LBL_AdressHinweis As Label
    Friend WithEvents LBL_Long As Label
    Friend WithEvents LBL_Lat As Label
    Friend WithEvents LBLLong As Label
    Friend WithEvents LBLLat As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PNL_Geodaten As Panel
    Friend WithEvents LabelLandAdressen As Label
    Friend WithEvents LBL_CC As Label
    Friend WithEvents PropertiesBindingSource As BindingSource
    Friend WithEvents PropertiesTableAdapter As _WSL_AdressenDataSetTableAdapters.propertiesTableAdapter
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TLP_1 As TableLayoutPanel
    Friend WithEvents PNL_Konto As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents IDAdresse As DataGridViewTextBoxColumn
    Friend WithEvents IDKonto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
