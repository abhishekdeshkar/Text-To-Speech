Public Class Form1

    Private Sub btnSpeak_Click(sender As Object, e As EventArgs) Handles btnSpeak.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")

        SAPI.Speak(rtxtData.Text)
    End Sub
End Class
