Imports System.Data.OleDb
Imports Cashiering_System01.OrderQuantityForm
Public Class PurchaseForm
    Dim connection As New Connection
    Dim cs As String = connection.connectionString

    Dim Order As New OrderQuantityForm
    Dim itemQuantity As Integer = 0

    Public toPay As Decimal = 0


    Private Sub Purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CSystemDataSet.Producttbl' table. You can move, or remove it, as needed.
        Me.ProducttblTableAdapter.Fill(Me.CSystemDataSet.Producttbl)

    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        Order.ShowDialog()
        AddOrder()
        lblTotal.Text = "Total: P " + TotalPriceDisplay().ToString
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        RemoveRow()
        lblTotal.Text = "Total: P " + TotalPriceDisplay().ToString
    End Sub
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        toPay = TotalPriceDisplay()
        Dim payment As Decimal = Decimal.Parse(tbxPayment.Text)
        If (payment < toPay) Then
            MessageBox.Show(" Transaction Invalid, Payment Not Enough")
        Else
            lblChange.Text = "Change : P " + (payment - toPay).ToString
            Dim fkItemPurchase = AddToItemPurchase()
            AddToTransaction(fkItemPurchase, payment)
            MessageBox.Show("Transaction Complete")
            RefreshPage()
        End If

    End Sub

    Function AddToItemPurchase() As Integer
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "INSERT INTO ItemPurchasetbl ([TotalPrice]) VALUES (@TotalPrice)" 'database query
        Dim getId As String = "Select @@Identity" 'database query
        conn.Open()
        Dim cmd As New OleDbCommand(update, conn)
        'Gives a parameter for database column name
        cmd.Parameters.Add(New OleDbParameter("TotalPrice", CType(toPay, Double)))
        cmd.ExecuteNonQuery()
        Dim newID As Integer = 0
        cmd = New OleDbCommand(getId, conn)
        newID = CInt(cmd.ExecuteScalar())
        conn.Close()

        AddToItemPurchase = newID
    End Function

    Function AddToTransaction(fkItemPurchase As Integer, payment As Decimal) As Integer
        Dim change As Decimal = payment - toPay
        change = Math.Round(change, 2, MidpointRounding.AwayFromZero)
        Dim conn As New OleDbConnection(cs)
        Dim update As String = "INSERT INTO Transactiontbl ([EmployeeID],[ItemPurchaseID],[Payment],[Change]) VALUES (@EmployeeID, @ItemPurchaseID, @Payment, @Change)"
        conn.Open()
        Dim cmd As New OleDbCommand(update, conn)
        'Gives a parameter for database column name
        cmd.Parameters.Add(New OleDbParameter("EmployeeID", CType(LoginForm.employeeID, Integer)))
        cmd.Parameters.Add(New OleDbParameter("ItemPurchaseID", CType(fkItemPurchase, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Payment", CType(payment, Double)))
        cmd.Parameters.Add(New OleDbParameter("Change", CType(change, Double)))
        cmd.ExecuteNonQuery()
        conn.Close()
        AddToTransaction = 0
    End Function
    Function RefreshPage() As Integer
        dgvOrderList.Rows.Clear()
        lblTotal.Text = "Total : P 0"
        lblChange.Text = "Change : P 0"
        tbxPayment.Text = ""

        RefreshPage = 0
    End Function

    Function AddOrder() As Integer
        itemQuantity = Order.quantity
        If (itemQuantity > 0) Then
            Dim i As Integer = dgvProductTable.CurrentRow.Index()
            Dim row() As String = {dgvProductTable.Item(0, i).Value.ToString, dgvProductTable.Item(1, i).Value.ToString, dgvProductTable.Item(2, i).Value.ToString, itemQuantity, dgvProductTable.Item(2, i).Value * itemQuantity}
            dgvOrderList.Rows.Add(row)
        End If
        AddOrder = 0
    End Function

    Function TotalPriceDisplay() As Decimal
        Dim j As Integer = 0
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvOrderList.Rows
            total += dgvOrderList.Item(4, j).Value
            j += 1
        Next
        total = Math.Round(total, 2, MidpointRounding.AwayFromZero)
        TotalPriceDisplay = total
    End Function
    Function RemoveRow() As Integer

        dgvOrderList.Rows.Remove(dgvOrderList.CurrentRow)

        RemoveRow = 0
    End Function
End Class