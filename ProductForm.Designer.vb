<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductForm
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
        Me.productnameLabel = New System.Windows.Forms.Label()
        Me.productNameTextbox = New System.Windows.Forms.TextBox()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.productDgv = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProducttblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CSystemDataSet = New Cashiering_System01.CSystemDataSet()
        Me.ProducttblTableAdapter = New Cashiering_System01.CSystemDataSetTableAdapters.ProducttblTableAdapter()
        Me.manufacturerLabel = New System.Windows.Forms.Label()
        Me.manufacturerTextbox = New System.Windows.Forms.TextBox()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.priceTextbox = New System.Windows.Forms.TextBox()
        Me.editButton = New System.Windows.Forms.Button()
        Me.addButton = New System.Windows.Forms.Button()
        Me.productIDLabel = New System.Windows.Forms.Label()
        Me.productIDTextbox = New System.Windows.Forms.TextBox()
        CType(Me.productDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProducttblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'productnameLabel
        '
        Me.productnameLabel.AutoSize = True
        Me.productnameLabel.BackColor = System.Drawing.Color.Tan
        Me.productnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productnameLabel.ForeColor = System.Drawing.Color.Black
        Me.productnameLabel.Location = New System.Drawing.Point(9, 15)
        Me.productnameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.productnameLabel.Name = "productnameLabel"
        Me.productnameLabel.Size = New System.Drawing.Size(115, 17)
        Me.productnameLabel.TabIndex = 4
        Me.productnameLabel.Text = "Product Name:"
        '
        'productNameTextbox
        '
        Me.productNameTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productNameTextbox.Location = New System.Drawing.Point(139, 11)
        Me.productNameTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.productNameTextbox.Name = "productNameTextbox"
        Me.productNameTextbox.Size = New System.Drawing.Size(134, 23)
        Me.productNameTextbox.TabIndex = 1
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.Tan
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.ForeColor = System.Drawing.Color.Black
        Me.deleteButton.Location = New System.Drawing.Point(480, 278)
        Me.deleteButton.Margin = New System.Windows.Forms.Padding(2)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(82, 76)
        Me.deleteButton.TabIndex = 16
        Me.deleteButton.Text = "DELETE"
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'productDgv
        '
        Me.productDgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.productDgv.AutoGenerateColumns = False
        Me.productDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.productDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.ManufacturerDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn2})
        Me.productDgv.DataSource = Me.ProducttblBindingSource
        Me.productDgv.Location = New System.Drawing.Point(18, 93)
        Me.productDgv.Name = "productDgv"
        Me.productDgv.Size = New System.Drawing.Size(443, 261)
        Me.productDgv.TabIndex = 17
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProductName"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'ManufacturerDataGridViewTextBoxColumn
        '
        Me.ManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.Name = "ManufacturerDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'ProducttblBindingSource
        '
        Me.ProducttblBindingSource.DataMember = "Producttbl"
        Me.ProducttblBindingSource.DataSource = Me.CSystemDataSet
        '
        'CSystemDataSet
        '
        Me.CSystemDataSet.DataSetName = "CSystemDataSet"
        Me.CSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProducttblTableAdapter
        '
        Me.ProducttblTableAdapter.ClearBeforeFill = True
        '
        'manufacturerLabel
        '
        Me.manufacturerLabel.AutoSize = True
        Me.manufacturerLabel.BackColor = System.Drawing.Color.Tan
        Me.manufacturerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manufacturerLabel.ForeColor = System.Drawing.Color.Black
        Me.manufacturerLabel.Location = New System.Drawing.Point(15, 50)
        Me.manufacturerLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.manufacturerLabel.Name = "manufacturerLabel"
        Me.manufacturerLabel.Size = New System.Drawing.Size(109, 17)
        Me.manufacturerLabel.TabIndex = 18
        Me.manufacturerLabel.Text = "Manufacturer:"
        '
        'manufacturerTextbox
        '
        Me.manufacturerTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manufacturerTextbox.Location = New System.Drawing.Point(139, 47)
        Me.manufacturerTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.manufacturerTextbox.Name = "manufacturerTextbox"
        Me.manufacturerTextbox.Size = New System.Drawing.Size(322, 23)
        Me.manufacturerTextbox.TabIndex = 2
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.BackColor = System.Drawing.Color.Tan
        Me.priceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceLabel.ForeColor = System.Drawing.Color.Black
        Me.priceLabel.Location = New System.Drawing.Point(288, 15)
        Me.priceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(50, 17)
        Me.priceLabel.TabIndex = 20
        Me.priceLabel.Text = "Price:"
        '
        'priceTextbox
        '
        Me.priceTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceTextbox.Location = New System.Drawing.Point(351, 11)
        Me.priceTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.priceTextbox.Name = "priceTextbox"
        Me.priceTextbox.Size = New System.Drawing.Size(110, 23)
        Me.priceTextbox.TabIndex = 3
        '
        'editButton
        '
        Me.editButton.BackColor = System.Drawing.Color.Tan
        Me.editButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.ForeColor = System.Drawing.Color.Black
        Me.editButton.Location = New System.Drawing.Point(480, 189)
        Me.editButton.Margin = New System.Windows.Forms.Padding(2)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(82, 76)
        Me.editButton.TabIndex = 21
        Me.editButton.Text = "EDIT"
        Me.editButton.UseVisualStyleBackColor = False
        '
        'addButton
        '
        Me.addButton.BackColor = System.Drawing.Color.Tan
        Me.addButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addButton.ForeColor = System.Drawing.Color.Black
        Me.addButton.Location = New System.Drawing.Point(480, 93)
        Me.addButton.Margin = New System.Windows.Forms.Padding(2)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(82, 76)
        Me.addButton.TabIndex = 22
        Me.addButton.Text = "ADD"
        Me.addButton.UseVisualStyleBackColor = False
        '
        'productIDLabel
        '
        Me.productIDLabel.AutoSize = True
        Me.productIDLabel.BackColor = System.Drawing.Color.Tan
        Me.productIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productIDLabel.ForeColor = System.Drawing.Color.Black
        Me.productIDLabel.Location = New System.Drawing.Point(473, 11)
        Me.productIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.productIDLabel.Name = "productIDLabel"
        Me.productIDLabel.Size = New System.Drawing.Size(89, 17)
        Me.productIDLabel.TabIndex = 23
        Me.productIDLabel.Text = "Product ID:"
        '
        'productIDTextbox
        '
        Me.productIDTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.productIDTextbox.Location = New System.Drawing.Point(480, 44)
        Me.productIDTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.productIDTextbox.Name = "productIDTextbox"
        Me.productIDTextbox.ReadOnly = True
        Me.productIDTextbox.Size = New System.Drawing.Size(76, 23)
        Me.productIDTextbox.TabIndex = 24
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cashiering_System01.My.Resources.Resources.plain_
        Me.ClientSize = New System.Drawing.Size(579, 366)
        Me.Controls.Add(Me.productIDTextbox)
        Me.Controls.Add(Me.productIDLabel)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.editButton)
        Me.Controls.Add(Me.priceTextbox)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.manufacturerTextbox)
        Me.Controls.Add(Me.manufacturerLabel)
        Me.Controls.Add(Me.productDgv)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.productNameTextbox)
        Me.Controls.Add(Me.productnameLabel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ProductForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRODUCT INFO"
        CType(Me.productDgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProducttblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents productnameLabel As Label
    Friend WithEvents productNameTextbox As TextBox
    Friend WithEvents deleteButton As Button
    Friend WithEvents productDgv As DataGridView
    Friend WithEvents ProductNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CSystemDataSet As CSystemDataSet
    Friend WithEvents ProducttblBindingSource As BindingSource
    Friend WithEvents ProducttblTableAdapter As CSystemDataSetTableAdapters.ProducttblTableAdapter
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents manufacturerLabel As Label
    Friend WithEvents manufacturerTextbox As TextBox
    Friend WithEvents priceLabel As Label
    Friend WithEvents priceTextbox As TextBox
    Friend WithEvents editButton As Button
    Friend WithEvents addButton As Button
    Friend WithEvents productIDLabel As Label
    Friend WithEvents productIDTextbox As TextBox
End Class
