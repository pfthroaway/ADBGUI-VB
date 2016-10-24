Imports RegawMOD.Android                'required to access the class library
Imports System.IO
Imports System.IO.Compression

Public Class frmTabbed
    Dim android As AndroidController        'required to access ADB
    Dim device As Device                    'required to access devices
    Dim connectedDevices As New ArrayList   'arrayList of connected devices
    Dim nl As String = ControlChars.NewLine 'new line
    Dim currDevice As CDevice               'current device; used in arrayList
    Private WithEvents proc As Process
    Private Delegate Sub AppendStdOutDelegate(ByVal text As String)

    Private Sub addText(newText As String)
        Dim oldText As String = txtOutput.Text
        txtOutput.Text = newText & nl & oldText
    End Sub

    Private Function checkSelectedDevice() As Boolean
        If lstDevices.SelectedIndex >= 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    'Push File  
    Private Sub btnPushFile_Click(sender As Object, e As EventArgs) Handles btnPushFile.Click
        If device.PushFile(txtPushFileSource.Text, txtPushFileDest.Text) Then
            addText("Successfully pushed file.")
        Else
            addText("Failed to push file.")
        End If
    End Sub

    Private Sub btnBrowsePushFile_Click(sender As Object, e As EventArgs) Handles btnBrowsePushFile.Click
        Dim pushFile As OpenFileDialog = New OpenFileDialog
        pushFile.Title = "Please select the file to push to your device..."
        pushFile.SupportMultiDottedExtensions = True
        pushFile.Multiselect = False
        pushFile.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        If pushFile.ShowDialog = DialogResult.OK Then
            txtPushFileSource.Text = pushFile.FileName
        End If
    End Sub

    Private Sub txtPushFile_TextChanged(sender As Object, e As EventArgs) Handles txtPushFileSource.TextChanged, txtPushFileDest.TextChanged
        If checkSelectedDevice() Then
            If txtPushFileSource.TextLength > 0 AndAlso txtPushFileDest.TextLength > 0 Then
                btnPushFile.Enabled = True
            Else
                btnPushFile.Enabled = False
            End If
        Else
            btnPushFile.Enabled = False
        End If
    End Sub

    ' Push Directory  
    Private Sub txtPushDir_TextChanged(sender As Object, e As EventArgs) Handles txtPushDirSource.TextChanged, txtPushDirDest.TextChanged
        If checkSelectedDevice() Then
            If txtPushDirSource.TextLength > 0 AndAlso txtPushDirDest.TextLength > 0 Then
                btnPushDir.Enabled = True
            Else
                btnPushDir.Enabled = False
            End If
        Else
            btnPushDir.Enabled = False
        End If
    End Sub

    Private Sub btnPushDir_Click(sender As Object, e As EventArgs) Handles btnPushDir.Click
        If device.PushFile(txtPushDirSource.Text, txtPushDirDest.Text) Then
            addText("Successfully pushed directory.")
        Else
            addText("Failed to push directory.")
        End If
    End Sub

    Private Sub btnBrowsePushDir_Click(sender As Object, e As EventArgs) Handles btnBrowsePushDir.Click
        Dim pushDir As FolderBrowserDialog = New FolderBrowserDialog
        pushDir.Description = "Please select the folder to push to your device..."
        pushDir.RootFolder = My.Computer.FileSystem.CurrentDirectory
        pushDir.ShowNewFolderButton = True
        If pushDir.ShowDialog = DialogResult.OK Then
            txtPushFileDest.Text = pushDir.SelectedPath
        End If
    End Sub

    ' Pull Dir  
    Private Sub txtPullDir_TextChanged(sender As Object, e As EventArgs) Handles txtPullDirSource.TextChanged, txtPullDirDest.TextChanged
        If checkSelectedDevice() Then
            If txtPullDirSource.TextLength > 0 AndAlso txtPullDirDest.TextLength > 0 Then
                btnPullDir.Enabled = True
            Else
                btnPullDir.Enabled = False
            End If
        Else
            btnPullDir.Enabled = False
        End If
    End Sub

    Private Sub btnBrowsePullDir_Click(sender As Object, e As EventArgs) Handles btnBrowsePullDir.Click
        Dim pullDir As FolderBrowserDialog = New FolderBrowserDialog
        pullDir.Description = "Please select the folder to pull from your device..."
        pullDir.RootFolder = My.Computer.FileSystem.CurrentDirectory
        pullDir.ShowNewFolderButton = True
        If pullDir.ShowDialog = DialogResult.OK Then
            txtPullFileDest.Text = pullDir.SelectedPath
        End If
    End Sub

    Private Sub btnPullDir_Click(sender As Object, e As EventArgs) Handles btnPullDir.Click
        If device.PullDirectory(txtPushDirSource.Text, txtPushDirDest.Text) Then
            addText("Successfully pulled directory.")
        Else
            addText("Failed to pull directory.")
        End If
    End Sub

    'Pull File  
    Private Sub txtPullFile_TextChanged(sender As Object, e As EventArgs) Handles txtPullFileSource.TextChanged, txtPullFileDest.TextChanged
        If checkSelectedDevice() Then
            If txtPullFileSource.TextLength > 0 AndAlso txtPullFileDest.TextLength > 0 Then
                btnPullFile.Enabled = True
            Else
                btnPullFile.Enabled = False
            End If
        Else
            btnPullFile.Enabled = False
        End If
    End Sub

    Private Sub btnPullFile_Click(sender As Object, e As EventArgs) Handles btnPullFile.Click
        If device.PullFile(txtPushFileSource.Text, txtPushFileDest.Text) Then
            addText("Successfully pulled file.")
        Else
            addText("Failed to pull file.")
        End If
    End Sub
    Private Sub btnBrowsePullFile_Click(sender As Object, e As EventArgs) Handles btnBrowsePullFile.Click
        Dim pullFile As OpenFileDialog = New OpenFileDialog
        pullFile.Title = "Please select the file to pull to your device..."
        pullFile.SupportMultiDottedExtensions = True
        pullFile.Multiselect = False
        pullFile.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        If pullFile.ShowDialog = DialogResult.OK Then
            txtPullFileSource.Text = pullFile.FileName
        End If
    End Sub
End Class