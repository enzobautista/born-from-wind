Public Class Form17

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If TextBox1.Text = "Big Dipper" Or TextBox1.Text = "big dipper" Or TextBox1.Text = "The Big Dipper" Or TextBox1.Text = "the big dipper" Then
            Me.Hide()
            Form16.Label1.Hide()
            Form16.Show()
            Form16.lblFmate.Show()
            Form16.lblFmate1.Show()
            Form6.Label17.Text = "First Mate"
            Form16.lblRank.Text = "First Mate"
            Form16.ProgressBarX1.Value = Form16.ProgressBarX1.Value + 10
            Form16.ProgressBarX2.Value = Form16.ProgressBarX2.Value + 20
            Form16.ProgressBarX3.Value = Form16.ProgressBarX3.Value + 15
        Else
            Me.Hide()
            Form16.Show()
            Form16.lblDeck.Show()

        End If
    End Sub

    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class