Public Class Form14

    Private Sub btnDeck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeck.Click
        Me.Hide()
        Form16.Show()
        Form16.lblDeck.Show()
        Form16.Label1.Hide()

    End Sub

    Private Sub btnFmate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFmate.Click
        Me.Hide()
        Form17.Show()
    End Sub
End Class