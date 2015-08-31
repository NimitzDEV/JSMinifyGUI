Public Class frmSettings
    Dim opSettings As New FileSettings
    Dim opLevel As Integer = 0
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If selectIndex = -1 Then
            opSettings = defaultSetting
            Me.Text = "修改默认设置"
            lbPath.Text = "默认保存路径（留空则为原目录）："
        Else
            opSettings = settingsList(selectIndex)
            Me.Text = opSettings.fileName & " - " & "修改文件设置"
        End If
        'LOAD 
        tbCstCmd.Text = opSettings.cstParameters
        tbFileLocation.Text = opSettings.fileDest
        lbFileName.Text = "文件名：" & opSettings.fileName
        tbPath.Text = IIf(opSettings.saveTo.Trim = "", "", opSettings.saveTo)
        Select Case opSettings.opLevel
            Case 0
                rbLevel1.Checked = True
            Case 1
                rbLevel2.Checked = True
            Case 2
                rbLevel3.Checked = True
            Case Else
                rbLevel1.Checked = True
        End Select
        cbEVersion.Checked = opSettings.enableECMA
        cbECMAList.Enabled = cbEVersion.Checked
        For i = 0 To ecmaVersion.Count - 1
            cbECMAList.Items.Add(ecmaVersion(i))
        Next
        cbECMAList.SelectedIndex = opSettings.EcmascriptVersion
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        opSettings.saveTo = tbPath.Text
        opSettings.fileName = IO.Path.GetFileName(tbPath.Text)
        opSettings.opLevel = opLevel
        opSettings.EcmascriptVersion = cbECMAList.SelectedIndex
        opSettings.enableECMA = cbEVersion.Checked
        opSettings.cstParameters = tbCstCmd.Text.Trim
        If selectIndex <> -1 Then settingsList(selectIndex) = opSettings
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        fbdFolder.Description = "请选择保存位置"
        If fbdFolder.ShowDialog = DialogResult.Cancel Then Exit Sub
        tbPath.Text = fbdFolder.SelectedPath & "\" & opSettings.fileName
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://developers.google.com/closure/compiler/docs/api-tutorial3")
    End Sub

    Private Sub rbLevel1_CheckedChanged(sender As Object, e As EventArgs) Handles rbLevel1.CheckedChanged
        opLevel = 0
    End Sub

    Private Sub rbLevel2_CheckedChanged(sender As Object, e As EventArgs) Handles rbLevel2.CheckedChanged
        opLevel = 1
    End Sub

    Private Sub rbLevel3_CheckedChanged(sender As Object, e As EventArgs) Handles rbLevel3.CheckedChanged
        opLevel = 2
    End Sub

    Private Sub cbEVersion_CheckedChanged(sender As Object, e As EventArgs) Handles cbEVersion.CheckedChanged
        cbECMAList.Enabled = cbEVersion.Checked
    End Sub
End Class