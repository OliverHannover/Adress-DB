<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Umkreissuche
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
        Dim StaatLabel As System.Windows.Forms.Label
        Dim PLZLabel As System.Windows.Forms.Label
        Dim OrtLabel As System.Windows.Forms.Label
        Dim BundeslandLabel As System.Windows.Forms.Label
        Dim LandkreisLabel As System.Windows.Forms.Label
        Dim LatitudeLabel As System.Windows.Forms.Label
        Dim LongitudeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Umkreissuche))
        Me.CB_Staat = New System.Windows.Forms.ComboBox()
        Me.StaatenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._WSL_AdressenDataSet = New Adress_DB._WSL_AdressenDataSet()
        Me.BundeslandLabel1 = New System.Windows.Forms.Label()
        Me.PLZ_GeodatenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LandkreisLabel1 = New System.Windows.Forms.Label()
        Me.TB_PLZ = New System.Windows.Forms.TextBox()
        Me.CB_Ort = New System.Windows.Forms.ComboBox()
        Me.LatitudeLabel1 = New System.Windows.Forms.Label()
        Me.LongitudeLabel1 = New System.Windows.Forms.Label()
        Me.TB_Entfernung = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LBL_Countrycode = New System.Windows.Forms.Label()
        Me.AdresseMitGeodatenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager()
        Me.StaatenTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.StaatenTableAdapter()
        Me.AdresseMitGeodatenTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.AdresseMitGeodatenTableAdapter()
        Me.PLZ_GeodatenTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.PLZ_GeodatenTableAdapter()
        Me.LBL_Treffer = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.LBL_PLZungueltig = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_IDFirmenName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_Schliessen = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        StaatLabel = New System.Windows.Forms.Label()
        PLZLabel = New System.Windows.Forms.Label()
        OrtLabel = New System.Windows.Forms.Label()
        BundeslandLabel = New System.Windows.Forms.Label()
        LandkreisLabel = New System.Windows.Forms.Label()
        LatitudeLabel = New System.Windows.Forms.Label()
        LongitudeLabel = New System.Windows.Forms.Label()
        CType(Me.StaatenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._WSL_AdressenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLZ_GeodatenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdresseMitGeodatenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StaatLabel
        '
        StaatLabel.AutoSize = True
        StaatLabel.Location = New System.Drawing.Point(3, 9)
        StaatLabel.Name = "StaatLabel"
        StaatLabel.Size = New System.Drawing.Size(35, 13)
        StaatLabel.TabIndex = 0
        StaatLabel.Text = "Staat:"
        '
        'PLZLabel
        '
        PLZLabel.AutoSize = True
        PLZLabel.Location = New System.Drawing.Point(8, 36)
        PLZLabel.Name = "PLZLabel"
        PLZLabel.Size = New System.Drawing.Size(30, 13)
        PLZLabel.TabIndex = 4
        PLZLabel.Text = "PLZ:"
        '
        'OrtLabel
        '
        OrtLabel.AutoSize = True
        OrtLabel.Location = New System.Drawing.Point(13, 62)
        OrtLabel.Name = "OrtLabel"
        OrtLabel.Size = New System.Drawing.Size(24, 13)
        OrtLabel.TabIndex = 6
        OrtLabel.Text = "Ort:"
        '
        'BundeslandLabel
        '
        BundeslandLabel.AutoSize = True
        BundeslandLabel.Location = New System.Drawing.Point(15, 148)
        BundeslandLabel.Name = "BundeslandLabel"
        BundeslandLabel.Size = New System.Drawing.Size(44, 13)
        BundeslandLabel.TabIndex = 8
        BundeslandLabel.Text = "Region:"
        '
        'LandkreisLabel
        '
        LandkreisLabel.AutoSize = True
        LandkreisLabel.Location = New System.Drawing.Point(3, 170)
        LandkreisLabel.Name = "LandkreisLabel"
        LandkreisLabel.Size = New System.Drawing.Size(56, 13)
        LandkreisLabel.TabIndex = 10
        LandkreisLabel.Text = "Landkreis:"
        '
        'LatitudeLabel
        '
        LatitudeLabel.AutoSize = True
        LatitudeLabel.Location = New System.Drawing.Point(15, 194)
        LatitudeLabel.Name = "LatitudeLabel"
        LatitudeLabel.Size = New System.Drawing.Size(44, 13)
        LatitudeLabel.TabIndex = 13
        LatitudeLabel.Text = "latitude:"
        '
        'LongitudeLabel
        '
        LongitudeLabel.AutoSize = True
        LongitudeLabel.Location = New System.Drawing.Point(6, 207)
        LongitudeLabel.Name = "LongitudeLabel"
        LongitudeLabel.Size = New System.Drawing.Size(53, 13)
        LongitudeLabel.TabIndex = 14
        LongitudeLabel.Text = "longitude:"
        '
        'CB_Staat
        '
        Me.CB_Staat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_Staat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Staat.FormattingEnabled = True
        Me.CB_Staat.Location = New System.Drawing.Point(44, 6)
        Me.CB_Staat.Name = "CB_Staat"
        Me.CB_Staat.Size = New System.Drawing.Size(120, 21)
        Me.CB_Staat.TabIndex = 1
        '
        'StaatenBindingSource
        '
        Me.StaatenBindingSource.DataMember = "Staaten"
        Me.StaatenBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        '_WSL_AdressenDataSet
        '
        Me._WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet"
        Me._WSL_AdressenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BundeslandLabel1
        '
        Me.BundeslandLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLZ_GeodatenBindingSource, "Bundesland", True))
        Me.BundeslandLabel1.Location = New System.Drawing.Point(79, 143)
        Me.BundeslandLabel1.Name = "BundeslandLabel1"
        Me.BundeslandLabel1.Size = New System.Drawing.Size(138, 23)
        Me.BundeslandLabel1.TabIndex = 9
        Me.BundeslandLabel1.Text = "Region"
        Me.BundeslandLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PLZ_GeodatenBindingSource
        '
        Me.PLZ_GeodatenBindingSource.DataMember = "PLZ_Geodaten"
        Me.PLZ_GeodatenBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'LandkreisLabel1
        '
        Me.LandkreisLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLZ_GeodatenBindingSource, "Landkreis", True))
        Me.LandkreisLabel1.Location = New System.Drawing.Point(65, 166)
        Me.LandkreisLabel1.Name = "LandkreisLabel1"
        Me.LandkreisLabel1.Size = New System.Drawing.Size(138, 23)
        Me.LandkreisLabel1.TabIndex = 11
        Me.LandkreisLabel1.Text = "landkreis"
        Me.LandkreisLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TB_PLZ
        '
        Me.TB_PLZ.Location = New System.Drawing.Point(44, 33)
        Me.TB_PLZ.Name = "TB_PLZ"
        Me.TB_PLZ.Size = New System.Drawing.Size(74, 20)
        Me.TB_PLZ.TabIndex = 12
        '
        'CB_Ort
        '
        Me.CB_Ort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_Ort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Ort.Cursor = System.Windows.Forms.Cursors.Default
        Me.CB_Ort.DataSource = Me.PLZ_GeodatenBindingSource
        Me.CB_Ort.DisplayMember = "Ort"
        Me.CB_Ort.FormattingEnabled = True
        Me.CB_Ort.Location = New System.Drawing.Point(44, 59)
        Me.CB_Ort.Name = "CB_Ort"
        Me.CB_Ort.Size = New System.Drawing.Size(159, 21)
        Me.CB_Ort.TabIndex = 13
        '
        'LatitudeLabel1
        '
        Me.LatitudeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLZ_GeodatenBindingSource, "latitude", True))
        Me.LatitudeLabel1.Location = New System.Drawing.Point(66, 194)
        Me.LatitudeLabel1.Name = "LatitudeLabel1"
        Me.LatitudeLabel1.Size = New System.Drawing.Size(100, 13)
        Me.LatitudeLabel1.TabIndex = 14
        Me.LatitudeLabel1.Text = "lat"
        '
        'LongitudeLabel1
        '
        Me.LongitudeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PLZ_GeodatenBindingSource, "longitude", True))
        Me.LongitudeLabel1.Location = New System.Drawing.Point(66, 207)
        Me.LongitudeLabel1.Name = "LongitudeLabel1"
        Me.LongitudeLabel1.Size = New System.Drawing.Size(100, 17)
        Me.LongitudeLabel1.TabIndex = 15
        Me.LongitudeLabel1.Text = "long"
        '
        'TB_Entfernung
        '
        Me.TB_Entfernung.Location = New System.Drawing.Point(68, 94)
        Me.TB_Entfernung.Name = "TB_Entfernung"
        Me.TB_Entfernung.Size = New System.Drawing.Size(41, 20)
        Me.TB_Entfernung.TabIndex = 16
        Me.TB_Entfernung.Text = "10"
        Me.TB_Entfernung.WordWrap = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(233, 42)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.Size = New System.Drawing.Size(752, 407)
        Me.dgv.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Adress_DB.My.Resources.Resources.Search_16x
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(44, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 31)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Umkreissuche"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LBL_Countrycode
        '
        Me.LBL_Countrycode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaatenBindingSource, "ISO2", True))
        Me.LBL_Countrycode.Location = New System.Drawing.Point(170, 6)
        Me.LBL_Countrycode.Name = "LBL_Countrycode"
        Me.LBL_Countrycode.Size = New System.Drawing.Size(47, 23)
        Me.LBL_Countrycode.TabIndex = 3
        Me.LBL_Countrycode.Text = "Code"
        Me.LBL_Countrycode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdresseMitGeodatenBindingSource
        '
        Me.AdresseMitGeodatenBindingSource.DataMember = "AdresseMitGeodaten"
        Me.AdresseMitGeodatenBindingSource.DataSource = Me._WSL_AdressenDataSet
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
        'StaatenTableAdapter
        '
        Me.StaatenTableAdapter.ClearBeforeFill = True
        '
        'AdresseMitGeodatenTableAdapter
        '
        Me.AdresseMitGeodatenTableAdapter.ClearBeforeFill = True
        '
        'PLZ_GeodatenTableAdapter
        '
        Me.PLZ_GeodatenTableAdapter.ClearBeforeFill = True
        '
        'LBL_Treffer
        '
        Me.LBL_Treffer.AutoSize = True
        Me.LBL_Treffer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Treffer.ForeColor = System.Drawing.Color.White
        Me.LBL_Treffer.Location = New System.Drawing.Point(259, 12)
        Me.LBL_Treffer.Name = "LBL_Treffer"
        Me.LBL_Treffer.Size = New System.Drawing.Size(63, 20)
        Me.LBL_Treffer.TabIndex = 19
        Me.LBL_Treffer.Text = "Treffer"
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Image = Global.Adress_DB.My.Resources.Resources.PrintDocument_16x
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(796, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Drucken"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'LBL_PLZungueltig
        '
        Me.LBL_PLZungueltig.AutoSize = True
        Me.LBL_PLZungueltig.ForeColor = System.Drawing.Color.Red
        Me.LBL_PLZungueltig.Location = New System.Drawing.Point(133, 36)
        Me.LBL_PLZungueltig.Name = "LBL_PLZungueltig"
        Me.LBL_PLZungueltig.Size = New System.Drawing.Size(70, 13)
        Me.LBL_PLZungueltig.TabIndex = 28
        Me.LBL_PLZungueltig.Text = "PLZ ungültig!"
        Me.LBL_PLZungueltig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBL_PLZungueltig.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Umkreis:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "10 - max. 200 km"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dgv, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(988, 498)
        Me.TableLayoutPanel1.TabIndex = 32
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel2, 2)
        Me.Panel2.Controls.Add(Me.lbl_IDFirmenName)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(982, 33)
        Me.Panel2.TabIndex = 26
        '
        'lbl_IDFirmenName
        '
        Me.lbl_IDFirmenName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdresseMitGeodatenBindingSource, "FirmenName", True))
        Me.lbl_IDFirmenName.ForeColor = System.Drawing.Color.Gray
        Me.lbl_IDFirmenName.Location = New System.Drawing.Point(230, 6)
        Me.lbl_IDFirmenName.Name = "lbl_IDFirmenName"
        Me.lbl_IDFirmenName.Size = New System.Drawing.Size(407, 23)
        Me.lbl_IDFirmenName.TabIndex = 33
        Me.lbl_IDFirmenName.Text = "FirmenName"
        Me.lbl_IDFirmenName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Umkreissuche (D-A-CH)"
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel3, 2)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.BTN_Schliessen)
        Me.Panel3.Controls.Add(Me.LBL_Treffer)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 455)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(982, 40)
        Me.Panel3.TabIndex = 28
        '
        'Button3
        '
        Me.Button3.Image = Global.Adress_DB.My.Resources.Resources.BackToResultList_16x
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(345, 10)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 23)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Auswahl anzeigen"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(185, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Treffer:"
        '
        'BTN_Schliessen
        '
        Me.BTN_Schliessen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Schliessen.Image = Global.Adress_DB.My.Resources.Resources.CloseSolution_16x
        Me.BTN_Schliessen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Schliessen.Location = New System.Drawing.Point(891, 10)
        Me.BTN_Schliessen.Name = "BTN_Schliessen"
        Me.BTN_Schliessen.Size = New System.Drawing.Size(80, 22)
        Me.BTN_Schliessen.TabIndex = 16
        Me.BTN_Schliessen.Text = "Schließen"
        Me.BTN_Schliessen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Schliessen.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(StaatLabel)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.CB_Staat)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LBL_Countrycode)
        Me.Panel1.Controls.Add(Me.LBL_PLZungueltig)
        Me.Panel1.Controls.Add(PLZLabel)
        Me.Panel1.Controls.Add(Me.TB_PLZ)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TB_Entfernung)
        Me.Panel1.Controls.Add(Me.BundeslandLabel1)
        Me.Panel1.Controls.Add(LandkreisLabel)
        Me.Panel1.Controls.Add(Me.LatitudeLabel1)
        Me.Panel1.Controls.Add(Me.LongitudeLabel1)
        Me.Panel1.Controls.Add(Me.LandkreisLabel1)
        Me.Panel1.Controls.Add(LongitudeLabel)
        Me.Panel1.Controls.Add(Me.CB_Ort)
        Me.Panel1.Controls.Add(LatitudeLabel)
        Me.Panel1.Controls.Add(OrtLabel)
        Me.Panel1.Controls.Add(BundeslandLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(224, 407)
        Me.Panel1.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 91)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Die berechneten Entfernungen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "beziehen sich auf die Mitte" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "der PLZ-Region!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tre" &
    "ffer innerhalb der gleichen" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PLZ/Region, haben keine Entfernung" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zueinander."
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Umkreissuche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 499)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Umkreissuche"
        Me.Text = "Form8"
        CType(Me.StaatenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._WSL_AdressenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLZ_GeodatenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdresseMitGeodatenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents _WSL_AdressenDataSet As _WSL_AdressenDataSet
    Friend WithEvents TableAdapterManager As _WSL_AdressenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CB_Staat As ComboBox
    Friend WithEvents BundeslandLabel1 As Label
    Friend WithEvents LandkreisLabel1 As Label

    Friend WithEvents TB_PLZ As TextBox
    Friend WithEvents CB_Ort As ComboBox
    Friend WithEvents StaatenBindingSource As BindingSource
    Friend WithEvents StaatenTableAdapter As _WSL_AdressenDataSetTableAdapters.StaatenTableAdapter
    Friend WithEvents LatitudeLabel1 As Label
    Friend WithEvents LongitudeLabel1 As Label
    Friend WithEvents AdresseMitGeodatenBindingSource As BindingSource
    Friend WithEvents AdresseMitGeodatenTableAdapter As _WSL_AdressenDataSetTableAdapters.AdresseMitGeodatenTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PLZ_GeodatenBindingSource As BindingSource
    Friend WithEvents PLZ_GeodatenTableAdapter As _WSL_AdressenDataSetTableAdapters.PLZ_GeodatenTableAdapter
    Friend WithEvents TB_Entfernung As TextBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents LBL_Countrycode As Label
    Friend WithEvents LBL_Treffer As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents LBL_PLZungueltig As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents BTN_Schliessen As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_IDFirmenName As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
End Class
