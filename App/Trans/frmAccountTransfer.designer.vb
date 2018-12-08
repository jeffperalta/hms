<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountTransfer
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblTransferredToCheckOut = New System.Windows.Forms.Label
        Me.lblTransferredToContactNo = New System.Windows.Forms.Label
        Me.lblTransferredToCheckIn = New System.Windows.Forms.Label
        Me.lblTransferredToGuestName = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnTransferredTo = New System.Windows.Forms.Button
        Me.dtpDateTransferred = New System.Windows.Forms.DateTimePicker
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtAmountToBeTransferred = New System.Windows.Forms.TextBox
        Me.btnTransferAccout = New System.Windows.Forms.Button
        Me.lblTransferToREGNO = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgvTransferredAccountInformation = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnRemove = New System.Windows.Forms.Button
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.lchGuestRmNo = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblGuestBillREGNO = New System.Windows.Forms.Label
        Me.dgvGuestBillInformation = New System.Windows.Forms.DataGridView
        Me.lblTotalBalance = New System.Windows.Forms.Label
        Me.lblTotalCharges = New System.Windows.Forms.Label
        Me.lblCheckOutDate = New System.Windows.Forms.Label
        Me.lblContactNo = New System.Windows.Forms.Label
        Me.lblCheckInDate = New System.Windows.Forms.Label
        Me.lblGuestName = New System.Windows.Forms.Label
        Me.btnGuestBill = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblClose = New System.Windows.Forms.LinkLabel
        Me.Label1 = New System.Windows.Forms.Label
        Me.tsActivities = New System.Windows.Forms.ToolStrip
        Me.tsbActGuestFolio = New System.Windows.Forms.ToolStripButton
        Me.tss1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbActRmCharge = New System.Windows.Forms.ToolStripButton
        Me.tss2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbActAmnServ = New System.Windows.Forms.ToolStripButton
        Me.tss3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbActIncDec = New System.Windows.Forms.ToolStripButton
        Me.tss5 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbActGuestInfo = New System.Windows.Forms.ToolStripButton
        Me.tss6 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbActPayment = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.btnClear = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvTransferredAccountInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvGuestBillInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsActivities.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lblTransferredToCheckOut)
        Me.GroupBox3.Controls.Add(Me.lblTransferredToContactNo)
        Me.GroupBox3.Controls.Add(Me.lblTransferredToCheckIn)
        Me.GroupBox3.Controls.Add(Me.lblTransferredToGuestName)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btnTransferredTo)
        Me.GroupBox3.Controls.Add(Me.dtpDateTransferred)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtAmountToBeTransferred)
        Me.GroupBox3.Controls.Add(Me.btnTransferAccout)
        Me.GroupBox3.Controls.Add(Me.lblTransferToREGNO)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GroupBox3.Location = New System.Drawing.Point(143, 248)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(834, 128)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transferred To"
        '
        'lblTransferredToCheckOut
        '
        Me.lblTransferredToCheckOut.AutoSize = True
        Me.lblTransferredToCheckOut.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.lblTransferredToCheckOut.Location = New System.Drawing.Point(551, 42)
        Me.lblTransferredToCheckOut.Name = "lblTransferredToCheckOut"
        Me.lblTransferredToCheckOut.Size = New System.Drawing.Size(0, 18)
        Me.lblTransferredToCheckOut.TabIndex = 9
        '
        'lblTransferredToContactNo
        '
        Me.lblTransferredToContactNo.AutoSize = True
        Me.lblTransferredToContactNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.lblTransferredToContactNo.Location = New System.Drawing.Point(245, 42)
        Me.lblTransferredToContactNo.Name = "lblTransferredToContactNo"
        Me.lblTransferredToContactNo.Size = New System.Drawing.Size(0, 18)
        Me.lblTransferredToContactNo.TabIndex = 5
        '
        'lblTransferredToCheckIn
        '
        Me.lblTransferredToCheckIn.AutoSize = True
        Me.lblTransferredToCheckIn.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.lblTransferredToCheckIn.Location = New System.Drawing.Point(551, 19)
        Me.lblTransferredToCheckIn.Name = "lblTransferredToCheckIn"
        Me.lblTransferredToCheckIn.Size = New System.Drawing.Size(0, 18)
        Me.lblTransferredToCheckIn.TabIndex = 7
        '
        'lblTransferredToGuestName
        '
        Me.lblTransferredToGuestName.AutoSize = True
        Me.lblTransferredToGuestName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.lblTransferredToGuestName.Location = New System.Drawing.Point(245, 19)
        Me.lblTransferredToGuestName.Name = "lblTransferredToGuestName"
        Me.lblTransferredToGuestName.Size = New System.Drawing.Size(0, 18)
        Me.lblTransferredToGuestName.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.TextBox1.Location = New System.Drawing.Point(12, 73)
        Me.TextBox1.MaxLength = 1000
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(223, 46)
        Me.TextBox1.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(9, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Remarks:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(130, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Tag = " "
        Me.Label2.Text = "Contact No.:"
        '
        'btnTransferredTo
        '
        Me.btnTransferredTo.AutoSize = True
        Me.btnTransferredTo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.btnTransferredTo.Location = New System.Drawing.Point(9, 21)
        Me.btnTransferredTo.Name = "btnTransferredTo"
        Me.btnTransferredTo.Size = New System.Drawing.Size(98, 28)
        Me.btnTransferredTo.TabIndex = 0
        Me.btnTransferredTo.Text = "Choos&e Guest"
        Me.btnTransferredTo.UseVisualStyleBackColor = True
        '
        'dtpDateTransferred
        '
        Me.dtpDateTransferred.CustomFormat = "MMMM dd, yyyy"
        Me.dtpDateTransferred.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.dtpDateTransferred.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTransferred.Location = New System.Drawing.Point(499, 70)
        Me.dtpDateTransferred.Name = "dtpDateTransferred"
        Me.dtpDateTransferred.Size = New System.Drawing.Size(157, 23)
        Me.dtpDateTransferred.TabIndex = 13
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label24.Location = New System.Drawing.Point(453, 72)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 18)
        Me.Label24.TabIndex = 12
        Me.Label24.Text = "&Date:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(436, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Check Out Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(436, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Check In Date:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(130, 19)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(84, 18)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Guest Name:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(323, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(173, 18)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "&Amount to be Transferred:"
        '
        'txtAmountToBeTransferred
        '
        Me.txtAmountToBeTransferred.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.txtAmountToBeTransferred.Location = New System.Drawing.Point(499, 98)
        Me.txtAmountToBeTransferred.MaxLength = 20
        Me.txtAmountToBeTransferred.Name = "txtAmountToBeTransferred"
        Me.txtAmountToBeTransferred.Size = New System.Drawing.Size(157, 23)
        Me.txtAmountToBeTransferred.TabIndex = 15
        Me.txtAmountToBeTransferred.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnTransferAccout
        '
        Me.btnTransferAccout.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.btnTransferAccout.Location = New System.Drawing.Point(703, 94)
        Me.btnTransferAccout.Name = "btnTransferAccout"
        Me.btnTransferAccout.Size = New System.Drawing.Size(125, 28)
        Me.btnTransferAccout.TabIndex = 16
        Me.btnTransferAccout.Text = "&Transfer Account"
        Me.btnTransferAccout.UseVisualStyleBackColor = True
        '
        'lblTransferToREGNO
        '
        Me.lblTransferToREGNO.AutoSize = True
        Me.lblTransferToREGNO.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransferToREGNO.Location = New System.Drawing.Point(109, 94)
        Me.lblTransferToREGNO.Name = "lblTransferToREGNO"
        Me.lblTransferToREGNO.Size = New System.Drawing.Size(0, 16)
        Me.lblTransferToREGNO.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(309, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 19)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "*"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(848, 582)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 28)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dgvTransferredAccountInformation)
        Me.GroupBox2.Controls.Add(Me.btnRemove)
        Me.GroupBox2.Controls.Add(Me.ListView2)
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(143, 380)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(831, 198)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transferred Account Information"
        '
        'dgvTransferredAccountInformation
        '
        Me.dgvTransferredAccountInformation.AllowUserToAddRows = False
        Me.dgvTransferredAccountInformation.AllowUserToDeleteRows = False
        Me.dgvTransferredAccountInformation.AllowUserToOrderColumns = True
        Me.dgvTransferredAccountInformation.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTransferredAccountInformation.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTransferredAccountInformation.BackgroundColor = System.Drawing.Color.White
        Me.dgvTransferredAccountInformation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dgvTransferredAccountInformation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTransferredAccountInformation.Location = New System.Drawing.Point(6, 19)
        Me.dgvTransferredAccountInformation.MultiSelect = False
        Me.dgvTransferredAccountInformation.Name = "dgvTransferredAccountInformation"
        Me.dgvTransferredAccountInformation.ReadOnly = True
        Me.dgvTransferredAccountInformation.RowHeadersVisible = False
        Me.dgvTransferredAccountInformation.RowHeadersWidth = 25
        Me.dgvTransferredAccountInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransferredAccountInformation.Size = New System.Drawing.Size(819, 142)
        Me.dgvTransferredAccountInformation.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Service"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date Incurred"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Reference"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Modified Charge"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Balance"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Amount Transferred"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Transferred From"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Transferred To"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Date Transferred"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "FDNO"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(757, 166)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(68, 28)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.lchGuestRmNo, Me.ColumnHeader3})
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(5, 61)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(1, 1)
        Me.ListView2.TabIndex = 1
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Resource Locator"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 108
        '
        'lchGuestRmNo
        '
        Me.lchGuestRmNo.Text = "Room No."
        Me.lchGuestRmNo.Width = 78
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Status"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 99
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblGuestBillREGNO)
        Me.GroupBox1.Controls.Add(Me.dgvGuestBillInformation)
        Me.GroupBox1.Controls.Add(Me.lblTotalBalance)
        Me.GroupBox1.Controls.Add(Me.lblTotalCharges)
        Me.GroupBox1.Controls.Add(Me.lblCheckOutDate)
        Me.GroupBox1.Controls.Add(Me.lblContactNo)
        Me.GroupBox1.Controls.Add(Me.lblCheckInDate)
        Me.GroupBox1.Controls.Add(Me.lblGuestName)
        Me.GroupBox1.Controls.Add(Me.btnGuestBill)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(143, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(834, 219)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guest Bill Information"
        '
        'lblGuestBillREGNO
        '
        Me.lblGuestBillREGNO.AutoSize = True
        Me.lblGuestBillREGNO.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestBillREGNO.Location = New System.Drawing.Point(9, 59)
        Me.lblGuestBillREGNO.Name = "lblGuestBillREGNO"
        Me.lblGuestBillREGNO.Size = New System.Drawing.Size(0, 16)
        Me.lblGuestBillREGNO.TabIndex = 10
        Me.lblGuestBillREGNO.Visible = False
        '
        'dgvGuestBillInformation
        '
        Me.dgvGuestBillInformation.AllowUserToAddRows = False
        Me.dgvGuestBillInformation.AllowUserToDeleteRows = False
        Me.dgvGuestBillInformation.AllowUserToOrderColumns = True
        Me.dgvGuestBillInformation.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvGuestBillInformation.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvGuestBillInformation.BackgroundColor = System.Drawing.Color.White
        Me.dgvGuestBillInformation.Location = New System.Drawing.Point(10, 64)
        Me.dgvGuestBillInformation.MultiSelect = False
        Me.dgvGuestBillInformation.Name = "dgvGuestBillInformation"
        Me.dgvGuestBillInformation.ReadOnly = True
        Me.dgvGuestBillInformation.RowHeadersVisible = False
        Me.dgvGuestBillInformation.RowHeadersWidth = 25
        Me.dgvGuestBillInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGuestBillInformation.Size = New System.Drawing.Size(818, 108)
        Me.dgvGuestBillInformation.TabIndex = 244
        '
        'lblTotalBalance
        '
        Me.lblTotalBalance.AutoSize = True
        Me.lblTotalBalance.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.lblTotalBalance.Location = New System.Drawing.Point(338, 197)
        Me.lblTotalBalance.Name = "lblTotalBalance"
        Me.lblTotalBalance.Size = New System.Drawing.Size(15, 18)
        Me.lblTotalBalance.TabIndex = 15
        Me.lblTotalBalance.Text = "0"
        '
        'lblTotalCharges
        '
        Me.lblTotalCharges.AutoSize = True
        Me.lblTotalCharges.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.lblTotalCharges.Location = New System.Drawing.Point(338, 175)
        Me.lblTotalCharges.Name = "lblTotalCharges"
        Me.lblTotalCharges.Size = New System.Drawing.Size(15, 18)
        Me.lblTotalCharges.TabIndex = 13
        Me.lblTotalCharges.Text = "0"
        '
        'lblCheckOutDate
        '
        Me.lblCheckOutDate.AutoSize = True
        Me.lblCheckOutDate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckOutDate.Location = New System.Drawing.Point(551, 40)
        Me.lblCheckOutDate.Name = "lblCheckOutDate"
        Me.lblCheckOutDate.Size = New System.Drawing.Size(0, 18)
        Me.lblCheckOutDate.TabIndex = 9
        '
        'lblContactNo
        '
        Me.lblContactNo.AutoSize = True
        Me.lblContactNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.lblContactNo.Location = New System.Drawing.Point(223, 40)
        Me.lblContactNo.Name = "lblContactNo"
        Me.lblContactNo.Size = New System.Drawing.Size(0, 18)
        Me.lblContactNo.TabIndex = 5
        '
        'lblCheckInDate
        '
        Me.lblCheckInDate.AutoSize = True
        Me.lblCheckInDate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheckInDate.Location = New System.Drawing.Point(551, 19)
        Me.lblCheckInDate.Name = "lblCheckInDate"
        Me.lblCheckInDate.Size = New System.Drawing.Size(0, 18)
        Me.lblCheckInDate.TabIndex = 7
        '
        'lblGuestName
        '
        Me.lblGuestName.AutoSize = True
        Me.lblGuestName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.lblGuestName.Location = New System.Drawing.Point(223, 19)
        Me.lblGuestName.Name = "lblGuestName"
        Me.lblGuestName.Size = New System.Drawing.Size(0, 18)
        Me.lblGuestName.TabIndex = 3
        '
        'btnGuestBill
        '
        Me.btnGuestBill.AutoSize = True
        Me.btnGuestBill.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.btnGuestBill.Location = New System.Drawing.Point(9, 26)
        Me.btnGuestBill.Name = "btnGuestBill"
        Me.btnGuestBill.Size = New System.Drawing.Size(98, 28)
        Me.btnGuestBill.TabIndex = 1
        Me.btnGuestBill.Text = "&Choose Guest"
        Me.btnGuestBill.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(436, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 18)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Check Out Date:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(436, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 18)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Check In Date:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(130, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 18)
        Me.Label12.TabIndex = 4
        Me.Label12.Tag = " "
        Me.Label12.Text = "Contact No.:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(130, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 18)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Guest Name:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(9, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(218, 18)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Select particulars to be transferred."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(242, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 18)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Total Balance:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(242, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total Charges:"
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
        Me.lblClose.TabIndex = 7
        Me.lblClose.TabStop = True
        Me.lblClose.Text = "Close"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Transfer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tsActivities
        '
        Me.tsActivities.AutoSize = False
        Me.tsActivities.BackColor = System.Drawing.Color.Transparent
        Me.tsActivities.Dock = System.Windows.Forms.DockStyle.None
        Me.tsActivities.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsActivities.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsActivities.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.tsActivities.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbActGuestFolio, Me.tss1, Me.tsbActRmCharge, Me.tss2, Me.tsbActAmnServ, Me.tss3, Me.tsbActIncDec, Me.tss5, Me.tsbActGuestInfo, Me.tss6, Me.tsbActPayment, Me.ToolStripSeparator1, Me.ToolStripButton2})
        Me.tsActivities.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsActivities.Location = New System.Drawing.Point(-2, 83)
        Me.tsActivities.Name = "tsActivities"
        Me.tsActivities.ShowItemToolTips = False
        Me.tsActivities.Size = New System.Drawing.Size(116, 308)
        Me.tsActivities.TabIndex = 6
        Me.tsActivities.Text = "ToolStrip2"
        '
        'tsbActGuestFolio
        '
        Me.tsbActGuestFolio.AutoSize = False
        Me.tsbActGuestFolio.AutoToolTip = False
        Me.tsbActGuestFolio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsbActGuestFolio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbActGuestFolio.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.tsbActGuestFolio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbActGuestFolio.Name = "tsbActGuestFolio"
        Me.tsbActGuestFolio.Size = New System.Drawing.Size(120, 30)
        Me.tsbActGuestFolio.Text = "Guest Folio"
        Me.tsbActGuestFolio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss1
        '
        Me.tss1.Name = "tss1"
        Me.tss1.Size = New System.Drawing.Size(114, 6)
        '
        'tsbActRmCharge
        '
        Me.tsbActRmCharge.AutoSize = False
        Me.tsbActRmCharge.AutoToolTip = False
        Me.tsbActRmCharge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbActRmCharge.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.tsbActRmCharge.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbActRmCharge.Name = "tsbActRmCharge"
        Me.tsbActRmCharge.Size = New System.Drawing.Size(120, 30)
        Me.tsbActRmCharge.Text = "Update Room Charge"
        Me.tsbActRmCharge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss2
        '
        Me.tss2.Name = "tss2"
        Me.tss2.Size = New System.Drawing.Size(114, 6)
        '
        'tsbActAmnServ
        '
        Me.tsbActAmnServ.AutoSize = False
        Me.tsbActAmnServ.AutoToolTip = False
        Me.tsbActAmnServ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbActAmnServ.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
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
        Me.tss3.Size = New System.Drawing.Size(114, 6)
        '
        'tsbActIncDec
        '
        Me.tsbActIncDec.AutoSize = False
        Me.tsbActIncDec.AutoToolTip = False
        Me.tsbActIncDec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbActIncDec.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.tsbActIncDec.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbActIncDec.Name = "tsbActIncDec"
        Me.tsbActIncDec.Size = New System.Drawing.Size(120, 30)
        Me.tsbActIncDec.Text = "Modify Amount"
        Me.tsbActIncDec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss5
        '
        Me.tss5.Name = "tss5"
        Me.tss5.Size = New System.Drawing.Size(114, 6)
        '
        'tsbActGuestInfo
        '
        Me.tsbActGuestInfo.AutoSize = False
        Me.tsbActGuestInfo.AutoToolTip = False
        Me.tsbActGuestInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbActGuestInfo.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.tsbActGuestInfo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbActGuestInfo.Name = "tsbActGuestInfo"
        Me.tsbActGuestInfo.Size = New System.Drawing.Size(120, 30)
        Me.tsbActGuestInfo.Text = "Guest Information"
        Me.tsbActGuestInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss6
        '
        Me.tss6.Name = "tss6"
        Me.tss6.Size = New System.Drawing.Size(114, 6)
        '
        'tsbActPayment
        '
        Me.tsbActPayment.AutoSize = False
        Me.tsbActPayment.AutoToolTip = False
        Me.tsbActPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbActPayment.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.tsbActPayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbActPayment.Name = "tsbActPayment"
        Me.tsbActPayment.Size = New System.Drawing.Size(120, 30)
        Me.tsbActPayment.Text = "Billing"
        Me.tsbActPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(114, 6)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(120, 30)
        Me.ToolStripButton2.Text = "Uncollectible"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(914, 582)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 28)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmAccountTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tsActivities)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 80)
        Me.Name = "frmAccountTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SLU Hotel"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvTransferredAccountInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvGuestBillInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsActivities.ResumeLayout(False)
        Me.tsActivities.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents btnTransferredTo As System.Windows.Forms.Button
    Friend WithEvents dtpDateTransferred As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents txtAmountToBeTransferred As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents btnTransferAccout As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Private WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lchGuestRmNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btnGuestBill As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsActivities As System.Windows.Forms.ToolStrip
    Public WithEvents tsbActGuestFolio As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbActRmCharge As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbActAmnServ As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbActIncDec As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbActGuestInfo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbActPayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTransferredToCheckOut As System.Windows.Forms.Label
    Friend WithEvents lblTransferredToContactNo As System.Windows.Forms.Label
    Friend WithEvents lblTransferredToCheckIn As System.Windows.Forms.Label
    Friend WithEvents lblTransferredToGuestName As System.Windows.Forms.Label
    Friend WithEvents lblTotalBalance As System.Windows.Forms.Label
    Friend WithEvents lblTotalCharges As System.Windows.Forms.Label
    Friend WithEvents lblCheckOutDate As System.Windows.Forms.Label
    Friend WithEvents lblContactNo As System.Windows.Forms.Label
    Friend WithEvents lblCheckInDate As System.Windows.Forms.Label
    Friend WithEvents lblGuestName As System.Windows.Forms.Label
    Friend WithEvents dgvTransferredAccountInformation As System.Windows.Forms.DataGridView
    Friend WithEvents dgvGuestBillInformation As System.Windows.Forms.DataGridView
    Private WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblGuestBillREGNO As System.Windows.Forms.Label
    Friend WithEvents lblTransferToREGNO As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblClose As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
