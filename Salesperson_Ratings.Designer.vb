<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salesperson_Ratings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SALESPERSONIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RATINGVALUEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RATINGCOMMENTSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RATINGDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALESPERSONRATINGSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet = New HOAProject.ProjectDataSet()
        Me.SALESPERSON_RATINGSTableAdapter = New HOAProject.ProjectDataSetTableAdapters.SALESPERSON_RATINGSTableAdapter()
        Me.Exit_Salesperson_Ratings = New System.Windows.Forms.Button()
        Me.TextAverage = New System.Windows.Forms.Label()
        Me.OutputAverage = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALESPERSONRATINGSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SALESPERSONIDDataGridViewTextBoxColumn, Me.CUSTOMERIDDataGridViewTextBoxColumn, Me.RATINGVALUEDataGridViewTextBoxColumn, Me.RATINGCOMMENTSDataGridViewTextBoxColumn, Me.RATINGDATEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SALESPERSONRATINGSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(81, 42)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(751, 337)
        Me.DataGridView1.TabIndex = 0
        '
        'SALESPERSONIDDataGridViewTextBoxColumn
        '
        Me.SALESPERSONIDDataGridViewTextBoxColumn.DataPropertyName = "SALESPERSON_ID"
        Me.SALESPERSONIDDataGridViewTextBoxColumn.HeaderText = "SALESPERSON_ID"
        Me.SALESPERSONIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SALESPERSONIDDataGridViewTextBoxColumn.Name = "SALESPERSONIDDataGridViewTextBoxColumn"
        Me.SALESPERSONIDDataGridViewTextBoxColumn.Width = 160
        '
        'CUSTOMERIDDataGridViewTextBoxColumn
        '
        Me.CUSTOMERIDDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.HeaderText = "CUSTOMER_ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CUSTOMERIDDataGridViewTextBoxColumn.Name = "CUSTOMERIDDataGridViewTextBoxColumn"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.Width = 136
        '
        'RATINGVALUEDataGridViewTextBoxColumn
        '
        Me.RATINGVALUEDataGridViewTextBoxColumn.DataPropertyName = "RATING_VALUE"
        Me.RATINGVALUEDataGridViewTextBoxColumn.HeaderText = "RATING_VALUE"
        Me.RATINGVALUEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RATINGVALUEDataGridViewTextBoxColumn.Name = "RATINGVALUEDataGridViewTextBoxColumn"
        Me.RATINGVALUEDataGridViewTextBoxColumn.Width = 142
        '
        'RATINGCOMMENTSDataGridViewTextBoxColumn
        '
        Me.RATINGCOMMENTSDataGridViewTextBoxColumn.DataPropertyName = "RATING_COMMENTS"
        Me.RATINGCOMMENTSDataGridViewTextBoxColumn.HeaderText = "RATING_COMMENTS"
        Me.RATINGCOMMENTSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RATINGCOMMENTSDataGridViewTextBoxColumn.Name = "RATINGCOMMENTSDataGridViewTextBoxColumn"
        Me.RATINGCOMMENTSDataGridViewTextBoxColumn.Width = 176
        '
        'RATINGDATEDataGridViewTextBoxColumn
        '
        Me.RATINGDATEDataGridViewTextBoxColumn.DataPropertyName = "RATING_DATE"
        Me.RATINGDATEDataGridViewTextBoxColumn.HeaderText = "RATING_DATE"
        Me.RATINGDATEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RATINGDATEDataGridViewTextBoxColumn.Name = "RATINGDATEDataGridViewTextBoxColumn"
        Me.RATINGDATEDataGridViewTextBoxColumn.Width = 134
        '
        'SALESPERSONRATINGSBindingSource
        '
        Me.SALESPERSONRATINGSBindingSource.DataMember = "SALESPERSON_RATINGS"
        Me.SALESPERSONRATINGSBindingSource.DataSource = Me.ProjectDataSet
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "ProjectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SALESPERSON_RATINGSTableAdapter
        '
        Me.SALESPERSON_RATINGSTableAdapter.ClearBeforeFill = True
        '
        'Exit_Salesperson_Ratings
        '
        Me.Exit_Salesperson_Ratings.Location = New System.Drawing.Point(369, 460)
        Me.Exit_Salesperson_Ratings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Exit_Salesperson_Ratings.Name = "Exit_Salesperson_Ratings"
        Me.Exit_Salesperson_Ratings.Size = New System.Drawing.Size(183, 28)
        Me.Exit_Salesperson_Ratings.TabIndex = 1
        Me.Exit_Salesperson_Ratings.Text = "Return to Welcome Page"
        Me.Exit_Salesperson_Ratings.UseVisualStyleBackColor = True
        '
        'TextAverage
        '
        Me.TextAverage.AutoSize = True
        Me.TextAverage.Location = New System.Drawing.Point(611, 388)
        Me.TextAverage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TextAverage.Name = "TextAverage"
        Me.TextAverage.Size = New System.Drawing.Size(197, 17)
        Me.TextAverage.TabIndex = 2
        Me.TextAverage.Text = "Average Salesperson Rating: "
        '
        'OutputAverage
        '
        Me.OutputAverage.AutoSize = True
        Me.OutputAverage.BackColor = System.Drawing.Color.Yellow
        Me.OutputAverage.Location = New System.Drawing.Point(816, 388)
        Me.OutputAverage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OutputAverage.Name = "OutputAverage"
        Me.OutputAverage.Size = New System.Drawing.Size(16, 17)
        Me.OutputAverage.TabIndex = 3
        Me.OutputAverage.Text = "0"
        '
        'Salesperson_Ratings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.OutputAverage)
        Me.Controls.Add(Me.TextAverage)
        Me.Controls.Add(Me.Exit_Salesperson_Ratings)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Salesperson_Ratings"
        Me.Text = "Salesperson_Ratings"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALESPERSONRATINGSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProjectDataSet As ProjectDataSet
    Friend WithEvents SALESPERSONRATINGSBindingSource As BindingSource
    Friend WithEvents SALESPERSON_RATINGSTableAdapter As ProjectDataSetTableAdapters.SALESPERSON_RATINGSTableAdapter
    Friend WithEvents SALESPERSONIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RATINGVALUEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RATINGCOMMENTSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RATINGDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Exit_Salesperson_Ratings As Button
    Friend WithEvents TextAverage As Label
    Friend WithEvents OutputAverage As Label
End Class
