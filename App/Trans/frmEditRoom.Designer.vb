<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditRoom
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
        Me.Label27 = New System.Windows.Forms.Label
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.dtpCheckOutDate = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.dtpCheckOutTime = New System.Windows.Forms.DateTimePicker
        Me.dtpCheckInTime = New System.Windows.Forms.DateTimePicker
        Me.dtpCheckInDate = New System.Windows.Forms.DateTimePicker
        Me.txtNoOfOccupants = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblRoomNo = New System.Windows.Forms.Label
        Me.lblNoOfNights = New System.Windows.Forms.Label
        Me.chkRoomByRequest = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(16, 42)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(70, 18)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Room No.:"
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(289, 173)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(60, 28)
        Me.btnEdit.TabIndex = 14
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(355, 173)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 28)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dtpCheckOutDate
        '
        Me.dtpCheckOutDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpCheckOutDate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckOutDate.Location = New System.Drawing.Point(131, 101)
        Me.dtpCheckOutDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpCheckOutDate.Name = "dtpCheckOutDate"
        Me.dtpCheckOutDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpCheckOutDate.TabIndex = 7
        Me.dtpCheckOutDate.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 18)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Check &In Date:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 101)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(107, 18)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Check &Out Date:"
        '
        'dtpCheckOutTime
        '
        Me.dtpCheckOutTime.CustomFormat = "hhmmtt"
        Me.dtpCheckOutTime.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpCheckOutTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpCheckOutTime.Location = New System.Drawing.Point(301, 101)
        Me.dtpCheckOutTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpCheckOutTime.Name = "dtpCheckOutTime"
        Me.dtpCheckOutTime.ShowUpDown = True
        Me.dtpCheckOutTime.Size = New System.Drawing.Size(110, 23)
        Me.dtpCheckOutTime.TabIndex = 8
        Me.dtpCheckOutTime.Value = New Date(2006, 12, 11, 11, 59, 0, 0)
        '
        'dtpCheckInTime
        '
        Me.dtpCheckInTime.CustomFormat = "hhmmtt"
        Me.dtpCheckInTime.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpCheckInTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpCheckInTime.Location = New System.Drawing.Point(301, 69)
        Me.dtpCheckInTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpCheckInTime.Name = "dtpCheckInTime"
        Me.dtpCheckInTime.ShowUpDown = True
        Me.dtpCheckInTime.Size = New System.Drawing.Size(110, 23)
        Me.dtpCheckInTime.TabIndex = 5
        Me.dtpCheckInTime.Value = New Date(2006, 12, 11, 12, 0, 0, 0)
        '
        'dtpCheckInDate
        '
        Me.dtpCheckInDate.CustomFormat = "MMMM dd, yyyy"
        Me.dtpCheckInDate.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckInDate.Location = New System.Drawing.Point(131, 69)
        Me.dtpCheckInDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpCheckInDate.Name = "dtpCheckInDate"
        Me.dtpCheckInDate.Size = New System.Drawing.Size(160, 23)
        Me.dtpCheckInDate.TabIndex = 4
        Me.dtpCheckInDate.Value = New Date(2007, 1, 23, 0, 0, 0, 0)
        '
        'txtNoOfOccupants
        '
        Me.txtNoOfOccupants.BackColor = System.Drawing.Color.White
        Me.txtNoOfOccupants.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfOccupants.Location = New System.Drawing.Point(131, 129)
        Me.txtNoOfOccupants.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNoOfOccupants.MaxLength = 4
        Me.txtNoOfOccupants.Name = "txtNoOfOccupants"
        Me.txtNoOfOccupants.Size = New System.Drawing.Size(45, 23)
        Me.txtNoOfOccupants.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "No. of &Occupants:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(182, 129)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 18)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "No. of Nights:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edit Room Information"
        '
        'lblRoomNo
        '
        Me.lblRoomNo.AutoSize = True
        Me.lblRoomNo.BackColor = System.Drawing.Color.Transparent
        Me.lblRoomNo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomNo.Location = New System.Drawing.Point(85, 42)
        Me.lblRoomNo.Name = "lblRoomNo"
        Me.lblRoomNo.Size = New System.Drawing.Size(15, 18)
        Me.lblRoomNo.TabIndex = 2
        Me.lblRoomNo.Text = "0"
        '
        'lblNoOfNights
        '
        Me.lblNoOfNights.AutoSize = True
        Me.lblNoOfNights.BackColor = System.Drawing.Color.Transparent
        Me.lblNoOfNights.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfNights.Location = New System.Drawing.Point(277, 131)
        Me.lblNoOfNights.Name = "lblNoOfNights"
        Me.lblNoOfNights.Size = New System.Drawing.Size(15, 18)
        Me.lblNoOfNights.TabIndex = 13
        Me.lblNoOfNights.Text = "0"
        '
        'chkRoomByRequest
        '
        Me.chkRoomByRequest.AutoSize = True
        Me.chkRoomByRequest.BackColor = System.Drawing.Color.Transparent
        Me.chkRoomByRequest.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkRoomByRequest.Location = New System.Drawing.Point(19, 167)
        Me.chkRoomByRequest.Name = "chkRoomByRequest"
        Me.chkRoomByRequest.Size = New System.Drawing.Size(130, 22)
        Me.chkRoomByRequest.TabIndex = 0
        Me.chkRoomByRequest.Text = "Room by &request"
        Me.chkRoomByRequest.UseVisualStyleBackColor = False
        '
        'frmEditRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Log
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(438, 220)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkRoomByRequest)
        Me.Controls.Add(Me.lblNoOfNights)
        Me.Controls.Add(Me.lblRoomNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNoOfOccupants)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dtpCheckOutDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dtpCheckOutTime)
        Me.Controls.Add(Me.dtpCheckInTime)
        Me.Controls.Add(Me.dtpCheckInDate)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label27)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmEditRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents btnEdit As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents dtpCheckOutDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpCheckOutTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCheckInTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCheckInDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNoOfOccupants As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblRoomNo As System.Windows.Forms.Label
    Friend WithEvents lblNoOfNights As System.Windows.Forms.Label
    Friend WithEvents chkRoomByRequest As System.Windows.Forms.CheckBox
End Class
