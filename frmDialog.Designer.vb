<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDialog
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdentification = New System.Windows.Forms.TextBox()
        Me.btnTransaction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Profile Identification"
        '
        'txtIdentification
        '
        Me.txtIdentification.Location = New System.Drawing.Point(15, 64)
        Me.txtIdentification.Name = "txtIdentification"
        Me.txtIdentification.Size = New System.Drawing.Size(336, 25)
        Me.txtIdentification.TabIndex = 1
        '
        'btnTransaction
        '
        Me.btnTransaction.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnTransaction.FlatAppearance.BorderSize = 0
        Me.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransaction.Location = New System.Drawing.Point(75, 126)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(222, 41)
        Me.btnTransaction.TabIndex = 2
        Me.btnTransaction.Text = "Delete"
        Me.btnTransaction.UseVisualStyleBackColor = False
        '
        'frmDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(363, 187)
        Me.Controls.Add(Me.btnTransaction)
        Me.Controls.Add(Me.txtIdentification)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdentification As TextBox
    Public WithEvents btnTransaction As Button
End Class
