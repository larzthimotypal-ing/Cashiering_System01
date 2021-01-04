Imports System.Data.OleDb

Public Class LoginCreateForm
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Private Sub LoginCreateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CSystemDataSet.Logintbl' table. You can move, or remove it, as needed.
        Me.LogintblTableAdapter.Fill(Me.CSystemDataSet.Logintbl)

        'To update datagrid after CRUD
        Dim conn As New OleDbConnection(cs)
        loginDgv.DataSource = Nothing
        loginDgv.Refresh()

        Dim str As String = "SELECT * FROM Logintbl"
        Using cmd As New OleDb.OleDbCommand(str, conn)
            Using da As New OleDbDataAdapter(cmd)
                Using newtable As New DataTable
                    da.Fill(newtable)
                    loginDgv.DataSource = newtable
                End Using
            End Using
        End Using

    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "INSERT INTO Logintbl ([EmployeeID], [Password], [UserType]) VALUES (@EmployeeID, @Password, @UserType)" 'database query

        If employeeIDTextbox.Text = Nothing Or passwordLabel.Text = Nothing Or usertypeCheckbox.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()

            Dim cmd As New OleDbCommand(update, conn)
            'Gives a parameter for database column name
            cmd.Parameters.Add(New OleDbParameter("EmployeeID", CType(employeeIDTextbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Password", CType(passwordTextbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("UserType", CType(usertypeCheckbox.Text, String)))
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Add Login Info?", "Login Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            LoginCreateForm_Load(e, e) 'Reloads the Form
            Refresh()

        End If
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "UPDATE Logintbl SET EmployeeID=@EmployeeID, Password=@Password, UserType=@UserType WHERE LoginID=LoginID)" 'database query

        If employeeIDTextbox.Text = Nothing Or passwordLabel.Text = Nothing Or usertypeCheckbox.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()

            Dim cmd As New OleDbCommand(update, conn)
            'Gives a parameter for database column name
            cmd.Parameters.Add(New OleDbParameter("EmployeeID", CType(employeeIDTextbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Password", CType(passwordLabel.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("UserType", CType(usertypeCheckbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("LoginID", CType(loginIDTextbox.Text, String)))
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Edit Login Info?", "Login Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            LoginCreateForm_Load(e, e) 'Reloads the Form
            Refresh()

        End If

    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "DELETE FROM Logintbl WHERE LoginID=@LoginID" 'database query

        conn.Open()

        Dim cmd As New OleDbCommand(update, conn)
        'Gives a parameter for database column name
        cmd.Parameters.AddWithValue("@LoginID", loginIDTextbox.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Delete Login Info?", "Login Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        LoginCreateForm_Load(e, e) 'Reloads the Form
        Refresh()

    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
    End Sub

    Private Sub loginDgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles loginDgv.CellClick
        'cellclick to fetch data to textbox
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Fetch the cell data to textbox value
        i = loginDgv.CurrentRow.Index

        Me.loginIDTextbox.Text = loginDgv.Item(0, i).Value
        Me.employeeIDTextbox.Text = loginDgv.Item(1, i).Value
        Me.passwordTextbox.Text = loginDgv.Item(2, i).Value
        Me.usertypeCheckbox.Text = loginDgv.Item(3, i).Value

    End Sub
End Class