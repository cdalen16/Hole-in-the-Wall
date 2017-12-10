<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLevel3))
        Me.lblWinOrLose = New System.Windows.Forms.Label()
        Me.lblLevel3 = New System.Windows.Forms.Label()
        Me.lblGameTime = New System.Windows.Forms.Label()
        Me.picFootLeft = New System.Windows.Forms.PictureBox()
        Me.picFootRight = New System.Windows.Forms.PictureBox()
        Me.picHead = New System.Windows.Forms.PictureBox()
        Me.PicHandLeft = New System.Windows.Forms.PictureBox()
        Me.picHandRight = New System.Windows.Forms.PictureBox()
        Me.picHITW = New System.Windows.Forms.PictureBox()
        Me.timGameTime = New System.Windows.Forms.Timer(Me.components)
        Me.timKinect = New System.Windows.Forms.Timer(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNextLevel = New System.Windows.Forms.Button()
        Me.timGoodSkel = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picFootLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFootRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicHandLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHandRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHITW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWinOrLose
        '
        Me.lblWinOrLose.AutoSize = True
        Me.lblWinOrLose.Font = New System.Drawing.Font("Baveuse", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinOrLose.Location = New System.Drawing.Point(499, 67)
        Me.lblWinOrLose.Name = "lblWinOrLose"
        Me.lblWinOrLose.Size = New System.Drawing.Size(97, 95)
        Me.lblWinOrLose.TabIndex = 26
        Me.lblWinOrLose.Text = "   "
        '
        'lblLevel3
        '
        Me.lblLevel3.AutoSize = True
        Me.lblLevel3.Font = New System.Drawing.Font("Baveuse", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel3.Location = New System.Drawing.Point(352, 130)
        Me.lblLevel3.Name = "lblLevel3"
        Me.lblLevel3.Size = New System.Drawing.Size(116, 32)
        Me.lblLevel3.TabIndex = 25
        Me.lblLevel3.Text = "Level 3"
        '
        'lblGameTime
        '
        Me.lblGameTime.AutoSize = True
        Me.lblGameTime.Font = New System.Drawing.Font("Baveuse", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTime.Location = New System.Drawing.Point(951, 130)
        Me.lblGameTime.Name = "lblGameTime"
        Me.lblGameTime.Size = New System.Drawing.Size(39, 32)
        Me.lblGameTime.TabIndex = 24
        Me.lblGameTime.Text = "15"
        '
        'picFootLeft
        '
        Me.picFootLeft.BackColor = System.Drawing.Color.Blue
        Me.picFootLeft.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._115743_magic_marker_icon_people_things_foot_left_ps
        Me.picFootLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFootLeft.Location = New System.Drawing.Point(504, 606)
        Me.picFootLeft.Name = "picFootLeft"
        Me.picFootLeft.Size = New System.Drawing.Size(55, 55)
        Me.picFootLeft.TabIndex = 23
        Me.picFootLeft.TabStop = False
        '
        'picFootRight
        '
        Me.picFootRight.BackColor = System.Drawing.Color.Blue
        Me.picFootRight.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._115743_magic_marker_icon_people_things_foot_right_ps
        Me.picFootRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFootRight.Location = New System.Drawing.Point(794, 606)
        Me.picFootRight.Name = "picFootRight"
        Me.picFootRight.Size = New System.Drawing.Size(55, 55)
        Me.picFootRight.TabIndex = 22
        Me.picFootRight.TabStop = False
        '
        'picHead
        '
        Me.picHead.BackColor = System.Drawing.Color.Blue
        Me.picHead.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Gentleman_512
        Me.picHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHead.Location = New System.Drawing.Point(650, 231)
        Me.picHead.Name = "picHead"
        Me.picHead.Size = New System.Drawing.Size(55, 55)
        Me.picHead.TabIndex = 21
        Me.picHead.TabStop = False
        '
        'PicHandLeft
        '
        Me.PicHandLeft.BackColor = System.Drawing.Color.Blue
        Me.PicHandLeft.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._115755_magic_marker_icon_people_things_hand_right1_ps
        Me.PicHandLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicHandLeft.Location = New System.Drawing.Point(441, 330)
        Me.PicHandLeft.Name = "PicHandLeft"
        Me.PicHandLeft.Size = New System.Drawing.Size(55, 55)
        Me.PicHandLeft.TabIndex = 20
        Me.PicHandLeft.TabStop = False
        '
        'picHandRight
        '
        Me.picHandRight.BackColor = System.Drawing.Color.Blue
        Me.picHandRight.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._115755_magic_marker_icon_people_things_hand_left1_ps
        Me.picHandRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHandRight.Location = New System.Drawing.Point(848, 330)
        Me.picHandRight.Name = "picHandRight"
        Me.picHandRight.Size = New System.Drawing.Size(55, 55)
        Me.picHandRight.TabIndex = 19
        Me.picHandRight.TabStop = False
        '
        'picHITW
        '
        Me.picHITW.BackColor = System.Drawing.SystemColors.Control
        Me.picHITW.Location = New System.Drawing.Point(358, 181)
        Me.picHITW.Name = "picHITW"
        Me.picHITW.Size = New System.Drawing.Size(640, 480)
        Me.picHITW.TabIndex = 18
        Me.picHITW.TabStop = False
        '
        'timGameTime
        '
        Me.timGameTime.Enabled = True
        Me.timGameTime.Interval = 1000
        '
        'timKinect
        '
        Me.timKinect.Enabled = True
        Me.timKinect.Interval = 1
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Baveuse", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 30)
        Me.btnBack.TabIndex = 37
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNextLevel
        '
        Me.btnNextLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextLevel.Font = New System.Drawing.Font("Baveuse", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextLevel.Location = New System.Drawing.Point(1258, 12)
        Me.btnNextLevel.Name = "btnNextLevel"
        Me.btnNextLevel.Size = New System.Drawing.Size(80, 30)
        Me.btnNextLevel.TabIndex = 39
        Me.btnNextLevel.Text = "Next Level"
        Me.btnNextLevel.UseVisualStyleBackColor = True
        '
        'timGoodSkel
        '
        Me.timGoodSkel.Enabled = True
        Me.timGoodSkel.Interval = 1000
        '
        'frmLevel3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.btnNextLevel)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblWinOrLose)
        Me.Controls.Add(Me.lblLevel3)
        Me.Controls.Add(Me.lblGameTime)
        Me.Controls.Add(Me.picFootLeft)
        Me.Controls.Add(Me.picFootRight)
        Me.Controls.Add(Me.picHead)
        Me.Controls.Add(Me.PicHandLeft)
        Me.Controls.Add(Me.picHandRight)
        Me.Controls.Add(Me.picHITW)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLevel3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hole in the wall! - Level 3"
        CType(Me.picFootLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFootRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicHandLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHandRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHITW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWinOrLose As System.Windows.Forms.Label
    Friend WithEvents lblLevel3 As System.Windows.Forms.Label
    Friend WithEvents lblGameTime As System.Windows.Forms.Label
    Friend WithEvents picFootLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picFootRight As System.Windows.Forms.PictureBox
    Friend WithEvents picHead As System.Windows.Forms.PictureBox
    Friend WithEvents PicHandLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picHandRight As System.Windows.Forms.PictureBox
    Friend WithEvents picHITW As System.Windows.Forms.PictureBox
    Friend WithEvents timGameTime As System.Windows.Forms.Timer
    Friend WithEvents timKinect As System.Windows.Forms.Timer
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNextLevel As System.Windows.Forms.Button
    Friend WithEvents timGoodSkel As System.Windows.Forms.Timer
End Class
