<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class File__Name_Editor
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
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbPrefix = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.chkDateTime = New System.Windows.Forms.CheckBox()
        Me.numAuto = New System.Windows.Forms.NumericUpDown()
        Me.lblAuto = New System.Windows.Forms.Label()
        Me.chkAutoNum = New System.Windows.Forms.CheckBox()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.grpDateTime = New System.Windows.Forms.GroupBox()
        Me.radTime = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbDateFormat = New System.Windows.Forms.ComboBox()
        Me.radDateTime = New System.Windows.Forms.RadioButton()
        Me.radDate = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.numAuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDateTime.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPreview
        '
        Me.lblPreview.BackColor = System.Drawing.Color.HotPink
        Me.lblPreview.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPreview.Font = New System.Drawing.Font("Comic Sans MS", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPreview.Location = New System.Drawing.Point(3, 18)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(355, 36)
        Me.lblPreview.TabIndex = 0
        Me.lblPreview.Text = "File Name"
        Me.lblPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbPrefix)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnDefault)
        Me.GroupBox1.Controls.Add(Me.chkDateTime)
        Me.GroupBox1.Controls.Add(Me.numAuto)
        Me.GroupBox1.Controls.Add(Me.lblAuto)
        Me.GroupBox1.Controls.Add(Me.chkAutoNum)
        Me.GroupBox1.Controls.Add(Me.txtPrefix)
        Me.GroupBox1.Controls.Add(Me.grpDateTime)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(357, 257)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Name"
        '
        'cmbPrefix
        '
        Me.cmbPrefix.AutoSize = True
        Me.cmbPrefix.Location = New System.Drawing.Point(18, 21)
        Me.cmbPrefix.Name = "cmbPrefix"
        Me.cmbPrefix.Size = New System.Drawing.Size(40, 13)
        Me.cmbPrefix.TabIndex = 16
        Me.cmbPrefix.Text = "Text   :"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(8, 224)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear All"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(267, 224)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(75, 23)
        Me.btnDefault.TabIndex = 14
        Me.btnDefault.Text = "Default Name"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'chkDateTime
        '
        Me.chkDateTime.AutoSize = True
        Me.chkDateTime.Location = New System.Drawing.Point(6, 109)
        Me.chkDateTime.Name = "chkDateTime"
        Me.chkDateTime.Size = New System.Drawing.Size(118, 17)
        Me.chkDateTime.TabIndex = 13
        Me.chkDateTime.Text = "Add Date and Time"
        Me.chkDateTime.UseVisualStyleBackColor = True
        '
        'numAuto
        '
        Me.numAuto.Location = New System.Drawing.Point(106, 71)
        Me.numAuto.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numAuto.Name = "numAuto"
        Me.numAuto.Size = New System.Drawing.Size(57, 20)
        Me.numAuto.TabIndex = 12
        '
        'lblAuto
        '
        Me.lblAuto.AutoSize = True
        Me.lblAuto.Location = New System.Drawing.Point(39, 71)
        Me.lblAuto.Name = "lblAuto"
        Me.lblAuto.Size = New System.Drawing.Size(61, 13)
        Me.lblAuto.TabIndex = 11
        Me.lblAuto.Text = "Start From :"
        '
        'chkAutoNum
        '
        Me.chkAutoNum.AutoSize = True
        Me.chkAutoNum.Location = New System.Drawing.Point(6, 48)
        Me.chkAutoNum.Name = "chkAutoNum"
        Me.chkAutoNum.Size = New System.Drawing.Size(135, 17)
        Me.chkAutoNum.TabIndex = 10
        Me.chkAutoNum.Text = "Add Automatic Number"
        Me.chkAutoNum.UseVisualStyleBackColor = True
        '
        'txtPrefix
        '
        Me.txtPrefix.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtPrefix.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrefix.Location = New System.Drawing.Point(64, 17)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(290, 21)
        Me.txtPrefix.TabIndex = 4
        '
        'grpDateTime
        '
        Me.grpDateTime.Controls.Add(Me.radTime)
        Me.grpDateTime.Controls.Add(Me.Label2)
        Me.grpDateTime.Controls.Add(Me.cmbDateFormat)
        Me.grpDateTime.Controls.Add(Me.radDateTime)
        Me.grpDateTime.Controls.Add(Me.radDate)
        Me.grpDateTime.Location = New System.Drawing.Point(35, 132)
        Me.grpDateTime.Name = "grpDateTime"
        Me.grpDateTime.Size = New System.Drawing.Size(313, 87)
        Me.grpDateTime.TabIndex = 3
        Me.grpDateTime.TabStop = False
        Me.grpDateTime.Text = "Date and Time"
        '
        'radTime
        '
        Me.radTime.AutoSize = True
        Me.radTime.Location = New System.Drawing.Point(15, 65)
        Me.radTime.Name = "radTime"
        Me.radTime.Size = New System.Drawing.Size(85, 17)
        Me.radTime.TabIndex = 4
        Me.radTime.Text = "Current Time"
        Me.radTime.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date And Format"
        '
        'cmbDateFormat
        '
        Me.cmbDateFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDateFormat.FormattingEnabled = True
        Me.cmbDateFormat.Location = New System.Drawing.Point(142, 38)
        Me.cmbDateFormat.Name = "cmbDateFormat"
        Me.cmbDateFormat.Size = New System.Drawing.Size(165, 21)
        Me.cmbDateFormat.TabIndex = 2
        '
        'radDateTime
        '
        Me.radDateTime.AutoSize = True
        Me.radDateTime.Location = New System.Drawing.Point(15, 42)
        Me.radDateTime.Name = "radDateTime"
        Me.radDateTime.Size = New System.Drawing.Size(95, 17)
        Me.radDateTime.TabIndex = 1
        Me.radDateTime.Text = "Date and Time"
        Me.radDateTime.UseVisualStyleBackColor = True
        '
        'radDate
        '
        Me.radDate.AutoSize = True
        Me.radDate.Location = New System.Drawing.Point(15, 19)
        Me.radDate.Name = "radDate"
        Me.radDate.Size = New System.Drawing.Size(72, 17)
        Me.radDate.TabIndex = 0
        Me.radDate.Text = "Only Date"
        Me.radDate.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPreview)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 262)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 57)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Preview"
        '
        'Timer1
        '
        '
        'File__Name_Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 319)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "File__Name_Editor"
        Me.Text = "File Name Editor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numAuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDateTime.ResumeLayout(False)
        Me.grpDateTime.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPreview As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grpDateTime As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDateFormat As System.Windows.Forms.ComboBox
    Friend WithEvents radDateTime As System.Windows.Forms.RadioButton
    Friend WithEvents radDate As System.Windows.Forms.RadioButton
    Friend WithEvents txtPrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents chkAutoNum As System.Windows.Forms.CheckBox
    Friend WithEvents numAuto As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblAuto As System.Windows.Forms.Label
    Friend WithEvents chkDateTime As System.Windows.Forms.CheckBox
    Friend WithEvents radTime As System.Windows.Forms.RadioButton
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDefault As System.Windows.Forms.Button
    Friend WithEvents cmbPrefix As System.Windows.Forms.Label
End Class
