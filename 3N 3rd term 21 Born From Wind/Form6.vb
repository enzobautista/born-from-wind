Public Class Form6


    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.SoundtrackStart, AudioPlayMode.BackgroundLoop)
        btnsoundstop2.SendToBack()
        btnstats2.Visible = False
        Me.Height = 470
        TextBox1.Hide()
        btnok.Hide()
        btnok2.Hide()
        Label13.Hide()





        
        If Form4.Tbxcheat.Text = "Polaris" Or Form4.Tbxcheat.Text = "POLARIS" Or Form4.Tbxcheat.Text = "polaris" Or Form4.Tbxcheat.Text = "pOLARIS" Then
            ProgressBarX1.Value = ProgressBarX1.Value + 50
            ProgressBarX2.Value = ProgressBarX2.Value + 50
            ProgressBarX3.Value = ProgressBarX3.Value + 50
        End If
    End Sub

   

    Private Sub btnsound2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsound2.Click
        My.Computer.Audio.Stop()
        btnsound2.SendToBack()

    End Sub

    Private Sub btnsoundstop2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsoundstop2.Click
        My.Computer.Audio.Play(My.Resources.SoundtrackStart, AudioPlayMode.BackgroundLoop)
        btnsoundstop2.SendToBack()

    End Sub

    
    Private Sub btnstats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstats.Click
        Do Until Me.Height > 700
            Me.Height = Me.Height + 10


        Loop
        btnstats2.Visible = True

        Label5.Text = ProgressBarX1.Value
        Label6.Text = ProgressBarX2.Value
        Label7.Text = ProgressBarX3.Value

       

    End Sub

    Private Sub btnstats2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstats2.Click
        Do Until Me.Height = 470
            Me.Height = Me.Height - 10
        Loop
        btnstats2.Visible = False

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        pbxa2.Hide()
        pbxa3.Show()
        ButtonX1.Hide()
        ButtonX2.Hide()
        TextBox1.Show()
        Label12.Text = "Pirate"
        btnok.Show()
        Label13.Hide()






    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Label8.Text = TextBox1.Text

        ProgressBarX1.Value = ProgressBarX1.Value + 20
        pbxa3.Hide()
        TextBox1.Text = ""
        Label13.Show()
        pbxa2.Hide()
        Label13.Text = "What skill are you known for?"
        btnok.Hide()
        btnok2.Show()


    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        pbxa2.Hide()
        pbxa3.Show()
        ButtonX1.Hide()
        ButtonX2.Hide()
        TextBox1.Show()
        Label12.Text = "Navy"
        btnok.Show()
        Label13.Hide()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub btnok2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok2.Click
        Label15.Text = TextBox1.Text
        Form8.Show()


    End Sub

    Private Sub pbxa2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxa2.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub ProgressBarX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBarX2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub ProgressBarX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBarX1.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class