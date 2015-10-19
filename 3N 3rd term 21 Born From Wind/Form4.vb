Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Tbxcheat.Text = "Polaris" Or Tbxcheat.Text = "POLARIS" Or Tbxcheat.Text = "polaris" Or Tbxcheat.Text = "pOLARIS" Then
            My.Computer.Audio.Play(My.Resources.Barrel_Exploding_SoundBible_com_1134967902, AudioPlayMode.Background)
            lblcheatenabled.Show()



        End If
    End Sub

    Private Sub Form4_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Computer.Audio.Play(My.Resources.SoundtrackStart2, AudioPlayMode.BackgroundLoop)
        If Tbxcheat.Text = "Polaris" Or Tbxcheat.Text = "POLARIS" Or Tbxcheat.Text = "polaris" Or Tbxcheat.Text = "pOLARIS" Then
            Form6.ProgressBarX1.Value = Form6.ProgressBarX1.Value + 50
            Form6.ProgressBarX2.Value = Form6.ProgressBarX2.Value + 50
            Form6.ProgressBarX3.Value = Form6.ProgressBarX3.Value + 50
        End If
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblcheatenabled.Hide()
        My.Computer.Audio.Stop()

    End Sub
End Class