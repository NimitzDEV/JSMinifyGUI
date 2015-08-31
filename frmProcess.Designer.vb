<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcess
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbNow = New System.Windows.Forms.Label()
        Me.pbProgress = New System.Windows.Forms.ProgressBar()
        Me.btnAction = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lbNow
        '
        Me.lbNow.AutoSize = True
        Me.lbNow.Location = New System.Drawing.Point(12, 9)
        Me.lbNow.Name = "lbNow"
        Me.lbNow.Size = New System.Drawing.Size(71, 12)
        Me.lbNow.TabIndex = 0
        Me.lbNow.Text = "正在准备..."
        '
        'pbProgress
        '
        Me.pbProgress.Location = New System.Drawing.Point(12, 33)
        Me.pbProgress.Name = "pbProgress"
        Me.pbProgress.Size = New System.Drawing.Size(234, 23)
        Me.pbProgress.TabIndex = 1
        '
        'btnAction
        '
        Me.btnAction.Location = New System.Drawing.Point(171, 62)
        Me.btnAction.Name = "btnAction"
        Me.btnAction.Size = New System.Drawing.Size(75, 23)
        Me.btnAction.TabIndex = 2
        Me.btnAction.Text = "取消"
        Me.btnAction.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 94)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAction)
        Me.Controls.Add(Me.pbProgress)
        Me.Controls.Add(Me.lbNow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmProcess"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "正在处理..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbNow As Label
    Friend WithEvents pbProgress As ProgressBar
    Friend WithEvents btnAction As Button
    Friend WithEvents Timer1 As Timer
End Class
