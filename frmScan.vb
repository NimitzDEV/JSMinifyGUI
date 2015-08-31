Public Class frmScan
    Private Sub btnDir_Click(sender As Object, e As EventArgs) Handles btnDir.Click
        fbd.Description = "选择目录，确认后自动扫描"
        If fbd.ShowDialog = DialogResult.Cancel Then Exit Sub
        lbStatus.Text = "正在扫描..."
        lbFile.Items.Clear()
        Application.DoEvents()
        Try
            For Each ff As String In My.Computer.FileSystem.GetFiles(fbd.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.js")
                Try
                    lbFile.Items.Add(IO.Path.GetFileName(ff))
                Catch ex As Exception
                    Continue For
                End Try
            Next
            lbStatus.Text = "扫描结束"
        Catch ex As Exception
            lbStatus.Text = "扫描出错"
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lbFile_DoubleClick(sender As Object, e As EventArgs) Handles lbFile.DoubleClick
        If lbFile.SelectedIndex = -1 Then Exit Sub
        lbFile.Items.Remove(lbFile.SelectedItem)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        For i = 0 To lbFile.Items.Count - 1
            FrmMain.addFile(fbd.SelectedPath & "\" & lbFile.Items.Item(i))
        Next
        Me.Close()
    End Sub

End Class