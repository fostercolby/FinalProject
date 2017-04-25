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
        Dim result As Boolean = False


        If txtId.Text = "" Then
            errProvider.SetError(txtId, txtId.Tag.ToString & " is blank")
            txtId.Focus()
            Return
        End If






        For Each entry In adapter.GetData
            If txtId.Text = entry.Id Then
                errProvider.Clear()

                lblUpdate.Visible = True
                btnUpdate.Visible = True
                txtMetric2.Visible = True
                txtName.Visible = True
                txtNPS.Visible = True
                txtType.Visible = True
                Label3.Visible = True
                Label5.Visible = True
                Label4.Visible = True
                Label6.Visible = True



                txtName.Text = entry.Name.ToString
                txtNPS.Text = entry.NPS.ToString
                txtMetric2.Text = entry.Metric2.ToString
                txtType.Text = entry.Type.ToString

                result = True


            End If


        Next

        If result = False Then
            errProvider.SetError(txtId, "No employee with that id")
            Return
        End If



    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim updateCounter As Integer = 0
        Dim CurrentXP As Double = 0
        Dim afterXP As Double = 0
        Dim currentNPS As Integer
        Dim currentMetric2 As Double
        Dim counter As Integer = 0




        errProvider.Clear()

        For i As Integer = Controls.Count - 1 To 0 Step -1
            If TypeOf Controls(i) Is TextBox Then
                Dim txt As TextBox = CType(Controls(i), TextBox)
                If txt.Text = "" Then
                    errProvider.SetError(txt, txt.Tag.ToString & " is blank")
                    txt.Focus()
                    Return
                End If

                If txt.Text.Contains(",") Then
                    errProvider.SetError(txt, txt.Tag.ToString & " cannot contain a comma")
                    txt.Focus()
                    Return
                End If
                If txt.Name = "txtMetric2" Then
                    Dim metric2 As Decimal
                    If Not Decimal.TryParse(txt.Text, metric2) Then
                        errProvider.SetError(txt, txt.Tag.ToString & " must be an integer or decimal")
                        Return

                    End If
                End If
            End If


            If TypeOf Controls(i) Is ComboBox Then
                Dim cbo As ComboBox = CType(Controls(i), ComboBox)
                If cbo.SelectedIndex = -1 Then
                    errProvider.SetError(cbo, cbo.Tag.ToString & " is not selected")
                    cbo.Focus()
                    Return

                End If
            End If
        Next


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

    Private Sub txtId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtId.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            If e.KeyChar = vbBack Then
                e.Handled = False
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class