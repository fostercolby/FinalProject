Imports System.IO

Public Class Form1
    Dim adapter As New EmployeeDataSetTableAdapters.EmployeesTableAdapter
    Dim XPAdapter As New EmployeeDataSetTableAdapters.ExperienceTableAdapter

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

    Private Sub LevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LevelToolStripMenuItem.Click

    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        frmAddEmployee.ShowDialog()

    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        frmDeleteEmployees.ShowDialog()

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        frmUpdateEmployees.ShowDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Dim topXP As Double = 0
        Dim topID As Integer = 0
        Dim topName As String = ""
        Dim topType As String = ""
        Dim topMetric2 As Double = 0
        Dim topNPS As Double = 0


        For Each entry In XPAdapter.GetData
            If entry.Experience > topXP Then
                topXP = entry.Experience
                topID = entry.Id

            End If
        Next

        For Each entry In adapter.GetData
            If entry.Id = topID Then
                topName = entry.Name
                topType = entry.Type
                topNPS = entry.NPS
                topMetric2 = entry.Metric2

            End If
        Next


        Dim outfile As New StreamWriter("CurrentRankReport.txt")
        outfile.WriteLine("The current leader is :" & topName)
        outfile.WriteLine(" ")
        outfile.WriteLine("Leaders information: ")
        outfile.WriteLine("Name: " & topName & Environment.NewLine &
                          "Type: " & topType & Environment.NewLine &
                          "NPS: " & topNPS & Environment.NewLine &
                          "Metric 2: " & topMetric2 & Environment.NewLine)

        outfile.WriteLine("All employees information: ")

        For Each entry In adapter.GetData
            outfile.WriteLine("Name: " & entry.Name & Environment.NewLine &
                          "Type: " & entry.Type & Environment.NewLine &
                          "NPS: " & entry.NPS & Environment.NewLine &
                          "Metric 2: " & entry.Metric2 & Environment.NewLine)
        Next


        outfile.Close()
        MessageBox.Show("Current report has been created!")



    End Sub
End Class
