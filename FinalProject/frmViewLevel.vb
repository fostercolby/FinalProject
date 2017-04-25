Public Class frmViewLevel
    Dim adapter As New EmployeeDataSetTableAdapters.EmployeesTableAdapter

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        errProvider.Clear()

        If txtId.Text = "" Then
            errProvider.SetError(txtId, "Id is blank")
            Return


        End If
        For Each entry In adapter.GetData
            If txtId.Text = entry.Id Then
                frmLevel.ShowDialog()
                Me.Close()

            End If

        Next
        errProvider.SetError(txtId, "Id does not exist")
        Return

    End Sub

    Private Sub frmViewLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        dgvEmployees.DataSource = adapter.GetData



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
End Class