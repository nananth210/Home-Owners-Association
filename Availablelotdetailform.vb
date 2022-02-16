Public Class Availablelotdetailform
    Private Sub Availablelotdetailform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.Available_lot_detail_Query' table. You can move, or remove it, as needed.
        Me.Available_lot_detail_QueryTableAdapter.Availablelotdetailquery(Me.ProjectDataSet.Available_lot_detail_Query)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        WelcomePage.Show()
    End Sub

    Private Sub GOToolStripButton_Click(sender As Object, e As EventArgs) Handles GOToolStripButton.Click
        Try
            Me.Available_lot_detail_QueryTableAdapter.GO(Me.ProjectDataSet.Available_lot_detail_Query, Subdivision_NameToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class