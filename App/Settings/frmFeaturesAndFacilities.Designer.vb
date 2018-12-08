<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFeaturesAndFacilities
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
        Me.gbxInput = New System.Windows.Forms.GroupBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.cboStatus = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnEdit = New System.Windows.Forms.Button
        Me.dgvFeaturesAndFacilities = New System.Windows.Forms.DataGridView
        Me.gbxListOfFeaturesAndFacilities = New System.Windows.Forms.GroupBox
        Me.optUnused = New System.Windows.Forms.RadioButton
        Me.optViewAll = New System.Windows.Forms.RadioButton
        Me.btnDelete = New System.Windows.Forms.Button
        Me.cboViewStatus = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnAddNew = New System.Windows.Forms.Button
        Me.lblCount = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.lblReq = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.gbxInput.SuspendLayout()
        CType(Me.dgvFeaturesAndFacilities, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxListOfFeaturesAndFacilities.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxInput
        '
        Me.gbxInput.BackColor = System.Drawing.Color.Transparent
        Me.gbxInput.Controls.Add(Me.btnCancel)
        Me.gbxInput.Controls.Add(Me.Label33)
        Me.gbxInput.Controls.Add(Me.txtRemarks)
        Me.gbxInput.Controls.Add(Me.cboStatus)
        Me.gbxInput.Controls.Add(Me.Label19)
        Me.gbxInput.Controls.Add(Me.Label35)
        Me.gbxInput.Controls.Add(Me.btnSave)
        Me.gbxInput.Controls.Add(Me.txtName)
        Me.gbxInput.Controls.Add(Me.Label20)
        Me.gbxInput.Controls.Add(Me.Label1)
        Me.gbxInput.Enabled = False
        Me.gbxInput.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxInput.Location = New System.Drawing.Point(21, 450)
        Me.gbxInput.Name = "gbxInput"
        Me.gbxInput.Size = New System.Drawing.Size(762, 105)
        Me.gbxInput.TabIndex = 2
        Me.gbxInput.TabStop = False
        Me.gbxInput.Text = "Information"
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.Location = New System.Drawing.Point(693, 71)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 28)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(18, 48)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(65, 18)
        Me.Label33.TabIndex = 2
        Me.Label33.Text = "&Remarks:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(85, 48)
        Me.txtRemarks.MaxLength = 200
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(324, 47)
        Me.txtRemarks.TabIndex = 3
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Available", "Unavailable"})
        Me.cboStatus.Location = New System.Drawing.Point(487, 20)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(143, 26)
        Me.cboStatus.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(428, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 18)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "&Status:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(28, 22)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(47, 18)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "&Name:"
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.Location = New System.Drawing.Point(633, 71)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(54, 28)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(85, 22)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(324, 23)
        Me.txtName.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(13, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 19)
        Me.Label20.TabIndex = 204
        Me.Label20.Text = "*"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(415, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "*"
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.Location = New System.Drawing.Point(601, 347)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(73, 28)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'dgvFeaturesAndFacilities
        '
        Me.dgvFeaturesAndFacilities.AllowUserToAddRows = False
        Me.dgvFeaturesAndFacilities.AllowUserToDeleteRows = False
        Me.dgvFeaturesAndFacilities.AllowUserToOrderColumns = True
        Me.dgvFeaturesAndFacilities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvFeaturesAndFacilities.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvFeaturesAndFacilities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFeaturesAndFacilities.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvFeaturesAndFacilities.Location = New System.Drawing.Point(3, 19)
        Me.dgvFeaturesAndFacilities.MultiSelect = False
        Me.dgvFeaturesAndFacilities.Name = "dgvFeaturesAndFacilities"
        Me.dgvFeaturesAndFacilities.ReadOnly = True
        Me.dgvFeaturesAndFacilities.RowHeadersVisible = False
        Me.dgvFeaturesAndFacilities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFeaturesAndFacilities.Size = New System.Drawing.Size(759, 317)
        Me.dgvFeaturesAndFacilities.TabIndex = 0
        '
        'gbxListOfFeaturesAndFacilities
        '
        Me.gbxListOfFeaturesAndFacilities.BackColor = System.Drawing.Color.Transparent
        Me.gbxListOfFeaturesAndFacilities.Controls.Add(Me.optUnused)
        Me.gbxListOfFeaturesAndFacilities.Controls.Add(Me.optViewAll)
        Me.gbxListOfFeaturesAndFacilities.Controls.Add(Me.btnDelete)
        Me.gbxListOfFeaturesAndFacilities.Controls.Add(Me.cboViewStatus)
        Me.gbxListOfFeaturesAndFacilities.Controls.Add(Me.Label3)
        Me.gbxListOfFeaturesAndFacilities.Controls.Add(Me.btnAddNew)
        Me.gbxListOfFeaturesAndFacilities.Controls.Add(Me.lblCount)
        Me.gbxListOfFeaturesAndFacilities.Controls.Add(Me.Label27)
        Me.gbxListOfFeaturesAndFacilities.Controls.Add(Me.dgvFeaturesAndFacilities)
        Me.gbxListOfFeaturesAndFacilities.Controls.Add(Me.btnEdit)
        Me.gbxListOfFeaturesAndFacilities.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxListOfFeaturesAndFacilities.Location = New System.Drawing.Point(18, 64)
        Me.gbxListOfFeaturesAndFacilities.Name = "gbxListOfFeaturesAndFacilities"
        Me.gbxListOfFeaturesAndFacilities.Size = New System.Drawing.Size(765, 386)
        Me.gbxListOfFeaturesAndFacilities.TabIndex = 1
        Me.gbxListOfFeaturesAndFacilities.TabStop = False
        Me.gbxListOfFeaturesAndFacilities.Text = "List of Features and Facilities"
        '
        'optUnused
        '
        Me.optUnused.AutoSize = True
        Me.optUnused.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optUnused.Location = New System.Drawing.Point(213, 349)
        Me.optUnused.Name = "optUnused"
        Me.optUnused.Size = New System.Drawing.Size(72, 22)
        Me.optUnused.TabIndex = 5
        Me.optUnused.Text = "Unused"
        Me.optUnused.UseVisualStyleBackColor = True
        '
        'optViewAll
        '
        Me.optViewAll.AutoSize = True
        Me.optViewAll.Checked = True
        Me.optViewAll.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optViewAll.Location = New System.Drawing.Point(136, 349)
        Me.optViewAll.Name = "optViewAll"
        Me.optViewAll.Size = New System.Drawing.Size(75, 22)
        Me.optViewAll.TabIndex = 4
        Me.optViewAll.TabStop = True
        Me.optViewAll.Text = "View All"
        Me.optViewAll.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.Location = New System.Drawing.Point(680, 347)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(73, 28)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'cboViewStatus
        '
        Me.cboViewStatus.FormattingEnabled = True
        Me.cboViewStatus.Items.AddRange(New Object() {"All", "Available", "Unavailable"})
        Me.cboViewStatus.Location = New System.Drawing.Point(336, 347)
        Me.cboViewStatus.Name = "cboViewStatus"
        Me.cboViewStatus.Size = New System.Drawing.Size(91, 26)
        Me.cboViewStatus.TabIndex = 7
        Me.cboViewStatus.Text = "All"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(287, 351)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "&Status:"
        '
        'btnAddNew
        '
        Me.btnAddNew.AutoSize = True
        Me.btnAddNew.Location = New System.Drawing.Point(522, 347)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(73, 28)
        Me.btnAddNew.TabIndex = 8
        Me.btnAddNew.Text = "&Add New"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(58, 351)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(15, 18)
        Me.lblCount.TabIndex = 3
        Me.lblCount.Text = "0"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(5, 351)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(47, 18)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Count:"
        '
        'lblReq
        '
        Me.lblReq.AutoSize = True
        Me.lblReq.BackColor = System.Drawing.Color.Transparent
        Me.lblReq.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReq.ForeColor = System.Drawing.Color.Red
        Me.lblReq.Location = New System.Drawing.Point(18, 564)
        Me.lblReq.Name = "lblReq"
        Me.lblReq.Size = New System.Drawing.Size(173, 16)
        Me.lblReq.TabIndex = 203
        Me.lblReq.Text = "NOTE: Fields with * are required." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Add/Edit Features and Facilities"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(714, 558)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 28)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmFeaturesAndFacilities
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.LogLarge
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblReq)
        Me.Controls.Add(Me.gbxListOfFeaturesAndFacilities)
        Me.Controls.Add(Me.gbxInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmFeaturesAndFacilities"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.gbxInput.ResumeLayout(False)
        Me.gbxInput.PerformLayout()
        CType(Me.dgvFeaturesAndFacilities, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxListOfFeaturesAndFacilities.ResumeLayout(False)
        Me.gbxListOfFeaturesAndFacilities.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxInput As System.Windows.Forms.GroupBox
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Private WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents dgvFeaturesAndFacilities As System.Windows.Forms.DataGridView
    Friend WithEvents gbxListOfFeaturesAndFacilities As System.Windows.Forms.GroupBox
    Private WithEvents btnAddNew As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblReq As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboViewStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents optUnused As System.Windows.Forms.RadioButton
    Friend WithEvents optViewAll As System.Windows.Forms.RadioButton
End Class
