<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Availablelotdetailform
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
        Me.AvailableDetailformGrid = New System.Windows.Forms.DataGridView()
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISFENCEDDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.NUMOFTREESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISCULDESACDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LOTSTREETDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOTPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOTSIZEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOTMODELHOMEDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AvailablelotdetailQueryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet = New HOAProject.ProjectDataSet()
        Me.Available_lot_detail_QueryTableAdapter = New HOAProject.ProjectDataSetTableAdapters.Available_lot_detail_QueryTableAdapter()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.GOToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Subdivision_NameToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Subdivision_NameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.GOToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.AvailableDetailformGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvailablelotdetailQueryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GOToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AvailableDetailformGrid
        '
        Me.AvailableDetailformGrid.AutoGenerateColumns = False
        Me.AvailableDetailformGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.AvailableDetailformGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AvailableDetailformGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AvailableDetailformGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn, Me.LOTIDDataGridViewTextBoxColumn, Me.ISFENCEDDataGridViewCheckBoxColumn, Me.NUMOFTREESDataGridViewTextBoxColumn, Me.ISCULDESACDataGridViewCheckBoxColumn, Me.LOTSTREETDataGridViewTextBoxColumn, Me.LOTPRICEDataGridViewTextBoxColumn, Me.LOTSIZEDataGridViewTextBoxColumn, Me.LOTMODELHOMEDataGridViewCheckBoxColumn})
        Me.AvailableDetailformGrid.DataSource = Me.AvailablelotdetailQueryBindingSource
        Me.AvailableDetailformGrid.Location = New System.Drawing.Point(27, 49)
        Me.AvailableDetailformGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AvailableDetailformGrid.Name = "AvailableDetailformGrid"
        Me.AvailableDetailformGrid.RowHeadersVisible = False
        Me.AvailableDetailformGrid.RowHeadersWidth = 51
        Me.AvailableDetailformGrid.RowTemplate.Height = 24
        Me.AvailableDetailformGrid.Size = New System.Drawing.Size(1177, 318)
        Me.AvailableDetailformGrid.TabIndex = 0
        '
        'SUBDIVISIONNAMEDataGridViewTextBoxColumn
        '
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn.DataPropertyName = "SUBDIVISION_NAME"
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn.HeaderText = "SUBDIVISION_NAME"
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn.Name = "SUBDIVISIONNAMEDataGridViewTextBoxColumn"
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn.Width = 170
        '
        'LOTIDDataGridViewTextBoxColumn
        '
        Me.LOTIDDataGridViewTextBoxColumn.DataPropertyName = "LOT_ID"
        Me.LOTIDDataGridViewTextBoxColumn.HeaderText = "LOT_ID"
        Me.LOTIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LOTIDDataGridViewTextBoxColumn.Name = "LOTIDDataGridViewTextBoxColumn"
        Me.LOTIDDataGridViewTextBoxColumn.Width = 86
        '
        'ISFENCEDDataGridViewCheckBoxColumn
        '
        Me.ISFENCEDDataGridViewCheckBoxColumn.DataPropertyName = "IS_FENCED"
        Me.ISFENCEDDataGridViewCheckBoxColumn.HeaderText = "IS_FENCED"
        Me.ISFENCEDDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.ISFENCEDDataGridViewCheckBoxColumn.Name = "ISFENCEDDataGridViewCheckBoxColumn"
        Me.ISFENCEDDataGridViewCheckBoxColumn.Width = 89
        '
        'NUMOFTREESDataGridViewTextBoxColumn
        '
        Me.NUMOFTREESDataGridViewTextBoxColumn.DataPropertyName = "NUM_OF_TREES"
        Me.NUMOFTREESDataGridViewTextBoxColumn.HeaderText = "NUM_OF_TREES"
        Me.NUMOFTREESDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NUMOFTREESDataGridViewTextBoxColumn.Name = "NUMOFTREESDataGridViewTextBoxColumn"
        Me.NUMOFTREESDataGridViewTextBoxColumn.Width = 149
        '
        'ISCULDESACDataGridViewCheckBoxColumn
        '
        Me.ISCULDESACDataGridViewCheckBoxColumn.DataPropertyName = "IS_CULDESAC"
        Me.ISCULDESACDataGridViewCheckBoxColumn.HeaderText = "IS_CULDESAC"
        Me.ISCULDESACDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.ISCULDESACDataGridViewCheckBoxColumn.Name = "ISCULDESACDataGridViewCheckBoxColumn"
        Me.ISCULDESACDataGridViewCheckBoxColumn.Width = 107
        '
        'LOTSTREETDataGridViewTextBoxColumn
        '
        Me.LOTSTREETDataGridViewTextBoxColumn.DataPropertyName = "LOT_STREET"
        Me.LOTSTREETDataGridViewTextBoxColumn.HeaderText = "LOT_STREET"
        Me.LOTSTREETDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LOTSTREETDataGridViewTextBoxColumn.Name = "LOTSTREETDataGridViewTextBoxColumn"
        Me.LOTSTREETDataGridViewTextBoxColumn.Width = 128
        '
        'LOTPRICEDataGridViewTextBoxColumn
        '
        Me.LOTPRICEDataGridViewTextBoxColumn.DataPropertyName = "LOT_PRICE"
        Me.LOTPRICEDataGridViewTextBoxColumn.HeaderText = "LOT_PRICE"
        Me.LOTPRICEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LOTPRICEDataGridViewTextBoxColumn.Name = "LOTPRICEDataGridViewTextBoxColumn"
        Me.LOTPRICEDataGridViewTextBoxColumn.Width = 113
        '
        'LOTSIZEDataGridViewTextBoxColumn
        '
        Me.LOTSIZEDataGridViewTextBoxColumn.DataPropertyName = "LOT_SIZE"
        Me.LOTSIZEDataGridViewTextBoxColumn.HeaderText = "LOT_SIZE"
        Me.LOTSIZEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LOTSIZEDataGridViewTextBoxColumn.Name = "LOTSIZEDataGridViewTextBoxColumn"
        Me.LOTSIZEDataGridViewTextBoxColumn.Width = 103
        '
        'LOTMODELHOMEDataGridViewCheckBoxColumn
        '
        Me.LOTMODELHOMEDataGridViewCheckBoxColumn.DataPropertyName = "LOT_MODEL_HOME"
        Me.LOTMODELHOMEDataGridViewCheckBoxColumn.HeaderText = "LOT_MODEL_HOME"
        Me.LOTMODELHOMEDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.LOTMODELHOMEDataGridViewCheckBoxColumn.Name = "LOTMODELHOMEDataGridViewCheckBoxColumn"
        Me.LOTMODELHOMEDataGridViewCheckBoxColumn.Width = 148
        '
        'AvailablelotdetailQueryBindingSource
        '
        Me.AvailablelotdetailQueryBindingSource.DataMember = "Available_lot_detail_Query"
        Me.AvailablelotdetailQueryBindingSource.DataSource = Me.ProjectDataSet
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "ProjectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Available_lot_detail_QueryTableAdapter
        '
        Me.Available_lot_detail_QueryTableAdapter.ClearBeforeFill = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(587, 414)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(91, 23)
        Me.BackButton.TabIndex = 2
        Me.BackButton.Text = "&Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'GOToolStrip1
        '
        Me.GOToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.GOToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Subdivision_NameToolStripLabel, Me.Subdivision_NameToolStripTextBox, Me.GOToolStripButton})
        Me.GOToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.GOToolStrip1.Name = "GOToolStrip1"
        Me.GOToolStrip1.Size = New System.Drawing.Size(1219, 27)
        Me.GOToolStrip1.TabIndex = 5
        Me.GOToolStrip1.Text = "GOToolStrip1"
        '
        'Subdivision_NameToolStripLabel
        '
        Me.Subdivision_NameToolStripLabel.Name = "Subdivision_NameToolStripLabel"
        Me.Subdivision_NameToolStripLabel.Size = New System.Drawing.Size(134, 24)
        Me.Subdivision_NameToolStripLabel.Text = "Subdivision_Name:"
        '
        'Subdivision_NameToolStripTextBox
        '
        Me.Subdivision_NameToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Subdivision_NameToolStripTextBox.Name = "Subdivision_NameToolStripTextBox"
        Me.Subdivision_NameToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'GOToolStripButton
        '
        Me.GOToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GOToolStripButton.Name = "GOToolStripButton"
        Me.GOToolStripButton.Size = New System.Drawing.Size(34, 24)
        Me.GOToolStripButton.Text = "GO"
        '
        'Availablelotdetailform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 450)
        Me.Controls.Add(Me.GOToolStrip1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.AvailableDetailformGrid)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Availablelotdetailform"
        Me.Text = "Details of Available Lots"
        CType(Me.AvailableDetailformGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvailablelotdetailQueryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GOToolStrip1.ResumeLayout(False)
        Me.GOToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AvailableDetailformGrid As DataGridView
    Friend WithEvents ProjectDataSet As ProjectDataSet
    Friend WithEvents AvailablelotdetailQueryBindingSource As BindingSource
    Friend WithEvents Available_lot_detail_QueryTableAdapter As ProjectDataSetTableAdapters.Available_lot_detail_QueryTableAdapter
    Friend WithEvents SUBDIVISIONNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LOTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ISFENCEDDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents NUMOFTREESDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ISCULDESACDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents LOTSTREETDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LOTPRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LOTSIZEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LOTMODELHOMEDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents BackButton As Button
    Friend WithEvents GOToolStrip1 As ToolStrip
    Friend WithEvents Subdivision_NameToolStripLabel As ToolStripLabel
    Friend WithEvents Subdivision_NameToolStripTextBox As ToolStripTextBox
    Friend WithEvents GOToolStripButton As ToolStripButton
End Class
