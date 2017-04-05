Public Class frmLevel
    Private Sub frmLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim level As Integer = 1
        Dim currentXP As Integer = 200
        Dim minimumXP As Integer = 0
        Dim maximumXP As Integer = 250


        lblMessage.Text = "Congradulations you are level " & level
        lblMin.Text = "This level starts at " & minimumXP & " experience"
        lblMax.Text = "The next level starts at " & maximumXP & " experience"
        barExperience.Minimum = minimumXP
        barExperience.Maximum = maximumXP
        barExperience.Value = currentXP



    End Sub

    Private Sub lblMin_Click(sender As Object, e As EventArgs) Handles lblMin.Click

    End Sub
End Class