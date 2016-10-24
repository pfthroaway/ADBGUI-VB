<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTabbed
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabADB = New System.Windows.Forms.TabPage()
        Me.grpReboot = New System.Windows.Forms.GroupBox()
        Me.btnReboot = New System.Windows.Forms.Button()
        Me.btnRecovery = New System.Windows.Forms.Button()
        Me.btnBootloader = New System.Windows.Forms.Button()
        Me.tabFastboot = New System.Windows.Forms.TabPage()
        Me.tabPushPull = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBrowsePullDir = New System.Windows.Forms.Button()
        Me.txtPullDirDest = New System.Windows.Forms.TextBox()
        Me.btnPullDir = New System.Windows.Forms.Button()
        Me.txtPullDirSource = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnBrowsePullFile = New System.Windows.Forms.Button()
        Me.txtPullFileDest = New System.Windows.Forms.TextBox()
        Me.btnPullFile = New System.Windows.Forms.Button()
        Me.txtPullFileSource = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpPushDir = New System.Windows.Forms.GroupBox()
        Me.btnBrowsePushDir = New System.Windows.Forms.Button()
        Me.txtPushDirDest = New System.Windows.Forms.TextBox()
        Me.btnPushDir = New System.Windows.Forms.Button()
        Me.txtPushDirSource = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpPushFile = New System.Windows.Forms.GroupBox()
        Me.btnBrowsePushFile = New System.Windows.Forms.Button()
        Me.txtPushFileDest = New System.Windows.Forms.TextBox()
        Me.btnPushFile = New System.Windows.Forms.Button()
        Me.txtPushFileSource = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpDevInfo = New System.Windows.Forms.GroupBox()
        Me.pctDevice = New System.Windows.Forms.PictureBox()
        Me.lblModelName = New System.Windows.Forms.Label()
        Me.lblManuName = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.grpConsole = New System.Windows.Forms.GroupBox()
        Me.txtOutput = New System.Windows.Forms.RichTextBox()
        Me.grpDevices = New System.Windows.Forms.GroupBox()
        Me.lstDevices = New System.Windows.Forms.ListBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.tabMain.SuspendLayout()
        Me.tabADB.SuspendLayout()
        Me.grpReboot.SuspendLayout()
        Me.tabPushPull.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpPushDir.SuspendLayout()
        Me.grpPushFile.SuspendLayout()
        Me.grpDevInfo.SuspendLayout()
        CType(Me.pctDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConsole.SuspendLayout()
        Me.grpDevices.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabADB)
        Me.tabMain.Controls.Add(Me.tabFastboot)
        Me.tabMain.Controls.Add(Me.tabPushPull)
        Me.tabMain.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.Location = New System.Drawing.Point(760, 23)
        Me.tabMain.Margin = New System.Windows.Forms.Padding(4)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(649, 762)
        Me.tabMain.TabIndex = 0
        '
        'tabADB
        '
        Me.tabADB.BackColor = System.Drawing.SystemColors.Control
        Me.tabADB.Controls.Add(Me.grpReboot)
        Me.tabADB.Location = New System.Drawing.Point(4, 32)
        Me.tabADB.Margin = New System.Windows.Forms.Padding(4)
        Me.tabADB.Name = "tabADB"
        Me.tabADB.Padding = New System.Windows.Forms.Padding(4)
        Me.tabADB.Size = New System.Drawing.Size(641, 726)
        Me.tabADB.TabIndex = 0
        Me.tabADB.Text = "ADB"
        Me.tabADB.ToolTipText = "Issue ADB commands to your device."
        '
        'grpReboot
        '
        Me.grpReboot.Controls.Add(Me.btnReboot)
        Me.grpReboot.Controls.Add(Me.btnRecovery)
        Me.grpReboot.Controls.Add(Me.btnBootloader)
        Me.grpReboot.Location = New System.Drawing.Point(8, 8)
        Me.grpReboot.Name = "grpReboot"
        Me.grpReboot.Size = New System.Drawing.Size(137, 178)
        Me.grpReboot.TabIndex = 0
        Me.grpReboot.TabStop = False
        Me.grpReboot.Text = "Reboot"
        '
        'btnReboot
        '
        Me.btnReboot.Enabled = False
        Me.btnReboot.Location = New System.Drawing.Point(6, 29)
        Me.btnReboot.Name = "btnReboot"
        Me.btnReboot.Size = New System.Drawing.Size(120, 40)
        Me.btnReboot.TabIndex = 5
        Me.btnReboot.Text = "&System"
        Me.btnReboot.UseVisualStyleBackColor = True
        '
        'btnRecovery
        '
        Me.btnRecovery.Enabled = False
        Me.btnRecovery.Location = New System.Drawing.Point(6, 121)
        Me.btnRecovery.Name = "btnRecovery"
        Me.btnRecovery.Size = New System.Drawing.Size(120, 40)
        Me.btnRecovery.TabIndex = 7
        Me.btnRecovery.Text = "&Recovery"
        Me.btnRecovery.UseVisualStyleBackColor = True
        '
        'btnBootloader
        '
        Me.btnBootloader.Enabled = False
        Me.btnBootloader.Location = New System.Drawing.Point(6, 75)
        Me.btnBootloader.Name = "btnBootloader"
        Me.btnBootloader.Size = New System.Drawing.Size(120, 40)
        Me.btnBootloader.TabIndex = 6
        Me.btnBootloader.Text = "&Bootloader"
        Me.btnBootloader.UseVisualStyleBackColor = True
        '
        'tabFastboot
        '
        Me.tabFastboot.BackColor = System.Drawing.SystemColors.Control
        Me.tabFastboot.Location = New System.Drawing.Point(4, 32)
        Me.tabFastboot.Margin = New System.Windows.Forms.Padding(4)
        Me.tabFastboot.Name = "tabFastboot"
        Me.tabFastboot.Padding = New System.Windows.Forms.Padding(4)
        Me.tabFastboot.Size = New System.Drawing.Size(641, 726)
        Me.tabFastboot.TabIndex = 1
        Me.tabFastboot.Text = "Fastboot"
        Me.tabFastboot.ToolTipText = "Issue fastboot commands to your device."
        '
        'tabPushPull
        '
        Me.tabPushPull.BackColor = System.Drawing.SystemColors.Control
        Me.tabPushPull.Controls.Add(Me.GroupBox2)
        Me.tabPushPull.Controls.Add(Me.GroupBox3)
        Me.tabPushPull.Controls.Add(Me.grpPushDir)
        Me.tabPushPull.Controls.Add(Me.grpPushFile)
        Me.tabPushPull.Location = New System.Drawing.Point(4, 32)
        Me.tabPushPull.Name = "tabPushPull"
        Me.tabPushPull.Size = New System.Drawing.Size(641, 726)
        Me.tabPushPull.TabIndex = 2
        Me.tabPushPull.Text = "Push/Pull"
        Me.tabPushPull.ToolTipText = "Push and pull files from your device."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBrowsePullDir)
        Me.GroupBox2.Controls.Add(Me.txtPullDirDest)
        Me.GroupBox2.Controls.Add(Me.btnPullDir)
        Me.GroupBox2.Controls.Add(Me.txtPullDirSource)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 501)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(633, 160)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pull Directory"
        '
        'btnBrowsePullDir
        '
        Me.btnBrowsePullDir.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowsePullDir.Location = New System.Drawing.Point(6, 69)
        Me.btnBrowsePullDir.Name = "btnBrowsePullDir"
        Me.btnBrowsePullDir.Size = New System.Drawing.Size(103, 31)
        Me.btnBrowsePullDir.TabIndex = 18
        Me.btnBrowsePullDir.Text = "Browse..."
        Me.btnBrowsePullDir.UseVisualStyleBackColor = True
        '
        'txtPullDirDest
        '
        Me.txtPullDirDest.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPullDirDest.Location = New System.Drawing.Point(115, 70)
        Me.txtPullDirDest.Name = "txtPullDirDest"
        Me.txtPullDirDest.Size = New System.Drawing.Size(494, 30)
        Me.txtPullDirDest.TabIndex = 3
        Me.txtPullDirDest.Text = "/mnt/sdcard/"
        '
        'btnPullDir
        '
        Me.btnPullDir.Enabled = False
        Me.btnPullDir.Location = New System.Drawing.Point(232, 106)
        Me.btnPullDir.Name = "btnPullDir"
        Me.btnPullDir.Size = New System.Drawing.Size(150, 40)
        Me.btnPullDir.TabIndex = 17
        Me.btnPullDir.Text = "Pull Directory"
        Me.btnPullDir.UseVisualStyleBackColor = True
        '
        'txtPullDirSource
        '
        Me.txtPullDirSource.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPullDirSource.Location = New System.Drawing.Point(115, 34)
        Me.txtPullDirSource.Name = "txtPullDirSource"
        Me.txtPullDirSource.Size = New System.Drawing.Size(494, 30)
        Me.txtPullDirSource.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Source:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnBrowsePullFile)
        Me.GroupBox3.Controls.Add(Me.txtPullFileDest)
        Me.GroupBox3.Controls.Add(Me.btnPullFile)
        Me.GroupBox3.Controls.Add(Me.txtPullFileSource)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 335)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(615, 160)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pull File"
        '
        'btnBrowsePullFile
        '
        Me.btnBrowsePullFile.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowsePullFile.Location = New System.Drawing.Point(6, 69)
        Me.btnBrowsePullFile.Name = "btnBrowsePullFile"
        Me.btnBrowsePullFile.Size = New System.Drawing.Size(103, 31)
        Me.btnBrowsePullFile.TabIndex = 18
        Me.btnBrowsePullFile.Text = "Browse..."
        Me.btnBrowsePullFile.UseVisualStyleBackColor = True
        '
        'txtPullFileDest
        '
        Me.txtPullFileDest.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPullFileDest.Location = New System.Drawing.Point(115, 70)
        Me.txtPullFileDest.Name = "txtPullFileDest"
        Me.txtPullFileDest.Size = New System.Drawing.Size(494, 30)
        Me.txtPullFileDest.TabIndex = 3
        Me.txtPullFileDest.Text = "/mnt/sdcard/"
        '
        'btnPullFile
        '
        Me.btnPullFile.Enabled = False
        Me.btnPullFile.Location = New System.Drawing.Point(232, 106)
        Me.btnPullFile.Name = "btnPullFile"
        Me.btnPullFile.Size = New System.Drawing.Size(150, 40)
        Me.btnPullFile.TabIndex = 17
        Me.btnPullFile.Text = "Pull File"
        Me.btnPullFile.UseVisualStyleBackColor = True
        '
        'txtPullFileSource
        '
        Me.txtPullFileSource.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPullFileSource.Location = New System.Drawing.Point(115, 34)
        Me.txtPullFileSource.Name = "txtPullFileSource"
        Me.txtPullFileSource.Size = New System.Drawing.Size(494, 30)
        Me.txtPullFileSource.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Source:"
        '
        'grpPushDir
        '
        Me.grpPushDir.Controls.Add(Me.btnBrowsePushDir)
        Me.grpPushDir.Controls.Add(Me.txtPushDirDest)
        Me.grpPushDir.Controls.Add(Me.btnPushDir)
        Me.grpPushDir.Controls.Add(Me.txtPushDirSource)
        Me.grpPushDir.Controls.Add(Me.Label1)
        Me.grpPushDir.Location = New System.Drawing.Point(5, 169)
        Me.grpPushDir.Name = "grpPushDir"
        Me.grpPushDir.Size = New System.Drawing.Size(633, 160)
        Me.grpPushDir.TabIndex = 3
        Me.grpPushDir.TabStop = False
        Me.grpPushDir.Text = "Push Directory"
        '
        'btnBrowsePushDir
        '
        Me.btnBrowsePushDir.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowsePushDir.Location = New System.Drawing.Point(6, 33)
        Me.btnBrowsePushDir.Name = "btnBrowsePushDir"
        Me.btnBrowsePushDir.Size = New System.Drawing.Size(103, 31)
        Me.btnBrowsePushDir.TabIndex = 18
        Me.btnBrowsePushDir.Text = "Browse..."
        Me.btnBrowsePushDir.UseVisualStyleBackColor = True
        '
        'txtPushDirDest
        '
        Me.txtPushDirDest.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPushDirDest.Location = New System.Drawing.Point(115, 70)
        Me.txtPushDirDest.Name = "txtPushDirDest"
        Me.txtPushDirDest.Size = New System.Drawing.Size(494, 30)
        Me.txtPushDirDest.TabIndex = 3
        Me.txtPushDirDest.Text = "/mnt/sdcard/"
        '
        'btnPushDir
        '
        Me.btnPushDir.Enabled = False
        Me.btnPushDir.Location = New System.Drawing.Point(232, 106)
        Me.btnPushDir.Name = "btnPushDir"
        Me.btnPushDir.Size = New System.Drawing.Size(150, 40)
        Me.btnPushDir.TabIndex = 17
        Me.btnPushDir.Text = "Push Directory"
        Me.btnPushDir.UseVisualStyleBackColor = True
        '
        'txtPushDirSource
        '
        Me.txtPushDirSource.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPushDirSource.Location = New System.Drawing.Point(115, 34)
        Me.txtPushDirSource.Name = "txtPushDirSource"
        Me.txtPushDirSource.Size = New System.Drawing.Size(494, 30)
        Me.txtPushDirSource.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Destination:"
        '
        'grpPushFile
        '
        Me.grpPushFile.Controls.Add(Me.btnBrowsePushFile)
        Me.grpPushFile.Controls.Add(Me.txtPushFileDest)
        Me.grpPushFile.Controls.Add(Me.btnPushFile)
        Me.grpPushFile.Controls.Add(Me.txtPushFileSource)
        Me.grpPushFile.Controls.Add(Me.Label2)
        Me.grpPushFile.Location = New System.Drawing.Point(5, 3)
        Me.grpPushFile.Name = "grpPushFile"
        Me.grpPushFile.Size = New System.Drawing.Size(615, 160)
        Me.grpPushFile.TabIndex = 2
        Me.grpPushFile.TabStop = False
        Me.grpPushFile.Text = "Push File"
        '
        'btnBrowsePushFile
        '
        Me.btnBrowsePushFile.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowsePushFile.Location = New System.Drawing.Point(6, 33)
        Me.btnBrowsePushFile.Name = "btnBrowsePushFile"
        Me.btnBrowsePushFile.Size = New System.Drawing.Size(103, 31)
        Me.btnBrowsePushFile.TabIndex = 18
        Me.btnBrowsePushFile.Text = "Browse..."
        Me.btnBrowsePushFile.UseVisualStyleBackColor = True
        '
        'txtPushFileDest
        '
        Me.txtPushFileDest.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPushFileDest.Location = New System.Drawing.Point(115, 70)
        Me.txtPushFileDest.Name = "txtPushFileDest"
        Me.txtPushFileDest.Size = New System.Drawing.Size(494, 30)
        Me.txtPushFileDest.TabIndex = 3
        Me.txtPushFileDest.Text = "/mnt/sdcard/"
        '
        'btnPushFile
        '
        Me.btnPushFile.Enabled = False
        Me.btnPushFile.Location = New System.Drawing.Point(232, 106)
        Me.btnPushFile.Name = "btnPushFile"
        Me.btnPushFile.Size = New System.Drawing.Size(150, 40)
        Me.btnPushFile.TabIndex = 17
        Me.btnPushFile.Text = "Push File"
        Me.btnPushFile.UseVisualStyleBackColor = True
        '
        'txtPushFileSource
        '
        Me.txtPushFileSource.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPushFileSource.Location = New System.Drawing.Point(115, 34)
        Me.txtPushFileSource.Name = "txtPushFileSource"
        Me.txtPushFileSource.Size = New System.Drawing.Size(494, 30)
        Me.txtPushFileSource.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Destination:"
        '
        'grpDevInfo
        '
        Me.grpDevInfo.Controls.Add(Me.pctDevice)
        Me.grpDevInfo.Controls.Add(Me.lblModelName)
        Me.grpDevInfo.Controls.Add(Me.lblManuName)
        Me.grpDevInfo.Controls.Add(Me.lblModel)
        Me.grpDevInfo.Controls.Add(Me.lblManufacturer)
        Me.grpDevInfo.Location = New System.Drawing.Point(296, 23)
        Me.grpDevInfo.Name = "grpDevInfo"
        Me.grpDevInfo.Size = New System.Drawing.Size(457, 234)
        Me.grpDevInfo.TabIndex = 12
        Me.grpDevInfo.TabStop = False
        Me.grpDevInfo.Text = "Device Information"
        '
        'pctDevice
        '
        Me.pctDevice.InitialImage = Global.ADB_GUI.My.Resources.Resources.clear
        Me.pctDevice.Location = New System.Drawing.Point(344, 26)
        Me.pctDevice.Name = "pctDevice"
        Me.pctDevice.Size = New System.Drawing.Size(100, 200)
        Me.pctDevice.TabIndex = 4
        Me.pctDevice.TabStop = False
        '
        'lblModelName
        '
        Me.lblModelName.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelName.Location = New System.Drawing.Point(138, 66)
        Me.lblModelName.Name = "lblModelName"
        Me.lblModelName.Size = New System.Drawing.Size(200, 30)
        Me.lblModelName.TabIndex = 3
        Me.lblModelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblManuName
        '
        Me.lblManuName.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManuName.Location = New System.Drawing.Point(138, 36)
        Me.lblManuName.Name = "lblManuName"
        Me.lblManuName.Size = New System.Drawing.Size(200, 30)
        Me.lblManuName.TabIndex = 2
        Me.lblManuName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblModel
        '
        Me.lblModel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(7, 66)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(125, 30)
        Me.lblModel.TabIndex = 1
        Me.lblModel.Text = "Model:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblManufacturer
        '
        Me.lblManufacturer.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManufacturer.Location = New System.Drawing.Point(7, 36)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(125, 30)
        Me.lblManufacturer.TabIndex = 0
        Me.lblManufacturer.Text = "Manufacturer:"
        Me.lblManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpConsole
        '
        Me.grpConsole.Controls.Add(Me.txtOutput)
        Me.grpConsole.Location = New System.Drawing.Point(14, 300)
        Me.grpConsole.Name = "grpConsole"
        Me.grpConsole.Size = New System.Drawing.Size(739, 486)
        Me.grpConsole.TabIndex = 11
        Me.grpConsole.TabStop = False
        Me.grpConsole.Text = "Console Output"
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("Lucida Console", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(16, 33)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(710, 434)
        Me.txtOutput.TabIndex = 7
        Me.txtOutput.Text = ""
        '
        'grpDevices
        '
        Me.grpDevices.Controls.Add(Me.lstDevices)
        Me.grpDevices.Location = New System.Drawing.Point(14, 23)
        Me.grpDevices.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpDevices.Name = "grpDevices"
        Me.grpDevices.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpDevices.Size = New System.Drawing.Size(275, 186)
        Me.grpDevices.TabIndex = 10
        Me.grpDevices.TabStop = False
        Me.grpDevices.Text = "Connected Devices"
        '
        'lstDevices
        '
        Me.lstDevices.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDevices.FormattingEnabled = True
        Me.lstDevices.ItemHeight = 17
        Me.lstDevices.Location = New System.Drawing.Point(8, 36)
        Me.lstDevices.Name = "lstDevices"
        Me.lstDevices.Size = New System.Drawing.Size(260, 140)
        Me.lstDevices.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(51, 217)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(200, 40)
        Me.btnRefresh.TabIndex = 13
        Me.btnRefresh.Text = "&Refresh Devices"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'frmTabbed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1422, 798)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.grpDevInfo)
        Me.Controls.Add(Me.grpConsole)
        Me.Controls.Add(Me.grpDevices)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTabbed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TabbedForm"
        Me.tabMain.ResumeLayout(False)
        Me.tabADB.ResumeLayout(False)
        Me.grpReboot.ResumeLayout(False)
        Me.tabPushPull.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpPushDir.ResumeLayout(False)
        Me.grpPushDir.PerformLayout()
        Me.grpPushFile.ResumeLayout(False)
        Me.grpPushFile.PerformLayout()
        Me.grpDevInfo.ResumeLayout(False)
        CType(Me.pctDevice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConsole.ResumeLayout(False)
        Me.grpDevices.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tabADB As System.Windows.Forms.TabPage
    Friend WithEvents tabFastboot As System.Windows.Forms.TabPage
    Friend WithEvents grpDevInfo As System.Windows.Forms.GroupBox
    Friend WithEvents pctDevice As System.Windows.Forms.PictureBox
    Friend WithEvents lblModelName As System.Windows.Forms.Label
    Friend WithEvents lblManuName As System.Windows.Forms.Label
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents lblManufacturer As System.Windows.Forms.Label
    Friend WithEvents grpConsole As System.Windows.Forms.GroupBox
    Friend WithEvents txtOutput As System.Windows.Forms.RichTextBox
    Friend WithEvents grpDevices As System.Windows.Forms.GroupBox
    Friend WithEvents lstDevices As System.Windows.Forms.ListBox
    Friend WithEvents grpReboot As System.Windows.Forms.GroupBox
    Friend WithEvents btnReboot As System.Windows.Forms.Button
    Friend WithEvents btnRecovery As System.Windows.Forms.Button
    Friend WithEvents btnBootloader As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents tabPushPull As System.Windows.Forms.TabPage
    Friend WithEvents grpPushFile As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowsePushFile As System.Windows.Forms.Button
    Friend WithEvents txtPushFileDest As System.Windows.Forms.TextBox
    Friend WithEvents btnPushFile As System.Windows.Forms.Button
    Friend WithEvents txtPushFileSource As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpPushDir As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowsePushDir As System.Windows.Forms.Button
    Friend WithEvents txtPushDirDest As System.Windows.Forms.TextBox
    Friend WithEvents btnPushDir As System.Windows.Forms.Button
    Friend WithEvents txtPushDirSource As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowsePullDir As System.Windows.Forms.Button
    Friend WithEvents txtPullDirDest As System.Windows.Forms.TextBox
    Friend WithEvents btnPullDir As System.Windows.Forms.Button
    Friend WithEvents txtPullDirSource As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowsePullFile As System.Windows.Forms.Button
    Friend WithEvents txtPullFileDest As System.Windows.Forms.TextBox
    Friend WithEvents btnPullFile As System.Windows.Forms.Button
    Friend WithEvents txtPullFileSource As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
