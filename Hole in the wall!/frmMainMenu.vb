Imports Microsoft.Kinect

Public Class frmMainMenu

    Dim GHead As DepthImagePoint
    Dim GHandRight As DepthImagePoint
    Dim GHandLeft As DepthImagePoint

    Dim WithEvents kinz As KinectSensor
    Dim imagez As ColorImageFrame
    Dim skeletonz As SkeletonFrame
    Dim piccolor As Bitmap = New Bitmap(640, 480, Imaging.PixelFormat.Format32bppRgb)
    Dim gfx As Graphics = Graphics.FromImage(piccolor)

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        My.Computer.Audio.Play(My.Resources.Hole_in_the_wall_, AudioPlayMode.BackgroundLoop)

        For Each potentialSensor In KinectSensor.KinectSensors

            If potentialSensor.Status = KinectStatus.Connected Then

                kinz = potentialSensor

                Exit For

            End If

        Next potentialSensor

        kinz.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30)
        kinz.SkeletonStream.Enable()

        kinz.Start()

        kinz.SkeletonStream.TrackingMode = SkeletonTrackingMode.Default
        kinz.ElevationAngle = -10

        Dim rnd As New Random

        Me.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))

    End Sub

    Private Sub colorready(ByVal sender As Object, ByVal e As ColorImageFrameReadyEventArgs)

        imagez = e.OpenColorImageFrame

    End Sub

    Private Sub skeletonready(ByVal sender As Object, ByVal e As SkeletonFrameReadyEventArgs)

        skeletonz = e.OpenSkeletonFrame

    End Sub

    'Color Video
    Public Sub colormethod()

        Dim pixz(kinz.ColorStream.FramePixelDataLength - 1) As Byte

        If Me.Visible = True Then

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

        End If

    End Sub

    'Skeleton display
    Public Sub skeletonmethod()

        Dim penz As Pen = New Pen(Brushes.LimeGreen, 3)

        Dim skeletons(-1) As Skeleton

        If skeletonz IsNot Nothing And Me.Visible = True Then

            skeletons = New Skeleton(skeletonz.SkeletonArrayLength - 1) {}
            skeletonz.CopySkeletonDataTo(skeletons)

        End If

        If skeletons.Length <> 0 And Me.Visible = True Then

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
                GHandRight = handright
                GHandLeft = handleft

            Next skel

        End If

    End Sub

    Private Sub timBackColor_Tick(sender As Object, e As EventArgs) Handles timBackColor.Tick

        Dim rnd As New Random

        Me.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))

    End Sub

    Private Sub kinz_ColorFrameReady(sender As Object, e As ColorImageFrameReadyEventArgs) Handles kinz.ColorFrameReady

        imagez = e.OpenColorImageFrame

    End Sub

    Private Sub kinz_SkeletonFrameReady(sender As Object, e As SkeletonFrameReadyEventArgs) Handles kinz.SkeletonFrameReady

        skeletonz = e.OpenSkeletonFrame

    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click

        Me.Hide()
        frmLevelSelect.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub

    Private Sub timKinect_Tick(sender As Object, e As EventArgs) Handles timKinect.Tick

        colormethod()
        skeletonmethod()
        PictureBox1.Image = piccolor

    End Sub

End Class
