<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Salesperson_DetailForm
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
        Me.ProjectDataSet = New HOAProject.ProjectDataSet()
        Me.ProjectDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet1 = New HOAProject.ProjectDataSet1()
        Me.GetMgrnameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Get_MgrnameTableAdapter = New HOAProject.ProjectDataSet1TableAdapters.get_MgrnameTableAdapter()
        Me.EmployeeManagerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeManagerTableAdapter = New HOAProject.ProjectDataSet1TableAdapters.EmployeeManagerTableAdapter()
        Me.SalespersonManagerGrid = New System.Windows.Forms.DataGridView()
        Me.SALESPERSONIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPFIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPLASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPCONTACTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPEMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManagerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.EmployeeLabel = New System.Windows.Forms.Label()
        Me.FillToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.EmployeeName_Button = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetMgrnameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeManagerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalespersonManagerGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "ProjectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProjectDataSetBindingSource
        '
        Me.ProjectDataSetBindingSource.DataSource = Me.ProjectDataSet
        Me.ProjectDataSetBindingSource.Position = 0
        '
        'ProjectDataSet1
        '
        Me.ProjectDataSet1.DataSetName = "ProjectDataSet1"
        Me.ProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GetMgrnameBindingSource
        '
        Me.GetMgrnameBindingSource.DataMember = "get_Mgrname"
        Me.GetMgrnameBindingSource.DataSource = Me.ProjectDataSet1
        '
        'Get_MgrnameTableAdapter
        '
        Me.Get_MgrnameTableAdapter.ClearBeforeFill = True
        '
        'EmployeeManagerBindingSource
        '
        Me.EmployeeManagerBindingSource.DataMember = "EmployeeManager"
        Me.EmployeeManagerBindingSource.DataSource = Me.ProjectDataSet1
        '
        'EmployeeManagerTableAdapter
        '
        Me.EmployeeManagerTableAdapter.ClearBeforeFill = True
        '
        'SalespersonManagerGrid
        '
        Me.SalespersonManagerGrid.AllowUserToAddRows = False
        Me.SalespersonManagerGrid.AutoGenerateColumns = False
        Me.SalespersonManagerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.SalespersonManagerGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.SalespersonManagerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalespersonManagerGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SALESPERSONIDDataGridViewTextBoxColumn, Me.SPFIRSTNAMEDataGridViewTextBoxColumn, Me.SPLASTNAMEDataGridViewTextBoxColumn, Me.SPCONTACTDataGridViewTextBoxColumn, Me.SPEMAILDataGridViewTextBoxColumn, Me.ManagerNameDataGridViewTextBoxColumn})
        Me.SalespersonManagerGrid.DataSource = Me.EmployeeManagerBindingSource
        Me.SalespersonManagerGrid.Location = New System.Drawing.Point(185, 87)
        Me.SalespersonManagerGrid.Name = "SalespersonManagerGrid"
        Me.SalespersonManagerGrid.RowHeadersVisible = False
        Me.SalespersonManagerGrid.RowHeadersWidth = 51
        Me.SalespersonManagerGrid.RowTemplate.Height = 24
        Me.SalespersonManagerGrid.Size = New System.Drawing.Size(828, 330)
        Me.SalespersonManagerGrid.TabIndex = 0
        '
        'SALESPERSONIDDataGridViewTextBoxColumn
        '
        Me.SALESPERSONIDDataGridViewTextBoxColumn.DataPropertyName = "SALESPERSON_ID"
        Me.SALESPERSONIDDataGridViewTextBoxColumn.HeaderText = "SALESPERSON_ID"
        Me.SALESPERSONIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SALESPERSONIDDataGridViewTextBoxColumn.Name = "SALESPERSONIDDataGridViewTextBoxColumn"
        Me.SALESPERSONIDDataGridViewTextBoxColumn.Width = 160
        '
        'SPFIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.SPFIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "SP_FIRST_NAME"
        Me.SPFIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "SP_FIRST_NAME"
        Me.SPFIRSTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SPFIRSTNAMEDataGridViewTextBoxColumn.Name = "SPFIRSTNAMEDataGridViewTextBoxColumn"
        Me.SPFIRSTNAMEDataGridViewTextBoxColumn.Width = 149
        '
        'SPLASTNAMEDataGridViewTextBoxColumn
        '
        Me.SPLASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "SP_LAST_NAME"
        Me.SPLASTNAMEDataGridViewTextBoxColumn.HeaderText = "SP_LAST_NAME"
        Me.SPLASTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SPLASTNAMEDataGridViewTextBoxColumn.Name = "SPLASTNAMEDataGridViewTextBoxColumn"
        Me.SPLASTNAMEDataGridViewTextBoxColumn.Width = 145
        '
        'SPCONTACTDataGridViewTextBoxColumn
        '
        Me.SPCONTACTDataGridViewTextBoxColumn.DataPropertyName = "SP_CONTACT"
        Me.SPCONTACTDataGridViewTextBoxColumn.HeaderText = "SP_CONTACT"
        Me.SPCONTACTDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SPCONTACTDataGridViewTextBoxColumn.Name = "SPCONTACTDataGridViewTextBoxColumn"
        Me.SPCONTACTDataGridViewTextBoxColumn.Width = 129
        '
        'SPEMAILDataGridViewTextBoxColumn
        '
        Me.SPEMAILDataGridViewTextBoxColumn.DataPropertyName = "SP_EMAIL"
        Me.SPEMAILDataGridViewTextBoxColumn.HeaderText = "SP_EMAIL"
        Me.SPEMAILDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SPEMAILDataGridViewTextBoxColumn.Name = "SPEMAILDataGridViewTextBoxColumn"
        Me.SPEMAILDataGridViewTextBoxColumn.Width = 103
        '
        'ManagerNameDataGridViewTextBoxColumn
        '
        Me.ManagerNameDataGridViewTextBoxColumn.DataPropertyName = "Manager_Name"
        Me.ManagerNameDataGridViewTextBoxColumn.HeaderText = "Manager_Name"
        Me.ManagerNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ManagerNameDataGridViewTextBoxColumn.Name = "ManagerNameDataGridViewTextBoxColumn"
        Me.ManagerNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ManagerNameDataGridViewTextBoxColumn.Width = 138
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(554, 634)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(91, 23)
        Me.BackButton.TabIndex = 3
        Me.BackButton.Text = "&Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.GetMgrnameBindingSource
        Me.ComboBox1.DisplayMember = "Manager_Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(598, 562)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.ValueMember = "Manager_Name"
        '
        'EmployeeLabel
        '
        Me.EmployeeLabel.AutoSize = True
        Me.EmployeeLabel.ForeColor = System.Drawing.Color.Lime
        Me.EmployeeLabel.Location = New System.Drawing.Point(450, 565)
        Me.EmployeeLabel.Name = "EmployeeLabel"
        Me.EmployeeLabel.Size = New System.Drawing.Size(105, 17)
        Me.EmployeeLabel.TabIndex = 6
        Me.EmployeeLabel.Text = "Manager Name"
        '
        'FillToolStrip1
        '
        Me.FillToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.FillToolStrip1.Name = "FillToolStrip1"
        Me.FillToolStrip1.Size = New System.Drawing.Size(1441, 25)
        Me.FillToolStrip1.TabIndex = 7
        Me.FillToolStrip1.Text = "FillToolStrip1"
        '
        'EmployeeName_Button
        '
        Me.EmployeeName_Button.Location = New System.Drawing.Point(205, 491)
        Me.EmployeeName_Button.Name = "EmployeeName_Button"
        Me.EmployeeName_Button.Size = New System.Drawing.Size(167, 24)
        Me.EmployeeName_Button.TabIndex = 8
        Me.EmployeeName_Button.Text = "Enter Employee Name:"
        Me.EmployeeName_Button.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(409, 491)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 22)
        Me.TextBox1.TabIndex = 9
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.EmployeeManagerBindingSource
        Me.ComboBox2.DisplayMember = "SP_FIRST_NAME"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(892, 488)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(567, 491)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "OR     Select Employee Name from DropDown:"
        '
        'Salesperson_DetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1441, 797)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.EmployeeName_Button)
        Me.Controls.Add(Me.FillToolStrip1)
        Me.Controls.Add(Me.EmployeeLabel)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SalespersonManagerGrid)
        Me.Name = "Salesperson_DetailForm"
        Me.Text = "Salesperson_DetailForm"
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetMgrnameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeManagerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalespersonManagerGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GetMgrnameBindingSource As BindingSource
    Friend WithEvents ProjectDataSet1 As ProjectDataSet1
    Friend WithEvents ProjectDataSet As ProjectDataSet
    Friend WithEvents ProjectDataSetBindingSource As BindingSource
    Friend WithEvents Get_MgrnameTableAdapter As ProjectDataSet1TableAdapters.get_MgrnameTableAdapter
    Friend WithEvents EmployeeManagerBindingSource As BindingSource
    Friend WithEvents EmployeeManagerTableAdapter As ProjectDataSet1TableAdapters.EmployeeManagerTableAdapter
    Friend WithEvents SalespersonManagerGrid As DataGridView
    Friend WithEvents SALESPERSONIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SPFIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SPLASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SPCONTACTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SPEMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManagerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BackButton As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents EmployeeLabel As Label
    Friend WithEvents FillToolStrip1 As ToolStrip
    Friend WithEvents EmployeeName_Button As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
End Class
