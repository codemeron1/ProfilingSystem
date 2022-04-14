<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCamera
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.pbCapture = New System.Windows.Forms.Button()
        Me.cmdNo = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(781, 653)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(219, 677)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(105, 40)
        Me.cmdOk.TabIndex = 1
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'pbCapture
        '
        Me.pbCapture.Location = New System.Drawing.Point(287, 671)
        Me.pbCapture.Name = "pbCapture"
        Me.pbCapture.Size = New System.Drawing.Size(143, 53)
        Me.pbCapture.TabIndex = 2
        Me.pbCapture.Text = "Capture"
        Me.pbCapture.UseVisualStyleBackColor = True
        '
        'cmdNo
        '
        Me.cmdNo.Location = New System.Drawing.Point(416, 680)
        Me.cmdNo.Name = "cmdNo"
        Me.cmdNo.Size = New System.Drawing.Size(115, 40)
        Me.cmdNo.TabIndex = 3
        Me.cmdNo.Text = "Try Again"
        Me.cmdNo.UseVisualStyleBackColor = True
        '
        'frmCamera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(781, 738)
        Me.Controls.Add(Me.pbCapture)
        Me.Controls.Add(Me.cmdNo)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCamera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capture Picture"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdOk As Button
    Friend WithEvents pbCapture As Button
    Friend WithEvents cmdNo As Button
End Class
