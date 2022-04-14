Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.ComponentModel
Imports System.IO
Public Class frmCamera
    Dim CAMARA As VideoCaptureDevice
    Dim BMP As Bitmap
    Dim Cap As String = "Capture"
    Private Sub CAPTURAR(sender As Object, eventArgs As NewFrameEventArgs)
        BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
    Private Sub frmCamera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdNo.Visible = False
        cmdOk.Visible = False
        Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        If CAMARAS.ShowDialog() = DialogResult.OK Then
            CAMARA = CAMARAS.VideoDevice
            AddHandler CAMARA.NewFrame, New NewFrameEventHandler(AddressOf CAPTURAR)
            CAMARA.Start()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub frmCamera_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            CAMARA.Stop()
        Catch ex As Exception
            Me.Dispose()
        End Try
    End Sub

    Private Sub pbCapture_Click(sender As Object, e As EventArgs) Handles pbCapture.Click
        If Cap = "Capture" Then
            cmdNo.Visible = True
            cmdOk.Visible = True
            pbCapture.Visible = False
            CAMARA.Stop()
            Cap = "Start"
        ElseIf Cap = "Start" Then
            Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
            CAMARA.Start()
            cmdNo.Visible = False
            cmdOk.Visible = False
            Cap = "Capture"
        End If
    End Sub

    Private Sub cmdNo_Click(sender As Object, e As EventArgs) Handles cmdNo.Click
        Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        CAMARA.Start()
        cmdNo.Visible = False
        cmdOk.Visible = False
        pbCapture.Visible = True
        Cap = "Capture"
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        Dim SD As New SaveFileDialog
        SD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        SD.FileName = "Visual Capture " & Date.Now.ToString("MM/dd/yy")
        SD.SupportMultiDottedExtensions = True
        SD.AddExtension = True
        SD.Filter = "PNG File|*.png"
        If SD.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox1.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
                frmNewRecord.picDirectory = SD.FileName
                frmNewRecord.pic.Image = PictureBox1.Image
                Me.Close()
            Catch ex As Exception
            End Try
        Else
            Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
            CAMARA.Start()
            cmdNo.Visible = False
            cmdOk.Visible = False
            pbCapture.Visible = True
            Cap = "Capture"
        End If
    End Sub
End Class