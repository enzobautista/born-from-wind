Public Class Form11

    
    
    
    
    Private Sub btnBow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBow.Click
        Me.Hide()
        Form16.Show()
    End Sub

    Private Sub btnHelm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelm.Click
        Me.Hide()
        Form12.Show()
        Form6.ProgressBarX2.Value = Form6.ProgressBarX2.Value + 15
    End Sub
End Class