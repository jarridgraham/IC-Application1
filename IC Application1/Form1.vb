Public Class Form1

    Private Delegate Sub DeviceLostDelegate()

    Private VCDProp As TIS.Imaging.VCDHelpers.VCDSimpleProperty

    Private Delegate Sub ShowBufferDelegate(ByVal buffer As TIS.Imaging.ImageBuffer)

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' VCDProp = TIS.Imaging.VCDHelpers.VCDSimpleModule.GetSimplePropertyContainer(IcImagingControl1.VCDPropertyItems)

        'Open the last used video capture device.
        Try
            IcImagingControl1.LoadDeviceStateFromFile("device.xml", True)
        Catch
            ' Either the xml file does not exist or the device
            ' could not be loaded. In both cases we do nothing and proceed.
        End Try
        'Setup IC Imaging Control for continuous image processing.

        IcImagingControl1.LiveCaptureContinuous = True


        IcImagingControl1.LiveDisplay = False


        UpdateControls()

        SetStatusbarTexts()

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If IcImagingControl1.DeviceValid = True Then
            IcImagingControl1.LiveStop()
        End If
    End Sub

    '
    ' Open a new video capture device. If the selected device could be opened sucessfully,
    ' its name and settings is save in the file "device.xml".
    ' This application tries to open the video capture device described by the file "device.xml"
    ' the next time it is started.
    '
    Private Sub OpenVideoCaptureDevice()
        If IcImagingControl1.DeviceValid Then
            IcImagingControl1.LiveStop()
        Else
            IcImagingControl1.Device = ""
        End If
        IcImagingControl1.ShowDeviceSettingsDialog()
        If IcImagingControl1.DeviceValid Then
            IcImagingControl1.SaveDeviceStateToFile("device.xml")
        End If
        UpdateControls()

        SetStatusbarTexts()

    End Sub

    '
    ' Show the device's property dialog for exposure, brightness etc. The 
    ' changes that were made using the dialog are saved to the file 'device.xml'.
    '
    Private Sub ShowDeviceProperties()
        If IcImagingControl1.DeviceValid Then
            IcImagingControl1.ShowPropertyDialog()
            IcImagingControl1.SaveDeviceStateToFile("device.xml")
        End If
    End Sub

    '
    ' Start the live video and update the state of the start/stop button.
    '
    Private Sub StartLiveVideo()
        If IcImagingControl1.DeviceValid Then
            IcImagingControl1.LiveStart()
            UpdateControls()
        End If
    End Sub

    '
    ' Stop the live video and update the state of the start/stop button.
    '
    Private Sub StopLiveVideo()
        If IcImagingControl1.DeviceValid Then
            IcImagingControl1.LiveStop()
            UpdateControls()
        End If
    End Sub

    '
    ' Update the controls in the toolbar and the menu, according
    ' to the device state.
    '
    Private Sub UpdateControls()

        menuImageSettings.Enabled = IcImagingControl1.DeviceValid

        tbImageSettings.Enabled = IcImagingControl1.DeviceValid

        If IcImagingControl1.DeviceValid Then
            menuLiveStart.Enabled = Not IcImagingControl1.LiveVideoRunning
            menuItemDevice.Enabled = Not IcImagingControl1.LiveVideoRunning
            menuLiveStop.Enabled = IcImagingControl1.LiveVideoRunning

            tbStartLive.Enabled = Not IcImagingControl1.LiveVideoRunning
            tbDevice.Enabled = Not IcImagingControl1.LiveVideoRunning
            tbStopLive.Enabled = IcImagingControl1.LiveVideoRunning

        Else
            menuLiveStart.Enabled = False
            menuLiveStop.Enabled = False
            menuItemDevice.Enabled = True

            tbStartLive.Enabled = False
            tbStopLive.Enabled = False
            tbDevice.Enabled = True

        End If
    End Sub

    '
    ' Render the name of the video capture device and the video format on the
    ' status bar.
    '
    Private Sub SetStatusbarTexts()
        If IcImagingControl1.DeviceValid Then
            sbDeviceName.Text = IcImagingControl1.Device
            sbVideoFormat.Text = IcImagingControl1.VideoFormat
        Else
            sbDeviceName.Text = "No video capture device opened."
            sbVideoFormat.Text = ""
        End If
    End Sub

    '
    ' Menu event handler subs.
    '

    Private Sub menuItemDevice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItemDevice.Click
        OpenVideoCaptureDevice()
    End Sub

    Private Sub mnuImageSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuImageSettings.Click
        ShowDeviceProperties()
    End Sub

    Private Sub mnuLiveStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLiveStart.Click
        StartLiveVideo()
    End Sub

    Private Sub mnuLiveStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLiveStop.Click
        StopLiveVideo()
    End Sub



    Private Sub tbDevice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbDevice.Click
        OpenVideoCaptureDevice()
    End Sub

    Private Sub tbImageSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbImageSettings.Click
        ShowDeviceProperties()
    End Sub

    Private Sub tbStartLive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbStartLive.Click
        StartLiveVideo()
    End Sub

    Private Sub tbStopLive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbStopLive.Click
        StopLiveVideo()
    End Sub


    Private Sub ShowImagebuffer(ByVal buffer As TIS.Imaging.ImageBuffer)
        IcImagingControl1.DisplayImageBuffer(buffer)
        buffer.Unlock()
    End Sub


    '
    'ImageAvailable event
    '
    'It is called after a frame has been copied into the ring buffer.
    '
    Private Sub IcImagingControl1_ImageAvailable(ByVal sender As Object, ByVal e As TIS.Imaging.ICImagingControl.ImageAvailableEventArgs) Handles IcImagingControl1.ImageAvailable
        Try
            Dim ImgBuffer As TIS.Imaging.ImageBuffer
            Dim x As Integer, y As Integer
            Dim BytesPerLine As Integer

            ' Retrieve the snapped image.
            ImgBuffer = IcImagingControl1.ImageBuffers(e.bufferIndex)

            ' Prevent overwriting of the current image buffer
            ImgBuffer.Lock()
            ' Calculate the number of bytes per line
            BytesPerLine = ImgBuffer.BitsPerPixel / 8 * ImgBuffer.PixelPerLine

            ' Do the image processing. The image is inverted.
            ' TODO: Insert your own image processing code here.
            For y = 0 To ImgBuffer.Lines - 1
                For x = 0 To BytesPerLine - 1
                    ImgBuffer(x, y) = 255 - ImgBuffer(x, y)
                Next x
            Next y


            ' Display the resulting image in the IC Imaging Control window.
            Me.BeginInvoke(New ShowBufferDelegate(AddressOf ShowImagebuffer), ImgBuffer)



        Catch ex As System.Exception
            ' An exception that occurs here cannot be handled elsewhere. 
            ' Therefore, if you are using the ImageAvailable event, watch the debug
            ' output window of your Visual Studio because the message (see below)
            ' will appear there.
            System.Diagnostics.Debug.WriteLine(ex.Message)
        End Try
    End Sub






    '
    ' Handle the DeviceLost event.
    '
    Private Sub DeviceLost()
        MessageBox.Show("Device Lost!")
        UpdateControls()
    End Sub

    Private Sub IcImagingControl1_DeviceLost(ByVal sender As System.Object, ByVal e As TIS.Imaging.ICImagingControl.DeviceLostEventArgs) Handles IcImagingControl1.DeviceLost
        Me.BeginInvoke(New DeviceLostDelegate(AddressOf DeviceLost))
    End Sub

    Private Sub TextBox1_DoubleClick(sender As Object, e As EventArgs) Handles TextBox1.DoubleClick
        Dim Focus As TIS.Imaging.VCDPropertyItem
        Dim FocusRange As TIS.Imaging.VCDRangeProperty


        VCDProp = TIS.Imaging.VCDHelpers.VCDSimpleModule.GetSimplePropertyContainer(IcImagingControl1.VCDPropertyItems)
        Focus = IcImagingControl1.VCDPropertyItems.FindItem(TIS.Imaging.VCDIDs.VCDID_Focus)

        FocusRange = Focus.Elements.FindInterface(TIS.Imaging.VCDIDs.VCDElement_Value + ":" + TIS.Imaging.VCDIDs.VCDInterface_Range)
        FocusRange.Value = TextBox1.Text
        Threading.Thread.Sleep(500)


        IcImagingControl1.MemorySaveImage("1234.bmp")


    End Sub
End Class
