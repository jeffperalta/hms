<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomTransfer
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
        Dim TabControl1 As System.Windows.Forms.TabControl
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dgvRegRooms = New System.Windows.Forms.DataGridView
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.dgvCheckOutRooms = New System.Windows.Forms.DataGridView
        Me.grpAddRoom = New System.Windows.Forms.GroupBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblTotalBalance = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblTotalPayments = New System.Windows.Forms.Label
        Me.lblTotalCharges = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.lvwTransferRooms = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.btnCancel = New System.Windows.Forms.Button
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.tsbGuestSearch = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbNewRegistration = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbUpdateRegistration = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGuestFolio = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbPayment = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.Label11 = New System.Windows.Forms.Label
        Me.gbxRoomVacancySearch = New System.Windows.Forms.GroupBox
        Me.btnChangeDateTime = New System.Windows.Forms.Button
        Me.dtpCheckOutDate = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.cboRoomType = New System.Windows.Forms.ComboBox
        Me.txtRoomNumber = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.dtpCheckOutTime = New System.Windows.Forms.DateTimePicker
        Me.dtpCheckInTime = New System.Windows.Forms.DateTimePicker
        Me.dgvRoomVacancySearch = New System.Windows.Forms.DataGridView
        Me.btnRoomVacancySearch = New System.Windows.Forms.Button
        Me.cboView = New System.Windows.Forms.ComboBox
        Me.cboFloor = New System.Windows.Forms.ComboBox
        Me.Label78 = New System.Windows.Forms.Label
        Me.Label82 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.dtpCheckInDate = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.gbxRoomRegistrationDetails = New System.Windows.Forms.GroupBox
        Me.lblRoomRate = New System.Windows.Forms.Label
        Me.lblRoomNumberOld = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblNumberOfNights = New System.Windows.Forms.Label
        Me.txtNoOfOccupants = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnViewDetails = New System.Windows.Forms.Button
        Me.lblRoomNumber = New System.Windows.Forms.Label
        Me.btnAddRoom = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.lblGuestName = New System.Windows.Forms.Label
        Me.lblClose = New System.Windows.Forms.LinkLabel
        TabControl1 = New System.Windows.Forms.TabControl
        TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvRegRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvCheckOutRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAddRoom.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.gbxRoomVacancySearch.SuspendLayout()
        CType(Me.dgvRoomVacancySearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxRoomRegistrationDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        TabControl1.Controls.Add(Me.TabPage1)
        TabControl1.Controls.Add(Me.TabPage2)
        TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        TabControl1.Location = New System.Drawing.Point(3, 19)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New System.Drawing.Size(417, 233)
        TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.dgvRegRooms)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(409, 202)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registered Rooms"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvRegRooms
        '
        Me.dgvRegRooms.AllowUserToAddRows = False
        Me.dgvRegRooms.AllowUserToDeleteRows = False
        Me.dgvRegRooms.AllowUserToOrderColumns = True
        Me.dgvRegRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvRegRooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvRegRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegRooms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegRooms.Location = New System.Drawing.Point(3, 3)
        Me.dgvRegRooms.MultiSelect = False
        Me.dgvRegRooms.Name = "dgvRegRooms"
        Me.dgvRegRooms.ReadOnly = True
        Me.dgvRegRooms.RowHeadersVisible = False
        Me.dgvRegRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRegRooms.Size = New System.Drawing.Size(403, 196)
        Me.dgvRegRooms.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvCheckOutRooms)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(409, 202)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Checked Out Rooms"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvCheckOutRooms
        '
        Me.dgvCheckOutRooms.AllowUserToAddRows = False
        Me.dgvCheckOutRooms.AllowUserToDeleteRows = False
        Me.dgvCheckOutRooms.AllowUserToOrderColumns = True
        Me.dgvCheckOutRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvCheckOutRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCheckOutRooms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCheckOutRooms.Location = New System.Drawing.Point(3, 3)
        Me.dgvCheckOutRooms.MultiSelect = False
        Me.dgvCheckOutRooms.Name = "dgvCheckOutRooms"
        Me.dgvCheckOutRooms.ReadOnly = True
        Me.dgvCheckOutRooms.RowHeadersVisible = False
        Me.dgvCheckOutRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCheckOutRooms.Size = New System.Drawing.Size(403, 196)
        Me.dgvCheckOutRooms.TabIndex = 201
        '
        'grpAddRoom
        '
        Me.grpAddRoom.BackColor = System.Drawing.Color.Transparent
        Me.grpAddRoom.Controls.Add(TabControl1)
        Me.grpAddRoom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAddRoom.Location = New System.Drawing.Point(139, 44)
        Me.grpAddRoom.Name = "grpAddRoom"
        Me.grpAddRoom.Size = New System.Drawing.Size(423, 255)
        Me.grpAddRoom.TabIndex = 4
        Me.grpAddRoom.TabStop = False
        Me.grpAddRoom.Text = "Guest Rooms"
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.Transparent
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.lblTotalBalance)
        Me.groupBox1.Controls.Add(Me.Label5)
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Controls.Add(Me.lblTotalPayments)
        Me.groupBox1.Controls.Add(Me.lblTotalCharges)
        Me.groupBox1.Controls.Add(Me.Label7)
        Me.groupBox1.Controls.Add(Me.btnClear)
        Me.groupBox1.Controls.Add(Me.lvwTransferRooms)
        Me.groupBox1.Controls.Add(Me.btnCancel)
        Me.groupBox1.Controls.Add(Me.txtRemarks)
        Me.groupBox1.Controls.Add(Me.Label1)
        Me.groupBox1.Controls.Add(Me.btnSave)
        Me.groupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(139, 409)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(839, 199)
        Me.groupBox1.TabIndex = 6
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Transfering Rooms"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(15, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(244, 16)
        Me.Label8.TabIndex = 357
        Me.Label8.Text = "Click an item to define its registration details."
        '
        'lblTotalBalance
        '
        Me.lblTotalBalance.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalBalance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBalance.Location = New System.Drawing.Point(506, 161)
        Me.lblTotalBalance.Name = "lblTotalBalance"
        Me.lblTotalBalance.Size = New System.Drawing.Size(123, 18)
        Me.lblTotalBalance.TabIndex = 9
        Me.lblTotalBalance.Text = "0"
        Me.lblTotalBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(406, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total Balance:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(406, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Total Charges:"
        '
        'lblTotalPayments
        '
        Me.lblTotalPayments.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPayments.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayments.Location = New System.Drawing.Point(506, 143)
        Me.lblTotalPayments.Name = "lblTotalPayments"
        Me.lblTotalPayments.Size = New System.Drawing.Size(123, 18)
        Me.lblTotalPayments.TabIndex = 7
        Me.lblTotalPayments.Text = "0"
        Me.lblTotalPayments.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalCharges
        '
        Me.lblTotalCharges.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalCharges.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCharges.Location = New System.Drawing.Point(506, 125)
        Me.lblTotalCharges.Name = "lblTotalCharges"
        Me.lblTotalCharges.Size = New System.Drawing.Size(123, 18)
        Me.lblTotalCharges.TabIndex = 5
        Me.lblTotalCharges.Text = "0"
        Me.lblTotalCharges.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(406, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Payments:"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(772, 161)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 28)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lvwTransferRooms
        '
        Me.lvwTransferRooms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader1, Me.ColumnHeader5, Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader9, Me.ColumnHeader2, Me.ColumnHeader12, Me.ColumnHeader15})
        Me.lvwTransferRooms.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.lvwTransferRooms.FullRowSelect = True
        Me.lvwTransferRooms.GridLines = True
        Me.lvwTransferRooms.HideSelection = False
        Me.lvwTransferRooms.Location = New System.Drawing.Point(6, 19)
        Me.lvwTransferRooms.MultiSelect = False
        Me.lvwTransferRooms.Name = "lvwTransferRooms"
        Me.lvwTransferRooms.Size = New System.Drawing.Size(825, 92)
        Me.lvwTransferRooms.TabIndex = 0
        Me.lvwTransferRooms.UseCompatibleStateImageBehavior = False
        Me.lvwTransferRooms.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Room No"
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Old Room No"
        Me.ColumnHeader1.Width = 84
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Room Type"
        Me.ColumnHeader5.Width = 86
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Room Rate"
        Me.ColumnHeader3.Width = 73
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Check In Time"
        Me.ColumnHeader6.Width = 113
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Expected Checkout"
        Me.ColumnHeader9.Width = 131
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "No of Occupants"
        Me.ColumnHeader2.Width = 103
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Registration No"
        Me.ColumnHeader12.Width = 119
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Remarks"
        Me.ColumnHeader15.Width = 130
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.btnCancel.Location = New System.Drawing.Point(14, 123)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(68, 25)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Return"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(159, 122)
        Me.txtRemarks.MaxLength = 1000
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(206, 52)
        Me.txtRemarks.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Remarks:"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(706, 161)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 28)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(143, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 18)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Guest Name:"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuestSearch, Me.ToolStripSeparator1, Me.tsbNewRegistration, Me.ToolStripSeparator2, Me.tsbUpdateRegistration, Me.ToolStripSeparator11, Me.tsbGuestFolio, Me.ToolStripSeparator4, Me.tsbPayment, Me.ToolStripSeparator3})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 76)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(113, 315)
        Me.ToolStrip2.TabIndex = 7
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbGuestSearch
        '
        Me.tsbGuestSearch.AutoSize = False
        Me.tsbGuestSearch.AutoToolTip = False
        Me.tsbGuestSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGuestSearch.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbGuestSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuestSearch.Name = "tsbGuestSearch"
        Me.tsbGuestSearch.Size = New System.Drawing.Size(120, 30)
        Me.tsbGuestSearch.Text = "Guest Search"
        Me.tsbGuestSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(111, 6)
        '
        'tsbNewRegistration
        '
        Me.tsbNewRegistration.AutoSize = False
        Me.tsbNewRegistration.AutoToolTip = False
        Me.tsbNewRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsbNewRegistration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbNewRegistration.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbNewRegistration.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNewRegistration.Name = "tsbNewRegistration"
        Me.tsbNewRegistration.Size = New System.Drawing.Size(120, 30)
        Me.tsbNewRegistration.Text = "New Registration"
        Me.tsbNewRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(111, 6)
        '
        'tsbUpdateRegistration
        '
        Me.tsbUpdateRegistration.AutoSize = False
        Me.tsbUpdateRegistration.AutoToolTip = False
        Me.tsbUpdateRegistration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbUpdateRegistration.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbUpdateRegistration.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUpdateRegistration.Name = "tsbUpdateRegistration"
        Me.tsbUpdateRegistration.Size = New System.Drawing.Size(120, 30)
        Me.tsbUpdateRegistration.Text = "Update Registration"
        Me.tsbUpdateRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(111, 6)
        '
        'tsbGuestFolio
        '
        Me.tsbGuestFolio.AutoSize = False
        Me.tsbGuestFolio.AutoToolTip = False
        Me.tsbGuestFolio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGuestFolio.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbGuestFolio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuestFolio.Name = "tsbGuestFolio"
        Me.tsbGuestFolio.Size = New System.Drawing.Size(120, 30)
        Me.tsbGuestFolio.Text = "Guest Folio"
        Me.tsbGuestFolio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(111, 6)
        '
        'tsbPayment
        '
        Me.tsbPayment.AutoSize = False
        Me.tsbPayment.AutoToolTip = False
        Me.tsbPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbPayment.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPayment.Name = "tsbPayment"
        Me.tsbPayment.Size = New System.Drawing.Size(120, 30)
        Me.tsbPayment.Text = "Billing"
        Me.tsbPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(111, 6)
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-2, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 47)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Room Transfer"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxRoomVacancySearch
        '
        Me.gbxRoomVacancySearch.BackColor = System.Drawing.Color.Transparent
        Me.gbxRoomVacancySearch.Controls.Add(Me.btnChangeDateTime)
        Me.gbxRoomVacancySearch.Controls.Add(Me.dtpCheckOutDate)
        Me.gbxRoomVacancySearch.Controls.Add(Me.Label18)
        Me.gbxRoomVacancySearch.Controls.Add(Me.cboRoomType)
        Me.gbxRoomVacancySearch.Controls.Add(Me.txtRoomNumber)
        Me.gbxRoomVacancySearch.Controls.Add(Me.Label19)
        Me.gbxRoomVacancySearch.Controls.Add(Me.Label20)
        Me.gbxRoomVacancySearch.Controls.Add(Me.dtpCheckOutTime)
        Me.gbxRoomVacancySearch.Controls.Add(Me.dtpCheckInTime)
        Me.gbxRoomVacancySearch.Controls.Add(Me.dgvRoomVacancySearch)
        Me.gbxRoomVacancySearch.Controls.Add(Me.btnRoomVacancySearch)
        Me.gbxRoomVacancySearch.Controls.Add(Me.cboView)
        Me.gbxRoomVacancySearch.Controls.Add(Me.cboFloor)
        Me.gbxRoomVacancySearch.Controls.Add(Me.Label78)
        Me.gbxRoomVacancySearch.Controls.Add(Me.Label82)
        Me.gbxRoomVacancySearch.Controls.Add(Me.Label59)
        Me.gbxRoomVacancySearch.Controls.Add(Me.Label25)
        Me.gbxRoomVacancySearch.Controls.Add(Me.dtpCheckInDate)
        Me.gbxRoomVacancySearch.Controls.Add(Me.Label2)
        Me.gbxRoomVacancySearch.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxRoomVacancySearch.Location = New System.Drawing.Point(569, 45)
        Me.gbxRoomVacancySearch.Name = "gbxRoomVacancySearch"
        Me.gbxRoomVacancySearch.Size = New System.Drawing.Size(409, 358)
        Me.gbxRoomVacancySearch.TabIndex = 3
        Me.gbxRoomVacancySearch.TabStop = False
        Me.gbxRoomVacancySearch.Text = "Room Vacancy Search"
        '
        'btnChangeDateTime
        '
        Me.btnChangeDateTime.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeDateTime.Location = New System.Drawing.Point(339, 22)
        Me.btnChangeDateTime.Name = "btnChangeDateTime"
        Me.btnChangeDateTime.Size = New System.Drawing.Size(60, 28)
        Me.btnChangeDateTime.TabIndex = 6
        Me.btnChangeDateTime.Text = "&Change"
        Me.btnChangeDateTime.UseVisualStyleBackColor = True
        '
        'dtpCheckOutDate
        '
        Me.dtpCheckOutDate.CustomFormat = "MMM dd, yyyy"
        Me.dtpCheckOutDate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckOutDate.Location = New System.Drawing.Point(111, 48)
        Me.dtpCheckOutDate.Name = "dtpCheckOutDate"
        Me.dtpCheckOutDate.Size = New System.Drawing.Size(116, 23)
        Me.dtpCheckOutDate.TabIndex = 4
        Me.dtpCheckOutDate.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(107, 18)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "&Check Out Date:"
        '
        'cboRoomType
        '
        Me.cboRoomType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboRoomType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRoomType.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRoomType.FormattingEnabled = True
        Me.cboRoomType.Items.AddRange(New Object() {""})
        Me.cboRoomType.Location = New System.Drawing.Point(286, 77)
        Me.cboRoomType.MaxLength = 50
        Me.cboRoomType.Name = "cboRoomType"
        Me.cboRoomType.Size = New System.Drawing.Size(117, 26)
        Me.cboRoomType.TabIndex = 10
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomNumber.Location = New System.Drawing.Point(74, 79)
        Me.txtRoomNumber.MaxLength = 20
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Size = New System.Drawing.Size(117, 23)
        Me.txtRoomNumber.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(5, 78)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 18)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Room &No.:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(200, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 18)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "Room &Type:"
        '
        'dtpCheckOutTime
        '
        Me.dtpCheckOutTime.CustomFormat = "hhmmtt"
        Me.dtpCheckOutTime.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpCheckOutTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpCheckOutTime.Location = New System.Drawing.Point(233, 48)
        Me.dtpCheckOutTime.Name = "dtpCheckOutTime"
        Me.dtpCheckOutTime.ShowUpDown = True
        Me.dtpCheckOutTime.Size = New System.Drawing.Size(100, 23)
        Me.dtpCheckOutTime.TabIndex = 5
        Me.dtpCheckOutTime.Value = New Date(2006, 12, 11, 11, 59, 0, 0)
        '
        'dtpCheckInTime
        '
        Me.dtpCheckInTime.CustomFormat = "hhmmtt"
        Me.dtpCheckInTime.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpCheckInTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpCheckInTime.Location = New System.Drawing.Point(233, 22)
        Me.dtpCheckInTime.Name = "dtpCheckInTime"
        Me.dtpCheckInTime.ShowUpDown = True
        Me.dtpCheckInTime.Size = New System.Drawing.Size(100, 23)
        Me.dtpCheckInTime.TabIndex = 2
        Me.dtpCheckInTime.Value = New Date(2006, 12, 11, 12, 0, 0, 0)
        '
        'dgvRoomVacancySearch
        '
        Me.dgvRoomVacancySearch.AllowUserToAddRows = False
        Me.dgvRoomVacancySearch.AllowUserToDeleteRows = False
        Me.dgvRoomVacancySearch.AllowUserToOrderColumns = True
        Me.dgvRoomVacancySearch.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRoomVacancySearch.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRoomVacancySearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvRoomVacancySearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvRoomVacancySearch.BackgroundColor = System.Drawing.Color.White
        Me.dgvRoomVacancySearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoomVacancySearch.Location = New System.Drawing.Point(6, 164)
        Me.dgvRoomVacancySearch.MultiSelect = False
        Me.dgvRoomVacancySearch.Name = "dgvRoomVacancySearch"
        Me.dgvRoomVacancySearch.ReadOnly = True
        Me.dgvRoomVacancySearch.RowHeadersVisible = False
        Me.dgvRoomVacancySearch.RowHeadersWidth = 25
        Me.dgvRoomVacancySearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRoomVacancySearch.Size = New System.Drawing.Size(395, 172)
        Me.dgvRoomVacancySearch.TabIndex = 17
        '
        'btnRoomVacancySearch
        '
        Me.btnRoomVacancySearch.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoomVacancySearch.Location = New System.Drawing.Point(341, 133)
        Me.btnRoomVacancySearch.Name = "btnRoomVacancySearch"
        Me.btnRoomVacancySearch.Size = New System.Drawing.Size(60, 28)
        Me.btnRoomVacancySearch.TabIndex = 15
        Me.btnRoomVacancySearch.Text = "&Search"
        Me.btnRoomVacancySearch.UseVisualStyleBackColor = True
        '
        'cboView
        '
        Me.cboView.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboView.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboView.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboView.FormattingEnabled = True
        Me.cboView.Items.AddRange(New Object() {""})
        Me.cboView.Location = New System.Drawing.Point(286, 106)
        Me.cboView.Name = "cboView"
        Me.cboView.Size = New System.Drawing.Size(117, 26)
        Me.cboView.TabIndex = 14
        '
        'cboFloor
        '
        Me.cboFloor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboFloor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFloor.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFloor.FormattingEnabled = True
        Me.cboFloor.Items.AddRange(New Object() {""})
        Me.cboFloor.Location = New System.Drawing.Point(74, 105)
        Me.cboFloor.MaxLength = 30
        Me.cboFloor.Name = "cboFloor"
        Me.cboFloor.Size = New System.Drawing.Size(117, 26)
        Me.cboFloor.TabIndex = 12
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(200, 106)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(42, 18)
        Me.Label78.TabIndex = 13
        Me.Label78.Text = "&View:"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.Color.Red
        Me.Label82.Location = New System.Drawing.Point(6, 339)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(244, 16)
        Me.Label82.TabIndex = 18
        Me.Label82.Text = "Click an item to define its registration details."
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(5, 106)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(45, 18)
        Me.Label59.TabIndex = 11
        Me.Label59.Text = "&Floor:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label25.Location = New System.Drawing.Point(5, 145)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(95, 16)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "Search Result/s:"
        '
        'dtpCheckInDate
        '
        Me.dtpCheckInDate.CustomFormat = "MMM dd, yyyy"
        Me.dtpCheckInDate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckInDate.Location = New System.Drawing.Point(111, 22)
        Me.dtpCheckInDate.Name = "dtpCheckInDate"
        Me.dtpCheckInDate.Size = New System.Drawing.Size(116, 23)
        Me.dtpCheckInDate.TabIndex = 1
        Me.dtpCheckInDate.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Transfer Date:"
        '
        'gbxRoomRegistrationDetails
        '
        Me.gbxRoomRegistrationDetails.BackColor = System.Drawing.Color.Transparent
        Me.gbxRoomRegistrationDetails.Controls.Add(Me.lblRoomRate)
        Me.gbxRoomRegistrationDetails.Controls.Add(Me.lblRoomNumberOld)
        Me.gbxRoomRegistrationDetails.Controls.Add(Me.Label4)
        Me.gbxRoomRegistrationDetails.Controls.Add(Me.lblNumberOfNights)
        Me.gbxRoomRegistrationDetails.Controls.Add(Me.txtNoOfOccupants)
        Me.gbxRoomRegistrationDetails.Controls.Add(Me.Label3)
        Me.gbxRoomRegistrationDetails.Controls.Add(Me.Label12)
        Me.gbxRoomRegistrationDetails.Controls.Add(Me.btnViewDetails)
        Me.gbxRoomRegistrationDetails.Controls.Add(Me.lblRoomNumber)
        Me.gbxRoomRegistrationDetails.Controls.Add(Me.btnAddRoom)
        Me.gbxRoomRegistrationDetails.Controls.Add(Me.Label15)
        Me.gbxRoomRegistrationDetails.Controls.Add(Me.Label27)
        Me.gbxRoomRegistrationDetails.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxRoomRegistrationDetails.Location = New System.Drawing.Point(139, 305)
        Me.gbxRoomRegistrationDetails.Name = "gbxRoomRegistrationDetails"
        Me.gbxRoomRegistrationDetails.Size = New System.Drawing.Size(423, 98)
        Me.gbxRoomRegistrationDetails.TabIndex = 5
        Me.gbxRoomRegistrationDetails.TabStop = False
        Me.gbxRoomRegistrationDetails.Text = "Room Registration Details"
        '
        'lblRoomRate
        '
        Me.lblRoomRate.AutoSize = True
        Me.lblRoomRate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomRate.Location = New System.Drawing.Point(120, 67)
        Me.lblRoomRate.Name = "lblRoomRate"
        Me.lblRoomRate.Size = New System.Drawing.Size(15, 18)
        Me.lblRoomRate.TabIndex = 5
        Me.lblRoomRate.Text = "0"
        '
        'lblRoomNumberOld
        '
        Me.lblRoomNumberOld.AutoSize = True
        Me.lblRoomNumberOld.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.lblRoomNumberOld.Location = New System.Drawing.Point(120, 16)
        Me.lblRoomNumberOld.Name = "lblRoomNumberOld"
        Me.lblRoomNumberOld.Size = New System.Drawing.Size(14, 16)
        Me.lblRoomNumberOld.TabIndex = 1
        Me.lblRoomNumberOld.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "To Room No.:"
        '
        'lblNumberOfNights
        '
        Me.lblNumberOfNights.AutoSize = True
        Me.lblNumberOfNights.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfNights.Location = New System.Drawing.Point(297, 42)
        Me.lblNumberOfNights.Name = "lblNumberOfNights"
        Me.lblNumberOfNights.Size = New System.Drawing.Size(15, 18)
        Me.lblNumberOfNights.TabIndex = 9
        Me.lblNumberOfNights.Text = "0"
        '
        'txtNoOfOccupants
        '
        Me.txtNoOfOccupants.BackColor = System.Drawing.Color.White
        Me.txtNoOfOccupants.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfOccupants.Location = New System.Drawing.Point(325, 16)
        Me.txtNoOfOccupants.MaxLength = 4
        Me.txtNoOfOccupants.Name = "txtNoOfOccupants"
        Me.txtNoOfOccupants.Size = New System.Drawing.Size(56, 23)
        Me.txtNoOfOccupants.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "No. of &Occupants:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(200, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 18)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "No. of Nights:"
        '
        'btnViewDetails
        '
        Me.btnViewDetails.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDetails.Location = New System.Drawing.Point(289, 67)
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.Size = New System.Drawing.Size(117, 28)
        Me.btnViewDetails.TabIndex = 11
        Me.btnViewDetails.Text = "View &Details"
        Me.btnViewDetails.UseVisualStyleBackColor = True
        '
        'lblRoomNumber
        '
        Me.lblRoomNumber.AutoSize = True
        Me.lblRoomNumber.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomNumber.Location = New System.Drawing.Point(120, 42)
        Me.lblRoomNumber.Name = "lblRoomNumber"
        Me.lblRoomNumber.Size = New System.Drawing.Size(15, 18)
        Me.lblRoomNumber.TabIndex = 3
        Me.lblRoomNumber.Text = "0"
        '
        'btnAddRoom
        '
        Me.btnAddRoom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRoom.Location = New System.Drawing.Point(203, 67)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(77, 28)
        Me.btnAddRoom.TabIndex = 10
        Me.btnAddRoom.Text = "&Transfer"
        Me.btnAddRoom.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(10, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 18)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Room Rate:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(10, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(104, 18)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "From Room No.:"
        '
        'lblGuestName
        '
        Me.lblGuestName.AutoSize = True
        Me.lblGuestName.BackColor = System.Drawing.Color.Transparent
        Me.lblGuestName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestName.Location = New System.Drawing.Point(225, 23)
        Me.lblGuestName.Name = "lblGuestName"
        Me.lblGuestName.Size = New System.Drawing.Size(31, 18)
        Me.lblGuestName.TabIndex = 2
        Me.lblGuestName.Text = "N/A"
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblClose.Location = New System.Drawing.Point(945, 10)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(39, 18)
        Me.lblClose.TabIndex = 8
        Me.lblClose.TabStop = True
        Me.lblClose.Text = "Close"
        '
        'frmRoomTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblGuestName)
        Me.Controls.Add(Me.gbxRoomRegistrationDetails)
        Me.Controls.Add(Me.gbxRoomVacancySearch)
        Me.Controls.Add(Me.grpAddRoom)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 80)
        Me.Name = "frmRoomTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SLU Hotel"
        TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvRegRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvCheckOutRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAddRoom.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.gbxRoomVacancySearch.ResumeLayout(False)
        Me.gbxRoomVacancySearch.PerformLayout()
        CType(Me.dgvRoomVacancySearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxRoomRegistrationDetails.ResumeLayout(False)
        Me.gbxRoomRegistrationDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents grpAddRoom As System.Windows.Forms.GroupBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuestSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents tsbNewRegistration As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbUpdateRegistration As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuestFolio As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbPayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gbxRoomVacancySearch As System.Windows.Forms.GroupBox
    Friend WithEvents dtpCheckOutDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboRoomType As System.Windows.Forms.ComboBox
    Private WithEvents txtRoomNumber As System.Windows.Forms.TextBox
    Private WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dtpCheckOutTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCheckInTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvRoomVacancySearch As System.Windows.Forms.DataGridView
    Public WithEvents btnRoomVacancySearch As System.Windows.Forms.Button
    Friend WithEvents cboView As System.Windows.Forms.ComboBox
    Friend WithEvents cboFloor As System.Windows.Forms.ComboBox
    Private WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Private WithEvents Label59 As System.Windows.Forms.Label
    Private WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpCheckInDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbxRoomRegistrationDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoOfOccupants As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents btnViewDetails As System.Windows.Forms.Button
    Friend WithEvents lblRoomNumber As System.Windows.Forms.Label
    Private WithEvents btnAddRoom As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblGuestName As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvRegRooms As System.Windows.Forms.DataGridView
    Friend WithEvents dgvCheckOutRooms As System.Windows.Forms.DataGridView
    Friend WithEvents lblNumberOfNights As System.Windows.Forms.Label
    Friend WithEvents lvwTransferRooms As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblRoomNumberOld As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Private WithEvents btnChangeDateTime As System.Windows.Forms.Button
    Private WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTotalBalance As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPayments As System.Windows.Forms.Label
    Friend WithEvents lblTotalCharges As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblRoomRate As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.LinkLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
