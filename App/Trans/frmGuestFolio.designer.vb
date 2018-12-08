<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuestFolio
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
        Me.grpGuestInfo = New System.Windows.Forms.GroupBox
        Me.txtCompanyAddress = New System.Windows.Forms.TextBox
        Me.txtCompanyContactNo = New System.Windows.Forms.TextBox
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtContactNo = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblGTitle = New System.Windows.Forms.Label
        Me.lblMiddleInitial = New System.Windows.Forms.Label
        Me.lblLastName = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.lblFirstName = New System.Windows.Forms.Label
        Me.dtpDate1 = New System.Windows.Forms.Label
        Me.lblCompanyAddress = New System.Windows.Forms.Label
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.lblCompanyContactNo = New System.Windows.Forms.Label
        Me.chkSelectAll = New System.Windows.Forms.CheckBox
        Me.lblCompany = New System.Windows.Forms.Label
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblContactNumber = New System.Windows.Forms.Label
        Me.lblGuestType = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.tsActivities = New System.Windows.Forms.ToolStrip
        Me.tsbGuestSearch = New System.Windows.Forms.ToolStripButton
        Me.tss1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbActRmCharge = New System.Windows.Forms.ToolStripButton
        Me.tss8 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbActAmnServ = New System.Windows.Forms.ToolStripButton
        Me.tss3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbActAccTrans = New System.Windows.Forms.ToolStripButton
        Me.tss4 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbActIncDec = New System.Windows.Forms.ToolStripButton
        Me.tss5 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbActPayment = New System.Windows.Forms.ToolStripButton
        Me.tss7 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbUncollectibles = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.dgvPaymentHistory = New System.Windows.Forms.DataGridView
        Me.lblTotalBalanceAmt = New System.Windows.Forms.Label
        Me.lblTotalPayment = New System.Windows.Forms.Label
        Me.lblTotalNumberOfPayments = New System.Windows.Forms.Label
        Me.Label82 = New System.Windows.Forms.Label
        Me.Label81 = New System.Windows.Forms.Label
        Me.Label80 = New System.Windows.Forms.Label
        Me.gbxPaymentHistory = New System.Windows.Forms.GroupBox
        Me.lblCountBills = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblTotalBill = New System.Windows.Forms.Label
        Me.Label83 = New System.Windows.Forms.Label
        Me.grpBillBreakdown = New System.Windows.Forms.GroupBox
        Me.dgvBillBreakdown = New System.Windows.Forms.DataGridView
        Me.btnRemove = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblRemove = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblUncollectibles = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblCountUncollectibles = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblRefund = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblNoOfRefunds = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.grpGuestInfo.SuspendLayout()
        Me.tsActivities.SuspendLayout()
        CType(Me.dgvPaymentHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPaymentHistory.SuspendLayout()
        Me.grpBillBreakdown.SuspendLayout()
        CType(Me.dgvBillBreakdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGuestInfo
        '
        Me.grpGuestInfo.BackColor = System.Drawing.Color.Transparent
        Me.grpGuestInfo.Controls.Add(Me.txtCompanyAddress)
        Me.grpGuestInfo.Controls.Add(Me.txtCompanyContactNo)
        Me.grpGuestInfo.Controls.Add(Me.txtCompany)
        Me.grpGuestInfo.Controls.Add(Me.txtAddress)
        Me.grpGuestInfo.Controls.Add(Me.txtContactNo)
        Me.grpGuestInfo.Controls.Add(Me.txtName)
        Me.grpGuestInfo.Controls.Add(Me.lblGTitle)
        Me.grpGuestInfo.Controls.Add(Me.lblMiddleInitial)
        Me.grpGuestInfo.Controls.Add(Me.lblLastName)
        Me.grpGuestInfo.Controls.Add(Me.Label10)
        Me.grpGuestInfo.Controls.Add(Me.dtpEndDate)
        Me.grpGuestInfo.Controls.Add(Me.lblFirstName)
        Me.grpGuestInfo.Controls.Add(Me.dtpDate1)
        Me.grpGuestInfo.Controls.Add(Me.lblCompanyAddress)
        Me.grpGuestInfo.Controls.Add(Me.dtpStartDate)
        Me.grpGuestInfo.Controls.Add(Me.lblCompanyContactNo)
        Me.grpGuestInfo.Controls.Add(Me.chkSelectAll)
        Me.grpGuestInfo.Controls.Add(Me.lblCompany)
        Me.grpGuestInfo.Controls.Add(Me.lblAddress)
        Me.grpGuestInfo.Controls.Add(Me.lblContactNumber)
        Me.grpGuestInfo.Controls.Add(Me.lblGuestType)
        Me.grpGuestInfo.Controls.Add(Me.lblName)
        Me.grpGuestInfo.Controls.Add(Me.Label21)
        Me.grpGuestInfo.Controls.Add(Me.Label20)
        Me.grpGuestInfo.Controls.Add(Me.Label19)
        Me.grpGuestInfo.Controls.Add(Me.Label1)
        Me.grpGuestInfo.Controls.Add(Me.Label17)
        Me.grpGuestInfo.Controls.Add(Me.Label18)
        Me.grpGuestInfo.Controls.Add(Me.Label2)
        Me.grpGuestInfo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpGuestInfo.Location = New System.Drawing.Point(143, 21)
        Me.grpGuestInfo.Name = "grpGuestInfo"
        Me.grpGuestInfo.Size = New System.Drawing.Size(837, 130)
        Me.grpGuestInfo.TabIndex = 1
        Me.grpGuestInfo.TabStop = False
        Me.grpGuestInfo.Text = "Guest Information"
        '
        'txtCompanyAddress
        '
        Me.txtCompanyAddress.BackColor = System.Drawing.Color.White
        Me.txtCompanyAddress.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyAddress.Location = New System.Drawing.Point(510, 44)
        Me.txtCompanyAddress.MaxLength = 100
        Me.txtCompanyAddress.Name = "txtCompanyAddress"
        Me.txtCompanyAddress.ReadOnly = True
        Me.txtCompanyAddress.Size = New System.Drawing.Size(316, 23)
        Me.txtCompanyAddress.TabIndex = 7
        Me.txtCompanyAddress.TabStop = False
        '
        'txtCompanyContactNo
        '
        Me.txtCompanyContactNo.BackColor = System.Drawing.Color.White
        Me.txtCompanyContactNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyContactNo.Location = New System.Drawing.Point(510, 69)
        Me.txtCompanyContactNo.MaxLength = 30
        Me.txtCompanyContactNo.Name = "txtCompanyContactNo"
        Me.txtCompanyContactNo.ReadOnly = True
        Me.txtCompanyContactNo.Size = New System.Drawing.Size(316, 23)
        Me.txtCompanyContactNo.TabIndex = 9
        Me.txtCompanyContactNo.TabStop = False
        '
        'txtCompany
        '
        Me.txtCompany.BackColor = System.Drawing.Color.White
        Me.txtCompany.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.Location = New System.Drawing.Point(510, 19)
        Me.txtCompany.MaxLength = 50
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.ReadOnly = True
        Me.txtCompany.Size = New System.Drawing.Size(316, 23)
        Me.txtCompany.TabIndex = 5
        Me.txtCompany.TabStop = False
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(92, 44)
        Me.txtAddress.MaxLength = 100
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(316, 23)
        Me.txtAddress.TabIndex = 1
        Me.txtAddress.TabStop = False
        '
        'txtContactNo
        '
        Me.txtContactNo.BackColor = System.Drawing.Color.White
        Me.txtContactNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.Location = New System.Drawing.Point(92, 70)
        Me.txtContactNo.MaxLength = 30
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.ReadOnly = True
        Me.txtContactNo.Size = New System.Drawing.Size(316, 23)
        Me.txtContactNo.TabIndex = 3
        Me.txtContactNo.TabStop = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(92, 19)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(316, 23)
        Me.txtName.TabIndex = 1
        Me.txtName.TabStop = False
        '
        'lblGTitle
        '
        Me.lblGTitle.AccessibleDescription = ""
        Me.lblGTitle.AutoSize = True
        Me.lblGTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblGTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGTitle.Location = New System.Drawing.Point(282, 20)
        Me.lblGTitle.Name = "lblGTitle"
        Me.lblGTitle.Size = New System.Drawing.Size(0, 13)
        Me.lblGTitle.TabIndex = 93
        Me.lblGTitle.Visible = False
        '
        'lblMiddleInitial
        '
        Me.lblMiddleInitial.AccessibleDescription = ""
        Me.lblMiddleInitial.AutoSize = True
        Me.lblMiddleInitial.BackColor = System.Drawing.Color.Transparent
        Me.lblMiddleInitial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiddleInitial.Location = New System.Drawing.Point(350, 63)
        Me.lblMiddleInitial.Name = "lblMiddleInitial"
        Me.lblMiddleInitial.Size = New System.Drawing.Size(0, 13)
        Me.lblMiddleInitial.TabIndex = 92
        '
        'lblLastName
        '
        Me.lblLastName.AccessibleDescription = ""
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(354, 40)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(0, 13)
        Me.lblLastName.TabIndex = 91
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(367, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 18)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "&End Date:"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(438, 97)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(154, 23)
        Me.dtpEndDate.TabIndex = 4
        '
        'lblFirstName
        '
        Me.lblFirstName.AccessibleDescription = ""
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(355, 19)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(0, 13)
        Me.lblFirstName.TabIndex = 90
        '
        'dtpDate1
        '
        Me.dtpDate1.AutoSize = True
        Me.dtpDate1.BackColor = System.Drawing.Color.Transparent
        Me.dtpDate1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate1.Location = New System.Drawing.Point(121, 97)
        Me.dtpDate1.Name = "dtpDate1"
        Me.dtpDate1.Size = New System.Drawing.Size(73, 18)
        Me.dtpDate1.TabIndex = 1
        Me.dtpDate1.Text = "&Start Date:"
        '
        'lblCompanyAddress
        '
        Me.lblCompanyAddress.AutoSize = True
        Me.lblCompanyAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblCompanyAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyAddress.Location = New System.Drawing.Point(82, 167)
        Me.lblCompanyAddress.Name = "lblCompanyAddress"
        Me.lblCompanyAddress.Size = New System.Drawing.Size(0, 13)
        Me.lblCompanyAddress.TabIndex = 87
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpStartDate.Enabled = False
        Me.dtpStartDate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(200, 95)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(155, 23)
        Me.dtpStartDate.TabIndex = 2
        '
        'lblCompanyContactNo
        '
        Me.lblCompanyContactNo.AutoSize = True
        Me.lblCompanyContactNo.BackColor = System.Drawing.Color.Transparent
        Me.lblCompanyContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyContactNo.Location = New System.Drawing.Point(7, 103)
        Me.lblCompanyContactNo.Name = "lblCompanyContactNo"
        Me.lblCompanyContactNo.Size = New System.Drawing.Size(0, 13)
        Me.lblCompanyContactNo.TabIndex = 86
        '
        'chkSelectAll
        '
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.BackColor = System.Drawing.Color.Transparent
        Me.chkSelectAll.Checked = True
        Me.chkSelectAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSelectAll.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelectAll.Location = New System.Drawing.Point(12, 96)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(72, 22)
        Me.chkSelectAll.TabIndex = 0
        Me.chkSelectAll.Text = "View All"
        Me.chkSelectAll.UseVisualStyleBackColor = False
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.BackColor = System.Drawing.Color.Transparent
        Me.lblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(7, 82)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(0, 13)
        Me.lblCompany.TabIndex = 4
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(7, 42)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(0, 13)
        Me.lblAddress.TabIndex = 2
        '
        'lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.BackColor = System.Drawing.Color.Transparent
        Me.lblContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactNumber.Location = New System.Drawing.Point(83, 94)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(0, 13)
        Me.lblContactNumber.TabIndex = 83
        '
        'lblGuestType
        '
        Me.lblGuestType.AutoSize = True
        Me.lblGuestType.BackColor = System.Drawing.Color.Transparent
        Me.lblGuestType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestType.Location = New System.Drawing.Point(83, 68)
        Me.lblGuestType.Name = "lblGuestType"
        Me.lblGuestType.Size = New System.Drawing.Size(0, 13)
        Me.lblGuestType.TabIndex = 82
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(82, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 13)
        Me.lblName.TabIndex = 81
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(430, 46)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 18)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Address:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(430, 71)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(85, 18)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Contact No.:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(430, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 18)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Company:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Contact No.:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 18)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Address:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(83, 104)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 13)
        Me.Label18.TabIndex = 76
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name:"
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
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Close"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(-2, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(118, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Guest Folio"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tsActivities
        '
        Me.tsActivities.AutoSize = False
        Me.tsActivities.BackColor = System.Drawing.Color.Transparent
        Me.tsActivities.Dock = System.Windows.Forms.DockStyle.None
        Me.tsActivities.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsActivities.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.tsActivities.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuestSearch, Me.tss1, Me.tsbActRmCharge, Me.tss8, Me.tsbActAmnServ, Me.tss3, Me.tsbActAccTrans, Me.tss4, Me.tsbActIncDec, Me.tss5, Me.tsbActPayment, Me.tss7, Me.tsbUncollectibles, Me.ToolStripSeparator1})
        Me.tsActivities.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsActivities.Location = New System.Drawing.Point(2, 77)
        Me.tsActivities.Name = "tsActivities"
        Me.tsActivities.ShowItemToolTips = False
        Me.tsActivities.Size = New System.Drawing.Size(113, 315)
        Me.tsActivities.TabIndex = 22
        Me.tsActivities.Text = "ToolStrip2"
        '
        'tsbGuestSearch
        '
        Me.tsbGuestSearch.AutoSize = False
        Me.tsbGuestSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGuestSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuestSearch.Name = "tsbGuestSearch"
        Me.tsbGuestSearch.Size = New System.Drawing.Size(120, 30)
        Me.tsbGuestSearch.Text = "Guest Search"
        '
        'tss1
        '
        Me.tss1.Name = "tss1"
        Me.tss1.Size = New System.Drawing.Size(111, 6)
        '
        'tsbActRmCharge
        '
        Me.tsbActRmCharge.AutoSize = False
        Me.tsbActRmCharge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbActRmCharge.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbActRmCharge.Name = "tsbActRmCharge"
        Me.tsbActRmCharge.Size = New System.Drawing.Size(120, 30)
        Me.tsbActRmCharge.Text = "Update Room Charge"
        Me.tsbActRmCharge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss8
        '
        Me.tss8.Name = "tss8"
        Me.tss8.Size = New System.Drawing.Size(111, 6)
        '
        'tsbActAmnServ
        '
        Me.tsbActAmnServ.AutoSize = False
        Me.tsbActAmnServ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbActAmnServ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbActAmnServ.Name = "tsbActAmnServ"
        Me.tsbActAmnServ.Size = New System.Drawing.Size(120, 30)
        Me.tsbActAmnServ.Text = "Amenities and Services"
        Me.tsbActAmnServ.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss3
        '
        Me.tss3.Name = "tss3"
        Me.tss3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tss3.Size = New System.Drawing.Size(111, 6)
        '
        'tsbActAccTrans
        '
        Me.tsbActAccTrans.AutoSize = False
        Me.tsbActAccTrans.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbActAccTrans.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbActAccTrans.Name = "tsbActAccTrans"
        Me.tsbActAccTrans.Size = New System.Drawing.Size(120, 30)
        Me.tsbActAccTrans.Text = "Account Transfer"
        Me.tsbActAccTrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbActAccTrans.ToolTipText = "Account Transfer"
        '
        'tss4
        '
        Me.tss4.Name = "tss4"
        Me.tss4.Size = New System.Drawing.Size(111, 6)
        '
        'tsbActIncDec
        '
        Me.tsbActIncDec.AutoSize = False
        Me.tsbActIncDec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbActIncDec.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbActIncDec.Name = "tsbActIncDec"
        Me.tsbActIncDec.Size = New System.Drawing.Size(120, 30)
        Me.tsbActIncDec.Text = "Modify Amount"
        Me.tsbActIncDec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss5
        '
        Me.tss5.Name = "tss5"
        Me.tss5.Size = New System.Drawing.Size(111, 6)
        '
        'tsbActPayment
        '
        Me.tsbActPayment.AutoSize = False
        Me.tsbActPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
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
        'tsbUncollectibles
        '
        Me.tsbUncollectibles.AutoSize = False
        Me.tsbUncollectibles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbUncollectibles.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUncollectibles.Name = "tsbUncollectibles"
        Me.tsbUncollectibles.Size = New System.Drawing.Size(120, 30)
        Me.tsbUncollectibles.Text = "Uncollectible"
        Me.tsbUncollectibles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(111, 6)
        '
        'dgvPaymentHistory
        '
        Me.dgvPaymentHistory.AllowUserToAddRows = False
        Me.dgvPaymentHistory.AllowUserToDeleteRows = False
        Me.dgvPaymentHistory.AllowUserToOrderColumns = True
        Me.dgvPaymentHistory.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvPaymentHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPaymentHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvPaymentHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvPaymentHistory.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvPaymentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaymentHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPaymentHistory.Location = New System.Drawing.Point(3, 19)
        Me.dgvPaymentHistory.MultiSelect = False
        Me.dgvPaymentHistory.Name = "dgvPaymentHistory"
        Me.dgvPaymentHistory.ReadOnly = True
        Me.dgvPaymentHistory.RowHeadersVisible = False
        Me.dgvPaymentHistory.RowHeadersWidth = 25
        Me.dgvPaymentHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPaymentHistory.Size = New System.Drawing.Size(829, 130)
        Me.dgvPaymentHistory.TabIndex = 0
        '
        'lblTotalBalanceAmt
        '
        Me.lblTotalBalanceAmt.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalBalanceAmt.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBalanceAmt.Location = New System.Drawing.Point(844, 558)
        Me.lblTotalBalanceAmt.Name = "lblTotalBalanceAmt"
        Me.lblTotalBalanceAmt.Size = New System.Drawing.Size(97, 17)
        Me.lblTotalBalanceAmt.TabIndex = 18
        Me.lblTotalBalanceAmt.Text = "0"
        Me.lblTotalBalanceAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalPayment
        '
        Me.lblTotalPayment.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPayment.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayment.Location = New System.Drawing.Point(842, 534)
        Me.lblTotalPayment.Name = "lblTotalPayment"
        Me.lblTotalPayment.Size = New System.Drawing.Size(99, 18)
        Me.lblTotalPayment.TabIndex = 16
        Me.lblTotalPayment.Text = "0"
        Me.lblTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalNumberOfPayments
        '
        Me.lblTotalNumberOfPayments.AutoSize = True
        Me.lblTotalNumberOfPayments.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalNumberOfPayments.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNumberOfPayments.Location = New System.Drawing.Point(317, 510)
        Me.lblTotalNumberOfPayments.Name = "lblTotalNumberOfPayments"
        Me.lblTotalNumberOfPayments.Size = New System.Drawing.Size(15, 18)
        Me.lblTotalNumberOfPayments.TabIndex = 12
        Me.lblTotalNumberOfPayments.Text = "0"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.BackColor = System.Drawing.Color.Transparent
        Me.Label82.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(702, 557)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(96, 18)
        Me.Label82.TabIndex = 17
        Me.Label82.Text = "Total Balance:"
        '
        'Label81
        '
        Me.Label81.BackColor = System.Drawing.Color.Transparent
        Me.Label81.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(702, 534)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(110, 22)
        Me.Label81.TabIndex = 15
        Me.Label81.Text = "Total Payment:"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.BackColor = System.Drawing.Color.Transparent
        Me.Label80.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(143, 510)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(168, 18)
        Me.Label80.TabIndex = 11
        Me.Label80.Text = "Total Number of Payments:"
        '
        'gbxPaymentHistory
        '
        Me.gbxPaymentHistory.BackColor = System.Drawing.Color.Transparent
        Me.gbxPaymentHistory.Controls.Add(Me.dgvPaymentHistory)
        Me.gbxPaymentHistory.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPaymentHistory.Location = New System.Drawing.Point(143, 352)
        Me.gbxPaymentHistory.Name = "gbxPaymentHistory"
        Me.gbxPaymentHistory.Size = New System.Drawing.Size(835, 152)
        Me.gbxPaymentHistory.TabIndex = 10
        Me.gbxPaymentHistory.TabStop = False
        Me.gbxPaymentHistory.Text = "Payment History"
        '
        'lblCountBills
        '
        Me.lblCountBills.AutoSize = True
        Me.lblCountBills.BackColor = System.Drawing.Color.Transparent
        Me.lblCountBills.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountBills.Location = New System.Drawing.Point(291, 327)
        Me.lblCountBills.Name = "lblCountBills"
        Me.lblCountBills.Size = New System.Drawing.Size(15, 18)
        Me.lblCountBills.TabIndex = 7
        Me.lblCountBills.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(150, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Number of Bills:"
        '
        'lblTotalBill
        '
        Me.lblTotalBill.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalBill.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBill.Location = New System.Drawing.Point(844, 510)
        Me.lblTotalBill.Name = "lblTotalBill"
        Me.lblTotalBill.Size = New System.Drawing.Size(97, 19)
        Me.lblTotalBill.TabIndex = 14
        Me.lblTotalBill.Text = "0"
        Me.lblTotalBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.BackColor = System.Drawing.Color.Transparent
        Me.Label83.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(702, 510)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(68, 18)
        Me.Label83.TabIndex = 13
        Me.Label83.Text = "Total Bill:"
        '
        'grpBillBreakdown
        '
        Me.grpBillBreakdown.BackColor = System.Drawing.Color.Transparent
        Me.grpBillBreakdown.Controls.Add(Me.dgvBillBreakdown)
        Me.grpBillBreakdown.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBillBreakdown.Location = New System.Drawing.Point(142, 157)
        Me.grpBillBreakdown.Name = "grpBillBreakdown"
        Me.grpBillBreakdown.Size = New System.Drawing.Size(838, 167)
        Me.grpBillBreakdown.TabIndex = 5
        Me.grpBillBreakdown.TabStop = False
        Me.grpBillBreakdown.Text = "Bill Breakdown"
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
        Me.dgvBillBreakdown.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dgvBillBreakdown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBillBreakdown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBillBreakdown.Location = New System.Drawing.Point(3, 19)
        Me.dgvBillBreakdown.MultiSelect = False
        Me.dgvBillBreakdown.Name = "dgvBillBreakdown"
        Me.dgvBillBreakdown.ReadOnly = True
        Me.dgvBillBreakdown.RowHeadersVisible = False
        Me.dgvBillBreakdown.RowHeadersWidth = 25
        Me.dgvBillBreakdown.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBillBreakdown.Size = New System.Drawing.Size(832, 145)
        Me.dgvBillBreakdown.TabIndex = 0
        '
        'btnRemove
        '
        Me.btnRemove.AutoSize = True
        Me.btnRemove.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(910, 578)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(65, 28)
        Me.btnRemove.TabIndex = 19
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(832, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(881, 324)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(97, 19)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRemove
        '
        Me.lblRemove.AutoSize = True
        Me.lblRemove.BackColor = System.Drawing.Color.Transparent
        Me.lblRemove.Font = New System.Drawing.Font("Trebuchet MS", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemove.ForeColor = System.Drawing.Color.Red
        Me.lblRemove.Location = New System.Drawing.Point(166, 589)
        Me.lblRemove.Name = "lblRemove"
        Me.lblRemove.Size = New System.Drawing.Size(0, 16)
        Me.lblRemove.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(139, 590)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(371, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Note: To delete items from the Bill Breakdown click the Remove Button."
        '
        'lblUncollectibles
        '
        Me.lblUncollectibles.BackColor = System.Drawing.Color.Transparent
        Me.lblUncollectibles.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUncollectibles.Location = New System.Drawing.Point(715, 325)
        Me.lblUncollectibles.Name = "lblUncollectibles"
        Me.lblUncollectibles.Size = New System.Drawing.Size(97, 19)
        Me.lblUncollectibles.TabIndex = 304
        Me.lblUncollectibles.Text = "0"
        Me.lblUncollectibles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(626, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 18)
        Me.Label7.TabIndex = 303
        Me.Label7.Text = "Uncollectibles:"
        '
        'lblCountUncollectibles
        '
        Me.lblCountUncollectibles.BackColor = System.Drawing.Color.Transparent
        Me.lblCountUncollectibles.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountUncollectibles.Location = New System.Drawing.Point(483, 326)
        Me.lblCountUncollectibles.Name = "lblCountUncollectibles"
        Me.lblCountUncollectibles.Size = New System.Drawing.Size(97, 19)
        Me.lblCountUncollectibles.TabIndex = 306
        Me.lblCountUncollectibles.Text = "0"
        Me.lblCountUncollectibles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(402, 326)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 18)
        Me.Label8.TabIndex = 305
        Me.Label8.Text = "No. of Uncollectibles:"
        '
        'lblRefund
        '
        Me.lblRefund.BackColor = System.Drawing.Color.Transparent
        Me.lblRefund.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefund.Location = New System.Drawing.Point(484, 529)
        Me.lblRefund.Name = "lblRefund"
        Me.lblRefund.Size = New System.Drawing.Size(97, 19)
        Me.lblRefund.TabIndex = 308
        Me.lblRefund.Text = "0"
        Me.lblRefund.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(436, 530)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 18)
        Me.Label11.TabIndex = 307
        Me.Label11.Text = "Refund:"
        '
        'lblNoOfRefunds
        '
        Me.lblNoOfRefunds.BackColor = System.Drawing.Color.Transparent
        Me.lblNoOfRefunds.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfRefunds.Location = New System.Drawing.Point(484, 510)
        Me.lblNoOfRefunds.Name = "lblNoOfRefunds"
        Me.lblNoOfRefunds.Size = New System.Drawing.Size(97, 19)
        Me.lblNoOfRefunds.TabIndex = 310
        Me.lblNoOfRefunds.Text = "0"
        Me.lblNoOfRefunds.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(396, 510)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 18)
        Me.Label12.TabIndex = 309
        Me.Label12.Text = "No. of Refund:"
        '
        'frmGuestFolio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblNoOfRefunds)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblRefund)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblUncollectibles)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblRemove)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblCountBills)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotalBill)
        Me.Controls.Add(Me.Label83)
        Me.Controls.Add(Me.gbxPaymentHistory)
        Me.Controls.Add(Me.lblTotalBalanceAmt)
        Me.Controls.Add(Me.lblTotalPayment)
        Me.Controls.Add(Me.lblTotalNumberOfPayments)
        Me.Controls.Add(Me.Label82)
        Me.Controls.Add(Me.Label81)
        Me.Controls.Add(Me.Label80)
        Me.Controls.Add(Me.grpGuestInfo)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.tsActivities)
        Me.Controls.Add(Me.grpBillBreakdown)
        Me.Controls.Add(Me.lblCountUncollectibles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 80)
        Me.Name = "frmGuestFolio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SLU Hotel"
        Me.grpGuestInfo.ResumeLayout(False)
        Me.grpGuestInfo.PerformLayout()
        Me.tsActivities.ResumeLayout(False)
        Me.tsActivities.PerformLayout()
        CType(Me.dgvPaymentHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPaymentHistory.ResumeLayout(False)
        Me.grpBillBreakdown.ResumeLayout(False)
        CType(Me.dgvBillBreakdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpGuestInfo As System.Windows.Forms.GroupBox
    Private WithEvents lblAddress As System.Windows.Forms.Label
    Private WithEvents lblContactNumber As System.Windows.Forms.Label
    Private WithEvents lblGuestType As System.Windows.Forms.Label
    Private WithEvents Label21 As System.Windows.Forms.Label
    Private WithEvents Label20 As System.Windows.Forms.Label
    Private WithEvents Label19 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents tsActivities As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbGuestSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbActRmCharge As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbActAmnServ As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbActAccTrans As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbActIncDec As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbActPayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbUncollectibles As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents lblCompany As System.Windows.Forms.Label
    Private WithEvents lblCompanyAddress As System.Windows.Forms.Label
    Private WithEvents lblCompanyContactNo As System.Windows.Forms.Label
    Friend WithEvents dgvPaymentHistory As System.Windows.Forms.DataGridView
    Private WithEvents lblGTitle As System.Windows.Forms.Label
    Private WithEvents lblMiddleInitial As System.Windows.Forms.Label
    Private WithEvents lblLastName As System.Windows.Forms.Label
    Private WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtCompanyAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCompanyContactNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalBalanceAmt As System.Windows.Forms.Label
    Friend WithEvents lblTotalPayment As System.Windows.Forms.Label
    Friend WithEvents lblTotalNumberOfPayments As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Private WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpDate1 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents gbxPaymentHistory As System.Windows.Forms.GroupBox
    Friend WithEvents lblCountBills As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotalBill As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents grpBillBreakdown As System.Windows.Forms.GroupBox
    Friend WithEvents dgvBillBreakdown As System.Windows.Forms.DataGridView
    Private WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblRemove As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblUncollectibles As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblCountUncollectibles As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblRefund As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblNoOfRefunds As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
