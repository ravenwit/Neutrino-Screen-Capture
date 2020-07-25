Public Class Area_Capture
    Dim NewArea As New System.Drawing.Point()
    Dim X, Y As Integer
    Public Function CaptureImage(ByVal X As Integer, ByVal Y As Integer, ByVal Width As Integer, ByVal Height As Integer)
        Dim AreaPicture As New System.Drawing.Bitmap(Width, Height)
        Dim G As Graphics = Graphics.FromImage(AreaPicture)
        G.CopyFromScreen(New Point(X, Y), New Point(0, 0), AreaPicture.Size)
        G.Dispose()
        Return AreaPicture
    End Function

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub


    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = MouseButtons.Left Then
            NewArea = Control.MousePosition
            NewArea.X -= (X)
            NewArea.Y -= (Y)
            Me.Location = NewArea
        End If
    End Sub


    Private Sub Screen_Capture_Area_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Hide()
        Neutrino_Screen_Capture_Image_Viewer.PictureBox1.Image = CaptureImage(Me.Location.X, Me.Location.Y, Me.ClientSize.Width, Me.ClientSize.Height)
        screencapture.Show()
        screencapture.WindowState = FormWindowState.Maximized

    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Hide()
        Neutrino_Screen_Capture_Image_Viewer.PictureBox1.Image = CaptureImage(Me.Location.X, Me.Location.Y, Me.ClientSize.Width, Me.ClientSize.Height)
        If My.Settings.ImageViewer = True Then
            Neutrino_Screen_Capture_Image_Viewer.Show()
            Neutrino_Screen_Capture_Image_Viewer.WindowState = FormWindowState.Maximized
        End If
        If My.Settings.DefaultDir_Bool = True Then
            Try

                If My.Settings.autonum = True Then Neutrino_Screen_Capture_Image_Viewer.PictureBox1.Image.Save((My.Settings.Default_Directory + "\" + (My.Settings.FileName).ToString + (My.Settings.AutomaticNmber).ToString + "." + (My.Settings.FileFormat).ToString).ToString, My.Settings.FileFormat) Else Neutrino_Screen_Capture_Image_Viewer.PictureBox1.Image.Save((My.Settings.Default_Directory + "\" + (My.Settings.FileName).ToString + "." + (My.Settings.FileFormat).ToString).ToString, My.Settings.FileFormat)

            Catch ex As Exception
                MsgBox("Sorry ! An error occured to save the image file. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
            End Try
            If My.Settings.autonum = True Then My.Settings.AutomaticNmber = My.Settings.AutomaticNmber + 1 Else My.Settings.AutomaticNmber = My.Settings.AutomaticNmber

        End If

        If My.Settings.autonum = True Then My.Settings.AutomaticNmber = My.Settings.AutomaticNmber + 1
        If My.Settings.NotificationShow = True Then
            screencapture.NotifyIcon1.BalloonTipTitle = "Area Captured"
            screencapture.NotifyIcon1.BalloonTipText = "Neutrino Screen Capture captured an area"
            screencapture.NotifyIcon1.ShowBalloonTip(My.Settings.NotificationDuration)
        End If

    End Sub

    Private Sub Area_Capture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class