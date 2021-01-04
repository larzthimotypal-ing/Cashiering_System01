Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class DailyReportForm
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Private Sub SalesReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New OleDbConnection(cs)
        Dim sql As String = "SELECT EmployeeName, TotalPrice, Payment, Change FROM (Transactiontbl INNER JOIN Employeetbl ON Transactiontbl.EmployeeID = Employeetbl.EmployeeID) INNER JOIN ItemPurchasetbl ON Transactiontbl.ItemPurchaseID = ItemPurchasetbl.ItemPurchaseID WHERE DateOfTransaction= Date();"
        Dim dataadapter As New OleDbDataAdapter(sql, conn)
        Dim ds As New DataSet()
        conn.Open()
        dataadapter.Fill(ds, "Transactiontbl")
        conn.Close()
        dgvTodaysTransaction.DataSource = ds
        dgvTodaysTransaction.DataMember = "Transactiontbl"

        lblDailyEarning.Text = "Daily Earning : P" + CalculateDailyEarning.ToString
    End Sub


    Function CalculateDailyEarning() As Decimal
        Dim i As Integer = 0
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvTodaysTransaction.Rows
            total += dgvTodaysTransaction.Item(1, i).Value
            i += 1
        Next
        total = Math.Round(total, 2, MidpointRounding.AwayFromZero)
        CalculateDailyEarning = total
    End Function

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        Dim conn As New OleDbConnection(cs)
        Dim read As String = "SELECT * FROM DailyReporttbl WHERE DailyReportID = Date()"
        Dim insert As String = "INSERT INTO DailyReporttbl ([WeekNumber],[DailyEarning]) VALUES (@WeekNumber, @DailyEarning)"
        Dim adapter As New OleDbDataAdapter(read, conn)
        Dim ds As New DataSet()
        Dim cb As New OleDb.OleDbCommandBuilder(adapter)
        conn.Open()
        adapter.Fill(ds, "DailyReporttbl")
        conn.Close()
        If (ds.Tables(0).Rows.Count > 0) Then
            ds.Tables(0).Rows(0)(1) = Integer.Parse(tbxWeekNumber.Text)
            ds.Tables(0).Rows(0)(2) = Double.Parse(CalculateDailyEarning())
            adapter.Update(ds, "DailyReporttbl")
            MessageBox.Show("Report for the Day Recorded")
        Else
            conn.Open()
            Dim cmd As New OleDbCommand(insert, conn)
            cmd.Parameters.Add(New OleDbParameter("WeekNumber", CType(tbxWeekNumber.Text, Integer)))
            cmd.Parameters.Add(New OleDbParameter("DailyEarning", CType(CalculateDailyEarning(), Double)))
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Report for the Day Recorded")
        End If

    End Sub
    Private Sub tbxWeekNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxWeekNumber.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub tbxWeekNumber_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxWeekNumber.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        tbxWeekNumber.Text = digitsOnly.Replace(tbxWeekNumber.Text, "")
    End Sub
End Class