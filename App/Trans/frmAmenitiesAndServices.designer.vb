<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmenitiesAndServices
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
        Me.Label11 = New System.Windows.Forms.Label
        Me.tsActivities = New System.Windows.Forms.ToolStrip
        Me.tsbGuestSearch = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.lblGuest = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboDepartment = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboService = New System.Windows.Forms.ComboBox
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPersonnel = New System.Windows.Forms.TextBox
        Me.txtSlipNo = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.radRoom = New System.Windows.Forms.RadioButton
        Me.radRegistration = New System.Windows.Forms.RadioButton
        Me.gbxRegisteredRoom = New System.Windows.Forms.GroupBox
        Me.lblNumberOfRegisteredRooms = New System.Windows.Forms.Label
        Me.dgvRegisteredRoom = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpDateIncurred = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.lsvAmenitiesAndServices = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.cmsLsvAmenitiesAndServices = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tlsRemove = New System.Windows.Forms.ToolStripMenuItem
        Me.lblTotalBalance = New System.Windows.Forms.Label
        Me.lblSubTotal = New System.Windows.Forms.Label
        Me.lblNoOfAmenitiesAndServices = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblTotalPayments = New System.Windows.Forms.Label
        Me.lblTotalCharges = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblReq = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.tsActivities.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbxRegisteredRoom.SuspendLayout()
        CType(Me.dgvRegisteredRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.cmsLsvAmenitiesAndServices.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 57)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Amenities and Services"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tsActivities
        '
        Me.tsActivities.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tsActivities.AutoSize = False
        Me.tsActivities.BackColor = System.Drawing.Color.Transparent
        Me.tsActivities.Dock = System.Windows.Forms.DockStyle.None
        Me.tsActivities.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsActivities.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsActivities.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.tsActivities.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuestSearch, Me.ToolStripSeparator1, Me.ToolStripButton8, Me.ToolStripSeparator7, Me.ToolStripButton13, Me.ToolStripSeparator12, Me.ToolStripButton1, Me.ToolStripSeparator2})
        Me.tsActivities.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsActivities.Location = New System.Drawing.Point(3, 77)
        Me.tsActivities.Name = "tsActivities"
        Me.tsActivities.Size = New System.Drawing.Size(113, 315)
        Me.tsActivities.TabIndex = 22
        Me.tsActivities.Text = "ToolStrip2"
        '
        'tsbGuestSearch
        '
        Me.tsbGuestSearch.AutoSize = False
        Me.tsbGuestSearch.AutoToolTip = False
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
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(111, 6)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.AutoSize = False
        Me.ToolStripButton8.AutoToolTip = False
        Me.ToolStripButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(120, 30)
        Me.ToolStripButton8.Text = "Guest Folio"
        Me.ToolStripButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(111, 6)
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.AutoSize = False
        Me.ToolStripButton13.AutoToolTip = False
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.Size = New System.Drawing.Size(120, 30)
        Me.ToolStripButton13.Text = "Guest Information"
        Me.ToolStripButton13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(111, 6)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.AutoToolTip = False
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(120, 30)
        Me.ToolStripButton1.Text = "Billing"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(111, 6)
        '
        'lblGuest
        '
        Me.lblGuest.AutoEllipsis = True
        Me.lblGuest.BackColor = System.Drawing.Color.Transparent
        Me.lblGuest.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuest.Location = New System.Drawing.Point(238, 18)
        Me.lblGuest.Name = "lblGuest"
        Me.lblGuest.Size = New System.Drawing.Size(704, 24)
        Me.lblGuest.TabIndex = 2
        Me.lblGuest.Text = "<Code will generate text here>"
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(764, 172)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 28)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(455, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "&Department:"
        '
        'cboDepartment
        '
        Me.cboDepartment.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Location = New System.Drawing.Point(541, 42)
        Me.cboDepartment.MaxLength = 50
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(213, 26)
        Me.cboDepartment.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Guest Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(156, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 18)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "&Service:"
        '
        'cboService
        '
        Me.cboService.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboService.FormattingEnabled = True
        Me.cboService.Location = New System.Drawing.Point(217, 72)
        Me.cboService.MaxLength = 100
        Me.cboService.Name = "cboService"
        Me.cboService.Size = New System.Drawing.Size(214, 26)
        Me.cboService.TabIndex = 5
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(218, 103)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(214, 23)
        Me.txtAmount.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(156, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 18)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "&Amount:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(540, 102)
        Me.txtRemarks.MaxLength = 200
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(424, 26)
        Me.txtRemarks.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(455, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Personnel:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(455, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "&Remarks:"
        '
        'txtPersonnel
        '
        Me.txtPersonnel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersonnel.Location = New System.Drawing.Point(540, 73)
        Me.txtPersonnel.MaxLength = 50
        Me.txtPersonnel.Name = "txtPersonnel"
        Me.txtPersonnel.Size = New System.Drawing.Size(214, 23)
        Me.txtPersonnel.TabIndex = 7
        '
        'txtSlipNo
        '
        Me.txtSlipNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlipNo.Location = New System.Drawing.Point(217, 45)
        Me.txtSlipNo.MaxLength = 30
        Me.txtSlipNo.Name = "txtSlipNo"
        Me.txtSlipNo.Size = New System.Drawing.Size(214, 23)
        Me.txtSlipNo.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.radRoom)
        Me.GroupBox1.Controls.Add(Me.radRegistration)
        Me.GroupBox1.Controls.Add(Me.gbxRegisteredRoom)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(143, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(831, 204)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Charge To:"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(6, 184)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(412, 20)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Select a Room No. from where you will charge the amenity or service. "
        '
        'radRoom
        '
        Me.radRoom.AutoSize = True
        Me.radRoom.Location = New System.Drawing.Point(116, 19)
        Me.radRoom.Name = "radRoom"
        Me.radRoom.Size = New System.Drawing.Size(59, 22)
        Me.radRoom.TabIndex = 1
        Me.radRoom.Text = "R&oom"
        Me.radRoom.UseVisualStyleBackColor = True
        '
        'radRegistration
        '
        Me.radRegistration.AutoSize = True
        Me.radRegistration.Checked = True
        Me.radRegistration.Location = New System.Drawing.Point(14, 18)
        Me.radRegistration.Name = "radRegistration"
        Me.radRegistration.Size = New System.Drawing.Size(98, 22)
        Me.radRegistration.TabIndex = 0
        Me.radRegistration.TabStop = True
        Me.radRegistration.Text = "&Registration"
        Me.radRegistration.UseVisualStyleBackColor = True
        '
        'gbxRegisteredRoom
        '
        Me.gbxRegisteredRoom.Controls.Add(Me.lblNumberOfRegisteredRooms)
        Me.gbxRegisteredRoom.Controls.Add(Me.dgvRegisteredRoom)
        Me.gbxRegisteredRoom.Controls.Add(Me.Label3)
        Me.gbxRegisteredRoom.Enabled = False
        Me.gbxRegisteredRoom.Location = New System.Drawing.Point(9, 37)
        Me.gbxRegisteredRoom.Name = "gbxRegisteredRoom"
        Me.gbxRegisteredRoom.Size = New System.Drawing.Size(816, 133)
        Me.gbxRegisteredRoom.TabIndex = 2
        Me.gbxRegisteredRoom.TabStop = False
        Me.gbxRegisteredRoom.Text = "Registered Room"
        '
        'lblNumberOfRegisteredRooms
        '
        Me.lblNumberOfRegisteredRooms.AutoSize = True
        Me.lblNumberOfRegisteredRooms.BackColor = System.Drawing.Color.Transparent
        Me.lblNumberOfRegisteredRooms.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfRegisteredRooms.Location = New System.Drawing.Point(201, 106)
        Me.lblNumberOfRegisteredRooms.Name = "lblNumberOfRegisteredRooms"
        Me.lblNumberOfRegisteredRooms.Size = New System.Drawing.Size(15, 18)
        Me.lblNumberOfRegisteredRooms.TabIndex = 2
        Me.lblNumberOfRegisteredRooms.Text = "0"
        '
        'dgvRegisteredRoom
        '
        Me.dgvRegisteredRoom.AllowUserToAddRows = False
        Me.dgvRegisteredRoom.AllowUserToDeleteRows = False
        Me.dgvRegisteredRoom.AllowUserToOrderColumns = True
        Me.dgvRegisteredRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvRegisteredRoom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvRegisteredRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegisteredRoom.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvRegisteredRoom.Location = New System.Drawing.Point(3, 19)
        Me.dgvRegisteredRoom.MultiSelect = False
        Me.dgvRegisteredRoom.Name = "dgvRegisteredRoom"
        Me.dgvRegisteredRoom.ReadOnly = True
        Me.dgvRegisteredRoom.RowHeadersVisible = False
        Me.dgvRegisteredRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRegisteredRoom.Size = New System.Drawing.Size(810, 84)
        Me.dgvRegisteredRoom.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Number of Registered Room:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(156, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Slip &No.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(770, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "&Date Incurred:"
        '
        'dtpDateIncurred
        '
        Me.dtpDateIncurred.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDateIncurred.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateIncurred.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateIncurred.Location = New System.Drawing.Point(773, 64)
        Me.dtpDateIncurred.Name = "dtpDateIncurred"
        Me.dtpDateIncurred.Size = New System.Drawing.Size(153, 23)
        Me.dtpDateIncurred.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.lsvAmenitiesAndServices)
        Me.GroupBox2.Controls.Add(Me.lblTotalBalance)
        Me.GroupBox2.Controls.Add(Me.lblSubTotal)
        Me.GroupBox2.Controls.Add(Me.lblNoOfAmenitiesAndServices)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lblTotalPayments)
        Me.GroupBox2.Controls.Add(Me.lblTotalCharges)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(143, 345)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(832, 245)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional Amenities And Services"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(5, 222)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(172, 16)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "Right Click on an item to remove"
        '
        'lsvAmenitiesAndServices
        '
        Me.lsvAmenitiesAndServices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader8, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lsvAmenitiesAndServices.ContextMenuStrip = Me.cmsLsvAmenitiesAndServices
        Me.lsvAmenitiesAndServices.Dock = System.Windows.Forms.DockStyle.Top
        Me.lsvAmenitiesAndServices.FullRowSelect = True
        Me.lsvAmenitiesAndServices.GridLines = True
        Me.lsvAmenitiesAndServices.Location = New System.Drawing.Point(3, 19)
        Me.lsvAmenitiesAndServices.Name = "lsvAmenitiesAndServices"
        Me.lsvAmenitiesAndServices.Size = New System.Drawing.Size(826, 131)
        Me.lsvAmenitiesAndServices.TabIndex = 0
        Me.lsvAmenitiesAndServices.UseCompatibleStateImageBehavior = False
        Me.lsvAmenitiesAndServices.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Folio No."
        Me.ColumnHeader1.Width = 91
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Slip No."
        Me.ColumnHeader8.Width = 78
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Service"
        Me.ColumnHeader2.Width = 168
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Amount"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 112
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Charge To"
        Me.ColumnHeader4.Width = 137
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Department"
        Me.ColumnHeader5.Width = 151
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Personnel"
        Me.ColumnHeader6.Width = 130
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Remarks"
        Me.ColumnHeader7.Width = 187
        '
        'cmsLsvAmenitiesAndServices
        '
        Me.cmsLsvAmenitiesAndServices.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlsRemove})
        Me.cmsLsvAmenitiesAndServices.Name = "cmsLsvAmenitiesAndServices"
        Me.cmsLsvAmenitiesAndServices.Size = New System.Drawing.Size(172, 26)
        '
        'tlsRemove
        '
        Me.tlsRemove.Name = "tlsRemove"
        Me.tlsRemove.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.tlsRemove.Size = New System.Drawing.Size(171, 22)
        Me.tlsRemove.Text = "Remove"
        '
        'lblTotalBalance
        '
        Me.lblTotalBalance.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalBalance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBalance.Location = New System.Drawing.Point(692, 222)
        Me.lblTotalBalance.Name = "lblTotalBalance"
        Me.lblTotalBalance.Size = New System.Drawing.Size(123, 18)
        Me.lblTotalBalance.TabIndex = 10
        Me.lblTotalBalance.Text = "0"
        Me.lblTotalBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTotal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(674, 158)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(15, 18)
        Me.lblSubTotal.TabIndex = 4
        Me.lblSubTotal.Text = "0"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNoOfAmenitiesAndServices
        '
        Me.lblNoOfAmenitiesAndServices.AutoSize = True
        Me.lblNoOfAmenitiesAndServices.BackColor = System.Drawing.Color.Transparent
        Me.lblNoOfAmenitiesAndServices.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfAmenitiesAndServices.Location = New System.Drawing.Point(150, 154)
        Me.lblNoOfAmenitiesAndServices.Name = "lblNoOfAmenitiesAndServices"
        Me.lblNoOfAmenitiesAndServices.Size = New System.Drawing.Size(16, 16)
        Me.lblNoOfAmenitiesAndServices.TabIndex = 2
        Me.lblNoOfAmenitiesAndServices.Text = "0"
        Me.lblNoOfAmenitiesAndServices.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(592, 220)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 18)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Total Balance:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(592, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sub Total:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(592, 184)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 18)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Total Charges:"
        '
        'lblTotalPayments
        '
        Me.lblTotalPayments.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPayments.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayments.Location = New System.Drawing.Point(692, 204)
        Me.lblTotalPayments.Name = "lblTotalPayments"
        Me.lblTotalPayments.Size = New System.Drawing.Size(123, 18)
        Me.lblTotalPayments.TabIndex = 8
        Me.lblTotalPayments.Text = "0"
        Me.lblTotalPayments.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalCharges
        '
        Me.lblTotalCharges.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalCharges.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCharges.Location = New System.Drawing.Point(692, 186)
        Me.lblTotalCharges.Name = "lblTotalCharges"
        Me.lblTotalCharges.Size = New System.Drawing.Size(123, 18)
        Me.lblTotalCharges.TabIndex = 6
        Me.lblTotalCharges.Text = "0"
        Me.lblTotalCharges.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(592, 202)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 18)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Total Payments:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 18)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Service Newly Availed:"
        '
        'lblReq
        '
        Me.lblReq.AutoSize = True
        Me.lblReq.BackColor = System.Drawing.Color.Transparent
        Me.lblReq.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReq.ForeColor = System.Drawing.Color.Red
        Me.lblReq.Location = New System.Drawing.Point(148, 593)
        Me.lblReq.Name = "lblReq"
        Me.lblReq.Size = New System.Drawing.Size(173, 16)
        Me.lblReq.TabIndex = 21
        Me.lblReq.Text = "NOTE: Fields with * are required." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(145, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 19)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "*"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(145, 107)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(18, 19)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "*"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(441, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 19)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "*"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(945, 10)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(39, 18)
        Me.LinkLabel1.TabIndex = 23
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Close"
        '
        'frmAmenitiesAndServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblReq)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblGuest)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboDepartment)
        Me.Controls.Add(Me.txtPersonnel)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cboService)
        Me.Controls.Add(Me.txtSlipNo)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tsActivities)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dtpDateIncurred)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 80)
        Me.Name = "frmAmenitiesAndServices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SLU Hotel"
        Me.tsActivities.ResumeLayout(False)
        Me.tsActivities.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxRegisteredRoom.ResumeLayout(False)
        Me.gbxRegisteredRoom.PerformLayout()
        CType(Me.dgvRegisteredRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.cmsLsvAmenitiesAndServices.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tsActivities As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuestSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblGuest As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboService As System.Windows.Forms.ComboBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPersonnel As System.Windows.Forms.TextBox
    Friend WithEvents txtSlipNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbxRegisteredRoom As System.Windows.Forms.GroupBox
    Friend WithEvents dgvRegisteredRoom As System.Windows.Forms.DataGridView
    Friend WithEvents radRoom As System.Windows.Forms.RadioButton
    Friend WithEvents radRegistration As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpDateIncurred As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNumberOfRegisteredRooms As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalBalance As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPayments As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblTotalCharges As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblReq As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lsvAmenitiesAndServices As System.Windows.Forms.ListView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblNoOfAmenitiesAndServices As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmsLsvAmenitiesAndServices As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tlsRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
