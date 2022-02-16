Public Class WelcomePage
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub AvailableLotButton_Click(sender As Object, e As EventArgs) Handles AvailableLotButton.Click
        Me.Hide()
        AvailableLotform.Show()
    End Sub

    Private Sub PurchaselotButton_Click(sender As Object, e As EventArgs) Handles PurchaselotButton.Click
        Me.Hide()
        PurchaseLotform.Show()
    End Sub

    Private Sub Customer_Prurchase_Record_Click(sender As Object, e As EventArgs) Handles Customer_Purchase_Record.Click
        Me.Hide()
        CustomerPurchaseRecordForm.Show()
    End Sub

    Private Sub Available_lot_Detail_Click(sender As Object, e As EventArgs) Handles Available_Lot_Detail.Click
        Me.Hide()
        Availablelotdetailform.Show()
    End Sub

    Private Sub WelcomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ShowReviewsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowReviewsToolStripMenuItem.Click
        Me.Hide()
        Salesperson_Ratings.Show()
    End Sub

    Private Sub SalespersonReviewsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalespersonReviewsToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Hide()
        Highest_Salesperson_Rating.Show()
    End Sub

    Private Sub ByLowestRatingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByLowestRatingToolStripMenuItem.Click
        Lowest_Salesperson_Rating.Show()
    End Sub

    Private Sub NewestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewestToolStripMenuItem.Click
        Me.Hide()
        Newest_Salesperson_Rating.Show()
    End Sub

    Private Sub PurchasedLotsButton_Click(sender As Object, e As EventArgs) Handles PurchasedLotsButton.Click
        Me.Hide()
        Availablelotdetailform.Show()
    End Sub

    Private Sub ModelsButton_Click(sender As Object, e As EventArgs) Handles ModelsButton.Click
        Me.Hide()
        Models.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SubdivisionButton.Click
        Me.Hide()
        Subdivisions.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Salespersons.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CustomersButton.Click
        Me.Hide()
        Customers.Show()
    End Sub

    Private Sub SalespersonDetailsButton_Click(sender As Object, e As EventArgs) Handles SalespersonDetailsButton.Click
        Me.Hide()
        Salesperson_DetailForm.Show()
    End Sub
End Class
