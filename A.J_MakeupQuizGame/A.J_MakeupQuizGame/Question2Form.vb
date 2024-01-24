Imports System
Public Class Question2Form
    Public Shared intPoint = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLiquidEyeLiner.Click
        Correct1.Text = "Incorrect!"
        btnLiquidEyeLiner.Enabled = False
        btnBlush.Enabled = False
        btnNext.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBlush.Click
        Correct1.Text = "Correct!"
        btnBlush.Enabled = False
        btnLiquidEyeLiner.Enabled = False
        btnNext.Enabled = True
        intPoint = intPoint + 10
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        HomeForm.Show()
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
    End Sub
End Class