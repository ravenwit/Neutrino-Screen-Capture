Public Class Help

    Private Sub Help_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub SpeechToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpeechToolStripMenuItem.Click
        Dim msg, voice
        msg = Label1.Text
        voice = CreateObject("sapi.spvoice")
        voice.Speak(msg)
    End Sub
End Class