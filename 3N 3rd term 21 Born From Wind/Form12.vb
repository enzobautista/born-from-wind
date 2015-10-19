Public Class Form12

    Private Sub btnMate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMate.Click
        Me.Hide()
        Form16.Show()
    End Sub

    Private Sub btnSkipper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSkipper.Click
        Me.Hide()
        Form13.Show()
        Form6.ProgressBarX1.Value = Form6.ProgressBarX1.Value + 10

    End Sub

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class