<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLevel5))
        Me.lblWinOrLose = New System.Windows.Forms.Label()
        Me.lblLevel5 = New System.Windows.Forms.Label()
        Me.lblGameTime = New System.Windows.Forms.Label()
        Me.picFootLeft = New System.Windows.Forms.PictureBox()
        Me.picFootRight = New System.Windows.Forms.PictureBox()
        Me.picHead = New System.Windows.Forms.PictureBox()
        Me.PicHandLeft = New System.Windows.Forms.PictureBox()
        Me.picHandRight = New System.Windows.Forms.PictureBox()
        Me.picHITW = New System.Windows.Forms.PictureBox()
        Me.btnLevelSelect = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.timGameTime = New System.Windows.Forms.Timer(Me.components)
        Me.timKinect = New System.Windows.Forms.Timer(Me.components)
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
        Me.lblWinOrLose.TabIndex = 44
        Me.lblWinOrLose.Text = "   "
        '
        'lblLevel5
        '
        Me.lblLevel5.AutoSize = True
        Me.lblLevel5.Font = New System.Drawing.Font("Baveuse", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel5.Location = New System.Drawing.Point(352, 130)
        Me.lblLevel5.Name = "lblLevel5"
        Me.lblLevel5.Size = New System.Drawing.Size(117, 32)
        Me.lblLevel5.TabIndex = 43
        Me.lblLevel5.Text = "Level 5"
        '
        'lblGameTime
        '
        Me.lblGameTime.AutoSize = True
        Me.lblGameTime.Font = New System.Drawing.Font("Baveuse", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTime.Location = New System.Drawing.Point(951, 130)
        Me.lblGameTime.Name = "lblGameTime"
        Me.lblGameTime.Size = New System.Drawing.Size(31, 32)
        Me.lblGameTime.TabIndex = 42
        Me.lblGameTime.Text = "5"
        '
        'picFootLeft
        '
        Me.picFootLeft.BackColor = System.Drawing.Color.Blue
        Me.picFootLeft.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._115743_magic_marker_icon_people_things_foot_left_ps
        Me.picFootLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFootLeft.Location = New System.Drawing.Point(641, 606)
        Me.picFootLeft.Name = "picFootLeft"
        Me.picFootLeft.Size = New System.Drawing.Size(55, 55)
        Me.picFootLeft.TabIndex = 41
        Me.picFootLeft.TabStop = False
        '
        'picFootRight
        '
        Me.picFootRight.BackColor = System.Drawing.Color.Blue
        Me.picFootRight.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._115743_magic_marker_icon_people_things_foot_right_ps
        Me.picFootRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFootRight.Location = New System.Drawing.Point(711, 518)
        Me.picFootRight.Name = "picFootRight"
        Me.picFootRight.Size = New System.Drawing.Size(55, 55)
        Me.picFootRight.TabIndex = 40
        Me.picFootRight.TabStop = False
        '
        'picHead
        '
        Me.picHead.BackColor = System.Drawing.Color.Blue
        Me.picHead.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Gentleman_512
        Me.picHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHead.Location = New System.Drawing.Point(650, 257)
        Me.picHead.Name = "picHead"
        Me.picHead.Size = New System.Drawing.Size(55, 55)
        Me.picHead.TabIndex = 39
        Me.picHead.TabStop = False
        '
        'PicHandLeft
        '
        Me.PicHandLeft.BackColor = System.Drawing.Color.Blue
        Me.PicHandLeft.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._115755_magic_marker_icon_people_things_hand_right1_ps
        Me.PicHandLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PicHandLeft.Location = New System.Drawing.Point(742, 372)
        Me.PicHandLeft.Name = "PicHandLeft"
        Me.PicHandLeft.Size = New System.Drawing.Size(55, 55)
        Me.PicHandLeft.TabIndex = 38
        Me.PicHandLeft.TabStop = False
        '
        'picHandRight
        '
        Me.picHandRight.BackColor = System.Drawing.Color.Blue
        Me.picHandRight.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._115755_magic_marker_icon_people_things_hand_left1_ps
        Me.picHandRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHandRight.Location = New System.Drawing.Point(554, 372)
        Me.picHandRight.Name = "picHandRight"
        Me.picHandRight.Size = New System.Drawing.Size(55, 55)
        Me.picHandRight.TabIndex = 37
        Me.picHandRight.TabStop = False
        '
        'picHITW
        '
        Me.picHITW.BackColor = System.Drawing.SystemColors.Control
        Me.picHITW.Location = New System.Drawing.Point(358, 181)
        Me.picHITW.Name = "picHITW"
        Me.picHITW.Size = New System.Drawing.Size(640, 480)
        Me.picHITW.TabIndex = 36
        Me.picHITW.TabStop = False
        '
        'btnLevelSelect
        '
        Me.btnLevelSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLevelSelect.Font = New System.Drawing.Font("Baveuse", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevelSelect.Location = New System.Drawing.Point(1258, 12)
        Me.btnLevelSelect.Name = "btnLevelSelect"
        Me.btnLevelSelect.Size = New System.Drawing.Size(80, 30)
        Me.btnLevelSelect.TabIndex = 45
        Me.btnLevelSelect.Text = "Levels"
        Me.btnLevelSelect.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Baveuse", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 30)
        Me.btnBack.TabIndex = 46
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
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
        'timGoodSkel
        '
        Me.timGoodSkel.Enabled = True
        Me.timGoodSkel.Interval = 1000
        '
        'frmLevel5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLevelSelect)
        Me.Controls.Add(Me.lblWinOrLose)
        Me.Controls.Add(Me.lblLevel5)
        Me.Controls.Add(Me.lblGameTime)
        Me.Controls.Add(Me.picFootLeft)
        Me.Controls.Add(Me.picFootRight)
        Me.Controls.Add(Me.picHead)
        Me.Controls.Add(Me.PicHandLeft)
        Me.Controls.Add(Me.picHandRight)
        Me.Controls.Add(Me.picHITW)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLevel5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hole in the wall! - Level 5"
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
    Friend WithEvents lblLevel5 As System.Windows.Forms.Label
    Friend WithEvents lblGameTime As System.Windows.Forms.Label
    Friend WithEvents picFootLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picFootRight As System.Windows.Forms.PictureBox
    Friend WithEvents picHead As System.Windows.Forms.PictureBox
    Friend WithEvents PicHandLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picHandRight As System.Windows.Forms.PictureBox
    Friend WithEvents picHITW As System.Windows.Forms.PictureBox
    Friend WithEvents btnLevelSelect As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents timGameTime As System.Windows.Forms.Timer
    Friend WithEvents timKinect As System.Windows.Forms.Timer
    Friend WithEvents timGoodSkel As System.Windows.Forms.Timer
End Class
