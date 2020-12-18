<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryForm
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
        Me.addButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.productIDLabel = New System.Windows.Forms.Label()
        Me.CSystemDataSet = New Cashiering_System01.CSystemDataSet()
        Me.StocktblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StocktblTableAdapter = New Cashiering_System01.CSystemDataSetTableAdapters.StocktblTableAdapter()
        Me.productRefDgv = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Manufacturer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProducttblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.stockDgv = New System.Windows.Forms.DataGridView()
        Me.StockIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProducttblTableAdapter = New Cashiering_System01.CSystemDataSetTableAdapters.ProducttblTableAdapter()
        Me.referenceLabel = New System.Windows.Forms.Label()
        Me.stockIDTextbox = New System.Windows.Forms.TextBox()
        Me.stockIDLabel = New System.Windows.Forms.Label()
        Me.productIDTextbox = New System.Windows.Forms.TextBox()
        Me.quantityTextbox = New System.Windows.Forms.TextBox()
        Me.quantityLabel = New System.Windows.Forms.Label()
        CType(Me.CSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StocktblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productRefDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProducttblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stockDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.Color.Tan
        Me.addButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addButton.ForeColor = System.Drawing.Color.Black
        Me.addButton.Location = New System.Drawing.Point(374, 93)
        Me.addButton.Margin = New System.Windows.Forms.Padding(2)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(82, 76)
        Me.addButton.TabIndex = 26
        Me.addButton.Text = "ADD"
        Me.addButton.UseVisualStyleBackColor = False
        '
        'editButton
        '
        Me.editButton.BackColor = System.Drawing.Color.Tan
        Me.editButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.ForeColor = System.Drawing.Color.Black
        Me.editButton.Location = New System.Drawing.Point(374, 189)
        Me.editButton.Margin = New System.Windows.Forms.Padding(2)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(82, 76)
        Me.editButton.TabIndex = 25
        Me.editButton.Text = "EDIT"
        Me.editButton.UseVisualStyleBackColor = False
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.Tan
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.ForeColor = System.Drawing.Color.Black
        Me.deleteButton.Location = New System.Drawing.Point(374, 278)
        Me.deleteButton.Margin = New System.Windows.Forms.Padding(2)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(82, 76)
        Me.deleteButton.TabIndex = 24
        Me.deleteButton.Text = "DELETE"
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'productIDLabel
        '
        Me.productIDLabel.AutoSize = True
        Me.productIDLabel.BackColor = System.Drawing.Color.Tan
        Me.productIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productIDLabel.ForeColor = System.Drawing.Color.Black
        Me.productIDLabel.Location = New System.Drawing.Point(11, 18)
        Me.productIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.productIDLabel.Name = "productIDLabel"
        Me.productIDLabel.Size = New System.Drawing.Size(89, 17)
        Me.productIDLabel.TabIndex = 28
        Me.productIDLabel.Text = "Product ID:"
        '
        'CSystemDataSet
        '
        Me.CSystemDataSet.DataSetName = "CSystemDataSet"
        Me.CSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StocktblBindingSource
        '
        Me.StocktblBindingSource.DataMember = "Stocktbl"
        Me.StocktblBindingSource.DataSource = Me.CSystemDataSet
        '
        'StocktblTableAdapter
        '
        Me.StocktblTableAdapter.ClearBeforeFill = True
        '
        'productRefDgv
        '
        Me.productRefDgv.AllowUserToAddRows = False
        Me.productRefDgv.AllowUserToDeleteRows = False
        Me.productRefDgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.productRefDgv.AutoGenerateColumns = False
        Me.productRefDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.productRefDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.ProductName, Me.Manufacturer, Me.Price})
        Me.productRefDgv.DataSource = Me.ProducttblBindingSource
        Me.productRefDgv.Location = New System.Drawing.Point(466, 93)
        Me.productRefDgv.Name = "productRefDgv"
        Me.productRefDgv.Size = New System.Drawing.Size(445, 261)
        Me.productRefDgv.TabIndex = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'ProductName
        '
        Me.ProductName.DataPropertyName = "ProductName"
        Me.ProductName.HeaderText = "ProductName"
        Me.ProductName.Name = "ProductName"
        '
        'Manufacturer
        '
        Me.Manufacturer.DataPropertyName = "Manufacturer"
        Me.Manufacturer.HeaderText = "Manufacturer"
        Me.Manufacturer.Name = "Manufacturer"
        '
        'Price
        '
        Me.Price.DataPropertyName = "Price"
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        '
        'ProducttblBindingSource
        '
        Me.ProducttblBindingSource.DataMember = "Producttbl"
        Me.ProducttblBindingSource.DataSource = Me.CSystemDataSet
        '
        'stockDgv
        '
        Me.stockDgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stockDgv.AutoGenerateColumns = False
        Me.stockDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.stockDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StockIDDataGridViewTextBoxColumn, Me.ProductIDDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn})
        Me.stockDgv.DataSource = Me.StocktblBindingSource
        Me.stockDgv.Location = New System.Drawing.Point(14, 93)
        Me.stockDgv.Name = "stockDgv"
        Me.stockDgv.Size = New System.Drawing.Size(343, 261)
        Me.stockDgv.TabIndex = 31
        '
        'StockIDDataGridViewTextBoxColumn
        '
        Me.StockIDDataGridViewTextBoxColumn.DataPropertyName = "StockID"
        Me.StockIDDataGridViewTextBoxColumn.HeaderText = "StockID"
        Me.StockIDDataGridViewTextBoxColumn.Name = "StockIDDataGridViewTextBoxColumn"
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'ProducttblTableAdapter
        '
        Me.ProducttblTableAdapter.ClearBeforeFill = True
        '
        'referenceLabel
        '
        Me.referenceLabel.AutoSize = True
        Me.referenceLabel.BackColor = System.Drawing.Color.Tan
        Me.referenceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.referenceLabel.ForeColor = System.Drawing.Color.Black
        Me.referenceLabel.Location = New System.Drawing.Point(573, 36)
        Me.referenceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.referenceLabel.Name = "referenceLabel"
        Me.referenceLabel.Size = New System.Drawing.Size(239, 39)
        Me.referenceLabel.TabIndex = 32
        Me.referenceLabel.Text = "REFERENCE"
        '
        'stockIDTextbox
        '
        Me.stockIDTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockIDTextbox.Location = New System.Drawing.Point(378, 42)
        Me.stockIDTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.stockIDTextbox.Name = "stockIDTextbox"
        Me.stockIDTextbox.ReadOnly = True
        Me.stockIDTextbox.Size = New System.Drawing.Size(76, 23)
        Me.stockIDTextbox.TabIndex = 34
        '
        'stockIDLabel
        '
        Me.stockIDLabel.AutoSize = True
        Me.stockIDLabel.BackColor = System.Drawing.Color.Tan
        Me.stockIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockIDLabel.ForeColor = System.Drawing.Color.Black
        Me.stockIDLabel.Location = New System.Drawing.Point(379, 9)
        Me.stockIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.stockIDLabel.Name = "stockIDLabel"
        Me.stockIDLabel.Size = New System.Drawing.Size(73, 17)
        Me.stockIDLabel.TabIndex = 33
        Me.stockIDLabel.Text = "Stock ID:"
        '
        'productIDTextbox
        '
        Me.productIDTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productIDTextbox.Location = New System.Drawing.Point(118, 12)
        Me.productIDTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.productIDTextbox.Name = "productIDTextbox"
        Me.productIDTextbox.Size = New System.Drawing.Size(134, 23)
        Me.productIDTextbox.TabIndex = 35
        '
        'quantityTextbox
        '
        Me.quantityTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantityTextbox.Location = New System.Drawing.Point(118, 47)
        Me.quantityTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.quantityTextbox.Name = "quantityTextbox"
        Me.quantityTextbox.Size = New System.Drawing.Size(134, 23)
        Me.quantityTextbox.TabIndex = 37
        '
        'quantityLabel
        '
        Me.quantityLabel.AutoSize = True
        Me.quantityLabel.BackColor = System.Drawing.Color.Tan
        Me.quantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantityLabel.ForeColor = System.Drawing.Color.Black
        Me.quantityLabel.Location = New System.Drawing.Point(26, 53)
        Me.quantityLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.quantityLabel.Name = "quantityLabel"
        Me.quantityLabel.Size = New System.Drawing.Size(74, 17)
        Me.quantityLabel.TabIndex = 36
        Me.quantityLabel.Text = "Quantity:"
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.BackgroundImage = Global.Cashiering_System01.My.Resources.Resources.plain_
        Me.ClientSize = New System.Drawing.Size(923, 375)
        Me.Controls.Add(Me.quantityTextbox)
        Me.Controls.Add(Me.quantityLabel)
        Me.Controls.Add(Me.productIDTextbox)
        Me.Controls.Add(Me.stockIDTextbox)
        Me.Controls.Add(Me.stockIDLabel)
        Me.Controls.Add(Me.referenceLabel)
        Me.Controls.Add(Me.stockDgv)
        Me.Controls.Add(Me.productRefDgv)
        Me.Controls.Add(Me.productIDLabel)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "InventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INVENTORY INFO"
        CType(Me.CSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StocktblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productRefDgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProducttblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stockDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StockNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BranchNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InItemsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OutItemsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents addButton As Button
    Friend WithEvents editButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents productIDLabel As Label
    Friend WithEvents CSystemDataSet As CSystemDataSet
    Friend WithEvents StocktblBindingSource As BindingSource
    Friend WithEvents StocktblTableAdapter As CSystemDataSetTableAdapters.StocktblTableAdapter
    Friend WithEvents productRefDgv As DataGridView
    Friend WithEvents stockDgv As DataGridView
    Friend WithEvents StockIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProducttblBindingSource As BindingSource
    Friend WithEvents ProducttblTableAdapter As CSystemDataSetTableAdapters.ProducttblTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Manufacturer As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents referenceLabel As Label
    Friend WithEvents stockIDTextbox As TextBox
    Friend WithEvents stockIDLabel As Label
    Friend WithEvents productIDTextbox As TextBox
    Friend WithEvents quantityTextbox As TextBox
    Friend WithEvents quantityLabel As Label
End Class
