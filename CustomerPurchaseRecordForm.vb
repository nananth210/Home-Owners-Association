Public Class CustomerPurchaseRecordForm
    Private Sub CustomerPurchaseRecordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.Customer_Purchase_Record' table. You can move, or remove it, as needed.
        Me.Customer_Purchase_RecordTableAdapter.Customer_Purchase_Record(Me.ProjectDataSet.Customer_Purchase_Record)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        WelcomePage.Show()
    End Sub





    Private Sub Customerpruchaserecordgrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerPurchases.CellContentClick

    End Sub
End Class