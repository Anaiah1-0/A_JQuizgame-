Public Class QuestionForm1
    Dim int1 As Integer
    Public Shared intPoint As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNext.Enabled = False

    End Sub

    'QUESTION 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMascara.Click
        Correct1.Text = "Incorrect!"
        btnMascara.Enabled = False
        btnFoundation.Enabled = False
        btnNext.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnFoundation.Click
        Correct1.Text = "Correct!"
        btnMascara.Enabled = False
        btnFoundation.Enabled = False
        btnNext.Enabled = True
        intPoint = intPoint + 10
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        HomeForm.Show()
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        Question2Form.Show()
    End Sub

End Class
