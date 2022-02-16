<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WelcomePage
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.AvailableLotButton = New System.Windows.Forms.Button()
        Me.PurchaselotButton = New System.Windows.Forms.Button()
        Me.Customer_Purchase_Record = New System.Windows.Forms.Button()
        Me.Available_Lot_Detail = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalespersonReviewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowReviewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByLowestRatingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModelsButton = New System.Windows.Forms.Button()
        Me.PurchasedLotsButton = New System.Windows.Forms.Button()
        Me.SubdivisionButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CustomersButton = New System.Windows.Forms.Button()
        Me.SalespersonDetailsButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Yellow
        Me.ExitButton.Location = New System.Drawing.Point(403, 482)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'AvailableLotButton
        '
        Me.AvailableLotButton.BackColor = System.Drawing.Color.Lime
        Me.AvailableLotButton.Location = New System.Drawing.Point(708, 49)
        Me.AvailableLotButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AvailableLotButton.Name = "AvailableLotButton"
        Me.AvailableLotButton.Size = New System.Drawing.Size(125, 42)
        Me.AvailableLotButton.TabIndex = 2
        Me.AvailableLotButton.Text = "Available Lots"
        Me.AvailableLotButton.UseVisualStyleBackColor = False
        '
        'PurchaselotButton
        '
        Me.PurchaselotButton.BackColor = System.Drawing.Color.Red
        Me.PurchaselotButton.Location = New System.Drawing.Point(708, 162)
        Me.PurchaselotButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PurchaselotButton.Name = "PurchaselotButton"
        Me.PurchaselotButton.Size = New System.Drawing.Size(125, 42)
        Me.PurchaselotButton.TabIndex = 1
        Me.PurchaselotButton.Text = "Purchased Lots"
        Me.PurchaselotButton.UseVisualStyleBackColor = False
        '
        'Customer_Purchase_Record
        '
        Me.Customer_Purchase_Record.BackColor = System.Drawing.Color.Aqua
        Me.Customer_Purchase_Record.Location = New System.Drawing.Point(15, 463)
        Me.Customer_Purchase_Record.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Customer_Purchase_Record.Name = "Customer_Purchase_Record"
        Me.Customer_Purchase_Record.Size = New System.Drawing.Size(160, 42)
        Me.Customer_Purchase_Record.TabIndex = 3
        Me.Customer_Purchase_Record.Text = "Customer Records"
        Me.Customer_Purchase_Record.UseVisualStyleBackColor = False
        '
        'Available_Lot_Detail
        '
        Me.Available_Lot_Detail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Available_Lot_Detail.Location = New System.Drawing.Point(500, 50)
        Me.Available_Lot_Detail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Available_Lot_Detail.Name = "Available_Lot_Detail"
        Me.Available_Lot_Detail.Size = New System.Drawing.Size(181, 43)
        Me.Available_Lot_Detail.TabIndex = 4
        Me.Available_Lot_Detail.Text = "Details of Available Lots"
        Me.Available_Lot_Detail.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalespersonReviewsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(848, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalespersonReviewsToolStripMenuItem
        '
        Me.SalespersonReviewsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowReviewsToolStripMenuItem})
        Me.SalespersonReviewsToolStripMenuItem.Name = "SalespersonReviewsToolStripMenuItem"
        Me.SalespersonReviewsToolStripMenuItem.Size = New System.Drawing.Size(159, 24)
        Me.SalespersonReviewsToolStripMenuItem.Text = "Salesperson Reviews"
        '
        'ShowReviewsToolStripMenuItem
        '
        Me.ShowReviewsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ByLowestRatingToolStripMenuItem, Me.NewestToolStripMenuItem})
        Me.ShowReviewsToolStripMenuItem.Name = "ShowReviewsToolStripMenuItem"
        Me.ShowReviewsToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.ShowReviewsToolStripMenuItem.Text = "Show Reviews"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(210, 26)
        Me.ToolStripMenuItem1.Text = "By Highest Rating"
        '
        'ByLowestRatingToolStripMenuItem
        '
        Me.ByLowestRatingToolStripMenuItem.Name = "ByLowestRatingToolStripMenuItem"
        Me.ByLowestRatingToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.ByLowestRatingToolStripMenuItem.Text = "By Lowest Rating"
        '
        'NewestToolStripMenuItem
        '
        Me.NewestToolStripMenuItem.Name = "NewestToolStripMenuItem"
        Me.NewestToolStripMenuItem.Size = New System.Drawing.Size(210, 26)
        Me.NewestToolStripMenuItem.Text = "Newest"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ModelsButton
        '
        Me.ModelsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ModelsButton.Location = New System.Drawing.Point(672, 386)
        Me.ModelsButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ModelsButton.Name = "ModelsButton"
        Me.ModelsButton.Size = New System.Drawing.Size(160, 42)
        Me.ModelsButton.TabIndex = 7
        Me.ModelsButton.Text = "Models"
        Me.ModelsButton.UseVisualStyleBackColor = False
        '
        'PurchasedLotsButton
        '
        Me.PurchasedLotsButton.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.PurchasedLotsButton.Location = New System.Drawing.Point(500, 161)
        Me.PurchasedLotsButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PurchasedLotsButton.Name = "PurchasedLotsButton"
        Me.PurchasedLotsButton.Size = New System.Drawing.Size(181, 43)
        Me.PurchasedLotsButton.TabIndex = 8
        Me.PurchasedLotsButton.Text = "Details of Purchased Lots"
        Me.PurchasedLotsButton.UseVisualStyleBackColor = False
        '
        'SubdivisionButton
        '
        Me.SubdivisionButton.BackColor = System.Drawing.Color.DimGray
        Me.SubdivisionButton.Location = New System.Drawing.Point(673, 463)
        Me.SubdivisionButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SubdivisionButton.Name = "SubdivisionButton"
        Me.SubdivisionButton.Size = New System.Drawing.Size(160, 42)
        Me.SubdivisionButton.TabIndex = 9
        Me.SubdivisionButton.Text = "Subdivisions"
        Me.SubdivisionButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(15, 63)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 42)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Salespersons "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CustomersButton
        '
        Me.CustomersButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CustomersButton.Location = New System.Drawing.Point(15, 399)
        Me.CustomersButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomersButton.Name = "CustomersButton"
        Me.CustomersButton.Size = New System.Drawing.Size(160, 42)
        Me.CustomersButton.TabIndex = 11
        Me.CustomersButton.Text = "Customers"
        Me.CustomersButton.UseVisualStyleBackColor = False
        '
        'SalespersonDetailsButton
        '
        Me.SalespersonDetailsButton.AutoEllipsis = True
        Me.SalespersonDetailsButton.AutoSize = True
        Me.SalespersonDetailsButton.BackColor = System.Drawing.Color.White
        Me.SalespersonDetailsButton.Location = New System.Drawing.Point(15, 162)
        Me.SalespersonDetailsButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SalespersonDetailsButton.Name = "SalespersonDetailsButton"
        Me.SalespersonDetailsButton.Size = New System.Drawing.Size(160, 42)
        Me.SalespersonDetailsButton.TabIndex = 12
        Me.SalespersonDetailsButton.Text = "SalespersonsDetails"
        Me.SalespersonDetailsButton.UseVisualStyleBackColor = False
        '
        'WelcomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.HOAProject.My.Resources.Resources.hoa2
        Me.ClientSize = New System.Drawing.Size(848, 519)
        Me.Controls.Add(Me.SalespersonDetailsButton)
        Me.Controls.Add(Me.CustomersButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SubdivisionButton)
        Me.Controls.Add(Me.PurchasedLotsButton)
        Me.Controls.Add(Me.ModelsButton)
        Me.Controls.Add(Me.Available_Lot_Detail)
        Me.Controls.Add(Me.Customer_Purchase_Record)
        Me.Controls.Add(Me.PurchaselotButton)
        Me.Controls.Add(Me.AvailableLotButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "WelcomePage"
        Me.Text = "ANANTH & GUPTA CO."
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents AvailableLotButton As Button
    Friend WithEvents PurchaselotButton As Button
    Friend WithEvents Customer_Purchase_Record As Button
    Friend WithEvents Available_Lot_Detail As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalespersonReviewsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ShowReviewsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ByLowestRatingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModelsButton As Button
    Friend WithEvents PurchasedLotsButton As Button
    Friend WithEvents SubdivisionButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CustomersButton As Button
    Friend WithEvents SalespersonDetailsButton As Button
End Class
