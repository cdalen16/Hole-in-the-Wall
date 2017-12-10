Imports Microsoft.Kinect

Public Class frmLevel2

    Dim GameTime As Integer = 20

    Dim ZeroZero As Rectangle = New Rectangle(New Point(0, 0), New Size(1, 1))

    Dim GHead As DepthImagePoint

    'right arm
    Dim GShoulderRight As DepthImagePoint
    Dim GElbowRight As DepthImagePoint
    Dim GWristRight As DepthImagePoint
    Dim GHandRight As DepthImagePoint

    'left arm
    Dim GShoulderLeft As DepthImagePoint
    Dim GElbowLeft As DepthImagePoint
    Dim GWristLeft As DepthImagePoint
    Dim GHandLeft As DepthImagePoint

    'right leg
    Dim GFootRight As DepthImagePoint
    Dim GAnkleRight As DepthImagePoint
    Dim GKneeRight As DepthImagePoint
    Dim GHipRight As DepthImagePoint

    'left leg
    Dim GFootLeft As DepthImagePoint
    Dim GAnkleLeft As DepthImagePoint
    Dim GKneeLeft As DepthImagePoint
    Dim GHipLeft As DepthImagePoint

    Dim WithEvents kinz As KinectSensor
    Dim imagez As ColorImageFrame
    Dim skeletonz As SkeletonFrame
    Dim piccolor As Bitmap = New Bitmap(640, 480, Imaging.PixelFormat.Format32bppRgb)
    Dim gfx As Graphics = Graphics.FromImage(piccolor)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        For Each potentialSensor In KinectSensor.KinectSensors

            If potentialSensor.Status = KinectStatus.Connected Then

                kinz = potentialSensor

                Exit For

            End If

        Next potentialSensor

        kinz.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30)
        kinz.SkeletonStream.Enable()

        'AddHandler kinz.ColorFrameReady, AddressOf colorready
        'AddHandler kinz.SkeletonFrameReady, AddressOf skeletonready

        kinz.Start()

        'kinz.SkeletonStream.TrackingMode = SkeletonTrackingMode.Default
        'kinz.ElevationAngle = 5

    End Sub

    'Color Video
    Public Sub colormethod()

        Dim pixz(kinz.ColorStream.FramePixelDataLength - 1) As Byte

        If imagez IsNot Nothing Then

            imagez.CopyPixelDataTo(pixz)

            Dim rect As New Rectangle(0, 0, piccolor.Width, piccolor.Height)
            Dim bmpData As System.Drawing.Imaging.BitmapData = piccolor.LockBits(rect, _
                Drawing.Imaging.ImageLockMode.ReadWrite, Imaging.PixelFormat.Format32bppRgb)

            Dim ptr As IntPtr = bmpData.Scan0
            Dim bytes As Integer = bmpData.Stride * piccolor.Height
            Dim rgbValues(bytes - 1) As Byte

            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes)

            Dim secondcounter As Integer
            Dim tempred As Integer
            Dim tempblue As Integer
            Dim tempgreen As Integer
            Dim tempalpha As Integer
            Dim tempx As Integer
            Dim tempy As Integer

            secondcounter = 0

            While secondcounter < rgbValues.Length

                tempblue = rgbValues(secondcounter)
                tempgreen = rgbValues(secondcounter + 1)
                tempred = rgbValues(secondcounter + 2)
                tempalpha = rgbValues(secondcounter + 3)
                tempalpha = 255

                tempy = ((secondcounter * 0.25) / 640)
                tempx = (secondcounter * 0.25) - (tempy * 640)

                If tempx < 0 Then

                    tempx = tempx + 640

                End If

                tempred = pixz(secondcounter + 2)
                tempgreen = pixz(secondcounter + 1)
                tempblue = pixz(secondcounter + 0)

                rgbValues(secondcounter) = tempblue
                rgbValues(secondcounter + 1) = tempgreen
                rgbValues(secondcounter + 2) = tempred
                rgbValues(secondcounter + 3) = tempalpha

                secondcounter = secondcounter + 4

            End While

            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes)

            piccolor.UnlockBits(bmpData)

        End If

    End Sub

    'Skeleton display
    Public Sub skeletonmethod()

        Dim penz As Pen = New Pen(Brushes.LimeGreen, 3)

        Dim skeletons(-1) As Skeleton

        If skeletonz IsNot Nothing Then

            skeletons = New Skeleton(skeletonz.SkeletonArrayLength - 1) {}
            skeletonz.CopySkeletonDataTo(skeletons)

        End If

        If skeletons.Length <> 0 Then

            For Each skel As Skeleton In skeletons

                'Right Arm
                Dim shoulderright As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.ShoulderRight).Position, DepthImageFormat.Resolution640x480Fps30)
                Dim elbowright As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.ElbowRight).Position, DepthImageFormat.Resolution640x480Fps30)
                Dim wristright As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.WristRight).Position, DepthImageFormat.Resolution640x480Fps30)
                Dim handright As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.HandRight).Position, DepthImageFormat.Resolution640x480Fps30)
                gfx.DrawLine(penz, New Point(shoulderright.X, shoulderright.Y), New Point(elbowright.X, elbowright.Y))
                gfx.DrawLine(penz, New Point(elbowright.X, elbowright.Y), New Point(wristright.X, wristright.Y))
                gfx.DrawLine(penz, New Point(wristright.X, wristright.Y), New Point(handright.X, handright.Y))
                'Left Arm
                Dim shoulderleft As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.ShoulderLeft).Position, DepthImageFormat.Resolution640x480Fps30)
                Dim elbowleft As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.ElbowLeft).Position, DepthImageFormat.Resolution640x480Fps30)
                Dim wristleft As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.WristLeft).Position, DepthImageFormat.Resolution640x480Fps30)
                Dim handleft As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.HandLeft).Position, DepthImageFormat.Resolution640x480Fps30)
                gfx.DrawLine(penz, New Point(shoulderleft.X, shoulderleft.Y), New Point(elbowleft.X, elbowleft.Y))
                gfx.DrawLine(penz, New Point(elbowleft.X, elbowleft.Y), New Point(wristleft.X, wristleft.Y))
                gfx.DrawLine(penz, New Point(wristleft.X, wristleft.Y), New Point(handleft.X, handleft.Y))
                'Right Leg
                Dim FootRight As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.FootRight).Position, DepthImageFormat.Resolution640x480Fps30)
                Dim AnkleRight As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.AnkleRight).Position, DepthImageFormat.Resolution640x480Fps30)
                Dim KneeRight As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.KneeRight).Position, DepthImageFormat.Resolution640x480Fps30)
                Dim HipRight As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.HipRight).Position, DepthImageFormat.Resolution640x480Fps30)
                gfx.DrawLine(penz, New Point(HipRight.X, HipRight.Y), New Point(KneeRight.X, KneeRight.Y))
                gfx.DrawLine(penz, New Point(KneeRight.X, KneeRight.Y), New Point(AnkleRight.X, AnkleRight.Y))
                gfx.DrawLine(penz, New Point(AnkleRight.X, AnkleRight.Y), New Point(FootRight.X, FootRight.Y))
                'Left Leg
                Dim FootLeft As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.FootLeft).Position, DepthImageFormat.Resolution640x480Fps30)
                Dim AnkleLeft As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.AnkleLeft).Position, DepthImageFormat.Resolution640x480Fps30)
                Dim KneeLeft As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.KneeLeft).Position, DepthImageFormat.Resolution640x480Fps30)
                Dim HipLeft As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.HipLeft).Position, DepthImageFormat.Resolution640x480Fps30)
                gfx.DrawLine(penz, New Point(HipLeft.X, HipLeft.Y), New Point(KneeLeft.X, KneeLeft.Y))
                gfx.DrawLine(penz, New Point(KneeLeft.X, KneeLeft.Y), New Point(AnkleLeft.X, AnkleLeft.Y))
                gfx.DrawLine(penz, New Point(AnkleLeft.X, AnkleLeft.Y), New Point(FootLeft.X, FootLeft.Y))
                'Body
                Dim Head As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.Head).Position, DepthImageFormat.Resolution640x480Fps30)
                Dim Shouldercenter As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.ShoulderCenter).Position, DepthImageFormat.Resolution640x480Fps30)
                Dim Spine As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.Spine).Position, DepthImageFormat.Resolution640x480Fps30)
                Dim HipCenter As DepthImagePoint = kinz.MapSkeletonPointToDepth(skel.Joints(JointType.HipCenter).Position, DepthImageFormat.Resolution640x480Fps30)
                gfx.DrawLine(penz, New Point(Head.X, Head.Y), New Point(Shouldercenter.X, Shouldercenter.Y))
                gfx.DrawLine(penz, New Point(Shouldercenter.X, Shouldercenter.Y), New Point(shoulderright.X, shoulderright.Y))
                gfx.DrawLine(penz, New Point(Shouldercenter.X, Shouldercenter.Y), New Point(shoulderleft.X, shoulderleft.Y))
                gfx.DrawLine(penz, New Point(Shouldercenter.X, Shouldercenter.Y), New Point(Spine.X, Spine.Y))
                gfx.DrawLine(penz, New Point(HipCenter.X, HipCenter.Y), New Point(Spine.X, Spine.Y))
                gfx.DrawLine(penz, New Point(HipCenter.X, HipCenter.Y), New Point(HipRight.X, HipRight.Y))
                gfx.DrawLine(penz, New Point(HipCenter.X, HipCenter.Y), New Point(HipLeft.X, HipLeft.Y))

                GHead = Head

                GShoulderRight = shoulderright
                GElbowRight = elbowright
                GWristRight = wristright
                GHandRight = handright

                GShoulderLeft = shoulderright
                GElbowLeft = elbowright
                GWristLeft = wristright
                GHandLeft = handleft

                GFootRight = FootRight
                GFootLeft = FootLeft

            Next skel

        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timKinect.Tick

        colormethod()
        skeletonmethod()
        picHITW.Image = piccolor

        If lblGameTime.Text = "0" Then

            If picFootLeft.BackColor = Color.Blue Or picFootRight.BackColor = Color.Blue Or PicHandLeft.BackColor = Color.Blue Or picHandRight.BackColor = Color.Blue Or picHead.BackColor = Color.Blue Then

                lblWinOrLose.Text = "You Lose!"

            End If

        End If

        If GameTime > 0 And picFootLeft.BackColor = Color.Red And picFootRight.BackColor = Color.Red And PicHandLeft.BackColor = Color.Red And picHandRight.BackColor = Color.Red And picHead.BackColor = Color.Red Then

            lblWinOrLose.Text = "You Win!"
            timGameTime.Stop()

        End If

        Dim headbounds As Rectangle = New Rectangle(New Point(GHead.X + picHITW.Location.X, GHead.Y + picHITW.Location.Y), New Size(1, 1))

        Dim handrightbounds As Rectangle = New Rectangle(New Point(GHandRight.X + picHITW.Location.X, GHandRight.Y + picHITW.Location.Y), New Size(1, 1))

        Dim handleftbounds As Rectangle = New Rectangle(New Point(GHandLeft.X + picHITW.Location.X, GHandLeft.Y + picHITW.Location.Y), New Size(1, 1))

        Dim footrightbounds As Rectangle = New Rectangle(New Point(GFootRight.X + picHITW.Location.X, GFootRight.Y + picHITW.Location.Y), New Size(1, 1))

        Dim footleftbounds As Rectangle = New Rectangle(New Point(GFootLeft.X + picHITW.Location.X, GFootLeft.Y + picHITW.Location.Y), New Size(1, 1))

        'head
        If headbounds.IntersectsWith(picHead.Bounds) Then

            picHead.BackColor = Color.Red

        Else

            picHead.BackColor = Color.Blue

        End If

        'hands
        If handrightbounds.IntersectsWith(picHandRight.Bounds) Then

            picHandRight.BackColor = Color.Red

        Else

            picHandRight.BackColor = Color.Blue

        End If

        If handleftbounds.IntersectsWith(PicHandLeft.Bounds) Then

            PicHandLeft.BackColor = Color.Red

        Else

            PicHandLeft.BackColor = Color.Blue

        End If

        'feet
        If footrightbounds.IntersectsWith(picFootRight.Bounds) Then

            picFootRight.BackColor = Color.Red

        Else

            picFootRight.BackColor = Color.Blue

        End If

        If footleftbounds.IntersectsWith(picFootLeft.Bounds) Then

            picFootLeft.BackColor = Color.Red

        Else

            picFootLeft.BackColor = Color.Blue

        End If

    End Sub

    Private Sub kinz_ColorFrameReady(sender As Object, e As ColorImageFrameReadyEventArgs) Handles kinz.ColorFrameReady

        imagez = e.OpenColorImageFrame

    End Sub

    Private Sub kinz_SkeletonFrameReady(sender As Object, e As SkeletonFrameReadyEventArgs) Handles kinz.SkeletonFrameReady

        skeletonz = e.OpenSkeletonFrame

    End Sub

    Private Sub timGameTime_Tick(sender As Object, e As EventArgs) Handles timGameTime.Tick

        lblGameTime.Text = GameTime

        If GameTime > 0 Then

            GameTime -= 1

        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmMainMenu.Show()
    End Sub

    Private Sub btnNextLevel_Click(sender As Object, e As EventArgs) Handles btnNextLevel.Click
        Me.Close()
        frmLevel3.Show()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles timGoodSkel.Tick
        If GHead.X = 0 And GHead.Y = 0 Then

            Me.BackColor = Color.Red
            btnBack.BackColor = Color.Red
            btnNextLevel.BackColor = Color.Red

            'skeletonz = Nothing
        Else

            Me.BackColor = Color.Green
            btnBack.BackColor = Color.Green
            btnNextLevel.BackColor = Color.Green

        End If
    End Sub
End Class