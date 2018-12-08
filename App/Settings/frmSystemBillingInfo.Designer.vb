<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemBillingInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSystemBillingInfo))
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.gbxRefundDaysValid = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtResVD = New System.Windows.Forms.TextBox
        Me.txtResVDR = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtRefVDR = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.gbxReservationDownPayment = New System.Windows.Forms.GroupBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtResD = New System.Windows.Forms.TextBox
        Me.txtResDR = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtRefDR = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.gbxReservationDaysValid = New System.Windows.Forms.GroupBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtRefVD = New System.Windows.Forms.TextBox
        Me.gbxReservationPercentageOfDownpayment = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtRefD = New System.Windows.Forms.TextBox
        Me.chkPromptForRefund = New System.Windows.Forms.CheckBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtReceipt = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.btnReceipt = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Label23 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.tsActivities = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtAmountInFrontDesk = New System.Windows.Forms.TextBox
        Me.gbxRefundDaysValid.SuspendLayout()
        Me.gbxReservationDownPayment.SuspendLayout()
        Me.gbxReservationDaysValid.SuspendLayout()
        Me.gbxReservationPercentageOfDownpayment.SuspendLayout()
        Me.tsActivities.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(848, 572)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 28)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(914, 572)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 28)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'gbxRefundDaysValid
        '
        Me.gbxRefundDaysValid.BackColor = System.Drawing.Color.Transparent
        Me.gbxRefundDaysValid.Controls.Add(Me.Label20)
        Me.gbxRefundDaysValid.Controls.Add(Me.Label4)
        Me.gbxRefundDaysValid.Controls.Add(Me.Label5)
        Me.gbxRefundDaysValid.Controls.Add(Me.Label6)
        Me.gbxRefundDaysValid.Controls.Add(Me.Label7)
        Me.gbxRefundDaysValid.Controls.Add(Me.txtResVD)
        Me.gbxRefundDaysValid.Controls.Add(Me.txtResVDR)
        Me.gbxRefundDaysValid.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxRefundDaysValid.Location = New System.Drawing.Point(149, 237)
        Me.gbxRefundDaysValid.Name = "gbxRefundDaysValid"
        Me.gbxRefundDaysValid.Size = New System.Drawing.Size(826, 106)
        Me.gbxRefundDaysValid.TabIndex = 3
        Me.gbxRefundDaysValid.TabStop = False
        Me.gbxRefundDaysValid.Text = "Valid Days for a Reservation"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(317, 33)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(463, 49)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "This determines the number of days before a reservation is marked as No-Show"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(258, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Days"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(258, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Days"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Change To:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(81, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Current: "
        '
        'txtResVD
        '
        Me.txtResVD.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResVD.Location = New System.Drawing.Point(152, 61)
        Me.txtResVD.Name = "txtResVD"
        Me.txtResVD.Size = New System.Drawing.Size(100, 23)
        Me.txtResVD.TabIndex = 1
        Me.txtResVD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtResVDR
        '
        Me.txtResVDR.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResVDR.Location = New System.Drawing.Point(152, 35)
        Me.txtResVDR.Name = "txtResVDR"
        Me.txtResVDR.ReadOnly = True
        Me.txtResVDR.Size = New System.Drawing.Size(100, 23)
        Me.txtResVDR.TabIndex = 0
        Me.txtResVDR.TabStop = False
        Me.txtResVDR.Text = "0"
        Me.txtResVDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(259, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 18)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Days"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(259, 38)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 18)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Days"
        '
        'txtRefVDR
        '
        Me.txtRefVDR.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefVDR.Location = New System.Drawing.Point(152, 35)
        Me.txtRefVDR.Name = "txtRefVDR"
        Me.txtRefVDR.ReadOnly = True
        Me.txtRefVDR.Size = New System.Drawing.Size(100, 23)
        Me.txtRefVDR.TabIndex = 0
        Me.txtRefVDR.TabStop = False
        Me.txtRefVDR.Text = "0"
        Me.txtRefVDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(69, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 18)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Change To:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(85, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 18)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Current: "
        '
        'gbxReservationDownPayment
        '
        Me.gbxReservationDownPayment.BackColor = System.Drawing.Color.Transparent
        Me.gbxReservationDownPayment.Controls.Add(Me.Label18)
        Me.gbxReservationDownPayment.Controls.Add(Me.Label2)
        Me.gbxReservationDownPayment.Controls.Add(Me.Label15)
        Me.gbxReservationDownPayment.Controls.Add(Me.Label3)
        Me.gbxReservationDownPayment.Controls.Add(Me.Label10)
        Me.gbxReservationDownPayment.Controls.Add(Me.txtResD)
        Me.gbxReservationDownPayment.Controls.Add(Me.txtResDR)
        Me.gbxReservationDownPayment.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxReservationDownPayment.Location = New System.Drawing.Point(149, 29)
        Me.gbxReservationDownPayment.Name = "gbxReservationDownPayment"
        Me.gbxReservationDownPayment.Size = New System.Drawing.Size(826, 95)
        Me.gbxReservationDownPayment.TabIndex = 1
        Me.gbxReservationDownPayment.TabStop = False
        Me.gbxReservationDownPayment.Text = "Reservation Downpayment"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(317, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(463, 49)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "This setting will determine the default downpayment although this can be altered " & _
            "during the actual reservation. This setting will also help in determining the re" & _
            "sults of the No-Show Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "%"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(85, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 18)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Current: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(259, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(69, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 18)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Change To:"
        '
        'txtResD
        '
        Me.txtResD.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResD.Location = New System.Drawing.Point(152, 58)
        Me.txtResD.Name = "txtResD"
        Me.txtResD.Size = New System.Drawing.Size(100, 23)
        Me.txtResD.TabIndex = 2
        Me.txtResD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtResDR
        '
        Me.txtResDR.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResDR.Location = New System.Drawing.Point(152, 32)
        Me.txtResDR.Name = "txtResDR"
        Me.txtResDR.ReadOnly = True
        Me.txtResDR.Size = New System.Drawing.Size(100, 23)
        Me.txtResDR.TabIndex = 0
        Me.txtResDR.TabStop = False
        Me.txtResDR.Text = "0"
        Me.txtResDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(259, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(259, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "%"
        '
        'txtRefDR
        '
        Me.txtRefDR.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefDR.Location = New System.Drawing.Point(152, 31)
        Me.txtRefDR.Name = "txtRefDR"
        Me.txtRefDR.ReadOnly = True
        Me.txtRefDR.Size = New System.Drawing.Size(100, 23)
        Me.txtRefDR.TabIndex = 0
        Me.txtRefDR.TabStop = False
        Me.txtRefDR.Text = "0"
        Me.txtRefDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(67, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 18)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Change To:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(83, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 18)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Current: "
        '
        'gbxReservationDaysValid
        '
        Me.gbxReservationDaysValid.BackColor = System.Drawing.Color.Transparent
        Me.gbxReservationDaysValid.Controls.Add(Me.Label21)
        Me.gbxReservationDaysValid.Controls.Add(Me.Label13)
        Me.gbxReservationDaysValid.Controls.Add(Me.Label16)
        Me.gbxReservationDaysValid.Controls.Add(Me.Label9)
        Me.gbxReservationDaysValid.Controls.Add(Me.Label14)
        Me.gbxReservationDaysValid.Controls.Add(Me.txtRefVD)
        Me.gbxReservationDaysValid.Controls.Add(Me.txtRefVDR)
        Me.gbxReservationDaysValid.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxReservationDaysValid.Location = New System.Drawing.Point(149, 349)
        Me.gbxReservationDaysValid.Name = "gbxReservationDaysValid"
        Me.gbxReservationDaysValid.Size = New System.Drawing.Size(826, 106)
        Me.gbxReservationDaysValid.TabIndex = 4
        Me.gbxReservationDaysValid.TabStop = False
        Me.gbxReservationDaysValid.Text = "Valid Days for a Refund"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(317, 33)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(463, 49)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "This setting is used to determine the refunds that are already expired"
        '
        'txtRefVD
        '
        Me.txtRefVD.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefVD.Location = New System.Drawing.Point(152, 61)
        Me.txtRefVD.Name = "txtRefVD"
        Me.txtRefVD.Size = New System.Drawing.Size(100, 23)
        Me.txtRefVD.TabIndex = 1
        Me.txtRefVD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbxReservationPercentageOfDownpayment
        '
        Me.gbxReservationPercentageOfDownpayment.BackColor = System.Drawing.Color.Transparent
        Me.gbxReservationPercentageOfDownpayment.Controls.Add(Me.Label19)
        Me.gbxReservationPercentageOfDownpayment.Controls.Add(Me.Label8)
        Me.gbxReservationPercentageOfDownpayment.Controls.Add(Me.Label1)
        Me.gbxReservationPercentageOfDownpayment.Controls.Add(Me.Label11)
        Me.gbxReservationPercentageOfDownpayment.Controls.Add(Me.Label12)
        Me.gbxReservationPercentageOfDownpayment.Controls.Add(Me.txtRefD)
        Me.gbxReservationPercentageOfDownpayment.Controls.Add(Me.txtRefDR)
        Me.gbxReservationPercentageOfDownpayment.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxReservationPercentageOfDownpayment.Location = New System.Drawing.Point(149, 128)
        Me.gbxReservationPercentageOfDownpayment.Name = "gbxReservationPercentageOfDownpayment"
        Me.gbxReservationPercentageOfDownpayment.Size = New System.Drawing.Size(826, 106)
        Me.gbxReservationPercentageOfDownpayment.TabIndex = 2
        Me.gbxReservationPercentageOfDownpayment.TabStop = False
        Me.gbxReservationPercentageOfDownpayment.Text = "Refund Percentage"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(317, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(463, 49)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = resources.GetString("Label19.Text")
        '
        'txtRefD
        '
        Me.txtRefD.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefD.Location = New System.Drawing.Point(152, 57)
        Me.txtRefD.Name = "txtRefD"
        Me.txtRefD.Size = New System.Drawing.Size(100, 23)
        Me.txtRefD.TabIndex = 1
        Me.txtRefD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkPromptForRefund
        '
        Me.chkPromptForRefund.AutoSize = True
        Me.chkPromptForRefund.BackColor = System.Drawing.Color.Transparent
        Me.chkPromptForRefund.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPromptForRefund.Location = New System.Drawing.Point(157, 461)
        Me.chkPromptForRefund.Name = "chkPromptForRefund"
        Me.chkPromptForRefund.Size = New System.Drawing.Size(595, 22)
        Me.chkPromptForRefund.TabIndex = 5
        Me.chkPromptForRefund.Text = "&Prompt user to convert excess payments to a refund (payments of direct billers a" & _
            "re not included)"
        Me.chkPromptForRefund.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(154, 593)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(616, 23)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "NOTE: Tax are added at the Service And Amenities Form"
        '
        'txtReceipt
        '
        Me.txtReceipt.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceipt.Location = New System.Drawing.Point(320, 487)
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.ReadOnly = True
        Me.txtReceipt.Size = New System.Drawing.Size(369, 23)
        Me.txtReceipt.TabIndex = 7
        Me.txtReceipt.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(156, 492)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(158, 18)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "&Location of Payment Slip:"
        '
        'btnReceipt
        '
        Me.btnReceipt.AutoSize = True
        Me.btnReceipt.Location = New System.Drawing.Point(695, 487)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(29, 23)
        Me.btnReceipt.TabIndex = 8
        Me.btnReceipt.Text = "..."
        Me.btnReceipt.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 9)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(99, 61)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Billing Settings"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(945, 10)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(39, 18)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Close"
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
        Me.tsActivities.TabIndex = 11
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
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(176, 519)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(140, 18)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Amount In &Front Desk:"
        '
        'txtAmountInFrontDesk
        '
        Me.txtAmountInFrontDesk.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountInFrontDesk.Location = New System.Drawing.Point(320, 516)
        Me.txtAmountInFrontDesk.MaxLength = 15
        Me.txtAmountInFrontDesk.Name = "txtAmountInFrontDesk"
        Me.txtAmountInFrontDesk.Size = New System.Drawing.Size(187, 23)
        Me.txtAmountInFrontDesk.TabIndex = 10
        Me.txtAmountInFrontDesk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmSystemBillingInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtAmountInFrontDesk)
        Me.Controls.Add(Me.tsActivities)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btnReceipt)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtReceipt)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.chkPromptForRefund)
        Me.Controls.Add(Me.gbxRefundDaysValid)
        Me.Controls.Add(Me.gbxReservationDownPayment)
        Me.Controls.Add(Me.gbxReservationDaysValid)
        Me.Controls.Add(Me.gbxReservationPercentageOfDownpayment)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSystemBillingInfo"
        Me.Text = "Billing Settings"
        Me.gbxRefundDaysValid.ResumeLayout(False)
        Me.gbxRefundDaysValid.PerformLayout()
        Me.gbxReservationDownPayment.ResumeLayout(False)
        Me.gbxReservationDownPayment.PerformLayout()
        Me.gbxReservationDaysValid.ResumeLayout(False)
        Me.gbxReservationDaysValid.PerformLayout()
        Me.gbxReservationPercentageOfDownpayment.ResumeLayout(False)
        Me.gbxReservationPercentageOfDownpayment.PerformLayout()
        Me.tsActivities.ResumeLayout(False)
        Me.tsActivities.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents gbxRefundDaysValid As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRefVDR As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents gbxReservationDownPayment As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRefDR As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents gbxReservationDaysValid As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtResVDR As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gbxReservationPercentageOfDownpayment As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtResDR As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label

    Private Sub checkBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Friend WithEvents txtResVD As System.Windows.Forms.TextBox
    Friend WithEvents txtResD As System.Windows.Forms.TextBox
    Friend WithEvents txtRefD As System.Windows.Forms.TextBox
    Friend WithEvents txtRefVD As System.Windows.Forms.TextBox
    Friend WithEvents chkPromptForRefund As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtReceipt As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnReceipt As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents tsActivities As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtAmountInFrontDesk As System.Windows.Forms.TextBox
End Class
