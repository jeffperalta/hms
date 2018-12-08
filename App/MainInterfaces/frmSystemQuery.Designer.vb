<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemQuery
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.picBilling = New System.Windows.Forms.PictureBox
        Me.picUser = New System.Windows.Forms.PictureBox
        Me.picRoom = New System.Windows.Forms.PictureBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        CType(Me.picBilling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(453, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 24)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Room Status Query"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(453, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 24)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Shift Query"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(453, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 24)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Settings Query"
        '
        'picBilling
        '
        Me.picBilling.BackColor = System.Drawing.Color.Transparent
        Me.picBilling.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.ParentSettings
        Me.picBilling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBilling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBilling.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBilling.Location = New System.Drawing.Point(390, 320)
        Me.picBilling.Name = "picBilling"
        Me.picBilling.Size = New System.Drawing.Size(56, 55)
        Me.picBilling.TabIndex = 42
        Me.picBilling.TabStop = False
        '
        'picUser
        '
        Me.picUser.BackColor = System.Drawing.Color.Transparent
        Me.picUser.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.LogMonitoring
        Me.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picUser.Location = New System.Drawing.Point(391, 259)
        Me.picUser.Name = "picUser"
        Me.picUser.Size = New System.Drawing.Size(56, 55)
        Me.picUser.TabIndex = 41
        Me.picUser.TabStop = False
        '
        'picRoom
        '
        Me.picRoom.BackColor = System.Drawing.Color.Transparent
        Me.picRoom.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.ParentRoomRack
        Me.picRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRoom.Location = New System.Drawing.Point(391, 198)
        Me.picRoom.Name = "picRoom"
        Me.picRoom.Size = New System.Drawing.Size(56, 55)
        Me.picRoom.TabIndex = 40
        Me.picRoom.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 24)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Queries"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(919, 572)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(54, 28)
        Me.btnClose.TabIndex = 46
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmSystemQuery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.SearchLog
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 625)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.picBilling)
        Me.Controls.Add(Me.picUser)
        Me.Controls.Add(Me.picRoom)
        Me.Controls.Add(Me.Label9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSystemQuery"
        Me.Text = "frmSystemQuery"
        CType(Me.picBilling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents picBilling As System.Windows.Forms.PictureBox
    Friend WithEvents picUser As System.Windows.Forms.PictureBox
    Friend WithEvents picRoom As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
