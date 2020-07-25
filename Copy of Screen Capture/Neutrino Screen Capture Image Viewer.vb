Public Class Neutrino_Screen_Capture_Image_Viewer
    Dim c = 1
    Dim filepath As String = vbNullString

    Private Sub Neutrino_Screen_Capture_Image_Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AutoSize = True
        Me.CenterToScreen()
        Me.Icon = screencapture.Icon
        Me.ShowIcon = True
        Me.ShowInTaskbar = True
        Me.Visible = True
        Me.PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        StatusBarToolStripMenuItem.Checked = True
        StatusStrip1.Visible = True
    End Sub

    Private Sub OpenImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenImageToolStripMenuItem.Click
        Dim openImage As New OpenFileDialog
        openImage.Title = "Open Image..."
        openImage.Filter = "All Files |*.*"
        Try
            If openImage.ShowDialog = DialogResult = vbOK Then
                PictureBox1.Image = System.Drawing.Image.FromFile(openImage.FileName)
                filepath = openImage.FileName

            End If
        Catch ex As Exception
            MsgBox("Sorry ! An error occured to open image. Please check your file format and try again.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
        lblStatus.Text = "Open Image"
    End Sub

    Private Sub SaveImageToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveImageToolStripMenuItem2.Click
        If filepath = vbNullString Then
            Try
                If My.Settings.autonum = True Then PictureBox1.Image.Save((My.Settings.Default_Directory + "\" + My.Settings.FileName + (My.Settings.AutomaticNmber).ToString + "." + (My.Settings.FileFormat).ToString).ToString, My.Settings.FileFormat) Else PictureBox1.Image.Save((My.Settings.Default_Directory + "\" + My.Settings.FileName + "." + (My.Settings.FileFormat).ToString).ToString, My.Settings.FileFormat)

            Catch ex As Exception
                MsgBox("Sorry ! An error occured to save the image file. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
            End Try
            If My.Settings.autonum = True Then My.Settings.AutomaticNmber = My.Settings.AutomaticNmber + 1 Else My.Settings.AutomaticNmber = My.Settings.AutomaticNmber
        ElseIf filepath <> vbNullString Then
            Try
                Me.PictureBox1.Image.Save(filepath)

            Catch ex As Exception
                MsgBox("Sorry ! An error occured to save the image file. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
            End Try
        End If
        
        lblStatus.Text = "Save Image"
    End Sub

    Private Sub SaveImageAsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveImageAsToolStripMenuItem1.Click
        Dim savefile As New SaveFileDialog
        savefile.Title = "Save Image - Neutrino Screen Capture"
        savefile.FileName = "Neutrino Screen Capture-Image " + c.ToString
        savefile.Filter = "Joint Photographic Experts Group |*.jpeg | Joint Photographic Group |*.jpg |Graphics Interchange Format |*.gif | Bitmap |*.bmp | W3C Portable Network Graphics |*.png | Tagged Image File |*.tiff | Enhanced Metafile |*.emf | Exchangable Image Format |*.exif | Windows Metafile |*.wmf"
        Try
            If savefile.ShowDialog = DialogResult.OK Then
                PictureBox1.Image.Save(savefile.FileName)
            End If
        Catch ex As Exception
            MsgBox("Sorry ! An error occured to save the image file. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try
        c = c + 1
        lblStatus.Text = "Save Image As Your Desired Format"
    End Sub

    Private Sub DeleteImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteImageToolStripMenuItem.Click
        PictureBox1.Image = Nothing
        lblStatus.Text = "Permanently Delete Image From Image Viewer"
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
        lblStatus.Text = "Close Neutrino Screen Capture Image Viewer"
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.Clear()
        My.Computer.Clipboard.SetImage(Me.PictureBox1.Image)
        lblStatus.Text = "Copy Image to Clipboard"
    End Sub

    Private Sub PasteAImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteAImageToolStripMenuItem.Click
        Try

            Me.PictureBox1.Image = My.Computer.Clipboard.GetImage

        Catch ex As Exception
            MsgBox("Sorry! An error occured to get image from ClipBoard. Please check your file and try again.", MsgBoxStyle.Critical)
        End Try

        lblStatus.Text = "Paste Image from Clipboard to Neutrino Screen Capture Image Viewer"
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        
    End Sub

    Private Sub MainWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainWindowToolStripMenuItem.Click
        screencapture.Show()
        lblStatus.Text = "Show Main Window"
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.Click
        If StatusBarToolStripMenuItem.Checked = True Then
            StatusBarToolStripMenuItem.Checked = False
            StatusStrip1.Visible = False
            lblStatus.Text = "Hide Status Bar"
        ElseIf StatusBarToolStripMenuItem.Checked = False Then
            StatusBarToolStripMenuItem.Checked = True
            StatusStrip1.Visible = True
            lblStatus.Text = "Show Status Bar"
        End If

    End Sub

    Private Sub HelpFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpFileToolStripMenuItem.Click
        Help.Show()
        lblStatus.Text = "Show Help"
    End Sub

    Private Sub AboutNeutrinoScreenCaptureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutNeutrinoScreenCaptureToolStripMenuItem.Click
        About_Neutrino_Screen_Capture.Show()

        lblStatus.Text = "Show About Neutrino Screen Capture"
    End Sub

    Private Sub OpenImageToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenImageToolStripMenuItem.MouseHover
        lblStatus.Text = "Open Image in Neutrino Screen Capture Image VIewer"
    End Sub

    Private Sub SaveImageToolStripMenuItem2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveImageToolStripMenuItem2.MouseHover
        lblStatus.Text = "Save Image"
    End Sub

    Private Sub OpenImageToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenImageToolStripMenuItem.MouseLeave
        lblStatus.Text = ""
    End Sub

    Private Sub SaveImageToolStripMenuItem2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveImageToolStripMenuItem2.MouseLeave
        lblStatus.Text = ""
    End Sub

    Private Sub SaveImageAsToolStripMenuItem1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveImageAsToolStripMenuItem1.MouseHover
        lblStatus.Text = "Save Image As Your Desired Format"
    End Sub

    Private Sub SaveImageAsToolStripMenuItem1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveImageAsToolStripMenuItem1.MouseLeave
        lblStatus.Text = ""
    End Sub

    Private Sub DeleteImageToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeleteImageToolStripMenuItem.MouseHover
        lblStatus.Text = "Permanently Delete Image"
    End Sub

    Private Sub DeleteImageToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeleteImageToolStripMenuItem.MouseLeave
        lblStatus.Text = ""
    End Sub

    Private Sub CloseToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.MouseHover
        lblStatus.Text = "Close Neutrino Screen Capture Image Viewer"
    End Sub

    Private Sub CloseToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.MouseLeave
        lblStatus.Text = ""
    End Sub

    Private Sub CopyToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.MouseHover
        lblStatus.Text = "Copy Image to Clipboard"
    End Sub

    Private Sub CopyToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.MouseLeave
        lblStatus.Text = ""
    End Sub

    Private Sub PasteAImageToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasteAImageToolStripMenuItem.MouseHover
        lblStatus.Text = "Paste Image from Clipboard to Neutrino Screen Capture Image Viewer"
    End Sub

    Private Sub PasteAImageToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasteAImageToolStripMenuItem.MouseLeave
        lblStatus.Text = ""
    End Sub

    Private Sub MainWindowToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainWindowToolStripMenuItem.MouseHover
        lblStatus.Text = "Show Main Window"
    End Sub

    Private Sub MainWindowToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainWindowToolStripMenuItem.MouseLeave
        lblStatus.Text = ""
    End Sub

    Private Sub StatusBarToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.MouseHover
        If StatusBarToolStripMenuItem.Checked = True Then
            lblStatus.Text = "Hide Status Bar"
        ElseIf StatusBarToolStripMenuItem.Checked = False Then
            lblStatus.Text = "Show Status Bar"
        End If
    End Sub

    Private Sub StatusBarToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.MouseLeave
        lblStatus.Text = ""
    End Sub

    Private Sub HelpFileToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles HelpFileToolStripMenuItem.MouseHover
        lblStatus.Text = "Show Help"
    End Sub

    Private Sub HelpFileToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles HelpFileToolStripMenuItem.MouseLeave
        lblStatus.Text = ""
    End Sub

    Private Sub AboutNeutrinoScreenCaptureToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles AboutNeutrinoScreenCaptureToolStripMenuItem.MouseHover
        lblStatus.Text = "Show About Neutrino Screen Capture"
    End Sub

    Private Sub AboutNeutrinoScreenCaptureToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles AboutNeutrinoScreenCaptureToolStripMenuItem.MouseLeave
        lblStatus.Text = ""
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If My.Computer.Clipboard.ContainsImage = False Then
            PasteAImageToolStripMenuItem.Enabled = False
            ToolStripButton4.Enabled = False
        Else
            PasteAImageToolStripMenuItem.Enabled = True
            ToolStripButton4.Enabled = True
        End If
        If IsNothing(Me.PictureBox1.Image) = True Then
            CopyToolStripMenuItem.Enabled = False
            ToolStripButton3.Enabled = False
        Else
            CopyToolStripMenuItem.Enabled = True
            ToolStripButton3.Enabled = True
        End If
    End Sub

    Private Sub OpenImageToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenImageToolStripMenuItem1.Click
        OpenImageToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem19.Click
        SaveImageToolStripMenuItem2.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click
        SaveImageAsToolStripMenuItem1.PerformClick()

    End Sub

    Private Sub DeleteImageToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteImageToolStripMenuItem1.Click
        DeleteImageToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
        CopyToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripMenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem38.Click
        Me.Close()

    End Sub

    Private Sub NormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalToolStripMenuItem.Click
        Me.PictureBox1.SizeMode = System.Windows.Forms.ImageLayout.None
        NormalToolStripMenuItem.Checked = True
        StrechToolStripMenuItem.Checked = False
        AutoSizeToolStripMenuItem.Checked = False
        CenterToolStripMenuItem.Checked = False
        ZoomToolStripMenuItem.Checked = False
        PictureBox1.Refresh()


    End Sub

    Private Sub StrechToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StrechToolStripMenuItem.Click
        Me.PictureBox1.SizeMode = System.Windows.Forms.ImageLayout.Stretch
        NormalToolStripMenuItem.Checked = False
        StrechToolStripMenuItem.Checked = True
        AutoSizeToolStripMenuItem.Checked = False
        CenterToolStripMenuItem.Checked = False
        ZoomToolStripMenuItem.Checked = False
        PictureBox1.Refresh()

    End Sub

    Private Sub AutoSizeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoSizeToolStripMenuItem.Click
        Me.PictureBox1.SizeMode = System.Windows.Forms.ImageLayout.Tile
        NormalToolStripMenuItem.Checked = False
        StrechToolStripMenuItem.Checked = False
        AutoSizeToolStripMenuItem.Checked = True
        CenterToolStripMenuItem.Checked = False
        ZoomToolStripMenuItem.Checked = False
        PictureBox1.Refresh()

    End Sub

    Private Sub CenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenterToolStripMenuItem.Click
        Me.PictureBox1.SizeMode = System.Windows.Forms.ImageLayout.Center
        NormalToolStripMenuItem.Checked = False
        StrechToolStripMenuItem.Checked = False
        AutoSizeToolStripMenuItem.Checked = False
        CenterToolStripMenuItem.Checked = True
        ZoomToolStripMenuItem.Checked = False
        PictureBox1.Refresh()

    End Sub

    Private Sub ZoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomToolStripMenuItem.Click
        Me.PictureBox1.SizeMode = System.Windows.Forms.ImageLayout.Zoom
        NormalToolStripMenuItem.Checked = False
        StrechToolStripMenuItem.Checked = False
        AutoSizeToolStripMenuItem.Checked = False
        CenterToolStripMenuItem.Checked = False
        ZoomToolStripMenuItem.Checked = True
        PictureBox1.Refresh()

    End Sub

   
    Private Sub NormalToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles NormalToolStripMenuItem.MouseHover
        lblStatus.Text = "Make Image Layout Normal"
    End Sub

    Private Sub NormalToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles NormalToolStripMenuItem.MouseLeave
        lblStatus.Text = ""
    End Sub

    Private Sub StrechToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles StrechToolStripMenuItem.MouseHover
        lblStatus.Text = "Make Image Layout Stretch"
    End Sub

    Private Sub StrechToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles StrechToolStripMenuItem.MouseLeave
        lblStatus.Text = ""
    End Sub

    Private Sub AutoSizeToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles AutoSizeToolStripMenuItem.MouseHover
        lblStatus.Text = "Auto Size Image Layout"
    End Sub

    Private Sub AutoSizeToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles AutoSizeToolStripMenuItem.MouseLeave
        lblStatus.Text = ""
    End Sub

    Private Sub CenterToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles CenterToolStripMenuItem.MouseHover
        lblStatus.Text = "Make Image Layout Center"
    End Sub

    Private Sub CenterToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CenterToolStripMenuItem.MouseLeave
        lblStatus.Text = ""
    End Sub

    Private Sub ZoomToolStripMenuItem_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ZoomToolStripMenuItem.MouseHover
        lblStatus.Text = "Make Image Layout Zoom (Recommended) "
    End Sub

    Private Sub ZoomToolStripMenuItem_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ZoomToolStripMenuItem.MouseLeave
        lblStatus.Text = ""
    End Sub

    Private Sub OpenToolButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolButton.Click
        OpenImageToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        SaveImageToolStripMenuItem2.PerformClick()

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        SaveImageAsToolStripMenuItem1.PerformClick()

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        CopyToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        PasteAImageToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        DeleteImageToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        MainWindowToolStripMenuItem.PerformClick()

    End Sub

    Private Sub PrintImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintImageToolStripMenuItem.Click
        Dim imageform As New Form
        Dim picturebox As New PictureBox
        Dim image As System.Drawing.Image
        image = Me.PictureBox1.Image
        If IsNothing(PictureBox1.Image) = False Then
            imageform.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            imageform.WindowState = FormWindowState.Maximized
            picturebox.SizeMode = PictureBoxSizeMode.Zoom
            picturebox.Image = image
            imageform.Controls.Add(picturebox)
            imageform.Show()

            Try
                PrintForm1.Form = imageform
                PrintForm1.Print()

            Catch ex As Exception
                MsgBox("Sorry! An error occured to print the image file. Please try again. " & vbCrLf & ex.Message, vbOKOnly, "ERROR")
            End Try
        Else
            MsgBox("There are no image to print.")
        End If
       
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        PrintImageToolStripMenuItem.PerformClick()

    End Sub
End Class