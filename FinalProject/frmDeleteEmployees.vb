

Public Class frmDeleteEmployees
    Dim adapter As New EmployeeDataSetTableAdapters.EmployeesTableAdapter
    Dim XPAdapter As New EmployeeDataSetTableAdapters.ExperienceTableAdapter

    Private Sub frmDeleteEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.EmployeeDataSet.Employees)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        errProvider.Clear()

        Dim result As Boolean = False

        For Each entry In adapter.GetData
            If txtID.Text = entry.Id Then
                adapter.Delete(txtID.Text)
                result = True
            Else

            End If
        Next
        For Each entry In XPAdapter.GetData
            If txtID.Text = entry.Id Then
                XPAdapter.Delete(txtID.Text)

            End If
        Next
        If result = False Then
            errProvider.SetError(txtID, "No id with that number")
            Return

        End If

    End Sub
End Class