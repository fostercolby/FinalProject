<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel
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
        Me.barExperience = New System.Windows.Forms.ProgressBar()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.lblPercentage = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barExperience
        '
        Me.barExperience.Location = New System.Drawing.Point(194, 305)
        Me.barExperience.Name = "barExperience"
        Me.barExperience.Size = New System.Drawing.Size(534, 48)
        Me.barExperience.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(174, 64)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(79, 17)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "lblMessage"
        '
        'lblMin
        '
        Me.lblMin.Location = New System.Drawing.Point(12, 305)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(176, 63)
        Me.lblMin.TabIndex = 2
        Me.lblMin.Text = "Label1"
        '
        'lblMax
        '
        Me.lblMax.Location = New System.Drawing.Point(754, 305)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(176, 63)
        Me.lblMax.TabIndex = 3
        Me.lblMax.Text = "Label 2"
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.Location = New System.Drawing.Point(434, 383)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(51, 17)
        Me.lblPercentage.TabIndex = 4
        Me.lblPercentage.Text = "Label1"
        '
        'frmLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(942, 474)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.barExperience)
        Me.Name = "frmLevel"
        Me.Text = "Level"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents barExperience As ProgressBar
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblMax As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents lblPercentage As Label
End Class
