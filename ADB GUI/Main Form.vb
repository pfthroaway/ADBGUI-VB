' Project Name:         ADB GUI
' Project Version:      Beta 1
' Project Creator:
' Project Description:  This project allows basic ADB functions from a GUI.


Imports RegawMOD.Android        'required to access the AndroidLib class library
Imports System.IO               'required for StringReader
Imports System.IO.Compression   'required for zipping files



Public Class frmMain
    Public android As AndroidController         'required to access ADB
    Dim device As Device                        'required to access devices
    Dim connectedDevices As New ArrayList       'arrayList of connected devices
    Dim nl As String = ControlChars.NewLine     'new line
    Dim currDevice As ConnectedDevice = New ConnectedDevice 'current device; used in arrayList
    Private WithEvents proc As Process
    Private Delegate Sub AppendStdOutDelegate(ByVal text As String)
    Dim tt As New ToolTip

#Region "Check ADB Commands"
    Private Sub checkADBCommand()
        If txtADBCommand.TextLength > 0 AndAlso currDevice.connectionStatus <> DeviceState.FASTBOOT Then
            btnADBCommand.Enabled = True
        Else
            btnADBCommand.Enabled = False
        End If
    End Sub

    Private Sub checkADBShellCommand()
        If txtADBShellCommand.TextLength > 0 AndAlso currDevice.connectionStatus <> DeviceState.FASTBOOT Then
            btnADBShellCommand.Enabled = True
        Else
            btnADBShellCommand.Enabled = False
        End If
    End Sub

    Private Sub checkPushFile()
        If txtPushFileSource.TextLength > 0 AndAlso txtPushFileDest.TextLength > 0 AndAlso currDevice.connectionStatus <> DeviceState.FASTBOOT Then
            btnPushFile.Enabled = True
        Else
            btnPushFile.Enabled = False
        End If
    End Sub

    Private Sub checkPushDir()
        If txtPushDirSource.TextLength > 0 AndAlso txtPushDirDest.TextLength > 0 AndAlso currDevice.connectionStatus <> DeviceState.FASTBOOT Then
            btnPushDir.Enabled = True
        Else
            btnPushDir.Enabled = False
        End If
    End Sub

    Private Sub checkPullFile()
        If txtPullFileSource.TextLength > 0 AndAlso txtPullFileDest.TextLength > 0 AndAlso currDevice.connectionStatus <> DeviceState.FASTBOOT Then
            btnPullFile.Enabled = True
        Else
            btnPullFile.Enabled = False
        End If
    End Sub

    Private Sub checkPullDir()
        If txtPullDirSource.TextLength > 0 AndAlso txtPullDirDest.TextLength > 0 AndAlso currDevice.connectionStatus <> DeviceState.FASTBOOT Then
            btnPullDir.Enabled = True
        Else
            btnPullDir.Enabled = False
        End If
    End Sub

    Private Sub checkRemount()
        If device.HasRoot AndAlso currDevice.connectionStatus <> DeviceState.FASTBOOT Then
            btnRemount.Enabled = True
        Else
            btnRemount.Enabled = False
        End If
    End Sub

    Private Sub checkSU()
        If currDevice.hasRoot() Then
            chkSU.Enabled = True
        Else
            chkSU.Enabled = False
        End If
    End Sub
#End Region

    ''' <summary>
    ''' This method adds text to the txtOutput TextBox.
    ''' </summary>
    ''' <param name="newText">Text to be added to the Textbox.</param>
    ''' <remarks></remarks>
    Private Sub addText(newText As String)
        Dim oldText As String = txtOutput.Text
        If newText.StartsWith("Android Debug Bridge") Then
            txtOutput.Text = "Invalid command." & nl & nl & oldText
        Else
            txtOutput.Text = newText & nl & nl & oldText
        End If

        txtOutput.Select(0, 0)
        txtOutput.ScrollToCaret()
    End Sub

    ''' <summary>
    ''' This method reboots the device from regular Fastboot to the Rom Update Utility.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub rebootRUU()
        Dim fbCmd As FastbootCommand
        fbCmd = Fastboot.FormFastbootCommand("-s " & currDevice.serial & " oem rebootRUU")
        addText(Fastboot.ExecuteFastbootCommand(fbCmd))
        MessageBox.Show("Your phone will now load the Rom Update Utility which, among other things, allows flashing of splash images and custom zip files. When the RUU has loaded on your device, press OK.", "ADB GUI", MessageBoxButtons.OK)

    End Sub

    ''' <summary>
    ''' This method displays the selected device's information.
    ''' </summary>
    ''' <param name="modelNum">The model number determines what information is displayed.</param>
    ''' <remarks></remarks>
    Private Sub displayDeviceInfo(ByVal modelNum As String)
        Select Case modelNum
            Case "Nexus 6", "shamu"
                currDevice = New ConnectedDevice(device.SerialNumber, device.State, "Nexus 6", "shamu", "Motorola", "", "1440x2560", device.HasRoot, False, ADB_GUI.My.Resources.Nexus6)
            Case "ADR6300", "incrediblec"
                currDevice = New ConnectedDevice(device.SerialNumber, device.State, "Droid Incredible", "ADR6300", "HTC", "", "480x800", device.HasRoot, False, ADB_GUI.My.Resources.Incredible)
            Case "ADR6410LVW", "fireball"
                currDevice = New ConnectedDevice(device.SerialNumber, device.State, "Droid Incredible 4G LTE", "ADR6410LVW", "HTC", "mmcblk0p14", "540x960", device.HasRoot, True, ADB_GUI.My.Resources.Incredible4G)
            Case "HTC6500LVW", "m7_wlv"
                currDevice = New ConnectedDevice(device.SerialNumber, device.State, "One", "HTC6500LVW", "HTC", "mmcblk0p13", "1080x1920", device.HasRoot, True, ADB_GUI.My.Resources.HTCOne)
            Case "SCH-I535"
                currDevice = New ConnectedDevice(device.SerialNumber, device.State, "Galaxy S III", "SCH-I535", "Samsung", "", "720x1280", device.HasRoot, False, ADB_GUI.My.Resources.GalaxyS3)
            Case "HTC One_M8", "m8_ul"
                currDevice = New ConnectedDevice(device.SerialNumber, device.State, "One (M8)", "M8", "HTC", "mmcblk0p12", "1080x1920", device.HasRoot, True, ADB_GUI.My.Resources.M8)
            Case "SCH-I545"
                currDevice = New ConnectedDevice(device.SerialNumber, device.State, "Galaxy S 4", "SCH-I545", "Samsung", "", "1080x1920", device.HasRoot, False, ADB_GUI.My.Resources.S4)
            Case Else
                currDevice = New ConnectedDevice(device.SerialNumber, device.State, "Unknown", modelNum, "Unknown", "", "Unknown", device.HasRoot, False, ADB_GUI.My.Resources.clear)
        End Select

        lblManuName.Text = currDevice.manufacturerName
        lblModelName.Text = currDevice.modelName
        pctDevice.Image = currDevice.image
    End Sub

    ''' <summary>
    ''' This method gets the model number when a device is in Fastboot.
    ''' </summary>
    ''' <param name="parseString">This string is parsed to retrieve the model number.</param>
    ''' <returns>Returns model number.</returns>
    ''' <remarks></remarks>
    Private Function getFastbootModelNum(ByVal parseString As String) As String
        Dim s As StringReader = New StringReader(parseString)
        Dim line As String

        While s.Peek() <> -1

            line = s.ReadLine()

            If line.Contains("product") Then
                Return line
                Exit Function
            End If
        End While

        Return "Could not determine device."
    End Function

    ''' <summary>
    ''' This method gets the model number of the selected device.
    ''' </summary>
    ''' <param name="serial">This is the selected device's serial number.</param>
    ''' <returns>Returns model number.</returns>
    ''' <remarks></remarks>
    Private Async Function getModelNum(ByVal serial As String) As Task(Of Boolean)
        Dim modelNum As String = ""
        Await Task.Factory.StartNew(Sub()
                                        device = android.GetConnectedDevice(serial)

                                        If device.State <> DeviceState.FASTBOOT Then
                                            Dim shellCmd As AdbCommand = Adb.FormAdbShellCommand(device, False, "cat", "/system/build.prop | grep product.model")
                                            Dim line As String = Adb.ExecuteAdbCommand(shellCmd)

                                            line = line.Substring(line.IndexOf("=") + 1).Trim()
                                            Dim s As StringReader = New StringReader(line)
                                            modelNum = s.ReadLine
                                        Else
                                            Dim fbCmd As FastbootCommand = Fastboot.FormFastbootCommand("-s " & device.SerialNumber & " getvar all")
                                            modelNum = getFastbootModelNum(Fastboot.ExecuteFastbootCommand(fbCmd))
                                            modelNum = modelNum.Substring(modelNum.IndexOf(": ") + 2).Trim()
                                        End If
                                    End Sub)
        displayDeviceInfo(modelNum)
        Return True
    End Function

    ''' <summary>
    ''' This method unselects the selected item in the lstDevices Listbox.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearSelection()
        lstDevices.ClearSelected()
        lblManuName.Text = ""
        lblModelName.Text = ""
        pctDevice.Image = My.Resources.clear
        currDevice = New ConnectedDevice
    End Sub

    ''' <summary>
    ''' This method updates the internal device list.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateDeviceList()
        Dim deviceList As String
        Dim adbDevices As String
        deviceList = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("devices"))
        connectedDevices.Clear()
        lstDevices.Items.Clear()
        disableADB()
        disableFastboot()

        If deviceList.Contains("device") OrElse deviceList.Contains("recovery") OrElse deviceList.Contains("bootloader") Then
            While deviceList.Contains(" & ")
                deviceList.Remove(0, deviceList.IndexOf(" & ") + 1)
            End While
            Dim s As StringReader = New StringReader(deviceList)
            Dim line As String

            While s.Peek() <> -1

                line = s.ReadLine()

                If line.StartsWith("List") OrElse line.StartsWith("vbCrLf") OrElse line.Trim() = "" Then
                    'do nothing
                Else
                    adbDevices = line.Substring(0, line.IndexOf("	"))
                    line = line.Substring(line.IndexOf("	") + 1)
                    Dim newDevice As New ConnectedDevice(adbDevices, line)
                    connectedDevices.Add(newDevice)
                End If
            End While
        End If

        deviceList = Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand("devices"))
        Dim fastbootDevices As String

        If (deviceList.Length > 0) Then
            Dim s As StringReader = New StringReader(deviceList)
            Dim line As String

            While s.Peek() <> -1

                line = s.ReadLine()

                If line.StartsWith("List") OrElse line.StartsWith("	") OrElse line.Trim() = "" Then
                    'do nothing
                Else
                    If (line.IndexOf("	") <> -1) Then
                        line = line.Substring(0, line.IndexOf("	"))
                        fastbootDevices = line
                        Dim newDevice As New ConnectedDevice(fastbootDevices, "fastboot")
                        connectedDevices.Add(newDevice)
                    End If
                End If
            End While
        End If

        For i As Integer = 0 To connectedDevices.Count - 1
            lstDevices.Items.Add(connectedDevices(i).serial & " - " & connectedDevices(i).connectionStatus)
        Next

    End Sub

    ''' <summary>
    ''' This method removes the selected item in the lstDevices Listbox.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub removeSelected()
        connectedDevices.Remove(lstDevices.SelectedIndex)
        lstDevices.Items.RemoveAt(lstDevices.SelectedIndex)
        disableADB()
        disableFastboot()
        clearSelection()
    End Sub

    ''' <summary>
    ''' This method determines whether there is a selected device.
    ''' </summary>
    ''' <returns>Returns true if a device is selected.</returns>
    ''' <remarks></remarks>
    Private Function checkSelectedDevice() As Boolean
        If lstDevices.SelectedIndex >= 0 Then
            Return True
        Else
            Return False
        End If
    End Function

#Region "Enable/Disable Buttons"
    Private Sub disableADB()
        btnReboot.Enabled = False
        btnBootloader.Enabled = False
        btnRecovery.Enabled = False
        btnADBCommand.Enabled = False
        btnADBShellCommand.Enabled = False
        btnRemount.Enabled = False
        btnPushFile.Enabled = False
        btnPushDir.Enabled = False
        btnPullDir.Enabled = False
        btnPullFile.Enabled = False
        btnBackupSplash.Enabled = False
        chkSU.Checked = False
    End Sub

    Private Sub disableFastboot()
        btnFastbootReboot.Enabled = False
        btnFlashRecovery.Enabled = False
        btnFlashSplash.Enabled = False
        btnFastbootBootloader.Enabled = False
        btnCustomFastboot.Enabled = False
        btnCustomZip.Enabled = False
    End Sub

    Private Sub enableADB()
        btnReboot.Enabled = True
        btnBootloader.Enabled = True
        btnRecovery.Enabled = True

        checkADBCommand()
        checkADBShellCommand()
        checkPushFile()
        checkPushDir()
        checkPullFile()
        checkPullDir()
        checkRemount()
        checkSU()
        checkBackupSplash()
    End Sub

    Private Sub enableFastboot()
        btnFastbootReboot.Enabled = True
        btnFastbootBootloader.Enabled = True
        checkFlashSplash()
        checkCustomFastboot()
        btnCustomZip.Enabled = True
    End Sub
#End Region

#Region "Push File"
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
            checkPushFile()
        End If
    End Sub
#End Region

#Region "Push Directory"
    Private Sub txtPushDir_TextChanged(sender As Object, e As EventArgs) Handles txtPushDirSource.TextChanged, txtPushDirDest.TextChanged
        If checkSelectedDevice() Then
            checkPushDir()
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
        pushDir.SelectedPath = My.Computer.FileSystem.CurrentDirectory
        pushDir.Description = "Please select the folder to push to your device..."
        pushDir.ShowNewFolderButton = True
        If pushDir.ShowDialog = DialogResult.OK Then
            txtPushDirSource.Text = pushDir.SelectedPath
        End If
    End Sub
#End Region

#Region "Pull Directory"
    Private Sub txtPullDir_TextChanged(sender As Object, e As EventArgs) Handles txtPullDirDest.TextChanged, txtPullDirSource.TextChanged
        If checkSelectedDevice() Then
            checkPullDir()
        End If
    End Sub

    Private Sub btnBrowsePullDir_Click(sender As Object, e As EventArgs) Handles btnBrowsePullDir.Click
        Dim pullDir As FolderBrowserDialog = New FolderBrowserDialog
        pullDir.Description = "Please select the destination for the directory you are attempting to pull from your device..."
        pullDir.SelectedPath = My.Computer.FileSystem.CurrentDirectory
        pullDir.ShowNewFolderButton = True
        If pullDir.ShowDialog = DialogResult.OK Then
            txtPullDirDest.Text = pullDir.SelectedPath
        End If
    End Sub

    Private Sub btnPullDir_Click(sender As Object, e As EventArgs) Handles btnPullDir.Click
        If device.PullDirectory(txtPullDirSource.Text, txtPullDirDest.Text) Then
            addText("Successfully pulled directory.")
        Else
            addText("Failed to pull directory.")
        End If
    End Sub
#End Region

#Region "Pull File"
    Private Sub txtPullFile_TextChanged(sender As Object, e As EventArgs) Handles txtPullFileDest.TextChanged, txtPullFileSource.TextChanged
        If checkSelectedDevice() Then
            checkPullFile()
        End If
    End Sub

    Private Sub btnPullFile_Click(sender As Object, e As EventArgs) Handles btnPullFile.Click
        If device.PullFile(txtPullFileSource.Text, txtPullFileDest.Text) Then
            addText("Successfully pulled file.")
        Else
            addText("Failed to pull file.")
        End If
    End Sub

    Private Sub btnBrowsePullFile_Click(sender As Object, e As EventArgs) Handles btnBrowsePullFile.Click
        Dim pullFileDest As FolderBrowserDialog = New FolderBrowserDialog
        pullFileDest.SelectedPath = My.Computer.FileSystem.CurrentDirectory
        pullFileDest.Description = "Please select the destination for the file you are attempting to pull from your device..."
        pullFileDest.ShowNewFolderButton = True
        If pullFileDest.ShowDialog = DialogResult.OK Then
            txtPullFileDest.Text = pullFileDest.SelectedPath
        End If
    End Sub
#End Region

    ''' <summary>
    ''' This method refreshes the list of selected devices.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        clearSelection()
        UpdateDeviceList()
    End Sub

    ''' <summary>
    ''' This method handles the lstDevices selection changing.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Async Sub lstDevices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDevices.SelectedIndexChanged
        If lstDevices.SelectedIndex >= 0 Then
            If android.IsDeviceConnected(connectedDevices(lstDevices.SelectedIndex).serial) Then
                Dim selectedDevice As String = lstDevices.SelectedItem.ToString
                selectedDevice = selectedDevice.Substring(0, selectedDevice.IndexOf(" "))
                Dim myTask As Task = getModelNum(selectedDevice)
                Await myTask
                If lstDevices.SelectedItem.ToString.Contains("fastboot") Then   'disable ADB
                    disableADB()
                    enableFastboot()
                Else    'disable Fastboot
                    disableFastboot()
                    enableADB()
                End If

            Else
                disableADB()
                disableFastboot()
            End If
        End If
    End Sub

#Region "Rebooting Methods"
    ''' <summary>
    ''' This method reboots the selected device.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnReboot_Click(sender As Object, e As EventArgs) Handles btnReboot.Click
        If currDevice.isConnected Then
            device.Reboot()
            addText("Rebooting " & currDevice.serial & " to system...")
            removeSelected()
        Else
            MessageBox.Show("This device appears to no longer be connected. Please ensure this device's connection, then click 'Refresh Devices'.", "ADB GUI", MessageBoxButtons.OK)
        End If
    End Sub

    ''' <summary>
    ''' This method reboots the selected device to the bootloader.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnBootloader_Click(sender As Object, e As EventArgs) Handles btnBootloader.Click
        If currDevice.isConnected Then
            device.RebootBootloader()
            addText("Rebooting " & currDevice.serial & " to bootloader...")
            removeSelected()
        Else
            MessageBox.Show("This device appears to no longer be connected. Please ensure this device's connection, then click 'Refresh Devices'.", "ADB GUI", MessageBoxButtons.OK)
        End If
    End Sub

    ''' <summary>
    ''' This method reboots the selected device to recovery.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRecovery_Click(sender As Object, e As EventArgs) Handles btnRecovery.Click
        If currDevice.isConnected Then
            device.RebootRecovery()
            addText("Rebooting " & currDevice.serial & " to recovery...")
            removeSelected()
        Else
            MessageBox.Show("This device appears to no longer be connected. Please ensure this device's connection, then click 'Refresh Devices'.", "ADB GUI", MessageBoxButtons.OK)
        End If
    End Sub
#End Region

    ''' <summary>
    ''' This method runs a custom ADB command.
    ''' </summary>
    ''' <returns>It returns output from the command.</returns>
    ''' <remarks></remarks>
    Private Async Function runADBCommand() As Task(Of String)
        Dim adbCmd As String = txtADBCommand.Text
        Dim params As String = ""

        If adbCmd.Contains(" ") Then
            params = Chr(34) & adbCmd.Substring(adbCmd.IndexOf(" ") + 1) & Chr(34)
            adbCmd = adbCmd.Substring(0, adbCmd.IndexOf(" "))
            If adbCmd = "push" Then
                params = params.Insert(params.IndexOf(" /"), Chr(34))
                params = params.Insert(params.IndexOf("/"), Chr(34))
            ElseIf adbCmd = "logcat" Then
                params = params.Substring(1)
                params = params.Substring(0, params.Length - 1)
            End If
        End If

        addText(nl & "adb " & adbCmd & " " & params & nl)
        Dim cmd As Task(Of String) = Task.Factory.StartNew(Function()
                                                               Return Adb.ExecuteAdbCommand(Adb.FormAdbCommand(device, adbCmd, params))
                                                           End Function)
        Dim result As String = Await cmd
        Return result
    End Function

    ''' <summary>
    ''' This method runs a custom Fastboot command.
    ''' </summary>
    ''' <returns>It returns output from the command.</returns>
    ''' <remarks></remarks>
    Private Async Function runFastbootCommand() As Task(Of String)
        Dim fbCmd As String = txtFastbootCommand.Text
        Dim params As String = ""

        If fbCmd.Contains(" ") Then
            params = Chr(34) & fbCmd.Substring(fbCmd.IndexOf(" ") + 1) & Chr(34)
            fbCmd = fbCmd.Substring(0, fbCmd.IndexOf(" "))
        End If
        Dim cmd As Task(Of String) = Task.Factory.StartNew(Function()
                                                               Return Fastboot.ExecuteFastbootCommand(Fastboot.FormFastbootCommand(device, fbCmd, params))
                                                           End Function)
        Dim result As String = Await cmd
        Return result
    End Function

    ''' <summary>
    ''' This method runs a custom ADB command.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Async Sub btnADBCommand_Click(sender As Object, e As EventArgs) Handles btnADBCommand.Click
        Dim myTask As Task(Of String) = runADBCommand()
        Dim runCmd As String = Await myTask
        addText(runCmd)
    End Sub

    ''' <summary>
    ''' This method runs a custom ADB shell command.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnADBShellCommand_Click(sender As Object, e As EventArgs) Handles btnADBShellCommand.Click
        Dim adbCmd As String = txtADBShellCommand.Text
        Dim params As String = ""
        Dim su As String = chkSU.Checked

        If adbCmd.Contains(" ") Then
            params = Chr(34) & adbCmd.Substring(adbCmd.IndexOf(" ") + 1) & Chr(34)
            adbCmd = adbCmd.Substring(0, adbCmd.IndexOf(" "))
        End If

        Try
            addText(Adb.ExecuteAdbCommand(Adb.FormAdbShellCommand(device, su, adbCmd, params)))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ADB GUI", MessageBoxButtons.OK)
        End Try
    End Sub

    ''' <summary>
    ''' This method handles text changing in the txtADBCommand TextBox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtADBCommand_TextChanged(sender As Object, e As EventArgs) Handles txtADBCommand.TextChanged
        If checkSelectedDevice() Then
            checkADBCommand()
        End If
    End Sub

#Region "Fastboot Commands"
    Private Sub btnFastbootReboot_Click(sender As Object, e As EventArgs) Handles btnFastbootReboot.Click
        If currDevice.isConnected Then
            device.FastbootReboot()
            addText("Rebooting " & currDevice.serial & " to system...")
            removeSelected()
        Else
            MessageBox.Show("This device appears to no longer be connected. Please ensure this device's connection, then click 'Refresh Devices'.", "ADB GUI", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnFastbootBootloader_Click(sender As Object, e As EventArgs) Handles btnFastbootBootloader.Click
        If currDevice.isConnected Then
            If lstDevices.SelectedIndex >= 0 Then
                Dim fbCmd As FastbootCommand
                fbCmd = Fastboot.FormFastbootCommand("-s " & currDevice.serial & " reboot-bootloader")
                addText(Fastboot.ExecuteFastbootCommand(fbCmd))
                addText("Rebooting " & currDevice.serial & " to bootloader...")
                removeSelected()
            Else
                MessageBox.Show("Please select a device to reboot.", "ADB GUI", MessageBoxButtons.OK)
            End If
        Else
            MessageBox.Show("This device appears to no longer be connected. Please ensure this device's connection, then click 'Refresh Devices'.", "ADB GUI", MessageBoxButtons.OK)
        End If
    End Sub

    Private Async Sub btnCustomFastboot_Click(sender As Object, e As EventArgs) Handles btnCustomFastboot.Click

        Dim myTask As Task(Of String) = runFastbootCommand()
        Dim runCmd As String = Await myTask
        addText(runCmd)
    End Sub
#End Region

#Region "Output Console"
    Private Sub btnClearConsole_Click(sender As Object, e As EventArgs) Handles btnClearConsole.Click
        txtOutput.Text = ""
    End Sub

    Private Sub txtOutput_TextChanged(sender As Object, e As EventArgs) Handles txtOutput.TextChanged
        If txtOutput.TextLength > 0 Then
            btnClearConsole.Enabled = True
        Else
            btnClearConsole.Enabled = False
        End If
    End Sub
#End Region

#Region "Menu Items"
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("HTC ADB GUI" & nl & _
                        "Beta 1" & nl &
                        "Copyright © 2014", "ADB GUI", MessageBoxButtons.OK)
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuHelpIndex_Click(sender As Object, e As EventArgs) Handles mnuHelpIndex.Click
        frmHelp.Show()
    End Sub
#End Region

    Private Sub btnRemount_Click(sender As Object, e As EventArgs) Handles btnRemount.Click
        addText(Adb.ExecuteAdbCommand(Adb.FormAdbCommand(device, "remount", "")))
    End Sub

    Private Sub txtADBShellCommand_TextChanged(sender As Object, e As EventArgs) Handles txtADBShellCommand.TextChanged
        If checkSelectedDevice() Then
            checkADBShellCommand()
        End If
    End Sub

#Region "Create Splash"
    Private Sub btnCreateSplash_Click(sender As Object, e As EventArgs) Handles btnCreateSplash.Click
        Dim pngLoc As String = txtCreateLoc.Text
        Dim andInfo As String = txtAndroidInfo.Text
        Dim zipName As String = txtCreateFilename.Text
        Dim dest As String = txtCreateDestination.Text
        Dim pngName As String = pngLoc.Substring(pngLoc.LastIndexOf("\") + 1)
        Dim pathToZip As String = dest & "\" & zipName

        MessageBox.Show("Please ensure that your splash image is the correct resolution for your device.", "ADB GUI", MessageBoxButtons.OK)
        If IO.File.Exists(pngLoc) AndAlso IO.File.Exists(andInfo) Then
            proc = New Process

            With proc.StartInfo
                .FileName = My.Computer.FileSystem.CurrentDirectory & "\ffmpeg.exe"
                .Arguments = "-i .\splash.png -f rawvideo -y -pix_fmt rgb565 .\splash1.img"
                .UseShellExecute = False
                .CreateNoWindow = True
                .RedirectStandardInput = True
                .RedirectStandardOutput = True
                .RedirectStandardError = True
            End With
            addText("Converting to splash1.img...")

            proc.Start()
            addText(proc.StandardOutput.ReadToEnd)
            addText(proc.StandardError.ReadToEnd)

            If IO.File.Exists(dest & "\splash1.img") Then
                addText("Creating " & zipName & "...")
                If IO.File.Exists(dest & "\" & zipName) Then
                    IO.File.Delete(dest & "\" & zipName)
                End If

                Dim newFile As ZipArchive = ZipFile.Open(dest & "\" & zipName, ZipArchiveMode.Create)

                newFile.CreateEntryFromFile(dest & "\splash1.img", "splash1.img")
                newFile.CreateEntryFromFile(andInfo, "android-info.txt")
                newFile.Dispose()

                If IO.File.Exists(pathToZip) Then
                    Dim infoReader As IO.FileInfo
                    infoReader = My.Computer.FileSystem.GetFileInfo(pathToZip)
                    If infoReader.Length > 0 Then
                        addText("Successfully created flashable splash image.")
                    Else
                        addText("Something went wrong. The zip file is empty. Please try again.")
                    End If
                Else
                    addText("Something went wrong. The zip file doesn't exist. Please try again.")
                End If
            Else
                addText("It appears that there was a problem while creating your splash image. Please try again.")
            End If
        Else
            MessageBox.Show("Ensure that both the required files exist at their selected locations.", "ADB GUI", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub checkCreateSplash()
        If txtAndroidInfo.TextLength > 0 AndAlso txtCreateLoc.TextLength > 0 AndAlso txtCreateDestination.TextLength > 0 AndAlso txtCreateFilename.TextLength > 0 Then
            btnCreateSplash.Enabled = True
        Else
            btnCreateSplash.Enabled = False
        End If
    End Sub

    Private Sub btnBrowseAndroidInfo_Click(sender As Object, e As EventArgs) Handles btnBrowseAndroidInfo.Click
        Dim andInfo As OpenFileDialog = New OpenFileDialog
        andInfo.Title = "Please select the android-info.txt file..."
        andInfo.SupportMultiDottedExtensions = True
        andInfo.Multiselect = False
        andInfo.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        andInfo.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
        If andInfo.ShowDialog = DialogResult.OK Then
            txtAndroidInfo.Text = andInfo.FileName
        End If
    End Sub

    Private Sub btnBrowseCreateSplash_Click(sender As Object, e As EventArgs) Handles btnBrowseCreateSplashImage.Click
        Dim imageLoc As OpenFileDialog = New OpenFileDialog
        imageLoc.Title = "Please select the splash image file. It should be a PNG file..."
        imageLoc.SupportMultiDottedExtensions = True
        imageLoc.Multiselect = False
        imageLoc.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        imageLoc.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*"
        If imageLoc.ShowDialog = DialogResult.OK Then
            txtCreateLoc.Text = imageLoc.FileName
        End If
    End Sub
    Private Sub txtCreateSplash_TextChanged(sender As Object, e As EventArgs) Handles txtAndroidInfo.TextChanged, txtCreateLoc.TextChanged, txtCreateDestination.TextChanged, txtCreateFilename.TextChanged
        If checkSelectedDevice() AndAlso currDevice.canFlashRecovery Then
            checkCreateSplash()
        End If
    End Sub

    Private Sub btnBrowseCreateDestination_Click(sender As Object, e As EventArgs) Handles btnBrowseCreateDestination.Click
        Dim createDest As FolderBrowserDialog = New FolderBrowserDialog
        createDest.SelectedPath = My.Computer.FileSystem.CurrentDirectory
        createDest.Description = "Please select the destination folder..."
        createDest.ShowNewFolderButton = True
        If createDest.ShowDialog = DialogResult.OK Then
            txtCreateDestination.Text = createDest.SelectedPath
        End If
    End Sub

#End Region

#Region "Backup Splash"
    Private Sub txtBackupSplash_TextChanged(sender As Object, e As EventArgs) Handles txtBackupSplash.TextChanged, txtBackupFilename.TextChanged
        If checkSelectedDevice() Then
            checkBackupSplash()
        End If
    End Sub

    Private Sub checkBackupSplash()
        If currDevice.splashBlock <> "" AndAlso currDevice.connectionStatus <> DeviceState.FASTBOOT AndAlso txtBackupSplash.TextLength > 0 AndAlso txtBackupFilename.TextLength > 0 Then
            btnBackupSplash.Enabled = True
        Else
            btnBackupSplash.Enabled = False
        End If
    End Sub

    Private Sub btnBrowseBackupSplash_Click(sender As Object, e As EventArgs) Handles btnBrowseBackupSplash.Click
        Dim backupLoc As FolderBrowserDialog = New FolderBrowserDialog
        backupLoc.SelectedPath = My.Computer.FileSystem.CurrentDirectory
        backupLoc.Description = "Please select the destination folder..."
        backupLoc.ShowNewFolderButton = True
        If backupLoc.ShowDialog = DialogResult.OK Then
            txtBackupSplash.Text = backupLoc.SelectedPath
        End If
    End Sub

    Private Async Function getSplash() As Task(Of String)
        Dim splashText As String = ""
        Dim cmd As Task(Of String) = _
            Task.Factory.StartNew(Function()
                                      Dim dest As String = txtBackupSplash.Text
                                      Dim filename As String = txtBackupFilename.Text
                                      Dim png As String = filename.Substring(0, filename.Length - 3) & "png"
                                      Dim pathToFile As String = dest & "\" & filename
                                      Dim pathToPNG As String = dest & "\" & png
                                      If IO.File.Exists(pathToFile) Then
                                          IO.File.Delete(pathToFile)
                                      End If
                                      If IO.File.Exists(pathToPNG) Then
                                          IO.File.Delete(pathToPNG)
                                      End If

                                      Dim adbCmd As AdbCommand = Adb.FormAdbShellCommand(device, False, "dd if=/dev/block/" & currDevice.splashBlock & " of=/mnt/sdcard/" & filename)
                                      splashText = Adb.ExecuteAdbCommand(adbCmd)
                                      If device.PullFile("/mnt/sdcard/" & filename, dest) Then
                                          splashText = "Pulling '" & filename & "' from '/sdcard/'..." & nl & nl & splashText
                                      Else
                                          splashText = "Unable to pull '" & filename & "' from '/sdcard/'." & nl & nl & splashText
                                      End If

                                      If IO.File.Exists(filename) Then
                                          adbCmd = Adb.FormAdbShellCommand(device, False, "rm /mnt/sdcard/" & filename)
                                          If Adb.ExecuteAdbCommand(adbCmd).ToString = "" Then
                                              splashText = "Removing '" & filename & "' from '/sdcard/'..." & nl & nl & splashText
                                          Else
                                              splashText = "Unable to remove '" & filename & "' from '/sdcard/'." & nl & nl & splashText
                                          End If

                                          proc = New Process

                                          With proc.StartInfo
                                              .FileName = My.Computer.FileSystem.CurrentDirectory & "\ffmpeg.exe"
                                              .Arguments = "-f rawvideo -pix_fmt rgb565 -s " & currDevice.res & " -i " & pathToFile & " -f image2 " & pathToPNG
                                              .UseShellExecute = False
                                              .CreateNoWindow = True
                                              .RedirectStandardInput = True
                                              .RedirectStandardOutput = True
                                              .RedirectStandardError = True
                                          End With

                                          proc.Start()
                                          proc.BeginOutputReadLine()
                                          proc.BeginErrorReadLine()

                                          If IO.File.Exists(pathToPNG) Then
                                              splashText = "Successfully backed up splash image from your device. It was copied in '.img' form to '" & pathToFile & "', and also converted to '" & pathToPNG & "' for editing." & nl & nl & splashText
                                              'Process.Start("explorer.exe", ".\")
                                          End If
                                      Else
                                          splashText = "Could not pull '" & filename & "' from SD card partition." & nl & nl & splashText
                                      End If
                                      Return ""
                                  End Function)
        Dim result As String = Await cmd
        Return splashText
    End Function

    Private Async Sub btnBackupSplash_Click(sender As Object, e As EventArgs) Handles btnBackupSplash.Click
        Dim myTask As Task(Of String) = getSplash()
        Dim runCmd As String = Await myTask
        addText(runCmd)
    End Sub
#End Region

#Region "Flash Splash"
    Private Sub txtFlashSplash_TextChanged(sender As Object, e As EventArgs) Handles txtFlashSplash.TextChanged
        checkFlashSplash()
    End Sub

    Private Sub checkFlashSplash()
        If checkSelectedDevice() AndAlso currDevice.canFlashRecovery AndAlso currDevice.connectionStatus = DeviceState.FASTBOOT Then
            If txtFlashSplash.TextLength > 0 Then
                btnFlashSplash.Enabled = True
            Else
                btnFlashSplash.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnBrowseFlashSplash_Click(sender As Object, e As EventArgs) Handles btnBrowseFlashSplash.Click
        Dim flashSplash As OpenFileDialog = New OpenFileDialog
        flashSplash.Title = "Please select the splash image file..."
        flashSplash.SupportMultiDottedExtensions = True
        flashSplash.Multiselect = False
        flashSplash.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        flashSplash.Filter = "ZIP files (*.zip)|*.zip|All files (*.*)|*.*"
        If flashSplash.ShowDialog = DialogResult.OK Then
            txtFlashSplash.Text = flashSplash.FileName
        End If
    End Sub

    Private Sub btnFlashSplash_Click(sender As Object, e As EventArgs) Handles btnFlashSplash.Click
        rebootRUU()


        If IO.File.Exists(txtFlashSplash.Text) Then
            If currDevice.isConnected Then
                Dim fbCmd As FastbootCommand = Fastboot.FormFastbootCommand("flash zip " & Chr(34) & txtFlashSplash.Text & Chr(34))
                addText(Fastboot.ExecuteFastbootCommand(fbCmd))
            Else
                MessageBox.Show("This device no longer appears to be connected.", "ADB GUI", MessageBoxButtons.OK)
                UpdateDeviceList()
            End If
        Else
            MessageBox.Show("The file '" & txtFlashSplash.Text & "' does not currently exist at the specified location.", "ADB GUI", MessageBoxButtons.OK)
        End If
    End Sub
#End Region

#Region "Custom Fastboot"
    Private Sub checkCustomFastboot()
        If checkSelectedDevice() AndAlso currDevice.connectionStatus = DeviceState.FASTBOOT Then
            If txtFastbootCommand.TextLength > 0 Then
                btnCustomFastboot.Enabled = True
            Else
                btnCustomFastboot.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtFastbootCommand_TextChanged(sender As Object, e As EventArgs) Handles txtFastbootCommand.TextChanged
        checkCustomFastboot()
    End Sub
#End Region

#Region "Load Program"
    Private Async Function loadTabbed() As Task(Of Boolean)
        Await Task.Factory.StartNew(Sub()
                                        android = AndroidController.Instance
                                    End Sub)
        UpdateDeviceList()
        Return True
    End Function

    Private Async Sub frmTabbed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myTask As Task = loadTabbed()
        Await myTask
        setToolTips()
    End Sub
#End Region

#Region "Flash Recovery"
    Private Sub checkFlashRecovery()
        If checkSelectedDevice() AndAlso currDevice.canFlashRecovery Then
            If txtFlashRecovery.TextLength > 0 Then
                btnFlashRecovery.Enabled = True
            Else
                btnFlashRecovery.Enabled = False
            End If
        End If
    End Sub
    Private Sub btnBrowseFlashRecovery_Click(sender As Object, e As EventArgs) Handles btnBrowseFlashRecovery.Click
        Dim recoveryImage As OpenFileDialog = New OpenFileDialog
        recoveryImage.Title = "Please select the recovery image..."
        recoveryImage.SupportMultiDottedExtensions = True
        recoveryImage.Multiselect = False
        recoveryImage.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        recoveryImage.Filter = "IMG files (*.img)|*.img|All files (*.*)|*.*"
        If recoveryImage.ShowDialog = DialogResult.OK Then
            txtFlashRecovery.Text = recoveryImage.FileName
        End If
    End Sub

    ''' <summary>
    ''' This method handles text changing in the txtFlashRecovery Textbox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtFlashRecovery_TextChanged(sender As Object, e As EventArgs) Handles txtFlashRecovery.TextChanged
        checkFlashRecovery()
    End Sub

    Private Sub btnFlashRecovery_Click(sender As Object, e As EventArgs) Handles btnFlashRecovery.Click
        If currDevice.isConnected Then
            If IO.File.Exists(txtFlashRecovery.Text) Then
                If lstDevices.SelectedIndex >= 0 Then
                    Dim fbCmd As FastbootCommand
                    fbCmd = Fastboot.FormFastbootCommand("-s " & currDevice.serial & " flash recovery " & Chr(34) & txtFlashRecovery.Text & Chr(34))
                    addText(Fastboot.ExecuteFastbootCommand(fbCmd) & ControlChars.NewLine)
                    addText(Fastboot.ExecuteFastbootCommand(fbCmd) & ControlChars.NewLine)
                    addText(Fastboot.ExecuteFastbootCommand(fbCmd) & ControlChars.NewLine)
                End If
            Else
                MessageBox.Show("The file at " & txtFlashRecovery.Text & " does not appear to exist.", "ADB GUI", MessageBoxButtons.OK)
            End If
        Else
            MessageBox.Show("This device appears to no longer be connected. Please ensure this device's connection, then click 'Refresh Devices'.", "ADB GUI", MessageBoxButtons.OK)
        End If
    End Sub
#End Region

#Region "Custom Zip"
    Private Sub btnBrowseCustomZip_Click(sender As Object, e As EventArgs) Handles btnBrowseCustomZip.Click
        Dim customZip As OpenFileDialog = New OpenFileDialog
        customZip.Title = "Please select the recovery image..."
        customZip.SupportMultiDottedExtensions = True
        customZip.Multiselect = False
        customZip.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        customZip.Filter = "Zip files (*.zip)|*.zip|All files (*.*)|*.*"
        If customZip.ShowDialog = DialogResult.OK Then
            txtFlashCustomZip.Text = customZip.FileName
        End If
    End Sub

    Private Sub checkCustomZip()
        If checkSelectedDevice() AndAlso currDevice.connectionStatus = DeviceState.FASTBOOT AndAlso currDevice.canFlashRecovery Then
            If txtFlashCustomZip.TextLength > 0 Then
                btnCustomZip.Enabled = True
            Else
                btnCustomZip.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnCustomZip_Click(sender As Object, e As EventArgs) Handles btnCustomZip.Click
        Dim zipLoc As String = txtFlashCustomZip.Text

        If currDevice.isConnected Then
            rebootRUU()
            If IO.File.Exists(zipLoc) Then
                If lstDevices.SelectedIndex >= 0 Then
                    Dim fbCmd As FastbootCommand
                    fbCmd = Fastboot.FormFastbootCommand("-s " & currDevice.serial & " flash zip " & zipLoc)
                    addText(Fastboot.ExecuteFastbootCommand(fbCmd) & ControlChars.NewLine)
                    addText(Fastboot.ExecuteFastbootCommand(fbCmd) & ControlChars.NewLine)
                    addText(Fastboot.ExecuteFastbootCommand(fbCmd) & ControlChars.NewLine)
                End If
            Else
                MessageBox.Show("The file at " & zipLoc & " does not appear to exist.", "ADB GUI", MessageBoxButtons.OK)
            End If
        Else
            MessageBox.Show("This device appears to no longer be connected. Please ensure this device's connection, then click 'Refresh Devices'.", "ADB GUI", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub txtCustomZip_TextChanged(sender As Object, e As EventArgs) Handles txtFlashCustomZip.TextChanged
        checkFlashRecovery()
    End Sub
#End Region

    ''' <summary>
    ''' This method sets the ToolTips for all question mark pictures.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub setToolTips()
        tt.SetToolTip(pctHelpReboot, "This section reboots your device over ADB.")
        tt.SetToolTip(pctHelpADBCommand, "This section allows you to issue a custom ADB command." & nl & _
                "You do not need to type 'adb' before the command." & nl & _
                "If you issue a command which directs to a path with spaces in it," & nl & _
                "please surround the entire path with quotes.")
        tt.SetToolTip(pctHelpADBShellCommand, "This section allows you to issue a custom ADB Shell command." & nl & _
                "You do not need to type 'adb shell' before the command." & nl & _
                "If you issue a command which directs to a path with spaces in it," & nl & _
                "please surround the entire path with quotes.")
        tt.SetToolTip(pctHelpMisc, "This section allows you to issue miscellaneous ADB commands.")
        tt.SetToolTip(pctHelpConnectedDevices, "This section allows you to select between any connected devices.")
        tt.SetToolTip(pctHelpFastbootReboot, "This section allows you to reboot your device while it is in Fastboot.")
        tt.SetToolTip(pctHelpFastbootCommand, "This section allows you to issue a custom Fastboot command." & nl & _
                "You do not need to type 'fastboot' before the command." & nl & _
                "If you issue a command which directs to a path with spaces in it," & nl & _
                "please surround the entire path with quotes.")
        tt.SetToolTip(pctHelpFlashRecovery, "This section allows you to flash a custom recovery.")
        tt.SetToolTip(pctHelpFlashCustomZip, "This section allows you to flash a custom zip file.")
        tt.SetToolTip(pctHelpPushFile, "This section allows you to push files to your device.")
        tt.SetToolTip(pctHelpPushDir, "This section allows you to push directories to your device.")
        tt.SetToolTip(pctHelpPullFile, "This section allows you to pull files from your device.")
        tt.SetToolTip(pctHelpPullDir, "This section allows you to pull directories from your device.")
        tt.SetToolTip(pctHelpCreateSplash, "This section allows you to create custom splash images for your device.")
        tt.SetToolTip(pctHelpBackupSplash, "This section allows you to backup custom splash images for capable devices.")
        tt.SetToolTip(pctHelpFlashSplash, "This section allows you to flash custom splash images to capable devices.")
        tt.SetToolTip(pctHelpPriority, "This section allows you to select what Logcat priority level you want.")
        tt.SetToolTip(pctHelpOutput, "This section allows you to select what Logcat output type you want.")
        tt.SetToolTip(pctHelpBuffer, "This section allows you to select what Logcat buffer type you want.")
        tt.SetToolTip(pctHelpTags, "This section allows you to select what Logcat tags you want.")

    End Sub

    ''' <summary>
    ''' This method clears the Logcat radio buttons.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearRadios()
        radVerbose.Checked = False
        radDebug.Checked = False
        radInfo.Checked = False
        radWarning.Checked = False
        radError.Checked = False
        radFatal.Checked = False
        radBrief.Checked = False
        radProcess.Checked = False
        radTag.Checked = False
        radRaw.Checked = False
        radTime.Checked = False
        radThreadTime.Checked = False
        radLong.Checked = False
        radRadio.Checked = False
        radEvents.Checked = False
        radMain.Checked = False
    End Sub

    ''' <summary>
    ''' This method clears the radio buttons when the user enters the Logcat tab.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub logcatEnter(ByVal sender As Object, ByVal e As EventArgs) Handles tabLogcat.Enter
        clearRadios()
    End Sub
End Class