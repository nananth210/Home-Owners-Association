<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salespersons
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
        Dim SP_FIRST_NAMELabel As System.Windows.Forms.Label
        Dim SP_LAST_NAMELabel As System.Windows.Forms.Label
        Dim SP_INITIALLabel As System.Windows.Forms.Label
        Dim SP_CONTACTLabel As System.Windows.Forms.Label
        Dim SP_EMAILLabel As System.Windows.Forms.Label
        Dim MANAGER_IDLabel As System.Windows.Forms.Label
        Dim SALESPERSON_IDLabel As System.Windows.Forms.Label
        Me.SALESPERSONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet = New HOAProject.ProjectDataSet()
        Me.SALESPERSONTableAdapter = New HOAProject.ProjectDataSetTableAdapters.SALESPERSONTableAdapter()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SALESPERSONBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet1 = New HOAProject.ProjectDataSet()
        Me.SALESPERSONBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New HOAProject.ProjectDataSetTableAdapters.TableAdapterManager()
        Me.SP_FIRST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.SP_LAST_NAMETextBox = New System.Windows.Forms.TextBox()
        Me.SP_INITIALTextBox = New System.Windows.Forms.TextBox()
        Me.SP_CONTACTTextBox = New System.Windows.Forms.TextBox()
        Me.SP_EMAILTextBox = New System.Windows.Forms.TextBox()
        Me.MANAGER_IDTextBox = New System.Windows.Forms.TextBox()
        Me.SALESPERSON_IDComboBox = New System.Windows.Forms.ComboBox()
        SP_FIRST_NAMELabel = New System.Windows.Forms.Label()
        SP_LAST_NAMELabel = New System.Windows.Forms.Label()
        SP_INITIALLabel = New System.Windows.Forms.Label()
        SP_CONTACTLabel = New System.Windows.Forms.Label()
        SP_EMAILLabel = New System.Windows.Forms.Label()
        MANAGER_IDLabel = New System.Windows.Forms.Label()
        SALESPERSON_IDLabel = New System.Windows.Forms.Label()
        CType(Me.SALESPERSONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALESPERSONBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALESPERSONBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SALESPERSONBindingSource
        '
        Me.SALESPERSONBindingSource.DataMember = "SALESPERSON"
        Me.SALESPERSONBindingSource.DataSource = Me.ProjectDataSet
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "ProjectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SALESPERSONTableAdapter
        '
        Me.SALESPERSONTableAdapter.ClearBeforeFill = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(481, 517)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(91, 23)
        Me.BackButton.TabIndex = 5
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'SALESPERSONBindingSource1
        '
        Me.SALESPERSONBindingSource1.DataMember = "SALESPERSON"
        Me.SALESPERSONBindingSource1.DataSource = Me.ProjectDataSet
        '
        'ProjectDataSet1
        '
        Me.ProjectDataSet1.DataSetName = "ProjectDataSet"
        Me.ProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SALESPERSONBindingSource2
        '
        Me.SALESPERSONBindingSource2.DataMember = "SALESPERSON"
        Me.SALESPERSONBindingSource2.DataSource = Me.ProjectDataSet1
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AVAILABLE_LOTSTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CUSTOMERTableAdapter = Nothing
        Me.TableAdapterManager.LOTTableAdapter = Nothing
        Me.TableAdapterManager.MODELTableAdapter = Nothing
        Me.TableAdapterManager.PURCHASED_LOTSTableAdapter = Nothing
        Me.TableAdapterManager.SALESPERSON_RATINGSTableAdapter = Nothing
        Me.TableAdapterManager.SALESPERSONTableAdapter = Nothing
        Me.TableAdapterManager.SUBDIVISIONTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = HOAProject.ProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SP_FIRST_NAMELabel
        '
        SP_FIRST_NAMELabel.AutoSize = True
        SP_FIRST_NAMELabel.Location = New System.Drawing.Point(230, 176)
        SP_FIRST_NAMELabel.Name = "SP_FIRST_NAMELabel"
        SP_FIRST_NAMELabel.Size = New System.Drawing.Size(116, 17)
        SP_FIRST_NAMELabel.TabIndex = 7
        SP_FIRST_NAMELabel.Text = "SP FIRST NAME:"
        '
        'SP_FIRST_NAMETextBox
        '
        Me.SP_FIRST_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALESPERSONBindingSource, "SP_FIRST_NAME", True))
        Me.SP_FIRST_NAMETextBox.Location = New System.Drawing.Point(367, 173)
        Me.SP_FIRST_NAMETextBox.Name = "SP_FIRST_NAMETextBox"
        Me.SP_FIRST_NAMETextBox.Size = New System.Drawing.Size(153, 22)
        Me.SP_FIRST_NAMETextBox.TabIndex = 8
        '
        'SP_LAST_NAMELabel
        '
        SP_LAST_NAMELabel.AutoSize = True
        SP_LAST_NAMELabel.Location = New System.Drawing.Point(230, 204)
        SP_LAST_NAMELabel.Name = "SP_LAST_NAMELabel"
        SP_LAST_NAMELabel.Size = New System.Drawing.Size(112, 17)
        SP_LAST_NAMELabel.TabIndex = 9
        SP_LAST_NAMELabel.Text = "SP LAST NAME:"
        '
        'SP_LAST_NAMETextBox
        '
        Me.SP_LAST_NAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALESPERSONBindingSource, "SP_LAST_NAME", True))
        Me.SP_LAST_NAMETextBox.Location = New System.Drawing.Point(367, 201)
        Me.SP_LAST_NAMETextBox.Name = "SP_LAST_NAMETextBox"
        Me.SP_LAST_NAMETextBox.Size = New System.Drawing.Size(153, 22)
        Me.SP_LAST_NAMETextBox.TabIndex = 10
        '
        'SP_INITIALLabel
        '
        SP_INITIALLabel.AutoSize = True
        SP_INITIALLabel.Location = New System.Drawing.Point(230, 232)
        SP_INITIALLabel.Name = "SP_INITIALLabel"
        SP_INITIALLabel.Size = New System.Drawing.Size(79, 17)
        SP_INITIALLabel.TabIndex = 11
        SP_INITIALLabel.Text = "SP INITIAL:"
        '
        'SP_INITIALTextBox
        '
        Me.SP_INITIALTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALESPERSONBindingSource, "SP_INITIAL", True))
        Me.SP_INITIALTextBox.Location = New System.Drawing.Point(367, 229)
        Me.SP_INITIALTextBox.Name = "SP_INITIALTextBox"
        Me.SP_INITIALTextBox.Size = New System.Drawing.Size(153, 22)
        Me.SP_INITIALTextBox.TabIndex = 12
        '
        'SP_CONTACTLabel
        '
        SP_CONTACTLabel.AutoSize = True
        SP_CONTACTLabel.Location = New System.Drawing.Point(230, 260)
        SP_CONTACTLabel.Name = "SP_CONTACTLabel"
        SP_CONTACTLabel.Size = New System.Drawing.Size(100, 17)
        SP_CONTACTLabel.TabIndex = 13
        SP_CONTACTLabel.Text = "SP CONTACT:"
        '
        'SP_CONTACTTextBox
        '
        Me.SP_CONTACTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALESPERSONBindingSource, "SP_CONTACT", True))
        Me.SP_CONTACTTextBox.Location = New System.Drawing.Point(367, 257)
        Me.SP_CONTACTTextBox.Name = "SP_CONTACTTextBox"
        Me.SP_CONTACTTextBox.Size = New System.Drawing.Size(153, 22)
        Me.SP_CONTACTTextBox.TabIndex = 14
        '
        'SP_EMAILLabel
        '
        SP_EMAILLabel.AutoSize = True
        SP_EMAILLabel.Location = New System.Drawing.Point(230, 288)
        SP_EMAILLabel.Name = "SP_EMAILLabel"
        SP_EMAILLabel.Size = New System.Drawing.Size(74, 17)
        SP_EMAILLabel.TabIndex = 15
        SP_EMAILLabel.Text = "SP EMAIL:"
        '
        'SP_EMAILTextBox
        '
        Me.SP_EMAILTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALESPERSONBindingSource, "SP_EMAIL", True))
        Me.SP_EMAILTextBox.Location = New System.Drawing.Point(367, 285)
        Me.SP_EMAILTextBox.Name = "SP_EMAILTextBox"
        Me.SP_EMAILTextBox.Size = New System.Drawing.Size(153, 22)
        Me.SP_EMAILTextBox.TabIndex = 16
        '
        'MANAGER_IDLabel
        '
        MANAGER_IDLabel.AutoSize = True
        MANAGER_IDLabel.Location = New System.Drawing.Point(230, 316)
        MANAGER_IDLabel.Name = "MANAGER_IDLabel"
        MANAGER_IDLabel.Size = New System.Drawing.Size(98, 17)
        MANAGER_IDLabel.TabIndex = 17
        MANAGER_IDLabel.Text = "MANAGER ID:"
        '
        'MANAGER_IDTextBox
        '
        Me.MANAGER_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALESPERSONBindingSource, "MANAGER_ID", True))
        Me.MANAGER_IDTextBox.Location = New System.Drawing.Point(367, 313)
        Me.MANAGER_IDTextBox.Name = "MANAGER_IDTextBox"
        Me.MANAGER_IDTextBox.Size = New System.Drawing.Size(153, 22)
        Me.MANAGER_IDTextBox.TabIndex = 18
        '
        'SALESPERSON_IDLabel
        '
        SALESPERSON_IDLabel.AutoSize = True
        SALESPERSON_IDLabel.Location = New System.Drawing.Point(230, 148)
        SALESPERSON_IDLabel.Name = "SALESPERSON_IDLabel"
        SALESPERSON_IDLabel.Size = New System.Drawing.Size(131, 17)
        SALESPERSON_IDLabel.TabIndex = 18
        SALESPERSON_IDLabel.Text = "SALESPERSON ID:"
        '
        'SALESPERSON_IDComboBox
        '
        Me.SALESPERSON_IDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SALESPERSONBindingSource, "SALESPERSON_ID", True, System.Windows.Forms.DataSourceUpdateMode.Never))
        Me.SALESPERSON_IDComboBox.DataSource = Me.SALESPERSONBindingSource
        Me.SALESPERSON_IDComboBox.DisplayMember = "SALESPERSON_ID"
        Me.SALESPERSON_IDComboBox.FormattingEnabled = True
        Me.SALESPERSON_IDComboBox.Location = New System.Drawing.Point(367, 145)
        Me.SALESPERSON_IDComboBox.Name = "SALESPERSON_IDComboBox"
        Me.SALESPERSON_IDComboBox.Size = New System.Drawing.Size(121, 24)
        Me.SALESPERSON_IDComboBox.TabIndex = 19
        '
        'Salespersons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1067, 560)
        Me.Controls.Add(SALESPERSON_IDLabel)
        Me.Controls.Add(Me.SALESPERSON_IDComboBox)
        Me.Controls.Add(SP_FIRST_NAMELabel)
        Me.Controls.Add(Me.SP_FIRST_NAMETextBox)
        Me.Controls.Add(SP_LAST_NAMELabel)
        Me.Controls.Add(Me.SP_LAST_NAMETextBox)
        Me.Controls.Add(SP_INITIALLabel)
        Me.Controls.Add(Me.SP_INITIALTextBox)
        Me.Controls.Add(SP_CONTACTLabel)
        Me.Controls.Add(Me.SP_CONTACTTextBox)
        Me.Controls.Add(SP_EMAILLabel)
        Me.Controls.Add(Me.SP_EMAILTextBox)
        Me.Controls.Add(MANAGER_IDLabel)
        Me.Controls.Add(Me.MANAGER_IDTextBox)
        Me.Controls.Add(Me.BackButton)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Salespersons"
        Me.Text = "Salespersons"
        Me.TopMost = True
        CType(Me.SALESPERSONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALESPERSONBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALESPERSONBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProjectDataSet As ProjectDataSet
    Friend WithEvents SALESPERSONBindingSource As BindingSource
    Friend WithEvents SALESPERSONTableAdapter As ProjectDataSetTableAdapters.SALESPERSONTableAdapter
    Friend WithEvents BackButton As Button
    Friend WithEvents SALESPERSONBindingSource1 As BindingSource
    Friend WithEvents ProjectDataSet1 As ProjectDataSet
    Friend WithEvents SALESPERSONBindingSource2 As BindingSource
    Friend WithEvents TableAdapterManager As ProjectDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SP_FIRST_NAMETextBox As TextBox
    Friend WithEvents SP_LAST_NAMETextBox As TextBox
    Friend WithEvents SP_INITIALTextBox As TextBox
    Friend WithEvents SP_CONTACTTextBox As TextBox
    Friend WithEvents SP_EMAILTextBox As TextBox
    Friend WithEvents MANAGER_IDTextBox As TextBox
    Friend WithEvents SALESPERSON_IDComboBox As ComboBox
End Class
