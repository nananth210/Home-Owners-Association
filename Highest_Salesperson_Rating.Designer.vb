<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Highest_Salesperson_Rating
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
        Me.SALESPERSONRATINGSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet = New HOAProject.ProjectDataSet()
        Me.SALESPERSON_RATINGSTableAdapter = New HOAProject.ProjectDataSetTableAdapters.SALESPERSON_RATINGSTableAdapter()
        Me.SALESPERSONRATINGSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RATINGDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RATINGCOMMENTSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RATINGVALUEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALESPERSONIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.Highest_ReviewsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Highest_ReviewsToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.SALESPERSONRATINGSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALESPERSONRATINGSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Highest_ReviewsToolStrip.SuspendLayout()
        Me.SuspendLayout()
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
        'SALESPERSONRATINGSBindingSource1
        '
        Me.SALESPERSONRATINGSBindingSource1.DataMember = "SALESPERSON_RATINGS"
        Me.SALESPERSONRATINGSBindingSource1.DataSource = Me.ProjectDataSet
        '
        'RATINGDATEDataGridViewTextBoxColumn
        '
        Me.RATINGDATEDataGridViewTextBoxColumn.DataPropertyName = "RATING_DATE"
        Me.RATINGDATEDataGridViewTextBoxColumn.HeaderText = "RATING_DATE"
        Me.RATINGDATEDataGridViewTextBoxColumn.Name = "RATINGDATEDataGridViewTextBoxColumn"
        Me.RATINGDATEDataGridViewTextBoxColumn.Width = 108
        '
        'RATINGCOMMENTSDataGridViewTextBoxColumn
        '
        Me.RATINGCOMMENTSDataGridViewTextBoxColumn.DataPropertyName = "RATING_COMMENTS"
        Me.RATINGCOMMENTSDataGridViewTextBoxColumn.HeaderText = "RATING_COMMENTS"
        Me.RATINGCOMMENTSDataGridViewTextBoxColumn.Name = "RATINGCOMMENTSDataGridViewTextBoxColumn"
        Me.RATINGCOMMENTSDataGridViewTextBoxColumn.Width = 141
        '
        'RATINGVALUEDataGridViewTextBoxColumn
        '
        Me.RATINGVALUEDataGridViewTextBoxColumn.DataPropertyName = "RATING_VALUE"
        Me.RATINGVALUEDataGridViewTextBoxColumn.HeaderText = "RATING_VALUE"
        Me.RATINGVALUEDataGridViewTextBoxColumn.Name = "RATINGVALUEDataGridViewTextBoxColumn"
        Me.RATINGVALUEDataGridViewTextBoxColumn.Width = 114
        '
        'CUSTOMERIDDataGridViewTextBoxColumn
        '
        Me.CUSTOMERIDDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.HeaderText = "CUSTOMER_ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.Name = "CUSTOMERIDDataGridViewTextBoxColumn"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.Width = 110
        '
        'SALESPERSONIDDataGridViewTextBoxColumn
        '
        Me.SALESPERSONIDDataGridViewTextBoxColumn.DataPropertyName = "SALESPERSON_ID"
        Me.SALESPERSONIDDataGridViewTextBoxColumn.HeaderText = "SALESPERSON_ID"
        Me.SALESPERSONIDDataGridViewTextBoxColumn.Name = "SALESPERSONIDDataGridViewTextBoxColumn"
        Me.SALESPERSONIDDataGridViewTextBoxColumn.Width = 128
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SALESPERSONIDDataGridViewTextBoxColumn, Me.CUSTOMERIDDataGridViewTextBoxColumn, Me.RATINGVALUEDataGridViewTextBoxColumn, Me.RATINGCOMMENTSDataGridViewTextBoxColumn, Me.RATINGDATEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SALESPERSONRATINGSBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(87, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(606, 148)
        Me.DataGridView1.TabIndex = 0
        '
        'ReturnButton
        '
        Me.ReturnButton.Location = New System.Drawing.Point(337, 365)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(114, 46)
        Me.ReturnButton.TabIndex = 2
        Me.ReturnButton.Text = "Return to All Reviews"
        Me.ReturnButton.UseVisualStyleBackColor = True
        '
        'Highest_ReviewsToolStrip
        '
        Me.Highest_ReviewsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Highest_ReviewsToolStripButton})
        Me.Highest_ReviewsToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.Highest_ReviewsToolStrip.Name = "Highest_ReviewsToolStrip"
        Me.Highest_ReviewsToolStrip.Size = New System.Drawing.Size(111, 25)
        Me.Highest_ReviewsToolStrip.TabIndex = 3
        Me.Highest_ReviewsToolStrip.Text = "Highest_ReviewsToolStrip"
        '
        'Highest_ReviewsToolStripButton
        '
        Me.Highest_ReviewsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Highest_ReviewsToolStripButton.Name = "Highest_ReviewsToolStripButton"
        Me.Highest_ReviewsToolStripButton.Size = New System.Drawing.Size(99, 22)
        Me.Highest_ReviewsToolStripButton.Text = "Highest_Reviews"
        '
        'Highest_Salesperson_Rating
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Highest_ReviewsToolStrip)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Highest_Salesperson_Rating"
        Me.Text = "Best Reviews"
        CType(Me.SALESPERSONRATINGSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALESPERSONRATINGSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Highest_ReviewsToolStrip.ResumeLayout(False)
        Me.Highest_ReviewsToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProjectDataSet As ProjectDataSet
    Friend WithEvents SALESPERSONRATINGSBindingSource As BindingSource
    Friend WithEvents SALESPERSON_RATINGSTableAdapter As ProjectDataSetTableAdapters.SALESPERSON_RATINGSTableAdapter
    Friend WithEvents SALESPERSONRATINGSBindingSource1 As BindingSource
    Friend WithEvents RATINGDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RATINGCOMMENTSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RATINGVALUEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SALESPERSONIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ReturnButton As Button
    Friend WithEvents Highest_ReviewsToolStrip As ToolStrip
    Friend WithEvents Highest_ReviewsToolStripButton As ToolStripButton
End Class
