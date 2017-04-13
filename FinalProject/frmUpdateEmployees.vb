Public Class frmUpdateEmployees
    Dim adapter As New EmployeeDataSetTableAdapters.EmployeesTableAdapter
    Dim XPAdapter As New EmployeeDataSetTableAdapters.ExperienceTableAdapter
    Private ARA As New ARA



    Private Sub frmUpdateEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.EmployeeDataSet.Employees)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        lblUpdate.Visible = True
        btnUpdate.Visible = True
        txtMetric2.Visible = True
        txtName.Visible = True
        txtNPS.Visible = True

        For Each entry In Form1.ARAList
            If txtId.Text = entry.Id Then
                txtName.Text = entry.Name.ToString
                txtNPS.Text = entry.NPS.ToString
                txtMetric2.Text = entry.TPH.ToString
                txtType.Text = entry.Type.ToString


            End If


        Next

        For Each entry In Form1.CAList
            If txtId.Text = entry.Id Then
                txtName.Text = entry.Name.ToString
                txtNPS.Text = entry.NPS.ToString
                txtMetric2.Text = entry.RPH.ToString
                txtType.Text = entry.Type.ToString

            End If


        Next



    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ARA.Update(CInt(txtId.Text), txtName.Text, txtType.Text, CInt(txtNPS.Text), CDbl(txtMetric2.Text))
        dgvEmployees.DataSource = adapter.GetData

    End Sub
End Class