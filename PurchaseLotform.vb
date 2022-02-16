Public Class PurchaseLotform
    Private Sub PurchaseLotformGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.PURCHASED_LOTS' table. You can move, or remove it, as needed.
        Me.PURCHASED_LOTSTableAdapter.Fill(Me.ProjectDataSet.PURCHASED_LOTS)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        WelcomePage.Show()
    End Sub

    Private Sub PurchaseLotGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PurchaseLotGrid.CellContentClick
    End Sub

    Private Sub HighestValuedLotsButton_Click(sender As Object, e As EventArgs) Handles HighestValuedLotsButton.Click
        Try
            Me.PURCHASED_LOTSTableAdapter.HighestValuedLots(Me.ProjectDataSet.PURCHASED_LOTS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LowestValuesLotsButton_Click(sender As Object, e As EventArgs) Handles LowestValuedLotsButton.Click
        Try
            Me.PURCHASED_LOTSTableAdapter.LowestValuedLots(Me.ProjectDataSet.PURCHASED_LOTS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ShowAllLotsButton_Click(sender As Object, e As EventArgs) Handles ShowAllLotsButton.Click
        Me.PURCHASED_LOTSTableAdapter.Fill(Me.ProjectDataSet.PURCHASED_LOTS)
    End Sub

    Private Sub TotalPurchasePriceButton_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub
End Class