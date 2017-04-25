Public Class frmAddEmployee
    Dim adapter As New EmployeeDataSetTableAdapters.EmployeesTableAdapter
    Dim XPAdapter As New EmployeeDataSetTableAdapters.ExperienceTableAdapter

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


        If adapter.Insert(txtName.Text, cboType.SelectedItem.ToString, CInt(txtMentions.Text), CDbl(txtMetric2.Text)) Then

            If cboType.SelectedItem.ToString = "Advanced Repair Agent" Then
                XPAdapter.Insert(adapter.MaxId, 0)
            ElseIf cboType.SelectedItem.ToString = "Consultation Agent" Then
                XPAdapter.Insert(adapter.MaxId, 0)
            End If
            dgvEmployees.DataSource = adapter.GetData
            lblError.Text = "Employee added succesfuly!"
        Else
            lblError.Text = "Error adding Employees"
            Return
        End If


    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            If e.KeyChar = vbBack Then
                e.Handled = False
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtMentions_TextChanged(sender As Object, e As EventArgs) Handles txtMentions.TextChanged

    End Sub

    Private Sub txtMentions_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMentions.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            If e.KeyChar = vbBack Then
                e.Handled = False
                Exit Sub
            End If
        End If
    End Sub



    Private Sub txtMetric2_TextChanged(sender As Object, e As EventArgs) Handles txtMetric2.TextChanged

    End Sub
End Class