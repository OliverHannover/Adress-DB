<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Personensuche
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Personensuche))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me._WSL_AdressenDataSet = New Adress_DB._WSL_AdressenDataSet()
        Me.KontakteMitAdresseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KontakteMitAdresseTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.KontakteMitAdresseTableAdapter()
        Me.TableAdapterManager = New Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager()
        Me.KontakteMitAdresseDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LBL_FirmenName = New System.Windows.Forms.Label()
        Me.LBL_IDKontakt = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me._WSL_AdressenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KontakteMitAdresseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KontakteMitAdresseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.LBL_IDKontakt)
        Me.Panel1.Controls.Add(Me.LBL_FirmenName)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 278)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 43)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.Adress_DB.My.Resources.Resources.ContactCard_16x
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(794, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Anzeigen"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        '_WSL_AdressenDataSet
        '
        Me._WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet"
        Me._WSL_AdressenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KontakteMitAdresseBindingSource
        '
        Me.KontakteMitAdresseBindingSource.DataMember = "KontakteMitAdresse"
        Me.KontakteMitAdresseBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'KontakteMitAdresseTableAdapter
        '
        Me.KontakteMitAdresseTableAdapter.ClearBeforeFill = True
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
        'KontakteMitAdresseDataGridView
        '
        Me.KontakteMitAdresseDataGridView.AllowUserToAddRows = False
        Me.KontakteMitAdresseDataGridView.AllowUserToDeleteRows = False
        Me.KontakteMitAdresseDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KontakteMitAdresseDataGridView.AutoGenerateColumns = False
        Me.KontakteMitAdresseDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.KontakteMitAdresseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.KontakteMitAdresseDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.KontakteMitAdresseDataGridView.DataSource = Me.KontakteMitAdresseBindingSource
        Me.KontakteMitAdresseDataGridView.Location = New System.Drawing.Point(1, 5)
        Me.KontakteMitAdresseDataGridView.Name = "KontakteMitAdresseDataGridView"
        Me.KontakteMitAdresseDataGridView.RowHeadersVisible = False
        Me.KontakteMitAdresseDataGridView.Size = New System.Drawing.Size(885, 271)
        Me.KontakteMitAdresseDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDKontakt"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDKontakt"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Nachname"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Nachname"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Vorname"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Vorname"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "EmailAddresse"
        Me.DataGridViewTextBoxColumn13.HeaderText = "EmailAddresse"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 120
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "FirmenName"
        Me.DataGridViewTextBoxColumn20.HeaderText = "FirmenName"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 300
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Straße"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Straße"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ort"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ort"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'LBL_FirmenName
        '
        Me.LBL_FirmenName.AutoSize = True
        Me.LBL_FirmenName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteMitAdresseBindingSource, "FirmenName", True))
        Me.LBL_FirmenName.Location = New System.Drawing.Point(81, 14)
        Me.LBL_FirmenName.Name = "LBL_FirmenName"
        Me.LBL_FirmenName.Size = New System.Drawing.Size(66, 13)
        Me.LBL_FirmenName.TabIndex = 1
        Me.LBL_FirmenName.Text = "FirmenName"
        '
        'LBL_IDKontakt
        '
        Me.LBL_IDKontakt.AutoSize = True
        Me.LBL_IDKontakt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontakteMitAdresseBindingSource, "IDKontakt", True))
        Me.LBL_IDKontakt.Location = New System.Drawing.Point(3, 14)
        Me.LBL_IDKontakt.Name = "LBL_IDKontakt"
        Me.LBL_IDKontakt.Size = New System.Drawing.Size(55, 13)
        Me.LBL_IDKontakt.TabIndex = 2
        Me.LBL_IDKontakt.Text = "IDKontakt"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 322)
        Me.Controls.Add(Me.KontakteMitAdresseDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form7"
        Me.Text = "Personensuche"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me._WSL_AdressenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KontakteMitAdresseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KontakteMitAdresseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents _WSL_AdressenDataSet As _WSL_AdressenDataSet
    Friend WithEvents KontakteMitAdresseBindingSource As BindingSource
    Friend WithEvents KontakteMitAdresseTableAdapter As _WSL_AdressenDataSetTableAdapters.KontakteMitAdresseTableAdapter
    Friend WithEvents TableAdapterManager As _WSL_AdressenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KontakteMitAdresseDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents LBL_FirmenName As Label
    Friend WithEvents LBL_IDKontakt As Label
End Class
