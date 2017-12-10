<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLevel1))
        Me.timKinect = New System.Windows.Forms.Timer(Me.components)
        Me.picHandRight = New System.Windows.Forms.PictureBox()
        Me.picHITW = New System.Windows.Forms.PictureBox()
        Me.PicHandLeft = New System.Windows.Forms.PictureBox()
        Me.picHead = New System.Windows.Forms.PictureBox()
        Me.picFootRight = New System.Windows.Forms.PictureBox()
        Me.picFootLeft = New System.Windows.Forms.PictureBox()
        Me.lblGameTime = New System.Windows.Forms.Label()
        Me.lblLevel1 = New System.Windows.Forms.Label()
        Me.timGameTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblWinOrLose = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNextLevel = New System.Windows.Forms.Button()
        Me.timGoodSkel = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picHandRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHITW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicHandLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFootRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFootLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timKinect
        '
        Me.timKinect.Enabled = True
        Me.timKinect.Interval = 1
        '
        'picHandRight
        '
        Me.picHandRight.BackColor = System.Drawing.Color.Blue
        Me.picHandRight.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._115755_magic_marker_icon_people_things_hand_left1_ps
        Me.picHandRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHandRight.Location = New System.Drawing.Point(685, 174)
        Me.picHandRight.Name = "picHandRight"
        Me.picHandRight.Size = New System.Drawing.Size(55, 55)
        Me.picHandRight.TabIndex = 1
        Me.picHandRight.TabStop = False
        '
        'picHITW
        '
        Me.picHITW.BackColor = System.Drawing.SystemColors.Control
        Me.picHITW.Location = New System.Drawing.Point(363, 144)
        Me.picHITW.Name = "picHITW"
        Me.picHITW.Size = New System.Drawing.Size(640, 480)
        Me.picHITW.TabIndex = 0
        Me.picHITW.TabStop = False
        '
        'PicHandLeft
        '
        Me.PicHandLeft.BackColor = System.Drawing.Color.Blue
        Me.PicHandLeft.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._115755_magic_marker_icon_people_things_hand_right1_ps
        Me.PicHandLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicHandLeft.Location = New System.Drawing.Point(462, 401)
        Me.PicHandLeft.Name = "PicHandLeft"
        Me.PicHandLeft.Size = New System.Drawing.Size(55, 55)
        Me.PicHandLeft.TabIndex = 2
        Me.PicHandLeft.TabStop = False
        '
        'picHead
        '
        Me.picHead.BackColor = System.Drawing.Color.Blue
        Me.picHead.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Gentleman_512
        Me.picHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHead.Location = New System.Drawing.Point(520, 235)
        Me.picHead.Name = "picHead"
        Me.picHead.Size = New System.Drawing.Size(55, 55)
        Me.picHead.TabIndex = 3
        Me.picHead.TabStop = False
        '
        'picFootRight
        '
        Me.picFootRight.BackColor = System.Drawing.Color.Blue
        Me.picFootRight.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._115743_magic_marker_icon_people_things_foot_right_ps
        Me.picFootRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFootRight.Location = New System.Drawing.Point(851, 500)
        Me.picFootRight.Name = "picFootRight"
        Me.picFootRight.Size = New System.Drawing.Size(55, 55)
        Me.picFootRight.TabIndex = 4
        Me.picFootRight.TabStop = False
        '
        'picFootLeft
        '
        Me.picFootLeft.BackColor = System.Drawing.Color.Blue
        Me.picFootLeft.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._115743_magic_marker_icon_people_things_foot_left_ps
        Me.picFootLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFootLeft.Location = New System.Drawing.Point(661, 569)
        Me.picFootLeft.Name = "picFootLeft"
        Me.picFootLeft.Size = New System.Drawing.Size(55, 55)
        Me.picFootLeft.TabIndex = 5
        Me.picFootLeft.TabStop = False
        '
        'lblGameTime
        '
        Me.lblGameTime.AutoSize = True
        Me.lblGameTime.Font = New System.Drawing.Font("Baveuse", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTime.Location = New System.Drawing.Point(944, 93)
        Me.lblGameTime.Name = "lblGameTime"
        Me.lblGameTime.Size = New System.Drawing.Size(47, 32)
        Me.lblGameTime.TabIndex = 6
        Me.lblGameTime.Text = "25"
        '
        'lblLevel1
        '
        Me.lblLevel1.AutoSize = True
        Me.lblLevel1.Font = New System.Drawing.Font("Baveuse", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel1.Location = New System.Drawing.Point(357, 93)
        Me.lblLevel1.Name = "lblLevel1"
        Me.lblLevel1.Size = New System.Drawing.Size(109, 32)
        Me.lblLevel1.TabIndex = 7
        Me.lblLevel1.Text = "Level 1"
        '
        'timGameTime
        '
        Me.timGameTime.Enabled = True
        Me.timGameTime.Interval = 1000
        '
        'lblWinOrLose
        '
        Me.lblWinOrLose.AutoSize = True
        Me.lblWinOrLose.Font = New System.Drawing.Font("Baveuse", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinOrLose.Location = New System.Drawing.Point(504, 30)
        Me.lblWinOrLose.Name = "lblWinOrLose"
        Me.lblWinOrLose.Size = New System.Drawing.Size(97, 95)
        Me.lblWinOrLose.TabIndex = 8
        Me.lblWinOrLose.Text = "   "
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
        'frmLevel1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.btnNextLevel)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblWinOrLose)
        Me.Controls.Add(Me.lblLevel1)
        Me.Controls.Add(Me.lblGameTime)
        Me.Controls.Add(Me.picFootLeft)
        Me.Controls.Add(Me.picFootRight)
        Me.Controls.Add(Me.picHead)
        Me.Controls.Add(Me.PicHandLeft)
        Me.Controls.Add(Me.picHandRight)
        Me.Controls.Add(Me.picHITW)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLevel1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hole in the wall! - Level 1"
        CType(Me.picHandRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHITW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicHandLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFootRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFootLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picHITW As System.Windows.Forms.PictureBox
    Friend WithEvents timKinect As System.Windows.Forms.Timer
    Friend WithEvents picHandRight As System.Windows.Forms.PictureBox
    Friend WithEvents PicHandLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picHead As System.Windows.Forms.PictureBox
    Friend WithEvents picFootRight As System.Windows.Forms.PictureBox
    Friend WithEvents picFootLeft As System.Windows.Forms.PictureBox
    Friend WithEvents lblGameTime As System.Windows.Forms.Label
    Friend WithEvents lblLevel1 As System.Windows.Forms.Label
    Friend WithEvents timGameTime As System.Windows.Forms.Timer
    Friend WithEvents lblWinOrLose As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNextLevel As System.Windows.Forms.Button
    Friend WithEvents timGoodSkel As System.Windows.Forms.Timer
End Class
