Public Class frmAddEmployee
    Dim adapter As New EmployeeDataSetTableAdapters.EmployeesTableAdapter
    Private Sub frmAddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.EmployeeDataSet.Employees)
        cboType.Items.Add("Consultation Agent")
        cboType.Items.Add("Advanced Repair Agent")
    End Sub

    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        If cboType.SelectedItem.ToString = "Consultation Agent" Then
            lblMetric2.Text = "Rev/hr:"
            lblMetric2.Visible = True
            txtMetric2.Visible = True
        ElseIf cboType.SelectedItem.ToString = "Advanced Repair Agent" Then
            lblMetric2.Text = "Tags/hr:"
            lblMetric2.Visible = True
            txtMetric2.Visible = True



        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        adapter.Insert(txtName.Text, cboType.SelectedItem.ToString, CInt(txtMentions.Text), txtMetric2.Text)
        ' dgvEmployees.DataSource = 
    End Sub
End Class