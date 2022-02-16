<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PurchaseLotform
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
        Me.PurchaseLotGrid = New System.Windows.Forms.DataGridView()
        Me.LOTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBDIVISIONIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PURCHASEPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PURCHASEDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PURCHASEDLOTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet = New HOAProject.ProjectDataSet()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.HighestValuedLotsButton = New System.Windows.Forms.Button()
        Me.LowestValuedLotsButton = New System.Windows.Forms.Button()
        Me.PURCHASED_LOTSTableAdapter = New HOAProject.ProjectDataSetTableAdapters.PURCHASED_LOTSTableAdapter()
        Me.ShowAllLotsButton = New System.Windows.Forms.Button()
        CType(Me.PurchaseLotGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PURCHASEDLOTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PurchaseLotGrid
        '
        Me.PurchaseLotGrid.AutoGenerateColumns = False
        Me.PurchaseLotGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.PurchaseLotGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.PurchaseLotGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurchaseLotGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LOTIDDataGridViewTextBoxColumn, Me.SUBDIVISIONIDDataGridViewTextBoxColumn, Me.PURCHASEPRICEDataGridViewTextBoxColumn, Me.PURCHASEDATEDataGridViewTextBoxColumn})
        Me.PurchaseLotGrid.DataSource = Me.PURCHASEDLOTSBindingSource
        Me.PurchaseLotGrid.Location = New System.Drawing.Point(96, 80)
        Me.PurchaseLotGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.PurchaseLotGrid.Name = "PurchaseLotGrid"
        Me.PurchaseLotGrid.RowHeadersVisible = False
        Me.PurchaseLotGrid.RowHeadersWidth = 51
        Me.PurchaseLotGrid.RowTemplate.Height = 24
        Me.PurchaseLotGrid.Size = New System.Drawing.Size(447, 224)
        Me.PurchaseLotGrid.TabIndex = 0
        '
        'LOTIDDataGridViewTextBoxColumn
        '
        Me.LOTIDDataGridViewTextBoxColumn.DataPropertyName = "LOT_ID"
        Me.LOTIDDataGridViewTextBoxColumn.HeaderText = "LOT_ID"
        Me.LOTIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LOTIDDataGridViewTextBoxColumn.Name = "LOTIDDataGridViewTextBoxColumn"
        Me.LOTIDDataGridViewTextBoxColumn.Width = 70
        '
        'SUBDIVISIONIDDataGridViewTextBoxColumn
        '
        Me.SUBDIVISIONIDDataGridViewTextBoxColumn.DataPropertyName = "SUBDIVISION_ID"
        Me.SUBDIVISIONIDDataGridViewTextBoxColumn.HeaderText = "SUBDIVISION_ID"
        Me.SUBDIVISIONIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SUBDIVISIONIDDataGridViewTextBoxColumn.Name = "SUBDIVISIONIDDataGridViewTextBoxColumn"
        Me.SUBDIVISIONIDDataGridViewTextBoxColumn.Width = 118
        '
        'PURCHASEPRICEDataGridViewTextBoxColumn
        '
        Me.PURCHASEPRICEDataGridViewTextBoxColumn.DataPropertyName = "PURCHASE_PRICE"
        Me.PURCHASEPRICEDataGridViewTextBoxColumn.HeaderText = "PURCHASE_PRICE"
        Me.PURCHASEPRICEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PURCHASEPRICEDataGridViewTextBoxColumn.Name = "PURCHASEPRICEDataGridViewTextBoxColumn"
        Me.PURCHASEPRICEDataGridViewTextBoxColumn.Width = 129
        '
        'PURCHASEDATEDataGridViewTextBoxColumn
        '
        Me.PURCHASEDATEDataGridViewTextBoxColumn.DataPropertyName = "PURCHASE_DATE"
        Me.PURCHASEDATEDataGridViewTextBoxColumn.HeaderText = "PURCHASE_DATE"
        Me.PURCHASEDATEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PURCHASEDATEDataGridViewTextBoxColumn.Name = "PURCHASEDATEDataGridViewTextBoxColumn"
        Me.PURCHASEDATEDataGridViewTextBoxColumn.Width = 126
        '
        'PURCHASEDLOTSBindingSource
        '
        Me.PURCHASEDLOTSBindingSource.DataMember = "PURCHASED_LOTS"
        Me.PURCHASEDLOTSBindingSource.DataSource = Me.ProjectDataSet
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "ProjectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(291, 371)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(68, 19)
        Me.BackButton.TabIndex = 1
        Me.BackButton.Text = "&Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'HighestValuedLotsButton
        '
        Me.HighestValuedLotsButton.Location = New System.Drawing.Point(96, 28)
        Me.HighestValuedLotsButton.Name = "HighestValuedLotsButton"
        Me.HighestValuedLotsButton.Size = New System.Drawing.Size(111, 23)
        Me.HighestValuedLotsButton.TabIndex = 2
        Me.HighestValuedLotsButton.Text = "Highest Valued Lots"
        Me.HighestValuedLotsButton.UseVisualStyleBackColor = True
        '
        'LowestValuedLotsButton
        '
        Me.LowestValuedLotsButton.Location = New System.Drawing.Point(432, 28)
        Me.LowestValuedLotsButton.Name = "LowestValuedLotsButton"
        Me.LowestValuedLotsButton.Size = New System.Drawing.Size(111, 23)
        Me.LowestValuedLotsButton.TabIndex = 3
        Me.LowestValuedLotsButton.Text = "Lowest Valued Lots"
        Me.LowestValuedLotsButton.UseVisualStyleBackColor = True
        '
        'PURCHASED_LOTSTableAdapter
        '
        Me.PURCHASED_LOTSTableAdapter.ClearBeforeFill = True
        '
        'ShowAllLotsButton
        '
        Me.ShowAllLotsButton.Location = New System.Drawing.Point(271, 28)
        Me.ShowAllLotsButton.Name = "ShowAllLotsButton"
        Me.ShowAllLotsButton.Size = New System.Drawing.Size(111, 23)
        Me.ShowAllLotsButton.TabIndex = 4
        Me.ShowAllLotsButton.Text = "Show All Lots"
        Me.ShowAllLotsButton.UseVisualStyleBackColor = True
        '
        'PurchaseLotform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 414)
        Me.Controls.Add(Me.ShowAllLotsButton)
        Me.Controls.Add(Me.LowestValuedLotsButton)
        Me.Controls.Add(Me.HighestValuedLotsButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.PurchaseLotGrid)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PurchaseLotform"
        Me.Text = "Purchased Lots"
        CType(Me.PurchaseLotGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PURCHASEDLOTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PurchaseLotGrid As DataGridView
    Friend WithEvents ProjectDataSet As ProjectDataSet
    Friend WithEvents PURCHASEDLOTSBindingSource As BindingSource
    Friend WithEvents PURCHASED_LOTSTableAdapter As ProjectDataSetTableAdapters.PURCHASED_LOTSTableAdapter
    Friend WithEvents LOTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUBDIVISIONIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PURCHASEPRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PURCHASEDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BackButton As Button
    Friend WithEvents HighestValuedLotsButton As Button
    Friend WithEvents LowestValuedLotsButton As Button
    Friend WithEvents ShowAllLotsButton As Button
End Class
