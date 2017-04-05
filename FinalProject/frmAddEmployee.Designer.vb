<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEmployee
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtMentions = New System.Windows.Forms.TextBox()
        Me.lblMetric2 = New System.Windows.Forms.Label()
        Me.txtMetric2 = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.EmployeeDataSet = New FinalProject.EmployeeDataSet()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesTableAdapter = New FinalProject.EmployeeDataSetTableAdapters.EmployeesTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NPSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Metric2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmployees
        '
        Me.dgvEmployees.AutoGenerateColumns = False
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.NPSDataGridViewTextBoxColumn, Me.Metric2DataGridViewTextBoxColumn})
        Me.dgvEmployees.DataSource = Me.EmployeesBindingSource
        Me.dgvEmployees.Location = New System.Drawing.Point(12, 214)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.RowTemplate.Height = 24
        Me.dgvEmployees.Size = New System.Drawing.Size(799, 247)
        Me.dgvEmployees.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Employee Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Name-Mentions:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(132, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 5
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(132, 33)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(164, 24)
        Me.cboType.TabIndex = 7
        '
        'txtMentions
        '
        Me.txtMentions.Location = New System.Drawing.Point(132, 72)
        Me.txtMentions.Name = "txtMentions"
        Me.txtMentions.Size = New System.Drawing.Size(100, 22)
        Me.txtMentions.TabIndex = 8
        '
        'lblMetric2
        '
        Me.lblMetric2.AutoSize = True
        Me.lblMetric2.Location = New System.Drawing.Point(16, 103)
        Me.lblMetric2.Name = "lblMetric2"
        Me.lblMetric2.Size = New System.Drawing.Size(62, 17)
        Me.lblMetric2.TabIndex = 9
        Me.lblMetric2.Text = "Metric 2:"
        Me.lblMetric2.Visible = False
        '
        'txtMetric2
        '
        Me.txtMetric2.Location = New System.Drawing.Point(132, 100)
        Me.txtMetric2.Name = "txtMetric2"
        Me.txtMetric2.Size = New System.Drawing.Size(100, 22)
        Me.txtMetric2.TabIndex = 10
        Me.txtMetric2.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(507, 56)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(166, 56)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add Employee"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'EmployeeDataSet
        '
        Me.EmployeeDataSet.DataSetName = "EmployeeDataSet"
        Me.EmployeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.EmployeeDataSet
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
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
        'frmAddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 473)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtMetric2)
        Me.Controls.Add(Me.lblMetric2)
        Me.Controls.Add(Me.txtMentions)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Name = "frmAddEmployee"
        Me.Text = "Add Employee"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents txtMentions As TextBox
    Friend WithEvents lblMetric2 As Label
    Friend WithEvents txtMetric2 As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents EmployeeDataSet As EmployeeDataSet
    Friend WithEvents EmployeesBindingSource As BindingSource
    Friend WithEvents EmployeesTableAdapter As EmployeeDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NPSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Metric2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
