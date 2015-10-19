Public Class Form8

    Private Sub PictureBox1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub btnstats2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Form6.ProgressBarX1.Value = Form6.ProgressBarX1.Value + 15
        Me.Hide()
        Form9.Show()

    End Sub

    Private Sub btnFront_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFront.Click
        Me.Hide()
        Form16.Show()

    End Sub
End Class