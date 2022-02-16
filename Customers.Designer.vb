<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
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
        Me.ProjectDataSet = New HOAProject.ProjectDataSet()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUSTOMERTableAdapter = New HOAProject.ProjectDataSetTableAdapters.CUSTOMERTableAdapter()
        Me.CUSTOMERIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSFIRSTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSLASTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSINITIALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSCONTACTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSEMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSCOMMENTSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CUSTOMERIDDataGridViewTextBoxColumn, Me.CUSFIRSTNAMEDataGridViewTextBoxColumn, Me.CUSLASTNAMEDataGridViewTextBoxColumn, Me.CUSINITIALDataGridViewTextBoxColumn, Me.CUSADDRESSDataGridViewTextBoxColumn, Me.CUSCONTACTDataGridViewTextBoxColumn, Me.CUSEMAILDataGridViewTextBoxColumn, Me.CUSCOMMENTSDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CUSTOMERBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(802, 358)
        Me.DataGridView1.TabIndex = 0
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "ProjectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.ProjectDataSet
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'CUSTOMERIDDataGridViewTextBoxColumn
        '
        Me.CUSTOMERIDDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER_ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.HeaderText = "CUSTOMER_ID"
        Me.CUSTOMERIDDataGridViewTextBoxColumn.Name = "CUSTOMERIDDataGridViewTextBoxColumn"
        '
        'CUSFIRSTNAMEDataGridViewTextBoxColumn
        '
        Me.CUSFIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUS_FIRST_NAME"
        Me.CUSFIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "CUS_FIRST_NAME"
        Me.CUSFIRSTNAMEDataGridViewTextBoxColumn.Name = "CUSFIRSTNAMEDataGridViewTextBoxColumn"
        '
        'CUSLASTNAMEDataGridViewTextBoxColumn
        '
        Me.CUSLASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUS_LAST_NAME"
        Me.CUSLASTNAMEDataGridViewTextBoxColumn.HeaderText = "CUS_LAST_NAME"
        Me.CUSLASTNAMEDataGridViewTextBoxColumn.Name = "CUSLASTNAMEDataGridViewTextBoxColumn"
        '
        'CUSINITIALDataGridViewTextBoxColumn
        '
        Me.CUSINITIALDataGridViewTextBoxColumn.DataPropertyName = "CUS_INITIAL"
        Me.CUSINITIALDataGridViewTextBoxColumn.HeaderText = "CUS_INITIAL"
        Me.CUSINITIALDataGridViewTextBoxColumn.Name = "CUSINITIALDataGridViewTextBoxColumn"
        '
        'CUSADDRESSDataGridViewTextBoxColumn
        '
        Me.CUSADDRESSDataGridViewTextBoxColumn.DataPropertyName = "CUS_ADDRESS"
        Me.CUSADDRESSDataGridViewTextBoxColumn.HeaderText = "CUS_ADDRESS"
        Me.CUSADDRESSDataGridViewTextBoxColumn.Name = "CUSADDRESSDataGridViewTextBoxColumn"
        '
        'CUSCONTACTDataGridViewTextBoxColumn
        '
        Me.CUSCONTACTDataGridViewTextBoxColumn.DataPropertyName = "CUS_CONTACT"
        Me.CUSCONTACTDataGridViewTextBoxColumn.HeaderText = "CUS_CONTACT"
        Me.CUSCONTACTDataGridViewTextBoxColumn.Name = "CUSCONTACTDataGridViewTextBoxColumn"
        '
        'CUSEMAILDataGridViewTextBoxColumn
        '
        Me.CUSEMAILDataGridViewTextBoxColumn.DataPropertyName = "CUS_EMAIL"
        Me.CUSEMAILDataGridViewTextBoxColumn.HeaderText = "CUS_EMAIL"
        Me.CUSEMAILDataGridViewTextBoxColumn.Name = "CUSEMAILDataGridViewTextBoxColumn"
        '
        'CUSCOMMENTSDataGridViewTextBoxColumn
        '
        Me.CUSCOMMENTSDataGridViewTextBoxColumn.DataPropertyName = "CUS_COMMENTS"
        Me.CUSCOMMENTSDataGridViewTextBoxColumn.HeaderText = "CUS_COMMENTS"
        Me.CUSCOMMENTSDataGridViewTextBoxColumn.Name = "CUSCOMMENTSDataGridViewTextBoxColumn"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(391, 420)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(68, 19)
        Me.BackButton.TabIndex = 6
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 473)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Customers"
        Me.Text = "Customers"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProjectDataSet As ProjectDataSet
    Friend WithEvents CUSTOMERBindingSource As BindingSource
    Friend WithEvents CUSTOMERTableAdapter As ProjectDataSetTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents CUSTOMERIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSFIRSTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSLASTNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSINITIALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSADDRESSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSCONTACTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSEMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSCOMMENTSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BackButton As Button
End Class
