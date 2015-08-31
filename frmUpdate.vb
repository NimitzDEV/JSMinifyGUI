Imports System.IO
Imports System.Security.Cryptography
Imports Microsoft.VisualBasic.FileIO.FileSystem
Public Class frmUpdate
    Private fileDld As Net.WebClient
    Dim trdBGTrd As System.Threading.Thread
    Dim newVersion As String
    Dim compilerHash As String
    Dim detailLink As String
    Dim downloadLink As String
    Dim compilerLink As String
    Private Delegate Sub VoidDelegate()
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        udCfgDownloadStarter()
        lbVersion.Text = "当前版本：" & Application.ProductVersion
    End Sub

    Public Sub downloadFile(ByVal Url As String, ByVal Path As String)
        Try
            fileDld = New Net.WebClient
            fileDld.DownloadFile(New Uri(Url), Path)
        Catch ex As Exception
            MsgBox("获取更新信息失败，稍后再试？")
        End Try
    End Sub

    Public Sub udCfgDownloadStarter()
        If DirectoryExists(folderPath) = False Then MkDir(folderPath)
        trdBGTrd = New Threading.Thread(New System.Threading.ThreadStart(AddressOf udCfg))
        trdBGTrd.Start()
    End Sub

    Private Sub udCfg()
        downloadFile("http://dl.nimitzdev.org/ud/ud_jsmgui.ini", folderPath & "ud.ini")
        compilerHash = GetHash(folderPath & "closure-compiler.jar", "md5")
        Me.Invoke(New VoidDelegate(AddressOf dectect))
    End Sub

    Private Sub frmUpdate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        trdBGTrd.Abort()
        Try
            DeleteFile(folderPath & "ud.ini")
        Catch
        End Try
    End Sub

    Private Sub dectect()
        Try
            If FileExists(folderPath & "ud.ini") Then
                detailLink = GetINI("ud", "details", "", "ud.ini")
                downloadLink = GetINI("ud", "download", "", "ud.ini")
                compilerLink = GetINI("ud", "compilerlink", "", "ud.ini")
                If String.Compare(GetINI("ud", "hash", "", "ud.ini").Trim, compilerHash, True) = 0 Then
                    lbCompilerVersion.Text = "Closure Compiler 为最新版"
                Else
                    lbCompilerVersion.Text = "Closure Compiler 有新版本"
                    lbCompilerVersion.ForeColor = Color.Green
                    If compilerLink <> "" Then btnUpdateCompiler.Enabled = True
                End If
                newVersion = GetINI("ud", "ver", "", "ud.ini")
                If isNew(newVersion) Then
                    lbNewVersion.Text = "有新版本：" & newVersion
                    lbNewVersion.ForeColor = Color.Green
                    If detailLink <> "" Then btnDe.Enabled = True
                    If downloadLink <> "" Then btnDl.Enabled = True
                Else
                    lbNewVersion.Text = "当前已是最新版本"
                    lbNewVersion.ForeColor = Color.Green
                End If
            End If
        Catch ex As Exception
            MsgBox("获取更新信息失败" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Function isNew(ByVal versionString As String) As Boolean
        For i = 0 To 3
            If Int(Split(versionString, ".")(i)) > Int(Split(Application.ProductVersion, ".")(i)) Then
                Return True
            ElseIf Int(Split(versionString, ".")(i)) < Int(Split(Application.ProductVersion, ".")(i)) Then
                Return False
            End If
        Next
        Return False
    End Function

    Private Function ConvertByteArrayToHex(ByVal bytArray() As Byte) As String
        Dim strReturn As String = ""
        Dim intByteCounter As Integer
        For intByteCounter = 0 To bytArray.Length - 1
            strReturn += bytArray(intByteCounter).ToString("X2")
        Next intByteCounter
        Return strReturn.ToLower
    End Function

    Private Function GetHash(ByVal strFile As String, ByVal strType As String) As String
        Dim objInstance As Object
        Dim bytHash() As Byte
        Dim objFileStream As FileStream
        Dim strReturn As String = ""
        If File.Exists(strFile) = False Then
            Return ""
            Exit Function
        End If
        Try
            objInstance = MD5.Create
        Catch ex As Exception
            Return ""
            Exit Function
        End Try
        Try
            objFileStream = File.OpenRead(strFile)
            objFileStream.Position = 0
        Catch ex As Exception
            MsgBox(ex.Message.ToString, vbCritical, "File Read Error!")
            Return ""
            Exit Function
        End Try
        bytHash = objInstance.ComputeHash(objFileStream)
        strReturn = ConvertByteArrayToHex(bytHash)
        Return strReturn
    End Function

    Private Sub btnDe_Click(sender As Object, e As EventArgs) Handles btnDe.Click
        Process.Start(detailLink)
    End Sub

    Private Sub btnDl_Click(sender As Object, e As EventArgs) Handles btnDl.Click
        Process.Start(downloadLink)
    End Sub

    Private Sub btnUpdateCompiler_Click(sender As Object, e As EventArgs) Handles btnUpdateCompiler.Click
        DeleteFile(folderPath & "closure-compiler.jar")
        My.Computer.Network.DownloadFile(compilerLink, folderPath & "closure-compiler.jar", "", "", True, 20, True)
    End Sub
End Class