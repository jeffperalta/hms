<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQueryShift
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
        Me.btnPrint = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtLoginRemarks2 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtRecompense = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTurnOver = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtReceivable = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCreditCard = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtBank = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCheque = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtOnHand = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCashOut = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtCash = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.lblFDO = New System.Windows.Forms.Label
        Me.lblLogOut = New System.Windows.Forms.Label
        Me.lblLogIn = New System.Windows.Forms.Label
        Me.lblShiftName = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.tsbQueryRmStat = New System.Windows.Forms.ToolStripButton
        Me.tss1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbQuerySettings = New System.Windows.Forms.ToolStripButton
        Me.tss2 = New System.Windows.Forms.ToolStripSeparator
        Me.Label11 = New System.Windows.Forms.Label
        Me.dgvShifts = New System.Windows.Forms.DataGridView
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtShiftRemarks = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtFDOName = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpTo = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.dgvFDOLogins = New System.Windows.Forms.DataGridView
        Me.tsActivities = New System.Windows.Forms.ToolStrip
        Me.tsbRoomStatusQuery = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbSettingsQuery = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.llbClose = New System.Windows.Forms.LinkLabel
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvShifts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgvFDOLogins, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsActivities.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(867, 584)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(113, 28)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "&Print Preview"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtLoginRemarks2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtRecompense)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtTurnOver)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtReceivable)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCreditCard)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtBank)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCheque)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtOnHand)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCashOut)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtCash)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.lblFDO)
        Me.GroupBox1.Controls.Add(Me.lblLogOut)
        Me.GroupBox1.Controls.Add(Me.lblLogIn)
        Me.GroupBox1.Controls.Add(Me.lblShiftName)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(686, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 551)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Shift/LogIn Information"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(20, 450)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 18)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Remarks:"
        '
        'txtLoginRemarks2
        '
        Me.txtLoginRemarks2.BackColor = System.Drawing.Color.White
        Me.txtLoginRemarks2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.txtLoginRemarks2.Location = New System.Drawing.Point(23, 471)
        Me.txtLoginRemarks2.MaxLength = 1000
        Me.txtLoginRemarks2.Multiline = True
        Me.txtLoginRemarks2.Name = "txtLoginRemarks2"
        Me.txtLoginRemarks2.ReadOnly = True
        Me.txtLoginRemarks2.Size = New System.Drawing.Size(253, 69)
        Me.txtLoginRemarks2.TabIndex = 32
        Me.txtLoginRemarks2.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(111, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "____________________"
        '
        'txtRecompense
        '
        Me.txtRecompense.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRecompense.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecompense.Location = New System.Drawing.Point(134, 206)
        Me.txtRecompense.MaxLength = 25
        Me.txtRecompense.Name = "txtRecompense"
        Me.txtRecompense.ReadOnly = True
        Me.txtRecompense.Size = New System.Drawing.Size(134, 23)
        Me.txtRecompense.TabIndex = 16
        Me.txtRecompense.TabStop = False
        Me.txtRecompense.Text = "0"
        Me.txtRecompense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 18)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Recompense:"
        '
        'txtTurnOver
        '
        Me.txtTurnOver.BackColor = System.Drawing.Color.White
        Me.txtTurnOver.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTurnOver.Location = New System.Drawing.Point(134, 400)
        Me.txtTurnOver.MaxLength = 25
        Me.txtTurnOver.Name = "txtTurnOver"
        Me.txtTurnOver.ReadOnly = True
        Me.txtTurnOver.Size = New System.Drawing.Size(134, 23)
        Me.txtTurnOver.TabIndex = 30
        Me.txtTurnOver.TabStop = False
        Me.txtTurnOver.Text = "0"
        Me.txtTurnOver.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 403)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Turn over:"
        '
        'txtReceivable
        '
        Me.txtReceivable.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtReceivable.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceivable.Location = New System.Drawing.Point(134, 301)
        Me.txtReceivable.MaxLength = 25
        Me.txtReceivable.Name = "txtReceivable"
        Me.txtReceivable.ReadOnly = True
        Me.txtReceivable.Size = New System.Drawing.Size(134, 23)
        Me.txtReceivable.TabIndex = 23
        Me.txtReceivable.TabStop = False
        Me.txtReceivable.Text = "0"
        Me.txtReceivable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Total Receivable:"
        '
        'txtCreditCard
        '
        Me.txtCreditCard.BackColor = System.Drawing.Color.White
        Me.txtCreditCard.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreditCard.Location = New System.Drawing.Point(134, 258)
        Me.txtCreditCard.MaxLength = 25
        Me.txtCreditCard.Name = "txtCreditCard"
        Me.txtCreditCard.ReadOnly = True
        Me.txtCreditCard.Size = New System.Drawing.Size(134, 23)
        Me.txtCreditCard.TabIndex = 20
        Me.txtCreditCard.TabStop = False
        Me.txtCreditCard.Text = "0"
        Me.txtCreditCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 18)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Total Credit Card:"
        '
        'txtBank
        '
        Me.txtBank.BackColor = System.Drawing.Color.White
        Me.txtBank.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBank.Location = New System.Drawing.Point(134, 232)
        Me.txtBank.MaxLength = 25
        Me.txtBank.Name = "txtBank"
        Me.txtBank.ReadOnly = True
        Me.txtBank.Size = New System.Drawing.Size(134, 23)
        Me.txtBank.TabIndex = 18
        Me.txtBank.TabStop = False
        Me.txtBank.Text = "0"
        Me.txtBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Total Bank:"
        '
        'txtCheque
        '
        Me.txtCheque.BackColor = System.Drawing.Color.White
        Me.txtCheque.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheque.Location = New System.Drawing.Point(134, 135)
        Me.txtCheque.MaxLength = 25
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.ReadOnly = True
        Me.txtCheque.Size = New System.Drawing.Size(134, 23)
        Me.txtCheque.TabIndex = 11
        Me.txtCheque.TabStop = False
        Me.txtCheque.Text = "0"
        Me.txtCheque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Total Cheque:"
        '
        'txtOnHand
        '
        Me.txtOnHand.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtOnHand.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOnHand.Location = New System.Drawing.Point(134, 180)
        Me.txtOnHand.MaxLength = 25
        Me.txtOnHand.Name = "txtOnHand"
        Me.txtOnHand.ReadOnly = True
        Me.txtOnHand.Size = New System.Drawing.Size(134, 23)
        Me.txtOnHand.TabIndex = 14
        Me.txtOnHand.TabStop = False
        Me.txtOnHand.Text = "0"
        Me.txtOnHand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "On Hand:"
        '
        'txtCashOut
        '
        Me.txtCashOut.BackColor = System.Drawing.Color.White
        Me.txtCashOut.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashOut.Location = New System.Drawing.Point(134, 375)
        Me.txtCashOut.MaxLength = 25
        Me.txtCashOut.Name = "txtCashOut"
        Me.txtCashOut.ReadOnly = True
        Me.txtCashOut.Size = New System.Drawing.Size(134, 23)
        Me.txtCashOut.TabIndex = 28
        Me.txtCashOut.TabStop = False
        Me.txtCashOut.Text = "0"
        Me.txtCashOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 378)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 18)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Cash Out:"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTotal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(134, 347)
        Me.txtTotal.MaxLength = 25
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(134, 23)
        Me.txtTotal.TabIndex = 26
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 350)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 18)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Total Sales:"
        '
        'txtCash
        '
        Me.txtCash.BackColor = System.Drawing.Color.White
        Me.txtCash.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(134, 109)
        Me.txtCash.MaxLength = 25
        Me.txtCash.Name = "txtCash"
        Me.txtCash.ReadOnly = True
        Me.txtCash.Size = New System.Drawing.Size(134, 23)
        Me.txtCash.TabIndex = 9
        Me.txtCash.TabStop = False
        Me.txtCash.Text = "0"
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 18)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Total Cash:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(111, 281)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(168, 16)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "____________________"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(100, 326)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(168, 16)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "____________________"
        '
        'lblFDO
        '
        Me.lblFDO.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFDO.Location = New System.Drawing.Point(139, 40)
        Me.lblFDO.Name = "lblFDO"
        Me.lblFDO.Size = New System.Drawing.Size(132, 18)
        Me.lblFDO.TabIndex = 3
        Me.lblFDO.Text = "All"
        '
        'lblLogOut
        '
        Me.lblLogOut.AutoSize = True
        Me.lblLogOut.BackColor = System.Drawing.Color.Transparent
        Me.lblLogOut.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOut.Location = New System.Drawing.Point(69, 81)
        Me.lblLogOut.Name = "lblLogOut"
        Me.lblLogOut.Size = New System.Drawing.Size(31, 18)
        Me.lblLogOut.TabIndex = 7
        Me.lblLogOut.Text = "N/A"
        '
        'lblLogIn
        '
        Me.lblLogIn.AutoSize = True
        Me.lblLogIn.BackColor = System.Drawing.Color.Transparent
        Me.lblLogIn.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogIn.Location = New System.Drawing.Point(61, 58)
        Me.lblLogIn.Name = "lblLogIn"
        Me.lblLogIn.Size = New System.Drawing.Size(31, 18)
        Me.lblLogIn.TabIndex = 5
        Me.lblLogIn.Text = "N/A"
        '
        'lblShiftName
        '
        Me.lblShiftName.AutoSize = True
        Me.lblShiftName.BackColor = System.Drawing.Color.Transparent
        Me.lblShiftName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShiftName.Location = New System.Drawing.Point(52, 19)
        Me.lblShiftName.Name = "lblShiftName"
        Me.lblShiftName.Size = New System.Drawing.Size(31, 18)
        Me.lblShiftName.TabIndex = 1
        Me.lblShiftName.Text = "N/A"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(15, 81)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 18)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Log Out:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 18)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Log In:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 18)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Shift:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 18)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Front Desk Officer:"
        '
        'tsbQueryRmStat
        '
        Me.tsbQueryRmStat.AutoSize = False
        Me.tsbQueryRmStat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbQueryRmStat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQueryRmStat.Name = "tsbQueryRmStat"
        Me.tsbQueryRmStat.Size = New System.Drawing.Size(120, 30)
        Me.tsbQueryRmStat.Text = "Room Status Query"
        Me.tsbQueryRmStat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss1
        '
        Me.tss1.Name = "tss1"
        Me.tss1.Size = New System.Drawing.Size(111, 6)
        '
        'tsbQuerySettings
        '
        Me.tsbQuerySettings.AutoSize = False
        Me.tsbQuerySettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbQuerySettings.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbQuerySettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbQuerySettings.Name = "tsbQuerySettings"
        Me.tsbQuerySettings.Size = New System.Drawing.Size(120, 30)
        Me.tsbQuerySettings.Text = "Settings Query"
        Me.tsbQuerySettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss2
        '
        Me.tss2.Name = "tss2"
        Me.tss2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tss2.Size = New System.Drawing.Size(111, 6)
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-1, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 45)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "FDO Shift Query"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvShifts
        '
        Me.dgvShifts.AllowUserToAddRows = False
        Me.dgvShifts.AllowUserToDeleteRows = False
        Me.dgvShifts.AllowUserToOrderColumns = True
        Me.dgvShifts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvShifts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvShifts.Location = New System.Drawing.Point(6, 21)
        Me.dgvShifts.MultiSelect = False
        Me.dgvShifts.Name = "dgvShifts"
        Me.dgvShifts.ReadOnly = True
        Me.dgvShifts.RowHeadersVisible = False
        Me.dgvShifts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvShifts.Size = New System.Drawing.Size(526, 112)
        Me.dgvShifts.TabIndex = 3
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.txtShiftRemarks)
        Me.GroupBox5.Controls.Add(Me.dgvShifts)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(142, 25)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(538, 180)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Shifts"
        '
        'txtShiftRemarks
        '
        Me.txtShiftRemarks.BackColor = System.Drawing.Color.White
        Me.txtShiftRemarks.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.txtShiftRemarks.Location = New System.Drawing.Point(66, 141)
        Me.txtShiftRemarks.MaxLength = 1000
        Me.txtShiftRemarks.Multiline = True
        Me.txtShiftRemarks.Name = "txtShiftRemarks"
        Me.txtShiftRemarks.ReadOnly = True
        Me.txtShiftRemarks.Size = New System.Drawing.Size(466, 23)
        Me.txtShiftRemarks.TabIndex = 5
        Me.txtShiftRemarks.TabStop = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(3, 141)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 18)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Remarks:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(7, 56)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(93, 18)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "FDO &Name/ID:"
        '
        'txtFDOName
        '
        Me.txtFDOName.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFDOName.Location = New System.Drawing.Point(112, 56)
        Me.txtFDOName.MaxLength = 50
        Me.txtFDOName.Name = "txtFDOName"
        Me.txtFDOName.Size = New System.Drawing.Size(227, 23)
        Me.txtFDOName.TabIndex = 1
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.dtpFrom)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.txtFDOName)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.dtpTo)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.dgvFDOLogins)
        Me.GroupBox6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(142, 208)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(538, 374)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "FDO Login Information"
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = "MMMM dd, yyyy"
        Me.dtpFrom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(88, 22)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(152, 23)
        Me.dtpFrom.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Date &From:"
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = "MMMM dd, yyyy"
        Me.dtpTo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(303, 21)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(152, 23)
        Me.dtpTo.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(246, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 18)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Date &To:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(7, 77)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(79, 18)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "FDO Logins:"
        '
        'dgvFDOLogins
        '
        Me.dgvFDOLogins.AllowUserToAddRows = False
        Me.dgvFDOLogins.AllowUserToDeleteRows = False
        Me.dgvFDOLogins.AllowUserToOrderColumns = True
        Me.dgvFDOLogins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvFDOLogins.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvFDOLogins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFDOLogins.Location = New System.Drawing.Point(6, 98)
        Me.dgvFDOLogins.MultiSelect = False
        Me.dgvFDOLogins.Name = "dgvFDOLogins"
        Me.dgvFDOLogins.ReadOnly = True
        Me.dgvFDOLogins.RowHeadersVisible = False
        Me.dgvFDOLogins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFDOLogins.Size = New System.Drawing.Size(526, 270)
        Me.dgvFDOLogins.TabIndex = 5
        '
        'tsActivities
        '
        Me.tsActivities.AutoSize = False
        Me.tsActivities.BackColor = System.Drawing.Color.Transparent
        Me.tsActivities.Dock = System.Windows.Forms.DockStyle.None
        Me.tsActivities.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsActivities.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsActivities.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.tsActivities.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbRoomStatusQuery, Me.ToolStripSeparator1, Me.tsbSettingsQuery, Me.ToolStripSeparator2})
        Me.tsActivities.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsActivities.Location = New System.Drawing.Point(1, 79)
        Me.tsActivities.Name = "tsActivities"
        Me.tsActivities.ShowItemToolTips = False
        Me.tsActivities.Size = New System.Drawing.Size(114, 311)
        Me.tsActivities.TabIndex = 6
        Me.tsActivities.Text = "ToolStrip2"
        '
        'tsbRoomStatusQuery
        '
        Me.tsbRoomStatusQuery.AutoSize = False
        Me.tsbRoomStatusQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbRoomStatusQuery.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbRoomStatusQuery.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRoomStatusQuery.Name = "tsbRoomStatusQuery"
        Me.tsbRoomStatusQuery.Size = New System.Drawing.Size(120, 30)
        Me.tsbRoomStatusQuery.Text = "Room Status Query"
        Me.tsbRoomStatusQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(112, 6)
        '
        'tsbSettingsQuery
        '
        Me.tsbSettingsQuery.AutoSize = False
        Me.tsbSettingsQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbSettingsQuery.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbSettingsQuery.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSettingsQuery.Name = "tsbSettingsQuery"
        Me.tsbSettingsQuery.Size = New System.Drawing.Size(120, 30)
        Me.tsbSettingsQuery.Text = "Settings Query"
        Me.tsbSettingsQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(112, 6)
        '
        'llbClose
        '
        Me.llbClose.AutoSize = True
        Me.llbClose.BackColor = System.Drawing.Color.Transparent
        Me.llbClose.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbClose.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.llbClose.Location = New System.Drawing.Point(945, 10)
        Me.llbClose.Name = "llbClose"
        Me.llbClose.Size = New System.Drawing.Size(39, 18)
        Me.llbClose.TabIndex = 7
        Me.llbClose.TabStop = True
        Me.llbClose.Text = "Close"
        '
        'frmQueryShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.llbClose)
        Me.Controls.Add(Me.tsActivities)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 80)
        Me.Name = "frmQueryShift"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SLU Hotel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvShifts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.dgvFDOLogins, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsActivities.ResumeLayout(False)
        Me.tsActivities.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLogOut As System.Windows.Forms.Label
    Friend WithEvents lblLogIn As System.Windows.Forms.Label
    Friend WithEvents lblShiftName As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tsbQueryRmStat As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbQuerySettings As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgvShifts As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtFDOName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvFDOLogins As System.Windows.Forms.DataGridView
    Friend WithEvents lblFDO As System.Windows.Forms.Label
    Private WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtShiftRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRecompense As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTurnOver As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtReceivable As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCreditCard As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtOnHand As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCashOut As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtLoginRemarks2 As System.Windows.Forms.TextBox
    Friend WithEvents tsActivities As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbRoomStatusQuery As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbSettingsQuery As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents llbClose As System.Windows.Forms.LinkLabel
End Class
