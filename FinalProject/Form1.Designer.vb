<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dvgCAEmployees = New System.Windows.Forms.DataGridView()
        Me.btnView = New System.Windows.Forms.Button()
        Me.dvgARAEmployee = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        CType(Me.dvgCAEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvgARAEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 433)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(141, 33)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Employee"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(667, 443)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dvgCAEmployees
        '
        Me.dvgCAEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgCAEmployees.Location = New System.Drawing.Point(12, 57)
        Me.dvgCAEmployees.Name = "dvgCAEmployees"
        Me.dvgCAEmployees.RowTemplate.Height = 24
        Me.dvgCAEmployees.Size = New System.Drawing.Size(730, 147)
        Me.dvgCAEmployees.TabIndex = 3
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(321, 433)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(141, 33)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "View Level"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'dvgARAEmployee
        '
        Me.dvgARAEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgARAEmployee.Location = New System.Drawing.Point(12, 280)
        Me.dvgARAEmployee.Name = "dvgARAEmployee"
        Me.dvgARAEmployee.RowTemplate.Height = 24
        Me.dvgARAEmployee.Size = New System.Drawing.Size(730, 147)
        Me.dvgARAEmployee.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(287, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Consultation Agents"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Advanced Repair Agents"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(484, 433)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 33)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Update Employee"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(159, 433)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(141, 33)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "Remove Employee"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 478)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dvgARAEmployee)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.dvgCAEmployees)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Text = "Employees"
        CType(Me.dvgCAEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvgARAEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents dvgCAEmployees As DataGridView
    Friend WithEvents btnView As Button
    Friend WithEvents dvgARAEmployee As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnRemove As Button
End Class
