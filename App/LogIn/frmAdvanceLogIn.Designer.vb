<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdvanceLogIn
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
        Me.tssLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.tssStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.tbcAdvanceLogInSettings = New System.Windows.Forms.TabControl
        Me.tbpShift = New System.Windows.Forms.TabPage
        Me.lblShiftName = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.gbxListOfShifts = New System.Windows.Forms.GroupBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.lblCount = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.dgvListOfShift = New System.Windows.Forms.DataGridView
        Me.tbpPassword = New System.Windows.Forms.TabPage
        Me.gbxChangePassword = New System.Windows.Forms.GroupBox
        Me.btnExit_Password = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnSavePassword = New System.Windows.Forms.Button
        Me.txtConfirm = New System.Windows.Forms.TextBox
        Me.txtNewPassword = New System.Windows.Forms.TextBox
        Me.txtOldPassword = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtOldUsername = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tlpMessage = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.tbcAdvanceLogInSettings.SuspendLayout()
        Me.tbpShift.SuspendLayout()
        Me.gbxListOfShifts.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvListOfShift, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpPassword.SuspendLayout()
        Me.gbxChangePassword.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tssLabel
        '
        Me.tssLabel.Name = "tssLabel"
        Me.tssLabel.Size = New System.Drawing.Size(58, 17)
        Me.tssLabel.Text = "Status:"
        '
        'tssStatus
        '
        Me.tssStatus.Name = "tssStatus"
        Me.tssStatus.Size = New System.Drawing.Size(29, 17)
        Me.tssStatus.Text = "xxx"
        '
        'tbcAdvanceLogInSettings
        '
        Me.tbcAdvanceLogInSettings.Controls.Add(Me.tbpShift)
        Me.tbcAdvanceLogInSettings.Controls.Add(Me.tbpPassword)
        Me.tbcAdvanceLogInSettings.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcAdvanceLogInSettings.Location = New System.Drawing.Point(187, 7)
        Me.tbcAdvanceLogInSettings.Name = "tbcAdvanceLogInSettings"
        Me.tbcAdvanceLogInSettings.SelectedIndex = 0
        Me.tbcAdvanceLogInSettings.Size = New System.Drawing.Size(583, 398)
        Me.tbcAdvanceLogInSettings.TabIndex = 0
        '
        'tbpShift
        '
        Me.tbpShift.Controls.Add(Me.lblShiftName)
        Me.tbpShift.Controls.Add(Me.Label10)
        Me.tbpShift.Controls.Add(Me.gbxListOfShifts)
        Me.tbpShift.Location = New System.Drawing.Point(4, 27)
        Me.tbpShift.Name = "tbpShift"
        Me.tbpShift.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpShift.Size = New System.Drawing.Size(575, 367)
        Me.tbpShift.TabIndex = 0
        Me.tbpShift.Text = "Shift"
        Me.tbpShift.UseVisualStyleBackColor = True
        '
        'lblShiftName
        '
        Me.lblShiftName.AutoSize = True
        Me.lblShiftName.Location = New System.Drawing.Point(107, 11)
        Me.lblShiftName.Name = "lblShiftName"
        Me.lblShiftName.Size = New System.Drawing.Size(0, 18)
        Me.lblShiftName.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 18)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Current Shift:"
        '
        'gbxListOfShifts
        '
        Me.gbxListOfShifts.Controls.Add(Me.btnExit)
        Me.gbxListOfShifts.Controls.Add(Me.lblCount)
        Me.gbxListOfShifts.Controls.Add(Me.Label1)
        Me.gbxListOfShifts.Controls.Add(Me.GroupBox1)
        Me.gbxListOfShifts.Controls.Add(Me.btnSave)
        Me.gbxListOfShifts.Controls.Add(Me.dgvListOfShift)
        Me.gbxListOfShifts.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxListOfShifts.Location = New System.Drawing.Point(3, 38)
        Me.gbxListOfShifts.Name = "gbxListOfShifts"
        Me.gbxListOfShifts.Size = New System.Drawing.Size(569, 323)
        Me.gbxListOfShifts.TabIndex = 0
        Me.gbxListOfShifts.TabStop = False
        Me.gbxListOfShifts.Text = "Choose a shift from the list to log in"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(482, 250)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 28)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(144, 257)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(15, 18)
        Me.lblCount.TabIndex = 3
        Me.lblCount.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "No of shifts available:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 277)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 40)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(6, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(526, 23)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "This is used if there are overlapping shifts/no shift. Consult the manager to arr" & _
            "ange a shift schedule."
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.AutoSize = True
        Me.btnSave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(401, 250)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 28)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Choose"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgvListOfShift
        '
        Me.dgvListOfShift.AllowUserToAddRows = False
        Me.dgvListOfShift.AllowUserToDeleteRows = False
        Me.dgvListOfShift.AllowUserToOrderColumns = True
        Me.dgvListOfShift.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvListOfShift.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvListOfShift.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListOfShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListOfShift.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvListOfShift.Location = New System.Drawing.Point(3, 19)
        Me.dgvListOfShift.MultiSelect = False
        Me.dgvListOfShift.Name = "dgvListOfShift"
        Me.dgvListOfShift.ReadOnly = True
        Me.dgvListOfShift.RowHeadersVisible = False
        Me.dgvListOfShift.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListOfShift.Size = New System.Drawing.Size(563, 227)
        Me.dgvListOfShift.TabIndex = 1
        '
        'tbpPassword
        '
        Me.tbpPassword.Controls.Add(Me.gbxChangePassword)
        Me.tbpPassword.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpPassword.Location = New System.Drawing.Point(4, 27)
        Me.tbpPassword.Name = "tbpPassword"
        Me.tbpPassword.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpPassword.Size = New System.Drawing.Size(575, 367)
        Me.tbpPassword.TabIndex = 1
        Me.tbpPassword.Text = "Password"
        Me.tbpPassword.UseVisualStyleBackColor = True
        '
        'gbxChangePassword
        '
        Me.gbxChangePassword.Controls.Add(Me.btnExit_Password)
        Me.gbxChangePassword.Controls.Add(Me.GroupBox2)
        Me.gbxChangePassword.Controls.Add(Me.btnSavePassword)
        Me.gbxChangePassword.Controls.Add(Me.txtConfirm)
        Me.gbxChangePassword.Controls.Add(Me.txtNewPassword)
        Me.gbxChangePassword.Controls.Add(Me.txtOldPassword)
        Me.gbxChangePassword.Controls.Add(Me.Label6)
        Me.gbxChangePassword.Controls.Add(Me.Label7)
        Me.gbxChangePassword.Controls.Add(Me.txtOldUsername)
        Me.gbxChangePassword.Controls.Add(Me.Label8)
        Me.gbxChangePassword.Controls.Add(Me.Label9)
        Me.gbxChangePassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxChangePassword.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxChangePassword.Location = New System.Drawing.Point(3, 3)
        Me.gbxChangePassword.Name = "gbxChangePassword"
        Me.gbxChangePassword.Size = New System.Drawing.Size(569, 361)
        Me.gbxChangePassword.TabIndex = 0
        Me.gbxChangePassword.TabStop = False
        Me.gbxChangePassword.Text = "Change Password"
        '
        'btnExit_Password
        '
        Me.btnExit_Password.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit_Password.AutoSize = True
        Me.btnExit_Password.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit_Password.Location = New System.Drawing.Point(388, 228)
        Me.btnExit_Password.Name = "btnExit_Password"
        Me.btnExit_Password.Size = New System.Drawing.Size(75, 28)
        Me.btnExit_Password.TabIndex = 9
        Me.btnExit_Password.Text = "E&xit"
        Me.btnExit_Password.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 318)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(563, 40)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(6, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(530, 36)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "If you forgot your password or liked to change your username, call the attention " & _
            "of the manager."
        '
        'btnSavePassword
        '
        Me.btnSavePassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSavePassword.AutoSize = True
        Me.btnSavePassword.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavePassword.Location = New System.Drawing.Point(307, 228)
        Me.btnSavePassword.Name = "btnSavePassword"
        Me.btnSavePassword.Size = New System.Drawing.Size(75, 28)
        Me.btnSavePassword.TabIndex = 8
        Me.btnSavePassword.Text = "&Save"
        Me.btnSavePassword.UseVisualStyleBackColor = True
        '
        'txtConfirm
        '
        Me.txtConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConfirm.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtConfirm.Location = New System.Drawing.Point(202, 200)
        Me.txtConfirm.MaxLength = 20
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtConfirm.Size = New System.Drawing.Size(261, 22)
        Me.txtConfirm.TabIndex = 7
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNewPassword.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(202, 171)
        Me.txtNewPassword.MaxLength = 20
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtNewPassword.Size = New System.Drawing.Size(261, 22)
        Me.txtNewPassword.TabIndex = 5
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOldPassword.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtOldPassword.Location = New System.Drawing.Point(202, 122)
        Me.txtOldPassword.MaxLength = 20
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtOldPassword.Size = New System.Drawing.Size(261, 22)
        Me.txtOldPassword.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(135, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "&Confirm:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(96, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "&New Password:"
        '
        'txtOldUsername
        '
        Me.txtOldUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOldUsername.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldUsername.Location = New System.Drawing.Point(202, 94)
        Me.txtOldUsername.MaxLength = 20
        Me.txtOldUsername.Name = "txtOldUsername"
        Me.txtOldUsername.Size = New System.Drawing.Size(261, 23)
        Me.txtOldUsername.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(102, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Old &Password:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(122, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 18)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "&Username:"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(302, 55)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.TextBox6.Size = New System.Drawing.Size(133, 22)
        Me.TextBox6.TabIndex = 89
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(302, 27)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.TextBox5.Size = New System.Drawing.Size(133, 22)
        Me.TextBox5.TabIndex = 88
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(92, 54)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtPassword.Size = New System.Drawing.Size(152, 22)
        Me.txtPassword.TabIndex = 87
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(358, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "&Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(251, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Confirm:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(215, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "New Password:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(92, 28)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(118, 20)
        Me.TextBox2.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(11, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Old Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(40, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "User ID:"
        '
        'tlpMessage
        '
        Me.tlpMessage.AutomaticDelay = 200
        Me.tlpMessage.AutoPopDelay = 2000
        Me.tlpMessage.InitialDelay = 200
        Me.tlpMessage.IsBalloon = True
        Me.tlpMessage.ReshowDelay = 0
        Me.tlpMessage.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.tlpMessage.ToolTipTitle = "Invalid User Credentials"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Res_LogIn
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(179, 412)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'frmAdvanceLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(778, 412)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.tbcAdvanceLogInSettings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAdvanceLogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advanced Settings"
        Me.tbcAdvanceLogInSettings.ResumeLayout(False)
        Me.tbpShift.ResumeLayout(False)
        Me.tbpShift.PerformLayout()
        Me.gbxListOfShifts.ResumeLayout(False)
        Me.gbxListOfShifts.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvListOfShift, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpPassword.ResumeLayout(False)
        Me.gbxChangePassword.ResumeLayout(False)
        Me.gbxChangePassword.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tssLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tbcAdvanceLogInSettings As System.Windows.Forms.TabControl
    Friend WithEvents tbpShift As System.Windows.Forms.TabPage
    Friend WithEvents gbxListOfShifts As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgvListOfShift As System.Windows.Forms.DataGridView
    Friend WithEvents tbpPassword As System.Windows.Forms.TabPage
    Friend WithEvents gbxChangePassword As System.Windows.Forms.GroupBox
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnSavePassword As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtOldUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tlpMessage As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblShiftName As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnExit_Password As System.Windows.Forms.Button
End Class
