Public Class Newest_Salesperson_Rating
    Private Sub Newest_Salesperson_Rating_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.SALESPERSON_RATINGS' table. You can move, or remove it, as needed.
        Me.SALESPERSON_RATINGSTableAdapter.Fill(Me.ProjectDataSet.SALESPERSON_RATINGS)

    End Sub

    Private Sub Newest_ReviewsToolStripButton_Click(sender As Object, e As EventArgs) Handles Newest_ReviewsToolStripButton.Click
        Try
            Me.SALESPERSON_RATINGSTableAdapter.Newest_Reviews(Me.ProjectDataSet.SALESPERSON_RATINGS)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        Me.Hide()
        Salesperson_Ratings.Show()
    End Sub
End Class