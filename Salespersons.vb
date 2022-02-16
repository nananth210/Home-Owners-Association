Public Class Salespersons
    Private Sub Salespersons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet1.SALESPERSON' table. You can move, or remove it, as needed.
        Me.SALESPERSONTableAdapter.Fill(Me.ProjectDataSet1.SALESPERSON)
        'TODO: This line of code loads data into the 'ProjectDataSet.SALESPERSON' table. You can move, or remove it, as needed.
        Me.SALESPERSONTableAdapter.Fill(Me.ProjectDataSet.SALESPERSON)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        WelcomePage.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class