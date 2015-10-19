Public Class Form2
    Dim res As MsgBoxResult
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.Barrel_Exploding_SoundBible_com_1134967902, AudioPlayMode.Background)
        res = MsgBox("Are you sure you want to exit game?", vbYesNoCancel)
        If res = MsgBoxResult.Yes Then
            End
        ElseIf res = MsgBoxResult.No And res = MsgBoxResult.Cancel Then
            Me.Refresh()
        End If

    End Sub

  
    Private Sub pbxencore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxencore.Click
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.Barrel_Exploding_SoundBible_com_1134967902, AudioPlayMode.Background)
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub lblencore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblencore.Click
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.Barrel_Exploding_SoundBible_com_1134967902, AudioPlayMode.Background)
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub lblsolutions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblsolutions.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub btnsound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsound.Click
        My.Computer.Audio.Stop()
        btnsound.SendToBack()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnsoundstop.SendToBack()
        pbxmap1.Hide()

    End Sub

    Private Sub btnsoundstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsoundstop.Click
        My.Computer.Audio.Play(My.Resources.SoundtrackStart2, AudioPlayMode.BackgroundLoop)
        btnsoundstop.SendToBack()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.Ship_Bell_Mike_Koenig_1911209136, AudioPlayMode.WaitToComplete)
        btnsound.Hide()
        btnsoundstop.Hide()
        btninfo.Hide()
        btnExit.Hide()
        Label1.Hide()
        lblencore.Hide()
        lblsolutions.Hide()
        pbxencore.Hide()
        Button1.Hide()
        pbxmap1.Show()
        Form5.Show()
        Me.Close()
        My.Computer.Audio.Play(My.Resources.SoundtrackStart2, AudioPlayMode.Background)







    End Sub

    Private Sub btninfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninfo.Click
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.Barrel_Exploding_SoundBible_com_1134967902, AudioPlayMode.Background)
        Form7.Show()


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Form4.Show()
    End Sub

  
End Class