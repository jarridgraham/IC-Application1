<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tbStartLive = New System.Windows.Forms.ToolStripButton()
        Me.tbImageSettings = New System.Windows.Forms.ToolStripButton()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tbDevice = New System.Windows.Forms.ToolStripButton()
        Me.tbStopLive = New System.Windows.Forms.ToolStripButton()
        Me.sbVideoFormat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sbDeviceName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.menuItemDevice = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuImageSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLiveStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLiveStop = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IcImagingControl1 = New TIS.Imaging.ICImagingControl()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.toolStrip1.SuspendLayout()
        Me.statusStrip1.SuspendLayout()
        Me.menuStrip1.SuspendLayout()
        CType(Me.IcImagingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbStartLive
        '
        Me.tbStartLive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbStartLive.Image = CType(resources.GetObject("tbStartLive.Image"), System.Drawing.Image)
        Me.tbStartLive.ImageTransparentColor = System.Drawing.Color.Silver
        Me.tbStartLive.Name = "tbStartLive"
        Me.tbStartLive.Size = New System.Drawing.Size(23, 22)
        Me.tbStartLive.Text = "Start Live Video"
        '
        'tbImageSettings
        '
        Me.tbImageSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbImageSettings.Image = CType(resources.GetObject("tbImageSettings.Image"), System.Drawing.Image)
        Me.tbImageSettings.ImageTransparentColor = System.Drawing.Color.Silver
        Me.tbImageSettings.Name = "tbImageSettings"
        Me.tbImageSettings.Size = New System.Drawing.Size(23, 22)
        Me.tbImageSettings.Text = "Image Settings"
        '
        'toolStrip1
        '
        Me.toolStrip1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbDevice, Me.tbImageSettings, Me.tbStartLive, Me.tbStopLive})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(644, 25)
        Me.toolStrip1.TabIndex = 11
        Me.toolStrip1.Text = "toolStrip1"
        '
        'tbDevice
        '
        Me.tbDevice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbDevice.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tbDevice.Image = CType(resources.GetObject("tbDevice.Image"), System.Drawing.Image)
        Me.tbDevice.ImageTransparentColor = System.Drawing.Color.Silver
        Me.tbDevice.Name = "tbDevice"
        Me.tbDevice.Size = New System.Drawing.Size(23, 22)
        Me.tbDevice.Text = "Device Settings"
        '
        'tbStopLive
        '
        Me.tbStopLive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbStopLive.Image = CType(resources.GetObject("tbStopLive.Image"), System.Drawing.Image)
        Me.tbStopLive.ImageTransparentColor = System.Drawing.Color.Silver
        Me.tbStopLive.Name = "tbStopLive"
        Me.tbStopLive.Size = New System.Drawing.Size(23, 22)
        Me.tbStopLive.Text = "Stop Live Video"
        '
        'sbVideoFormat
        '
        Me.sbVideoFormat.Name = "sbVideoFormat"
        Me.sbVideoFormat.Size = New System.Drawing.Size(31, 17)
        Me.sbVideoFormat.Text = "n / a"
        '
        'sbDeviceName
        '
        Me.sbDeviceName.Name = "sbDeviceName"
        Me.sbDeviceName.Size = New System.Drawing.Size(31, 17)
        Me.sbDeviceName.Text = "n / a"
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbDeviceName, Me.sbVideoFormat})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 558)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(644, 22)
        Me.statusStrip1.TabIndex = 12
        Me.statusStrip1.Text = "statusStrip1"
        '
        'menuItemDevice
        '
        Me.menuItemDevice.Name = "menuItemDevice"
        Me.menuItemDevice.Size = New System.Drawing.Size(180, 22)
        Me.menuItemDevice.Text = "Open / setup device"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuItemDevice, Me.menuImageSettings, Me.menuLiveStart, Me.menuLiveStop})
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(54, 20)
        Me.toolStripMenuItem1.Text = "Device"
        '
        'menuImageSettings
        '
        Me.menuImageSettings.Name = "menuImageSettings"
        Me.menuImageSettings.Size = New System.Drawing.Size(180, 22)
        Me.menuImageSettings.Text = "Properties"
        '
        'menuLiveStart
        '
        Me.menuLiveStart.Name = "menuLiveStart"
        Me.menuLiveStart.Size = New System.Drawing.Size(180, 22)
        Me.menuLiveStart.Text = "Start live"
        '
        'menuLiveStop
        '
        Me.menuLiveStop.Name = "menuLiveStop"
        Me.menuLiveStop.Size = New System.Drawing.Size(180, 22)
        Me.menuLiveStop.Text = "Stop live"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(644, 24)
        Me.menuStrip1.TabIndex = 10
        Me.menuStrip1.Text = "menuStrip1"
        '
        'IcImagingControl1
        '
        Me.IcImagingControl1.BackColor = System.Drawing.Color.White
        Me.IcImagingControl1.DeviceListChangedExecutionMode = TIS.Imaging.EventExecutionMode.Invoke
        Me.IcImagingControl1.DeviceLostExecutionMode = TIS.Imaging.EventExecutionMode.AsyncInvoke
        Me.IcImagingControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IcImagingControl1.ImageAvailableExecutionMode = TIS.Imaging.EventExecutionMode.MultiThreaded
        Me.IcImagingControl1.LiveDisplayPosition = New System.Drawing.Point(0, 0)
        Me.IcImagingControl1.Location = New System.Drawing.Point(0, 49)
        Me.IcImagingControl1.MemoryCurrentGrabberColorformat = TIS.Imaging.ICImagingControlColorformats.ICRGB32
        Me.IcImagingControl1.Name = "IcImagingControl1"
        Me.IcImagingControl1.Size = New System.Drawing.Size(644, 509)
        Me.IcImagingControl1.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(262, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(61, 20)
        Me.TextBox1.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 580)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.IcImagingControl1)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "IC Application1"
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        CType(Me.IcImagingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents tbStartLive As System.Windows.Forms.ToolStripButton
    Private WithEvents tbImageSettings As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents tbDevice As System.Windows.Forms.ToolStripButton
    Private WithEvents tbStopLive As System.Windows.Forms.ToolStripButton


    Private WithEvents sbVideoFormat As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents sbDeviceName As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip

    Private WithEvents menuItemDevice As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuImageSettings As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuLiveStart As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuLiveStop As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuStrip1 As System.Windows.Forms.MenuStrip

    Friend WithEvents IcImagingControl1 As TIS.Imaging.ICImagingControl
    Friend WithEvents TextBox1 As TextBox

End Class
