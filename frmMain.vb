Imports System.Data.OleDb

Public Class frmMain
    Public conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\db.accdb")
    Public updateString(8) As String

    Public Sub RefreshDataGrid()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()
            'kunin ang data sa database.
            Dim da As OleDbDataAdapter = New OleDbDataAdapter("SELECT * FROM profile", conn)
            Dim dt As New DataTable


            da.Fill(dt)
            If dg1.Rows.Count > 0 Then dg1.Rows.Clear()
            'set data to the datagridview
            For Each row As DataRow In dt.Rows
                dg1.Rows.Add(row.Item(0), row.Item(1), row.Item(2), row.Item(3), row.Item(4), row.Item(5), row.Item(6), row.Item(7))
            Next
            da.Dispose()
            dt.Dispose()

            'count records
            lblNumberRecord.Text = $"Record: {dg1.Rows.Count}"

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message()}")
        End Try
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RefreshDataGrid()
    End Sub

    Private Sub dg1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg1.CellClick
        'kunin ang lahat row data na naclick ng user. ilagay sa updateString variable
        Try
            updateString(0) = dg1.Rows(e.RowIndex).Cells(0).Value.ToString()
            updateString(1) = dg1.Rows(e.RowIndex).Cells(1).Value.ToString()
            updateString(2) = dg1.Rows(e.RowIndex).Cells(2).Value.ToString()
            updateString(3) = dg1.Rows(e.RowIndex).Cells(3).Value.ToString()
            updateString(4) = dg1.Rows(e.RowIndex).Cells(4).Value.ToString()
            updateString(5) = dg1.Rows(e.RowIndex).Cells(5).Value.ToString()
            updateString(6) = dg1.Rows(e.RowIndex).Cells(6).Value.ToString()
            updateString(7) = dg1.Rows(e.RowIndex).Cells(7).Value.ToString()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        frmNewRecord.btnSaveRecord.Text = "Save Record"
        frmNewRecord.Text = "Add New Record"
        frmNewRecord.ShowDialog()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        frmDialog.Text = "Update Record"
        frmDialog.btnTransaction.Text = "Edit"
        frmDialog.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        frmDialog.Text = "Delete Record"
        frmDialog.btnTransaction.Text = "Delete"
        frmDialog.ShowDialog()
    End Sub

    Private Sub dg1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg1.CellContentClick
        If dg1.Columns(e.ColumnIndex).Name = "colEdit" Then
            Dim dr As DataGridViewRow = dg1.SelectedRows(0)
            updateString = {dr.Cells(0).Value.ToString(), dr.Cells(1).Value.ToString(), dr.Cells(2).Value.ToString(), dr.Cells(3).Value.ToString(), dr.Cells(4).Value.ToString(), dr.Cells(5).Value.ToString(), dr.Cells(6).Value.ToString(), dr.Cells(7).Value.ToString()}
            frmNewRecord.btnSaveRecord.Visible = True
            frmNewRecord.btnSaveRecord.Text = "Update Record"
            frmNewRecord.Text = "Update Record"
            frmNewRecord.ShowDialog()
        ElseIf dg1.Columns(e.ColumnIndex).Name = "colDelete" Then
            Dim message = MessageBox.Show("Are you sure to delete this record?", "", MessageBoxButtons.YesNo)
            If message = vbYes Then
                Try
                    If Me.conn.State = ConnectionState.Open Then Me.conn.Close()
                    Dim dr As DataGridViewRow = dg1.SelectedRows(0)
                    Me.conn.Open()
                    Dim cmd As OleDbCommand = New OleDbCommand($"DELETE FROM profile WHERE idNumber = '{dr.Cells(0).Value.ToString()}'", Me.conn)
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    Me.conn.Close()

                    MessageBox.Show("Record Deleted.")
                    Me.RefreshDataGrid()
                Catch ex As Exception
                    MessageBox.Show($"Error: {ex.Message()}")
                End Try
            End If
        ElseIf dg1.Columns(e.ColumnIndex).Name = "colView" Then
            Dim dr As DataGridViewRow = dg1.SelectedRows(0)
            updateString = {dr.Cells(0).Value.ToString(), dr.Cells(1).Value.ToString(), dr.Cells(2).Value.ToString(), dr.Cells(3).Value.ToString(), dr.Cells(4).Value.ToString(), dr.Cells(5).Value.ToString(), dr.Cells(6).Value.ToString(), dr.Cells(7).Value.ToString()}
            frmNewRecord.btnSaveRecord.Visible = False
            frmNewRecord.Text = "Profile"
            frmNewRecord.ShowDialog()
        End If
    End Sub
End Class
