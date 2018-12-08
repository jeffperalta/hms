<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomSettings
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
        Me.gbxRooms = New System.Windows.Forms.GroupBox
        Me.cboViewRateName = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboFeatureAndFacility = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblCount = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.chkDisplayAll = New System.Windows.Forms.CheckBox
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.dgvExistingRoom = New System.Windows.Forms.DataGridView
        Me.cboRoomTypeExistingRoom = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.tlsRoomSettings = New System.Windows.Forms.ToolStrip
        Me.tsbSystemSettings = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbRoomRatesAndTypes = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbFeaturesAndFacilities = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbUpdateRates = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnAddSave = New System.Windows.Forms.Button
        Me.cboView = New System.Windows.Forms.ComboBox
        Me.cboFloor = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtTelNo = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtNoOfOccupants = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtRMDescription = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRoomNo = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.gbxInput = New System.Windows.Forms.GroupBox
        Me.lblReq = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.tbcRoomSettings = New System.Windows.Forms.TabControl
        Me.tbpRate = New System.Windows.Forms.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblRate = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.lblCurrentRateName = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.cboRoomType = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lsvRoomRatesAndTypes = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.cmsRooms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmSetAsCurrentRate = New System.Windows.Forms.ToolStripMenuItem
        Me.lblRateNo = New System.Windows.Forms.Label
        Me.tbpFeaturesAndFacilities = New System.Windows.Forms.TabPage
        Me.lsvFeaturesAndFacilities = New System.Windows.Forms.ListView
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader
        Me.lblClose = New System.Windows.Forms.LinkLabel
        Me.gbxRooms.SuspendLayout()
        CType(Me.dgvExistingRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlsRoomSettings.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInput.SuspendLayout()
        Me.tbcRoomSettings.SuspendLayout()
        Me.tbpRate.SuspendLayout()
        Me.cmsRooms.SuspendLayout()
        Me.tbpFeaturesAndFacilities.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxRooms
        '
        Me.gbxRooms.BackColor = System.Drawing.Color.Transparent
        Me.gbxRooms.Controls.Add(Me.cboViewRateName)
        Me.gbxRooms.Controls.Add(Me.Label8)
        Me.gbxRooms.Controls.Add(Me.cboFeatureAndFacility)
        Me.gbxRooms.Controls.Add(Me.Label3)
        Me.gbxRooms.Controls.Add(Me.lblCount)
        Me.gbxRooms.Controls.Add(Me.Label27)
        Me.gbxRooms.Controls.Add(Me.chkDisplayAll)
        Me.gbxRooms.Controls.Add(Me.btnAddNew)
        Me.gbxRooms.Controls.Add(Me.dgvExistingRoom)
        Me.gbxRooms.Controls.Add(Me.cboRoomTypeExistingRoom)
        Me.gbxRooms.Controls.Add(Me.Label20)
        Me.gbxRooms.Controls.Add(Me.btnEdit)
        Me.gbxRooms.Controls.Add(Me.btnDelete)
        Me.gbxRooms.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxRooms.Location = New System.Drawing.Point(140, 23)
        Me.gbxRooms.Name = "gbxRooms"
        Me.gbxRooms.Size = New System.Drawing.Size(841, 583)
        Me.gbxRooms.TabIndex = 1
        Me.gbxRooms.TabStop = False
        Me.gbxRooms.Text = "Existing Rooms"
        '
        'cboViewRateName
        '
        Me.cboViewRateName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboViewRateName.FormattingEnabled = True
        Me.cboViewRateName.Location = New System.Drawing.Point(450, 19)
        Me.cboViewRateName.MaxLength = 50
        Me.cboViewRateName.Name = "cboViewRateName"
        Me.cboViewRateName.Size = New System.Drawing.Size(217, 26)
        Me.cboViewRateName.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(372, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 18)
        Me.Label8.TabIndex = 201
        Me.Label8.Text = "&Rate Name:"
        '
        'cboFeatureAndFacility
        '
        Me.cboFeatureAndFacility.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFeatureAndFacility.FormattingEnabled = True
        Me.cboFeatureAndFacility.Location = New System.Drawing.Point(143, 53)
        Me.cboFeatureAndFacility.MaxLength = 50
        Me.cboFeatureAndFacility.Name = "cboFeatureAndFacility"
        Me.cboFeatureAndFacility.Size = New System.Drawing.Size(216, 26)
        Me.cboFeatureAndFacility.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Feature And Facility:"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(94, 556)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(16, 18)
        Me.lblCount.TabIndex = 198
        Me.lblCount.Text = "0"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 555)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(93, 18)
        Me.Label27.TabIndex = 197
        Me.Label27.Text = "No. of Rooms:"
        '
        'chkDisplayAll
        '
        Me.chkDisplayAll.AutoSize = True
        Me.chkDisplayAll.Checked = True
        Me.chkDisplayAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDisplayAll.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisplayAll.Location = New System.Drawing.Point(375, 53)
        Me.chkDisplayAll.Name = "chkDisplayAll"
        Me.chkDisplayAll.Size = New System.Drawing.Size(72, 22)
        Me.chkDisplayAll.TabIndex = 5
        Me.chkDisplayAll.Text = "&View All"
        Me.chkDisplayAll.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.AutoSize = True
        Me.btnAddNew.Location = New System.Drawing.Point(622, 549)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(75, 28)
        Me.btnAddNew.TabIndex = 7
        Me.btnAddNew.Text = "&Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'dgvExistingRoom
        '
        Me.dgvExistingRoom.AllowUserToAddRows = False
        Me.dgvExistingRoom.AllowUserToDeleteRows = False
        Me.dgvExistingRoom.AllowUserToOrderColumns = True
        Me.dgvExistingRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvExistingRoom.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvExistingRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExistingRoom.Location = New System.Drawing.Point(7, 86)
        Me.dgvExistingRoom.MultiSelect = False
        Me.dgvExistingRoom.Name = "dgvExistingRoom"
        Me.dgvExistingRoom.ReadOnly = True
        Me.dgvExistingRoom.RowHeadersVisible = False
        Me.dgvExistingRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExistingRoom.Size = New System.Drawing.Size(828, 459)
        Me.dgvExistingRoom.TabIndex = 6
        '
        'cboRoomTypeExistingRoom
        '
        Me.cboRoomTypeExistingRoom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRoomTypeExistingRoom.FormattingEnabled = True
        Me.cboRoomTypeExistingRoom.Location = New System.Drawing.Point(143, 18)
        Me.cboRoomTypeExistingRoom.MaxLength = 50
        Me.cboRoomTypeExistingRoom.Name = "cboRoomTypeExistingRoom"
        Me.cboRoomTypeExistingRoom.Size = New System.Drawing.Size(216, 26)
        Me.cboRoomTypeExistingRoom.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(67, 21)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 18)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "&Room Type:"
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.Location = New System.Drawing.Point(703, 549)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(60, 28)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.Location = New System.Drawing.Point(769, 549)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(66, 28)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
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
        Me.tlsRoomSettings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSystemSettings, Me.ToolStripSeparator4, Me.tsbRoomRatesAndTypes, Me.ToolStripSeparator1, Me.tsbFeaturesAndFacilities, Me.ToolStripSeparator2, Me.tsbUpdateRates, Me.ToolStripSeparator3})
        Me.tlsRoomSettings.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tlsRoomSettings.Location = New System.Drawing.Point(4, 77)
        Me.tlsRoomSettings.Name = "tlsRoomSettings"
        Me.tlsRoomSettings.Size = New System.Drawing.Size(112, 315)
        Me.tlsRoomSettings.TabIndex = 2
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(110, 6)
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
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(110, 6)
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
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(110, 6)
        '
        'tsbUpdateRates
        '
        Me.tsbUpdateRates.AutoSize = False
        Me.tsbUpdateRates.AutoToolTip = False
        Me.tsbUpdateRates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsbUpdateRates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbUpdateRates.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbUpdateRates.Name = "tsbUpdateRates"
        Me.tsbUpdateRates.Size = New System.Drawing.Size(120, 30)
        Me.tsbUpdateRates.Text = "Update Rates"
        Me.tsbUpdateRates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(110, 6)
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 61)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Room Settings"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 315
        Me.Label5.Text = "None is selected"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(255, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 25)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&List Rooms"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(346, 289)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 25)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "&Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(27, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "&Start Date:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(340, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 25)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "&Show"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(225, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "&End Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMMM dd, yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(281, 23)
        Me.DateTimePicker1.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(126, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "MMMM dd, yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(88, 23)
        Me.DateTimePicker2.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(127, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(260, 54)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "&Select All"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(88, 52)
        Me.ComboBox1.MaxLength = 50
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(20, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "&Room Type:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(5, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(409, 200)
        Me.DataGridView1.TabIndex = 8
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(766, 551)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 28)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddSave
        '
        Me.btnAddSave.AutoSize = True
        Me.btnAddSave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSave.Location = New System.Drawing.Point(700, 551)
        Me.btnAddSave.Name = "btnAddSave"
        Me.btnAddSave.Size = New System.Drawing.Size(60, 28)
        Me.btnAddSave.TabIndex = 14
        Me.btnAddSave.Text = "&Save"
        Me.btnAddSave.UseVisualStyleBackColor = True
        '
        'cboView
        '
        Me.cboView.BackColor = System.Drawing.Color.White
        Me.cboView.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboView.FormattingEnabled = True
        Me.cboView.Location = New System.Drawing.Point(296, 84)
        Me.cboView.MaxLength = 100
        Me.cboView.Name = "cboView"
        Me.cboView.Size = New System.Drawing.Size(177, 26)
        Me.cboView.Sorted = True
        Me.cboView.TabIndex = 322
        '
        'cboFloor
        '
        Me.cboFloor.BackColor = System.Drawing.Color.White
        Me.cboFloor.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFloor.FormattingEnabled = True
        Me.cboFloor.Location = New System.Drawing.Point(296, 50)
        Me.cboFloor.MaxLength = 50
        Me.cboFloor.Name = "cboFloor"
        Me.cboFloor.Size = New System.Drawing.Size(177, 26)
        Me.cboFloor.Sorted = True
        Me.cboFloor.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(495, 52)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 18)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "&Description:"
        '
        'txtTelNo
        '
        Me.txtTelNo.Location = New System.Drawing.Point(108, 84)
        Me.txtTelNo.MaxLength = 30
        Me.txtTelNo.Name = "txtTelNo"
        Me.txtTelNo.Size = New System.Drawing.Size(120, 23)
        Me.txtTelNo.TabIndex = 7
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(56, 87)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 18)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "&Tel No:"
        '
        'txtNoOfOccupants
        '
        Me.txtNoOfOccupants.Location = New System.Drawing.Point(108, 53)
        Me.txtNoOfOccupants.MaxLength = 4
        Me.txtNoOfOccupants.Name = "txtNoOfOccupants"
        Me.txtNoOfOccupants.Size = New System.Drawing.Size(120, 23)
        Me.txtNoOfOccupants.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(33, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 18)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "&Occupants:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(252, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 318
        Me.Label4.Text = "&View:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(253, 53)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 18)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "&Floor:"
        '
        'txtRMDescription
        '
        Me.txtRMDescription.Location = New System.Drawing.Point(577, 49)
        Me.txtRMDescription.MaxLength = 200
        Me.txtRMDescription.Multiline = True
        Me.txtRMDescription.Name = "txtRMDescription"
        Me.txtRMDescription.Size = New System.Drawing.Size(232, 61)
        Me.txtRMDescription.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(400, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOTE: Multiple rooms are delimited by commas"
        '
        'txtRoomNo
        '
        Me.txtRoomNo.Location = New System.Drawing.Point(108, 22)
        Me.txtRoomNo.Name = "txtRoomNo"
        Me.txtRoomNo.Size = New System.Drawing.Size(286, 23)
        Me.txtRoomNo.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(40, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(66, 18)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Room &No:"
        '
        'gbxInput
        '
        Me.gbxInput.BackColor = System.Drawing.Color.Transparent
        Me.gbxInput.Controls.Add(Me.lblReq)
        Me.gbxInput.Controls.Add(Me.Label22)
        Me.gbxInput.Controls.Add(Me.txtRemarks)
        Me.gbxInput.Controls.Add(Me.txtRoomNo)
        Me.gbxInput.Controls.Add(Me.cboView)
        Me.gbxInput.Controls.Add(Me.btnCancel)
        Me.gbxInput.Controls.Add(Me.cboFloor)
        Me.gbxInput.Controls.Add(Me.Label21)
        Me.gbxInput.Controls.Add(Me.btnAddSave)
        Me.gbxInput.Controls.Add(Me.Label1)
        Me.gbxInput.Controls.Add(Me.txtTelNo)
        Me.gbxInput.Controls.Add(Me.txtRMDescription)
        Me.gbxInput.Controls.Add(Me.Label26)
        Me.gbxInput.Controls.Add(Me.Label17)
        Me.gbxInput.Controls.Add(Me.txtNoOfOccupants)
        Me.gbxInput.Controls.Add(Me.Label4)
        Me.gbxInput.Controls.Add(Me.Label13)
        Me.gbxInput.Controls.Add(Me.Label14)
        Me.gbxInput.Controls.Add(Me.Label15)
        Me.gbxInput.Controls.Add(Me.tbcRoomSettings)
        Me.gbxInput.Controls.Add(Me.Label18)
        Me.gbxInput.Enabled = False
        Me.gbxInput.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxInput.Location = New System.Drawing.Point(140, 25)
        Me.gbxInput.Name = "gbxInput"
        Me.gbxInput.Size = New System.Drawing.Size(841, 581)
        Me.gbxInput.TabIndex = 2
        Me.gbxInput.TabStop = False
        Me.gbxInput.Text = "Room Information"
        '
        'lblReq
        '
        Me.lblReq.AutoSize = True
        Me.lblReq.BackColor = System.Drawing.Color.Transparent
        Me.lblReq.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReq.ForeColor = System.Drawing.Color.Red
        Me.lblReq.Location = New System.Drawing.Point(11, 557)
        Me.lblReq.Name = "lblReq"
        Me.lblReq.Size = New System.Drawing.Size(173, 16)
        Me.lblReq.TabIndex = 325
        Me.lblReq.Text = "NOTE: Fields with * are required." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(38, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 18)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "&Remarks:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(108, 117)
        Me.txtRemarks.MaxLength = 200
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(365, 46)
        Me.txtRemarks.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(27, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 19)
        Me.Label14.TabIndex = 323
        Me.Label14.Text = "*"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(22, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 19)
        Me.Label15.TabIndex = 324
        Me.Label15.Text = "*"
        '
        'tbcRoomSettings
        '
        Me.tbcRoomSettings.Controls.Add(Me.tbpRate)
        Me.tbcRoomSettings.Controls.Add(Me.tbpFeaturesAndFacilities)
        Me.tbcRoomSettings.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcRoomSettings.Location = New System.Drawing.Point(4, 173)
        Me.tbcRoomSettings.Name = "tbcRoomSettings"
        Me.tbcRoomSettings.SelectedIndex = 0
        Me.tbcRoomSettings.Size = New System.Drawing.Size(828, 376)
        Me.tbcRoomSettings.TabIndex = 13
        '
        'tbpRate
        '
        Me.tbpRate.Controls.Add(Me.Label7)
        Me.tbpRate.Controls.Add(Me.lblRate)
        Me.tbpRate.Controls.Add(Me.Label24)
        Me.tbpRate.Controls.Add(Me.lblCurrentRateName)
        Me.tbpRate.Controls.Add(Me.Label6)
        Me.tbpRate.Controls.Add(Me.Label23)
        Me.tbpRate.Controls.Add(Me.cboRoomType)
        Me.tbpRate.Controls.Add(Me.Label2)
        Me.tbpRate.Controls.Add(Me.Label16)
        Me.tbpRate.Controls.Add(Me.Label19)
        Me.tbpRate.Controls.Add(Me.lsvRoomRatesAndTypes)
        Me.tbpRate.Controls.Add(Me.lblRateNo)
        Me.tbpRate.Location = New System.Drawing.Point(4, 27)
        Me.tbpRate.Name = "tbpRate"
        Me.tbpRate.Size = New System.Drawing.Size(820, 345)
        Me.tbpRate.TabIndex = 3
        Me.tbpRate.Text = "Room Rates and Types"
        Me.tbpRate.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(112, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(271, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Right click on an item to make it as the current rate"
        '
        'lblRate
        '
        Me.lblRate.AutoEllipsis = True
        Me.lblRate.BackColor = System.Drawing.Color.Transparent
        Me.lblRate.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.Location = New System.Drawing.Point(357, 313)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(113, 18)
        Me.lblRate.TabIndex = 7
        Me.lblRate.Text = "0.00"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(309, 313)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 18)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Rate:"
        '
        'lblCurrentRateName
        '
        Me.lblCurrentRateName.AutoEllipsis = True
        Me.lblCurrentRateName.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentRateName.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentRateName.Location = New System.Drawing.Point(142, 313)
        Me.lblCurrentRateName.Name = "lblCurrentRateName"
        Me.lblCurrentRateName.Size = New System.Drawing.Size(161, 18)
        Me.lblCurrentRateName.TabIndex = 5
        Me.lblCurrentRateName.Text = "NONE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Current Rate Name:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(24, 13)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(80, 18)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Room &Type:"
        '
        'cboRoomType
        '
        Me.cboRoomType.BackColor = System.Drawing.Color.White
        Me.cboRoomType.FormattingEnabled = True
        Me.cboRoomType.Location = New System.Drawing.Point(115, 10)
        Me.cboRoomType.MaxLength = 50
        Me.cboRoomType.Name = "cboRoomType"
        Me.cboRoomType.Size = New System.Drawing.Size(222, 26)
        Me.cboRoomType.Sorted = True
        Me.cboRoomType.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 302
        Me.Label2.Text = "Rates:"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(11, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 19)
        Me.Label16.TabIndex = 324
        Me.Label16.Text = "*"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(14, 43)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(18, 19)
        Me.Label19.TabIndex = 325
        Me.Label19.Text = "*"
        '
        'lsvRoomRatesAndTypes
        '
        Me.lsvRoomRatesAndTypes.CheckBoxes = True
        Me.lsvRoomRatesAndTypes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lsvRoomRatesAndTypes.ContextMenuStrip = Me.cmsRooms
        Me.lsvRoomRatesAndTypes.FullRowSelect = True
        Me.lsvRoomRatesAndTypes.GridLines = True
        Me.lsvRoomRatesAndTypes.Location = New System.Drawing.Point(5, 64)
        Me.lsvRoomRatesAndTypes.MultiSelect = False
        Me.lsvRoomRatesAndTypes.Name = "lsvRoomRatesAndTypes"
        Me.lsvRoomRatesAndTypes.Size = New System.Drawing.Size(814, 235)
        Me.lsvRoomRatesAndTypes.TabIndex = 3
        Me.lsvRoomRatesAndTypes.UseCompatibleStateImageBehavior = False
        Me.lsvRoomRatesAndTypes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Rate Name"
        Me.ColumnHeader1.Width = 131
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Amount"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 110
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Starts on"
        Me.ColumnHeader3.Width = 121
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "End On"
        Me.ColumnHeader4.Width = 122
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "RoomType"
        Me.ColumnHeader5.Width = 130
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Remarks"
        Me.ColumnHeader6.Width = 141
        '
        'cmsRooms
        '
        Me.cmsRooms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmSetAsCurrentRate})
        Me.cmsRooms.Name = "ContextMenuStrip1"
        Me.cmsRooms.ShowImageMargin = False
        Me.cmsRooms.Size = New System.Drawing.Size(206, 26)
        '
        'tsmSetAsCurrentRate
        '
        Me.tsmSetAsCurrentRate.Name = "tsmSetAsCurrentRate"
        Me.tsmSetAsCurrentRate.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.tsmSetAsCurrentRate.Size = New System.Drawing.Size(205, 22)
        Me.tsmSetAsCurrentRate.Text = "Set as the current rate"
        '
        'lblRateNo
        '
        Me.lblRateNo.AutoEllipsis = True
        Me.lblRateNo.BackColor = System.Drawing.Color.Transparent
        Me.lblRateNo.Location = New System.Drawing.Point(704, 271)
        Me.lblRateNo.Name = "lblRateNo"
        Me.lblRateNo.Size = New System.Drawing.Size(113, 18)
        Me.lblRateNo.TabIndex = 332
        '
        'tbpFeaturesAndFacilities
        '
        Me.tbpFeaturesAndFacilities.Controls.Add(Me.lsvFeaturesAndFacilities)
        Me.tbpFeaturesAndFacilities.Location = New System.Drawing.Point(4, 27)
        Me.tbpFeaturesAndFacilities.Name = "tbpFeaturesAndFacilities"
        Me.tbpFeaturesAndFacilities.Size = New System.Drawing.Size(820, 345)
        Me.tbpFeaturesAndFacilities.TabIndex = 2
        Me.tbpFeaturesAndFacilities.Text = "Features and Facilities"
        Me.tbpFeaturesAndFacilities.UseVisualStyleBackColor = True
        '
        'lsvFeaturesAndFacilities
        '
        Me.lsvFeaturesAndFacilities.CheckBoxes = True
        Me.lsvFeaturesAndFacilities.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14})
        Me.lsvFeaturesAndFacilities.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvFeaturesAndFacilities.GridLines = True
        Me.lsvFeaturesAndFacilities.Location = New System.Drawing.Point(0, 0)
        Me.lsvFeaturesAndFacilities.MultiSelect = False
        Me.lsvFeaturesAndFacilities.Name = "lsvFeaturesAndFacilities"
        Me.lsvFeaturesAndFacilities.Size = New System.Drawing.Size(820, 345)
        Me.lsvFeaturesAndFacilities.TabIndex = 204
        Me.lsvFeaturesAndFacilities.UseCompatibleStateImageBehavior = False
        Me.lsvFeaturesAndFacilities.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Name"
        Me.ColumnHeader13.Width = 177
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Remarks"
        Me.ColumnHeader14.Width = 191
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblClose.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.LinkColor = System.Drawing.Color.Black
        Me.lblClose.Location = New System.Drawing.Point(945, 10)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(39, 18)
        Me.lblClose.TabIndex = 3
        Me.lblClose.TabStop = True
        Me.lblClose.Text = "Close"
        '
        'frmRoomSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.tlsRoomSettings)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.gbxRooms)
        Me.Controls.Add(Me.gbxInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 80)
        Me.Name = "frmRoomSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SLU Hotel"
        Me.gbxRooms.ResumeLayout(False)
        Me.gbxRooms.PerformLayout()
        CType(Me.dgvExistingRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlsRoomSettings.ResumeLayout(False)
        Me.tlsRoomSettings.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInput.ResumeLayout(False)
        Me.gbxInput.PerformLayout()
        Me.tbcRoomSettings.ResumeLayout(False)
        Me.tbpRate.ResumeLayout(False)
        Me.tbpRate.PerformLayout()
        Me.cmsRooms.ResumeLayout(False)
        Me.tbpFeaturesAndFacilities.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxRooms As System.Windows.Forms.GroupBox
    Friend WithEvents cboRoomTypeExistingRoom As System.Windows.Forms.ComboBox
    Private WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents tlsRoomSettings As System.Windows.Forms.ToolStrip
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents chkDisplayAll As System.Windows.Forms.CheckBox
    Friend WithEvents dgvExistingRoom As System.Windows.Forms.DataGridView
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents btnAddSave As System.Windows.Forms.Button
    Friend WithEvents cboView As System.Windows.Forms.ComboBox
    Friend WithEvents cboFloor As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtTelNo As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtNoOfOccupants As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtRMDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRoomNo As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents gbxInput As System.Windows.Forms.GroupBox
    Friend WithEvents tbcRoomSettings As System.Windows.Forms.TabControl
    Friend WithEvents tbpFeaturesAndFacilities As System.Windows.Forms.TabPage
    Friend WithEvents tbpRate As System.Windows.Forms.TabPage
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cboRoomType As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboViewRateName As System.Windows.Forms.ComboBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboFeatureAndFacility As System.Windows.Forms.ComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblReq As System.Windows.Forms.Label
    Public WithEvents tsbRoomRatesAndTypes As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents tsbFeaturesAndFacilities As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents lsvRoomRatesAndTypes As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lsvFeaturesAndFacilities As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblCurrentRateName As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblRateNo As System.Windows.Forms.Label
    Friend WithEvents cmsRooms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmSetAsCurrentRate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents tsbUpdateRates As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblClose As System.Windows.Forms.LinkLabel
    Public WithEvents tsbSystemSettings As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
End Class
