Public Class MenuAdminForm
    Private Sub inventoryButton_Click(sender As Object, e As EventArgs) Handles inventoryButton.Click
        Me.ActiveControl = Nothing
        InventoryForm.Show()

    End Sub

    Private Sub productButton_Click(sender As Object, e As EventArgs) Handles productButton.Click
        Me.ActiveControl = Nothing
        ProductForm.Show()

    End Sub

    Private Sub salesReportButton_Click(sender As Object, e As EventArgs) Handles salesReportButton.Click
        Me.ActiveControl = Nothing
        DailyReportForm.Show()

    End Sub

    Private Sub modifyEmpButton_Click(sender As Object, e As EventArgs) Handles modifyEmpButton.Click
        Me.ActiveControl = Nothing
        EmployeeCRUDForm.Show()

    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        Me.ActiveControl = Nothing
        LoginForm.Show()
        LoginForm.empLoginTxtbox.Clear()
        LoginForm.passwordLoginTxtbox.Clear()
        LoginForm.usertypeCheckbox.SelectedIndex = -1
        Me.Close()

    End Sub

End Class