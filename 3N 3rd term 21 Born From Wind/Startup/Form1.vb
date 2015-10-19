Public Class Form1

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        
        Form2.Show()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Start()

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBarX1.Increment(1)
        If ProgressBarX1.Value = 2 Then
            lblload.Text = "Loading."
        ElseIf ProgressBarX1.Value = 4 Then
            lblload.Text = "Loading.."
        ElseIf ProgressBarX1.Value = 8 Then
            lblload.Text = "Loading..."
        ElseIf ProgressBarX1.Value = 12 Then
            lblload.Text = "Loading...."
        ElseIf ProgressBarX1.Value = 16 Then
            lblload.Text = "Loading....."
        ElseIf ProgressBarX1.Value = 20 Then
            lblload.Text = "Loading."
        ElseIf ProgressBarX1.Value = 24 Then
            lblload.Text = "Loading.."
        ElseIf ProgressBarX1.Value = 28 Then
            lblload.Text = "Loading..."
        ElseIf ProgressBarX1.Value = 32 Then
            lblload.Text = "Loading...."
        ElseIf ProgressBarX1.Value = 36 Then
            lblload.Text = "Loading....."
        ElseIf ProgressBarX1.Value = 40 Then
            lblload.Text = "Loading."
        ElseIf ProgressBarX1.Value = 46 Then
            lblload.Text = "Catching Pirates.."
        ElseIf ProgressBarX1.Value = 52 Then
            lblload.Text = "Retrieving Treasure..."
        ElseIf ProgressBarX1.Value = 68 Then
            lblload.Text = "Boarding Ship...."
        ElseIf ProgressBarX1.Value = 86 Then
            lblload.Text = "Shipwrecked!....."
        ElseIf ProgressBarX1.Value = 88 Then
            My.Computer.Audio.Play(My.Resources.SoundtrackStart2, AudioPlayMode.BackgroundLoop)

        End If
        If ProgressBarX1.Value = ProgressBarX1.Maximum Then

            Me.Close()
            Timer1.Stop()


        End If


    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar2.Increment(2)
        If ProgressBar2.Value = 1 Then
            lblpresent.Text = " "
        ElseIf ProgressBar2.Value = 8 + 4 Then
            lblpresent.Text = "B"
        ElseIf ProgressBar2.Value = 12 + 4 Then
            lblpresent.Text = "Bo"
        ElseIf ProgressBar2.Value = 16 + 4 Then
            lblpresent.Text = "Bor"
        ElseIf ProgressBar2.Value = 20 + 4 Then
            lblpresent.Text = "Born"
        ElseIf ProgressBar2.Value = 24 + 4 Then
            lblpresent.Text = "Born F"
        ElseIf ProgressBar2.Value = 28 + 4 Then
            lblpresent.Text = "Born Fr"
        ElseIf ProgressBar2.Value = 32 + 4 Then
            lblpresent.Text = "Born Fro"
        ElseIf ProgressBar2.Value = 36 + 4 Then
            lblpresent.Text = "Born From"
        ElseIf ProgressBar2.Value = 40 + 4 Then
            lblpresent.Text = "Born From W"
        ElseIf ProgressBar2.Value = 44 + 4 Then
            lblpresent.Text = "Born From Wi"
        ElseIf ProgressBar2.Value = 48 + 4 Then
            lblpresent.Text = "Born From Win"
        ElseIf ProgressBar2.Value = 52 + 4 Then
            lblpresent.Text = "Born From Wind"
        End If

        If ProgressBar2.Value = 2 + 3 Then
            lblload.Text = "Loading."
        ElseIf ProgressBar2.Value = 5 + 2 Then
            lblload.Text = "Loading.."
        ElseIf ProgressBar2.Value = 10 + 2 Then
            lblload.Text = "Loading..."
        ElseIf ProgressBar2.Value = 15 + 2 Then
            lblload.Text = "Loading...."
        ElseIf ProgressBar2.Value = 20 + 2 Then
            lblload.Text = "Loading....."
        ElseIf ProgressBar2.Value = 25 Then
            lblload.Text = "Loading."
        ElseIf ProgressBar2.Value = 30 Then
            lblload.Text = "Loading.."
        ElseIf ProgressBar2.Value = 35 Then
            lblload.Text = "Loading..."
        ElseIf ProgressBar2.Value = 40 Then
            lblload.Text = "Loading...."
        ElseIf ProgressBar2.Value = 45 Then
            lblload.Text = "Loading....."
        End If
        If ProgressBar2.Value = 28 Then
            Timer1.Start()
        End If

    End Sub


End Class
