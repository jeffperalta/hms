<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateRoomCharge
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
        Me.tsActivities = New System.Windows.Forms.ToolStrip
        Me.tsbActGuestSearch = New System.Windows.Forms.ToolStripButton
        Me.tss1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbActGuestFolio = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbActGuestInfo = New System.Windows.Forms.ToolStripButton
        Me.tss6 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbActPayment = New System.Windows.Forms.ToolStripButton
        Me.tss7 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Label11 = New System.Windows.Forms.Label
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.lvwRoomsToUpdate = New System.Windows.Forms.ListView
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader16 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader17 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader18 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader21 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader22 = New System.Windows.Forms.ColumnHeader
        Me.dtpDateOfUpdate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnRemove = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNoOfDays = New System.Windows.Forms.NumericUpDown
        Me.radUseCurrentRoomRate = New System.Windows.Forms.RadioButton
        Me.raduseRegistrationRoomRate = New System.Windows.Forms.RadioButton
        Me.btnSave = New System.Windows.Forms.Button
        Me.lblCountToUpdate = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSelect = New System.Windows.Forms.Button
        Me.lblCountRegisteredRoom = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpLastUpdate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.chkDisplayAll = New System.Windows.Forms.CheckBox
        Me.lsvRegisteredRooms = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.chkDetails = New System.Windows.Forms.CheckBox
        Me.lblClose = New System.Windows.Forms.LinkLabel
        Me.lblRegAmt = New System.Windows.Forms.Label
        Me.lblCurAmt = New System.Windows.Forms.Label
        Me.tsActivities.SuspendLayout()
        CType(Me.txtNoOfDays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsActivities
        '
        Me.tsActivities.AutoSize = False
        Me.tsActivities.BackColor = System.Drawing.Color.Transparent
        Me.tsActivities.Dock = System.Windows.Forms.DockStyle.None
        Me.tsActivities.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsActivities.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.tsActivities.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbActGuestSearch, Me.tss1, Me.tsbActGuestFolio, Me.ToolStripSeparator1, Me.tsbActGuestInfo, Me.tss6, Me.tsbActPayment, Me.tss7, Me.ToolStripButton1, Me.ToolStripSeparator2})
        Me.tsActivities.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsActivities.Location = New System.Drawing.Point(4, 78)
        Me.tsActivities.Name = "tsActivities"
        Me.tsActivities.ShowItemToolTips = False
        Me.tsActivities.Size = New System.Drawing.Size(113, 310)
        Me.tsActivities.TabIndex = 22
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
        'tss1
        '
        Me.tss1.Name = "tss1"
        Me.tss1.Size = New System.Drawing.Size(111, 6)
        '
        'tsbActGuestFolio
        '
        Me.tsbActGuestFolio.AutoSize = False
        Me.tsbActGuestFolio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsbActGuestFolio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbActGuestFolio.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbActGuestFolio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbActGuestFolio.Name = "tsbActGuestFolio"
        Me.tsbActGuestFolio.Size = New System.Drawing.Size(120, 30)
        Me.tsbActGuestFolio.Text = "Guest Folio"
        Me.tsbActGuestFolio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(111, 6)
        '
        'tsbActGuestInfo
        '
        Me.tsbActGuestInfo.AutoSize = False
        Me.tsbActGuestInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbActGuestInfo.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbActGuestInfo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbActGuestInfo.Name = "tsbActGuestInfo"
        Me.tsbActGuestInfo.Size = New System.Drawing.Size(120, 30)
        Me.tsbActGuestInfo.Text = "Guest Information"
        Me.tsbActGuestInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss6
        '
        Me.tss6.Name = "tss6"
        Me.tss6.Size = New System.Drawing.Size(111, 6)
        '
        'tsbActPayment
        '
        Me.tsbActPayment.AutoSize = False
        Me.tsbActPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbActPayment.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.tss7.Size = New System.Drawing.Size(111, 6)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(120, 30)
        Me.ToolStripButton1.Text = "Room Rack"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(111, 6)
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 53)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Update Room Charge"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(17, 42)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(138, 17)
        Me.RadioButton1.TabIndex = 247
        Me.RadioButton1.Text = "Use Current Room Rate"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(17, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(160, 17)
        Me.RadioButton2.TabIndex = 248
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Use Registration Room Rate"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'lvwRoomsToUpdate
        '
        Me.lvwRoomsToUpdate.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader10, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader1, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader21, Me.ColumnHeader22})
        Me.lvwRoomsToUpdate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwRoomsToUpdate.FullRowSelect = True
        Me.lvwRoomsToUpdate.GridLines = True
        Me.lvwRoomsToUpdate.Location = New System.Drawing.Point(141, 352)
        Me.lvwRoomsToUpdate.Name = "lvwRoomsToUpdate"
        Me.lvwRoomsToUpdate.Size = New System.Drawing.Size(841, 217)
        Me.lvwRoomsToUpdate.TabIndex = 17
        Me.lvwRoomsToUpdate.UseCompatibleStateImageBehavior = False
        Me.lvwRoomsToUpdate.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Room No"
        Me.ColumnHeader11.Width = 90
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Guest Name"
        Me.ColumnHeader10.Width = 99
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Amount To Charge"
        Me.ColumnHeader2.Width = 140
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Days To Update"
        Me.ColumnHeader3.Width = 135
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Room Type"
        Me.ColumnHeader12.Width = 111
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Registration Rate"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader13.Width = 123
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Current Room Rate"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader14.Width = 136
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Registration Date"
        Me.ColumnHeader15.Width = 127
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Extention In Days"
        Me.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader1.Width = 119
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "Check Out (Expected)"
        Me.ColumnHeader16.Width = 97
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "No of Days at Hotel"
        Me.ColumnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader17.Width = 88
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Days that are already charged"
        Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader18.Width = 109
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Registration No"
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "Accomodation No."
        '
        'dtpDateOfUpdate
        '
        Me.dtpDateOfUpdate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDateOfUpdate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateOfUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfUpdate.Location = New System.Drawing.Point(698, 298)
        Me.dtpDateOfUpdate.Name = "dtpDateOfUpdate"
        Me.dtpDateOfUpdate.Size = New System.Drawing.Size(155, 23)
        Me.dtpDateOfUpdate.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(597, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "&Date of update"
        '
        'btnRemove
        '
        Me.btnRemove.AutoSize = True
        Me.btnRemove.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(784, 578)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 28)
        Me.btnRemove.TabIndex = 20
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(786, 329)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Day(s)"
        '
        'txtNoOfDays
        '
        Me.txtNoOfDays.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfDays.Location = New System.Drawing.Point(698, 326)
        Me.txtNoOfDays.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtNoOfDays.Name = "txtNoOfDays"
        Me.txtNoOfDays.Size = New System.Drawing.Size(82, 23)
        Me.txtNoOfDays.TabIndex = 14
        Me.txtNoOfDays.ThousandsSeparator = True
        Me.txtNoOfDays.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'radUseCurrentRoomRate
        '
        Me.radUseCurrentRoomRate.AutoSize = True
        Me.radUseCurrentRoomRate.BackColor = System.Drawing.Color.Transparent
        Me.radUseCurrentRoomRate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radUseCurrentRoomRate.Location = New System.Drawing.Point(268, 324)
        Me.radUseCurrentRoomRate.Name = "radUseCurrentRoomRate"
        Me.radUseCurrentRoomRate.Size = New System.Drawing.Size(163, 22)
        Me.radUseCurrentRoomRate.TabIndex = 11
        Me.radUseCurrentRoomRate.Text = "Use &Current Room Rate"
        Me.radUseCurrentRoomRate.UseVisualStyleBackColor = False
        '
        'raduseRegistrationRoomRate
        '
        Me.raduseRegistrationRoomRate.AutoSize = True
        Me.raduseRegistrationRoomRate.BackColor = System.Drawing.Color.Transparent
        Me.raduseRegistrationRoomRate.Checked = True
        Me.raduseRegistrationRoomRate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.raduseRegistrationRoomRate.Location = New System.Drawing.Point(268, 298)
        Me.raduseRegistrationRoomRate.Name = "raduseRegistrationRoomRate"
        Me.raduseRegistrationRoomRate.Size = New System.Drawing.Size(191, 22)
        Me.raduseRegistrationRoomRate.TabIndex = 10
        Me.raduseRegistrationRoomRate.TabStop = True
        Me.raduseRegistrationRoomRate.Text = "Use &Registration Room Rate"
        Me.raduseRegistrationRoomRate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(865, 578)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 28)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "&Update && Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblCountToUpdate
        '
        Me.lblCountToUpdate.AutoSize = True
        Me.lblCountToUpdate.BackColor = System.Drawing.Color.Transparent
        Me.lblCountToUpdate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountToUpdate.Location = New System.Drawing.Point(186, 586)
        Me.lblCountToUpdate.Name = "lblCountToUpdate"
        Me.lblCountToUpdate.Size = New System.Drawing.Size(15, 18)
        Me.lblCountToUpdate.TabIndex = 19
        Me.lblCountToUpdate.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(142, 586)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Count:"
        '
        'btnSelect
        '
        Me.btnSelect.AutoSize = True
        Me.btnSelect.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(894, 300)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 28)
        Me.btnSelect.TabIndex = 16
        Me.btnSelect.Text = "&Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lblCountRegisteredRoom
        '
        Me.lblCountRegisteredRoom.AutoSize = True
        Me.lblCountRegisteredRoom.BackColor = System.Drawing.Color.Transparent
        Me.lblCountRegisteredRoom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountRegisteredRoom.Location = New System.Drawing.Point(185, 300)
        Me.lblCountRegisteredRoom.Name = "lblCountRegisteredRoom"
        Me.lblCountRegisteredRoom.Size = New System.Drawing.Size(15, 18)
        Me.lblCountRegisteredRoom.TabIndex = 9
        Me.lblCountRegisteredRoom.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(141, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Count:"
        '
        'dtpLastUpdate
        '
        Me.dtpLastUpdate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpLastUpdate.Enabled = False
        Me.dtpLastUpdate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLastUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLastUpdate.Location = New System.Drawing.Point(490, 28)
        Me.dtpLastUpdate.Name = "dtpLastUpdate"
        Me.dtpLastUpdate.Size = New System.Drawing.Size(158, 23)
        Me.dtpLastUpdate.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(364, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "&Not Updated Since:"
        '
        'chkDisplayAll
        '
        Me.chkDisplayAll.AutoSize = True
        Me.chkDisplayAll.BackColor = System.Drawing.Color.Transparent
        Me.chkDisplayAll.Checked = True
        Me.chkDisplayAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDisplayAll.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisplayAll.Location = New System.Drawing.Point(145, 29)
        Me.chkDisplayAll.Name = "chkDisplayAll"
        Me.chkDisplayAll.Size = New System.Drawing.Size(195, 22)
        Me.chkDisplayAll.TabIndex = 1
        Me.chkDisplayAll.Text = "Display &all Registered Rooms"
        Me.chkDisplayAll.UseVisualStyleBackColor = False
        '
        'lsvRegisteredRooms
        '
        Me.lsvRegisteredRooms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lsvRegisteredRooms.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvRegisteredRooms.FullRowSelect = True
        Me.lsvRegisteredRooms.GridLines = True
        Me.lsvRegisteredRooms.HideSelection = False
        Me.lsvRegisteredRooms.LargeImageList = Me.ImageList1
        Me.lsvRegisteredRooms.Location = New System.Drawing.Point(141, 57)
        Me.lsvRegisteredRooms.MultiSelect = False
        Me.lsvRegisteredRooms.Name = "lsvRegisteredRooms"
        Me.lsvRegisteredRooms.Size = New System.Drawing.Size(840, 235)
        Me.lsvRegisteredRooms.TabIndex = 7
        Me.lsvRegisteredRooms.UseCompatibleStateImageBehavior = False
        Me.lsvRegisteredRooms.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Room No"
        Me.ColumnHeader4.Width = 121
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Guest Name"
        Me.ColumnHeader5.Width = 261
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Charged Days"
        Me.ColumnHeader6.Width = 155
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Days Stayed In Hotel"
        Me.ColumnHeader7.Width = 157
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Accommodation No"
        Me.ColumnHeader8.Width = 139
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(50, 50)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'chkDetails
        '
        Me.chkDetails.AutoSize = True
        Me.chkDetails.BackColor = System.Drawing.Color.Transparent
        Me.chkDetails.Checked = True
        Me.chkDetails.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDetails.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDetails.Location = New System.Drawing.Point(664, 28)
        Me.chkDetails.Name = "chkDetails"
        Me.chkDetails.Size = New System.Drawing.Size(98, 22)
        Me.chkDetails.TabIndex = 6
        Me.chkDetails.Text = "&View Details"
        Me.chkDetails.UseVisualStyleBackColor = False
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
        Me.lblClose.TabIndex = 23
        Me.lblClose.TabStop = True
        Me.lblClose.Text = "Close"
        '
        'lblRegAmt
        '
        Me.lblRegAmt.BackColor = System.Drawing.Color.Transparent
        Me.lblRegAmt.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegAmt.Location = New System.Drawing.Point(465, 300)
        Me.lblRegAmt.Name = "lblRegAmt"
        Me.lblRegAmt.Size = New System.Drawing.Size(106, 18)
        Me.lblRegAmt.TabIndex = 24
        Me.lblRegAmt.Text = "0.00"
        Me.lblRegAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCurAmt
        '
        Me.lblCurAmt.BackColor = System.Drawing.Color.Transparent
        Me.lblCurAmt.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurAmt.Location = New System.Drawing.Point(465, 326)
        Me.lblCurAmt.Name = "lblCurAmt"
        Me.lblCurAmt.Size = New System.Drawing.Size(106, 18)
        Me.lblCurAmt.TabIndex = 25
        Me.lblCurAmt.Text = "0.00"
        Me.lblCurAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmUpdateRoomCharge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.lblCurAmt)
        Me.Controls.Add(Me.lblRegAmt)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.chkDetails)
        Me.Controls.Add(Me.tsActivities)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lvwRoomsToUpdate)
        Me.Controls.Add(Me.chkDisplayAll)
        Me.Controls.Add(Me.dtpDateOfUpdate)
        Me.Controls.Add(Me.lsvRegisteredRooms)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.dtpLastUpdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNoOfDays)
        Me.Controls.Add(Me.lblCountRegisteredRoom)
        Me.Controls.Add(Me.radUseCurrentRoomRate)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.raduseRegistrationRoomRate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblCountToUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 80)
        Me.Name = "frmUpdateRoomCharge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "0"
        Me.tsActivities.ResumeLayout(False)
        Me.tsActivities.PerformLayout()
        CType(Me.txtNoOfDays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsActivities As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbActGuestSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss1 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents tsbActGuestFolio As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbActGuestInfo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbActPayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents lsvRegisteredRooms As System.Windows.Forms.ListView
    Friend WithEvents dtpLastUpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkDisplayAll As System.Windows.Forms.CheckBox
    Friend WithEvents lblCountRegisteredRoom As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblCountToUpdate As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents radUseCurrentRoomRate As System.Windows.Forms.RadioButton
    Friend WithEvents raduseRegistrationRoomRate As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNoOfDays As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lvwRoomsToUpdate As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dtpDateOfUpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkDetails As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblClose As System.Windows.Forms.LinkLabel
    Friend WithEvents lblRegAmt As System.Windows.Forms.Label
    Friend WithEvents lblCurAmt As System.Windows.Forms.Label
End Class
