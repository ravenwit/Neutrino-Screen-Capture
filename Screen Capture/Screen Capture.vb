Public Class screencapture
    Dim pictureForm As New Form
    Dim picturebox As New PictureBox
    Dim c = 1
    Dim seconds
    Dim timer As Boolean = False
    Dim TimerInterval As Integer
    Dim AutoInterval As Integer

    <System.Runtime.InteropServices.DllImport("user32.dll")> _
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function

    Friend Function ScreenShot(ByVal Screen_Capture As Boolean, ByVal Area_Capture As Boolean, ByVal Window_Capture As Boolean, ByVal Timer As Boolean, ByVal Auto As Boolean)
        If Screen_Capture = True Then
            Area_Capture = False
            Timer = False
            Auto = False
        ElseIf Area_Capture = True Then
            Screen_Capture = False
            Timer = False
            Auto = False
            AreaCaptureToolStripMenuItem.PerformClick()
            Timer1.Enabled = False
        ElseIf Timer = True Then
            Screen_Capture = False
            Area_Capture = False
            Auto = False
        ElseIf Auto = True Then
            Screen_Capture = False
            Area_Capture = False
            Timer = False
        End If
        If Area_Capture = False Then
            If My.Settings.PlaySound = True And Auto = False Then My.Computer.Audio.Play(Application.StartupPath + "\Camera.wav")
            Dim bounds As Rectangle
            Dim screenshot_image As System.Drawing.Bitmap
            Dim graph As Graphics

            If Window_Capture = False Then bounds = Screen.PrimaryScreen.Bounds Else bounds = My.Computer.Screen.WorkingArea
            screenshot_image = New System.Drawing.Bitmap(bounds.Width, bounds.Height, My.Settings.PixelFormat)
            graph = Graphics.FromImage(screenshot_image)
            graph.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
            Neutrino_Screen_Capture_Image_Viewer.PictureBox1.Image = screenshot_image
            If Auto = True Then
                Timer1.Enabled = True
                If CheckBox2.Checked = True Then Me.Opacity = 100 Else If My.Settings.Trasparent = True Then Me.Opacity = 0 Else Me.Opacity = My.Settings.Transparency
                Try
                    screenshot_image.Save((My.Settings.Default_Directory + "\" + My.Settings.FileName + (My.Settings.AutomaticNmber).ToString + "." + (My.Settings.FileFormat).ToString).ToString, My.Settings.FileFormat)
                Catch ex As Exception
                    MsgBox("Sorry ! An error occured to save the image file. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
                End Try
                My.Settings.AutomaticNmber = My.Settings.AutomaticNmber + 1
            Else
                Timer1.Enabled = False
                Me.Opacity = 100
                Me.ShowInTaskbar = True
                If My.Settings.MessageShow = True Then MsgBox("Neutrino Screen Capture captured your screen." + vbCrLf + "File Name :   " + My.Settings.FileName + vbCrLf + "Folder :     " + (My.Settings.Default_Directory).ToString, MsgBoxStyle.Information, "Neutrino Screen Capture")
                Neutrino_Screen_Capture_Image_Viewer.WindowState = FormWindowState.Maximized
                If My.Settings.ImageViewer = True Then Neutrino_Screen_Capture_Image_Viewer.Show()
                Me.ShowInTaskbar = True
                If My.Settings.DefaultDir_Bool = True Then

                    Try
                        If My.Settings.autonum = True Then screenshot_image.Save((My.Settings.Default_Directory + "\" + My.Settings.FileName + (My.Settings.AutomaticNmber).ToString + "." + (My.Settings.FileFormat).ToString).ToString, My.Settings.FileFormat) Else screenshot_image.Save((My.Settings.Default_Directory + "\" + My.Settings.FileName + "." + (My.Settings.FileFormat).ToString).ToString, My.Settings.FileFormat)
                    Catch ex As Exception
                        MsgBox("Sorry ! An error occured to save the image file. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
                    End Try
                End If
            End If
        End If
        If My.Settings.NotificationShow = True Then
            NotifyIcon1.BalloonTipTitle = "Screen Captured"
            NotifyIcon1.BalloonTipText = "Neutrino Screen Capture captured your screen."
            NotifyIcon1.ShowBalloonTip(My.Settings.NotificationDuration)

        End If
        If My.Settings.ClipBoardCopy = True Then Clipboard.SetImage(Neutrino_Screen_Capture_Image_Viewer.PictureBox1.Image)
        If My.Settings.autonum = True Then My.Settings.AutomaticNmber = My.Settings.AutomaticNmber + 1

        Return 0
    End Function

    Private Sub screencapture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedItem = "Seconds"
        ComboBox2.SelectedItem = "Seconds"
        ComboBox3.SelectedItem = "Seconds"
        If CheckBox3.Checked = True Then GroupBox2.Enabled = True Else GroupBox2.Enabled = False
        If CheckBox4.Checked = True Then GroupBox3.Enabled = True Else GroupBox3.Enabled = False
        If My.Settings.ImageViewer = True Then chkImageViewer.Checked = True
        If My.Settings.NotificationShow = True Then
            chkNotification.Checked = True
            lblDuration1.Visible = True
            numNotifyDuration.Visible = True
            cmbTimeOptions1.Visible = True
            chkMessage.Location = New Point(chkMessage.Location.X, 122)
        ElseIf My.Settings.NotificationShow = False Then
            chkNotification.Checked = False
            lblDuration1.Visible = False
            numNotifyDuration.Visible = False
            cmbTimeOptions1.Visible = False
            chkMessage.Location = New Point(chkMessage.Location.X, 92)
        End If
        If My.Settings.MessageShow = True Then
            chkMessage.Checked = True
        ElseIf My.Settings.MessageShow = False Then
            chkMessage.Checked = False
        End If
        If My.Settings.PlaySound = True Then chkSound.Checked = True Else chkSound.Checked = False
        If My.Settings.Trasparent = True Then chkTransparent.Checked = True Else chkTransparent.Checked = False
        If chkTransparent.Checked = True Then
            lblTrans.Visible = False
            txtTrans.Visible = False
            txtTrans.Text = My.Settings.Transparency
        ElseIf chkTransparent.Checked = False Then
            lblTrans.Visible = True
            txtTrans.Visible = True

        End If


        If My.Settings.DefaultDir_Bool = True Then chkAutoSave.Checked = True Else chkAutoSave.Checked = False
        If My.Settings.taskbar = True Then chktask.Checked = True Else chktask.Checked = False
        If My.Settings.ClipBoardCopy = True Then chkImageClip.Checked = True Else chkImageClip.Checked = False
        cmbFileFormat.SelectedItem = (My.Settings.FileFormat).ToString
        Select Case My.Settings.PixelFormat
            Case Imaging.PixelFormat.Alpha
                cmbPixelFormat.SelectedItem = "Alpha"
            Case Imaging.PixelFormat.PAlpha
                cmbPixelFormat.SelectedItem = "PAlpha"
            Case Imaging.PixelFormat.Extended
                cmbPixelFormat.SelectedItem = "Extended"
            Case Imaging.PixelFormat.Format16bppArgb1555
                cmbPixelFormat.SelectedItem = "Argb (16 bpp)  1555"
            Case Imaging.PixelFormat.Format32bppArgb
                cmbPixelFormat.SelectedItem = "Argb (32 bpp)"
            Case Imaging.PixelFormat.Format64bppArgb
                cmbPixelFormat.SelectedItem = "Argb (64 bpp)"
            Case Imaging.PixelFormat.Format16bppGrayScale
                cmbPixelFormat.SelectedItem = "Gray Scale (16 bpp)"
            Case Imaging.PixelFormat.Format16bppRgb555
                cmbPixelFormat.SelectedItem = "Rgb (16 bpp) 555"
            Case Imaging.PixelFormat.Format16bppRgb565
                cmbPixelFormat.SelectedItem = "Rgb (16 bpp) 565"
            Case Imaging.PixelFormat.Format24bppRgb
                cmbPixelFormat.SelectedItem = "Rgb (24 bpp)"
            Case Imaging.PixelFormat.Format32bppRgb
                cmbPixelFormat.SelectedItem = "Rgb (32 bpp)"
            Case Imaging.PixelFormat.Format48bppRgb
                cmbPixelFormat.SelectedItem = "Rgb (48 bpp)"
            Case Imaging.PixelFormat.Indexed
                cmbPixelFormat.SelectedItem = "Indexed"
            Case Imaging.PixelFormat.Format1bppIndexed
                cmbPixelFormat.SelectedItem = "Indexed (1 bpp)"
            Case Imaging.PixelFormat.Format4bppIndexed
                cmbPixelFormat.SelectedItem = "Indexed (4 bpp)"
            Case Imaging.PixelFormat.Format8bppIndexed
                cmbPixelFormat.SelectedItem = "Indexed (8 bpp)"
            Case Imaging.PixelFormat.Format32bppPArgb
                cmbPixelFormat.SelectedItem = "PArgb (32 bpp)"
            Case Imaging.PixelFormat.Format64bppPArgb
                cmbPixelFormat.SelectedItem = "PArgb (64 bpp)"
            Case Imaging.PixelFormat.DontCare
                cmbPixelFormat.SelectedItem = "Don't Care"
        End Select
        cmbPixelFormat.SelectedItem = (My.Settings.PixelFormat).ToString
        cmbTimeOptions1.SelectedItem = "Seconds"
        txtFileName.Text = My.Settings.FileName
        txtFolder.Text = My.Settings.Default_Directory
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub

    Private Sub ScreenCaptureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScreenCaptureToolStripMenuItem.Click
        ScreenShot(True, False, False, False, False)
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub AboutNeutrinoScreenCaptureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutNeutrinoScreenCaptureToolStripMenuItem.Click
        About_Neutrino_Screen_Capture.Show()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        Help.Show()

    End Sub

    Private Sub ImageViewerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageViewerToolStripMenuItem.Click
        Neutrino_Screen_Capture_Image_Viewer.Show()

    End Sub

    Private Sub ImageConverterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageConverterToolStripMenuItem.Click
        Convert_Image.Show()

    End Sub

    Private Sub AreaCaptureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaCaptureToolStripMenuItem.Click
        Area_Capture.Show()
        Area_Capture.Opacity = 100
        Area_Capture.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If radCapScr.Checked = True Then
            radCapAra.Checked = False
            radCapWin.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            ScreenShot(True, False, False, False, False)
        ElseIf radCapAra.Checked = True Then
            radCapScr.Checked = False
            radCapWin.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            ScreenShot(False, True, False, False, False)
        ElseIf radCapWin.Checked = True Then
            radCapScr.Checked = False
            radCapAra.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
            ScreenShot(False, False, True, False, False)
        ElseIf CheckBox3.Checked = True Then
            radCapScr.Checked = False
            radCapAra.Checked = False
            radCapWin.Checked = False
            CheckBox4.Checked = False
            ScreenShot(False, False, False, True, False)
        ElseIf CheckBox4.Checked = True Then
            radCapScr.Checked = False
            radCapAra.Checked = False
            radCapWin.Checked = False
            CheckBox3.Checked = False
            ScreenShot(False, False, False, False, True)
            If CheckBox1.Checked = True Then Timer3.Enabled = True
            If CheckBox1.Checked = False Then Timer3.Enabled = False

        End If

    End Sub

    Private Sub ChangeDefaultDirectoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeDefaultDirectoryToolStripMenuItem.Click
        Dim defaultdir As New FolderBrowserDialog
        Try
            If defaultdir.ShowDialog = DialogResult.OK Then
                My.Settings.Default_Directory = defaultdir.SelectedPath
                txtFolder.Text = My.Settings.Default_Directory

            End If
        Catch ex As Exception
            MsgBox("An error occured. Please try again", MsgBoxStyle.Critical, "Error")
        End Try
        My.Settings.Save()

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If My.Settings.NotificationShow = True Then
            Me.NotifyIcon1.BalloonTipTitle = "Timer Capture started"
            Me.NotifyIcon1.BalloonTipText = seconds & "  Seconds remaining..."
            Me.NotifyIcon1.ShowBalloonTip(970)
            seconds = seconds - 1
            If seconds <= -1 Then
                Timer1.Enabled = False
            End If
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If radCapAra.Checked = False And CheckBox2.Checked = False Then
            If My.Settings.Trasparent = True Then Me.Opacity = 0 Else Me.Opacity = My.Settings.Transparency
            If My.Settings.taskbar = True Then Me.ShowInTaskbar = True Else Me.ShowInTaskbar = False
        Else
            Me.Opacity = 100
            Me.ShowInTaskbar = True
        End If

        Timer1.Enabled = True

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            GroupBox2.Enabled = True
            radCapScr.Checked = False
            radCapAra.Checked = False

            CheckBox3.Font = New System.Drawing.Font(CheckBox3.Font, FontStyle.Bold)
        End If

        If CheckBox3.Checked = False Then
            GroupBox2.Enabled = False
            CheckBox3.Font = New System.Drawing.Font(CheckBox3.Font, FontStyle.Regular)
        End If


    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            GroupBox3.Enabled = True
            radCapScr.Checked = False
            radCapAra.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Font = New System.Drawing.Font(CheckBox3.Font, FontStyle.Bold)
        End If

        If CheckBox4.Checked = False Then
            GroupBox3.Enabled = False
            CheckBox4.Font = New System.Drawing.Font(CheckBox3.Font, FontStyle.Regular)
        End If


    End Sub

    Private Sub NumericUpDown3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown3.ValueChanged
        If Val(NumericUpDown3.Value) <> vbNull Then
            Dim time = 1
            Select Case ComboBox1.SelectedItem
                Case "Seconds"
                    time = Val(NumericUpDown3.Value) * 1000
                Case "Centiseconds"
                    time = Val(NumericUpDown3.Value) * 100
                Case "Miliseconds"
                    time = Val(NumericUpDown3.Value)

            End Select
            TimerInterval = time

            Me.Timer1.Interval = TimerInterval
            seconds = Me.Timer1.Interval / 1000

            timer = True

        Else
            MsgBox("Please enter a valid time.", , "Error!")
        End If

    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        If Val(NumericUpDown1.Value) <> vbNull Then
            Dim time = 1
            Select Case ComboBox1.SelectedItem
                Case "Seconds"
                    time = Val(NumericUpDown1.Value) * 1000
                Case "Centiseconds"
                    time = Val(NumericUpDown1.Value) * 100
                Case "Miliseconds"
                    time = Val(NumericUpDown1.Value)

            End Select
            If NumericUpDown1.Value > 0 Then Me.Timer1.Interval = time
            seconds = Me.Timer1.Interval / 1000



        Else
            MsgBox("Please enter a valid time.", , "Error!")
        End If
        If CheckBox1.Checked = False Then CheckBox2.Checked = True


    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            CheckBox2.Checked = False
            NumericUpDown2.Enabled = True
            ComboBox3.Enabled = True
            CheckBox1.Font = New System.Drawing.Font(CheckBox1.Font, FontStyle.Bold)
        End If

        If CheckBox1.Checked = False Then

            CheckBox2.Checked = True
            NumericUpDown2.Enabled = False
            ComboBox3.Enabled = False
            CheckBox1.Font = New System.Drawing.Font(CheckBox1.Font, FontStyle.Regular)
        End If

    End Sub

    Private Sub NumericUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        If NumericUpDown2.Value > 0 Then
            Select Case ComboBox3.SelectedItem
                Case "Seconds"
                    Timer3.Interval = NumericUpDown2.Value * 1000
                Case "Centiseconds"
                    Timer3.Interval = NumericUpDown2.Value * 100
                Case "Miliseconds"
                    Timer3.Interval = NumericUpDown2.Value

            End Select
        End If
        
        If CheckBox1.Checked = False Then CheckBox2.Checked = True
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        My.Computer.Audio.Play(Application.StartupPath + "\Camera.wav")
        Timer1.Enabled = False
        Timer3.Enabled = False
        If My.Settings.ImageViewer = True Then
            Neutrino_Screen_Capture_Image_Viewer.Show()
            Neutrino_Screen_Capture_Image_Viewer.WindowState = FormWindowState.Maximized
        End If
        If My.Settings.MessageShow = True Then MsgBox("Neutrino Screen Capture captured your screen." + vbCrLf + "File Name :    " + My.Settings.FileName + vbCrLf, MsgBoxStyle.Information, "Neutrino Screen Capture")
        Me.Opacity = 100
        Me.ShowInTaskbar = True

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then CheckBox2.Font = New System.Drawing.Font(CheckBox2.Font, FontStyle.Bold)
        If CheckBox2.Checked = False Then CheckBox2.Font = New System.Drawing.Font(CheckBox2.Font, FontStyle.Regular)

    End Sub

    Private Sub radCapScr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCapScr.CheckedChanged
        If radCapScr.Checked = True Then radCapScr.Font = New System.Drawing.Font(radCapScr.Font, FontStyle.Bold)
        If radCapScr.Checked = False Then radCapScr.Font = New System.Drawing.Font(radCapScr.Font, FontStyle.Regular)

    End Sub

    Private Sub radCapAra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCapAra.CheckedChanged
        If radCapAra.Checked = True Then radCapAra.Font = New System.Drawing.Font(radCapAra.Font, FontStyle.Bold)
        If radCapAra.Checked = False Then radCapAra.Font = New System.Drawing.Font(radCapAra.Font, FontStyle.Regular)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(Application.StartupPath + "\Camera.wav")
        Timer1.Enabled = False
        Timer3.Enabled = False
        If My.Settings.ImageViewer = True Then
            Neutrino_Screen_Capture_Image_Viewer.Show()
            Neutrino_Screen_Capture_Image_Viewer.WindowState = FormWindowState.Maximized
        End If
        If My.Settings.MessageShow = True Then MsgBox("Neutrino Screen Capture captured your screen." + vbCrLf + "File Name :    " + My.Settings.FileName + vbCrLf, MsgBoxStyle.Information, "Neutrino Screen Capture")
        Me.Opacity = 100
        Me.ShowInTaskbar = True

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFileFormat.SelectedIndexChanged
        Select Case cmbFileFormat.SelectedItem
            Case "JPEG"
                My.Settings.FileFormat = System.Drawing.Imaging.ImageFormat.Jpeg
            Case "PNG"
                My.Settings.FileFormat = System.Drawing.Imaging.ImageFormat.Png
            Case "BMP"
                My.Settings.FileFormat = System.Drawing.Imaging.ImageFormat.Bmp
            Case "GIF"
                My.Settings.FileFormat = System.Drawing.Imaging.ImageFormat.Gif
            Case "TIFF"
                My.Settings.FileFormat = System.Drawing.Imaging.ImageFormat.Tiff
            Case "EMF"
                My.Settings.FileFormat = System.Drawing.Imaging.ImageFormat.Emf
            Case "EXIF"
                My.Settings.FileFormat = System.Drawing.Imaging.ImageFormat.Exif
            Case "WMF"
                My.Settings.FileFormat = System.Drawing.Imaging.ImageFormat.Wmf

        End Select
        My.Settings.Save()

    End Sub

    Private Sub cmbPixelFormat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPixelFormat.SelectedIndexChanged
        Select Case cmbPixelFormat.SelectedItem
            Case "Alpha"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Alpha
            Case "PAlpha"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.PAlpha
            Case "Canonical"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Canonical
            Case "Extended"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Extended
            Case "Argb (16 bpp)  1555"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Format16bppArgb1555
            Case "Argb (32 bpp)"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Format32bppArgb
            Case "Argb (64 bpp)"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Format64bppArgb
            Case "Gray Scale (16 bpp)"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Format16bppGrayScale
            Case "Rgb (16 bpp) 555"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Format16bppRgb555
            Case "Rgb (16 bpp) 565"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Format16bppRgb565
            Case "Rgb (24 bpp)"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Format24bppRgb
            Case "Rgb (32 bpp)"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Format32bppRgb
            Case "Rgb (48 bpp)"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Format48bppRgb
            Case "Indexed"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Indexed
            Case "Indexed (1 bpp)"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Format1bppIndexed
            Case "Indexed (1 bpp)"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Format1bppIndexed
            Case "Indexed (4 bpp)"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Format4bppIndexed
            Case "Indexed (8 bpp)"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Format8bppIndexed
            Case "PArgb (32 bpp)"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Format32bppPArgb
            Case "PArgb (64 bpp)"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.Format64bppPArgb
            Case "Don't Care"
                My.Settings.PixelFormat = System.Drawing.Imaging.PixelFormat.DontCare

        End Select
        My.Settings.Save()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim openFolder As New FolderBrowserDialog
        If openFolder.ShowDialog = DialogResult.OK Then
            My.Settings.Default_Directory = openFolder.SelectedPath
            txtFolder.Text = My.Settings.Default_Directory

        End If
        My.Settings.Save()


    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoSave.CheckedChanged
        If chkAutoSave.Checked = True Then
            My.Settings.DefaultDir_Bool = True
            chkAutoSave.Font = New System.Drawing.Font(chkAutoSave.Font, FontStyle.Bold)
        ElseIf chkAutoSave.Checked = False Then
            My.Settings.DefaultDir_Bool = False
            chkAutoSave.Font = New System.Drawing.Font(chkAutoSave.Font, FontStyle.Regular)
        End If



    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFileName.TextChanged
        My.Settings.FileName = txtFileName.Text
        My.Settings.Save()


    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImageViewer.CheckedChanged
        If chkImageViewer.Checked = True Then
            My.Settings.ImageViewer = True
            chkImageViewer.Font = New Font(chkImageViewer.Font, FontStyle.Bold)
        Else
            My.Settings.ImageViewer = False
            chkImageViewer.Font = New Font(chkImageViewer.Font, FontStyle.Regular)
        End If
        My.Settings.Save()


    End Sub

    Private Sub chkNotification_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNotification.CheckedChanged
        Dim DurationPoint As New Point
        DurationPoint = New System.Drawing.Point(133, 60)
        If chkNotification.Checked = True Then
            My.Settings.NotificationShow = True
            chkNotification.Font = New Font(chkNotification.Font, FontStyle.Bold)
            lblDuration1.Visible = True
            numNotifyDuration.Visible = True
            cmbTimeOptions1.Visible = True
            chkMessage.Location = New Point(chkMessage.Location.X, 122)
        ElseIf chkNotification.Checked = False Then
            My.Settings.NotificationShow = False
            chkNotification.Font = New Font(chkNotification.Font, FontStyle.Regular)
            lblDuration1.Visible = False
            numNotifyDuration.Visible = False
            cmbTimeOptions1.Visible = False
            chkMessage.Location = New Point(chkMessage.Location.X, 92)


        End If
        My.Settings.Save()


    End Sub

    Private Sub numNotifyDuration_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numNotifyDuration.ValueChanged
        Select Case cmbTimeOptions1.SelectedItem
            Case "Seconds"
                My.Settings.NotificationDuration = numNotifyDuration.Value * 1000
            Case "Centiseconds"
                My.Settings.NotificationDuration = numNotifyDuration.Value * 100
            Case "Miliseconds"
                My.Settings.NotificationDuration = numNotifyDuration.Value

        End Select
        My.Settings.Save()

    End Sub

    Private Sub chkMessage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMessage.CheckedChanged
        If chkMessage.Checked = True Then
            My.Settings.MessageShow = True
            chkMessage.Font = New Font(chkMessage.Font, FontStyle.Bold)

        ElseIf chkMessage.Checked = False Then
            My.Settings.MessageShow = False
            chkMessage.Font = New Font(chkMessage.Font, FontStyle.Regular)
        End If
        My.Settings.Save()


    End Sub

    Private Sub chkSound_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSound.CheckedChanged
        If chkSound.Checked = True Then
            My.Settings.PlaySound = True
            chkSound.Font = New Font(chkSound.Font, FontStyle.Bold)
        Else
            My.Settings.PlaySound = False
            chkSound.Font = New Font(chkSound.Font, FontStyle.Regular)
        End If
        My.Settings.Save()


    End Sub

    Private Sub chkTransparent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTransparent.CheckedChanged
        If chkTransparent.Checked = True Then
            My.Settings.Trasparent = True
            chkTransparent.Font = New Font(chkTransparent.Font, FontStyle.Bold)
            lblTrans.Visible = False
            txtTrans.Visible = False
        ElseIf chkTransparent.Checked = False Then
            My.Settings.Trasparent = False
            chkTransparent.Font = New Font(chkTransparent.Font, FontStyle.Regular)
            lblTrans.Visible = True
            txtTrans.Visible = True

        End If
        My.Settings.Save()


    End Sub

    Private Sub txtTrans_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTrans.TextChanged
        If txtTrans.Text > 100 Then
            MsgBox("Invalid Transparency. Transparency must be less than 100.", MsgBoxStyle.Exclamation, "Error")
            txtTrans.Text = 100
        ElseIf txtTrans.Text < 100 Then
            My.Settings.Transparency = 100 - txtTrans.Text
            My.Settings.Save()
        End If



    End Sub

    Private Sub CheckBox6_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktask.CheckedChanged
        If chktask.Checked = True Then
            My.Settings.taskbar = True
            chktask.Font = New Font(chktask.Font, FontStyle.Bold)
        Else

            My.Settings.taskbar = False
            chktask.Font = New Font(chktask.Font, FontStyle.Regular)
        End If
        My.Settings.Save()

    End Sub

    Private Sub CheckBox5_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkImageClip.CheckedChanged
        If chkImageClip.Checked = True Then
            chkImageClip.Font = New Font(chkImageClip.Font, FontStyle.Bold)
            My.Settings.ClipBoardCopy = True
        Else
            chkImageClip.Font = New Font(chkImageClip.Font, FontStyle.Regular)
            My.Settings.ClipBoardCopy = False

        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub MinimizeToSystemTrayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeToSystemTrayToolStripMenuItem.Click
        Me.Hide()

    End Sub

    Private Sub CaptureScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptureScreenToolStripMenuItem.Click
        ScreenCaptureToolStripMenuItem.PerformClick()

    End Sub

    Private Sub CaptureAreaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptureAreaToolStripMenuItem.Click
        AreaCaptureToolStripMenuItem.PerformClick()

    End Sub

    Private Sub OpenImageViewerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenImageViewerToolStripMenuItem.Click
        Neutrino_Screen_Capture_Image_Viewer.Show()

    End Sub

    Private Sub OpenImageConverterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenImageConverterToolStripMenuItem.Click
        Convert_Image.Show()

    End Sub

    Private Sub MinimizeToSystemTrayToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeToSystemTrayToolStripMenuItem1.Click
        Me.Hide()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        End

    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub OpenMainWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenMainWindowToolStripMenuItem.Click
        Me.Show()

    End Sub

    Private Sub OpenImageViewerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenImageViewerToolStripMenuItem1.Click
        Neutrino_Screen_Capture_Image_Viewer.Show()

    End Sub

    Private Sub OpenImageConverterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenImageConverterToolStripMenuItem1.Click
        Convert_Image.Show()

    End Sub

    Private Sub CaptureScreenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptureScreenToolStripMenuItem1.Click
        CaptureScreenToolStripMenuItem.PerformClick()

    End Sub

    Private Sub CaptureAreaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaptureAreaToolStripMenuItem1.Click
        AreaCaptureToolStripMenuItem.PerformClick()

    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        About_Neutrino_Screen_Capture.Show()

    End Sub

    Private Sub HelpToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem3.Click
        Help.Show()

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        End

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        File__Name_Editor.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Dim CapScr_Hotkey As Boolean
        Dim CapAr_Hotkey As Boolean

        CapScr_Hotkey = GetAsyncKeyState(Keys.F7)
        CapAr_Hotkey = GetAsyncKeyState(Keys.F8)

        If CapScr_Hotkey = True Then
            ScreenCaptureToolStripMenuItem.PerformClick()
        ElseIf CapAr_Hotkey = True Then
            AreaCaptureToolStripMenuItem.PerformClick()

        End If
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Neutrino_Screen_Capture_Hotkey.Show()
        Neutrino_Screen_Capture_Hotkey.lblConfirm.Visible = True

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Neutrino_Screen_Capture_Hotkey.Show()
        Neutrino_Screen_Capture_Hotkey.lblConfirm.Visible = False

    End Sub
End Class