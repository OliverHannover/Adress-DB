﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim SachbearbeiterLabel As System.Windows.Forms.Label
        Dim KuerzelLabel As System.Windows.Forms.Label
        Dim DurchwahlLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim JobtitleLabel As System.Windows.Forms.Label
        Dim EnglJobtitleLabel As System.Windows.Forms.Label
        Dim AktivLabel As System.Windows.Forms.Label
        Dim LoginLabel As System.Windows.Forms.Label
        Dim AdminLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._WSL_AdressenDataSet = New Adress_DB._WSL_AdressenDataSet()
        Me.SachbearbeiterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SachbearbeiterTableAdapter = New Adress_DB._WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter()
        Me.TableAdapterManager = New Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager()
        Me.SachbearbeiterDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDSachbearbeiter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTN_Schliessen = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PNL_Edit = New System.Windows.Forms.Panel()
        Me.IDSachbearbeiterLabel1 = New System.Windows.Forms.Label()
        Me.EnglJobtitleTextBox = New System.Windows.Forms.TextBox()
        Me.PNL_Admin = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LockedCheckBox = New System.Windows.Forms.CheckBox()
        Me.AdminCheckBox = New System.Windows.Forms.CheckBox()
        Me.SachbearbeiterBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SachbearbeiterBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SachbearbeiterTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KuerzelTextBox = New System.Windows.Forms.TextBox()
        Me.LoginTextBox = New System.Windows.Forms.TextBox()
        Me.DurchwahlTextBox = New System.Windows.Forms.TextBox()
        Me.AktivCheckBox = New System.Windows.Forms.CheckBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.JobtitleTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        SachbearbeiterLabel = New System.Windows.Forms.Label()
        KuerzelLabel = New System.Windows.Forms.Label()
        DurchwahlLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        JobtitleLabel = New System.Windows.Forms.Label()
        EnglJobtitleLabel = New System.Windows.Forms.Label()
        AktivLabel = New System.Windows.Forms.Label()
        LoginLabel = New System.Windows.Forms.Label()
        AdminLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me._WSL_AdressenDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SachbearbeiterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SachbearbeiterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PNL_Edit.SuspendLayout()
        Me.PNL_Admin.SuspendLayout()
        CType(Me.SachbearbeiterBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SachbearbeiterBindingNavigator.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SachbearbeiterLabel
        '
        SachbearbeiterLabel.AutoSize = True
        SachbearbeiterLabel.Location = New System.Drawing.Point(14, 11)
        SachbearbeiterLabel.Name = "SachbearbeiterLabel"
        SachbearbeiterLabel.Size = New System.Drawing.Size(82, 13)
        SachbearbeiterLabel.TabIndex = 3
        SachbearbeiterLabel.Text = "Sachbearbeiter:"
        '
        'KuerzelLabel
        '
        KuerzelLabel.AutoSize = True
        KuerzelLabel.Location = New System.Drawing.Point(51, 37)
        KuerzelLabel.Name = "KuerzelLabel"
        KuerzelLabel.Size = New System.Drawing.Size(45, 13)
        KuerzelLabel.TabIndex = 5
        KuerzelLabel.Text = "Kuerzel:"
        '
        'DurchwahlLabel
        '
        DurchwahlLabel.AutoSize = True
        DurchwahlLabel.Location = New System.Drawing.Point(35, 89)
        DurchwahlLabel.Name = "DurchwahlLabel"
        DurchwahlLabel.Size = New System.Drawing.Size(61, 13)
        DurchwahlLabel.TabIndex = 7
        DurchwahlLabel.Text = "Durchwahl:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(61, 115)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "Email:"
        '
        'JobtitleLabel
        '
        JobtitleLabel.AutoSize = True
        JobtitleLabel.Location = New System.Drawing.Point(14, 138)
        JobtitleLabel.Name = "JobtitleLabel"
        JobtitleLabel.Size = New System.Drawing.Size(85, 13)
        JobtitleLabel.TabIndex = 11
        JobtitleLabel.Text = "Jobtitel/Position:"
        '
        'EnglJobtitleLabel
        '
        EnglJobtitleLabel.AutoSize = True
        EnglJobtitleLabel.Location = New System.Drawing.Point(14, 167)
        EnglJobtitleLabel.Name = "EnglJobtitleLabel"
        EnglJobtitleLabel.Size = New System.Drawing.Size(85, 13)
        EnglJobtitleLabel.TabIndex = 13
        EnglJobtitleLabel.Text = "Jobtitel/Position:"
        '
        'AktivLabel
        '
        AktivLabel.AutoSize = True
        AktivLabel.Location = New System.Drawing.Point(99, 199)
        AktivLabel.Name = "AktivLabel"
        AktivLabel.Size = New System.Drawing.Size(121, 13)
        AktivLabel.TabIndex = 15
        AktivLabel.Text = "Sachbearbeiter ist aktiv:"
        '
        'LoginLabel
        '
        LoginLabel.AutoSize = True
        LoginLabel.Location = New System.Drawing.Point(60, 63)
        LoginLabel.Name = "LoginLabel"
        LoginLabel.Size = New System.Drawing.Size(36, 13)
        LoginLabel.TabIndex = 17
        LoginLabel.Text = "Login:"
        '
        'AdminLabel
        '
        AdminLabel.AutoSize = True
        AdminLabel.Location = New System.Drawing.Point(3, 9)
        AdminLabel.Name = "AdminLabel"
        AdminLabel.Size = New System.Drawing.Size(127, 13)
        AdminLabel.TabIndex = 19
        AdminLabel.Text = "Sachbearbeiter ist Admin:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 38)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Benutzerliste bearbeiten"
        '
        '_WSL_AdressenDataSet
        '
        Me._WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet"
        Me._WSL_AdressenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SachbearbeiterBindingSource
        '
        Me.SachbearbeiterBindingSource.DataMember = "Sachbearbeiter"
        Me.SachbearbeiterBindingSource.DataSource = Me._WSL_AdressenDataSet
        '
        'SachbearbeiterTableAdapter
        '
        Me.SachbearbeiterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdressenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BelegeTableAdapter = Nothing
        Me.TableAdapterManager.FirmenNameTableAdapter = Nothing
        Me.TableAdapterManager.KonfigurationTableAdapter = Nothing
        Me.TableAdapterManager.KontakteTableAdapter = Nothing
        Me.TableAdapterManager.KontoTableAdapter = Nothing
        Me.TableAdapterManager.LogTabelleTableAdapter = Nothing
        Me.TableAdapterManager.SachbearbeiterTableAdapter = Me.SachbearbeiterTableAdapter
        Me.TableAdapterManager.UpdateOrder = Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SachbearbeiterDataGridView
        '
        Me.SachbearbeiterDataGridView.AllowUserToAddRows = False
        Me.SachbearbeiterDataGridView.AllowUserToDeleteRows = False
        Me.SachbearbeiterDataGridView.AutoGenerateColumns = False
        Me.SachbearbeiterDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SachbearbeiterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SachbearbeiterDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSachbearbeiter, Me.DataGridViewTextBoxColumn2})
        Me.SachbearbeiterDataGridView.DataSource = Me.SachbearbeiterBindingSource
        Me.SachbearbeiterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SachbearbeiterDataGridView.GridColor = System.Drawing.Color.White
        Me.SachbearbeiterDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SachbearbeiterDataGridView.Name = "SachbearbeiterDataGridView"
        Me.SachbearbeiterDataGridView.RowHeadersVisible = False
        Me.SachbearbeiterDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SachbearbeiterDataGridView.Size = New System.Drawing.Size(204, 354)
        Me.SachbearbeiterDataGridView.TabIndex = 2
        '
        'IDSachbearbeiter
        '
        Me.IDSachbearbeiter.DataPropertyName = "IDSachbearbeiter"
        Me.IDSachbearbeiter.HeaderText = "ID"
        Me.IDSachbearbeiter.Name = "IDSachbearbeiter"
        Me.IDSachbearbeiter.ReadOnly = True
        Me.IDSachbearbeiter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IDSachbearbeiter.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Sachbearbeiter"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sachbearbeiter"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 170
        '
        'BTN_Schliessen
        '
        Me.BTN_Schliessen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Schliessen.Image = Global.Adress_DB.My.Resources.Resources.CloseSolution_16x
        Me.BTN_Schliessen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTN_Schliessen.Location = New System.Drawing.Point(549, 10)
        Me.BTN_Schliessen.Name = "BTN_Schliessen"
        Me.BTN_Schliessen.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Schliessen.TabIndex = 23
        Me.BTN_Schliessen.Text = "schließen"
        Me.BTN_Schliessen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_Schliessen.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.BTN_Schliessen)
        Me.Panel2.Location = New System.Drawing.Point(3, 413)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(635, 43)
        Me.Panel2.TabIndex = 24
        '
        'PNL_Edit
        '
        Me.PNL_Edit.Controls.Add(Me.IDSachbearbeiterLabel1)
        Me.PNL_Edit.Controls.Add(Me.EnglJobtitleTextBox)
        Me.PNL_Edit.Controls.Add(Me.PNL_Admin)
        Me.PNL_Edit.Controls.Add(Me.SachbearbeiterBindingNavigator)
        Me.PNL_Edit.Controls.Add(Me.SachbearbeiterTextBox)
        Me.PNL_Edit.Controls.Add(Me.Label3)
        Me.PNL_Edit.Controls.Add(SachbearbeiterLabel)
        Me.PNL_Edit.Controls.Add(Me.Label2)
        Me.PNL_Edit.Controls.Add(Me.KuerzelTextBox)
        Me.PNL_Edit.Controls.Add(LoginLabel)
        Me.PNL_Edit.Controls.Add(KuerzelLabel)
        Me.PNL_Edit.Controls.Add(Me.LoginTextBox)
        Me.PNL_Edit.Controls.Add(Me.DurchwahlTextBox)
        Me.PNL_Edit.Controls.Add(AktivLabel)
        Me.PNL_Edit.Controls.Add(DurchwahlLabel)
        Me.PNL_Edit.Controls.Add(Me.AktivCheckBox)
        Me.PNL_Edit.Controls.Add(Me.EmailTextBox)
        Me.PNL_Edit.Controls.Add(EnglJobtitleLabel)
        Me.PNL_Edit.Controls.Add(EmailLabel)
        Me.PNL_Edit.Controls.Add(Me.JobtitleTextBox)
        Me.PNL_Edit.Controls.Add(JobtitleLabel)
        Me.PNL_Edit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNL_Edit.Location = New System.Drawing.Point(213, 3)
        Me.PNL_Edit.Name = "PNL_Edit"
        Me.PNL_Edit.Size = New System.Drawing.Size(419, 354)
        Me.PNL_Edit.TabIndex = 26
        '
        'IDSachbearbeiterLabel1
        '
        Me.IDSachbearbeiterLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "IDSachbearbeiter", True))
        Me.IDSachbearbeiterLabel1.Location = New System.Drawing.Point(346, 11)
        Me.IDSachbearbeiterLabel1.Name = "IDSachbearbeiterLabel1"
        Me.IDSachbearbeiterLabel1.Size = New System.Drawing.Size(52, 17)
        Me.IDSachbearbeiterLabel1.TabIndex = 26
        Me.IDSachbearbeiterLabel1.Text = "ID"
        '
        'EnglJobtitleTextBox
        '
        Me.EnglJobtitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "EnglJobtitle", True))
        Me.EnglJobtitleTextBox.Location = New System.Drawing.Point(102, 164)
        Me.EnglJobtitleTextBox.Name = "EnglJobtitleTextBox"
        Me.EnglJobtitleTextBox.Size = New System.Drawing.Size(238, 20)
        Me.EnglJobtitleTextBox.TabIndex = 14
        '
        'PNL_Admin
        '
        Me.PNL_Admin.BackColor = System.Drawing.Color.MistyRose
        Me.PNL_Admin.Controls.Add(Me.Label4)
        Me.PNL_Admin.Controls.Add(Me.LockedCheckBox)
        Me.PNL_Admin.Controls.Add(AdminLabel)
        Me.PNL_Admin.Controls.Add(Me.AdminCheckBox)
        Me.PNL_Admin.Enabled = False
        Me.PNL_Admin.Location = New System.Drawing.Point(95, 245)
        Me.PNL_Admin.Name = "PNL_Admin"
        Me.PNL_Admin.Size = New System.Drawing.Size(159, 52)
        Me.PNL_Admin.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "blockiert:"
        '
        'LockedCheckBox
        '
        Me.LockedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SachbearbeiterBindingSource, "locked", True))
        Me.LockedCheckBox.Location = New System.Drawing.Point(136, 31)
        Me.LockedCheckBox.Name = "LockedCheckBox"
        Me.LockedCheckBox.Size = New System.Drawing.Size(17, 18)
        Me.LockedCheckBox.TabIndex = 26
        Me.LockedCheckBox.UseVisualStyleBackColor = True
        '
        'AdminCheckBox
        '
        Me.AdminCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SachbearbeiterBindingSource, "Admin", True))
        Me.AdminCheckBox.Location = New System.Drawing.Point(136, 4)
        Me.AdminCheckBox.Name = "AdminCheckBox"
        Me.AdminCheckBox.Size = New System.Drawing.Size(17, 24)
        Me.AdminCheckBox.TabIndex = 20
        Me.AdminCheckBox.UseVisualStyleBackColor = True
        '
        'SachbearbeiterBindingNavigator
        '
        Me.SachbearbeiterBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SachbearbeiterBindingNavigator.BindingSource = Me.SachbearbeiterBindingSource
        Me.SachbearbeiterBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SachbearbeiterBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SachbearbeiterBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.SachbearbeiterBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SachbearbeiterBindingNavigatorSaveItem})
        Me.SachbearbeiterBindingNavigator.Location = New System.Drawing.Point(54, 322)
        Me.SachbearbeiterBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SachbearbeiterBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SachbearbeiterBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SachbearbeiterBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SachbearbeiterBindingNavigator.Name = "SachbearbeiterBindingNavigator"
        Me.SachbearbeiterBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SachbearbeiterBindingNavigator.Size = New System.Drawing.Size(287, 25)
        Me.SachbearbeiterBindingNavigator.TabIndex = 1
        Me.SachbearbeiterBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Neu hinzufügen"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Enabled = False
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Löschen"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Erste verschieben"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Vorherige verschieben"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 25)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Aktuelle Position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Letzte verschieben"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SachbearbeiterBindingNavigatorSaveItem
        '
        Me.SachbearbeiterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SachbearbeiterBindingNavigatorSaveItem.Image = CType(resources.GetObject("SachbearbeiterBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SachbearbeiterBindingNavigatorSaveItem.Name = "SachbearbeiterBindingNavigatorSaveItem"
        Me.SachbearbeiterBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SachbearbeiterBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'SachbearbeiterTextBox
        '
        Me.SachbearbeiterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "Sachbearbeiter", True))
        Me.SachbearbeiterTextBox.Location = New System.Drawing.Point(102, 8)
        Me.SachbearbeiterTextBox.Name = "SachbearbeiterTextBox"
        Me.SachbearbeiterTextBox.Size = New System.Drawing.Size(238, 20)
        Me.SachbearbeiterTextBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(346, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "(englisch)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(346, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "(deutsch)"
        '
        'KuerzelTextBox
        '
        Me.KuerzelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "Kuerzel", True))
        Me.KuerzelTextBox.Location = New System.Drawing.Point(102, 34)
        Me.KuerzelTextBox.Name = "KuerzelTextBox"
        Me.KuerzelTextBox.Size = New System.Drawing.Size(238, 20)
        Me.KuerzelTextBox.TabIndex = 6
        '
        'LoginTextBox
        '
        Me.LoginTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "Login", True))
        Me.LoginTextBox.Location = New System.Drawing.Point(102, 60)
        Me.LoginTextBox.Name = "LoginTextBox"
        Me.LoginTextBox.Size = New System.Drawing.Size(238, 20)
        Me.LoginTextBox.TabIndex = 18
        '
        'DurchwahlTextBox
        '
        Me.DurchwahlTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "Durchwahl", True))
        Me.DurchwahlTextBox.Location = New System.Drawing.Point(102, 86)
        Me.DurchwahlTextBox.Name = "DurchwahlTextBox"
        Me.DurchwahlTextBox.Size = New System.Drawing.Size(238, 20)
        Me.DurchwahlTextBox.TabIndex = 8
        '
        'AktivCheckBox
        '
        Me.AktivCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SachbearbeiterBindingSource, "Aktiv", True))
        Me.AktivCheckBox.Location = New System.Drawing.Point(231, 194)
        Me.AktivCheckBox.Name = "AktivCheckBox"
        Me.AktivCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AktivCheckBox.TabIndex = 16
        Me.AktivCheckBox.UseVisualStyleBackColor = True
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(102, 112)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(238, 20)
        Me.EmailTextBox.TabIndex = 10
        '
        'JobtitleTextBox
        '
        Me.JobtitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SachbearbeiterBindingSource, "Jobtitle", True))
        Me.JobtitleTextBox.Location = New System.Drawing.Point(102, 138)
        Me.JobtitleTextBox.Name = "JobtitleTextBox"
        Me.JobtitleTextBox.Size = New System.Drawing.Size(238, 20)
        Me.JobtitleTextBox.TabIndex = 12
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.29032!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(641, 459)
        Me.TableLayoutPanel1.TabIndex = 27
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.13679!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.8632!))
        Me.TableLayoutPanel2.Controls.Add(Me.PNL_Edit, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.SachbearbeiterDataGridView, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 47)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(635, 360)
        Me.TableLayoutPanel2.TabIndex = 25
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 459)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.Text = "Benutzerliste"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me._WSL_AdressenDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SachbearbeiterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SachbearbeiterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.PNL_Edit.ResumeLayout(False)
        Me.PNL_Edit.PerformLayout()
        Me.PNL_Admin.ResumeLayout(False)
        Me.PNL_Admin.PerformLayout()
        CType(Me.SachbearbeiterBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SachbearbeiterBindingNavigator.ResumeLayout(False)
        Me.SachbearbeiterBindingNavigator.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents _WSL_AdressenDataSet As _WSL_AdressenDataSet
    Friend WithEvents SachbearbeiterBindingSource As BindingSource
    Friend WithEvents SachbearbeiterTableAdapter As _WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter
    Friend WithEvents TableAdapterManager As _WSL_AdressenDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SachbearbeiterDataGridView As DataGridView
    Friend WithEvents BTN_Schliessen As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PNL_Edit As Panel
    Friend WithEvents EnglJobtitleTextBox As TextBox
    Friend WithEvents PNL_Admin As Panel
    Friend WithEvents AdminCheckBox As CheckBox
    Friend WithEvents SachbearbeiterBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SachbearbeiterBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SachbearbeiterTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents KuerzelTextBox As TextBox
    Friend WithEvents LoginTextBox As TextBox
    Friend WithEvents DurchwahlTextBox As TextBox
    Friend WithEvents AktivCheckBox As CheckBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents JobtitleTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LockedCheckBox As CheckBox
    Friend WithEvents IDSachbearbeiterLabel1 As Label
    Friend WithEvents IDSachbearbeiter As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
End Class
