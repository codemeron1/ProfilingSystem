Imports System.Data.OleDb
Public Class frmNewRecord
    Public picDirectory As String
    Private Sub frmNewRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If btnSaveRecord.Text = "Update Record" Or Me.Text = "Profile" Then
                txtIdNumber.Text = frmMain.updateString(0).ToString()
                txtFirstName.Text = frmMain.updateString(1).ToString()
                txtMiddleName.Text = frmMain.updateString(2).ToString()
                txtLastName.Text = frmMain.updateString(3).ToString()
                cboYearLevel.Text = frmMain.updateString(4).ToString()
                cboSection.Text = frmMain.updateString(5).ToString()
                txtSubjectCode.Text = frmMain.updateString(6).ToString()
                pic.Image = Image.FromFile($"{My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData}\profiling\{frmMain.updateString(7).ToString()}")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message()}")
        End Try

    End Sub

    Private Sub btnSaveRecord_Click(sender As Object, e As EventArgs) Handles btnSaveRecord.Click
        Try
            If btnSaveRecord.Text = "Save Record" Then
                Dim query As String = $"INSERT INTO profile VALUES ('{txtIdNumber.Text}', '{txtFirstName.Text}', '{txtMiddleName.Text}', '{txtLastName.Text}', '{cboYearLevel.Text}', '{cboSection.Text}', '{txtSubjectCode.Text}', '{txtIdNumber.Text}{IO.Path.GetExtension(picDirectory)}')"
                Dim cmd As OleDbCommand = New OleDbCommand(query, frmMain.conn)

                If frmMain.conn.State = ConnectionState.Open Then frmMain.conn.Close()
                frmMain.conn.Open()
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                frmMain.conn.Close()

                'check if folder where pictures will be saved exist.
                If IO.Directory.Exists($"{My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData}\profiling") Then
                    'copy the picture in the profiling folder - C:\Users\<PCNAME>\AppData\Roaming\ProfilingSystem\ProfilingSystem\1.0.0.0\profiling
                    Dim fDestination As String = $"{My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData}\profiling\{txtIdNumber.Text}{IO.Path.GetExtension(picDirectory)}"
                    IO.File.Copy(picDirectory, fDestination, True)
                Else
                    IO.Directory.CreateDirectory($"{My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData}\profiling")
                    'copy the picture in the profiling folder
                    IO.File.Copy(picDirectory, $"{My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData}\profiling\{txtIdNumber.Text}{IO.Path.GetExtension(picDirectory)}", True)
                End If

                MessageBox.Show("New record added.")
                Me.Close()
            ElseIf btnSaveRecord.Text = "Update Record" Then
                Dim query As String = $"UPDATE `profile` SET `idNumber` = '{txtIdNumber.Text}', `fname` = '{txtFirstName.Text}', `mName` = '{txtMiddleName.Text}', `lName` = '{txtLastName.Text}', `yearLevel` = '{cboSection.Text}', `section` = '{cboSection.Text}', `code` = '{txtSubjectCode.Text}' WHERE `idNumber` = '{frmMain.updateString(0).ToString()}'"
                Dim cmd As OleDbCommand = New OleDbCommand(query, frmMain.conn)

                If frmMain.conn.State = ConnectionState.Open Then frmMain.conn.Close()
                frmMain.conn.Open()
                cmd.ExecuteNonQuery()
                frmMain.conn.Close()
                cmd.Dispose()
                frmMain.conn.Close()

                MessageBox.Show("Record updated.")
                frmMain.RefreshDataGrid()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message()}")
        End Try
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim fd As New OpenFileDialog
        fd.Title = "Browse Picture"
        fd.Filter = "Image Files|*.jpg; *.png) "
        fd.ShowDialog()
        If fd.FileName <> "" Then
            pic.Image = Image.FromFile(fd.FileName)
            picDirectory = fd.FileName
        End If


    End Sub

    Private Sub btnCamera_Click(sender As Object, e As EventArgs) Handles btnCamera.Click
        frmCamera.ShowDialog()
    End Sub
End Class