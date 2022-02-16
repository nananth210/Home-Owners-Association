Public Class Salesperson_Ratings
    Private Sub Salesperson_Ratings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.SALESPERSON_RATINGS' table. You can move, or remove it, as needed.
        Me.SALESPERSON_RATINGSTableAdapter.Fill(Me.ProjectDataSet.SALESPERSON_RATINGS)
        OutputAverage.Text = Me.SALESPERSON_RATINGSTableAdapter.AverageSalespersonRatings

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Exit_Salesperson_Ratings_Click(sender As Object, e As EventArgs) Handles Exit_Salesperson_Ratings.Click
        Me.Close()
        WelcomePage.Show()
    End Sub
End Class