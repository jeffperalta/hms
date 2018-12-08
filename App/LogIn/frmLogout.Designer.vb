<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogout
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.radLogOutAndEndShift = New System.Windows.Forms.RadioButton
        Me.radLogOut = New System.Windows.Forms.RadioButton
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.lvwSummary = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblReq = New System.Windows.Forms.Label
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTurnOver = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCashOut = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lswSalesInfo = New System.Windows.Forms.ListView
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.gbxEndShiftInformation = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lsvTotals = New System.Windows.Forms.ListView
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.txtTime = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxEndShiftInformation.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'radLogOutAndEndShift
        '
        Me.radLogOutAndEndShift.AutoSize = True
        Me.radLogOutAndEndShift.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLogOutAndEndShift.Location = New System.Drawing.Point(492, 243)
        Me.radLogOutAndEndShift.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radLogOutAndEndShift.Name = "radLogOutAndEndShift"
        Me.radLogOutAndEndShift.Size = New System.Drawing.Size(79, 22)
        Me.radLogOutAndEndShift.TabIndex = 2
        Me.radLogOutAndEndShift.Text = "&End Shift"
        Me.radLogOutAndEndShift.UseVisualStyleBackColor = True
        '
        'radLogOut
        '
        Me.radLogOut.AutoSize = True
        Me.radLogOut.Checked = True
        Me.radLogOut.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLogOut.Location = New System.Drawing.Point(414, 243)
        Me.radLogOut.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radLogOut.Name = "radLogOut"
        Me.radLogOut.Size = New System.Drawing.Size(72, 22)
        Me.radLogOut.TabIndex = 1
        Me.radLogOut.TabStop = True
        Me.radLogOut.Text = "&Resume"
        Me.radLogOut.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.AutoSize = True
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(494, 405)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(77, 28)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        '
        'OK
        '
        Me.OK.AutoSize = True
        Me.OK.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.Location = New System.Drawing.Point(421, 405)
        Me.OK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(67, 28)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&OK"
        '
        'lvwSummary
        '
        Me.lvwSummary.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvwSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwSummary.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwSummary.FullRowSelect = True
        Me.lvwSummary.GridLines = True
        Me.lvwSummary.Location = New System.Drawing.Point(3, 3)
        Me.lvwSummary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lvwSummary.Name = "lvwSummary"
        Me.lvwSummary.Size = New System.Drawing.Size(376, 194)
        Me.lvwSummary.TabIndex = 0
        Me.lvwSummary.UseCompatibleStateImageBehavior = False
        Me.lvwSummary.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Information"
        Me.ColumnHeader1.Width = 166
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Details"
        Me.ColumnHeader2.Width = 203
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Res_LogIn
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 440)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'lblReq
        '
        Me.lblReq.AutoSize = True
        Me.lblReq.BackColor = System.Drawing.Color.Transparent
        Me.lblReq.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReq.ForeColor = System.Drawing.Color.Red
        Me.lblReq.Location = New System.Drawing.Point(8, 114)
        Me.lblReq.Name = "lblReq"
        Me.lblReq.Size = New System.Drawing.Size(173, 16)
        Me.lblReq.TabIndex = 8
        Me.lblReq.Text = "NOTE: Fields with * are required." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.White
        Me.txtRemarks.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(220, 52)
        Me.txtRemarks.MaxLength = 1000
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(160, 57)
        Me.txtRemarks.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(217, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "&Remarks:"
        '
        'txtTurnOver
        '
        Me.txtTurnOver.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTurnOver.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTurnOver.Location = New System.Drawing.Point(111, 57)
        Me.txtTurnOver.MaxLength = 25
        Me.txtTurnOver.Name = "txtTurnOver"
        Me.txtTurnOver.ReadOnly = True
        Me.txtTurnOver.Size = New System.Drawing.Size(100, 23)
        Me.txtTurnOver.TabIndex = 4
        Me.txtTurnOver.TabStop = False
        Me.txtTurnOver.Text = "0.00"
        Me.txtTurnOver.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Turn over"
        '
        'txtCashOut
        '
        Me.txtCashOut.BackColor = System.Drawing.Color.White
        Me.txtCashOut.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashOut.Location = New System.Drawing.Point(111, 86)
        Me.txtCashOut.MaxLength = 25
        Me.txtCashOut.Name = "txtCashOut"
        Me.txtCashOut.Size = New System.Drawing.Size(100, 23)
        Me.txtCashOut.TabIndex = 7
        Me.txtCashOut.Text = "0.00"
        Me.txtCashOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "&Cash Out"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTotal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(111, 28)
        Me.txtTotal.MaxLength = 25
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 23)
        Me.txtTotal.TabIndex = 1
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = "0.00"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 22)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Total Sales"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(34, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 19)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "*"
        '
        'lswSalesInfo
        '
        Me.lswSalesInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lswSalesInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lswSalesInfo.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lswSalesInfo.FullRowSelect = True
        Me.lswSalesInfo.GridLines = True
        Me.lswSalesInfo.Location = New System.Drawing.Point(3, 3)
        Me.lswSalesInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lswSalesInfo.Name = "lswSalesInfo"
        Me.lswSalesInfo.Size = New System.Drawing.Size(376, 110)
        Me.lswSalesInfo.TabIndex = 10
        Me.lswSalesInfo.UseCompatibleStateImageBehavior = False
        Me.lswSalesInfo.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Information"
        Me.ColumnHeader3.Width = 166
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Details"
        Me.ColumnHeader4.Width = 203
        '
        'gbxEndShiftInformation
        '
        Me.gbxEndShiftInformation.Controls.Add(Me.lblReq)
        Me.gbxEndShiftInformation.Controls.Add(Me.txtCashOut)
        Me.gbxEndShiftInformation.Controls.Add(Me.txtRemarks)
        Me.gbxEndShiftInformation.Controls.Add(Me.Label6)
        Me.gbxEndShiftInformation.Controls.Add(Me.txtTurnOver)
        Me.gbxEndShiftInformation.Controls.Add(Me.Label12)
        Me.gbxEndShiftInformation.Controls.Add(Me.Label1)
        Me.gbxEndShiftInformation.Controls.Add(Me.txtTotal)
        Me.gbxEndShiftInformation.Controls.Add(Me.Label5)
        Me.gbxEndShiftInformation.Controls.Add(Me.Label14)
        Me.gbxEndShiftInformation.Enabled = False
        Me.gbxEndShiftInformation.Location = New System.Drawing.Point(188, 263)
        Me.gbxEndShiftInformation.Name = "gbxEndShiftInformation"
        Me.gbxEndShiftInformation.Size = New System.Drawing.Size(386, 136)
        Me.gbxEndShiftInformation.TabIndex = 3
        Me.gbxEndShiftInformation.TabStop = False
        Me.gbxEndShiftInformation.Text = "End Shift Information"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(191, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(390, 231)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lvwSummary)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(382, 200)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Shift Info"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lsvTotals)
        Me.TabPage2.Controls.Add(Me.lswSalesInfo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(382, 200)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sales Info"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lsvTotals
        '
        Me.lsvTotals.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lsvTotals.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lsvTotals.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvTotals.FullRowSelect = True
        Me.lsvTotals.GridLines = True
        Me.lsvTotals.Location = New System.Drawing.Point(3, 117)
        Me.lsvTotals.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lsvTotals.Name = "lsvTotals"
        Me.lsvTotals.Size = New System.Drawing.Size(376, 80)
        Me.lsvTotals.TabIndex = 11
        Me.lsvTotals.UseCompatibleStateImageBehavior = False
        Me.lsvTotals.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Information"
        Me.ColumnHeader5.Width = 166
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Totals"
        Me.ColumnHeader6.Width = 203
        '
        'txtTime
        '
        Me.txtTime.AutoSize = True
        Me.txtTime.BackColor = System.Drawing.Color.Transparent
        Me.txtTime.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(195, 410)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(0, 18)
        Me.txtTime.TabIndex = 361
        '
        'frmLogout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 440)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.radLogOutAndEndShift)
        Me.Controls.Add(Me.radLogOut)
        Me.Controls.Add(Me.gbxEndShiftInformation)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmLogout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<Code will generate text here>"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxEndShiftInformation.ResumeLayout(False)
        Me.gbxEndShiftInformation.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents radLogOutAndEndShift As System.Windows.Forms.RadioButton
    Friend WithEvents radLogOut As System.Windows.Forms.RadioButton
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents lvwSummary As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblReq As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTurnOver As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCashOut As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lswSalesInfo As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents gbxEndShiftInformation As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtTime As System.Windows.Forms.Label
    Friend WithEvents lsvTotals As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
End Class
