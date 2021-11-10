<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KontoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KontoForm))
        Me.rdbKundenNr = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblKontoNummer = New System.Windows.Forms.Label()
        Me.rdbLieferantenNr = New System.Windows.Forms.RadioButton()
        Me.btnKontoSave = New System.Windows.Forms.Button()
        Me._WSL_AdressenDataSet = New Adress_DB._WSL_AdressenDataSet()
        Me.KontoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KontoTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.KontoTableAdapter()
        Me.TableAdapterManager = New Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager()
        Me.KontoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirmenNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FirmenNameTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.FirmenNameTableAdapter()
        Me.lblIDFirmenName = New System.Windows.Forms.Label()
        Me.lblFirmenName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PropertiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PropertiesTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.propertiesTableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me._WSL_AdressenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KontoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KontoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FirmenNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PropertiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdbKundenNr
        '
        Me.rdbKundenNr.AutoSize = True
        Me.rdbKundenNr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbKundenNr.Location = New System.Drawing.Point(27, 93)
        Me.rdbKundenNr.Name = "rdbKundenNr"
        Me.rdbKundenNr.Size = New System.Drawing.Size(126, 21)
        Me.rdbKundenNr.TabIndex = 0
        Me.rdbKundenNr.TabStop = True
        Me.rdbKundenNr.Text = "Kundennummer"
        Me.rdbKundenNr.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Neue Konto-Nummer für:"
        '
        'lblKontoNummer
        '
        Me.lblKontoNummer.AutoSize = True
        Me.lblKontoNummer.BackColor = System.Drawing.Color.White
        Me.lblKontoNummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKontoNummer.Location = New System.Drawing.Point(9, 0)
        Me.lblKontoNummer.Name = "lblKontoNummer"
        Me.lblKontoNummer.Size = New System.Drawing.Size(91, 29)
        Me.lblKontoNummer.TabIndex = 2
        Me.lblKontoNummer.Text = "123456"
        Me.lblKontoNummer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdbLieferantenNr
        '
        Me.rdbLieferantenNr.AutoSize = True
        Me.rdbLieferantenNr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbLieferantenNr.Location = New System.Drawing.Point(27, 120)
        Me.rdbLieferantenNr.Name = "rdbLieferantenNr"
        Me.rdbLieferantenNr.Size = New System.Drawing.Size(149, 21)
        Me.rdbLieferantenNr.TabIndex = 3
        Me.rdbLieferantenNr.TabStop = True
        Me.rdbLieferantenNr.Text = "Lieferantennummer"
        Me.rdbLieferantenNr.UseVisualStyleBackColor = True
        '
        'btnKontoSave
        '
        Me.btnKontoSave.Image = Global.Adress_DB.My.Resources.Resources.Save_16x
        Me.btnKontoSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnKontoSave.Location = New System.Drawing.Point(62, 8)
        Me.btnKontoSave.Name = "btnKontoSave"
        Me.btnKontoSave.Size = New System.Drawing.Size(151, 23)
        Me.btnKontoSave.TabIndex = 6
        Me.btnKontoSave.Text = "Hinzufügen / Speichern"
        Me.btnKontoSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKontoSave.UseVisualStyleBackColor = True
        '
        '_WSL_AdressenDataSet
        '
        Me._WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet"
        Me._WSL_AdressenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KontoBindingSource
        '
        Me.KontoBindingSource.DataMember = "Konto"
        Me.KontoBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'KontoTableAdapter
        '
        Me.KontoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdressenTableAdapter = Nothing
        Me.TableAdapterManager.AT_PLZ_GeodatenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BelegeTableAdapter = Nothing
        Me.TableAdapterManager.CH_PLZ_GeodatenTableAdapter = Nothing
        Me.TableAdapterManager.DE_PLZ_GeodatenTableAdapter = Nothing
        Me.TableAdapterManager.FirmenNameTableAdapter = Nothing
        Me.TableAdapterManager.KontakteTableAdapter = Nothing
        Me.TableAdapterManager.KontoTableAdapter = Me.KontoTableAdapter
        Me.TableAdapterManager.LogTabelleTableAdapter = Nothing
        Me.TableAdapterManager.PLZ_GeodatenTableAdapter = Nothing
        Me.TableAdapterManager.propertiesTableAdapter = Nothing
        Me.TableAdapterManager.SachbearbeiterTableAdapter = Nothing
        Me.TableAdapterManager.StaatenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.KontoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4})
        Me.KontoDataGridView.DataSource = Me.KontoBindingSource
        Me.KontoDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.KontoDataGridView.Location = New System.Drawing.Point(275, 71)
        Me.KontoDataGridView.MultiSelect = False
        Me.KontoDataGridView.Name = "KontoDataGridView"
        Me.KontoDataGridView.ReadOnly = True
        Me.KontoDataGridView.RowHeadersVisible = False
        Me.KontoDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.KontoDataGridView.Size = New System.Drawing.Size(233, 160)
        Me.KontoDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IDKonto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IDKonto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "KontoName"
        Me.DataGridViewTextBoxColumn5.HeaderText = "KontoName"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IDFirmenName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IDFirmenName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'FirmenNameBindingSource
        '
        Me.FirmenNameBindingSource.DataMember = "FirmenName"
        Me.FirmenNameBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'FirmenNameTableAdapter
        '
        Me.FirmenNameTableAdapter.ClearBeforeFill = True
        '
        'lblIDFirmenName
        '
        Me.lblIDFirmenName.AutoSize = True
        Me.lblIDFirmenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDFirmenName.Location = New System.Drawing.Point(391, 9)
        Me.lblIDFirmenName.Name = "lblIDFirmenName"
        Me.lblIDFirmenName.Size = New System.Drawing.Size(102, 13)
        Me.lblIDFirmenName.TabIndex = 10
        Me.lblIDFirmenName.Text = "lblIDFirmenName"
        Me.lblIDFirmenName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFirmenName
        '
        Me.lblFirmenName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FirmenNameBindingSource, "FirmenName", True))
        Me.lblFirmenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirmenName.Location = New System.Drawing.Point(13, 35)
        Me.lblFirmenName.Name = "lblFirmenName"
        Me.lblFirmenName.Size = New System.Drawing.Size(371, 24)
        Me.lblFirmenName.TabIndex = 11
        Me.lblFirmenName.Text = "lblFirmenName"
        Me.lblFirmenName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Bitte wählen, welche Nummer benötigt wird:"
        '
        'Button1
        '
        Me.Button1.Image = Global.Adress_DB.My.Resources.Resources.CloseSolution_16x
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(426, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Schließen"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblFirmenName)
        Me.Panel1.Controls.Add(Me.lblIDFirmenName)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(518, 65)
        Me.Panel1.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.btnKontoSave)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(-1, 238)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(518, 42)
        Me.Panel2.TabIndex = 15
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblKontoNummer)
        Me.Panel3.Location = New System.Drawing.Point(85, 178)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(113, 31)
        Me.Panel3.TabIndex = 16
        '
        'KontoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 281)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.KontoDataGridView)
        Me.Controls.Add(Me.rdbLieferantenNr)
        Me.Controls.Add(Me.rdbKundenNr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "KontoForm"
        Me.Text = "Neues Konto anlegen"
        CType(Me._WSL_AdressenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KontoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KontoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FirmenNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PropertiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rdbKundenNr As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblKontoNummer As Label
    Friend WithEvents rdbLieferantenNr As RadioButton
    Friend WithEvents btnKontoSave As Button
    Friend WithEvents _WSL_AdressenDataSet As _WSL_AdressenDataSet
    Friend WithEvents KontoBindingSource As BindingSource
    Friend WithEvents KontoTableAdapter As _WSL_AdressenDataSetTableAdapters.KontoTableAdapter
    Friend WithEvents TableAdapterManager As _WSL_AdressenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KontoDataGridView As DataGridView
    Friend WithEvents FirmenNameBindingSource As BindingSource
    Friend WithEvents FirmenNameTableAdapter As _WSL_AdressenDataSetTableAdapters.FirmenNameTableAdapter
    Friend WithEvents lblIDFirmenName As Label
    Friend WithEvents lblFirmenName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PropertiesBindingSource As BindingSource
    Friend WithEvents PropertiesTableAdapter As _WSL_AdressenDataSetTableAdapters.propertiesTableAdapter
    Friend WithEvents Panel3 As Panel
End Class
