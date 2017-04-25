<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewLevel
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.btnView = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter employee number and click view button to view progress!"
        '
        'dgvEmployees
        '
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Location = New System.Drawing.Point(12, 204)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.RowTemplate.Height = 24
        Me.dgvEmployees.Size = New System.Drawing.Size(837, 218)
        Me.dgvEmployees.TabIndex = 1
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(385, 142)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "View Progress"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(133, 64)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 22)
        Me.txtId.TabIndex = 3
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'frmViewLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 434)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmViewLevel"
        Me.Text = "View Level"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents btnView As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents errProvider As ErrorProvider
End Class
