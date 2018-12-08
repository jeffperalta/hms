<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUncollectible
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblTitle = New System.Windows.Forms.Label
        Me.tsActivities = New System.Windows.Forms.ToolStrip
        Me.tsbActGuestSearch = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.tss1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbActPayment = New System.Windows.Forms.ToolStripButton
        Me.tss7 = New System.Windows.Forms.ToolStripSeparator
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lblTotalBalance = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblTotalPayments = New System.Windows.Forms.Label
        Me.lblTotalCharges = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblGuest = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnUnmark = New System.Windows.Forms.Button
        Me.lblTotalAmountUncollectible = New System.Windows.Forms.Label
        Me.dgvUncollectibles_FirstTab = New System.Windows.Forms.DataGridView
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblTotalUncollectible = New System.Windows.Forms.Label
        Me.grpBillBreakdown = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblCount = New System.Windows.Forms.Label
        Me.dgvBillBreakdown = New System.Windows.Forms.DataGridView
        Me.btnSave = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.chkViewAll = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.dtpDate1 = New System.Windows.Forms.Label
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblTotalAmountMoneyUncollectible = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblCountAllUncollectibles = New System.Windows.Forms.Label
        Me.dgvUncollectible = New System.Windows.Forms.DataGridView
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.lblClose = New System.Windows.Forms.LinkLabel
        Me.tsActivities.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvUncollectibles_FirstTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBillBreakdown.SuspendLayout()
        CType(Me.dgvBillBreakdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvUncollectible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(-9, 29)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(138, 40)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Uncollectible"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tsActivities
        '
        Me.tsActivities.AutoSize = False
        Me.tsActivities.BackColor = System.Drawing.Color.Transparent
        Me.tsActivities.Dock = System.Windows.Forms.DockStyle.None
        Me.tsActivities.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsActivities.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.tsActivities.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbActGuestSearch, Me.ToolStripSeparator1, Me.ToolStripButton1, Me.tss1, Me.tsbActPayment, Me.tss7})
        Me.tsActivities.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsActivities.Location = New System.Drawing.Point(2, 78)
        Me.tsActivities.Name = "tsActivities"
        Me.tsActivities.ShowItemToolTips = False
        Me.tsActivities.Size = New System.Drawing.Size(114, 311)
        Me.tsActivities.TabIndex = 2
        Me.tsActivities.Text = "ToolStrip2"
        '
        'tsbActGuestSearch
        '
        Me.tsbActGuestSearch.AutoSize = False
        Me.tsbActGuestSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbActGuestSearch.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbActGuestSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbActGuestSearch.Name = "tsbActGuestSearch"
        Me.tsbActGuestSearch.Size = New System.Drawing.Size(120, 30)
        Me.tsbActGuestSearch.Text = "Guest Search"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(112, 6)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'tsbActPayment
        '
        Me.tsbActPayment.AutoSize = False
        Me.tsbActPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbActPayment.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbActPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbActPayment.Name = "tsbActPayment"
        Me.tsbActPayment.Size = New System.Drawing.Size(120, 30)
        Me.tsbActPayment.Text = "Billing"
        Me.tsbActPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss7
        '
        Me.tss7.BackColor = System.Drawing.Color.Transparent
        Me.tss7.Name = "tss7"
        Me.tss7.Size = New System.Drawing.Size(112, 6)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(137, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(846, 599)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblTotalBalance)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.lblTotalPayments)
        Me.TabPage1.Controls.Add(Me.lblTotalCharges)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.lblGuest)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.grpBillBreakdown)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(838, 568)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Uncollectibles"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblTotalBalance
        '
        Me.lblTotalBalance.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalBalance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBalance.Location = New System.Drawing.Point(702, 534)
        Me.lblTotalBalance.Name = "lblTotalBalance"
        Me.lblTotalBalance.Size = New System.Drawing.Size(123, 18)
        Me.lblTotalBalance.TabIndex = 1
        Me.lblTotalBalance.Text = "0"
        Me.lblTotalBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(602, 532)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 18)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Total Balance:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(602, 490)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 18)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Total Charges:"
        '
        'lblTotalPayments
        '
        Me.lblTotalPayments.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPayments.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayments.Location = New System.Drawing.Point(702, 513)
        Me.lblTotalPayments.Name = "lblTotalPayments"
        Me.lblTotalPayments.Size = New System.Drawing.Size(123, 18)
        Me.lblTotalPayments.TabIndex = 9
        Me.lblTotalPayments.Text = "0"
        Me.lblTotalPayments.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalCharges
        '
        Me.lblTotalCharges.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalCharges.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCharges.Location = New System.Drawing.Point(702, 492)
        Me.lblTotalCharges.Name = "lblTotalCharges"
        Me.lblTotalCharges.Size = New System.Drawing.Size(123, 18)
        Me.lblTotalCharges.TabIndex = 7
        Me.lblTotalCharges.Text = "0"
        Me.lblTotalCharges.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(602, 511)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 18)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Total Payments:"
        '
        'lblGuest
        '
        Me.lblGuest.AutoEllipsis = True
        Me.lblGuest.BackColor = System.Drawing.Color.Transparent
        Me.lblGuest.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuest.Location = New System.Drawing.Point(93, 14)
        Me.lblGuest.Name = "lblGuest"
        Me.lblGuest.Size = New System.Drawing.Size(736, 16)
        Me.lblGuest.TabIndex = 1
        Me.lblGuest.Text = "<Code Will Generate text in here>"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Guest Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnUnmark)
        Me.GroupBox1.Controls.Add(Me.lblTotalAmountUncollectible)
        Me.GroupBox1.Controls.Add(Me.dgvUncollectibles_FirstTab)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblTotalUncollectible)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 275)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(823, 201)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Billing"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(633, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Amount:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUnmark
        '
        Me.btnUnmark.AutoSize = True
        Me.btnUnmark.Location = New System.Drawing.Point(747, 170)
        Me.btnUnmark.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUnmark.Name = "btnUnmark"
        Me.btnUnmark.Size = New System.Drawing.Size(70, 28)
        Me.btnUnmark.TabIndex = 5
        Me.btnUnmark.Text = "&Unmark"
        Me.btnUnmark.UseVisualStyleBackColor = True
        '
        'lblTotalAmountUncollectible
        '
        Me.lblTotalAmountUncollectible.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAmountUncollectible.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountUncollectible.ForeColor = System.Drawing.Color.Black
        Me.lblTotalAmountUncollectible.Location = New System.Drawing.Point(697, 146)
        Me.lblTotalAmountUncollectible.Name = "lblTotalAmountUncollectible"
        Me.lblTotalAmountUncollectible.Size = New System.Drawing.Size(122, 20)
        Me.lblTotalAmountUncollectible.TabIndex = 4
        Me.lblTotalAmountUncollectible.Text = "0"
        Me.lblTotalAmountUncollectible.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvUncollectibles_FirstTab
        '
        Me.dgvUncollectibles_FirstTab.AllowUserToAddRows = False
        Me.dgvUncollectibles_FirstTab.AllowUserToDeleteRows = False
        Me.dgvUncollectibles_FirstTab.AllowUserToOrderColumns = True
        Me.dgvUncollectibles_FirstTab.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvUncollectibles_FirstTab.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUncollectibles_FirstTab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvUncollectibles_FirstTab.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvUncollectibles_FirstTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUncollectibles_FirstTab.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvUncollectibles_FirstTab.Location = New System.Drawing.Point(3, 20)
        Me.dgvUncollectibles_FirstTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvUncollectibles_FirstTab.MultiSelect = False
        Me.dgvUncollectibles_FirstTab.Name = "dgvUncollectibles_FirstTab"
        Me.dgvUncollectibles_FirstTab.ReadOnly = True
        Me.dgvUncollectibles_FirstTab.RowHeadersVisible = False
        Me.dgvUncollectibles_FirstTab.RowHeadersWidth = 25
        Me.dgvUncollectibles_FirstTab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUncollectibles_FirstTab.Size = New System.Drawing.Size(817, 123)
        Me.dgvUncollectibles_FirstTab.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Count:"
        '
        'lblTotalUncollectible
        '
        Me.lblTotalUncollectible.AutoSize = True
        Me.lblTotalUncollectible.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalUncollectible.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUncollectible.ForeColor = System.Drawing.Color.Black
        Me.lblTotalUncollectible.Location = New System.Drawing.Point(65, 147)
        Me.lblTotalUncollectible.Name = "lblTotalUncollectible"
        Me.lblTotalUncollectible.Size = New System.Drawing.Size(15, 18)
        Me.lblTotalUncollectible.TabIndex = 2
        Me.lblTotalUncollectible.Text = "0"
        '
        'grpBillBreakdown
        '
        Me.grpBillBreakdown.BackColor = System.Drawing.Color.Transparent
        Me.grpBillBreakdown.Controls.Add(Me.Label15)
        Me.grpBillBreakdown.Controls.Add(Me.lblAmount)
        Me.grpBillBreakdown.Controls.Add(Me.Label5)
        Me.grpBillBreakdown.Controls.Add(Me.lblCount)
        Me.grpBillBreakdown.Controls.Add(Me.dgvBillBreakdown)
        Me.grpBillBreakdown.Controls.Add(Me.btnSave)
        Me.grpBillBreakdown.Location = New System.Drawing.Point(9, 38)
        Me.grpBillBreakdown.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpBillBreakdown.Name = "grpBillBreakdown"
        Me.grpBillBreakdown.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpBillBreakdown.Size = New System.Drawing.Size(823, 235)
        Me.grpBillBreakdown.TabIndex = 3
        Me.grpBillBreakdown.TabStop = False
        Me.grpBillBreakdown.Text = "Bill Breakdown"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(630, 180)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 18)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Amount:"
        '
        'lblAmount
        '
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.Black
        Me.lblAmount.Location = New System.Drawing.Point(694, 179)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(122, 20)
        Me.lblAmount.TabIndex = 4
        Me.lblAmount.Text = "0"
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Count:"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.BackColor = System.Drawing.Color.Transparent
        Me.lblCount.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.Black
        Me.lblCount.Location = New System.Drawing.Point(65, 180)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(15, 18)
        Me.lblCount.TabIndex = 2
        Me.lblCount.Text = "0"
        '
        'dgvBillBreakdown
        '
        Me.dgvBillBreakdown.AllowUserToAddRows = False
        Me.dgvBillBreakdown.AllowUserToDeleteRows = False
        Me.dgvBillBreakdown.AllowUserToOrderColumns = True
        Me.dgvBillBreakdown.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvBillBreakdown.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBillBreakdown.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvBillBreakdown.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvBillBreakdown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBillBreakdown.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvBillBreakdown.Location = New System.Drawing.Point(3, 20)
        Me.dgvBillBreakdown.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvBillBreakdown.MultiSelect = False
        Me.dgvBillBreakdown.Name = "dgvBillBreakdown"
        Me.dgvBillBreakdown.ReadOnly = True
        Me.dgvBillBreakdown.RowHeadersVisible = False
        Me.dgvBillBreakdown.RowHeadersWidth = 25
        Me.dgvBillBreakdown.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBillBreakdown.Size = New System.Drawing.Size(817, 156)
        Me.dgvBillBreakdown.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.Location = New System.Drawing.Point(673, 200)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(141, 28)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "&Mark as Uncollectible"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chkViewAll)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.dtpEndDate)
        Me.TabPage2.Controls.Add(Me.dtpDate1)
        Me.TabPage2.Controls.Add(Me.dtpStartDate)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Size = New System.Drawing.Size(838, 568)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "All Uncollectibles"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chkViewAll
        '
        Me.chkViewAll.AutoSize = True
        Me.chkViewAll.Checked = True
        Me.chkViewAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkViewAll.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkViewAll.Location = New System.Drawing.Point(227, 16)
        Me.chkViewAll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkViewAll.Name = "chkViewAll"
        Me.chkViewAll.Size = New System.Drawing.Size(76, 22)
        Me.chkViewAll.TabIndex = 308
        Me.chkViewAll.Text = "View &All"
        Me.chkViewAll.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(585, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 18)
        Me.Label10.TabIndex = 306
        Me.Label10.Text = "&End Date:"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpEndDate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(656, 15)
        Me.dtpEndDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpEndDate.TabIndex = 307
        '
        'dtpDate1
        '
        Me.dtpDate1.AutoSize = True
        Me.dtpDate1.BackColor = System.Drawing.Color.Transparent
        Me.dtpDate1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate1.Location = New System.Drawing.Point(324, 17)
        Me.dtpDate1.Name = "dtpDate1"
        Me.dtpDate1.Size = New System.Drawing.Size(74, 18)
        Me.dtpDate1.TabIndex = 304
        Me.dtpDate1.Text = "&Start Date:"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpStartDate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(403, 15)
        Me.dtpStartDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpStartDate.TabIndex = 305
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblTotalAmountMoneyUncollectible)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblCountAllUncollectibles)
        Me.GroupBox2.Controls.Add(Me.dgvUncollectible)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 39)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(825, 521)
        Me.GroupBox2.TabIndex = 303
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Uncollectible"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(636, 480)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 18)
        Me.Label7.TabIndex = 341
        Me.Label7.Text = "Amount:"
        '
        'lblTotalAmountMoneyUncollectible
        '
        Me.lblTotalAmountMoneyUncollectible.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAmountMoneyUncollectible.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmountMoneyUncollectible.ForeColor = System.Drawing.Color.Black
        Me.lblTotalAmountMoneyUncollectible.Location = New System.Drawing.Point(700, 479)
        Me.lblTotalAmountMoneyUncollectible.Name = "lblTotalAmountMoneyUncollectible"
        Me.lblTotalAmountMoneyUncollectible.Size = New System.Drawing.Size(122, 20)
        Me.lblTotalAmountMoneyUncollectible.TabIndex = 342
        Me.lblTotalAmountMoneyUncollectible.Text = "0"
        Me.lblTotalAmountMoneyUncollectible.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 480)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 18)
        Me.Label9.TabIndex = 343
        Me.Label9.Text = "Count:"
        '
        'lblCountAllUncollectibles
        '
        Me.lblCountAllUncollectibles.AutoSize = True
        Me.lblCountAllUncollectibles.BackColor = System.Drawing.Color.Transparent
        Me.lblCountAllUncollectibles.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountAllUncollectibles.ForeColor = System.Drawing.Color.Black
        Me.lblCountAllUncollectibles.Location = New System.Drawing.Point(69, 480)
        Me.lblCountAllUncollectibles.Name = "lblCountAllUncollectibles"
        Me.lblCountAllUncollectibles.Size = New System.Drawing.Size(15, 18)
        Me.lblCountAllUncollectibles.TabIndex = 344
        Me.lblCountAllUncollectibles.Text = "0"
        '
        'dgvUncollectible
        '
        Me.dgvUncollectible.AllowUserToAddRows = False
        Me.dgvUncollectible.AllowUserToDeleteRows = False
        Me.dgvUncollectible.AllowUserToOrderColumns = True
        Me.dgvUncollectible.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvUncollectible.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUncollectible.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvUncollectible.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvUncollectible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUncollectible.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvUncollectible.Location = New System.Drawing.Point(3, 20)
        Me.dgvUncollectible.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvUncollectible.MultiSelect = False
        Me.dgvUncollectible.Name = "dgvUncollectible"
        Me.dgvUncollectible.ReadOnly = True
        Me.dgvUncollectible.RowHeadersVisible = False
        Me.dgvUncollectible.RowHeadersWidth = 25
        Me.dgvUncollectible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUncollectible.Size = New System.Drawing.Size(819, 449)
        Me.dgvUncollectible.TabIndex = 274
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 25
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(394, 339)
        Me.DataGridView2.TabIndex = 274
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblClose.Location = New System.Drawing.Point(945, 10)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(39, 18)
        Me.lblClose.TabIndex = 3
        Me.lblClose.TabStop = True
        Me.lblClose.Text = "Close"
        '
        'frmUncollectible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.tsActivities)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmUncollectible"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SLU Hotel"
        Me.tsActivities.ResumeLayout(False)
        Me.tsActivities.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvUncollectibles_FirstTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBillBreakdown.ResumeLayout(False)
        Me.grpBillBreakdown.PerformLayout()
        CType(Me.dgvBillBreakdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvUncollectible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents tsActivities As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbActGuestSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbActPayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvUncollectibles_FirstTab As System.Windows.Forms.DataGridView
    Friend WithEvents grpBillBreakdown As System.Windows.Forms.GroupBox
    Friend WithEvents dgvBillBreakdown As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvUncollectible As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpDate1 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkViewAll As System.Windows.Forms.CheckBox
    Friend WithEvents lblGuest As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUnmark As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmountUncollectible As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotalUncollectible As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents lblTotalBalance As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPayments As System.Windows.Forms.Label
    Friend WithEvents lblTotalCharges As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmountMoneyUncollectible As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCountAllUncollectibles As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.LinkLabel
End Class
