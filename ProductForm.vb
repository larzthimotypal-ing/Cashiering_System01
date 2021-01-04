Imports System.Data.OleDb

Public Class ProductForm
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CSystemDataSet.Producttbl' table. You can move, or remove it, as needed.
        Me.ProducttblTableAdapter.Fill(Me.CSystemDataSet.Producttbl)

        'To update datagrid after CRUD
        Dim conn As New OleDbConnection(cs)
        productDgv.DataSource = Nothing
        productDgv.Refresh()

        Dim str As String = "SELECT * FROM Producttbl"
        Using cmd As New OleDb.OleDbCommand(str, conn)
            Using da As New OleDbDataAdapter(cmd)
                Using newtable As New DataTable
                    da.Fill(newtable)
                    productDgv.DataSource = newtable
                End Using
            End Using
        End Using

    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "INSERT INTO Producttbl ([ProductName], [Manufacturer], [Price]) VALUES (@ProductName, @Manufacturer, @Price)" 'database query

        If productNameTextbox.Text = Nothing Or manufacturerTextbox.Text = Nothing Or priceTextbox.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()

            Dim cmd As New OleDbCommand(update, conn)
            'Gives a parameter for database column name
            cmd.Parameters.Add(New OleDbParameter("ProductName", CType(productNameTextbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Manufacturer", CType(manufacturerTextbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Price", CType(priceTextbox.Text, String)))
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Add Product?", "Product Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            ProductForm_Load(e, e) 'Reloads the Form
            Refresh()

        End If

    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "UPDATE Producttbl SET ProductName=@ProductName, Manufacturer=@Manufacturer, Price=@Price WHERE ProductID=@ProductID" 'database query

        If productNameTextbox.Text = Nothing Or manufacturerTextbox.Text = Nothing Or priceTextbox.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()

            Dim cmd As New OleDbCommand(update, conn)
            'Gives a parameter for database column name
            cmd.Parameters.Add(New OleDbParameter("ProductName", CType(productNameTextbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Manufacturer", CType(manufacturerTextbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Price", CType(priceTextbox.Text, String)))
            cmd.Parameters.AddWithValue("@ProductID", productIDTextbox.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Edit Product Info?", "Product Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            ProductForm_Load(e, e) 'Reloads the Form
            Refresh()

        End If

    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "DELETE FROM Producttbl WHERE ProductID=@ProductID" 'database query

        conn.Open()

        Dim cmd As New OleDbCommand(update, conn)
        'Gives a parameter for database column name
        cmd.Parameters.AddWithValue("@ProductID", productIDTextbox.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Delete Product?", "Product Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        ProductForm_Load(e, e) 'Reloads the Form
        Refresh()

    End Sub

    Private Sub productDgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles productDgv.CellClick
        'cellclick to fetch data to textbox
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Fetch the cell data to textbox value
        i = productDgv.CurrentRow.Index

        Me.productIDTextbox.Text = productDgv.Item(0, i).Value
        Me.productNameTextbox.Text = productDgv.Item(1, i).Value
        Me.manufacturerTextbox.Text = productDgv.Item(2, i).Value
        Me.priceTextbox.Text = productDgv.Item(3, i).Value

    End Sub
End Class

