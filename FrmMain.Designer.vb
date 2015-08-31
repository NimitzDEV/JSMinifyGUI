<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.lvFileList = New System.Windows.Forms.ListView()
        Me.chFileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSaveTo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAddFile = New System.Windows.Forms.Button()
        Me.ofdFileSelect = New System.Windows.Forms.OpenFileDialog()
        Me.btnDefault = New System.Windows.Forms.Button()
        Me.btnDo = New System.Windows.Forms.Button()
        Me.cmsRight = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiSetStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSetStatusUndone = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSetStatusDone = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.temiCMD = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.llbAbout = New System.Windows.Forms.LinkLabel()
        Me.llbUpdate = New System.Windows.Forms.LinkLabel()
        Me.lbTips = New System.Windows.Forms.Label()
        Me.btnScan = New System.Windows.Forms.Button()
        Me.cmsRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvFileList
        '
        Me.lvFileList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFileName, Me.chSaveTo, Me.chStatus})
        Me.lvFileList.FullRowSelect = True
        Me.lvFileList.Location = New System.Drawing.Point(12, 12)
        Me.lvFileList.MultiSelect = False
        Me.lvFileList.Name = "lvFileList"
        Me.lvFileList.Size = New System.Drawing.Size(542, 287)
        Me.lvFileList.TabIndex = 0
        Me.lvFileList.UseCompatibleStateImageBehavior = False
        Me.lvFileList.View = System.Windows.Forms.View.Details
        '
        'chFileName
        '
        Me.chFileName.Text = "文件名"
        Me.chFileName.Width = 150
        '
        'chSaveTo
        '
        Me.chSaveTo.Text = "保存到"
        Me.chSaveTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chSaveTo.Width = 310
        '
        'chStatus
        '
        Me.chStatus.Text = "状态"
        '
        'btnAddFile
        '
        Me.btnAddFile.Location = New System.Drawing.Point(12, 305)
        Me.btnAddFile.Name = "btnAddFile"
        Me.btnAddFile.Size = New System.Drawing.Size(181, 23)
        Me.btnAddFile.TabIndex = 1
        Me.btnAddFile.Text = "添加 JavaScript 文件..."
        Me.btnAddFile.UseVisualStyleBackColor = True
        '
        'ofdFileSelect
        '
        Me.ofdFileSelect.Multiselect = True
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(322, 305)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(121, 23)
        Me.btnDefault.TabIndex = 2
        Me.btnDefault.Text = "修改默认设置"
        Me.btnDefault.UseVisualStyleBackColor = True
        '
        'btnDo
        '
        Me.btnDo.Location = New System.Drawing.Point(449, 305)
        Me.btnDo.Name = "btnDo"
        Me.btnDo.Size = New System.Drawing.Size(105, 23)
        Me.btnDo.TabIndex = 3
        Me.btnDo.Text = "开始压缩"
        Me.btnDo.UseVisualStyleBackColor = True
        '
        'cmsRight
        '
        Me.cmsRight.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSetStatus, Me.tsmiDelete, Me.ToolStripMenuItem2, Me.temiCMD, Me.tsmiCopy, Me.ToolStripMenuItem1, Me.tsmiSettings})
        Me.cmsRight.Name = "cmsRight"
        Me.cmsRight.Size = New System.Drawing.Size(178, 126)
        '
        'tsmiSetStatus
        '
        Me.tsmiSetStatus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSetStatusUndone, Me.tsmiSetStatusDone})
        Me.tsmiSetStatus.Name = "tsmiSetStatus"
        Me.tsmiSetStatus.Size = New System.Drawing.Size(177, 22)
        Me.tsmiSetStatus.Text = "设置状态"
        '
        'tsmiSetStatusUndone
        '
        Me.tsmiSetStatusUndone.Name = "tsmiSetStatusUndone"
        Me.tsmiSetStatusUndone.Size = New System.Drawing.Size(112, 22)
        Me.tsmiSetStatusUndone.Text = "未处理"
        '
        'tsmiSetStatusDone
        '
        Me.tsmiSetStatusDone.Name = "tsmiSetStatusDone"
        Me.tsmiSetStatusDone.Size = New System.Drawing.Size(112, 22)
        Me.tsmiSetStatusDone.Text = "已完成"
        '
        'tsmiDelete
        '
        Me.tsmiDelete.Name = "tsmiDelete"
        Me.tsmiDelete.Size = New System.Drawing.Size(177, 22)
        Me.tsmiDelete.Text = "从列表中删除"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(174, 6)
        '
        'temiCMD
        '
        Me.temiCMD.Name = "temiCMD"
        Me.temiCMD.Size = New System.Drawing.Size(177, 22)
        Me.temiCMD.Text = "在CMD窗口中打开"
        '
        'tsmiCopy
        '
        Me.tsmiCopy.Name = "tsmiCopy"
        Me.tsmiCopy.Size = New System.Drawing.Size(177, 22)
        Me.tsmiCopy.Text = "复制命令行"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(174, 6)
        '
        'tsmiSettings
        '
        Me.tsmiSettings.Name = "tsmiSettings"
        Me.tsmiSettings.Size = New System.Drawing.Size(177, 22)
        Me.tsmiSettings.Text = "配置"
        '
        'llbAbout
        '
        Me.llbAbout.AutoSize = True
        Me.llbAbout.Location = New System.Drawing.Point(525, 336)
        Me.llbAbout.Name = "llbAbout"
        Me.llbAbout.Size = New System.Drawing.Size(29, 12)
        Me.llbAbout.TabIndex = 4
        Me.llbAbout.TabStop = True
        Me.llbAbout.Text = "关于"
        '
        'llbUpdate
        '
        Me.llbUpdate.AutoSize = True
        Me.llbUpdate.Location = New System.Drawing.Point(490, 336)
        Me.llbUpdate.Name = "llbUpdate"
        Me.llbUpdate.Size = New System.Drawing.Size(29, 12)
        Me.llbUpdate.TabIndex = 5
        Me.llbUpdate.TabStop = True
        Me.llbUpdate.Text = "更新"
        '
        'lbTips
        '
        Me.lbTips.AutoSize = True
        Me.lbTips.Location = New System.Drawing.Point(12, 337)
        Me.lbTips.Name = "lbTips"
        Me.lbTips.Size = New System.Drawing.Size(221, 12)
        Me.lbTips.TabIndex = 6
        Me.lbTips.Text = "双击条目可以单独配置，右键可弹出菜单"
        '
        'btnScan
        '
        Me.btnScan.Location = New System.Drawing.Point(199, 305)
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(117, 23)
        Me.btnScan.TabIndex = 8
        Me.btnScan.Text = "扫描添加..."
        Me.btnScan.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 358)
        Me.Controls.Add(Me.btnScan)
        Me.Controls.Add(Me.lbTips)
        Me.Controls.Add(Me.llbUpdate)
        Me.Controls.Add(Me.llbAbout)
        Me.Controls.Add(Me.btnDo)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.btnAddFile)
        Me.Controls.Add(Me.lvFileList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.cmsRight.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvFileList As ListView
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chSaveTo As ColumnHeader
    Friend WithEvents btnAddFile As Button
    Friend WithEvents ofdFileSelect As OpenFileDialog
    Friend WithEvents btnDefault As Button
    Friend WithEvents btnDo As Button
    Friend WithEvents chStatus As ColumnHeader
    Friend WithEvents cmsRight As ContextMenuStrip
    Friend WithEvents tsmiSetStatus As ToolStripMenuItem
    Friend WithEvents tsmiSetStatusUndone As ToolStripMenuItem
    Friend WithEvents tsmiSetStatusDone As ToolStripMenuItem
    Friend WithEvents tsmiDelete As ToolStripMenuItem
    Friend WithEvents temiCMD As ToolStripMenuItem
    Friend WithEvents tsmiCopy As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents tsmiSettings As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents llbAbout As LinkLabel
    Friend WithEvents llbUpdate As LinkLabel
    Friend WithEvents lbTips As Label
    Friend WithEvents btnScan As Button
End Class
