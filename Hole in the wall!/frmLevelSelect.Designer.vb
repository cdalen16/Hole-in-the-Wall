<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevelSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLevelSelect))
        Me.btnLevel3 = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnLevel2 = New System.Windows.Forms.Button()
        Me.btnLevel1 = New System.Windows.Forms.Button()
        Me.btnLevel5 = New System.Windows.Forms.Button()
        Me.btnLevel4 = New System.Windows.Forms.Button()
        Me.picHITW = New System.Windows.Forms.PictureBox()
        Me.timKinect = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picHITW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLevel3
        '
        Me.btnLevel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLevel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLevel3.Font = New System.Drawing.Font("Baveuse", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel3.Location = New System.Drawing.Point(141, 297)
        Me.btnLevel3.Name = "btnLevel3"
        Me.btnLevel3.Size = New System.Drawing.Size(330, 45)
        Me.btnLevel3.TabIndex = 7
        Me.btnLevel3.Text = "Level 3"
        Me.btnLevel3.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Baveuse", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(141, 477)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(330, 45)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnLevel2
        '
        Me.btnLevel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLevel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLevel2.Font = New System.Drawing.Font("Baveuse", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel2.Location = New System.Drawing.Point(141, 237)
        Me.btnLevel2.Name = "btnLevel2"
        Me.btnLevel2.Size = New System.Drawing.Size(330, 45)
        Me.btnLevel2.TabIndex = 5
        Me.btnLevel2.Text = "Level 2"
        Me.btnLevel2.UseVisualStyleBackColor = False
        '
        'btnLevel1
        '
        Me.btnLevel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLevel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLevel1.Font = New System.Drawing.Font("Baveuse", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel1.Location = New System.Drawing.Point(141, 177)
        Me.btnLevel1.Name = "btnLevel1"
        Me.btnLevel1.Size = New System.Drawing.Size(330, 45)
        Me.btnLevel1.TabIndex = 4
        Me.btnLevel1.Text = "Level 1"
        Me.btnLevel1.UseVisualStyleBackColor = False
        '
        'btnLevel5
        '
        Me.btnLevel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLevel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLevel5.Font = New System.Drawing.Font("Baveuse", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel5.Location = New System.Drawing.Point(141, 417)
        Me.btnLevel5.Name = "btnLevel5"
        Me.btnLevel5.Size = New System.Drawing.Size(330, 45)
        Me.btnLevel5.TabIndex = 8
        Me.btnLevel5.Text = "Level 5"
        Me.btnLevel5.UseVisualStyleBackColor = False
        '
        'btnLevel4
        '
        Me.btnLevel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLevel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLevel4.Font = New System.Drawing.Font("Baveuse", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevel4.Location = New System.Drawing.Point(141, 357)
        Me.btnLevel4.Name = "btnLevel4"
        Me.btnLevel4.Size = New System.Drawing.Size(330, 45)
        Me.btnLevel4.TabIndex = 9
        Me.btnLevel4.Text = "Level 4"
        Me.btnLevel4.UseVisualStyleBackColor = False
        '
        'picHITW
        '
        Me.picHITW.Location = New System.Drawing.Point(606, 116)
        Me.picHITW.Name = "picHITW"
        Me.picHITW.Size = New System.Drawing.Size(640, 480)
        Me.picHITW.TabIndex = 10
        Me.picHITW.TabStop = False
        '
        'timKinect
        '
        Me.timKinect.Enabled = True
        Me.timKinect.Interval = 1
        '
        'frmLevelSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.picHITW)
        Me.Controls.Add(Me.btnLevel4)
        Me.Controls.Add(Me.btnLevel5)
        Me.Controls.Add(Me.btnLevel3)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLevel2)
        Me.Controls.Add(Me.btnLevel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLevelSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hole In The Wall! - Level Select"
        CType(Me.picHITW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLevel3 As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnLevel2 As System.Windows.Forms.Button
    Friend WithEvents btnLevel1 As System.Windows.Forms.Button
    Friend WithEvents btnLevel5 As System.Windows.Forms.Button
    Friend WithEvents btnLevel4 As System.Windows.Forms.Button
    Friend WithEvents picHITW As System.Windows.Forms.PictureBox
    Friend WithEvents timKinect As System.Windows.Forms.Timer
End Class
