<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerPurchaseRecordForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CustomerPurchases = New System.Windows.Forms.DataGridView()
        Me.CustomernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CusContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CusEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesPersonnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchasedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerPurchaseRecordBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet = New HOAProject.ProjectDataSet()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TotalSalesCountToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CustomerPurchaseRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_Purchase_RecordTableAdapter = New HOAProject.ProjectDataSetTableAdapters.Customer_Purchase_RecordTableAdapter()
        CType(Me.CustomerPurchases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerPurchaseRecordBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerPurchaseRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerPurchases
        '
        Me.CustomerPurchases.AutoGenerateColumns = False
        Me.CustomerPurchases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CustomerPurchases.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.CustomerPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerPurchases.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomernameDataGridViewTextBoxColumn, Me.CUSADDRESSDataGridViewTextBoxColumn, Me.CusContactDataGridViewTextBoxColumn, Me.CusEmailDataGridViewTextBoxColumn, Me.SalesPersonnameDataGridViewTextBoxColumn, Me.PurchasedateDataGridViewTextBoxColumn, Me.SellPriceDataGridViewTextBoxColumn})
        Me.CustomerPurchases.DataSource = Me.CustomerPurchaseRecordBindingSource1
        Me.CustomerPurchases.Location = New System.Drawing.Point(28, 47)
        Me.CustomerPurchases.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CustomerPurchases.Name = "CustomerPurchases"
        Me.CustomerPurchases.RowHeadersVisible = False
        Me.CustomerPurchases.RowHeadersWidth = 51
        Me.CustomerPurchases.RowTemplate.Height = 24
        Me.CustomerPurchases.Size = New System.Drawing.Size(707, 153)
        Me.CustomerPurchases.TabIndex = 0
        '
        'CustomernameDataGridViewTextBoxColumn
        '
        Me.CustomernameDataGridViewTextBoxColumn.DataPropertyName = "Customer_name"
        Me.CustomernameDataGridViewTextBoxColumn.HeaderText = "Customer_name"
        Me.CustomernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustomernameDataGridViewTextBoxColumn.Name = "CustomernameDataGridViewTextBoxColumn"
        Me.CustomernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomernameDataGridViewTextBoxColumn.Width = 108
        '
        'CUSADDRESSDataGridViewTextBoxColumn
        '
        Me.CUSADDRESSDataGridViewTextBoxColumn.DataPropertyName = "CUS_ADDRESS"
        Me.CUSADDRESSDataGridViewTextBoxColumn.HeaderText = "CUS_ADDRESS"
        Me.CUSADDRESSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CUSADDRESSDataGridViewTextBoxColumn.Name = "CUSADDRESSDataGridViewTextBoxColumn"
        Me.CUSADDRESSDataGridViewTextBoxColumn.Width = 112
        '
        'CusContactDataGridViewTextBoxColumn
        '
        Me.CusContactDataGridViewTextBoxColumn.DataPropertyName = "Cus_Contact"
        Me.CusContactDataGridViewTextBoxColumn.HeaderText = "Cus_Contact"
        Me.CusContactDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CusContactDataGridViewTextBoxColumn.Name = "CusContactDataGridViewTextBoxColumn"
        Me.CusContactDataGridViewTextBoxColumn.Width = 93
        '
        'CusEmailDataGridViewTextBoxColumn
        '
        Me.CusEmailDataGridViewTextBoxColumn.DataPropertyName = "Cus_Email"
        Me.CusEmailDataGridViewTextBoxColumn.HeaderText = "Cus_Email"
        Me.CusEmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CusEmailDataGridViewTextBoxColumn.Name = "CusEmailDataGridViewTextBoxColumn"
        Me.CusEmailDataGridViewTextBoxColumn.Width = 81
        '
        'SalesPersonnameDataGridViewTextBoxColumn
        '
        Me.SalesPersonnameDataGridViewTextBoxColumn.DataPropertyName = "SalesPerson_name"
        Me.SalesPersonnameDataGridViewTextBoxColumn.HeaderText = "SalesPerson_name"
        Me.SalesPersonnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SalesPersonnameDataGridViewTextBoxColumn.Name = "SalesPersonnameDataGridViewTextBoxColumn"
        Me.SalesPersonnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SalesPersonnameDataGridViewTextBoxColumn.Width = 123
        '
        'PurchasedateDataGridViewTextBoxColumn
        '
        Me.PurchasedateDataGridViewTextBoxColumn.DataPropertyName = "Purchase_date"
        Me.PurchasedateDataGridViewTextBoxColumn.HeaderText = "Purchase_date"
        Me.PurchasedateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PurchasedateDataGridViewTextBoxColumn.Name = "PurchasedateDataGridViewTextBoxColumn"
        Me.PurchasedateDataGridViewTextBoxColumn.ReadOnly = True
        Me.PurchasedateDataGridViewTextBoxColumn.Width = 104
        '
        'SellPriceDataGridViewTextBoxColumn
        '
        Me.SellPriceDataGridViewTextBoxColumn.DataPropertyName = "Sell_Price"
        Me.SellPriceDataGridViewTextBoxColumn.HeaderText = "Sell_Price"
        Me.SellPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SellPriceDataGridViewTextBoxColumn.Name = "SellPriceDataGridViewTextBoxColumn"
        Me.SellPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.SellPriceDataGridViewTextBoxColumn.Width = 79
        '
        'CustomerPurchaseRecordBindingSource1
        '
        Me.CustomerPurchaseRecordBindingSource1.DataMember = "Customer_Purchase_Record"
        Me.CustomerPurchaseRecordBindingSource1.DataSource = Me.ProjectDataSet
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "ProjectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(258, 306)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(68, 19)
        Me.BackButton.TabIndex = 1
        Me.BackButton.Text = "&Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'TotalSalesCountToolStrip
        '
        Me.TotalSalesCountToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TotalSalesCountToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.TotalSalesCountToolStrip.Name = "TotalSalesCountToolStrip"
        Me.TotalSalesCountToolStrip.Size = New System.Drawing.Size(746, 25)
        Me.TotalSalesCountToolStrip.TabIndex = 5
        Me.TotalSalesCountToolStrip.Text = "TotalSalesCountToolStrip"
        '
        'CustomerPurchaseRecordBindingSource
        '
        Me.CustomerPurchaseRecordBindingSource.DataMember = "Customer_Purchase_Record"
        Me.CustomerPurchaseRecordBindingSource.DataSource = Me.ProjectDataSet
        '
        'Customer_Purchase_RecordTableAdapter
        '
        Me.Customer_Purchase_RecordTableAdapter.ClearBeforeFill = True
        '
        'CustomerPurchaseRecordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 366)
        Me.Controls.Add(Me.TotalSalesCountToolStrip)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.CustomerPurchases)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "CustomerPurchaseRecordForm"
        Me.Text = "Customer Purchase Records"
        CType(Me.CustomerPurchases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerPurchaseRecordBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerPurchaseRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerPurchases As DataGridView
    Friend WithEvents ProjectDataSet As ProjectDataSet
    Friend WithEvents CustomerPurchaseRecordBindingSource As BindingSource
    Friend WithEvents Customer_Purchase_RecordTableAdapter As ProjectDataSetTableAdapters.Customer_Purchase_RecordTableAdapter
    Friend WithEvents CustomernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CusContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CusEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalesPersonnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchasedateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SellPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BackButton As Button
    Friend WithEvents TotalSalesCountToolStrip As ToolStrip
    Friend WithEvents CustomerPurchaseRecordBindingSource1 As BindingSource
End Class
