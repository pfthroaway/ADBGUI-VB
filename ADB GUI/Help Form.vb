Public Class frmHelp
    Private Sub ADB(sender As Object, e As EventArgs) Handles tabADB.Enter
        txtHelp.Text = "ADB"
    End Sub

    Private Sub Fastboot(sender As Object, e As EventArgs) Handles tabFastboot.Enter
        txtHelp.Text = "FASTBOOT"
    End Sub

    Private Sub General(sender As Object, e As EventArgs) Handles tabGeneral.Enter
        txtHelp.Text = "GENERAL"
    End Sub

    Private Sub Push(sender As Object, e As EventArgs) Handles tabPush.Enter
        txtHelp.Text = "PUSH"
    End Sub

    Private Sub Pull(sender As Object, e As EventArgs) Handles tabPull.Enter
        txtHelp.Text = "PULL"
    End Sub

    Private Sub Splash(sender As Object, e As EventArgs) Handles tabSplash.Enter
        txtHelp.Text = "SPLASH"
    End Sub

    Private Sub Logcat(sender As Object, e As EventArgs) Handles tabLogcat.Enter
        txtHelp.Text = "LOGCAT"
    End Sub

    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabHelp.Select()
    End Sub
End Class