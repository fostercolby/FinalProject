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
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.EmployeesExperienceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExperienceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeesTableAdapter = New FinalProject.EmployeeDataSetTableAdapters.EmployeesTableAdapter()
        Me.ExperienceTableAdapter = New FinalProject.EmployeeDataSetTableAdapters.ExperienceTableAdapter()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesExperienceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtId.Tag = "Id"
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
        Me.txtName.Tag = "Name"
        Me.txtName.Visible = False
        '
        'txtNPS
        '
        Me.txtNPS.Location = New System.Drawing.Point(710, 120)
        Me.txtNPS.Name = "txtNPS"
        Me.txtNPS.Size = New System.Drawing.Size(100, 22)
        Me.txtNPS.TabIndex = 7
        Me.txtNPS.Tag = "Name-Mentions"
        Me.txtNPS.Visible = False
        '
        'txtMetric2
        '
        Me.txtMetric2.Location = New System.Drawing.Point(710, 148)
        Me.txtMetric2.Name = "txtMetric2"
        Me.txtMetric2.Size = New System.Drawing.Size(100, 22)
        Me.txtMetric2.TabIndex = 8
        Me.txtMetric2.Tag = "Metric 2"
        Me.txtMetric2.Visible = False
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(710, 92)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(100, 22)
        Me.txtType.TabIndex = 9
        Me.txtType.Tag = "Type"
        Me.txtType.Visible = False
        '
        'EmployeesExperienceBindingSource
        '
        Me.EmployeesExperienceBindingSource.DataMember = "Employees_Experience"
        Me.EmployeesExperienceBindingSource.DataSource = Me.EmployeesBindingSource
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.ExperienceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmployeesExperienceBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 440)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(986, 150)
        Me.DataGridView1.TabIndex = 10
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        '
        'ExperienceDataGridViewTextBoxColumn
        '
        Me.ExperienceDataGridViewTextBoxColumn.DataPropertyName = "Experience"
        Me.ExperienceDataGridViewTextBoxColumn.HeaderText = "Experience"
        Me.ExperienceDataGridViewTextBoxColumn.Name = "ExperienceDataGridViewTextBoxColumn"
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'ExperienceTableAdapter
        '
        Me.ExperienceTableAdapter.ClearBeforeFill = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(404, 147)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 23)
        Me.btnDone.TabIndex = 12
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(369, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 56)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Once you are done updating all employees please click done!"
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(630, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Name"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(630, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Type"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(574, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Name-Mentions"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(630, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Metric 2"
        Me.Label6.Visible = False
        '
        'frmUpdateEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 560)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.DataGridView1)
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
        CType(Me.EmployeesExperienceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents EmployeesExperienceBindingSource As BindingSource
    Friend WithEvents ExperienceTableAdapter As EmployeeDataSetTableAdapters.ExperienceTableAdapter
    Friend WithEvents ExperienceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnDone As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents errProvider As ErrorProvider
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
