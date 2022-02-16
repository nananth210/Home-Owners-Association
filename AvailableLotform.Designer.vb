<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvailableLotform
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Availablelotformgrid = New System.Windows.Forms.DataGridView()
        Me.LOTIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SUBDIVISIONIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMOFTREESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISFENCEDDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ISCULDESACDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AVAILABLELOTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectDataSet = New HOAProject.ProjectDataSet()
        Me.AVAILABLE_LOTSTableAdapter = New HOAProject.ProjectDataSetTableAdapters.AVAILABLE_LOTSTableAdapter()
        CType(Me.Availablelotformgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AVAILABLELOTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(273, 327)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(68, 19)
        Me.BackButton.TabIndex = 0
        Me.BackButton.Text = "&Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Availablelotformgrid
        '
        Me.Availablelotformgrid.AutoGenerateColumns = False
        Me.Availablelotformgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Availablelotformgrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Availablelotformgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Availablelotformgrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LOTIDDataGridViewTextBoxColumn, Me.SUBDIVISIONIDDataGridViewTextBoxColumn, Me.NUMOFTREESDataGridViewTextBoxColumn, Me.ISFENCEDDataGridViewCheckBoxColumn, Me.ISCULDESACDataGridViewCheckBoxColumn})
        Me.Availablelotformgrid.DataSource = Me.AVAILABLELOTSBindingSource
        Me.Availablelotformgrid.Location = New System.Drawing.Point(64, 52)
        Me.Availablelotformgrid.Margin = New System.Windows.Forms.Padding(2)
        Me.Availablelotformgrid.Name = "Availablelotformgrid"
        Me.Availablelotformgrid.RowHeadersVisible = False
        Me.Availablelotformgrid.RowHeadersWidth = 51
        Me.Availablelotformgrid.RowTemplate.Height = 24
        Me.Availablelotformgrid.Size = New System.Drawing.Size(473, 251)
        Me.Availablelotformgrid.TabIndex = 1
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
        'NUMOFTREESDataGridViewTextBoxColumn
        '
        Me.NUMOFTREESDataGridViewTextBoxColumn.DataPropertyName = "NUM_OF_TREES"
        Me.NUMOFTREESDataGridViewTextBoxColumn.HeaderText = "NUM_OF_TREES"
        Me.NUMOFTREESDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NUMOFTREESDataGridViewTextBoxColumn.Name = "NUMOFTREESDataGridViewTextBoxColumn"
        Me.NUMOFTREESDataGridViewTextBoxColumn.Width = 119
        '
        'ISFENCEDDataGridViewCheckBoxColumn
        '
        Me.ISFENCEDDataGridViewCheckBoxColumn.DataPropertyName = "IS_FENCED"
        Me.ISFENCEDDataGridViewCheckBoxColumn.HeaderText = "IS_FENCED"
        Me.ISFENCEDDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.ISFENCEDDataGridViewCheckBoxColumn.Name = "ISFENCEDDataGridViewCheckBoxColumn"
        Me.ISFENCEDDataGridViewCheckBoxColumn.Width = 72
        '
        'ISCULDESACDataGridViewCheckBoxColumn
        '
        Me.ISCULDESACDataGridViewCheckBoxColumn.DataPropertyName = "IS_CULDESAC"
        Me.ISCULDESACDataGridViewCheckBoxColumn.HeaderText = "IS_CULDESAC"
        Me.ISCULDESACDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.ISCULDESACDataGridViewCheckBoxColumn.Name = "ISCULDESACDataGridViewCheckBoxColumn"
        Me.ISCULDESACDataGridViewCheckBoxColumn.Width = 86
        '
        'AVAILABLELOTSBindingSource
        '
        Me.AVAILABLELOTSBindingSource.DataMember = "AVAILABLE_LOTS"
        Me.AVAILABLELOTSBindingSource.DataSource = Me.ProjectDataSet
        '
        'ProjectDataSet
        '
        Me.ProjectDataSet.DataSetName = "ProjectDataSet"
        Me.ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AVAILABLE_LOTSTableAdapter
        '
        Me.AVAILABLE_LOTSTableAdapter.ClearBeforeFill = True
        '
        'AvailableLotform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Availablelotformgrid)
        Me.Controls.Add(Me.BackButton)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AvailableLotform"
        Me.Text = "Available Lots"
        CType(Me.Availablelotformgrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AVAILABLELOTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents Availablelotformgrid As DataGridView
    Friend WithEvents ProjectDataSet As ProjectDataSet
    Friend WithEvents AVAILABLELOTSBindingSource As BindingSource
    Friend WithEvents AVAILABLE_LOTSTableAdapter As ProjectDataSetTableAdapters.AVAILABLE_LOTSTableAdapter
    Friend WithEvents LOTIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SUBDIVISIONIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NUMOFTREESDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ISFENCEDDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ISCULDESACDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
