<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestrictionSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRestrictionSettings))
        Me.tlsRoomSettings = New System.Windows.Forms.ToolStrip
        Me.tsbSystemSettings = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.Label11 = New System.Windows.Forms.Label
        Me.chkReservation = New System.Windows.Forms.CheckBox
        Me.chkShift = New System.Windows.Forms.CheckBox
        Me.chkRegistration = New System.Windows.Forms.CheckBox
        Me.chkGuestFolio = New System.Windows.Forms.CheckBox
        Me.chkModification = New System.Windows.Forms.CheckBox
        Me.chkUncollectibles = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.chkRefunds = New System.Windows.Forms.CheckBox
        Me.chkDirectBillers = New System.Windows.Forms.CheckBox
        Me.lblReq = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.tlsRoomSettings.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlsRoomSettings
        '
        Me.tlsRoomSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tlsRoomSettings.AutoSize = False
        Me.tlsRoomSettings.BackColor = System.Drawing.Color.Transparent
        Me.tlsRoomSettings.Dock = System.Windows.Forms.DockStyle.None
        Me.tlsRoomSettings.Font = New System.Drawing.Font("Trebuchet MS", 8.25!)
        Me.tlsRoomSettings.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tlsRoomSettings.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.tlsRoomSettings.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSystemSettings, Me.ToolStripSeparator1})
        Me.tlsRoomSettings.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tlsRoomSettings.Location = New System.Drawing.Point(2, 78)
        Me.tlsRoomSettings.Name = "tlsRoomSettings"
        Me.tlsRoomSettings.Size = New System.Drawing.Size(112, 309)
        Me.tlsRoomSettings.TabIndex = 4
        Me.tlsRoomSettings.Text = "ToolStrip2"
        '
        'tsbSystemSettings
        '
        Me.tsbSystemSettings.AutoSize = False
        Me.tsbSystemSettings.AutoToolTip = False
        Me.tsbSystemSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tsbSystemSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbSystemSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSystemSettings.Name = "tsbSystemSettings"
        Me.tsbSystemSettings.Size = New System.Drawing.Size(120, 30)
        Me.tsbSystemSettings.Text = "System Settings"
        Me.tsbSystemSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(110, 6)
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 61)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Restriction Settings"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkReservation
        '
        Me.chkReservation.AutoSize = True
        Me.chkReservation.BackColor = System.Drawing.Color.Transparent
        Me.chkReservation.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReservation.Location = New System.Drawing.Point(50, 85)
        Me.chkReservation.Name = "chkReservation"
        Me.chkReservation.Size = New System.Drawing.Size(212, 22)
        Me.chkReservation.TabIndex = 6
        Me.chkReservation.Text = "Update/Editing of Reservations"
        Me.chkReservation.UseVisualStyleBackColor = False
        '
        'chkShift
        '
        Me.chkShift.AutoSize = True
        Me.chkShift.BackColor = System.Drawing.Color.Transparent
        Me.chkShift.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShift.Location = New System.Drawing.Point(50, 55)
        Me.chkShift.Name = "chkShift"
        Me.chkShift.Size = New System.Drawing.Size(184, 22)
        Me.chkShift.TabIndex = 5
        Me.chkShift.Text = "Manual Changing of Shifts "
        Me.chkShift.UseVisualStyleBackColor = False
        '
        'chkRegistration
        '
        Me.chkRegistration.AutoSize = True
        Me.chkRegistration.BackColor = System.Drawing.Color.Transparent
        Me.chkRegistration.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRegistration.Location = New System.Drawing.Point(50, 115)
        Me.chkRegistration.Name = "chkRegistration"
        Me.chkRegistration.Size = New System.Drawing.Size(214, 22)
        Me.chkRegistration.TabIndex = 7
        Me.chkRegistration.Text = "Update/Editing of Registrations"
        Me.chkRegistration.UseVisualStyleBackColor = False
        '
        'chkGuestFolio
        '
        Me.chkGuestFolio.AutoSize = True
        Me.chkGuestFolio.BackColor = System.Drawing.Color.Transparent
        Me.chkGuestFolio.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGuestFolio.Location = New System.Drawing.Point(50, 145)
        Me.chkGuestFolio.Name = "chkGuestFolio"
        Me.chkGuestFolio.Size = New System.Drawing.Size(201, 22)
        Me.chkGuestFolio.TabIndex = 8
        Me.chkGuestFolio.Text = "Delition of Bills at Guest Folio"
        Me.chkGuestFolio.UseVisualStyleBackColor = False
        '
        'chkModification
        '
        Me.chkModification.AutoSize = True
        Me.chkModification.BackColor = System.Drawing.Color.Transparent
        Me.chkModification.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkModification.Location = New System.Drawing.Point(367, 55)
        Me.chkModification.Name = "chkModification"
        Me.chkModification.Size = New System.Drawing.Size(332, 22)
        Me.chkModification.TabIndex = 9
        Me.chkModification.Text = "Modifying Bills Either Through Percent or By Amount"
        Me.chkModification.UseVisualStyleBackColor = False
        '
        'chkUncollectibles
        '
        Me.chkUncollectibles.AutoSize = True
        Me.chkUncollectibles.BackColor = System.Drawing.Color.Transparent
        Me.chkUncollectibles.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUncollectibles.Location = New System.Drawing.Point(367, 85)
        Me.chkUncollectibles.Name = "chkUncollectibles"
        Me.chkUncollectibles.Size = New System.Drawing.Size(181, 22)
        Me.chkUncollectibles.TabIndex = 10
        Me.chkUncollectibles.Text = "Creating Uncollectible Bills"
        Me.chkUncollectibles.UseVisualStyleBackColor = False
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox7.Location = New System.Drawing.Point(685, 464)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(180, 22)
        Me.CheckBox7.TabIndex = 11
        Me.CheckBox7.Text = "Creating uncollectible Bills"
        Me.CheckBox7.UseVisualStyleBackColor = False
        '
        'chkRefunds
        '
        Me.chkRefunds.AutoSize = True
        Me.chkRefunds.BackColor = System.Drawing.Color.Transparent
        Me.chkRefunds.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRefunds.Location = New System.Drawing.Point(367, 115)
        Me.chkRefunds.Name = "chkRefunds"
        Me.chkRefunds.Size = New System.Drawing.Size(189, 22)
        Me.chkRefunds.TabIndex = 12
        Me.chkRefunds.Text = "Manual Creation of Refunds"
        Me.chkRefunds.UseVisualStyleBackColor = False
        '
        'chkDirectBillers
        '
        Me.chkDirectBillers.AutoSize = True
        Me.chkDirectBillers.BackColor = System.Drawing.Color.Transparent
        Me.chkDirectBillers.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDirectBillers.Location = New System.Drawing.Point(367, 145)
        Me.chkDirectBillers.Name = "chkDirectBillers"
        Me.chkDirectBillers.Size = New System.Drawing.Size(216, 22)
        Me.chkDirectBillers.TabIndex = 13
        Me.chkDirectBillers.Text = "Manual Creation of Direct Billers"
        Me.chkDirectBillers.UseVisualStyleBackColor = False
        '
        'lblReq
        '
        Me.lblReq.AutoSize = True
        Me.lblReq.BackColor = System.Drawing.Color.Transparent
        Me.lblReq.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReq.ForeColor = System.Drawing.Color.Red
        Me.lblReq.Location = New System.Drawing.Point(12, 204)
        Me.lblReq.Name = "lblReq"
        Me.lblReq.Size = New System.Drawing.Size(284, 16)
        Me.lblReq.TabIndex = 9
        Me.lblReq.Text = "NOTE: Restrictions are applied for transactional users."
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(43, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 48)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(42, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(472, 39)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "**Cannot use the sys account to authorize restricted actions."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblReq)
        Me.GroupBox1.Controls.Add(Me.chkDirectBillers)
        Me.GroupBox1.Controls.Add(Me.chkRefunds)
        Me.GroupBox1.Controls.Add(Me.CheckBox7)
        Me.GroupBox1.Controls.Add(Me.chkUncollectibles)
        Me.GroupBox1.Controls.Add(Me.chkModification)
        Me.GroupBox1.Controls.Add(Me.chkGuestFolio)
        Me.GroupBox1.Controls.Add(Me.chkRegistration)
        Me.GroupBox1.Controls.Add(Me.chkShift)
        Me.GroupBox1.Controls.Add(Me.chkReservation)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(141, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(831, 316)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Restrict Access:"
        '
        'frmRestrictionSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(992, 617)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tlsRoomSettings)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRestrictionSettings"
        Me.tlsRoomSettings.ResumeLayout(False)
        Me.tlsRoomSettings.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlsRoomSettings As System.Windows.Forms.ToolStrip
    Public WithEvents tsbSystemSettings As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkReservation As System.Windows.Forms.CheckBox
    Friend WithEvents chkShift As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegistration As System.Windows.Forms.CheckBox
    Friend WithEvents chkGuestFolio As System.Windows.Forms.CheckBox
    Friend WithEvents chkModification As System.Windows.Forms.CheckBox
    Friend WithEvents chkUncollectibles As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents chkRefunds As System.Windows.Forms.CheckBox
    Friend WithEvents chkDirectBillers As System.Windows.Forms.CheckBox
    Friend WithEvents lblReq As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
