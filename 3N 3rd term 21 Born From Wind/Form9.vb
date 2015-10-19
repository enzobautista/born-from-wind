Public Class Form9


    Private Sub btnJib_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJib.Click
        Me.Hide()
        Form16.Show()
    End Sub

    Private Sub btnMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMain.Click
        Me.Hide()
        Form11.Show()
        Form6.ProgressBarX3.Value = Form6.ProgressBarX3.Value + 20


    End Sub
End Class