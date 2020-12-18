Imports System.Data.OleDb

Public Class EmployeeCRUDForm
    Private Sub EmployeeCRUDForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CSystemDataSet.Employeetbl' table. You can move, or remove it, as needed.
        Me.EmployeetblTableAdapter.Fill(Me.CSystemDataSet.Employeetbl)

        'To update datagrid after CRUD
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\Desktop\Cashiering_System01\CSystem.accdb")
        employeeDgv.DataSource = Nothing
        employeeDgv.Refresh()

        Dim str As String = "SELECT * FROM Employeetbl"
        Using cmd As New OleDb.OleDbCommand(str, conn)
            Using da As New OleDbDataAdapter(cmd)
                Using newtable As New DataTable
                    da.Fill(newtable)
                    employeeDgv.DataSource = newtable
                End Using
            End Using
        End Using

    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\Desktop\Cashiering_System01\CSystem.accdb")
        Dim update As String = "INSERT INTO Employeetbl ([EmployeeName], [Age], [ContactNo], [Address]) VALUES (@EmployeeName, @Age, @ContactNo, @Address)" 'database query

        If employeeNameTextbox.Text = Nothing Or ageTextbox.Text = Nothing Or contactNoTextbox.Text = Nothing Or addressTextbox.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()

            Dim cmd As New OleDbCommand(update, conn)
            'Gives a parameter for database column name
            cmd.Parameters.Add(New OleDbParameter("EmployeeName", CType(employeeNameTextbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Age", CType(ageTextbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("ContactNo", CType(contactNoTextbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Address", CType(addressTextbox.Text, String)))
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Add Employee?", "Employee Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            EmployeeCRUDForm_Load(e, e) 'Reloads the Form
            Refresh()

        End If
    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\Desktop\Cashiering_System01\CSystem.accdb")
        Dim update As String = "UPDATE Employeetbl SET EmployeeName=@EmployeeName, Age=@Age, ContactNo=@ContactNo, Address=@Address WHERE EmployeeID=@EmployeeID" 'database query

        If employeeNameTextbox.Text = Nothing Or ageTextbox.Text = Nothing Or contactNoTextbox.Text = Nothing Or addressTextbox.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()

            Dim cmd As New OleDbCommand(update, conn)
            'Gives a parameter for database column name
            cmd.Parameters.Add(New OleDbParameter("EmployeeName", CType(employeeNameTextbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Age", CType(ageTextbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("ContactNo", CType(contactNoTextbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Address", CType(addressTextbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("EmployeeID", CType(employeeIDTextbox.Text, String)))
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Edit Employee?", "Employee Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            EmployeeCRUDForm_Load(e, e) 'Reloads the Form
            Refresh()

        End If

    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\Desktop\Cashiering_System01\CSystem.accdb")
        Dim update As String = "DELETE FROM Employeetbl WHERE EmployeeID=@EmployeeID" 'database query

        conn.Open()

        Dim cmd As New OleDbCommand(update, conn)
        'Gives a parameter for database column name
        cmd.Parameters.AddWithValue("@EmployeeID", employeeIDTextbox.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Delete Stock?", "Stock Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        EmployeeCRUDForm_Load(e, e) 'Reloads the Form
        Refresh()

    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        Me.Close()
    End Sub

    Private Sub employeeDgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles employeeDgv.CellClick
        'cellclick to fetch data to textbox
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jamez\Desktop\Cashiering_System01\CSystem.accdb")
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Fetch the cell data to textbox value
        i = employeeDgv.CurrentRow.Index

        Me.employeeIDTextbox.Text = employeeDgv.Item(0, i).Value
        Me.employeeNameTextbox.Text = employeeDgv.Item(1, i).Value
        Me.ageTextbox.Text = employeeDgv.Item(2, i).Value
        Me.contactNoTextbox.Text = employeeDgv.Item(3, i).Value
        Me.addressTextbox.Text = employeeDgv.Item(4, i).Value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.ActiveControl = Nothing
        LoginCreateForm.Show()
    End Sub
End Class