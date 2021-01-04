Imports System.Data.OleDb

Public Class DailyReportsCompilation
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Private Sub DailyReportsCompilation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CSystemDataSet1.DailyReporttbl' table. You can move, or remove it, as needed.
        Me.DailyReporttblTableAdapter.Fill(Me.CSystemDataSet1.DailyReporttbl)

        Dim conn As New OleDbConnection(cs)
        dgvDailyReportsCompilation.DataSource = Nothing
        dgvDailyReportsCompilation.Refresh()

        Dim str As String = "SELECT * FROM DailyReporttbl"
        Using cmd As New OleDb.OleDbCommand(str, conn)
            Using da As New OleDbDataAdapter(cmd)
                Using newtable As New DataTable
                    da.Fill(newtable)
                    dgvDailyReportsCompilation.DataSource = newtable
                End Using
            End Using
        End Using
    End Sub
End Class