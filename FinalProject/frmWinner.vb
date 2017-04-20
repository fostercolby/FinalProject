Public Class frmWinner
    Dim adapter As New EmployeeDataSetTableAdapters.EmployeesTableAdapter

    Dim XPAdapter As New EmployeeDataSetTableAdapters.ExperienceTableAdapter

    Private Sub frmWinner_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        For Each entry In adapter.GetData
                adapter.Update(entry.Name, entry.Type, 0, 0, entry.Id)

            Next
            For Each entry In XPAdapter.GetData
                XPAdapter.Update(0, entry.Id)
            Next

    End Sub

    Private Sub frmWinner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim highest As Double = 0
        Dim idCheck As Integer = 0
        Dim name As String = ""
        Dim Type As String = ""


        For Each entry In XPAdapter.GetData

            If entry.Experience > 0 Then
                highest = entry.Experience
                idCheck = entry.Id

            End If
        Next
        MessageBox.Show(highest & idCheck)
        For Each entry In adapter.GetData
            If entry.Id = idCheck Then
                name = entry.Name
                Type = entry.Type.ToString.Trim

            End If
        Next

        Label1.Text = "Congradulations " & Type & name & " you are the current champion!"
    End Sub
End Class