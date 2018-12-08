<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomRack
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.tsbRoomMaintenance = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbGuestSearch = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.lvwRooms = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader
        Me.imgLargeRooms = New System.Windows.Forms.ImageList(Me.components)
        Me.imgSmallRoom = New System.Windows.Forms.ImageList(Me.components)
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.lblDescription = New System.Windows.Forms.Label
        Me.cboRoomType = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboFeatures = New System.Windows.Forms.ComboBox
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtOccupants = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboView = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbcInformation = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblDesc = New System.Windows.Forms.Label
        Me.lbxFeatures = New System.Windows.Forms.ListBox
        Me.lblAmount = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.lblOccupants = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.lblRoomNo = New System.Windows.Forms.Label
        Me.lblTelNo = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblFloor = New System.Windows.Forms.Label
        Me.lblRoomType = New System.Windows.Forms.Label
        Me.lblView = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.dgvReservationsApplied = New System.Windows.Forms.DataGridView
        Me.cmsReservation = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsPayment = New System.Windows.Forms.ToolStripMenuItem
        Me.cmsRegister = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.dgvRegistrations = New System.Windows.Forms.DataGridView
        Me.cmsRegistration = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmFolio = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmPayment = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmDeparture = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmUpdateRegistration = New System.Windows.Forms.ToolStripMenuItem
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label26 = New System.Windows.Forms.Label
        Me.lblCount = New System.Windows.Forms.Label
        Me.cmsVacant = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmReservation = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmRegistration = New System.Windows.Forms.ToolStripMenuItem
        Me.lblTotalRooms = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.chkLarge = New System.Windows.Forms.CheckBox
        Me.lblClose = New System.Windows.Forms.LinkLabel
        Me.chkViewAll = New System.Windows.Forms.CheckBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label12 = New System.Windows.Forms.Label
        Me.ToolStrip2.SuspendLayout()
        Me.tbcInformation.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvReservationsApplied, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsReservation.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvRegistrations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsRegistration.SuspendLayout()
        Me.cmsVacant.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuestSearch, Me.ToolStripSeparator2, Me.tsbRoomMaintenance, Me.ToolStripSeparator3})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(9, 79)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(105, 310)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbRoomMaintenance
        '
        Me.tsbRoomMaintenance.AutoSize = False
        Me.tsbRoomMaintenance.AutoToolTip = False
        Me.tsbRoomMaintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsbRoomMaintenance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbRoomMaintenance.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRoomMaintenance.Name = "tsbRoomMaintenance"
        Me.tsbRoomMaintenance.Size = New System.Drawing.Size(120, 30)
        Me.tsbRoomMaintenance.Text = "Room Maintenance"
        Me.tsbRoomMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(103, 6)
        '
        'tsbGuestSearch
        '
        Me.tsbGuestSearch.AutoSize = False
        Me.tsbGuestSearch.AutoToolTip = False
        Me.tsbGuestSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsbGuestSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGuestSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuestSearch.Name = "tsbGuestSearch"
        Me.tsbGuestSearch.Size = New System.Drawing.Size(120, 30)
        Me.tsbGuestSearch.Text = "Guest Search"
        Me.tsbGuestSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(103, 6)
        '
        'lvwRooms
        '
        Me.lvwRooms.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lvwRooms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lvwRooms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwRooms.HideSelection = False
        Me.lvwRooms.LargeImageList = Me.imgLargeRooms
        Me.lvwRooms.Location = New System.Drawing.Point(0, 101)
        Me.lvwRooms.MultiSelect = False
        Me.lvwRooms.Name = "lvwRooms"
        Me.lvwRooms.Size = New System.Drawing.Size(843, 255)
        Me.lvwRooms.SmallImageList = Me.imgSmallRoom
        Me.lvwRooms.TabIndex = 1
        Me.lvwRooms.UseCompatibleStateImageBehavior = False
        Me.lvwRooms.View = System.Windows.Forms.View.SmallIcon
        '
        'imgLargeRooms
        '
        Me.imgLargeRooms.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imgLargeRooms.ImageSize = New System.Drawing.Size(50, 50)
        Me.imgLargeRooms.TransparentColor = System.Drawing.Color.Transparent
        '
        'imgSmallRoom
        '
        Me.imgSmallRoom.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imgSmallRoom.ImageSize = New System.Drawing.Size(25, 25)
        Me.imgSmallRoom.TransparentColor = System.Drawing.Color.Transparent
        '
        'txtDescription
        '
        Me.txtDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDescription.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(94, 68)
        Me.txtDescription.MaxLength = 200
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(193, 23)
        Me.txtDescription.TabIndex = 6
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(10, 69)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(83, 18)
        Me.lblDescription.TabIndex = 5
        Me.lblDescription.Text = "&Description:"
        '
        'cboRoomType
        '
        Me.cboRoomType.DisplayMember = "RMType"
        Me.cboRoomType.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRoomType.FormattingEnabled = True
        Me.cboRoomType.Location = New System.Drawing.Point(94, 6)
        Me.cboRoomType.MaxLength = 50
        Me.cboRoomType.Name = "cboRoomType"
        Me.cboRoomType.Size = New System.Drawing.Size(193, 26)
        Me.cboRoomType.TabIndex = 2
        Me.cboRoomType.ValueMember = "RMType"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(10, 11)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 18)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Room &Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "&Features:"
        '
        'cboFeatures
        '
        Me.cboFeatures.DisplayMember = "RMType"
        Me.cboFeatures.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFeatures.FormattingEnabled = True
        Me.cboFeatures.Location = New System.Drawing.Point(94, 36)
        Me.cboFeatures.MaxLength = 50
        Me.cboFeatures.Name = "cboFeatures"
        Me.cboFeatures.Size = New System.Drawing.Size(193, 26)
        Me.cboFeatures.TabIndex = 4
        Me.cboFeatures.ValueMember = "RMType"
        '
        'cboStatus
        '
        Me.cboStatus.DisplayMember = "RMType"
        Me.cboStatus.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Registered", "Reserved", "Vacant"})
        Me.cboStatus.Location = New System.Drawing.Point(380, 6)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(135, 26)
        Me.cboStatus.TabIndex = 8
        Me.cboStatus.Text = "VACANT"
        Me.cboStatus.ValueMember = "RMType"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "&Status:"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(576, 8)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(173, 23)
        Me.dtpDateFrom.TabIndex = 14
        Me.dtpDateFrom.Value = New Date(2007, 2, 22, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(535, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 18)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "&To:"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(576, 36)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(173, 23)
        Me.dtpDateTo.TabIndex = 16
        Me.dtpDateTo.Value = New Date(2007, 2, 22, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(535, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "&From:"
        '
        'txtOccupants
        '
        Me.txtOccupants.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtOccupants.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccupants.Location = New System.Drawing.Point(380, 70)
        Me.txtOccupants.MaxLength = 10
        Me.txtOccupants.Name = "txtOccupants"
        Me.txtOccupants.Size = New System.Drawing.Size(135, 23)
        Me.txtOccupants.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(300, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "&Occupants:"
        '
        'cboView
        '
        Me.cboView.DisplayMember = "RMType"
        Me.cboView.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboView.FormattingEnabled = True
        Me.cboView.Location = New System.Drawing.Point(379, 38)
        Me.cboView.MaxLength = 30
        Me.cboView.Name = "cboView"
        Me.cboView.Size = New System.Drawing.Size(135, 26)
        Me.cboView.TabIndex = 10
        Me.cboView.ValueMember = "RMType"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(300, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "&View:"
        '
        'tbcInformation
        '
        Me.tbcInformation.Controls.Add(Me.TabPage1)
        Me.tbcInformation.Controls.Add(Me.TabPage2)
        Me.tbcInformation.Controls.Add(Me.TabPage3)
        Me.tbcInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcInformation.Location = New System.Drawing.Point(0, 0)
        Me.tbcInformation.Name = "tbcInformation"
        Me.tbcInformation.SelectedIndex = 0
        Me.tbcInformation.Size = New System.Drawing.Size(843, 232)
        Me.tbcInformation.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.lblDesc)
        Me.TabPage1.Controls.Add(Me.lbxFeatures)
        Me.TabPage1.Controls.Add(Me.lblAmount)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.lblOccupants)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.lblRoomNo)
        Me.TabPage1.Controls.Add(Me.lblTelNo)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.lblFloor)
        Me.TabPage1.Controls.Add(Me.lblRoomType)
        Me.TabPage1.Controls.Add(Me.lblView)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(835, 201)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Room Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(6, 174)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(467, 16)
        Me.Label13.TabIndex = 291
        Me.Label13.Text = "Right click on the list to determine the transactions that can be done to the cho" & _
            "osen room."
        '
        'lblDesc
        '
        Me.lblDesc.AutoEllipsis = True
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(102, 140)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(289, 28)
        Me.lblDesc.TabIndex = 9
        Me.lblDesc.Text = "<NONE>"
        '
        'lbxFeatures
        '
        Me.lbxFeatures.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxFeatures.FormattingEnabled = True
        Me.lbxFeatures.ItemHeight = 18
        Me.lbxFeatures.Location = New System.Drawing.Point(507, 114)
        Me.lbxFeatures.Name = "lbxFeatures"
        Me.lbxFeatures.Size = New System.Drawing.Size(307, 76)
        Me.lbxFeatures.TabIndex = 17
        '
        'lblAmount
        '
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(504, 79)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(241, 20)
        Me.lblAmount.TabIndex = 15
        Me.lblAmount.Text = "<NONE>"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(396, 78)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(60, 18)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "Amount:"
        '
        'lblOccupants
        '
        Me.lblOccupants.BackColor = System.Drawing.Color.Transparent
        Me.lblOccupants.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccupants.Location = New System.Drawing.Point(504, 51)
        Me.lblOccupants.Name = "lblOccupants"
        Me.lblOccupants.Size = New System.Drawing.Size(241, 20)
        Me.lblOccupants.TabIndex = 13
        Me.lblOccupants.Text = "<NONE>"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(396, 49)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(78, 18)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Occupants:"
        '
        'lblRoomNo
        '
        Me.lblRoomNo.BackColor = System.Drawing.Color.Transparent
        Me.lblRoomNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomNo.Location = New System.Drawing.Point(102, 20)
        Me.lblRoomNo.Name = "lblRoomNo"
        Me.lblRoomNo.Size = New System.Drawing.Size(217, 20)
        Me.lblRoomNo.TabIndex = 1
        Me.lblRoomNo.Text = "<NONE>"
        '
        'lblTelNo
        '
        Me.lblTelNo.BackColor = System.Drawing.Color.Transparent
        Me.lblTelNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelNo.Location = New System.Drawing.Point(504, 23)
        Me.lblTelNo.Name = "lblTelNo"
        Me.lblTelNo.Size = New System.Drawing.Size(241, 20)
        Me.lblTelNo.TabIndex = 11
        Me.lblTelNo.Text = "<NONE>"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(396, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Features:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Description:"
        '
        'lblFloor
        '
        Me.lblFloor.BackColor = System.Drawing.Color.Transparent
        Me.lblFloor.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFloor.Location = New System.Drawing.Point(102, 50)
        Me.lblFloor.Name = "lblFloor"
        Me.lblFloor.Size = New System.Drawing.Size(217, 20)
        Me.lblFloor.TabIndex = 3
        Me.lblFloor.Text = "<NONE>"
        '
        'lblRoomType
        '
        Me.lblRoomType.BackColor = System.Drawing.Color.Transparent
        Me.lblRoomType.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomType.Location = New System.Drawing.Point(102, 110)
        Me.lblRoomType.Name = "lblRoomType"
        Me.lblRoomType.Size = New System.Drawing.Size(217, 20)
        Me.lblRoomType.TabIndex = 7
        Me.lblRoomType.Text = "<NONE>"
        '
        'lblView
        '
        Me.lblView.BackColor = System.Drawing.Color.Transparent
        Me.lblView.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblView.Location = New System.Drawing.Point(102, 80)
        Me.lblView.Name = "lblView"
        Me.lblView.Size = New System.Drawing.Size(217, 20)
        Me.lblView.TabIndex = 5
        Me.lblView.Text = "<NONE>"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(15, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 18)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Room No.:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(396, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 18)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Telephone No.:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 18)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Floor:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 110)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 18)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Room Type:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 18)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "View:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvReservationsApplied)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(835, 206)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Reservations"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvReservationsApplied
        '
        Me.dgvReservationsApplied.AllowUserToAddRows = False
        Me.dgvReservationsApplied.AllowUserToDeleteRows = False
        Me.dgvReservationsApplied.AllowUserToOrderColumns = True
        Me.dgvReservationsApplied.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvReservationsApplied.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReservationsApplied.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvReservationsApplied.ContextMenuStrip = Me.cmsReservation
        Me.dgvReservationsApplied.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReservationsApplied.Location = New System.Drawing.Point(3, 3)
        Me.dgvReservationsApplied.MultiSelect = False
        Me.dgvReservationsApplied.Name = "dgvReservationsApplied"
        Me.dgvReservationsApplied.ReadOnly = True
        Me.dgvReservationsApplied.RowHeadersVisible = False
        Me.dgvReservationsApplied.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservationsApplied.Size = New System.Drawing.Size(829, 200)
        Me.dgvReservationsApplied.TabIndex = 165
        '
        'cmsReservation
        '
        Me.cmsReservation.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsReservation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsPayment, Me.cmsRegister})
        Me.cmsReservation.Name = "cmsVacant"
        Me.cmsReservation.Size = New System.Drawing.Size(133, 48)
        '
        'cmsPayment
        '
        Me.cmsPayment.Image = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.ParentBilling
        Me.cmsPayment.Name = "cmsPayment"
        Me.cmsPayment.Size = New System.Drawing.Size(132, 22)
        Me.cmsPayment.Text = "Billing"
        '
        'cmsRegister
        '
        Me.cmsRegister.Image = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.ParentRegistration
        Me.cmsRegister.Name = "cmsRegister"
        Me.cmsRegister.Size = New System.Drawing.Size(132, 22)
        Me.cmsRegister.Text = "Register"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvRegistrations)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(835, 206)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Registration Information"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvRegistrations
        '
        Me.dgvRegistrations.AllowUserToAddRows = False
        Me.dgvRegistrations.AllowUserToDeleteRows = False
        Me.dgvRegistrations.AllowUserToOrderColumns = True
        Me.dgvRegistrations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvRegistrations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistrations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRegistrations.ContextMenuStrip = Me.cmsRegistration
        Me.dgvRegistrations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistrations.Location = New System.Drawing.Point(0, 0)
        Me.dgvRegistrations.MultiSelect = False
        Me.dgvRegistrations.Name = "dgvRegistrations"
        Me.dgvRegistrations.ReadOnly = True
        Me.dgvRegistrations.RowHeadersVisible = False
        Me.dgvRegistrations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRegistrations.Size = New System.Drawing.Size(835, 206)
        Me.dgvRegistrations.TabIndex = 166
        '
        'cmsRegistration
        '
        Me.cmsRegistration.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsRegistration.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFolio, Me.tsmPayment, Me.ToolStripSeparator4, Me.tsmDeparture, Me.ToolStripSeparator1, Me.tsmUpdateRegistration})
        Me.cmsRegistration.Name = "cmsVacant"
        Me.cmsRegistration.Size = New System.Drawing.Size(201, 104)
        '
        'tsmFolio
        '
        Me.tsmFolio.Image = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.ParentGuestFolio
        Me.tsmFolio.Name = "tsmFolio"
        Me.tsmFolio.Size = New System.Drawing.Size(200, 22)
        Me.tsmFolio.Text = "View Guest Folio"
        '
        'tsmPayment
        '
        Me.tsmPayment.Image = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.ParentBilling
        Me.tsmPayment.Name = "tsmPayment"
        Me.tsmPayment.Size = New System.Drawing.Size(200, 22)
        Me.tsmPayment.Text = "Billing"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(197, 6)
        '
        'tsmDeparture
        '
        Me.tsmDeparture.Image = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.ParentDeparture
        Me.tsmDeparture.Name = "tsmDeparture"
        Me.tsmDeparture.Size = New System.Drawing.Size(200, 22)
        Me.tsmDeparture.Text = "Departure"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(197, 6)
        '
        'tsmUpdateRegistration
        '
        Me.tsmUpdateRegistration.Image = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.ParentRegistration
        Me.tsmUpdateRegistration.Name = "tsmUpdateRegistration"
        Me.tsmUpdateRegistration.Size = New System.Drawing.Size(200, 22)
        Me.tsmUpdateRegistration.Text = "Update Registration"
        '
        'btnSearch
        '
        Me.btnSearch.AutoSize = True
        Me.btnSearch.Location = New System.Drawing.Point(779, 69)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(60, 28)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(560, 3)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(47, 18)
        Me.Label26.TabIndex = 259
        Me.Label26.Text = "Count:"
        '
        'lblCount
        '
        Me.lblCount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCount.AutoSize = True
        Me.lblCount.BackColor = System.Drawing.Color.Transparent
        Me.lblCount.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(613, 3)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(15, 18)
        Me.lblCount.TabIndex = 260
        Me.lblCount.Text = "0"
        '
        'cmsVacant
        '
        Me.cmsVacant.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmsVacant.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmReservation, Me.tsmRegistration})
        Me.cmsVacant.Name = "cmsVacant"
        Me.cmsVacant.Size = New System.Drawing.Size(133, 48)
        '
        'tsmReservation
        '
        Me.tsmReservation.Image = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.ParentReservation
        Me.tsmReservation.Name = "tsmReservation"
        Me.tsmReservation.Size = New System.Drawing.Size(132, 22)
        Me.tsmReservation.Text = "Reserve"
        '
        'tsmRegistration
        '
        Me.tsmRegistration.Image = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.ParentRegistration
        Me.tsmRegistration.Name = "tsmRegistration"
        Me.tsmRegistration.Size = New System.Drawing.Size(132, 22)
        Me.tsmRegistration.Text = "Register"
        '
        'lblTotalRooms
        '
        Me.lblTotalRooms.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotalRooms.AutoSize = True
        Me.lblTotalRooms.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalRooms.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRooms.Location = New System.Drawing.Point(783, 3)
        Me.lblTotalRooms.Name = "lblTotalRooms"
        Me.lblTotalRooms.Size = New System.Drawing.Size(15, 18)
        Me.lblTotalRooms.TabIndex = 262
        Me.lblTotalRooms.Text = "0"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(695, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 18)
        Me.Label14.TabIndex = 261
        Me.Label14.Text = "Total Rooms:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkLarge)
        Me.Panel2.Controls.Add(Me.lblClose)
        Me.Panel2.Controls.Add(Me.chkViewAll)
        Me.Panel2.Controls.Add(Me.cboRoomType)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.cboFeatures)
        Me.Panel2.Controls.Add(Me.txtOccupants)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cboView)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.dtpDateFrom)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.dtpDateTo)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtDescription)
        Me.Panel2.Controls.Add(Me.cboStatus)
        Me.Panel2.Controls.Add(Me.lblDescription)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(843, 101)
        Me.Panel2.TabIndex = 0
        '
        'chkLarge
        '
        Me.chkLarge.AutoSize = True
        Me.chkLarge.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLarge.Location = New System.Drawing.Point(654, 71)
        Me.chkLarge.Name = "chkLarge"
        Me.chkLarge.Size = New System.Drawing.Size(94, 22)
        Me.chkLarge.TabIndex = 19
        Me.chkLarge.Text = "&Large View"
        Me.chkLarge.UseVisualStyleBackColor = True
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblClose.Location = New System.Drawing.Point(803, 2)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(39, 18)
        Me.lblClose.TabIndex = 0
        Me.lblClose.TabStop = True
        Me.lblClose.Text = "Close"
        '
        'chkViewAll
        '
        Me.chkViewAll.AutoSize = True
        Me.chkViewAll.Checked = True
        Me.chkViewAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkViewAll.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkViewAll.Location = New System.Drawing.Point(531, 71)
        Me.chkViewAll.Name = "chkViewAll"
        Me.chkViewAll.Size = New System.Drawing.Size(119, 22)
        Me.chkViewAll.TabIndex = 17
        Me.chkViewAll.Text = "View &All Rooms"
        Me.chkViewAll.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(139, 13)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lvwRooms)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblTotalRooms)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCount)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label26)
        Me.SplitContainer1.Panel2.Controls.Add(Me.tbcInformation)
        Me.SplitContainer1.Size = New System.Drawing.Size(845, 596)
        Me.SplitContainer1.SplitterDistance = 358
        Me.SplitContainer1.TabIndex = 264
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 68)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Room Rack"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRoomRack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 80)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmRoomRack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SLU Hotel"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.tbcInformation.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvReservationsApplied, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsReservation.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvRegistrations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsRegistration.ResumeLayout(False)
        Me.cmsVacant.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Public WithEvents tsbRoomMaintenance As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lvwRooms As System.Windows.Forms.ListView
    Private WithEvents txtDescription As System.Windows.Forms.TextBox
    Private WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents cboRoomType As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboFeatures As System.Windows.Forms.ComboBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents txtOccupants As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboView As System.Windows.Forms.ComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbcInformation As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblOccupants As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblRoomNo As System.Windows.Forms.Label
    Friend WithEvents lblTelNo As System.Windows.Forms.Label
    Friend WithEvents lblFloor As System.Windows.Forms.Label
    Friend WithEvents lblRoomType As System.Windows.Forms.Label
    Friend WithEvents lblView As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents lbxFeatures As System.Windows.Forms.ListBox
    Private WithEvents Label26 As System.Windows.Forms.Label
    Private WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents dgvReservationsApplied As System.Windows.Forms.DataGridView
    Friend WithEvents imgSmallRoom As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgvRegistrations As System.Windows.Forms.DataGridView
    Friend WithEvents cmsVacant As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsReservation As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsRegistration As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmReservation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmRegistration As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPayment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsRegister As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmFolio As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmPayment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDeparture As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmUpdateRegistration As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents lblTotalRooms As System.Windows.Forms.Label
    Private WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents chkViewAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.LinkLabel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents tsbGuestSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkLarge As System.Windows.Forms.CheckBox
    Friend WithEvents imgLargeRooms As System.Windows.Forms.ImageList
End Class
