Module mdCommandLine
    Public Function getCmd(ByRef obj As FileSettings) As String
        Dim ecma As String = ""
        Dim level As String = ""
        If obj.enableECMA Then
            ecma = " --language_in " & ecmaVersion(obj.EcmascriptVersion)
        End If
        level = " --compilation_level " & opLevelVal(obj.opLevel)
        Return "-jar """ & folderPath & "closure-compiler.jar""" & ecma & level & " " & obj.cstParameters & " --js """ & obj.fileDest & """ --js_output_file """ & obj.saveTo & """"
    End Function
End Module
