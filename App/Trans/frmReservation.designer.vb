<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReservation
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
        Me.tsActivities = New System.Windows.Forms.ToolStrip
        Me.tsbGuestSearch = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbUpdateReservation = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbPayment = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator
        Me.lblTitle = New System.Windows.Forms.Label
        Me.tbcReservation = New System.Windows.Forms.TabControl
        Me.tbpGuestInformation = New System.Windows.Forms.TabPage
        Me.lblReq = New System.Windows.Forms.Label
        Me.grpGuestInformation = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtGuestInfoZipCode = New System.Windows.Forms.TextBox
        Me.dtpGuestInfoBirthDate = New System.Windows.Forms.DateTimePicker
        Me.cboGuestInfoGender = New System.Windows.Forms.ComboBox
        Me.lblReservationGIID = New System.Windows.Forms.Label
        Me.cboGuestInfoCivilStatus = New System.Windows.Forms.ComboBox
        Me.cboGuestInfoCountry = New System.Windows.Forms.ComboBox
        Me.txtGuestInfoCitezenship = New System.Windows.Forms.TextBox
        Me.txtGuestInfoTitle = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.txtGuestInfoNationality = New System.Windows.Forms.TextBox
        Me.txtGuestInfoFirstName = New System.Windows.Forms.TextBox
        Me.txtGuestInfoEmail = New System.Windows.Forms.TextBox
        Me.txtGuestInfoLastName = New System.Windows.Forms.TextBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.txtGuestInfoMiddleInitial = New System.Windows.Forms.TextBox
        Me.txtGuestInfoContactNo = New System.Windows.Forms.TextBox
        Me.txtGuestInfoAddress = New System.Windows.Forms.TextBox
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.grpCompanyGroupInformation = New System.Windows.Forms.GroupBox
        Me.dgvCompanyGroupInformation = New System.Windows.Forms.DataGridView
        Me.pnlCompanyGroupInformation = New System.Windows.Forms.Panel
        Me.txtCompanyInfoPosition = New System.Windows.Forms.TextBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCompanyInfoBranch = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCompanyInfoContactPerson = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCompanyInfoContactNo = New System.Windows.Forms.TextBox
        Me.txtCompanyInfoCompanyName = New System.Windows.Forms.TextBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.txtCompanyInfoAddress = New System.Windows.Forms.TextBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.lblReservationCID = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.radCompanyInfo = New System.Windows.Forms.RadioButton
        Me.radCompanyInfoPreviousCompany = New System.Windows.Forms.RadioButton
        Me.radCompanyInfoNew = New System.Windows.Forms.RadioButton
        Me.Label16 = New System.Windows.Forms.Label
        Me.btnGuestInfoClear = New System.Windows.Forms.Button
        Me.chkGuestInfoCompanyGroup = New System.Windows.Forms.CheckBox
        Me.tbpReservationInformation = New System.Windows.Forms.TabPage
        Me.Label9 = New System.Windows.Forms.Label
        Me.dgvGuestRooms = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.cboGuestType = New System.Windows.Forms.ComboBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.lblNumberOfOccupants = New System.Windows.Forms.Label
        Me.btnClear = New System.Windows.Forms.Button
        Me.lblDownPayment = New System.Windows.Forms.Label
        Me.lblNumberOfRooms = New System.Windows.Forms.Label
        Me.Label77 = New System.Windows.Forms.Label
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.gbxRoomReservationDetails = New System.Windows.Forms.GroupBox
        Me.lblNumberOfNights = New System.Windows.Forms.Label
        Me.txtNoOfOccupants = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblRoomRate = New System.Windows.Forms.Label
        Me.btnViewDetails = New System.Windows.Forms.Button
        Me.lblRoomNumber = New System.Windows.Forms.Label
        Me.btnAddRoom = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkRoomByRequest = New System.Windows.Forms.CheckBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.gbxRoomVacancySearch = New System.Windows.Forms.GroupBox
        Me.lblSearchResult = New System.Windows.Forms.Label
        Me.dtpCheckOutDate = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
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
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpCheckInDate = New System.Windows.Forms.DateTimePicker
        Me.lblResourceLocator = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.dtpDateOfReservation = New System.Windows.Forms.DateTimePicker
        Me.Label40 = New System.Windows.Forms.Label
        Me.lblTotalAmount = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.btnRemoveRoom = New System.Windows.Forms.Button
        Me.btnReservationSave = New System.Windows.Forms.Button
        Me.Label85 = New System.Windows.Forms.Label
        Me.lblNameOfGuest = New System.Windows.Forms.Label
        Me.lblReservationGNO = New System.Windows.Forms.Label
        Me.llbClose = New System.Windows.Forms.LinkLabel
        Me.tsActivities.SuspendLayout()
        Me.tbcReservation.SuspendLayout()
        Me.tbpGuestInformation.SuspendLayout()
        Me.grpGuestInformation.SuspendLayout()
        Me.grpCompanyGroupInformation.SuspendLayout()
        CType(Me.dgvCompanyGroupInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCompanyGroupInformation.SuspendLayout()
        Me.tbpReservationInformation.SuspendLayout()
        CType(Me.dgvGuestRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxRoomReservationDetails.SuspendLayout()
        Me.gbxRoomVacancySearch.SuspendLayout()
        CType(Me.dgvRoomVacancySearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsActivities
        '
        Me.tsActivities.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tsActivities.AutoSize = False
        Me.tsActivities.BackColor = System.Drawing.Color.Transparent
        Me.tsActivities.Dock = System.Windows.Forms.DockStyle.None
        Me.tsActivities.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsActivities.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.tsActivities.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuestSearch, Me.ToolStripSeparator1, Me.tsbUpdateReservation, Me.ToolStripSeparator8, Me.tsbPayment, Me.ToolStripSeparator12})
        Me.tsActivities.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsActivities.Location = New System.Drawing.Point(1, 76)
        Me.tsActivities.Name = "tsActivities"
        Me.tsActivities.Size = New System.Drawing.Size(113, 315)
        Me.tsActivities.TabIndex = 223
        Me.tsActivities.Text = "ToolStrip2"
        '
        'tsbGuestSearch
        '
        Me.tsbGuestSearch.AutoSize = False
        Me.tsbGuestSearch.AutoToolTip = False
        Me.tsbGuestSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGuestSearch.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbGuestSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuestSearch.Name = "tsbGuestSearch"
        Me.tsbGuestSearch.Size = New System.Drawing.Size(120, 30)
        Me.tsbGuestSearch.Text = "Guest Search"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(111, 6)
        '
        'tsbUpdateReservation
        '
        Me.tsbUpdateReservation.AutoSize = False
        Me.tsbUpdateReservation.AutoToolTip = False
        Me.tsbUpdateReservation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbUpdateReservation.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbUpdateReservation.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUpdateReservation.Name = "tsbUpdateReservation"
        Me.tsbUpdateReservation.Size = New System.Drawing.Size(120, 30)
        Me.tsbUpdateReservation.Text = "Update Reservation"
        Me.tsbUpdateReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(111, 6)
        '
        'tsbPayment
        '
        Me.tsbPayment.AutoSize = False
        Me.tsbPayment.AutoToolTip = False
        Me.tsbPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbPayment.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPayment.Name = "tsbPayment"
        Me.tsbPayment.Size = New System.Drawing.Size(120, 30)
        Me.tsbPayment.Text = "Billing"
        Me.tsbPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(111, 6)
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(1, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(118, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "New Reservation"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbcReservation
        '
        Me.tbcReservation.Controls.Add(Me.tbpGuestInformation)
        Me.tbcReservation.Controls.Add(Me.tbpReservationInformation)
        Me.tbcReservation.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcReservation.Location = New System.Drawing.Point(137, 39)
        Me.tbcReservation.Multiline = True
        Me.tbcReservation.Name = "tbcReservation"
        Me.tbcReservation.SelectedIndex = 0
        Me.tbcReservation.Size = New System.Drawing.Size(848, 546)
        Me.tbcReservation.TabIndex = 4
        '
        'tbpGuestInformation
        '
        Me.tbpGuestInformation.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbpGuestInformation.Controls.Add(Me.lblReq)
        Me.tbpGuestInformation.Controls.Add(Me.grpGuestInformation)
        Me.tbpGuestInformation.Controls.Add(Me.grpCompanyGroupInformation)
        Me.tbpGuestInformation.Controls.Add(Me.btnGuestInfoClear)
        Me.tbpGuestInformation.Controls.Add(Me.chkGuestInfoCompanyGroup)
        Me.tbpGuestInformation.Location = New System.Drawing.Point(4, 27)
        Me.tbpGuestInformation.Name = "tbpGuestInformation"
        Me.tbpGuestInformation.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpGuestInformation.Size = New System.Drawing.Size(840, 515)
        Me.tbpGuestInformation.TabIndex = 0
        Me.tbpGuestInformation.Text = "Guest Information"
        Me.tbpGuestInformation.UseVisualStyleBackColor = True
        '
        'lblReq
        '
        Me.lblReq.AutoSize = True
        Me.lblReq.BackColor = System.Drawing.Color.Transparent
        Me.lblReq.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReq.ForeColor = System.Drawing.Color.Red
        Me.lblReq.Location = New System.Drawing.Point(14, 492)
        Me.lblReq.Name = "lblReq"
        Me.lblReq.Size = New System.Drawing.Size(173, 16)
        Me.lblReq.TabIndex = 252
        Me.lblReq.Text = "NOTE: Fields with * are required."
        '
        'grpGuestInformation
        '
        Me.grpGuestInformation.BackColor = System.Drawing.Color.Transparent
        Me.grpGuestInformation.Controls.Add(Me.Label2)
        Me.grpGuestInformation.Controls.Add(Me.txtGuestInfoZipCode)
        Me.grpGuestInformation.Controls.Add(Me.dtpGuestInfoBirthDate)
        Me.grpGuestInformation.Controls.Add(Me.cboGuestInfoGender)
        Me.grpGuestInformation.Controls.Add(Me.lblReservationGIID)
        Me.grpGuestInformation.Controls.Add(Me.cboGuestInfoCivilStatus)
        Me.grpGuestInformation.Controls.Add(Me.cboGuestInfoCountry)
        Me.grpGuestInformation.Controls.Add(Me.txtGuestInfoCitezenship)
        Me.grpGuestInformation.Controls.Add(Me.txtGuestInfoTitle)
        Me.grpGuestInformation.Controls.Add(Me.Label56)
        Me.grpGuestInformation.Controls.Add(Me.txtGuestInfoNationality)
        Me.grpGuestInformation.Controls.Add(Me.txtGuestInfoFirstName)
        Me.grpGuestInformation.Controls.Add(Me.txtGuestInfoEmail)
        Me.grpGuestInformation.Controls.Add(Me.txtGuestInfoLastName)
        Me.grpGuestInformation.Controls.Add(Me.Label43)
        Me.grpGuestInformation.Controls.Add(Me.txtGuestInfoMiddleInitial)
        Me.grpGuestInformation.Controls.Add(Me.txtGuestInfoContactNo)
        Me.grpGuestInformation.Controls.Add(Me.txtGuestInfoAddress)
        Me.grpGuestInformation.Controls.Add(Me.Label57)
        Me.grpGuestInformation.Controls.Add(Me.Label55)
        Me.grpGuestInformation.Controls.Add(Me.Label54)
        Me.grpGuestInformation.Controls.Add(Me.Label44)
        Me.grpGuestInformation.Controls.Add(Me.Label53)
        Me.grpGuestInformation.Controls.Add(Me.Label46)
        Me.grpGuestInformation.Controls.Add(Me.Label51)
        Me.grpGuestInformation.Controls.Add(Me.Label50)
        Me.grpGuestInformation.Controls.Add(Me.Label48)
        Me.grpGuestInformation.Controls.Add(Me.Label49)
        Me.grpGuestInformation.Controls.Add(Me.Label11)
        Me.grpGuestInformation.Controls.Add(Me.Label17)
        Me.grpGuestInformation.Controls.Add(Me.Label47)
        Me.grpGuestInformation.Location = New System.Drawing.Point(17, 19)
        Me.grpGuestInformation.Name = "grpGuestInformation"
        Me.grpGuestInformation.Size = New System.Drawing.Size(419, 441)
        Me.grpGuestInformation.TabIndex = 0
        Me.grpGuestInformation.TabStop = False
        Me.grpGuestInformation.Text = "Guest Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "&Address:"
        '
        'txtGuestInfoZipCode
        '
        Me.txtGuestInfoZipCode.BackColor = System.Drawing.Color.White
        Me.txtGuestInfoZipCode.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestInfoZipCode.Location = New System.Drawing.Point(344, 183)
        Me.txtGuestInfoZipCode.MaxLength = 10
        Me.txtGuestInfoZipCode.Name = "txtGuestInfoZipCode"
        Me.txtGuestInfoZipCode.Size = New System.Drawing.Size(64, 23)
        Me.txtGuestInfoZipCode.TabIndex = 16
        '
        'dtpGuestInfoBirthDate
        '
        Me.dtpGuestInfoBirthDate.Checked = False
        Me.dtpGuestInfoBirthDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpGuestInfoBirthDate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpGuestInfoBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpGuestInfoBirthDate.Location = New System.Drawing.Point(112, 150)
        Me.dtpGuestInfoBirthDate.Name = "dtpGuestInfoBirthDate"
        Me.dtpGuestInfoBirthDate.ShowCheckBox = True
        Me.dtpGuestInfoBirthDate.Size = New System.Drawing.Size(189, 23)
        Me.dtpGuestInfoBirthDate.TabIndex = 12
        '
        'cboGuestInfoGender
        '
        Me.cboGuestInfoGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboGuestInfoGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboGuestInfoGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGuestInfoGender.FormattingEnabled = True
        Me.cboGuestInfoGender.Items.AddRange(New Object() {"", "MALE", "FEMALE"})
        Me.cboGuestInfoGender.Location = New System.Drawing.Point(280, 117)
        Me.cboGuestInfoGender.Name = "cboGuestInfoGender"
        Me.cboGuestInfoGender.Size = New System.Drawing.Size(97, 26)
        Me.cboGuestInfoGender.TabIndex = 10
        '
        'lblReservationGIID
        '
        Me.lblReservationGIID.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblReservationGIID.AutoSize = True
        Me.lblReservationGIID.BackColor = System.Drawing.Color.Transparent
        Me.lblReservationGIID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservationGIID.Location = New System.Drawing.Point(384, 396)
        Me.lblReservationGIID.Name = "lblReservationGIID"
        Me.lblReservationGIID.Size = New System.Drawing.Size(27, 13)
        Me.lblReservationGIID.TabIndex = 30
        Me.lblReservationGIID.Tag = "new"
        Me.lblReservationGIID.Text = "new"
        Me.lblReservationGIID.Visible = False
        '
        'cboGuestInfoCivilStatus
        '
        Me.cboGuestInfoCivilStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboGuestInfoCivilStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboGuestInfoCivilStatus.BackColor = System.Drawing.SystemColors.Window
        Me.cboGuestInfoCivilStatus.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGuestInfoCivilStatus.FormattingEnabled = True
        Me.cboGuestInfoCivilStatus.Location = New System.Drawing.Point(112, 319)
        Me.cboGuestInfoCivilStatus.MaxLength = 30
        Me.cboGuestInfoCivilStatus.Name = "cboGuestInfoCivilStatus"
        Me.cboGuestInfoCivilStatus.Size = New System.Drawing.Size(187, 26)
        Me.cboGuestInfoCivilStatus.TabIndex = 25
        '
        'cboGuestInfoCountry
        '
        Me.cboGuestInfoCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboGuestInfoCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboGuestInfoCountry.BackColor = System.Drawing.SystemColors.Window
        Me.cboGuestInfoCountry.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGuestInfoCountry.FormattingEnabled = True
        Me.cboGuestInfoCountry.Location = New System.Drawing.Point(112, 183)
        Me.cboGuestInfoCountry.MaxLength = 50
        Me.cboGuestInfoCountry.Name = "cboGuestInfoCountry"
        Me.cboGuestInfoCountry.Size = New System.Drawing.Size(154, 26)
        Me.cboGuestInfoCountry.TabIndex = 14
        '
        'txtGuestInfoCitezenship
        '
        Me.txtGuestInfoCitezenship.BackColor = System.Drawing.Color.White
        Me.txtGuestInfoCitezenship.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestInfoCitezenship.Location = New System.Drawing.Point(112, 389)
        Me.txtGuestInfoCitezenship.MaxLength = 30
        Me.txtGuestInfoCitezenship.Name = "txtGuestInfoCitezenship"
        Me.txtGuestInfoCitezenship.Size = New System.Drawing.Size(189, 23)
        Me.txtGuestInfoCitezenship.TabIndex = 29
        '
        'txtGuestInfoTitle
        '
        Me.txtGuestInfoTitle.BackColor = System.Drawing.Color.White
        Me.txtGuestInfoTitle.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestInfoTitle.Location = New System.Drawing.Point(112, 18)
        Me.txtGuestInfoTitle.MaxLength = 10
        Me.txtGuestInfoTitle.Name = "txtGuestInfoTitle"
        Me.txtGuestInfoTitle.Size = New System.Drawing.Size(114, 23)
        Me.txtGuestInfoTitle.TabIndex = 1
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(216, 117)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(58, 18)
        Me.Label56.TabIndex = 9
        Me.Label56.Text = "&Gender:"
        '
        'txtGuestInfoNationality
        '
        Me.txtGuestInfoNationality.BackColor = System.Drawing.Color.White
        Me.txtGuestInfoNationality.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestInfoNationality.Location = New System.Drawing.Point(112, 356)
        Me.txtGuestInfoNationality.MaxLength = 30
        Me.txtGuestInfoNationality.Name = "txtGuestInfoNationality"
        Me.txtGuestInfoNationality.Size = New System.Drawing.Size(189, 23)
        Me.txtGuestInfoNationality.TabIndex = 27
        '
        'txtGuestInfoFirstName
        '
        Me.txtGuestInfoFirstName.BackColor = System.Drawing.Color.White
        Me.txtGuestInfoFirstName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestInfoFirstName.Location = New System.Drawing.Point(112, 51)
        Me.txtGuestInfoFirstName.MaxLength = 50
        Me.txtGuestInfoFirstName.Name = "txtGuestInfoFirstName"
        Me.txtGuestInfoFirstName.Size = New System.Drawing.Size(301, 23)
        Me.txtGuestInfoFirstName.TabIndex = 4
        '
        'txtGuestInfoEmail
        '
        Me.txtGuestInfoEmail.BackColor = System.Drawing.Color.White
        Me.txtGuestInfoEmail.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestInfoEmail.Location = New System.Drawing.Point(112, 286)
        Me.txtGuestInfoEmail.MaxLength = 50
        Me.txtGuestInfoEmail.Name = "txtGuestInfoEmail"
        Me.txtGuestInfoEmail.Size = New System.Drawing.Size(187, 23)
        Me.txtGuestInfoEmail.TabIndex = 23
        '
        'txtGuestInfoLastName
        '
        Me.txtGuestInfoLastName.BackColor = System.Drawing.Color.White
        Me.txtGuestInfoLastName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestInfoLastName.Location = New System.Drawing.Point(112, 84)
        Me.txtGuestInfoLastName.MaxLength = 50
        Me.txtGuestInfoLastName.Name = "txtGuestInfoLastName"
        Me.txtGuestInfoLastName.Size = New System.Drawing.Size(301, 23)
        Me.txtGuestInfoLastName.TabIndex = 6
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(272, 183)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(66, 18)
        Me.Label43.TabIndex = 15
        Me.Label43.Text = "&Zip Code:"
        '
        'txtGuestInfoMiddleInitial
        '
        Me.txtGuestInfoMiddleInitial.BackColor = System.Drawing.Color.White
        Me.txtGuestInfoMiddleInitial.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestInfoMiddleInitial.Location = New System.Drawing.Point(112, 117)
        Me.txtGuestInfoMiddleInitial.MaxLength = 50
        Me.txtGuestInfoMiddleInitial.Name = "txtGuestInfoMiddleInitial"
        Me.txtGuestInfoMiddleInitial.Size = New System.Drawing.Size(81, 23)
        Me.txtGuestInfoMiddleInitial.TabIndex = 8
        '
        'txtGuestInfoContactNo
        '
        Me.txtGuestInfoContactNo.BackColor = System.Drawing.Color.White
        Me.txtGuestInfoContactNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestInfoContactNo.Location = New System.Drawing.Point(112, 253)
        Me.txtGuestInfoContactNo.MaxLength = 30
        Me.txtGuestInfoContactNo.Name = "txtGuestInfoContactNo"
        Me.txtGuestInfoContactNo.Size = New System.Drawing.Size(187, 23)
        Me.txtGuestInfoContactNo.TabIndex = 21
        '
        'txtGuestInfoAddress
        '
        Me.txtGuestInfoAddress.BackColor = System.Drawing.Color.White
        Me.txtGuestInfoAddress.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestInfoAddress.Location = New System.Drawing.Point(112, 220)
        Me.txtGuestInfoAddress.MaxLength = 100
        Me.txtGuestInfoAddress.Name = "txtGuestInfoAddress"
        Me.txtGuestInfoAddress.Size = New System.Drawing.Size(296, 23)
        Me.txtGuestInfoAddress.TabIndex = 19
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.BackColor = System.Drawing.Color.Transparent
        Me.Label57.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(16, 84)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(76, 18)
        Me.Label57.TabIndex = 5
        Me.Label57.Text = "&Last Name:"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(16, 389)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(82, 18)
        Me.Label55.TabIndex = 28
        Me.Label55.Text = "C&itizenship:"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(16, 356)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(80, 18)
        Me.Label54.TabIndex = 26
        Me.Label54.Text = "&Nationality:"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(16, 183)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(62, 18)
        Me.Label44.TabIndex = 13
        Me.Label44.Text = "&Country:"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(16, 253)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(80, 18)
        Me.Label53.TabIndex = 20
        Me.Label53.Tag = " "
        Me.Label53.Text = "Contact &No:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(16, 117)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(94, 18)
        Me.Label46.TabIndex = 7
        Me.Label46.Text = "&Middle Initial:"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(16, 150)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(75, 18)
        Me.Label51.TabIndex = 11
        Me.Label51.Text = "&Birth Date:"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Black
        Me.Label50.Location = New System.Drawing.Point(16, 319)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(82, 18)
        Me.Label50.TabIndex = 24
        Me.Label50.Text = "Civil &Status:"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(16, 18)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(41, 18)
        Me.Label48.TabIndex = 0
        Me.Label48.Text = "&Title:"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(16, 286)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(46, 18)
        Me.Label49.TabIndex = 22
        Me.Label49.Tag = " "
        Me.Label49.Text = "&Email:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(2, 220)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 24)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(2, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 24)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "*"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(16, 51)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(80, 18)
        Me.Label47.TabIndex = 3
        Me.Label47.Text = "&First Name:"
        '
        'grpCompanyGroupInformation
        '
        Me.grpCompanyGroupInformation.BackColor = System.Drawing.Color.Transparent
        Me.grpCompanyGroupInformation.Controls.Add(Me.dgvCompanyGroupInformation)
        Me.grpCompanyGroupInformation.Controls.Add(Me.pnlCompanyGroupInformation)
        Me.grpCompanyGroupInformation.Controls.Add(Me.radCompanyInfo)
        Me.grpCompanyGroupInformation.Controls.Add(Me.radCompanyInfoPreviousCompany)
        Me.grpCompanyGroupInformation.Controls.Add(Me.radCompanyInfoNew)
        Me.grpCompanyGroupInformation.Controls.Add(Me.Label16)
        Me.grpCompanyGroupInformation.Enabled = False
        Me.grpCompanyGroupInformation.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCompanyGroupInformation.Location = New System.Drawing.Point(442, 19)
        Me.grpCompanyGroupInformation.Name = "grpCompanyGroupInformation"
        Me.grpCompanyGroupInformation.Size = New System.Drawing.Size(392, 441)
        Me.grpCompanyGroupInformation.TabIndex = 2
        Me.grpCompanyGroupInformation.TabStop = False
        Me.grpCompanyGroupInformation.Text = "Company/Group Information"
        '
        'dgvCompanyGroupInformation
        '
        Me.dgvCompanyGroupInformation.AllowUserToAddRows = False
        Me.dgvCompanyGroupInformation.AllowUserToDeleteRows = False
        Me.dgvCompanyGroupInformation.AllowUserToOrderColumns = True
        Me.dgvCompanyGroupInformation.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvCompanyGroupInformation.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCompanyGroupInformation.BackgroundColor = System.Drawing.Color.White
        Me.dgvCompanyGroupInformation.Location = New System.Drawing.Point(6, 49)
        Me.dgvCompanyGroupInformation.MultiSelect = False
        Me.dgvCompanyGroupInformation.Name = "dgvCompanyGroupInformation"
        Me.dgvCompanyGroupInformation.ReadOnly = True
        Me.dgvCompanyGroupInformation.RowHeadersVisible = False
        Me.dgvCompanyGroupInformation.RowHeadersWidth = 25
        Me.dgvCompanyGroupInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompanyGroupInformation.Size = New System.Drawing.Size(380, 179)
        Me.dgvCompanyGroupInformation.TabIndex = 3
        '
        'pnlCompanyGroupInformation
        '
        Me.pnlCompanyGroupInformation.Controls.Add(Me.txtCompanyInfoPosition)
        Me.pnlCompanyGroupInformation.Controls.Add(Me.Label60)
        Me.pnlCompanyGroupInformation.Controls.Add(Me.Label3)
        Me.pnlCompanyGroupInformation.Controls.Add(Me.txtCompanyInfoBranch)
        Me.pnlCompanyGroupInformation.Controls.Add(Me.Label4)
        Me.pnlCompanyGroupInformation.Controls.Add(Me.txtCompanyInfoContactPerson)
        Me.pnlCompanyGroupInformation.Controls.Add(Me.Label6)
        Me.pnlCompanyGroupInformation.Controls.Add(Me.txtCompanyInfoContactNo)
        Me.pnlCompanyGroupInformation.Controls.Add(Me.txtCompanyInfoCompanyName)
        Me.pnlCompanyGroupInformation.Controls.Add(Me.Label62)
        Me.pnlCompanyGroupInformation.Controls.Add(Me.txtCompanyInfoAddress)
        Me.pnlCompanyGroupInformation.Controls.Add(Me.Label58)
        Me.pnlCompanyGroupInformation.Controls.Add(Me.lblReservationCID)
        Me.pnlCompanyGroupInformation.Controls.Add(Me.Label21)
        Me.pnlCompanyGroupInformation.Controls.Add(Me.Label22)
        Me.pnlCompanyGroupInformation.Controls.Add(Me.Label24)
        Me.pnlCompanyGroupInformation.Location = New System.Drawing.Point(6, 251)
        Me.pnlCompanyGroupInformation.Name = "pnlCompanyGroupInformation"
        Me.pnlCompanyGroupInformation.Size = New System.Drawing.Size(380, 184)
        Me.pnlCompanyGroupInformation.TabIndex = 0
        Me.pnlCompanyGroupInformation.Tag = "Enabled"
        '
        'txtCompanyInfoPosition
        '
        Me.txtCompanyInfoPosition.BackColor = System.Drawing.Color.White
        Me.txtCompanyInfoPosition.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyInfoPosition.Location = New System.Drawing.Point(132, 95)
        Me.txtCompanyInfoPosition.MaxLength = 30
        Me.txtCompanyInfoPosition.Name = "txtCompanyInfoPosition"
        Me.txtCompanyInfoPosition.Size = New System.Drawing.Size(244, 23)
        Me.txtCompanyInfoPosition.TabIndex = 10
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.Location = New System.Drawing.Point(13, 70)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(88, 16)
        Me.Label60.TabIndex = 7
        Me.Label60.Tag = " "
        Me.Label60.Text = "Contact &No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Tag = " "
        Me.Label3.Text = "&Position:"
        '
        'txtCompanyInfoBranch
        '
        Me.txtCompanyInfoBranch.BackColor = System.Drawing.Color.White
        Me.txtCompanyInfoBranch.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyInfoBranch.Location = New System.Drawing.Point(132, 148)
        Me.txtCompanyInfoBranch.MaxLength = 50
        Me.txtCompanyInfoBranch.Name = "txtCompanyInfoBranch"
        Me.txtCompanyInfoBranch.Size = New System.Drawing.Size(244, 23)
        Me.txtCompanyInfoBranch.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Tag = " "
        Me.Label4.Text = "&Branch:"
        '
        'txtCompanyInfoContactPerson
        '
        Me.txtCompanyInfoContactPerson.BackColor = System.Drawing.Color.White
        Me.txtCompanyInfoContactPerson.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyInfoContactPerson.Location = New System.Drawing.Point(132, 44)
        Me.txtCompanyInfoContactPerson.MaxLength = 50
        Me.txtCompanyInfoContactPerson.Name = "txtCompanyInfoContactPerson"
        Me.txtCompanyInfoContactPerson.Size = New System.Drawing.Size(244, 23)
        Me.txtCompanyInfoContactPerson.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(13, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Tag = " "
        Me.Label6.Text = "Contact &Person:"
        '
        'txtCompanyInfoContactNo
        '
        Me.txtCompanyInfoContactNo.BackColor = System.Drawing.Color.White
        Me.txtCompanyInfoContactNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyInfoContactNo.Location = New System.Drawing.Point(132, 70)
        Me.txtCompanyInfoContactNo.MaxLength = 30
        Me.txtCompanyInfoContactNo.Name = "txtCompanyInfoContactNo"
        Me.txtCompanyInfoContactNo.Size = New System.Drawing.Size(244, 23)
        Me.txtCompanyInfoContactNo.TabIndex = 8
        '
        'txtCompanyInfoCompanyName
        '
        Me.txtCompanyInfoCompanyName.BackColor = System.Drawing.Color.White
        Me.txtCompanyInfoCompanyName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyInfoCompanyName.Location = New System.Drawing.Point(132, 18)
        Me.txtCompanyInfoCompanyName.MaxLength = 50
        Me.txtCompanyInfoCompanyName.Name = "txtCompanyInfoCompanyName"
        Me.txtCompanyInfoCompanyName.Size = New System.Drawing.Size(244, 23)
        Me.txtCompanyInfoCompanyName.TabIndex = 2
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.Black
        Me.Label62.Location = New System.Drawing.Point(13, 18)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(122, 16)
        Me.Label62.TabIndex = 1
        Me.Label62.Text = "Company &Name:"
        '
        'txtCompanyInfoAddress
        '
        Me.txtCompanyInfoAddress.BackColor = System.Drawing.Color.White
        Me.txtCompanyInfoAddress.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyInfoAddress.Location = New System.Drawing.Point(132, 122)
        Me.txtCompanyInfoAddress.MaxLength = 100
        Me.txtCompanyInfoAddress.Name = "txtCompanyInfoAddress"
        Me.txtCompanyInfoAddress.Size = New System.Drawing.Size(244, 23)
        Me.txtCompanyInfoAddress.TabIndex = 12
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Black
        Me.Label58.Location = New System.Drawing.Point(13, 122)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(70, 16)
        Me.Label58.TabIndex = 11
        Me.Label58.Text = "&Address:"
        '
        'lblReservationCID
        '
        Me.lblReservationCID.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lblReservationCID.AutoSize = True
        Me.lblReservationCID.BackColor = System.Drawing.Color.Transparent
        Me.lblReservationCID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservationCID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblReservationCID.Location = New System.Drawing.Point(332, 152)
        Me.lblReservationCID.Name = "lblReservationCID"
        Me.lblReservationCID.Size = New System.Drawing.Size(27, 13)
        Me.lblReservationCID.TabIndex = 15
        Me.lblReservationCID.Tag = "none"
        Me.lblReservationCID.Text = "new"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(2, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(18, 24)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "*"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(2, 44)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(18, 24)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "*"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(2, 71)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(18, 24)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "*"
        '
        'radCompanyInfo
        '
        Me.radCompanyInfo.AutoSize = True
        Me.radCompanyInfo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCompanyInfo.Location = New System.Drawing.Point(240, 23)
        Me.radCompanyInfo.Name = "radCompanyInfo"
        Me.radCompanyInfo.Size = New System.Drawing.Size(139, 22)
        Me.radCompanyInfo.TabIndex = 2
        Me.radCompanyInfo.Text = "&All Company/Group"
        Me.radCompanyInfo.UseVisualStyleBackColor = True
        '
        'radCompanyInfoPreviousCompany
        '
        Me.radCompanyInfoPreviousCompany.AutoSize = True
        Me.radCompanyInfoPreviousCompany.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCompanyInfoPreviousCompany.Location = New System.Drawing.Point(59, 23)
        Me.radCompanyInfoPreviousCompany.Name = "radCompanyInfoPreviousCompany"
        Me.radCompanyInfoPreviousCompany.Size = New System.Drawing.Size(175, 22)
        Me.radCompanyInfoPreviousCompany.TabIndex = 1
        Me.radCompanyInfoPreviousCompany.Text = "&Previous Company/Group"
        Me.radCompanyInfoPreviousCompany.UseVisualStyleBackColor = True
        '
        'radCompanyInfoNew
        '
        Me.radCompanyInfoNew.AutoSize = True
        Me.radCompanyInfoNew.Checked = True
        Me.radCompanyInfoNew.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCompanyInfoNew.Location = New System.Drawing.Point(6, 23)
        Me.radCompanyInfoNew.Name = "radCompanyInfoNew"
        Me.radCompanyInfoNew.Size = New System.Drawing.Size(50, 22)
        Me.radCompanyInfoNew.TabIndex = 0
        Me.radCompanyInfoNew.TabStop = True
        Me.radCompanyInfoNew.Text = "&New"
        Me.radCompanyInfoNew.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(3, 231)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(285, 16)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Click an item to define its company/group Information."
        '
        'btnGuestInfoClear
        '
        Me.btnGuestInfoClear.Location = New System.Drawing.Point(774, 480)
        Me.btnGuestInfoClear.Name = "btnGuestInfoClear"
        Me.btnGuestInfoClear.Size = New System.Drawing.Size(60, 28)
        Me.btnGuestInfoClear.TabIndex = 3
        Me.btnGuestInfoClear.Text = "&Clear"
        Me.btnGuestInfoClear.UseVisualStyleBackColor = True
        '
        'chkGuestInfoCompanyGroup
        '
        Me.chkGuestInfoCompanyGroup.AutoSize = True
        Me.chkGuestInfoCompanyGroup.BackColor = System.Drawing.Color.Transparent
        Me.chkGuestInfoCompanyGroup.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGuestInfoCompanyGroup.Location = New System.Drawing.Point(452, 1)
        Me.chkGuestInfoCompanyGroup.Name = "chkGuestInfoCompanyGroup"
        Me.chkGuestInfoCompanyGroup.Size = New System.Drawing.Size(122, 22)
        Me.chkGuestInfoCompanyGroup.TabIndex = 1
        Me.chkGuestInfoCompanyGroup.Text = "Compan&y/Group"
        Me.chkGuestInfoCompanyGroup.UseVisualStyleBackColor = False
        '
        'tbpReservationInformation
        '
        Me.tbpReservationInformation.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tbpReservationInformation.Controls.Add(Me.Label9)
        Me.tbpReservationInformation.Controls.Add(Me.dgvGuestRooms)
        Me.tbpReservationInformation.Controls.Add(Me.cboGuestType)
        Me.tbpReservationInformation.Controls.Add(Me.Label52)
        Me.tbpReservationInformation.Controls.Add(Me.lblNumberOfOccupants)
        Me.tbpReservationInformation.Controls.Add(Me.btnClear)
        Me.tbpReservationInformation.Controls.Add(Me.lblDownPayment)
        Me.tbpReservationInformation.Controls.Add(Me.lblNumberOfRooms)
        Me.tbpReservationInformation.Controls.Add(Me.Label77)
        Me.tbpReservationInformation.Controls.Add(Me.txtRemarks)
        Me.tbpReservationInformation.Controls.Add(Me.Label8)
        Me.tbpReservationInformation.Controls.Add(Me.gbxRoomReservationDetails)
        Me.tbpReservationInformation.Controls.Add(Me.gbxRoomVacancySearch)
        Me.tbpReservationInformation.Controls.Add(Me.lblResourceLocator)
        Me.tbpReservationInformation.Controls.Add(Me.Label41)
        Me.tbpReservationInformation.Controls.Add(Me.dtpDateOfReservation)
        Me.tbpReservationInformation.Controls.Add(Me.Label40)
        Me.tbpReservationInformation.Controls.Add(Me.lblTotalAmount)
        Me.tbpReservationInformation.Controls.Add(Me.Label12)
        Me.tbpReservationInformation.Controls.Add(Me.Label34)
        Me.tbpReservationInformation.Controls.Add(Me.Label37)
        Me.tbpReservationInformation.Controls.Add(Me.btnRemoveRoom)
        Me.tbpReservationInformation.Location = New System.Drawing.Point(4, 27)
        Me.tbpReservationInformation.Name = "tbpReservationInformation"
        Me.tbpReservationInformation.Size = New System.Drawing.Size(840, 515)
        Me.tbpReservationInformation.TabIndex = 3
        Me.tbpReservationInformation.Text = "Reservation Information"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(419, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Reserved Rooms:"
        '
        'dgvGuestRooms
        '
        Me.dgvGuestRooms.AllowUserToAddRows = False
        Me.dgvGuestRooms.AllowUserToDeleteRows = False
        Me.dgvGuestRooms.AllowUserToOrderColumns = True
        Me.dgvGuestRooms.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvGuestRooms.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGuestRooms.BackgroundColor = System.Drawing.Color.White
        Me.dgvGuestRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvGuestRooms.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvGuestRooms.Location = New System.Drawing.Point(417, 75)
        Me.dgvGuestRooms.MultiSelect = False
        Me.dgvGuestRooms.Name = "dgvGuestRooms"
        Me.dgvGuestRooms.ReadOnly = True
        Me.dgvGuestRooms.RowHeadersVisible = False
        Me.dgvGuestRooms.RowHeadersWidth = 25
        Me.dgvGuestRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGuestRooms.Size = New System.Drawing.Size(419, 221)
        Me.dgvGuestRooms.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "Room No."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "Room Rate"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Room Type"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "No. of Occupants"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "No. of Nights"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Check In Date and Time"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Check Out Date and Time"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Room by Request"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'cboGuestType
        '
        Me.cboGuestType.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGuestType.FormattingEnabled = True
        Me.cboGuestType.Items.AddRange(New Object() {""})
        Me.cboGuestType.Location = New System.Drawing.Point(505, 304)
        Me.cboGuestType.Name = "cboGuestType"
        Me.cboGuestType.Size = New System.Drawing.Size(114, 26)
        Me.cboGuestType.TabIndex = 9
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(417, 305)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(82, 18)
        Me.Label52.TabIndex = 8
        Me.Label52.Text = "Guest &Type:"
        '
        'lblNumberOfOccupants
        '
        Me.lblNumberOfOccupants.AutoSize = True
        Me.lblNumberOfOccupants.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfOccupants.Location = New System.Drawing.Point(528, 333)
        Me.lblNumberOfOccupants.Name = "lblNumberOfOccupants"
        Me.lblNumberOfOccupants.Size = New System.Drawing.Size(15, 18)
        Me.lblNumberOfOccupants.TabIndex = 12
        Me.lblNumberOfOccupants.Text = "0"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(772, 480)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 28)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblDownPayment
        '
        Me.lblDownPayment.BackColor = System.Drawing.Color.Transparent
        Me.lblDownPayment.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownPayment.Location = New System.Drawing.Point(713, 375)
        Me.lblDownPayment.Name = "lblDownPayment"
        Me.lblDownPayment.Size = New System.Drawing.Size(106, 18)
        Me.lblDownPayment.TabIndex = 20
        Me.lblDownPayment.Text = "0.00"
        Me.lblDownPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNumberOfRooms
        '
        Me.lblNumberOfRooms.AutoSize = True
        Me.lblNumberOfRooms.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfRooms.Location = New System.Drawing.Point(528, 354)
        Me.lblNumberOfRooms.Name = "lblNumberOfRooms"
        Me.lblNumberOfRooms.Size = New System.Drawing.Size(15, 18)
        Me.lblNumberOfRooms.TabIndex = 14
        Me.lblNumberOfRooms.Text = "0"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(417, 354)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(92, 18)
        Me.Label77.TabIndex = 13
        Me.Label77.Text = "No. of Rooms:"
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.White
        Me.txtRemarks.Location = New System.Drawing.Point(417, 411)
        Me.txtRemarks.MaxLength = 1000
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(349, 89)
        Me.txtRemarks.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(417, 390)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "&Remarks:"
        '
        'gbxRoomReservationDetails
        '
        Me.gbxRoomReservationDetails.BackColor = System.Drawing.Color.Transparent
        Me.gbxRoomReservationDetails.Controls.Add(Me.lblNumberOfNights)
        Me.gbxRoomReservationDetails.Controls.Add(Me.txtNoOfOccupants)
        Me.gbxRoomReservationDetails.Controls.Add(Me.Label1)
        Me.gbxRoomReservationDetails.Controls.Add(Me.Label13)
        Me.gbxRoomReservationDetails.Controls.Add(Me.lblRoomRate)
        Me.gbxRoomReservationDetails.Controls.Add(Me.btnViewDetails)
        Me.gbxRoomReservationDetails.Controls.Add(Me.lblRoomNumber)
        Me.gbxRoomReservationDetails.Controls.Add(Me.btnAddRoom)
        Me.gbxRoomReservationDetails.Controls.Add(Me.Label5)
        Me.gbxRoomReservationDetails.Controls.Add(Me.chkRoomByRequest)
        Me.gbxRoomReservationDetails.Controls.Add(Me.Label27)
        Me.gbxRoomReservationDetails.Location = New System.Drawing.Point(3, 390)
        Me.gbxRoomReservationDetails.Name = "gbxRoomReservationDetails"
        Me.gbxRoomReservationDetails.Size = New System.Drawing.Size(409, 110)
        Me.gbxRoomReservationDetails.TabIndex = 1
        Me.gbxRoomReservationDetails.TabStop = False
        Me.gbxRoomReservationDetails.Text = "Room Reservation Details"
        '
        'lblNumberOfNights
        '
        Me.lblNumberOfNights.AutoSize = True
        Me.lblNumberOfNights.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfNights.Location = New System.Drawing.Point(103, 54)
        Me.lblNumberOfNights.Name = "lblNumberOfNights"
        Me.lblNumberOfNights.Size = New System.Drawing.Size(15, 18)
        Me.lblNumberOfNights.TabIndex = 5
        Me.lblNumberOfNights.Text = "0"
        Me.lblNumberOfNights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNoOfOccupants
        '
        Me.txtNoOfOccupants.BackColor = System.Drawing.Color.White
        Me.txtNoOfOccupants.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfOccupants.Location = New System.Drawing.Point(320, 16)
        Me.txtNoOfOccupants.MaxLength = 4
        Me.txtNoOfOccupants.Name = "txtNoOfOccupants"
        Me.txtNoOfOccupants.Size = New System.Drawing.Size(56, 23)
        Me.txtNoOfOccupants.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "No. of &Occupants:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(10, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 18)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "No. of Nights:"
        '
        'lblRoomRate
        '
        Me.lblRoomRate.AutoSize = True
        Me.lblRoomRate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomRate.Location = New System.Drawing.Point(103, 35)
        Me.lblRoomRate.Name = "lblRoomRate"
        Me.lblRoomRate.Size = New System.Drawing.Size(15, 18)
        Me.lblRoomRate.TabIndex = 3
        Me.lblRoomRate.Text = "0"
        Me.lblRoomRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnViewDetails
        '
        Me.btnViewDetails.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.btnViewDetails.Location = New System.Drawing.Point(301, 78)
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.Size = New System.Drawing.Size(102, 28)
        Me.btnViewDetails.TabIndex = 10
        Me.btnViewDetails.Text = "View &Details"
        Me.btnViewDetails.UseVisualStyleBackColor = True
        '
        'lblRoomNumber
        '
        Me.lblRoomNumber.AutoSize = True
        Me.lblRoomNumber.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomNumber.Location = New System.Drawing.Point(103, 16)
        Me.lblRoomNumber.Name = "lblRoomNumber"
        Me.lblRoomNumber.Size = New System.Drawing.Size(15, 18)
        Me.lblRoomNumber.TabIndex = 1
        Me.lblRoomNumber.Text = "0"
        Me.lblRoomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddRoom
        '
        Me.btnAddRoom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.btnAddRoom.Location = New System.Drawing.Point(216, 78)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(77, 28)
        Me.btnAddRoom.TabIndex = 9
        Me.btnAddRoom.Text = "&Add Room"
        Me.btnAddRoom.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Room Rate:"
        '
        'chkRoomByRequest
        '
        Me.chkRoomByRequest.AutoSize = True
        Me.chkRoomByRequest.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRoomByRequest.Location = New System.Drawing.Point(195, 36)
        Me.chkRoomByRequest.Name = "chkRoomByRequest"
        Me.chkRoomByRequest.Size = New System.Drawing.Size(128, 22)
        Me.chkRoomByRequest.TabIndex = 8
        Me.chkRoomByRequest.Tag = "No"
        Me.chkRoomByRequest.Text = "&Room By Request"
        Me.chkRoomByRequest.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(10, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(70, 18)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Room No.:"
        '
        'gbxRoomVacancySearch
        '
        Me.gbxRoomVacancySearch.BackColor = System.Drawing.Color.Transparent
        Me.gbxRoomVacancySearch.Controls.Add(Me.lblSearchResult)
        Me.gbxRoomVacancySearch.Controls.Add(Me.dtpCheckOutDate)
        Me.gbxRoomVacancySearch.Controls.Add(Me.Label14)
        Me.gbxRoomVacancySearch.Controls.Add(Me.Label15)
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
        Me.gbxRoomVacancySearch.Controls.Add(Me.Label7)
        Me.gbxRoomVacancySearch.Controls.Add(Me.dtpCheckInDate)
        Me.gbxRoomVacancySearch.Location = New System.Drawing.Point(3, 3)
        Me.gbxRoomVacancySearch.Name = "gbxRoomVacancySearch"
        Me.gbxRoomVacancySearch.Size = New System.Drawing.Size(409, 386)
        Me.gbxRoomVacancySearch.TabIndex = 0
        Me.gbxRoomVacancySearch.TabStop = False
        Me.gbxRoomVacancySearch.Text = "Room Vacancy Search"
        '
        'lblSearchResult
        '
        Me.lblSearchResult.AutoSize = True
        Me.lblSearchResult.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.lblSearchResult.Location = New System.Drawing.Point(105, 138)
        Me.lblSearchResult.Name = "lblSearchResult"
        Me.lblSearchResult.Size = New System.Drawing.Size(15, 18)
        Me.lblSearchResult.TabIndex = 16
        Me.lblSearchResult.Text = "0"
        '
        'dtpCheckOutDate
        '
        Me.dtpCheckOutDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckOutDate.Location = New System.Drawing.Point(111, 45)
        Me.dtpCheckOutDate.Name = "dtpCheckOutDate"
        Me.dtpCheckOutDate.Size = New System.Drawing.Size(170, 23)
        Me.dtpCheckOutDate.TabIndex = 4
        Me.dtpCheckOutDate.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 18)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Check &In Date:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(4, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 18)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Check &Out Date:"
        '
        'cboRoomType
        '
        Me.cboRoomType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboRoomType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboRoomType.FormattingEnabled = True
        Me.cboRoomType.Items.AddRange(New Object() {""})
        Me.cboRoomType.Location = New System.Drawing.Point(280, 72)
        Me.cboRoomType.Name = "cboRoomType"
        Me.cboRoomType.Size = New System.Drawing.Size(117, 26)
        Me.cboRoomType.TabIndex = 9
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.Location = New System.Drawing.Point(73, 72)
        Me.txtRoomNumber.MaxLength = 20
        Me.txtRoomNumber.Name = "txtRoomNumber"
        Me.txtRoomNumber.Size = New System.Drawing.Size(117, 23)
        Me.txtRoomNumber.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(4, 72)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 18)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Room &No.:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(201, 72)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 18)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Room &Type:"
        '
        'dtpCheckOutTime
        '
        Me.dtpCheckOutTime.CustomFormat = "hhmmtt"
        Me.dtpCheckOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpCheckOutTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpCheckOutTime.Location = New System.Drawing.Point(296, 45)
        Me.dtpCheckOutTime.Name = "dtpCheckOutTime"
        Me.dtpCheckOutTime.ShowUpDown = True
        Me.dtpCheckOutTime.Size = New System.Drawing.Size(101, 23)
        Me.dtpCheckOutTime.TabIndex = 5
        Me.dtpCheckOutTime.Value = New Date(2006, 12, 11, 11, 59, 0, 0)
        '
        'dtpCheckInTime
        '
        Me.dtpCheckInTime.CustomFormat = "hhmmtt"
        Me.dtpCheckInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpCheckInTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpCheckInTime.Location = New System.Drawing.Point(296, 19)
        Me.dtpCheckInTime.Name = "dtpCheckInTime"
        Me.dtpCheckInTime.ShowUpDown = True
        Me.dtpCheckInTime.Size = New System.Drawing.Size(101, 23)
        Me.dtpCheckInTime.TabIndex = 2
        Me.dtpCheckInTime.Value = New Date(2006, 12, 11, 12, 0, 0, 0)
        '
        'dgvRoomVacancySearch
        '
        Me.dgvRoomVacancySearch.AllowUserToAddRows = False
        Me.dgvRoomVacancySearch.AllowUserToDeleteRows = False
        Me.dgvRoomVacancySearch.AllowUserToOrderColumns = True
        Me.dgvRoomVacancySearch.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRoomVacancySearch.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRoomVacancySearch.BackgroundColor = System.Drawing.Color.White
        Me.dgvRoomVacancySearch.Location = New System.Drawing.Point(6, 159)
        Me.dgvRoomVacancySearch.MultiSelect = False
        Me.dgvRoomVacancySearch.Name = "dgvRoomVacancySearch"
        Me.dgvRoomVacancySearch.ReadOnly = True
        Me.dgvRoomVacancySearch.RowHeadersVisible = False
        Me.dgvRoomVacancySearch.RowHeadersWidth = 25
        Me.dgvRoomVacancySearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRoomVacancySearch.Size = New System.Drawing.Size(395, 207)
        Me.dgvRoomVacancySearch.TabIndex = 17
        '
        'btnRoomVacancySearch
        '
        Me.btnRoomVacancySearch.Location = New System.Drawing.Point(337, 129)
        Me.btnRoomVacancySearch.Name = "btnRoomVacancySearch"
        Me.btnRoomVacancySearch.Size = New System.Drawing.Size(60, 28)
        Me.btnRoomVacancySearch.TabIndex = 14
        Me.btnRoomVacancySearch.Text = "&Search"
        Me.btnRoomVacancySearch.UseVisualStyleBackColor = True
        '
        'cboView
        '
        Me.cboView.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboView.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboView.FormattingEnabled = True
        Me.cboView.Items.AddRange(New Object() {""})
        Me.cboView.Location = New System.Drawing.Point(280, 101)
        Me.cboView.Name = "cboView"
        Me.cboView.Size = New System.Drawing.Size(117, 26)
        Me.cboView.TabIndex = 13
        '
        'cboFloor
        '
        Me.cboFloor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboFloor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFloor.FormattingEnabled = True
        Me.cboFloor.Items.AddRange(New Object() {""})
        Me.cboFloor.Location = New System.Drawing.Point(73, 101)
        Me.cboFloor.Name = "cboFloor"
        Me.cboFloor.Size = New System.Drawing.Size(117, 26)
        Me.cboFloor.TabIndex = 11
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(201, 101)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(42, 18)
        Me.Label78.TabIndex = 12
        Me.Label78.Text = "&View:"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.Color.Red
        Me.Label82.Location = New System.Drawing.Point(6, 368)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(241, 16)
        Me.Label82.TabIndex = 18
        Me.Label82.Text = "Click an item to define its reservation details."
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(4, 101)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(45, 18)
        Me.Label59.TabIndex = 10
        Me.Label59.Text = "&Floor:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Search Result/s:"
        '
        'dtpCheckInDate
        '
        Me.dtpCheckInDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckInDate.Location = New System.Drawing.Point(111, 19)
        Me.dtpCheckInDate.Name = "dtpCheckInDate"
        Me.dtpCheckInDate.Size = New System.Drawing.Size(170, 23)
        Me.dtpCheckInDate.TabIndex = 1
        Me.dtpCheckInDate.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'lblResourceLocator
        '
        Me.lblResourceLocator.AutoSize = True
        Me.lblResourceLocator.BackColor = System.Drawing.Color.Transparent
        Me.lblResourceLocator.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResourceLocator.Location = New System.Drawing.Point(550, 6)
        Me.lblResourceLocator.Name = "lblResourceLocator"
        Me.lblResourceLocator.Size = New System.Drawing.Size(16, 18)
        Me.lblResourceLocator.TabIndex = 3
        Me.lblResourceLocator.Text = "0"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(418, 6)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(106, 18)
        Me.Label41.TabIndex = 2
        Me.Label41.Text = "Record Locator:"
        '
        'dtpDateOfReservation
        '
        Me.dtpDateOfReservation.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDateOfReservation.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateOfReservation.Location = New System.Drawing.Point(553, 29)
        Me.dtpDateOfReservation.Name = "dtpDateOfReservation"
        Me.dtpDateOfReservation.Size = New System.Drawing.Size(149, 23)
        Me.dtpDateOfReservation.TabIndex = 5
        Me.dtpDateOfReservation.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(419, 29)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(132, 18)
        Me.Label40.TabIndex = 4
        Me.Label40.Text = "&Date of Reservation:"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAmount.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(713, 353)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(106, 18)
        Me.lblTotalAmount.TabIndex = 18
        Me.lblTotalAmount.Text = "0.00"
        Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(609, 371)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 18)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Down Payment:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(609, 351)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(95, 18)
        Me.Label34.TabIndex = 17
        Me.Label34.Text = "Total Amount:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(417, 333)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(113, 18)
        Me.Label37.TabIndex = 11
        Me.Label37.Text = "No. of Occupants:"
        '
        'btnRemoveRoom
        '
        Me.btnRemoveRoom.Location = New System.Drawing.Point(726, 305)
        Me.btnRemoveRoom.Name = "btnRemoveRoom"
        Me.btnRemoveRoom.Size = New System.Drawing.Size(110, 28)
        Me.btnRemoveRoom.TabIndex = 10
        Me.btnRemoveRoom.Text = "&Remove Room"
        Me.btnRemoveRoom.UseVisualStyleBackColor = True
        '
        'btnReservationSave
        '
        Me.btnReservationSave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservationSave.Location = New System.Drawing.Point(913, 585)
        Me.btnReservationSave.Name = "btnReservationSave"
        Me.btnReservationSave.Size = New System.Drawing.Size(60, 28)
        Me.btnReservationSave.TabIndex = 5
        Me.btnReservationSave.Text = "&Save"
        Me.btnReservationSave.UseVisualStyleBackColor = True
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.BackColor = System.Drawing.Color.Transparent
        Me.Label85.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(142, 16)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(84, 18)
        Me.Label85.TabIndex = 1
        Me.Label85.Text = "Guest Name:"
        '
        'lblNameOfGuest
        '
        Me.lblNameOfGuest.AutoSize = True
        Me.lblNameOfGuest.BackColor = System.Drawing.Color.Transparent
        Me.lblNameOfGuest.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.lblNameOfGuest.Location = New System.Drawing.Point(239, 16)
        Me.lblNameOfGuest.Name = "lblNameOfGuest"
        Me.lblNameOfGuest.Size = New System.Drawing.Size(12, 18)
        Me.lblNameOfGuest.TabIndex = 2
        Me.lblNameOfGuest.Text = " "
        '
        'lblReservationGNO
        '
        Me.lblReservationGNO.AutoSize = True
        Me.lblReservationGNO.BackColor = System.Drawing.Color.Transparent
        Me.lblReservationGNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservationGNO.Location = New System.Drawing.Point(107, 13)
        Me.lblReservationGNO.Name = "lblReservationGNO"
        Me.lblReservationGNO.Size = New System.Drawing.Size(27, 13)
        Me.lblReservationGNO.TabIndex = 239
        Me.lblReservationGNO.Text = "new"
        Me.lblReservationGNO.Visible = False
        '
        'llbClose
        '
        Me.llbClose.AutoSize = True
        Me.llbClose.BackColor = System.Drawing.Color.Transparent
        Me.llbClose.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbClose.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.llbClose.Location = New System.Drawing.Point(945, 10)
        Me.llbClose.Name = "llbClose"
        Me.llbClose.Size = New System.Drawing.Size(39, 18)
        Me.llbClose.TabIndex = 6
        Me.llbClose.TabStop = True
        Me.llbClose.Text = "Close"
        '
        'frmReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.llbClose)
        Me.Controls.Add(Me.lblNameOfGuest)
        Me.Controls.Add(Me.tbcReservation)
        Me.Controls.Add(Me.btnReservationSave)
        Me.Controls.Add(Me.lblReservationGNO)
        Me.Controls.Add(Me.Label85)
        Me.Controls.Add(Me.tsActivities)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 80)
        Me.Name = "frmReservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SLU Hotel"
        Me.tsActivities.ResumeLayout(False)
        Me.tsActivities.PerformLayout()
        Me.tbcReservation.ResumeLayout(False)
        Me.tbpGuestInformation.ResumeLayout(False)
        Me.tbpGuestInformation.PerformLayout()
        Me.grpGuestInformation.ResumeLayout(False)
        Me.grpGuestInformation.PerformLayout()
        Me.grpCompanyGroupInformation.ResumeLayout(False)
        Me.grpCompanyGroupInformation.PerformLayout()
        CType(Me.dgvCompanyGroupInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCompanyGroupInformation.ResumeLayout(False)
        Me.pnlCompanyGroupInformation.PerformLayout()
        Me.tbpReservationInformation.ResumeLayout(False)
        Me.tbpReservationInformation.PerformLayout()
        CType(Me.dgvGuestRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxRoomReservationDetails.ResumeLayout(False)
        Me.gbxRoomReservationDetails.PerformLayout()
        Me.gbxRoomVacancySearch.ResumeLayout(False)
        Me.gbxRoomVacancySearch.PerformLayout()
        CType(Me.dgvRoomVacancySearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsActivities As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuestSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbUpdateReservation As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbPayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents tbcReservation As System.Windows.Forms.TabControl
    Friend WithEvents tbpGuestInformation As System.Windows.Forms.TabPage
    Friend WithEvents tbpReservationInformation As System.Windows.Forms.TabPage
    Friend WithEvents lblDownPayment As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfRooms As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbxRoomReservationDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoOfOccupants As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblRoomRate As System.Windows.Forms.Label
    Private WithEvents btnViewDetails As System.Windows.Forms.Button
    Friend WithEvents lblRoomNumber As System.Windows.Forms.Label
    Private WithEvents btnAddRoom As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkRoomByRequest As System.Windows.Forms.CheckBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblResourceLocator As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents dtpDateOfReservation As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Private WithEvents btnRemoveRoom As System.Windows.Forms.Button
    Private WithEvents Label85 As System.Windows.Forms.Label
    Private WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblNumberOfOccupants As System.Windows.Forms.Label
    Friend WithEvents grpGuestInformation As System.Windows.Forms.GroupBox
    Friend WithEvents txtGuestInfoTitle As System.Windows.Forms.TextBox
    Friend WithEvents chkGuestInfoCompanyGroup As System.Windows.Forms.CheckBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txtGuestInfoNationality As System.Windows.Forms.TextBox
    Friend WithEvents txtGuestInfoFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtGuestInfoEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtGuestInfoLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtGuestInfoMiddleInitial As System.Windows.Forms.TextBox
    Friend WithEvents txtGuestInfoZipCode As System.Windows.Forms.TextBox
    Friend WithEvents txtGuestInfoContactNo As System.Windows.Forms.TextBox
    Friend WithEvents txtGuestInfoAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents grpCompanyGroupInformation As System.Windows.Forms.GroupBox
    Friend WithEvents radCompanyInfo As System.Windows.Forms.RadioButton
    Friend WithEvents radCompanyInfoPreviousCompany As System.Windows.Forms.RadioButton
    Friend WithEvents radCompanyInfoNew As System.Windows.Forms.RadioButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents btnGuestInfoClear As System.Windows.Forms.Button
    Friend WithEvents pnlCompanyGroupInformation As System.Windows.Forms.Panel
    Friend WithEvents txtCompanyInfoPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyInfoBranch As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyInfoContactPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyInfoCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyInfoContactNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyInfoAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Private WithEvents lblNameOfGuest As System.Windows.Forms.Label
    Friend WithEvents txtGuestInfoCitezenship As System.Windows.Forms.TextBox
    Friend WithEvents cboGuestType As System.Windows.Forms.ComboBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents cboGuestInfoCivilStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cboGuestInfoCountry As System.Windows.Forms.ComboBox
    Friend WithEvents cboGuestInfoGender As System.Windows.Forms.ComboBox
    Public WithEvents btnReservationSave As System.Windows.Forms.Button
    Public WithEvents lblReservationGNO As System.Windows.Forms.Label
    Public WithEvents lblReservationGIID As System.Windows.Forms.Label
    Public WithEvents lblReservationCID As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dgvCompanyGroupInformation As System.Windows.Forms.DataGridView
    Friend WithEvents dtpGuestInfoBirthDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvGuestRooms As System.Windows.Forms.DataGridView
    Friend WithEvents gbxRoomVacancySearch As System.Windows.Forms.GroupBox
    Friend WithEvents dtpCheckOutDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
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
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpCheckInDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNumberOfNights As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents lblReq As System.Windows.Forms.Label
    Friend WithEvents llbClose As System.Windows.Forms.LinkLabel
    Friend WithEvents lblSearchResult As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
