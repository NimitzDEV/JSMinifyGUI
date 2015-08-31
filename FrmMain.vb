Public Class FrmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName & "-" & Application.ProductVersion
        ReadSettings()
        If Not FileIO.FileSystem.FileExists(folderPath & "closure-compiler.jar") Then
            frmDownload.ShowDialog()
            frmDownload.Dispose()
        End If
    End Sub

    Private Sub btnAddFile_Click(sender As Object, e As EventArgs) Handles btnAddFile.Click
        ofdFileSelect.Filter = "JavaScript|*.js"
        If ofdFileSelect.ShowDialog() = DialogResult.Cancel Then Exit Sub
        For Each files In ofdFileSelect.FileNames
            addFile(files)
        Next
        freshList()
    End Sub

    Public Sub addFile(fileName As String)
        Dim fileItem As New FileSettings
        fileItem.fileDest = fileName
        fileItem.fileName = IO.Path.GetFileName(fileName)
        fileItem.saveTo = IIf(defaultSetting.saveTo.Trim = "", IO.Path.GetDirectoryName(fileName) & "\" & IO.Path.GetFileNameWithoutExtension(fileName) & ".min" & IO.Path.GetExtension(fileName), defaultSetting.saveTo & IO.Path.GetFileNameWithoutExtension(fileName) & ".min" & IO.Path.GetExtension(fileName))
        fileItem.opLevel = defaultSetting.opLevel
        fileItem.enableECMA = defaultSetting.enableECMA
        fileItem.EcmascriptVersion = defaultSetting.EcmascriptVersion
        fileItem.fileStatus = "未处理"
        fileItem.cstParameters = defaultSetting.cstParameters
        settingsList.Add(fileItem)
    End Sub

    Private Sub freshList()
        lvFileList.Items.Clear()
        For Each fileInfo As FileSettings In settingsList
            Dim listInfo As New ListViewItem
            listInfo.Text = fileInfo.fileName
            listInfo.SubItems.Add(fileInfo.saveTo)
            listInfo.SubItems.Add(fileInfo.fileStatus)
            If fileInfo.fileStatus = "已完成" Then
                listInfo.BackColor = Color.LawnGreen
            ElseIf fileInfo.fileStatus = "错误" Then
                listInfo.BackColor = Color.OrangeRed
            End If
            lvFileList.Items.Add(listInfo)
        Next
    End Sub

    Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveSettings()
    End Sub

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        selectIndex = -1
        frmSettings.ShowDialog()
        frmSettings.Dispose()
    End Sub

    Private Sub lvFileList_DoubleClick(sender As Object, e As EventArgs) Handles lvFileList.DoubleClick
        If lvFileList.SelectedItems.Count = 0 Then Exit Sub
        selectIndex = lvFileList.SelectedItems(0).Index
        frmSettings.ShowDialog()
        frmSettings.Dispose()
        freshList()
    End Sub

    Private Sub btnDo_Click(sender As Object, e As EventArgs) Handles btnDo.Click
        If lvFileList.Items.Count <> 0 Then
            frmProcess.ShowDialog()
            frmProcess.Dispose()
            freshList()
        Else
            btnAddFile.PerformClick()
        End If
    End Sub

    Private Sub lvFileList_MouseClick(sender As Object, e As MouseEventArgs) Handles lvFileList.MouseClick
        If e.Button <> MouseButtons.Right Then Exit Sub
        If lvFileList.SelectedItems.Count = 0 Then
            cmsRight.Enabled = False
        Else
            cmsRight.Enabled = True
        End If
        cmsRight.Show(MousePosition)
    End Sub

    Private Sub tsmiSettings_Click(sender As Object, e As EventArgs) Handles tsmiSettings.Click
        If lvFileList.SelectedItems.Count = 0 Then Exit Sub
        selectIndex = lvFileList.SelectedItems(0).Index
        frmSettings.ShowDialog()
        frmSettings.Dispose()
        freshList()
    End Sub

    Private Sub tsmiSetStatusUndone_Click(sender As Object, e As EventArgs) Handles tsmiSetStatusUndone.Click
        lvFileList.SelectedItems(0).SubItems(2).Text = "未处理"
        lvFileList.SelectedItems(0).BackColor = Color.White
        settingsList(lvFileList.SelectedItems(0).Index).fileStatus = "未处理"
    End Sub

    Private Sub tsmiSetStatusDone_Click(sender As Object, e As EventArgs) Handles tsmiSetStatusDone.Click
        lvFileList.SelectedItems(0).SubItems(2).Text = "已完成"
        lvFileList.SelectedItems(0).BackColor = Color.LawnGreen
        settingsList(lvFileList.SelectedItems(0).Index).fileStatus = "已完成"
    End Sub

    Private Sub tsmiDelete_Click(sender As Object, e As EventArgs) Handles tsmiDelete.Click
        settingsList.Remove(settingsList(lvFileList.SelectedItems(0).Index))
        lvFileList.SelectedItems(0).Remove()
    End Sub

    Private Sub tsmiCopy_Click(sender As Object, e As EventArgs) Handles tsmiCopy.Click
        Clipboard.Clear()
        Clipboard.SetText("java " & getCmd(settingsList(lvFileList.SelectedItems(0).Index)))
    End Sub

    Private Sub temiCMD_Click(sender As Object, e As EventArgs) Handles temiCMD.Click
        FileOpen(1, folderPath & "test.bat", OpenMode.Output)
        Print(1, "@echo off" & vbCrLf)
        Print(1, "java " & getCmd(settingsList(lvFileList.SelectedItems(0).Index)) & vbCrLf)
        Print(1, "pause")
        FileClose(1)
        Process.Start(folderPath & "test.bat")
    End Sub

    Private Sub llbAbout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbAbout.LinkClicked
        frmAbout.ShowDialog()
    End Sub

    Private Sub llbUpdate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbUpdate.LinkClicked
        frmUpdate.ShowDialog()
        frmUpdate.Dispose()
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        frmScan.ShowDialog()
        frmScan.Dispose()
        freshList()
    End Sub
End Class