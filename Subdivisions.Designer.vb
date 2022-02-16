<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Subdivisions
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SUBDIVISIONIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBDIVISIONADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSTRUCTIONENDDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALESPERSONIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBDIVISIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet = New HOAProject.ProjectDataSet()
        Me.SUBDIVISIONTableAdapter = New HOAProject.ProjectDataSetTableAdapters.SUBDIVISIONTableAdapter()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ShowSubdivisionStateToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ShowSubdivisionStateToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AlamoSalespersons = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBySubdivisonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SUBDIVISIONBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SUBDIVISIONBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SUBDIVISIONTableAdapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBySubdivisonTableAdapter = New HOAProject.ProjectDataSetTableAdapters.GroupBySubdivisonTableAdapter()
        Me.GroupBySubdivisonBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountofSalesPersonsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesPerson_Label = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.ProjectDataSet1 = New HOAProject.ProjectDataSet()
        Me.GroupByStateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupByStateTableAdapter = New HOAProject.ProjectDataSetTableAdapters.GroupByStateTableAdapter()
        Me.STATEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberofSubdivisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sundivision_State = New System.Windows.Forms.Label()
        Me.ShowAllLotsButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUBDIVISIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShowSubdivisionStateToolStrip.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupBySubdivisonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUBDIVISIONBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUBDIVISIONBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUBDIVISIONTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupBySubdivisonBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupByStateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SUBDIVISIONIDDataGridViewTextBoxColumn, Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn, Me.SUBDIVISIONADDRESSDataGridViewTextBoxColumn, Me.CITYDataGridViewTextBoxColumn, Me.STATEDataGridViewTextBoxColumn, Me.ZIPDataGridViewTextBoxColumn, Me.CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn, Me.CONSTRUCTIONENDDATEDataGridViewTextBoxColumn, Me.SALESPERSONIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SUBDIVISIONBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(41, 34)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1348, 247)
        Me.DataGridView1.TabIndex = 0
        '
        'SUBDIVISIONIDDataGridViewTextBoxColumn
        '
        Me.SUBDIVISIONIDDataGridViewTextBoxColumn.DataPropertyName = "SUBDIVISION_ID"
        Me.SUBDIVISIONIDDataGridViewTextBoxColumn.HeaderText = "SUBDIVISION_ID"
        Me.SUBDIVISIONIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SUBDIVISIONIDDataGridViewTextBoxColumn.Name = "SUBDIVISIONIDDataGridViewTextBoxColumn"
        Me.SUBDIVISIONIDDataGridViewTextBoxColumn.Width = 144
        '
        'SUBDIVISIONNAMEDataGridViewTextBoxColumn
        '
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn.DataPropertyName = "SUBDIVISION_NAME"
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn.HeaderText = "SUBDIVISION_NAME"
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn.Name = "SUBDIVISIONNAMEDataGridViewTextBoxColumn"
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn.Width = 170
        '
        'SUBDIVISIONADDRESSDataGridViewTextBoxColumn
        '
        Me.SUBDIVISIONADDRESSDataGridViewTextBoxColumn.DataPropertyName = "SUBDIVISION_ADDRESS"
        Me.SUBDIVISIONADDRESSDataGridViewTextBoxColumn.HeaderText = "SUBDIVISION_ADDRESS"
        Me.SUBDIVISIONADDRESSDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SUBDIVISIONADDRESSDataGridViewTextBoxColumn.Name = "SUBDIVISIONADDRESSDataGridViewTextBoxColumn"
        Me.SUBDIVISIONADDRESSDataGridViewTextBoxColumn.Width = 197
        '
        'CITYDataGridViewTextBoxColumn
        '
        Me.CITYDataGridViewTextBoxColumn.DataPropertyName = "CITY"
        Me.CITYDataGridViewTextBoxColumn.HeaderText = "CITY"
        Me.CITYDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CITYDataGridViewTextBoxColumn.Name = "CITYDataGridViewTextBoxColumn"
        Me.CITYDataGridViewTextBoxColumn.Width = 67
        '
        'STATEDataGridViewTextBoxColumn
        '
        Me.STATEDataGridViewTextBoxColumn.DataPropertyName = "STATE"
        Me.STATEDataGridViewTextBoxColumn.HeaderText = "STATE"
        Me.STATEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.STATEDataGridViewTextBoxColumn.Name = "STATEDataGridViewTextBoxColumn"
        Me.STATEDataGridViewTextBoxColumn.Width = 82
        '
        'ZIPDataGridViewTextBoxColumn
        '
        Me.ZIPDataGridViewTextBoxColumn.DataPropertyName = "ZIP"
        Me.ZIPDataGridViewTextBoxColumn.HeaderText = "ZIP"
        Me.ZIPDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ZIPDataGridViewTextBoxColumn.Name = "ZIPDataGridViewTextBoxColumn"
        Me.ZIPDataGridViewTextBoxColumn.Width = 58
        '
        'CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn
        '
        Me.CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn.DataPropertyName = "CONSTRUCTION_START_DATE"
        Me.CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn.HeaderText = "CONSTRUCTION_START_DATE"
        Me.CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn.Name = "CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn"
        Me.CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn.Width = 246
        '
        'CONSTRUCTIONENDDATEDataGridViewTextBoxColumn
        '
        Me.CONSTRUCTIONENDDATEDataGridViewTextBoxColumn.DataPropertyName = "CONSTRUCTION_END_DATE"
        Me.CONSTRUCTIONENDDATEDataGridViewTextBoxColumn.HeaderText = "CONSTRUCTION_END_DATE"
        Me.CONSTRUCTIONENDDATEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CONSTRUCTIONENDDATEDataGridViewTextBoxColumn.Name = "CONSTRUCTIONENDDATEDataGridViewTextBoxColumn"
        Me.CONSTRUCTIONENDDATEDataGridViewTextBoxColumn.Width = 229
        '
        'SALESPERSONIDDataGridViewTextBoxColumn
        '
        Me.SALESPERSONIDDataGridViewTextBoxColumn.DataPropertyName = "SALESPERSON_ID"
        Me.SALESPERSONIDDataGridViewTextBoxColumn.HeaderText = "SALESPERSON_ID"
        Me.SALESPERSONIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SALESPERSONIDDataGridViewTextBoxColumn.Name = "SALESPERSONIDDataGridViewTextBoxColumn"
        Me.SALESPERSONIDDataGridViewTextBoxColumn.Width = 160
        '
        'SUBDIVISIONBindingSource
        '
        Me.SUBDIVISIONBindingSource.DataMember = "SUBDIVISION"
        Me.SUBDIVISIONBindingSource.DataSource = Me.ProjectDataSet
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "ProjectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SUBDIVISIONTableAdapter
        '
        Me.SUBDIVISIONTableAdapter.ClearBeforeFill = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(619, 502)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(91, 23)
        Me.BackButton.TabIndex = 4
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ShowSubdivisionStateToolStrip
        '
        Me.ShowSubdivisionStateToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ShowSubdivisionStateToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowSubdivisionStateToolStripButton, Me.ToolStripSeparator1})
        Me.ShowSubdivisionStateToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ShowSubdivisionStateToolStrip.Name = "ShowSubdivisionStateToolStrip"
        Me.ShowSubdivisionStateToolStrip.Size = New System.Drawing.Size(1477, 27)
        Me.ShowSubdivisionStateToolStrip.TabIndex = 5
        Me.ShowSubdivisionStateToolStrip.Text = "By State"
        '
        'ShowSubdivisionStateToolStripButton
        '
        Me.ShowSubdivisionStateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ShowSubdivisionStateToolStripButton.Name = "ShowSubdivisionStateToolStripButton"
        Me.ShowSubdivisionStateToolStripButton.Size = New System.Drawing.Size(128, 24)
        Me.ShowSubdivisionStateToolStripButton.Text = "By State Demand"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'AlamoSalespersons
        '
        Me.AlamoSalespersons.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AlamoSalespersons.ForeColor = System.Drawing.Color.Black
        Me.AlamoSalespersons.Location = New System.Drawing.Point(1240, 341)
        Me.AlamoSalespersons.Margin = New System.Windows.Forms.Padding(4)
        Me.AlamoSalespersons.Name = "AlamoSalespersons"
        Me.AlamoSalespersons.Size = New System.Drawing.Size(149, 28)
        Me.AlamoSalespersons.TabIndex = 6
        Me.AlamoSalespersons.Text = "Alamo Salespersons"
        Me.AlamoSalespersons.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn1, Me.CountofSalesPersonsDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.GroupBySubdivisonBindingSource1
        Me.DataGridView2.Location = New System.Drawing.Point(41, 325)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(369, 150)
        Me.DataGridView2.TabIndex = 7
        '
        'GroupBySubdivisonBindingSource
        '
        Me.GroupBySubdivisonBindingSource.DataMember = "GroupBySubdivison"
        Me.GroupBySubdivisonBindingSource.DataSource = Me.ProjectDataSet
        '
        'SUBDIVISIONBindingSource2
        '
        Me.SUBDIVISIONBindingSource2.DataMember = "SUBDIVISION"
        Me.SUBDIVISIONBindingSource2.DataSource = Me.ProjectDataSet
        '
        'SUBDIVISIONBindingSource1
        '
        Me.SUBDIVISIONBindingSource1.DataMember = "SUBDIVISION"
        Me.SUBDIVISIONBindingSource1.DataSource = Me.ProjectDataSet
        '
        'SUBDIVISIONTableAdapterBindingSource
        '
        Me.SUBDIVISIONTableAdapterBindingSource.DataSource = GetType(HOAProject.ProjectDataSet1TableAdapters.SUBDIVISIONTableAdapter)
        '
        'GroupBySubdivisonTableAdapter
        '
        Me.GroupBySubdivisonTableAdapter.ClearBeforeFill = True
        '
        'GroupBySubdivisonBindingSource1
        '
        Me.GroupBySubdivisonBindingSource1.DataMember = "GroupBySubdivison"
        Me.GroupBySubdivisonBindingSource1.DataSource = Me.ProjectDataSet
        '
        'SUBDIVISIONNAMEDataGridViewTextBoxColumn1
        '
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn1.DataPropertyName = "SUBDIVISION_NAME"
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn1.HeaderText = "SUBDIVISION_NAME"
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn1.Name = "SUBDIVISIONNAMEDataGridViewTextBoxColumn1"
        Me.SUBDIVISIONNAMEDataGridViewTextBoxColumn1.Width = 170
        '
        'CountofSalesPersonsDataGridViewTextBoxColumn
        '
        Me.CountofSalesPersonsDataGridViewTextBoxColumn.DataPropertyName = "CountofSalesPersons"
        Me.CountofSalesPersonsDataGridViewTextBoxColumn.HeaderText = "CountofSalesPersons"
        Me.CountofSalesPersonsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CountofSalesPersonsDataGridViewTextBoxColumn.Name = "CountofSalesPersonsDataGridViewTextBoxColumn"
        Me.CountofSalesPersonsDataGridViewTextBoxColumn.ReadOnly = True
        Me.CountofSalesPersonsDataGridViewTextBoxColumn.Width = 173
        '
        'SalesPerson_Label
        '
        Me.SalesPerson_Label.AutoSize = True
        Me.SalesPerson_Label.Location = New System.Drawing.Point(58, 296)
        Me.SalesPerson_Label.Name = "SalesPerson_Label"
        Me.SalesPerson_Label.Size = New System.Drawing.Size(184, 17)
        Me.SalesPerson_Label.TabIndex = 8
        Me.SalesPerson_Label.Text = "Sales Person by Subdivison"
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STATEDataGridViewTextBoxColumn1, Me.NumberofSubdivisionDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.GroupByStateBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(921, 325)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(273, 150)
        Me.DataGridView3.TabIndex = 9
        '
        'ProjectDataSet1
        '
        Me.ProjectDataSet1.DataSetName = "ProjectDataSet"
        Me.ProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupByStateBindingSource
        '
        Me.GroupByStateBindingSource.DataMember = "GroupByState"
        Me.GroupByStateBindingSource.DataSource = Me.ProjectDataSet1
        '
        'GroupByStateTableAdapter
        '
        Me.GroupByStateTableAdapter.ClearBeforeFill = True
        '
        'STATEDataGridViewTextBoxColumn1
        '
        Me.STATEDataGridViewTextBoxColumn1.DataPropertyName = "STATE"
        Me.STATEDataGridViewTextBoxColumn1.HeaderText = "STATE"
        Me.STATEDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.STATEDataGridViewTextBoxColumn1.Name = "STATEDataGridViewTextBoxColumn1"
        Me.STATEDataGridViewTextBoxColumn1.Width = 82
        '
        'NumberofSubdivisionDataGridViewTextBoxColumn
        '
        Me.NumberofSubdivisionDataGridViewTextBoxColumn.DataPropertyName = "Number_of_Subdivision"
        Me.NumberofSubdivisionDataGridViewTextBoxColumn.HeaderText = "Number_of_Subdivision"
        Me.NumberofSubdivisionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumberofSubdivisionDataGridViewTextBoxColumn.Name = "NumberofSubdivisionDataGridViewTextBoxColumn"
        Me.NumberofSubdivisionDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumberofSubdivisionDataGridViewTextBoxColumn.Width = 187
        '
        'Sundivision_State
        '
        Me.Sundivision_State.AutoSize = True
        Me.Sundivision_State.Location = New System.Drawing.Point(934, 296)
        Me.Sundivision_State.Name = "Sundivision_State"
        Me.Sundivision_State.Size = New System.Drawing.Size(225, 17)
        Me.Sundivision_State.TabIndex = 10
        Me.Sundivision_State.Text = "State with more than 1 Subdivision"
        '
        'ShowAllLotsButton
        '
        Me.ShowAllLotsButton.Location = New System.Drawing.Point(592, 369)
        Me.ShowAllLotsButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ShowAllLotsButton.Name = "ShowAllLotsButton"
        Me.ShowAllLotsButton.Size = New System.Drawing.Size(148, 28)
        Me.ShowAllLotsButton.TabIndex = 11
        Me.ShowAllLotsButton.Text = "Show All Subdivision"
        Me.ShowAllLotsButton.UseVisualStyleBackColor = True
        '
        'Subdivisions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1477, 554)
        Me.Controls.Add(Me.ShowAllLotsButton)
        Me.Controls.Add(Me.Sundivision_State)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.SalesPerson_Label)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.AlamoSalespersons)
        Me.Controls.Add(Me.ShowSubdivisionStateToolStrip)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Subdivisions"
        Me.Text = "SubdivisionsbyState"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUBDIVISIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShowSubdivisionStateToolStrip.ResumeLayout(False)
        Me.ShowSubdivisionStateToolStrip.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupBySubdivisonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUBDIVISIONBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUBDIVISIONBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUBDIVISIONTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupBySubdivisonBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupByStateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProjectDataSet As ProjectDataSet
    Friend WithEvents SUBDIVISIONBindingSource As BindingSource
    Friend WithEvents SUBDIVISIONTableAdapter As ProjectDataSetTableAdapters.SUBDIVISIONTableAdapter
    Friend WithEvents SUBDIVISIONIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUBDIVISIONNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUBDIVISIONADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CITYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZIPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONSTRUCTIONSTARTDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONSTRUCTIONENDDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SALESPERSONIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BackButton As Button
    Friend WithEvents ShowSubdivisionStateToolStrip As ToolStrip
    Friend WithEvents ShowSubdivisionStateToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AlamoSalespersons As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents SUBDIVISIONBindingSource1 As BindingSource
    Friend WithEvents SUBDIVISIONBindingSource2 As BindingSource
    Friend WithEvents SUBDIVISIONTableAdapterBindingSource As BindingSource
    Friend WithEvents GroupBySubdivisonBindingSource As BindingSource
    Friend WithEvents GroupBySubdivisonTableAdapter As ProjectDataSetTableAdapters.GroupBySubdivisonTableAdapter
    Friend WithEvents Expr1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUBDIVISIONNAMEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CountofSalesPersonsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBySubdivisonBindingSource1 As BindingSource
    Friend WithEvents SalesPerson_Label As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents ProjectDataSet1 As ProjectDataSet
    Friend WithEvents GroupByStateBindingSource As BindingSource
    Friend WithEvents GroupByStateTableAdapter As ProjectDataSetTableAdapters.GroupByStateTableAdapter
    Friend WithEvents STATEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NumberofSubdivisionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Sundivision_State As Label
    Friend WithEvents ShowAllLotsButton As Button
End Class
