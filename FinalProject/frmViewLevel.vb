Public Class frmViewLevel
    Dim adapter As New EmployeeDataSetTableAdapters.EmployeesTableAdapter

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        frmLevel.ShowDialog()

    End Sub

    Private Sub frmViewLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEmployees.DataSource = adapter.GetData

    End Sub
End Class