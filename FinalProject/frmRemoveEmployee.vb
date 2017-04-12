Public Class frmRemoveEmployee
    Dim adapter As New EmployeeDataSetTableAdapters.EmployeesTableAdapter

    Private Sub frmRemoveEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEmployees.DataSource = adapter.GetData

    End Sub
End Class