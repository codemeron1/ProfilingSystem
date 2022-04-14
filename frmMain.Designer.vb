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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.aa = New System.Windows.Forms.ToolStrip()
        Me.btnNewRecord = New System.Windows.Forms.ToolStripButton()
        Me.btnUpdate = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblNumberRecord = New System.Windows.Forms.ToolStripStatusLabel()
        Me.colIDNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colYearLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSection = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubjectCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPicture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colView = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.aa.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'aa
        '
        Me.aa.BackColor = System.Drawing.Color.LightGray
        Me.aa.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNewRecord, Me.btnUpdate, Me.btnDelete})
        Me.aa.Location = New System.Drawing.Point(0, 0)
        Me.aa.Name = "aa"
        Me.aa.Size = New System.Drawing.Size(1289, 25)
        Me.aa.TabIndex = 0
        Me.aa.Text = "ToolStrip1"
        '
        'btnNewRecord
        '
        Me.btnNewRecord.Image = CType(resources.GetObject("btnNewRecord.Image"), System.Drawing.Image)
        Me.btnNewRecord.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(100, 22)
        Me.btnNewRecord.Text = "New Record"
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(117, 22)
        Me.btnUpdate.Text = "Update Record"
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(111, 22)
        Me.btnDelete.Text = "Delete Record"
        '
        'dg1
        '
        Me.dg1.AllowUserToAddRows = False
        Me.dg1.AllowUserToDeleteRows = False
        Me.dg1.AllowUserToResizeColumns = False
        Me.dg1.AllowUserToResizeRows = False
        Me.dg1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg1.BackgroundColor = System.Drawing.Color.White
        Me.dg1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIDNumber, Me.colFirstName, Me.colMiddleName, Me.colLastName, Me.colYearLevel, Me.colSection, Me.colSubjectCode, Me.colPicture, Me.colEdit, Me.colDelete, Me.colView})
        Me.dg1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg1.Location = New System.Drawing.Point(0, 25)
        Me.dg1.MultiSelect = False
        Me.dg1.Name = "dg1"
        Me.dg1.ReadOnly = True
        Me.dg1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg1.Size = New System.Drawing.Size(1289, 712)
        Me.dg1.TabIndex = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblNumberRecord})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 715)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1289, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblNumberRecord
        '
        Me.lblNumberRecord.BackColor = System.Drawing.Color.Transparent
        Me.lblNumberRecord.Name = "lblNumberRecord"
        Me.lblNumberRecord.Size = New System.Drawing.Size(133, 17)
        Me.lblNumberRecord.Text = "ToolStripStatusLabel1"
        '
        'colIDNumber
        '
        Me.colIDNumber.FillWeight = 27.45525!
        Me.colIDNumber.HeaderText = "ID Number"
        Me.colIDNumber.Name = "colIDNumber"
        Me.colIDNumber.ReadOnly = True
        '
        'colFirstName
        '
        Me.colFirstName.FillWeight = 27.45525!
        Me.colFirstName.HeaderText = "First Name"
        Me.colFirstName.Name = "colFirstName"
        Me.colFirstName.ReadOnly = True
        '
        'colMiddleName
        '
        Me.colMiddleName.FillWeight = 27.45525!
        Me.colMiddleName.HeaderText = "Middle Name"
        Me.colMiddleName.Name = "colMiddleName"
        Me.colMiddleName.ReadOnly = True
        '
        'colLastName
        '
        Me.colLastName.FillWeight = 27.45525!
        Me.colLastName.HeaderText = "Last Name"
        Me.colLastName.Name = "colLastName"
        Me.colLastName.ReadOnly = True
        '
        'colYearLevel
        '
        Me.colYearLevel.FillWeight = 27.45525!
        Me.colYearLevel.HeaderText = "Year Level"
        Me.colYearLevel.Name = "colYearLevel"
        Me.colYearLevel.ReadOnly = True
        '
        'colSection
        '
        Me.colSection.FillWeight = 27.45525!
        Me.colSection.HeaderText = "Section"
        Me.colSection.Name = "colSection"
        Me.colSection.ReadOnly = True
        '
        'colSubjectCode
        '
        Me.colSubjectCode.FillWeight = 27.45525!
        Me.colSubjectCode.HeaderText = "Subject Code"
        Me.colSubjectCode.Name = "colSubjectCode"
        Me.colSubjectCode.ReadOnly = True
        '
        'colPicture
        '
        Me.colPicture.HeaderText = "Picture"
        Me.colPicture.Name = "colPicture"
        Me.colPicture.ReadOnly = True
        Me.colPicture.Visible = False
        '
        'colEdit
        '
        Me.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colEdit.DefaultCellStyle = DataGridViewCellStyle1
        Me.colEdit.FillWeight = 10.0!
        Me.colEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colEdit.HeaderText = "Edit"
        Me.colEdit.Name = "colEdit"
        Me.colEdit.ReadOnly = True
        Me.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colEdit.Text = "Edit"
        Me.colEdit.ToolTipText = "Edit Record"
        Me.colEdit.UseColumnTextForButtonValue = True
        '
        'colDelete
        '
        Me.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colDelete.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDelete.FillWeight = 10.0!
        Me.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colDelete.HeaderText = "Delete"
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Text = "Delete"
        Me.colDelete.ToolTipText = "Delete Record"
        Me.colDelete.UseColumnTextForButtonValue = True
        '
        'colView
        '
        Me.colView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green
        Me.colView.DefaultCellStyle = DataGridViewCellStyle3
        Me.colView.FillWeight = 10.0!
        Me.colView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colView.HeaderText = "View"
        Me.colView.Name = "colView"
        Me.colView.ReadOnly = True
        Me.colView.Text = "View"
        Me.colView.ToolTipText = "View Record"
        Me.colView.UseColumnTextForButtonValue = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1289, 737)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.aa)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profiling System"
        Me.aa.ResumeLayout(False)
        Me.aa.PerformLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents aa As ToolStrip
    Friend WithEvents btnNewRecord As ToolStripButton
    Friend WithEvents btnUpdate As ToolStripButton
    Friend WithEvents btnDelete As ToolStripButton
    Friend WithEvents dg1 As DataGridView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblNumberRecord As ToolStripStatusLabel
    Friend WithEvents colIDNumber As DataGridViewTextBoxColumn
    Friend WithEvents colFirstName As DataGridViewTextBoxColumn
    Friend WithEvents colMiddleName As DataGridViewTextBoxColumn
    Friend WithEvents colLastName As DataGridViewTextBoxColumn
    Friend WithEvents colYearLevel As DataGridViewTextBoxColumn
    Friend WithEvents colSection As DataGridViewTextBoxColumn
    Friend WithEvents colSubjectCode As DataGridViewTextBoxColumn
    Friend WithEvents colPicture As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewButtonColumn
    Friend WithEvents colDelete As DataGridViewButtonColumn
    Friend WithEvents colView As DataGridViewButtonColumn
End Class
