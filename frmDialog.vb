Imports System.Data.OleDb
Public Class frmDialog
    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        If btnTransaction.Text = "Edit" And txtIdentification.Text <> "" Then
            If frmMain.conn.State = ConnectionState.Open Then frmMain.conn.Close()

            'check if id number exists
            Dim da As OleDbDataAdapter = New OleDbDataAdapter($"SELECT * FROM profile WHERE idNumber = '{txtIdentification.Text}'", frmMain.conn)
            Dim dt As New DataTable
            frmMain.conn.Open()
            da.Fill(dt)
            frmMain.conn.Close()

            If dt.Rows.Count = 1 Then
                frmMain.updateString = {dt.Rows(0).Item(0).ToString(), dt.Rows(0).Item(1).ToString(), dt.Rows(0).Item(2).ToString(), dt.Rows(0).Item(3).ToString(), dt.Rows(0).Item(4).ToString(), dt.Rows(0).Item(5).ToString(), dt.Rows(0).Item(6).ToString(), dt.Rows(0).Item(7).ToString()}
                frmNewRecord.btnSaveRecord.Text = "Update Record"
                frmNewRecord.Text = "Update Record"
                frmNewRecord.ShowDialog()

                Me.Close()

            ElseIf dt.Rows.Count > 1 Then
                MessageBox.Show("There are multiple instances of records exist.")
            Else
                MessageBox.Show("This record does'nt exists.")
            End If


        ElseIf btnTransaction.Text = "Delete" And txtIdentification.Text <> "" Then

            'check if id number exists
            Dim da As OleDbDataAdapter = New OleDbDataAdapter($"SELECT * FROM profile WHERE idNumber = '{txtIdentification.Text}'", frmMain.conn)
            Dim dt As New DataTable

            If frmMain.conn.State = ConnectionState.Open Then frmMain.conn.Close()

            frmMain.conn.Open()
            da.Fill(dt)
            frmMain.conn.Close()

            If dt.Rows.Count > 0 Then
                Dim message = MessageBox.Show("Are you sure to delete this record?", "", MessageBoxButtons.YesNo)
                If message = vbYes Then
                    Try
                        If frmMain.conn.State = ConnectionState.Open Then frmMain.conn.Close()

                        frmMain.conn.Open()
                        Dim cmd As OleDbCommand = New OleDbCommand($"DELETE FROM profile WHERE idNumber = '{txtIdentification.Text}'", frmMain.conn)
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        frmMain.conn.Close()

                        MessageBox.Show("Record Deleted.")
                        frmMain.RefreshDataGrid()
                        Me.Close()
                    Catch ex As Exception
                        MessageBox.Show($"Error: {ex.Message()}")
                    End Try
                End If
            Else
                MessageBox.Show("This record does'nt exists.")
            End If

        End If
    End Sub
End Class