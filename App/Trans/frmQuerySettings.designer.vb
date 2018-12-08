<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuerySettings
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
        Me.tbcSettingsQuery = New System.Windows.Forms.TabControl
        Me.tbpRoomRates = New System.Windows.Forms.TabPage
        Me.txtAmountTo = New System.Windows.Forms.TextBox
        Me.txtAmountFrom = New System.Windows.Forms.TextBox
        Me.lblTotalResult = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboRoomNumber = New System.Windows.Forms.ComboBox
        Me.chkActive = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dgvRoomRates = New System.Windows.Forms.DataGridView
        Me.btnViewRoom = New System.Windows.Forms.Button
        Me.btnShow = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboRoomRateType = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblFDOName = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnAmenitiesShow = New System.Windows.Forms.Button
        Me.cboDepartment = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dgvAmenities = New System.Windows.Forms.DataGridView
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.tlsSettingQuery = New System.Windows.Forms.ToolStrip
        Me.tsbQueryShift = New System.Windows.Forms.ToolStripButton
        Me.tss1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbQueryRmStat = New System.Windows.Forms.ToolStripButton
        Me.tss2 = New System.Windows.Forms.ToolStripSeparator
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblClose = New System.Windows.Forms.LinkLabel
        Me.tbcSettingsQuery.SuspendLayout()
        Me.tbpRoomRates.SuspendLayout()
        CType(Me.dgvRoomRates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvAmenities, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlsSettingQuery.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcSettingsQuery
        '
        Me.tbcSettingsQuery.Controls.Add(Me.tbpRoomRates)
        Me.tbcSettingsQuery.Controls.Add(Me.TabPage2)
        Me.tbcSettingsQuery.Controls.Add(Me.TabPage1)
        Me.tbcSettingsQuery.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.tbcSettingsQuery.Location = New System.Drawing.Point(140, 23)
        Me.tbcSettingsQuery.Name = "tbcSettingsQuery"
        Me.tbcSettingsQuery.SelectedIndex = 0
        Me.tbcSettingsQuery.Size = New System.Drawing.Size(848, 590)
        Me.tbcSettingsQuery.TabIndex = 2
        '
        'tbpRoomRates
        '
        Me.tbpRoomRates.Controls.Add(Me.txtAmountTo)
        Me.tbpRoomRates.Controls.Add(Me.txtAmountFrom)
        Me.tbpRoomRates.Controls.Add(Me.lblTotalResult)
        Me.tbpRoomRates.Controls.Add(Me.Label3)
        Me.tbpRoomRates.Controls.Add(Me.cboRoomNumber)
        Me.tbpRoomRates.Controls.Add(Me.chkActive)
        Me.tbpRoomRates.Controls.Add(Me.Label5)
        Me.tbpRoomRates.Controls.Add(Me.dgvRoomRates)
        Me.tbpRoomRates.Controls.Add(Me.btnViewRoom)
        Me.tbpRoomRates.Controls.Add(Me.btnShow)
        Me.tbpRoomRates.Controls.Add(Me.Label9)
        Me.tbpRoomRates.Controls.Add(Me.Label10)
        Me.tbpRoomRates.Controls.Add(Me.cboRoomRateType)
        Me.tbpRoomRates.Controls.Add(Me.Label1)
        Me.tbpRoomRates.Controls.Add(Me.lblFDOName)
        Me.tbpRoomRates.Location = New System.Drawing.Point(4, 27)
        Me.tbpRoomRates.Name = "tbpRoomRates"
        Me.tbpRoomRates.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpRoomRates.Size = New System.Drawing.Size(840, 559)
        Me.tbpRoomRates.TabIndex = 0
        Me.tbpRoomRates.Text = "Room Rates"
        Me.tbpRoomRates.UseVisualStyleBackColor = True
        '
        'txtAmountTo
        '
        Me.txtAmountTo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtAmountTo.Location = New System.Drawing.Point(544, 44)
        Me.txtAmountTo.MaxLength = 20
        Me.txtAmountTo.Name = "txtAmountTo"
        Me.txtAmountTo.Size = New System.Drawing.Size(157, 23)
        Me.txtAmountTo.TabIndex = 10
        Me.txtAmountTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmountFrom
        '
        Me.txtAmountFrom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtAmountFrom.Location = New System.Drawing.Point(302, 43)
        Me.txtAmountFrom.MaxLength = 20
        Me.txtAmountFrom.Name = "txtAmountFrom"
        Me.txtAmountFrom.Size = New System.Drawing.Size(184, 23)
        Me.txtAmountFrom.TabIndex = 8
        Me.txtAmountFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalResult
        '
        Me.lblTotalResult.AutoSize = True
        Me.lblTotalResult.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblTotalResult.Location = New System.Drawing.Point(58, 530)
        Me.lblTotalResult.Name = "lblTotalResult"
        Me.lblTotalResult.Size = New System.Drawing.Size(16, 18)
        Me.lblTotalResult.TabIndex = 13
        Me.lblTotalResult.Text = "0"
        Me.lblTotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(5, 530)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 18)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Count:"
        '
        'cboRoomNumber
        '
        Me.cboRoomNumber.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.cboRoomNumber.FormattingEnabled = True
        Me.cboRoomNumber.Items.AddRange(New Object() {""})
        Me.cboRoomNumber.Location = New System.Drawing.Point(69, 14)
        Me.cboRoomNumber.Name = "cboRoomNumber"
        Me.cboRoomNumber.Size = New System.Drawing.Size(95, 26)
        Me.cboRoomNumber.TabIndex = 2
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Checked = True
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkActive.Location = New System.Drawing.Point(69, 46)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(95, 22)
        Me.chkActive.TabIndex = 6
        Me.chkActive.Text = "Active &only"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(10, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Status:"
        '
        'dgvRoomRates
        '
        Me.dgvRoomRates.AllowUserToAddRows = False
        Me.dgvRoomRates.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRoomRates.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRoomRates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvRoomRates.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvRoomRates.BackgroundColor = System.Drawing.Color.White
        Me.dgvRoomRates.Location = New System.Drawing.Point(7, 73)
        Me.dgvRoomRates.Name = "dgvRoomRates"
        Me.dgvRoomRates.ReadOnly = True
        Me.dgvRoomRates.RowHeadersVisible = False
        Me.dgvRoomRates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRoomRates.Size = New System.Drawing.Size(826, 446)
        Me.dgvRoomRates.TabIndex = 12
        '
        'btnViewRoom
        '
        Me.btnViewRoom.AutoSize = True
        Me.btnViewRoom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.btnViewRoom.Location = New System.Drawing.Point(707, 525)
        Me.btnViewRoom.Name = "btnViewRoom"
        Me.btnViewRoom.Size = New System.Drawing.Size(126, 28)
        Me.btnViewRoom.TabIndex = 14
        Me.btnViewRoom.Text = "&View Room Details"
        Me.btnViewRoom.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.AutoSize = True
        Me.btnShow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.btnShow.Location = New System.Drawing.Point(773, 39)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(60, 28)
        Me.btnShow.TabIndex = 11
        Me.btnShow.Text = "&Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(200, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 18)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Amount &From:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(500, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "&To:"
        '
        'cboRoomRateType
        '
        Me.cboRoomRateType.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.cboRoomRateType.FormattingEnabled = True
        Me.cboRoomRateType.Items.AddRange(New Object() {""})
        Me.cboRoomRateType.Location = New System.Drawing.Point(302, 14)
        Me.cboRoomRateType.Name = "cboRoomRateType"
        Me.cboRoomRateType.Size = New System.Drawing.Size(399, 26)
        Me.cboRoomRateType.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(29, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&No.:"
        '
        'lblFDOName
        '
        Me.lblFDOName.AutoSize = True
        Me.lblFDOName.BackColor = System.Drawing.Color.Transparent
        Me.lblFDOName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblFDOName.Location = New System.Drawing.Point(185, 17)
        Me.lblFDOName.Name = "lblFDOName"
        Me.lblFDOName.Size = New System.Drawing.Size(115, 18)
        Me.lblFDOName.TabIndex = 3
        Me.lblFDOName.Text = "Room &Rate Name:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.btnAmenitiesShow)
        Me.TabPage2.Controls.Add(Me.cboDepartment)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.dgvAmenities)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(840, 559)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Amenities and Services"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(59, 528)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(6, 528)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Count:"
        '
        'btnAmenitiesShow
        '
        Me.btnAmenitiesShow.AutoSize = True
        Me.btnAmenitiesShow.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.btnAmenitiesShow.Location = New System.Drawing.Point(289, 11)
        Me.btnAmenitiesShow.Name = "btnAmenitiesShow"
        Me.btnAmenitiesShow.Size = New System.Drawing.Size(60, 28)
        Me.btnAmenitiesShow.TabIndex = 3
        Me.btnAmenitiesShow.Text = "&Show"
        Me.btnAmenitiesShow.UseVisualStyleBackColor = True
        '
        'cboDepartment
        '
        Me.cboDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cboDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDepartment.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.cboDepartment.FormattingEnabled = True
        Me.cboDepartment.Items.AddRange(New Object() {""})
        Me.cboDepartment.Location = New System.Drawing.Point(94, 11)
        Me.cboDepartment.Name = "cboDepartment"
        Me.cboDepartment.Size = New System.Drawing.Size(189, 26)
        Me.cboDepartment.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(11, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "&Department:"
        '
        'dgvAmenities
        '
        Me.dgvAmenities.AllowUserToAddRows = False
        Me.dgvAmenities.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAmenities.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAmenities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvAmenities.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvAmenities.BackgroundColor = System.Drawing.Color.White
        Me.dgvAmenities.Location = New System.Drawing.Point(6, 43)
        Me.dgvAmenities.Name = "dgvAmenities"
        Me.dgvAmenities.ReadOnly = True
        Me.dgvAmenities.RowHeadersVisible = False
        Me.dgvAmenities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAmenities.Size = New System.Drawing.Size(828, 476)
        Me.dgvAmenities.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.RadioButton3)
        Me.TabPage1.Controls.Add(Me.RadioButton2)
        Me.TabPage1.Controls.Add(Me.RadioButton1)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(840, 559)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Features And Facilities"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Button1.Location = New System.Drawing.Point(213, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 28)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "&Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(130, 9)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(73, 22)
        Me.RadioButton3.TabIndex = 21
        Me.RadioButton3.Text = "Inactive"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(19, 9)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(40, 22)
        Me.RadioButton2.TabIndex = 20
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "All"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(65, 9)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(63, 22)
        Me.RadioButton1.TabIndex = 19
        Me.RadioButton1.Text = "Active"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(56, 531)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 18)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "0"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(3, 531)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Count:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(6, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(828, 485)
        Me.DataGridView1.TabIndex = 16
        '
        'tlsSettingQuery
        '
        Me.tlsSettingQuery.AutoSize = False
        Me.tlsSettingQuery.BackColor = System.Drawing.Color.Transparent
        Me.tlsSettingQuery.Dock = System.Windows.Forms.DockStyle.None
        Me.tlsSettingQuery.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsSettingQuery.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.tlsSettingQuery.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbQueryShift, Me.tss1, Me.tsbQueryRmStat, Me.tss2})
        Me.tlsSettingQuery.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tlsSettingQuery.Location = New System.Drawing.Point(3, 76)
        Me.tlsSettingQuery.Name = "tlsSettingQuery"
        Me.tlsSettingQuery.ShowItemToolTips = False
        Me.tlsSettingQuery.Size = New System.Drawing.Size(113, 315)
        Me.tlsSettingQuery.TabIndex = 0
        Me.tlsSettingQuery.Text = "ToolStrip2"
        '
        'tsbQueryShift
        '
        Me.tsbQueryShift.AutoSize = False
        Me.tsbQueryShift.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbQueryShift.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'tsbQueryRmStat
        '
        Me.tsbQueryRmStat.AutoSize = False
        Me.tsbQueryRmStat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbQueryRmStat.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbQueryRmStat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQueryRmStat.Name = "tsbQueryRmStat"
        Me.tsbQueryRmStat.Size = New System.Drawing.Size(120, 30)
        Me.tsbQueryRmStat.Text = "Room Status Query"
        Me.tsbQueryRmStat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.Label11.Location = New System.Drawing.Point(4, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 45)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Settings Query"
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
        Me.lblClose.TabIndex = 2
        Me.lblClose.TabStop = True
        Me.lblClose.Text = "Close"
        '
        'frmQuerySettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbcSettingsQuery)
        Me.Controls.Add(Me.tlsSettingQuery)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 80)
        Me.Name = "frmQuerySettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SLU Hotel"
        Me.tbcSettingsQuery.ResumeLayout(False)
        Me.tbpRoomRates.ResumeLayout(False)
        Me.tbpRoomRates.PerformLayout()
        CType(Me.dgvRoomRates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvAmenities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlsSettingQuery.ResumeLayout(False)
        Me.tlsSettingQuery.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbcSettingsQuery As System.Windows.Forms.TabControl
    Friend WithEvents tbpRoomRates As System.Windows.Forms.TabPage
    Friend WithEvents btnViewRoom As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboRoomRateType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblFDOName As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents tlsSettingQuery As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbQueryShift As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbQueryRmStat As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvRoomRates As System.Windows.Forms.DataGridView
    Friend WithEvents cboDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvAmenities As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents cboRoomNumber As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalResult As System.Windows.Forms.Label
    Friend WithEvents btnAmenitiesShow As System.Windows.Forms.Button
    Friend WithEvents txtAmountFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountTo As System.Windows.Forms.TextBox
    Friend WithEvents lblClose As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
