Imports System.Data.OleDb

Public Class LoginForm
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Public employeeID As Integer = 0
    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim conn As New OleDbConnection(cs)
        Dim cmd As New OleDbCommand("SELECT * FROM Logintbl WHERE EmployeeID=@EmployeeID And Password=@Password and UserType=@UserType", conn)

        'Added parameters for the variable attachment on database query
        cmd.Parameters.Add("@EmployeeID", OleDbType.VarChar).Value = empLoginTxtbox.Text
        cmd.Parameters.Add("@Password", OleDbType.VarChar).Value = passwordLoginTxtbox.Text
        cmd.Parameters.Add("@UserType", OleDbType.VarChar).Value = usertypeCheckbox.Text

        'Data adapter to Fill the data coming from textbox, and check if its matched
        Dim submitlogin As New OleDbDataAdapter(cmd)
        Dim table As New DataTable
        submitlogin.Fill(table)

        'If condition for checking the proper data on UserType
        If table.Rows.Count <= 0 Then
            MsgBox("Error Login. Please check Username or Password.", MsgBoxStyle.Exclamation)

        ElseIf usertypeCheckbox.Text = "Admin" Then
            MsgBox("Login Success!", MsgBoxStyle.Information)
            employeeID = Integer.Parse(empLoginTxtbox.Text)
            Me.Hide()
            MenuAdminForm.Show()

        ElseIf usertypeCheckbox.Text = "Employee" Then
            MsgBox("Login Success!", MsgBoxStyle.Information)
            employeeID = Integer.Parse(empLoginTxtbox.Text)
            Me.Hide()
            MenuEmpForm.Show()

        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

        Application.Exit()
        End

    End Sub

End Class
