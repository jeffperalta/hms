<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomTypeAndRates
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.gbxRates = New System.Windows.Forms.GroupBox
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.lblCount = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.chkRoomRateSelectAll = New System.Windows.Forms.CheckBox
        Me.cboRoomRateRoomType = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.dgvRates = New System.Windows.Forms.DataGridView
        Me.btnClose = New System.Windows.Forms.Button
        Me.gbxInput = New System.Windows.Forms.GroupBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.cboRoomType = New System.Windows.Forms.ComboBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.txtRateName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblReq = New System.Windows.Forms.Label
        Me.gbxRates.SuspendLayout()
        CType(Me.dgvRates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Add/Edit Room Type and Rates"
        '
        'gbxRates
        '
        Me.gbxRates.BackColor = System.Drawing.Color.Transparent
        Me.gbxRates.Controls.Add(Me.btnDelete)
        Me.gbxRates.Controls.Add(Me.btnAddNew)
        Me.gbxRates.Controls.Add(Me.btnEdit)
        Me.gbxRates.Controls.Add(Me.lblCount)
        Me.gbxRates.Controls.Add(Me.Label27)
        Me.gbxRates.Controls.Add(Me.chkRoomRateSelectAll)
        Me.gbxRates.Controls.Add(Me.cboRoomRateRoomType)
        Me.gbxRates.Controls.Add(Me.Label25)
        Me.gbxRates.Controls.Add(Me.dgvRates)
        Me.gbxRates.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxRates.Location = New System.Drawing.Point(17, 66)
        Me.gbxRates.Name = "gbxRates"
        Me.gbxRates.Size = New System.Drawing.Size(767, 328)
        Me.gbxRates.TabIndex = 1
        Me.gbxRates.TabStop = False
        Me.gbxRates.Text = "List of Seasonal and Special Rates:"
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.Location = New System.Drawing.Point(688, 293)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(73, 28)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.AutoSize = True
        Me.btnAddNew.Location = New System.Drawing.Point(530, 293)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(73, 28)
        Me.btnAddNew.TabIndex = 6
        Me.btnAddNew.Text = "&Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.Location = New System.Drawing.Point(609, 293)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(73, 28)
        Me.btnEdit.TabIndex = 7
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(59, 298)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(15, 18)
        Me.lblCount.TabIndex = 5
        Me.lblCount.Text = "0"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 298)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(47, 18)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "Count:"
        '
        'chkRoomRateSelectAll
        '
        Me.chkRoomRateSelectAll.AutoSize = True
        Me.chkRoomRateSelectAll.Checked = True
        Me.chkRoomRateSelectAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRoomRateSelectAll.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRoomRateSelectAll.Location = New System.Drawing.Point(412, 27)
        Me.chkRoomRateSelectAll.Name = "chkRoomRateSelectAll"
        Me.chkRoomRateSelectAll.Size = New System.Drawing.Size(76, 22)
        Me.chkRoomRateSelectAll.TabIndex = 0
        Me.chkRoomRateSelectAll.Text = "&View All"
        Me.chkRoomRateSelectAll.UseVisualStyleBackColor = True
        '
        'cboRoomRateRoomType
        '
        Me.cboRoomRateRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoomRateRoomType.Enabled = False
        Me.cboRoomRateRoomType.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRoomRateRoomType.FormattingEnabled = True
        Me.cboRoomRateRoomType.Location = New System.Drawing.Point(589, 22)
        Me.cboRoomRateRoomType.MaxLength = 50
        Me.cboRoomRateRoomType.Name = "cboRoomRateRoomType"
        Me.cboRoomRateRoomType.Size = New System.Drawing.Size(160, 26)
        Me.cboRoomRateRoomType.TabIndex = 2
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(505, 27)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 18)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "&Room Type:"
        '
        'dgvRates
        '
        Me.dgvRates.AllowUserToAddRows = False
        Me.dgvRates.AllowUserToDeleteRows = False
        Me.dgvRates.AllowUserToOrderColumns = True
        Me.dgvRates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvRates.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRates.Location = New System.Drawing.Point(6, 55)
        Me.dgvRates.MultiSelect = False
        Me.dgvRates.Name = "dgvRates"
        Me.dgvRates.ReadOnly = True
        Me.dgvRates.RowHeadersVisible = False
        Me.dgvRates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRates.Size = New System.Drawing.Size(755, 232)
        Me.dgvRates.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(705, 554)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(73, 28)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'gbxInput
        '
        Me.gbxInput.BackColor = System.Drawing.Color.Transparent
        Me.gbxInput.Controls.Add(Me.Label37)
        Me.gbxInput.Controls.Add(Me.cboRoomType)
        Me.gbxInput.Controls.Add(Me.Label41)
        Me.gbxInput.Controls.Add(Me.Label1)
        Me.gbxInput.Controls.Add(Me.btnCancel)
        Me.gbxInput.Controls.Add(Me.btnSave)
        Me.gbxInput.Controls.Add(Me.Label14)
        Me.gbxInput.Controls.Add(Me.txtRemarks)
        Me.gbxInput.Controls.Add(Me.Label30)
        Me.gbxInput.Controls.Add(Me.Label29)
        Me.gbxInput.Controls.Add(Me.dtpEndDate)
        Me.gbxInput.Controls.Add(Me.dtpStartDate)
        Me.gbxInput.Controls.Add(Me.txtRate)
        Me.gbxInput.Controls.Add(Me.Label38)
        Me.gbxInput.Controls.Add(Me.txtRateName)
        Me.gbxInput.Controls.Add(Me.Label3)
        Me.gbxInput.Controls.Add(Me.Label7)
        Me.gbxInput.Enabled = False
        Me.gbxInput.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxInput.Location = New System.Drawing.Point(17, 394)
        Me.gbxInput.Name = "gbxInput"
        Me.gbxInput.Size = New System.Drawing.Size(767, 142)
        Me.gbxInput.TabIndex = 2
        Me.gbxInput.TabStop = False
        Me.gbxInput.Text = "Information"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(31, 23)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(78, 18)
        Me.Label37.TabIndex = 1
        Me.Label37.Text = "Rate &Name:"
        '
        'cboRoomType
        '
        Me.cboRoomType.FormattingEnabled = True
        Me.cboRoomType.Location = New System.Drawing.Point(114, 51)
        Me.cboRoomType.MaxLength = 50
        Me.cboRoomType.Name = "cboRoomType"
        Me.cboRoomType.Size = New System.Drawing.Size(270, 26)
        Me.cboRoomType.TabIndex = 5
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(30, 54)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(80, 18)
        Me.Label41.TabIndex = 4
        Me.Label41.Text = "Room &Type:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(17, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "*"
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.Location = New System.Drawing.Point(702, 107)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 28)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.Location = New System.Drawing.Point(642, 107)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(54, 28)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(248, 89)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 18)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "&Remarks:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(318, 86)
        Me.txtRemarks.MaxLength = 100
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(228, 23)
        Me.txtRemarks.TabIndex = 14
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(395, 25)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(74, 18)
        Me.Label30.TabIndex = 9
        Me.Label30.Text = "&Start Date:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(403, 55)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(67, 18)
        Me.Label29.TabIndex = 11
        Me.Label29.Text = "&End Date:"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpEndDate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(470, 53)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(154, 23)
        Me.dtpEndDate.TabIndex = 12
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpStartDate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(470, 21)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(154, 23)
        Me.dtpStartDate.TabIndex = 10
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(114, 86)
        Me.txtRate.MaxLength = 0
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(127, 23)
        Me.txtRate.TabIndex = 8
        Me.txtRate.Text = "0"
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(68, 89)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(40, 18)
        Me.Label38.TabIndex = 7
        Me.Label38.Text = "&Rate:"
        '
        'txtRateName
        '
        Me.txtRateName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRateName.Location = New System.Drawing.Point(114, 22)
        Me.txtRateName.MaxLength = 100
        Me.txtRateName.Name = "txtRateName"
        Me.txtRateName.Size = New System.Drawing.Size(270, 23)
        Me.txtRateName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(55, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "*"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(17, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 19)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "*"
        '
        'lblReq
        '
        Me.lblReq.AutoSize = True
        Me.lblReq.BackColor = System.Drawing.Color.Transparent
        Me.lblReq.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReq.ForeColor = System.Drawing.Color.Red
        Me.lblReq.Location = New System.Drawing.Point(15, 566)
        Me.lblReq.Name = "lblReq"
        Me.lblReq.Size = New System.Drawing.Size(173, 16)
        Me.lblReq.TabIndex = 255
        Me.lblReq.Text = "NOTE: Fields with * are required." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmRoomTypeAndRates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.LogLarge
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblReq)
        Me.Controls.Add(Me.gbxRates)
        Me.Controls.Add(Me.gbxInput)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmRoomTypeAndRates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.gbxRates.ResumeLayout(False)
        Me.gbxRates.PerformLayout()
        CType(Me.dgvRates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInput.ResumeLayout(False)
        Me.gbxInput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbxRates As System.Windows.Forms.GroupBox
    Friend WithEvents chkRoomRateSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents cboRoomRateRoomType As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dgvRates As System.Windows.Forms.DataGridView
    Friend WithEvents gbxInput As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Private WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtRateName As System.Windows.Forms.TextBox
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnAddNew As System.Windows.Forms.Button
    Private WithEvents btnEdit As System.Windows.Forms.Button
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblReq As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents cboRoomType As System.Windows.Forms.ComboBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
