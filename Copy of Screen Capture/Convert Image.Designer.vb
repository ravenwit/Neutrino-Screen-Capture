<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Convert_Image
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Convert_Image))
        Me.cmbFormats = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvertImageToTheSelectedFormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvertToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JPEGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GIFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BMPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PNGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TIFFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ICONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXIFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WMFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbFormats
        '
        Me.cmbFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormats.FormattingEnabled = True
        Me.cmbFormats.Items.AddRange(New Object() {"JPEG", "GIF", "BMP", "PNG", "TIFF", "ICON", "EMF", "EXIF", "WMF"})
        Me.cmbFormats.Location = New System.Drawing.Point(69, 233)
        Me.cmbFormats.Name = "cmbFormats"
        Me.cmbFormats.Size = New System.Drawing.Size(121, 21)
        Me.cmbFormats.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(10, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(312, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Preview"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(247, 231)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 6
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(332, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenImageToolStripMenuItem, Me.ConvertImageToTheSelectedFormatToolStripMenuItem, Me.ConvertToToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenImageToolStripMenuItem
        '
        Me.OpenImageToolStripMenuItem.Name = "OpenImageToolStripMenuItem"
        Me.OpenImageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenImageToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.OpenImageToolStripMenuItem.Text = "Open Image"
        '
        'ConvertImageToTheSelectedFormatToolStripMenuItem
        '
        Me.ConvertImageToTheSelectedFormatToolStripMenuItem.Name = "ConvertImageToTheSelectedFormatToolStripMenuItem"
        Me.ConvertImageToTheSelectedFormatToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ConvertImageToTheSelectedFormatToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.ConvertImageToTheSelectedFormatToolStripMenuItem.Text = "Convert Image to the Selected Format"
        '
        'ConvertToToolStripMenuItem
        '
        Me.ConvertToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JPEGToolStripMenuItem, Me.GIFToolStripMenuItem, Me.BMPToolStripMenuItem, Me.PNGToolStripMenuItem, Me.TIFFToolStripMenuItem, Me.ICONToolStripMenuItem, Me.EMFToolStripMenuItem, Me.EXIFToolStripMenuItem, Me.WMFToolStripMenuItem})
        Me.ConvertToToolStripMenuItem.Name = "ConvertToToolStripMenuItem"
        Me.ConvertToToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.ConvertToToolStripMenuItem.Text = "Convert to"
        '
        'JPEGToolStripMenuItem
        '
        Me.JPEGToolStripMenuItem.Name = "JPEGToolStripMenuItem"
        Me.JPEGToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.JPEGToolStripMenuItem.Text = "JPEG"
        '
        'GIFToolStripMenuItem
        '
        Me.GIFToolStripMenuItem.Name = "GIFToolStripMenuItem"
        Me.GIFToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GIFToolStripMenuItem.Text = "GIF"
        '
        'BMPToolStripMenuItem
        '
        Me.BMPToolStripMenuItem.Name = "BMPToolStripMenuItem"
        Me.BMPToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BMPToolStripMenuItem.Text = "BMP"
        '
        'PNGToolStripMenuItem
        '
        Me.PNGToolStripMenuItem.Name = "PNGToolStripMenuItem"
        Me.PNGToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PNGToolStripMenuItem.Text = "PNG"
        '
        'TIFFToolStripMenuItem
        '
        Me.TIFFToolStripMenuItem.Name = "TIFFToolStripMenuItem"
        Me.TIFFToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TIFFToolStripMenuItem.Text = "TIFF"
        '
        'ICONToolStripMenuItem
        '
        Me.ICONToolStripMenuItem.Name = "ICONToolStripMenuItem"
        Me.ICONToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ICONToolStripMenuItem.Text = "ICON"
        '
        'EMFToolStripMenuItem
        '
        Me.EMFToolStripMenuItem.Name = "EMFToolStripMenuItem"
        Me.EMFToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EMFToolStripMenuItem.Text = "EMF"
        '
        'EXIFToolStripMenuItem
        '
        Me.EXIFToolStripMenuItem.Name = "EXIFToolStripMenuItem"
        Me.EXIFToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EXIFToolStripMenuItem.Text = "EXIF"
        '
        'WMFToolStripMenuItem
        '
        Me.WMFToolStripMenuItem.Name = "WMFToolStripMenuItem"
        Me.WMFToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.WMFToolStripMenuItem.Text = "WMF"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Convert to"
        '
        'Convert_Image
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmbFormats)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Convert_Image"
        Me.Text = "Image Converter"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbFormats As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConvertImageToTheSelectedFormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConvertToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents JPEGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GIFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BMPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PNGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TIFFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ICONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXIFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WMFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
