<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Neutrino_Screen_Capture_Hotkey
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
        Me.chkCtrl = New System.Windows.Forms.CheckBox()
        Me.chkShift = New System.Windows.Forms.CheckBox()
        Me.chkAlt = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbKeys = New System.Windows.Forms.ComboBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblConfirm = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkCtrl
        '
        Me.chkCtrl.AutoSize = True
        Me.chkCtrl.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCtrl.Location = New System.Drawing.Point(12, 12)
        Me.chkCtrl.Name = "chkCtrl"
        Me.chkCtrl.Size = New System.Drawing.Size(55, 24)
        Me.chkCtrl.TabIndex = 0
        Me.chkCtrl.Text = "Ctrl"
        Me.chkCtrl.UseVisualStyleBackColor = True
        '
        'chkShift
        '
        Me.chkShift.AutoSize = True
        Me.chkShift.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkShift.Location = New System.Drawing.Point(125, 12)
        Me.chkShift.Name = "chkShift"
        Me.chkShift.Size = New System.Drawing.Size(65, 24)
        Me.chkShift.TabIndex = 1
        Me.chkShift.Text = "Shift"
        Me.chkShift.UseVisualStyleBackColor = True
        '
        'chkAlt
        '
        Me.chkAlt.AutoSize = True
        Me.chkAlt.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAlt.Location = New System.Drawing.Point(234, 12)
        Me.chkAlt.Name = "chkAlt"
        Me.chkAlt.Size = New System.Drawing.Size(50, 24)
        Me.chkAlt.TabIndex = 2
        Me.chkAlt.Text = "Alt"
        Me.chkAlt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Keys :"
        '
        'cmbKeys
        '
        Me.cmbKeys.AllowDrop = True
        Me.cmbKeys.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKeys.AutoCompleteCustomSource.AddRange(New String() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "NumPad0", "NumPad1", "NumPad2", "NumPad3", "NumPad4", "NumPad5", "NumPad6", "NumPad7", "NumPad8", "NumPad9", "Space", "Tab", "Escape", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "Ins", "Home", "Del", "End", "Up", "Down", "Right", "Left"})
        Me.cmbKeys.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbKeys.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbKeys.FormattingEnabled = True
        Me.cmbKeys.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "NumPad0", "NumPad1", "NumPad2", "NumPad3", "NumPad4", "NumPad5", "NumPad6", "NumPad7", "NumPad8", "NumPad9", "Space", "Tab", "Escape", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "Ins", "Home", "Del", "End", "Up", "Down", "Right", "Left"})
        Me.cmbKeys.Location = New System.Drawing.Point(54, 50)
        Me.cmbKeys.Name = "cmbKeys"
        Me.cmbKeys.Size = New System.Drawing.Size(181, 21)
        Me.cmbKeys.TabIndex = 4
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 77)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(234, 77)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblConfirm
        '
        Me.lblConfirm.AutoSize = True
        Me.lblConfirm.Location = New System.Drawing.Point(145, 87)
        Me.lblConfirm.Name = "lblConfirm"
        Me.lblConfirm.Size = New System.Drawing.Size(13, 13)
        Me.lblConfirm.TabIndex = 7
        Me.lblConfirm.Text = "_"
        '
        'Neutrino_Screen_Capture_Hotkey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 106)
        Me.Controls.Add(Me.lblConfirm)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.cmbKeys)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkAlt)
        Me.Controls.Add(Me.chkShift)
        Me.Controls.Add(Me.chkCtrl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Neutrino_Screen_Capture_Hotkey"
        Me.Text = "Neutrino_Screen_Capture_Hotkey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkCtrl As System.Windows.Forms.CheckBox
    Friend WithEvents chkShift As System.Windows.Forms.CheckBox
    Friend WithEvents chkAlt As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbKeys As System.Windows.Forms.ComboBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblConfirm As System.Windows.Forms.Label
End Class
