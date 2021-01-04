Imports Cashiering_System01.PurchaseForm
Public Class CheckoutForm
    Dim connection As New Connection
    Dim cs As String = connection.connectionString

    Dim Purchase As New PurchaseForm
    Dim total As Decimal = 0
    Private Sub CheckoutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        total = Purchase.toPay
        lblTotal.Text = "Total : " + total.ToString
    End Sub
End Class