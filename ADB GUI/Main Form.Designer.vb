<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabADB = New System.Windows.Forms.TabPage()
        Me.grpADBMisc = New System.Windows.Forms.GroupBox()
        Me.pctHelpMisc = New System.Windows.Forms.PictureBox()
        Me.btnRemount = New System.Windows.Forms.Button()
        Me.grpADBShellCommand = New System.Windows.Forms.GroupBox()
        Me.pctHelpADBShellCommand = New System.Windows.Forms.PictureBox()
        Me.chkSU = New System.Windows.Forms.CheckBox()
        Me.btnADBShellCommand = New System.Windows.Forms.Button()
        Me.txtADBShellCommand = New System.Windows.Forms.TextBox()
        Me.grpADBCommand = New System.Windows.Forms.GroupBox()
        Me.pctHelpADBCommand = New System.Windows.Forms.PictureBox()
        Me.btnADBCommand = New System.Windows.Forms.Button()
        Me.txtADBCommand = New System.Windows.Forms.TextBox()
        Me.grpReboot = New System.Windows.Forms.GroupBox()
        Me.pctHelpReboot = New System.Windows.Forms.PictureBox()
        Me.btnReboot = New System.Windows.Forms.Button()
        Me.btnRecovery = New System.Windows.Forms.Button()
        Me.btnBootloader = New System.Windows.Forms.Button()
        Me.tabFastboot = New System.Windows.Forms.TabPage()
        Me.grpFlashCustomZip = New System.Windows.Forms.GroupBox()
        Me.pctHelpFlashCustomZip = New System.Windows.Forms.PictureBox()
        Me.btnBrowseCustomZip = New System.Windows.Forms.Button()
        Me.txtFlashCustomZip = New System.Windows.Forms.TextBox()
        Me.btnCustomZip = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.grpFastbootCommand = New System.Windows.Forms.GroupBox()
        Me.pctHelpFastbootCommand = New System.Windows.Forms.PictureBox()
        Me.txtFastbootCommand = New System.Windows.Forms.TextBox()
        Me.btnCustomFastboot = New System.Windows.Forms.Button()
        Me.grpFlashRecovery = New System.Windows.Forms.GroupBox()
        Me.pctHelpFlashRecovery = New System.Windows.Forms.PictureBox()
        Me.btnBrowseFlashRecovery = New System.Windows.Forms.Button()
        Me.txtFlashRecovery = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnFlashRecovery = New System.Windows.Forms.Button()
        Me.grpFastboot = New System.Windows.Forms.GroupBox()
        Me.pctHelpFastbootReboot = New System.Windows.Forms.PictureBox()
        Me.btnFastbootBootloader = New System.Windows.Forms.Button()
        Me.btnFastbootReboot = New System.Windows.Forms.Button()
        Me.tabPush = New System.Windows.Forms.TabPage()
        Me.grpPushDir = New System.Windows.Forms.GroupBox()
        Me.pctHelpPushDir = New System.Windows.Forms.PictureBox()
        Me.btnBrowsePushDir = New System.Windows.Forms.Button()
        Me.txtPushDirDest = New System.Windows.Forms.TextBox()
        Me.btnPushDir = New System.Windows.Forms.Button()
        Me.txtPushDirSource = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpPushFile = New System.Windows.Forms.GroupBox()
        Me.pctHelpPushFile = New System.Windows.Forms.PictureBox()
        Me.btnBrowsePushFile = New System.Windows.Forms.Button()
        Me.txtPushFileDest = New System.Windows.Forms.TextBox()
        Me.btnPushFile = New System.Windows.Forms.Button()
        Me.txtPushFileSource = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabPull = New System.Windows.Forms.TabPage()
        Me.grpPullDir = New System.Windows.Forms.GroupBox()
        Me.pctHelpPullDir = New System.Windows.Forms.PictureBox()
        Me.btnBrowsePullDir = New System.Windows.Forms.Button()
        Me.txtPullDirDest = New System.Windows.Forms.TextBox()
        Me.btnPullDir = New System.Windows.Forms.Button()
        Me.txtPullDirSource = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpPullFile = New System.Windows.Forms.GroupBox()
        Me.pctHelpPullFile = New System.Windows.Forms.PictureBox()
        Me.btnBrowsePullFile = New System.Windows.Forms.Button()
        Me.txtPullFileDest = New System.Windows.Forms.TextBox()
        Me.btnPullFile = New System.Windows.Forms.Button()
        Me.txtPullFileSource = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tabSplash1 = New System.Windows.Forms.TabPage()
        Me.grpCreateSplash = New System.Windows.Forms.GroupBox()
        Me.pctHelpCreateSplash = New System.Windows.Forms.PictureBox()
        Me.btnBrowseCreateDestination = New System.Windows.Forms.Button()
        Me.btnBrowseAndroidInfo = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCreateFilename = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCreateDestination = New System.Windows.Forms.TextBox()
        Me.btnCreateSplash = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnBrowseCreateSplashImage = New System.Windows.Forms.Button()
        Me.txtAndroidInfo = New System.Windows.Forms.TextBox()
        Me.txtCreateLoc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabSplash2 = New System.Windows.Forms.TabPage()
        Me.grpFlashSplash = New System.Windows.Forms.GroupBox()
        Me.pctHelpFlashSplash = New System.Windows.Forms.PictureBox()
        Me.btnBrowseFlashSplash = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFlashSplash = New System.Windows.Forms.TextBox()
        Me.btnFlashSplash = New System.Windows.Forms.Button()
        Me.grpSplash = New System.Windows.Forms.GroupBox()
        Me.pctHelpBackupSplash = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBackupFilename = New System.Windows.Forms.TextBox()
        Me.btnBrowseBackupSplash = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBackupSplash = New System.Windows.Forms.TextBox()
        Me.btnBackupSplash = New System.Windows.Forms.Button()
        Me.tabLogcat = New System.Windows.Forms.TabPage()
        Me.grpLogcatSD = New System.Windows.Forms.GroupBox()
        Me.pctHelpLogcatSD = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtLogcatSD = New System.Windows.Forms.TextBox()
        Me.grpTags = New System.Windows.Forms.GroupBox()
        Me.pctHelpTags = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.grpBuffer = New System.Windows.Forms.GroupBox()
        Me.pctHelpBuffer = New System.Windows.Forms.PictureBox()
        Me.radMain = New System.Windows.Forms.RadioButton()
        Me.radEvents = New System.Windows.Forms.RadioButton()
        Me.radRadio = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pctHelpOutput = New System.Windows.Forms.PictureBox()
        Me.radLong = New System.Windows.Forms.RadioButton()
        Me.radThreadTime = New System.Windows.Forms.RadioButton()
        Me.radTime = New System.Windows.Forms.RadioButton()
        Me.radRaw = New System.Windows.Forms.RadioButton()
        Me.radTag = New System.Windows.Forms.RadioButton()
        Me.radProcess = New System.Windows.Forms.RadioButton()
        Me.radBrief = New System.Windows.Forms.RadioButton()
        Me.btnStartLogcat = New System.Windows.Forms.Button()
        Me.grpPriority = New System.Windows.Forms.GroupBox()
        Me.pctHelpPriority = New System.Windows.Forms.PictureBox()
        Me.radFatal = New System.Windows.Forms.RadioButton()
        Me.radError = New System.Windows.Forms.RadioButton()
        Me.radWarning = New System.Windows.Forms.RadioButton()
        Me.radInfo = New System.Windows.Forms.RadioButton()
        Me.radDebug = New System.Windows.Forms.RadioButton()
        Me.radVerbose = New System.Windows.Forms.RadioButton()
        Me.grpDevInfo = New System.Windows.Forms.GroupBox()
        Me.pctDevice = New System.Windows.Forms.PictureBox()
        Me.lblModelName = New System.Windows.Forms.Label()
        Me.lblManuName = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.grpConsole = New System.Windows.Forms.GroupBox()
        Me.btnClearConsole = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.RichTextBox()
        Me.grpDevices = New System.Windows.Forms.GroupBox()
        Me.pctHelpConnectedDevices = New System.Windows.Forms.PictureBox()
        Me.lstDevices = New System.Windows.Forms.ListBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.mnu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpIndex = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabMain.SuspendLayout()
        Me.tabADB.SuspendLayout()
        Me.grpADBMisc.SuspendLayout()
        CType(Me.pctHelpMisc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpADBShellCommand.SuspendLayout()
        CType(Me.pctHelpADBShellCommand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpADBCommand.SuspendLayout()
        CType(Me.pctHelpADBCommand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpReboot.SuspendLayout()
        CType(Me.pctHelpReboot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFastboot.SuspendLayout()
        Me.grpFlashCustomZip.SuspendLayout()
        CType(Me.pctHelpFlashCustomZip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFastbootCommand.SuspendLayout()
        CType(Me.pctHelpFastbootCommand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFlashRecovery.SuspendLayout()
        CType(Me.pctHelpFlashRecovery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFastboot.SuspendLayout()
        CType(Me.pctHelpFastbootReboot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPush.SuspendLayout()
        Me.grpPushDir.SuspendLayout()
        CType(Me.pctHelpPushDir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPushFile.SuspendLayout()
        CType(Me.pctHelpPushFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPull.SuspendLayout()
        Me.grpPullDir.SuspendLayout()
        CType(Me.pctHelpPullDir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPullFile.SuspendLayout()
        CType(Me.pctHelpPullFile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSplash1.SuspendLayout()
        Me.grpCreateSplash.SuspendLayout()
        CType(Me.pctHelpCreateSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSplash2.SuspendLayout()
        Me.grpFlashSplash.SuspendLayout()
        CType(Me.pctHelpFlashSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSplash.SuspendLayout()
        CType(Me.pctHelpBackupSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLogcat.SuspendLayout()
        Me.grpLogcatSD.SuspendLayout()
        CType(Me.pctHelpLogcatSD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTags.SuspendLayout()
        CType(Me.pctHelpTags, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBuffer.SuspendLayout()
        CType(Me.pctHelpBuffer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pctHelpOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPriority.SuspendLayout()
        CType(Me.pctHelpPriority, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDevInfo.SuspendLayout()
        CType(Me.pctDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConsole.SuspendLayout()
        Me.grpDevices.SuspendLayout()
        CType(Me.pctHelpConnectedDevices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabADB)
        Me.tabMain.Controls.Add(Me.tabFastboot)
        Me.tabMain.Controls.Add(Me.tabPush)
        Me.tabMain.Controls.Add(Me.tabPull)
        Me.tabMain.Controls.Add(Me.tabSplash1)
        Me.tabMain.Controls.Add(Me.tabSplash2)
        Me.tabMain.Controls.Add(Me.tabLogcat)
        Me.tabMain.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabMain.Location = New System.Drawing.Point(12, 285)
        Me.tabMain.Margin = New System.Windows.Forms.Padding(4)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(739, 500)
        Me.tabMain.TabIndex = 2
        '
        'tabADB
        '
        Me.tabADB.BackColor = System.Drawing.SystemColors.Control
        Me.tabADB.Controls.Add(Me.grpADBMisc)
        Me.tabADB.Controls.Add(Me.grpADBShellCommand)
        Me.tabADB.Controls.Add(Me.grpADBCommand)
        Me.tabADB.Controls.Add(Me.grpReboot)
        Me.tabADB.Location = New System.Drawing.Point(4, 28)
        Me.tabADB.Margin = New System.Windows.Forms.Padding(4)
        Me.tabADB.Name = "tabADB"
        Me.tabADB.Padding = New System.Windows.Forms.Padding(4)
        Me.tabADB.Size = New System.Drawing.Size(731, 468)
        Me.tabADB.TabIndex = 0
        Me.tabADB.Text = "ADB"
        Me.tabADB.ToolTipText = "Issue ADB commands to your device."
        '
        'grpADBMisc
        '
        Me.grpADBMisc.Controls.Add(Me.pctHelpMisc)
        Me.grpADBMisc.Controls.Add(Me.btnRemount)
        Me.grpADBMisc.Location = New System.Drawing.Point(8, 196)
        Me.grpADBMisc.Name = "grpADBMisc"
        Me.grpADBMisc.Size = New System.Drawing.Size(137, 75)
        Me.grpADBMisc.TabIndex = 9
        Me.grpADBMisc.TabStop = False
        Me.grpADBMisc.Text = "Misc."
        '
        'pctHelpMisc
        '
        Me.pctHelpMisc.Image = CType(resources.GetObject("pctHelpMisc.Image"), System.Drawing.Image)
        Me.pctHelpMisc.InitialImage = CType(resources.GetObject("pctHelpMisc.InitialImage"), System.Drawing.Image)
        Me.pctHelpMisc.Location = New System.Drawing.Point(117, 3)
        Me.pctHelpMisc.Name = "pctHelpMisc"
        Me.pctHelpMisc.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpMisc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpMisc.TabIndex = 17
        Me.pctHelpMisc.TabStop = False
        '
        'btnRemount
        '
        Me.btnRemount.Enabled = False
        Me.btnRemount.Location = New System.Drawing.Point(6, 29)
        Me.btnRemount.Name = "btnRemount"
        Me.btnRemount.Size = New System.Drawing.Size(120, 40)
        Me.btnRemount.TabIndex = 7
        Me.btnRemount.Text = "Remount"
        Me.btnRemount.UseVisualStyleBackColor = True
        '
        'grpADBShellCommand
        '
        Me.grpADBShellCommand.Controls.Add(Me.pctHelpADBShellCommand)
        Me.grpADBShellCommand.Controls.Add(Me.chkSU)
        Me.grpADBShellCommand.Controls.Add(Me.btnADBShellCommand)
        Me.grpADBShellCommand.Controls.Add(Me.txtADBShellCommand)
        Me.grpADBShellCommand.Location = New System.Drawing.Point(436, 8)
        Me.grpADBShellCommand.Name = "grpADBShellCommand"
        Me.grpADBShellCommand.Size = New System.Drawing.Size(275, 178)
        Me.grpADBShellCommand.TabIndex = 2
        Me.grpADBShellCommand.TabStop = False
        Me.grpADBShellCommand.Text = "ADB Shell Command"
        '
        'pctHelpADBShellCommand
        '
        Me.pctHelpADBShellCommand.Image = CType(resources.GetObject("pctHelpADBShellCommand.Image"), System.Drawing.Image)
        Me.pctHelpADBShellCommand.InitialImage = CType(resources.GetObject("pctHelpADBShellCommand.InitialImage"), System.Drawing.Image)
        Me.pctHelpADBShellCommand.Location = New System.Drawing.Point(255, 3)
        Me.pctHelpADBShellCommand.Name = "pctHelpADBShellCommand"
        Me.pctHelpADBShellCommand.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpADBShellCommand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpADBShellCommand.TabIndex = 16
        Me.pctHelpADBShellCommand.TabStop = False
        '
        'chkSU
        '
        Me.chkSU.AutoSize = True
        Me.chkSU.Enabled = False
        Me.chkSU.Location = New System.Drawing.Point(113, 75)
        Me.chkSU.Name = "chkSU"
        Me.chkSU.Size = New System.Drawing.Size(42, 23)
        Me.chkSU.TabIndex = 6
        Me.chkSU.Text = "su"
        Me.chkSU.UseVisualStyleBackColor = True
        '
        'btnADBShellCommand
        '
        Me.btnADBShellCommand.Enabled = False
        Me.btnADBShellCommand.Location = New System.Drawing.Point(74, 121)
        Me.btnADBShellCommand.Name = "btnADBShellCommand"
        Me.btnADBShellCommand.Size = New System.Drawing.Size(120, 40)
        Me.btnADBShellCommand.TabIndex = 7
        Me.btnADBShellCommand.Text = "Submit"
        Me.btnADBShellCommand.UseVisualStyleBackColor = True
        '
        'txtADBShellCommand
        '
        Me.txtADBShellCommand.Location = New System.Drawing.Point(6, 33)
        Me.txtADBShellCommand.Name = "txtADBShellCommand"
        Me.txtADBShellCommand.Size = New System.Drawing.Size(263, 26)
        Me.txtADBShellCommand.TabIndex = 5
        Me.txtADBShellCommand.Text = "ls /mnt/sdcard/"
        '
        'grpADBCommand
        '
        Me.grpADBCommand.Controls.Add(Me.pctHelpADBCommand)
        Me.grpADBCommand.Controls.Add(Me.btnADBCommand)
        Me.grpADBCommand.Controls.Add(Me.txtADBCommand)
        Me.grpADBCommand.Location = New System.Drawing.Point(153, 8)
        Me.grpADBCommand.Name = "grpADBCommand"
        Me.grpADBCommand.Size = New System.Drawing.Size(275, 178)
        Me.grpADBCommand.TabIndex = 1
        Me.grpADBCommand.TabStop = False
        Me.grpADBCommand.Text = "ADB Command"
        '
        'pctHelpADBCommand
        '
        Me.pctHelpADBCommand.Image = CType(resources.GetObject("pctHelpADBCommand.Image"), System.Drawing.Image)
        Me.pctHelpADBCommand.InitialImage = CType(resources.GetObject("pctHelpADBCommand.InitialImage"), System.Drawing.Image)
        Me.pctHelpADBCommand.Location = New System.Drawing.Point(255, 3)
        Me.pctHelpADBCommand.Name = "pctHelpADBCommand"
        Me.pctHelpADBCommand.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpADBCommand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpADBCommand.TabIndex = 11
        Me.pctHelpADBCommand.TabStop = False
        '
        'btnADBCommand
        '
        Me.btnADBCommand.Enabled = False
        Me.btnADBCommand.Location = New System.Drawing.Point(80, 121)
        Me.btnADBCommand.Name = "btnADBCommand"
        Me.btnADBCommand.Size = New System.Drawing.Size(120, 40)
        Me.btnADBCommand.TabIndex = 4
        Me.btnADBCommand.Text = "Submit"
        Me.btnADBCommand.UseVisualStyleBackColor = True
        '
        'txtADBCommand
        '
        Me.txtADBCommand.Location = New System.Drawing.Point(6, 33)
        Me.txtADBCommand.Name = "txtADBCommand"
        Me.txtADBCommand.Size = New System.Drawing.Size(263, 26)
        Me.txtADBCommand.TabIndex = 3
        Me.txtADBCommand.Text = "devices"
        '
        'grpReboot
        '
        Me.grpReboot.Controls.Add(Me.pctHelpReboot)
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
        'pctHelpReboot
        '
        Me.pctHelpReboot.Image = CType(resources.GetObject("pctHelpReboot.Image"), System.Drawing.Image)
        Me.pctHelpReboot.InitialImage = CType(resources.GetObject("pctHelpReboot.InitialImage"), System.Drawing.Image)
        Me.pctHelpReboot.Location = New System.Drawing.Point(117, 3)
        Me.pctHelpReboot.Name = "pctHelpReboot"
        Me.pctHelpReboot.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpReboot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpReboot.TabIndex = 10
        Me.pctHelpReboot.TabStop = False
        '
        'btnReboot
        '
        Me.btnReboot.Enabled = False
        Me.btnReboot.Location = New System.Drawing.Point(6, 29)
        Me.btnReboot.Name = "btnReboot"
        Me.btnReboot.Size = New System.Drawing.Size(120, 40)
        Me.btnReboot.TabIndex = 0
        Me.btnReboot.Text = "System"
        Me.btnReboot.UseVisualStyleBackColor = True
        '
        'btnRecovery
        '
        Me.btnRecovery.Enabled = False
        Me.btnRecovery.Location = New System.Drawing.Point(6, 121)
        Me.btnRecovery.Name = "btnRecovery"
        Me.btnRecovery.Size = New System.Drawing.Size(120, 40)
        Me.btnRecovery.TabIndex = 2
        Me.btnRecovery.Text = "Recovery"
        Me.btnRecovery.UseVisualStyleBackColor = True
        '
        'btnBootloader
        '
        Me.btnBootloader.Enabled = False
        Me.btnBootloader.Location = New System.Drawing.Point(6, 75)
        Me.btnBootloader.Name = "btnBootloader"
        Me.btnBootloader.Size = New System.Drawing.Size(120, 40)
        Me.btnBootloader.TabIndex = 1
        Me.btnBootloader.Text = "Bootloader"
        Me.btnBootloader.UseVisualStyleBackColor = True
        '
        'tabFastboot
        '
        Me.tabFastboot.BackColor = System.Drawing.SystemColors.Control
        Me.tabFastboot.Controls.Add(Me.grpFlashCustomZip)
        Me.tabFastboot.Controls.Add(Me.grpFastbootCommand)
        Me.tabFastboot.Controls.Add(Me.grpFlashRecovery)
        Me.tabFastboot.Controls.Add(Me.grpFastboot)
        Me.tabFastboot.Location = New System.Drawing.Point(4, 28)
        Me.tabFastboot.Margin = New System.Windows.Forms.Padding(4)
        Me.tabFastboot.Name = "tabFastboot"
        Me.tabFastboot.Padding = New System.Windows.Forms.Padding(4)
        Me.tabFastboot.Size = New System.Drawing.Size(731, 468)
        Me.tabFastboot.TabIndex = 1
        Me.tabFastboot.Text = "Fastboot"
        Me.tabFastboot.ToolTipText = "Issue fastboot commands to your device."
        '
        'grpFlashCustomZip
        '
        Me.grpFlashCustomZip.Controls.Add(Me.pctHelpFlashCustomZip)
        Me.grpFlashCustomZip.Controls.Add(Me.btnBrowseCustomZip)
        Me.grpFlashCustomZip.Controls.Add(Me.txtFlashCustomZip)
        Me.grpFlashCustomZip.Controls.Add(Me.btnCustomZip)
        Me.grpFlashCustomZip.Controls.Add(Me.Label13)
        Me.grpFlashCustomZip.Location = New System.Drawing.Point(9, 249)
        Me.grpFlashCustomZip.Name = "grpFlashCustomZip"
        Me.grpFlashCustomZip.Size = New System.Drawing.Size(715, 104)
        Me.grpFlashCustomZip.TabIndex = 13
        Me.grpFlashCustomZip.TabStop = False
        Me.grpFlashCustomZip.Text = "Flash Custom Zip"
        '
        'pctHelpFlashCustomZip
        '
        Me.pctHelpFlashCustomZip.Image = CType(resources.GetObject("pctHelpFlashCustomZip.Image"), System.Drawing.Image)
        Me.pctHelpFlashCustomZip.InitialImage = CType(resources.GetObject("pctHelpFlashCustomZip.InitialImage"), System.Drawing.Image)
        Me.pctHelpFlashCustomZip.Location = New System.Drawing.Point(695, 0)
        Me.pctHelpFlashCustomZip.Name = "pctHelpFlashCustomZip"
        Me.pctHelpFlashCustomZip.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpFlashCustomZip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpFlashCustomZip.TabIndex = 14
        Me.pctHelpFlashCustomZip.TabStop = False
        '
        'btnBrowseCustomZip
        '
        Me.btnBrowseCustomZip.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseCustomZip.Location = New System.Drawing.Point(591, 22)
        Me.btnBrowseCustomZip.Name = "btnBrowseCustomZip"
        Me.btnBrowseCustomZip.Size = New System.Drawing.Size(103, 30)
        Me.btnBrowseCustomZip.TabIndex = 8
        Me.btnBrowseCustomZip.Text = "Browse..."
        Me.btnBrowseCustomZip.UseVisualStyleBackColor = True
        '
        'txtFlashCustomZip
        '
        Me.txtFlashCustomZip.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlashCustomZip.Location = New System.Drawing.Point(132, 22)
        Me.txtFlashCustomZip.Name = "txtFlashCustomZip"
        Me.txtFlashCustomZip.Size = New System.Drawing.Size(453, 26)
        Me.txtFlashCustomZip.TabIndex = 7
        '
        'btnCustomZip
        '
        Me.btnCustomZip.Enabled = False
        Me.btnCustomZip.Location = New System.Drawing.Point(277, 58)
        Me.btnCustomZip.Name = "btnCustomZip"
        Me.btnCustomZip.Size = New System.Drawing.Size(160, 40)
        Me.btnCustomZip.TabIndex = 9
        Me.btnCustomZip.Text = "Flash Custom Zip"
        Me.btnCustomZip.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(47, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 19)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Location:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpFastbootCommand
        '
        Me.grpFastbootCommand.Controls.Add(Me.pctHelpFastbootCommand)
        Me.grpFastbootCommand.Controls.Add(Me.txtFastbootCommand)
        Me.grpFastbootCommand.Controls.Add(Me.btnCustomFastboot)
        Me.grpFastbootCommand.Location = New System.Drawing.Point(153, 8)
        Me.grpFastbootCommand.Name = "grpFastbootCommand"
        Me.grpFastbootCommand.Size = New System.Drawing.Size(275, 121)
        Me.grpFastbootCommand.TabIndex = 12
        Me.grpFastbootCommand.TabStop = False
        Me.grpFastbootCommand.Text = "Fastboot Command"
        '
        'pctHelpFastbootCommand
        '
        Me.pctHelpFastbootCommand.Image = CType(resources.GetObject("pctHelpFastbootCommand.Image"), System.Drawing.Image)
        Me.pctHelpFastbootCommand.InitialImage = CType(resources.GetObject("pctHelpFastbootCommand.InitialImage"), System.Drawing.Image)
        Me.pctHelpFastbootCommand.Location = New System.Drawing.Point(255, 3)
        Me.pctHelpFastbootCommand.Name = "pctHelpFastbootCommand"
        Me.pctHelpFastbootCommand.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpFastbootCommand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpFastbootCommand.TabIndex = 14
        Me.pctHelpFastbootCommand.TabStop = False
        '
        'txtFastbootCommand
        '
        Me.txtFastbootCommand.Location = New System.Drawing.Point(6, 33)
        Me.txtFastbootCommand.Name = "txtFastbootCommand"
        Me.txtFastbootCommand.Size = New System.Drawing.Size(263, 26)
        Me.txtFastbootCommand.TabIndex = 2
        Me.txtFastbootCommand.Text = "devices"
        '
        'btnCustomFastboot
        '
        Me.btnCustomFastboot.Enabled = False
        Me.btnCustomFastboot.Location = New System.Drawing.Point(76, 75)
        Me.btnCustomFastboot.Name = "btnCustomFastboot"
        Me.btnCustomFastboot.Size = New System.Drawing.Size(120, 40)
        Me.btnCustomFastboot.TabIndex = 3
        Me.btnCustomFastboot.Text = "Submit"
        Me.btnCustomFastboot.UseVisualStyleBackColor = True
        '
        'grpFlashRecovery
        '
        Me.grpFlashRecovery.Controls.Add(Me.pctHelpFlashRecovery)
        Me.grpFlashRecovery.Controls.Add(Me.btnBrowseFlashRecovery)
        Me.grpFlashRecovery.Controls.Add(Me.txtFlashRecovery)
        Me.grpFlashRecovery.Controls.Add(Me.Label12)
        Me.grpFlashRecovery.Controls.Add(Me.btnFlashRecovery)
        Me.grpFlashRecovery.Location = New System.Drawing.Point(8, 137)
        Me.grpFlashRecovery.Name = "grpFlashRecovery"
        Me.grpFlashRecovery.Size = New System.Drawing.Size(715, 104)
        Me.grpFlashRecovery.TabIndex = 11
        Me.grpFlashRecovery.TabStop = False
        Me.grpFlashRecovery.Text = "Flash Recovery"
        '
        'pctHelpFlashRecovery
        '
        Me.pctHelpFlashRecovery.Image = CType(resources.GetObject("pctHelpFlashRecovery.Image"), System.Drawing.Image)
        Me.pctHelpFlashRecovery.InitialImage = CType(resources.GetObject("pctHelpFlashRecovery.InitialImage"), System.Drawing.Image)
        Me.pctHelpFlashRecovery.Location = New System.Drawing.Point(695, 0)
        Me.pctHelpFlashRecovery.Name = "pctHelpFlashRecovery"
        Me.pctHelpFlashRecovery.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpFlashRecovery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpFlashRecovery.TabIndex = 14
        Me.pctHelpFlashRecovery.TabStop = False
        '
        'btnBrowseFlashRecovery
        '
        Me.btnBrowseFlashRecovery.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseFlashRecovery.Location = New System.Drawing.Point(591, 22)
        Me.btnBrowseFlashRecovery.Name = "btnBrowseFlashRecovery"
        Me.btnBrowseFlashRecovery.Size = New System.Drawing.Size(103, 30)
        Me.btnBrowseFlashRecovery.TabIndex = 5
        Me.btnBrowseFlashRecovery.Text = "Browse..."
        Me.btnBrowseFlashRecovery.UseVisualStyleBackColor = True
        '
        'txtFlashRecovery
        '
        Me.txtFlashRecovery.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlashRecovery.Location = New System.Drawing.Point(132, 22)
        Me.txtFlashRecovery.Name = "txtFlashRecovery"
        Me.txtFlashRecovery.Size = New System.Drawing.Size(453, 26)
        Me.txtFlashRecovery.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(47, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 19)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Location:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFlashRecovery
        '
        Me.btnFlashRecovery.Enabled = False
        Me.btnFlashRecovery.Location = New System.Drawing.Point(278, 58)
        Me.btnFlashRecovery.Name = "btnFlashRecovery"
        Me.btnFlashRecovery.Size = New System.Drawing.Size(160, 40)
        Me.btnFlashRecovery.TabIndex = 6
        Me.btnFlashRecovery.Text = "Flash Recovery"
        Me.btnFlashRecovery.UseVisualStyleBackColor = True
        '
        'grpFastboot
        '
        Me.grpFastboot.Controls.Add(Me.pctHelpFastbootReboot)
        Me.grpFastboot.Controls.Add(Me.btnFastbootBootloader)
        Me.grpFastboot.Controls.Add(Me.btnFastbootReboot)
        Me.grpFastboot.Location = New System.Drawing.Point(8, 8)
        Me.grpFastboot.Name = "grpFastboot"
        Me.grpFastboot.Size = New System.Drawing.Size(137, 121)
        Me.grpFastboot.TabIndex = 7
        Me.grpFastboot.TabStop = False
        Me.grpFastboot.Text = "Reboot"
        '
        'pctHelpFastbootReboot
        '
        Me.pctHelpFastbootReboot.Image = CType(resources.GetObject("pctHelpFastbootReboot.Image"), System.Drawing.Image)
        Me.pctHelpFastbootReboot.InitialImage = CType(resources.GetObject("pctHelpFastbootReboot.InitialImage"), System.Drawing.Image)
        Me.pctHelpFastbootReboot.Location = New System.Drawing.Point(117, 3)
        Me.pctHelpFastbootReboot.Name = "pctHelpFastbootReboot"
        Me.pctHelpFastbootReboot.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpFastbootReboot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpFastbootReboot.TabIndex = 14
        Me.pctHelpFastbootReboot.TabStop = False
        '
        'btnFastbootBootloader
        '
        Me.btnFastbootBootloader.Enabled = False
        Me.btnFastbootBootloader.Location = New System.Drawing.Point(6, 75)
        Me.btnFastbootBootloader.Name = "btnFastbootBootloader"
        Me.btnFastbootBootloader.Size = New System.Drawing.Size(120, 40)
        Me.btnFastbootBootloader.TabIndex = 1
        Me.btnFastbootBootloader.Text = "Bootloader"
        Me.btnFastbootBootloader.UseVisualStyleBackColor = True
        '
        'btnFastbootReboot
        '
        Me.btnFastbootReboot.Enabled = False
        Me.btnFastbootReboot.Location = New System.Drawing.Point(6, 29)
        Me.btnFastbootReboot.Name = "btnFastbootReboot"
        Me.btnFastbootReboot.Size = New System.Drawing.Size(120, 40)
        Me.btnFastbootReboot.TabIndex = 0
        Me.btnFastbootReboot.Text = "System"
        Me.btnFastbootReboot.UseVisualStyleBackColor = True
        '
        'tabPush
        '
        Me.tabPush.BackColor = System.Drawing.SystemColors.Control
        Me.tabPush.Controls.Add(Me.grpPushDir)
        Me.tabPush.Controls.Add(Me.grpPushFile)
        Me.tabPush.Location = New System.Drawing.Point(4, 28)
        Me.tabPush.Name = "tabPush"
        Me.tabPush.Size = New System.Drawing.Size(731, 468)
        Me.tabPush.TabIndex = 2
        Me.tabPush.Text = "Push"
        Me.tabPush.ToolTipText = "Push files to your device."
        '
        'grpPushDir
        '
        Me.grpPushDir.Controls.Add(Me.pctHelpPushDir)
        Me.grpPushDir.Controls.Add(Me.btnBrowsePushDir)
        Me.grpPushDir.Controls.Add(Me.txtPushDirDest)
        Me.grpPushDir.Controls.Add(Me.btnPushDir)
        Me.grpPushDir.Controls.Add(Me.txtPushDirSource)
        Me.grpPushDir.Controls.Add(Me.Label1)
        Me.grpPushDir.Location = New System.Drawing.Point(8, 176)
        Me.grpPushDir.Name = "grpPushDir"
        Me.grpPushDir.Size = New System.Drawing.Size(633, 160)
        Me.grpPushDir.TabIndex = 3
        Me.grpPushDir.TabStop = False
        Me.grpPushDir.Text = "Push Directory"
        '
        'pctHelpPushDir
        '
        Me.pctHelpPushDir.Image = CType(resources.GetObject("pctHelpPushDir.Image"), System.Drawing.Image)
        Me.pctHelpPushDir.InitialImage = CType(resources.GetObject("pctHelpPushDir.InitialImage"), System.Drawing.Image)
        Me.pctHelpPushDir.Location = New System.Drawing.Point(613, 0)
        Me.pctHelpPushDir.Name = "pctHelpPushDir"
        Me.pctHelpPushDir.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpPushDir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpPushDir.TabIndex = 19
        Me.pctHelpPushDir.TabStop = False
        '
        'btnBrowsePushDir
        '
        Me.btnBrowsePushDir.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowsePushDir.Location = New System.Drawing.Point(6, 34)
        Me.btnBrowsePushDir.Name = "btnBrowsePushDir"
        Me.btnBrowsePushDir.Size = New System.Drawing.Size(103, 30)
        Me.btnBrowsePushDir.TabIndex = 4
        Me.btnBrowsePushDir.Text = "Browse..."
        Me.btnBrowsePushDir.UseVisualStyleBackColor = True
        '
        'txtPushDirDest
        '
        Me.txtPushDirDest.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPushDirDest.Location = New System.Drawing.Point(115, 70)
        Me.txtPushDirDest.Name = "txtPushDirDest"
        Me.txtPushDirDest.Size = New System.Drawing.Size(494, 26)
        Me.txtPushDirDest.TabIndex = 6
        Me.txtPushDirDest.Text = "/mnt/sdcard/"
        '
        'btnPushDir
        '
        Me.btnPushDir.Enabled = False
        Me.btnPushDir.Location = New System.Drawing.Point(241, 106)
        Me.btnPushDir.Name = "btnPushDir"
        Me.btnPushDir.Size = New System.Drawing.Size(150, 40)
        Me.btnPushDir.TabIndex = 7
        Me.btnPushDir.Text = "Push Directory"
        Me.btnPushDir.UseVisualStyleBackColor = True
        '
        'txtPushDirSource
        '
        Me.txtPushDirSource.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPushDirSource.Location = New System.Drawing.Point(115, 34)
        Me.txtPushDirSource.Name = "txtPushDirSource"
        Me.txtPushDirSource.Size = New System.Drawing.Size(494, 26)
        Me.txtPushDirSource.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Destination:"
        '
        'grpPushFile
        '
        Me.grpPushFile.Controls.Add(Me.pctHelpPushFile)
        Me.grpPushFile.Controls.Add(Me.btnBrowsePushFile)
        Me.grpPushFile.Controls.Add(Me.txtPushFileDest)
        Me.grpPushFile.Controls.Add(Me.btnPushFile)
        Me.grpPushFile.Controls.Add(Me.txtPushFileSource)
        Me.grpPushFile.Controls.Add(Me.Label2)
        Me.grpPushFile.Location = New System.Drawing.Point(8, 8)
        Me.grpPushFile.Name = "grpPushFile"
        Me.grpPushFile.Size = New System.Drawing.Size(633, 160)
        Me.grpPushFile.TabIndex = 2
        Me.grpPushFile.TabStop = False
        Me.grpPushFile.Text = "Push File"
        '
        'pctHelpPushFile
        '
        Me.pctHelpPushFile.Image = CType(resources.GetObject("pctHelpPushFile.Image"), System.Drawing.Image)
        Me.pctHelpPushFile.InitialImage = CType(resources.GetObject("pctHelpPushFile.InitialImage"), System.Drawing.Image)
        Me.pctHelpPushFile.Location = New System.Drawing.Point(613, 0)
        Me.pctHelpPushFile.Name = "pctHelpPushFile"
        Me.pctHelpPushFile.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpPushFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpPushFile.TabIndex = 15
        Me.pctHelpPushFile.TabStop = False
        '
        'btnBrowsePushFile
        '
        Me.btnBrowsePushFile.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowsePushFile.Location = New System.Drawing.Point(6, 34)
        Me.btnBrowsePushFile.Name = "btnBrowsePushFile"
        Me.btnBrowsePushFile.Size = New System.Drawing.Size(103, 30)
        Me.btnBrowsePushFile.TabIndex = 0
        Me.btnBrowsePushFile.Text = "Browse..."
        Me.btnBrowsePushFile.UseVisualStyleBackColor = True
        '
        'txtPushFileDest
        '
        Me.txtPushFileDest.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPushFileDest.Location = New System.Drawing.Point(115, 70)
        Me.txtPushFileDest.Name = "txtPushFileDest"
        Me.txtPushFileDest.Size = New System.Drawing.Size(494, 26)
        Me.txtPushFileDest.TabIndex = 2
        Me.txtPushFileDest.Text = "/mnt/sdcard/"
        '
        'btnPushFile
        '
        Me.btnPushFile.Enabled = False
        Me.btnPushFile.Location = New System.Drawing.Point(241, 106)
        Me.btnPushFile.Name = "btnPushFile"
        Me.btnPushFile.Size = New System.Drawing.Size(150, 40)
        Me.btnPushFile.TabIndex = 3
        Me.btnPushFile.Text = "Push File"
        Me.btnPushFile.UseVisualStyleBackColor = True
        '
        'txtPushFileSource
        '
        Me.txtPushFileSource.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPushFileSource.Location = New System.Drawing.Point(115, 34)
        Me.txtPushFileSource.Name = "txtPushFileSource"
        Me.txtPushFileSource.Size = New System.Drawing.Size(494, 26)
        Me.txtPushFileSource.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Destination:"
        '
        'tabPull
        '
        Me.tabPull.BackColor = System.Drawing.SystemColors.Control
        Me.tabPull.Controls.Add(Me.grpPullDir)
        Me.tabPull.Controls.Add(Me.grpPullFile)
        Me.tabPull.Location = New System.Drawing.Point(4, 28)
        Me.tabPull.Name = "tabPull"
        Me.tabPull.Size = New System.Drawing.Size(731, 468)
        Me.tabPull.TabIndex = 3
        Me.tabPull.Text = "Pull"
        '
        'grpPullDir
        '
        Me.grpPullDir.Controls.Add(Me.pctHelpPullDir)
        Me.grpPullDir.Controls.Add(Me.btnBrowsePullDir)
        Me.grpPullDir.Controls.Add(Me.txtPullDirDest)
        Me.grpPullDir.Controls.Add(Me.btnPullDir)
        Me.grpPullDir.Controls.Add(Me.txtPullDirSource)
        Me.grpPullDir.Controls.Add(Me.Label5)
        Me.grpPullDir.Location = New System.Drawing.Point(8, 176)
        Me.grpPullDir.Name = "grpPullDir"
        Me.grpPullDir.Size = New System.Drawing.Size(633, 160)
        Me.grpPullDir.TabIndex = 6
        Me.grpPullDir.TabStop = False
        Me.grpPullDir.Text = "Pull Directory"
        '
        'pctHelpPullDir
        '
        Me.pctHelpPullDir.Image = CType(resources.GetObject("pctHelpPullDir.Image"), System.Drawing.Image)
        Me.pctHelpPullDir.InitialImage = CType(resources.GetObject("pctHelpPullDir.InitialImage"), System.Drawing.Image)
        Me.pctHelpPullDir.Location = New System.Drawing.Point(613, 0)
        Me.pctHelpPullDir.Name = "pctHelpPullDir"
        Me.pctHelpPullDir.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpPullDir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpPullDir.TabIndex = 15
        Me.pctHelpPullDir.TabStop = False
        '
        'btnBrowsePullDir
        '
        Me.btnBrowsePullDir.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowsePullDir.Location = New System.Drawing.Point(6, 70)
        Me.btnBrowsePullDir.Name = "btnBrowsePullDir"
        Me.btnBrowsePullDir.Size = New System.Drawing.Size(103, 30)
        Me.btnBrowsePullDir.TabIndex = 5
        Me.btnBrowsePullDir.Text = "Browse..."
        Me.btnBrowsePullDir.UseVisualStyleBackColor = True
        '
        'txtPullDirDest
        '
        Me.txtPullDirDest.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPullDirDest.Location = New System.Drawing.Point(115, 70)
        Me.txtPullDirDest.Name = "txtPullDirDest"
        Me.txtPullDirDest.Size = New System.Drawing.Size(494, 26)
        Me.txtPullDirDest.TabIndex = 6
        '
        'btnPullDir
        '
        Me.btnPullDir.Enabled = False
        Me.btnPullDir.Location = New System.Drawing.Point(232, 106)
        Me.btnPullDir.Name = "btnPullDir"
        Me.btnPullDir.Size = New System.Drawing.Size(150, 40)
        Me.btnPullDir.TabIndex = 7
        Me.btnPullDir.Text = "Pull Directory"
        Me.btnPullDir.UseVisualStyleBackColor = True
        '
        'txtPullDirSource
        '
        Me.txtPullDirSource.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPullDirSource.Location = New System.Drawing.Point(115, 34)
        Me.txtPullDirSource.Name = "txtPullDirSource"
        Me.txtPullDirSource.Size = New System.Drawing.Size(494, 26)
        Me.txtPullDirSource.TabIndex = 4
        Me.txtPullDirSource.Text = "/mnt/sdcard/"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Source:"
        '
        'grpPullFile
        '
        Me.grpPullFile.Controls.Add(Me.pctHelpPullFile)
        Me.grpPullFile.Controls.Add(Me.btnBrowsePullFile)
        Me.grpPullFile.Controls.Add(Me.txtPullFileDest)
        Me.grpPullFile.Controls.Add(Me.btnPullFile)
        Me.grpPullFile.Controls.Add(Me.txtPullFileSource)
        Me.grpPullFile.Controls.Add(Me.Label6)
        Me.grpPullFile.Location = New System.Drawing.Point(8, 8)
        Me.grpPullFile.Name = "grpPullFile"
        Me.grpPullFile.Size = New System.Drawing.Size(633, 160)
        Me.grpPullFile.TabIndex = 5
        Me.grpPullFile.TabStop = False
        Me.grpPullFile.Text = "Pull File"
        '
        'pctHelpPullFile
        '
        Me.pctHelpPullFile.Image = CType(resources.GetObject("pctHelpPullFile.Image"), System.Drawing.Image)
        Me.pctHelpPullFile.InitialImage = CType(resources.GetObject("pctHelpPullFile.InitialImage"), System.Drawing.Image)
        Me.pctHelpPullFile.Location = New System.Drawing.Point(613, 0)
        Me.pctHelpPullFile.Name = "pctHelpPullFile"
        Me.pctHelpPullFile.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpPullFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpPullFile.TabIndex = 15
        Me.pctHelpPullFile.TabStop = False
        '
        'btnBrowsePullFile
        '
        Me.btnBrowsePullFile.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowsePullFile.Location = New System.Drawing.Point(6, 70)
        Me.btnBrowsePullFile.Name = "btnBrowsePullFile"
        Me.btnBrowsePullFile.Size = New System.Drawing.Size(103, 30)
        Me.btnBrowsePullFile.TabIndex = 1
        Me.btnBrowsePullFile.Text = "Browse..."
        Me.btnBrowsePullFile.UseVisualStyleBackColor = True
        '
        'txtPullFileDest
        '
        Me.txtPullFileDest.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPullFileDest.Location = New System.Drawing.Point(115, 70)
        Me.txtPullFileDest.Name = "txtPullFileDest"
        Me.txtPullFileDest.Size = New System.Drawing.Size(494, 26)
        Me.txtPullFileDest.TabIndex = 2
        '
        'btnPullFile
        '
        Me.btnPullFile.Enabled = False
        Me.btnPullFile.Location = New System.Drawing.Point(232, 106)
        Me.btnPullFile.Name = "btnPullFile"
        Me.btnPullFile.Size = New System.Drawing.Size(150, 40)
        Me.btnPullFile.TabIndex = 3
        Me.btnPullFile.Text = "Pull File"
        Me.btnPullFile.UseVisualStyleBackColor = True
        '
        'txtPullFileSource
        '
        Me.txtPullFileSource.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPullFileSource.Location = New System.Drawing.Point(115, 34)
        Me.txtPullFileSource.Name = "txtPullFileSource"
        Me.txtPullFileSource.Size = New System.Drawing.Size(494, 26)
        Me.txtPullFileSource.TabIndex = 0
        Me.txtPullFileSource.Text = "/mnt/sdcard/"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Source:"
        '
        'tabSplash1
        '
        Me.tabSplash1.BackColor = System.Drawing.SystemColors.Control
        Me.tabSplash1.Controls.Add(Me.grpCreateSplash)
        Me.tabSplash1.Location = New System.Drawing.Point(4, 28)
        Me.tabSplash1.Name = "tabSplash1"
        Me.tabSplash1.Size = New System.Drawing.Size(731, 468)
        Me.tabSplash1.TabIndex = 4
        Me.tabSplash1.Text = "Create Splash"
        '
        'grpCreateSplash
        '
        Me.grpCreateSplash.Controls.Add(Me.pctHelpCreateSplash)
        Me.grpCreateSplash.Controls.Add(Me.btnBrowseCreateDestination)
        Me.grpCreateSplash.Controls.Add(Me.btnBrowseAndroidInfo)
        Me.grpCreateSplash.Controls.Add(Me.Label10)
        Me.grpCreateSplash.Controls.Add(Me.txtCreateFilename)
        Me.grpCreateSplash.Controls.Add(Me.Label9)
        Me.grpCreateSplash.Controls.Add(Me.txtCreateDestination)
        Me.grpCreateSplash.Controls.Add(Me.btnCreateSplash)
        Me.grpCreateSplash.Controls.Add(Me.Label4)
        Me.grpCreateSplash.Controls.Add(Me.btnBrowseCreateSplashImage)
        Me.grpCreateSplash.Controls.Add(Me.txtAndroidInfo)
        Me.grpCreateSplash.Controls.Add(Me.txtCreateLoc)
        Me.grpCreateSplash.Controls.Add(Me.Label3)
        Me.grpCreateSplash.Location = New System.Drawing.Point(8, 8)
        Me.grpCreateSplash.Name = "grpCreateSplash"
        Me.grpCreateSplash.Size = New System.Drawing.Size(720, 219)
        Me.grpCreateSplash.TabIndex = 13
        Me.grpCreateSplash.TabStop = False
        Me.grpCreateSplash.Text = "Create Splash Image"
        '
        'pctHelpCreateSplash
        '
        Me.pctHelpCreateSplash.Image = CType(resources.GetObject("pctHelpCreateSplash.Image"), System.Drawing.Image)
        Me.pctHelpCreateSplash.InitialImage = CType(resources.GetObject("pctHelpCreateSplash.InitialImage"), System.Drawing.Image)
        Me.pctHelpCreateSplash.Location = New System.Drawing.Point(700, 0)
        Me.pctHelpCreateSplash.Name = "pctHelpCreateSplash"
        Me.pctHelpCreateSplash.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpCreateSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpCreateSplash.TabIndex = 15
        Me.pctHelpCreateSplash.TabStop = False
        '
        'btnBrowseCreateDestination
        '
        Me.btnBrowseCreateDestination.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseCreateDestination.Location = New System.Drawing.Point(611, 101)
        Me.btnBrowseCreateDestination.Name = "btnBrowseCreateDestination"
        Me.btnBrowseCreateDestination.Size = New System.Drawing.Size(103, 30)
        Me.btnBrowseCreateDestination.TabIndex = 5
        Me.btnBrowseCreateDestination.Text = "Browse..."
        Me.btnBrowseCreateDestination.UseVisualStyleBackColor = True
        '
        'btnBrowseAndroidInfo
        '
        Me.btnBrowseAndroidInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseAndroidInfo.Location = New System.Drawing.Point(611, 65)
        Me.btnBrowseAndroidInfo.Name = "btnBrowseAndroidInfo"
        Me.btnBrowseAndroidInfo.Size = New System.Drawing.Size(103, 30)
        Me.btnBrowseAndroidInfo.TabIndex = 3
        Me.btnBrowseAndroidInfo.Text = "Browse..."
        Me.btnBrowseAndroidInfo.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(32, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 19)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "ZIP Filename:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCreateFilename
        '
        Me.txtCreateFilename.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateFilename.Location = New System.Drawing.Point(151, 137)
        Me.txtCreateFilename.Name = "txtCreateFilename"
        Me.txtCreateFilename.Size = New System.Drawing.Size(454, 26)
        Me.txtCreateFilename.TabIndex = 6
        Me.txtCreateFilename.Text = "splash.zip"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(44, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 19)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Destination:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCreateDestination
        '
        Me.txtCreateDestination.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateDestination.Location = New System.Drawing.Point(151, 101)
        Me.txtCreateDestination.Name = "txtCreateDestination"
        Me.txtCreateDestination.Size = New System.Drawing.Size(454, 26)
        Me.txtCreateDestination.TabIndex = 4
        '
        'btnCreateSplash
        '
        Me.btnCreateSplash.Enabled = False
        Me.btnCreateSplash.Location = New System.Drawing.Point(280, 173)
        Me.btnCreateSplash.Name = "btnCreateSplash"
        Me.btnCreateSplash.Size = New System.Drawing.Size(160, 40)
        Me.btnCreateSplash.TabIndex = 7
        Me.btnCreateSplash.Text = "Create Splash"
        Me.btnCreateSplash.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 19)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Android-Info.txt:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBrowseCreateSplashImage
        '
        Me.btnBrowseCreateSplashImage.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseCreateSplashImage.Location = New System.Drawing.Point(611, 29)
        Me.btnBrowseCreateSplashImage.Name = "btnBrowseCreateSplashImage"
        Me.btnBrowseCreateSplashImage.Size = New System.Drawing.Size(103, 30)
        Me.btnBrowseCreateSplashImage.TabIndex = 1
        Me.btnBrowseCreateSplashImage.Text = "Browse..."
        Me.btnBrowseCreateSplashImage.UseVisualStyleBackColor = True
        '
        'txtAndroidInfo
        '
        Me.txtAndroidInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAndroidInfo.Location = New System.Drawing.Point(151, 65)
        Me.txtAndroidInfo.Name = "txtAndroidInfo"
        Me.txtAndroidInfo.Size = New System.Drawing.Size(454, 26)
        Me.txtAndroidInfo.TabIndex = 2
        '
        'txtCreateLoc
        '
        Me.txtCreateLoc.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreateLoc.Location = New System.Drawing.Point(151, 29)
        Me.txtCreateLoc.Name = "txtCreateLoc"
        Me.txtCreateLoc.Size = New System.Drawing.Size(454, 26)
        Me.txtCreateLoc.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "PNG Location:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabSplash2
        '
        Me.tabSplash2.BackColor = System.Drawing.SystemColors.Control
        Me.tabSplash2.Controls.Add(Me.grpFlashSplash)
        Me.tabSplash2.Controls.Add(Me.grpSplash)
        Me.tabSplash2.Location = New System.Drawing.Point(4, 28)
        Me.tabSplash2.Name = "tabSplash2"
        Me.tabSplash2.Size = New System.Drawing.Size(731, 468)
        Me.tabSplash2.TabIndex = 6
        Me.tabSplash2.Text = "Backup/Flash Splash"
        '
        'grpFlashSplash
        '
        Me.grpFlashSplash.Controls.Add(Me.pctHelpFlashSplash)
        Me.grpFlashSplash.Controls.Add(Me.btnBrowseFlashSplash)
        Me.grpFlashSplash.Controls.Add(Me.Label8)
        Me.grpFlashSplash.Controls.Add(Me.txtFlashSplash)
        Me.grpFlashSplash.Controls.Add(Me.btnFlashSplash)
        Me.grpFlashSplash.Location = New System.Drawing.Point(8, 163)
        Me.grpFlashSplash.Name = "grpFlashSplash"
        Me.grpFlashSplash.Size = New System.Drawing.Size(720, 111)
        Me.grpFlashSplash.TabIndex = 17
        Me.grpFlashSplash.TabStop = False
        Me.grpFlashSplash.Text = "Flash Splash Image"
        '
        'pctHelpFlashSplash
        '
        Me.pctHelpFlashSplash.Image = CType(resources.GetObject("pctHelpFlashSplash.Image"), System.Drawing.Image)
        Me.pctHelpFlashSplash.InitialImage = CType(resources.GetObject("pctHelpFlashSplash.InitialImage"), System.Drawing.Image)
        Me.pctHelpFlashSplash.Location = New System.Drawing.Point(700, 0)
        Me.pctHelpFlashSplash.Name = "pctHelpFlashSplash"
        Me.pctHelpFlashSplash.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpFlashSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpFlashSplash.TabIndex = 18
        Me.pctHelpFlashSplash.TabStop = False
        '
        'btnBrowseFlashSplash
        '
        Me.btnBrowseFlashSplash.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseFlashSplash.Location = New System.Drawing.Point(611, 29)
        Me.btnBrowseFlashSplash.Name = "btnBrowseFlashSplash"
        Me.btnBrowseFlashSplash.Size = New System.Drawing.Size(103, 30)
        Me.btnBrowseFlashSplash.TabIndex = 1
        Me.btnBrowseFlashSplash.Text = "Browse..."
        Me.btnBrowseFlashSplash.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 19)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Splash Location:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFlashSplash
        '
        Me.txtFlashSplash.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlashSplash.Location = New System.Drawing.Point(150, 29)
        Me.txtFlashSplash.Name = "txtFlashSplash"
        Me.txtFlashSplash.Size = New System.Drawing.Size(455, 26)
        Me.txtFlashSplash.TabIndex = 0
        '
        'btnFlashSplash
        '
        Me.btnFlashSplash.Enabled = False
        Me.btnFlashSplash.Location = New System.Drawing.Point(280, 65)
        Me.btnFlashSplash.Name = "btnFlashSplash"
        Me.btnFlashSplash.Size = New System.Drawing.Size(160, 40)
        Me.btnFlashSplash.TabIndex = 2
        Me.btnFlashSplash.Text = "Flash Splash"
        Me.btnFlashSplash.UseVisualStyleBackColor = True
        '
        'grpSplash
        '
        Me.grpSplash.Controls.Add(Me.pctHelpBackupSplash)
        Me.grpSplash.Controls.Add(Me.Label11)
        Me.grpSplash.Controls.Add(Me.txtBackupFilename)
        Me.grpSplash.Controls.Add(Me.btnBrowseBackupSplash)
        Me.grpSplash.Controls.Add(Me.Label7)
        Me.grpSplash.Controls.Add(Me.txtBackupSplash)
        Me.grpSplash.Controls.Add(Me.btnBackupSplash)
        Me.grpSplash.Location = New System.Drawing.Point(8, 8)
        Me.grpSplash.Name = "grpSplash"
        Me.grpSplash.Size = New System.Drawing.Size(720, 147)
        Me.grpSplash.TabIndex = 16
        Me.grpSplash.TabStop = False
        Me.grpSplash.Text = "Backup Splash"
        '
        'pctHelpBackupSplash
        '
        Me.pctHelpBackupSplash.Image = CType(resources.GetObject("pctHelpBackupSplash.Image"), System.Drawing.Image)
        Me.pctHelpBackupSplash.InitialImage = CType(resources.GetObject("pctHelpBackupSplash.InitialImage"), System.Drawing.Image)
        Me.pctHelpBackupSplash.Location = New System.Drawing.Point(700, 0)
        Me.pctHelpBackupSplash.Name = "pctHelpBackupSplash"
        Me.pctHelpBackupSplash.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpBackupSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpBackupSplash.TabIndex = 31
        Me.pctHelpBackupSplash.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 19)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "IMG Filename:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBackupFilename
        '
        Me.txtBackupFilename.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBackupFilename.Location = New System.Drawing.Point(151, 65)
        Me.txtBackupFilename.Name = "txtBackupFilename"
        Me.txtBackupFilename.Size = New System.Drawing.Size(454, 26)
        Me.txtBackupFilename.TabIndex = 2
        Me.txtBackupFilename.Text = "backup.img"
        '
        'btnBrowseBackupSplash
        '
        Me.btnBrowseBackupSplash.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseBackupSplash.Location = New System.Drawing.Point(611, 29)
        Me.btnBrowseBackupSplash.Name = "btnBrowseBackupSplash"
        Me.btnBrowseBackupSplash.Size = New System.Drawing.Size(103, 30)
        Me.btnBrowseBackupSplash.TabIndex = 1
        Me.btnBrowseBackupSplash.Text = "Browse..."
        Me.btnBrowseBackupSplash.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 19)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Destination:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBackupSplash
        '
        Me.txtBackupSplash.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBackupSplash.Location = New System.Drawing.Point(151, 29)
        Me.txtBackupSplash.Name = "txtBackupSplash"
        Me.txtBackupSplash.Size = New System.Drawing.Size(454, 26)
        Me.txtBackupSplash.TabIndex = 0
        '
        'btnBackupSplash
        '
        Me.btnBackupSplash.Enabled = False
        Me.btnBackupSplash.Location = New System.Drawing.Point(280, 101)
        Me.btnBackupSplash.Name = "btnBackupSplash"
        Me.btnBackupSplash.Size = New System.Drawing.Size(160, 40)
        Me.btnBackupSplash.TabIndex = 3
        Me.btnBackupSplash.Text = "Backup Splash"
        Me.btnBackupSplash.UseVisualStyleBackColor = True
        '
        'tabLogcat
        '
        Me.tabLogcat.BackColor = System.Drawing.SystemColors.Control
        Me.tabLogcat.Controls.Add(Me.grpLogcatSD)
        Me.tabLogcat.Controls.Add(Me.grpTags)
        Me.tabLogcat.Controls.Add(Me.grpBuffer)
        Me.tabLogcat.Controls.Add(Me.GroupBox2)
        Me.tabLogcat.Controls.Add(Me.btnStartLogcat)
        Me.tabLogcat.Controls.Add(Me.grpPriority)
        Me.tabLogcat.Location = New System.Drawing.Point(4, 28)
        Me.tabLogcat.Name = "tabLogcat"
        Me.tabLogcat.Size = New System.Drawing.Size(731, 468)
        Me.tabLogcat.TabIndex = 5
        Me.tabLogcat.Text = "Logcat"
        '
        'grpLogcatSD
        '
        Me.grpLogcatSD.Controls.Add(Me.pctHelpLogcatSD)
        Me.grpLogcatSD.Controls.Add(Me.Label14)
        Me.grpLogcatSD.Controls.Add(Me.txtLogcatSD)
        Me.grpLogcatSD.Location = New System.Drawing.Point(261, 142)
        Me.grpLogcatSD.Name = "grpLogcatSD"
        Me.grpLogcatSD.Size = New System.Drawing.Size(451, 69)
        Me.grpLogcatSD.TabIndex = 18
        Me.grpLogcatSD.TabStop = False
        Me.grpLogcatSD.Text = "Save Logcat to Device"
        '
        'pctHelpLogcatSD
        '
        Me.pctHelpLogcatSD.Image = CType(resources.GetObject("pctHelpLogcatSD.Image"), System.Drawing.Image)
        Me.pctHelpLogcatSD.InitialImage = CType(resources.GetObject("pctHelpLogcatSD.InitialImage"), System.Drawing.Image)
        Me.pctHelpLogcatSD.Location = New System.Drawing.Point(422, 3)
        Me.pctHelpLogcatSD.Name = "pctHelpLogcatSD"
        Me.pctHelpLogcatSD.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpLogcatSD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpLogcatSD.TabIndex = 18
        Me.pctHelpLogcatSD.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 19)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Location:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLogcatSD
        '
        Me.txtLogcatSD.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogcatSD.Location = New System.Drawing.Point(100, 29)
        Me.txtLogcatSD.Name = "txtLogcatSD"
        Me.txtLogcatSD.Size = New System.Drawing.Size(336, 26)
        Me.txtLogcatSD.TabIndex = 0
        '
        'grpTags
        '
        Me.grpTags.Controls.Add(Me.pctHelpTags)
        Me.grpTags.Controls.Add(Me.TextBox1)
        Me.grpTags.Location = New System.Drawing.Point(361, 8)
        Me.grpTags.Name = "grpTags"
        Me.grpTags.Size = New System.Drawing.Size(362, 62)
        Me.grpTags.TabIndex = 3
        Me.grpTags.TabStop = False
        Me.grpTags.Text = "Specific Tags"
        '
        'pctHelpTags
        '
        Me.pctHelpTags.Image = CType(resources.GetObject("pctHelpTags.Image"), System.Drawing.Image)
        Me.pctHelpTags.InitialImage = CType(resources.GetObject("pctHelpTags.InitialImage"), System.Drawing.Image)
        Me.pctHelpTags.Location = New System.Drawing.Point(342, 3)
        Me.pctHelpTags.Name = "pctHelpTags"
        Me.pctHelpTags.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpTags.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpTags.TabIndex = 22
        Me.pctHelpTags.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(350, 26)
        Me.TextBox1.TabIndex = 0
        '
        'grpBuffer
        '
        Me.grpBuffer.Controls.Add(Me.pctHelpBuffer)
        Me.grpBuffer.Controls.Add(Me.radMain)
        Me.grpBuffer.Controls.Add(Me.radEvents)
        Me.grpBuffer.Controls.Add(Me.radRadio)
        Me.grpBuffer.Location = New System.Drawing.Point(261, 8)
        Me.grpBuffer.Name = "grpBuffer"
        Me.grpBuffer.Size = New System.Drawing.Size(93, 128)
        Me.grpBuffer.TabIndex = 2
        Me.grpBuffer.TabStop = False
        Me.grpBuffer.Text = "Buffer"
        '
        'pctHelpBuffer
        '
        Me.pctHelpBuffer.Image = CType(resources.GetObject("pctHelpBuffer.Image"), System.Drawing.Image)
        Me.pctHelpBuffer.InitialImage = CType(resources.GetObject("pctHelpBuffer.InitialImage"), System.Drawing.Image)
        Me.pctHelpBuffer.Location = New System.Drawing.Point(73, 3)
        Me.pctHelpBuffer.Name = "pctHelpBuffer"
        Me.pctHelpBuffer.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpBuffer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpBuffer.TabIndex = 21
        Me.pctHelpBuffer.TabStop = False
        '
        'radMain
        '
        Me.radMain.AutoSize = True
        Me.radMain.Location = New System.Drawing.Point(6, 95)
        Me.radMain.Name = "radMain"
        Me.radMain.Size = New System.Drawing.Size(59, 23)
        Me.radMain.TabIndex = 2
        Me.radMain.TabStop = True
        Me.radMain.Text = "Main"
        Me.radMain.UseVisualStyleBackColor = True
        '
        'radEvents
        '
        Me.radEvents.AutoSize = True
        Me.radEvents.Location = New System.Drawing.Point(6, 62)
        Me.radEvents.Name = "radEvents"
        Me.radEvents.Size = New System.Drawing.Size(67, 23)
        Me.radEvents.TabIndex = 1
        Me.radEvents.TabStop = True
        Me.radEvents.Text = "Events"
        Me.radEvents.UseVisualStyleBackColor = True
        '
        'radRadio
        '
        Me.radRadio.AutoSize = True
        Me.radRadio.Location = New System.Drawing.Point(6, 29)
        Me.radRadio.Name = "radRadio"
        Me.radRadio.Size = New System.Drawing.Size(63, 23)
        Me.radRadio.TabIndex = 0
        Me.radRadio.TabStop = True
        Me.radRadio.Text = "Radio"
        Me.radRadio.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pctHelpOutput)
        Me.GroupBox2.Controls.Add(Me.radLong)
        Me.GroupBox2.Controls.Add(Me.radThreadTime)
        Me.GroupBox2.Controls.Add(Me.radTime)
        Me.GroupBox2.Controls.Add(Me.radRaw)
        Me.GroupBox2.Controls.Add(Me.radTag)
        Me.GroupBox2.Controls.Add(Me.radProcess)
        Me.GroupBox2.Controls.Add(Me.radBrief)
        Me.GroupBox2.Location = New System.Drawing.Point(122, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(133, 260)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output Format"
        '
        'pctHelpOutput
        '
        Me.pctHelpOutput.Image = CType(resources.GetObject("pctHelpOutput.Image"), System.Drawing.Image)
        Me.pctHelpOutput.InitialImage = CType(resources.GetObject("pctHelpOutput.InitialImage"), System.Drawing.Image)
        Me.pctHelpOutput.Location = New System.Drawing.Point(113, 3)
        Me.pctHelpOutput.Name = "pctHelpOutput"
        Me.pctHelpOutput.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpOutput.TabIndex = 20
        Me.pctHelpOutput.TabStop = False
        '
        'radLong
        '
        Me.radLong.AutoSize = True
        Me.radLong.Location = New System.Drawing.Point(6, 227)
        Me.radLong.Name = "radLong"
        Me.radLong.Size = New System.Drawing.Size(58, 23)
        Me.radLong.TabIndex = 6
        Me.radLong.TabStop = True
        Me.radLong.Text = "Long"
        Me.radLong.UseVisualStyleBackColor = True
        '
        'radThreadTime
        '
        Me.radThreadTime.AutoSize = True
        Me.radThreadTime.Location = New System.Drawing.Point(6, 194)
        Me.radThreadTime.Name = "radThreadTime"
        Me.radThreadTime.Size = New System.Drawing.Size(101, 23)
        Me.radThreadTime.TabIndex = 5
        Me.radThreadTime.TabStop = True
        Me.radThreadTime.Text = "ThreadTime"
        Me.radThreadTime.UseVisualStyleBackColor = True
        '
        'radTime
        '
        Me.radTime.AutoSize = True
        Me.radTime.Location = New System.Drawing.Point(6, 161)
        Me.radTime.Name = "radTime"
        Me.radTime.Size = New System.Drawing.Size(58, 23)
        Me.radTime.TabIndex = 4
        Me.radTime.TabStop = True
        Me.radTime.Text = "Time"
        Me.radTime.UseVisualStyleBackColor = True
        '
        'radRaw
        '
        Me.radRaw.AutoSize = True
        Me.radRaw.Location = New System.Drawing.Point(6, 128)
        Me.radRaw.Name = "radRaw"
        Me.radRaw.Size = New System.Drawing.Size(54, 23)
        Me.radRaw.TabIndex = 3
        Me.radRaw.TabStop = True
        Me.radRaw.Text = "Raw"
        Me.radRaw.UseVisualStyleBackColor = True
        '
        'radTag
        '
        Me.radTag.AutoSize = True
        Me.radTag.Location = New System.Drawing.Point(6, 95)
        Me.radTag.Name = "radTag"
        Me.radTag.Size = New System.Drawing.Size(49, 23)
        Me.radTag.TabIndex = 2
        Me.radTag.TabStop = True
        Me.radTag.Text = "Tag"
        Me.radTag.UseVisualStyleBackColor = True
        '
        'radProcess
        '
        Me.radProcess.AutoSize = True
        Me.radProcess.Location = New System.Drawing.Point(6, 62)
        Me.radProcess.Name = "radProcess"
        Me.radProcess.Size = New System.Drawing.Size(74, 23)
        Me.radProcess.TabIndex = 1
        Me.radProcess.TabStop = True
        Me.radProcess.Text = "Process"
        Me.radProcess.UseVisualStyleBackColor = True
        '
        'radBrief
        '
        Me.radBrief.AutoSize = True
        Me.radBrief.Location = New System.Drawing.Point(6, 29)
        Me.radBrief.Name = "radBrief"
        Me.radBrief.Size = New System.Drawing.Size(56, 23)
        Me.radBrief.TabIndex = 0
        Me.radBrief.TabStop = True
        Me.radBrief.Text = "Brief"
        Me.radBrief.UseVisualStyleBackColor = True
        '
        'btnStartLogcat
        '
        Me.btnStartLogcat.Location = New System.Drawing.Point(290, 391)
        Me.btnStartLogcat.Name = "btnStartLogcat"
        Me.btnStartLogcat.Size = New System.Drawing.Size(160, 40)
        Me.btnStartLogcat.TabIndex = 2
        Me.btnStartLogcat.Text = "Start Logcat"
        Me.btnStartLogcat.UseVisualStyleBackColor = True
        '
        'grpPriority
        '
        Me.grpPriority.Controls.Add(Me.pctHelpPriority)
        Me.grpPriority.Controls.Add(Me.radFatal)
        Me.grpPriority.Controls.Add(Me.radError)
        Me.grpPriority.Controls.Add(Me.radWarning)
        Me.grpPriority.Controls.Add(Me.radInfo)
        Me.grpPriority.Controls.Add(Me.radDebug)
        Me.grpPriority.Controls.Add(Me.radVerbose)
        Me.grpPriority.Location = New System.Drawing.Point(8, 8)
        Me.grpPriority.Name = "grpPriority"
        Me.grpPriority.Size = New System.Drawing.Size(108, 227)
        Me.grpPriority.TabIndex = 0
        Me.grpPriority.TabStop = False
        Me.grpPriority.Text = "Priority"
        '
        'pctHelpPriority
        '
        Me.pctHelpPriority.Image = CType(resources.GetObject("pctHelpPriority.Image"), System.Drawing.Image)
        Me.pctHelpPriority.InitialImage = CType(resources.GetObject("pctHelpPriority.InitialImage"), System.Drawing.Image)
        Me.pctHelpPriority.Location = New System.Drawing.Point(88, 3)
        Me.pctHelpPriority.Name = "pctHelpPriority"
        Me.pctHelpPriority.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpPriority.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpPriority.TabIndex = 19
        Me.pctHelpPriority.TabStop = False
        '
        'radFatal
        '
        Me.radFatal.AutoSize = True
        Me.radFatal.Location = New System.Drawing.Point(6, 194)
        Me.radFatal.Name = "radFatal"
        Me.radFatal.Size = New System.Drawing.Size(57, 23)
        Me.radFatal.TabIndex = 5
        Me.radFatal.TabStop = True
        Me.radFatal.Text = "Fatal"
        Me.radFatal.UseVisualStyleBackColor = True
        '
        'radError
        '
        Me.radError.AutoSize = True
        Me.radError.Location = New System.Drawing.Point(6, 161)
        Me.radError.Name = "radError"
        Me.radError.Size = New System.Drawing.Size(57, 23)
        Me.radError.TabIndex = 4
        Me.radError.TabStop = True
        Me.radError.Text = "Error"
        Me.radError.UseVisualStyleBackColor = True
        '
        'radWarning
        '
        Me.radWarning.AutoSize = True
        Me.radWarning.Location = New System.Drawing.Point(6, 128)
        Me.radWarning.Name = "radWarning"
        Me.radWarning.Size = New System.Drawing.Size(80, 23)
        Me.radWarning.TabIndex = 3
        Me.radWarning.TabStop = True
        Me.radWarning.Text = "Warning"
        Me.radWarning.UseVisualStyleBackColor = True
        '
        'radInfo
        '
        Me.radInfo.AutoSize = True
        Me.radInfo.Location = New System.Drawing.Point(6, 95)
        Me.radInfo.Name = "radInfo"
        Me.radInfo.Size = New System.Drawing.Size(52, 23)
        Me.radInfo.TabIndex = 2
        Me.radInfo.TabStop = True
        Me.radInfo.Text = "Info"
        Me.radInfo.UseVisualStyleBackColor = True
        '
        'radDebug
        '
        Me.radDebug.AutoSize = True
        Me.radDebug.Location = New System.Drawing.Point(6, 62)
        Me.radDebug.Name = "radDebug"
        Me.radDebug.Size = New System.Drawing.Size(68, 23)
        Me.radDebug.TabIndex = 1
        Me.radDebug.TabStop = True
        Me.radDebug.Text = "Debug"
        Me.radDebug.UseVisualStyleBackColor = True
        '
        'radVerbose
        '
        Me.radVerbose.AutoSize = True
        Me.radVerbose.Location = New System.Drawing.Point(6, 29)
        Me.radVerbose.Name = "radVerbose"
        Me.radVerbose.Size = New System.Drawing.Size(76, 23)
        Me.radVerbose.TabIndex = 0
        Me.radVerbose.TabStop = True
        Me.radVerbose.Text = "Verbose"
        Me.radVerbose.UseVisualStyleBackColor = True
        '
        'grpDevInfo
        '
        Me.grpDevInfo.Controls.Add(Me.pctDevice)
        Me.grpDevInfo.Controls.Add(Me.lblModelName)
        Me.grpDevInfo.Controls.Add(Me.lblManuName)
        Me.grpDevInfo.Controls.Add(Me.lblModel)
        Me.grpDevInfo.Controls.Add(Me.lblManufacturer)
        Me.grpDevInfo.Location = New System.Drawing.Point(295, 33)
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
        Me.lblModelName.TabIndex = 7
        Me.lblModelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblManuName
        '
        Me.lblManuName.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManuName.Location = New System.Drawing.Point(138, 36)
        Me.lblManuName.Name = "lblManuName"
        Me.lblManuName.Size = New System.Drawing.Size(200, 30)
        Me.lblManuName.TabIndex = 6
        Me.lblManuName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblModel
        '
        Me.lblModel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(7, 66)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(125, 30)
        Me.lblModel.TabIndex = 5
        Me.lblModel.Text = "Model:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblManufacturer
        '
        Me.lblManufacturer.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManufacturer.Location = New System.Drawing.Point(7, 36)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(125, 30)
        Me.lblManufacturer.TabIndex = 4
        Me.lblManufacturer.Text = "Manufacturer:"
        Me.lblManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpConsole
        '
        Me.grpConsole.Controls.Add(Me.btnClearConsole)
        Me.grpConsole.Controls.Add(Me.txtOutput)
        Me.grpConsole.Location = New System.Drawing.Point(758, 33)
        Me.grpConsole.Name = "grpConsole"
        Me.grpConsole.Size = New System.Drawing.Size(658, 769)
        Me.grpConsole.TabIndex = 11
        Me.grpConsole.TabStop = False
        Me.grpConsole.Text = "Console Output"
        '
        'btnClearConsole
        '
        Me.btnClearConsole.Enabled = False
        Me.btnClearConsole.Location = New System.Drawing.Point(271, 712)
        Me.btnClearConsole.Name = "btnClearConsole"
        Me.btnClearConsole.Size = New System.Drawing.Size(120, 40)
        Me.btnClearConsole.TabIndex = 4
        Me.btnClearConsole.Text = "Clear"
        Me.btnClearConsole.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(16, 33)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.txtOutput.Size = New System.Drawing.Size(636, 673)
        Me.txtOutput.TabIndex = 3
        Me.txtOutput.Text = ""
        '
        'grpDevices
        '
        Me.grpDevices.Controls.Add(Me.pctHelpConnectedDevices)
        Me.grpDevices.Controls.Add(Me.lstDevices)
        Me.grpDevices.Location = New System.Drawing.Point(13, 33)
        Me.grpDevices.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpDevices.Name = "grpDevices"
        Me.grpDevices.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpDevices.Size = New System.Drawing.Size(275, 186)
        Me.grpDevices.TabIndex = 10
        Me.grpDevices.TabStop = False
        Me.grpDevices.Text = "Connected Devices"
        '
        'pctHelpConnectedDevices
        '
        Me.pctHelpConnectedDevices.Image = CType(resources.GetObject("pctHelpConnectedDevices.Image"), System.Drawing.Image)
        Me.pctHelpConnectedDevices.InitialImage = CType(resources.GetObject("pctHelpConnectedDevices.InitialImage"), System.Drawing.Image)
        Me.pctHelpConnectedDevices.Location = New System.Drawing.Point(255, 0)
        Me.pctHelpConnectedDevices.Name = "pctHelpConnectedDevices"
        Me.pctHelpConnectedDevices.Size = New System.Drawing.Size(20, 20)
        Me.pctHelpConnectedDevices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctHelpConnectedDevices.TabIndex = 18
        Me.pctHelpConnectedDevices.TabStop = False
        '
        'lstDevices
        '
        Me.lstDevices.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDevices.FormattingEnabled = True
        Me.lstDevices.ItemHeight = 14
        Me.lstDevices.Location = New System.Drawing.Point(8, 36)
        Me.lstDevices.Name = "lstDevices"
        Me.lstDevices.Size = New System.Drawing.Size(260, 130)
        Me.lstDevices.TabIndex = 0
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(50, 227)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(200, 40)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "&Refresh Devices"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'mnu
        '
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuHelp})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(1422, 24)
        Me.mnu.TabIndex = 14
        Me.mnu.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpIndex, Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpIndex
        '
        Me.mnuHelpIndex.Name = "mnuHelpIndex"
        Me.mnuHelpIndex.Size = New System.Drawing.Size(107, 22)
        Me.mnuHelpIndex.Text = "&Index"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuHelpAbout.Text = "A&bout"
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1422, 798)
        Me.Controls.Add(Me.mnu)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.grpDevInfo)
        Me.Controls.Add(Me.grpConsole)
        Me.Controls.Add(Me.grpDevices)
        Me.Controls.Add(Me.tabMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADB GUI"
        Me.tabMain.ResumeLayout(False)
        Me.tabADB.ResumeLayout(False)
        Me.grpADBMisc.ResumeLayout(False)
        CType(Me.pctHelpMisc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpADBShellCommand.ResumeLayout(False)
        Me.grpADBShellCommand.PerformLayout()
        CType(Me.pctHelpADBShellCommand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpADBCommand.ResumeLayout(False)
        Me.grpADBCommand.PerformLayout()
        CType(Me.pctHelpADBCommand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpReboot.ResumeLayout(False)
        CType(Me.pctHelpReboot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFastboot.ResumeLayout(False)
        Me.grpFlashCustomZip.ResumeLayout(False)
        Me.grpFlashCustomZip.PerformLayout()
        CType(Me.pctHelpFlashCustomZip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFastbootCommand.ResumeLayout(False)
        Me.grpFastbootCommand.PerformLayout()
        CType(Me.pctHelpFastbootCommand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFlashRecovery.ResumeLayout(False)
        Me.grpFlashRecovery.PerformLayout()
        CType(Me.pctHelpFlashRecovery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFastboot.ResumeLayout(False)
        CType(Me.pctHelpFastbootReboot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPush.ResumeLayout(False)
        Me.grpPushDir.ResumeLayout(False)
        Me.grpPushDir.PerformLayout()
        CType(Me.pctHelpPushDir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPushFile.ResumeLayout(False)
        Me.grpPushFile.PerformLayout()
        CType(Me.pctHelpPushFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPull.ResumeLayout(False)
        Me.grpPullDir.ResumeLayout(False)
        Me.grpPullDir.PerformLayout()
        CType(Me.pctHelpPullDir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPullFile.ResumeLayout(False)
        Me.grpPullFile.PerformLayout()
        CType(Me.pctHelpPullFile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSplash1.ResumeLayout(False)
        Me.grpCreateSplash.ResumeLayout(False)
        Me.grpCreateSplash.PerformLayout()
        CType(Me.pctHelpCreateSplash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSplash2.ResumeLayout(False)
        Me.grpFlashSplash.ResumeLayout(False)
        Me.grpFlashSplash.PerformLayout()
        CType(Me.pctHelpFlashSplash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSplash.ResumeLayout(False)
        Me.grpSplash.PerformLayout()
        CType(Me.pctHelpBackupSplash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLogcat.ResumeLayout(False)
        Me.grpLogcatSD.ResumeLayout(False)
        Me.grpLogcatSD.PerformLayout()
        CType(Me.pctHelpLogcatSD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTags.ResumeLayout(False)
        Me.grpTags.PerformLayout()
        CType(Me.pctHelpTags, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBuffer.ResumeLayout(False)
        Me.grpBuffer.PerformLayout()
        CType(Me.pctHelpBuffer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pctHelpOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPriority.ResumeLayout(False)
        Me.grpPriority.PerformLayout()
        CType(Me.pctHelpPriority, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDevInfo.ResumeLayout(False)
        CType(Me.pctDevice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConsole.ResumeLayout(False)
        Me.grpDevices.ResumeLayout(False)
        CType(Me.pctHelpConnectedDevices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents tabPush As System.Windows.Forms.TabPage
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
    Friend WithEvents grpADBCommand As System.Windows.Forms.GroupBox
    Friend WithEvents btnADBCommand As System.Windows.Forms.Button
    Friend WithEvents txtADBCommand As System.Windows.Forms.TextBox
    Friend WithEvents grpADBShellCommand As System.Windows.Forms.GroupBox
    Friend WithEvents btnADBShellCommand As System.Windows.Forms.Button
    Friend WithEvents txtADBShellCommand As System.Windows.Forms.TextBox
    Friend WithEvents tabPull As System.Windows.Forms.TabPage
    Friend WithEvents grpPullDir As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowsePullDir As System.Windows.Forms.Button
    Friend WithEvents txtPullDirDest As System.Windows.Forms.TextBox
    Friend WithEvents btnPullDir As System.Windows.Forms.Button
    Friend WithEvents txtPullDirSource As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grpPullFile As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowsePullFile As System.Windows.Forms.Button
    Friend WithEvents txtPullFileDest As System.Windows.Forms.TextBox
    Friend WithEvents btnPullFile As System.Windows.Forms.Button
    Friend WithEvents txtPullFileSource As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkSU As System.Windows.Forms.CheckBox
    Friend WithEvents tabSplash1 As System.Windows.Forms.TabPage
    Friend WithEvents tabLogcat As System.Windows.Forms.TabPage
    Friend WithEvents btnCustomFastboot As System.Windows.Forms.Button
    Friend WithEvents grpFastboot As System.Windows.Forms.GroupBox
    Friend WithEvents btnFastbootBootloader As System.Windows.Forms.Button
    Friend WithEvents btnFastbootReboot As System.Windows.Forms.Button
    Friend WithEvents btnFlashRecovery As System.Windows.Forms.Button
    Friend WithEvents btnCustomZip As System.Windows.Forms.Button
    Friend WithEvents grpFlashRecovery As System.Windows.Forms.GroupBox
    Friend WithEvents grpFastbootCommand As System.Windows.Forms.GroupBox
    Friend WithEvents txtFastbootCommand As System.Windows.Forms.TextBox
    Friend WithEvents btnClearConsole As System.Windows.Forms.Button
    Friend WithEvents grpADBMisc As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemount As System.Windows.Forms.Button
    Friend WithEvents grpCreateSplash As System.Windows.Forms.GroupBox
    Friend WithEvents btnCreateSplash As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseCreateSplashImage As System.Windows.Forms.Button
    Friend WithEvents txtAndroidInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtCreateLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseAndroidInfo As System.Windows.Forms.Button
    Friend WithEvents btnBrowseCreateDestination As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCreateDestination As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCreateFilename As System.Windows.Forms.TextBox
    Friend WithEvents tabSplash2 As System.Windows.Forms.TabPage
    Friend WithEvents grpFlashSplash As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowseFlashSplash As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFlashSplash As System.Windows.Forms.TextBox
    Friend WithEvents btnFlashSplash As System.Windows.Forms.Button
    Friend WithEvents grpSplash As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowseBackupSplash As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBackupSplash As System.Windows.Forms.TextBox
    Friend WithEvents btnBackupSplash As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtBackupFilename As System.Windows.Forms.TextBox
    Friend WithEvents mnu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpIndex As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpFlashCustomZip As System.Windows.Forms.GroupBox
    Friend WithEvents btnBrowseCustomZip As System.Windows.Forms.Button
    Friend WithEvents txtFlashCustomZip As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseFlashRecovery As System.Windows.Forms.Button
    Friend WithEvents txtFlashRecovery As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents pctHelpReboot As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpADBCommand As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpADBShellCommand As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpMisc As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpConnectedDevices As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpFlashCustomZip As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpFastbootCommand As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpFlashRecovery As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpFastbootReboot As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpPushDir As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpPushFile As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpPullDir As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpPullFile As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpCreateSplash As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpFlashSplash As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpBackupSplash As System.Windows.Forms.PictureBox
    Friend WithEvents grpPriority As System.Windows.Forms.GroupBox
    Friend WithEvents radFatal As System.Windows.Forms.RadioButton
    Friend WithEvents radError As System.Windows.Forms.RadioButton
    Friend WithEvents radWarning As System.Windows.Forms.RadioButton
    Friend WithEvents radInfo As System.Windows.Forms.RadioButton
    Friend WithEvents radDebug As System.Windows.Forms.RadioButton
    Friend WithEvents radVerbose As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radThreadTime As System.Windows.Forms.RadioButton
    Friend WithEvents radTime As System.Windows.Forms.RadioButton
    Friend WithEvents radRaw As System.Windows.Forms.RadioButton
    Friend WithEvents radTag As System.Windows.Forms.RadioButton
    Friend WithEvents radProcess As System.Windows.Forms.RadioButton
    Friend WithEvents radBrief As System.Windows.Forms.RadioButton
    Friend WithEvents radLong As System.Windows.Forms.RadioButton
    Friend WithEvents grpBuffer As System.Windows.Forms.GroupBox
    Friend WithEvents radMain As System.Windows.Forms.RadioButton
    Friend WithEvents radEvents As System.Windows.Forms.RadioButton
    Friend WithEvents radRadio As System.Windows.Forms.RadioButton
    Friend WithEvents grpTags As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents pctHelpTags As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpBuffer As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpOutput As System.Windows.Forms.PictureBox
    Friend WithEvents pctHelpPriority As System.Windows.Forms.PictureBox
    Friend WithEvents grpLogcatSD As System.Windows.Forms.GroupBox
    Friend WithEvents pctHelpLogcatSD As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtLogcatSD As System.Windows.Forms.TextBox
    Friend WithEvents btnStartLogcat As System.Windows.Forms.Button
End Class
