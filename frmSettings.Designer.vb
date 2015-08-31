<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lbFileName = New System.Windows.Forms.Label()
        Me.lbPath = New System.Windows.Forms.Label()
        Me.tbPath = New System.Windows.Forms.TextBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.fbdFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.rbLevel3 = New System.Windows.Forms.RadioButton()
        Me.rbLevel2 = New System.Windows.Forms.RadioButton()
        Me.rbLevel1 = New System.Windows.Forms.RadioButton()
        Me.cbEVersion = New System.Windows.Forms.CheckBox()
        Me.cbECMAList = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbFileLocation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCstCmd = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(449, 288)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "取消"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(368, 288)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "确定"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lbFileName
        '
        Me.lbFileName.AutoSize = True
        Me.lbFileName.Location = New System.Drawing.Point(12, 9)
        Me.lbFileName.Name = "lbFileName"
        Me.lbFileName.Size = New System.Drawing.Size(41, 12)
        Me.lbFileName.TabIndex = 2
        Me.lbFileName.Text = "文件名"
        '
        'lbPath
        '
        Me.lbPath.AutoSize = True
        Me.lbPath.Location = New System.Drawing.Point(12, 63)
        Me.lbPath.Name = "lbPath"
        Me.lbPath.Size = New System.Drawing.Size(173, 12)
        Me.lbPath.TabIndex = 3
        Me.lbPath.Text = "保存位置(--js_output_file)："
        '
        'tbPath
        '
        Me.tbPath.Location = New System.Drawing.Point(14, 80)
        Me.tbPath.Name = "tbPath"
        Me.tbPath.Size = New System.Drawing.Size(429, 21)
        Me.tbPath.TabIndex = 4
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(449, 80)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnSelect.TabIndex = 5
        Me.btnSelect.Text = "选择..."
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.rbLevel3)
        Me.GroupBox1.Controls.Add(Me.rbLevel2)
        Me.GroupBox1.Controls.Add(Me.rbLevel1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 119)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "优化等级(--compilation_level)"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(85, 93)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(143, 12)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Google Closure Compiler"
        '
        'rbLevel3
        '
        Me.rbLevel3.AutoSize = True
        Me.rbLevel3.Location = New System.Drawing.Point(19, 64)
        Me.rbLevel3.Name = "rbLevel3"
        Me.rbLevel3.Size = New System.Drawing.Size(215, 16)
        Me.rbLevel3.TabIndex = 9
        Me.rbLevel3.TabStop = True
        Me.rbLevel3.Text = "高级优化(ADVANCED_OPTIMIZATIONS)"
        Me.rbLevel3.UseVisualStyleBackColor = True
        '
        'rbLevel2
        '
        Me.rbLevel2.AutoSize = True
        Me.rbLevel2.Location = New System.Drawing.Point(19, 42)
        Me.rbLevel2.Name = "rbLevel2"
        Me.rbLevel2.Size = New System.Drawing.Size(203, 16)
        Me.rbLevel2.TabIndex = 8
        Me.rbLevel2.TabStop = True
        Me.rbLevel2.Text = "简单优化(SIMPLE_OPTIMIZATIONS)"
        Me.rbLevel2.UseVisualStyleBackColor = True
        '
        'rbLevel1
        '
        Me.rbLevel1.AutoSize = True
        Me.rbLevel1.Location = New System.Drawing.Point(19, 20)
        Me.rbLevel1.Name = "rbLevel1"
        Me.rbLevel1.Size = New System.Drawing.Size(209, 16)
        Me.rbLevel1.TabIndex = 7
        Me.rbLevel1.TabStop = True
        Me.rbLevel1.Text = "仅移除无用字符(WHITESPACE_ONLY)"
        Me.rbLevel1.UseVisualStyleBackColor = True
        '
        'cbEVersion
        '
        Me.cbEVersion.AutoSize = True
        Me.cbEVersion.Location = New System.Drawing.Point(285, 117)
        Me.cbEVersion.Name = "cbEVersion"
        Me.cbEVersion.Size = New System.Drawing.Size(222, 16)
        Me.cbEVersion.TabIndex = 7
        Me.cbEVersion.Text = "指定Ecmascript版本(--language_in)"
        Me.cbEVersion.UseVisualStyleBackColor = True
        '
        'cbECMAList
        '
        Me.cbECMAList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbECMAList.FormattingEnabled = True
        Me.cbECMAList.Location = New System.Drawing.Point(307, 139)
        Me.cbECMAList.Name = "cbECMAList"
        Me.cbECMAList.Size = New System.Drawing.Size(200, 20)
        Me.cbECMAList.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "文件位置"
        '
        'tbFileLocation
        '
        Me.tbFileLocation.Location = New System.Drawing.Point(71, 27)
        Me.tbFileLocation.Name = "tbFileLocation"
        Me.tbFileLocation.ReadOnly = True
        Me.tbFileLocation.Size = New System.Drawing.Size(453, 21)
        Me.tbFileLocation.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "自定义参数"
        '
        'tbCstCmd
        '
        Me.tbCstCmd.Location = New System.Drawing.Point(83, 251)
        Me.tbCstCmd.Name = "tbCstCmd"
        Me.tbCstCmd.Size = New System.Drawing.Size(441, 21)
        Me.tbCstCmd.TabIndex = 12
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 323)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbCstCmd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbFileLocation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbECMAList)
        Me.Controls.Add(Me.cbEVersion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.tbPath)
        Me.Controls.Add(Me.lbPath)
        Me.Controls.Add(Me.lbFileName)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmSettings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents lbFileName As Label
    Friend WithEvents lbPath As Label
    Friend WithEvents tbPath As TextBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents fbdFolder As FolderBrowserDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbLevel1 As RadioButton
    Friend WithEvents rbLevel3 As RadioButton
    Friend WithEvents rbLevel2 As RadioButton
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents cbEVersion As CheckBox
    Friend WithEvents cbECMAList As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbFileLocation As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCstCmd As TextBox
End Class
