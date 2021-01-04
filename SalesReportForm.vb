Public Class SalesReportForm
    Private Sub btnTodaysReport_Click(sender As Object, e As EventArgs) Handles btnTodaysReport.Click
        Me.ActiveControl = Nothing
        DailyReportForm.Show()
    End Sub

    Private Sub btnDailyReportsCompilation_Click(sender As Object, e As EventArgs) Handles btnDailyReportsCompilation.Click
        Me.ActiveControl = Nothing
        DailyReportsCompilation.Show()
    End Sub

    Private Sub btnWeeklyReport_Click(sender As Object, e As EventArgs) Handles btnWeeklyReport.Click
        Me.ActiveControl = Nothing
        WeeklyReportForms.Show()
    End Sub
End Class