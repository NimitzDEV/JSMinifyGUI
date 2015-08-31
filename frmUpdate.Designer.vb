<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.lbNewVersion = New System.Windows.Forms.Label()
        Me.btnDe = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbCompilerVersion = New System.Windows.Forms.Label()
        Me.btnUpdateCompiler = New System.Windows.Forms.Button()
        Me.btnDl = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(233, 183)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "关闭"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lbVersion
        '
        Me.lbVersion.AutoSize = True
        Me.lbVersion.Location = New System.Drawing.Point(82, 12)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(41, 12)
        Me.lbVersion.TabIndex = 2
        Me.lbVersion.Text = "Label1"
        '
        'lbNewVersion
        '
        Me.lbNewVersion.AutoSize = True
        Me.lbNewVersion.Location = New System.Drawing.Point(82, 34)
        Me.lbNewVersion.Name = "lbNewVersion"
        Me.lbNewVersion.Size = New System.Drawing.Size(119, 12)
        Me.lbNewVersion.TabIndex = 3
        Me.lbNewVersion.Text = "正在获取更新信息..."
        '
        'btnDe
        '
        Me.btnDe.Enabled = False
        Me.btnDe.Location = New System.Drawing.Point(150, 53)
        Me.btnDe.Name = "btnDe"
        Me.btnDe.Size = New System.Drawing.Size(75, 23)
        Me.btnDe.TabIndex = 4
        Me.btnDe.Text = "查看详情"
        Me.btnDe.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.JSMinifyGUI.My.Resources.Resources._20150801112627257_easyicon_net_64
        Me.PictureBox2.Location = New System.Drawing.Point(12, 94)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.JSMinifyGUI.My.Resources.Resources._20150801110123299_easyicon_net_128
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lbCompilerVersion
        '
        Me.lbCompilerVersion.AutoSize = True
        Me.lbCompilerVersion.Location = New System.Drawing.Point(82, 94)
        Me.lbCompilerVersion.Name = "lbCompilerVersion"
        Me.lbCompilerVersion.Size = New System.Drawing.Size(119, 12)
        Me.lbCompilerVersion.TabIndex = 6
        Me.lbCompilerVersion.Text = "正在获取更新信息..."
        '
        'btnUpdateCompiler
        '
        Me.btnUpdateCompiler.Enabled = False
        Me.btnUpdateCompiler.Location = New System.Drawing.Point(233, 135)
        Me.btnUpdateCompiler.Name = "btnUpdateCompiler"
        Me.btnUpdateCompiler.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateCompiler.TabIndex = 7
        Me.btnUpdateCompiler.Text = "立即更新"
        Me.btnUpdateCompiler.UseVisualStyleBackColor = True
        '
        'btnDl
        '
        Me.btnDl.Enabled = False
        Me.btnDl.Location = New System.Drawing.Point(233, 53)
        Me.btnDl.Name = "btnDl"
        Me.btnDl.Size = New System.Drawing.Size(75, 23)
        Me.btnDl.TabIndex = 8
        Me.btnDl.Text = "下载更新"
        Me.btnDl.UseVisualStyleBackColor = True
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 215)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDl)
        Me.Controls.Add(Me.btnUpdateCompiler)
        Me.Controls.Add(Me.lbCompilerVersion)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnDe)
        Me.Controls.Add(Me.lbNewVersion)
        Me.Controls.Add(Me.lbVersion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmUpdate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "更新"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbVersion As Label
    Friend WithEvents lbNewVersion As Label
    Friend WithEvents btnDe As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbCompilerVersion As Label
    Friend WithEvents btnUpdateCompiler As Button
    Friend WithEvents btnDl As Button
End Class
