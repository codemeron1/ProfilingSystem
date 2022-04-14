<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewRecord
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
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.cboSection = New System.Windows.Forms.ComboBox()
        Me.cboYearLevel = New System.Windows.Forms.ComboBox()
        Me.btnSaveRecord = New System.Windows.Forms.Button()
        Me.label8 = New System.Windows.Forms.Label()
        Me.txtSubjectCode = New System.Windows.Forms.TextBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtIdNumber = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnCamera = New System.Windows.Forms.Button()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic
        '
        Me.pic.Location = New System.Drawing.Point(143, 12)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(133, 114)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic.TabIndex = 0
        Me.pic.TabStop = False
        '
        'cboSection
        '
        Me.cboSection.FormattingEnabled = True
        Me.cboSection.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G"})
        Me.cboSection.Location = New System.Drawing.Point(27, 574)
        Me.cboSection.Name = "cboSection"
        Me.cboSection.Size = New System.Drawing.Size(355, 26)
        Me.cboSection.TabIndex = 32
        '
        'cboYearLevel
        '
        Me.cboYearLevel.FormattingEnabled = True
        Me.cboYearLevel.Items.AddRange(New Object() {"I", "II", "III", "IV"})
        Me.cboYearLevel.Location = New System.Drawing.Point(29, 509)
        Me.cboYearLevel.Name = "cboYearLevel"
        Me.cboYearLevel.Size = New System.Drawing.Size(355, 26)
        Me.cboYearLevel.TabIndex = 31
        '
        'btnSaveRecord
        '
        Me.btnSaveRecord.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSaveRecord.FlatAppearance.BorderSize = 0
        Me.btnSaveRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveRecord.Location = New System.Drawing.Point(106, 693)
        Me.btnSaveRecord.Name = "btnSaveRecord"
        Me.btnSaveRecord.Size = New System.Drawing.Size(170, 50)
        Me.btnSaveRecord.TabIndex = 30
        Me.btnSaveRecord.Text = "Save Record"
        Me.btnSaveRecord.UseVisualStyleBackColor = False
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label8.Location = New System.Drawing.Point(26, 614)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(94, 18)
        Me.label8.TabIndex = 29
        Me.label8.Text = "Subject Code"
        '
        'txtSubjectCode
        '
        Me.txtSubjectCode.Location = New System.Drawing.Point(27, 637)
        Me.txtSubjectCode.Name = "txtSubjectCode"
        Me.txtSubjectCode.Size = New System.Drawing.Size(357, 25)
        Me.txtSubjectCode.TabIndex = 28
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label7.Location = New System.Drawing.Point(26, 544)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(54, 18)
        Me.label7.TabIndex = 27
        Me.label7.Text = "Section"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label6.Location = New System.Drawing.Point(26, 472)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(77, 18)
        Me.label6.TabIndex = 26
        Me.label6.Text = "Year Level"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label5.Location = New System.Drawing.Point(26, 406)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(79, 18)
        Me.label5.TabIndex = 25
        Me.label5.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(27, 429)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(357, 25)
        Me.txtLastName.TabIndex = 24
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(27, 363)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(357, 25)
        Me.txtMiddleName.TabIndex = 23
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(27, 284)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(357, 25)
        Me.txtFirstName.TabIndex = 22
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label4.Location = New System.Drawing.Point(24, 332)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(92, 18)
        Me.label4.TabIndex = 21
        Me.label4.Text = "Middle Name"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(24, 263)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(79, 18)
        Me.label3.TabIndex = 20
        Me.label3.Text = "First Name"
        '
        'txtIdNumber
        '
        Me.txtIdNumber.Location = New System.Drawing.Point(27, 215)
        Me.txtIdNumber.Name = "txtIdNumber"
        Me.txtIdNumber.Size = New System.Drawing.Size(357, 25)
        Me.txtIdNumber.TabIndex = 19
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(24, 187)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(81, 18)
        Me.label2.TabIndex = 18
        Me.label2.Text = "ID Number"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Location = New System.Drawing.Point(143, 132)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(61, 34)
        Me.btnBrowse.TabIndex = 33
        Me.btnBrowse.Text = "B"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'btnCamera
        '
        Me.btnCamera.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCamera.FlatAppearance.BorderSize = 0
        Me.btnCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCamera.Location = New System.Drawing.Point(215, 132)
        Me.btnCamera.Name = "btnCamera"
        Me.btnCamera.Size = New System.Drawing.Size(61, 34)
        Me.btnCamera.TabIndex = 34
        Me.btnCamera.Text = "C"
        Me.btnCamera.UseVisualStyleBackColor = False
        '
        'frmNewRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 772)
        Me.Controls.Add(Me.btnCamera)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.cboSection)
        Me.Controls.Add(Me.cboYearLevel)
        Me.Controls.Add(Me.btnSaveRecord)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.txtSubjectCode)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtMiddleName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtIdNumber)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.pic)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNewRecord"
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents cboSection As ComboBox
    Private WithEvents cboYearLevel As ComboBox
    Private WithEvents label8 As Label
    Private WithEvents txtSubjectCode As TextBox
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents txtLastName As TextBox
    Private WithEvents txtMiddleName As TextBox
    Private WithEvents txtFirstName As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents txtIdNumber As TextBox
    Private WithEvents label2 As Label
    Private WithEvents btnBrowse As Button
    Private WithEvents btnCamera As Button
    Public WithEvents btnSaveRecord As Button
    Public WithEvents pic As PictureBox
End Class
