Public Class Neutrino_Screen_Capture_Hotkey
    Dim scrhot As Boolean
    Dim arhot As Boolean

    Private Sub Neutrino_Screen_Capture_Hotkey_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblConfirm.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim hotkeys As System.Windows.Forms.Keys
        If chkAlt.Checked = True Then
            hotkeys = Keys.ControlKey

        End If
        If chkShift.Checked = True Then
            hotkeys = Keys.ShiftKey

        End If
        If chkAlt.Checked = True Then
            hotkeys = Keys.Alt

        End If
        hotkeys = CDbl(hotkeys + CDbl(cmbKeys.SelectedItem))
        If lblConfirm.Visible = True Then My.Settings.CapScrKey = hotkeys Else My.Settings.CapArKey = hotkeys
    End Sub
End Class