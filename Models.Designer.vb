<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Models
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.AllTwoStoriesButton = New System.Windows.Forms.Button()
        Me.OutputTotal = New System.Windows.Forms.Label()
        Me.OutputResult = New System.Windows.Forms.Label()
        Me.AllModels = New System.Windows.Forms.Button()
        Me.ShowModelPricing = New System.Windows.Forms.Button()
        Me.StartingPrice = New System.Windows.Forms.TextBox()
        Me.StartingSize = New System.Windows.Forms.TextBox()
        Me.ModelsonSizeInput = New System.Windows.Forms.Button()
        Me.DoubleInputButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MODELIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BEDROOMNUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FULLBATHNUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HALFBATHNUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SQUAREFOOTAGEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GARAGENUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STORIESNUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BASEPRICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODELBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet = New HOAProject.ProjectDataSet()
        Me.MODELTableAdapter = New HOAProject.ProjectDataSetTableAdapters.MODELTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MODELIDDataGridViewTextBoxColumn, Me.MODELNAMEDataGridViewTextBoxColumn, Me.BEDROOMNUMDataGridViewTextBoxColumn, Me.FULLBATHNUMDataGridViewTextBoxColumn, Me.HALFBATHNUMDataGridViewTextBoxColumn, Me.SQUAREFOOTAGEDataGridViewTextBoxColumn, Me.GARAGENUMDataGridViewTextBoxColumn, Me.STORIESNUMDataGridViewTextBoxColumn, Me.BASEPRICEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MODELBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(7, 13)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1241, 321)
        Me.DataGridView1.TabIndex = 0
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(588, 564)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(91, 23)
        Me.BackButton.TabIndex = 3
        Me.BackButton.Text = "&Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'AllTwoStoriesButton
        '
        Me.AllTwoStoriesButton.Location = New System.Drawing.Point(33, 356)
        Me.AllTwoStoriesButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AllTwoStoriesButton.Name = "AllTwoStoriesButton"
        Me.AllTwoStoriesButton.Size = New System.Drawing.Size(163, 28)
        Me.AllTwoStoriesButton.TabIndex = 4
        Me.AllTwoStoriesButton.Text = "Two Stories"
        Me.AllTwoStoriesButton.UseVisualStyleBackColor = True
        '
        'OutputTotal
        '
        Me.OutputTotal.AutoSize = True
        Me.OutputTotal.Location = New System.Drawing.Point(1148, 356)
        Me.OutputTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OutputTotal.Name = "OutputTotal"
        Me.OutputTotal.Size = New System.Drawing.Size(48, 17)
        Me.OutputTotal.TabIndex = 5
        Me.OutputTotal.Text = "Total: "
        '
        'OutputResult
        '
        Me.OutputResult.AutoSize = True
        Me.OutputResult.BackColor = System.Drawing.Color.Lime
        Me.OutputResult.ForeColor = System.Drawing.Color.Black
        Me.OutputResult.Location = New System.Drawing.Point(1205, 356)
        Me.OutputResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OutputResult.Name = "OutputResult"
        Me.OutputResult.Size = New System.Drawing.Size(16, 17)
        Me.OutputResult.TabIndex = 6
        Me.OutputResult.Text = "0"
        '
        'AllModels
        '
        Me.AllModels.Location = New System.Drawing.Point(1033, 559)
        Me.AllModels.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AllModels.Name = "AllModels"
        Me.AllModels.Size = New System.Drawing.Size(163, 28)
        Me.AllModels.TabIndex = 7
        Me.AllModels.Text = "All Models"
        Me.AllModels.UseVisualStyleBackColor = True
        '
        'ShowModelPricing
        '
        Me.ShowModelPricing.Location = New System.Drawing.Point(33, 428)
        Me.ShowModelPricing.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ShowModelPricing.Name = "ShowModelPricing"
        Me.ShowModelPricing.Size = New System.Drawing.Size(180, 28)
        Me.ShowModelPricing.TabIndex = 8
        Me.ShowModelPricing.Text = "Show Models starting at: "
        Me.ShowModelPricing.UseVisualStyleBackColor = True
        '
        'StartingPrice
        '
        Me.StartingPrice.Location = New System.Drawing.Point(221, 431)
        Me.StartingPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.StartingPrice.Multiline = True
        Me.StartingPrice.Name = "StartingPrice"
        Me.StartingPrice.Size = New System.Drawing.Size(132, 20)
        Me.StartingPrice.TabIndex = 9
        '
        'StartingSize
        '
        Me.StartingSize.Location = New System.Drawing.Point(221, 492)
        Me.StartingSize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.StartingSize.Name = "StartingSize"
        Me.StartingSize.Size = New System.Drawing.Size(132, 22)
        Me.StartingSize.TabIndex = 11
        '
        'ModelsonSizeInput
        '
        Me.ModelsonSizeInput.Location = New System.Drawing.Point(33, 492)
        Me.ModelsonSizeInput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ModelsonSizeInput.Name = "ModelsonSizeInput"
        Me.ModelsonSizeInput.Size = New System.Drawing.Size(180, 28)
        Me.ModelsonSizeInput.TabIndex = 10
        Me.ModelsonSizeInput.Text = "Show Models larger than: "
        Me.ModelsonSizeInput.UseVisualStyleBackColor = True
        '
        'DoubleInputButton
        '
        Me.DoubleInputButton.Location = New System.Drawing.Point(33, 538)
        Me.DoubleInputButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DoubleInputButton.Name = "DoubleInputButton"
        Me.DoubleInputButton.Size = New System.Drawing.Size(263, 28)
        Me.DoubleInputButton.TabIndex = 13
        Me.DoubleInputButton.Text = "Show Models Starting at Price and Size"
        Me.DoubleInputButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 582)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Starting Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 582)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Size"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 604)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(164, 603)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 19
        '
        'MODELIDDataGridViewTextBoxColumn
        '
        Me.MODELIDDataGridViewTextBoxColumn.DataPropertyName = "MODEL_ID"
        Me.MODELIDDataGridViewTextBoxColumn.HeaderText = "MODEL_ID"
        Me.MODELIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MODELIDDataGridViewTextBoxColumn.Name = "MODELIDDataGridViewTextBoxColumn"
        Me.MODELIDDataGridViewTextBoxColumn.Width = 107
        '
        'MODELNAMEDataGridViewTextBoxColumn
        '
        Me.MODELNAMEDataGridViewTextBoxColumn.DataPropertyName = "MODEL_NAME"
        Me.MODELNAMEDataGridViewTextBoxColumn.HeaderText = "MODEL_NAME"
        Me.MODELNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MODELNAMEDataGridViewTextBoxColumn.Name = "MODELNAMEDataGridViewTextBoxColumn"
        Me.MODELNAMEDataGridViewTextBoxColumn.Width = 133
        '
        'BEDROOMNUMDataGridViewTextBoxColumn
        '
        Me.BEDROOMNUMDataGridViewTextBoxColumn.DataPropertyName = "BEDROOM_NUM"
        Me.BEDROOMNUMDataGridViewTextBoxColumn.HeaderText = "BEDROOM_NUM"
        Me.BEDROOMNUMDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BEDROOMNUMDataGridViewTextBoxColumn.Name = "BEDROOMNUMDataGridViewTextBoxColumn"
        Me.BEDROOMNUMDataGridViewTextBoxColumn.Width = 147
        '
        'FULLBATHNUMDataGridViewTextBoxColumn
        '
        Me.FULLBATHNUMDataGridViewTextBoxColumn.DataPropertyName = "FULL_BATH_NUM"
        Me.FULLBATHNUMDataGridViewTextBoxColumn.HeaderText = "FULL_BATH_NUM"
        Me.FULLBATHNUMDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FULLBATHNUMDataGridViewTextBoxColumn.Name = "FULLBATHNUMDataGridViewTextBoxColumn"
        Me.FULLBATHNUMDataGridViewTextBoxColumn.Width = 155
        '
        'HALFBATHNUMDataGridViewTextBoxColumn
        '
        Me.HALFBATHNUMDataGridViewTextBoxColumn.DataPropertyName = "HALF_BATH_NUM"
        Me.HALFBATHNUMDataGridViewTextBoxColumn.HeaderText = "HALF_BATH_NUM"
        Me.HALFBATHNUMDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HALFBATHNUMDataGridViewTextBoxColumn.Name = "HALFBATHNUMDataGridViewTextBoxColumn"
        Me.HALFBATHNUMDataGridViewTextBoxColumn.Width = 156
        '
        'SQUAREFOOTAGEDataGridViewTextBoxColumn
        '
        Me.SQUAREFOOTAGEDataGridViewTextBoxColumn.DataPropertyName = "SQUARE_FOOTAGE"
        Me.SQUAREFOOTAGEDataGridViewTextBoxColumn.HeaderText = "SQUARE_FOOTAGE"
        Me.SQUAREFOOTAGEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SQUAREFOOTAGEDataGridViewTextBoxColumn.Name = "SQUAREFOOTAGEDataGridViewTextBoxColumn"
        Me.SQUAREFOOTAGEDataGridViewTextBoxColumn.Width = 171
        '
        'GARAGENUMDataGridViewTextBoxColumn
        '
        Me.GARAGENUMDataGridViewTextBoxColumn.DataPropertyName = "GARAGE_NUM"
        Me.GARAGENUMDataGridViewTextBoxColumn.HeaderText = "GARAGE_NUM"
        Me.GARAGENUMDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GARAGENUMDataGridViewTextBoxColumn.Name = "GARAGENUMDataGridViewTextBoxColumn"
        Me.GARAGENUMDataGridViewTextBoxColumn.Width = 135
        '
        'STORIESNUMDataGridViewTextBoxColumn
        '
        Me.STORIESNUMDataGridViewTextBoxColumn.DataPropertyName = "STORIES_NUM"
        Me.STORIESNUMDataGridViewTextBoxColumn.HeaderText = "STORIES_NUM"
        Me.STORIESNUMDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.STORIESNUMDataGridViewTextBoxColumn.Name = "STORIESNUMDataGridViewTextBoxColumn"
        Me.STORIESNUMDataGridViewTextBoxColumn.Width = 136
        '
        'BASEPRICEDataGridViewTextBoxColumn
        '
        Me.BASEPRICEDataGridViewTextBoxColumn.DataPropertyName = "BASE_PRICE"
        Me.BASEPRICEDataGridViewTextBoxColumn.HeaderText = "BASE_PRICE"
        Me.BASEPRICEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BASEPRICEDataGridViewTextBoxColumn.Name = "BASEPRICEDataGridViewTextBoxColumn"
        Me.BASEPRICEDataGridViewTextBoxColumn.Width = 121
        '
        'MODELBindingSource
        '
        Me.MODELBindingSource.DataMember = "MODEL"
        Me.MODELBindingSource.DataSource = Me.ProjectDataSet
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "ProjectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MODELTableAdapter
        '
        Me.MODELTableAdapter.ClearBeforeFill = True
        '
        'Models
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 639)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DoubleInputButton)
        Me.Controls.Add(Me.StartingSize)
        Me.Controls.Add(Me.ModelsonSizeInput)
        Me.Controls.Add(Me.StartingPrice)
        Me.Controls.Add(Me.ShowModelPricing)
        Me.Controls.Add(Me.AllModels)
        Me.Controls.Add(Me.OutputResult)
        Me.Controls.Add(Me.OutputTotal)
        Me.Controls.Add(Me.AllTwoStoriesButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Models"
        Me.Text = "Models"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProjectDataSet As ProjectDataSet
    Friend WithEvents MODELBindingSource As BindingSource
    Friend WithEvents MODELTableAdapter As ProjectDataSetTableAdapters.MODELTableAdapter
    Friend WithEvents MODELIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MODELNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BEDROOMNUMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FULLBATHNUMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HALFBATHNUMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SQUAREFOOTAGEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GARAGENUMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STORIESNUMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BASEPRICEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BackButton As Button
    Friend WithEvents AllTwoStoriesButton As Button
    Friend WithEvents OutputTotal As Label
    Friend WithEvents OutputResult As Label
    Friend WithEvents AllModels As Button
    Friend WithEvents ShowModelPricing As Button
    Friend WithEvents StartingPrice As TextBox
    Friend WithEvents StartingSize As TextBox
    Friend WithEvents ModelsonSizeInput As Button
    Friend WithEvents DoubleInputButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
