<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesStatRep
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
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.tsActivities = New System.Windows.Forms.ToolStrip
        Me.tsbPostAudRep = New System.Windows.Forms.ToolStripButton
        Me.tss2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbShiftSalesRep = New System.Windows.Forms.ToolStripButton
        Me.tss3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsActivities.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.Location = New System.Drawing.Point(146, 109)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(146, 17)
        Me.RadioButton3.TabIndex = 232
        Me.RadioButton3.Text = "Uncollectibles/Bad Debts"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(208, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 225
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(143, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 224
        Me.Label4.Text = "Date From:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(343, 19)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 226
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(314, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 227
        Me.Label2.Text = "To:"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Location = New System.Drawing.Point(146, 76)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(81, 17)
        Me.RadioButton2.TabIndex = 231
        Me.RadioButton2.Text = "Registration"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"No-Show", "Reservation Master", "Reservation Activity Log", "Expected Arrival", "Cancelled Reservations"})
        Me.ComboBox1.Location = New System.Drawing.Point(234, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(222, 21)
        Me.ComboBox1.TabIndex = 228
        Me.ComboBox1.Text = "No-Show"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Registration Activity Log", "Expected Departure"})
        Me.ComboBox2.Location = New System.Drawing.Point(234, 75)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(222, 21)
        Me.ComboBox2.TabIndex = 230
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(146, 49)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(82, 17)
        Me.RadioButton1.TabIndex = 229
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Reservation"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(852, 591)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 25)
        Me.Button1.TabIndex = 223
        Me.Button1.Text = "Print Preview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.AutoSize = True
        Me.Button8.Location = New System.Drawing.Point(942, 591)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(60, 25)
        Me.Button8.TabIndex = 222
        Me.Button8.Text = "Close"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = "Re"
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 50)
        Me.Label1.TabIndex = 221
        Me.Label1.Text = "Sales Status Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tsActivities
        '
        Me.tsActivities.AutoSize = False
        Me.tsActivities.BackColor = System.Drawing.Color.Transparent
        Me.tsActivities.Dock = System.Windows.Forms.DockStyle.None
        Me.tsActivities.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsActivities.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.tsActivities.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbPostAudRep, Me.tss2, Me.tsbShiftSalesRep, Me.tss3})
        Me.tsActivities.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsActivities.Location = New System.Drawing.Point(5, 80)
        Me.tsActivities.Name = "tsActivities"
        Me.tsActivities.Size = New System.Drawing.Size(113, 315)
        Me.tsActivities.TabIndex = 220
        Me.tsActivities.Text = "ToolStrip2"
        '
        'tsbPostAudRep
        '
        Me.tsbPostAudRep.AutoSize = False
        Me.tsbPostAudRep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbPostAudRep.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPostAudRep.Name = "tsbPostAudRep"
        Me.tsbPostAudRep.Size = New System.Drawing.Size(120, 30)
        Me.tsbPostAudRep.Text = "Posting Audit Report"
        Me.tsbPostAudRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss2
        '
        Me.tss2.Name = "tss2"
        Me.tss2.Size = New System.Drawing.Size(111, 6)
        '
        'tsbShiftSalesRep
        '
        Me.tsbShiftSalesRep.AutoSize = False
        Me.tsbShiftSalesRep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbShiftSalesRep.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbShiftSalesRep.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbShiftSalesRep.Name = "tsbShiftSalesRep"
        Me.tsbShiftSalesRep.Size = New System.Drawing.Size(120, 30)
        Me.tsbShiftSalesRep.Text = "Shift Sales Report"
        Me.tsbShiftSalesRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tss3
        '
        Me.tss3.Name = "tss3"
        Me.tss3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tss3.Size = New System.Drawing.Size(111, 6)
        '
        'frmSalesStatRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1019, 633)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tsActivities)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(0, 80)
        Me.Name = "frmSalesStatRep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SLU Hotel"
        Me.tsActivities.ResumeLayout(False)
        Me.tsActivities.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tsActivities As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbPostAudRep As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbShiftSalesRep As System.Windows.Forms.ToolStripButton
    Friend WithEvents tss3 As System.Windows.Forms.ToolStripSeparator
End Class
