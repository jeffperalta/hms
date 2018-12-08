<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRefund
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.tbcRefund = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.chkSelectAll = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btnRemove = New System.Windows.Forms.Button
        Me.Label45 = New System.Windows.Forms.Label
        Me.lblCountRefundsToRelease = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.lblTotalAmountToRelease = New System.Windows.Forms.Label
        Me.lsvToRelease = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.dtpDateReleased = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.btnEdit_Info = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.dgvListOfRefundAtRefundIssuance = New System.Windows.Forms.DataGridView
        Me.ListOfFinalRefund = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label40 = New System.Windows.Forms.Label
        Me.lblTotalAmountAtRefundIssuance = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.lblCountAtRefundIssuance = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lblGuestName = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.gbxRefundInformation = New System.Windows.Forms.GroupBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lblTotalBalance = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.lblTotalPayments = New System.Windows.Forms.Label
        Me.lblTotalCharges = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.lsvTransactions = New System.Windows.Forms.ListView
        Me.ColumnHeader19 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader20 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader22 = New System.Windows.Forms.ColumnHeader
        Me.lblReq = New System.Windows.Forms.Label
        Me.cboStatus_Input = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpDateIncurred = New System.Windows.Forms.DateTimePicker
        Me.txtOriginalAmount = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtAmountToIssue = New System.Windows.Forms.TextBox
        Me.txtRefundPercentage = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnSaveEditRefundInformation = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.dtpExpirationDate = New System.Windows.Forms.DateTimePicker
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.lblCountListAtRefundView = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.gbxInformation = New System.Windows.Forms.GroupBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.lblTotalAmountToReleaseAtRefundInformation = New System.Windows.Forms.Label
        Me.dgvListOfRefundAtRefundView = New System.Windows.Forms.DataGridView
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblTotalCountRefInfo = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.btnMarkAsUnexpired = New System.Windows.Forms.Button
        Me.lblTotalAmountToIssueMarked = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.lblCountExpired = New System.Windows.Forms.Label
        Me.dgvExpiredButMarked = New System.Windows.Forms.DataGridView
        Me.lblCountRefundExpired = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.dtpDateOfExpiration = New System.Windows.Forms.DateTimePicker
        Me.lblTotalAmountToIssueUnmarked = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.btnMarkAsExpired = New System.Windows.Forms.Button
        Me.lblCountUnmarked = New System.Windows.Forms.Label
        Me.dgvExpiredButNotMarked = New System.Windows.Forms.DataGridView
        Me.btnClose = New System.Windows.Forms.Button
        Me.tsActivities = New System.Windows.Forms.ToolStrip
        Me.tsbGuestSearch = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbActGuestInfo = New System.Windows.Forms.ToolStripButton
        Me.tss3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.tss1 = New System.Windows.Forms.ToolStripSeparator
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.DataGridView4 = New System.Windows.Forms.DataGridView
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.DataGridView7 = New System.Windows.Forms.DataGridView
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.DataGridView8 = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker6 = New System.Windows.Forms.DateTimePicker
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.lblClose = New System.Windows.Forms.LinkLabel
        Me.tbcRefund.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.dgvListOfRefundAtRefundIssuance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListOfFinalRefund.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbxRefundInformation.SuspendLayout()
        Me.gbxInformation.SuspendLayout()
        CType(Me.dgvListOfRefundAtRefundView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.dgvExpiredButMarked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dgvExpiredButNotMarked, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsActivities.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcRefund
        '
        Me.tbcRefund.Controls.Add(Me.TabPage2)
        Me.tbcRefund.Controls.Add(Me.TabPage1)
        Me.tbcRefund.Controls.Add(Me.TabPage3)
        Me.tbcRefund.Location = New System.Drawing.Point(138, 13)
        Me.tbcRefund.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbcRefund.Name = "tbcRefund"
        Me.tbcRefund.SelectedIndex = 0
        Me.tbcRefund.Size = New System.Drawing.Size(845, 592)
        Me.tbcRefund.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chkSelectAll)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.dtpDateReleased)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.GroupBox11)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Size = New System.Drawing.Size(837, 561)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Refund Issuance"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chkSelectAll
        '
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.Checked = True
        Me.chkSelectAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSelectAll.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelectAll.Location = New System.Drawing.Point(495, 12)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(84, 22)
        Me.chkSelectAll.TabIndex = 0
        Me.chkSelectAll.Text = "Select All"
        Me.chkSelectAll.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnRemove)
        Me.GroupBox5.Controls.Add(Me.Label45)
        Me.GroupBox5.Controls.Add(Me.lblCountRefundsToRelease)
        Me.GroupBox5.Controls.Add(Me.Label43)
        Me.GroupBox5.Controls.Add(Me.btnSave)
        Me.GroupBox5.Controls.Add(Me.lblTotalAmountToRelease)
        Me.GroupBox5.Controls.Add(Me.lsvToRelease)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 320)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(827, 233)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "List of Refunds to Issue"
        '
        'btnRemove
        '
        Me.btnRemove.AutoSize = True
        Me.btnRemove.Location = New System.Drawing.Point(673, 197)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(70, 28)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(6, 160)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(47, 18)
        Me.Label45.TabIndex = 1
        Me.Label45.Text = "Count:"
        '
        'lblCountRefundsToRelease
        '
        Me.lblCountRefundsToRelease.AutoSize = True
        Me.lblCountRefundsToRelease.BackColor = System.Drawing.Color.Transparent
        Me.lblCountRefundsToRelease.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountRefundsToRelease.Location = New System.Drawing.Point(52, 160)
        Me.lblCountRefundsToRelease.Name = "lblCountRefundsToRelease"
        Me.lblCountRefundsToRelease.Size = New System.Drawing.Size(15, 18)
        Me.lblCountRefundsToRelease.TabIndex = 2
        Me.lblCountRefundsToRelease.Text = "0"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(588, 160)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(95, 18)
        Me.Label43.TabIndex = 3
        Me.Label43.Text = "Total Amount:"
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.Location = New System.Drawing.Point(749, 197)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 28)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblTotalAmountToRelease
        '
        Me.lblTotalAmountToRelease.AutoSize = True
        Me.lblTotalAmountToRelease.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAmountToRelease.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountToRelease.Location = New System.Drawing.Point(689, 160)
        Me.lblTotalAmountToRelease.Name = "lblTotalAmountToRelease"
        Me.lblTotalAmountToRelease.Size = New System.Drawing.Size(16, 18)
        Me.lblTotalAmountToRelease.TabIndex = 4
        Me.lblTotalAmountToRelease.Text = "0"
        Me.lblTotalAmountToRelease.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsvToRelease
        '
        Me.lsvToRelease.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader17, Me.ColumnHeader18})
        Me.lsvToRelease.Dock = System.Windows.Forms.DockStyle.Top
        Me.lsvToRelease.FullRowSelect = True
        Me.lsvToRelease.GridLines = True
        Me.lsvToRelease.HideSelection = False
        Me.lsvToRelease.Location = New System.Drawing.Point(3, 20)
        Me.lsvToRelease.MultiSelect = False
        Me.lsvToRelease.Name = "lsvToRelease"
        Me.lsvToRelease.Size = New System.Drawing.Size(821, 127)
        Me.lsvToRelease.TabIndex = 0
        Me.lsvToRelease.UseCompatibleStateImageBehavior = False
        Me.lsvToRelease.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Refund ID"
        Me.ColumnHeader7.Width = 84
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Name"
        Me.ColumnHeader8.Width = 84
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Original Amount"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 115
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Amount To Issue"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader12.Width = 139
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Transaction"
        Me.ColumnHeader13.Width = 0
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Refund Date"
        Me.ColumnHeader14.Width = 129
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Expiration Date"
        Me.ColumnHeader17.Width = 152
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Remarks"
        Me.ColumnHeader18.Width = 108
        '
        'dtpDateReleased
        '
        Me.dtpDateReleased.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDateReleased.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateReleased.Location = New System.Drawing.Point(679, 8)
        Me.dtpDateReleased.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpDateReleased.Name = "dtpDateReleased"
        Me.dtpDateReleased.Size = New System.Drawing.Size(151, 23)
        Me.dtpDateReleased.TabIndex = 2
        Me.dtpDateReleased.Value = New Date(2006, 8, 25, 22, 19, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(594, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 18)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Date Issued:"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.btnEdit_Info)
        Me.GroupBox11.Controls.Add(Me.btnAdd)
        Me.GroupBox11.Controls.Add(Me.dgvListOfRefundAtRefundIssuance)
        Me.GroupBox11.Controls.Add(Me.Label40)
        Me.GroupBox11.Controls.Add(Me.lblTotalAmountAtRefundIssuance)
        Me.GroupBox11.Controls.Add(Me.Label42)
        Me.GroupBox11.Controls.Add(Me.lblCountAtRefundIssuance)
        Me.GroupBox11.Location = New System.Drawing.Point(7, 30)
        Me.GroupBox11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox11.Size = New System.Drawing.Size(826, 282)
        Me.GroupBox11.TabIndex = 3
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "List of Finalized Refunds"
        '
        'btnEdit_Info
        '
        Me.btnEdit_Info.AutoSize = True
        Me.btnEdit_Info.Location = New System.Drawing.Point(630, 249)
        Me.btnEdit_Info.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEdit_Info.Name = "btnEdit_Info"
        Me.btnEdit_Info.Size = New System.Drawing.Size(114, 28)
        Me.btnEdit_Info.TabIndex = 5
        Me.btnEdit_Info.Text = "&Edit Information"
        Me.btnEdit_Info.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.Location = New System.Drawing.Point(750, 249)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 28)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Release"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvListOfRefundAtRefundIssuance
        '
        Me.dgvListOfRefundAtRefundIssuance.AllowUserToAddRows = False
        Me.dgvListOfRefundAtRefundIssuance.AllowUserToDeleteRows = False
        Me.dgvListOfRefundAtRefundIssuance.AllowUserToOrderColumns = True
        Me.dgvListOfRefundAtRefundIssuance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvListOfRefundAtRefundIssuance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvListOfRefundAtRefundIssuance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListOfRefundAtRefundIssuance.ContextMenuStrip = Me.ListOfFinalRefund
        Me.dgvListOfRefundAtRefundIssuance.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvListOfRefundAtRefundIssuance.Location = New System.Drawing.Point(3, 20)
        Me.dgvListOfRefundAtRefundIssuance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvListOfRefundAtRefundIssuance.MultiSelect = False
        Me.dgvListOfRefundAtRefundIssuance.Name = "dgvListOfRefundAtRefundIssuance"
        Me.dgvListOfRefundAtRefundIssuance.ReadOnly = True
        Me.dgvListOfRefundAtRefundIssuance.RowHeadersVisible = False
        Me.dgvListOfRefundAtRefundIssuance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListOfRefundAtRefundIssuance.Size = New System.Drawing.Size(820, 196)
        Me.dgvListOfRefundAtRefundIssuance.TabIndex = 0
        '
        'ListOfFinalRefund
        '
        Me.ListOfFinalRefund.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditInformationToolStripMenuItem})
        Me.ListOfFinalRefund.Name = "ListOfFinalRefund"
        Me.ListOfFinalRefund.Size = New System.Drawing.Size(201, 26)
        '
        'EditInformationToolStripMenuItem
        '
        Me.EditInformationToolStripMenuItem.Name = "EditInformationToolStripMenuItem"
        Me.EditInformationToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditInformationToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.EditInformationToolStripMenuItem.Text = "Edit Information"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(587, 220)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(95, 18)
        Me.Label40.TabIndex = 3
        Me.Label40.Text = "Total Amount:"
        '
        'lblTotalAmountAtRefundIssuance
        '
        Me.lblTotalAmountAtRefundIssuance.AutoSize = True
        Me.lblTotalAmountAtRefundIssuance.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAmountAtRefundIssuance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountAtRefundIssuance.Location = New System.Drawing.Point(688, 220)
        Me.lblTotalAmountAtRefundIssuance.Name = "lblTotalAmountAtRefundIssuance"
        Me.lblTotalAmountAtRefundIssuance.Size = New System.Drawing.Size(16, 18)
        Me.lblTotalAmountAtRefundIssuance.TabIndex = 4
        Me.lblTotalAmountAtRefundIssuance.Text = "0"
        Me.lblTotalAmountAtRefundIssuance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(5, 220)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(47, 18)
        Me.Label42.TabIndex = 1
        Me.Label42.Text = "Count:"
        '
        'lblCountAtRefundIssuance
        '
        Me.lblCountAtRefundIssuance.AutoSize = True
        Me.lblCountAtRefundIssuance.BackColor = System.Drawing.Color.Transparent
        Me.lblCountAtRefundIssuance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountAtRefundIssuance.Location = New System.Drawing.Point(51, 220)
        Me.lblCountAtRefundIssuance.Name = "lblCountAtRefundIssuance"
        Me.lblCountAtRefundIssuance.Size = New System.Drawing.Size(15, 18)
        Me.lblCountAtRefundIssuance.TabIndex = 2
        Me.lblCountAtRefundIssuance.Text = "0"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblGuestName)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cboStatus)
        Me.TabPage1.Controls.Add(Me.gbxRefundInformation)
        Me.TabPage1.Controls.Add(Me.lblCountListAtRefundView)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.gbxInformation)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(837, 561)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Refund Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblGuestName
        '
        Me.lblGuestName.AutoSize = True
        Me.lblGuestName.BackColor = System.Drawing.Color.Transparent
        Me.lblGuestName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestName.Location = New System.Drawing.Point(93, 15)
        Me.lblGuestName.Name = "lblGuestName"
        Me.lblGuestName.Size = New System.Drawing.Size(131, 18)
        Me.lblGuestName.TabIndex = 1
        Me.lblGuestName.Text = "<Generated by code>"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(637, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Status:"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"", "EXPIRED", "ONHOLD", "RELEASED", "UNFINALIZED"})
        Me.cboStatus.Location = New System.Drawing.Point(688, 16)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(140, 26)
        Me.cboStatus.TabIndex = 3
        '
        'gbxRefundInformation
        '
        Me.gbxRefundInformation.Controls.Add(Me.btnCancel)
        Me.gbxRefundInformation.Controls.Add(Me.lblTotalBalance)
        Me.gbxRefundInformation.Controls.Add(Me.Label52)
        Me.gbxRefundInformation.Controls.Add(Me.Label53)
        Me.gbxRefundInformation.Controls.Add(Me.lblTotalPayments)
        Me.gbxRefundInformation.Controls.Add(Me.lblTotalCharges)
        Me.gbxRefundInformation.Controls.Add(Me.Label54)
        Me.gbxRefundInformation.Controls.Add(Me.Label46)
        Me.gbxRefundInformation.Controls.Add(Me.lsvTransactions)
        Me.gbxRefundInformation.Controls.Add(Me.lblReq)
        Me.gbxRefundInformation.Controls.Add(Me.cboStatus_Input)
        Me.gbxRefundInformation.Controls.Add(Me.Label4)
        Me.gbxRefundInformation.Controls.Add(Me.dtpDateIncurred)
        Me.gbxRefundInformation.Controls.Add(Me.txtOriginalAmount)
        Me.gbxRefundInformation.Controls.Add(Me.Label15)
        Me.gbxRefundInformation.Controls.Add(Me.txtAmountToIssue)
        Me.gbxRefundInformation.Controls.Add(Me.txtRefundPercentage)
        Me.gbxRefundInformation.Controls.Add(Me.Label10)
        Me.gbxRefundInformation.Controls.Add(Me.btnSaveEditRefundInformation)
        Me.gbxRefundInformation.Controls.Add(Me.Label14)
        Me.gbxRefundInformation.Controls.Add(Me.txtRemarks)
        Me.gbxRefundInformation.Controls.Add(Me.Label20)
        Me.gbxRefundInformation.Controls.Add(Me.Label18)
        Me.gbxRefundInformation.Controls.Add(Me.dtpExpirationDate)
        Me.gbxRefundInformation.Controls.Add(Me.Label17)
        Me.gbxRefundInformation.Controls.Add(Me.Label13)
        Me.gbxRefundInformation.Controls.Add(Me.Label22)
        Me.gbxRefundInformation.Controls.Add(Me.Label27)
        Me.gbxRefundInformation.Controls.Add(Me.Label29)
        Me.gbxRefundInformation.Controls.Add(Me.Label39)
        Me.gbxRefundInformation.Controls.Add(Me.Label44)
        Me.gbxRefundInformation.Controls.Add(Me.Label51)
        Me.gbxRefundInformation.Enabled = False
        Me.gbxRefundInformation.Location = New System.Drawing.Point(8, 266)
        Me.gbxRefundInformation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxRefundInformation.Name = "gbxRefundInformation"
        Me.gbxRefundInformation.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxRefundInformation.Size = New System.Drawing.Size(820, 287)
        Me.gbxRefundInformation.TabIndex = 5
        Me.gbxRefundInformation.TabStop = False
        Me.gbxRefundInformation.Text = "Refund Details"
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.Location = New System.Drawing.Point(755, 251)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 28)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblTotalBalance
        '
        Me.lblTotalBalance.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalBalance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBalance.Location = New System.Drawing.Point(683, 213)
        Me.lblTotalBalance.Name = "lblTotalBalance"
        Me.lblTotalBalance.Size = New System.Drawing.Size(123, 18)
        Me.lblTotalBalance.TabIndex = 26
        Me.lblTotalBalance.Text = "0"
        Me.lblTotalBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(583, 211)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(96, 18)
        Me.Label52.TabIndex = 25
        Me.Label52.Text = "Total Balance:"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(583, 171)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(97, 18)
        Me.Label53.TabIndex = 21
        Me.Label53.Text = "Total Charges:"
        '
        'lblTotalPayments
        '
        Me.lblTotalPayments.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPayments.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayments.Location = New System.Drawing.Point(683, 193)
        Me.lblTotalPayments.Name = "lblTotalPayments"
        Me.lblTotalPayments.Size = New System.Drawing.Size(123, 18)
        Me.lblTotalPayments.TabIndex = 24
        Me.lblTotalPayments.Text = "0"
        Me.lblTotalPayments.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalCharges
        '
        Me.lblTotalCharges.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalCharges.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCharges.Location = New System.Drawing.Point(683, 173)
        Me.lblTotalCharges.Name = "lblTotalCharges"
        Me.lblTotalCharges.Size = New System.Drawing.Size(123, 18)
        Me.lblTotalCharges.TabIndex = 22
        Me.lblTotalCharges.Text = "0"
        Me.lblTotalCharges.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(583, 191)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(107, 18)
        Me.Label54.TabIndex = 23
        Me.Label54.Text = "Total Payments:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(19, 179)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(86, 18)
        Me.Label46.TabIndex = 19
        Me.Label46.Text = "&Transaction:"
        '
        'lsvTransactions
        '
        Me.lsvTransactions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22})
        Me.lsvTransactions.FullRowSelect = True
        Me.lsvTransactions.GridLines = True
        Me.lsvTransactions.HideSelection = False
        Me.lsvTransactions.Location = New System.Drawing.Point(131, 173)
        Me.lsvTransactions.MultiSelect = False
        Me.lsvTransactions.Name = "lsvTransactions"
        Me.lsvTransactions.Size = New System.Drawing.Size(419, 82)
        Me.lsvTransactions.TabIndex = 0
        Me.lsvTransactions.UseCompatibleStateImageBehavior = False
        Me.lsvTransactions.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "Trans ID"
        Me.ColumnHeader19.Width = 76
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "Transaction"
        Me.ColumnHeader20.Width = 93
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Date"
        Me.ColumnHeader21.Width = 88
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Status"
        Me.ColumnHeader22.Width = 86
        '
        'lblReq
        '
        Me.lblReq.AutoSize = True
        Me.lblReq.BackColor = System.Drawing.Color.Transparent
        Me.lblReq.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReq.ForeColor = System.Drawing.Color.Red
        Me.lblReq.Location = New System.Drawing.Point(7, 268)
        Me.lblReq.Name = "lblReq"
        Me.lblReq.Size = New System.Drawing.Size(173, 16)
        Me.lblReq.TabIndex = 29
        Me.lblReq.Text = "NOTE: Fields with * are required." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cboStatus_Input
        '
        Me.cboStatus_Input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus_Input.FormattingEnabled = True
        Me.cboStatus_Input.Items.AddRange(New Object() {"EXPIRED", "ONHOLD", "RELEASED", "UNFINALIZED"})
        Me.cboStatus_Input.Location = New System.Drawing.Point(131, 141)
        Me.cboStatus_Input.Name = "cboStatus_Input"
        Me.cboStatus_Input.Size = New System.Drawing.Size(152, 26)
        Me.cboStatus_Input.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 18)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Refund &Status:"
        '
        'dtpDateIncurred
        '
        Me.dtpDateIncurred.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDateIncurred.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateIncurred.Location = New System.Drawing.Point(131, 26)
        Me.dtpDateIncurred.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpDateIncurred.Name = "dtpDateIncurred"
        Me.dtpDateIncurred.Size = New System.Drawing.Size(153, 23)
        Me.dtpDateIncurred.TabIndex = 2
        Me.dtpDateIncurred.Value = New Date(2006, 8, 25, 22, 19, 0, 0)
        '
        'txtOriginalAmount
        '
        Me.txtOriginalAmount.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtOriginalAmount.Location = New System.Drawing.Point(131, 85)
        Me.txtOriginalAmount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOriginalAmount.Name = "txtOriginalAmount"
        Me.txtOriginalAmount.Size = New System.Drawing.Size(153, 23)
        Me.txtOriginalAmount.TabIndex = 8
        Me.txtOriginalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(18, 91)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 18)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "&Original Amount:"
        '
        'txtAmountToIssue
        '
        Me.txtAmountToIssue.Location = New System.Drawing.Point(130, 114)
        Me.txtAmountToIssue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAmountToIssue.Name = "txtAmountToIssue"
        Me.txtAmountToIssue.Size = New System.Drawing.Size(153, 23)
        Me.txtAmountToIssue.TabIndex = 11
        Me.txtAmountToIssue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRefundPercentage
        '
        Me.txtRefundPercentage.Location = New System.Drawing.Point(433, 27)
        Me.txtRefundPercentage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRefundPercentage.Name = "txtRefundPercentage"
        Me.txtRefundPercentage.Size = New System.Drawing.Size(117, 23)
        Me.txtRefundPercentage.TabIndex = 16
        Me.txtRefundPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(306, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 18)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Refund &Percentage:"
        '
        'btnSaveEditRefundInformation
        '
        Me.btnSaveEditRefundInformation.AutoSize = True
        Me.btnSaveEditRefundInformation.Location = New System.Drawing.Point(689, 251)
        Me.btnSaveEditRefundInformation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSaveEditRefundInformation.Name = "btnSaveEditRefundInformation"
        Me.btnSaveEditRefundInformation.Size = New System.Drawing.Size(60, 28)
        Me.btnSaveEditRefundInformation.TabIndex = 27
        Me.btnSaveEditRefundInformation.Text = "&Save"
        Me.btnSaveEditRefundInformation.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 118)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 18)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "&Amount To Issue:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(309, 85)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtRemarks.MaxLength = 1000
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(241, 80)
        Me.txtRemarks.TabIndex = 18
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(306, 62)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 18)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "&Remarks:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(18, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 18)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Date &Incurred:"
        '
        'dtpExpirationDate
        '
        Me.dtpExpirationDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExpirationDate.Location = New System.Drawing.Point(131, 57)
        Me.dtpExpirationDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpExpirationDate.Name = "dtpExpirationDate"
        Me.dtpExpirationDate.Size = New System.Drawing.Size(153, 23)
        Me.dtpExpirationDate.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(17, 63)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(102, 18)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "&Expiration Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(556, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "%"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(5, 31)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(18, 19)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "*"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(5, 62)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(18, 19)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "*"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(5, 146)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(18, 19)
        Me.Label29.TabIndex = 12
        Me.Label29.Text = "*"
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Red
        Me.Label39.Location = New System.Drawing.Point(5, 90)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(18, 19)
        Me.Label39.TabIndex = 6
        Me.Label39.Text = "*"
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Red
        Me.Label44.Location = New System.Drawing.Point(6, 118)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(18, 19)
        Me.Label44.TabIndex = 9
        Me.Label44.Text = "*"
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Red
        Me.Label51.Location = New System.Drawing.Point(5, 176)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(18, 19)
        Me.Label51.TabIndex = 15
        Me.Label51.Text = "*"
        '
        'lblCountListAtRefundView
        '
        Me.lblCountListAtRefundView.AutoSize = True
        Me.lblCountListAtRefundView.BackColor = System.Drawing.Color.Transparent
        Me.lblCountListAtRefundView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountListAtRefundView.Location = New System.Drawing.Point(931, 451)
        Me.lblCountListAtRefundView.Name = "lblCountListAtRefundView"
        Me.lblCountListAtRefundView.Size = New System.Drawing.Size(13, 13)
        Me.lblCountListAtRefundView.TabIndex = 241
        Me.lblCountListAtRefundView.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(885, 451)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 240
        Me.Label1.Text = "Count:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(11, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 18)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Guest Name:"
        '
        'gbxInformation
        '
        Me.gbxInformation.Controls.Add(Me.btnDelete)
        Me.gbxInformation.Controls.Add(Me.btnAddNew)
        Me.gbxInformation.Controls.Add(Me.btnEdit)
        Me.gbxInformation.Controls.Add(Me.lblTotalAmountToReleaseAtRefundInformation)
        Me.gbxInformation.Controls.Add(Me.dgvListOfRefundAtRefundView)
        Me.gbxInformation.Controls.Add(Me.Label21)
        Me.gbxInformation.Controls.Add(Me.Label11)
        Me.gbxInformation.Controls.Add(Me.lblTotalCountRefInfo)
        Me.gbxInformation.Location = New System.Drawing.Point(8, 42)
        Me.gbxInformation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxInformation.Name = "gbxInformation"
        Me.gbxInformation.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbxInformation.Size = New System.Drawing.Size(823, 223)
        Me.gbxInformation.TabIndex = 4
        Me.gbxInformation.TabStop = False
        Me.gbxInformation.Text = "List of Refunds"
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.Location = New System.Drawing.Point(755, 190)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(60, 28)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.AutoSize = True
        Me.btnAddNew.Location = New System.Drawing.Point(608, 190)
        Me.btnAddNew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(75, 28)
        Me.btnAddNew.TabIndex = 5
        Me.btnAddNew.Text = "&Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.Location = New System.Drawing.Point(689, 190)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(60, 28)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'lblTotalAmountToReleaseAtRefundInformation
        '
        Me.lblTotalAmountToReleaseAtRefundInformation.AutoSize = True
        Me.lblTotalAmountToReleaseAtRefundInformation.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAmountToReleaseAtRefundInformation.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountToReleaseAtRefundInformation.Location = New System.Drawing.Point(734, 168)
        Me.lblTotalAmountToReleaseAtRefundInformation.Name = "lblTotalAmountToReleaseAtRefundInformation"
        Me.lblTotalAmountToReleaseAtRefundInformation.Size = New System.Drawing.Size(15, 18)
        Me.lblTotalAmountToReleaseAtRefundInformation.TabIndex = 4
        Me.lblTotalAmountToReleaseAtRefundInformation.Text = "0"
        Me.lblTotalAmountToReleaseAtRefundInformation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvListOfRefundAtRefundView
        '
        Me.dgvListOfRefundAtRefundView.AllowUserToAddRows = False
        Me.dgvListOfRefundAtRefundView.AllowUserToDeleteRows = False
        Me.dgvListOfRefundAtRefundView.AllowUserToOrderColumns = True
        Me.dgvListOfRefundAtRefundView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvListOfRefundAtRefundView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvListOfRefundAtRefundView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListOfRefundAtRefundView.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvListOfRefundAtRefundView.Location = New System.Drawing.Point(3, 20)
        Me.dgvListOfRefundAtRefundView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvListOfRefundAtRefundView.MultiSelect = False
        Me.dgvListOfRefundAtRefundView.Name = "dgvListOfRefundAtRefundView"
        Me.dgvListOfRefundAtRefundView.ReadOnly = True
        Me.dgvListOfRefundAtRefundView.RowHeadersVisible = False
        Me.dgvListOfRefundAtRefundView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListOfRefundAtRefundView.Size = New System.Drawing.Size(817, 144)
        Me.dgvListOfRefundAtRefundView.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(586, 168)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(145, 18)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Total Amount To Issue:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 18)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Count:"
        '
        'lblTotalCountRefInfo
        '
        Me.lblTotalCountRefInfo.AutoSize = True
        Me.lblTotalCountRefInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalCountRefInfo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCountRefInfo.Location = New System.Drawing.Point(59, 168)
        Me.lblTotalCountRefInfo.Name = "lblTotalCountRefInfo"
        Me.lblTotalCountRefInfo.Size = New System.Drawing.Size(15, 18)
        Me.lblTotalCountRefInfo.TabIndex = 2
        Me.lblTotalCountRefInfo.Text = "0"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox8)
        Me.TabPage3.Controls.Add(Me.lblCountRefundExpired)
        Me.TabPage3.Controls.Add(Me.Label30)
        Me.TabPage3.Controls.Add(Me.GroupBox7)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage3.Size = New System.Drawing.Size(837, 561)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Expired Refunds"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.btnMarkAsUnexpired)
        Me.GroupBox8.Controls.Add(Me.lblTotalAmountToIssueMarked)
        Me.GroupBox8.Controls.Add(Me.Label28)
        Me.GroupBox8.Controls.Add(Me.Label49)
        Me.GroupBox8.Controls.Add(Me.lblCountExpired)
        Me.GroupBox8.Controls.Add(Me.dgvExpiredButMarked)
        Me.GroupBox8.Location = New System.Drawing.Point(3, 280)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox8.Size = New System.Drawing.Size(828, 273)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Expired Refunds"
        '
        'btnMarkAsUnexpired
        '
        Me.btnMarkAsUnexpired.AutoSize = True
        Me.btnMarkAsUnexpired.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarkAsUnexpired.Location = New System.Drawing.Point(679, 237)
        Me.btnMarkAsUnexpired.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMarkAsUnexpired.Name = "btnMarkAsUnexpired"
        Me.btnMarkAsUnexpired.Size = New System.Drawing.Size(133, 28)
        Me.btnMarkAsUnexpired.TabIndex = 270
        Me.btnMarkAsUnexpired.Text = "Mark as &Unexpired"
        Me.btnMarkAsUnexpired.UseVisualStyleBackColor = True
        '
        'lblTotalAmountToIssueMarked
        '
        Me.lblTotalAmountToIssueMarked.AutoSize = True
        Me.lblTotalAmountToIssueMarked.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAmountToIssueMarked.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountToIssueMarked.Location = New System.Drawing.Point(689, 199)
        Me.lblTotalAmountToIssueMarked.Name = "lblTotalAmountToIssueMarked"
        Me.lblTotalAmountToIssueMarked.Size = New System.Drawing.Size(16, 18)
        Me.lblTotalAmountToIssueMarked.TabIndex = 269
        Me.lblTotalAmountToIssueMarked.Text = "0"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(533, 199)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(149, 18)
        Me.Label28.TabIndex = 268
        Me.Label28.Text = "Total Amount To Issue:"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(12, 199)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(47, 18)
        Me.Label49.TabIndex = 266
        Me.Label49.Text = "Count:"
        '
        'lblCountExpired
        '
        Me.lblCountExpired.AutoSize = True
        Me.lblCountExpired.BackColor = System.Drawing.Color.Transparent
        Me.lblCountExpired.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountExpired.Location = New System.Drawing.Point(68, 199)
        Me.lblCountExpired.Name = "lblCountExpired"
        Me.lblCountExpired.Size = New System.Drawing.Size(15, 18)
        Me.lblCountExpired.TabIndex = 267
        Me.lblCountExpired.Text = "0"
        '
        'dgvExpiredButMarked
        '
        Me.dgvExpiredButMarked.AllowUserToAddRows = False
        Me.dgvExpiredButMarked.AllowUserToDeleteRows = False
        Me.dgvExpiredButMarked.AllowUserToOrderColumns = True
        Me.dgvExpiredButMarked.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvExpiredButMarked.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvExpiredButMarked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExpiredButMarked.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvExpiredButMarked.Location = New System.Drawing.Point(3, 20)
        Me.dgvExpiredButMarked.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvExpiredButMarked.MultiSelect = False
        Me.dgvExpiredButMarked.Name = "dgvExpiredButMarked"
        Me.dgvExpiredButMarked.ReadOnly = True
        Me.dgvExpiredButMarked.RowHeadersVisible = False
        Me.dgvExpiredButMarked.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExpiredButMarked.Size = New System.Drawing.Size(822, 175)
        Me.dgvExpiredButMarked.TabIndex = 0
        '
        'lblCountRefundExpired
        '
        Me.lblCountRefundExpired.AutoSize = True
        Me.lblCountRefundExpired.BackColor = System.Drawing.Color.Transparent
        Me.lblCountRefundExpired.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountRefundExpired.Location = New System.Drawing.Point(945, 515)
        Me.lblCountRefundExpired.Name = "lblCountRefundExpired"
        Me.lblCountRefundExpired.Size = New System.Drawing.Size(13, 13)
        Me.lblCountRefundExpired.TabIndex = 249
        Me.lblCountRefundExpired.Text = "0"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(899, 515)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(38, 13)
        Me.Label30.TabIndex = 248
        Me.Label30.Text = "Count:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label55)
        Me.GroupBox7.Controls.Add(Me.dtpDateOfExpiration)
        Me.GroupBox7.Controls.Add(Me.lblTotalAmountToIssueUnmarked)
        Me.GroupBox7.Controls.Add(Me.Label26)
        Me.GroupBox7.Controls.Add(Me.Label47)
        Me.GroupBox7.Controls.Add(Me.btnMarkAsExpired)
        Me.GroupBox7.Controls.Add(Me.lblCountUnmarked)
        Me.GroupBox7.Controls.Add(Me.dgvExpiredButNotMarked)
        Me.GroupBox7.Location = New System.Drawing.Point(4, 8)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox7.Size = New System.Drawing.Size(824, 271)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "List of refunds that exceed the refund period"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(532, 23)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(123, 18)
        Me.Label55.TabIndex = 267
        Me.Label55.Text = "Date of &Expiration:"
        '
        'dtpDateOfExpiration
        '
        Me.dtpDateOfExpiration.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDateOfExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfExpiration.Location = New System.Drawing.Point(658, 21)
        Me.dtpDateOfExpiration.Name = "dtpDateOfExpiration"
        Me.dtpDateOfExpiration.Size = New System.Drawing.Size(147, 23)
        Me.dtpDateOfExpiration.TabIndex = 266
        '
        'lblTotalAmountToIssueUnmarked
        '
        Me.lblTotalAmountToIssueUnmarked.AutoSize = True
        Me.lblTotalAmountToIssueUnmarked.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAmountToIssueUnmarked.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountToIssueUnmarked.Location = New System.Drawing.Point(688, 220)
        Me.lblTotalAmountToIssueUnmarked.Name = "lblTotalAmountToIssueUnmarked"
        Me.lblTotalAmountToIssueUnmarked.Size = New System.Drawing.Size(16, 18)
        Me.lblTotalAmountToIssueUnmarked.TabIndex = 265
        Me.lblTotalAmountToIssueUnmarked.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(532, 220)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(149, 18)
        Me.Label26.TabIndex = 264
        Me.Label26.Text = "Total Amount To Issue:"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(11, 220)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(47, 18)
        Me.Label47.TabIndex = 262
        Me.Label47.Text = "Count:"
        '
        'btnMarkAsExpired
        '
        Me.btnMarkAsExpired.AutoSize = True
        Me.btnMarkAsExpired.Location = New System.Drawing.Point(691, 241)
        Me.btnMarkAsExpired.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMarkAsExpired.Name = "btnMarkAsExpired"
        Me.btnMarkAsExpired.Size = New System.Drawing.Size(114, 28)
        Me.btnMarkAsExpired.TabIndex = 261
        Me.btnMarkAsExpired.Text = "&Mark as Expired"
        Me.btnMarkAsExpired.UseVisualStyleBackColor = True
        '
        'lblCountUnmarked
        '
        Me.lblCountUnmarked.AutoSize = True
        Me.lblCountUnmarked.BackColor = System.Drawing.Color.Transparent
        Me.lblCountUnmarked.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountUnmarked.Location = New System.Drawing.Point(67, 220)
        Me.lblCountUnmarked.Name = "lblCountUnmarked"
        Me.lblCountUnmarked.Size = New System.Drawing.Size(15, 18)
        Me.lblCountUnmarked.TabIndex = 263
        Me.lblCountUnmarked.Text = "0"
        '
        'dgvExpiredButNotMarked
        '
        Me.dgvExpiredButNotMarked.AllowUserToAddRows = False
        Me.dgvExpiredButNotMarked.AllowUserToDeleteRows = False
        Me.dgvExpiredButNotMarked.AllowUserToOrderColumns = True
        Me.dgvExpiredButNotMarked.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvExpiredButNotMarked.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvExpiredButNotMarked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExpiredButNotMarked.Location = New System.Drawing.Point(3, 51)
        Me.dgvExpiredButNotMarked.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvExpiredButNotMarked.MultiSelect = False
        Me.dgvExpiredButNotMarked.Name = "dgvExpiredButNotMarked"
        Me.dgvExpiredButNotMarked.ReadOnly = True
        Me.dgvExpiredButNotMarked.RowHeadersVisible = False
        Me.dgvExpiredButNotMarked.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExpiredButNotMarked.Size = New System.Drawing.Size(818, 165)
        Me.dgvExpiredButNotMarked.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(1064, 816)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(70, 35)
        Me.btnClose.TabIndex = 237
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tsActivities
        '
        Me.tsActivities.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tsActivities.AutoSize = False
        Me.tsActivities.BackColor = System.Drawing.Color.Transparent
        Me.tsActivities.Dock = System.Windows.Forms.DockStyle.None
        Me.tsActivities.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsActivities.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.tsActivities.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuestSearch, Me.ToolStripSeparator1, Me.tsbActGuestInfo, Me.tss3, Me.ToolStripButton3, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.tss1})
        Me.tsActivities.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsActivities.Location = New System.Drawing.Point(2, 79)
        Me.tsActivities.Name = "tsActivities"
        Me.tsActivities.Size = New System.Drawing.Size(114, 313)
        Me.tsActivities.TabIndex = 2
        Me.tsActivities.Text = "ToolStrip2"
        '
        'tsbGuestSearch
        '
        Me.tsbGuestSearch.AutoSize = False
        Me.tsbGuestSearch.AutoToolTip = False
        Me.tsbGuestSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsbGuestSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGuestSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuestSearch.Name = "tsbGuestSearch"
        Me.tsbGuestSearch.Size = New System.Drawing.Size(120, 30)
        Me.tsbGuestSearch.Text = "Guest Search"
        Me.tsbGuestSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(112, 6)
        '
        'tsbActGuestInfo
        '
        Me.tsbActGuestInfo.AutoSize = False
        Me.tsbActGuestInfo.AutoToolTip = False
        Me.tsbActGuestInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbActGuestInfo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbActGuestInfo.Name = "tsbActGuestInfo"
        Me.tsbActGuestInfo.Size = New System.Drawing.Size(120, 30)
        Me.tsbActGuestInfo.Text = "Guest Information"
        Me.tsbActGuestInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss3
        '
        Me.tss3.Name = "tss3"
        Me.tss3.Size = New System.Drawing.Size(112, 6)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.AutoToolTip = False
        Me.ToolStripButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(120, 30)
        Me.ToolStripButton3.Text = "Billing"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(112, 6)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.AutoToolTip = False
        Me.ToolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(120, 30)
        Me.ToolStripButton1.Text = "Guest Folio"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss1
        '
        Me.tss1.Name = "tss1"
        Me.tss1.Size = New System.Drawing.Size(112, 6)
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(-6, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(138, 40)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Refund"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(912, 816)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 35)
        Me.Button3.TabIndex = 260
        Me.Button3.Text = "Print Refund Certificate"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Period"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 56
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Transaction"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 73
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Total Charge"
        Me.ColumnHeader3.Width = 79
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Total Amount Paid"
        Me.ColumnHeader4.Width = 113
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Refund Amount"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 68
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Remaining Refund"
        Me.ColumnHeader6.Width = 110
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Refund Status"
        Me.ColumnHeader9.Width = 84
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Date of Refund"
        Me.ColumnHeader10.Width = 90
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Expiration Date"
        Me.ColumnHeader15.Width = 73
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Remarks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 241
        Me.Label3.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 240
        Me.Label5.Text = "Count:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(808, 222)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List of Refunds"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(802, 203)
        Me.DataGridView2.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(68, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 241
        Me.Label6.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 240
        Me.Label7.Text = "Count:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView3)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(808, 222)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "List of Refunds"
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(802, 203)
        Me.DataGridView3.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(68, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 241
        Me.Label8.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 240
        Me.Label9.Text = "Count:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView4)
        Me.GroupBox4.Location = New System.Drawing.Point(17, 18)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(808, 222)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "List of Refunds"
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView4.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(802, 203)
        Me.DataGridView4.TabIndex = 0
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(775, 444)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(13, 13)
        Me.Label31.TabIndex = 251
        Me.Label31.Text = "0"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(699, 444)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(70, 13)
        Me.Label32.TabIndex = 250
        Me.Label32.Text = "Total Amount"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(474, 444)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(13, 13)
        Me.Label33.TabIndex = 249
        Me.Label33.Text = "0"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(435, 444)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(38, 13)
        Me.Label34.TabIndex = 248
        Me.Label34.Text = "Count:"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.DataGridView7)
        Me.GroupBox9.Location = New System.Drawing.Point(424, 26)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(398, 415)
        Me.GroupBox9.TabIndex = 3
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Expired Refunds"
        '
        'DataGridView7
        '
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView7.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView7.Name = "DataGridView7"
        Me.DataGridView7.Size = New System.Drawing.Size(392, 396)
        Me.DataGridView7.TabIndex = 0
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(365, 444)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(13, 13)
        Me.Label35.TabIndex = 247
        Me.Label35.Text = "0"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(289, 444)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(70, 13)
        Me.Label36.TabIndex = 246
        Me.Label36.Text = "Total Amount"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(64, 444)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(13, 13)
        Me.Label37.TabIndex = 245
        Me.Label37.Text = "0"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(25, 444)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(38, 13)
        Me.Label38.TabIndex = 244
        Me.Label38.Text = "Count:"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.DataGridView8)
        Me.GroupBox10.Location = New System.Drawing.Point(20, 26)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(398, 415)
        Me.GroupBox10.TabIndex = 2
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "List of Refunds that Excede the refund period"
        '
        'DataGridView8
        '
        Me.DataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView8.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView8.Name = "DataGridView8"
        Me.DataGridView8.Size = New System.Drawing.Size(392, 396)
        Me.DataGridView8.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(249, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(189, 56)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(20, 13)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "To"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(189, 82)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 13)
        Me.Label24.TabIndex = 31
        Me.Label24.Text = "From"
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.Enabled = False
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker5.Location = New System.Drawing.Point(225, 52)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(99, 20)
        Me.DateTimePicker5.TabIndex = 32
        '
        'DateTimePicker6
        '
        Me.DateTimePicker6.Enabled = False
        Me.DateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker6.Location = New System.Drawing.Point(225, 78)
        Me.DateTimePicker6.Name = "DateTimePicker6"
        Me.DateTimePicker6.Size = New System.Drawing.Size(99, 20)
        Me.DateTimePicker6.TabIndex = 30
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(168, 29)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(86, 17)
        Me.RadioButton5.TabIndex = 25
        Me.RadioButton5.Text = "Specify Date"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(29, 98)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(119, 17)
        Me.RadioButton1.TabIndex = 24
        Me.RadioButton1.Text = "Within the past year"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(29, 75)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(78, 17)
        Me.RadioButton2.TabIndex = 23
        Me.RadioButton2.Text = "Past month"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(29, 52)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(121, 17)
        Me.RadioButton3.TabIndex = 22
        Me.RadioButton3.Text = "Within the last week"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(29, 29)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(104, 17)
        Me.RadioButton4.TabIndex = 21
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Don't Remember"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblClose.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblClose.Location = New System.Drawing.Point(945, 10)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(39, 18)
        Me.lblClose.TabIndex = 0
        Me.lblClose.TabStop = True
        Me.lblClose.Text = "Close"
        '
        'frmRefund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.tbcRefund)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tsActivities)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 80)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmRefund"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SLU Hotel"
        Me.tbcRefund.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.dgvListOfRefundAtRefundIssuance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListOfFinalRefund.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.gbxRefundInformation.ResumeLayout(False)
        Me.gbxRefundInformation.PerformLayout()
        Me.gbxInformation.ResumeLayout(False)
        Me.gbxInformation.PerformLayout()
        CType(Me.dgvListOfRefundAtRefundView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.dgvExpiredButMarked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.dgvExpiredButNotMarked, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsActivities.ResumeLayout(False)
        Me.tsActivities.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbcRefund As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents tsActivities As System.Windows.Forms.ToolStrip
    Public WithEvents tsbGuestSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbActGuestInfo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss3 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbxInformation As System.Windows.Forms.GroupBox
    Friend WithEvents dgvListOfRefundAtRefundView As System.Windows.Forms.DataGridView
    Private WithEvents lblTotalCountRefInfo As System.Windows.Forms.Label
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents lblCountListAtRefundView As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents dtpExpirationDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents gbxRefundInformation As System.Windows.Forms.GroupBox
    Friend WithEvents btnSaveEditRefundInformation As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvExpiredButNotMarked As System.Windows.Forms.DataGridView
    Friend WithEvents btnMarkAsExpired As System.Windows.Forms.Button
    Private WithEvents lblCountRefundExpired As System.Windows.Forms.Label
    Private WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvExpiredButMarked As System.Windows.Forms.DataGridView
    Private WithEvents Label31 As System.Windows.Forms.Label
    Private WithEvents Label32 As System.Windows.Forms.Label
    Private WithEvents Label33 As System.Windows.Forms.Label
    Private WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView7 As System.Windows.Forms.DataGridView
    Private WithEvents Label35 As System.Windows.Forms.Label
    Private WithEvents Label36 As System.Windows.Forms.Label
    Private WithEvents Label37 As System.Windows.Forms.Label
    Private WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView8 As System.Windows.Forms.DataGridView
    Private WithEvents lblTotalAmountAtRefundIssuance As System.Windows.Forms.Label
    Private WithEvents Label40 As System.Windows.Forms.Label
    Private WithEvents lblCountAtRefundIssuance As System.Windows.Forms.Label
    Private WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvListOfRefundAtRefundIssuance As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker5 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker6 As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Private WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtOriginalAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtAmountToIssue As System.Windows.Forms.TextBox
    Friend WithEvents txtRefundPercentage As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDateReleased As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents lblTotalAmountToReleaseAtRefundInformation As System.Windows.Forms.Label
    Private WithEvents Label21 As System.Windows.Forms.Label
    Private WithEvents lblGuestName As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Private WithEvents Label45 As System.Windows.Forms.Label
    Private WithEvents lblCountRefundsToRelease As System.Windows.Forms.Label
    Private WithEvents Label43 As System.Windows.Forms.Label
    Private WithEvents lblTotalAmountToRelease As System.Windows.Forms.Label
    Friend WithEvents lsvToRelease As System.Windows.Forms.ListView
    Friend WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents dtpDateIncurred As System.Windows.Forms.DateTimePicker
    Private WithEvents lblTotalAmountToIssueUnmarked As System.Windows.Forms.Label
    Private WithEvents Label26 As System.Windows.Forms.Label
    Private WithEvents Label47 As System.Windows.Forms.Label
    Private WithEvents lblCountUnmarked As System.Windows.Forms.Label
    Friend WithEvents btnMarkAsUnexpired As System.Windows.Forms.Button
    Private WithEvents lblTotalAmountToIssueMarked As System.Windows.Forms.Label
    Private WithEvents Label28 As System.Windows.Forms.Label
    Private WithEvents Label49 As System.Windows.Forms.Label
    Private WithEvents lblCountExpired As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboStatus_Input As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblReq As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents lsvTransactions As System.Windows.Forms.ListView
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTotalBalance As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPayments As System.Windows.Forms.Label
    Friend WithEvents lblTotalCharges As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents chkSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents btnEdit_Info As System.Windows.Forms.Button
    Friend WithEvents ListOfFinalRefund As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtpDateOfExpiration As System.Windows.Forms.DateTimePicker
    Private WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.LinkLabel
End Class
