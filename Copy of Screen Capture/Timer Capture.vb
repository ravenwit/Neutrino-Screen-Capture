Public Class Timer_Capture
    Dim seconds
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Val(TextBox1.Text) <> vbNull Then
            Dim time = 1
            Select Case ComboBox1.SelectedItem
                Case "Seconds"
                    time = Val(TextBox1.Text) * 1000
                Case "Centiseconds"
                    time = Val(TextBox1.Text) * 100
                Case "Miliseconds"
                    time = Val(TextBox1.Text)

            End Select
            screencapture.Timer1.Interval = time
            seconds = screencapture.Timer1.Interval / 1000
            screencapture.ScreenCaptureToolStripMenuItem.PerformClick()
            Timer1.Interval = 800
            Timer1.Enabled = True

        Else
            MsgBox("Please enter a valid time.", , "Error!")
        End If
       

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        screencapture.NotifyIcon1.BalloonTipTitle = "Timer Capture started"
        screencapture.NotifyIcon1.BalloonTipText = seconds & "  Seconds remaining..."
        screencapture.NotifyIcon1.ShowBalloonTip(970)
        seconds = seconds - 1
        If seconds <= -1 Then
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer_Capture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedItem = "Seconds"

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class