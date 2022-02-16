Imports System.Globalization
Public Class Models
    Private Sub Models_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet.MODEL' table. You can move, or remove it, as needed.
        Me.MODELTableAdapter.Fill(Me.ProjectDataSet.MODEL)
        OutputResult.Text = Me.MODELTableAdapter.CountAllModels
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        WelcomePage.Show()
    End Sub

    Private Sub OutputResult_Click(sender As Object, e As EventArgs) Handles OutputResult.Click

    End Sub

    Private Sub AllTwoStoriesButton_Click(sender As Object, e As EventArgs) Handles AllTwoStoriesButton.Click
        Try
            Me.MODELTableAdapter.ShowTwoStoryModels(Me.ProjectDataSet.MODEL)
            OutputResult.Text = Me.MODELTableAdapter.CountTwoStoryModels
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AllModels_Click(sender As Object, e As EventArgs) Handles AllModels.Click
        Try
            Me.MODELTableAdapter.Fill(Me.ProjectDataSet.MODEL)
            OutputResult.Text = Me.MODELTableAdapter.CountAllModels
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ShowModelPricing_Click(sender As Object, e As EventArgs) Handles ShowModelPricing.Click
        Try

            Me.MODELTableAdapter.ModelsonPriceInput(Me.ProjectDataSet.MODEL, Decimal.Parse(StartingPrice.Text))
            OutputResult.Text = Me.MODELTableAdapter.CountonPriceInput(Me.ProjectDataSet.MODEL, Decimal.Parse(StartingPrice.Text))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            System.Windows.Forms.MessageBox.Show("Please enter a valid model price.")
            OutputResult.Text = ""
        End Try
    End Sub

    Private Sub StartingPrice_TextChanged(sender As Object, e As EventArgs) Handles StartingPrice.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles StartingSize.TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ModelsonSizeInput.Click
        Try
            Me.MODELTableAdapter.ModelsonSizeInput(Me.ProjectDataSet.MODEL, Decimal.Parse(StartingSize.Text))
            OutputResult.Text = Me.MODELTableAdapter.ModelsonSizeInput(Me.ProjectDataSet.MODEL, Decimal.Parse(StartingSize.Text))
        Catch
            System.Windows.Forms.MessageBox.Show("Please enter a valid model size.")
            OutputResult.Text = ""
        End Try
    End Sub


    Private ReadOnly Property Parse(text As String) As NumberStyles
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Private Sub DoubleInputButton_Click_1(sender As Object, e As EventArgs) Handles DoubleInputButton.Click
        Try
            Dim mODEL As ProjectDataSet.MODELDataTable = Me.ProjectDataSet.MODEL
            Me.MODELTableAdapter.ModelbyDoubleInput(mODEL, Decimal.Parse(StartingPrice.Text, Parse(StartingSize.Text)))
            OutputResult.Text = Me.MODELTableAdapter.CountModelbyDoubleInput(mODEL, Decimal.Parse(StartingPrice.Text, Parse(StartingSize.Text)))
        Catch
            System.Windows.Forms.MessageBox.Show("Please enter a valid model Price or Size.")
            OutputResult.Text = ""
        End Try
    End Sub
End Class
