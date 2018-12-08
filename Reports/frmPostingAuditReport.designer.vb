<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPostingAuditReport
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpAmenitiesTo = New System.Windows.Forms.DateTimePicker
        Me.dtpAmenitiesDateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkAllAmen = New System.Windows.Forms.CheckBox
        Me.clbAmenities = New System.Windows.Forms.CheckedListBox
        Me.btnPrintPreview = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.clbSettlement = New System.Windows.Forms.CheckedListBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpSettlementTo = New System.Windows.Forms.DateTimePicker
        Me.dtpSettlementDateFrome = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dtpAdjustmentsDateFrom = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpAdjustmentsTo = New System.Windows.Forms.DateTimePicker
        Me.chkAllAdjustments = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.clbAdjustments = New System.Windows.Forms.CheckedListBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.tsActivities = New System.Windows.Forms.ToolStrip
        Me.tsbSalesStatRep = New System.Windows.Forms.ToolStripButton
        Me.tss1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbShiftSalesRep = New System.Windows.Forms.ToolStripButton
        Me.tss4 = New System.Windows.Forms.ToolStripSeparator
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tsActivities.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpAmenitiesTo)
        Me.GroupBox1.Controls.Add(Me.dtpAmenitiesDateFrom)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.chkAllAmen)
        Me.GroupBox1.Controls.Add(Me.clbAmenities)
        Me.GroupBox1.Location = New System.Drawing.Point(143, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 157)
        Me.GroupBox1.TabIndex = 225
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Amenities"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(187, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 149
        Me.Label2.Text = "To:"
        '
        'dtpAmenitiesTo
        '
        Me.dtpAmenitiesTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAmenitiesTo.Location = New System.Drawing.Point(218, 20)
        Me.dtpAmenitiesTo.Name = "dtpAmenitiesTo"
        Me.dtpAmenitiesTo.Size = New System.Drawing.Size(104, 20)
        Me.dtpAmenitiesTo.TabIndex = 148
        '
        'dtpAmenitiesDateFrom
        '
        Me.dtpAmenitiesDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAmenitiesDateFrom.Location = New System.Drawing.Point(68, 19)
        Me.dtpAmenitiesDateFrom.Name = "dtpAmenitiesDateFrom"
        Me.dtpAmenitiesDateFrom.Size = New System.Drawing.Size(104, 20)
        Me.dtpAmenitiesDateFrom.TabIndex = 147
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "Date From:"
        '
        'chkAllAmen
        '
        Me.chkAllAmen.AutoSize = True
        Me.chkAllAmen.Location = New System.Drawing.Point(6, 50)
        Me.chkAllAmen.Name = "chkAllAmen"
        Me.chkAllAmen.Size = New System.Drawing.Size(88, 17)
        Me.chkAllAmen.TabIndex = 144
        Me.chkAllAmen.Text = "All Amenities:"
        Me.chkAllAmen.UseVisualStyleBackColor = True
        '
        'clbAmenities
        '
        Me.clbAmenities.FormattingEnabled = True
        Me.clbAmenities.Items.AddRange(New Object() {"Spa", "Gym", "Long-distance Call", "Local Call", "Housekeeping", "Coffee Shop", "Restaurant", "Breakfast"})
        Me.clbAmenities.Location = New System.Drawing.Point(6, 72)
        Me.clbAmenities.Name = "clbAmenities"
        Me.clbAmenities.Size = New System.Drawing.Size(150, 79)
        Me.clbAmenities.TabIndex = 142
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.AutoSize = True
        Me.btnPrintPreview.Location = New System.Drawing.Point(852, 591)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(84, 25)
        Me.btnPrintPreview.TabIndex = 222
        Me.btnPrintPreview.Text = "Print Preview"
        Me.btnPrintPreview.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.clbSettlement)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.dtpSettlementTo)
        Me.GroupBox3.Controls.Add(Me.dtpSettlementDateFrome)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(143, 349)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(337, 164)
        Me.GroupBox3.TabIndex = 224
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Settlement"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(9, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 197
        Me.Label6.Text = "Settlement:"
        '
        'clbSettlement
        '
        Me.clbSettlement.FormattingEnabled = True
        Me.clbSettlement.Items.AddRange(New Object() {"Cash", "Master Credit Card", "Visa Card", "Cheque", "Bank Transfer", "Payment Using Refund"})
        Me.clbSettlement.Location = New System.Drawing.Point(12, 59)
        Me.clbSettlement.Name = "clbSettlement"
        Me.clbSettlement.Size = New System.Drawing.Size(310, 94)
        Me.clbSettlement.TabIndex = 147
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(187, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 145
        Me.Label7.Text = "To:"
        '
        'dtpSettlementTo
        '
        Me.dtpSettlementTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSettlementTo.Location = New System.Drawing.Point(218, 17)
        Me.dtpSettlementTo.Name = "dtpSettlementTo"
        Me.dtpSettlementTo.Size = New System.Drawing.Size(104, 20)
        Me.dtpSettlementTo.TabIndex = 144
        '
        'dtpSettlementDateFrome
        '
        Me.dtpSettlementDateFrome.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSettlementDateFrome.Location = New System.Drawing.Point(68, 16)
        Me.dtpSettlementDateFrome.Name = "dtpSettlementDateFrome"
        Me.dtpSettlementDateFrome.Size = New System.Drawing.Size(104, 20)
        Me.dtpSettlementDateFrome.TabIndex = 143
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(6, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 142
        Me.Label9.Text = "Date From:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.dtpAdjustmentsDateFrom)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dtpAdjustmentsTo)
        Me.GroupBox2.Controls.Add(Me.chkAllAdjustments)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.clbAdjustments)
        Me.GroupBox2.Location = New System.Drawing.Point(143, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(337, 157)
        Me.GroupBox2.TabIndex = 223
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Adjustments"
        '
        'dtpAdjustmentsDateFrom
        '
        Me.dtpAdjustmentsDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAdjustmentsDateFrom.Location = New System.Drawing.Point(75, 20)
        Me.dtpAdjustmentsDateFrom.Name = "dtpAdjustmentsDateFrom"
        Me.dtpAdjustmentsDateFrom.Size = New System.Drawing.Size(100, 20)
        Me.dtpAdjustmentsDateFrom.TabIndex = 209
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(10, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 208
        Me.Label5.Text = "Date From:"
        '
        'dtpAdjustmentsTo
        '
        Me.dtpAdjustmentsTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAdjustmentsTo.Location = New System.Drawing.Point(223, 20)
        Me.dtpAdjustmentsTo.Name = "dtpAdjustmentsTo"
        Me.dtpAdjustmentsTo.Size = New System.Drawing.Size(100, 20)
        Me.dtpAdjustmentsTo.TabIndex = 210
        '
        'chkAllAdjustments
        '
        Me.chkAllAdjustments.AutoSize = True
        Me.chkAllAdjustments.Location = New System.Drawing.Point(9, 46)
        Me.chkAllAdjustments.Name = "chkAllAdjustments"
        Me.chkAllAdjustments.Size = New System.Drawing.Size(100, 17)
        Me.chkAllAdjustments.TabIndex = 143
        Me.chkAllAdjustments.Text = "All Adjustments:"
        Me.chkAllAdjustments.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(194, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 211
        Me.Label8.Text = "To:"
        '
        'clbAdjustments
        '
        Me.clbAdjustments.FormattingEnabled = True
        Me.clbAdjustments.Items.AddRange(New Object() {"Late Check Out", "Early Check Out", "Extensions", "Room Transfer", "Avail New Room"})
        Me.clbAdjustments.Location = New System.Drawing.Point(9, 69)
        Me.clbAdjustments.Name = "clbAdjustments"
        Me.clbAdjustments.Size = New System.Drawing.Size(150, 79)
        Me.clbAdjustments.TabIndex = 139
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(942, 591)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 25)
        Me.btnClose.TabIndex = 221
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tsActivities
        '
        Me.tsActivities.AutoSize = False
        Me.tsActivities.BackColor = System.Drawing.Color.Transparent
        Me.tsActivities.Dock = System.Windows.Forms.DockStyle.None
        Me.tsActivities.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsActivities.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.tsActivities.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSalesStatRep, Me.tss1, Me.tsbShiftSalesRep, Me.tss4})
        Me.tsActivities.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsActivities.Location = New System.Drawing.Point(5, 80)
        Me.tsActivities.Name = "tsActivities"
        Me.tsActivities.Size = New System.Drawing.Size(113, 315)
        Me.tsActivities.TabIndex = 219
        Me.tsActivities.Text = "ToolStrip2"
        '
        'tsbSalesStatRep
        '
        Me.tsbSalesStatRep.AutoSize = False
        Me.tsbSalesStatRep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsbSalesStatRep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbSalesStatRep.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalesStatRep.Name = "tsbSalesStatRep"
        Me.tsbSalesStatRep.Size = New System.Drawing.Size(120, 30)
        Me.tsbSalesStatRep.Text = "Sales Status Report"
        Me.tsbSalesStatRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss1
        '
        Me.tss1.Name = "tss1"
        Me.tss1.Size = New System.Drawing.Size(111, 6)
        '
        'tsbShiftSalesRep
        '
        Me.tsbShiftSalesRep.AutoSize = False
        Me.tsbShiftSalesRep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbShiftSalesRep.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbShiftSalesRep.Name = "tsbShiftSalesRep"
        Me.tsbShiftSalesRep.Size = New System.Drawing.Size(120, 30)
        Me.tsbShiftSalesRep.Text = "Shift Sales Report"
        Me.tsbShiftSalesRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss4
        '
        Me.tss4.Name = "tss4"
        Me.tss4.Size = New System.Drawing.Size(111, 6)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 47)
        Me.Label1.TabIndex = 220
        Me.Label1.Text = "Posting Audit Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPostingAuditReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1019, 633)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnPrintPreview)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tsActivities)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 80)
        Me.Name = "frmPostingAuditReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SLU Hotel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tsActivities.ResumeLayout(False)
        Me.tsActivities.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpAmenitiesTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAmenitiesDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkAllAmen As System.Windows.Forms.CheckBox
    Friend WithEvents clbAmenities As System.Windows.Forms.CheckedListBox
    Private WithEvents btnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents clbSettlement As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpSettlementTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpSettlementDateFrome As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpAdjustmentsDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpAdjustmentsTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkAllAdjustments As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents clbAdjustments As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents tsActivities As System.Windows.Forms.ToolStrip
    Public WithEvents tsbSalesStatRep As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbShiftSalesRep As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
