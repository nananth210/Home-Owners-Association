<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Newest_Salesperson_Rating
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
        Me.SALESPERSONRATINGSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet = New HOAProject.ProjectDataSet()
        Me.Newest_ReviewsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Newest_ReviewsToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.SALESPERSONRATINGSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALESPERSON_RATINGSTableAdapter = New HOAProject.ProjectDataSetTableAdapters.SALESPERSON_RATINGSTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALESPERSONRATINGSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Newest_ReviewsToolStrip.SuspendLayout()
        CType(Me.SALESPERSONRATINGSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SALESPERSONIDDataGridViewTextBoxColumn, Me.CUSTOMERIDDataGridViewTextBoxColumn, Me.RATINGVALUEDataGridViewTextBoxColumn, Me.RATINGCOMMENTSDataGridViewTextBoxColumn, Me.RATINGDATEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SALESPERSONRATINGSBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(82, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(607, 223)
        Me.DataGridView1.TabIndex = 0
        '
        'SALESPERSONIDDataGridViewTextBoxColumn
        '
        Me.SALESPERSONIDDataGridViewTextBoxColumn.DataPropertyName = "SALESPERSON_ID"
        Me.SALESPERSONIDDataGridViewTextBoxColumn.HeaderText = "SALESPERSON_ID"
        Me.SALESPERSONIDDataGridViewTextBoxColumn.Name = "SALESPERSONIDDataGridViewTextBoxColumn"
        Me.SALESPERSONIDDataGridViewTextBoxColumn.Width = 128
        '
        'CUSTOMERIDDataGridViewTextBoxColumn
        '
        Me.CUSTOMERIDDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.HeaderText = "CUSTOMER_ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.Name = "CUSTOMERIDDataGridViewTextBoxColumn"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.Width = 110
        '
        'RATINGVALUEDataGridViewTextBoxColumn
        '
        Me.RATINGVALUEDataGridViewTextBoxColumn.DataPropertyName = "RATING_VALUE"
        Me.RATINGVALUEDataGridViewTextBoxColumn.HeaderText = "RATING_VALUE"
        Me.RATINGVALUEDataGridViewTextBoxColumn.Name = "RATINGVALUEDataGridViewTextBoxColumn"
        Me.RATINGVALUEDataGridViewTextBoxColumn.Width = 114
        '
        'RATINGCOMMENTSDataGridViewTextBoxColumn
        '
        Me.RATINGCOMMENTSDataGridViewTextBoxColumn.DataPropertyName = "RATING_COMMENTS"
        Me.RATINGCOMMENTSDataGridViewTextBoxColumn.HeaderText = "RATING_COMMENTS"
        Me.RATINGCOMMENTSDataGridViewTextBoxColumn.Name = "RATINGCOMMENTSDataGridViewTextBoxColumn"
        Me.RATINGCOMMENTSDataGridViewTextBoxColumn.Width = 141
        '
        'RATINGDATEDataGridViewTextBoxColumn
        '
        Me.RATINGDATEDataGridViewTextBoxColumn.DataPropertyName = "RATING_DATE"
        Me.RATINGDATEDataGridViewTextBoxColumn.HeaderText = "RATING_DATE"
        Me.RATINGDATEDataGridViewTextBoxColumn.Name = "RATINGDATEDataGridViewTextBoxColumn"
        Me.RATINGDATEDataGridViewTextBoxColumn.Width = 108
        '
        'SALESPERSONRATINGSBindingSource1
        '
        Me.SALESPERSONRATINGSBindingSource1.DataMember = "SALESPERSON_RATINGS"
        Me.SALESPERSONRATINGSBindingSource1.DataSource = Me.ProjectDataSet
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "ProjectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Newest_ReviewsToolStrip
        '
        Me.Newest_ReviewsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Newest_ReviewsToolStripButton})
        Me.Newest_ReviewsToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.Newest_ReviewsToolStrip.Name = "Newest_ReviewsToolStrip"
        Me.Newest_ReviewsToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.Newest_ReviewsToolStrip.TabIndex = 1
        Me.Newest_ReviewsToolStrip.Text = "Newest_ReviewsToolStrip"
        '
        'Newest_ReviewsToolStripButton
        '
        Me.Newest_ReviewsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Newest_ReviewsToolStripButton.Name = "Newest_ReviewsToolStripButton"
        Me.Newest_ReviewsToolStripButton.Size = New System.Drawing.Size(104, 22)
        Me.Newest_ReviewsToolStripButton.Text = "NEWEST REVIEWS"
        '
        'ReturnButton
        '
        Me.ReturnButton.Location = New System.Drawing.Point(332, 372)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(114, 46)
        Me.ReturnButton.TabIndex = 3
        Me.ReturnButton.TabStop = False
        Me.ReturnButton.Text = "Return to All Reviews"
        Me.ReturnButton.UseVisualStyleBackColor = True
        '
        'SALESPERSONRATINGSBindingSource
        '
        Me.SALESPERSONRATINGSBindingSource.DataMember = "SALESPERSON_RATINGS"
        Me.SALESPERSONRATINGSBindingSource.DataSource = Me.ProjectDataSet
        '
        'SALESPERSON_RATINGSTableAdapter
        '
        Me.SALESPERSON_RATINGSTableAdapter.ClearBeforeFill = True
        '
        'Newest_Salesperson_Rating
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.Newest_ReviewsToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Newest_Salesperson_Rating"
        Me.Text = "Newest Reviews"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALESPERSONRATINGSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Newest_ReviewsToolStrip.ResumeLayout(False)
        Me.Newest_ReviewsToolStrip.PerformLayout()
        CType(Me.SALESPERSONRATINGSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProjectDataSet As ProjectDataSet
    Friend WithEvents SALESPERSONRATINGSBindingSource As BindingSource
    Friend WithEvents SALESPERSON_RATINGSTableAdapter As ProjectDataSetTableAdapters.SALESPERSON_RATINGSTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SALESPERSONIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RATINGVALUEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RATINGCOMMENTSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RATINGDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SALESPERSONRATINGSBindingSource1 As BindingSource
    Friend WithEvents Newest_ReviewsToolStrip As ToolStrip
    Friend WithEvents Newest_ReviewsToolStripButton As ToolStripButton
    Friend WithEvents ReturnButton As Button
End Class
