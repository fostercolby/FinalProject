Public Class Form1
    Dim adapter As New EmployeeDataSetTableAdapters.EmployeesTableAdapter
    Public ARAList As New List(Of ARA)
    Public CAList As New List(Of CA)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddEmployee.ShowDialog()

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        frmDeleteEmployees.ShowDialog()

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        frmViewLevel.ShowDialog()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        For Each entry In adapter.GetData
            If entry.Type = "Advanced Repair Agent    " Then
                Dim newARA As New ARA(entry.Id, entry.Name, entry.Type, entry.NPS, entry.Metric2)
                ARAList.Add(newARA)
            ElseIf entry.Type = "Consultation Agent       " Then
                Dim newCA As New CA(entry.Id, entry.Name, entry.Type, entry.NPS, entry.Metric2)
                CAList.Add(newCA)

            End If


        Next
        dvgARAEmployee.DataSource = adapter.GetDataByARA
        dvgCAEmployees.DataSource = adapter.GetDataByCA














    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmUpdateEmployees.ShowDialog()

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        dvgARAEmployee.DataSource = adapter.GetDataByARA
        dvgCAEmployees.DataSource = adapter.GetDataByCA
    End Sub
End Class
