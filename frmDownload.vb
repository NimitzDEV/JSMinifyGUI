Public Class frmDownload

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Network.DownloadFile("http://7u2omn.com1.z0.glb.clouddn.com/plugin/closure-compiler.jar", folderPath & "closure-compiler.jar", "", "", True, 20, True)
        If Dir(folderPath & "closure-compiler.jar") <> "" Then
            Me.Close()
        Else
            MsgBox("下载失败")
        End If
    End Sub
End Class