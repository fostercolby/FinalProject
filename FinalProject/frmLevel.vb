Public Class frmLevel
    Dim XPAdapter As New EmployeeDataSetTableAdapters.ExperienceTableAdapter


    Private Sub frmLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim level As Integer
        Dim currentXP As Double
        Dim minimumXP As Integer
        Dim maximumXP As Integer


        For Each entry In XPAdapter.GetData
            If frmViewLevel.txtId.Text = entry.Id Then
                currentXP = entry.Experience
            End If

        Next


        For Each entry In Form1.ARAList
            If frmViewLevel.txtId.Text = entry.Id Then
                entry.Experience = currentXP
                If currentXP < 800 Then
                    level = 1
                    minimumXP = 0
                    maximumXP = 800
                ElseIf currentXP > 800 And currentXP < 1600 Then
                    level = 2
                    minimumXP = 800
                    maximumXP = 1600

                End If

            End If
        Next
            barExperience.Minimum = minimumXP
            barExperience.Maximum = maximumXP
            barExperience.Value = currentXP
            lblMessage.Text = "Congradulations you are level " & level
            lblMin.Text = "This level starts at " & minimumXP & " experience"
            lblMax.Text = "The next level starts at " & maximumXP & " experience"

    End Sub

    Private Sub lblMin_Click(sender As Object, e As EventArgs) Handles lblMin.Click

    End Sub
End Class