Public Class Form16

    Private Sub Form16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblFmate.Hide()
        lblFmate1.Hide()
        lblDeck.Hide()
        Label4.Text = Form6.Label12.Text
        Label5.Text = Form6.Label15.Text
        Label3.Text = Form6.Label8.Text
        ProgressBarX1.Value = Form6.ProgressBarX1.Value
        ProgressBarX2.Value = Form6.ProgressBarX2.Value
        ProgressBarX3.Value = Form6.ProgressBarX3.Value
        Label13.Text = ProgressBarX1.Value
        Label12.Text = ProgressBarX2.Value
        Label11.Text = ProgressBarX3.Value
        lblRank.Text = Form6.Label17.Text


    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()

        Form6.Close()
        Me.Close()
    End Sub
End Class