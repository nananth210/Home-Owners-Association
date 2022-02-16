Public Class AvailableLotform

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        WelcomePage.Show()
    End Sub

    Private Sub AvailableLotform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.AVAILABLE_LOTS' table. You can move, or remove it, as needed.
        Me.AVAILABLE_LOTSTableAdapter.Fill(Me.ProjectDataSet.AVAILABLE_LOTS)

    End Sub


End Class