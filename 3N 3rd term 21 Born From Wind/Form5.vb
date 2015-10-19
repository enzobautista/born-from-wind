Public Class Form5

    Private Sub Form5_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form6.Show()
    End Sub


    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.SoundtrackStart, AudioPlayMode.BackgroundLoop)
        btnsoundstop2.SendToBack()
        timer2.start()


    End Sub

    Private Sub btnsound2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsound2.Click
        My.Computer.Audio.Stop()
        btnsound2.SendToBack()

    End Sub

    Private Sub btnsoundstop2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsoundstop2.Click
        My.Computer.Audio.Play(My.Resources.SoundtrackStart, AudioPlayMode.BackgroundLoop)
        btnsoundstop2.SendToBack()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    




    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseHover
        Timer1.Stop()

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBarX1.Increment(1)
        If ProgressBarX1.Value = ProgressBarX1.Maximum Then
            Me.Close()
            Form6.Show()

        End If
    End Sub
End Class