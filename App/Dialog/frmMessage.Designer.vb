<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMessage))
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button0 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.picCritical = New System.Windows.Forms.PictureBox
        Me.picInformation = New System.Windows.Forms.PictureBox
        Me.picExclamation = New System.Windows.Forms.PictureBox
        Me.picQuestion = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picCritical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExclamation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(255, 148)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 28)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(336, 148)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 28)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(417, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(3, 19)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(476, 172)
        Me.TextBox1.TabIndex = 10
        '
        'Button0
        '
        Me.Button0.AutoSize = True
        Me.Button0.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button0.Location = New System.Drawing.Point(13, 148)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(101, 28)
        Me.Button0.TabIndex = 3
        Me.Button0.Text = "Show &Details"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 106)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 194)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Message Details"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "n")
        Me.ImageList1.Images.SetKeyName(1, "e")
        Me.ImageList1.Images.SetKeyName(2, "q")
        Me.ImageList1.Images.SetKeyName(3, "i")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(117, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(378, 128)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'picCritical
        '
        Me.picCritical.BackColor = System.Drawing.Color.Transparent
        Me.picCritical.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Critical
        Me.picCritical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCritical.Location = New System.Drawing.Point(12, 18)
        Me.picCritical.Name = "picCritical"
        Me.picCritical.Size = New System.Drawing.Size(102, 117)
        Me.picCritical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCritical.TabIndex = 19
        Me.picCritical.TabStop = False
        '
        'picInformation
        '
        Me.picInformation.BackColor = System.Drawing.Color.Transparent
        Me.picInformation.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Information
        Me.picInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picInformation.Location = New System.Drawing.Point(12, 18)
        Me.picInformation.Name = "picInformation"
        Me.picInformation.Size = New System.Drawing.Size(102, 117)
        Me.picInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picInformation.TabIndex = 20
        Me.picInformation.TabStop = False
        '
        'picExclamation
        '
        Me.picExclamation.BackColor = System.Drawing.Color.Transparent
        Me.picExclamation.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Exclamation
        Me.picExclamation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picExclamation.Location = New System.Drawing.Point(12, 18)
        Me.picExclamation.Name = "picExclamation"
        Me.picExclamation.Size = New System.Drawing.Size(102, 117)
        Me.picExclamation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picExclamation.TabIndex = 22
        Me.picExclamation.TabStop = False
        '
        'picQuestion
        '
        Me.picQuestion.BackColor = System.Drawing.Color.Transparent
        Me.picQuestion.BackgroundImage = Global.SLU_Hotel_Front_Desk_System.My.Resources.Resources.Question
        Me.picQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picQuestion.Location = New System.Drawing.Point(12, 18)
        Me.picQuestion.Name = "picQuestion"
        Me.picQuestion.Size = New System.Drawing.Size(102, 117)
        Me.picQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picQuestion.TabIndex = 21
        Me.picQuestion.TabStop = False
        '
        'frmMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(507, 186)
        Me.ControlBox = False
        Me.Controls.Add(Me.picCritical)
        Me.Controls.Add(Me.picInformation)
        Me.Controls.Add(Me.picExclamation)
        Me.Controls.Add(Me.picQuestion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMessage"
        Me.Text = "frmMessage"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.picCritical, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExclamation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button0 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents picCritical As System.Windows.Forms.PictureBox
    Friend WithEvents picInformation As System.Windows.Forms.PictureBox
    Friend WithEvents picExclamation As System.Windows.Forms.PictureBox
    Friend WithEvents picQuestion As System.Windows.Forms.PictureBox
End Class
