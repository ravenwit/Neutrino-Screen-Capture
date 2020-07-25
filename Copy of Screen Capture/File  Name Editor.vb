Public Class File__Name_Editor

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter


    End Sub

    Private Sub File__Name_Editor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If My.Settings.FileName = vbNullString Then
            MsgBox("You can't let File Name be empty. Please choose some name", MsgBoxStyle.Exclamation, "Error In File Name")
            My.Settings.FileName = "_"
        End If

        screencapture.txtFileName.Text = My.Settings.FileName
        My.Settings.Save()
       
    End Sub

    Private Sub File__Name_Editor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.DateBool = True And My.Settings.FileTime = False Then radDateTime.Checked = True Else radDate.Checked = False
        If My.Settings.FileName.Contains((My.Settings.AutomaticNmber).ToString) = True Then chkAutoNum.Checked = True Else chkAutoNum.Checked = False
        If My.Settings.FileName.Contains((Now).ToString) = True Then
            chkDateTime.Checked = True
            radDateTime.Checked = True
            radDate.Checked = False
            radTime.Checked = False
        ElseIf My.Settings.FileName.Contains((Now.Date).ToString) = True Then
            chkDateTime.Checked = True
            radDate.Checked = True
            radDateTime.Checked = False
            radTime.Checked = False
        ElseIf My.Settings.FileName.Contains((Now.TimeOfDay).ToString) = True Then
            chkDateTime.Checked = True
            radDate.Checked = False
            radDateTime.Checked = False
            radTime.Checked = True
        Else
            chkDateTime.Checked = False
            grpDateTime.Enabled = False
        End If

        If chkAutoNum.Checked = True Then
            lblAuto.Visible = True
            numAuto.Visible = True
        ElseIf chkAutoNum.Checked = False Then
            lblAuto.Visible = False
            numAuto.Visible = False
        End If
        lblPreview.Text = My.Settings.FileName
        cmbDateFormat.Items.Add((DateFormat.GeneralDate).ToString)
        cmbDateFormat.Items.Add((DateFormat.LongDate).ToString)
        cmbDateFormat.Items.Add((DateFormat.LongTime).ToString)
        cmbDateFormat.Items.Add((DateFormat.ShortDate).ToString)
        cmbDateFormat.Items.Add((DateFormat.ShortTime).ToString)
        cmbDateFormat.SelectedItem = (My.Settings.FileDateandTime).ToString

    End Sub

   

    Private Sub txtPrefix_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrefix.TextChanged
        My.Settings.FileName = (txtPrefix.Text).ToString
        lblPreview.Text = My.Settings.FileName
        My.Settings.Save()
    End Sub

    Private Sub radDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDate.CheckedChanged
        If radDate.Checked = True Then
            radDate.Font = New Font(radDate.Font, FontStyle.Bold)
            My.Settings.FileName = (txtPrefix.Text + (FormatDateTime(Now.Date, My.Settings.FileDateandTime).ToString).ToString)
        ElseIf radDate.Checked = False Then
            radDate.Checked = False
            radDate.Font = New Font(radDate.Font, FontStyle.Regular)
            My.Settings.FileName = (txtPrefix.Text).ToString
        End If
        My.Settings.Save()
        lblPreview.Text = My.Settings.FileName
    End Sub

    Private Sub radDateTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDateTime.CheckedChanged
        If radDateTime.Checked = True Then
            radDateTime.Font = New System.Drawing.Font(radDateTime.Font, FontStyle.Bold)
            My.Settings.FileName = (txtPrefix.Text + (FormatDateTime(Now, My.Settings.FileDateandTime)).ToString).ToString

        ElseIf radDateTime.Checked = False Then
            radDateTime.Font = New System.Drawing.Font(radDateTime.Font, FontStyle.Regular)
            My.Settings.FileName = (txtPrefix.Text).ToString
        End If
        My.Settings.Save()
        lblPreview.Text = My.Settings.FileName
    End Sub

    Private Sub cmbDateFormat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDateFormat.SelectedIndexChanged
        Select Case cmbDateFormat.SelectedItem
            Case (DateFormat.GeneralDate).ToString
                My.Settings.FileDateandTime = DateFormat.GeneralDate
            Case (DateFormat.LongDate).ToString
                My.Settings.FileDateandTime = DateFormat.LongDate
            Case (DateFormat.LongTime).ToString
                My.Settings.FileDateandTime = DateFormat.LongTime
            Case (DateFormat.ShortDate).ToString
                My.Settings.FileDateandTime = DateFormat.ShortDate
            Case (DateFormat.ShortTime).ToString
                My.Settings.FileDateandTime = DateFormat.ShortTime

        End Select
        My.Settings.Save()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Interval = 700
        lblPreview.Text = My.Settings.FileName
        screencapture.txtFileName.Text = My.Settings.FileName

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoNum.CheckedChanged
        If chkAutoNum.Checked = True Then
            My.Settings.autonum = True
            lblAuto.Visible = True
            numAuto.Visible = True
        Else
            My.Settings.autonum = False
            lblAuto.Visible = False
            numAuto.Visible = False
        End If
        My.Settings.Save()
        lblPreview.Text = My.Settings.FileName
    End Sub

    Private Sub numAuto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numAuto.ValueChanged
        My.Settings.AutomaticNmber = numAuto.Value
        lblPreview.Text = My.Settings.FileName
        My.Settings.Save()

    End Sub

    Private Sub lblAuto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAuto.Click

    End Sub

    Private Sub txtSuffix_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chkDateTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDateTime.CheckedChanged
        If chkDateTime.Checked = True Then
            chkDateTime.Font = New Font(chkDateTime.Font, FontStyle.Bold)
            grpDateTime.Enabled = True
            If radDate.Checked = True Then
                radDate.Font = New Font(radDate.Font, FontStyle.Bold)
                My.Settings.FileName = (txtPrefix.Text + (FormatDateTime(Now.Date, My.Settings.FileDateandTime)).ToString).ToString

            ElseIf radDateTime.Checked = True Then
                radDateTime.Font = New System.Drawing.Font(radDateTime.Font, FontStyle.Bold)
                My.Settings.FileName = (txtPrefix.Text + (FormatDateTime(Now, My.Settings.FileDateandTime)).ToString).ToString

            ElseIf radTime.Checked = True Then
                radTime.Font = New Font(radTime.Font, FontStyle.Bold)
                My.Settings.FileName = (txtPrefix.Text + (Now.TimeOfDay).ToString).ToString

            End If
        ElseIf chkDateTime.Checked = False Then
            chkDateTime.Font = New Font(chkDateTime.Font, FontStyle.Regular)
            grpDateTime.Enabled = False
            My.Settings.FileName = (txtPrefix.Text).ToString
        End If
        
        My.Settings.Save()
        lblPreview.Text = My.Settings.FileName
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radTime.CheckedChanged
        If radTime.Checked = True Then
            radTime.Font = New Font(radTime.Font, FontStyle.Bold)
            My.Settings.FileName = (txtPrefix.Text + (Now.TimeOfDay).ToString).ToString

        ElseIf radTime.Checked = False Then
           radTime.Font = New Font(radTime.Font, FontStyle.Regular)
            My.Settings.FileName = (txtPrefix.Text).ToString
        End If
        My.Settings.Save()
        lblPreview.Text = My.Settings.FileName
    End Sub

    Private Sub btnDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefault.Click
        My.Settings.FileName = "Screen Shot"
        lblPreview.Text = My.Settings.FileName
        My.Settings.Save()

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        My.Settings.FileName = vbNullString
        lblPreview.Text = My.Settings.FileName
        My.Settings.Save()

    End Sub

    Private Sub cmbPrefix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPrefix.Click

    End Sub
End Class