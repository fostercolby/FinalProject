Public Class frmUpdateEmployees
    Dim adapter As New EmployeeDataSetTableAdapters.EmployeesTableAdapter
    Dim XPAdapter As New EmployeeDataSetTableAdapters.ExperienceTableAdapter
    Private ARA As New ARA



    Private Sub frmUpdateEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeeDataSet.Experience' table. You can move, or remove it, as needed.
        Me.ExperienceTableAdapter.Fill(Me.EmployeeDataSet.Experience)
        'TODO: This line of code loads data into the 'EmployeeDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.EmployeeDataSet.Employees)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        lblUpdate.Visible = True
        btnUpdate.Visible = True
        txtMetric2.Visible = True
        txtName.Visible = True
        txtNPS.Visible = True
        txtType.Visible = True




        For Each entry In adapter.GetData
            If txtId.Text = entry.Id Then


                txtName.Text = entry.Name.ToString
                txtNPS.Text = entry.NPS.ToString
                txtMetric2.Text = entry.Metric2.ToString
                txtType.Text = entry.Type.ToString


            End If


        Next





    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim updateCounter As Integer = 0
        Dim CurrentXP As Double = 0
        Dim afterXP As Double = 0
        Dim currentNPS As Integer
        Dim currentMetric2 As Double
        Dim counter As Integer = 0

        'IF ARA

        For Each entry In XPAdapter.GetData
            If txtId.Text = entry.Id Then
                CurrentXP = entry.Experience

            End If

        Next

        For Each entry In Form1.ARAList
            If txtId.Text = entry.Id Then
                entry.Update(entry.Id, entry.Name, entry.Type, txtNPS.Text, txtMetric2.Text)
                currentNPS = entry.NPS
                currentMetric2 = entry.TPH
            End If
        Next

        For Each entry In XPAdapter.GetData
            If txtId.Text = entry.Id Then
                afterXP = entry.Experience + ((currentNPS * 50) + (currentMetric2 * 300))
                XPAdapter.Update(afterXP, txtId.Text)
            End If

        Next



        'IF CA



        For Each entry In Form1.CAList
            If txtId.Text = entry.Id Then
                entry.Update(entry.Id, entry.Name, entry.Type, txtNPS.Text, txtMetric2.Text)
                currentNPS = entry.NPS
                currentMetric2 = entry.RPH
            End If
        Next

        For Each entry In XPAdapter.GetData
            If txtId.Text = entry.Id Then
                afterXP = entry.Experience + ((currentNPS * 50) + (currentMetric2 * 20))
                XPAdapter.Update(afterXP, txtId.Text)
            End If

        Next
















        dgvEmployees.DataSource = adapter.GetData

        DataGridView1.DataSource = XPAdapter.GetData
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        Dim count As Integer
        count += 1
        If count = 6 Then
            Me.Close()
            frmWinner.ShowDialog()
        Else
            Me.Close()

        End If

    End Sub
End Class