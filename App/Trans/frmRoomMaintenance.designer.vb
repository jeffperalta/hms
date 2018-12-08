<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomMaintenance
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
        Me.Label12 = New System.Windows.Forms.Label
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.tsbRoomRack = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.lblOriginalRemarks = New System.Windows.Forms.Label
        Me.imgRoom = New System.Windows.Forms.ImageList(Me.components)
        Me.lblCount = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.cboView = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtOccupants = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboFeatures = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.lblDescription = New System.Windows.Forms.Label
        Me.cboRoomType = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.lsvRoom = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmClean = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmDirty = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmMaintenance = New System.Windows.Forms.ToolStripMenuItem
        Me.radDetails = New System.Windows.Forms.RadioButton
        Me.radLargeIcons = New System.Windows.Forms.RadioButton
        Me.pnlMaintenanceStatus = New System.Windows.Forms.Panel
        Me.picStatus = New System.Windows.Forms.PictureBox
        Me.radMaintenance = New System.Windows.Forms.RadioButton
        Me.radClean = New System.Windows.Forms.RadioButton
        Me.radDirty = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.lblReq = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblClose = New System.Windows.Forms.LinkLabel
        Me.ToolStrip2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.pnlMaintenanceStatus.SuspendLayout()
        CType(Me.picStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 60)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Room Maintenance"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbRoomRack, Me.ToolStripSeparator3})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(4, 82)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(111, 308)
        Me.ToolStrip2.TabIndex = 27
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbRoomRack
        '
        Me.tsbRoomRack.AutoSize = False
        Me.tsbRoomRack.AutoToolTip = False
        Me.tsbRoomRack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsbRoomRack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbRoomRack.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbRoomRack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRoomRack.Name = "tsbRoomRack"
        Me.tsbRoomRack.Size = New System.Drawing.Size(120, 30)
        Me.tsbRoomRack.Text = "Room Rack"
        Me.tsbRoomRack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(109, 6)
        '
        'lblOriginalRemarks
        '
        Me.lblOriginalRemarks.AutoSize = True
        Me.lblOriginalRemarks.BackColor = System.Drawing.Color.Transparent
        Me.lblOriginalRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOriginalRemarks.Location = New System.Drawing.Point(174, 762)
        Me.lblOriginalRemarks.Name = "lblOriginalRemarks"
        Me.lblOriginalRemarks.Size = New System.Drawing.Size(0, 13)
        Me.lblOriginalRemarks.TabIndex = 144
        Me.lblOriginalRemarks.Visible = False
        '
        'imgRoom
        '
        Me.imgRoom.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imgRoom.ImageSize = New System.Drawing.Size(50, 50)
        Me.imgRoom.TransparentColor = System.Drawing.Color.Transparent
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.BackColor = System.Drawing.Color.Transparent
        Me.lblCount.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(198, 449)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(15, 18)
        Me.lblCount.TabIndex = 18
        Me.lblCount.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(145, 449)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(47, 18)
        Me.Label26.TabIndex = 17
        Me.Label26.Text = "Count:"
        '
        'btnSearch
        '
        Me.btnSearch.AutoSize = True
        Me.btnSearch.Location = New System.Drawing.Point(807, 74)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(60, 28)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cboView
        '
        Me.cboView.DisplayMember = "RMType"
        Me.cboView.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboView.FormattingEnabled = True
        Me.cboView.Location = New System.Drawing.Point(525, 48)
        Me.cboView.MaxLength = 30
        Me.cboView.Name = "cboView"
        Me.cboView.Size = New System.Drawing.Size(204, 26)
        Me.cboView.TabIndex = 10
        Me.cboView.ValueMember = "RMType"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(478, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "&View:"
        '
        'txtOccupants
        '
        Me.txtOccupants.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtOccupants.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccupants.Location = New System.Drawing.Point(525, 78)
        Me.txtOccupants.MaxLength = 5
        Me.txtOccupants.Name = "txtOccupants"
        Me.txtOccupants.Size = New System.Drawing.Size(204, 23)
        Me.txtOccupants.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(445, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "&Occupants:"
        '
        'cboStatus
        '
        Me.cboStatus.DisplayMember = "RMType"
        Me.cboStatus.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Clean", "Dirty", "Maintenance"})
        Me.cboStatus.Location = New System.Drawing.Point(525, 17)
        Me.cboStatus.MaxLength = 50
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(204, 26)
        Me.cboStatus.TabIndex = 8
        Me.cboStatus.ValueMember = "RMType"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(469, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "&Status:"
        '
        'cboFeatures
        '
        Me.cboFeatures.DisplayMember = "RMType"
        Me.cboFeatures.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFeatures.FormattingEnabled = True
        Me.cboFeatures.Location = New System.Drawing.Point(230, 48)
        Me.cboFeatures.MaxLength = 50
        Me.cboFeatures.Name = "cboFeatures"
        Me.cboFeatures.Size = New System.Drawing.Size(193, 26)
        Me.cboFeatures.TabIndex = 4
        Me.cboFeatures.ValueMember = "RMType"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(160, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "&Features:"
        '
        'txtDescription
        '
        Me.txtDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtDescription.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(230, 78)
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
        Me.lblDescription.Location = New System.Drawing.Point(145, 79)
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
        Me.cboRoomType.Location = New System.Drawing.Point(230, 17)
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
        Me.Label25.Location = New System.Drawing.Point(146, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 18)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Room &Type:"
        '
        'lsvRoom
        '
        Me.lsvRoom.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lsvRoom.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lsvRoom.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lsvRoom.FullRowSelect = True
        Me.lsvRoom.GridLines = True
        Me.lsvRoom.HideSelection = False
        Me.lsvRoom.LargeImageList = Me.imgRoom
        Me.lsvRoom.Location = New System.Drawing.Point(140, 107)
        Me.lsvRoom.Name = "lsvRoom"
        Me.lsvRoom.Size = New System.Drawing.Size(842, 339)
        Me.lsvRoom.TabIndex = 16
        Me.lsvRoom.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Room No"
        Me.ColumnHeader1.Width = 89
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Room Type"
        Me.ColumnHeader2.Width = 242
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Current Status"
        Me.ColumnHeader3.Width = 149
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Floor"
        Me.ColumnHeader4.Width = 118
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "View"
        Me.ColumnHeader5.Width = 128
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Telephone No"
        Me.ColumnHeader6.Width = 110
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Occupants"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader7.Width = 81
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Description"
        Me.ColumnHeader8.Width = 172
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Remarks"
        Me.ColumnHeader9.Width = 190
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmClean, Me.tsmDirty, Me.tsmMaintenance})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 70)
        '
        'tsmClean
        '
        Me.tsmClean.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmClean.Image = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Vacant
        Me.tsmClean.Name = "tsmClean"
        Me.tsmClean.Size = New System.Drawing.Size(160, 22)
        Me.tsmClean.Text = "Clean"
        '
        'tsmDirty
        '
        Me.tsmDirty.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmDirty.Image = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Dirty
        Me.tsmDirty.Name = "tsmDirty"
        Me.tsmDirty.Size = New System.Drawing.Size(160, 22)
        Me.tsmDirty.Text = "Dirty"
        '
        'tsmMaintenance
        '
        Me.tsmMaintenance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsmMaintenance.Image = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Construction
        Me.tsmMaintenance.Name = "tsmMaintenance"
        Me.tsmMaintenance.Size = New System.Drawing.Size(160, 22)
        Me.tsmMaintenance.Text = "Maintenance"
        '
        'radDetails
        '
        Me.radDetails.AutoSize = True
        Me.radDetails.BackColor = System.Drawing.Color.Transparent
        Me.radDetails.Location = New System.Drawing.Point(762, 43)
        Me.radDetails.Name = "radDetails"
        Me.radDetails.Size = New System.Drawing.Size(105, 22)
        Me.radDetails.TabIndex = 14
        Me.radDetails.Text = "&Detailed View"
        Me.radDetails.UseVisualStyleBackColor = False
        '
        'radLargeIcons
        '
        Me.radLargeIcons.AutoSize = True
        Me.radLargeIcons.BackColor = System.Drawing.Color.Transparent
        Me.radLargeIcons.Checked = True
        Me.radLargeIcons.Location = New System.Drawing.Point(762, 18)
        Me.radLargeIcons.Name = "radLargeIcons"
        Me.radLargeIcons.Size = New System.Drawing.Size(93, 22)
        Me.radLargeIcons.TabIndex = 13
        Me.radLargeIcons.TabStop = True
        Me.radLargeIcons.Text = "&Large Icons"
        Me.radLargeIcons.UseVisualStyleBackColor = False
        '
        'pnlMaintenanceStatus
        '
        Me.pnlMaintenanceStatus.BackColor = System.Drawing.Color.Transparent
        Me.pnlMaintenanceStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMaintenanceStatus.Controls.Add(Me.picStatus)
        Me.pnlMaintenanceStatus.Controls.Add(Me.radMaintenance)
        Me.pnlMaintenanceStatus.Controls.Add(Me.radClean)
        Me.pnlMaintenanceStatus.Controls.Add(Me.radDirty)
        Me.pnlMaintenanceStatus.Location = New System.Drawing.Point(163, 498)
        Me.pnlMaintenanceStatus.Name = "pnlMaintenanceStatus"
        Me.pnlMaintenanceStatus.Size = New System.Drawing.Size(223, 83)
        Me.pnlMaintenanceStatus.TabIndex = 21
        '
        'picStatus
        '
        Me.picStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picStatus.Location = New System.Drawing.Point(143, 3)
        Me.picStatus.Name = "picStatus"
        Me.picStatus.Size = New System.Drawing.Size(75, 75)
        Me.picStatus.TabIndex = 15
        Me.picStatus.TabStop = False
        '
        'radMaintenance
        '
        Me.radMaintenance.AutoSize = True
        Me.radMaintenance.Location = New System.Drawing.Point(16, 6)
        Me.radMaintenance.Name = "radMaintenance"
        Me.radMaintenance.Size = New System.Drawing.Size(110, 22)
        Me.radMaintenance.TabIndex = 0
        Me.radMaintenance.TabStop = True
        Me.radMaintenance.Text = "&MAINTENANCE"
        Me.radMaintenance.UseVisualStyleBackColor = True
        '
        'radClean
        '
        Me.radClean.AutoSize = True
        Me.radClean.Location = New System.Drawing.Point(16, 28)
        Me.radClean.Name = "radClean"
        Me.radClean.Size = New System.Drawing.Size(64, 22)
        Me.radClean.TabIndex = 1
        Me.radClean.TabStop = True
        Me.radClean.Text = "&CLEAN"
        Me.radClean.UseVisualStyleBackColor = True
        '
        'radDirty
        '
        Me.radDirty.AutoSize = True
        Me.radDirty.Location = New System.Drawing.Point(16, 51)
        Me.radDirty.Name = "radDirty"
        Me.radDirty.Size = New System.Drawing.Size(61, 22)
        Me.radDirty.TabIndex = 2
        Me.radDirty.TabStop = True
        Me.radDirty.Text = "&DIRTY"
        Me.radDirty.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(160, 477)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 18)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Set to:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(410, 498)
        Me.txtRemarks.MaxLength = 1000
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(360, 83)
        Me.txtRemarks.TabIndex = 23
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(407, 477)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(64, 18)
        Me.Label35.TabIndex = 22
        Me.Label35.Text = "&Remarks:"
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.Location = New System.Drawing.Point(922, 576)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 28)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblReq
        '
        Me.lblReq.AutoSize = True
        Me.lblReq.BackColor = System.Drawing.Color.Transparent
        Me.lblReq.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReq.ForeColor = System.Drawing.Color.Red
        Me.lblReq.Location = New System.Drawing.Point(137, 588)
        Me.lblReq.Name = "lblReq"
        Me.lblReq.Size = New System.Drawing.Size(173, 16)
        Me.lblReq.TabIndex = 24
        Me.lblReq.Text = "NOTE: Fields with * are required." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(147, 477)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 19)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(320, 588)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(203, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Right Click on the rooms for quick save"
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblClose.Location = New System.Drawing.Point(945, 10)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(39, 18)
        Me.lblClose.TabIndex = 28
        Me.lblClose.TabStop = True
        Me.lblClose.Text = "Close"
        '
        'frmRoomMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.radDetails)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.pnlMaintenanceStatus)
        Me.Controls.Add(Me.radLargeIcons)
        Me.Controls.Add(Me.cboView)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtOccupants)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboStatus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboFeatures)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.cboRoomType)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lsvRoom)
        Me.Controls.Add(Me.lblOriginalRemarks)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.lblReq)
        Me.Controls.Add(Me.Label20)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 80)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmRoomMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SLU Hotel"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.pnlMaintenanceStatus.ResumeLayout(False)
        Me.pnlMaintenanceStatus.PerformLayout()
        CType(Me.picStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Public WithEvents tsbRoomRack As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblOriginalRemarks As System.Windows.Forms.Label
    Friend WithEvents imgRoom As System.Windows.Forms.ImageList
    Private WithEvents lblCount As System.Windows.Forms.Label
    Private WithEvents Label26 As System.Windows.Forms.Label
    Private WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cboView As System.Windows.Forms.ComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents txtOccupants As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboFeatures As System.Windows.Forms.ComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtDescription As System.Windows.Forms.TextBox
    Private WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents cboRoomType As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lsvRoom As System.Windows.Forms.ListView
    Friend WithEvents radDetails As System.Windows.Forms.RadioButton
    Friend WithEvents radLargeIcons As System.Windows.Forms.RadioButton
    Friend WithEvents pnlMaintenanceStatus As System.Windows.Forms.Panel
    Friend WithEvents radMaintenance As System.Windows.Forms.RadioButton
    Friend WithEvents radClean As System.Windows.Forms.RadioButton
    Friend WithEvents radDirty As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Private WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmClean As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmDirty As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmMaintenance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picStatus As System.Windows.Forms.PictureBox
    Friend WithEvents lblReq As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblClose As System.Windows.Forms.LinkLabel
End Class
