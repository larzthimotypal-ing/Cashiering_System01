Imports System.Data.OleDb

Public Class InventoryForm
    Dim connection As New Connection
    Dim cs As String = connection.connectionString
    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CSystemDataSet.Producttbl' table. You can move, or remove it, as needed.
        Me.ProducttblTableAdapter.Fill(Me.CSystemDataSet.Producttbl)
        'TODO: This line of code loads data into the 'CSystemDataSet.Stocktbl' table. You can move, or remove it, as needed.
        Me.StocktblTableAdapter.Fill(Me.CSystemDataSet.Stocktbl)
        'TODO: This line of code loads data into the 'CSystemDataSet.Producttbl' table. You can move, or remove it, as needed.
        Me.ProducttblTableAdapter.Fill(Me.CSystemDataSet.Producttbl)
        'TODO: This line of code loads data into the 'CSystemDataSet.Stocktbl' table. You can move, or remove it, as needed.
        Me.StocktblTableAdapter.Fill(Me.CSystemDataSet.Stocktbl)

        'To update datagrid after CRUD
        Dim conn As New OleDbConnection(cs)
        stockDgv.DataSource = Nothing
        stockDgv.Refresh()

        Dim str As String = "SELECT * FROM Stocktbl"
        Using cmd As New OleDb.OleDbCommand(str, conn)
            Using da As New OleDbDataAdapter(cmd)
                Using newtable As New DataTable
                    da.Fill(newtable)
                    stockDgv.DataSource = newtable
                End Using
            End Using
        End Using

    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "INSERT INTO Stocktbl ([ProductID], [Quantity]) VALUES (@ProductID, @Quantity)" 'database query

        If productIDTextbox.Text = Nothing Or quantityTextbox.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()

            Dim cmd As New OleDbCommand(update, conn)
            'Gives a parameter for database column name
            cmd.Parameters.Add(New OleDbParameter("ProductID", CType(productIDTextbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Quantity", CType(quantityTextbox.Text, String)))
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Add Stock?", "Stock Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            InventoryForm_Load(e, e) 'Reloads the Form
            Refresh()

        End If

    End Sub

    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "UPDATE Stocktbl SET ProductID=@ProductID, Quantity=@Quantity WHERE StockID=@StockID" 'database query

        If productIDTextbox.Text = Nothing Or quantityTextbox.Text = Nothing Then
            MsgBox("Fill up the empty box", MsgBoxStyle.Exclamation, "Missing")

        Else
            conn.Open()

            Dim cmd As New OleDbCommand(update, conn)
            'Gives a parameter for database column name
            cmd.Parameters.Add(New OleDbParameter("ProductID", CType(productIDTextbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Quantity", CType(quantityTextbox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("StockID", CType(stockIDTextbox.Text, String)))
            cmd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Edit Stock?", "Stock Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            InventoryForm_Load(e, e) 'Reloads the Form
            Refresh()

        End If

    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "DELETE FROM Stocktbl WHERE StockID=@StockID" 'database query

        conn.Open()

        Dim cmd As New OleDbCommand(update, conn)
        'Gives a parameter for database column name
        cmd.Parameters.AddWithValue("@StockID", stockIDTextbox.Text)
        cmd.ExecuteNonQuery()
        conn.Close()
        MessageBox.Show("Delete Stock?", "Stock Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        InventoryForm_Load(e, e) 'Reloads the Form
        Refresh()

    End Sub

    Private Sub stockDgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles stockDgv.CellClick
        'cellclick to fetch data to textbox
        Dim conn As New OleDbConnection(cs)
        Dim i As Integer
        Dim io As String
        io = CStr(i) 'conversion of Integer to String because Ref# or SL_ID/Loan Amount is an Integer value and won't be valid to call below without this

        'Fetch the cell data to textbox value
        i = stockDgv.CurrentRow.Index

        Me.stockIDTextbox.Text = stockDgv.Item(0, i).Value
        Me.productIDTextbox.Text = stockDgv.Item(1, i).Value
        Me.quantityTextbox.Text = stockDgv.Item(2, i).Value

    End Sub
End Class