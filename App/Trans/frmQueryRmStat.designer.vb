<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQueryRmStat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQueryRmStat))
        Me.tbCtlRoomStatusQuery = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lblResult_1 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkExactMatch = New System.Windows.Forms.CheckBox
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.dgvRoomMaintenanceStatus = New System.Windows.Forms.DataGridView
        Me.btnShow = New System.Windows.Forms.Button
        Me.btnViewRoomDetails = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboFloor = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblFDOName = New System.Windows.Forms.Label
        Me.cboType = New System.Windows.Forms.ComboBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dgvReservedRooms = New System.Windows.Forms.DataGridView
        Me.dtpDateFrom2 = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnShowReservedRooms = New System.Windows.Forms.Button
        Me.dtpDateTo2 = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.dgvRegisteredRooms = New System.Windows.Forms.DataGridView
        Me.dtpDateFrom3 = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnShowRegisteredRooms = New System.Windows.Forms.Button
        Me.dtpDateTo3 = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.tsActivities = New System.Windows.Forms.ToolStrip
        Me.tsbQueryShift = New System.Windows.Forms.ToolStripButton
        Me.tss1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbQuerySettings = New System.Windows.Forms.ToolStripButton
        Me.tss2 = New System.Windows.Forms.ToolStripSeparator
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblClose = New System.Windows.Forms.LinkLabel
        Me.tbCtlRoomStatusQuery.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvRoomMaintenanceStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvReservedRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvRegisteredRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsActivities.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbCtlRoomStatusQuery
        '
        Me.tbCtlRoomStatusQuery.Controls.Add(Me.TabPage1)
        Me.tbCtlRoomStatusQuery.Controls.Add(Me.TabPage2)
        Me.tbCtlRoomStatusQuery.Controls.Add(Me.TabPage3)
        Me.tbCtlRoomStatusQuery.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCtlRoomStatusQuery.Location = New System.Drawing.Point(138, 15)
        Me.tbCtlRoomStatusQuery.Name = "tbCtlRoomStatusQuery"
        Me.tbCtlRoomStatusQuery.SelectedIndex = 0
        Me.tbCtlRoomStatusQuery.Size = New System.Drawing.Size(850, 588)
        Me.tbCtlRoomStatusQuery.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.lblResult_1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.chkExactMatch)
        Me.TabPage1.Controls.Add(Me.cboStatus)
        Me.TabPage1.Controls.Add(Me.dgvRoomMaintenanceStatus)
        Me.TabPage1.Controls.Add(Me.btnShow)
        Me.TabPage1.Controls.Add(Me.btnViewRoomDetails)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.cboFloor)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.lblFDOName)
        Me.TabPage1.Controls.Add(Me.cboType)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(842, 557)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Room Maintenance Status"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblResult_1
        '
        Me.lblResult_1.AutoSize = True
        Me.lblResult_1.BackColor = System.Drawing.Color.Transparent
        Me.lblResult_1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult_1.Location = New System.Drawing.Point(65, 528)
        Me.lblResult_1.Name = "lblResult_1"
        Me.lblResult_1.Size = New System.Drawing.Size(15, 18)
        Me.lblResult_1.TabIndex = 14
        Me.lblResult_1.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 528)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Results"
        '
        'chkExactMatch
        '
        Me.chkExactMatch.AutoSize = True
        Me.chkExactMatch.BackColor = System.Drawing.Color.Transparent
        Me.chkExactMatch.Checked = True
        Me.chkExactMatch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkExactMatch.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExactMatch.Location = New System.Drawing.Point(546, 15)
        Me.chkExactMatch.Name = "chkExactMatch"
        Me.chkExactMatch.Size = New System.Drawing.Size(98, 22)
        Me.chkExactMatch.TabIndex = 9
        Me.chkExactMatch.Text = "&Exact Match"
        Me.chkExactMatch.UseVisualStyleBackColor = False
        '
        'cboStatus
        '
        Me.cboStatus.AutoCompleteCustomSource.AddRange(New String() {"Vacant Clean ", "Vacant Dirty", "Vacant "})
        Me.cboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"CLEAN", "DIRTY", "MAINTENANCE"})
        Me.cboStatus.Location = New System.Drawing.Point(400, 13)
        Me.cboStatus.MaxLength = 50
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(131, 26)
        Me.cboStatus.TabIndex = 8
        '
        'dgvRoomMaintenanceStatus
        '
        Me.dgvRoomMaintenanceStatus.AllowUserToAddRows = False
        Me.dgvRoomMaintenanceStatus.AllowUserToDeleteRows = False
        Me.dgvRoomMaintenanceStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvRoomMaintenanceStatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvRoomMaintenanceStatus.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvRoomMaintenanceStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoomMaintenanceStatus.Location = New System.Drawing.Point(6, 46)
        Me.dgvRoomMaintenanceStatus.MultiSelect = False
        Me.dgvRoomMaintenanceStatus.Name = "dgvRoomMaintenanceStatus"
        Me.dgvRoomMaintenanceStatus.ReadOnly = True
        Me.dgvRoomMaintenanceStatus.RowHeadersVisible = False
        Me.dgvRoomMaintenanceStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRoomMaintenanceStatus.Size = New System.Drawing.Size(826, 471)
        Me.dgvRoomMaintenanceStatus.TabIndex = 11
        '
        'btnShow
        '
        Me.btnShow.AutoSize = True
        Me.btnShow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(660, 10)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(60, 28)
        Me.btnShow.TabIndex = 10
        Me.btnShow.Text = "&Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnViewRoomDetails
        '
        Me.btnViewRoomDetails.AutoSize = True
        Me.btnViewRoomDetails.Location = New System.Drawing.Point(706, 523)
        Me.btnViewRoomDetails.Name = "btnViewRoomDetails"
        Me.btnViewRoomDetails.Size = New System.Drawing.Size(126, 28)
        Me.btnViewRoomDetails.TabIndex = 12
        Me.btnViewRoomDetails.Text = "&View Room Details"
        Me.btnViewRoomDetails.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(353, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&Status:"
        '
        'cboFloor
        '
        Me.cboFloor.FormattingEnabled = True
        Me.cboFloor.Items.AddRange(New Object() {"cboStatus.SelectedItem.ToString ", "cboStatus.SelectedItem.ToString ", "cboStatus.SelectedItem.ToString ", "cboStatus.SelectedItem.ToString "})
        Me.cboFloor.Location = New System.Drawing.Point(253, 13)
        Me.cboFloor.MaxLength = 30
        Me.cboFloor.Name = "cboFloor"
        Me.cboFloor.Size = New System.Drawing.Size(89, 26)
        Me.cboFloor.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(213, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "&Floor:"
        '
        'lblFDOName
        '
        Me.lblFDOName.AutoSize = True
        Me.lblFDOName.BackColor = System.Drawing.Color.Transparent
        Me.lblFDOName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFDOName.Location = New System.Drawing.Point(9, 15)
        Me.lblFDOName.Name = "lblFDOName"
        Me.lblFDOName.Size = New System.Drawing.Size(41, 18)
        Me.lblFDOName.TabIndex = 3
        Me.lblFDOName.Text = "&Type:"
        '
        'cboType
        '
        Me.cboType.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cboType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"cboStatus.SelectedItem.ToString ", "cboStatus.SelectedItem.ToString ", "cboStatus.SelectedItem.ToString ", "cboStatus.SelectedItem.ToString "})
        Me.cboType.Location = New System.Drawing.Point(52, 12)
        Me.cboType.MaxLength = 50
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(148, 26)
        Me.cboType.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.dgvReservedRooms)
        Me.TabPage2.Controls.Add(Me.dtpDateFrom2)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.btnShowReservedRooms)
        Me.TabPage2.Controls.Add(Me.dtpDateTo2)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(842, 557)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reserved Rooms"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 530)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 530)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Results"
        '
        'dgvReservedRooms
        '
        Me.dgvReservedRooms.AllowUserToAddRows = False
        Me.dgvReservedRooms.AllowUserToDeleteRows = False
        Me.dgvReservedRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvReservedRooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvReservedRooms.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvReservedRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservedRooms.Location = New System.Drawing.Point(3, 37)
        Me.dgvReservedRooms.MultiSelect = False
        Me.dgvReservedRooms.Name = "dgvReservedRooms"
        Me.dgvReservedRooms.ReadOnly = True
        Me.dgvReservedRooms.RowHeadersVisible = False
        Me.dgvReservedRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservedRooms.Size = New System.Drawing.Size(833, 490)
        Me.dgvReservedRooms.TabIndex = 13
        '
        'dtpDateFrom2
        '
        Me.dtpDateFrom2.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDateFrom2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom2.Location = New System.Drawing.Point(89, 6)
        Me.dtpDateFrom2.Name = "dtpDateFrom2"
        Me.dtpDateFrom2.Size = New System.Drawing.Size(149, 23)
        Me.dtpDateFrom2.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(9, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "&Date From:"
        '
        'btnShowReservedRooms
        '
        Me.btnShowReservedRooms.AutoSize = True
        Me.btnShowReservedRooms.Location = New System.Drawing.Point(463, 3)
        Me.btnShowReservedRooms.Name = "btnShowReservedRooms"
        Me.btnShowReservedRooms.Size = New System.Drawing.Size(60, 28)
        Me.btnShowReservedRooms.TabIndex = 12
        Me.btnShowReservedRooms.Text = "&Show"
        Me.btnShowReservedRooms.UseVisualStyleBackColor = True
        '
        'dtpDateTo2
        '
        Me.dtpDateTo2.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDateTo2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo2.Location = New System.Drawing.Point(295, 6)
        Me.dtpDateTo2.Name = "dtpDateTo2"
        Me.dtpDateTo2.Size = New System.Drawing.Size(149, 23)
        Me.dtpDateTo2.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(261, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "&To:"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.dgvRegisteredRooms)
        Me.TabPage3.Controls.Add(Me.dtpDateFrom3)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.btnShowRegisteredRooms)
        Me.TabPage3.Controls.Add(Me.dtpDateTo3)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(842, 557)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Registered Rooms"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(70, 528)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 18)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(14, 528)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 18)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Results"
        '
        'dgvRegisteredRooms
        '
        Me.dgvRegisteredRooms.AllowUserToAddRows = False
        Me.dgvRegisteredRooms.AllowUserToDeleteRows = False
        Me.dgvRegisteredRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvRegisteredRooms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvRegisteredRooms.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvRegisteredRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegisteredRooms.Location = New System.Drawing.Point(6, 39)
        Me.dgvRegisteredRooms.MultiSelect = False
        Me.dgvRegisteredRooms.Name = "dgvRegisteredRooms"
        Me.dgvRegisteredRooms.ReadOnly = True
        Me.dgvRegisteredRooms.RowHeadersVisible = False
        Me.dgvRegisteredRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRegisteredRooms.Size = New System.Drawing.Size(830, 482)
        Me.dgvRegisteredRooms.TabIndex = 13
        '
        'dtpDateFrom3
        '
        Me.dtpDateFrom3.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDateFrom3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom3.Location = New System.Drawing.Point(88, 9)
        Me.dtpDateFrom3.Name = "dtpDateFrom3"
        Me.dtpDateFrom3.Size = New System.Drawing.Size(145, 23)
        Me.dtpDateFrom3.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(14, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 18)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = " &Date From:"
        '
        'btnShowRegisteredRooms
        '
        Me.btnShowRegisteredRooms.AutoSize = True
        Me.btnShowRegisteredRooms.Location = New System.Drawing.Point(435, 6)
        Me.btnShowRegisteredRooms.Name = "btnShowRegisteredRooms"
        Me.btnShowRegisteredRooms.Size = New System.Drawing.Size(60, 28)
        Me.btnShowRegisteredRooms.TabIndex = 12
        Me.btnShowRegisteredRooms.Text = "&Show"
        Me.btnShowRegisteredRooms.UseVisualStyleBackColor = True
        '
        'dtpDateTo3
        '
        Me.dtpDateTo3.CustomFormat = "MMMM dd,yyyy"
        Me.dtpDateTo3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo3.Location = New System.Drawing.Point(284, 10)
        Me.dtpDateTo3.Name = "dtpDateTo3"
        Me.dtpDateTo3.Size = New System.Drawing.Size(145, 23)
        Me.dtpDateTo3.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(250, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 18)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "&To:"
        '
        'tsActivities
        '
        Me.tsActivities.AutoSize = False
        Me.tsActivities.BackColor = System.Drawing.Color.Transparent
        Me.tsActivities.Dock = System.Windows.Forms.DockStyle.None
        Me.tsActivities.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsActivities.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.tsActivities.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbQueryShift, Me.tss1, Me.tsbQuerySettings, Me.tss2})
        Me.tsActivities.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsActivities.Location = New System.Drawing.Point(2, 76)
        Me.tsActivities.Name = "tsActivities"
        Me.tsActivities.ShowItemToolTips = False
        Me.tsActivities.Size = New System.Drawing.Size(113, 315)
        Me.tsActivities.TabIndex = 2
        Me.tsActivities.Text = "ToolStrip2"
        '
        'tsbQueryShift
        '
        Me.tsbQueryShift.AutoSize = False
        Me.tsbQueryShift.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbQueryShift.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQueryShift.Name = "tsbQueryShift"
        Me.tsbQueryShift.Size = New System.Drawing.Size(120, 30)
        Me.tsbQueryShift.Text = "FDO Shift Query"
        Me.tsbQueryShift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss1
        '
        Me.tss1.Name = "tss1"
        Me.tss1.Size = New System.Drawing.Size(111, 6)
        '
        'tsbQuerySettings
        '
        Me.tsbQuerySettings.AutoSize = False
        Me.tsbQuerySettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbQuerySettings.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbQuerySettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuerySettings.Name = "tsbQuerySettings"
        Me.tsbQuerySettings.Size = New System.Drawing.Size(120, 30)
        Me.tsbQuerySettings.Text = "Settings Query"
        Me.tsbQuerySettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss2
        '
        Me.tss2.Name = "tss2"
        Me.tss2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tss2.Size = New System.Drawing.Size(111, 6)
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(4, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 70)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Room Status Query"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.lblClose.TabIndex = 3
        Me.lblClose.TabStop = True
        Me.lblClose.Text = "Close"
        '
        'frmQueryRmStat
        '
        Me.AcceptButton = Me.btnShow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.tbCtlRoomStatusQuery)
        Me.Controls.Add(Me.tsActivities)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 80)
        Me.Name = "frmQueryRmStat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SLU Hotel"
        Me.tbCtlRoomStatusQuery.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvRoomMaintenanceStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvReservedRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvRegisteredRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsActivities.ResumeLayout(False)
        Me.tsActivities.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbCtlRoomStatusQuery As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Private WithEvents btnViewRoomDetails As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboFloor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFDOName As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dtpDateFrom2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnShowReservedRooms As System.Windows.Forms.Button
    Friend WithEvents dtpDateTo2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dtpDateFrom3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnShowRegisteredRooms As System.Windows.Forms.Button
    Friend WithEvents dtpDateTo3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tsActivities As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbQueryShift As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbQuerySettings As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvRoomMaintenanceStatus As System.Windows.Forms.DataGridView
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents dgvReservedRooms As System.Windows.Forms.DataGridView
    Friend WithEvents dgvRegisteredRooms As System.Windows.Forms.DataGridView
    Friend WithEvents chkExactMatch As System.Windows.Forms.CheckBox
    Friend WithEvents lblClose As System.Windows.Forms.LinkLabel
    Friend WithEvents lblResult_1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
