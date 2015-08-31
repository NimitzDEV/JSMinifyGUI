Public Class frmAbout
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://nimitzdev.org")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://developers.google.com/closure/compiler")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://github.com/NimitzDEV/JSMinifyGUI")
    End Sub

    Private Sub llbIcon_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbIcon.LinkClicked
        Process.Start("https://github.com/alecive/FlatWoken")
    End Sub
End Class