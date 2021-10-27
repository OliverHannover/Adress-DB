<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim IDFirmenNameLabel As System.Windows.Forms.Label
        Dim LeadnummerLabel As System.Windows.Forms.Label
        Dim KundennummerLabel As System.Windows.Forms.Label
        Dim LieferantennummerLabel As System.Windows.Forms.Label
        Dim IDAdresseLabel As System.Windows.Forms.Label
        Dim IDKontaktLabel As System.Windows.Forms.Label
        Dim IDBesuchLabel As System.Windows.Forms.Label
        Dim VorlagenpfadLabel As System.Windows.Forms.Label
        Dim SachbearbeiterLabel As System.Windows.Forms.Label
        Dim AdminLabel As System.Windows.Forms.Label
        Dim IDFirmenNameLabel1 As System.Windows.Forms.Label
        Dim FirmenNameLabel As System.Windows.Forms.Label
        Dim LoginLabel As System.Windows.Forms.Label
        Dim ChangedLabel As System.Windows.Forms.Label
        Dim IDKontoLabel As System.Windows.Forms.Label
        Dim IDFirmenNameLabel2 As System.Windows.Forms.Label
        Dim KontoNameLabel As System.Windows.Forms.Label
        Dim AnlageDatumLabel As System.Windows.Forms.Label
        Dim IDAdresseLabel1 As System.Windows.Forms.Label
        Dim IDFirmenNameLabel3 As System.Windows.Forms.Label
        Dim IDKontoLabel1 As System.Windows.Forms.Label
        Dim AdresstypLabel As System.Windows.Forms.Label
        Dim StraßeLabel As System.Windows.Forms.Label
        Dim PostfachLabel As System.Windows.Forms.Label
        Dim PLZLabel As System.Windows.Forms.Label
        Dim OrtLabel As System.Windows.Forms.Label
        Dim BundeslandLabel As System.Windows.Forms.Label
        Dim LandLabel As System.Windows.Forms.Label
        Dim UStIdNrLabel As System.Windows.Forms.Label
        Dim WebseiteLabel As System.Windows.Forms.Label
        Dim IDKontaktLabel1 As System.Windows.Forms.Label
        Dim IDFirmenNameLabel4 As System.Windows.Forms.Label
        Dim VornameLabel As System.Windows.Forms.Label
        Dim NachnameLabel As System.Windows.Forms.Label
        Dim AnredeLabel As System.Windows.Forms.Label
        Dim EmailAddresseLabel As System.Windows.Forms.Label
        Dim JobtitleLabel As System.Windows.Forms.Label
        Dim TelefonGeschaeftlichLabel As System.Windows.Forms.Label
        Dim TelefonPrivatLabel As System.Windows.Forms.Label
        Dim MobiltelefonLabel As System.Windows.Forms.Label
        Dim FaxnummerLabel As System.Windows.Forms.Label
        Dim IDAdresseLabel2 As System.Windows.Forms.Label
        Dim DWpfadLabel As System.Windows.Forms.Label
        Dim DWDateinameLabel As System.Windows.Forms.Label
        Dim InaktivLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim HilfelinkLabel As System.Windows.Forms.Label
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.VorlagenpfadTextBox = New System.Windows.Forms.TextBox()
        Me.KonfigurationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._WSL_AdressenDataSet = New Adress_DB._WSL_AdressenDataSet()
        Me.IDBesuchTextBox = New System.Windows.Forms.TextBox()
        Me.IDKontaktTextBox = New System.Windows.Forms.TextBox()
        Me.IDAdresseTextBox = New System.Windows.Forms.TextBox()
        Me.LieferantennummerTextBox = New System.Windows.Forms.TextBox()
        Me.KundennummerTextBox = New System.Windows.Forms.TextBox()
        Me.LeadnummerTextBox = New System.Windows.Forms.TextBox()
        Me.IDFirmenNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTN_Alle = New System.Windows.Forms.Button()
        Me.BTN_Aktuell = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SachbearbeiterLabel1 = New System.Windows.Forms.Label()
        Me.SachbearbeiterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BTN_Schliessen = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager()
        Me.KonfigurationTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.KonfigurationTableAdapter()
        Me.SachbearbeiterTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter()
        Me.TC_Administration = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BTN_DWPfad = New System.Windows.Forms.Button()
        Me.DWDateinameTextBox = New System.Windows.Forms.TextBox()
        Me.DWpfadTextBox = New System.Windows.Forms.TextBox()
        Me.BTN_Speichern = New System.Windows.Forms.Button()
        Me.BTN_Vorlagenpfad = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.InaktivCheckBox = New System.Windows.Forms.CheckBox()
        Me.FirmenNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton21 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton22 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton23 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton24 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton25 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton26 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.BNAV_FirmenNameSave = New System.Windows.Forms.ToolStripButton()
        Me.ChangedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LoginTextBox = New System.Windows.Forms.TextBox()
        Me.FirmenNameTextBox = New System.Windows.Forms.TextBox()
        Me.IDFirmenNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.FirmenNameDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Login = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.changed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inaktiv = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.KontoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton16 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton17 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton18 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton19 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.BNAV_KontoSave = New System.Windows.Forms.ToolStripButton()
        Me.AnlageDatumDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.KontoNameTextBox = New System.Windows.Forms.TextBox()
        Me.IDFirmenNameTextBox2 = New System.Windows.Forms.TextBox()
        Me.IDKontoTextBox = New System.Windows.Forms.TextBox()
        Me.KontoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Datum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.AdressenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BNAV_AdressenSave = New System.Windows.Forms.ToolStripButton()
        Me.WebseiteTextBox = New System.Windows.Forms.TextBox()
        Me.UStIdNrTextBox = New System.Windows.Forms.TextBox()
        Me.LandTextBox = New System.Windows.Forms.TextBox()
        Me.BundeslandTextBox = New System.Windows.Forms.TextBox()
        Me.OrtTextBox = New System.Windows.Forms.TextBox()
        Me.PLZTextBox = New System.Windows.Forms.TextBox()
        Me.PostfachTextBox = New System.Windows.Forms.TextBox()
        Me.StraßeTextBox = New System.Windows.Forms.TextBox()
        Me.AdresstypTextBox = New System.Windows.Forms.TextBox()
        Me.IDKontoTextBox1 = New System.Windows.Forms.TextBox()
        Me.IDFirmenNameTextBox3 = New System.Windows.Forms.TextBox()
        Me.IDAdresseTextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDAdresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDKonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adresstyp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Straße = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Postfach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLZ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bundesland = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Land = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UStIdNr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Webseite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.SachbearbeiterBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.KontakteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BNAV_KontakteSave = New System.Windows.Forms.ToolStripButton()
        Me.IDAdresseTextBox2 = New System.Windows.Forms.TextBox()
        Me.FaxnummerTextBox = New System.Windows.Forms.TextBox()
        Me.MobiltelefonTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonPrivatTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonGeschaeftlichTextBox = New System.Windows.Forms.TextBox()
        Me.JobtitleTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddresseTextBox = New System.Windows.Forms.TextBox()
        Me.AnredeTextBox = New System.Windows.Forms.TextBox()
        Me.NachnameTextBox = New System.Windows.Forms.TextBox()
        Me.VornameTextBox = New System.Windows.Forms.TextBox()
        Me.IDFirmenNameTextBox4 = New System.Windows.Forms.TextBox()
        Me.IDKontaktTextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDKontakt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDFirmenName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nachname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vorname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobtitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonGeschaeftlichDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonPrivatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobiltelefonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaxnummerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDAdresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnredeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Belege = New System.Windows.Forms.TabPage()
        Me.BNAV_Belege = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton28 = New System.Windows.Forms.ToolStripButton()
        Me.BelegeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton29 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton30 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton31 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox5 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton32 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton33 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.BNAV_BelegeSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BelegeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirmenNameTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.FirmenNameTableAdapter()
        Me.KontoTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.KontoTableAdapter()
        Me.AdressenTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.AdressenTableAdapter()
        Me.KontakteTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.KontakteTableAdapter()
        Me.BelegeTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.BelegeTableAdapter()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.HilfelinkTextBox = New System.Windows.Forms.TextBox()
        IDFirmenNameLabel = New System.Windows.Forms.Label()
        LeadnummerLabel = New System.Windows.Forms.Label()
        KundennummerLabel = New System.Windows.Forms.Label()
        LieferantennummerLabel = New System.Windows.Forms.Label()
        IDAdresseLabel = New System.Windows.Forms.Label()
        IDKontaktLabel = New System.Windows.Forms.Label()
        IDBesuchLabel = New System.Windows.Forms.Label()
        VorlagenpfadLabel = New System.Windows.Forms.Label()
        SachbearbeiterLabel = New System.Windows.Forms.Label()
        AdminLabel = New System.Windows.Forms.Label()
        IDFirmenNameLabel1 = New System.Windows.Forms.Label()
        FirmenNameLabel = New System.Windows.Forms.Label()
        LoginLabel = New System.Windows.Forms.Label()
        ChangedLabel = New System.Windows.Forms.Label()
        IDKontoLabel = New System.Windows.Forms.Label()
        IDFirmenNameLabel2 = New System.Windows.Forms.Label()
        KontoNameLabel = New System.Windows.Forms.Label()
        AnlageDatumLabel = New System.Windows.Forms.Label()
        IDAdresseLabel1 = New System.Windows.Forms.Label()
        IDFirmenNameLabel3 = New System.Windows.Forms.Label()
        IDKontoLabel1 = New System.Windows.Forms.Label()
        AdresstypLabel = New System.Windows.Forms.Label()
        StraßeLabel = New System.Windows.Forms.Label()
        PostfachLabel = New System.Windows.Forms.Label()
        PLZLabel = New System.Windows.Forms.Label()
        OrtLabel = New System.Windows.Forms.Label()
        BundeslandLabel = New System.Windows.Forms.Label()
        LandLabel = New System.Windows.Forms.Label()
        UStIdNrLabel = New System.Windows.Forms.Label()
        WebseiteLabel = New System.Windows.Forms.Label()
        IDKontaktLabel1 = New System.Windows.Forms.Label()
        IDFirmenNameLabel4 = New System.Windows.Forms.Label()
        VornameLabel = New System.Windows.Forms.Label()
        NachnameLabel = New System.Windows.Forms.Label()
        AnredeLabel = New System.Windows.Forms.Label()
        EmailAddresseLabel = New System.Windows.Forms.Label()
        JobtitleLabel = New System.Windows.Forms.Label()
        TelefonGeschaeftlichLabel = New System.Windows.Forms.Label()
        TelefonPrivatLabel = New System.Windows.Forms.Label()
        MobiltelefonLabel = New System.Windows.Forms.Label()
        FaxnummerLabel = New System.Windows.Forms.Label()
        IDAdresseLabel2 = New System.Windows.Forms.Label()
        DWpfadLabel = New System.Windows.Forms.Label()
        DWDateinameLabel = New System.Windows.Forms.Label()
        InaktivLabel = New System.Windows.Forms.Label()
        HilfelinkLabel = New System.Windows.Forms.Label()
        CType(Me.KonfigurationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._WSL_AdressenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.SachbearbeiterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TC_Administration.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.FirmenNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.FirmenNameDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.KontoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KontoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        CType(Me.AdressenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.SachbearbeiterBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SachbearbeiterBindingNavigator.SuspendLayout()
        CType(Me.KontakteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Belege.SuspendLayout()
        CType(Me.BNAV_Belege, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BNAV_Belege.SuspendLayout()
        CType(Me.BelegeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BelegeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDFirmenNameLabel
        '
        IDFirmenNameLabel.AutoSize = True
        IDFirmenNameLabel.Location = New System.Drawing.Point(24, 119)
        IDFirmenNameLabel.Name = "IDFirmenNameLabel"
        IDFirmenNameLabel.Size = New System.Drawing.Size(83, 13)
        IDFirmenNameLabel.TabIndex = 2
        IDFirmenNameLabel.Text = "IDFirmen Name:"
        '
        'LeadnummerLabel
        '
        LeadnummerLabel.AutoSize = True
        LeadnummerLabel.Location = New System.Drawing.Point(36, 145)
        LeadnummerLabel.Name = "LeadnummerLabel"
        LeadnummerLabel.Size = New System.Drawing.Size(71, 13)
        LeadnummerLabel.TabIndex = 4
        LeadnummerLabel.Text = "Leadnummer:"
        '
        'KundennummerLabel
        '
        KundennummerLabel.AutoSize = True
        KundennummerLabel.Location = New System.Drawing.Point(23, 171)
        KundennummerLabel.Name = "KundennummerLabel"
        KundennummerLabel.Size = New System.Drawing.Size(84, 13)
        KundennummerLabel.TabIndex = 6
        KundennummerLabel.Text = "Kundennummer:"
        '
        'LieferantennummerLabel
        '
        LieferantennummerLabel.AutoSize = True
        LieferantennummerLabel.Location = New System.Drawing.Point(7, 197)
        LieferantennummerLabel.Name = "LieferantennummerLabel"
        LieferantennummerLabel.Size = New System.Drawing.Size(100, 13)
        LieferantennummerLabel.TabIndex = 8
        LieferantennummerLabel.Text = "Lieferantennummer:"
        '
        'IDAdresseLabel
        '
        IDAdresseLabel.AutoSize = True
        IDAdresseLabel.Location = New System.Drawing.Point(48, 223)
        IDAdresseLabel.Name = "IDAdresseLabel"
        IDAdresseLabel.Size = New System.Drawing.Size(59, 13)
        IDAdresseLabel.TabIndex = 10
        IDAdresseLabel.Text = "IDAdresse:"
        '
        'IDKontaktLabel
        '
        IDKontaktLabel.AutoSize = True
        IDKontaktLabel.Location = New System.Drawing.Point(49, 249)
        IDKontaktLabel.Name = "IDKontaktLabel"
        IDKontaktLabel.Size = New System.Drawing.Size(58, 13)
        IDKontaktLabel.TabIndex = 12
        IDKontaktLabel.Text = "IDKontakt:"
        '
        'IDBesuchLabel
        '
        IDBesuchLabel.AutoSize = True
        IDBesuchLabel.Location = New System.Drawing.Point(50, 275)
        IDBesuchLabel.Name = "IDBesuchLabel"
        IDBesuchLabel.Size = New System.Drawing.Size(48, 13)
        IDBesuchLabel.TabIndex = 14
        IDBesuchLabel.Text = "IDBeleg:"
        '
        'VorlagenpfadLabel
        '
        VorlagenpfadLabel.AutoSize = True
        VorlagenpfadLabel.Location = New System.Drawing.Point(34, 15)
        VorlagenpfadLabel.Name = "VorlagenpfadLabel"
        VorlagenpfadLabel.Size = New System.Drawing.Size(73, 13)
        VorlagenpfadLabel.TabIndex = 15
        VorlagenpfadLabel.Text = "Vorlagenpfad:"
        '
        'SachbearbeiterLabel
        '
        SachbearbeiterLabel.AutoSize = True
        SachbearbeiterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SachbearbeiterLabel.Location = New System.Drawing.Point(13, 33)
        SachbearbeiterLabel.Name = "SachbearbeiterLabel"
        SachbearbeiterLabel.Size = New System.Drawing.Size(82, 13)
        SachbearbeiterLabel.TabIndex = 25
        SachbearbeiterLabel.Text = "Sachbearbeiter:"
        '
        'AdminLabel
        '
        AdminLabel.AutoSize = True
        AdminLabel.Location = New System.Drawing.Point(492, 39)
        AdminLabel.Name = "AdminLabel"
        AdminLabel.Size = New System.Drawing.Size(70, 13)
        AdminLabel.TabIndex = 27
        AdminLabel.Text = "Administrator:"
        '
        'IDFirmenNameLabel1
        '
        IDFirmenNameLabel1.AutoSize = True
        IDFirmenNameLabel1.Location = New System.Drawing.Point(9, 11)
        IDFirmenNameLabel1.Name = "IDFirmenNameLabel1"
        IDFirmenNameLabel1.Size = New System.Drawing.Size(83, 13)
        IDFirmenNameLabel1.TabIndex = 1
        IDFirmenNameLabel1.Text = "IDFirmen Name:"
        '
        'FirmenNameLabel
        '
        FirmenNameLabel.AutoSize = True
        FirmenNameLabel.Location = New System.Drawing.Point(20, 37)
        FirmenNameLabel.Name = "FirmenNameLabel"
        FirmenNameLabel.Size = New System.Drawing.Size(72, 13)
        FirmenNameLabel.TabIndex = 3
        FirmenNameLabel.Text = "Firmen Name:"
        '
        'LoginLabel
        '
        LoginLabel.AutoSize = True
        LoginLabel.Location = New System.Drawing.Point(56, 63)
        LoginLabel.Name = "LoginLabel"
        LoginLabel.Size = New System.Drawing.Size(36, 13)
        LoginLabel.TabIndex = 5
        LoginLabel.Text = "Login:"
        '
        'ChangedLabel
        '
        ChangedLabel.AutoSize = True
        ChangedLabel.Location = New System.Drawing.Point(40, 90)
        ChangedLabel.Name = "ChangedLabel"
        ChangedLabel.Size = New System.Drawing.Size(52, 13)
        ChangedLabel.TabIndex = 7
        ChangedLabel.Text = "changed:"
        '
        'IDKontoLabel
        '
        IDKontoLabel.AutoSize = True
        IDKontoLabel.Location = New System.Drawing.Point(641, 10)
        IDKontoLabel.Name = "IDKontoLabel"
        IDKontoLabel.Size = New System.Drawing.Size(49, 13)
        IDKontoLabel.TabIndex = 1
        IDKontoLabel.Text = "IDKonto:"
        '
        'IDFirmenNameLabel2
        '
        IDFirmenNameLabel2.AutoSize = True
        IDFirmenNameLabel2.Location = New System.Drawing.Point(607, 36)
        IDFirmenNameLabel2.Name = "IDFirmenNameLabel2"
        IDFirmenNameLabel2.Size = New System.Drawing.Size(83, 13)
        IDFirmenNameLabel2.TabIndex = 3
        IDFirmenNameLabel2.Text = "IDFirmen Name:"
        '
        'KontoNameLabel
        '
        KontoNameLabel.AutoSize = True
        KontoNameLabel.Location = New System.Drawing.Point(621, 62)
        KontoNameLabel.Name = "KontoNameLabel"
        KontoNameLabel.Size = New System.Drawing.Size(69, 13)
        KontoNameLabel.TabIndex = 5
        KontoNameLabel.Text = "Konto Name:"
        '
        'AnlageDatumLabel
        '
        AnlageDatumLabel.AutoSize = True
        AnlageDatumLabel.Location = New System.Drawing.Point(613, 89)
        AnlageDatumLabel.Name = "AnlageDatumLabel"
        AnlageDatumLabel.Size = New System.Drawing.Size(77, 13)
        AnlageDatumLabel.TabIndex = 7
        AnlageDatumLabel.Text = "Anlage Datum:"
        '
        'IDAdresseLabel1
        '
        IDAdresseLabel1.AutoSize = True
        IDAdresseLabel1.Location = New System.Drawing.Point(27, 7)
        IDAdresseLabel1.Name = "IDAdresseLabel1"
        IDAdresseLabel1.Size = New System.Drawing.Size(59, 13)
        IDAdresseLabel1.TabIndex = 1
        IDAdresseLabel1.Text = "IDAdresse:"
        '
        'IDFirmenNameLabel3
        '
        IDFirmenNameLabel3.AutoSize = True
        IDFirmenNameLabel3.Location = New System.Drawing.Point(3, 59)
        IDFirmenNameLabel3.Name = "IDFirmenNameLabel3"
        IDFirmenNameLabel3.Size = New System.Drawing.Size(83, 13)
        IDFirmenNameLabel3.TabIndex = 3
        IDFirmenNameLabel3.Text = "IDFirmen Name:"
        '
        'IDKontoLabel1
        '
        IDKontoLabel1.AutoSize = True
        IDKontoLabel1.Location = New System.Drawing.Point(37, 33)
        IDKontoLabel1.Name = "IDKontoLabel1"
        IDKontoLabel1.Size = New System.Drawing.Size(49, 13)
        IDKontoLabel1.TabIndex = 5
        IDKontoLabel1.Text = "IDKonto:"
        '
        'AdresstypLabel
        '
        AdresstypLabel.AutoSize = True
        AdresstypLabel.Location = New System.Drawing.Point(206, 7)
        AdresstypLabel.Name = "AdresstypLabel"
        AdresstypLabel.Size = New System.Drawing.Size(56, 13)
        AdresstypLabel.TabIndex = 7
        AdresstypLabel.Text = "Adresstyp:"
        '
        'StraßeLabel
        '
        StraßeLabel.AutoSize = True
        StraßeLabel.Location = New System.Drawing.Point(407, 33)
        StraßeLabel.Name = "StraßeLabel"
        StraßeLabel.Size = New System.Drawing.Size(41, 13)
        StraßeLabel.TabIndex = 9
        StraßeLabel.Text = "Straße:"
        '
        'PostfachLabel
        '
        PostfachLabel.AutoSize = True
        PostfachLabel.Location = New System.Drawing.Point(396, 8)
        PostfachLabel.Name = "PostfachLabel"
        PostfachLabel.Size = New System.Drawing.Size(52, 13)
        PostfachLabel.TabIndex = 11
        PostfachLabel.Text = "Postfach:"
        '
        'PLZLabel
        '
        PLZLabel.AutoSize = True
        PLZLabel.Location = New System.Drawing.Point(418, 59)
        PLZLabel.Name = "PLZLabel"
        PLZLabel.Size = New System.Drawing.Size(30, 13)
        PLZLabel.TabIndex = 13
        PLZLabel.Text = "PLZ:"
        '
        'OrtLabel
        '
        OrtLabel.AutoSize = True
        OrtLabel.Location = New System.Drawing.Point(542, 59)
        OrtLabel.Name = "OrtLabel"
        OrtLabel.Size = New System.Drawing.Size(24, 13)
        OrtLabel.TabIndex = 15
        OrtLabel.Text = "Ort:"
        '
        'BundeslandLabel
        '
        BundeslandLabel.AutoSize = True
        BundeslandLabel.Location = New System.Drawing.Point(723, 9)
        BundeslandLabel.Name = "BundeslandLabel"
        BundeslandLabel.Size = New System.Drawing.Size(66, 13)
        BundeslandLabel.TabIndex = 17
        BundeslandLabel.Text = "Bundesland:"
        '
        'LandLabel
        '
        LandLabel.AutoSize = True
        LandLabel.Location = New System.Drawing.Point(911, 7)
        LandLabel.Name = "LandLabel"
        LandLabel.Size = New System.Drawing.Size(34, 13)
        LandLabel.TabIndex = 19
        LandLabel.Text = "Land:"
        '
        'UStIdNrLabel
        '
        UStIdNrLabel.AutoSize = True
        UStIdNrLabel.Location = New System.Drawing.Point(208, 33)
        UStIdNrLabel.Name = "UStIdNrLabel"
        UStIdNrLabel.Size = New System.Drawing.Size(54, 13)
        UStIdNrLabel.TabIndex = 21
        UStIdNrLabel.Text = "USt Id Nr:"
        '
        'WebseiteLabel
        '
        WebseiteLabel.AutoSize = True
        WebseiteLabel.Location = New System.Drawing.Point(734, 33)
        WebseiteLabel.Name = "WebseiteLabel"
        WebseiteLabel.Size = New System.Drawing.Size(55, 13)
        WebseiteLabel.TabIndex = 23
        WebseiteLabel.Text = "Webseite:"
        '
        'IDKontaktLabel1
        '
        IDKontaktLabel1.AutoSize = True
        IDKontaktLabel1.Location = New System.Drawing.Point(34, 9)
        IDKontaktLabel1.Name = "IDKontaktLabel1"
        IDKontaktLabel1.Size = New System.Drawing.Size(58, 13)
        IDKontaktLabel1.TabIndex = 2
        IDKontaktLabel1.Text = "IDKontakt:"
        '
        'IDFirmenNameLabel4
        '
        IDFirmenNameLabel4.AutoSize = True
        IDFirmenNameLabel4.Location = New System.Drawing.Point(5, 35)
        IDFirmenNameLabel4.Name = "IDFirmenNameLabel4"
        IDFirmenNameLabel4.Size = New System.Drawing.Size(83, 13)
        IDFirmenNameLabel4.TabIndex = 3
        IDFirmenNameLabel4.Text = "IDFirmen-Name:"
        '
        'VornameLabel
        '
        VornameLabel.AutoSize = True
        VornameLabel.Location = New System.Drawing.Point(231, 60)
        VornameLabel.Name = "VornameLabel"
        VornameLabel.Size = New System.Drawing.Size(52, 13)
        VornameLabel.TabIndex = 5
        VornameLabel.Text = "Vorname:"
        '
        'NachnameLabel
        '
        NachnameLabel.AutoSize = True
        NachnameLabel.Location = New System.Drawing.Point(217, 34)
        NachnameLabel.Name = "NachnameLabel"
        NachnameLabel.Size = New System.Drawing.Size(62, 13)
        NachnameLabel.TabIndex = 7
        NachnameLabel.Text = "Nachname:"
        '
        'AnredeLabel
        '
        AnredeLabel.AutoSize = True
        AnredeLabel.Location = New System.Drawing.Point(239, 9)
        AnredeLabel.Name = "AnredeLabel"
        AnredeLabel.Size = New System.Drawing.Size(44, 13)
        AnredeLabel.TabIndex = 9
        AnredeLabel.Text = "Anrede:"
        '
        'EmailAddresseLabel
        '
        EmailAddresseLabel.AutoSize = True
        EmailAddresseLabel.Location = New System.Drawing.Point(445, 35)
        EmailAddresseLabel.Name = "EmailAddresseLabel"
        EmailAddresseLabel.Size = New System.Drawing.Size(35, 13)
        EmailAddresseLabel.TabIndex = 11
        EmailAddresseLabel.Text = "Email:"
        '
        'JobtitleLabel
        '
        JobtitleLabel.AutoSize = True
        JobtitleLabel.Location = New System.Drawing.Point(439, 9)
        JobtitleLabel.Name = "JobtitleLabel"
        JobtitleLabel.Size = New System.Drawing.Size(43, 13)
        JobtitleLabel.TabIndex = 13
        JobtitleLabel.Text = "Jobtitle:"
        '
        'TelefonGeschaeftlichLabel
        '
        TelefonGeschaeftlichLabel.AutoSize = True
        TelefonGeschaeftlichLabel.Location = New System.Drawing.Point(629, 8)
        TelefonGeschaeftlichLabel.Name = "TelefonGeschaeftlichLabel"
        TelefonGeschaeftlichLabel.Size = New System.Drawing.Size(84, 13)
        TelefonGeschaeftlichLabel.TabIndex = 15
        TelefonGeschaeftlichLabel.Text = "Telefon (gesch):"
        '
        'TelefonPrivatLabel
        '
        TelefonPrivatLabel.AutoSize = True
        TelefonPrivatLabel.Location = New System.Drawing.Point(633, 34)
        TelefonPrivatLabel.Name = "TelefonPrivatLabel"
        TelefonPrivatLabel.Size = New System.Drawing.Size(76, 13)
        TelefonPrivatLabel.TabIndex = 17
        TelefonPrivatLabel.Text = "Telefon Privat:"
        '
        'MobiltelefonLabel
        '
        MobiltelefonLabel.AutoSize = True
        MobiltelefonLabel.Location = New System.Drawing.Point(645, 60)
        MobiltelefonLabel.Name = "MobiltelefonLabel"
        MobiltelefonLabel.Size = New System.Drawing.Size(67, 13)
        MobiltelefonLabel.TabIndex = 19
        MobiltelefonLabel.Text = "Mobiltelefon:"
        '
        'FaxnummerLabel
        '
        FaxnummerLabel.AutoSize = True
        FaxnummerLabel.Location = New System.Drawing.Point(645, 86)
        FaxnummerLabel.Name = "FaxnummerLabel"
        FaxnummerLabel.Size = New System.Drawing.Size(64, 13)
        FaxnummerLabel.TabIndex = 21
        FaxnummerLabel.Text = "Faxnummer:"
        '
        'IDAdresseLabel2
        '
        IDAdresseLabel2.AutoSize = True
        IDAdresseLabel2.Location = New System.Drawing.Point(29, 61)
        IDAdresseLabel2.Name = "IDAdresseLabel2"
        IDAdresseLabel2.Size = New System.Drawing.Size(59, 13)
        IDAdresseLabel2.TabIndex = 23
        IDAdresseLabel2.Text = "IDAdresse:"
        '
        'DWpfadLabel
        '
        DWpfadLabel.AutoSize = True
        DWpfadLabel.Location = New System.Drawing.Point(17, 41)
        DWpfadLabel.Name = "DWpfadLabel"
        DWpfadLabel.Size = New System.Drawing.Size(86, 13)
        DWpfadLabel.TabIndex = 18
        DWpfadLabel.Text = "DocuWare pfad:"
        '
        'DWDateinameLabel
        '
        DWDateinameLabel.AutoSize = True
        DWDateinameLabel.Location = New System.Drawing.Point(23, 67)
        DWDateinameLabel.Name = "DWDateinameLabel"
        DWDateinameLabel.Size = New System.Drawing.Size(83, 13)
        DWDateinameLabel.TabIndex = 20
        DWDateinameLabel.Text = "DW-Dateiname:"
        '
        'InaktivLabel
        '
        InaktivLabel.AutoSize = True
        InaktivLabel.Location = New System.Drawing.Point(51, 117)
        InaktivLabel.Name = "InaktivLabel"
        InaktivLabel.Size = New System.Drawing.Size(41, 13)
        InaktivLabel.TabIndex = 10
        InaktivLabel.Text = "inaktiv:"
        '
        'VorlagenpfadTextBox
        '
        Me.VorlagenpfadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationBindingSource, "Vorlagenpfad", True))
        Me.VorlagenpfadTextBox.Location = New System.Drawing.Point(113, 12)
        Me.VorlagenpfadTextBox.Name = "VorlagenpfadTextBox"
        Me.VorlagenpfadTextBox.Size = New System.Drawing.Size(457, 20)
        Me.VorlagenpfadTextBox.TabIndex = 16
        '
        'KonfigurationBindingSource
        '
        Me.KonfigurationBindingSource.DataMember = "Konfiguration"
        Me.KonfigurationBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        '_WSL_AdressenDataSet
        '
        Me._WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet"
        Me._WSL_AdressenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDBesuchTextBox
        '
        Me.IDBesuchTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationBindingSource, "IDBeleg", True))
        Me.IDBesuchTextBox.Location = New System.Drawing.Point(113, 272)
        Me.IDBesuchTextBox.Name = "IDBesuchTextBox"
        Me.IDBesuchTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDBesuchTextBox.TabIndex = 15
        '
        'IDKontaktTextBox
        '
        Me.IDKontaktTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationBindingSource, "IDKontakt", True))
        Me.IDKontaktTextBox.Location = New System.Drawing.Point(113, 246)
        Me.IDKontaktTextBox.Name = "IDKontaktTextBox"
        Me.IDKontaktTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDKontaktTextBox.TabIndex = 13
        '
        'IDAdresseTextBox
        '
        Me.IDAdresseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationBindingSource, "IDAdresse", True))
        Me.IDAdresseTextBox.Location = New System.Drawing.Point(113, 220)
        Me.IDAdresseTextBox.Name = "IDAdresseTextBox"
        Me.IDAdresseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDAdresseTextBox.TabIndex = 11
        '
        'LieferantennummerTextBox
        '
        Me.LieferantennummerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationBindingSource, "Lieferantennummer", True))
        Me.LieferantennummerTextBox.Location = New System.Drawing.Point(113, 194)
        Me.LieferantennummerTextBox.Name = "LieferantennummerTextBox"
        Me.LieferantennummerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LieferantennummerTextBox.TabIndex = 9
        '
        'KundennummerTextBox
        '
        Me.KundennummerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationBindingSource, "Kundennummer", True))
        Me.KundennummerTextBox.Location = New System.Drawing.Point(113, 168)
        Me.KundennummerTextBox.Name = "KundennummerTextBox"
        Me.KundennummerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KundennummerTextBox.TabIndex = 7
        '
        'LeadnummerTextBox
        '
        Me.LeadnummerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationBindingSource, "Leadnummer", True))
        Me.LeadnummerTextBox.Location = New System.Drawing.Point(113, 142)
        Me.LeadnummerTextBox.Name = "LeadnummerTextBox"
        Me.LeadnummerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LeadnummerTextBox.TabIndex = 5
        '
        'IDFirmenNameTextBox
        '
        Me.IDFirmenNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationBindingSource, "IDFirmenName", True))
        Me.IDFirmenNameTextBox.Location = New System.Drawing.Point(113, 116)
        Me.IDFirmenNameTextBox.Name = "IDFirmenNameTextBox"
        Me.IDFirmenNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDFirmenNameTextBox.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.AdminCheckBox)
        Me.Panel2.Controls.Add(AdminLabel)
        Me.Panel2.Controls.Add(Me.SachbearbeiterLabel1)
        Me.Panel2.Controls.Add(Me.BTN_Alle)
        Me.Panel2.Controls.Add(SachbearbeiterLabel)
        Me.Panel2.Controls.Add(Me.BTN_Aktuell)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1062, 61)
        Me.Panel2.TabIndex = 25
        '
        'BTN_Alle
        '
        Me.BTN_Alle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Alle.Enabled = False
        Me.BTN_Alle.Location = New System.Drawing.Point(821, 6)
        Me.BTN_Alle.Name = "BTN_Alle"
        Me.BTN_Alle.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Alle.TabIndex = 2
        Me.BTN_Alle.Text = "alle"
        Me.BTN_Alle.UseVisualStyleBackColor = True
        '
        'BTN_Aktuell
        '
        Me.BTN_Aktuell.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Aktuell.Enabled = False
        Me.BTN_Aktuell.Location = New System.Drawing.Point(902, 6)
        Me.BTN_Aktuell.Name = "BTN_Aktuell"
        Me.BTN_Aktuell.Size = New System.Drawing.Size(156, 23)
        Me.BTN_Aktuell.TabIndex = 1
        Me.BTN_Aktuell.Text = "Aktuellen Geschäftspartner"
        Me.BTN_Aktuell.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Administration"
        '
        'SachbearbeiterLabel1
        '
        Me.SachbearbeiterLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "Sachbearbeiter", True))
        Me.SachbearbeiterLabel1.Location = New System.Drawing.Point(101, 29)
        Me.SachbearbeiterLabel1.Name = "SachbearbeiterLabel1"
        Me.SachbearbeiterLabel1.Size = New System.Drawing.Size(385, 22)
        Me.SachbearbeiterLabel1.TabIndex = 26
        Me.SachbearbeiterLabel1.Text = "Vorname Name"
        Me.SachbearbeiterLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SachbearbeiterBindingSource
        '
        Me.SachbearbeiterBindingSource.DataMember = "Sachbearbeiter"
        Me.SachbearbeiterBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'AdminCheckBox
        '
        Me.AdminCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SachbearbeiterBindingSource, "Admin", True))
        Me.AdminCheckBox.Enabled = False
        Me.AdminCheckBox.Location = New System.Drawing.Point(568, 33)
        Me.AdminCheckBox.Name = "AdminCheckBox"
        Me.AdminCheckBox.Size = New System.Drawing.Size(16, 24)
        Me.AdminCheckBox.TabIndex = 28
        Me.AdminCheckBox.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Controls.Add(Me.BTN_Schliessen)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 465)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1062, 43)
        Me.Panel3.TabIndex = 26
        '
        'BTN_Schliessen
        '
        Me.BTN_Schliessen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Schliessen.Image = CType(resources.GetObject("BTN_Schliessen.Image"), System.Drawing.Image)
        Me.BTN_Schliessen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Schliessen.Location = New System.Drawing.Point(978, 10)
        Me.BTN_Schliessen.Name = "BTN_Schliessen"
        Me.BTN_Schliessen.Size = New System.Drawing.Size(80, 23)
        Me.BTN_Schliessen.TabIndex = 16
        Me.BTN_Schliessen.Text = "Schließen"
        Me.BTN_Schliessen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Schliessen.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdressenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BelegeTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.FirmenNameTableAdapter = Nothing
        Me.TableAdapterManager.KonfigurationTableAdapter = Nothing
        Me.TableAdapterManager.KontakteTableAdapter = Nothing
        Me.TableAdapterManager.KontoTableAdapter = Nothing
        Me.TableAdapterManager.LogTabelleTableAdapter = Nothing
        Me.TableAdapterManager.SachbearbeiterTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KonfigurationTableAdapter
        '
        Me.KonfigurationTableAdapter.ClearBeforeFill = True
        '
        'SachbearbeiterTableAdapter
        '
        Me.SachbearbeiterTableAdapter.ClearBeforeFill = True
        '
        'TC_Administration
        '
        Me.TC_Administration.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TC_Administration.Controls.Add(Me.TabPage1)
        Me.TC_Administration.Controls.Add(Me.TabPage2)
        Me.TC_Administration.Controls.Add(Me.TabPage3)
        Me.TC_Administration.Controls.Add(Me.TabPage4)
        Me.TC_Administration.Controls.Add(Me.TabPage5)
        Me.TC_Administration.Controls.Add(Me.Belege)
        Me.TC_Administration.Location = New System.Drawing.Point(3, 70)
        Me.TC_Administration.Name = "TC_Administration"
        Me.TC_Administration.SelectedIndex = 0
        Me.TC_Administration.Size = New System.Drawing.Size(1062, 389)
        Me.TC_Administration.TabIndex = 30
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(HilfelinkLabel)
        Me.TabPage1.Controls.Add(Me.HilfelinkTextBox)
        Me.TabPage1.Controls.Add(Me.BTN_DWPfad)
        Me.TabPage1.Controls.Add(DWDateinameLabel)
        Me.TabPage1.Controls.Add(Me.DWDateinameTextBox)
        Me.TabPage1.Controls.Add(DWpfadLabel)
        Me.TabPage1.Controls.Add(Me.DWpfadTextBox)
        Me.TabPage1.Controls.Add(Me.BTN_Speichern)
        Me.TabPage1.Controls.Add(VorlagenpfadLabel)
        Me.TabPage1.Controls.Add(Me.LeadnummerTextBox)
        Me.TabPage1.Controls.Add(Me.VorlagenpfadTextBox)
        Me.TabPage1.Controls.Add(Me.BTN_Vorlagenpfad)
        Me.TabPage1.Controls.Add(IDBesuchLabel)
        Me.TabPage1.Controls.Add(Me.IDFirmenNameTextBox)
        Me.TabPage1.Controls.Add(Me.IDBesuchTextBox)
        Me.TabPage1.Controls.Add(IDFirmenNameLabel)
        Me.TabPage1.Controls.Add(IDKontaktLabel)
        Me.TabPage1.Controls.Add(LeadnummerLabel)
        Me.TabPage1.Controls.Add(Me.IDKontaktTextBox)
        Me.TabPage1.Controls.Add(Me.KundennummerTextBox)
        Me.TabPage1.Controls.Add(IDAdresseLabel)
        Me.TabPage1.Controls.Add(KundennummerLabel)
        Me.TabPage1.Controls.Add(Me.IDAdresseTextBox)
        Me.TabPage1.Controls.Add(Me.LieferantennummerTextBox)
        Me.TabPage1.Controls.Add(LieferantennummerLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1054, 363)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Konfiguration"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BTN_DWPfad
        '
        Me.BTN_DWPfad.Image = Global.Adress_DB.My.Resources.Resources.DocumentsFolder_16x
        Me.BTN_DWPfad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_DWPfad.Location = New System.Drawing.Point(576, 38)
        Me.BTN_DWPfad.Name = "BTN_DWPfad"
        Me.BTN_DWPfad.Size = New System.Drawing.Size(138, 23)
        Me.BTN_DWPfad.TabIndex = 22
        Me.BTN_DWPfad.Text = "DW-Pfad ändern"
        Me.BTN_DWPfad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_DWPfad.UseVisualStyleBackColor = True
        '
        'DWDateinameTextBox
        '
        Me.DWDateinameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationBindingSource, "DWDateiname", True))
        Me.DWDateinameTextBox.Location = New System.Drawing.Point(113, 64)
        Me.DWDateinameTextBox.Name = "DWDateinameTextBox"
        Me.DWDateinameTextBox.Size = New System.Drawing.Size(230, 20)
        Me.DWDateinameTextBox.TabIndex = 21
        '
        'DWpfadTextBox
        '
        Me.DWpfadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationBindingSource, "DWpfad", True))
        Me.DWpfadTextBox.Location = New System.Drawing.Point(113, 38)
        Me.DWpfadTextBox.Name = "DWpfadTextBox"
        Me.DWpfadTextBox.Size = New System.Drawing.Size(457, 20)
        Me.DWpfadTextBox.TabIndex = 19
        '
        'BTN_Speichern
        '
        Me.BTN_Speichern.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Speichern.Image = CType(resources.GetObject("BTN_Speichern.Image"), System.Drawing.Image)
        Me.BTN_Speichern.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Speichern.Location = New System.Drawing.Point(911, 318)
        Me.BTN_Speichern.Name = "BTN_Speichern"
        Me.BTN_Speichern.Size = New System.Drawing.Size(80, 23)
        Me.BTN_Speichern.TabIndex = 17
        Me.BTN_Speichern.Text = "speichern"
        Me.BTN_Speichern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Speichern.UseVisualStyleBackColor = True
        '
        'BTN_Vorlagenpfad
        '
        Me.BTN_Vorlagenpfad.Image = Global.Adress_DB.My.Resources.Resources.DocumentsFolder_16x
        Me.BTN_Vorlagenpfad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Vorlagenpfad.Location = New System.Drawing.Point(576, 10)
        Me.BTN_Vorlagenpfad.Name = "BTN_Vorlagenpfad"
        Me.BTN_Vorlagenpfad.Size = New System.Drawing.Size(138, 23)
        Me.BTN_Vorlagenpfad.TabIndex = 2
        Me.BTN_Vorlagenpfad.Text = "Vorlagenpfad ändern"
        Me.BTN_Vorlagenpfad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Vorlagenpfad.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(InaktivLabel)
        Me.TabPage2.Controls.Add(Me.InaktivCheckBox)
        Me.TabPage2.Controls.Add(Me.BindingNavigator1)
        Me.TabPage2.Controls.Add(ChangedLabel)
        Me.TabPage2.Controls.Add(Me.ChangedDateTimePicker)
        Me.TabPage2.Controls.Add(LoginLabel)
        Me.TabPage2.Controls.Add(Me.LoginTextBox)
        Me.TabPage2.Controls.Add(FirmenNameLabel)
        Me.TabPage2.Controls.Add(Me.FirmenNameTextBox)
        Me.TabPage2.Controls.Add(IDFirmenNameLabel1)
        Me.TabPage2.Controls.Add(Me.IDFirmenNameTextBox1)
        Me.TabPage2.Controls.Add(Me.FirmenNameDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1058, 291)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "FirmenName"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'InaktivCheckBox
        '
        Me.InaktivCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.FirmenNameBindingSource, "inaktiv", True))
        Me.InaktivCheckBox.Location = New System.Drawing.Point(98, 112)
        Me.InaktivCheckBox.Name = "InaktivCheckBox"
        Me.InaktivCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.InaktivCheckBox.TabIndex = 11
        Me.InaktivCheckBox.Text = "Geschäftspartner deaktivieren"
        Me.InaktivCheckBox.UseVisualStyleBackColor = True
        '
        'FirmenNameBindingSource
        '
        Me.FirmenNameBindingSource.DataMember = "FirmenName"
        Me.FirmenNameBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.ToolStripButton21
        Me.BindingNavigator1.BindingSource = Me.FirmenNameBindingSource
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel4
        Me.BindingNavigator1.DeleteItem = Me.ToolStripButton22
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton23, Me.ToolStripButton24, Me.ToolStripSeparator10, Me.ToolStripTextBox4, Me.ToolStripLabel4, Me.ToolStripSeparator11, Me.ToolStripButton25, Me.ToolStripButton26, Me.ToolStripSeparator12, Me.ToolStripButton21, Me.ToolStripButton22, Me.BNAV_FirmenNameSave})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 263)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton23
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton26
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton25
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton24
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox4
        Me.BindingNavigator1.Size = New System.Drawing.Size(1052, 25)
        Me.BindingNavigator1.TabIndex = 10
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripButton21
        '
        Me.ToolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton21.Image = CType(resources.GetObject("ToolStripButton21.Image"), System.Drawing.Image)
        Me.ToolStripButton21.Name = "ToolStripButton21"
        Me.ToolStripButton21.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton21.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton21.Text = "Neu hinzufügen"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripLabel4.Text = "von {0}"
        Me.ToolStripLabel4.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'ToolStripButton22
        '
        Me.ToolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton22.Image = CType(resources.GetObject("ToolStripButton22.Image"), System.Drawing.Image)
        Me.ToolStripButton22.Name = "ToolStripButton22"
        Me.ToolStripButton22.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton22.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton22.Text = "Löschen"
        '
        'ToolStripButton23
        '
        Me.ToolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton23.Image = CType(resources.GetObject("ToolStripButton23.Image"), System.Drawing.Image)
        Me.ToolStripButton23.Name = "ToolStripButton23"
        Me.ToolStripButton23.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton23.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton23.Text = "Erste verschieben"
        '
        'ToolStripButton24
        '
        Me.ToolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton24.Image = CType(resources.GetObject("ToolStripButton24.Image"), System.Drawing.Image)
        Me.ToolStripButton24.Name = "ToolStripButton24"
        Me.ToolStripButton24.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton24.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton24.Text = "Vorherige verschieben"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.AccessibleName = "Position"
        Me.ToolStripTextBox4.AutoSize = False
        Me.ToolStripTextBox4.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(50, 25)
        Me.ToolStripTextBox4.Text = "0"
        Me.ToolStripTextBox4.ToolTipText = "Aktuelle Position"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton25
        '
        Me.ToolStripButton25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton25.Image = CType(resources.GetObject("ToolStripButton25.Image"), System.Drawing.Image)
        Me.ToolStripButton25.Name = "ToolStripButton25"
        Me.ToolStripButton25.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton25.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton25.Text = "Nächste verschieben"
        '
        'ToolStripButton26
        '
        Me.ToolStripButton26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton26.Image = CType(resources.GetObject("ToolStripButton26.Image"), System.Drawing.Image)
        Me.ToolStripButton26.Name = "ToolStripButton26"
        Me.ToolStripButton26.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton26.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton26.Text = "Letzte verschieben"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'BNAV_FirmenNameSave
        '
        Me.BNAV_FirmenNameSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BNAV_FirmenNameSave.Image = CType(resources.GetObject("BNAV_FirmenNameSave.Image"), System.Drawing.Image)
        Me.BNAV_FirmenNameSave.Name = "BNAV_FirmenNameSave"
        Me.BNAV_FirmenNameSave.Size = New System.Drawing.Size(23, 22)
        Me.BNAV_FirmenNameSave.Text = "Daten speichern"
        '
        'ChangedDateTimePicker
        '
        Me.ChangedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FirmenNameBindingSource, "changed", True))
        Me.ChangedDateTimePicker.Location = New System.Drawing.Point(98, 86)
        Me.ChangedDateTimePicker.Name = "ChangedDateTimePicker"
        Me.ChangedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ChangedDateTimePicker.TabIndex = 8
        '
        'LoginTextBox
        '
        Me.LoginTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FirmenNameBindingSource, "Login", True))
        Me.LoginTextBox.Location = New System.Drawing.Point(98, 60)
        Me.LoginTextBox.Name = "LoginTextBox"
        Me.LoginTextBox.Size = New System.Drawing.Size(349, 20)
        Me.LoginTextBox.TabIndex = 6
        '
        'FirmenNameTextBox
        '
        Me.FirmenNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FirmenNameBindingSource, "FirmenName", True))
        Me.FirmenNameTextBox.Location = New System.Drawing.Point(98, 34)
        Me.FirmenNameTextBox.Name = "FirmenNameTextBox"
        Me.FirmenNameTextBox.Size = New System.Drawing.Size(349, 20)
        Me.FirmenNameTextBox.TabIndex = 4
        '
        'IDFirmenNameTextBox1
        '
        Me.IDFirmenNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FirmenNameBindingSource, "IDFirmenName", True))
        Me.IDFirmenNameTextBox1.Location = New System.Drawing.Point(98, 8)
        Me.IDFirmenNameTextBox1.Name = "IDFirmenNameTextBox1"
        Me.IDFirmenNameTextBox1.Size = New System.Drawing.Size(349, 20)
        Me.IDFirmenNameTextBox1.TabIndex = 2
        '
        'FirmenNameDataGridView
        '
        Me.FirmenNameDataGridView.AutoGenerateColumns = False
        Me.FirmenNameDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.FirmenNameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FirmenNameDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Login, Me.changed, Me.inaktiv})
        Me.FirmenNameDataGridView.DataSource = Me.FirmenNameBindingSource
        Me.FirmenNameDataGridView.Location = New System.Drawing.Point(453, 6)
        Me.FirmenNameDataGridView.Name = "FirmenNameDataGridView"
        Me.FirmenNameDataGridView.RowHeadersVisible = False
        Me.FirmenNameDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FirmenNameDataGridView.Size = New System.Drawing.Size(597, 254)
        Me.FirmenNameDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDFirmenName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDFirmenName"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirmenName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Firmen-Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 220
        '
        'Login
        '
        Me.Login.DataPropertyName = "Login"
        Me.Login.HeaderText = "Login"
        Me.Login.Name = "Login"
        Me.Login.Width = 70
        '
        'changed
        '
        Me.changed.DataPropertyName = "changed"
        Me.changed.HeaderText = "changed"
        Me.changed.Name = "changed"
        Me.changed.Width = 180
        '
        'inaktiv
        '
        Me.inaktiv.DataPropertyName = "inaktiv"
        Me.inaktiv.HeaderText = "inaktiv"
        Me.inaktiv.Name = "inaktiv"
        Me.inaktiv.Width = 50
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.BindingNavigator2)
        Me.TabPage3.Controls.Add(AnlageDatumLabel)
        Me.TabPage3.Controls.Add(Me.AnlageDatumDateTimePicker)
        Me.TabPage3.Controls.Add(KontoNameLabel)
        Me.TabPage3.Controls.Add(Me.KontoNameTextBox)
        Me.TabPage3.Controls.Add(IDFirmenNameLabel2)
        Me.TabPage3.Controls.Add(Me.IDFirmenNameTextBox2)
        Me.TabPage3.Controls.Add(IDKontoLabel)
        Me.TabPage3.Controls.Add(Me.IDKontoTextBox)
        Me.TabPage3.Controls.Add(Me.KontoDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1058, 291)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Konto"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.ToolStripButton14
        Me.BindingNavigator2.BindingSource = Me.KontoBindingSource
        Me.BindingNavigator2.CountItem = Me.ToolStripLabel3
        Me.BindingNavigator2.DeleteItem = Me.ToolStripButton15
        Me.BindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton16, Me.ToolStripButton17, Me.ToolStripSeparator7, Me.ToolStripTextBox3, Me.ToolStripLabel3, Me.ToolStripSeparator8, Me.ToolStripButton18, Me.ToolStripButton19, Me.ToolStripSeparator9, Me.ToolStripButton14, Me.ToolStripButton15, Me.BNAV_KontoSave})
        Me.BindingNavigator2.Location = New System.Drawing.Point(3, 263)
        Me.BindingNavigator2.MoveFirstItem = Me.ToolStripButton16
        Me.BindingNavigator2.MoveLastItem = Me.ToolStripButton19
        Me.BindingNavigator2.MoveNextItem = Me.ToolStripButton18
        Me.BindingNavigator2.MovePreviousItem = Me.ToolStripButton17
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.ToolStripTextBox3
        Me.BindingNavigator2.Size = New System.Drawing.Size(1052, 25)
        Me.BindingNavigator2.TabIndex = 9
        Me.BindingNavigator2.Text = "BindingNavigator1"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton14.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton14.Text = "Neu hinzufügen"
        '
        'KontoBindingSource
        '
        Me.KontoBindingSource.DataMember = "Konto"
        Me.KontoBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripLabel3.Text = "von {0}"
        Me.ToolStripLabel3.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), System.Drawing.Image)
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton15.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton15.Text = "Löschen"
        '
        'ToolStripButton16
        '
        Me.ToolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton16.Image = CType(resources.GetObject("ToolStripButton16.Image"), System.Drawing.Image)
        Me.ToolStripButton16.Name = "ToolStripButton16"
        Me.ToolStripButton16.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton16.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton16.Text = "Erste verschieben"
        '
        'ToolStripButton17
        '
        Me.ToolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton17.Image = CType(resources.GetObject("ToolStripButton17.Image"), System.Drawing.Image)
        Me.ToolStripButton17.Name = "ToolStripButton17"
        Me.ToolStripButton17.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton17.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton17.Text = "Vorherige verschieben"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.AccessibleName = "Position"
        Me.ToolStripTextBox3.AutoSize = False
        Me.ToolStripTextBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(50, 25)
        Me.ToolStripTextBox3.Text = "0"
        Me.ToolStripTextBox3.ToolTipText = "Aktuelle Position"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton18
        '
        Me.ToolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton18.Image = CType(resources.GetObject("ToolStripButton18.Image"), System.Drawing.Image)
        Me.ToolStripButton18.Name = "ToolStripButton18"
        Me.ToolStripButton18.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton18.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton18.Text = "Nächste verschieben"
        '
        'ToolStripButton19
        '
        Me.ToolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton19.Image = CType(resources.GetObject("ToolStripButton19.Image"), System.Drawing.Image)
        Me.ToolStripButton19.Name = "ToolStripButton19"
        Me.ToolStripButton19.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton19.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton19.Text = "Letzte verschieben"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'BNAV_KontoSave
        '
        Me.BNAV_KontoSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BNAV_KontoSave.Image = CType(resources.GetObject("BNAV_KontoSave.Image"), System.Drawing.Image)
        Me.BNAV_KontoSave.Name = "BNAV_KontoSave"
        Me.BNAV_KontoSave.Size = New System.Drawing.Size(23, 22)
        Me.BNAV_KontoSave.Text = "Daten speichern"
        '
        'AnlageDatumDateTimePicker
        '
        Me.AnlageDatumDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.KontoBindingSource, "Datum", True))
        Me.AnlageDatumDateTimePicker.Location = New System.Drawing.Point(696, 85)
        Me.AnlageDatumDateTimePicker.Name = "AnlageDatumDateTimePicker"
        Me.AnlageDatumDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.AnlageDatumDateTimePicker.TabIndex = 8
        '
        'KontoNameTextBox
        '
        Me.KontoNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontoBindingSource, "KontoName", True))
        Me.KontoNameTextBox.Location = New System.Drawing.Point(696, 59)
        Me.KontoNameTextBox.Name = "KontoNameTextBox"
        Me.KontoNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KontoNameTextBox.TabIndex = 6
        '
        'IDFirmenNameTextBox2
        '
        Me.IDFirmenNameTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontoBindingSource, "IDFirmenName", True))
        Me.IDFirmenNameTextBox2.Location = New System.Drawing.Point(696, 33)
        Me.IDFirmenNameTextBox2.Name = "IDFirmenNameTextBox2"
        Me.IDFirmenNameTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.IDFirmenNameTextBox2.TabIndex = 4
        '
        'IDKontoTextBox
        '
        Me.IDKontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontoBindingSource, "IDKonto", True))
        Me.IDKontoTextBox.Location = New System.Drawing.Point(696, 7)
        Me.IDKontoTextBox.Name = "IDKontoTextBox"
        Me.IDKontoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDKontoTextBox.TabIndex = 2
        '
        'KontoDataGridView
        '
        Me.KontoDataGridView.AutoGenerateColumns = False
        Me.KontoDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.KontoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KontoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.Datum})
        Me.KontoDataGridView.DataSource = Me.KontoBindingSource
        Me.KontoDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.KontoDataGridView.Location = New System.Drawing.Point(7, 6)
        Me.KontoDataGridView.Name = "KontoDataGridView"
        Me.KontoDataGridView.RowHeadersVisible = False
        Me.KontoDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.KontoDataGridView.Size = New System.Drawing.Size(472, 246)
        Me.KontoDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IDKonto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IDKonto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IDFirmenName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IDFirmenName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "KontoName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "KontoName"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Datum
        '
        Me.Datum.DataPropertyName = "Datum"
        Me.Datum.HeaderText = "Datum"
        Me.Datum.Name = "Datum"
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.BindingNavigator3)
        Me.TabPage4.Controls.Add(WebseiteLabel)
        Me.TabPage4.Controls.Add(Me.WebseiteTextBox)
        Me.TabPage4.Controls.Add(UStIdNrLabel)
        Me.TabPage4.Controls.Add(Me.UStIdNrTextBox)
        Me.TabPage4.Controls.Add(LandLabel)
        Me.TabPage4.Controls.Add(Me.LandTextBox)
        Me.TabPage4.Controls.Add(BundeslandLabel)
        Me.TabPage4.Controls.Add(Me.BundeslandTextBox)
        Me.TabPage4.Controls.Add(OrtLabel)
        Me.TabPage4.Controls.Add(Me.OrtTextBox)
        Me.TabPage4.Controls.Add(PLZLabel)
        Me.TabPage4.Controls.Add(Me.PLZTextBox)
        Me.TabPage4.Controls.Add(PostfachLabel)
        Me.TabPage4.Controls.Add(Me.PostfachTextBox)
        Me.TabPage4.Controls.Add(StraßeLabel)
        Me.TabPage4.Controls.Add(Me.StraßeTextBox)
        Me.TabPage4.Controls.Add(AdresstypLabel)
        Me.TabPage4.Controls.Add(Me.AdresstypTextBox)
        Me.TabPage4.Controls.Add(IDKontoLabel1)
        Me.TabPage4.Controls.Add(Me.IDKontoTextBox1)
        Me.TabPage4.Controls.Add(IDFirmenNameLabel3)
        Me.TabPage4.Controls.Add(Me.IDFirmenNameTextBox3)
        Me.TabPage4.Controls.Add(IDAdresseLabel1)
        Me.TabPage4.Controls.Add(Me.IDAdresseTextBox1)
        Me.TabPage4.Controls.Add(Me.DataGridView1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1058, 291)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Adressen"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Me.ToolStripButton7
        Me.BindingNavigator3.BindingSource = Me.AdressenBindingSource
        Me.BindingNavigator3.CountItem = Me.ToolStripLabel2
        Me.BindingNavigator3.DeleteItem = Me.ToolStripButton8
        Me.BindingNavigator3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripSeparator4, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton11, Me.ToolStripButton12, Me.ToolStripSeparator6, Me.ToolStripButton7, Me.ToolStripButton8, Me.BNAV_AdressenSave})
        Me.BindingNavigator3.Location = New System.Drawing.Point(3, 263)
        Me.BindingNavigator3.MoveFirstItem = Me.ToolStripButton9
        Me.BindingNavigator3.MoveLastItem = Me.ToolStripButton12
        Me.BindingNavigator3.MoveNextItem = Me.ToolStripButton11
        Me.BindingNavigator3.MovePreviousItem = Me.ToolStripButton10
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.ToolStripTextBox2
        Me.BindingNavigator3.Size = New System.Drawing.Size(1052, 25)
        Me.BindingNavigator3.TabIndex = 25
        Me.BindingNavigator3.Text = "BindingNavigator1"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Neu hinzufügen"
        '
        'AdressenBindingSource
        '
        Me.AdressenBindingSource.DataMember = "Adressen"
        Me.AdressenBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripLabel2.Text = "von {0}"
        Me.ToolStripLabel2.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Löschen"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "Erste verschieben"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton10.Text = "Vorherige verschieben"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.AccessibleName = "Position"
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(50, 25)
        Me.ToolStripTextBox2.Text = "0"
        Me.ToolStripTextBox2.ToolTipText = "Aktuelle Position"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "Nächste verschieben"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton12.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton12.Text = "Letzte verschieben"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'BNAV_AdressenSave
        '
        Me.BNAV_AdressenSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BNAV_AdressenSave.Image = CType(resources.GetObject("BNAV_AdressenSave.Image"), System.Drawing.Image)
        Me.BNAV_AdressenSave.Name = "BNAV_AdressenSave"
        Me.BNAV_AdressenSave.Size = New System.Drawing.Size(23, 22)
        Me.BNAV_AdressenSave.Text = "Daten speichern"
        '
        'WebseiteTextBox
        '
        Me.WebseiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Webseite", True))
        Me.WebseiteTextBox.Location = New System.Drawing.Point(795, 32)
        Me.WebseiteTextBox.Name = "WebseiteTextBox"
        Me.WebseiteTextBox.Size = New System.Drawing.Size(257, 20)
        Me.WebseiteTextBox.TabIndex = 24
        '
        'UStIdNrTextBox
        '
        Me.UStIdNrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "UStIdNr", True))
        Me.UStIdNrTextBox.Location = New System.Drawing.Point(268, 30)
        Me.UStIdNrTextBox.Name = "UStIdNrTextBox"
        Me.UStIdNrTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UStIdNrTextBox.TabIndex = 22
        '
        'LandTextBox
        '
        Me.LandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Land", True))
        Me.LandTextBox.Location = New System.Drawing.Point(951, 6)
        Me.LandTextBox.Name = "LandTextBox"
        Me.LandTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LandTextBox.TabIndex = 20
        '
        'BundeslandTextBox
        '
        Me.BundeslandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Bundesland", True))
        Me.BundeslandTextBox.Location = New System.Drawing.Point(795, 6)
        Me.BundeslandTextBox.Name = "BundeslandTextBox"
        Me.BundeslandTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BundeslandTextBox.TabIndex = 18
        '
        'OrtTextBox
        '
        Me.OrtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Ort", True))
        Me.OrtTextBox.Location = New System.Drawing.Point(572, 56)
        Me.OrtTextBox.Name = "OrtTextBox"
        Me.OrtTextBox.Size = New System.Drawing.Size(140, 20)
        Me.OrtTextBox.TabIndex = 16
        '
        'PLZTextBox
        '
        Me.PLZTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "PLZ", True))
        Me.PLZTextBox.Location = New System.Drawing.Point(454, 56)
        Me.PLZTextBox.Name = "PLZTextBox"
        Me.PLZTextBox.Size = New System.Drawing.Size(67, 20)
        Me.PLZTextBox.TabIndex = 14
        '
        'PostfachTextBox
        '
        Me.PostfachTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Postfach", True))
        Me.PostfachTextBox.Location = New System.Drawing.Point(454, 5)
        Me.PostfachTextBox.Name = "PostfachTextBox"
        Me.PostfachTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PostfachTextBox.TabIndex = 12
        '
        'StraßeTextBox
        '
        Me.StraßeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Straße", True))
        Me.StraßeTextBox.Location = New System.Drawing.Point(454, 30)
        Me.StraßeTextBox.Name = "StraßeTextBox"
        Me.StraßeTextBox.Size = New System.Drawing.Size(258, 20)
        Me.StraßeTextBox.TabIndex = 10
        '
        'AdresstypTextBox
        '
        Me.AdresstypTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "Adresstyp", True))
        Me.AdresstypTextBox.Location = New System.Drawing.Point(268, 4)
        Me.AdresstypTextBox.Name = "AdresstypTextBox"
        Me.AdresstypTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AdresstypTextBox.TabIndex = 8
        '
        'IDKontoTextBox1
        '
        Me.IDKontoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "IDKonto", True))
        Me.IDKontoTextBox1.Location = New System.Drawing.Point(92, 30)
        Me.IDKontoTextBox1.Name = "IDKontoTextBox1"
        Me.IDKontoTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.IDKontoTextBox1.TabIndex = 6
        '
        'IDFirmenNameTextBox3
        '
        Me.IDFirmenNameTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "IDFirmenName", True))
        Me.IDFirmenNameTextBox3.Location = New System.Drawing.Point(92, 55)
        Me.IDFirmenNameTextBox3.Name = "IDFirmenNameTextBox3"
        Me.IDFirmenNameTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.IDFirmenNameTextBox3.TabIndex = 4
        '
        'IDAdresseTextBox1
        '
        Me.IDAdresseTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdressenBindingSource, "IDAdresse", True))
        Me.IDAdresseTextBox1.Location = New System.Drawing.Point(92, 4)
        Me.IDAdresseTextBox1.Name = "IDAdresseTextBox1"
        Me.IDAdresseTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.IDAdresseTextBox1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDAdresse, Me.DataGridViewTextBoxColumn7, Me.IDKonto, Me.Adresstyp, Me.Straße, Me.Postfach, Me.PLZ, Me.Ort, Me.Bundesland, Me.Land, Me.UStIdNr, Me.Webseite})
        Me.DataGridView1.DataSource = Me.AdressenBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.DataGridView1.Location = New System.Drawing.Point(7, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(1043, 163)
        Me.DataGridView1.TabIndex = 1
        '
        'IDAdresse
        '
        Me.IDAdresse.DataPropertyName = "IDAdresse"
        Me.IDAdresse.HeaderText = "IDAdresse"
        Me.IDAdresse.Name = "IDAdresse"
        Me.IDAdresse.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IDFirmenName"
        Me.DataGridViewTextBoxColumn7.HeaderText = "IDFirmenName"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 70
        '
        'IDKonto
        '
        Me.IDKonto.DataPropertyName = "IDKonto"
        Me.IDKonto.HeaderText = "IDKonto"
        Me.IDKonto.Name = "IDKonto"
        Me.IDKonto.Width = 70
        '
        'Adresstyp
        '
        Me.Adresstyp.DataPropertyName = "Adresstyp"
        Me.Adresstyp.HeaderText = "Adresstyp"
        Me.Adresstyp.Name = "Adresstyp"
        '
        'Straße
        '
        Me.Straße.DataPropertyName = "Straße"
        Me.Straße.HeaderText = "Straße"
        Me.Straße.Name = "Straße"
        '
        'Postfach
        '
        Me.Postfach.DataPropertyName = "Postfach"
        Me.Postfach.HeaderText = "Postfach"
        Me.Postfach.Name = "Postfach"
        '
        'PLZ
        '
        Me.PLZ.DataPropertyName = "PLZ"
        Me.PLZ.HeaderText = "PLZ"
        Me.PLZ.Name = "PLZ"
        Me.PLZ.Width = 50
        '
        'Ort
        '
        Me.Ort.DataPropertyName = "Ort"
        Me.Ort.HeaderText = "Ort"
        Me.Ort.Name = "Ort"
        '
        'Bundesland
        '
        Me.Bundesland.DataPropertyName = "Bundesland"
        Me.Bundesland.HeaderText = "Bundesland"
        Me.Bundesland.Name = "Bundesland"
        '
        'Land
        '
        Me.Land.DataPropertyName = "Land"
        Me.Land.HeaderText = "Land"
        Me.Land.Name = "Land"
        '
        'UStIdNr
        '
        Me.UStIdNr.DataPropertyName = "UStIdNr"
        Me.UStIdNr.HeaderText = "UStIdNr"
        Me.UStIdNr.Name = "UStIdNr"
        '
        'Webseite
        '
        Me.Webseite.DataPropertyName = "Webseite"
        Me.Webseite.HeaderText = "Webseite"
        Me.Webseite.Name = "Webseite"
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.Controls.Add(Me.SachbearbeiterBindingNavigator)
        Me.TabPage5.Controls.Add(IDAdresseLabel2)
        Me.TabPage5.Controls.Add(Me.IDAdresseTextBox2)
        Me.TabPage5.Controls.Add(FaxnummerLabel)
        Me.TabPage5.Controls.Add(Me.FaxnummerTextBox)
        Me.TabPage5.Controls.Add(MobiltelefonLabel)
        Me.TabPage5.Controls.Add(Me.MobiltelefonTextBox)
        Me.TabPage5.Controls.Add(TelefonPrivatLabel)
        Me.TabPage5.Controls.Add(Me.TelefonPrivatTextBox)
        Me.TabPage5.Controls.Add(TelefonGeschaeftlichLabel)
        Me.TabPage5.Controls.Add(Me.TelefonGeschaeftlichTextBox)
        Me.TabPage5.Controls.Add(JobtitleLabel)
        Me.TabPage5.Controls.Add(Me.JobtitleTextBox)
        Me.TabPage5.Controls.Add(EmailAddresseLabel)
        Me.TabPage5.Controls.Add(Me.EmailAddresseTextBox)
        Me.TabPage5.Controls.Add(AnredeLabel)
        Me.TabPage5.Controls.Add(Me.AnredeTextBox)
        Me.TabPage5.Controls.Add(NachnameLabel)
        Me.TabPage5.Controls.Add(Me.NachnameTextBox)
        Me.TabPage5.Controls.Add(VornameLabel)
        Me.TabPage5.Controls.Add(Me.VornameTextBox)
        Me.TabPage5.Controls.Add(IDFirmenNameLabel4)
        Me.TabPage5.Controls.Add(Me.IDFirmenNameTextBox4)
        Me.TabPage5.Controls.Add(IDKontaktLabel1)
        Me.TabPage5.Controls.Add(Me.IDKontaktTextBox1)
        Me.TabPage5.Controls.Add(Me.DataGridView2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1058, 291)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Kontakte"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'SachbearbeiterBindingNavigator
        '
        Me.SachbearbeiterBindingNavigator.AddNewItem = Me.ToolStripButton1
        Me.SachbearbeiterBindingNavigator.BindingSource = Me.KontakteBindingSource
        Me.SachbearbeiterBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.SachbearbeiterBindingNavigator.DeleteItem = Me.ToolStripButton2
        Me.SachbearbeiterBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SachbearbeiterBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.BNAV_KontakteSave})
        Me.SachbearbeiterBindingNavigator.Location = New System.Drawing.Point(3, 263)
        Me.SachbearbeiterBindingNavigator.MoveFirstItem = Me.ToolStripButton3
        Me.SachbearbeiterBindingNavigator.MoveLastItem = Me.ToolStripButton6
        Me.SachbearbeiterBindingNavigator.MoveNextItem = Me.ToolStripButton5
        Me.SachbearbeiterBindingNavigator.MovePreviousItem = Me.ToolStripButton4
        Me.SachbearbeiterBindingNavigator.Name = "SachbearbeiterBindingNavigator"
        Me.SachbearbeiterBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.SachbearbeiterBindingNavigator.Size = New System.Drawing.Size(1052, 25)
        Me.SachbearbeiterBindingNavigator.TabIndex = 25
        Me.SachbearbeiterBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Neu hinzufügen"
        '
        'KontakteBindingSource
        '
        Me.KontakteBindingSource.DataMember = "Kontakte"
        Me.KontakteBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripLabel1.Text = "von {0}"
        Me.ToolStripLabel1.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Löschen"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Erste verschieben"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Vorherige verschieben"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 25)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Aktuelle Position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Nächste verschieben"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Letzte verschieben"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BNAV_KontakteSave
        '
        Me.BNAV_KontakteSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BNAV_KontakteSave.Image = CType(resources.GetObject("BNAV_KontakteSave.Image"), System.Drawing.Image)
        Me.BNAV_KontakteSave.Name = "BNAV_KontakteSave"
        Me.BNAV_KontakteSave.Size = New System.Drawing.Size(23, 22)
        Me.BNAV_KontakteSave.Text = "Daten speichern"
        '
        'IDAdresseTextBox2
        '
        Me.IDAdresseTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "IDAdresse", True))
        Me.IDAdresseTextBox2.Location = New System.Drawing.Point(94, 58)
        Me.IDAdresseTextBox2.Name = "IDAdresseTextBox2"
        Me.IDAdresseTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.IDAdresseTextBox2.TabIndex = 24
        '
        'FaxnummerTextBox
        '
        Me.FaxnummerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Faxnummer", True))
        Me.FaxnummerTextBox.Location = New System.Drawing.Point(715, 83)
        Me.FaxnummerTextBox.Name = "FaxnummerTextBox"
        Me.FaxnummerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FaxnummerTextBox.TabIndex = 22
        '
        'MobiltelefonTextBox
        '
        Me.MobiltelefonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Mobiltelefon", True))
        Me.MobiltelefonTextBox.Location = New System.Drawing.Point(715, 57)
        Me.MobiltelefonTextBox.Name = "MobiltelefonTextBox"
        Me.MobiltelefonTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MobiltelefonTextBox.TabIndex = 20
        '
        'TelefonPrivatTextBox
        '
        Me.TelefonPrivatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "TelefonPrivat", True))
        Me.TelefonPrivatTextBox.Location = New System.Drawing.Point(715, 31)
        Me.TelefonPrivatTextBox.Name = "TelefonPrivatTextBox"
        Me.TelefonPrivatTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonPrivatTextBox.TabIndex = 18
        '
        'TelefonGeschaeftlichTextBox
        '
        Me.TelefonGeschaeftlichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "TelefonGeschaeftlich", True))
        Me.TelefonGeschaeftlichTextBox.Location = New System.Drawing.Point(715, 5)
        Me.TelefonGeschaeftlichTextBox.Name = "TelefonGeschaeftlichTextBox"
        Me.TelefonGeschaeftlichTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TelefonGeschaeftlichTextBox.TabIndex = 16
        '
        'JobtitleTextBox
        '
        Me.JobtitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Jobtitle", True))
        Me.JobtitleTextBox.Location = New System.Drawing.Point(484, 6)
        Me.JobtitleTextBox.Name = "JobtitleTextBox"
        Me.JobtitleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.JobtitleTextBox.TabIndex = 14
        '
        'EmailAddresseTextBox
        '
        Me.EmailAddresseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "EmailAddresse", True))
        Me.EmailAddresseTextBox.Location = New System.Drawing.Point(484, 32)
        Me.EmailAddresseTextBox.Name = "EmailAddresseTextBox"
        Me.EmailAddresseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailAddresseTextBox.TabIndex = 12
        '
        'AnredeTextBox
        '
        Me.AnredeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Anrede", True))
        Me.AnredeTextBox.Location = New System.Drawing.Point(285, 6)
        Me.AnredeTextBox.Name = "AnredeTextBox"
        Me.AnredeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AnredeTextBox.TabIndex = 10
        '
        'NachnameTextBox
        '
        Me.NachnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Nachname", True))
        Me.NachnameTextBox.Location = New System.Drawing.Point(285, 31)
        Me.NachnameTextBox.Name = "NachnameTextBox"
        Me.NachnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NachnameTextBox.TabIndex = 8
        '
        'VornameTextBox
        '
        Me.VornameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "Vorname", True))
        Me.VornameTextBox.Location = New System.Drawing.Point(285, 57)
        Me.VornameTextBox.Name = "VornameTextBox"
        Me.VornameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VornameTextBox.TabIndex = 6
        '
        'IDFirmenNameTextBox4
        '
        Me.IDFirmenNameTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "IDFirmenName", True))
        Me.IDFirmenNameTextBox4.Location = New System.Drawing.Point(94, 32)
        Me.IDFirmenNameTextBox4.Name = "IDFirmenNameTextBox4"
        Me.IDFirmenNameTextBox4.Size = New System.Drawing.Size(100, 20)
        Me.IDFirmenNameTextBox4.TabIndex = 4
        '
        'IDKontaktTextBox1
        '
        Me.IDKontaktTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteBindingSource, "IDKontakt", True))
        Me.IDKontaktTextBox1.Location = New System.Drawing.Point(94, 6)
        Me.IDKontaktTextBox1.Name = "IDKontaktTextBox1"
        Me.IDKontaktTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.IDKontaktTextBox1.TabIndex = 3
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDKontakt, Me.IDFirmenName, Me.Nachname, Me.Vorname, Me.EmailAddresseDataGridViewTextBoxColumn, Me.JobtitleDataGridViewTextBoxColumn, Me.TelefonGeschaeftlichDataGridViewTextBoxColumn, Me.TelefonPrivatDataGridViewTextBoxColumn, Me.MobiltelefonDataGridViewTextBoxColumn, Me.FaxnummerDataGridViewTextBoxColumn, Me.IDAdresseDataGridViewTextBoxColumn, Me.AnredeDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.KontakteBindingSource
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.DataGridView2.Location = New System.Drawing.Point(7, 109)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView2.Size = New System.Drawing.Size(1045, 147)
        Me.DataGridView2.TabIndex = 2
        '
        'IDKontakt
        '
        Me.IDKontakt.DataPropertyName = "IDKontakt"
        Me.IDKontakt.HeaderText = "IDKontakt"
        Me.IDKontakt.Name = "IDKontakt"
        Me.IDKontakt.Width = 70
        '
        'IDFirmenName
        '
        Me.IDFirmenName.DataPropertyName = "IDFirmenName"
        Me.IDFirmenName.HeaderText = "IDFirmenName"
        Me.IDFirmenName.Name = "IDFirmenName"
        Me.IDFirmenName.Width = 80
        '
        'Nachname
        '
        Me.Nachname.DataPropertyName = "Nachname"
        Me.Nachname.HeaderText = "Nachname"
        Me.Nachname.Name = "Nachname"
        Me.Nachname.Width = 90
        '
        'Vorname
        '
        Me.Vorname.DataPropertyName = "Vorname"
        Me.Vorname.HeaderText = "Vorname"
        Me.Vorname.Name = "Vorname"
        Me.Vorname.Width = 90
        '
        'EmailAddresseDataGridViewTextBoxColumn
        '
        Me.EmailAddresseDataGridViewTextBoxColumn.DataPropertyName = "EmailAddresse"
        Me.EmailAddresseDataGridViewTextBoxColumn.HeaderText = "EmailAddresse"
        Me.EmailAddresseDataGridViewTextBoxColumn.Name = "EmailAddresseDataGridViewTextBoxColumn"
        '
        'JobtitleDataGridViewTextBoxColumn
        '
        Me.JobtitleDataGridViewTextBoxColumn.DataPropertyName = "Jobtitle"
        Me.JobtitleDataGridViewTextBoxColumn.HeaderText = "Jobtitle"
        Me.JobtitleDataGridViewTextBoxColumn.Name = "JobtitleDataGridViewTextBoxColumn"
        Me.JobtitleDataGridViewTextBoxColumn.Width = 90
        '
        'TelefonGeschaeftlichDataGridViewTextBoxColumn
        '
        Me.TelefonGeschaeftlichDataGridViewTextBoxColumn.DataPropertyName = "TelefonGeschaeftlich"
        Me.TelefonGeschaeftlichDataGridViewTextBoxColumn.HeaderText = "TelefonGeschaeftlich"
        Me.TelefonGeschaeftlichDataGridViewTextBoxColumn.Name = "TelefonGeschaeftlichDataGridViewTextBoxColumn"
        '
        'TelefonPrivatDataGridViewTextBoxColumn
        '
        Me.TelefonPrivatDataGridViewTextBoxColumn.DataPropertyName = "TelefonPrivat"
        Me.TelefonPrivatDataGridViewTextBoxColumn.HeaderText = "TelefonPrivat"
        Me.TelefonPrivatDataGridViewTextBoxColumn.Name = "TelefonPrivatDataGridViewTextBoxColumn"
        '
        'MobiltelefonDataGridViewTextBoxColumn
        '
        Me.MobiltelefonDataGridViewTextBoxColumn.DataPropertyName = "Mobiltelefon"
        Me.MobiltelefonDataGridViewTextBoxColumn.HeaderText = "Mobiltelefon"
        Me.MobiltelefonDataGridViewTextBoxColumn.Name = "MobiltelefonDataGridViewTextBoxColumn"
        '
        'FaxnummerDataGridViewTextBoxColumn
        '
        Me.FaxnummerDataGridViewTextBoxColumn.DataPropertyName = "Faxnummer"
        Me.FaxnummerDataGridViewTextBoxColumn.HeaderText = "Faxnummer"
        Me.FaxnummerDataGridViewTextBoxColumn.Name = "FaxnummerDataGridViewTextBoxColumn"
        '
        'IDAdresseDataGridViewTextBoxColumn
        '
        Me.IDAdresseDataGridViewTextBoxColumn.DataPropertyName = "IDAdresse"
        Me.IDAdresseDataGridViewTextBoxColumn.HeaderText = "IDAdresse"
        Me.IDAdresseDataGridViewTextBoxColumn.Name = "IDAdresseDataGridViewTextBoxColumn"
        Me.IDAdresseDataGridViewTextBoxColumn.Width = 70
        '
        'AnredeDataGridViewTextBoxColumn
        '
        Me.AnredeDataGridViewTextBoxColumn.DataPropertyName = "Anrede"
        Me.AnredeDataGridViewTextBoxColumn.HeaderText = "Anrede"
        Me.AnredeDataGridViewTextBoxColumn.Name = "AnredeDataGridViewTextBoxColumn"
        Me.AnredeDataGridViewTextBoxColumn.Width = 60
        '
        'Belege
        '
        Me.Belege.AutoScroll = True
        Me.Belege.Controls.Add(Me.BNAV_Belege)
        Me.Belege.Controls.Add(Me.BelegeDataGridView)
        Me.Belege.Location = New System.Drawing.Point(4, 22)
        Me.Belege.Name = "Belege"
        Me.Belege.Padding = New System.Windows.Forms.Padding(3)
        Me.Belege.Size = New System.Drawing.Size(1058, 291)
        Me.Belege.TabIndex = 5
        Me.Belege.Text = "Belege"
        Me.Belege.UseVisualStyleBackColor = True
        '
        'BNAV_Belege
        '
        Me.BNAV_Belege.AddNewItem = Me.ToolStripButton28
        Me.BNAV_Belege.BindingSource = Me.BelegeBindingSource
        Me.BNAV_Belege.CountItem = Me.ToolStripLabel5
        Me.BNAV_Belege.DeleteItem = Me.ToolStripButton29
        Me.BNAV_Belege.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BNAV_Belege.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton30, Me.ToolStripButton31, Me.ToolStripSeparator13, Me.ToolStripTextBox5, Me.ToolStripLabel5, Me.ToolStripSeparator14, Me.ToolStripButton32, Me.ToolStripButton33, Me.ToolStripSeparator15, Me.ToolStripButton28, Me.ToolStripButton29, Me.BNAV_BelegeSaveItem})
        Me.BNAV_Belege.Location = New System.Drawing.Point(3, 263)
        Me.BNAV_Belege.MoveFirstItem = Me.ToolStripButton30
        Me.BNAV_Belege.MoveLastItem = Me.ToolStripButton33
        Me.BNAV_Belege.MoveNextItem = Me.ToolStripButton32
        Me.BNAV_Belege.MovePreviousItem = Me.ToolStripButton31
        Me.BNAV_Belege.Name = "BNAV_Belege"
        Me.BNAV_Belege.PositionItem = Me.ToolStripTextBox5
        Me.BNAV_Belege.Size = New System.Drawing.Size(1052, 25)
        Me.BNAV_Belege.TabIndex = 26
        Me.BNAV_Belege.Text = "BindingNavigator1"
        '
        'ToolStripButton28
        '
        Me.ToolStripButton28.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton28.Image = CType(resources.GetObject("ToolStripButton28.Image"), System.Drawing.Image)
        Me.ToolStripButton28.Name = "ToolStripButton28"
        Me.ToolStripButton28.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton28.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton28.Text = "Neu hinzufügen"
        '
        'BelegeBindingSource
        '
        Me.BelegeBindingSource.DataMember = "Belege"
        Me.BelegeBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripLabel5.Text = "von {0}"
        Me.ToolStripLabel5.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'ToolStripButton29
        '
        Me.ToolStripButton29.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton29.Image = CType(resources.GetObject("ToolStripButton29.Image"), System.Drawing.Image)
        Me.ToolStripButton29.Name = "ToolStripButton29"
        Me.ToolStripButton29.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton29.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton29.Text = "Löschen"
        '
        'ToolStripButton30
        '
        Me.ToolStripButton30.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton30.Image = CType(resources.GetObject("ToolStripButton30.Image"), System.Drawing.Image)
        Me.ToolStripButton30.Name = "ToolStripButton30"
        Me.ToolStripButton30.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton30.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton30.Text = "Erste verschieben"
        '
        'ToolStripButton31
        '
        Me.ToolStripButton31.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton31.Image = CType(resources.GetObject("ToolStripButton31.Image"), System.Drawing.Image)
        Me.ToolStripButton31.Name = "ToolStripButton31"
        Me.ToolStripButton31.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton31.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton31.Text = "Vorherige verschieben"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox5
        '
        Me.ToolStripTextBox5.AccessibleName = "Position"
        Me.ToolStripTextBox5.AutoSize = False
        Me.ToolStripTextBox5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ToolStripTextBox5.Name = "ToolStripTextBox5"
        Me.ToolStripTextBox5.Size = New System.Drawing.Size(50, 25)
        Me.ToolStripTextBox5.Text = "0"
        Me.ToolStripTextBox5.ToolTipText = "Aktuelle Position"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton32
        '
        Me.ToolStripButton32.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton32.Image = CType(resources.GetObject("ToolStripButton32.Image"), System.Drawing.Image)
        Me.ToolStripButton32.Name = "ToolStripButton32"
        Me.ToolStripButton32.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton32.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton32.Text = "Nächste verschieben"
        '
        'ToolStripButton33
        '
        Me.ToolStripButton33.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton33.Image = CType(resources.GetObject("ToolStripButton33.Image"), System.Drawing.Image)
        Me.ToolStripButton33.Name = "ToolStripButton33"
        Me.ToolStripButton33.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton33.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton33.Text = "Letzte verschieben"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 25)
        '
        'BNAV_BelegeSaveItem
        '
        Me.BNAV_BelegeSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BNAV_BelegeSaveItem.Image = CType(resources.GetObject("BNAV_BelegeSaveItem.Image"), System.Drawing.Image)
        Me.BNAV_BelegeSaveItem.Name = "BNAV_BelegeSaveItem"
        Me.BNAV_BelegeSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BNAV_BelegeSaveItem.Text = "Daten speichern"
        '
        'BelegeDataGridView
        '
        Me.BelegeDataGridView.AutoGenerateColumns = False
        Me.BelegeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BelegeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.BelegeDataGridView.DataSource = Me.BelegeBindingSource
        Me.BelegeDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.BelegeDataGridView.Name = "BelegeDataGridView"
        Me.BelegeDataGridView.Size = New System.Drawing.Size(1058, 243)
        Me.BelegeDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IDBeleg"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IDBeleg"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IDFirmenName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "IDFirmenName"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "FirmenName"
        Me.DataGridViewTextBoxColumn9.HeaderText = "FirmenName"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Datum"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Datum"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "IDAdresse"
        Me.DataGridViewTextBoxColumn11.HeaderText = "IDAdresse"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "IDKonto"
        Me.DataGridViewTextBoxColumn12.HeaderText = "IDKonto"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Kuerzel"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Kuerzel"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Kontakt"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Kontakt"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "WeitereKontakte"
        Me.DataGridViewTextBoxColumn15.HeaderText = "WeitereKontakte"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Thema"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Thema"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "WeitereBesucher"
        Me.DataGridViewTextBoxColumn17.HeaderText = "WeitereBesucher"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Login"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Login"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Belegname"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Belegname"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
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
        'KontakteTableAdapter
        '
        Me.KontakteTableAdapter.ClearBeforeFill = True
        '
        'BelegeTableAdapter
        '
        Me.BelegeTableAdapter.ClearBeforeFill = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TC_Administration, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1068, 511)
        Me.TableLayoutPanel1.TabIndex = 31
        '
        'HilfelinkLabel
        '
        HilfelinkLabel.AutoSize = True
        HilfelinkLabel.Location = New System.Drawing.Point(60, 93)
        HilfelinkLabel.Name = "HilfelinkLabel"
        HilfelinkLabel.Size = New System.Drawing.Size(47, 13)
        HilfelinkLabel.TabIndex = 23
        HilfelinkLabel.Text = "Hilfelink:"
        '
        'HilfelinkTextBox
        '
        Me.HilfelinkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KonfigurationBindingSource, "Hilfelink", True))
        Me.HilfelinkTextBox.Location = New System.Drawing.Point(113, 90)
        Me.HilfelinkTextBox.Name = "HilfelinkTextBox"
        Me.HilfelinkTextBox.Size = New System.Drawing.Size(457, 20)
        Me.HilfelinkTextBox.TabIndex = 24
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 512)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "Administration"
        CType(Me.KonfigurationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._WSL_AdressenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.SachbearbeiterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.TC_Administration.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.FirmenNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.FirmenNameDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.KontoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KontoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        CType(Me.AdressenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.SachbearbeiterBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SachbearbeiterBindingNavigator.ResumeLayout(False)
        Me.SachbearbeiterBindingNavigator.PerformLayout()
        CType(Me.KontakteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Belege.ResumeLayout(False)
        Me.Belege.PerformLayout()
        CType(Me.BNAV_Belege, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BNAV_Belege.ResumeLayout(False)
        Me.BNAV_Belege.PerformLayout()
        CType(Me.BelegeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BelegeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BTN_Vorlagenpfad As Button
    Friend WithEvents BTN_Schliessen As Button
    Friend WithEvents _WSL_AdressenDataSet As _WSL_AdressenDataSet
    Friend WithEvents TableAdapterManager As _WSL_AdressenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KonfigurationBindingSource As BindingSource
    Friend WithEvents KonfigurationTableAdapter As _WSL_AdressenDataSetTableAdapters.KonfigurationTableAdapter
    Friend WithEvents VorlagenpfadTextBox As TextBox
    Friend WithEvents IDBesuchTextBox As TextBox
    Friend WithEvents IDKontaktTextBox As TextBox
    Friend WithEvents IDAdresseTextBox As TextBox
    Friend WithEvents LieferantennummerTextBox As TextBox
    Friend WithEvents KundennummerTextBox As TextBox
    Friend WithEvents LeadnummerTextBox As TextBox
    Friend WithEvents IDFirmenNameTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents SachbearbeiterBindingSource As BindingSource
    Friend WithEvents SachbearbeiterTableAdapter As _WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter
    Friend WithEvents SachbearbeiterLabel1 As Label
    Friend WithEvents AdminCheckBox As CheckBox
    Friend WithEvents BTN_Speichern As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TC_Administration As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents FirmenNameBindingSource As BindingSource
    Friend WithEvents FirmenNameTableAdapter As _WSL_AdressenDataSetTableAdapters.FirmenNameTableAdapter
    Friend WithEvents ChangedDateTimePicker As DateTimePicker
    Friend WithEvents LoginTextBox As TextBox
    Friend WithEvents FirmenNameTextBox As TextBox
    Friend WithEvents IDFirmenNameTextBox1 As TextBox
    Friend WithEvents FirmenNameDataGridView As DataGridView
    Friend WithEvents KontoBindingSource As BindingSource
    Friend WithEvents KontoTableAdapter As _WSL_AdressenDataSetTableAdapters.KontoTableAdapter
    Friend WithEvents AnlageDatumDateTimePicker As DateTimePicker
    Friend WithEvents KontoNameTextBox As TextBox
    Friend WithEvents IDFirmenNameTextBox2 As TextBox
    Friend WithEvents IDKontoTextBox As TextBox
    Friend WithEvents KontoDataGridView As DataGridView
    Friend WithEvents AdressenBindingSource As BindingSource
    Friend WithEvents AdressenTableAdapter As _WSL_AdressenDataSetTableAdapters.AdressenTableAdapter
    Friend WithEvents LandTextBox As TextBox
    Friend WithEvents BundeslandTextBox As TextBox
    Friend WithEvents OrtTextBox As TextBox
    Friend WithEvents PLZTextBox As TextBox
    Friend WithEvents PostfachTextBox As TextBox
    Friend WithEvents StraßeTextBox As TextBox
    Friend WithEvents AdresstypTextBox As TextBox
    Friend WithEvents IDKontoTextBox1 As TextBox
    Friend WithEvents IDFirmenNameTextBox3 As TextBox
    Friend WithEvents IDAdresseTextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents WebseiteTextBox As TextBox
    Friend WithEvents UStIdNrTextBox As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents KontakteBindingSource As BindingSource
    Friend WithEvents KontakteTableAdapter As _WSL_AdressenDataSetTableAdapters.KontakteTableAdapter
    Friend WithEvents IDAdresseTextBox2 As TextBox
    Friend WithEvents FaxnummerTextBox As TextBox
    Friend WithEvents MobiltelefonTextBox As TextBox
    Friend WithEvents TelefonPrivatTextBox As TextBox
    Friend WithEvents TelefonGeschaeftlichTextBox As TextBox
    Friend WithEvents JobtitleTextBox As TextBox
    Friend WithEvents EmailAddresseTextBox As TextBox
    Friend WithEvents AnredeTextBox As TextBox
    Friend WithEvents NachnameTextBox As TextBox
    Friend WithEvents VornameTextBox As TextBox
    Friend WithEvents IDFirmenNameTextBox4 As TextBox
    Friend WithEvents IDKontaktTextBox1 As TextBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripButton21 As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripButton22 As ToolStripButton
    Friend WithEvents ToolStripButton23 As ToolStripButton
    Friend WithEvents ToolStripButton24 As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox4 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripButton25 As ToolStripButton
    Friend WithEvents ToolStripButton26 As ToolStripButton
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents BNAV_FirmenNameSave As ToolStripButton
    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents ToolStripButton14 As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripButton15 As ToolStripButton
    Friend WithEvents ToolStripButton16 As ToolStripButton
    Friend WithEvents ToolStripButton17 As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox3 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripButton18 As ToolStripButton
    Friend WithEvents ToolStripButton19 As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents BNAV_KontoSave As ToolStripButton
    Friend WithEvents BindingNavigator3 As BindingNavigator
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripButton10 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton11 As ToolStripButton
    Friend WithEvents ToolStripButton12 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents BNAV_AdressenSave As ToolStripButton
    Friend WithEvents SachbearbeiterBindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BNAV_KontakteSave As ToolStripButton
    Friend WithEvents BTN_Aktuell As Button
    Friend WithEvents BTN_Alle As Button
    Friend WithEvents BTN_DWPfad As Button
    Friend WithEvents DWDateinameTextBox As TextBox
    Friend WithEvents DWpfadTextBox As TextBox
    Friend WithEvents IDKontakt As DataGridViewTextBoxColumn
    Friend WithEvents IDFirmenName As DataGridViewTextBoxColumn
    Friend WithEvents Nachname As DataGridViewTextBoxColumn
    Friend WithEvents Vorname As DataGridViewTextBoxColumn
    Friend WithEvents EmailAddresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JobtitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonGeschaeftlichDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonPrivatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobiltelefonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FaxnummerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDAdresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnredeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDAdresse As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IDKonto As DataGridViewTextBoxColumn
    Friend WithEvents Adresstyp As DataGridViewTextBoxColumn
    Friend WithEvents Straße As DataGridViewTextBoxColumn
    Friend WithEvents Postfach As DataGridViewTextBoxColumn
    Friend WithEvents PLZ As DataGridViewTextBoxColumn
    Friend WithEvents Ort As DataGridViewTextBoxColumn
    Friend WithEvents Bundesland As DataGridViewTextBoxColumn
    Friend WithEvents Land As DataGridViewTextBoxColumn
    Friend WithEvents UStIdNr As DataGridViewTextBoxColumn
    Friend WithEvents Webseite As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Datum As DataGridViewTextBoxColumn
    Friend WithEvents Belege As TabPage
    Friend WithEvents BelegeBindingSource As BindingSource
    Friend WithEvents BelegeTableAdapter As _WSL_AdressenDataSetTableAdapters.BelegeTableAdapter
    Friend WithEvents BelegeDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents BNAV_Belege As BindingNavigator
    Friend WithEvents ToolStripButton28 As ToolStripButton
    Friend WithEvents ToolStripLabel5 As ToolStripLabel
    Friend WithEvents ToolStripButton29 As ToolStripButton
    Friend WithEvents ToolStripButton30 As ToolStripButton
    Friend WithEvents ToolStripButton31 As ToolStripButton
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox5 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents ToolStripButton32 As ToolStripButton
    Friend WithEvents ToolStripButton33 As ToolStripButton
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents BNAV_BelegeSaveItem As ToolStripButton
    Friend WithEvents InaktivCheckBox As CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Login As DataGridViewTextBoxColumn
    Friend WithEvents changed As DataGridViewTextBoxColumn
    Friend WithEvents inaktiv As DataGridViewCheckBoxColumn
    Friend WithEvents HilfelinkTextBox As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
