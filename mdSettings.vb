Imports System.IO
Imports Microsoft.VisualBasic.FileIO.FileSystem
Module mdSettings
    Public folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\NimitzDEV\JSMinify\"
    Public selectIndex As Integer = -1
    Public opLevelVal() As String = {"WHITESPACE_ONLY", "SIMPLE_OPTIMIZATIONS", "ADVANCED_OPTIMIZATIONS"}
    Public ecmaVersion() As String = {"ECMASCRIPT3", "ECMASCRIPT5", "ECMASCRIPT5_STRICT"}
    '====
    Public Class FileSettings
        Public Property opLevel As Integer
        Public Property EcmascriptVersion As Integer
        Public Property enableECMA As Boolean
        Public Property cstParameters As String
        'CM
        Public Property saveTo As String
        Public Property fileName As String
        Public Property fileDest As String
        Public Property fileStatus As String
    End Class
    Public settingsList As New List(Of FileSettings)
    Public defaultSetting As New FileSettings
    '====
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32

    Public Sub ReadSettings()
        If DirectoryExists(folderPath) = False Then MkDir(folderPath)
        defaultSetting.opLevel = GetINI("Default", "Level", 0)
        defaultSetting.saveTo = GetINI("Default", "SaveTo", "")
        defaultSetting.enableECMA = GetINI("Default", "EnableSpcECMAVersion", False)
        defaultSetting.EcmascriptVersion = GetINI("Default", "SpcECMAScriptVersion", 3)
        defaultSetting.cstParameters = GetINI("Default", "CustomParameters", "")
        If defaultSetting.opLevel > opLevelVal.Count - 1 Then defaultSetting.opLevel = 0
        If defaultSetting.EcmascriptVersion > ecmaVersion.Count - 1 Then defaultSetting.EcmascriptVersion = 0
        defaultSetting.fileName = ""
    End Sub
    Public Sub SaveSettings()
        If DirectoryExists(folderPath) = False Then MkDir(folderPath)
        WriteINI("Default", "Level", defaultSetting.opLevel)
        WriteINI("Default", "SaveTo", defaultSetting.saveTo)
        WriteINI("Default", "EnableSpcECMAVersion", defaultSetting.enableECMA)
        WriteINI("Default", "SpcECMAScriptVersion", defaultSetting.EcmascriptVersion)
        WriteINI("Default", "CustomParameters", defaultSetting.cstParameters)
    End Sub
    Public Function GetINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, Optional ByVal iniName As String = "\config.ini") As String
        If FileExists(folderPath & "config.ini") = False Then Return lpDefault
        Dim Str As String = ""
        Str = LSet(Str, 256)
        GetPrivateProfileString(Section, AppName, lpDefault, Str, Len(Str), folderPath & iniName)
        Return Left(Str, InStr(Str, Chr(0)) - 1)
    End Function

    Public Function WriteINI(ByVal Section As String, ByVal AppName As String, ByVal lpDefault As String, Optional ByVal iniName As String = "\config.ini") As Long
        WriteINI = WritePrivateProfileString(Section, AppName, lpDefault, folderPath & iniName)
    End Function

    Public Sub runJava(Optional ByVal cmd As String = "", Optional ByVal stg As String = "java.exe", Optional ByVal nsWin As Boolean = True)
        Try
            Using P As New Process()
                P.StartInfo.FileName = stg
                P.StartInfo.Arguments = cmd
                P.StartInfo.UseShellExecute = False
                P.StartInfo.RedirectStandardOutput = True
                P.StartInfo.CreateNoWindow = nsWin
                P.Start()
                P.WaitForExit()
                P.Close()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Module
