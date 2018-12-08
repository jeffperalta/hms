<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateRoomRates
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
        Me.gbxRates = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnNoRate = New System.Windows.Forms.Button
        Me.radSelectAll = New System.Windows.Forms.RadioButton
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.optOnDate = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDays = New System.Windows.Forms.TextBox
        Me.optNextDays = New System.Windows.Forms.RadioButton
        Me.optToday = New System.Windows.Forms.RadioButton
        Me.dgvRooms = New System.Windows.Forms.DataGridView
        Me.gbxApplyToRoom = New System.Windows.Forms.GroupBox
        Me.chkViewAllRooms = New System.Windows.Forms.CheckBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.lsvRoom = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.btnActivate = New System.Windows.Forms.Button
        Me.btnSelectAll = New System.Windows.Forms.Button
        Me.lblCountSelected = New System.Windows.Forms.Label
        Me.lblCount = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.gbxNoRates = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dgvNoRates = New System.Windows.Forms.DataGridView
        Me.lblRateNo = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCancelAtUnassignedRooms = New System.Windows.Forms.Button
        Me.lsvRoomRatesAndTypes = New System.Windows.Forms.ListView
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.btnSaveAtUnassignedRooms = New System.Windows.Forms.Button
        Me.lblCountUnassigned = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tlsRoomSettings = New System.Windows.Forms.ToolStrip
        Me.tsbSystemSettings = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbRoomRatesAndTypes = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbFeaturesAndFacilities = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.Label11 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.gbxRates.SuspendLayout()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxApplyToRoom.SuspendLayout()
        Me.gbxNoRates.SuspendLayout()
        CType(Me.dgvNoRates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlsRoomSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxRates
        '
        Me.gbxRates.BackColor = System.Drawing.Color.Transparent
        Me.gbxRates.Controls.Add(Me.Label7)
        Me.gbxRates.Controls.Add(Me.btnNoRate)
        Me.gbxRates.Controls.Add(Me.radSelectAll)
        Me.gbxRates.Controls.Add(Me.dtpDate)
        Me.gbxRates.Controls.Add(Me.optOnDate)
        Me.gbxRates.Controls.Add(Me.Label1)
        Me.gbxRates.Controls.Add(Me.txtDays)
        Me.gbxRates.Controls.Add(Me.optNextDays)
        Me.gbxRates.Controls.Add(Me.optToday)
        Me.gbxRates.Controls.Add(Me.dgvRooms)
        Me.gbxRates.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxRates.Location = New System.Drawing.Point(141, 27)
        Me.gbxRates.Name = "gbxRates"
        Me.gbxRates.Size = New System.Drawing.Size(839, 265)
        Me.gbxRates.TabIndex = 1
        Me.gbxRates.TabStop = False
        Me.gbxRates.Text = "Room Rates"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(6, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(263, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Double click an item to update the rates of rooms."
        '
        'btnNoRate
        '
        Me.btnNoRate.AutoSize = True
        Me.btnNoRate.Location = New System.Drawing.Point(687, 209)
        Me.btnNoRate.Name = "btnNoRate"
        Me.btnNoRate.Size = New System.Drawing.Size(146, 28)
        Me.btnNoRate.TabIndex = 8
        Me.btnNoRate.Text = "&Rooms with No Rate"
        Me.btnNoRate.UseVisualStyleBackColor = True
        '
        'radSelectAll
        '
        Me.radSelectAll.AutoSize = True
        Me.radSelectAll.Checked = True
        Me.radSelectAll.Location = New System.Drawing.Point(8, 187)
        Me.radSelectAll.Name = "radSelectAll"
        Me.radSelectAll.Size = New System.Drawing.Size(71, 22)
        Me.radSelectAll.TabIndex = 1
        Me.radSelectAll.TabStop = True
        Me.radSelectAll.Text = "View &All"
        Me.radSelectAll.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "MMMM dd, yyyy dddd"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(457, 211)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(215, 23)
        Me.dtpDate.TabIndex = 7
        '
        'optOnDate
        '
        Me.optOnDate.AutoSize = True
        Me.optOnDate.Location = New System.Drawing.Point(277, 215)
        Me.optOnDate.Name = "optOnDate"
        Me.optOnDate.Size = New System.Drawing.Size(180, 22)
        Me.optOnDate.TabIndex = 6
        Me.optOnDate.Text = "Rates that will activate &on"
        Me.optOnDate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(600, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Days"
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(538, 182)
        Me.txtDays.MaxLength = 2
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(56, 23)
        Me.txtDays.TabIndex = 4
        '
        'optNextDays
        '
        Me.optNextDays.AutoSize = True
        Me.optNextDays.Location = New System.Drawing.Point(277, 187)
        Me.optNextDays.Name = "optNextDays"
        Me.optNextDays.Size = New System.Drawing.Size(265, 22)
        Me.optNextDays.TabIndex = 3
        Me.optNextDays.Text = "Rates that will be activated for the &next "
        Me.optNextDays.UseVisualStyleBackColor = True
        '
        'optToday
        '
        Me.optToday.AutoSize = True
        Me.optToday.Location = New System.Drawing.Point(8, 212)
        Me.optToday.Name = "optToday"
        Me.optToday.Size = New System.Drawing.Size(241, 22)
        Me.optToday.TabIndex = 2
        Me.optToday.Text = "Rates that should be activated &today"
        Me.optToday.UseVisualStyleBackColor = True
        '
        'dgvRooms
        '
        Me.dgvRooms.AllowUserToAddRows = False
        Me.dgvRooms.AllowUserToDeleteRows = False
        Me.dgvRooms.AllowUserToOrderColumns = True
        Me.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvRooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRooms.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvRooms.Location = New System.Drawing.Point(3, 19)
        Me.dgvRooms.MultiSelect = False
        Me.dgvRooms.Name = "dgvRooms"
        Me.dgvRooms.ReadOnly = True
        Me.dgvRooms.RowHeadersVisible = False
        Me.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRooms.Size = New System.Drawing.Size(833, 153)
        Me.dgvRooms.TabIndex = 0
        '
        'gbxApplyToRoom
        '
        Me.gbxApplyToRoom.BackColor = System.Drawing.Color.Transparent
        Me.gbxApplyToRoom.Controls.Add(Me.chkViewAllRooms)
        Me.gbxApplyToRoom.Controls.Add(Me.btnCancel)
        Me.gbxApplyToRoom.Controls.Add(Me.lsvRoom)
        Me.gbxApplyToRoom.Controls.Add(Me.btnActivate)
        Me.gbxApplyToRoom.Controls.Add(Me.btnSelectAll)
        Me.gbxApplyToRoom.Controls.Add(Me.lblCountSelected)
        Me.gbxApplyToRoom.Controls.Add(Me.lblCount)
        Me.gbxApplyToRoom.Controls.Add(Me.Label13)
        Me.gbxApplyToRoom.Controls.Add(Me.Label12)
        Me.gbxApplyToRoom.Enabled = False
        Me.gbxApplyToRoom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxApplyToRoom.Location = New System.Drawing.Point(139, 292)
        Me.gbxApplyToRoom.Name = "gbxApplyToRoom"
        Me.gbxApplyToRoom.Size = New System.Drawing.Size(839, 316)
        Me.gbxApplyToRoom.TabIndex = 2
        Me.gbxApplyToRoom.TabStop = False
        Me.gbxApplyToRoom.Text = "Apply to Room"
        '
        'chkViewAllRooms
        '
        Me.chkViewAllRooms.AutoSize = True
        Me.chkViewAllRooms.Location = New System.Drawing.Point(278, 283)
        Me.chkViewAllRooms.Name = "chkViewAllRooms"
        Me.chkViewAllRooms.Size = New System.Drawing.Size(114, 22)
        Me.chkViewAllRooms.TabIndex = 5
        Me.chkViewAllRooms.Text = "&View all Rooms"
        Me.chkViewAllRooms.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.Location = New System.Drawing.Point(767, 280)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 28)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lsvRoom
        '
        Me.lsvRoom.CheckBoxes = True
        Me.lsvRoom.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lsvRoom.Dock = System.Windows.Forms.DockStyle.Top
        Me.lsvRoom.FullRowSelect = True
        Me.lsvRoom.GridLines = True
        Me.lsvRoom.Location = New System.Drawing.Point(3, 19)
        Me.lsvRoom.MultiSelect = False
        Me.lsvRoom.Name = "lsvRoom"
        Me.lsvRoom.Size = New System.Drawing.Size(833, 241)
        Me.lsvRoom.TabIndex = 0
        Me.lsvRoom.UseCompatibleStateImageBehavior = False
        Me.lsvRoom.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Room No"
        Me.ColumnHeader1.Width = 91
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Room Type"
        Me.ColumnHeader2.Width = 163
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Current Status"
        Me.ColumnHeader3.Width = 141
        '
        'btnActivate
        '
        Me.btnActivate.AutoSize = True
        Me.btnActivate.Location = New System.Drawing.Point(701, 280)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(60, 28)
        Me.btnActivate.TabIndex = 7
        Me.btnActivate.Text = "&Save"
        Me.btnActivate.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.AutoSize = True
        Me.btnSelectAll.Location = New System.Drawing.Point(620, 280)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(75, 28)
        Me.btnSelectAll.TabIndex = 6
        Me.btnSelectAll.Text = "Select &All"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'lblCountSelected
        '
        Me.lblCountSelected.AutoSize = True
        Me.lblCountSelected.Location = New System.Drawing.Point(192, 285)
        Me.lblCountSelected.Name = "lblCountSelected"
        Me.lblCountSelected.Size = New System.Drawing.Size(15, 18)
        Me.lblCountSelected.TabIndex = 4
        Me.lblCountSelected.Text = "0"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(59, 285)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(15, 18)
        Me.lblCount.TabIndex = 2
        Me.lblCount.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(124, 285)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 18)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Selected:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 285)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 18)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Count:"
        '
        'gbxNoRates
        '
        Me.gbxNoRates.BackColor = System.Drawing.Color.Transparent
        Me.gbxNoRates.Controls.Add(Me.Label3)
        Me.gbxNoRates.Controls.Add(Me.dgvNoRates)
        Me.gbxNoRates.Controls.Add(Me.lblRateNo)
        Me.gbxNoRates.Controls.Add(Me.Label2)
        Me.gbxNoRates.Controls.Add(Me.btnCancelAtUnassignedRooms)
        Me.gbxNoRates.Controls.Add(Me.lsvRoomRatesAndTypes)
        Me.gbxNoRates.Controls.Add(Me.btnSaveAtUnassignedRooms)
        Me.gbxNoRates.Controls.Add(Me.lblCountUnassigned)
        Me.gbxNoRates.Controls.Add(Me.Label5)
        Me.gbxNoRates.Enabled = False
        Me.gbxNoRates.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxNoRates.Location = New System.Drawing.Point(144, 293)
        Me.gbxNoRates.Name = "gbxNoRates"
        Me.gbxNoRates.Size = New System.Drawing.Size(836, 316)
        Me.gbxNoRates.TabIndex = 0
        Me.gbxNoRates.TabStop = False
        Me.gbxNoRates.Text = "Rooms that have no rates"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(134, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Select a room and check its current rate below"
        '
        'dgvNoRates
        '
        Me.dgvNoRates.AllowUserToAddRows = False
        Me.dgvNoRates.AllowUserToDeleteRows = False
        Me.dgvNoRates.AllowUserToOrderColumns = True
        Me.dgvNoRates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvNoRates.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvNoRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNoRates.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvNoRates.Location = New System.Drawing.Point(3, 19)
        Me.dgvNoRates.MultiSelect = False
        Me.dgvNoRates.Name = "dgvNoRates"
        Me.dgvNoRates.ReadOnly = True
        Me.dgvNoRates.RowHeadersVisible = False
        Me.dgvNoRates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNoRates.Size = New System.Drawing.Size(830, 93)
        Me.dgvNoRates.TabIndex = 0
        '
        'lblRateNo
        '
        Me.lblRateNo.AutoEllipsis = True
        Me.lblRateNo.BackColor = System.Drawing.Color.Transparent
        Me.lblRateNo.Location = New System.Drawing.Point(710, 523)
        Me.lblRateNo.Name = "lblRateNo"
        Me.lblRateNo.Size = New System.Drawing.Size(113, 18)
        Me.lblRateNo.TabIndex = 348
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Defined rates for this room:"
        '
        'btnCancelAtUnassignedRooms
        '
        Me.btnCancelAtUnassignedRooms.AutoSize = True
        Me.btnCancelAtUnassignedRooms.Location = New System.Drawing.Point(746, 279)
        Me.btnCancelAtUnassignedRooms.Name = "btnCancelAtUnassignedRooms"
        Me.btnCancelAtUnassignedRooms.Size = New System.Drawing.Size(75, 28)
        Me.btnCancelAtUnassignedRooms.TabIndex = 7
        Me.btnCancelAtUnassignedRooms.Text = "&Cancel"
        Me.btnCancelAtUnassignedRooms.UseVisualStyleBackColor = True
        '
        'lsvRoomRatesAndTypes
        '
        Me.lsvRoomRatesAndTypes.CheckBoxes = True
        Me.lsvRoomRatesAndTypes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lsvRoomRatesAndTypes.FullRowSelect = True
        Me.lsvRoomRatesAndTypes.GridLines = True
        Me.lsvRoomRatesAndTypes.Location = New System.Drawing.Point(-2, 158)
        Me.lsvRoomRatesAndTypes.MultiSelect = False
        Me.lsvRoomRatesAndTypes.Name = "lsvRoomRatesAndTypes"
        Me.lsvRoomRatesAndTypes.Size = New System.Drawing.Size(832, 115)
        Me.lsvRoomRatesAndTypes.TabIndex = 5
        Me.lsvRoomRatesAndTypes.UseCompatibleStateImageBehavior = False
        Me.lsvRoomRatesAndTypes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Rate Name"
        Me.ColumnHeader7.Width = 131
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Amount"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 110
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Starts on"
        Me.ColumnHeader9.Width = 135
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "End On"
        Me.ColumnHeader10.Width = 122
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "RoomType"
        Me.ColumnHeader11.Width = 130
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Remarks"
        Me.ColumnHeader12.Width = 141
        '
        'btnSaveAtUnassignedRooms
        '
        Me.btnSaveAtUnassignedRooms.AutoSize = True
        Me.btnSaveAtUnassignedRooms.Location = New System.Drawing.Point(665, 279)
        Me.btnSaveAtUnassignedRooms.Name = "btnSaveAtUnassignedRooms"
        Me.btnSaveAtUnassignedRooms.Size = New System.Drawing.Size(75, 28)
        Me.btnSaveAtUnassignedRooms.TabIndex = 6
        Me.btnSaveAtUnassignedRooms.Text = "&Save"
        Me.btnSaveAtUnassignedRooms.UseVisualStyleBackColor = True
        '
        'lblCountUnassigned
        '
        Me.lblCountUnassigned.AutoSize = True
        Me.lblCountUnassigned.Location = New System.Drawing.Point(54, 117)
        Me.lblCountUnassigned.Name = "lblCountUnassigned"
        Me.lblCountUnassigned.Size = New System.Drawing.Size(15, 18)
        Me.lblCountUnassigned.TabIndex = 2
        Me.lblCountUnassigned.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Count:"
        '
        'tlsRoomSettings
        '
        Me.tlsRoomSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tlsRoomSettings.AutoSize = False
        Me.tlsRoomSettings.BackColor = System.Drawing.Color.Transparent
        Me.tlsRoomSettings.Dock = System.Windows.Forms.DockStyle.None
        Me.tlsRoomSettings.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.tlsRoomSettings.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsRoomSettings.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.tlsRoomSettings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSystemSettings, Me.ToolStripSeparator7, Me.tsbRoomRatesAndTypes, Me.ToolStripSeparator1, Me.tsbFeaturesAndFacilities, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator3})
        Me.tlsRoomSettings.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tlsRoomSettings.Location = New System.Drawing.Point(5, 82)
        Me.tlsRoomSettings.Name = "tlsRoomSettings"
        Me.tlsRoomSettings.Size = New System.Drawing.Size(110, 308)
        Me.tlsRoomSettings.TabIndex = 3
        Me.tlsRoomSettings.Text = "ToolStrip2"
        '
        'tsbSystemSettings
        '
        Me.tsbSystemSettings.AutoSize = False
        Me.tsbSystemSettings.AutoToolTip = False
        Me.tsbSystemSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsbSystemSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbSystemSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSystemSettings.Name = "tsbSystemSettings"
        Me.tsbSystemSettings.Size = New System.Drawing.Size(120, 30)
        Me.tsbSystemSettings.Text = "System Settings"
        Me.tsbSystemSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(108, 6)
        '
        'tsbRoomRatesAndTypes
        '
        Me.tsbRoomRatesAndTypes.AutoSize = False
        Me.tsbRoomRatesAndTypes.AutoToolTip = False
        Me.tsbRoomRatesAndTypes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsbRoomRatesAndTypes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbRoomRatesAndTypes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRoomRatesAndTypes.Name = "tsbRoomRatesAndTypes"
        Me.tsbRoomRatesAndTypes.Size = New System.Drawing.Size(120, 30)
        Me.tsbRoomRatesAndTypes.Text = "Room Rates && Types"
        Me.tsbRoomRatesAndTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(108, 6)
        '
        'tsbFeaturesAndFacilities
        '
        Me.tsbFeaturesAndFacilities.AutoSize = False
        Me.tsbFeaturesAndFacilities.AutoToolTip = False
        Me.tsbFeaturesAndFacilities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsbFeaturesAndFacilities.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbFeaturesAndFacilities.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFeaturesAndFacilities.Name = "tsbFeaturesAndFacilities"
        Me.tsbFeaturesAndFacilities.Size = New System.Drawing.Size(120, 30)
        Me.tsbFeaturesAndFacilities.Text = "Features && Facilities"
        Me.tsbFeaturesAndFacilities.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(108, 6)
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
        Me.ToolStripButton1.Text = "Room Settings"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(108, 6)
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 73)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Update Room Rate Settings"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(945, 10)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(39, 18)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Close"
        '
        'frmUpdateRoomRates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.gbxApplyToRoom)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tlsRoomSettings)
        Me.Controls.Add(Me.gbxRates)
        Me.Controls.Add(Me.gbxNoRates)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdateRoomRates"
        Me.Text = "frmUpdateRoomCharges"
        Me.gbxRates.ResumeLayout(False)
        Me.gbxRates.PerformLayout()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxApplyToRoom.ResumeLayout(False)
        Me.gbxApplyToRoom.PerformLayout()
        Me.gbxNoRates.ResumeLayout(False)
        Me.gbxNoRates.PerformLayout()
        CType(Me.dgvNoRates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlsRoomSettings.ResumeLayout(False)
        Me.tlsRoomSettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxRates As System.Windows.Forms.GroupBox
    Friend WithEvents dgvRooms As System.Windows.Forms.DataGridView
    Friend WithEvents optOnDate As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDays As System.Windows.Forms.TextBox
    Friend WithEvents optNextDays As System.Windows.Forms.RadioButton
    Friend WithEvents optToday As System.Windows.Forms.RadioButton
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbxApplyToRoom As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents lblCountSelected As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnActivate As System.Windows.Forms.Button
    Friend WithEvents lsvRoom As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbxNoRates As System.Windows.Forms.GroupBox
    Friend WithEvents btnSaveAtUnassignedRooms As System.Windows.Forms.Button
    Friend WithEvents lblCountUnassigned As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancelAtUnassignedRooms As System.Windows.Forms.Button
    Friend WithEvents lsvRoomRatesAndTypes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnNoRate As System.Windows.Forms.Button
    Friend WithEvents lblRateNo As System.Windows.Forms.Label
    Friend WithEvents dgvNoRates As System.Windows.Forms.DataGridView
    Friend WithEvents radSelectAll As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tlsRoomSettings As System.Windows.Forms.ToolStrip
    Public WithEvents tsbSystemSettings As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents tsbRoomRatesAndTypes As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents tsbFeaturesAndFacilities As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkViewAllRooms As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Public WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
End Class
