Public Class Subdivisions
    Private Sub Subdivisions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet1.GroupByState' table. You can move, or remove it, as needed.
        Me.GroupByStateTableAdapter.GroupbyState(Me.ProjectDataSet1.GroupByState)
        'TODO: This line of code loads data into the 'ProjectDataSet.GroupBySubdivison' table. You can move, or remove it, as needed.
        Me.GroupBySubdivisonTableAdapter.GetCountbySubdivisonName(Me.ProjectDataSet.GroupBySubdivison)
        'TODO: This line of code loads data into the 'ProjectDataSet.SUBDIVISION' table. You can move, or remove it, as needed.
        Me.SUBDIVISIONTableAdapter.Fill(Me.ProjectDataSet.SUBDIVISION)

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        WelcomePage.Show()
    End Sub

    Private Sub ShowSubdivisionStateToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.SUBDIVISIONTableAdapter.ShowSubdivisionState(Me.ProjectDataSet.SUBDIVISION)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ShowSubdivisionStateToolStripButton_Click_1(sender As Object, e As EventArgs) Handles ShowSubdivisionStateToolStripButton.Click
        Try
            Me.SUBDIVISIONTableAdapter.ShowSubdivisionState(Me.ProjectDataSet.SUBDIVISION)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub AlamoSalespersons_Click(sender As Object, e As EventArgs) Handles AlamoSalespersons.Click
        Try
            Me.SUBDIVISIONTableAdapter.AlamoSalespersons(Me.ProjectDataSet.SUBDIVISION)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ShowAllLotsButton_Click(sender As Object, e As EventArgs) Handles ShowAllLotsButton.Click
        Me.SUBDIVISIONTableAdapter.Fill(Me.ProjectDataSet.SUBDIVISION)
    End Sub
End Class