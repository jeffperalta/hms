<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemDatabase_parent
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
        Me.lblReq = New System.Windows.Forms.Label
        Me.btnTest = New System.Windows.Forms.Button
        Me.btnBrowsePath = New System.Windows.Forms.Button
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.chkSetAsDefault = New System.Windows.Forms.CheckBox
        Me.gbxInput = New System.Windows.Forms.GroupBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtHotelName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.dgvListOfDatabase = New System.Windows.Forms.DataGridView
        Me.gbxListOfDatabase = New System.Windows.Forms.GroupBox
        Me.btnCreateNewDatabase = New System.Windows.Forms.Button
        Me.lblCount = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnAddnew = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.tsActivities = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.lblClose = New System.Windows.Forms.LinkLabel
        Me.btnClose = New System.Windows.Forms.Button
        Me.gbxInput.SuspendLayout()
        CType(Me.dgvListOfDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxListOfDatabase.SuspendLayout()
        Me.tsActivities.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblReq
        '
        Me.lblReq.AutoSize = True
        Me.lblReq.BackColor = System.Drawing.Color.Transparent
        Me.lblReq.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReq.ForeColor = System.Drawing.Color.Red
        Me.lblReq.Location = New System.Drawing.Point(138, 567)
        Me.lblReq.Name = "lblReq"
        Me.lblReq.Size = New System.Drawing.Size(260, 16)
        Me.lblReq.TabIndex = 0
        Me.lblReq.Text = "Restart the application to apply the new settings."
        '
        'btnTest
        '
        Me.btnTest.AutoSize = True
        Me.btnTest.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.Location = New System.Drawing.Point(621, 103)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(78, 28)
        Me.btnTest.TabIndex = 7
        Me.btnTest.Text = "&Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'btnBrowsePath
        '
        Me.btnBrowsePath.AutoSize = True
        Me.btnBrowsePath.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowsePath.Location = New System.Drawing.Point(755, 30)
        Me.btnBrowsePath.Name = "btnBrowsePath"
        Me.btnBrowsePath.Size = New System.Drawing.Size(36, 28)
        Me.btnBrowsePath.TabIndex = 3
        Me.btnBrowsePath.Text = "..."
        Me.btnBrowsePath.UseVisualStyleBackColor = True
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.FileName = "OpenFileDialog1"
        '
        'chkSetAsDefault
        '
        Me.chkSetAsDefault.AutoSize = True
        Me.chkSetAsDefault.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSetAsDefault.Location = New System.Drawing.Point(130, 89)
        Me.chkSetAsDefault.Name = "chkSetAsDefault"
        Me.chkSetAsDefault.Size = New System.Drawing.Size(167, 22)
        Me.chkSetAsDefault.TabIndex = 6
        Me.chkSetAsDefault.Text = "Set as &Default Database"
        Me.chkSetAsDefault.UseVisualStyleBackColor = True
        '
        'gbxInput
        '
        Me.gbxInput.BackColor = System.Drawing.Color.Transparent
        Me.gbxInput.Controls.Add(Me.btnTest)
        Me.gbxInput.Controls.Add(Me.btnBrowsePath)
        Me.gbxInput.Controls.Add(Me.chkSetAsDefault)
        Me.gbxInput.Controls.Add(Me.btnCancel)
        Me.gbxInput.Controls.Add(Me.btnSave)
        Me.gbxInput.Controls.Add(Me.txtHotelName)
        Me.gbxInput.Controls.Add(Me.Label3)
        Me.gbxInput.Controls.Add(Me.txtPath)
        Me.gbxInput.Controls.Add(Me.Label1)
        Me.gbxInput.Controls.Add(Me.Label4)
        Me.gbxInput.Controls.Add(Me.Label20)
        Me.gbxInput.Enabled = False
        Me.gbxInput.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxInput.Location = New System.Drawing.Point(138, 414)
        Me.gbxInput.Name = "gbxInput"
        Me.gbxInput.Size = New System.Drawing.Size(844, 144)
        Me.gbxInput.TabIndex = 2
        Me.gbxInput.TabStop = False
        Me.gbxInput.Text = "Input Fields"
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(774, 103)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 28)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(704, 103)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(64, 28)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtHotelName
        '
        Me.txtHotelName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHotelName.Location = New System.Drawing.Point(130, 60)
        Me.txtHotelName.MaxLength = 50
        Me.txtHotelName.Name = "txtHotelName"
        Me.txtHotelName.Size = New System.Drawing.Size(619, 23)
        Me.txtHotelName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hotel &Name"
        '
        'txtPath
        '
        Me.txtPath.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.Location = New System.Drawing.Point(130, 31)
        Me.txtPath.MaxLength = 1000
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(619, 23)
        Me.txtPath.TabIndex = 2
        Me.txtPath.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Path"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(34, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "*"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(78, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 19)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "*"
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(774, 352)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(64, 28)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dgvListOfDatabase
        '
        Me.dgvListOfDatabase.AllowUserToAddRows = False
        Me.dgvListOfDatabase.AllowUserToDeleteRows = False
        Me.dgvListOfDatabase.AllowUserToOrderColumns = True
        Me.dgvListOfDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvListOfDatabase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvListOfDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListOfDatabase.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvListOfDatabase.Location = New System.Drawing.Point(3, 19)
        Me.dgvListOfDatabase.MultiSelect = False
        Me.dgvListOfDatabase.Name = "dgvListOfDatabase"
        Me.dgvListOfDatabase.ReadOnly = True
        Me.dgvListOfDatabase.RowHeadersVisible = False
        Me.dgvListOfDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListOfDatabase.Size = New System.Drawing.Size(841, 329)
        Me.dgvListOfDatabase.TabIndex = 0
        '
        'gbxListOfDatabase
        '
        Me.gbxListOfDatabase.BackColor = System.Drawing.Color.Transparent
        Me.gbxListOfDatabase.Controls.Add(Me.btnCreateNewDatabase)
        Me.gbxListOfDatabase.Controls.Add(Me.lblCount)
        Me.gbxListOfDatabase.Controls.Add(Me.Label2)
        Me.gbxListOfDatabase.Controls.Add(Me.btnDelete)
        Me.gbxListOfDatabase.Controls.Add(Me.btnAddnew)
        Me.gbxListOfDatabase.Controls.Add(Me.btnEdit)
        Me.gbxListOfDatabase.Controls.Add(Me.dgvListOfDatabase)
        Me.gbxListOfDatabase.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxListOfDatabase.Location = New System.Drawing.Point(138, 25)
        Me.gbxListOfDatabase.Name = "gbxListOfDatabase"
        Me.gbxListOfDatabase.Size = New System.Drawing.Size(847, 386)
        Me.gbxListOfDatabase.TabIndex = 1
        Me.gbxListOfDatabase.TabStop = False
        Me.gbxListOfDatabase.Text = "List of Databases"
        '
        'btnCreateNewDatabase
        '
        Me.btnCreateNewDatabase.AutoSize = True
        Me.btnCreateNewDatabase.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateNewDatabase.Location = New System.Drawing.Point(445, 352)
        Me.btnCreateNewDatabase.Name = "btnCreateNewDatabase"
        Me.btnCreateNewDatabase.Size = New System.Drawing.Size(150, 28)
        Me.btnCreateNewDatabase.TabIndex = 1
        Me.btnCreateNewDatabase.Text = "&Create New Database"
        Me.btnCreateNewDatabase.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(109, 357)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(15, 18)
        Me.lblCount.TabIndex = 2
        Me.lblCount.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No of Database:"
        '
        'btnAddnew
        '
        Me.btnAddnew.AutoSize = True
        Me.btnAddnew.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddnew.Location = New System.Drawing.Point(601, 352)
        Me.btnAddnew.Name = "btnAddnew"
        Me.btnAddnew.Size = New System.Drawing.Size(98, 28)
        Me.btnAddnew.TabIndex = 2
        Me.btnAddnew.Text = "&Add Existing"
        Me.btnAddnew.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(705, 352)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(63, 28)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(138, 585)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "NOTE: Fields with * are required." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 61)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Database Settings"
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
        Me.tsActivities.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator3})
        Me.tsActivities.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsActivities.Location = New System.Drawing.Point(1, 80)
        Me.tsActivities.Name = "tsActivities"
        Me.tsActivities.Size = New System.Drawing.Size(113, 310)
        Me.tsActivities.TabIndex = 4
        Me.tsActivities.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.AutoToolTip = False
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(120, 30)
        Me.ToolStripButton1.Text = "System Settings"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(111, 6)
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblClose.Location = New System.Drawing.Point(943, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(39, 18)
        Me.lblClose.TabIndex = 5
        Me.lblClose.TabStop = True
        Me.lblClose.Text = "Close"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(912, 565)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(64, 28)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSystemDatabase_parent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.gbxListOfDatabase)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.tsActivities)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblReq)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.gbxInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSystemDatabase_parent"
        Me.Text = "Database Settings"
        Me.gbxInput.ResumeLayout(False)
        Me.gbxInput.PerformLayout()
        CType(Me.dgvListOfDatabase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxListOfDatabase.ResumeLayout(False)
        Me.gbxListOfDatabase.PerformLayout()
        Me.tsActivities.ResumeLayout(False)
        Me.tsActivities.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblReq As System.Windows.Forms.Label
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents btnBrowsePath As System.Windows.Forms.Button
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkSetAsDefault As System.Windows.Forms.CheckBox
    Friend WithEvents gbxInput As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtHotelName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents dgvListOfDatabase As System.Windows.Forms.DataGridView
    Friend WithEvents gbxListOfDatabase As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddnew As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCreateNewDatabase As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tsActivities As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblClose As System.Windows.Forms.LinkLabel
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
