Public Class frmProcess
    Dim err As Boolean = False
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        If checkJava() Then
            processFiles()
        Else
            Me.Close()
        End If
    End Sub

    Private Function checkJava() As Boolean
        Try
            runJava("")
            Return True
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "请确认 Java 已经正确安装")
            Return False
        End Try
    End Function

    Private Sub btnAction_Click(sender As Object, e As EventArgs) Handles btnAction.Click
        Me.Close()
    End Sub

    Private Sub processFiles()
        Dim cmd As String = ""
        Dim nowR As Integer = 0
        Dim ask As String
        pbProgress.Maximum = settingsList.Count
        For Each fileInfo As FileSettings In settingsList
            pbProgress.Value += 1
            Me.Text = "正在处理... " & String.Format("{0:000.00}", pbProgress.Value / pbProgress.Maximum * 100) & "%"
            lbNow.Text = "正在处理文件：" & fileInfo.fileName
            Application.DoEvents()
            '处理重复
            If Dir(fileInfo.saveTo) <> "" Then
                ask = "文件已经存在，是否覆盖？" & vbCrLf _
                    & "源文件：" & fileInfo.fileDest & fileInfo.fileName & vbCrLf &
                    "目标文件：" & fileInfo.saveTo & vbCrLf &
                    "----------------------------" & vbCrLf &
                    "点击 是 覆盖文件" & vbCrLf & "点击 否 跳过"
                If MsgBox(ask, MsgBoxStyle.YesNo, "文件覆盖") = MsgBoxResult.No Then
                    nowR += 1
                    Continue For
                End If
            End If
            If fileInfo.fileStatus = "已完成" Then
                nowR += 1
                Continue For
            End If
            runJava(getCmd(fileInfo))
            Debug.Print(cmd)
            If Dir(fileInfo.saveTo) = "" Then
                settingsList(nowR).fileStatus = "错误"
                err = True
            Else
                settingsList(nowR).fileStatus = "已完成"
            End If
            nowR += 1
        Next
        Me.Text = "处理完成"
        If err Then MsgBox("部分文件处理失败，右键选择在CMD中执行可以查看详细信息")
        Me.Close()
    End Sub

End Class