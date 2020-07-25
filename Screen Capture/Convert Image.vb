Public Class Convert_Image
    Public openImage As New OpenFileDialog
    Private Sub Convert_Image_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbFormats.SelectedItem = "JPEG"
    End Sub

    Private Sub OpenImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenImageToolStripMenuItem.Click
        openImage.Title = "Open Image"
        openImage.Filter = "All Files | *.*"
        Try
            If openImage.ShowDialog = DialogResult.OK Then
                PictureBox1.Image = System.Drawing.Image.FromFile(openImage.FileName)
            End If
        Catch ex As Exception
            MsgBox("Sorry ! An error occured to open image. Please try again.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub ConvertImageToTheSelectedFormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertImageToTheSelectedFormatToolStripMenuItem.Click
        Select Case Me.cmbFormats.SelectedItem
            Case "JPEG"
                JPEGToolStripMenuItem.PerformClick()
            Case "GIF"
                GIFToolStripMenuItem.PerformClick()
            Case "BMP"
                BMPToolStripMenuItem.PerformClick()
            Case "PNG"
                PNGToolStripMenuItem.PerformClick()
            Case "TIFF"
                TIFFToolStripMenuItem.PerformClick()
            Case "ICON"
                ICONToolStripMenuItem.PerformClick()
            Case "EMF"
                EMFToolStripMenuItem.PerformClick()
            Case "EXIF"
                EXIFToolStripMenuItem.PerformClick()
            Case "WMF"
                WMFToolStripMenuItem.PerformClick()


        End Select


    End Sub

    Private Sub JPEGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JPEGToolStripMenuItem.Click
        Dim savefile As New SaveFileDialog
        Try
            savefile.Title = "Save File"
            savefile.FileName = "Converted Image"
            savefile.Filter = "Joint Photographic Experts Group |*.jpeg"
            savefile.InitialDirectory = My.Settings.Default_Directory
            If savefile.ShowDialog = DialogResult.OK Then
                PictureBox1.Image.Save(savefile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        Catch ex As Exception
            MsgBox("Sorry ! An error occured to save the image file. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub GIFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GIFToolStripMenuItem.Click
        Dim savefile As New SaveFileDialog
        Try
            savefile.Title = "Save File"
            savefile.FileName = "Converted Image"
            savefile.Filter = "Graphics Interchange Format |*.gif"
            savefile.InitialDirectory = My.Settings.Default_Directory
            If savefile.ShowDialog = DialogResult.OK Then
                PictureBox1.Image.Save(savefile.FileName, System.Drawing.Imaging.ImageFormat.Gif)
            End If
        Catch ex As Exception
            MsgBox("Sorry ! An error occured to save the image file. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BMPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BMPToolStripMenuItem.Click
        Dim savefile As New SaveFileDialog
        Try
            savefile.Title = "Save File"
            savefile.FileName = "Converted Image"
            savefile.Filter = "Bitmap |*.bmp"
            savefile.InitialDirectory = My.Settings.Default_Directory
            If savefile.ShowDialog = DialogResult.OK Then
                PictureBox1.Image.Save(savefile.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
            End If
        Catch ex As Exception
            MsgBox("Sorry ! An error occured to save the image file. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub PNGToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PNGToolStripMenuItem.Click
        Dim savefile As New SaveFileDialog
        Try
            savefile.Title = "Save File"
            savefile.FileName = "Converted Image"
            savefile.Filter = "W3C Portable Network Graphics |*.png"
            savefile.InitialDirectory = My.Settings.Default_Directory
            If savefile.ShowDialog = DialogResult.OK Then
                PictureBox1.Image.Save(savefile.FileName, System.Drawing.Imaging.ImageFormat.Png)
            End If
        Catch ex As Exception
            MsgBox("Sorry ! An error occured to save the image file. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub TIFFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIFFToolStripMenuItem.Click
        Dim savefile As New SaveFileDialog
        Try
            savefile.Title = "Save File"
            savefile.FileName = "Converted Image"
            savefile.Filter = "Tagged Image File Format |*.tiff"
            savefile.InitialDirectory = My.Settings.Default_Directory
            If savefile.ShowDialog = DialogResult.OK Then
                PictureBox1.Image.Save(savefile.FileName, System.Drawing.Imaging.ImageFormat.Tiff)
            End If
        Catch ex As Exception
            MsgBox("Sorry ! An error occured to save the image file. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ICONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ICONToolStripMenuItem.Click
        Dim savefile As New SaveFileDialog
        Try
            savefile.Title = "Save File"
            savefile.FileName = "Converted Image"
            savefile.Filter = "Windows Icon |*.ico"
            savefile.InitialDirectory = My.Settings.Default_Directory
            If savefile.ShowDialog = DialogResult.OK Then
                PictureBox1.Image.Save(savefile.FileName, System.Drawing.Imaging.ImageFormat.Icon)
            End If
        Catch ex As Exception
            MsgBox("Sorry ! An error occured to save the image file. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EMFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMFToolStripMenuItem.Click
        Dim savefile As New SaveFileDialog
        Try
            savefile.Title = "Save File"
            savefile.FileName = "Converted Image"
            savefile.Filter = "Enhanced Metafile |*.emf"
            savefile.InitialDirectory = My.Settings.Default_Directory
            If savefile.ShowDialog = DialogResult.OK Then
                PictureBox1.Image.Save(savefile.FileName, System.Drawing.Imaging.ImageFormat.Emf)
            End If
        Catch ex As Exception
            MsgBox("Sorry ! An error occured to save the image file. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub EXIFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXIFToolStripMenuItem.Click
        Dim savefile As New SaveFileDialog
        Try
            savefile.Title = "Save File"
            savefile.FileName = "Converted Image"
            savefile.Filter = "Exchangable Image File |*.exif"
            savefile.InitialDirectory = My.Settings.Default_Directory
            If savefile.ShowDialog = DialogResult.OK Then
                PictureBox1.Image.Save(savefile.FileName, System.Drawing.Imaging.ImageFormat.Exif)
            End If
        Catch ex As Exception
            MsgBox("Sorry ! An error occured to save the image file. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub WMFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WMFToolStripMenuItem.Click
        Dim savefile As New SaveFileDialog
        Try
            savefile.Title = "Save File"
            savefile.FileName = "Converted Image"
            savefile.Filter = "Windows Metafile |*.wmf"
            savefile.InitialDirectory = My.Settings.Default_Directory
            If savefile.ShowDialog = DialogResult.OK Then
                PictureBox1.Image.Save(savefile.FileName, System.Drawing.Imaging.ImageFormat.Wmf)
            End If
        Catch ex As Exception
            MsgBox("Sorry ! An error occured to save the image file. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click
        
        ConvertImageToTheSelectedFormatToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ConvertToToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvertToToolStripMenuItem.Click

    End Sub
End Class