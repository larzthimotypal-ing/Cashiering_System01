Imports System.Text.RegularExpressions

Public Class OrderQuantityForm
    'To Prevent Non Numberic Input'
    Public quantity As Integer = 1
    Private Sub tbxOrderQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxOrderQuantity.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub tbxOrderQuantity_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbxOrderQuantity.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        tbxOrderQuantity.Text = digitsOnly.Replace(tbxOrderQuantity.Text, "")
    End Sub

    Private Sub btnOrderQuantitySubmit_Click(sender As Object, e As EventArgs) Handles btnOrderQuantitySubmit.Click

        If (tbxOrderQuantity.Text = 0) Then
            MessageBox.Show("You must put at least 1")
        Else
            Me.Close()
            quantity = tbxOrderQuantity.Text
        End If
    End Sub

    Private Sub OrderQuantityForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        quantity = 1
        tbxOrderQuantity.Text = 1
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        quantity = 0
        Me.Close()
    End Sub
End Class