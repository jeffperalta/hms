<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemDatabase
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
        Me.gbxListOfDatabase = New System.Windows.Forms.GroupBox
        Me.btnRestart = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnAddnew = New System.Windows.Forms.Button
        Me.lblCount = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvListOfDatabase = New System.Windows.Forms.DataGridView
        Me.gbxInput = New System.Windows.Forms.GroupBox
        Me.btnTest = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblReq = New System.Windows.Forms.Label
        Me.btnBrowsePath = New System.Windows.Forms.Button
        Me.chkSetAsDefault = New System.Windows.Forms.CheckBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtHotelName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPath = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.gbxListOfDatabase.SuspendLayout()
        CType(Me.dgvListOfDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInput.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxListOfDatabase
        '
        Me.gbxListOfDatabase.BackColor = System.Drawing.SystemColors.Control
        Me.gbxListOfDatabase.Controls.Add(Me.btnRestart)
        Me.gbxListOfDatabase.Controls.Add(Me.btnDelete)
        Me.gbxListOfDatabase.Controls.Add(Me.btnEdit)
        Me.gbxListOfDatabase.Controls.Add(Me.btnAddnew)
        Me.gbxListOfDatabase.Controls.Add(Me.lblCount)
        Me.gbxListOfDatabase.Controls.Add(Me.Label2)
        Me.gbxListOfDatabase.Controls.Add(Me.dgvListOfDatabase)
        Me.gbxListOfDatabase.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxListOfDatabase.Location = New System.Drawing.Point(187, 6)
        Me.gbxListOfDatabase.Name = "gbxListOfDatabase"
        Me.gbxListOfDatabase.Size = New System.Drawing.Size(499, 304)
        Me.gbxListOfDatabase.TabIndex = 0
        Me.gbxListOfDatabase.TabStop = False
        Me.gbxListOfDatabase.Text = "List of Databases"
        '
        'btnRestart
        '
        Me.btnRestart.AutoSize = True
        Me.btnRestart.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(202, 269)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(64, 28)
        Me.btnRestart.TabIndex = 5
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.AutoSize = True
        Me.btnDelete.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(425, 269)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(64, 28)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(356, 269)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(63, 28)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAddnew
        '
        Me.btnAddnew.AutoSize = True
        Me.btnAddnew.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddnew.Location = New System.Drawing.Point(272, 269)
        Me.btnAddnew.Name = "btnAddnew"
        Me.btnAddnew.Size = New System.Drawing.Size(78, 28)
        Me.btnAddnew.TabIndex = 2
        Me.btnAddnew.Text = "&Add New"
        Me.btnAddnew.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(109, 269)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(15, 18)
        Me.lblCount.TabIndex = 1
        Me.lblCount.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No of Database:"
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
        Me.dgvListOfDatabase.Size = New System.Drawing.Size(493, 244)
        Me.dgvListOfDatabase.TabIndex = 1
        '
        'gbxInput
        '
        Me.gbxInput.BackColor = System.Drawing.SystemColors.Control
        Me.gbxInput.Controls.Add(Me.btnTest)
        Me.gbxInput.Controls.Add(Me.Label5)
        Me.gbxInput.Controls.Add(Me.lblReq)
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
        Me.gbxInput.Location = New System.Drawing.Point(187, 6)
        Me.gbxInput.Name = "gbxInput"
        Me.gbxInput.Size = New System.Drawing.Size(499, 304)
        Me.gbxInput.TabIndex = 0
        Me.gbxInput.TabStop = False
        Me.gbxInput.Text = "Input Fields"
        '
        'btnTest
        '
        Me.btnTest.AutoSize = True
        Me.btnTest.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.Location = New System.Drawing.Point(289, 259)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(62, 28)
        Me.btnTest.TabIndex = 10
        Me.btnTest.Text = "&Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(6, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(338, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "To apply the new settings, click save before closing or restarting "
        '
        'lblReq
        '
        Me.lblReq.AutoSize = True
        Me.lblReq.BackColor = System.Drawing.Color.Transparent
        Me.lblReq.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReq.ForeColor = System.Drawing.Color.Red
        Me.lblReq.Location = New System.Drawing.Point(6, 176)
        Me.lblReq.Name = "lblReq"
        Me.lblReq.Size = New System.Drawing.Size(173, 16)
        Me.lblReq.TabIndex = 8
        Me.lblReq.Text = "NOTE: Fields with * are required." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnBrowsePath
        '
        Me.btnBrowsePath.AutoSize = True
        Me.btnBrowsePath.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowsePath.Location = New System.Drawing.Point(425, 64)
        Me.btnBrowsePath.Name = "btnBrowsePath"
        Me.btnBrowsePath.Size = New System.Drawing.Size(33, 28)
        Me.btnBrowsePath.TabIndex = 3
        Me.btnBrowsePath.Text = "..."
        Me.btnBrowsePath.UseVisualStyleBackColor = True
        '
        'chkSetAsDefault
        '
        Me.chkSetAsDefault.AutoSize = True
        Me.chkSetAsDefault.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSetAsDefault.Location = New System.Drawing.Point(134, 134)
        Me.chkSetAsDefault.Name = "chkSetAsDefault"
        Me.chkSetAsDefault.Size = New System.Drawing.Size(167, 22)
        Me.chkSetAsDefault.TabIndex = 7
        Me.chkSetAsDefault.Text = "Set as &Default Database"
        Me.chkSetAsDefault.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(425, 259)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 28)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(357, 259)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(64, 28)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtHotelName
        '
        Me.txtHotelName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHotelName.Location = New System.Drawing.Point(134, 95)
        Me.txtHotelName.MaxLength = 50
        Me.txtHotelName.Name = "txtHotelName"
        Me.txtHotelName.Size = New System.Drawing.Size(285, 23)
        Me.txtHotelName.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hotel &Name"
        '
        'txtPath
        '
        Me.txtPath.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.Location = New System.Drawing.Point(134, 66)
        Me.txtPath.MaxLength = 1000
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(285, 23)
        Me.txtPath.TabIndex = 2
        Me.txtPath.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Path"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(38, 99)
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
        Me.Label20.Location = New System.Drawing.Point(82, 69)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 19)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "*"
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.DatabaseMissing
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(178, 331)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'frmSystemDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(697, 331)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbxListOfDatabase)
        Me.Controls.Add(Me.gbxInput)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSystemDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Settings"
        Me.gbxListOfDatabase.ResumeLayout(False)
        Me.gbxListOfDatabase.PerformLayout()
        CType(Me.dgvListOfDatabase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInput.ResumeLayout(False)
        Me.gbxInput.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxListOfDatabase As System.Windows.Forms.GroupBox
    Friend WithEvents dgvListOfDatabase As System.Windows.Forms.DataGridView
    Friend WithEvents gbxInput As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowsePath As System.Windows.Forms.Button
    Friend WithEvents chkSetAsDefault As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtHotelName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents lblReq As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddnew As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
