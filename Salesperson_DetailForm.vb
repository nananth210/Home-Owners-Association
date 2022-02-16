Public Class Salesperson_DetailForm
    Private Sub Salesperson_DetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProjectDataSet1.EmployeeManager' table. You can move, or remove it, as needed.
        Me.EmployeeManagerTableAdapter.Fill(Me.ProjectDataSet1.EmployeeManager)

    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        WelcomePage.Show()
    End Sub
    Private Sub SalespersonManagerGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SalespersonManagerGrid.CellContentClick

    End Sub







    Private Sub EmployeeName_Button_Click(sender As Object, e As EventArgs) Handles EmployeeName_Button.Click
        Try
            Me.Get_MgrnameTableAdapter.Fill(Me.ProjectDataSet1.get_Mgrname, TextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            System.Windows.Forms.MessageBox.Show("No Such Employee Exist")

        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Try
            Me.Get_MgrnameTableAdapter.Fill(Me.ProjectDataSet1.get_Mgrname, ComboBox2.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            System.Windows.Forms.MessageBox.Show("No Such Employee Exist")

        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class