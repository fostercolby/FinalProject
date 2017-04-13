<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateEmployees
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Metric2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeDataSet = New FinalProject.EmployeeDataSet()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtNPS = New System.Windows.Forms.TextBox()
        Me.txtMetric2 = New System.Windows.Forms.TextBox()
        Me.EmployeesTableAdapter = New FinalProject.EmployeeDataSetTableAdapters.EmployeesTableAdapter()
        Me.txtType = New System.Windows.Forms.TextBox()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmployees
        '
        Me.dgvEmployees.AutoGenerateColumns = False
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.NPSDataGridViewTextBoxColumn, Me.Metric2DataGridViewTextBoxColumn})
        Me.dgvEmployees.DataSource = Me.EmployeesBindingSource
        Me.dgvEmployees.Location = New System.Drawing.Point(12, 216)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.RowTemplate.Height = 24
        Me.dgvEmployees.Size = New System.Drawing.Size(986, 218)
        Me.dgvEmployees.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'NPSDataGridViewTextBoxColumn
        '
        Me.NPSDataGridViewTextBoxColumn.DataPropertyName = "NPS"
        Me.NPSDataGridViewTextBoxColumn.HeaderText = "NPS"
        Me.NPSDataGridViewTextBoxColumn.Name = "NPSDataGridViewTextBoxColumn"
        '
        'Metric2DataGridViewTextBoxColumn
        '
        Me.Metric2DataGridViewTextBoxColumn.DataPropertyName = "Metric2"
        Me.Metric2DataGridViewTextBoxColumn.HeaderText = "Metric2"
        Me.Metric2DataGridViewTextBoxColumn.Name = "Metric2DataGridViewTextBoxColumn"
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.EmployeeDataSet
        '
        'EmployeeDataSet
        '
        Me.EmployeeDataSet.DataSetName = "EmployeeDataSet"
        Me.EmployeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(50, 90)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 22)
        Me.txtId.TabIndex = 1
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(50, 161)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Please enter ID of employee you wish to update!"
        '
        'lblUpdate
        '
        Me.lblUpdate.AutoSize = True
        Me.lblUpdate.Location = New System.Drawing.Point(581, 35)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(334, 17)
        Me.lblUpdate.TabIndex = 4
        Me.lblUpdate.Text = "Please update desired informatin and press update!"
        Me.lblUpdate.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(710, 187)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(710, 62)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 6
        Me.txtName.Visible = False
        '
        'txtNPS
        '
        Me.txtNPS.Location = New System.Drawing.Point(710, 120)
        Me.txtNPS.Name = "txtNPS"
        Me.txtNPS.Size = New System.Drawing.Size(100, 22)
        Me.txtNPS.TabIndex = 7
        Me.txtNPS.Visible = False
        '
        'txtMetric2
        '
        Me.txtMetric2.Location = New System.Drawing.Point(710, 148)
        Me.txtMetric2.Name = "txtMetric2"
        Me.txtMetric2.Size = New System.Drawing.Size(100, 22)
        Me.txtMetric2.TabIndex = 8
        Me.txtMetric2.Visible = False
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(710, 92)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(100, 22)
        Me.txtType.TabIndex = 9
        Me.txtType.Visible = False
        '
        'frmUpdateEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 446)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtMetric2)
        Me.Controls.Add(Me.txtNPS)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Name = "frmUpdateEmployees"
        Me.Text = "UpdateEmployees"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUpdate As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNPS As TextBox
    Friend WithEvents txtMetric2 As TextBox
    Friend WithEvents EmployeeDataSet As EmployeeDataSet
    Friend WithEvents EmployeesBindingSource As BindingSource
    Friend WithEvents EmployeesTableAdapter As EmployeeDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NPSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Metric2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtType As TextBox
End Class
