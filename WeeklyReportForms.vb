Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class WeeklyReportForms
    Dim connection As New Connection
    Dim cs As String = connection.connectionString

    Dim wn As Integer = 1
    Private Sub WeeklyReportForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CSystemDataSet1.DailyReporttbl' table. You can move, or remove it, as needed.
        Me.DailyReporttblTableAdapter.Fill(Me.CSystemDataSet1.DailyReporttbl)
        RefreshDGV()
    End Sub

    Function CalculateWeeklyEarning() As Decimal
        Dim i As Integer = 0
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvWeeklyReport.Rows
            total += dgvWeeklyReport.Item(1, i).Value
            i += 1
        Next
        total = Math.Round(total, 2, MidpointRounding.AwayFromZero)
        CalculateWeeklyEarning = total
    End Function

    Private Sub btnGetReport_Click(sender As Object, e As EventArgs) Handles btnGetReport.Click
        wn = Integer.Parse(tbxWeekNumber.Text)
        RefreshDGV()
    End Sub

    Function RefreshDGV() As Integer
        Dim conn As New OleDbConnection(cs)
        dgvWeeklyReport.DataSource = Nothing
        dgvWeeklyReport.Refresh()

        Dim str As String = "SELECT * FROM DailyReporttbl WHERE WeekNumber = " + wn.ToString + ";"
        Using cmd As New OleDb.OleDbCommand(str, conn)
            Using da As New OleDbDataAdapter(cmd)
                Using newtable As New DataTable
                    da.Fill(newtable)
                    dgvWeeklyReport.DataSource = newtable
                End Using
            End Using
        End Using

        lblWeeklyEarning.Text = "Weekly Earning : P " + CalculateWeeklyEarning().ToString()
        RefreshDGV = 0
    End Function

    Private Sub tbxOrderQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxWeekNumber.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub tbxOrderQuantity_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxWeekNumber.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        tbxWeekNumber.Text = digitsOnly.Replace(tbxWeekNumber.Text, "")
    End Sub
End Class