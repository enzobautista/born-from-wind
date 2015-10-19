Public Class Form13

    Private Sub btnStorm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStorm.Click
        Me.Hide()
        Form14.Show()
        Form6.ProgressBarX2.Value = Form6.ProgressBarX2.Value + 20
        Form6.Label17.Text = "Deckhand"
    End Sub

    Private Sub btnWave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWave.Click
        Me.Hide()
        Form16.Show()
    End Sub

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class