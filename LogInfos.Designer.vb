<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loginformationen
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loginformationen))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTN_Alle = New System.Windows.Forms.Button()
        Me.BTN_Aktuell = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._WSL_AdressenDataSet = New Adress_DB._WSL_AdressenDataSet()
        Me.TableAdapterManager = New Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BTN_Schliessen = New System.Windows.Forms.Button()
        Me.LogTabelleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogTabelleTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.LogTabelleTableAdapter()
        Me.LogTabelleDataGridView = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirmenName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me._WSL_AdressenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.LogTabelleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogTabelleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.BTN_Alle)
        Me.Panel2.Controls.Add(Me.BTN_Aktuell)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(935, 33)
        Me.Panel2.TabIndex = 26
        '
        'BTN_Alle
        '
        Me.BTN_Alle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Alle.Location = New System.Drawing.Point(681, 6)
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
        Me.BTN_Aktuell.Location = New System.Drawing.Point(768, 6)
        Me.BTN_Aktuell.Name = "BTN_Aktuell"
        Me.BTN_Aktuell.Size = New System.Drawing.Size(156, 23)
        Me.BTN_Aktuell.TabIndex = 1
        Me.BTN_Aktuell.Text = "aktuellen Geschäftspartner"
        Me.BTN_Aktuell.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Loginformationen"
        '
        '_WSL_AdressenDataSet
        '
        Me._WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet"
        Me._WSL_AdressenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Controls.Add(Me.BTN_Schliessen)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 343)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(935, 40)
        Me.Panel3.TabIndex = 28
        '
        'BTN_Schliessen
        '
        Me.BTN_Schliessen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Schliessen.Image = Global.Adress_DB.My.Resources.Resources.CloseSolution_16x
        Me.BTN_Schliessen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Schliessen.Location = New System.Drawing.Point(844, 10)
        Me.BTN_Schliessen.Name = "BTN_Schliessen"
        Me.BTN_Schliessen.Size = New System.Drawing.Size(80, 22)
        Me.BTN_Schliessen.TabIndex = 16
        Me.BTN_Schliessen.Text = "Schließen"
        Me.BTN_Schliessen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Schliessen.UseVisualStyleBackColor = True
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
        'LogTabelleDataGridView
        '
        Me.LogTabelleDataGridView.AutoGenerateColumns = False
        Me.LogTabelleDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.LogTabelleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LogTabelleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.FirmenName, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.LogTabelleDataGridView.DataSource = Me.LogTabelleBindingSource
        Me.LogTabelleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogTabelleDataGridView.Location = New System.Drawing.Point(3, 42)
        Me.LogTabelleDataGridView.Name = "LogTabelleDataGridView"
        Me.LogTabelleDataGridView.RowHeadersVisible = False
        Me.LogTabelleDataGridView.Size = New System.Drawing.Size(935, 295)
        Me.LogTabelleDataGridView.TabIndex = 29
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LogTabelleDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.7489!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(941, 386)
        Me.TableLayoutPanel1.TabIndex = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'FirmenName
        '
        Me.FirmenName.DataPropertyName = "FirmenName"
        Me.FirmenName.HeaderText = "FirmenName"
        Me.FirmenName.Name = "FirmenName"
        Me.FirmenName.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Meldung"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Meldung"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Tabelle"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tabelle"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IDInTabelle"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IDInTabelle"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Hinweis"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Hinweis"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Login"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Login"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Datum"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Datum"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IDFirmenName"
        Me.DataGridViewTextBoxColumn8.HeaderText = "IDFirmenName"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Loginformationen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 386)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Loginformationen"
        Me.Text = "Log-Informationen"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me._WSL_AdressenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.LogTabelleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogTabelleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BTN_Alle As Button
    Friend WithEvents BTN_Aktuell As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents _WSL_AdressenDataSet As _WSL_AdressenDataSet
    Friend WithEvents TableAdapterManager As _WSL_AdressenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTN_Schliessen As Button
    Friend WithEvents LogTabelleBindingSource As BindingSource
    Friend WithEvents LogTabelleTableAdapter As _WSL_AdressenDataSetTableAdapters.LogTabelleTableAdapter
    Friend WithEvents LogTabelleDataGridView As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FirmenName As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
