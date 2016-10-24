<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Me.txtHelp = New System.Windows.Forms.RichTextBox()
        Me.tabHelp = New System.Windows.Forms.TabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.tabADB = New System.Windows.Forms.TabPage()
        Me.tabFastboot = New System.Windows.Forms.TabPage()
        Me.tabPush = New System.Windows.Forms.TabPage()
        Me.tabPull = New System.Windows.Forms.TabPage()
        Me.tabLogcat = New System.Windows.Forms.TabPage()
        Me.tabSplash = New System.Windows.Forms.TabPage()
        Me.tabHelp.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtHelp
        '
        Me.txtHelp.BackColor = System.Drawing.SystemColors.Control
        Me.txtHelp.Location = New System.Drawing.Point(12, 43)
        Me.txtHelp.Name = "txtHelp"
        Me.txtHelp.Size = New System.Drawing.Size(758, 694)
        Me.txtHelp.TabIndex = 0
        Me.txtHelp.Text = ""
        '
        'tabHelp
        '
        Me.tabHelp.Controls.Add(Me.tabGeneral)
        Me.tabHelp.Controls.Add(Me.tabADB)
        Me.tabHelp.Controls.Add(Me.tabFastboot)
        Me.tabHelp.Controls.Add(Me.tabPush)
        Me.tabHelp.Controls.Add(Me.tabPull)
        Me.tabHelp.Controls.Add(Me.tabSplash)
        Me.tabHelp.Controls.Add(Me.tabLogcat)
        Me.tabHelp.Location = New System.Drawing.Point(12, 13)
        Me.tabHelp.Name = "tabHelp"
        Me.tabHelp.SelectedIndex = 0
        Me.tabHelp.Size = New System.Drawing.Size(750, 32)
        Me.tabHelp.TabIndex = 1
        '
        'tabGeneral
        '
        Me.tabGeneral.BackColor = System.Drawing.SystemColors.Control
        Me.tabGeneral.Location = New System.Drawing.Point(4, 32)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(742, 0)
        Me.tabGeneral.TabIndex = 1
        Me.tabGeneral.Text = "General"
        '
        'tabADB
        '
        Me.tabADB.BackColor = System.Drawing.SystemColors.Control
        Me.tabADB.Location = New System.Drawing.Point(4, 32)
        Me.tabADB.Name = "tabADB"
        Me.tabADB.Padding = New System.Windows.Forms.Padding(3)
        Me.tabADB.Size = New System.Drawing.Size(742, 0)
        Me.tabADB.TabIndex = 0
        Me.tabADB.Text = "ADB"
        '
        'tabFastboot
        '
        Me.tabFastboot.BackColor = System.Drawing.SystemColors.Control
        Me.tabFastboot.Location = New System.Drawing.Point(4, 32)
        Me.tabFastboot.Name = "tabFastboot"
        Me.tabFastboot.Size = New System.Drawing.Size(742, 0)
        Me.tabFastboot.TabIndex = 2
        Me.tabFastboot.Text = "Fastboot"
        '
        'tabPush
        '
        Me.tabPush.BackColor = System.Drawing.SystemColors.Control
        Me.tabPush.Location = New System.Drawing.Point(4, 32)
        Me.tabPush.Name = "tabPush"
        Me.tabPush.Size = New System.Drawing.Size(742, 0)
        Me.tabPush.TabIndex = 3
        Me.tabPush.Text = "Push"
        '
        'tabPull
        '
        Me.tabPull.BackColor = System.Drawing.SystemColors.Control
        Me.tabPull.Location = New System.Drawing.Point(4, 32)
        Me.tabPull.Name = "tabPull"
        Me.tabPull.Size = New System.Drawing.Size(742, 0)
        Me.tabPull.TabIndex = 4
        Me.tabPull.Text = "Pull"
        '
        'tabLogcat
        '
        Me.tabLogcat.BackColor = System.Drawing.SystemColors.Control
        Me.tabLogcat.Location = New System.Drawing.Point(4, 32)
        Me.tabLogcat.Name = "tabLogcat"
        Me.tabLogcat.Size = New System.Drawing.Size(742, 0)
        Me.tabLogcat.TabIndex = 5
        Me.tabLogcat.Text = "Logcat"
        '
        'tabSplash
        '
        Me.tabSplash.BackColor = System.Drawing.SystemColors.Control
        Me.tabSplash.Location = New System.Drawing.Point(4, 32)
        Me.tabSplash.Name = "tabSplash"
        Me.tabSplash.Size = New System.Drawing.Size(742, 0)
        Me.tabSplash.TabIndex = 6
        Me.tabSplash.Text = "Splash Images"
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 755)
        Me.Controls.Add(Me.txtHelp)
        Me.Controls.Add(Me.tabHelp)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Help"
        Me.tabHelp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtHelp As System.Windows.Forms.RichTextBox
    Friend WithEvents tabHelp As System.Windows.Forms.TabControl
    Friend WithEvents tabADB As System.Windows.Forms.TabPage
    Friend WithEvents tabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabFastboot As System.Windows.Forms.TabPage
    Friend WithEvents tabPush As System.Windows.Forms.TabPage
    Friend WithEvents tabPull As System.Windows.Forms.TabPage
    Friend WithEvents tabLogcat As System.Windows.Forms.TabPage
    Friend WithEvents tabSplash As System.Windows.Forms.TabPage
End Class
